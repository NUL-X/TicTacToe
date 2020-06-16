namespace TicTacToe.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicTacToe.Forms.MainForm));
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btn_back = new Bunifu.Framework.UI.BunifuImageButton();
            this.pb_min = new System.Windows.Forms.PictureBox();
            this.pb_close = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.userControl11 = new TicTacToe.Forms.UserControl1();
            this.menu1 = new TicTacToe.Forms.Menu();
            this.gridForm1 = new TicTacToe.Forms.GridForm();
            this.bunifuTransition2 = new BunifuAnimatorNS.BunifuTransition(this.components);
            ((System.ComponentModel.ISupportInitialize) (this.btn_back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pb_min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pb_close)).BeginInit();
            this.SuspendLayout();
            this.btn_back.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.btn_back, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.btn_back, BunifuAnimatorNS.DecorationType.None);
            this.btn_back.Image = TicTacToe.Properties.Resources.icons8_back_arrow.ToBitmap();
            this.btn_back.ImageActive = null;
            this.btn_back.Location = new System.Drawing.Point(14, 14);
            this.btn_back.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(53, 45);
            this.btn_back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_back.TabIndex = 5;
            this.btn_back.TabStop = false;
            this.toolTip1.SetToolTip(this.btn_back, "Back to Menu");
            this.btn_back.Visible = false;
            this.btn_back.Zoom = 10;
            this.btn_back.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            this.pb_min.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuTransition1.SetDecoration(this.pb_min, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.pb_min, BunifuAnimatorNS.DecorationType.None);
            this.pb_min.Image = TicTacToe.Properties.Resources.icons8_subtract_5.ToBitmap();
            this.pb_min.Location = new System.Drawing.Point(1024, 0);
            this.pb_min.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pb_min.Name = "pb_min";
            this.pb_min.Size = new System.Drawing.Size(69, 68);
            this.pb_min.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb_min.TabIndex = 1;
            this.pb_min.TabStop = false;
            this.toolTip1.SetToolTip(this.pb_min, "Minimize");
            this.pb_min.Visible = false;
            this.pb_min.Click += new System.EventHandler(this.pb_min_Click);
            this.pb_min.MouseEnter += new System.EventHandler(this.pb_min_MouseEnter);
            this.pb_min.MouseLeave += new System.EventHandler(this.pb_min_MouseLeave);
            this.pb_close.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuTransition1.SetDecoration(this.pb_close, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.pb_close, BunifuAnimatorNS.DecorationType.None);
            this.pb_close.Image = TicTacToe.Properties.Resources.icons8_delete_5.ToBitmap();
            this.pb_close.Location = new System.Drawing.Point(1095, 0);
            this.pb_close.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pb_close.Name = "pb_close";
            this.pb_close.Size = new System.Drawing.Size(69, 68);
            this.pb_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb_close.TabIndex = 0;
            this.pb_close.TabStop = false;
            this.toolTip1.SetToolTip(this.pb_close, "Close");
            this.pb_close.Visible = false;
            this.pb_close.Click += new System.EventHandler(this.pb_close_Click);
            this.pb_close.MouseLeave += new System.EventHandler(this.pb_close_MouseLeave);
            this.pb_close.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            this.timer1.Interval = 1500;
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.bunifuTransition1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF) (resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF) (resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF) (resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF) (resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF) (resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 1F;
            this.bunifuTransition1.DefaultAnimation = animation1;
            this.bunifuTransition1.Interval = 50;
            this.bunifuTransition1.MaxAnimationTime = 2500;
            this.userControl11.BackColor = System.Drawing.Color.White;
            this.userControl11.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.bunifuTransition2.SetDecoration(this.userControl11, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.userControl11, BunifuAnimatorNS.DecorationType.None);
            this.userControl11.Location = new System.Drawing.Point(1, 75);
            this.userControl11.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(1162, 858);
            this.userControl11.TabIndex = 2;
            this.menu1.BackColor = System.Drawing.Color.White;
            this.bunifuTransition2.SetDecoration(this.menu1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.menu1, BunifuAnimatorNS.DecorationType.None);
            this.menu1.Location = new System.Drawing.Point(1, 66);
            this.menu1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.menu1.Name = "menu1";
            this.menu1.Size = new System.Drawing.Size(1123, 889);
            this.menu1.TabIndex = 3;
            this.gridForm1.BackColor = System.Drawing.Color.White;
            this.bunifuTransition2.SetDecoration(this.gridForm1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.gridForm1, BunifuAnimatorNS.DecorationType.None);
            this.gridForm1.Location = new System.Drawing.Point(38, 75);
            this.gridForm1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.gridForm1.Name = "gridForm1";
            this.gridForm1.Size = new System.Drawing.Size(1110, 880);
            this.gridForm1.TabIndex = 4;
            this.bunifuTransition2.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            this.bunifuTransition2.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF) (resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF) (resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF) (resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF) (resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF) (resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.bunifuTransition2.DefaultAnimation = animation2;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1162, 970);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.pb_min);
            this.Controls.Add(this.pb_close);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.menu1);
            this.Controls.Add(this.gridForm1);
            this.bunifuTransition2.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Tic Tac Toe";
            ((System.ComponentModel.ISupportInitialize) (this.btn_back)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pb_min)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pb_close)).EndInit();
            this.ResumeLayout(false);
        }

        private Bunifu.Framework.UI.BunifuImageButton btn_back;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition2;
        private TicTacToe.Forms.GridForm gridForm1;
        private TicTacToe.Forms.Menu menu1;
        private System.Windows.Forms.PictureBox pb_close;
        private System.Windows.Forms.PictureBox pb_min;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolTip toolTip1;
        private TicTacToe.Forms.UserControl1 userControl11;

        #endregion
    }
}

