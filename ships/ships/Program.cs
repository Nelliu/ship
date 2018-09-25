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
            boatList boat = boatz.returnShip(2);
            int XX = 0;
            int YY = 0;

            while (true) {
                
                Console.WriteLine();

                for (int a = 0; a < 100; a++)
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    if (a == XX){
                        
                        boat.posX = pam.ReturnFie(a).X ;
                        boat.posY = pam.ReturnFie(a).Y ;
                        Console.ForegroundColor = ConsoleColor.Green;
                        for (int i = 0; i < boat.width; i++)
			            {
                            Console.Write(pam.ReturnFie(boat.posX).icon);
                            
            			}
                        if (boat.width > 1)
                        {
                            a = a + (boat.width );
                        }   
                        
                        
                        
                        Console.ForegroundColor = ConsoleColor.Gray;

                    }
                    if (boat.row != 0)
                    {
                        if (a == XX + 10)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            for (int i = 0; i < boat.row; i++)
                            {
                                Console.Write(pam.ReturnFie(boat.posX).icon);

                            }
                            a = a + boat.row;
                            Console.ForegroundColor = ConsoleColor.Gray;
                        }
                        
                        
                    }
                    if (pam.ReturnFie(a).status == 1)
                    {
                        for (int i = 0; i < boat.width; i++)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write(pam.ReturnFie(a).icon);
                            Console.ForegroundColor = ConsoleColor.Gray;
                        }
                        if (boat.width > 1)
                        {
                            a = a + (boat.width - 1);
                        }                      
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
                if (abc.Key == ConsoleKey.DownArrow) {
                    if(XX == 90 || XX == 91 || XX == 92 || XX == 93 || XX == 94 || XX == 95 || XX == 96 || XX == 97 || XX == 98 || XX == 99)
                    {

                    }
                    else
                    {
                        XX = XX + 10;
                    }
                    
                } else if (abc.Key == ConsoleKey.UpArrow) {
                    if (XX == 0 || XX == 1 || XX == 2 || XX == 3 || XX == 4 || XX == 5 || XX == 6 || XX == 7 || XX == 8 || XX == 9)
                    {

                    }
                    else
                    {
                        XX = XX - 10;
                    }
                } else if (abc.Key == ConsoleKey.RightArrow) {
                    if(XX == 7 || XX == 17 || XX == 27 || XX == 37 || XX == 47 || XX == 57 || XX == 67 || XX == 77 || XX == 87 || XX == 97)
                    {
                        
                    }
                    else
                    {
                        XX++;
                        YY++;
                    }
                    
                } else if (abc.Key == ConsoleKey.LeftArrow) {
                    if (XX == 00 || XX == 10 || XX == 20 || XX == 30 || XX == 40 || XX == 50 || XX == 60 || XX == 70 || XX == 80 || XX == 90)
                    {

                    }
                    else
                    {
                        XX--;
                        YY--;
                    }
                } else if (abc.Key == ConsoleKey.Enter)
                {
                    
                    if (pam.ReturnFie(XX).status != 1)
                    {
                        pam.ReturnFie(XX).status = 1;
                    } else if (pam.ReturnFie(XX).status == 1)
                    {
                        pam.ReturnFie(XX).status = 0;
                    }
                }

                Console.Clear();
                Console.WriteLine(XX);
            }

            Console.WriteLine("\n");
        }
    }
}
