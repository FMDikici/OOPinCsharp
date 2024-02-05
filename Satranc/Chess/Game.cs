using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Chess.Pieces;
using Chess.Properties;
using Microsoft.Win32.SafeHandles;

namespace Chess
{
    public class Game
    {
        private Piece[][] board;  // Tahtayı temsil eden 2D dizi
        private bool _isWhiteTurn = true;  // Sıranın beyaz oyuncuda olup olmadığını belirten değişken

        private Form1 _form1;  // Oyunun ana formu
        private string[] _letters = new[] { "a", "b", "c", "d", "e", "f", "g", "h" };  // Sütun harf dizisi

        private bool[] _kingCastle = new bool[] { true, true };  // Şahın rok yapabilme durumu

        private List<string> _fenStorage = new List<string>();  // FEN durumlarını saklayan liste

        private bool[][] _rookCastle = new bool[][] { new bool[] { false, false }, new bool[] { false, false } };  // Kalelerin rok yapabilme durumu

        private List<(int, int)> _enPassant = new List<(int, int)>();  // İleri alanda çift adımda atlanabilir durumu

        private int _halfMoves;  // Yarı hamle sayısı
        private int _moves;  // Hamle sayısı
        private bool _highlightSquares;  // Vurgulanmış karelerin durumu
        private bool _isPuzzle;  // Bulmaca durumu
        private List<string> _puzzleMoves;  // Bulmaca hamleleri

        public bool HighlightSquares => _highlightSquares;  // Vurgulanmış karelerin durumunu getiren özellik





        public Piece[][] GetBoard()
        {
            return board;
        }

        public Game(string fen, Form1 form1, bool highlightSquares, bool isPuzzle, List<string> puzzleMoves = null)
        {
            // FEN notasyonundaki bilgileri ayır ve oyun durumunu başlat
            string[] fenSplit = fen.Split(' ');
            board = Fen.Fen2Board(fenSplit[0]);
            _form1 = form1;

            _isWhiteTurn = fenSplit[1] == "w";

            // Rok yapabilme durumunu işaretle
            foreach (var c in fenSplit[2].ToCharArray())
            {
                switch (c)
                {
                    case 'K':
                        _rookCastle[1][1] = true;
                        break;
                    case 'Q':
                        _rookCastle[1][0] = true;
                        break;
                    case 'k':
                        _rookCastle[0][1] = true;
                        break;
                    case 'q':
                        _rookCastle[0][0] = true;
                        break;
                }
            }

            // İleri alanda çift adımla atlanabilir durumu ekleyin
            _enPassant.AddRange(GetCoordinatesByMove(fenSplit[3]));

            _halfMoves = Convert.ToInt32(fenSplit[4]);  // Yarı hamle sayısını ayarla
            _moves = Convert.ToInt32(fenSplit[5]);  // Hamle sayısını ayarla

            _highlightSquares = highlightSquares;
            _isPuzzle = isPuzzle;
            _puzzleMoves = puzzleMoves;


        }



        // Oyun durumunu FEN notasyonuna dönüştürme
        public bool IsWhiteTurn => _isWhiteTurn;  // Şu anki sıranın beyaz oyuncuda olup olmadığını getiren özellik
        public bool[] KingCastle => _kingCastle;  // Şahın rok yapabilme durumunu getiren özellik
        public bool[][] RookCastle => _rookCastle;  // Kalelerin rok yapabilme durumunu getiren özellik

        public List<(int, int)> EnPassant => _enPassant;  // İleri alanda çift adımla atlanabilir durumu getiren özellik

        public int HalfMoves => _halfMoves;  // Yarı hamle sayısını getiren özellik

        public int Moves => _moves;  // Hamle sayısını getiren özellik

        // Belirtilen konum için mümkün olan hamleleri alır
        public List<(int, int)> PossibleMoves(int x, int y)
        {
            Piece piece = board[y][x];
            if (piece == null)
            {
                return new List<(int, int)>();
            }

            if (piece.IsWhite != _isWhiteTurn)
            {
                return new List<(int, int)>();
            }

            return piece.GetMoves(this, x, y);
        }

