using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Shape
    {
        protected List<Point> points;
        public void PrintLine()
        {
            foreach (var item in points)
            {
                item.PrintPoint();
            }
        }
    }
}
