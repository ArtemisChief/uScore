namespace μScore
{
    partial class LoginControl
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
            this.password = new System.Windows.Forms.TextBox();
            this.signUpButton = new CCWin.SkinControl.SkinButton();
            this.loginButton = new CCWin.SkinControl.SkinButton();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.skinFlowLayoutPanel1 = new CCWin.SkinControl.SkinFlowLayoutPanel();
            this.label = new System.Windows.Forms.Label();
            this.PictureBox1 = new CCWin.SkinControl.SkinPictureBox();
            this.autoLogin = new System.Windows.Forms.CheckBox();
            this.rememberPwd = new System.Windows.Forms.CheckBox();
            this.UserName = new System.Windows.Forms.ComboBox();
            this.infoLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.skinPanel2 = new CCWin.SkinControl.SkinPanel();
            this.skinFlowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.skinPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("思源黑体 Regular", 13F);
            this.password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.password.Location = new System.Drawing.Point(332, 175);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(207, 33);
            this.password.TabIndex = 2;
            // 
            // signUpButton
            // 
            this.signUpButton.BackColor = System.Drawing.Color.Transparent;
            this.signUpButton.BaseColor = System.Drawing.Color.Transparent;
            this.signUpButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.signUpButton.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.signUpButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signUpButton.DownBack = null;
            this.signUpButton.DownBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.signUpButton.FadeGlow = false;
            this.signUpButton.Font = new System.Drawing.Font("思源黑体 Regular", 13F);
            this.signUpButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.signUpButton.GlowColor = System.Drawing.Color.Transparent;
            this.signUpButton.InnerBorderColor = System.Drawing.Color.Transparent;
            this.signUpButton.IsDrawGlass = false;
            this.signUpButton.Location = new System.Drawing.Point(269, 289);
            this.signUpButton.Margin = new System.Windows.Forms.Padding(2);
            this.signUpButton.MouseBack = null;
            this.signUpButton.MouseBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.NormlBack = null;
            this.signUpButton.Size = new System.Drawing.Size(100, 40);
            this.signUpButton.TabIndex = 15;
            this.signUpButton.TabStop = false;
            this.signUpButton.Text = "Sign Up";
            this.signUpButton.UseVisualStyleBackColor = false;
            this.signUpButton.Click += new System.EventHandler(this.signUpButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.Transparent;
            this.loginButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.loginButton.BorderColor = System.Drawing.Color.Transparent;
            this.loginButton.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButton.DownBack = null;
            this.loginButton.DownBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(159)))), ((int)(((byte)(234)))));
            this.loginButton.FadeGlow = false;
            this.loginButton.Font = new System.Drawing.Font("思源黑体 Regular", 13F);
            this.loginButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.loginButton.GlowColor = System.Drawing.Color.Transparent;
            this.loginButton.InnerBorderColor = System.Drawing.Color.Transparent;
            this.loginButton.IsDrawGlass = false;
            this.loginButton.Location = new System.Drawing.Point(434, 289);
            this.loginButton.Margin = new System.Windows.Forms.Padding(2);
            this.loginButton.MouseBack = null;
            this.loginButton.MouseBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(159)))), ((int)(((byte)(234)))));
            this.loginButton.Name = "loginButton";
            this.loginButton.NormlBack = null;
            this.loginButton.Size = new System.Drawing.Size(100, 40);
            this.loginButton.TabIndex = 14;
            this.loginButton.TabStop = false;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
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
            this.skinLabel2.TabIndex = 13;
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
            this.skinLabel1.TabIndex = 12;
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
            this.skinFlowLayoutPanel1.TabIndex = 30;
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
            this.label.Size = new System.Drawing.Size(95, 40);
            this.label.TabIndex = 18;
            this.label.Text = "Login";
            // 
            // PictureBox1
            // 
            this.PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.PictureBox1.Image = global::μScore.Properties.Resources.head;
            this.PictureBox1.Location = new System.Drawing.Point(0, 0);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(140, 140);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox1.TabIndex = 25;
            this.PictureBox1.TabStop = false;
            // 
            // autoLogin
            // 
            this.autoLogin.AutoSize = true;
            this.autoLogin.Font = new System.Drawing.Font("思源黑体 Regular", 10F);
            this.autoLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.autoLogin.Location = new System.Drawing.Point(434, 227);
            this.autoLogin.Name = "autoLogin";
            this.autoLogin.Size = new System.Drawing.Size(97, 24);
            this.autoLogin.TabIndex = 4;
            this.autoLogin.Text = "Auto Login";
            this.autoLogin.UseVisualStyleBackColor = true;
            this.autoLogin.CheckedChanged += new System.EventHandler(this.autoLogin_CheckedChanged);
            // 
            // rememberPwd
            // 
            this.rememberPwd.AutoSize = true;
            this.rememberPwd.Font = new System.Drawing.Font("思源黑体 Regular", 10F);
            this.rememberPwd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.rememberPwd.Location = new System.Drawing.Point(239, 227);
            this.rememberPwd.Name = "rememberPwd";
            this.rememberPwd.Size = new System.Drawing.Size(167, 24);
            this.rememberPwd.TabIndex = 3;
            this.rememberPwd.Text = "Remember Password";
            this.rememberPwd.UseVisualStyleBackColor = true;
            this.rememberPwd.CheckedChanged += new System.EventHandler(this.rememberPwd_CheckedChanged);
            // 
            // UserName
            // 
            this.UserName.Font = new System.Drawing.Font("思源黑体 Regular", 13F);
            this.UserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.UserName.FormattingEnabled = true;
            this.UserName.Location = new System.Drawing.Point(332, 123);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(207, 33);
            this.UserName.TabIndex = 1;
            this.UserName.SelectedIndexChanged += new System.EventHandler(this.UserName_SelectedIndexChanged);
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Font = new System.Drawing.Font("思源黑体 Regular", 12F);
            this.infoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.infoLabel.Location = new System.Drawing.Point(46, 84);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(0, 24);
            this.infoLabel.TabIndex = 31;
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
            this.skinPanel2.TabIndex = 34;
            // 
            // LoginControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.skinPanel2);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.autoLogin);
            this.Controls.Add(this.rememberPwd);
            this.Controls.Add(this.skinFlowLayoutPanel1);
            this.Controls.Add(this.password);
            this.Controls.Add(this.signUpButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.skinLabel2);
            this.Controls.Add(this.skinLabel1);
            this.DoubleBuffered = true;
            this.Name = "LoginControl";
            this.Size = new System.Drawing.Size(600, 365);
            this.skinFlowLayoutPanel1.ResumeLayout(false);
            this.skinFlowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.skinPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox password;
        private CCWin.SkinControl.SkinButton signUpButton;
        private CCWin.SkinControl.SkinButton loginButton;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinFlowLayoutPanel skinFlowLayoutPanel1;
        private System.Windows.Forms.Label label;
        private CCWin.SkinControl.SkinPictureBox PictureBox1;
        private System.Windows.Forms.CheckBox autoLogin;
        private System.Windows.Forms.CheckBox rememberPwd;
        private System.Windows.Forms.ComboBox UserName;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Timer timer1;
        private CCWin.SkinControl.SkinPanel skinPanel2;
    }
}
