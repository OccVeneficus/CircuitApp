using System;
using System.ComponentModel;
using System.Numerics;

namespace CircutApp.Elements
{
    /// <summary>
    /// <inheritdoc cref="IElement"/>
    /// </summary>
    public abstract class Element : IElement
    {
        /// <summary>
        /// SubSegments for element are always null
        /// </summary>
        public EventDrivenCollection SubSegments { get; } = null;

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
                PropertyChanged?.Invoke(this, new 
                    PropertyChangedEventArgs(string.Empty));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public abstract Complex CalculateImpedance(double frequency);
    }
}
