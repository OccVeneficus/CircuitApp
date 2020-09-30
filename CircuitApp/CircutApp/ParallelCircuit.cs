using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CircutApp
{
    public class ParallelCircuit : ISegment
    {
        public EventDrivenCollection<ISegment> SubSegments { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public Complex CalculateZ(double frequency)
        {
            Complex result = SubSegments.Aggregate<ISegment, Complex>(0, (current, segment) =>
                    current + 1 / segment.CalculateZ(frequency));
            return 1/result;
        }

        public ParallelCircuit()
        {
            SubSegments = new EventDrivenCollection<ISegment>();
            SubSegments.CollectionChanged += OnSegmentChanged;
        }

        private void OnSegmentChanged(object sender, EventArgs e)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(string.Empty));
        }
    }
}
