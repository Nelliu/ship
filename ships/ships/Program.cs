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
            
                       
            

           
            //Console.Write(pam.ReturnFie(a).Y);
            //Console.Write(pam.ReturnFie(a).X);   // Check of x,y



            List<Point> Fiel = new List<Point>();
            map pam = new map();

            boat boatz = new boat();
            boatList boat = boatz.returnShip(1);
            int XX = 0;
            int YY = 0;

            while (true) {
                
                Console.WriteLine();

                for (int a = 0; a < 100; a++)
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    if (a == XX){
                        pam.ReturnFie(a).status++;
                        boat.posX = pam.ReturnFie(a).X + XX;
                        boat.posY = pam.ReturnFie(a).Y + YY;
                        Console.ForegroundColor = ConsoleColor.Green;
                        for (int i = 0; i < boat.width; i++)
			            {
                            Console.Write(pam.ReturnFie(boat.posX).icon);
            			}
                              
                        
                        Console.ForegroundColor = ConsoleColor.Gray;
                   
                        

                    }
                    else
                    {
                        Console.Write(pam.ReturnFie(a).icon);
                    }
              
                    


                    if (a == 9 || a == 19 || a == 29 || a == 39 || a == 49 || a == 59 || a == 69 || a == 79 || a == 89 || a == 99)
                    {
                        Console.WriteLine();
                    }
                    
                    

                }

                ConsoleKeyInfo abc = Console.ReadKey();
                if (abc.Key == ConsoleKey.DownArrow){
                    XX = XX +10;
                } else if (abc.Key == ConsoleKey.UpArrow){
                    XX = XX -10;
                } else if (abc.Key == ConsoleKey.RightArrow){
                    XX++;
                } else if(abc.Key == ConsoleKey.LeftArrow){
                    XX--;
                }

                Console.Clear();
            }

            Console.WriteLine("\n");
        }
    }
}
