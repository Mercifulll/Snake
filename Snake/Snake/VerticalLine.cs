﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VerticalLine : Shape
    {
        public VerticalLine(int left, int top, int count, char symbol)
        {
            points = new List<Point>();
            for (int i = top; i < count; i++)
            {
                Point point = new Point(left, i, symbol);
                points.Add(point);
            }
        }
    }
}
