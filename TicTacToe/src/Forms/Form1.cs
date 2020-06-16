using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
    (
        int nLeftRect, // x-coordinate of upper-left corner
        int nTopRect, // y-coordinate of upper-left corner
        int nRightRect, // x-coordinate of lower-right corner
        int nBottomRect, // y-coordinate of lower-right corner
        int nWidthEllipse, // height of ellipse
        int nHeightEllipse // width of ellipse
     );

        [DllImport("dwmapi.dll")]
        public static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMarInset);

        [DllImport("dwmapi.dll")]
        public static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);

        [DllImport("dwmapi.dll")]
        public static extern int DwmIsCompositionEnabled(ref int pfEnabled);

        private bool m_aeroEnabled;                     // variables for box shadow
        private const int CS_DROPSHADOW = 0x00020000;
        private const int WM_NCPAINT = 0x0085;
        private const int WM_ACTIVATEAPP = 0x001C;

        public struct MARGINS                           // struct for box shadow
        {
            public int leftWidth;
            public int rightWidth;
            public int topHeight;
            public int bottomHeight;
        }

        private const int WM_NCHITTEST = 0x84;          // variables for dragging the form
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;

        protected override CreateParams CreateParams
        {
            get
            {
                m_aeroEnabled = CheckAeroEnabled();

                CreateParams cp = base.CreateParams;
                if (!m_aeroEnabled)
                    cp.ClassStyle |= CS_DROPSHADOW;

                return cp;
            }
        }

        private bool CheckAeroEnabled()
        {
            if (Environment.OSVersion.Version.Major >= 6)
            {
                int enabled = 0;
                DwmIsCompositionEnabled(ref enabled);
                return (enabled == 1) ? true : false;
            }
            return false;
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCPAINT:                        // box shadow
                    if (m_aeroEnabled)
                    {
                        var v = 2;
                        DwmSetWindowAttribute(this.Handle, 2, ref v, 4);
                        MARGINS margins = new MARGINS()
                        {
                            bottomHeight = 1,
                            leftWidth = 1,
                            rightWidth = 1,
                            topHeight = 1
                        };
                        DwmExtendFrameIntoClientArea(this.Handle, ref margins);

                    }
                    break;
                default:
                    break;
            }
            base.WndProc(ref m);

            if (m.Msg == WM_NCHITTEST && (int)m.Result == HTCLIENT)     // drag the form
                m.Result = (IntPtr)HTCAPTION;

        }

        /*
         *Border Radius
         */




        public Form1()
        {
            InitializeComponent();

            timer1.Enabled = true;
            timer1.Tick += OnHideSplashScreen;


        }

        /*
         * Splash Screen
         */

        private void OnHideSplashScreen(object sender, EventArgs e)
        {
            this.pb_min.Visible = true;
            this.pb_close.Visible = true;
            bunifuTransition1.HideSync(userControl11, true);
            bunifuTransition1.ShowSync(this.menu1, true);
            this.timer1.Stop();

        }


        /*
         * Close button events
         */

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pb_close.BackColor = Color.LightGray;

        }

        private void pb_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pb_close_MouseLeave(object sender, EventArgs e)
        {
            pb_close.BackColor = this.BackColor;
        }


        /*-----------------------------------------------------------------------------------*/

        /*
         * Minimize button events
         */

        private void pb_min_MouseEnter(object sender, EventArgs e)
        {
            pb_min.BackColor = Color.LightGray;
        }

        private void pb_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pb_min_MouseLeave(object sender, EventArgs e)
        {
            pb_min.BackColor = this.BackColor;
        }



        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            ShowMenu();

        }



        public void ShowMenu()
        {
            this.btn_back.Visible = false;
            bunifuTransition1.HideSync(this.gridForm1);
            bunifuTransition2.ShowSync(this.menu1);

        }

        public void ShowGridForm()
        {

            bunifuTransition1.HideSync(this.menu1);
            bunifuTransition1.Show(this.gridForm1);
            bunifuTransition1.Show(this.btn_back);

        }


    }
}
