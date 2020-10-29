﻿using System.Drawing;
using CircutApp.Elements;
using CircutApp.Segments;

namespace CircuitAppUI.CircuitDraw.SegmentsDraw
{
    /// <summary>
    /// Class for parallel segment drawing
    /// </summary>
    public class DrawParallelSegment : DrawableCircuitSegmentBase
    {
        public override void CalculatePoints()
        {
            var yMargin = 0;
            if (SubNodes.Count % 2 == 0)
            {
                yMargin = 1;
            }
            foreach (var node in SubNodes)
            {
                switch (node.Segment)
                {
                    case Element _:
                    {
                        node.StartPoint =
                            new Point(Size.Width / 2 - ElementSize.Width / 2,
                                node.StartPoint.Y + yMargin);
                        node.LeftConnectionPoint =
                            new Point(Size.Width / 2 - ElementSize.Width / 2,
                                node.LeftConnectionPoint.Y + yMargin);
                        node.RightConnectionPoint =
                            new Point(Size.Width / 2 + ElementSize.Width / 2,
                                node.RightConnectionPoint.Y + yMargin);
                        break;
                    }
                    case SerialSegment _ when node.Size.Height > ElementSize.Height:
                    {
                        var delimiter = (node.Size.Height / ElementSize.Height) - 1;
                        var connectionHeight = (ConnectionHeightMargin) * delimiter;
                        node.LeftConnectionPoint = new Point(node.LeftConnectionPoint.X,
                            node.LeftConnectionPoint.Y + connectionHeight - yMargin);
                        node.RightConnectionPoint = new Point(node.RightConnectionPoint.X,
                            node.RightConnectionPoint.Y + connectionHeight - yMargin);
                        break;
                    }
                }
            }
        }

        public override Size GetSegmentSize()
        {
            var size = new Size(0, 0);
            var x = 0;
            var y = 0;
            var yConnectionPoint = ConnectionHeightMargin;
            foreach (var subNode in SubNodes)
            {
                subNode.GetSegmentSize();
                switch (subNode.Segment)
                {
                    case Element _:
                    {
                        //TODO: вот в таких алгоритмах надо оставлять МНОГО комментариев, потому что понять для чего написана каждая строка практически невозможно ...
                        // или один большой комментарий в начале ветки if, или отдельные комментарии у строчек.
                        subNode.GetSegmentSize();
                        size.Height += ElementSize.Height;
                        size.Width = size.Width < ElementSize.Width
                            ? ElementSize.Width + 2 * XMargin
                            : size.Width;
                        subNode.Size = ElementSize;
                        subNode.StartPoint = new Point(x, y);
                        subNode.LeftConnectionPoint = new Point(x, yConnectionPoint);
                        subNode.RightConnectionPoint = new Point(x + ElementSize.Width,
                            yConnectionPoint);
                        y += ElementSize.Height;
                        yConnectionPoint += ElementSize.Height;
                        break;
                    }
                    case SerialSegment _:
                    {
                        var serialSegmentSize = subNode.GetSegmentSize();
                        size.Height += serialSegmentSize.Height;
                        size.Width = size.Width < serialSegmentSize.Width
                            ? serialSegmentSize.Width + XMargin : size.Width;
                        subNode.Size = serialSegmentSize;
                        subNode.StartPoint = new Point(x + XMargin, y);
                        subNode.LeftConnectionPoint = new Point(x + XMargin, yConnectionPoint);
                        subNode.RightConnectionPoint = new Point(x + serialSegmentSize.Width,
                            yConnectionPoint);
                        yConnectionPoint += subNode.Size.Height;
                        y += subNode.Size.Height;
                        break;
                    }
                    case ParallelSegment _:
                    {
                        var parallelSegmentSize = subNode.GetSegmentSize();
                        size.Height += parallelSegmentSize.Height;
                        size.Width = size.Width < parallelSegmentSize.Width + XMargin
                            ? parallelSegmentSize.Width + 2 * XMargin
                            : size.Width;
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
                        break;
                    }
                }
            }
            LeftConnectionPoint = new Point(x, size.Height / 2 + 1);
            RightConnectionPoint = new Point(size.Width, size.Height / 2 + 1);
            Size = size;
            return size;
        }

        protected override void DrawConnections(Image image)
        {
            var g = Graphics.FromImage(image);
            g.DrawLine(Pen,
                XMargin, SubNodes[0].RightConnectionPoint.Y,
                XMargin, SubNodes[SubNodes.Count - 1].RightConnectionPoint.Y);
            g.DrawLine(Pen,
                Size.Width - XMargin, SubNodes[0].LeftConnectionPoint.Y,
                Size.Width - XMargin, SubNodes[SubNodes.Count - 1].LeftConnectionPoint.Y);
            foreach (var subNode in SubNodes)
            {
                g.DrawLine(Pen,
                    subNode.LeftConnectionPoint.X, subNode.LeftConnectionPoint.Y,
                    XMargin, subNode.LeftConnectionPoint.Y);
                g.DrawLine(Pen, subNode.RightConnectionPoint.X, subNode.RightConnectionPoint.Y,
                    Size.Width - XMargin, subNode.RightConnectionPoint.Y);
            }
            g.DrawLine(Pen, 0, Size.Height / 2 + 1, XMargin, Size.Height / 2 + 1);
            g.DrawLine(Pen, Size.Width - XMargin, Size.Height / 2 + 1,
                Size.Width, Size.Height / 2 + 1);
        }
    }
}