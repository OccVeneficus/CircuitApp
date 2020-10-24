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

        private static Size GetCircuitSize(PictureNode rootNode)
        {
            var size = new Size(0,0);
            if (rootNode.Segment is SerialSegment)
            {
                size = GetSerialSegmentSize(rootNode);
            }
            else if (rootNode.Segment is ParallelSegment)
            {
                size = GetParallelSegmentSize(rootNode);
            }
            else if (rootNode.Segment is Element)
            {
                size = ElementSize;
            }
            rootNode.Size = size;
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
                    subNode.Size = ElementSize;
                    subNode.NodeStartPoint = new Point(x, y);
                    subNode.LeftConnectionPoint = new Point(x, ElementSize.Height / 2 + 1);
                    subNode.RightConnectionPoint = new Point(x + ElementSize.Width, ElementSize.Height / 2 + 1);
                    x += ElementSize.Width + 11;
                }
                else if (subNode.Segment is ParallelSegment)
                {
                    var parallelSegmentSize = GetParallelSegmentSize(subNode);
                    size.Height = size.Height < parallelSegmentSize.Height ? parallelSegmentSize.Height : size.Height;
                    size.Width += parallelSegmentSize.Width + 11;
                    subNode.Size = parallelSegmentSize;
                    subNode.NodeStartPoint = new Point(x, y);
                    subNode.LeftConnectionPoint = new Point(x, subNode.Size.Height / 2 + 1);
                    subNode.RightConnectionPoint = new Point(x + subNode.Size.Width, subNode.Size.Height / 2 + 1);
                    x += subNode.Size.Width + 11;
                }
            }

            return size;
        }

        private static Size GetParallelSegmentSize(PictureNode node)
        {
            var size = new Size(0,0);
            var x = 0;
            var y = 0;
            var yConnectionPoint = 26;
            foreach (var subNode in node.SubNodes)
            {
                if (subNode.Segment is Element)
                {
                    size.Height += ElementSize.Height;
                    size.Width = size.Width < ElementSize.Width ? ElementSize.Width : size.Width;
                    subNode.Size = ElementSize;
                }
                subNode.NodeStartPoint = new Point(x,y);
                subNode.LeftConnectionPoint = new Point(x,Math.Abs(yConnectionPoint));
                subNode.RightConnectionPoint = new Point(x+ElementSize.Width, Math.Abs(yConnectionPoint));
                y += ElementSize.Height;
                yConnectionPoint += ElementSize.Height;
            }
            node.LeftConnectionPoint = new Point(x,size.Height/2);
            node.RightConnectionPoint = new Point(size.Width,size.Height/2);
            node.Size = size;
            return size;
        }

        private static void AddSubSegment(PictureNode rootNode)
        {
            foreach (var subSegment in rootNode.Segment.SubSegments)
            {
                var subNode = new PictureNode(subSegment);
                rootNode.SubNodes.Add(subNode);
                if (subSegment.SubSegments != null)
                {
                    AddSubSegment(subNode);
                }
            }
        }

        public static void DrawCircuit(PictureNode node)
        {
            AddSubSegment(node);
            var size = GetCircuitSize(node);
            if (node.Segment is ParallelSegment)
            {
                CircuitImage = DrawParallelSegment(node);
            }
            else if (node.Segment is SerialSegment)
            {
                CircuitImage = DrawSerialSegment(node);
            }
            PictureGraphics.DrawImage(CircuitImage,new Point(10,CircuitPictureBox.Height/2 - CircuitImage.Height/2));
        }

        private static Bitmap DrawSerialSegment(PictureNode rootNode)
        {
            var size = rootNode.Size;
            var image = new Bitmap(size.Width, size.Height);
            var g = Graphics.FromImage(image);
            foreach (var subNode in rootNode.SubNodes)
            {
                var subNodeImage = new Bitmap(subNode.Size.Width,subNode.Size.Height);
                if (subNode.Segment is Element)
                {
                    subNodeImage = DrawElement(subNode);
                }
                else if (subNode.Segment is ParallelSegment)
                {
                    subNodeImage = DrawParallelSegment(subNode);
                }
                g.DrawImage(subNodeImage, subNode.NodeStartPoint);
            }
            DrawSerialConnections(rootNode,image);
            return image;
        }

        private static Bitmap DrawParallelSegment(PictureNode rootNode)
        {
            var size = rootNode.Size;
            var image = new Bitmap(size.Width, size.Height);
            var g = Graphics.FromImage(image);
            foreach (var subNode in rootNode.SubNodes)
            {
                g.DrawImage(DrawElement(subNode), subNode.NodeStartPoint);
            }
            DrawParallelConnections(rootNode,image);
            return image;
        }

        private static void DrawParallelConnections(PictureNode node, Bitmap image)
        {
            var g = Graphics.FromImage(image);
            g.DrawLine(BlackPen,node.SubNodes[0].RightConnectionPoint,
                node.SubNodes[node.SubNodes.Count-1].RightConnectionPoint);
            g.DrawLine(BlackPen, node.SubNodes[0].LeftConnectionPoint,
                node.SubNodes[node.SubNodes.Count-1].LeftConnectionPoint);
            //if (node.SubNodes.Count % 2 != 0)
            //{
            //    node.LeftConnectionPoint = new Point(node.LeftConnectionPoint.X,node.LeftConnectionPoint.Y +1);
            //    node.RightConnectionPoint = new Point(node.RightConnectionPoint.X, node.RightConnectionPoint.Y + 1);
            //}
            //g.DrawLine(BlackPen, node.LeftConnectionPoint.X, node.LeftConnectionPoint.Y,
            //    node.LeftConnectionPoint.X - 10, node.LeftConnectionPoint.Y);
            //g.DrawLine(BlackPen, node.RightConnectionPoint.X, node.RightConnectionPoint.Y,
            //    node.RightConnectionPoint.X + 10, node.RightConnectionPoint.Y);
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

        public static Bitmap DrawElement(PictureNode node)
        {
            var size = node.Size;
            var image = new Bitmap(size.Width,size.Height);
            var g = Graphics.FromImage(image);
            if (node.Segment is Resistor)
            { 
                g.DrawImage(DrawResistor(), 0,0);
            }
            else if (node.Segment is Inductor)
            {
                g.DrawImage(DrawInductor(), 0,0);
            }
            else if (node.Segment is Capacitor)
            {
                g.DrawImage(DrawCapacitor(), 0,0);
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
