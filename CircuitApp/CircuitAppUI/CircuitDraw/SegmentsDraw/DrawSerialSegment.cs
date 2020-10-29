using System.Drawing;

namespace CircuitAppUI.CircuitDraw.SegmentsDraw
{
    public class DrawSerialSegment : DrawableCircuitSegmentBase
    {
        public override void CalculatePoints()
        {
            foreach (var node in SubNodes)
            {
                node.StartPoint = new Point(node.StartPoint.X,
                    Size.Height / 2 - node.Size.Height / 2);
                node.LeftConnectionPoint = new Point(node.LeftConnectionPoint.X,
                    Size.Height / 2 + 1);
                node.RightConnectionPoint = new Point(node.RightConnectionPoint.X,
                    Size.Height / 2 + 1);
            }
        }

        protected override void DrawConnections(Image image)
        {
            var g = Graphics.FromImage(image);
            for (var i = 0; i < SubNodes.Count - 1; i++)
            {
                g.DrawLine(Pen, SubNodes[i].RightConnectionPoint.X - 10,
                    SubNodes[i].RightConnectionPoint.Y,
                    SubNodes[i + 1].LeftConnectionPoint.X,
                    SubNodes[i + 1].LeftConnectionPoint.Y);
            }
            g.DrawLine(Pen, SubNodes[SubNodes.Count - 1].RightConnectionPoint.X,
                SubNodes[SubNodes.Count - 1].RightConnectionPoint.Y,
                SubNodes[SubNodes.Count - 1].RightConnectionPoint.X - XMargin + 1,
                SubNodes[SubNodes.Count - 1].RightConnectionPoint.Y);
        }

        public override Size GetSegmentSize()
        {
            var size = new Size(0, 0);
            var x = 0;
            var y = 0;
            foreach (var subNode in SubNodes)
            {
                subNode.GetSegmentSize();
                size.Height = size.Height < subNode.Size.Height ? subNode.Size.Height : size.Height;
                size.Width += subNode.Size.Width + XMargin;
                subNode.StartPoint = new Point(x, y);
                subNode.LeftConnectionPoint = new Point(x, subNode.Size.Height / 2 + 1);
                subNode.RightConnectionPoint = new Point(x + subNode.Size.Width,
                    subNode.Size.Height / 2 + 1);
                x += subNode.Size.Width + XMargin;
            }

            Size = size;
            return size;
        }
    }
}
