using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jegyrendszer.Models
{
    internal class Gyorsvonat : Jegy
    {
        public Gyorsvonat(int alapdij, int megtettKm) : base(alapdij, megtettKm)
        {
            Alapdij = 900;
            MegtettKm = megtettKm;
        }

        public override int arSzamitas()
        {
            return Alapdij + (MegtettKm * 50);
        }
    }
}
