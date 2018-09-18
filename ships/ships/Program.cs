using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ships
{
    class Program
    {
        static void Main(string[] args)
        {
            retab Retabc = new retab(); 
            List<Point> Position = new List<Point>();
            int howm = 0;

                                                                // map 
            for (int sloupec = 0; sloupec < 10; sloupec++)
            {
                Console.WriteLine();
                for (int radek = 0; radek < 10; radek++)
                {
                    int all = sloupec + radek;
                    
                    if (all % 2 == 0)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkBlue;

                        
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                    }
                    Position[sloupec].X = sloupec;
                    Position[radek].Y = radek;
                    Console.Write("   ");
                }
                
            }


            Console.WriteLine("\n");
        }
    }
}
