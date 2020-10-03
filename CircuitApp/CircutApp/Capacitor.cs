using System;
using System.Numerics;

namespace CircutApp
{
    ///<summary>
    /// Class for circuit element capacitor
    /// </summary>
    /// <inheritdoc cref="ISegment"/>
    public class Capacitor : Element
    {
        public override Complex CalculateZ(double frequency)
        {
            return (Complex)(1 / (2 * Math.PI * frequency * Value * Complex.ImaginaryOne));
        }
    }
}
