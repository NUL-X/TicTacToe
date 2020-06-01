using System;
using System.Windows.Forms;

namespace TicTacToe.Forms
{
    public partial class Main : Form
    {
        public bool isConnected = false;
        public bool isClient = false;
        public Main()
        {
            InitializeComponent();
        }
        
        public void displayMatrix(){
            // TODO: @Yassine-Ag Display a stored matrix from the saved games list 
        }

        public void MakeMove(int x, int y)
        {
            // TODO: @Yassine-Ag Store in matrix then display to the game grid
        }
        
        public void RestartGame(){}
        
        public void SetStatusMessage(string msg){}
        
        public void mnDisconnect_Click(object sender, EventArgs args){}
        
    }
}