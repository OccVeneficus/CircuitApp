using System;
using System.ComponentModel;
using System.Numerics;

namespace CircutApp
{
    /// <summary>
    /// Base type for parallel and serial segments
    /// </summary>
    /// <inheritdoc cref="IElement"/>
    public abstract class Segment : ISegment
    {
        public EventDrivenCollection SubSegments { get; set; }
        public abstract string Name { get; }

        public event PropertyChangedEventHandler PropertyChanged;

        public abstract Complex CalculateImpedance(double frequency);

        /// <summary>
        /// Segment constructor
        /// </summary>
        protected Segment()
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
