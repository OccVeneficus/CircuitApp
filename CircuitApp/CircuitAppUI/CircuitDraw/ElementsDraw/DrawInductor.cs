using System.Drawing;

namespace CircuitAppUI.CircuitDraw.ElementsDraw
{
    /// <summary>
    /// Class for inductor drawing
    /// </summary>
    public class DrawInductor : DrawableCircuitElementBase
    {
        /// <summary>
        /// Determines arc height
        /// </summary>
        private const int ArcHeight = 10;

        /// <summary>
        /// Determines arc width
        /// </summary>
        private const int ArcWidth = 10;

        /// <summary>
        /// Start Y coordinate for arcs
        /// </summary>
        private const int ArcStartY = 20;

        /// <summary>
        /// Arcs quantity
        /// </summary>
        private const int ArcCount = 3;

        /// <summary>
        /// Arc start and sweep angel
        /// </summary>
        private const int ArcAngle = 180;

        /// <summary>
        /// From were to start drawing arcs
        /// </summary>
        private const int ArcStartX = 10;

        public override Bitmap DrawSegment()
        {
            GetSegmentSize();
            var bitmap = new Bitmap(ElementSize.Width, ElementSize.Height);
            var graphics = Graphics.FromImage(bitmap); ;
            for (var index = 0; index < ArcCount; index++)
            {
                var currentArcStartX = ArcStartX * (index + 1);
                graphics.DrawArc(Pen, currentArcStartX, ArcStartY, ArcWidth, ArcHeight,
                    ArcAngle, ArcAngle);
            }
            DrawConnections(bitmap);
            return bitmap;
        }

        protected override void DrawConnections(Image image)
        {
            var graphics = Graphics.FromImage(image);
            const int lastArcEnd = ArcStartX + ArcWidth * ArcCount; 
            graphics.DrawLine(Pen, 0, ConnectionHeightMargin,
                ArcWidth, ConnectionHeightMargin);
            graphics.DrawLine(Pen, lastArcEnd, ConnectionHeightMargin,
                ElementSize.Width, ConnectionHeightMargin);
        }
    }
}
