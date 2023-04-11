using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class FoodFactory
    {
        private static Random rand = new Random();
        public static Point RandFood(int width, int height, char symbol)
        {
            width = rand.Next(2, width - 2);
            height = rand.Next(2, height - 2);
            return new Point(width, height, symbol);
        }
    }
}
