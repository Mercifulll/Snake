using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            LineInstaller line = new LineInstaller();
            line.PrintShapes();

            Point point = FoodFactory.RandFood(119, 20, Convert.ToChar(176));
            point.PrintPoint();
        }
    }
}