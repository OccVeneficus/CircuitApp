using System.Linq;
using System.Numerics;

namespace CircutApp.Segments
{
    /// <summary>
    /// Type for parallel segment
    /// </summary>
    /// <inheritdoc cref="Segment"/>
    public class ParallelSegment : Segment
    {
        public override string Name { get; } = "Parallel segment";
        public override Complex CalculateImpedance(double frequency)
        {
            Complex result = SubSegments.Aggregate<ISegment, Complex>(0, (current,
                    segment) => current + 1 / segment.CalculateImpedance(frequency));
            if (result.Equals(Complex.Zero))
            {
                return result;
            }
            return 1/result;
        }
    }
}
