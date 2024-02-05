using System;
using System.Windows.Forms;

namespace Chess
{
    public partial class PawnPromotionPicker : Form
    {
        public PawnPromotionPicker()
        {
            InitializeComponent();
        }

        private int _result;
        public int Show(bool isWhite)
        {
            Setup(isWhite);
            this.ShowDialog();
            return _result;

        }
        private void Setup(bool isWhite)
        {
            if (isWhite)
            {
                picQueen.Image = Textures.WhiteQueen;
                picKnight.Image = Textures.WhiteKnight;
                picBishop.Image = Textures.WhiteBishop;
                picRook.Image = Textures.WhiteRook;
            }
            else
            {
                picQueen.Image = Textures.BlackQueen;
                picKnight.Image = Textures.BlackKnight;
                picBishop.Image = Textures.BlackBishop;
                picRook.Image = Textures.BlackRook;
            }
        }

        private void picQueen_Click(object sender, EventArgs e)
        {
            _result = 0;
            Dispose();
        }

        private void picKnight_Click(object sender, EventArgs e)
        {
            _result = 1;
            Dispose();
        }

        private void picBishop_Click(object sender, EventArgs e)
        {
            _result = 2;
            Dispose();
        }

        private void picRook_Click(object sender, EventArgs e)
        {
            _result = 3;
            Dispose();
        }
    }
}