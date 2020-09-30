using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Numerics;

namespace CircutApp
{
    /// <summary>
    /// Interface for circuit segments
    /// </summary>
    public interface ISegment : INotifyPropertyChanged
    {
        /// <summary>
        /// Method for impedance calculating
        /// </summary>
        /// <param name="frequency">on what frequency calculate</param>
        /// <returns></returns>
        Complex CalculateZ(double frequency);

        /// <summary>
        /// SubSegments collection
        /// </summary>
        EventDrivenCollection<ISegment> SubSegments { get; }
    }
}
