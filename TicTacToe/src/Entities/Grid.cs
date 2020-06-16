using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicTacToe;
using TicTacToe;

namespace TicTacToe
{
    public class Grid
    {
        private DrawGraphics[,] grid;
        SoundEffectsControl sfc = new SoundEffectsControl();
        public static int PlayCount;
        private int[] gridWinIndex = new int[6];

        private ScoreBoard score;
        // Player a,b; 



        private static bool _isWin;

        public Grid(int l, Point start)
        {
            grid = new DrawGraphics[3, 3];
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                {
                    grid[i, j] = new DrawGraphics(50 + j * l, 50 + i * l, 150);
                }


        }

        public bool SeachRect(Point p, out int ix, out int jy)
        {
            ix = -1;
            jy = -1;
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    if (grid[i, j].PointInRect(p))
                    {
                        ix = i;
                        jy = j;
                        return true;
                    }

            return false;
        }


        public bool SeachRect_AI(out int ix, out int jy)
        {
            ix = -1;
            jy = -1;
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    if (grid[i, j].GridValue() == 0)
                    {
                        ix = i;
                        jy = j;
                        return true;
                    }

            return false;
        }



        public void DrawGrid(ref Graphics g)
        {
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    grid[i, j].Desiner(ref g);

        }

        public void Drawing(ref Graphics g)
        {

            g.DrawLine(new Pen(Brushes.DarkGray, 5), 200, 50, 200, 500);

            g.DrawLine(new Pen(Brushes.DarkGray, 5), 350, 50, 350, 500);



            g.DrawLine(new Pen(Brushes.DarkGray, 5), 50, 200, 500, 200);

            g.DrawLine(new Pen(Brushes.DarkGray, 5), 50, 350, 500, 350);

            DrawGrid(ref g);


        }


        public bool PlayerA(ref Graphics g, Point p)
        {

            bool r = SeachRect(p, out var i, out var j);
            if (!r)
            {
                validatePlayerEntry();
                return false;
            }

            if (PlayCount % 2 == 0)
            {
                if (grid[i, j].GridValue() == 0 && r)
                {
                    grid[i, j].DessinerX_Black(ref g);
                    sfc.PlayerA();
                    PlayCount++;
                }


            }
            return true;
        }


        public bool PlayerB(ref Graphics g, Point p)
        {

            bool r = SeachRect(p, out var i, out var j);
            if (!r)
            {
                validatePlayerEntry();
                return false;
            }

            if (PlayCount % 2 != 0)
            {
                if (grid[i, j].GridValue() == 0 && r)
                {
                    grid[i, j].DessinerO_Black(ref g);
                    sfc.PlayerB();
                    PlayCount++;
                }
            }

            return true;
        }

        public bool PlayerB_AI(ref Graphics g, int i, int j)
        {

            bool r = SeachRect_AI(out i, out j);
            if (!r)
            {
                validatePlayerEntry();
                return false;
            }

            if (PlayCount % 2 != 0)
            {
                if (grid[i, j].GridValue() == 0 && r)
                {
                    grid[i, j].DessinerO_Black(ref g);
                    sfc.PlayerB();
                    PlayCount++;
                }
            }
            return true;
        }

