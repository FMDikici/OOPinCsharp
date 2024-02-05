using System.Collections.Generic;
using System.Drawing;

namespace Chess.Pieces
{
    public class King : Piece
    {
        private bool _canCastle = true;
        public King(bool isWhite) : base(isWhite)
        {
            
        }

        public void test()
        {
            
        }

        public override List<(int, int)> GetMoves(Game game, int x, int y)
        {
            List<(int, int)> moves = new List<(int, int)>();

            
            for (int kx = -1; kx <= 1; kx= kx+2)
            {
                for (int j = -1; j < 2; j++)
                {
                    if (!game.IsOccupied(x + kx, y + 1*j) || game.IsEnemy(IsWhite,x + kx, y + 1*j))
                    {
                        moves.Add((x + kx, y + 1*j));
                    }
                }
            }
            for (int ky = -1; ky <= 1; ky = ky +2)
            {
                if (!game.IsOccupied(x, y+ky) || game.IsEnemy(IsWhite,x, y+ky))
                {
                    moves.Add((x, y + ky));
                }
            }
            // Check for Castle
            moves.AddRange(game.GetCastleMoves(IsWhite));
            
            
            //TODO шах и пат
            return moves;
        }

        // public List<(int, int)> GetMoves(Game game, int x, int y, bool test)
        // {
        //     List<(int, int)> moves = new List<(int, int)>();
        //     return moves;
        // }
        public override PieceType GetPieceType() => PieceType.King;
    }
}