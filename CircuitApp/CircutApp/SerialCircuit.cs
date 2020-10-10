using System;
using System.ComponentModel;
using System.Linq;
using System.Numerics;

namespace CircutApp
{
    /// <summary>
    /// Type for serial segment
    /// </summary>
    /// <inheritdoc cref="ISegment"/>
    public class SerialCircuit : ISegment
    {
        /// <summary>
        /// Event for serial segment subsegments change
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        public EventDrivenCollection SubSegments { get; set; }

        public Complex CalculateZ(double frequency)
        {
            return SubSegments.Aggregate<ISegment, Complex>(0, (current, segment) => 
                    current + segment.CalculateZ(frequency));
        }

        /// <summary>
        /// Class constructor. Subscribes SubSegment changed event on event handler
        /// </summary>
        public SerialCircuit()
        {
            SubSegments = new EventDrivenCollection();
            SubSegments.CollectionChanged += OnCollectionChanged;
        }

        /// <summary>
        /// Event handler for SubSegments changed event
        /// </summary>
        /// <param name="sender">SubSegments</param>
        /// <param name="e">Default event arguments</param>
        private void OnCollectionChanged(object sender, EventArgs e)
        {
            PropertyChanged?.Invoke(this, 
                new PropertyChangedEventArgs(string.Empty));
        }
    }
}
