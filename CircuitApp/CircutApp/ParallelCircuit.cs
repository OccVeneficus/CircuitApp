using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CircutApp
{
    public class ParallelCircuit : ISegment
    {
        private ObservableCollection<ISegment> _subSegments;
        public ObservableCollection<ISegment> SubSegments
        {
            get => _subSegments;
            set
            {
                switch (value)
                {
                    case IElement element:
                    {
                        _subSegments = value;
                        element.SegmentChanged += OnSegmentChanged;
                        break;
                    }
                    default:
                    {
                        _subSegments = value;
                        value.CollectionChanged += OnSegmentChanged;
                        break;
                    }
                }
            }
        }

        public event EventHandler SegmentChanged;

        public Complex CalculateZ(double frequency)
        {
            Complex result = SubSegments.Aggregate<ISegment, Complex>(0, (current, segment) =>
                    current + 1 / segment.CalculateZ(frequency));
            return 1/result;
        }

        public ParallelCircuit()
        {
            SubSegments = new ObservableCollection<ISegment>();
            SubSegments.CollectionChanged += OnSegmentChanged;
        }

        private void OnSegmentChanged(object sender, EventArgs e)
        {
            SegmentChanged?.Invoke(this, e);
        }
    }
}
