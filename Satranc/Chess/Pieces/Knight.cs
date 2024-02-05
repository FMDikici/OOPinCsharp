using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Chess.Pieces
{
    public class Knight : Piece
    {
        public Knight(bool isWhite) : base(isWhite)
        {
            
        }

        public override List<(int, int)> GetMoves(Game game, int x, int y)
        {
            List<(int, int)> moves = new List<(int, int)>();

            //left and right
            for (int kx = -2; kx <= 2; kx= kx+4)
            {
                for (int j = -1; j <= 1; j = j +2)
                {
                    if (!game.IsOccupied(x + kx, y + 1*j) || game.IsEnemy(IsWhite,x + kx, y + 1*j))
                    {
                        moves.Add((x + kx, y + 1*j));
                    }
                }
            }
            //up and down
            for (int ky = -2; ky <= 2; ky= ky+4)
            {
                for (int j = -1; j <= 1; j = j +2)
                {
                    if (!game.IsOccupied(x + 1*j, y+ky) || game.IsEnemy(IsWhite,x + 1*j, y+ky))
                    {
                        moves.Add((x + 1*j, y+ky));
                    }
                }
            }
            return moves;
        }

        public override PieceType GetPieceType() => PieceType.Knight;
    }
}