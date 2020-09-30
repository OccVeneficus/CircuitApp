using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Numerics;

namespace CircutApp
{
    ///<summary>
    /// Class for circuit element capacitor
    /// </summary>
    /// <inheritdoc cref="ISegment"/>
    public class Capacitor : IElement
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public string Name { get; set; }
        private double _value;

        public double Value
        {
            get => _value;
            set
            {
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
            return (Complex)(1 / (2 * Math.PI * frequency * Value * Complex.ImaginaryOne));
        }
    }
}
