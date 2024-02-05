using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ntp_projeler4._2
{
    public class Asus : Laptop
    {
        public Asus(string islemci, int ramGB, double ramMHZ, string anakart, string disk, double ekranBoyut) : base(islemci, ramGB, ramMHZ, anakart, disk, ekranBoyut)
        {
            // İşlemci, RAM miktarı, RAM hızı, anakart, disk ve ekran boyutu, Laptop sınıfının constructor'ına geçirildi.
        }

        public int AsusFiyatHesapla()
        {
            int toplamFiyat = 0;

            // RAM fiyatı hesaplanır.
            int ramFiyati = HesaplaRamFiyati(ramGB);
            toplamFiyat += ramFiyati;

            int ramHizFiyati = HesaplaRamHizFiyati(4200); 
            toplamFiyat += ramHizFiyati;

            // İşlemci fiyatı hesaplanır.
            int islemciFiyati = HesaplaIslemciFiyati(3); // Asus bilgisayarlar sadece i7 işlemci ile gelir.
            toplamFiyat += islemciFiyati;

            // Disk fiyatı hesaplanır.
            int diskFiyati = HesaplaDiskFiyati(2); 
            toplamFiyat += diskFiyati;

            // Ekran fiyatı hesaplanır.
            int ekranFiyati = HesaplaEkranFiyati(ekranBoyut);
            toplamFiyat += ekranFiyati;

            // Anakart fiyatı hesaplanır.
            int anakartFiyati = HesaplaAnakartFiyati("sabit"); // Sabit anakart için fiyat 1'dir.
            toplamFiyat += anakartFiyati;

            Console.WriteLine("ASUS Urun Katolog Ozellikleri Disinda Ozellik Ekleme");
            EkstraRamSor();

            return toplamFiyat;
        }
    }
}
