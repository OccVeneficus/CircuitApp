using System;
using System.Drawing;
using System.Windows.Forms;
using CircutApp.Elements;
using CircutApp.Segments;

namespace CircuitAppUI.CircuitDraw
{
    //TODO: статический класс подразумевает, что в программе в один момент времени можно отрисовать только одну цепь. Для САПР это плохо
    /// <summary>
    /// Service class for circuit drawing
    /// </summary>
    public static class CircuitDrawer
    {
        /// <summary>
        /// Margin on x coordinate in pixels
        /// </summary>
        private static readonly int XMargin = 11;

        /// <summary>
        /// Margin for connection point y coordinate in pixels
        /// </summary>
        private static readonly int ConnectionHeightMargin = 26;

        /// <summary>
        /// Default pen
        /// </summary>
        private static readonly Pen BlackPen = new Pen(new SolidBrush(Color.Black), 1);

        /// <summary>
        /// Default size for element pictures
        /// </summary>
        private static readonly Size ElementSize = new Size(50,51);
        //TODO: тут надо определиться - или класс создает и возвращает битмап, а клиентский код решает, где этот битмап пристроить ...
        // ... или в класс передается графикс, на котором всё и рисуется
        /// <summary>
        /// Bitmap with circuit drawing
        /// </summary>
        private static Bitmap _circuitImage;

        /// <summary>
        /// PictureBox to draw on
        /// </summary>
        public static PictureBox CircuitPictureBox { get; set; }
        //TODO: А нужно ли хранить и пикчербокс, и его же графикс?
        /// <summary>
        /// Graphics of circuitPictureBox
        /// </summary>
        public static Graphics PictureGraphics { get; set; }

        /// <summary>
        /// Draws circuit
        /// </summary>
        /// <param name="node">Node that contains circuit root element</param>
        public static void DrawCircuit(PictureNode node)
        {
            if (node.Segment == null || node.Segment.SubSegments.Count == 0)
            {
                return;
            }
            AddSubSegment(node);
            GetCircuitSize(node);
            switch (node.Segment)
            {
                case ParallelSegment _ when node.Segment.SubSegments.Count != 0:
                {
                    _circuitImage = DrawParallelSegment(node);
                    break;
                }
                case SerialSegment _ when node.Segment.SubSegments.Count != 0:
                {
                    _circuitImage = DrawSerialSegment(node);
                    break;
                }
            }

            PictureGraphics.DrawImage(_circuitImage, new Point(10, CircuitPictureBox.Height 
                / 2 - _circuitImage.Height / 2));
        }

        /// <summary>
        /// Calculates circuit size in pixels
        /// </summary>
        /// <param name="rootNode">Node that contains circuit root segment</param>
        private static void GetCircuitSize(PictureNode rootNode)
        {
            var size = new Size(0,0);
            //TODO: к твоему вопросу "что лучше - if или switch?" ...
            // ... Зависит от цели. Есть варианты, при которых if нельзя заменить на switch, так как switch может проверять значения только одного объекта.
            // ... При этом почти все if else и switch в этом классе по-хорошему должны быть заменены на использование полиморфных объектов через общий интерфейс
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
            rootNode.LeftConnectionPoint = new Point(0,size.Height/2 + 1);
            rootNode.RightConnectionPoint = new Point(rootNode.Size.Width, size.Height / 2 + 1);
        }

        /// <summary>
        /// Calculates size of serial size segment in pixels
        /// </summary>
        /// <param name="node">Node that contains serial segment root segment</param>
        /// <returns>Size of serial segment in pixels</returns>
        private static Size GetSerialSegmentSize(PictureNode node)
        {
            var size = new Size(0,0);
            var x = 0;
            var y = 0;
            foreach (var subNode in node.SubNodes)
            {
                if (subNode.Segment is Element)
                {
                    subNode.Size = ElementSize;
                }
                else if (subNode.Segment is SerialSegment)
                {
                    subNode.Size = GetSerialSegmentSize(subNode);
                }
                else if (subNode.Segment is ParallelSegment)
                {
                    subNode.Size = GetParallelSegmentSize(subNode);
                }
                size.Height = size.Height < subNode.Size.Height ? subNode.Size.Height : size.Height;
                size.Width += subNode.Size.Width + XMargin;
                subNode.StartPoint = new Point(x, y);
                subNode.LeftConnectionPoint = new Point(x, subNode.Size.Height / 2 + 1);
                subNode.RightConnectionPoint = new Point(x + subNode.Size.Width,
                    subNode.Size.Height / 2 + 1);
                x += subNode.Size.Width + XMargin;
            }
            return size;
        }