        public void Move(int x1, int y1, int x2, int y2)
        {
            if (_isPuzzle)
            {
                if (GetMoveByCoordinates(x1,y1,x2,y2) != _puzzleMoves[_moves-1])
                {
                    _form1.DisplayMessage("Wrong Move!");
                    return;
                }
            }


            // eğer kral yakalanırsa
            if (IsOccupied(x2, y2))
            {
                if (board[y2][x2].GetPieceType() == PieceType.King)
                {
                    if (_isWhiteTurn)
                    {
                        MessageBox.Show("White won!");
                    }
                    else
                    {
                        MessageBox.Show("Black won!");
                    }
                    _form1.GameEnd();
                }
            }
            // kale hamlelerinden sonra kale
            int k = 0;
            k = _isWhiteTurn ? 1 : 0;
            int y = 0 + k * 7;
            if (board[y1][x1].GetPieceType() == PieceType.Rook)
            {
                if (x1 == 0 && y1 == y)
                {
                    _rookCastle[k][0] = false;
                }
                if (x1 == 7 && y1 == y)
                {
                    _rookCastle[k][1] = false;
                }
            }
            
            _enPassant.Clear();
            // en passant
            if (board[y1][x1].GetPieceType() == PieceType.Pawn && Math.Abs(y2 - y1) == 2)
            {
                _enPassant.Add((x2,y2));
            }



            // tüm if'ler bir hamleyle sonuçlanır
            // kale kralı
            if (board[y1][x1].GetPieceType() == PieceType.King)
            {
                if (x2 == 2 && y2 == y)
                {
                    // 0-0-0
                    AddMove("0-0-0");
                    board[y2][x2] = board[y1][x1];
                    board[y1][x1] = null;
                    board[y][3] = board[y][0];
                    board[y][0] = null;
                }
                else if (x2 == 6 && y2 == y)
                {
                    //0-0
                    AddMove("0-0");
                    board[y2][x2] = board[y1][x1];
                    board[y1][x1] = null;
                    board[y][5] = board[y][7];
                    board[y][7] = null;
                }
                else
                {
                    AddMove(GetMoveByCoordinates(x1, y1, x2, y2));
                    board[y2][x2] = board[y1][x1];
                    board[y1][x1] = null;
                }
                _kingCastle[k] = false;
            }
            // terfi
            else if (board[y1][x1].GetPieceType() == PieceType.Pawn && y2 == 0 + (1-k) * 7)
            {
                PawnPromotionPicker pwn = new PawnPromotionPicker();
                int result = pwn.Show(_isWhiteTurn);
                switch (result)
                {
                    case 0:
                        board[y2][x2] = new Queen(_isWhiteTurn);
                        break;
                    case 1:
                        board[y2][x2] = new Knight(_isWhiteTurn);
                        break;
                    case 2:
                        board[y2][x2] = new Bishop(_isWhiteTurn);
                        break;
                    case 3:
                        board[y2][x2] = new Rook(_isWhiteTurn);
                        break;
                }
                board[y1][x1] = null;
            }
            // enPassant
            else if (board[y1][x1].GetPieceType() == PieceType.Pawn && !IsOccupied(x2,y2) && Math.Abs(x2-x1)==1 && Math.Abs(y2-y1) == 1)
            {
                
                AddMove(GetMoveByCoordinates(x1, y1, x2, y2).Insert(2,"x"));
                board[y2][x2] = board[y1][x1];
                board[y1][x1] = null;
                board[y1][x1 + (x2-x1)] = null;
            }
            else
            {
                AddMove(GetMoveByCoordinates(x1, y1, x2, y2));
                board[y2][x2] = board[y1][x1];
                board[y1][x1] = null;
            }
            _isWhiteTurn = !_isWhiteTurn;
            _moves++;

            _fenStorage.Add(Fen.Game2Fen(this));



            if (_isPuzzle)
            {
                if ((_moves % 2 == 0) && _moves != _puzzleMoves.Count + 1)
                {
                    _form1.DisplayMessage("Nice Move!");
                    PlayNextMove();
                    // siyah hamle oyna
                }
                // YAPILACAKLAR çok hızlı bitiyor, belki oyunun sonu yeniden işlenebilir
                if (_moves == _puzzleMoves.Count + 1)
                {
                    MessageBox.Show("Puzzle Solved!");
                    _form1.GameEnd();
                }
            }
        }

        private void PlayNextMove()
        {
            List<int> coords = GetCoordinatesByFullMove(_puzzleMoves[_moves - 1]);
            Move(coords[0],coords[1],coords[2],coords[3]);
        }
        
        public string GetFenById(int id)
        {
            return _fenStorage[id];
        }
        public void AddMove(string move)
        {
            
            move = _moves + ": " + move;
            _form1.AddMoveToList(move);
            
        }

        public void UpdateGame(int id)
        {
            var fen = _fenStorage[id];
            string[] fenSplit = fen.Split(' ');
            board = Fen.Fen2Board(fenSplit[0]);
            _isWhiteTurn = fenSplit[1] == "w";
            
            foreach (var c in fenSplit[2].ToCharArray())
            {
                switch (c)
                {
                    case 'K':
                        _rookCastle[1][1] = true;
                        break;
                    case 'Q':
                        _rookCastle[1][0] = true;
                        break;
                    case 'k':
                        _rookCastle[0][1] = true;
                        break;
                    case 'q':
                        _rookCastle[0][0] = true;
                        break;
                }
            }
            _enPassant.AddRange(GetCoordinatesByMove(fenSplit[3]));
            _halfMoves = Convert.ToInt32(fenSplit[4]);
            _moves = Convert.ToInt32(fenSplit[5]);
            
            _fenStorage.RemoveRange(id + 1,_fenStorage.Count - (id+1));
            
        } 
        
