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
    

        public boatList()
        {
            boats.Add(new boattype {
                Type = 20,
                Row0 = 1,
                R0posY0 = 1
               
            });
            boats.Add(new boattype
            {
                Type = 1,
                Row0 = 1,
                R0posY0 = 1,
                R0posY1 = 1,
                
            });
        }


        public boattype returnShip(int a)
        {
            return boats[a];
        }
        
    }


}
