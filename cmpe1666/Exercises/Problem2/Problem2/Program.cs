using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using GDIDrawer;

namespace Problem2
{
    internal class Program
    {
        static CDrawer Canvas = new CDrawer();
        static void Main(string[] args)
        {
            string input;
            bool success;
            int cellSize;
            Point MousePos;
            int xPos = 0;
            int yPos = 0;
            int xCoord = 0;
            int yCoord = 0;

            //get cell size from user
            do
            {
                Console.Write("Enter cell size: ");
                input = Console.ReadLine();
                success = int.TryParse(input, out cellSize);
                if (cellSize > 100 || cellSize < 5)
                {
                    success = false;
                    Console.WriteLine("Enter a valid number between 5 and 100.");
                }
            } while (!success);

            //draw cells
            for (int x = 0; x < Canvas.m_ciWidth; x += cellSize) Canvas.AddLine(x,0,x,Canvas.m_ciWidth);
            for (int y = 0; y < Canvas.m_ciHeight; y += cellSize) Canvas.AddLine(0, y, Canvas.m_ciWidth, y);

            //mouse cell position
            while (!Console.KeyAvailable)
            {
                Canvas.GetLastMousePosition(out MousePos);
                if (!(MousePos.X == xPos) && !(MousePos.Y == yPos))
                {
                    xPos = MousePos.X;
                    yPos = MousePos.Y;
                    xCoord = xPos / cellSize;
                    yCoord = yPos / cellSize;
                    Console.WriteLine($"{xCoord},{yCoord}");
                }
            }
            Console.ReadKey();
        }
    }
}
