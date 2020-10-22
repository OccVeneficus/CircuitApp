using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CircuitAppUI.CircuitDraw;
using CircutApp;

namespace CircuitAppUI
{
    /// <summary>
    /// Service class for circuit drawing
    /// </summary>
    public static class CircuitDrawer
    {
        public static PictureBox CircuitPictureBox { get; set; }

        /// <summary>
        /// Graphics of circuitPictureBox
        /// </summary>
        public static Graphics PictureGraphics { get; set; }

        /// <summary>
        /// Default pen
        /// </summary>
        private static readonly Pen BlackPen = new Pen(new SolidBrush(Color.Black), 2);

        /// <summary>
        /// Default size for element pictures
        /// </summary>
        private static readonly Size ElementSize = new Size(50,51);

        public static Bitmap CircuitImage { get; set; }

        private static Size GetCircuitSize(PictureNode segment)
        {
            var size = new Size(0,0);
            if (segment.Segment is SerialSegment)
            {
                size = GetSerialSegmentSize(segment);
            }
            else if (segment.Segment is ParallelSegment)
            {
                size = GetParallelSegmentSize(segment);
                //size.Height += ElementSize.Height;
                //size.Width = size.Width < ElementSize.Width ? ElementSize.Width : size.Width;
            }
            return size;
        }

        private static Size GetSerialSegmentSize(PictureNode node)
        {
            var size = new Size(0,0);
            var x = 0;
            var y = 0;
            foreach (var subNode in node.SubNodes)
            {
                if (subNode.Segment is Element)
                {
                    size.Height = size.Height < ElementSize.Height ? ElementSize.Height : size.Height;
                    size.Width += ElementSize.Width + 11;
                }
                subNode.NodeStartPoint = new Point(x, y);
                subNode.LeftConnectionPoint = new Point(x, 26);
                subNode.RightConnectionPoint = new Point(x + ElementSize.Width, 26);
                x += ElementSize.Width + 11;
            }

            return size;
        }

        private static Size GetParallelSegmentSize(PictureNode node)
        {
            var size = new Size(0,0);
            var x = 15;
            var y = 0;
            var yConnectionPoint = 26;
            foreach (var subNode in node.SubNodes)
            {
                if (subNode.Segment is Element)
                {
                    size.Height += ElementSize.Height;
                    size.Width = size.Width < ElementSize.Width +15 ? ElementSize.Width+30 : size.Width;
                }
                subNode.NodeStartPoint = new Point(x,y);
                subNode.LeftConnectionPoint = new Point(x,Math.Abs(yConnectionPoint));
                subNode.RightConnectionPoint = new Point(x+ElementSize.Width, Math.Abs(yConnectionPoint));
                y += ElementSize.Height;
                yConnectionPoint += ElementSize.Height;
            }
            return size;
        }

        private static void AddSubSegment(PictureNode rootNode)
        {
            foreach (var subSegment in rootNode.Segment.SubSegments)
            {
                rootNode.SubNodes.Add(new PictureNode(subSegment));
            }
        }

        public static void DrawCircuit(PictureNode node)
        {
            AddSubSegment(node);
            CircuitImage = Draw(node);
            if (node.Segment is ParallelSegment)
            {
                DrawParallelConnections(node,CircuitImage);
            }
            else if (node.Segment is SerialSegment)
            {
                DrawSerialConnections(node,CircuitImage);
            }
            PictureGraphics.DrawImage(CircuitImage,new Point(50,50));
        }

