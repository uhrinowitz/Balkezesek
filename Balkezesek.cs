using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balkezesek
{
    class Balkezesek
    {
        public string Név { get; set; }
        public string Első { get; set; }
        public string Utolsó { get; set; }
        public int Súly { get; set; }
        public int Magasság { get; set; }

        public Balkezesek(string sor)
        {
            string[] adatok = sor.Split(';');
            Név = adatok[0];
            Első = adatok[1];
            Utolsó = adatok[2];
            Súly = int.Parse(adatok[3]);
            Magasság = int.Parse(adatok[4]);
        }
    }
}
