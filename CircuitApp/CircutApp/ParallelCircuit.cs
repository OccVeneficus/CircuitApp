using System;
using System.ComponentModel;
using System.Linq;
using System.Numerics;

namespace CircutApp
{
    public class ParallelCircuit : ISegment
    {
        public EventDrivenCollection SubSegments { get; set; }

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

        public ParallelCircuit()
        {
            SubSegments = new EventDrivenCollection();
            SubSegments.CollectionChanged += OnSegmentChanged;
        }

        private void OnSegmentChanged(object sender, EventArgs e)
        {
            PropertyChanged?.Invoke(this, 
                new PropertyChangedEventArgs(string.Empty));
        }
    }
}
