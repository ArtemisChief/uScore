namespace μScore
{
    partial class SettingNormalControl
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
            this.skinPanel2 = new CCWin.SkinControl.SkinPanel();
            this.avatar = new System.Windows.Forms.PictureBox();
            this.userAvatarLabel = new System.Windows.Forms.Label();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.changePhotoBtn = new CCWin.SkinControl.SkinButton();
            this.signOutBtn = new CCWin.SkinControl.SkinButton();
            this.skinPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // skinPanel2
            // 
            this.skinPanel2.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel2.Controls.Add(this.avatar);
            this.skinPanel2.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel2.DownBack = null;
            this.skinPanel2.Location = new System.Drawing.Point(165, 113);
            this.skinPanel2.Margin = new System.Windows.Forms.Padding(43, 145, 3, 3);
            this.skinPanel2.MouseBack = null;
            this.skinPanel2.Name = "skinPanel2";
            this.skinPanel2.NormlBack = null;
            this.skinPanel2.Radius = 15;
            this.skinPanel2.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinPanel2.Size = new System.Drawing.Size(140, 140);
            this.skinPanel2.TabIndex = 40;
            // 
            // avatar
            // 
            this.avatar.Image = global::μScore.Properties.Resources.head;
            this.avatar.Location = new System.Drawing.Point(0, 0);
            this.avatar.Name = "avatar";
            this.avatar.Size = new System.Drawing.Size(140, 140);
            this.avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.avatar.TabIndex = 26;
            this.avatar.TabStop = false;
            // 
            // userAvatarLabel
            // 
            this.userAvatarLabel.AutoSize = true;
            this.userAvatarLabel.Font = new System.Drawing.Font("思源黑体 Regular", 12F);
            this.userAvatarLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.userAvatarLabel.Location = new System.Drawing.Point(55, 229);
            this.userAvatarLabel.Name = "userAvatarLabel";
            this.userAvatarLabel.Size = new System.Drawing.Size(104, 24);
            this.userAvatarLabel.TabIndex = 39;
            this.userAvatarLabel.Text = "User Avatar: ";
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("思源黑体 Regular", 12F);
            this.userNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.userNameLabel.Location = new System.Drawing.Point(55, 44);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(155, 24);
            this.userNameLabel.TabIndex = 38;
            this.userNameLabel.Text = "User Name:     Chief";
            // 
            // changePhotoBtn
            // 
            this.changePhotoBtn.BackColor = System.Drawing.Color.Transparent;
            this.changePhotoBtn.BaseColor = System.Drawing.Color.Transparent;
            this.changePhotoBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.changePhotoBtn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.changePhotoBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changePhotoBtn.DownBack = null;
            this.changePhotoBtn.DownBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.changePhotoBtn.FadeGlow = false;
            this.changePhotoBtn.Font = new System.Drawing.Font("思源黑体 Regular", 14F);
            this.changePhotoBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.changePhotoBtn.GlowColor = System.Drawing.Color.Transparent;
            this.changePhotoBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.changePhotoBtn.InnerBorderColor = System.Drawing.Color.Transparent;
            this.changePhotoBtn.IsDrawGlass = false;
            this.changePhotoBtn.Location = new System.Drawing.Point(418, 121);
            this.changePhotoBtn.Margin = new System.Windows.Forms.Padding(15, 50, 5, 0);
            this.changePhotoBtn.MouseBack = null;
            this.changePhotoBtn.MouseBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.changePhotoBtn.Name = "changePhotoBtn";
            this.changePhotoBtn.NormlBack = null;
            this.changePhotoBtn.Size = new System.Drawing.Size(265, 41);
            this.changePhotoBtn.TabIndex = 37;
            this.changePhotoBtn.TabStop = false;
            this.changePhotoBtn.Text = "Change the Avatar";
            this.changePhotoBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.changePhotoBtn.UseVisualStyleBackColor = false;
            this.changePhotoBtn.Click += new System.EventHandler(this.changePhotoBtn_Click);
            // 
            // signOutBtn
            // 
            this.signOutBtn.BackColor = System.Drawing.Color.Transparent;
            this.signOutBtn.BaseColor = System.Drawing.Color.Transparent;
            this.signOutBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.signOutBtn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.signOutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signOutBtn.DownBack = null;
            this.signOutBtn.DownBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.signOutBtn.FadeGlow = false;
            this.signOutBtn.Font = new System.Drawing.Font("思源黑体 Regular", 14F);
            this.signOutBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.signOutBtn.GlowColor = System.Drawing.Color.Transparent;
            this.signOutBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.signOutBtn.InnerBorderColor = System.Drawing.Color.Transparent;
            this.signOutBtn.IsDrawGlass = false;
            this.signOutBtn.Location = new System.Drawing.Point(418, 212);
            this.signOutBtn.Margin = new System.Windows.Forms.Padding(15, 50, 5, 0);
            this.signOutBtn.MouseBack = null;
            this.signOutBtn.MouseBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.signOutBtn.Name = "signOutBtn";
            this.signOutBtn.NormlBack = null;
            this.signOutBtn.Size = new System.Drawing.Size(265, 41);
            this.signOutBtn.TabIndex = 36;
            this.signOutBtn.TabStop = false;
            this.signOutBtn.Text = "Sign out";
            this.signOutBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.signOutBtn.UseVisualStyleBackColor = false;
            this.signOutBtn.Click += new System.EventHandler(this.signOutBtn_Click);
            // 
            // SettingNormalControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.skinPanel2);
            this.Controls.Add(this.userAvatarLabel);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.changePhotoBtn);
            this.Controls.Add(this.signOutBtn);
            this.DoubleBuffered = true;
            this.Name = "SettingNormalControl";
            this.Size = new System.Drawing.Size(820, 300);
            this.skinPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinPanel skinPanel2;
        private System.Windows.Forms.PictureBox avatar;
        private System.Windows.Forms.Label userAvatarLabel;
        private System.Windows.Forms.Label userNameLabel;
        private CCWin.SkinControl.SkinButton changePhotoBtn;
        private CCWin.SkinControl.SkinButton signOutBtn;
    }
}
