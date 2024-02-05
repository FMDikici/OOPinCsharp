using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Channels;
using System.Windows.Forms;
using Chess.Pieces;

namespace Chess
{
    public interface ISquare
    {
        int X { get; set; }
        int Y { get; set; }
        Piece Piece { get; set; }

        event EventHandler ClickEvent;

        void SelectSquare(); // Kare seçildiğinde kullanılır.
        void SelectEnemySquare(); // Düşman kare seçildiğinde kullanılır.
        void UnSelectSquare(); // Seçili olan kareyi iptal etmek için kullanılır.
        bool IsPieceWhite(); // Karede beyaz bir taş var mı yok mu kontrol eder.
    }

    public class Square : PictureBox, ISquare
    {
        private int x;
        private int y;
        private Piece piece;
        private bool selected = false;
        private BoardPanel boardPanel;

        public Square(int x, int y, BoardPanel boardPanel)
        {
            this.x = x;
            this.y = y;
            this.boardPanel = boardPanel;
            Location = new Point(x * 80, y * 80);
            Size = new Size(80, 80);

            BackColor = Color.Transparent;
            this.Click += new EventHandler(SquareClick);
        }

        public event EventHandler ClickEvent;

        private void SquareClick(object sender, EventArgs e)
        {
            ClickEvent?.Invoke(this, EventArgs.Empty);
            boardPanel.OnClick(x, y);
        }

        public void SelectSquare()
        {
            selected = true;
            Image = Textures.Dot; // Textures sınıfına uygun bir referans ekleyin
        }

        public void SelectEnemySquare()
        {
            selected = true;
            Image = Textures.Attack; // Textures sınıfına uygun bir referans ekleyin
        }

        public void UnSelectSquare()
        {
            if (selected)
            {
                selected = false;
                Image = null;
            }
        }

        public bool IsPieceWhite()
        {
            return piece?.IsWhite ?? false;
        }

        public int X
        {
            get => x;
            set => x = value;
        }

        public int Y
        {
            get => y;
            set => y = value;
        }

        public Piece Piece
        {
            get => piece;
            set
            {
                piece = value;
                if (piece == null)
                {
                    BackgroundImage = null;
                }
                else
                {
                    BackgroundImage = piece.Texture();
                }
            }
        }
    }
}