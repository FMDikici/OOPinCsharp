using System;

namespace ntp_projeler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 4 araç için döngü oluşturma
            for (int j = 0; j < 4; j++)
            {
                int i = 0;
                Console.WriteLine("Araç Bilgilerini giriniz:");
                Console.Write("Şasi Numarası: ");
                string chasissNo = Console.ReadLine();
                Console.Write("Model: ");
                string model = Console.ReadLine();
                Console.Write("Marka: ");
                string brand = Console.ReadLine();
                Console.Write("Yıl (örneğin 2020): ");
                int year = int.Parse(Console.ReadLine());

                // Araç oluşturma ve kişi sayısını belirleme
                Vehicle vehicle = new Vehicle(chasissNo, model, brand, new DateTime(year, 1, 1));

                if (j == 0) { i = 4; }
                else if (j == 1) { i = 6; }
                else if (j == 2) { i = 8; }
                else if (j == 3) { i = 6; }

                // Kişi bilgilerini ve satış bilgilerini almak için döngü oluşturma
                for (int k = 0; k < i; k++)
                {
                    Console.WriteLine("Kişi Bilgilerini giriniz:");
                    Console.Write("T.C. Kimlik Numarası: ");
                    string tc = Console.ReadLine();
                    Console.Write("Ad: ");
                    string name = Console.ReadLine();
                    Console.Write("Soyad: ");
                    string surname = Console.ReadLine();
                    Console.Write("Doğum Tarihi (örneğin 1980-01-15): ");
                    DateTime birthday = DateTime.Parse(Console.ReadLine());

                    // Kişi oluşturma
                    Person person = new Person(tc, name, surname, birthday);

                    Console.WriteLine("Satış Bilgilerini giriniz:");
                    Console.Write("Satış Zamanı (örneğin 2023-10-14): ");
                    DateTime sellTime = DateTime.Parse(Console.ReadLine());
                    Console.Write("Satış Fiyatı: ");
                    int sellPrice = int.Parse(Console.ReadLine());

                    // Araç satışı
                    vehicle.sell(person, sellTime, sellPrice);
                }

                Console.WriteLine("Araç Bilgileri:");
                // Araç bilgilerini listeleme
                vehicle.listInfo();
            }

           

            // Programı sonlandırma-ekranda tutma
            Console.ReadKey();
        }
    }
}
