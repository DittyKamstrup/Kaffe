using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaffe
{
    public class SortKaffe : Kaffe
    {
        public override int Pris()
        {
            int prisMedRabat = 20 - Rabat;

            if (prisMedRabat <= 0)
                throw new ArgumentException("Du kan ikke give en rabat på 20 eller derover!");

            return prisMedRabat;
        }

        public SortKaffe()
        {
        }

        public SortKaffe(int rabat)
            : base(rabat)
        {

        }
    }
}
