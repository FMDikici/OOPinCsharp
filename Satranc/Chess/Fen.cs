using System.Text;
using System.Windows.Forms;
using Chess.Pieces;

namespace Chess
{
    public class Fen
    {
        // Fen notasyonundan tahta durumunu oluşturan metot
        public static Piece[][] Fen2Board(string fenPiecePlacement)
        {
            var board = new Piece[8][];
            for (var i = 0; i < 8; i++)
            {
                board[i] = new Piece[8];
            }

            int x = 0, y = 0;
            foreach (var c in fenPiecePlacement.ToCharArray())
            {
                Piece newPiece = null;

                switch (c)
                {
                    // Siyah piyon
                    case 'p':
                        newPiece = new Pawn(false);
                        break;
                    // Siyah kale
                    case 'r':
                        newPiece = new Rook(false);
                        break;
                    // Siyah at
                    case 'n':
                        newPiece = new Knight(false);
                        break;
                    // Siyah fil
                    case 'b':
                        newPiece = new Bishop(false);
                        break;
                    // Siyah vezir
                    case 'q':
                        newPiece = new Queen(false);
                        break;
                    // Siyah şah
                    case 'k':
                        newPiece = new King(false);
                        break;

                    // Beyaz piyon
                    case 'P':
                        newPiece = new Pawn(true);
                        break;
                    // Beyaz kale
                    case 'R':
                        newPiece = new Rook(true);
                        break;
                    // Beyaz at
                    case 'N':
                        newPiece = new Knight(true);
                        break;
                    // Beyaz fil
                    case 'B':
                        newPiece = new Bishop(true);
                        break;
                    // Beyaz vezir
                    case 'Q':
                        newPiece = new Queen(true);
                        break;
                    // Beyaz şah
                    case 'K':
                        newPiece = new King(true);
                        break;

                    // Satır sona erdikten sonra yeni satıra geçme
                    case '/':
                        x = 0;
                        y++;
                        break;

                    // Boşluk karakterlerini atlayarak null kareler oluşturma
                    default:
                        x += c - '0';
                        break;
                }

                if (newPiece != null)
                {
                    board[y][x] = newPiece;
                    x++;
                }
            }
            return board;
        }

        // Oyun durumunu Fen notasyonuna çeviren metot
        public static string Game2Fen(Game game)
        {
            var board = game.GetBoard();
            StringBuilder sb = new StringBuilder();
            int blank = 0;

            // Tahtadaki pozisyon
            for (int y = 0; y < 8; y++)
            {
                for (int x = 0; x < 8; x++)
                {
                    if (game.IsOccupied(x, y))
                    {
                        if (blank != 0)
                        {
                            sb.Append(blank);
                            blank = 0;
                        }
                        switch (board[y][x].GetPieceType())
                        {
                            case PieceType.Pawn:
                                sb.Append(board[y][x].IsWhite ? "P" : "p");
                                break;
                            case PieceType.Rook:
                                sb.Append(board[y][x].IsWhite ? "R" : "r");
                                break;
                            case PieceType.Knight:
                                sb.Append(board[y][x].IsWhite ? "N" : "n");
                                break;
                            case PieceType.Bishop:
                                sb.Append(board[y][x].IsWhite ? "B" : "b");
                                break;
                            case PieceType.Queen:
                                sb.Append(board[y][x].IsWhite ? "Q" : "q");
                                break;
                            case PieceType.King:
                                sb.Append(board[y][x].IsWhite ? "K" : "k");
                                break;
                        }
                    }
                    else
                    {
                        blank++;
                    }
                }
                if (blank != 0)
                {
                    sb.Append(blank);
                    blank = 0;
                }

                if (y != 7)
                {
                    sb.Append("/");
                }
            }

            sb.Append(" ");
            // Sıradaki taraf
            sb.Append(game.IsWhiteTurn ? "w" : "b");
            sb.Append(" ");

            // Roçalar
            if (game.KingCastle[1])
            {
                sb.Append(game.RookCastle[1][1] ? "K" : "-");
                sb.Append(game.RookCastle[1][0] ? "Q" : "-");
            }
            if (game.KingCastle[0])
            {
                sb.Append(game.RookCastle[0][1] ? "k" : "-");
                sb.Append(game.RookCastle[0][0] ? "q" : "-");
            }
            sb.Append(" ");

            // İleri alınabilir piyon
            sb.Append(game.GetMoveByCoordinatesList(game.EnPassant));
            sb.Append(" ");

            // Yarı hamle sayısı
            sb.Append(game.HalfMoves);
            sb.Append(" ");

            // Hamle sayısı
            sb.Append(game.Moves);
            return sb.ToString();
        }
    }
}