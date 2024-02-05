using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Chess.Pieces;

namespace Chess
{
    public class BoardPanel : Panel
    {
        private Square[][] _squares;  // Tahtayı oluşturan karelerin 2D dizisi
        private Game _game;  // Oyun durumunu temsil eden Game sınıfı
        private List<(int, int)> lastPoints = new List<(int, int)>();  // Son tıklanan noktanın koordinatları
        private (int, int) lastPoint;  // Son tıklanan noktanın koordinatları

        // BoardPanel sınıfının kurucu metodu
        public BoardPanel(Game game)
        {
            _game = game;
            _squares = new Square[8][];

            // Tahtayı oluştur
            for (int y = 0; y < 8; y++)
            {
                _squares[y] = new Square[8];
                for (int x = 0; x < 8; x++)
                {
                    _squares[y][x] = new Square(x, y, this);
                    Controls.Add(_squares[y][x]);
                }
            }

            // Oyun durumunu tahtaya yansıt
            SetBoard(game.GetBoard());
        }

        // Tahta üzerinde bir kareye tıklandığında çağrılan metot
        public void OnClick(int x, int y)
        {
            // Eğer daha önce bir kare seçilmediyse veya seçilen karelerin içinde bulunmuyorsa
            if (lastPoints.Count == 0 || !lastPoints.Contains((x, y)))
            {
                // Mümkün olan hamle noktalarını al
                var points = _game.PossibleMoves(x, y);
                ClearSelectedSquares();

                // Mümkün olan hamle noktalarını tahtada vurgula
                foreach (var point in points)
                {
                    int pointX = point.Item1;
                    int pointY = point.Item2;
                    if (_game.HighlightSquares)
                    {
                        if (_game.IsOccupied(pointX, pointY))
                        {
                            if (_game.IsEnemy(_squares[y][x].IsPieceWhite(), pointX, pointY))
                            {
                                _squares[pointY][pointX].SelectEnemySquare();
                            }
                        }
                        else
                        {
                            _squares[pointY][pointX].SelectSquare();
                        }
                    }
                }

                lastPoint = (x, y);
                lastPoints = points;
            }
            else
            {
                // Seçilen kareye taşınan hamleyi gerçekleştir
                _game.Move(lastPoint.Item1, lastPoint.Item2, x, y);

                // Seçilen kareleri temizle ve tahtayı güncelle
                ClearSelectedSquares();
                SetBoard(_game.GetBoard());
                lastPoints.Clear();
                lastPoint = (x, y);
            }
        }

        // Tahta üzerindeki bir kareyi belirtilen taş ile güncelleme metodu
        public void SetBoard(Piece[][] board)
        {
            for (int y = 0; y < 8; y++)
            {
                for (int x = 0; x < 8; x++)
                {
                    _squares[y][x].Piece = board[y][x];
                }
            }
        }

        // Belirtilen koordinattaki kareyi alma metodu
        public Square GetSquare(int x, int y)
        {
            return _squares[y][x];
        }

        // Tahtadaki tüm kareleri alma metodu
        public Square[][] GetSquares()
        {
            return _squares;
        }

        // Seçilen kareleri temizleme metodu
        public void ClearSelectedSquares()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    _squares[i][j].UnSelectSquare();
                }
            }
        }
    }

}