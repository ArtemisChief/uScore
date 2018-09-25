namespace μScore
{
    partial class Sign
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sign));
            this.skinPanel1 = new CCWin.SkinControl.SkinPanel();
            this.skinFlowLayoutPanel1 = new CCWin.SkinControl.SkinFlowLayoutPanel();
            this.close = new CCWin.SkinControl.SkinButton();
            this.maximum = new CCWin.SkinControl.SkinButton();
            this.minimal = new CCWin.SkinControl.SkinButton();
            this.skinFlowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // skinPanel1
            // 
            this.skinPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.skinPanel1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel1.DownBack = null;
            this.skinPanel1.Location = new System.Drawing.Point(0, 35);
            this.skinPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.skinPanel1.MouseBack = null;
            this.skinPanel1.Name = "skinPanel1";
            this.skinPanel1.NormlBack = null;
            this.skinPanel1.Size = new System.Drawing.Size(600, 365);
            this.skinPanel1.TabIndex = 8;
            // 
            // skinFlowLayoutPanel1
            // 
            this.skinFlowLayoutPanel1.AutoSize = true;
            this.skinFlowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.skinFlowLayoutPanel1.Controls.Add(this.close);
            this.skinFlowLayoutPanel1.Controls.Add(this.maximum);
            this.skinFlowLayoutPanel1.Controls.Add(this.minimal);
            this.skinFlowLayoutPanel1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinFlowLayoutPanel1.DownBack = null;
            this.skinFlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.skinFlowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.skinFlowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.skinFlowLayoutPanel1.MouseBack = null;
            this.skinFlowLayoutPanel1.Name = "skinFlowLayoutPanel1";
            this.skinFlowLayoutPanel1.NormlBack = null;
            this.skinFlowLayoutPanel1.Radius = 7;
            this.skinFlowLayoutPanel1.RoundStyle = CCWin.SkinClass.RoundStyle.Top;
            this.skinFlowLayoutPanel1.Size = new System.Drawing.Size(600, 35);
            this.skinFlowLayoutPanel1.TabIndex = 9;
            this.skinFlowLayoutPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.skinFlowLayoutPanel1_MouseDown);
            this.skinFlowLayoutPanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.skinFlowLayoutPanel1_MouseMove);
            this.skinFlowLayoutPanel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.skinFlowLayoutPanel1_MouseUp);
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.Transparent;
            this.close.BackgroundImage = global::μScore.Properties.Resources.closeB;
            this.close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.close.BaseColor = System.Drawing.Color.Transparent;
            this.close.BorderColor = System.Drawing.Color.Transparent;
            this.close.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.DownBack = ((System.Drawing.Image)(resources.GetObject("close.DownBack")));
            this.close.DownBaseColor = System.Drawing.Color.Transparent;
            this.close.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.close.FadeGlow = false;
            this.close.ForeColor = System.Drawing.Color.Transparent;
            this.close.GlowColor = System.Drawing.Color.Transparent;
            this.close.InnerBorderColor = System.Drawing.Color.Transparent;
            this.close.IsDrawBorder = false;
            this.close.IsDrawGlass = false;
            this.close.Location = new System.Drawing.Point(570, 10);
            this.close.Margin = new System.Windows.Forms.Padding(8, 10, 15, 10);
            this.close.MouseBack = ((System.Drawing.Image)(resources.GetObject("close.MouseBack")));
            this.close.MouseBaseColor = System.Drawing.Color.Transparent;
            this.close.Name = "close";
            this.close.NormlBack = null;
            this.close.Size = new System.Drawing.Size(15, 15);
            this.close.TabIndex = 0;
            this.close.TabStop = false;
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // maximum
            // 
            this.maximum.BackColor = System.Drawing.Color.Transparent;
            this.maximum.BackgroundImage = global::μScore.Properties.Resources.maximumB;
            this.maximum.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.maximum.BaseColor = System.Drawing.Color.Transparent;
            this.maximum.BorderColor = System.Drawing.Color.Transparent;
            this.maximum.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.maximum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.maximum.DownBack = ((System.Drawing.Image)(resources.GetObject("maximum.DownBack")));
            this.maximum.DownBaseColor = System.Drawing.Color.Transparent;
            this.maximum.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.maximum.Enabled = false;
            this.maximum.FadeGlow = false;
            this.maximum.ForeColor = System.Drawing.Color.Transparent;
            this.maximum.GlowColor = System.Drawing.Color.Transparent;
            this.maximum.InnerBorderColor = System.Drawing.Color.Transparent;
            this.maximum.IsDrawBorder = false;
            this.maximum.IsDrawGlass = false;
            this.maximum.Location = new System.Drawing.Point(539, 10);
            this.maximum.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.maximum.MouseBack = ((System.Drawing.Image)(resources.GetObject("maximum.MouseBack")));
            this.maximum.MouseBaseColor = System.Drawing.Color.Transparent;
            this.maximum.Name = "maximum";
            this.maximum.NormlBack = null;
            this.maximum.Size = new System.Drawing.Size(15, 15);
            this.maximum.TabIndex = 3;
            this.maximum.TabStop = false;
            this.maximum.UseVisualStyleBackColor = false;
            this.maximum.Click += new System.EventHandler(this.maximum_Click);
            // 
            // minimal
            // 
            this.minimal.BackColor = System.Drawing.Color.Transparent;
            this.minimal.BackgroundImage = global::μScore.Properties.Resources.minimalB;
            this.minimal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.minimal.BaseColor = System.Drawing.Color.Transparent;
            this.minimal.BorderColor = System.Drawing.Color.Transparent;
            this.minimal.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.minimal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimal.DownBack = ((System.Drawing.Image)(resources.GetObject("minimal.DownBack")));
            this.minimal.DownBaseColor = System.Drawing.Color.Transparent;
            this.minimal.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.minimal.FadeGlow = false;
            this.minimal.ForeColor = System.Drawing.Color.Transparent;
            this.minimal.GlowColor = System.Drawing.Color.Transparent;
            this.minimal.InnerBorderColor = System.Drawing.Color.Transparent;
            this.minimal.IsDrawBorder = false;
            this.minimal.IsDrawGlass = false;
            this.minimal.Location = new System.Drawing.Point(508, 10);
            this.minimal.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.minimal.MouseBack = ((System.Drawing.Image)(resources.GetObject("minimal.MouseBack")));
            this.minimal.MouseBaseColor = System.Drawing.Color.Transparent;
            this.minimal.Name = "minimal";
            this.minimal.NormlBack = null;
            this.minimal.Size = new System.Drawing.Size(15, 15);
            this.minimal.TabIndex = 4;
            this.minimal.TabStop = false;
            this.minimal.UseVisualStyleBackColor = false;
            this.minimal.Click += new System.EventHandler(this.minimal_Click);
            // 
            // Sign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.CanResize = false;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.ControlBox = false;
            this.Controls.Add(this.skinFlowLayoutPanel1);
            this.Controls.Add(this.skinPanel1);
            this.DropBack = false;
            this.EffectCaption = CCWin.TitleType.None;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Sign";
            this.Radius = 7;
            this.ShadowWidth = 7;
            this.ShowBorder = false;
            this.ShowDrawIcon = false;
            this.Special = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "";
            this.VisibleChanged += new System.EventHandler(this.Sign_VisibleChanged);
            this.skinFlowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public CCWin.SkinControl.SkinFlowLayoutPanel skinFlowLayoutPanel1;
        private CCWin.SkinControl.SkinButton close;
        private CCWin.SkinControl.SkinButton maximum;
        private CCWin.SkinControl.SkinButton minimal;
        private CCWin.SkinControl.SkinPanel skinPanel1;
    }
}