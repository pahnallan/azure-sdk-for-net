// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Enum to determine endpoint authentication mode. </summary>
    public readonly partial struct EndpointAuthMode : IEquatable<EndpointAuthMode>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="EndpointAuthMode"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public EndpointAuthMode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AMLTokenValue = "AMLToken";
        private const string KeyValue = "Key";
        private const string AADTokenValue = "AADToken";

        /// <summary> AMLToken. </summary>
        public static EndpointAuthMode AMLToken { get; } = new EndpointAuthMode(AMLTokenValue);
        /// <summary> Key. </summary>
        public static EndpointAuthMode Key { get; } = new EndpointAuthMode(KeyValue);
        /// <summary> AADToken. </summary>
        public static EndpointAuthMode AADToken { get; } = new EndpointAuthMode(AADTokenValue);
        /// <summary> Determines if two <see cref="EndpointAuthMode"/> values are the same. </summary>
        public static bool operator ==(EndpointAuthMode left, EndpointAuthMode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="EndpointAuthMode"/> values are not the same. </summary>
        public static bool operator !=(EndpointAuthMode left, EndpointAuthMode right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="EndpointAuthMode"/>. </summary>
        public static implicit operator EndpointAuthMode(string value) => new EndpointAuthMode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is EndpointAuthMode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(EndpointAuthMode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
