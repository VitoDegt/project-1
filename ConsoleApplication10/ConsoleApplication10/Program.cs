using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NConsoleGraphics;
using System.Threading;

namespace ConsoleApplication10
{
    class Program
    {
        static void Main(string[] args)
        {
            

            ConsoleGraphics graphics = new ConsoleGraphics();
            
            int xMouse = Input.MouseX;
            int yMouse = Input.MouseY;
            int x=100, y=100, w = 100, h = 100;
            while (true)
            {

                if (Input.IsKeyDown(Keys.LEFT))
                {
                    x -= 10;
                }
                if (Input.IsKeyDown(Keys.RIGHT))
                {
                    x += 10;
                }
                if (Input.IsKeyDown(Keys.UP))
                {
                    y -= 10;
                } 
                if (Input.IsKeyDown(Keys.DOWN))
                {
                    y += 10;
                }


                if (Input.IsKeyDown(Keys.UP) && y < 10)
                {
                   y = 10;
                }
                if (Input.IsKeyDown(Keys.DOWN) && y > 370)
                {
                   y = 370;
                }

                if (Input.IsKeyDown(Keys.LEFT) && x < 5)
                {
                  x = 5;
                }
                if (Input.IsKeyDown(Keys.RIGHT) && x > 850)
                {
                    x = 850;
                }


                graphics.FillRectangle(0xFF000000, 0, 0,graphics.ClientWidth, graphics.ClientHeight);

                graphics.FillRectangle(0xFFFF0000, x, y, w, h);
                
                if (xMouse==x && yMouse == y)
                {
                    graphics.FillRectangle(0x00FF00, x, y, w, h);
                } 
                
                
                
                graphics.FlipPages();
                Thread.Sleep(10);
            }
        }
    }
}
