using System;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class ScoreBoard : UserControl
    {
        private static int _incA, _incB, _incTie = 0;

        private Players _playMode;

        public ScoreBoard()
        {
            InitializeComponent();
            scoreBordMode();
        }


        private void pb_close_MouseLeave(object sender, EventArgs e)
        {
            this.pb_close.Image = null;
        }



        private void pb_close_Click(object sender, EventArgs e)
        {
            this.Transition.HideSync(this);
            ((GridForm) this.Parent).pn_Tools.Visible = true;
        }

        private void bunifuCards1_MouseEnter(object sender, EventArgs e)
        {
            this.pb_close.Image = Properties.Resources.icons8_delete_4.ToBitmap();
        }

        private void bunifuCards1_MouseLeave(object sender, EventArgs e)
        {
            this.pb_close.Image = null;
        }

        private void pb_close_MouseEnter(object sender, EventArgs e)
        {
            this.pb_close.Image = Properties.Resources.icons8_delete_4.ToBitmap();
        }

        private void pb_close_MouseLeave_1(object sender, EventArgs e)
        {
            this.pb_close.Image = Properties.Resources.icons8_delete_4.ToBitmap();
        }

        public void Two_Players()
        {
            this.img_playerB.Image = Properties.Resources.user;
            this.lb_B.Text = "Player 2";
        }

        public void vsComputer()
        {
            this.img_playerB.Image = Properties.Resources.robot;
            this.lb_B.Text = "Computer";
        }

        public int isTwoPlayers()
        {
           return  Players.GamePlay() ;
        }

        public void scoreBordMode()
        {
            int play = isTwoPlayers();
            
            switch (play)
            {
                case 1: vsComputer();
                    break;
                case 2: Two_Players();
                    break;
            }
        }

        public void OnPlayerA_Win()
        {
            _incA += 1;
            lbl_A.Text= _incA.ToString();
        }

        public void OnPlayerB_Win()
        {
            _incB += 1;
            lbl_B.Text = _incB.ToString();
        }

        public void OnTie()
        {
            _incTie += 1;
            lbl_Tie.Text = _incTie.ToString();
        }

        public  void ClearScores()
        {
            _incTie = 0; _incA = 0; _incB = 0;
            lbl_Tie.Text = 0 + "";
            lbl_A.Text = 0 + "";
            lbl_B.Text = 0 + "";
        }
    }
}