        /// <summary>
        /// Calculates size in pixels of parallel segment
        /// </summary>
        /// <param name="node">Node that contains parallel segment root segment</param>
        /// <returns>Parallel segment size in pixels</returns>
        private static Size GetParallelSegmentSize(PictureNode node)
        {
            var size = new Size(0, 0);
            var x = 0;
            var y = 0;
            var yConnectionPoint = ConnectionHeightMargin;
            foreach (var subNode in node.SubNodes)
            {
                if (subNode.Segment is Element)
                {
                    //TODO: вот в таких алгоритмах надо оставлять МНОГО комментариев, потому что понять для чего написана каждая строка практически невозможно ...
                    // или один большой комментарий в начале ветки if, или отдельные комментарии у строчек.

                    size.Height += ElementSize.Height;
                    size.Width = size.Width < ElementSize.Width ? ElementSize.Width + 2 * XMargin 
                        : size.Width;
                    subNode.Size = ElementSize;
                    subNode.StartPoint = new Point(x, y);
                    subNode.LeftConnectionPoint = new Point(x, yConnectionPoint);
                    subNode.RightConnectionPoint = new Point(x + ElementSize.Width,
                        yConnectionPoint);
                    y += ElementSize.Height;
                    yConnectionPoint += ElementSize.Height;
                }
                else if (subNode.Segment is SerialSegment)
                {
                    var serialSegmentSize = GetSerialSegmentSize(subNode);
                    size.Width = size.Width < serialSegmentSize.Width 
                        ? serialSegmentSize.Width + XMargin : size.Width;
                    size.Height += serialSegmentSize.Height;
                    subNode.Size = serialSegmentSize;
                    subNode.StartPoint = new Point(x + XMargin, y);
                    subNode.LeftConnectionPoint = new Point(x + XMargin, yConnectionPoint);
                    subNode.RightConnectionPoint = new Point(x + serialSegmentSize.Width,
                        yConnectionPoint);
                    yConnectionPoint += subNode.Size.Height;
                    y += subNode.Size.Height;
                }
                else if (subNode.Segment is ParallelSegment)
                {
                    var parallelSegmentSize = GetParallelSegmentSize(subNode);
                    size.Width = size.Width < parallelSegmentSize.Width + XMargin
                        ? parallelSegmentSize.Width + 2 * XMargin
                        : size.Width;
                    size.Height += parallelSegmentSize.Height;
                    var delimiter = (subNode.Size.Height / ElementSize.Height) - 1;
                    var connectionHeight = (ElementSize.Height / 2) * delimiter;

                    subNode.Size = parallelSegmentSize;
                    subNode.StartPoint = new Point(x + XMargin, y);
                    subNode.LeftConnectionPoint = new Point(x + XMargin,
                        yConnectionPoint + (connectionHeight + 2)
                        * (subNode.Segment.SubSegments.Count - 1) - 1);
                    subNode.RightConnectionPoint =
                        new Point(x + parallelSegmentSize.Width + XMargin,
                        yConnectionPoint + (connectionHeight + 2)
                        * (subNode.Segment.SubSegments.Count - 1) - 1);
                    yConnectionPoint += subNode.Size.Height;
                    y += subNode.Size.Height;
                }
            }
            node.LeftConnectionPoint = new Point(x, size.Height / 2 + 1);
            node.RightConnectionPoint = new Point(size.Width, size.Height / 2 + 1);
            node.Size = size;
            return size;
        }

        /// <summary>
        /// Adjust points of parallel segment elements
        /// relative to bigger bitmap
        /// </summary>
        /// <param name="rootNode">Node that contains parallel segment root segment</param>
        private static void SetPointsForParallelSegment(PictureNode rootNode)
        {
            var yMargin = 0;
            if (rootNode.SubNodes.Count % 2 == 0)
            {
                yMargin = 1;
            }
            foreach (var node in rootNode.SubNodes)
            {
                if (node.Segment is Element)
                {
                    node.StartPoint = 
                        new Point(rootNode.Size.Width/2 - ElementSize.Width/2,
                            node.StartPoint.Y + yMargin);
                    node.LeftConnectionPoint = 
                        new Point(rootNode.Size.Width / 2 - ElementSize.Width / 2,
                            node.LeftConnectionPoint.Y + yMargin);
                    node.RightConnectionPoint = 
                        new Point(rootNode.Size.Width / 2 + ElementSize.Width / 2,
                            node.RightConnectionPoint.Y + yMargin);
                }
                else if (node.Segment is SerialSegment && node.Size.Height > ElementSize.Height)
                {
                    var delimiter = (node.Size.Height / ElementSize.Height) - 1;
                    var connectionHeight = (ConnectionHeightMargin) * delimiter;
                    node.LeftConnectionPoint = new Point(node.LeftConnectionPoint.X,
                        node.LeftConnectionPoint.Y + connectionHeight - yMargin);
                    node.RightConnectionPoint = new Point(node.RightConnectionPoint.X,
                        node.RightConnectionPoint.Y + connectionHeight - yMargin);
                }
            }
        }

