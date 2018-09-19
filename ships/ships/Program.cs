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


            Console.ForegroundColor = ConsoleColor.Yellow;
            /*for (int i = 0; i < 10; i++)
            {
                
                for (int a = 0; a < 10; a++)
                {
                    Console.Write(" ■ ");
                }
                Console.WriteLine(" ■ ");
            }*/

            List<Point> Fiel = new List<Point>();
            map pam = new map();
            for (int a = 0; a < 100; a++)
            {
                
                    Console.Write(pam.ReturnFie(a).X);
                    Console.Write(pam.ReturnFie(a).Y);
                    Console.Write(" ");
                    if (a == 10 || a == 21)
                {
                    Console.WriteLine();
                }
                
            }


                                                             
            
            int abx = 0;
            int aby = 0;
            Console.WriteLine("\n\n\n");

            for (int a = 0; a < 10; a++)
            {
                abx = a;
                for (int i = 0; i < 10; i++)
                {
                    aby = i;
                    Console.Write(abx);
                    Console.Write(aby);
                    Console.Write("  ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n\n");
            Console.Write(pam.ReturnFie(50).X);
            Console.Write(pam.ReturnFie(2).Y);

            






            Console.WriteLine("\n");
        }
    }
}
