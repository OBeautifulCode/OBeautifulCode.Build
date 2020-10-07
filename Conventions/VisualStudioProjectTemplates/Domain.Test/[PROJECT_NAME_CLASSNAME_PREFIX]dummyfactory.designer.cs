﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="[PROJECT_NAME_CLASSNAME_PREFIX]DummyFactory.designer.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// <auto-generated>
//   Sourced from NuGet package [VISUAL_STUDIO_TEMPLATE_PACKAGE_ID] ([VISUAL_STUDIO_TEMPLATE_PACKAGE_VERSION])
// </auto-generated>
// --------------------------------------------------------------------------------------------------------------------

namespace [PROJECT_NAME]
{
    using global::System;

    using FakeItEasy;

    /// <summary>
    /// DO NOT EDIT.  
    /// THIS CLASS EXISTS SO THAT THE DUMMY FACTORY CAN INHERIT FROM IT AND THE PROJECT CAN COMPILE.
    /// THIS WILL BE REPLACED BY A CODE GENERATED DEFAULT DUMMY FACTORY.
    /// </summary>
    [global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    [global::System.CodeDom.Compiler.GeneratedCode("[VISUAL_STUDIO_TEMPLATE_PACKAGE_ID]", "[VISUAL_STUDIO_TEMPLATE_PACKAGE_VERSION]")]
#if ![SOLUTION_NAME_CONDITIONAL_COMPILATION_SYMBOL]
    internal
#else
    public
#endif
    abstract class Default[PROJECT_NAME_CLASSNAME_PREFIX]DummyFactory : IDummyFactory
    {
        /// <inheritdoc />
        public Priority Priority => new FakeItEasy.Priority(1);

        /// <inheritdoc />
        public bool CanCreate(Type type)
        {
            return false;
        }

        /// <inheritdoc />
        public object Create(Type type)
        {
            return null;
        }
    }
}