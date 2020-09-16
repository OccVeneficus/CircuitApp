using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Threading;

namespace CircutApp
{
    /// <summary>
    /// Interface for electric circuit elements
    /// </summary>
    public interface IElement
    {
        /// <summary>
        /// Element name
        /// </summary>
        string Name { get; set; }
        /// <summary>
        /// Element value
        /// </summary>
        double Value { get; set; }
        /// <summary>
        /// Calculate impedance of element
        /// </summary>
        /// <param name="frequency">frequency for capacitor and inductor impedance</param>
        /// <returns></returns>
        Complex CalculateZ(double frequency);
        /// <summary>
        /// Event on Value change
        /// </summary>
        event EventHandler ValueChanged;
    }
}
