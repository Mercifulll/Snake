using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class Point
    {
        int left;
        int top;
        char symbol;


        public Point(int left, int top, char symbol)
        {
            this.left = left;
            this.top = top;
            this.symbol = symbol;
        }


        public void PrintPoint()
        {
            Console.SetCursorPosition(left, top);
            Console.WriteLine(symbol);
        }
    }
}