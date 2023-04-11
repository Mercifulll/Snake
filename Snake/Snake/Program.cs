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
            HorizontalLine up = new HorizontalLine(0,0,120, '-');
            up.PrintLine();
            HorizontalLine down = new HorizontalLine(0, 20, 120, '-');
            down.PrintLine();
            VerticalLine left = new VerticalLine(0, 1, 20, '|');
            left.PrintLine();
            VerticalLine right = new VerticalLine(119, 1, 20, '|');
            right.PrintLine();
        }
    }
}