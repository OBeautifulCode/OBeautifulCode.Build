// --------------------------------------------------------------------------------------------------------------------
// <copyright file="[SUBSYSTEM_NAME]BsonSerializationConfiguration.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace [PROJECT_NAME]
{
    using System;
    using System.Collections.Generic;

    using OBeautifulCode.Serialization.Bson;

    /// <inheritdoc />
    public class [SUBSYSTEM_NAME]BsonSerializationConfiguration : BsonConfigurationBase
    {
        /// <inheritdoc />
        protected override IReadOnlyCollection<Type> TypesToAutoRegister => new[]
        {
            // ADD TYPES TO REGISTER HERE
        };
    }
}