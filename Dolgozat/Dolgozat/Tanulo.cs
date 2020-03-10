using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolgozat
{
    class Tanulo
    {
        public string Nev { get; set; }
        public string Igazolt { get; set; }
        public string Igazolatlan { get; set; }

        public Tanulo(string n, string i, string iz)
        {
            this.Nev = n;
            this.Igazolt = i;
            this.Igazolatlan = iz;
        }
    }
}
