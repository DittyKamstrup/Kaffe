using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaffe
{
    public class Cortado : Kaffe , Imælk
    {
        /// <summary>
        /// Hvor meget mælk skal bruges til Cortado
        /// </summary>
        /// <returns></returns>
        public int mlMælk()
        {
            return 25;
        }

        /// <summary>
        /// Prisen på Cortado
        /// </summary>
        /// <returns></returns>
        public override int Pris()
        {
            return 25;
        }
    }
}