        /// <summary>
        /// Adjust points of serial segment elements
        /// relative to bigger bitmap
        /// </summary>
        /// <param name="rootNode">Node that contains serial segment root segment</param>
        private static void SetPointsForSerialSegment(PictureNode rootNode)
        {
            foreach (var node in rootNode.SubNodes)
            {
                node.StartPoint = new Point(node.StartPoint.X,
                        rootNode.Size.Height / 2 - node.Size.Height / 2);
                node.LeftConnectionPoint = new Point(node.LeftConnectionPoint.X,
                        rootNode.Size.Height / 2 + 1);
                node.RightConnectionPoint = new Point(node.RightConnectionPoint.X,
                        rootNode.Size.Height / 2 + 1);
            }
        }

        /// <summary>
        /// Fills rootNode SubSegments
        /// </summary>
        /// <param name="rootNode">Node that contains circuit root segment</param>
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

        /// <summary>
        /// Draws serial segment
        /// </summary>
        /// <param name="rootNode">Node with serial segment</param>
        /// <returns>Bitmap with serial segment drawing</returns>
        private static Bitmap DrawSerialSegment(PictureNode rootNode)
        {
            if (rootNode.Size.Height == 0 || rootNode.Size.Width == 0)
            {
                return new Bitmap(1,1);
            }
            SetPointsForSerialSegment(rootNode);
            var size = rootNode.Size;
            var image = new Bitmap(size.Width, size.Height);
            var g = Graphics.FromImage(image);
            foreach (var subNode in rootNode.SubNodes)
            {
                if (subNode.Size.IsEmpty)
                {
                    continue;
                }
                var subNodeImage = new Bitmap(subNode.Size.Width,subNode.Size.Height);
                if (subNode.Segment is Element)
                {
                    subNodeImage = DrawElement(subNode);
                }
                else if (subNode.Segment is ParallelSegment)
                {
                    subNodeImage = DrawParallelSegment(subNode);
                }
                else if (subNode.Segment is SerialSegment)
                {
                    subNodeImage = DrawSerialSegment(subNode);
                }
                g.DrawImage(subNodeImage, subNode.StartPoint);
            }
            DrawSerialConnections(rootNode,image);
            return image;
        }


        /// <summary>
        /// Draws parallel segment
        /// </summary>
        /// <param name="rootNode">Node that contains parallel segment</param>
        /// <returns>Parallel segment drawing</returns>
        private static Bitmap DrawParallelSegment(PictureNode rootNode)
        {
            if (rootNode.Size.Height == 0 || rootNode.Size.Width == 0)
            {
                return new Bitmap(1, 1);
            }
            SetPointsForParallelSegment(rootNode);
            var size = rootNode.Size;
            var image = new Bitmap(size.Width, size.Height);
            var g = Graphics.FromImage(image);
            foreach (var subNode in rootNode.SubNodes)
            {
                Bitmap subNodeImage;
                if (subNode.Segment is Element)
                {
                    subNodeImage = DrawElement(subNode);
                }
                else if (subNode.Segment is SerialSegment)
                {
                    subNodeImage = DrawSerialSegment(subNode);
                }
                else if (subNode.Segment is ParallelSegment)
                {
                    subNodeImage = DrawParallelSegment(subNode);
                }
                else
                {
                    throw new NotImplementedException("Unknown circuit segment type");
                }
                g.DrawImage(subNodeImage, subNode.StartPoint);
            }
            DrawParallelConnections(rootNode,image);
            return image;
        }

