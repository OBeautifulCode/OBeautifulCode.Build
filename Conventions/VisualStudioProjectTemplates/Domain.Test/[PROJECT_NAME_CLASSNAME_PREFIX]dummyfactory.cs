﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="[PROJECT_NAME_CLASSNAME_PREFIX]DummyFactory.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// <auto-generated>
//   Sourced from NuGet package. Will be overwritten with package update except in [PROJECT_NAME] source.
// </auto-generated>
// --------------------------------------------------------------------------------------------------------------------

namespace [PROJECT_NAME]
{
    using global::System;

    using FakeItEasy;

    using OBeautifulCode.AutoFakeItEasy;

    /// <summary>
    /// A Dummy Factory for types in <see cref="[PROJECT_NAME_WITHOUT_TEST_SUFFIX]"/>.
    /// </summary>
#if ![SOLUTION_NAME_CONDITIONAL_COMPILATION_SYMBOL]
    [global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    [global::System.CodeDom.Compiler.GeneratedCode("[PROJECT_NAME]", "See package version number")]
    internal
#else
    public
#endif
    class [PROJECT_NAME_CLASSNAME_PREFIX]DummyFactory : Default[PROJECT_NAME_CLASSNAME_PREFIX]DummyFactory
    {
        public [PROJECT_NAME_CLASSNAME_PREFIX]DummyFactory()
        {
            /* Add any overriding or custom registrations here. */
        }
    }
}