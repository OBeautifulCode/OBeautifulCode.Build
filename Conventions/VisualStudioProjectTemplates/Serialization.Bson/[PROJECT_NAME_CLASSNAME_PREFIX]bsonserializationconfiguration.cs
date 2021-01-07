// --------------------------------------------------------------------------------------------------------------------
// <copyright file="[PROJECT_NAME_CLASSNAME_PREFIX]BsonSerializationConfiguration.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace [PROJECT_NAME]
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using OBeautifulCode.Serialization.Bson;
    using OBeautifulCode.Type;
    using OBeautifulCode.Type.Recipes;

    /// <inheritdoc />
    public class [PROJECT_NAME_CLASSNAME_PREFIX]BsonSerializationConfiguration : BsonSerializationConfigurationBase
    {
        /// <inheritdoc />
        protected override IReadOnlyCollection<string> TypeToRegisterNamespacePrefixFilters =>
            new[]
            {
                    [SOLUTION_NAME].ProjectInfo.Namespace,
            };

        /// <inheritdoc />
        protected override IReadOnlyCollection<BsonSerializationConfigurationType> DependentBsonSerializationConfigurationTypes =>
            new BsonSerializationConfigurationType[]
            {
            };

        /// <inheritdoc />
        protected override IReadOnlyCollection<TypeToRegisterForBson> TypesToRegisterForBson => new Type[0]
            .Concat(new[] { typeof(IModel) })
            .Concat([SOLUTION_NAME].ProjectInfo.Assembly.GetPublicEnumTypes())
            .Select(_ => _.ToTypeToRegisterForBson())
            .ToList();
    }
}