using System.Drawing;

namespace CircuitAppUI.CircuitDraw.SegmentsDraw
{
    public interface IDrawableCircuitSegment
    {
        Pen Pen { get; set; }

        /// <summary>
        /// Draws segment
        /// </summary>
        /// <returns>Bitmap with segment drawing</returns>
        Bitmap DrawSegment();

        /// <summary>
        /// Sets points for <see cref="SegmentNode"/> SubNodes
        /// </summary>
        void CalculatePoints();

        /// <summary>
        /// Calculates segment size
        /// </summary>
        /// <returns>Segment size in pixels</returns>
        Size GetSegmentSize();
    }
}
