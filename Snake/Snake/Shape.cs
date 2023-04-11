using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class Shape
    {
        protected List<Point> points;
        public void PrintLine()
        {
            foreach (var item in points)
            {
                item.PrintPoint();
            }
        }

        internal bool Collision(Shape shape)
        {
            foreach (var item in points)
            {
                if (shape.ComparePoints(item))
                    return true;
            }
            return false;
        }

        private bool ComparePoints(Point point)
        {
            foreach (var item in points)
            {
                if (point.ComparePoints(item))
                    return true;
            }
            return false;
        }
    }
}
