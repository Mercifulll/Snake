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

            Point food = FoodFactory.RandFood(119, 20, Convert.ToChar(176));
            food.PrintPoint();

            Snake snake = new Snake();
            snake.CreateSnake(5, new Point(5, 5, Convert.ToChar(4)), Direction.Right);
            snake.PrintLine();


            while (true)
            {
                if (line.Collision(snake))
                {
                    break;
                }
                if (snake.Eat(food))
                {
                    food = FoodFactory.RandFood(119, 20, Convert.ToChar(176));
                    food.PrintPoint();
                }
                Thread.Sleep(100);
                snake.Move();

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.Press(key.Key);
                }
            }

            Console.WriteLine("Game Over");
            //ConsoleKeyInfo key = Console.ReadKey();

        }
    }
}