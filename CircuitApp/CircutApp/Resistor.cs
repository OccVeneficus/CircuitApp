using System.Numerics;

namespace CircutApp
{
    /// <summary>
    /// Class for circuit element Resistor
    /// </summary>
    /// <inheritdoc cref="ISegment"/>
    public class Resistor : Element
    {
        public override Complex CalculateZ(double frequency)
        {
            return (Complex) Value;
        }
    }
}
