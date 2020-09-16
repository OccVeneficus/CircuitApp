using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CircutApp
{
    public class Resistor : IElement
    {
        public string Name { get; set; }

        private double _value;
        public double Value
        {
            get => _value;
            set
            {
                _value = value;
                ValueChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        public Complex CalculateZ(double frequency)
        {
            return (Complex) Value;
        }

        public event EventHandler ValueChanged;
    }
}
