using System;
using System.ComponentModel;
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(string.Empty));
            }
        }

        /// <summary>
        /// For IElements sub segments always null
        /// </summary>
        private EventDrivenCollection<ISegment> _subSegments;
        public EventDrivenCollection<ISegment> SubSegments
        {
            get => _subSegments;
            private set => _subSegments = null;
        }

        public Complex CalculateZ(double frequency)
        {
            return (Complex)2 * Math.PI * frequency * Value * Complex.ImaginaryOne;
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
