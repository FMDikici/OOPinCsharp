using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace futboloyunu
{
    // IFutbolcularinYetenekleri1 arayüzünü uygulayan OrtaSaha sınıfı
    internal class OrtaSaha : IFutbolcularinYetenekleri1
    {
        // SutDene metodu, orta saha oyuncusunun şut denemesini temsil eder
        public string SutDene()
        {
            return "Fisek Gibi Bir Sut!";
        }

        // GolAt metodu, orta saha oyuncusunun gol atma yeteneğini temsil eder
        public string GolAt()
        {
            return "Gole Çok Yakın!!!";
        }

        // PasVer metodu, orta saha oyuncusunun pas verme yeteneğini temsil eder
        public string PasVer()
        {
            return "Pas verildi!";
        }
    }
}

