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
            map pam2 = new map();
            map pam1p = new map();
            map pam2p = new map();
            int round = 1;
            boatList boat = new boatList();
           
            
            List<int> enableships = new List<int>() { 0, 0, 1, 1, 2, 3, 4 };
            List<boattype> ships1 = new List<boattype>();
            List<boattype> ships2 = new List<boattype>();
            List<boattype> shotp1 = new List<boattype>();
            List<boattype> shotp2 = new List<boattype>();

            bool addingboat1 = false;
            int shiptyp1 = 0;
            int shiptyp2 = 0;
            int p1fshot = 0;
            int p2fshot = 0;
            bool oneboat = true;
            int boatnumb = -1;
            int boatnumb2 = -1;
            int shotnumb = -1;
            int shotnumb2 = -1;
            bool fplayChoose = true;
            bool splayChoose = true;
            bool fplayshooting = true;
            bool splayshooting = true;
            bool anothershot = true;
            void removestatus1()
            {
                for (int i = 0; i < 100; i++)
                {
                    if (pam2.ReturnFie(i).status == 1)
                    {
                        pam2.ReturnFie(i).status = 0;
                    }
                }
            }
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
            void removeshotstat()
            {
                for (int i = 0; i < 100; i++)
                {
                    if (pam1p.ReturnFie(i).status == 2)
                    {
                        pam1p.ReturnFie(i).status = 0;
                    }
                }
            }

            int once = 0;
            int twice = 0;
            while (true)
            {
                bool oncepressed = true;
                while (fplayChoose)
                {
                    int howmanyships = enableships.Count();



                    boattype rotboats = boat.RotatedShip1(0);
                    boattype boats = boat.returnShip(enableships[shiptyp1]);
                    if (once == 1)
                    {
                        rotboats = boat.returnShip(enableships[shiptyp1]);
                        once = 0;
                    }





                    for (int a = 0; a < 100; a++)
                    {
                        if (round == 1)
                        {
                            if (addingboat1 == true)
                            {
                                boats.R0posY0 = pam.ReturnFie(a).Y;
                                boats.R0posX = pam.ReturnFie(a).X;
                                //pam.ReturnFie(a).status = 0;
                                //pam.ReturnFie(a).status = 1;
                                //round++;

                                ships1.Add(new boattype
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
                                addingboat1 = false;
                                Console.WriteLine(ships1.Count());
                                Console.WriteLine();
                                Console.WriteLine(ships1[0].R0posY0);

                            }



                            if (ships1.Count() != 0)
                            {

                                for (int i = 0; i < ships1.Count(); i++)
                                {
                                    if (ships1[i].R0posX == pam.ReturnFie(a).X && ships1[i].R0posY0 == pam.ReturnFie(a).Y)
                                    {
                                        int truepos = a;
                                        if (ships1[i].State != 1)
                                        {
                                            if (ships1[i].boattyp < 3)
                                            {

                                                if (ships1[i].R0posY0 != -1)
                                                {
                                                    pam.ReturnFie(truepos).status = 1;

                                                }
                                            }



                                            if (ships1[i].R0posY1 != 0)
                                            {
                                                pam.ReturnFie(truepos + 1).status = 1;
                                            }

                                            if (ships1[i].R0posY2 != 0)
                                            {
                                                pam.ReturnFie(truepos + 2).status = 1;
                                            }
                                            if (ships1[i].Row1 != 0)
                                            {
                                                if (ships1[i].R1posY0 != 0)
                                                {
                                                    pam.ReturnFie(truepos + 10).status = 1;
                                                }
                                                if (ships1[i].R1posY1 != 0)
                                                {
                                                    pam.ReturnFie(truepos + 11).status = 1;
                                                }
                                                if (ships1[i].R1posY2 != 0)
                                                {
                                                    pam.ReturnFie(truepos + 12).status = 1;
                                                }
                                            }
                                            if (ships1[i].Row2 == 1)
                                            {


                                                if (ships1[i].R2posY0 != 0)
                                                {
                                                    pam.ReturnFie(truepos + 20).status = 1;
                                                }
                                                if (ships1[i].R2posY1 != 0)
                                                {
                                                    pam.ReturnFie(truepos + 21).status = 1;
                                                }
                                                if (ships1[i].R2posY2 != 0)
                                                {
                                                    pam.ReturnFie(truepos + 22).status = 1;
                                                }

                                            }
                                        }
                                        else if (ships1[i].State == 1)
                                        {
                                            if (ships1[i].boattyp < 3)
                                            {

                                                if (ships1[i].R0posY0 != -1)
                                                {
                                                    pam.ReturnFie(truepos).status = 2;

                                                }
                                            }



                                            if (ships1[i].R0posY1 != 0)
                                            {
                                                pam.ReturnFie(truepos + 1).status = 2;
                                            }

                                            if (ships1[i].R0posY2 != 0)
                                            {
                                                pam.ReturnFie(truepos + 2).status = 2;
                                            }
                                            if (ships1[i].Row1 != 0)
                                            {
                                                if (ships1[i].R1posY0 != 0)
                                                {
                                                    pam.ReturnFie(truepos + 10).status = 2;
                                                }
                                                if (ships1[i].R1posY1 != 0)
                                                {
                                                    pam.ReturnFie(truepos + 11).status = 2;
                                                }
                                                if (ships1[i].R1posY2 != 0)
                                                {
                                                    pam.ReturnFie(truepos + 12).status = 2;
                                                }
                                            }
                                            if (ships1[i].Row2 == 1)
                                            {


                                                if (ships1[i].R2posY0 != 0)
                                                {
                                                    pam.ReturnFie(truepos + 20).status = 2;
                                                }
                                                if (ships1[i].R2posY1 != 0)
                                                {
                                                    pam.ReturnFie(truepos + 21).status = 2;
                                                }
                                                if (ships1[i].R2posY2 != 0)
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
                            if (oncepressed == true)
                            {
                                addingboat1 = true;
                                round = 1;
                                oneboat = false;
                                oncepressed = false;
                            }

                        }
                    }
                    else if (abc.Key == ConsoleKey.DownArrow)
                    {
                        try
                        {
                            removestatus();
                            ships1[boatnumb].R0posX++;
                        }
                        catch (Exception)
                        {
                        }
                    }
                    else if (abc.Key == ConsoleKey.UpArrow)
                    {
                        try
                        {
                            removestatus();
                            ships1[boatnumb].R0posX--;
                        }
                        catch (Exception)
                        {


                        }


                    }
                    else if (abc.Key == ConsoleKey.RightArrow)
                    {
                        try
                        {
                            removestatus();
                            ships1[boatnumb].R0posY0++;
                        }
                        catch (Exception)
                        {


                        }

                    }
                    else if (abc.Key == ConsoleKey.LeftArrow)
                    {
                        try
                        {
                            removestatus();
                            ships1[boatnumb].R0posY0--;
                        }
                        catch (Exception)
                        {


                        }

                    }
                    else if (abc.Key == ConsoleKey.R)
                    {
                        try
                        {
                            if (ships1[boatnumb].boattyp == 2)
                            {
                                if (ships1[boatnumb].State == 1)
                                {

                                }
                                else if (ships1[boatnumb].State == 0)
                                {
                                    ships1[boatnumb] = rotboats;
                                    once++;
                                }
                            }
                        }
                        catch (Exception)
                        {


                        }



                    }
                    else if (abc.Key == ConsoleKey.Enter)
                    {
                        try
                        {

                            ships1[boatnumb].State = 1;
                            
                            oneboat = true;
                            addingboat1 = true;
                            round = 1;
                            if ( shiptyp1 + 1 >= howmanyships)
                            {
                                fplayChoose = false;
                            }
                            else
                            {
                                shiptyp1++;
                            }
                        }
                        catch (Exception)
                        {


                        }


                    }
                }    // first player choosing boats positions
                while (splayChoose)       // second player ^^
                {
                    int howmanyships = enableships.Count();



                    boattype rotboats = boat.RotatedShip1(0);
                    boattype boats = boat.returnShip(enableships[shiptyp2]);
                    if (twice == 1)
                    {
                        rotboats = boat.returnShip(enableships[shiptyp2]);
                        twice = 0;
                    }






                    for (int a = 0; a < 100; a++)
                    {



                        if (round == 1)
                        {



                            if (addingboat1 == true)
                            {
                                boats.R0posY0 = pam2.ReturnFie(a).Y;
                                boats.R0posX = pam2.ReturnFie(a).X;
                                //pam.ReturnFie(a).status = 0;
                                //pam.ReturnFie(a).status = 1;
                                //round++;

                                ships2.Add(new boattype
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
                                boatnumb2++;
                                addingboat1 = false;
                                Console.WriteLine(ships2.Count());
                                Console.WriteLine();
                                Console.WriteLine(ships2[0].R0posY0);

                            }



                            if (ships2.Count() != 0)
                            {

                                for (int i = 0; i < ships2.Count(); i++)
                                {
                                    if (ships2[i].R0posX == pam2.ReturnFie(a).X && ships2[i].R0posY0 == pam2.ReturnFie(a).Y)
                                    {
                                        int truepos = a;
                                        if (ships2[i].State != 1)
                                        {
                                            if (ships2[i].boattyp < 3)
                                            {

                                                if (ships2[i].R0posY0 != -1)
                                                {
                                                    pam2.ReturnFie(truepos).status = 1;
                                                    ships2[i].R0posY0 = pam2.ReturnFie(truepos).Y;
                                                    ships2[i].R0posX = pam2.ReturnFie(truepos).X;

                                                }
                                            }

                                           

                                            if (ships2[i].R0posY1 != 0)
                                            {
                                                pam2.ReturnFie(truepos + 1).status = 1;
                                                ships2[i].R0posY1 = pam2.ReturnFie(truepos + 1).Y;
                                            }

                                            if (ships2[i].R0posY2 != 0)
                                            {
                                                pam2.ReturnFie(truepos + 2).status = 1;
                                                ships2[i].R0posY2 = pam2.ReturnFie(truepos + 2).Y;
                                            }
                                            if (ships2[i].Row1 != 0)
                                            {
                                                if (ships2[i].R1posY0 != 0)
                                                {
                                                    pam2.ReturnFie(truepos + 10).status = 1;
                                                    ships2[i].R1posY0 = pam2.ReturnFie(truepos + 10).Y;
                                                    ships2[i].R1posX = pam2.ReturnFie(truepos + 10).X;
                                                }
                                                if (ships2[i].R1posY1 != 0)
                                                {
                                                    pam2.ReturnFie(truepos + 11).status = 1;
                                                    ships2[i].R1posY1 = pam2.ReturnFie(truepos + 11).Y;

                                                }
                                                if (ships2[i].R1posY2 != 0)
                                                {
                                                    pam2.ReturnFie(truepos + 12).status = 1;
                                                    ships2[i].R1posY2 = pam2.ReturnFie(truepos + 12).Y;
                                                }
                                            }
                                            if (ships2[i].Row2 == 1)
                                            {


                                                if (ships2[i].R2posY0 != 0)
                                                {
                                                    pam2.ReturnFie(truepos + 20).status = 1;
                                                    ships2[i].R2posY0 = pam2.ReturnFie(truepos + 20).Y;
                                                    ships2[i].R2posX = pam2.ReturnFie(truepos + 20).X;
                                                }
                                                if (ships2[i].R2posY1 != 0)
                                                {
                                                    pam2.ReturnFie(truepos + 21).status = 1;
                                                    ships2[i].R2posY1 = pam2.ReturnFie(truepos + 21).Y;
                                                }
                                                if (ships2[i].R2posY2 != 0)
                                                {
                                                    pam2.ReturnFie(truepos + 22).status = 1;
                                                    ships2[i].R2posY2 = pam2.ReturnFie(truepos + 22).Y;
                                                }

                                            }
                                        }
                                        else if (ships2[i].State == 1)
                                        {
                                            if (ships2[i].boattyp < 3)
                                            {

                                                if (ships2[i].R0posY0 != -1)
                                                {
                                                    pam2.ReturnFie(truepos).status = 2;

                                                }
                                            }



                                            if (ships2[i].R0posY1 != 0)
                                            {
                                                pam2.ReturnFie(truepos + 1).status = 2;
                                            }

                                            if (ships2[i].R0posY2 != 0)
                                            {
                                                pam2.ReturnFie(truepos + 2).status = 2;
                                            }
                                            if (ships2[i].Row1 != 0)
                                            {
                                                if (ships2[i].R1posY0 != 0)
                                                {
                                                    pam2.ReturnFie(truepos + 10).status = 2;
                                                    ships2[i].R1posY0 = pam2.ReturnFie(truepos + 10).Y;
                                                    ships2[i].R1posX = pam2.ReturnFie(truepos + 10).X;

                                                }
                                                if (ships2[i].R1posY1 != 0)
                                                {
                                                    pam2.ReturnFie(truepos + 11).status = 2;
                                                    
                                                }
                                                if (ships2[i].R1posY2 != 0)
                                                {
                                                    pam2.ReturnFie(truepos + 12).status = 2;

                                                }
                                            }
                                            if (ships2[i].Row2 == 1)
                                            {


                                                if (ships2[i].R2posY0 != 0)
                                                {
                                                    pam2.ReturnFie(truepos + 20).status = 2;
                                                }
                                                if (ships2[i].R2posY1 != 0)
                                                {
                                                    pam2.ReturnFie(truepos + 21).status = 2;
                                                }
                                                if (ships2[i].R2posY2 != 0)
                                                {
                                                    pam2.ReturnFie(truepos + 22).status = 2;
                                                }

                                            }
                                        }
                                    }

                                }



                            }


                        }

                        if (pam2.ReturnFie(a).status == 1)
                        {

                            Console.ForegroundColor = ConsoleColor.Yellow;
                            //Console.Write(pam.ReturnFie(a).X);
                            //Console.Write(pam.ReturnFie(a).Y);
                            Console.Write(pam.ReturnFie(a).icon);
                            Console.ForegroundColor = ConsoleColor.Gray;

                        }
                        else if (pam2.ReturnFie(a).status == 0)
                        {
                            //Console.Write(pam.ReturnFie(a).X);
                            //Console.Write(pam.ReturnFie(a).Y);
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.Write(pam2.ReturnFie(a).icon);

                        }
                        else if (pam2.ReturnFie(a).status == 2)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.Write(pam2.ReturnFie(a).icon);
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
                            if (oncepressed == true)
                            {
                                addingboat1 = true;
                                round = 1;
                                oneboat = false;
                                oncepressed = false;
                            }

                        }


                    }
                    else if (abc.Key == ConsoleKey.DownArrow)
                    {
                        try
                        {
                            removestatus1();
                            ships2[boatnumb2].R0posX++;
                        }
                        catch (Exception)
                        {


                        }






                    }
                    else if (abc.Key == ConsoleKey.UpArrow)
                    {
                        try
                        {
                            removestatus1();
                            ships2[boatnumb2].R0posX--;
                        }
                        catch (Exception)
                        {


                        }


                    }
                    else if (abc.Key == ConsoleKey.RightArrow)
                    {
                        try
                        {
                            removestatus1();
                            ships2[boatnumb2].R0posY0++;
                            
                        }
                        catch (Exception)
                        {


                        }

                    }
                    else if (abc.Key == ConsoleKey.LeftArrow)
                    {
                        try
                        {
                            removestatus1();
                            ships2[boatnumb2].R0posY0--;
                        }
                        catch (Exception)
                        {


                        }

                    }
                    else if (abc.Key == ConsoleKey.R)
                    {
                        try
                        {
                            if (ships2[boatnumb2].boattyp == 2)
                            {
                                if (ships2[boatnumb2].State == 1)
                                {

                                }
                                else if (ships2[boatnumb2].State == 0)
                                {
                                    ships2[boatnumb2] = rotboats;
                                    twice++;
                                }
                            }
                        }
                        catch (Exception)
                        {


                        }



                    }
                    else if (abc.Key == ConsoleKey.Enter)
                    {
                        try
                        {

                            ships2[boatnumb2].State = 1;
                            oneboat = true;
                            addingboat1 = true;
                            round = 1;
                            if (shiptyp2 + 1 > howmanyships || shiptyp2 + 2 > howmanyships)
                            {
                                splayChoose = false;
                            }
                            else
                            {
                                shiptyp2++;
                            }
                        }
                        catch (Exception)
                        {


                        }


                    }
                    

                }      // second player ^^
                
                while (fplayshooting)
                {


                    Console.WriteLine(pam2.ReturnFie(0).status);
                    Console.WriteLine(pam2.ReturnFie(0).X);
                    Console.WriteLine(pam2.ReturnFie(0).Y);
                    for (int i = 0; i < 100; i++)
                    {
                        if (anothershot == true)
                        {
                            shotp1.Add(new boattype
                            {
                                boattyp = 0,
                                Row0 = 1,
                                R0posY0 = 0
                            });
                            shotnumb++;
                            anothershot = false;
                        }
                        if (shotp1.Count() != 0)
                        {
                            for (int ez = 0; ez < shotp1.Count(); ez++)
                            {
                                if (shotp1[ez].R0posX == pam1p.ReturnFie(i).X && shotp1[ez].R0posY0 == pam1p.ReturnFie(i).Y)
                                {
                                    int truepos = i;
                                    if (shotp1[ez].State < 1)
                                    {
                                       
                                        

                                        if (shotp1[ez].R0posY0 != -1)
                                        {
                                            pam1p.ReturnFie(truepos).status = 2;

                                        }
                                        
                                    }
                                    else if (shotp1[ez].State == 1)
                                    {
                                        pam1p.ReturnFie(truepos).status = 3;
                                    }
                                    else if (shotp1[ez].State == 2)
                                    {
                                        pam1p.ReturnFie(truepos).status = 4;
                                    }
                                }
                            }
                        }



                        //if (p1fshot == 0)
                        //{
                        //    pam1p.ReturnFie(i).status = 2;
                        //    p1fshot++;
                        //}
                        if (pam1p.ReturnFie(i).status == 2)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write(pam1p.ReturnFie(i).icon);
                        }
                        else if (pam1p.ReturnFie(i).status == 3)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.Write(pam1p.ReturnFie(i).icon);
                        }
                        else if (pam1p.ReturnFie(i).status == 4)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(pam1p.ReturnFie(i).icon);
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.Write(pam1p.ReturnFie(i).icon);
                        }

                        
                        for (int a = 9; a < 100; a= a + 10)
                        {
                            if (i == a)
                            {
                                Console.WriteLine();
                            }
                        }
                        
                        
                    }





                    ConsoleKeyInfo abc = Console.ReadKey();
                    if (abc.Key == ConsoleKey.DownArrow)
                    {
                        try
                        {
                            removeshotstat();
                            shotp1[shotnumb].R0posX++;
                        }
                        catch (Exception)
                        {
                        }
                    }
                    else if (abc.Key == ConsoleKey.UpArrow)
                    {
                        try
                        {
                            removeshotstat();
                            shotp1[shotnumb].R0posX--;
                        }
                        catch (Exception)
                        {
                        }

                    }
                    else if (abc.Key == ConsoleKey.RightArrow)
                    {
                        try
                        {
                            removeshotstat();
                            shotp1[shotnumb].R0posY0++;
                        }
                        catch (Exception)
                        {
                        }

                    }
                    else if (abc.Key == ConsoleKey.LeftArrow)
                    {
                        try
                        {
                            removeshotstat();
                            shotp1[shotnumb].R0posY0--;
                        }
                        catch (Exception)
                        {
                        }

                    }
                    else if(abc.Key == ConsoleKey.Enter)
                    {
                        int check = 0;
                        for (int ab = 0; ab < 100; ab++)
                        {
                            if (pam2.ReturnFie(0).status == 2)
                            {

                                check++;
                            }
                            if (pam2.ReturnFie(0).X == shotp1[shotnumb].R0posX)
                            {
                                check++;
                            }
                            if (shotp1[shotnumb].R0posY0 == pam2.ReturnFie(0).Y)
                            {
                                check++;
                            }
                            if (check == 3)
                            {
                                shotp1[shotnumb].State = 2;
                            }
                            else
                            {
                                shotp1[shotnumb].State = 1;
                            }
                        }
  
                        anothershot = false;
                        
                    }


                    Console.Clear();
                    //Console.WriteLine(shotp1[shotnumb].R0posX);
                    //Console.WriteLine(shotp1[shotnumb].R0posY0);
                    //Console.WriteLine(shotp1[shotnumb].State);
                    
                    
                    
                    

                }
                while (splayshooting) // 2nd player shot
                {

                }
            }
            
        }
    }
}
