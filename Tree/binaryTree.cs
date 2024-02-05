using Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    public class BinaryTree
    {
        // Kök düğümü temsil eden özellik
        public TreeNode Root { get; set; }

        // BinaryTree sınıfının kurucu metodu
        public BinaryTree()
        {
            // Başlangıçta kök düğümü null olarak ayarlanır
            Root = null;
        }

        // Binary ağaca yeni bir değer eklemek için kullanılan metot
        public void Add(Person value)
        {
            // Eğer kök düğüm null ise, yeni düğümü kök olarak ayarlar
            if (Root == null)
            {
                Root = new TreeNode(value);
            }
            else
            {
                // Kök düğüm null değilse, ekleme işlemini TreeNode sınıfındaki Add metodu ile devam ettirir
                Root.Add(value);
            }
        }

        // Binary ağacı ziyaret ederek düğümleri sıralayan metot
        public void Traverse(TreeNode node)
        {
            // Eğer düğüm null değilse, inorder gezinme yapılır
            if (node != null)
            {
                // Sol alt ağacı ziyaret et
                Traverse(node.Left);

                // Düğümün değerini ekrana yazdır
                Console.WriteLine(node.Value.Name + " " + node.Value.Surname + " " + node.Value.GetId());

                // Sağ alt ağacı ziyaret et
                Traverse(node.Right);
            }
        }
    }
}



