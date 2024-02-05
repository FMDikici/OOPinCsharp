using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Chess
{
    public partial class Form1 : Form
    {
        private Panel _gamePanel;
        private Label _lblConfirm;
        private Label _lblMessage;
        private ListBox _lstMoves;
        private Game game;
        private BoardPanel boardPanel;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPuzzle_Click(object sender, EventArgs e)
        {
            panelMenu.Hide();
            panelPuzzle.Show();
        }

        private void btnPuzzleBack_Click(object sender, EventArgs e)
        {
            panelPuzzle.Hide();
            panelMenu.Show();
            
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            panelMenu.Hide();
            panelSettings.Show();
        }
        
        private void btnSettingsBack_Click(object sender, EventArgs e)
        {
            panelSettings.Hide();
            panelMenu.Show();
        }

        private void btnClassic_Click(object sender, EventArgs e)
        {
            StartGame("rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq - 0 1", checkBoxHelper.Checked, false);
            // panelMenu.Hide();
            // Point loc = this.Location;
            // Size = new Size(900, 800);
            // Location = new Point(loc.X - 100, loc.Y - 100);
            //
            // _gamePanel = new Panel();
            // _gamePanel.Location = new Point(0, 0);
            // _gamePanel.Size = new Size(900, 800);
            // Controls.Add(_gamePanel);
            //
            // Button btnExit = new Button();
            // btnExit.Location = new Point(12, 12);
            // btnExit.Size = new Size(75, 50);
            // btnExit.BackColor = Control.DefaultBackColor;
            // btnExit.Text = "Exit";
            // btnExit.Click += BtnExit_Click;
            // _gamePanel.Controls.Add(btnExit);
            //
            // _lstMoves = new ListBox();
            // _lstMoves.Location = new Point(760, 225);
            // _lstMoves.Size = new Size(120, 290);
            // _lstMoves.SelectedIndexChanged += _lstMoves_SelectedIndexChanged;
            // _lstMoves.DoubleClick += _lstMoves_DoubleClick;
            // _gamePanel.Controls.Add(_lstMoves);

            // standart
            // StartGame("rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq - 0 1", checkBoxHelper.Checked, false);
            //game = new Game("rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq - 0 1", this, checkBoxHelper.Checked, false);
            
            // for castle 
            // game = new Game("r3k2r/pppppppp/8/8/8/8/PPPPPPPP/R3K2R w KQkq - 0 1", this);
            
            // quick fen castle testing
            //Game game = new Game("r3k2r/pppppppp/8/8/8/8/PPPPPPPP/R3K2R w --kq - 0 1", this);
            //Game game = new Game("rnbq1bnr/pppkpppp/8/3p4/4P3/5N2/PPPP1PPP/RNBQKB1R w KQ - 2 3");
            // boardPanel = new BoardPanel(game);
            //
            // boardPanel.Location = new Point(100, 50);
            // boardPanel.Size = new Size(640, 640);
            // boardPanel.BackgroundImage = Textures.Board;
            // _gamePanel.Controls.Add(boardPanel);

            
            
            //Game game = new Game("rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq - 0 1");
            //Game game = new Game("rnbq1bnr/pppkpppp/8/3p4/4P3/5N2/PPPP1PPP/RNBQKB1R w KQ - 2 3");
            //game.SetPanel(game.GetBoard(),_gamePanel);
            //boardPanel.SetBoard(game.GetBoard());
        }

        private void _lstMoves_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox listBox =  (ListBox)sender;
            var fen = game.GetFenById(listBox.SelectedIndex);
            //string[] fenSplit = fen.Split(' ');
            boardPanel.SetBoard(Fen.Fen2Board(fen.Split(' ')[0]));
            
        }
        
        private void _lstMoves_DoubleClick(object sender, EventArgs e)
        {
            ListBox listBox =  (ListBox)sender;
            var id = listBox.SelectedIndex;
            var count = listBox.Items.Count;
            game.UpdateGame(id);
            for (int i = id + 1; i < count; i++)
            {
                listBox.Items.RemoveAt(id+1);
            }
            
            // var fen = game.GetFenById(listBox.SelectedIndex);
            //string[] fenSplit = fen.Split(' ');
            // game = new Game(fen, this);
            //boardPanel.SetBoard(Fen.Fen2Board(fen.Split(' ')[0]));
        }

        

        public void AddMoveToList(string move)
        {
            _lstMoves.Items.Add(move);
        }

        public void DisplayMessage(string message)
        {
            _lblMessage.Text = message;
        }
        
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (!timerExit.Enabled)
            {
                _lblConfirm = new Label();
                _lblConfirm.Text = "Click Again to Confirm";
                _lblConfirm.Size = new Size(75, 50);
                _lblConfirm.Location = new Point(btn.Location.X, btn.Location.Y + 50);
                _gamePanel.Controls.Add(_lblConfirm);
                timerExit.Start();
            }
            else
            {
                timerExit.Stop();
                GameEnd();    
            }
        }
        
        private void timerExit_Tick(object sender, EventArgs e)
        {
            timerExit.Stop();
            _gamePanel.Controls.Remove(_lblConfirm);
            _lblConfirm.Dispose();
        }
        
        public void GameEnd()
        {
            _gamePanel.Dispose();
            panelMenu.Show();
            Size = new Size(750, 500);
            Point loc = this.Location;
            Location = new Point(loc.X + 100, loc.Y + 100);
        }

        // TODO
        // So, maybe we should use listbox for chess notation,
        // of perhaps two checked lists?
        // we also need to implement game2fen and the 3 special moves <3 (done)
        // and check for public and private classes
        private void btnTestForm_Click(object sender, EventArgs e)
        {
            Form frm = new testForm();
            frm.Show();
        }


        private void btnPuzzle1_Click(object sender, EventArgs e)
        {
            //47.d7 Ra8 48.Nd6+ Ke6 49.Nc8 Kxd7 50.Nxb6+ Kc7 51.Nxa8+ 1-0
            // d6d7 a5a8 e4d6 f5e6 d6c8 e6xd7 c8xb6 d7c7 b6xa8
            StartGame("8/8/1p1P4/rP3kp1/4N3/5PKP/8/8 w - - 1 1",checkBoxHelper.Checked, true, new List<string>()
            {
                "d6d7",
                "Ra5a8",
                "Ne4d6",
                "Kf5e6",
                "Nd6c8",
                "Ke6xd7",
                "Nc8xb6",
                "Kd7c7",
                "Nb6xa8"
            });
        }

        private void StartGame(string fen, bool highlightSquares, bool isPuzzle, List<string> puzzleMoves = null)
        {
            panelMenu.Hide();
            panelPuzzle.Hide();
            Point loc = this.Location;
            Size = new Size(900, 800);
            Location = new Point(loc.X - 100, loc.Y - 100);

            _gamePanel = new Panel();
            _gamePanel.Location = new Point(0, 0);
            _gamePanel.Size = new Size(900, 800);
            Controls.Add(_gamePanel);

            Button btnExit = new Button();
            btnExit.Location = new Point(12, 12);
            btnExit.Size = new Size(75, 50);
            btnExit.BackColor = Control.DefaultBackColor;
            btnExit.Text = "Exit";
            btnExit.Click += BtnExit_Click;
            _gamePanel.Controls.Add(btnExit);

            _lblMessage = new Label();
            //_lblMessage.Text = "Click Again to Confirm";
            _lblMessage.Size = new Size(70, 50);
            _lblMessage.Font = new Font("Microsoft Sans Serif", 14);
            _lblMessage.Location = new Point(760,150);
            _gamePanel.Controls.Add(_lblMessage);
            
            _lstMoves = new ListBox();
            _lstMoves.Location = new Point(760, 225);
            _lstMoves.Size = new Size(120, 290);
            _lstMoves.SelectedIndexChanged += _lstMoves_SelectedIndexChanged;
            _lstMoves.DoubleClick += _lstMoves_DoubleClick;
            _gamePanel.Controls.Add(_lstMoves);

            // standart
            game = new Game(fen, this, highlightSquares, isPuzzle, puzzleMoves);
            
            // for castle 
            // game = new Game("r3k2r/pppppppp/8/8/8/8/PPPPPPPP/R3K2R w KQkq - 0 1", this);
            
            // quick fen castle testing
            //Game game = new Game("r3k2r/pppppppp/8/8/8/8/PPPPPPPP/R3K2R w --kq - 0 1", this);
            //Game game = new Game("rnbq1bnr/pppkpppp/8/3p4/4P3/5N2/PPPP1PPP/RNBQKB1R w KQ - 2 3");
            boardPanel = new BoardPanel(game);
            
            boardPanel.Location = new Point(100, 50);
            boardPanel.Size = new Size(640, 640);
            boardPanel.BackgroundImage = Textures.Board;
            _gamePanel.Controls.Add(boardPanel);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelPuzzle_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
