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
            boatList boat = new boatList();
           
            bool DownArrow = false;
            List<int> enableships = new List<int>() { 0, 0, 1, 1, 2, 3, 4 };
            List<boattype> ships = new List<boattype>();

            bool addingboat = false;
            int shiptyp = 0;
            bool oneboat = true;
            int boatnumb = -1;
            void removestatus()
            {
                for (int i = 0; i < 100; i++)
                {
                    if (pam.ReturnFie(i).status == 1)
                    {
                        pam.ReturnFie(i).status = 0;
                    }
                }
            }
            
            int once = 0;
            while (true)
            {
                int howmanyships = enableships.Count();
                
                

                boattype rotboats = boat.RotatedShip1(0);
                boattype boats = boat.returnShip(enableships[shiptyp]);
                if (once == 1)
                {
                    rotboats = boat.returnShip(enableships[shiptyp]);
                    once = 0;
                }
                
                

             

                for (int a = 0; a < 100; a++)
                {


                    
                    if (round == 1)
                    {



                        if (addingboat == true)
                        {
                            boats.R0posY0 = pam.ReturnFie(a).Y;
                            boats.R0posX = pam.ReturnFie(a).X;
                            //pam.ReturnFie(a).status = 0;
                            //pam.ReturnFie(a).status = 1;
                            //round++;

                            ships.Add(new boattype
                            {
                                boattyp = boats.boattyp,
                                Row0 = boats.Row0,
                                R0posX = boats.R0posX,
                                R0posY0 = boats.R0posY0,
                                R0posY1 = boats.R0posY1,
                                R0posY2 = boats.R0posY2,
                                R1posX = boats.R1posX,
                                R1posY0 = boats.R1posY0,
                                R1posY1 = boats.R1posY1,
                                R1posY2 = boats.R1posY2,
                                R2posX = boats.R2posX,
                                R2posY0 = boats.R2posY0,
                                R2posY1 = boats.R2posY1,
                                R2posY2 = boats.R2posY2,
                                Row1 = boats.Row1,
                                Row2 = boats.Row2

                            });
                            boatnumb++;
                            addingboat = false;
                            Console.WriteLine(ships.Count());
                            Console.WriteLine();
                            Console.WriteLine(ships[0].R0posY0);
                            
                        }
                        

                        
                        if (ships.Count() != 0)
                        {
                            
                            for (int i = 0; i < ships.Count(); i++)
                            {
                                if (ships[i].R0posX == pam.ReturnFie(a).X && ships[i].R0posY0 == pam.ReturnFie(a).Y) { 
                                    int truepos = a;
                                    if (ships[i].State != 1)
                                    {
                                        if (ships[i].boattyp < 3)
                                        {

                                            if (ships[i].R0posY0 != -1)
                                            {
                                                pam.ReturnFie(truepos).status = 1;

                                            }
                                        }



                                        if (ships[i].R0posY1 != 0)
                                        {
                                            pam.ReturnFie(truepos + 1).status = 1;
                                        }

                                        if (ships[i].R0posY2 != 0)
                                        {
                                            pam.ReturnFie(truepos + 2).status = 1;
                                        }
                                        if (ships[i].Row1 != 0)
                                        {
                                            if (ships[i].R1posY0 != 0)
                                            {
                                                pam.ReturnFie(truepos + 10).status = 1;
                                            }
                                            if (ships[i].R1posY1 != 0)
                                            {
                                                pam.ReturnFie(truepos + 11).status = 1;
                                            }
                                            if (ships[i].R1posY2 != 0)
                                            {
                                                pam.ReturnFie(truepos + 12).status = 1;
                                            }
                                        }
                                        if (ships[i].Row2 == 1)
                                        {


                                            if (ships[i].R2posY0 != 0)
                                            {
                                                pam.ReturnFie(truepos + 20).status = 1;
                                            }
                                            if (ships[i].R2posY1 != 0)
                                            {
                                                pam.ReturnFie(truepos + 21).status = 1;
                                            }
                                            if (ships[i].R2posY2 != 0)
                                            {
                                                pam.ReturnFie(truepos + 22).status = 1;
                                            }

                                        }
                                    } 
                                    else if (ships[i].State == 1)
                                    {
                                        if (ships[i].boattyp < 3)
                                        {

                                            if (ships[i].R0posY0 != -1)
                                            {
                                                pam.ReturnFie(truepos).status = 2;

                                            }
                                        }



                                        if (ships[i].R0posY1 != 0)
                                        {
                                            pam.ReturnFie(truepos + 1).status = 2;
                                        }

                                        if (ships[i].R0posY2 != 0)
                                        {
                                            pam.ReturnFie(truepos + 2).status = 2;
                                        }
                                        if (ships[i].Row1 != 0)
                                        {
                                            if (ships[i].R1posY0 != 0)
                                            {
                                                pam.ReturnFie(truepos + 10).status = 2;
                                            }
                                            if (ships[i].R1posY1 != 0)
                                            {
                                                pam.ReturnFie(truepos + 11).status = 2;
                                            }
                                            if (ships[i].R1posY2 != 0)
                                            {
                                                pam.ReturnFie(truepos + 12).status = 2;
                                            }
                                        }
                                        if (ships[i].Row2 == 1)
                                        {


                                            if (ships[i].R2posY0 != 0)
                                            {
                                                pam.ReturnFie(truepos + 20).status = 2;
                                            }
                                            if (ships[i].R2posY1 != 0)
                                            {
                                                pam.ReturnFie(truepos + 21).status = 2;
                                            }
                                            if (ships[i].R2posY2 != 0)
                                            {
                                                pam.ReturnFie(truepos + 22).status = 2;
                                            }

                                        }
                                    }
                                }
                                    
                            }
                                
                            
                            
                        }


                    }
                    
                    if (pam.ReturnFie(a).status == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        //Console.Write(pam.ReturnFie(a).X);
                        //Console.Write(pam.ReturnFie(a).Y);
                        Console.Write(pam.ReturnFie(a).icon);
                        Console.ForegroundColor = ConsoleColor.Gray;

                    }
                    else if (pam.ReturnFie(a).status == 0)
                    {
                        //Console.Write(pam.ReturnFie(a).X);
                        //Console.Write(pam.ReturnFie(a).Y);
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write(pam.ReturnFie(a).icon);
                        
                    }
                    else if (pam.ReturnFie(a).status == 2)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write(pam.ReturnFie(a).icon);
                    }
                    

                    
                    for (int i = 9; i < 100; i = i + 10)
                    {
                        if (a == i)
                        {
                            Console.WriteLine();
                        }
                    }
                    //Console.WriteLine(DownArrow);
                   
                }
                Console.WriteLine();
                ConsoleKeyInfo abc = Console.ReadKey();
                

                

                Console.WriteLine();
                Console.Clear();
                if (abc.Key == ConsoleKey.D1 || abc.Key == ConsoleKey.NumPad1)
                {
                    if (oneboat == true)
                    {
                        addingboat = true;
                        round = 1;
                        oneboat = false;
                    }


                }
                else if (abc.Key == ConsoleKey.DownArrow)
                {
                    removestatus();
                    ships[boatnumb].R0posX++;





                }
                else if (abc.Key == ConsoleKey.UpArrow)
                {
                    removestatus();
                    ships[boatnumb].R0posX--;

                }
                else if (abc.Key == ConsoleKey.RightArrow)
                {
                    removestatus();
                    ships[boatnumb].R0posY0++;
                }
                else if (abc.Key == ConsoleKey.LeftArrow)
                {
                    removestatus();
                    ships[boatnumb].R0posY0--;
                }
                else if (abc.Key == ConsoleKey.R)
                {
                    if (ships[boatnumb].boattyp == 2)
                    {
                        if (ships[boatnumb].State == 1)
                        {

                        }
                        else if (ships[boatnumb].State == 0)
                        {
                            ships[boatnumb] = rotboats;
                            once++;
                        }
                    }
                    
                    
                }
                else if (abc.Key == ConsoleKey.Enter)
                {
                    ships[boatnumb].State = 1;
                    oneboat = true;
                    addingboat = true;
                    round = 1;
                    if (shiptyp+1 > howmanyships || shiptyp + 2 > howmanyships)
                    {
                        
                    }
                    else
                    {
                        shiptyp++;
                    }
                    
                }
                
            }
        }
    }
}
