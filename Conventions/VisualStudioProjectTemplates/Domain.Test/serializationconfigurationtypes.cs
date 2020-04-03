﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SerializationConfigurationTypes.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// <auto-generated>
//   Sourced from NuGet package [VISUAL_STUDIO_TEMPLATE_PACKAGE_ID] ([VISUAL_STUDIO_TEMPLATE_PACKAGE_VERSION])
// </auto-generated>
// --------------------------------------------------------------------------------------------------------------------

namespace [PROJECT_NAME]
{
    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics.CodeAnalysis;

    using [PROJECT_NAME_WITHOUT_TEST_SUFFIX].Serialization.Bson;
    using [PROJECT_NAME_WITHOUT_TEST_SUFFIX].Serialization.Json;

    [ExcludeFromCodeCoverage]
    [GeneratedCode("[VISUAL_STUDIO_TEMPLATE_PACKAGE_ID]", "[VISUAL_STUDIO_TEMPLATE_PACKAGE_VERSION]")]
    public static class SerializationConfigurationTypes
    {
        public static Type BsonConfigurationType => typeof([PROJECT_NAME_CLASSNAME_PREFIX]BsonSerializationConfiguration);

        public static Type JsonConfigurationType => typeof([PROJECT_NAME_CLASSNAME_PREFIX]JsonSerializationConfiguration);
    }
}