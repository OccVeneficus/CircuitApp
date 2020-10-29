using System.Drawing;
using CircuitAppUI.CircuitDraw.SegmentsDraw;

namespace CircuitAppUI.CircuitDraw.ElementsDraw
{
    /// <summary>
    /// Base class for circuit elements drawers
    /// </summary>
    /// <inheritdoc cref="DrawableCircuitSegmentBase"/>
    public abstract class DrawableCircuitElementBase : DrawableCircuitSegmentBase
    {
        public override Size GetSegmentSize()
        {
            Size = ElementSize;
            return ElementSize;
        }

        public override void CalculatePoints()
        {
            StartPoint = new Point(0,0);
            LeftConnectionPoint = new Point(0, ConnectionHeightMargin);
            RightConnectionPoint = new Point(ElementSize.Width,ConnectionHeightMargin);
        }
    }
}
