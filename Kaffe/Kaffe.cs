using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaffe
{
    public abstract class Kaffe
    {
        // abstract - Skal overskrives
        public abstract int Pris();

        // virtual - Kan overskrives
        public virtual string Styrke()
        {
            return "Stærk";
        }

        /// <summary>
        /// Rabat, der gives på kaffe
        /// </summary>
        public int Rabat { get; set; }

        public Kaffe()
        {
            Rabat = 0;
        }

        public Kaffe(int rabat)
        {
            Rabat = rabat;
        }
    }
}
