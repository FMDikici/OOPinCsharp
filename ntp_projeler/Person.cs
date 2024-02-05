using System;

namespace ntp_projeler
{
    internal class Person
    {
        // Kişi sınıfı tanımı

        private string tc; // Kişi T.C. kimlik numarası
        private string name; // Kişi adı
        private string surname; // Kişi soyadı
        private DateTime birthday; // Kişi doğum tarihi //datetime veritipi tarihlerde kullanmak icindir

        public object Owners { get; internal set; }

        public Person(string tc, string name, string surname, DateTime birthday)
        {
            // Kişi sınıfı kurucu yöntemi
            //binevi fonksiyon içindekileri isaretleme

            this.tc = tc;
            this.name = name;
            this.surname = surname;
            this.birthday = birthday;
        }

        public string getName()
        {
            return name; // Kişi adını getir
        }

        public string setName(string name)
        {
            this.name = name; // Kişi adını güncelle
            return name;
        }

        public string getSurname()
        {
            return surname; // Kişi soyadını getir
        }

        public string setSurname(string surname)
        {
            this.surname = surname; // Kişi soyadını güncelle
            return surname;
        }

        public DateTime getBirthday()
        {
            return birthday; // Kişi doğum tarihini getir
        }

        public DateTime setBirthday(DateTime birthday)
        {
            this.birthday = birthday; // Kişi doğum tarihini güncelle
            return birthday;
        }

        public string getTC()
        {
            return tc; // Kişi T.C. kimlik numarasını getir
            //T.C.'yi set yapmamıza gerek yok cunku tc sonradan degisemez 
        }
    }
}
