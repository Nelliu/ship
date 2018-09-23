using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ships
{
    class boat
    {
        List<boatList> boats = new List<boatList>();

        public boat()
        {
            boats.Add(new boatList {              // basic boat
                type = 0,
                width = 1,
                posX = 0,
                posY = 0
                
            });
            boats.Add( new boatList{
                type = 1,
                width = 2,
                row = 0,
                posX = 0,
                posY = 0
            });
        }


        public boatList returnShip(int a)
        {
            return boats[a];
        }
    }


}
