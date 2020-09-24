using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Numerics;

namespace CircutApp
{
    public class SerialCircuit : ISegment
    {
        public Complex CalculateZ(double frequency)
        {
            return SubSegments.Aggregate<ISegment, Complex>(0, (current, segment) => 
                    current + segment.CalculateZ(frequency));
        }

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

        public SerialCircuit()
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
