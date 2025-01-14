// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Integration runtime debug resource. </summary>
    public partial class FactoryIntegrationRuntimeDebugInfo : FactoryDebugInfo
    {
        /// <summary> Initializes a new instance of FactoryIntegrationRuntimeDebugInfo. </summary>
        /// <param name="properties">
        /// Integration runtime properties.
        /// Please note <see cref="IntegrationRuntimeDefinition"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ManagedIntegrationRuntime"/> and <see cref="SelfHostedIntegrationRuntime"/>.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="properties"/> is null. </exception>
        public FactoryIntegrationRuntimeDebugInfo(IntegrationRuntimeDefinition properties)
        {
            if (properties == null)
            {
                throw new ArgumentNullException(nameof(properties));
            }

            Properties = properties;
        }

        /// <summary>
        /// Integration runtime properties.
        /// Please note <see cref="IntegrationRuntimeDefinition"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ManagedIntegrationRuntime"/> and <see cref="SelfHostedIntegrationRuntime"/>.
        /// </summary>
        public IntegrationRuntimeDefinition Properties { get; }
    }
}
