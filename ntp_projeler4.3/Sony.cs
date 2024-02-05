using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ntp_projeler4._2
{
    public class Sony : Laptop
    {
        private int toplamFiyatSony; // Sony sınıfına özgü toplam fiyat

        public Sony(string islemci, int ramGB, double ramMHZ, string anakart, string disk, double ekranBoyut)
            : base(islemci, ramGB, ramMHZ, anakart, disk, ekranBoyut)
        {
            // İşlemci, RAM miktarı, RAM hızı, anakart, disk ve ekran boyutu, Laptop sınıfının constructor'ına geçirildi.
        }

        public int SonyFiyatHesapla1()
        {
            int toplamFiyat = 0; // Sony sınıfına özgü toplam fiyat

            // RAM fiyatı hesaplanır.
            int ramFiyati = HesaplaRamFiyati(ramGB);
            toplamFiyatSony += ramFiyati;

            int ramHizFiyati = HesaplaRamHizFiyati(3200);
            toplamFiyatSony += ramHizFiyati;

            // İşlemci fiyatı hesaplanır.
            int islemciFiyati = HesaplaIslemciFiyati(2); // Sony bilgisayarlar sadece i5 işlemci ile gelir.
            toplamFiyatSony += islemciFiyati;

            // Disk fiyatı hesaplanır.
            int diskFiyati = HesaplaDiskFiyati(1); // HDD disk zorunludur.
            toplamFiyatSony += diskFiyati;

            // Ekran fiyatı hesaplanır.
            int ekranFiyati = HesaplaEkranFiyati(ekranBoyut);
            toplamFiyatSony += ekranFiyati;

            // Anakart fiyatı hesaplanır.
            int anakartFiyati = HesaplaAnakartFiyati("sabit"); // Sabit anakart için fiyat 1'dir.
            toplamFiyatSony += anakartFiyati;

            Console.WriteLine("SONY Urun Katolog Ozellikleri Disinda Ozellik Ekleme");
            EkstraRamSor();

            return toplamFiyatSony;
        }
    }
}