        public int IsWinner()
        {


            // player A
            if (
                (grid[0, 0].PlayerA()) &&
                (grid[1, 0].PlayerA()) &&
                (grid[2, 0].PlayerA())
            )
            {
                gridWinIndex[0] = 0;
                gridWinIndex[1] = 0;
                gridWinIndex[2] = 1;
                gridWinIndex[3] = 0;
                gridWinIndex[4] = 2;
                gridWinIndex[5] = 0;

                return 1;
            }



            if (
                (grid[0, 1].PlayerA()) &&
                (grid[1, 1].PlayerA()) &&
                (grid[2, 1].PlayerA())
            )
            {
                gridWinIndex[0] = 0;
                gridWinIndex[1] = 1;
                gridWinIndex[2] = 1;
                gridWinIndex[3] = 1;
                gridWinIndex[4] = 2;
                gridWinIndex[5] = 1;

                return 1;
            }


            if (
                (grid[0, 2].PlayerA()) &&
                (grid[1, 2].PlayerA()) &&
                (grid[2, 2].PlayerA())
            )
            {
                gridWinIndex[0] = 0;
                gridWinIndex[1] = 2;
                gridWinIndex[2] = 1;
                gridWinIndex[3] = 2;
                gridWinIndex[4] = 2;
                gridWinIndex[5] = 2;

                return 1;
            }


            if (
                (grid[0, 0].PlayerA()) &&
                (grid[0, 1].PlayerA()) &&
                (grid[0, 2].PlayerA())
            )
            {
                gridWinIndex[0] = 0;
                gridWinIndex[1] = 0;
                gridWinIndex[2] = 0;
                gridWinIndex[3] = 1;
                gridWinIndex[4] = 0;
                gridWinIndex[5] = 2;

                return 1;
            }

            if (
                (grid[1, 0].PlayerA()) &&
                (grid[1, 1].PlayerA()) &&
                (grid[1, 2].PlayerA())
            )
            {
                gridWinIndex[0] = 1;
                gridWinIndex[1] = 0;
                gridWinIndex[2] = 1;
                gridWinIndex[3] = 1;
                gridWinIndex[4] = 1;
                gridWinIndex[5] = 2;

                return 1;
            }


            if (
                (grid[2, 0].PlayerA()) &&
                (grid[2, 1].PlayerA()) &&
                (grid[2, 2].PlayerA())
            )
            {
                gridWinIndex[0] = 2;
                gridWinIndex[1] = 0;
                gridWinIndex[2] = 2;
                gridWinIndex[3] = 1;
                gridWinIndex[4] = 2;
                gridWinIndex[5] = 2;

                return 1;
            }



            // player B

            if (
                (grid[0, 0].PlayerB()) &&
                (grid[1, 0].PlayerB()) &&
                (grid[2, 0].PlayerB())
            )
            {
                gridWinIndex[0] = 0;
                gridWinIndex[1] = 0;
                gridWinIndex[2] = 1;
                gridWinIndex[3] = 0;
                gridWinIndex[4] = 2;
                gridWinIndex[5] = 0;

                return -1;
            }


            if (
                (grid[0, 1].PlayerB()) &&
                (grid[1, 1].PlayerB()) &&
                (grid[2, 1].PlayerB())
            )
            {
                gridWinIndex[0] = 0;
                gridWinIndex[1] = 1;
                gridWinIndex[2] = 1;
                gridWinIndex[3] = 1;
                gridWinIndex[4] = 2;
                gridWinIndex[5] = 1;

                return -1;
            }

            if (
                (grid[0, 2].PlayerB()) &&
                (grid[1, 2].PlayerB()) &&
                (grid[2, 2].PlayerB())
            )
            {
                gridWinIndex[0] = 0;
                gridWinIndex[1] = 2;
                gridWinIndex[2] = 1;
                gridWinIndex[3] = 2;
                gridWinIndex[4] = 2;
                gridWinIndex[5] = 2;

                return -1;
            }


            if (
                (grid[0, 0].PlayerB()) &&
                (grid[0, 1].PlayerB()) &&
                (grid[0, 2].PlayerB())
            )
            {
                gridWinIndex[0] = 0;  gridWinIndex[1] = 0;
                gridWinIndex[2] = 0;  gridWinIndex[3] = 1;
                gridWinIndex[4] = 0;  gridWinIndex[5] = 2;
               

                return -1;
            }


            if (
                (grid[1, 0].PlayerB()) &&
                (grid[1, 1].PlayerB()) &&
                (grid[1, 2].PlayerB())
            )
            {
                gridWinIndex[0] = 1;
                gridWinIndex[1] = 0;
                gridWinIndex[2] = 1;
                gridWinIndex[3] = 1;
                gridWinIndex[4] = 1;
                gridWinIndex[5] = 2;

                return -1;
            }


            if (
                (grid[2, 0].PlayerB()) &&
                (grid[2, 1].PlayerB()) &&
                (grid[2, 2].PlayerB())
            )
            {
                gridWinIndex[0] = 2;
                gridWinIndex[1] = 0;
                gridWinIndex[2] = 2;
                gridWinIndex[3] = 1;
                gridWinIndex[4] = 2;
                gridWinIndex[5] = 2;

                return -1;
            }







            // player A
            if (
                (grid[0, 0].PlayerA()) &&
                (grid[1, 1].PlayerA()) &&
                (grid[2, 2].PlayerA())
            )
            {
                gridWinIndex[0] = 0;
                gridWinIndex[1] = 0;
                gridWinIndex[2] = 1;
                gridWinIndex[3] = 1;
                gridWinIndex[4] = 2;
                gridWinIndex[5] = 2;

                return 1;
            }


            // player A
            if (
                (grid[0, 2].PlayerA()) &&
                (grid[1, 1].PlayerA()) &&
                (grid[2, 0].PlayerA())
            )
            {
                gridWinIndex[0] = 0;
                gridWinIndex[1] = 2;
                gridWinIndex[2] = 1;
                gridWinIndex[3] = 1;
                gridWinIndex[4] = 2;
                gridWinIndex[5] = 0;

                return 1;
            }


            // player B
            if (
                (grid[0, 2].PlayerB()) &&
                (grid[1, 1].PlayerB()) &&
                (grid[2, 0].PlayerB())
            )
            {
                gridWinIndex[0] = 0;
                gridWinIndex[1] = 2;
                gridWinIndex[2] = 1;
                gridWinIndex[3] = 1;
                gridWinIndex[4] = 2;
                gridWinIndex[5] = 0;

                return -1;
            }


            // player B
            if (
                (grid[0, 0].PlayerB()) &&
                (grid[1, 1].PlayerB()) &&
                (grid[2, 2].PlayerB())
            )
            {
                gridWinIndex[0] = 0;
                gridWinIndex[1] = 0;
                gridWinIndex[2] = 1;
                gridWinIndex[3] = 1;
                gridWinIndex[4] = 2;
                gridWinIndex[5] = 2;

                return -1;
            }



            return 0;
        }



