using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autok
{
    class Autok
    {
        public string Rendszam { get; set; }
        public string Marka { get; set; }
        public string Tipus { get; set; }
        public int Evjarat  { get; set; }
        public string Uzemanyag { get; set; }

        public Autok(string rsz, string marka, string tip, int aj, string uz)
        {
            this.Rendszam = rsz;
            this.Marka = marka;
            this.Tipus = tip;
            this.Evjarat = aj;
            this.Uzemanyag = uz;
        }
         public string Kiir()
        {
            return $"{this.Rendszam}, {this.Marka}, {this.Tipus}, {this.Evjarat}, {this.Uzemanyag}";
        }
     }
}
