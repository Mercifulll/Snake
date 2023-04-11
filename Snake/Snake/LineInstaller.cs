using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class LineInstaller
    {
        private List<Shape> shapes;
        public LineInstaller()
        {
            shapes = new List<Shape>();
            HorizontalLine upLine = new HorizontalLine(0, 0, 120, '-');
            HorizontalLine downLine = new HorizontalLine(0, 20, 120, '-');

            VerticalLine leftLine = new VerticalLine(0, 1, 20, '|');
            VerticalLine rightLine = new VerticalLine(119, 1, 20, '|');
            shapes.Add(upLine);
            shapes.Add(downLine);
            shapes.Add(leftLine);
            shapes.Add(rightLine);
        }
        public void PrintShapes()
        {
            foreach (var item in shapes)
                item.PrintLine();
        }
    }
}
