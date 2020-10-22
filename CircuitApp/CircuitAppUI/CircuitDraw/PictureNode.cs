using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CircutApp;

namespace CircuitAppUI.CircuitDraw
{
    public class PictureNode
    {
        public ISegment Segment { get; private set; }

        public Point LeftConnectionPoint { get; set; }

        public Point RightConnectionPoint { get; set; }
        
        public Point NodeStartPoint { get; set; } = Point.Empty;

        public PictureNode Parent { get; set; }

        public Size Size { get; set; }

        public List<PictureNode> SubNodes { get; set; } = new List<PictureNode>();

        public PictureNode(ISegment segment)
        {
            Segment = segment;
        }
    }
}
