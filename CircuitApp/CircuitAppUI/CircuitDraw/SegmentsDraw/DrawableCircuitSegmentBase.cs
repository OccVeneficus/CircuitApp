using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using CircutApp.Segments;

namespace CircuitAppUI.CircuitDraw.SegmentsDraw
{
    /// <summary>
    /// Base class for all segment drawers
    /// </summary>
    public abstract class DrawableCircuitSegmentBase : IDrawableCircuitSegment
    {
        /// <summary>
        /// Margin on x coordinate in pixels
        /// </summary>
        protected static readonly int XMargin = 11;

        /// <summary>
        /// Margin for connection point y coordinate in pixels
        /// </summary>
        protected static readonly int ConnectionHeightMargin = 26;

        /// <summary>
        /// Size of element drawing in pixels
        /// </summary>
        public readonly Size ElementSize = new Size(50, 51);

        /// <summary>
        /// Circuit segment
        /// </summary>
        public ISegment Segment { get; set; }

        /// <summary>
        /// Point from where segment image will be drawn
        /// </summary>
        public Point StartPoint { get; set; } = Point.Empty;

        /// <summary>
        /// Point of left connection. Postpones from <see cref="StartPoint"/>
        /// </summary>
        public Point LeftConnectionPoint { get; set; }

        /// <summary>
        /// Point of right connection. Postpones from <see cref="StartPoint"/>
        /// </summary>
        public Point RightConnectionPoint { get; set; }
        
        /// <summary>
        /// Segment size in pixels
        /// </summary>
        public Size Size { get; set; }

        /// <summary>
        /// List of <see cref="Segment"/> SubSegments in <see cref="DrawableCircuitSegmentBase"/> form
        /// </summary>
        public List<DrawableCircuitSegmentBase> SubNodes { get; set; } = new List<DrawableCircuitSegmentBase>();

        /// <summary>
        /// Pen to draw circuit with
        /// </summary>
        public Pen Pen { get; set; } = new Pen(Color.Black,1);

        /// <summary>
        /// Draws an image of <see cref="Segment"/>
        /// </summary>
        /// <returns><see cref="Segment"/> image</returns>
        public virtual Bitmap DrawSegment()
        {
            if (Size.Height == 0 || Size.Width == 0)
            {
                return new Bitmap(1, 1);
            }
            CalculatePoints();
            var size = Size;
            var image = new Bitmap(size.Width, size.Height);
            var g = Graphics.FromImage(image);
            foreach (var subNode in SubNodes.Where
                (subNode => !subNode.Size.IsEmpty))
            {
                g.DrawImage(subNode.DrawSegment(), subNode.StartPoint);
            }
            DrawConnections(image);
            return image;
        }

        /// <summary>
        /// Draws connections between segments in <see cref="Segment"/> image
        /// </summary>
        /// <param name="image"><see cref="Segment"/> image</param>
        protected abstract void DrawConnections(Image image);

        /// <summary>
        /// Calculates <see cref="StartPoint"/>, <see cref="LeftConnectionPoint"/>
        /// and <see cref="RightConnectionPoint"/> positions
        /// </summary>
        public abstract void CalculatePoints();

        /// <summary>
        /// Calculates size of <see cref="Segment"/> image
        /// </summary>
        /// <returns>Size in pixels</returns>
        public abstract Size GetSegmentSize();
    }
}
