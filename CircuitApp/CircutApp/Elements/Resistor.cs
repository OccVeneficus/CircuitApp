using System.Numerics;
using CircutApp.Segments;

namespace CircutApp.Elements
{
    /// <summary>
    /// Class for circuit element Resistor
    /// </summary>
    /// <inheritdoc cref="ISegment"/>
    public class Resistor : Element
    {
        public override Complex CalculateImpedance(double frequency)
        {
            return (Complex) Value;
        }
    }
}
