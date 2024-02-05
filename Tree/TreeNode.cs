using Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    public class TreeNode
    {
        // Düğümdeki değeri temsil eden özellik
        public Person Value { get; set; }

        // Sol alt düğümü temsil eden özellik
        public TreeNode Left { get; set; }

        // Sağ alt düğümü temsil eden özellik
        public TreeNode Right { get; set; }

        // TreeNode sınıfının kurucu metodu
        public TreeNode(Person value)
        {
            // Düğümün değeri atanır, sol ve sağ alt düğümler başlangıçta null olarak ayarlanır
            Value = value;
            Left = null;
            Right = null;
        }

        // Binary ağaca yeni bir değer eklemek için kullanılan metot
        public void Add(Person newValue)
        {
            // Eklenen değer, mevcut düğümdeki değerden küçükse
            if (newValue.CompareTo(Value) < 0)
            {
                // Sol alt düğüm boşsa, yeni düğümü sol alt düğüm olarak ayarlar
                if (Left == null)
                {
                    Left = new TreeNode(newValue);
                }
                else
                {
                    // Sol alt düğüm doluysa, ekleme işlemini sol alt düğümde tekrarlar
                    Left.Add(newValue);
                }
            }
            else
            {
                // Eklenen değer, mevcut düğümdeki değerden büyükse
                if (Right == null)
                {
                    // Sağ alt düğüm boşsa, yeni düğümü sağ alt düğüm olarak ayarlar
                    Right = new TreeNode(newValue);
                }
                else
                {
                    // Sağ alt düğüm doluysa, ekleme işlemini sağ alt düğümde tekrarlar
                    Right.Add(newValue);
                }
            }
        }
    }

}

