using Jegyrendszer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jegyrendszer
{
    internal class Program
    {
        static void Main()
        {
            List<Jegy> jegyek = new List<Jegy>();

            for (int i = 0; i < 10; i++)
            {
                Random random = new Random();
                int km = random.Next(1, 26);
                jegyek.Add(new Vonalbusz(450, km));
            }
            for (int i = 0; i < 5; i++)
            {
                Random random = new Random();
                int km = random.Next(1, 51);
                jegyek.Add(new Gyorsvonat(900, km));
            }
            for (int i = 0; i < 3; i++)
            {
                Random random = new Random();
                int km = random.Next(1, 11);
                jegyek.Add(new ERoller(0, km));
            }

            int jegyOsszeg = 0;
            foreach (Jegy jegy in jegyek)
            {
                jegyOsszeg += jegy.arSzamitas(); // "a nap teljes be *Nem* folyó bevételét"... Tanár úr, az mit tud?
            }
        }
    }
}
