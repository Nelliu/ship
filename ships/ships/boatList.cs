using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ships
{
    class boatList
    {
        List<boattype> boats = new List<boattype>();
        List<boattype> rotatedboat1 = new List<boattype>();
    

        public boatList()
        {
            boats.Add(new boattype {
                boattyp = 0,
                Row0 = 1,
                R0posY0 = 1
               
            });
            boats.Add(new boattype
            {
                boattyp = 1,
                Row0 = 1,
                R0posY0 = 1,
                R0posY1 = 1,
                
            });
            boats.Add(new boattype {
                boattyp = 2,
                Row0 = 1,
                R0posY0 = 1,
                R0posY1 = 1,
                R0posY2 = 1,
    
            });
            boats.Add(new boattype {
                boattyp = 3,                // HYDROPLANE
                Row0 = 1,
                Row1 = 1,
                R0posY0 = -1,
                R0posY1 = 1,
                R1posY0 = 1,
                R1posY2 = 1
            });

            boats.Add(new boattype {
                boattyp = 4,
                Row0 = 1,
                Row1 = 1,
                Row2 = 1,

                R0posY0 = -1,
                R0posY1 = 1,
                R1posY0 = 1,
                R1posY1 = 1,
                R1posY2 = 1,
                R2posY1 = 1,
                

            });




            rotatedboat1.Add(new boattype
            {
                boattyp = 1,
                Row0 = 1,
                Row1 = 1,
                R0posY1 = 0,
                R0posY0 = 1,
                R1posY0 = 1
            });






        }


        public boattype returnShip(int a)
        {
            return boats[a];
        }
        
        public boattype RotatedShip1(int a)
        {
            return rotatedboat1[a];
        }
    }


}
