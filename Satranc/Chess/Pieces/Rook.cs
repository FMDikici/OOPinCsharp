using System.Collections.Generic;
using System.Drawing;

namespace Chess.Pieces
{
    public class Rook : Piece
    {
        private bool _canCastle = true;
        public Rook(bool isWhite) : base(isWhite)
        {
            
        }


        public override List<(int, int)> GetMoves(Game game, int x, int y)
        {
            List<(int, int)> moves = new List<(int, int)>();
            
            int j = 1;
            // for (int i = 0; i < 4; i++)
            // {
            
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
                
                
                
                // set up the sides
                // if (i == 0)
                // {
                //     //right
                //     kx = 1;
                //     ky = 0;
                // }
                // if (i == 1)
                // {
                //     //down
                //     kx = 0;
                //     ky = 1;
                // }
                // if (i == 2)
                // {
                //     //left
                //     kx = -1;
                //     ky = 0;
                // }
                // if (i == 3)
                // {
                //     //up
                //     kx = 0;
                //     ky = -1;
                // }
                //
                // while (!game.IsOccupied(x + (j * kx), y + (j * ky)))
                // {
                //     moves.Add((x + (j * kx),y + (j * ky)));
                //     j++;
                //     
                // }
                //
                // if (game.IsEnemy(IsWhite, x + (j * kx), y + (j * ky)))
                // {
                //     moves.Add((x + (j * kx),y + (j * ky)));
                // }
                //     
                // j = 1;

            

            return moves;
        }

        public bool CanCastle()
        {
            return _canCastle;
        }
        
        public override PieceType GetPieceType() => PieceType.Rook;
    }
}