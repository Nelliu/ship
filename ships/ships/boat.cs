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
        List<boatList> rotatedBoatsUp = new List<boatList>();

        public boat()
        {
            boats.Add(new boatList
            {                           // basic boat
                type = 0,
                width = 1,
                
                
            });
            boats.Add( new boatList
            {                          // 2 tile boat
                type = 1,
                width = 2,
                row = 0,
                
                
            });
            boats.Add(new boatList
            {                          // 3 tile, with 3 tile row under
                type = 2,
                width = 3,
                row = 3,
                
            });




                                                        // Adding rotated boats when first rotation - UP
            rotatedBoatsUp.Add(new boatList
            {
                type = 1,
                width = 1,
                row = 1
            });
            rotatedBoatsUp.Add(new boatList
            {
                type = 2,
                width = 2,
                row = 2,
                row1 = 2
            });



        }


        public boatList returnShip(int a)
        {
            return boats[a];
        }
        public boatList rotation(int a)
        {
            return rotatedBoatsUp[a];
        }
    }


}
