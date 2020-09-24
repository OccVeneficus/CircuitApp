using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Numerics;

namespace CircutApp
{
    /// <summary>
    /// Class for circuit element Inductor
    /// </summary>
    /// <inheritdoc cref="ISegment"/>
    public class Inductor : IElement
    {
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

        /// <summary>
        /// For IElements sub segments always null
        /// </summary>
        private ObservableCollection<ISegment> _subSegments;
        public ObservableCollection<ISegment> SubSegments
        {
            get => _subSegments;
            private set => _subSegments = null;
        }

        public Complex CalculateZ(double frequency)
        {
            return (Complex)2 * Math.PI * frequency * Value * Complex.ImaginaryOne;
        }

        public event EventHandler SegmentChanged;
    }
}
