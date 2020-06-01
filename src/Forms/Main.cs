using System;
using static TicTacToe.Entities.Structures;
using System.Windows.Forms;
using TicTacToe.Entities;

namespace TicTacToe.Forms
{
    public partial class Main : Form
    {
        public bool isConnected = false;
        public bool isClient = false;
        
        // these 2 fields needed in AI.cs
        public MoveType _moveTypeCpu=MoveType.Cross;
        public MoveType _MoveTypePlayer=MoveType.Ball;
        public AIDifficulty _difficulty;    // still needs to be initialised?
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
        
        public void DisconnectButton_Click(object sender, EventArgs args){}
        
    }
}