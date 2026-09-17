using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jegyrendszer.Models
{
    internal class ERoller : Jegy
    {
        public ERoller(int alapdij, int megtettKm) : base(alapdij, megtettKm)
        {
            Alapdij = 0;
            MegtettKm = megtettKm;
        }

        public override int arSzamitas()
        {
            return Alapdij + (MegtettKm * 120);
        }
    }
}
