using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ships
{
    class retab
    {
        List<string> abc = new List<string>();
       

        public retab()
        {
            abc.Add("A");
            abc.Add("B");
            abc.Add("C");
            abc.Add("D");
            abc.Add("E");
            abc.Add("F");
            abc.Add("G");
            abc.Add("H");
            abc.Add("I");
            abc.Add("J");

        }

        public List<string> Retab()
        {
            return abc;
        }
    }
}
