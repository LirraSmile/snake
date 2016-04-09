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

            Point p = new Point(5, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Drow();

            FoodCreator foodCreator = new FoodCreator(80, 25, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();

            while(true)
            {
                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }
                Thread.Sleep(200);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
            }
                        
            Console.ReadLine();
        }

    }
}
