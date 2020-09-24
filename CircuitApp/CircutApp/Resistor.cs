using System;
using System.Collections.ObjectModel;
using System.Numerics;

namespace CircutApp
{
    /// <summary>
    /// Class for circuit element Resistor
    /// </summary>
    /// <inheritdoc cref="ISegment"/>
    public class Resistor : IElement
    {
        /// <summary>
        /// SubSegments for elements is always null
        /// </summary>
        private ObservableCollection<ISegment> _subSegments;
        public ObservableCollection<ISegment> SubSegments
        {
            get => _subSegments;
            private set => _subSegments = null;
        }

        public string Name { get; set; }

        private double _value;
        public double Value
        {
            get => _value;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                _value = value;
                SegmentChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        public Complex CalculateZ(double frequency)
        {
            return (Complex) Value;
        }

        public event EventHandler SegmentChanged;
    }
}
