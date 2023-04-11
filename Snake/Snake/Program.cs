using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

            Snake snake = new Snake();
            snake.CreateSnake(5, new Point(5, 5, Convert.ToChar(4)), Direction.Right);
            snake.PrintLine();

            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(100);
                snake.Move();
            }
        }
    }
}