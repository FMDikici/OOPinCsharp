using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace futboloyunu
{
    internal class Defans: IFutbolcularinYetenekleri1
    {
        public string SutDene()
        {
            return "Futbolcu şut çekti(Defans)!";
        }
        public string PasVer()
        {
            return "Oyuncuya pas attı!!(Def";
        }
        public string GolAt()
        {
            return "Topu filelere gönderdi!";
        }
    }
}
