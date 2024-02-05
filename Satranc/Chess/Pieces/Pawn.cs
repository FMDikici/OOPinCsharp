using System;
using System.Collections.Generic;
using System.Drawing;

namespace Chess.Pieces
{
    public class Pawn : Piece
    {
        public Pawn(bool isWhite) : base(isWhite)
        {
            
        }

        public override List<(int, int)> GetMoves(Game game, int x, int y)
        {
            List<(int, int)> moves = new List<(int, int)>();
            int k = IsWhite ? -1 : 1;

            if (!game.IsOccupied(x, y + k))
            {
                moves.Add((x, y + k));
                if (y == (7 - 5 * k) / 2)
                {
                    if (!game.IsOccupied(x, y + 2 * k))
                    {
                        moves.Add((x, y + 2 * k));
                    }
                }
            }

            if (game.IsEnemy(IsWhite, x - 1, y + k))
            {
                moves.Add((x - 1, y + k));
            }

            if (game.IsEnemy(IsWhite, x + 1, y + k))
            {
                moves.Add((x + 1, y + k));
            }

            moves.AddRange(game.GetEnPassantMoves(IsWhite,x,y));
            
            return moves;
        }

        public override PieceType GetPieceType() => PieceType.Pawn;
    }
}