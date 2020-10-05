using System;
using System.ComponentModel;
using System.Numerics;

namespace CircutApp
{
    public abstract class Element : IElement
    {

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

        public abstract Complex CalculateZ(double frequency);
    }
}
