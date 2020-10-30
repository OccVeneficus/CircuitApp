using System.Drawing;

namespace CircuitAppUI.CircuitDraw.ElementsDraw
{
    /// <summary>
    /// Class for capacitor drawing
    /// </summary>
    public class DrawCapacitor : DrawableCircuitElementBase
    {
        /// <summary>
        /// Capacitor left plate X coordinate
        /// </summary>
        private const int LeftPlateX = 22;

        /// <summary>
        /// Capacitor right plate X coordinate
        /// </summary>
        private const int RightPlateX = 27;

        public override Bitmap DrawSegment()
        {
            //TODO: магические числа (done)
            GetSegmentSize();
            var bitmap = new Bitmap(ElementSize.Width, ElementSize.Height);
            var graphics = Graphics.FromImage(bitmap);

            /*Draw capacitor plates*/
            const int platesTopY = 19;
            const int platesBottomY = 33;
            //Draw left plate
            graphics.DrawLine(Pen, LeftPlateX, platesTopY, LeftPlateX, platesBottomY);
            //Draw right plate
            graphics.DrawLine(Pen, RightPlateX, platesTopY, RightPlateX, platesBottomY);
            DrawConnections(bitmap);

            return bitmap;
        }

        protected override void DrawConnections(Image image)
        {
            var graphics = Graphics.FromImage(image);
            /*Draw capacitor connections*/
            const int drawingLeftEndX = 0;
            var drawingRightEndX = ElementSize.Width;
            //Draw left connection
            graphics.DrawLine(Pen, drawingLeftEndX, ConnectionHeightMargin,
                LeftPlateX, ConnectionHeightMargin);
            //Draw right connection
            graphics.DrawLine(Pen, RightPlateX, ConnectionHeightMargin,
                drawingRightEndX, ConnectionHeightMargin);
        }
    }
}
