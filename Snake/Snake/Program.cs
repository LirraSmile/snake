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
            Console.SetBufferSize(80, 25);
 
            // Draw frame
            HorizontalLine lineUp = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine lineDown = new HorizontalLine(0, 78, 24, '+');
            VerticalLine lineLeft = new VerticalLine(0, 24, 0, '^');
            VerticalLine lineRight = new VerticalLine(0, 24, 78, '^');

            lineUp.Drow();
            lineDown.Drow();
            lineLeft.Drow();
            lineRight.Drow();

            // Draw points

            Point p1 = new Point(1, 3, '*');
            p1.Draw();

            Point p2 = new Point(2, 4, '#');
            p2.Draw();




            Console.ReadLine();
        }

    }
}
