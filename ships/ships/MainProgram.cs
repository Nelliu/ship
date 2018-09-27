using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ships
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            map pam = new map();
            int round = 1;
            while (true)
            {
                if (round == 1)
                {
                    boattype boat = new boattype();
                    //boatList boats = boat;

                    Console.WriteLine(boat.);
                }

                for (int a = 0; a < 100; a++)
                {

                    
                    Console.Write(pam.ReturnFie(a).X);
                    Console.Write(pam.ReturnFie(a).Y);
                    Console.Write("   ");

                    
                    for (int i = 9; i < 100; i = i + 10)
                    {
                        if (a == i)
                        {
                            Console.WriteLine();
                        }
                    }

                }
                Console.WriteLine();
                ConsoleKeyInfo abc = Console.ReadKey();
                Console.WriteLine();
                Console.Clear();
            }
        }
    }
}
