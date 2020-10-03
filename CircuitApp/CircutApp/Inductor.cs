using System;
using System.Numerics;

namespace CircutApp
{
    /// <summary>
    /// Class for circuit element Inductor
    /// </summary>
    /// <inheritdoc cref="ISegment"/>
    public class Inductor : Element
    {
        public override Complex CalculateZ(double frequency)
        {
            return (Complex)2 * Math.PI * frequency * Value * Complex.ImaginaryOne;
        }
    }
}
