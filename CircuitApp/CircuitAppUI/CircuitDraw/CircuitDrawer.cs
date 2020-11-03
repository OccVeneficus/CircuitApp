using System;
using System.Drawing;
using CircuitAppUI.CircuitDraw.ElementsDraw;
using CircuitAppUI.CircuitDraw.SegmentsDraw;
using CircutApp.Elements;
using CircutApp.Segments;

namespace CircuitAppUI.CircuitDraw
{
    /// <summary>
    /// Class that draws an image of Circuit
    /// </summary>
    public class CircuitDrawer
    {
        /// <summary>
        /// Draws circuit
        /// </summary>
        /// <param name="node">Node that contains circuit root element</param>
        /// <returns>Image of segment</returns>
        public Bitmap DrawCircuit(DrawableCircuitSegmentBase node)
        {
            if (node.Segment == null || node.Segment.SubSegments.Count == 0)
            {
                return new Bitmap(1,1);
            }
            AddSubSegment(node);
            node.GetSegmentSize();
            return node.DrawSegment();
        }
        
        /// <summary>
        /// Fills rootNode SubSegments
        /// </summary>
        /// <param name="rootNode">Node that contains circuit root segment</param>
        private void AddSubSegment(DrawableCircuitSegmentBase rootNode)
        {
            foreach (var subSegment in rootNode.Segment.SubSegments)
            {
                var subNode = ChooseDrawer(subSegment);
                subNode.Segment = subSegment;
                rootNode.SubNodes.Add(subNode);
                if (subSegment.SubSegments != null)
                {
                    AddSubSegment(subNode);
                }
            }
        }

        /// <summary>
        /// Chooses drawer based on segment type
        /// </summary>
        /// <param name="segment">Circuit segment</param>
        /// <exception cref="ArgumentException"></exception>
        /// <returns>New segment drawer of chosen type</returns>
        private DrawableCircuitSegmentBase ChooseDrawer(ISegment segment)
        {
            switch (segment)
            {
                case Resistor _:
                {
                    return new DrawResistor();
                }
                case Capacitor _:
                {
                    return new DrawCapacitor();
                }
                case Inductor _:
                {
                    return new DrawInductor();
                }
                case SerialSegment _:
                {
                    return new DrawSerialSegment();
                }
                case ParallelSegment _:
                {
                    return new DrawParallelSegment();
                }
                default:
                {
                    throw new ArgumentException("Unknown circuit segment type");
                }
            }
        }
    }
}