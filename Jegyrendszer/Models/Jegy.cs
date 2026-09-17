using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jegyrendszer.Models
{
    internal abstract class Jegy
    {
        protected Jegy(int alapdij, int megtettKm)
        {
            Alapdij = alapdij;
            MegtettKm = megtettKm;
        }

        public int Alapdij { get; set; }
        public int MegtettKm { get; set; }

        public abstract int arSzamitas();
    }
}
