using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ntp_projeler4._2
{
    public class Laptop
    {
        public string secim { get; set; }
        public int ramGB { get; set; }
        public double ramMHZ { get; set; }
        public int ramEkle { get; set; }
        public string anakart { get; set; }
        public string disk { get; set; }
        public double ekranBoyut { get; set; }
        private int toplamFiyat;

        public Laptop(string islemci, int ramGB, double ramMHZ, string anakart, string disk, double ekranBoyut)
        {
            this.secim = islemci;
            this.ramGB = ramGB;
            this.ramMHZ = ramMHZ;
            this.anakart = anakart;
            this.disk = disk;
            this.ekranBoyut = ekranBoyut;
            this.ramEkle = 0; // Başlangıçta eklenen RAM miktarı 0 olarak başlasın.
        }

        public int HesaplaRamFiyati(int ramGB)
        {
            int sonuc = ramGB * 3;
            return sonuc;
        }

        public int HesaplaRamHizFiyati(double ramMHZ)
        {
            if (ramMHZ == 2400)
            {
                return 0; // 2400MHz hızı baz alındığı için ekstra ücret yok.
            }
            else if (ramMHZ == 3200)
            {
                return 20;
            }
            else if (ramMHZ == 4200)
            {
                return 40;
            }
            else
            {
                Console.WriteLine("Hatalı giriş");
                return 0; // Hatalı giriş işlemi
            }
        }



        public int HesaplaIslemciFiyati(int secim)
        {
            if (secim == 1) // i3 işlemcidir
            {
                return 100;
            }
            else if (secim == 2)
            {
                return 140;
            }
            else if (secim == 3)
            {
                return 190;
            }
            else
            {
                return 0;
            }
        }

        public int HesaplaDiskFiyati(int secim)
        {
            if (secim == 1) // HDD
            {
                return 35;
            }
            else if (secim == 2) // SSD
            {
                return 80;
            }
            else
            {
                return 0;
            }
        }

        public int HesaplaEkranFiyati(double ekranBoyut)
        {
            if (ekranBoyut == 15.6)
            {
                return 50;
            }
            else if (ekranBoyut == 17.3)
            {
                return 100;
            }
            else
            {
                return 0; // Geçersiz ekran boyutu.
            }
        }

        public int HesaplaAnakartFiyati(string secim)
        {
            if (secim == "sabit")
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public void OzellikleriGoster()
        {
            Console.WriteLine("İşlemci: " + secim);
            Console.WriteLine("RAM (GB): " + ramGB);
            Console.WriteLine("RAM Hızı (MHz): " + ramMHZ);
            Console.WriteLine("Anakart: " + anakart);
            Console.WriteLine("Disk: " + disk);
            Console.WriteLine("Ekran Boyutu: " + ekranBoyut + "\"");
        }

        public void EkstraRamSor()
        {
            Console.WriteLine("Ekstra RAM eklemek ister misiniz? (Evet/Hayır)");
            string cevap = Console.ReadLine();

            if (cevap.Equals("Evet", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Kaç GB RAM eklemek istersiniz?");
                int eklenenRamGB = Convert.ToInt32(Console.ReadLine());
                EkstraRamEkle(eklenenRamGB);
            }
        }

        public void EkstraRamEkle(int eklenenRamGB)
        {
            if (eklenenRamGB > 0)
            {
                // Mevcut RAM miktarına eklenen RAM miktarını ekleyin.
                ramGB += eklenenRamGB;

                // Fiyatı güncelleyin (örneğin her 1 GB için 20$ ekleyin).
                int eklenenRamFiyati = eklenenRamGB * 20; // 1 GB için 20$ olarak varsayalım
                toplamFiyat += eklenenRamFiyati;

                Console.WriteLine(eklenenRamGB + " GB RAM eklenmiştir. Yeni toplam RAM: " + ramGB + " GB");
                Console.WriteLine("Toplam fiyat: " + toplamFiyat + "$");
            }
            else
            {
                Console.WriteLine("Geçerli bir RAM miktarı girilmedi.");
            }
        }






    }
}
