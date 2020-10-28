using System.Collections.Generic;
using System.Drawing;
using CircutApp.Segments;

namespace CircuitAppUI.CircuitDraw
{
    /// <summary>
    /// Type to contain circuit segment information for drawing
    /// </summary>
    public class PictureNode
    {
        /// <summary>
        /// Circuit segment
        /// </summary>
        public ISegment Segment { get; private set; }

        //TODO: здесь и далее имеет смысл в комментарии указать, что точка откладывается от StartPoint
        /// <summary>
        /// Point of left connection 
        /// </summary>
        public Point LeftConnectionPoint { get; set; }

        /// <summary>
        /// Point of right connection
        /// </summary>
        public Point RightConnectionPoint { get; set; }
        
        /// <summary>
        /// Point from where segment image will be drawn
        /// </summary>
        public Point StartPoint { get; set; } = Point.Empty;

        /// <summary>
        /// Segment size in pixels
        /// </summary>
        public Size Size { get; set; }

        /// <summary>
        /// List of <see cref="Segment"/> SubSegments in <see cref="PictureNode"/> form
        /// </summary>
        public List<PictureNode> SubNodes { get; set; } = new List<PictureNode>();

        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="segment">Node segment</param>
        public PictureNode(ISegment segment)
        {
            Segment = segment;
        }
    }
}
