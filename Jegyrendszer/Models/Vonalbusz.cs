using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jegyrendszer.Models
{
    internal class Vonalbusz : Jegy
    {
        public Vonalbusz(int alapdij, int megtettKm) : base(alapdij, megtettKm)
        {
            Alapdij = 450;
            MegtettKm = megtettKm;
        }

        public override int arSzamitas()
        {
            return Alapdij + (MegtettKm * 30);
        }
    }
}
