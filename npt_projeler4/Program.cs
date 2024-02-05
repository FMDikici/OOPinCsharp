using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ntp_projeler4._2
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıya bilgilendirme mesajları gösteriliyor.
            Console.WriteLine("Merhabalar..\nSecimlerinize Göre Fiyatlandirma Listesi..");
            Console.WriteLine("ONEMLI HATIRLATMA!!\nTum Bilgisayarlarda baz Olarak DD4 ram bulunur ama hızlari degiskenlik gosterebilir\nDell bilgisayarlarda SSD zorunludur\nSony bilgisayarla en az i5 islemci icermelidir");
            Console.WriteLine("Lenovo bilgisayarlar sadece 17.3 inc ekran ile gelir\nAsus bilgisayarlar sadece i7 islemci icerebilir\n\n\n");

            // Farklı bilgisayar modelleri oluşturuluyor.
            Lenovo lenovo1 = new Lenovo("i7", 32, 3200, "sabit", "ssd", 17.3);
            Lenovo lenovo2 = new Lenovo("i5", 16, 4200, "sabit", "hdd", 17.3);
            //17.3 zorunludur

            Dell dell1 = new Dell("i5", 24, 4200, "sabit", "ssd", 17.3);
            Dell dell2 = new Dell("i7", 16, 3200, "sabit", "ssd", 15.6);
            //ssd zorunludur

            Asus asus1 = new Asus("i7", 32, 3200, "sabit", "ssd", 17.3);
            Asus asus2 = new Asus("i7", 16, 4200, "sabit", "ssd", 15.6);
            //asus sadece i7 olabilir

            Sony sony1 = new Sony("i5", 8, 3200, "sabit", "hdd", 15.6);
            Sony sony2 = new Sony("i7", 32, 4200, "sabit", "ssd", 17.3);
            //snoy en az i5 olabilir

            // Bilgisayar fiyatları hesaplanıyor
            int lenovoFiyat1 = lenovo1.LenovofiyatHesapla();
            int lenovoFiyat2 = lenovo2.LenovofiyatHesapla();

            int dellFiyat1 = dell1.DellFiyatHesapla();
            int dellFiyat2 = dell2.DellFiyatHesapla();

            int asusFiyat1 = asus1.AsusFiyatHesapla();
            int asusFiyat2 = asus2.AsusFiyatHesapla();

            int sonyFiyat1 = sony1.SonyFiyatHesapla1();
            int sonyFiyat2 = sony2.SonyFiyatHesapla1();

            // Ekstra RAM ekleme bilgisi kullanıcıya iletiliyor.
            Console.WriteLine("\n\nEger Sonradan Ram Takilmasi İstendiyse Ucret Katolog Fiyati Haric Alinir..\nSergilenen Fiyatlar Ekstra Ram Eklenmeyen Katolog Fiyatlaridir..\n\n");

            // Bilgisayar fiyatları kullanıcıya gösteriliyor.
            Console.WriteLine("Lenovo Bilgisayar #1 Fiyat Listesi: " + lenovoFiyat1 + "$");
            Console.WriteLine("Lenovo Bilgisayar #2 Fiyat Listesi:\n " + lenovoFiyat2 + "$");

            Console.WriteLine("Dell Bilgisayar #1 Fiyat Listesi: " + dellFiyat1 + "$");
            Console.WriteLine("Dell Bilgisayar #2 Fiyat Listesi:\n " + dellFiyat2 + "$");

            Console.WriteLine("Asus Bilgisayar #1 Fiyat Listesi: " + asusFiyat1 + "$");
            Console.WriteLine("Asus Bilgisayar #2 Fiyat Listesi:\n " + asusFiyat2 + "$");

            Console.WriteLine("Sony Bilgisayar #1 Fiyat Listesi: " + sonyFiyat1 + "$");
            Console.WriteLine("Sony Bilgisayar #2 Fiyat Listesi:\n " + sonyFiyat2 + "$");

            // Kullanıcıya detay gösterme seçeneği sunuluyor.
            Console.WriteLine("Detay gormek ister misiniz?\n[1]Evet\n[2]Hayir");
            string secim = Console.ReadLine();

            if (secim == "1")
            {
                // Bilgisayar özellikleri kullanıcıya gösteriliyor.
                Console.WriteLine("\nLENOVO Bilgisayar #1 Ozellikleri");
                lenovo1.OzellikleriGoster();
                Console.WriteLine("\nLENOVO Bilgisayar #2 Ozellikleri");
                lenovo2.OzellikleriGoster();

                Console.WriteLine("\nDELL Bilgisayar #1 Ozellikleri");
                dell1.OzellikleriGoster();
                Console.WriteLine("\nDELL Bilgisayar #2 Ozellikleri");
                dell2.OzellikleriGoster();

                Console.WriteLine("\nASUS Bilgisayar #1 Ozellikleri");
                asus1.OzellikleriGoster();
                Console.WriteLine("\nASUS Bilgisayar #2 Ozellikleri");
                asus2.OzellikleriGoster();

                Console.WriteLine("\nSONY Bilgisayar #1 Ozellikleri");
                sony1.OzellikleriGoster();
                Console.WriteLine("\nSONY Bilgisayar #2 Ozellikleri");
                sony2.OzellikleriGoster();
            }
            else
            {
                Console.WriteLine("Tesekkurler");
            }

            Console.ReadKey();
        }
    }
}

