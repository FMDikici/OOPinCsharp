using Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    internal class Program
    {
        static void Main()
        {
            // Binary ağaç oluşturulur
            BinaryTree peopleTree = new BinaryTree();

            // Ağaca kişiler eklenir
            peopleTree.Add(new Person("Aylin", "Yılmaz", 25684971234));
            peopleTree.Add(new Person("Baran", "Kaya", 96584321876));
            peopleTree.Add(new Person("Ceren", "Aksoy", 78459632145));
            peopleTree.Add(new Person("Deniz", "Arslan", 63259847123));
            peopleTree.Add(new Person("Emre", "Demir", 12345678901));
            peopleTree.Add(new Person("Funda", "Kocaman", 98765432109));
            peopleTree.Add(new Person("Gökhan", "Türkmen", 34567210987));
            peopleTree.Add(new Person("Hande", "Doğan", 56789012345));
            peopleTree.Add(new Person("İpek", "Yıldız", 87654321098));
            peopleTree.Add(new Person("Jale", "Çetin", 43210987654));
            peopleTree.Add(new Person("Kaan", "Yalçın", 10987654321));
            peopleTree.Add(new Person("Leyla", "Atalay", 87654321012));
            peopleTree.Add(new Person("Murat", "Demirbaş", 56789012343));
            peopleTree.Add(new Person("Nihan", "Kılıç", 23456789090));
            peopleTree.Add(new Person("Onur", "Korkmaz", 87654321098));
            peopleTree.Add(new Person("Pınar", "Başaran", 98765432109));
            peopleTree.Add(new Person("Rüzgar", "Aktaş", 87654321011));
            peopleTree.Add(new Person("Sibel", "Erdoğan", 87654321012));
            peopleTree.Add(new Person("Tamer", "Yılmaz", 12345678909));
            peopleTree.Add(new Person("Ümit", "Avcı", 34567890123));
            peopleTree.Add(new Person("Vildan", "Durmaz", 87654321011));
            peopleTree.Add(new Person("Yavuz", "Karahan", 98765432109));
            peopleTree.Add(new Person("Zeynep", "Şenol", 87654321011));

            // Ağaç üzerinde inorder gezinme yapılır ve kişiler ekrana yazdırılır
            peopleTree.Traverse(peopleTree.Root);

            // Kullanıcının ekrandaki çıktıyı görmesi için bekleme yapılır
            Console.ReadLine();
        }

    }
}
