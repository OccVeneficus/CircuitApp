using System.ComponentModel;
using System.Numerics;

namespace CircutApp.Segments
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
        Complex CalculateImpedance(double frequency);

        /// <summary>
        /// SubSegments collection
        /// </summary>
        EventDrivenCollection SubSegments { get; }

        string Name { get; }
    }
}