        private static void DrawParallelConnections(PictureNode node, Bitmap image)
        {
            var g = Graphics.FromImage(image);
            g.DrawLine(BlackPen,node.SubNodes[0].RightConnectionPoint,
                node.SubNodes[node.SubNodes.Count-1].RightConnectionPoint);
            g.DrawLine(BlackPen, node.SubNodes[0].LeftConnectionPoint,
                node.SubNodes[node.SubNodes.Count-1].LeftConnectionPoint);
            if (node.SubNodes.Count % 2 != 0)
            {
                Point leftConnectionPoint = node.SubNodes[node.SubNodes.Count / 2].LeftConnectionPoint;
                Point rightConnectionPoint = node.SubNodes[node.SubNodes.Count / 2].RightConnectionPoint;
                g.DrawLine(BlackPen, leftConnectionPoint.X,leftConnectionPoint.Y,
                    leftConnectionPoint.X - 10, leftConnectionPoint.Y);
                g.DrawLine(BlackPen, rightConnectionPoint.X, rightConnectionPoint.Y,
                    rightConnectionPoint.X + 10, rightConnectionPoint.Y);
            }
        }

        private static void DrawSerialConnections(PictureNode node, Bitmap image)
        {
            var g = Graphics.FromImage(image);
            for (int i = 0; i < node.SubNodes.Count - 1; i++)
            {
                g.DrawLine(BlackPen,node.SubNodes[i].RightConnectionPoint,
                    node.SubNodes[i+1].LeftConnectionPoint);
            }
        }

        public static Bitmap Draw(PictureNode node)
        {
            var size = GetCircuitSize(node);
            var image = new Bitmap(size.Width,size.Height);
            var g = Graphics.FromImage(image);
            foreach (var subNode in node.SubNodes)
            {
                if (subNode.Segment is Resistor)
                {
                    g.DrawImage(DrawResistor(), subNode.NodeStartPoint);
                }
                else if (subNode.Segment is Inductor)
                {
                    g.DrawImage(DrawInductor(), subNode.NodeStartPoint);
                }
                else if (subNode.Segment is Capacitor)
                {
                    g.DrawImage(DrawCapacitor(), subNode.NodeStartPoint);
                }
            }

            return image;
        }

        /// <summary>
        /// Draw inductor
        /// </summary>
        /// <returns>Bitmap with inductor picture</returns>
        public static Bitmap DrawInductor()
        {
            Bitmap bitmap = new Bitmap(ElementSize.Width, ElementSize.Height);
            Graphics graphics = Graphics.FromImage(bitmap);
            graphics.DrawLine(BlackPen, 0, 26, 5, 26);
            graphics.DrawArc(BlackPen, 5, 19, 11, 14, 180, 180);
            graphics.DrawArc(BlackPen, 16, 19, 11, 14, 180, 180);
            graphics.DrawArc(BlackPen, 27, 19, 11, 14, 180, 180);
            graphics.DrawLine(BlackPen, 37, 26, ElementSize.Width, 26);
            return bitmap;
        }

        /// <summary>
        /// Draw resistor
        /// </summary>
        /// <returns>Bitmap with resistor picture</returns>
        public static Bitmap DrawResistor()
        {
            Bitmap bitmap = new Bitmap(ElementSize.Width, ElementSize.Height);
            Graphics graphics = Graphics.FromImage(bitmap);
            graphics.DrawRectangle(BlackPen, new Rectangle(10, 19, 30, 14));
            graphics.DrawLine(BlackPen, 0, 26, 10, 26);
            graphics.DrawLine(BlackPen, 40, 26, ElementSize.Width, 26);
            return bitmap;
        }

        /// <summary>
        /// Draw capacitor
        /// </summary>
        /// <returns>Bitmap with capacitor picture</returns>
        public static Bitmap DrawCapacitor()
        {
            Bitmap bitmap = new Bitmap(ElementSize.Width, ElementSize.Height);
            Graphics graphics = Graphics.FromImage(bitmap);
            graphics.DrawLine(BlackPen, 20, 19, 20, 33);
            graphics.DrawLine(BlackPen, 25, 19, 25, 33);

            graphics.DrawLine(BlackPen, 0, 26, 20, 26);

            graphics.DrawLine(BlackPen, 25, 26, ElementSize.Width, 26);
            return bitmap;
        }

    }
}
