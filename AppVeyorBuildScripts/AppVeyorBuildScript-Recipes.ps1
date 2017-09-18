# PASTE THIS INTO APPVEYOUR - Recipes

###########################################################
###       Setup variables from Appveyor                 ###
###########################################################
$repoPath = Resolve-Path .
$branchName = $env:appveyor_repo_branch
$buildVersion = $env:appveyor_build_version

###########################################################
###    Download and dot source tools to use             ###
###########################################################
NuGet sources add -Name OBeautifulCodeMyGet -Source https://www.myget.org/F/obeautifulcode-nuget/api/v3/index.json
NuGet sources add -Name NaosMyGet -Source https://www.myget.org/F/naos-nuget/api/v3/index.json
$TempBuildPackagesDir = "../BuildToolsFromNuGet/packages"
if (-not (Test-Path $TempBuildPackagesDir)) { md $TempBuildPackagesDir | Out-Null }
$TempBuildPackagesDir = Resolve-Path $TempBuildPackagesDir
NuGet install OBeautifulCode.Build -OutputDirectory $TempBuildPackagesDir

$nuSpecTemplateFile = Join-Path (Join-Path (ls $TempBuildPackagesDir/OBeautifulCode.Build.*).FullName 'scripts') 'OBeautifulCodeNuSpecTemplate.template-nuspec'

$nugetFunctionsScriptPath = $(ls $TempBuildPackagesDir -Recurse | ?{$_.Name -eq 'NuGet-Functions.ps1'}).FullName

. $nugetFunctionsScriptPath

#######################################################################
###     Setup NuGet/Artifact scriptblocks                           ###
#######################################################################
$nugetScriptblock = { param([string] $fileName) 
   Write-Host "Pushing $fileName to Build Artifacts"
   Push-AppveyorArtifact $fileName
   Write-Host "Pushing $fileName to NuGet Gallery"
   Nuget-PublishPackage -packagePath $fileName -apiUrl $env:nuget_gallery_url -apiKey $env:nuget_api_key
   Write-Host "Pushing $fileName to MyGet Gallery"
   Nuget-PublishPackage -packagePath $fileName -apiUrl $env:myget_gallery_url -apiKey $env:myget_api_key
}

$artifactScriptBlock = { param([string] $fileName) 
   Write-Host "Pushing $fileName to Build Artifacts"
   Push-AppveyorArtifact $fileName
}

#######################################################################
###       Run steps to process recipes repo             ###
#######################################################################

# if we are in a branch then create a pre-release version for nuget
$preReleaseSupportVersion = Nuget-CreatePreReleaseSupportedVersion -version $buildVersion -branchName $branchName

# discover the distinct recipes
$recipes = ls $repoPath | ?{ $_.PSIsContainer } | ?{ -not $_.Name.StartsWith('.') } | %{$_}

# create the nuspec files in place
$recipes | %{
	$recipePath = $_.FullName
	Write-Output ''
	Write-Output "Creating NuSpec for '$recipePath'"
	NuGet-CreateRecipeNuSpecInFolder -recipeFolderPath $recipePath -authors 'OBeautifulCode' -nuSpecTemplateFilePath $nuSpecTemplateFile
}

# push the nuspecs as artifacts
ls . *.nuspec -Recurse | %{&$artifactScriptBlock($_.FullName)}

# create the nupkgs in place
$recipes | %{
	$recipePath = $_.FullName
	$nuspecFilePath = $(ls $recipePath -Filter "*.$($nuGetConstants.FileExtensionsWithoutDot.Nuspec)").FullName
	$packageFile = Nuget-CreatePackageFromNuspec -nuspecFilePath $nuspecFilePath -version $buildVersion -throwOnError $true -outputDirectory $recipePath
}

# push the nupkgs
$recipes | %{
	$recipePath = $_.FullName
	$nuPkgFilePath = $(ls $recipePath -Filter "*.$($nuGetConstants.FileExtensionsWithoutDot.Package)").FullName
	Write-Output "Pushing package $nuPkgFilePath"
	&$nugetScriptblock($nuPkgFilePath)
}

Remove-Item $TempBuildPackagesDir -Recurse -Force