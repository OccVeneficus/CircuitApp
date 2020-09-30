using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Numerics;

namespace CircutApp
{
    /// <summary>
    /// Interface for electric circuit elements
    /// </summary>
    public interface IElement : ISegment
    {
        /// <summary>
        /// Element value
        /// </summary>
        double Value { get; set; }
        /// <summary>
        /// Element name
        /// </summary>
        string Name { get; set; }
    }
}
