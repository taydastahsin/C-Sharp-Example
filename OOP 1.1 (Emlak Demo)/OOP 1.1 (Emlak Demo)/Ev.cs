using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_1._1__Emlak_Demo_
{
    class Ev
    {
        public string turu { get; set; }
       public  string renk { get; set; }
        public int  kat { get; set; }
       public  int oda { get; set; }

       public string evigöster()
        {
            return turu;
        }

    }
}