        private string GetMoveByCoordinates(int x1, int y1, int x2, int y2)
        {
            string Move = "";
            switch (board[y1][x1].GetPieceType())
            {  
                case PieceType.Pawn:
                    break;
                case PieceType.Bishop:
                    Move += "B";
                    break;
                case PieceType.Knight:
                    Move += "N";
                    break;
                case PieceType.Rook:
                    Move += "R";
                    break;
                case PieceType.Queen:
                    Move += "Q";
                    break;
                case PieceType.King:
                    Move += "K";
                    break;
            }
            Move += _letters[x1] + (8 - y1);
            if (IsOccupied(x2, y2))
            {
                Move += "x";
            }

            Move += _letters[x2] + (8 - y2);
            // eğer kral işaretliyse "+" ekle
            return Move;
        }
        public string GetMoveByCoordinatesList(List<(int, int)> list)
        {
            if (list.Count == 0)
            {
                return "-";
            }
            string Move = "";
            int x = list[0].Item1;
            int y = list[0].Item2;
            switch (board[y][x].GetPieceType())
            {  
                case PieceType.Pawn:
                    break;
                case PieceType.Bishop:
                    Move += "B";
                    break;
                case PieceType.Knight:
                    Move += "N";
                    break;
                case PieceType.Rook:
                    Move += "R";
                    break;
                case PieceType.Queen:
                    Move += "Q";
                    break;
                case PieceType.King:
                    Move += "K";
                    break;
            }
            Move += _letters[x] + (8 - y);
            // eğer kral işaretliyse "+" ekle
            return Move;
        }
        private List<(int, int)> GetCoordinatesByMove(string move)
        {
            if (move == "-")
            {
                return new List<(int, int)>();
            }
            return new List<(int, int)>{(Array.IndexOf(_letters,move[0]),Convert.ToInt32(move[1]))};    

        }

        private List<int> GetCoordinatesByFullMove(string move)
        {
            List<int> coords = new List<int>();
            foreach (var c in move.ToCharArray())
            {
                if (c >= 'a' && c <= 'h')
                {
                    coords.Add(Array.IndexOf(_letters,char.ToString(c)));
                }

                if (char.IsDigit(c))
                {
                    coords.Add(8-( c - '0'));
                }
            }

            return coords;
        }
        

        public void SetPanel(BoardPanel boardPanel,Panel panel)
        {
            boardPanel.Location = new Point(70, 50);
            boardPanel.Size = new Size(640, 640);
            boardPanel.BackgroundImage = Textures.Board;
            panel.Controls.Add(boardPanel);
        }

        public bool IsEnemy(bool isWhite, int x,int y)
        {
            if (x < 0 || 7 < x || y < 0 || 7 < y)
            {
                return false;
            }
            
            if (board[y][x] == null)
            {
                return false;
            }

            if (board[y][x].IsWhite == isWhite)
            {
                return false;
            }

            return true;
        }
        
        public bool IsOccupied(int x,int y)
        {
            if (x < 0 || 7 < x || y < 0 || 7 < y)
            {
                return true;
            }

            if (board[y][x] == null)
            {
                return false;
            }

            return true;
        }

        public List<(int, int)> GetEnPassantMoves(bool IsWhite, int x,int y)
        {
            List<(int, int)> moves = new List<(int, int)>();
            if (_enPassant.Any())
            {
                int k = IsWhite ? -1 : 1;
                if (_enPassant[0] == (x - 1, y) && IsEnemy(IsWhite, x - 1, y))
                {
                    moves.Add((x - 1, y + k));
                }
                if (_enPassant[0] == (x + 1, y) && IsEnemy(IsWhite, x + 1, y))
                {
                    moves.Add((x + 1, y + k));
                }
            }
            return moves;
        }
        public List<(int, int)> GetCastleMoves(bool isWhite)
        {
            // 0,2  0,6
            List<(int, int)> moves = new List<(int, int)>();
            int k = 0;
            k = isWhite ? 1 : 0;
            int y = 0 + k * 7;

            if (_kingCastle[k])
            {
                if (_rookCastle[k][0] && !IsOccupied(1,y) && !IsOccupied(2,y) && !IsOccupied(3,y) )
                {
                    moves.Add((2, y));
                }
                if (_rookCastle[k][1] && !IsOccupied(5,y) && !IsOccupied(6,y))
                {
                    moves.Add((6, y));
                }
            }
            return moves;
        }
        
        
    }
}