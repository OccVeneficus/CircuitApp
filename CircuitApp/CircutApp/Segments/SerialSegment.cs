using System.Linq;
using System.Numerics;

namespace CircutApp.Segments
{
    /// <summary>
    /// Type for serial segment
    /// </summary>
    /// <inheritdoc cref="Segment"/>
    public class SerialSegment : Segment
    {
        public override string Name { get; } = "Serial segment";
        public override Complex CalculateImpedance(double frequency)
        {
            return SubSegments.Aggregate<ISegment, Complex>(0, (current, segment) => 
                    current + segment.CalculateImpedance(frequency));
        }
    }
}
