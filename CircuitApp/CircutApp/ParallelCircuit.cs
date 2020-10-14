using System;
using System.ComponentModel;
using System.Linq;
using System.Numerics;

namespace CircutApp
{
    /// <summary>
    /// Type for parallel segment
    /// </summary>
    /// <inheritdoc cref="Segment"/>
    public class ParallelCircuit : Segment
    {
        public override Complex CalculateZ(double frequency)
        {
            Complex result = SubSegments.Aggregate<ISegment, Complex>(0, (current,
                    segment) => current + 1 / segment.CalculateZ(frequency));
            if (result.Equals(Complex.Zero))
            {
                return result;
            }
            return 1/result;
        }
    }
}
