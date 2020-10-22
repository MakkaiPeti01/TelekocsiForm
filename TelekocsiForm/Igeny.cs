using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelekocsiForm
{
    class Igeny
    {
        public string Azonosito { get; private set; }
        public string Indulas { get; private set; }
        public string Cel { get; private set; }
        public int Szemelyek { get; private set; }
        public string Utvonal { get; private set; }
        public Igeny(string sor)
        {
            string[] adatok = sor.Split(';');
            Azonosito = adatok[0];
            Indulas = adatok[1];
            Cel = adatok[2];
            Szemelyek = int.Parse(adatok[3]);
        }
        public int VanAuto(List<Autok> autok)
        {
            int i = 0;
            while (i < autok.Count &&
              !(
                  Utvonal == autok[i].Utvonal &&
                  Szemelyek <= autok[i].Hely
              )
            )
            {
                i++;
            }

            if (i < autok.Count)
            {
                return i;
            }
            else
            {
                return -1;
            }
        }
    }
}
