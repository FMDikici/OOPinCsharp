using System.Collections.Generic;

namespace Chess.Pieces
{
    public abstract class Piece
    {
        private bool _killed = false;
        private bool _isWhite = false;

        public Piece(bool isWhite)
        {
            _isWhite = isWhite;
        }
        


        /// <summary>
        /// True if piece is killed, false if not
        /// </summary>
        public bool Killed
        {
            get => _killed;
            set => _killed = value;
        }

        /// <summary>
        /// True if piece is white, false if black
        /// </summary>
        public bool IsWhite
        {
            get => _isWhite;
            set => _isWhite = value;
        }
        
        public abstract List<(int, int)> GetMoves(Game game, int x, int y);

        public abstract PieceType GetPieceType();



    }
}