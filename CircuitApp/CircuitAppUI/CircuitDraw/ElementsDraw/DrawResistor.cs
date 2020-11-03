using System.Drawing;

namespace CircuitAppUI.CircuitDraw.ElementsDraw
{
    /// <summary>
    /// Class for resistor drawing
    /// </summary>
    public class DrawResistor : DrawableCircuitElementBase
    {
        /// <summary>
        /// Resistor rectangle start X coordinate
        /// </summary>
        private const int ResistorStartX = 10;

        /// <summary>
        /// Resistor rectangle start Y coordinate
        /// </summary>
        private const int ResistorStartY = 19;

        /// <summary>
        /// Resistor rectangle width
        /// </summary>
        private const int ResistorWidth = 30;

        /// <summary>
        /// Resistor rectangle height
        /// </summary>
        private const int ResistorHeight = 14;

        public override Bitmap DrawSegment()
        {
            GetSegmentSize();
            var bitmap = new Bitmap(ElementSize.Width, ElementSize.Height);
            var graphics = Graphics.FromImage(bitmap);
            graphics.DrawRectangle(Pen, new Rectangle(ResistorStartX, ResistorStartY,
                ResistorWidth, ResistorHeight));
            DrawConnections(bitmap);
            return bitmap;
        }

        protected override void DrawConnections(Image image)
        {
            var graphics = Graphics.FromImage(image);
            graphics.DrawLine(Pen, 0, ConnectionHeightMargin,
                ResistorStartX, ConnectionHeightMargin);
            graphics.DrawLine(Pen, ResistorStartX+ResistorWidth, ConnectionHeightMargin,
                ElementSize.Width, ConnectionHeightMargin);
        }
    }
}
