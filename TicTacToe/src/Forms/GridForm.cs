using System;
using System.Drawing;
using System.Windows.Forms;
using TicTacToe.Entities;
using TicTacToe.Utils;
using static TicTacToe.Entities.Structures;

namespace TicTacToe.Forms
{
    public partial class GridForm : UserControl
    {
        public Grid Game;

        bool verrou = true;
        bool _isPlayerA = true;

        public bool isConnected, isClient;

        //_____________________________________________________________________________________________
        //
        // Who plays, who won, the kind of player is CPU and human
        //_____________________________________________________________________________________________

        public MoveType wTurn = MoveType.Ball;
        public MoveType wWinner = MoveType.None;

        // these 2 fields needed in AI.cs
        public MoveType _moveTypeCpu = MoveType.Cross;
        public MoveType _moveTypePlayer = MoveType.Ball;
        public AIDifficulty _difficulty;    // still needs to be initialised?


        //_____________________________________________________________________________________________
        //
        // Board is saved in a matrix
        //_____________________________________________________________________________________________

        public MoveType[,] wBoard = new MoveType[4, 4] {{MoveType.None,MoveType.None,MoveType.None,MoveType.None},
            {MoveType.None,MoveType.None,MoveType.None,MoveType.None},
            {MoveType.None,MoveType.None,MoveType.None,MoveType.None},
            {MoveType.None,MoveType.None,MoveType.None,MoveType.None}};

        SoundEffectsControl sfc = new SoundEffectsControl();
        private int countP = 0;

        public GridForm()
        {
            InitializeComponent();
        }

        private void GridForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Point p = new Point(350, 450);
            Game = new Grid(150, p);
            Game.Drawing(ref g);
        }

        private void GridForm_MouseDown(object sender, MouseEventArgs e)
        {
            Graphics g = CreateGraphics();
            Point p = e.Location;

            if (countP == 0)
            {
                switch (_isPlayerA)
                {
                    case true:
                        {
                            if (verrou)
                            {
                                var ok = Game.PlayerA(ref g, p);

                                if (ok) verrou = false;
                            }
                            bool test = Game.CheckForGameOver(this, ref g);
                            if (test)
                            {
                                verrou = true;
                                countP++;

                            }
                        }
                        _isPlayerA = false;

                        break;

                    case false:
                        {
                            if (!verrou)
                            {
                                var ok = Game.PlayerB(ref g, p);

                                if (ok) verrou = true;
                            }
                            bool test = Game.CheckForGameOver(this, ref g);
                            if (test)
                            {
                                verrou = true;
                                countP++;
                            }
                        }
                        _isPlayerA = true;
                        break;

                }
            }
            else if (countP == 1)
            {
                Game.ResetGame(this);
                countP = 0;
            }

        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            sfc.MoveSound();
            Game.ResetGame(this);
            countP = 0;
        }

        private void bunifuImageButton3_Click_1(object sender, EventArgs e)
        {
            sfc.MoveSound();
            scoreBoard1.scoreBordMode();
            this.pn_Tools.Visible = false;
            Transition1.Show(scoreBoard1);
        }

        public void ModifyScoreBoard()
        {
            int GamePlay = Players.GamePlay();
            if(GamePlay==1)
                scoreBoard1.vsComputer();
            else scoreBoard1.Two_Players();
        }

        public void OnPlayerA_Win()
        {
            scoreBoard1.OnPlayerA_Win();
        }
        public void OnPlayerB_Win()
        {
            scoreBoard1.OnPlayerB_Win();
        }
        public void OnTie()
        {
            scoreBoard1.OnTie();
        }

        private void GridForm_VisibleChanged(object sender, EventArgs e)
        {
            if (!this.Visible)
            {
             scoreBoard1.Visible = false;
             scoreBoard1.ClearScores();
            }
            else if (this.Visible && !scoreBoard1.Visible)
            {
                this.pn_Tools.Visible = true;
            }
                
        }


        public void displayMatrix()
        {
            // TODO: @Yassine-Ag Display a stored matrix from the saved games list 
        }

        public void MakeMove(int x, int y)
        {
            // TODO: @Yassine-Ag Store in matrix then display to the game grid
        }

        public void RestartGame() 
        {
            sfc.MoveSound();
            Game.ResetGame(this);
            countP = 0;
        }

        public void SetStatusMessage(string msg) { }

        public void DisconnectButton_Click(object sender, EventArgs args) { }
    }

}
