using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ships
{
    class map
    {
        List<Point> mapp = new List<Point>();

        public map()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int a = 0; a < 10; a++)
                {
                        mapp.Add(new Point {
                            X = i,
                            Y = a
                        });
                        
                }
                
            }
        }

        public Point ReturnFie(int c)
        {
            return mapp[c];
        }

    }
}
