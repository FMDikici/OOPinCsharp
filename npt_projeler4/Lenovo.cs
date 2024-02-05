using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ntp_projeler4._2
{
    public class Lenovo : Laptop
    {
        public Lenovo(string islemci, int ramGB, double ramMHZ, string anakart, string disk, double ekranBoyut) : base(islemci, ramGB, ramMHZ, anakart, disk, ekranBoyut)
        {
            // İşlemci, RAM miktarı, RAM hızı, anakart, disk ve ekran boyutu, Laptop sınıfının constructor'ına geçirildi.
        }

        public int LenovofiyatHesapla()
        {
            int toplamFiyat = 0;

            // RAM fiyatı hesaplanır.
            int ramFiyati = HesaplaRamFiyati(ramGB);
            toplamFiyat += ramFiyati;

            int ramHizFiyati = HesaplaRamHizFiyati(3200);
            toplamFiyat += ramHizFiyati;

            // İşlemci fiyatı hesaplanır.
            int islemciFiyati = HesaplaIslemciFiyati(1); // Lenovo bilgisayarlar sadece i7 işlemci ile gelir.
            toplamFiyat += islemciFiyati;

            // Disk fiyatı hesaplanır.
            int diskFiyati = HesaplaDiskFiyati(2); // SSD disk zorunludur.
            toplamFiyat += diskFiyati;

            // Ekran fiyatı hesaplanır.
            int ekranFiyati = HesaplaEkranFiyati(ekranBoyut);
            toplamFiyat += ekranFiyati;

            // Anakart fiyatı hesaplanır.
            int anakartFiyati = HesaplaAnakartFiyati("sabit"); // Sabit anakart için fiyat 1'dir.
            toplamFiyat += anakartFiyati;

            // Kullanıcıya ekstra RAM eklemesi konusunda bilgi veriliyor.
            Console.WriteLine("LENOVO Urun Katolog Ozellikleri Disinda Ozellik Ekleme");
            EkstraRamSor();

            return toplamFiyat;
        }
    }
}

