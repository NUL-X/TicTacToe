using System;
using System.Windows.Forms;
using TicTacToe.Entities;
using TicTacToe.Utils;

namespace TicTacToe.Forms
{

    public partial class Menu : UserControl
    {
        SoundEffectsControl sfc = new SoundEffectsControl();

        public Menu()
        {
            InitializeComponent();

        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            sfc.MenuClickSound();
            transition_Tansparent.Show(pn_p1);
            transition_Tansparent.Hide(pn_p2);

        }

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
            sfc.MenuClickSound();
            transition_Tansparent.Show(pn_p2);
            transition_Tansparent.Hide(pn_p1);
        }

        private void bunifuThinButton23_MouseHover(object sender, EventArgs e)
        {
            sfc.MoveSound();
        }

        private void bunifuThinButton24_MouseHover(object sender, EventArgs e)
        {
            sfc.MoveSound();
        }

        private void bunifuThinButton25_MouseHover(object sender, EventArgs e)
        {
            sfc.MoveSound();
        }

        private void bunifuThinButton21_MouseHover(object sender, EventArgs e)
        {
            sfc.MoveSound();
        }

        private void bunifuThinButton22_MouseHover(object sender, EventArgs e)
        {
            sfc.MoveSound();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Players.TwoPlayer();

           ((MainForm)this.ParentForm).ShowGridForm();

        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            Players.OnePlayer(1);

            ((MainForm)this.ParentForm).ShowGridForm();
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            Players.OnePlayer(2);

            ((MainForm)this.ParentForm).ShowGridForm();
        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            Players.OnePlayer(3);
            
            ((MainForm)this.ParentForm).ShowGridForm();
        }
    }
}