        /// <summary>
        /// Draws connections on bitmap with parallel segment image
        /// </summary>
        /// <param name="node">Node that contains parallel segment</param>
        /// <param name="image">Parallel segment image</param>
        private static void DrawParallelConnections(PictureNode node, Image image)
        {
            var g = Graphics.FromImage(image);
            g.DrawLine(BlackPen, 
                XMargin, node.SubNodes[0].RightConnectionPoint.Y, 
                XMargin, node.SubNodes[node.SubNodes.Count - 1].RightConnectionPoint.Y);
            g.DrawLine(BlackPen, 
                node.Size.Width - XMargin, node.SubNodes[0].LeftConnectionPoint.Y,
                node.Size.Width - XMargin, node.SubNodes[node.SubNodes.Count - 1].LeftConnectionPoint.Y);
            foreach (var subNode in node.SubNodes)
            {
                g.DrawLine(BlackPen, 
                    subNode.LeftConnectionPoint.X, subNode.LeftConnectionPoint.Y, 
                    XMargin, subNode.LeftConnectionPoint.Y);
                g.DrawLine(BlackPen, subNode.RightConnectionPoint.X, subNode.RightConnectionPoint.Y,
                    node.Size.Width - XMargin, subNode.RightConnectionPoint.Y);
            }
            g.DrawLine(BlackPen, 0, node.Size.Height/2+1, XMargin, node.Size.Height / 2 + 1);
            g.DrawLine(BlackPen, node.Size.Width - XMargin, node.Size.Height / 2 + 1,
                node.Size.Width, node.Size.Height / 2 + 1);
        }

        /// <summary>
        /// Draws connections on drawing with serial segment
        /// </summary>
        /// <param name="node">Node that contains serial segment</param>
        /// <param name="image">Image of serial segment</param>
        private static void DrawSerialConnections(PictureNode node, Image image)
        {
            var g = Graphics.FromImage(image);
            for (var i = 0; i < node.SubNodes.Count - 1; i++)
            {
                g.DrawLine(BlackPen, node.SubNodes[i].RightConnectionPoint.X - 10,
                    node.SubNodes[i].RightConnectionPoint.Y,
                    node.SubNodes[i + 1].LeftConnectionPoint.X,
                    node.SubNodes[i + 1].LeftConnectionPoint.Y);
            }
            g.DrawLine(BlackPen, node.SubNodes[node.SubNodes.Count-1].RightConnectionPoint.X,
                node.SubNodes[node.SubNodes.Count - 1].RightConnectionPoint.Y,
                node.SubNodes[node.SubNodes.Count - 1].RightConnectionPoint.X - XMargin + 1,
                node.SubNodes[node.SubNodes.Count - 1].RightConnectionPoint.Y);
        }

        /// <summary>
        /// Chooses method to draw element
        /// </summary>
        /// <param name="node">Node with element to draw</param>
        /// <returns>Bitmap with element drawing</returns>
        public static Bitmap DrawElement(PictureNode node)
        {
            var size = node.Size;
            if (size.IsEmpty)
            {
                return new Bitmap(1,1);
            }
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
            else
            {
                throw new NotImplementedException("Unknown circuit element type");
            }
            return image;
        }

        /// <summary>
        /// Draw inductor
        /// </summary>
        /// <returns>Bitmap with inductor picture</returns>
        public static Bitmap DrawInductor()
        {
            //TODO: магические числа
            var bitmap = new Bitmap(ElementSize.Width, ElementSize.Height);
            var graphics = Graphics.FromImage(bitmap);
            graphics.DrawLine(BlackPen, 0, 26, 10, 26);
            graphics.DrawArc(BlackPen, 10, 20, 10, 10, 180, 180);
            graphics.DrawArc(BlackPen, 20, 20, 10, 10, 180, 180);
            graphics.DrawArc(BlackPen, 30, 20, 10, 10, 180, 180);
            graphics.DrawLine(BlackPen, 40, 26, ElementSize.Width, 26);
            return bitmap;
        }

        /// <summary>
        /// Draw resistor
        /// </summary>
        /// <returns>Bitmap with resistor picture</returns>
        public static Bitmap DrawResistor()
        {
            //TODO: магические числа
            var bitmap = new Bitmap(ElementSize.Width, ElementSize.Height);
            var graphics = Graphics.FromImage(bitmap);
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
            //TODO: магические числа
            var bitmap = new Bitmap(ElementSize.Width, ElementSize.Height);
            var graphics = Graphics.FromImage(bitmap);
            graphics.DrawLine(BlackPen, 22, 19, 22, 33);
            graphics.DrawLine(BlackPen, 27, 19, 27, 33);

            graphics.DrawLine(BlackPen, 0, 26, 22, 26);

            graphics.DrawLine(BlackPen, 27, 26, ElementSize.Width, 26);
            return bitmap;
        }
        //TODO: отрисовка годная. Теперь попробуй разбить этот класс на полиморфные объекты
    }
}