        public bool CheckForGameOver(GridForm f, ref Graphics g)
        {
            int nWin = IsWinner();

            if (nWin == 1)
            {

                _isWin = true;
                sfc.Win();
                f.OnPlayerA_Win();
                WinGraphics(ref g, f, 1);
                


                return true;
            }

            if (nWin == -1)
            {
                _isWin = true;

                sfc.Win();
                f.OnPlayerB_Win();
                WinGraphics(ref g, f, -1);



                return true;
            }


            if (PlayCount >= 9 && !_isWin)
            {
                sfc.Lose();
                f.OnTie();
                TieGraphics(ref g);
                
                return true;

            }

            return false;

        }


        private void validatePlayerEntry()
        {

            return; // Bruh, seriously, why would you display this shit while interrupting the game ......
            string message = "You did not click on the grid. Cancel this operation?";
            string caption = "Error Detected in Input given by " + "Player";
            MessageBoxButtons buttons = MessageBoxButtons.OK;

            // Displays the MessageBox.
            MessageBox.Show(message, caption, buttons);
        }



        public void ResetGame(GridForm f)
        {


            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                {
                    grid[i, j].Reset();
                }


            //f.ResetScoreBoard();

            f.Refresh();

            PlayCount = 0;
            _isWin = false;

        }


        public void WinGraphics(ref Graphics g, GridForm f, int playerWinNumber)
        {
            bool b;
            b = playerWinNumber <= 0;
            int i1, i2, i3, j1, j2, j3;

            i1 = gridWinIndex[0]; j1 = gridWinIndex[1];

            i2 = gridWinIndex[2]; j2 = gridWinIndex[3];

            i3 = gridWinIndex[4]; j3 = gridWinIndex[5];


            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {

                    if (
                        (i == i1 && j == j1) ||
                        (i == i2 && j == j2) ||
                        (i == i3 && j == j3))
                    {


                        if (grid[i, j].GridValue() == 1)
                        {
                            Thread.Sleep(150);
                            grid[i, j].DessinerX(ref g);
                        }


                        else if (grid[i, j].GridValue() == -1)
                        {
                            Thread.Sleep(150);
                            grid[i, j].DessinerO(ref g);
                        }
                    }



                }
            }



        }

     

        public void TieGraphics(ref Graphics g)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (grid[i, j].GridValue() == 1)
                    {
                        Thread.Sleep(50);
                        grid[i, j].DessinerX(ref g);
                    }


                    else if (grid[i, j].GridValue() == -1)
                    {
                        Thread.Sleep(50);
                        grid[i, j].DessinerO(ref g);
                    }
                }
            }
        }
    }
}
