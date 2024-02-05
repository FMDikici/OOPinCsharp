using System.Collections.Generic;
using System.Drawing;

namespace Chess.Pieces
{
    public class Queen : Piece
    {
        public Queen(bool isWhite) : base(isWhite)
        {
            
        }

        public override List<(int, int)> GetMoves(Game game, int x, int y)
        {
            List<(int, int)> moves = new List<(int, int)>();
            
            //bishop's diagonals
            int j = 1;

            int[] numList = { -1, 1 }; 
            foreach (int kx in numList)
            {
                foreach (int ky in numList)
                {
                    while (!game.IsOccupied(x + (j * kx), y + (j * ky)))
                    {
                        moves.Add((x + (j * kx),y + (j * ky)));
                        j++;
                    
                    }

                    if (game.IsEnemy(IsWhite, x + (j * kx), y + (j * ky)))
                    {
                        moves.Add((x + (j * kx),y + (j * ky)));
                    }
                    
                    j = 1;
                }
            }
            
            
            //rook's straights
            //right and left
            for (int kx = -1; kx <= 1; kx = kx + 2)
            {
                while (!game.IsOccupied(x + (j * kx), y))
                {
                    moves.Add((x + (j * kx),y));
                    j++;
                    
                }
                
                if (game.IsEnemy(IsWhite, x + (j * kx), y))
                {
                    moves.Add((x + (j * kx),y));
                }
                    
                j = 1;
            }
            // up and down
            for (int ky = -1; ky <= 1; ky = ky + 2)
            {
                while (!game.IsOccupied(x, y + (j * ky)))
                {
                    moves.Add((x,y + (j * ky)));
                    j++;
                    
                }
                
                if (game.IsEnemy(IsWhite, x, y + (j * ky)))
                {
                    moves.Add((x,y + (j * ky)));
                }
                    
                j = 1;
            }

            return moves;
            //throw new System.NotImplementedException();
        }

        public override PieceType GetPieceType() => PieceType.Queen;
    }
}