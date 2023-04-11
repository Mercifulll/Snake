using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class Snake : Shape
    {
        Direction direction;
        public Snake()
        {
            points = new List<Point>();
        }
        public Snake CreateSnake(int length, Point tail, Direction direction)
        {
            this.direction = direction;
            for (int i = 0; i < length; i++)
            {
                Point point = new Point(tail);
                point.SetDirection(i, direction);
                points.Add(point);
            }
            return new Snake();
        }
        public void Move()
        {
            Point tail = points.First();
            points.Remove(tail);
            Point head = new Point(points.Last());
            head.SetDirection(1, direction);
            points.Add(head);

            tail.ClearPoint();
            head.PrintPoint();
        }
        public void Press(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow)
                direction = Direction.Left;
            else if (key == ConsoleKey.RightArrow)
                direction = Direction.Right;
            else if (key == ConsoleKey.UpArrow)
                direction = Direction.Up;
            else if (key == ConsoleKey.DownArrow)
                direction = Direction.Down;
        }
        public bool Eat(Point food)
        {
            Point head = new Point(points.Last());
            head.SetDirection(1, direction);
            if (head.ComparePoints(food))
            {
                food.Symbol = head.Symbol;
                points.Add(food);
                return true;
            }
            return false;
        }
    }
}
