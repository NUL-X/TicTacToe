namespace TicTacToe
{
    partial class ScoreBoard
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
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScoreBoard));
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.lbl_Tie = new System.Windows.Forms.Label();
            this.lbl_A = new System.Windows.Forms.Label();
            this.lbl_B = new System.Windows.Forms.Label();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.lb_B = new System.Windows.Forms.Label();
            this.lb_1 = new System.Windows.Forms.Label();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.label1 = new System.Windows.Forms.Label();
            this.pb_close = new System.Windows.Forms.PictureBox();
            this.img_playerB = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Transition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.bunifuCards1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pb_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.img_playerB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.bunifuImageButton2)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.Transition.SetDecoration(this.bunifuSeparator1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int) (((byte) (50)))), ((int) (((byte) (50)))), ((int) (((byte) (50)))));
            this.bunifuSeparator1.LineThickness = 5;
            this.bunifuSeparator1.Location = new System.Drawing.Point(60, 458);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(763, 29);
            this.bunifuSeparator1.TabIndex = 0;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // lbl_Tie
            // 
            this.lbl_Tie.AutoSize = true;
            this.Transition.SetDecoration(this.lbl_Tie, BunifuAnimatorNS.DecorationType.None);
            this.lbl_Tie.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_Tie.Location = new System.Drawing.Point(426, 491);
            this.lbl_Tie.Name = "lbl_Tie";
            this.lbl_Tie.Size = new System.Drawing.Size(31, 36);
            this.lbl_Tie.TabIndex = 7;
            this.lbl_Tie.Text = "0";
            // 
            // lbl_A
            // 
            this.lbl_A.AutoSize = true;
            this.Transition.SetDecoration(this.lbl_A, BunifuAnimatorNS.DecorationType.None);
            this.lbl_A.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_A.Location = new System.Drawing.Point(220, 491);
            this.lbl_A.Name = "lbl_A";
            this.lbl_A.Size = new System.Drawing.Size(31, 36);
            this.lbl_A.TabIndex = 8;
            this.lbl_A.Text = "0";
            // 
            // lbl_B
            // 
            this.lbl_B.AutoSize = true;
            this.Transition.SetDecoration(this.lbl_B, BunifuAnimatorNS.DecorationType.None);
            this.lbl_B.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_B.Location = new System.Drawing.Point(633, 491);
            this.lbl_B.Name = "lbl_B";
            this.lbl_B.Size = new System.Drawing.Size(31, 36);
            this.lbl_B.TabIndex = 9;
            this.lbl_B.Text = "0";
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.Transition.SetDecoration(this.bunifuSeparator2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int) (((byte) (50)))), ((int) (((byte) (50)))), ((int) (((byte) (50)))));
            this.bunifuSeparator2.LineThickness = 5;
            this.bunifuSeparator2.Location = new System.Drawing.Point(60, 535);
            this.bunifuSeparator2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(763, 25);
            this.bunifuSeparator2.TabIndex = 10;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // lb_B
            // 
            this.lb_B.AutoSize = true;
            this.Transition.SetDecoration(this.lb_B, BunifuAnimatorNS.DecorationType.None);
            this.lb_B.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lb_B.Location = new System.Drawing.Point(592, 381);
            this.lb_B.Name = "lb_B";
            this.lb_B.Size = new System.Drawing.Size(120, 36);
            this.lb_B.TabIndex = 11;
            this.lb_B.Text = "Player 2";
            // 
            // lb_1
            // 
            this.lb_1.AutoSize = true;
            this.Transition.SetDecoration(this.lb_1, BunifuAnimatorNS.DecorationType.None);
            this.lb_1.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lb_1.Location = new System.Drawing.Point(174, 381);
            this.lb_1.Name = "lb_1";
            this.lb_1.Size = new System.Drawing.Size(120, 36);
            this.lb_1.TabIndex = 12;
            this.lb_1.Text = "Player 1";
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.FromArgb(((int) (((byte) (50)))), ((int) (((byte) (50)))), ((int) (((byte) (50)))));
            this.bunifuCards1.Controls.Add(this.bunifuSeparator1);
            this.bunifuCards1.Controls.Add(this.bunifuSeparator2);
            this.bunifuCards1.Controls.Add(this.label1);
            this.bunifuCards1.Controls.Add(this.pb_close);
            this.bunifuCards1.Controls.Add(this.lbl_Tie);
            this.bunifuCards1.Controls.Add(this.lb_B);
            this.bunifuCards1.Controls.Add(this.lbl_B);
            this.bunifuCards1.Controls.Add(this.lb_1);
            this.bunifuCards1.Controls.Add(this.img_playerB);
            this.bunifuCards1.Controls.Add(this.lbl_A);
            this.bunifuCards1.Controls.Add(this.bunifuImageButton2);
            this.Transition.SetDecoration(this.bunifuCards1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCards1.LeftSahddow = true;
            this.bunifuCards1.Location = new System.Drawing.Point(25, 6);
            this.bunifuCards1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bunifuCards1.ShadowDepth = 30;
            this.bunifuCards1.Size = new System.Drawing.Size(873, 728);
            this.bunifuCards1.TabIndex = 15;
            this.bunifuCards1.MouseEnter += new System.EventHandler(this.bunifuCards1_MouseEnter);
            this.bunifuCards1.MouseLeave += new System.EventHandler(this.bunifuCards1_MouseLeave);
            // 
            // label1
            // 
            this.Transition.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.Location = new System.Drawing.Point(392, 381);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 39);
            this.label1.TabIndex = 17;
            this.label1.Text = "Tie";
            // 
            // pb_close
            // 
            this.pb_close.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Transition.SetDecoration(this.pb_close, BunifuAnimatorNS.DecorationType.None);
            this.pb_close.Location = new System.Drawing.Point(816, 20);
            this.pb_close.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pb_close.Name = "pb_close";
            this.pb_close.Size = new System.Drawing.Size(43, 48);
            this.pb_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb_close.TabIndex = 16;
            this.pb_close.TabStop = false;
            this.toolTip1.SetToolTip(this.pb_close, "Close");
            this.pb_close.Click += new System.EventHandler(this.pb_close_Click);
            this.pb_close.MouseEnter += new System.EventHandler(this.pb_close_MouseEnter);
            this.pb_close.MouseLeave += new System.EventHandler(this.pb_close_MouseLeave_1);
            // 
            // img_playerB
            // 
            this.img_playerB.BackColor = System.Drawing.Color.White;
            this.Transition.SetDecoration(this.img_playerB, BunifuAnimatorNS.DecorationType.None);
            this.img_playerB.Image = global::TicTacToe.Properties.Resources.user;
            this.img_playerB.ImageActive = null;
            this.img_playerB.Location = new System.Drawing.Point(580, 134);
            this.img_playerB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.img_playerB.Name = "img_playerB";
            this.img_playerB.Size = new System.Drawing.Size(148, 155);
            this.img_playerB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_playerB.TabIndex = 5;
            this.img_playerB.TabStop = false;
            this.img_playerB.Zoom = 10;
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.White;
            this.Transition.SetDecoration(this.bunifuImageButton2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton2.Image = global::TicTacToe.Properties.Resources.user;
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(163, 134);
            this.bunifuImageButton2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(154, 155);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 4;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            // 
            // Transition
            // 
            this.Transition.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.Transition.Cursor = null;
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
            this.Transition.DefaultAnimation = animation1;
            this.Transition.Interval = 30;
            // 
            // ScoreBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.bunifuCards1);
            this.Transition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ScoreBoard";
            this.Size = new System.Drawing.Size(918, 770);
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pb_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.img_playerB)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.bunifuImageButton2)).EndInit();
            this.ResumeLayout(false);
        }

        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private Bunifu.Framework.UI.BunifuImageButton img_playerB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_1;
        private System.Windows.Forms.Label lb_B;
        private System.Windows.Forms.Label lbl_A;
        private System.Windows.Forms.Label lbl_B;
        private System.Windows.Forms.Label lbl_Tie;
        private System.Windows.Forms.PictureBox pb_close;
        private System.Windows.Forms.ToolTip toolTip1;
        private BunifuAnimatorNS.BunifuTransition Transition;

        #endregion
    }
}
