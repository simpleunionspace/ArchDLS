using System;

namespace ArchDLS.Abstractions
{
    /// <summary>
    /// Slice interface.
    /// </summary>
    public interface ISlice
    {
        /// <summary>
        /// Gets or sets the date time.
        /// </summary>
        /// <value>
        /// The date time.
        /// </value>
        DateTime DateTime { get; }
    }
}