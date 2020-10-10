using System;
using System.ComponentModel;
using System.Linq;
using System.Numerics;

namespace CircutApp
{
    /// <summary>
    /// Type for parallel segment
    /// </summary>
    /// <inheritdoc cref="ISegment"/>
    public class ParallelCircuit : ISegment
    {
        public EventDrivenCollection SubSegments { get; set; }

        /// <summary>
        /// Event for segment change
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        public Complex CalculateZ(double frequency)
        {
            Complex result = SubSegments.Aggregate<ISegment, Complex>(0, (current,
                    segment) => current + 1 / segment.CalculateZ(frequency));
            if (result.Equals(Complex.Zero))
            {
                return result;
            }
            return 1/result;
        }

        /// <summary>
        /// Segment constructor
        /// </summary>
        public ParallelCircuit()
        {
            SubSegments = new EventDrivenCollection();
            SubSegments.CollectionChanged += OnSegmentChanged;
        }

        /// <summary>
        /// Event handler for SubSegments changed event
        /// </summary>
        /// <param name="sender">SubSegments</param>
        /// <param name="e">Default event arguments</param>
        private void OnSegmentChanged(object sender, EventArgs e)
        {
            PropertyChanged?.Invoke(this, 
                new PropertyChangedEventArgs(string.Empty));
        }
    }
}
