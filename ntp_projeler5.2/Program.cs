using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ntp_projeler5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random(); // Rastgele sayı üretmek için Random sınıfı kullanılır

            // Ana kart ve sanal kartları oluştur
            KrediKarti anaKart = new KrediKarti(20000, "Ana Kart");
            Sanal ulasimKarti = new Sanal(3500, "Ulasim Kart");
            Sanal eglenceKarti = new Sanal(3500, "Eglence Kart");
            Sanal giyimKarti = new Sanal(3500, "Giyim Kart");
            Sanal yemekKarti = new Sanal(3500, "Yemek Kart");

            // 4 kez rastgele harcama yapılır
            for (int i = 1; i < 6; i++)
            {
                // Rastgele harcama tutarları oluştur
                int ulasimRandom = random.Next(251);    // 0 ile 250 arasında rastgele bir tutar
                int eglenceRandom = random.Next(501);    // 0 ile 500 arasında rastgele bir tutar
                int giyimRandom = random.Next(2001);     // 0 ile 2000 arasında rastgele bir tutar
                int yemekRandom = random.Next(1001);     // 0 ile 1000 arasında rastgele bir tutar

                // Sanal kartlara rastgele harcama yapılır
                ulasimKarti.HarcamaYap(ulasimRandom);
                eglenceKarti.HarcamaYap(eglenceRandom);
                giyimKarti.HarcamaYap(giyimRandom);
                yemekKarti.HarcamaYap(yemekRandom);

                // Ana kart, sanal kartlara yapılan harcamaların toplamını yapar
                anaKart.HarcamaYap(ulasimRandom + eglenceRandom + giyimRandom + yemekRandom);
            }

            // Kullanıcıdan alınan input ile 4 kez kendi harcamalarını yazabilir

            Console.WriteLine("\nAylık Ekstreler:\n");

            // Kart ekstreleri ekrana yazdırılır
            anaKart.EkstreyiGoster();
            ulasimKarti.EkstreyiGoster();
            eglenceKarti.EkstreyiGoster();
            giyimKarti.EkstreyiGoster();
            yemekKarti.EkstreyiGoster();
            anaKart.EkstreyiGoster(); // Ana kartın ekstresi tekrar yazdırılır

            Console.ReadKey(); // Kullanıcıdan bir tuşa basması beklenir
        }
    }

}
