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

        public char Symbol
        {
            get { return symbol; }
            set { symbol = value; }
        }
        public Point(Point tail)
        {
            left = tail.left;
            top = tail.top;
            symbol = tail.symbol;
        }

        public Point(int left, int top, char symbol)
        {
            this.left = left;
            this.top = top;
            this.symbol = symbol;
        }

        public void SetDirection(int i, Direction direction)
        {
            switch (direction)
            {
                case Direction.Right:
                    left = left + i;
                    break;
                case Direction.Left:
                    left = left - i;
                    break;
                case Direction.Up:
                    top = top - i;
                    break;
                case Direction.Down:
                    top = top + i;
                    break;
            }
        }

        internal void ClearPoint()
        {
            symbol = ' ';
            PrintPoint();
        }

        public void PrintPoint()
        {
            Console.SetCursorPosition(left, top);
            Console.WriteLine(symbol);
        }

        public bool ComparePoints(Point point)
        {
            return point.left == left && point.top == top;
        }
    }
}
