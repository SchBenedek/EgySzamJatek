using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgySzamJatek
{
    internal class Jatekos
    {
        private string nev;
        private int[] szamok = new int[10];
        public Jatekos(string nev)
        {
            this.nev = nev;
        }

        public string Nev { get => nev; set => nev = value; }
        public int[] Szamok { get => szamok; set => szamok = value; }


        public override string ToString()
        {
            return this.nev+", "+this.szamok;
        }
    }
}
