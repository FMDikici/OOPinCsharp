using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Chess.Pieces
{
    public class Bishop : Piece
    {
        public Bishop(bool isWhite) : base(isWhite)
        {
            

        }
        public override List<(int, int)> GetMoves(Game game, int x, int y)
        {
            List<(int, int)> moves = new List<(int, int)>();
            
            // the side where the bishop will go (up-right,up-left etc)
            //int kx = 0, ky = 0;
            // how far is the square
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
            
            // for (int i = 0; i < 4; i++)
            // {
            //     // set up the side
            //     if (i == 0)
            //     {
            //         //down-right
            //         kx = 1;
            //         ky = 1;
            //     }
            //     if (i == 1)
            //     {
            //         //down-left
            //         kx = -1;
            //         ky = 1;
            //     }
            //     if (i == 2)
            //     {
            //         //up-right                    
            //         kx = 1;
            //         ky = -1;
            //     }
            //     if (i == 3)
            //     {
            //         //up-left
            //         kx = -1;
            //         ky = -1;
            //     }
            //
            //     while (!game.IsOccupied(x + (j * kx), y + (j * ky)))
            //     {
            //         moves.Add((x + (j * kx),y + (j * ky)));
            //         j++;
            //         
            //     }
            //
            //     if (game.IsEnemy(IsWhite, x + (j * kx), y + (j * ky)))
            //     {
            //         moves.Add((x + (j * kx),y + (j * ky)));
            //     }
            //         
            //     j = 1;
            //
            // }

            return moves;
        }

        public override PieceType GetPieceType() => PieceType.Bishop;
    }
}