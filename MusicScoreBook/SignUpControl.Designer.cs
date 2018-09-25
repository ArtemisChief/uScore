namespace μScore
{
    partial class SignUpControl
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.skinButton1 = new CCWin.SkinControl.SkinButton();
            this.SCPassword = new System.Windows.Forms.TextBox();
            this.SPassword = new System.Windows.Forms.TextBox();
            this.SUsername = new System.Windows.Forms.TextBox();
            this.PictureBox1 = new CCWin.SkinControl.SkinPictureBox();
            this.signUpButton = new CCWin.SkinControl.SkinButton();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.skinFlowLayoutPanel1 = new CCWin.SkinControl.SkinFlowLayoutPanel();
            this.label = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.infoLabel = new System.Windows.Forms.Label();
            this.skinPanel2 = new CCWin.SkinControl.SkinPanel();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.skinFlowLayoutPanel1.SuspendLayout();
            this.skinPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // skinButton1
            // 
            this.skinButton1.BackColor = System.Drawing.Color.Transparent;
            this.skinButton1.BaseColor = System.Drawing.Color.Transparent;
            this.skinButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.skinButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.skinButton1.DownBack = null;
            this.skinButton1.DownBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.skinButton1.FadeGlow = false;
            this.skinButton1.Font = new System.Drawing.Font("思源黑体 Regular", 13F);
            this.skinButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.skinButton1.GlowColor = System.Drawing.Color.Transparent;
            this.skinButton1.InnerBorderColor = System.Drawing.Color.Transparent;
            this.skinButton1.IsDrawGlass = false;
            this.skinButton1.Location = new System.Drawing.Point(269, 289);
            this.skinButton1.Margin = new System.Windows.Forms.Padding(2);
            this.skinButton1.MouseBack = null;
            this.skinButton1.MouseBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.skinButton1.Name = "skinButton1";
            this.skinButton1.NormlBack = null;
            this.skinButton1.Size = new System.Drawing.Size(100, 40);
            this.skinButton1.TabIndex = 28;
            this.skinButton1.TabStop = false;
            this.skinButton1.Text = "Back";
            this.skinButton1.UseVisualStyleBackColor = false;
            this.skinButton1.Click += new System.EventHandler(this.skinButton1_Click);
            // 
            // SCPassword
            // 
            this.SCPassword.Font = new System.Drawing.Font("思源黑体 Regular", 13F);
            this.SCPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.SCPassword.Location = new System.Drawing.Point(331, 227);
            this.SCPassword.Name = "SCPassword";
            this.SCPassword.PasswordChar = '*';
            this.SCPassword.Size = new System.Drawing.Size(207, 33);
            this.SCPassword.TabIndex = 3;
            // 
            // SPassword
            // 
            this.SPassword.Font = new System.Drawing.Font("思源黑体 Regular", 13F);
            this.SPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.SPassword.Location = new System.Drawing.Point(332, 175);
            this.SPassword.Name = "SPassword";
            this.SPassword.PasswordChar = '*';
            this.SPassword.Size = new System.Drawing.Size(206, 33);
            this.SPassword.TabIndex = 2;
            // 
            // SUsername
            // 
            this.SUsername.Font = new System.Drawing.Font("思源黑体 Regular", 13F);
            this.SUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.SUsername.Location = new System.Drawing.Point(332, 123);
            this.SUsername.Name = "SUsername";
            this.SUsername.Size = new System.Drawing.Size(206, 33);
            this.SUsername.TabIndex = 1;
            // 
            // PictureBox1
            // 
            this.PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureBox1.Image = global::μScore.Properties.Resources.head;
            this.PictureBox1.Location = new System.Drawing.Point(0, 0);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(140, 140);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox1.TabIndex = 24;
            this.PictureBox1.TabStop = false;
            this.PictureBox1.Click += new System.EventHandler(this.upLoadPhoto_Click);
            // 
            // signUpButton
            // 
            this.signUpButton.BackColor = System.Drawing.Color.Transparent;
            this.signUpButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.signUpButton.BorderColor = System.Drawing.Color.Transparent;
            this.signUpButton.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.signUpButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signUpButton.DownBack = null;
            this.signUpButton.DownBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(159)))), ((int)(((byte)(234)))));
            this.signUpButton.FadeGlow = false;
            this.signUpButton.Font = new System.Drawing.Font("思源黑体 Regular", 13F);
            this.signUpButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.signUpButton.GlowColor = System.Drawing.Color.Transparent;
            this.signUpButton.InnerBorderColor = System.Drawing.Color.Transparent;
            this.signUpButton.IsDrawGlass = false;
            this.signUpButton.Location = new System.Drawing.Point(434, 289);
            this.signUpButton.Margin = new System.Windows.Forms.Padding(2);
            this.signUpButton.MouseBack = null;
            this.signUpButton.MouseBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(159)))), ((int)(((byte)(234)))));
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.NormlBack = null;
            this.signUpButton.Size = new System.Drawing.Size(100, 40);
            this.signUpButton.TabIndex = 23;
            this.signUpButton.TabStop = false;
            this.signUpButton.Text = "Enter";
            this.signUpButton.UseVisualStyleBackColor = false;
            this.signUpButton.Click += new System.EventHandler(this.signUpButton_Click);
            // 
            // skinLabel3
            // 
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.White;
            this.skinLabel3.Font = new System.Drawing.Font("思源黑体 Regular", 13F);
            this.skinLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.skinLabel3.Location = new System.Drawing.Point(245, 230);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(80, 27);
            this.skinLabel3.TabIndex = 21;
            this.skinLabel3.Text = "Confirm";
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("思源黑体 Regular", 13F);
            this.skinLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.skinLabel2.Location = new System.Drawing.Point(234, 178);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(91, 27);
            this.skinLabel2.TabIndex = 20;
            this.skinLabel2.Text = "Password";
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("思源黑体 Regular", 13F);
            this.skinLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.skinLabel1.Location = new System.Drawing.Point(230, 126);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(98, 27);
            this.skinLabel1.TabIndex = 19;
            this.skinLabel1.Text = "Username";
            // 
            // skinFlowLayoutPanel1
            // 
            this.skinFlowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.skinFlowLayoutPanel1.Controls.Add(this.label);
            this.skinFlowLayoutPanel1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinFlowLayoutPanel1.DownBack = null;
            this.skinFlowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.skinFlowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.skinFlowLayoutPanel1.MouseBack = null;
            this.skinFlowLayoutPanel1.Name = "skinFlowLayoutPanel1";
            this.skinFlowLayoutPanel1.NormlBack = null;
            this.skinFlowLayoutPanel1.Size = new System.Drawing.Size(600, 69);
            this.skinFlowLayoutPanel1.TabIndex = 29;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.skinFlowLayoutPanel1.SetFlowBreak(this.label, true);
            this.label.Font = new System.Drawing.Font("思源黑体 Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label.ForeColor = System.Drawing.Color.White;
            this.label.Location = new System.Drawing.Point(55, 15);
            this.label.Margin = new System.Windows.Forms.Padding(55, 15, 0, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(124, 40);
            this.label.TabIndex = 18;
            this.label.Text = "Sign Up";
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Font = new System.Drawing.Font("思源黑体 Regular", 12F);
            this.infoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.infoLabel.Location = new System.Drawing.Point(46, 84);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(0, 24);
            this.infoLabel.TabIndex = 32;
            // 
            // skinPanel2
            // 
            this.skinPanel2.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel2.Controls.Add(this.PictureBox1);
            this.skinPanel2.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel2.DownBack = null;
            this.skinPanel2.Location = new System.Drawing.Point(50, 120);
            this.skinPanel2.Margin = new System.Windows.Forms.Padding(43, 145, 3, 3);
            this.skinPanel2.MouseBack = null;
            this.skinPanel2.Name = "skinPanel2";
            this.skinPanel2.NormlBack = null;
            this.skinPanel2.Radius = 15;
            this.skinPanel2.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinPanel2.Size = new System.Drawing.Size(140, 140);
            this.skinPanel2.TabIndex = 33;
            // 
            // SignUpControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.skinPanel2);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.skinFlowLayoutPanel1);
            this.Controls.Add(this.skinButton1);
            this.Controls.Add(this.SCPassword);
            this.Controls.Add(this.SPassword);
            this.Controls.Add(this.SUsername);
            this.Controls.Add(this.signUpButton);
            this.Controls.Add(this.skinLabel3);
            this.Controls.Add(this.skinLabel2);
            this.Controls.Add(this.skinLabel1);
            this.DoubleBuffered = true;
            this.Name = "SignUpControl";
            this.Size = new System.Drawing.Size(600, 365);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.skinFlowLayoutPanel1.ResumeLayout(false);
            this.skinFlowLayoutPanel1.PerformLayout();
            this.skinPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinButton skinButton1;
        private System.Windows.Forms.TextBox SCPassword;
        private System.Windows.Forms.TextBox SPassword;
        private System.Windows.Forms.TextBox SUsername;
        private CCWin.SkinControl.SkinPictureBox PictureBox1;
        private CCWin.SkinControl.SkinButton signUpButton;
        private CCWin.SkinControl.SkinLabel skinLabel3;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinFlowLayoutPanel skinFlowLayoutPanel1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label infoLabel;
        private CCWin.SkinControl.SkinPanel skinPanel2;
    }
}
