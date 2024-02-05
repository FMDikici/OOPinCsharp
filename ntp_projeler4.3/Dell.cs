using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ntp_projeler4._2
{
    public class Dell : Laptop
    {
        public Dell(string islemci, int ramGB, double ramMHZ, string anakart, string disk, double ekranBoyut) : base(islemci, ramGB, ramMHZ, anakart, disk, ekranBoyut)
        {
            // İşlemci, RAM miktarı, RAM hızı, anakart, disk ve ekran boyutu, Laptop sınıfının constructor'ına geçirildi.
        }

        public int DellFiyatHesapla()
        {
            int toplamFiyat = 0;

            // RAM fiyatı hesaplanır.
            int ramFiyati = HesaplaRamFiyati(ramGB);
            toplamFiyat += ramFiyati;

            int ramHizFiyati = HesaplaRamHizFiyati(4200);
            toplamFiyat += ramHizFiyati;

            // İşlemci fiyatı hesaplanır.
            int islemciFiyati = HesaplaIslemciFiyati(1); // Dell bilgisayarlar sadece i3 işlemci ile gelir.
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

            Console.WriteLine("DELL Urun Katolog Ozellikleri Disinda Ozellik Ekleme");
            EkstraRamSor();

            return toplamFiyat;
        }
    }
}