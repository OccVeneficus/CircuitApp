using System;
using System.Collections.ObjectModel;
using System.Numerics;

namespace CircutApp
{
    /// <summary>
    /// Interface for circuit segments
    /// </summary>
    public interface ISegment
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
        ObservableCollection<ISegment> SubSegments { get; }

        /// <summary>
        /// Event that fires whenever segment of circuit changed
        /// </summary>
        event EventHandler SegmentChanged;
    }
}
