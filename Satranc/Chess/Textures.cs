using System;
using System.Drawing;
using Chess.Pieces;

namespace Chess
{
    public static class Textures
    {
        public static Image BlackPawn = new Bitmap(Properties.Resources.blackPawn);
        public static Image BlackRook = new Bitmap(Properties.Resources.blackRook);
        public static Image BlackBishop = new Bitmap(Properties.Resources.blackBishop);
        public static Image BlackKnight = new Bitmap(Properties.Resources.blackKnight);
        public static Image BlackKing = new Bitmap(Properties.Resources.blackKing);
        public static Image BlackQueen = new Bitmap(Properties.Resources.blackQueen);

        public static Image WhitePawn = new Bitmap(Properties.Resources.whitePawn);
        public static Image WhiteRook = new Bitmap(Properties.Resources.whiteRook);
        public static Image WhiteBishop = new Bitmap(Properties.Resources.whiteBishop);
        public static Image WhiteKnight = new Bitmap(Properties.Resources.whiteKnight);
        public static Image WhiteKing = new Bitmap(Properties.Resources.whiteKing);
        public static Image WhiteQueen = new Bitmap(Properties.Resources.whiteQueen);
        
        public static Image Board = new Bitmap(Properties.Resources.board);
        public static Image Blank = new Bitmap(Properties.Resources.blank);
        public static Image Dot = new Bitmap(Properties.Resources.dot);
        public static Image Attack = new Bitmap(Properties.Resources.attack);
        public static Image[] WhiteTextures = { WhitePawn, WhiteRook, WhiteBishop, WhiteKnight, WhiteKing, WhiteQueen };
        public static Image[] BlackTextures = { BlackPawn, BlackRook, BlackBishop, BlackKnight, BlackKing, BlackQueen };

       
        public static Image Texture(this Piece piece)
        {
            int index = (int)piece.GetPieceType();
            if (piece.IsWhite)
            {
                return WhiteTextures[index];
            }
            else
            {
                return BlackTextures[index];
            }
        }
    }
}