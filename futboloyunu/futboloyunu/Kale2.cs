using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace futboloyunu
{
    // Kale2 sınıfı, KalecininYetenekleri arayüzünü uygular
    internal class Kale2 : KalecininYetenekleri
    {
        // Rastgele sayı üretmek için kullanılacak nesne
        private Random random;

        // A takımın skorunu tutacak değişken
        private int puan;

        // Parametresiz kurucu metot
        public Kale2()
        {
            // Rastgele sayı üretmek ve skoru sıfırlamak için başlangıç değerleri atanır
            random = new Random();
            puan = 0;
        }

        // A takımının gol durumunu kontrol eden metot
        public string GolDurumu()
        {
            // 1 ile 100 arasında rastgele bir sayı oluşturma
            int randomGol = random.Next(1, 101);

            // Oluşturulan sayı %40'tan küçükse gol olur
            if (randomGol <= 40)
            {
                puan++;
                return "Gol oldu! A Takım Skor:" + puan;
            }
            else
            {
                return "Gol olmadı. A Takım Skor:" + puan;
            }
        }

        // Kalecinin topu tuttuğunu belirten metot
        public string TopuTut()
        {
            return "Kaleci topu tuttu, gol değil!";
        }

        // Kalecinin topu attığını belirten metot
        public string TopuAt()
        {
            return "Kaleci topu fırlattı!";
        }
    }

}
