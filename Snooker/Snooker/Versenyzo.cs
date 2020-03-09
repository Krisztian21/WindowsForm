using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snooker
{
    class Versenyzo
    {
        public int Helyezes { get; set; }
        public string Nev { get; set; }
        public string Orszag { get; set; }
        public int Nyeremeny { get; set; }
        public int Szamlalo { get; set; }
        public Versenyzo(int h, string n, string o, int ny, int sz)
        {
            h = this.Helyezes;
            n = this.Nev;
            o = this.Orszag;
            ny = this.Nyeremeny;
            sz = this.Szamlalo;
        }
        public Versenyzo()
        {

        }

    }
}
