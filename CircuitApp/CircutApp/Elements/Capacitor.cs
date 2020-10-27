using System;
using System.Numerics;
using CircutApp.Segments;

namespace CircutApp.Elements
{
    ///<summary>
    /// Class for circuit element capacitor
    /// </summary>
    /// <inheritdoc cref="ISegment"/>
    public class Capacitor : Element
    {
        public override Complex CalculateImpedance(double frequency)
        {
            return (Complex)(1 / (2 * Math.PI * frequency * Value * Complex.ImaginaryOne));
        }
    }
}
