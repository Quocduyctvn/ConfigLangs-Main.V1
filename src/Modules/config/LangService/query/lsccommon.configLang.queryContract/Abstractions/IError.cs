﻿using lsccommon.configLang.queryContract.Enumerations;
using System.Text.Json.Serialization;

namespace lsccommon.configLang.queryContract.Abstractions
{
    /// <summary>
    /// Represent application error
    /// </summary>
    public interface IError
    {
        /// <summary>
        /// Use for providing more information
        /// </summary>
        public IReadOnlyList<string>? Messages { get; }

        /// <summary>
        /// Indicate which type of error
        /// </summary>
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public ErrorType Type { get; }
    }
}