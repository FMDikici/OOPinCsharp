using System;
using System.Collections.Generic;

namespace ntp_projeler
{

    internal class Vehicle
    {
        //arac turu+
        //model+,yıl+,marka+,edinme tarihi+,edinilme fiyatı+ public
        //sasi no 0***9 seklnide
        //sahipler+
        public string chasissNo;
        public string model;
        public string brand;
        public DateTime year;


        public DateTime sellTime;
        public int sellPrice;
        public List<Person> Owners;

        public Vehicle(string chasissNo, string model, string brand, DateTime year)
        {
            this.chasissNo = chasissNo;
            this.model = model;
            this.brand = brand;
            this.year = year;
            this.Owners = new List<Person>();
        }

        public void sell(Person p, DateTime sellTime, int sellPrice)
        {
            Owners.Add(p);
            this.sellTime = sellTime;
            this.sellPrice = sellPrice;

        }

        public void listInfo()
        {
            string formattedChasissNo = string.Format("Şasi NO: {0}{1}{2}", chasissNo.Substring(0, 1), new string('*', chasissNo.Length - 2), chasissNo.Substring(chasissNo.Length - 2));
            Console.WriteLine(formattedChasissNo);

            Console.Write(string.Format("Son sahibi: {0} ", Owners[Owners.Count - 1].getName()));
            Console.WriteLine(Owners[Owners.Count - 1].getSurname());

            Console.Write(string.Format("Önceki sahibi: {0} ", Owners[Owners.Count - 2].getName()));
            Console.WriteLine(Owners[Owners.Count - 2].getSurname());

            Console.WriteLine(string.Format("Satış tarihi: {0}", sellTime));
            Console.WriteLine(string.Format("Satış Fiyatı: {0}", sellPrice));
            Console.WriteLine(string.Format("Aracın yılı: {0}", year));

            if (Owners.Count >= 1)
            {
                Console.WriteLine($"Bir önceki sahibinin adı: {Owners[Owners.Count - 1].getName()} {Owners[Owners.Count - 1].getSurname()}");
            }
            if (Owners.Count >= 2)
            {
                Console.WriteLine($"İkinci önceki sahibinin adı: {Owners[Owners.Count - 2].getName()} {Owners[Owners.Count - 2].getSurname()}");
            }

        }



    }
}


