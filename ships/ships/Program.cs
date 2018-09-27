/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

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

            boatList boatz = new boatList();
            
            int XX = 0;
            int YY = 0;
            int rotation = 0;
            while (true) {
                boatList boatList = boatz.returnShip(1);
                if (rotation == 1)
                {
                   boatList = boatz.rotation(0); 
                }
                
                
                Console.WriteLine();

                for (int a = 0; a < 100; a++)
                {

                    Console.ForegroundColor = ConsoleColor.Gray;
                    if (a == XX){
                        
                        boatList.posX = pam.ReturnFie(a).X ;
                        
                        boatList.posY = pam.ReturnFie(a).Y ;
                        Console.ForegroundColor = ConsoleColor.Green;
                        for (int i = 0; i < boatList.Row0; i++)
			            {
                            Console.Write(pam.ReturnFie(boatList.posX).icon);
                            
            			}
                        if (boatList.Row0 >= 1)
                        {
                            a = a + (boatList.Row0 );
                        }   
                        
                        
                        
                        Console.ForegroundColor = ConsoleColor.Gray;

                    }
                    if (boatList.Row1 != 0)
                    {
                        if (a == XX + 10)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            for (int i = 0; i < boatList.Row1; i++)
                            {

                                Console.Write(pam.ReturnFie(a).X);
                                Console.Write(pam.ReturnFie(a).Y);
                                Console.Write(pam.ReturnFie(boatList.posX).icon);

                            }
                            a = a + boatList.Row1;
                            Console.ForegroundColor = ConsoleColor.Gray;
                        }
                        
                        
                    }
                    if (boatList.Row2 != 0)
                    {
                        if (a == XX + 20)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            for (int i = 0; i < boatList.Row2; i++)
                            {
                                Console.Write(pam.ReturnFie(a).X);
                                Console.Write(pam.ReturnFie(boatList.posX).icon);
                            }
                            Console.ForegroundColor = ConsoleColor.Gray;
                        }
                    }
                    if (pam.ReturnFie(a).status == 1)
                    {
                        boatList = boatz.returnShip(1);
                        for (int i = 0; i < boatList.Row0; i++)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write(pam.ReturnFie(a).X);
                            Console.Write(pam.ReturnFie(a).Y);
                            Console.Write(pam.ReturnFie(a).icon);
                            Console.ForegroundColor = ConsoleColor.Gray;
                        }
                        if (boatList.Row0 >= 1)
                        {
                            a = a + (boatList.Row0 - 1);
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
                    if(Enumerable.Range(90, 99).Contains(XX))
                    {

                    }
                    else if (boatList.Row1 != 0)
                    {
                        if (Enumerable.Range(81, 89).Contains(XX))
                        {
                            
                        }
                        else
                        {
                            XX = XX + 10;
                        }
                        
                    }
                    else
                    {
                        XX = XX + 10;
                    }
                    
                }
                else if (abc.Key == ConsoleKey.UpArrow) {
                    if (Enumerable.Range(0, 9).Contains(XX))
                    {

                    }
                    else
                    {
                        XX = XX - 10;
                    }
                }
                else if (abc.Key == ConsoleKey.RightArrow) {
                    if(XX == 7 || XX == 17 || XX == 27 || XX == 37 || XX == 47 || XX == 57 || XX == 67 || XX == 77 || XX == 87 || XX == 97)
                    {
                        
                    }
                    else
                    {
                        XX++;
                        YY++;
                    }
                    
                }
                else if (abc.Key == ConsoleKey.LeftArrow) {
                    if (XX == 00 || XX == 10 || XX == 20 || XX == 30 || XX == 40 || XX == 50 || XX == 60 || XX == 70 || XX == 80 || XX == 90)
                    {

                    }
                    else
                    {
                        XX--;
                        YY--;
                    }
                }
                else if (abc.Key == ConsoleKey.Enter)
                {
                    
                    if (pam.ReturnFie(XX).status != 1)
                    {
                        pam.ReturnFie(XX).status = 1;
                        if (boatList.Row1 != 0)
                        {
                            pam.ReturnFie(XX + 10).status = 1;
                        } 
                        
                    }
                    else if (pam.ReturnFie(XX).status == 1)
                    {
                        pam.ReturnFie(XX).status = 0;
                    }
                }
                else if (abc.Key == ConsoleKey.R)
                {
                    if (rotation == 3)
                    {
                        rotation = 0;
                    }
                    else
                    {
                        rotation++;
                    }

                }


                Console.Clear();
                //Console.WriteLine(XX);
               

                for (int a = 0; a < 100; a++)
                {

                    Console.Write(pam.ReturnFie(a).X);
                    Console.Write(" ");
                    Console.Write(pam.ReturnFie(a).Y);
                    Console.Write("   ");
                    if (a == 9 || a == 19 || a == 29 || a == 39 || a == 49 ||a==59||a==69||a==79||a==89)
                    {
                        Console.WriteLine();
                    }
                    
                }
                Console.WriteLine();
            }

           
        }
    }
}
*/