using System;
using System.ComponentModel;
using System.Linq;
using System.Numerics;

namespace CircutApp
{
    /// <summary>
    /// Type for serial segment
    /// </summary>
    /// <inheritdoc cref="Segment"/>
    public class SerialCircuit : Segment
    {
        public override Complex CalculateZ(double frequency)
        {
            return SubSegments.Aggregate<ISegment, Complex>(0, (current, segment) => 
                    current + segment.CalculateZ(frequency));
        }
    }
}
