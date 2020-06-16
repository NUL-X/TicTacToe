namespace TicTacToe.Forms
{
    partial class GridForm
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation6 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicTacToe.Forms.GridForm));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.bunifuImageButton3 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.pn_Tools = new System.Windows.Forms.Panel();
            this.Transition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.scoreBoard1 = new TicTacToe.Forms.ScoreBoard();
            ((System.ComponentModel.ISupportInitialize) (this.bunifuImageButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.bunifuImageButton2)).BeginInit();
            this.pn_Tools.SuspendLayout();
            this.SuspendLayout();
            this.bunifuImageButton3.BackColor = System.Drawing.Color.White;
            this.Transition1.SetDecoration(this.bunifuImageButton3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton3.Image = global::TicTacToe.Properties.Resources._scoreboard_;
            this.bunifuImageButton3.ImageActive = null;
            this.bunifuImageButton3.Location = new System.Drawing.Point(15, 124);
            this.bunifuImageButton3.Name = "bunifuImageButton3";
            this.bunifuImageButton3.Size = new System.Drawing.Size(71, 80);
            this.bunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bunifuImageButton3.TabIndex = 2;
            this.bunifuImageButton3.TabStop = false;
            this.toolTip1.SetToolTip(this.bunifuImageButton3, "Scoreboard");
            this.bunifuImageButton3.Zoom = 10;
            this.bunifuImageButton3.Click += new System.EventHandler(this.bunifuImageButton3_Click_1);
            this.bunifuImageButton2.BackColor = System.Drawing.Color.White;
            this.Transition1.SetDecoration(this.bunifuImageButton2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton2.Image = TicTacToe.Properties.Resources.icons8_replay_2.ToBitmap();
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(15, 30);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(71, 60);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 1;
            this.bunifuImageButton2.TabStop = false;
            this.toolTip1.SetToolTip(this.bunifuImageButton2, "New Game");
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            this.pn_Tools.Controls.Add(this.bunifuImageButton2);
            this.pn_Tools.Controls.Add(this.bunifuImageButton3);
            this.Transition1.SetDecoration(this.pn_Tools, BunifuAnimatorNS.DecorationType.None);
            this.pn_Tools.Location = new System.Drawing.Point(809, 236);
            this.pn_Tools.Name = "pn_Tools";
            this.pn_Tools.Size = new System.Drawing.Size(99, 258);
            this.pn_Tools.TabIndex = 4;
            this.Transition1.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.Transition1.Cursor = null;
            animation6.AnimateOnlyDifferences = true;
            animation6.BlindCoeff = ((System.Drawing.PointF) (resources.GetObject("animation6.BlindCoeff")));
            animation6.LeafCoeff = 0F;
            animation6.MaxTime = 1F;
            animation6.MinTime = 0F;
            animation6.MosaicCoeff = ((System.Drawing.PointF) (resources.GetObject("animation6.MosaicCoeff")));
            animation6.MosaicShift = ((System.Drawing.PointF) (resources.GetObject("animation6.MosaicShift")));
            animation6.MosaicSize = 0;
            animation6.Padding = new System.Windows.Forms.Padding(0);
            animation6.RotateCoeff = 0F;
            animation6.RotateLimit = 0F;
            animation6.ScaleCoeff = ((System.Drawing.PointF) (resources.GetObject("animation6.ScaleCoeff")));
            animation6.SlideCoeff = ((System.Drawing.PointF) (resources.GetObject("animation6.SlideCoeff")));
            animation6.TimeCoeff = 0F;
            animation6.TransparencyCoeff = 1F;
            this.Transition1.DefaultAnimation = animation6;
            this.scoreBoard1.BackColor = System.Drawing.Color.White;
            this.Transition1.SetDecoration(this.scoreBoard1, BunifuAnimatorNS.DecorationType.None);
            this.scoreBoard1.Location = new System.Drawing.Point(58, 57);
            this.scoreBoard1.Name = "scoreBoard1";
            this.scoreBoard1.Size = new System.Drawing.Size(850, 598);
            this.scoreBoard1.TabIndex = 3;
            this.scoreBoard1.Visible = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pn_Tools);
            this.Controls.Add(this.scoreBoard1);
            this.Transition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Name = "GridForm";
            this.Size = new System.Drawing.Size(911, 741);
            this.VisibleChanged += new System.EventHandler(this.GridForm_VisibleChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GridForm_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GridForm_MouseDown);
            ((System.ComponentModel.ISupportInitialize) (this.bunifuImageButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.bunifuImageButton2)).EndInit();
            this.pn_Tools.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton3;
        public System.Windows.Forms.Panel pn_Tools;
        private TicTacToe.Forms.ScoreBoard scoreBoard1;
        private System.Windows.Forms.ToolTip toolTip1;
        private BunifuAnimatorNS.BunifuTransition Transition1;

        #endregion
    }
}
