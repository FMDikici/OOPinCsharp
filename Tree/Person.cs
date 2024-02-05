using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    // Person sınıfı, IComparable<T> arayüzünü uygular
    public class Person : IComparable<Person>
    {
        // Kişinin adını temsil eden özellik
        public string Name { get; set; }

        // Kişinin soyadını temsil eden özellik
        public string Surname { get; set; }

        // Kişinin özel kimlik numarasını temsil eden private alan
        private long id;

        // Person sınıfının kurucu metodu
        public Person(string name, string surname, long id)
        {
            // Kurucu metod aracılığıyla ad, soyad ve kimlik numarası atanır
            Name = name;
            Surname = surname;
            this.id = id;
        }

        // Kişinin özel kimlik numarasını döndüren metot
        public long GetId()
        {
            return id;
        }

        // IComparable<T> arayüzünden miras alınan CompareTo metodu
        public int CompareTo(Person other)
        {
            // Soyadları karşılaştır
            int result = Surname.CompareTo(other.Surname);

            // Eğer soyadları eşitse, isimleri karşılaştır
            if (result == 0)
            {
                result = Name.CompareTo(other.Name);
            }

            // Karşılaştırma sonucunu döndür
            return result;
        }
    }
}

