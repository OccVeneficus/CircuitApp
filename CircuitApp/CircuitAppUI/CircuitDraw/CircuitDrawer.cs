using System;
using System.Drawing;
using CircuitAppUI.CircuitDraw.ElementsDraw;
using CircuitAppUI.CircuitDraw.SegmentsDraw;
using CircutApp.Elements;
using CircutApp.Segments;

namespace CircuitAppUI.CircuitDraw
{
    //TODO: статический класс подразумевает, что в программе в один момент времени можно отрисовать только одну цепь. Для САПР это плохо (done)
    /// <summary>
    /// Class that draws an image of Circuit
    /// </summary>
    public class CircuitDrawer
    {
        //TODO: тут надо определиться - или класс создает и возвращает битмап, а клиентский код решает, где этот битмап пристроить ...(done)
        // ... или в класс передается графикс, на котором всё и рисуется
        //TODO: А нужно ли хранить и пикчербокс, и его же графикс?(done)

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
        //TODO: к твоему вопросу "что лучше - if или switch?" ...
        // ... Зависит от цели. Есть варианты, при которых if нельзя заменить на switch, так как switch может проверять значения только одного объекта.
        // ... При этом почти все if else и switch в этом классе по-хорошему должны быть заменены на использование полиморфных объектов через общий интерфейс

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
        //TODO: отрисовка годная. Теперь попробуй разбить этот класс на полиморфные объекты (done)
    }
}