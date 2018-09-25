using System.Windows.Forms.VisualStyles;

namespace μScore
{
    partial class ScoreControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScoreControl));
            this.titleLabel = new System.Windows.Forms.Label();
            this.musicianLabel = new System.Windows.Forms.Label();
            this.sourceLabel = new System.Windows.Forms.Label();
            this.updateBtn = new CCWin.SkinControl.SkinButton();
            this.deleteBtn = new CCWin.SkinControl.SkinButton();
            this.Content = new System.Windows.Forms.RichTextBox();
            this.editorBtn = new CCWin.SkinControl.SkinButton();
            this.infoLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.demoLabel = new System.Windows.Forms.LinkLabel();
            this.skinFlowLayoutPanel1 = new CCWin.SkinControl.SkinFlowLayoutPanel();
            this.skinFlowLayoutPanel2 = new CCWin.SkinControl.SkinFlowLayoutPanel();
            this.favoriteBtn = new CCWin.SkinControl.SkinButton();
            this.skinFlowLayoutPanel1.SuspendLayout();
            this.skinFlowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.skinFlowLayoutPanel1.SetFlowBreak(this.titleLabel, true);
            this.titleLabel.Font = new System.Drawing.Font("思源黑体 Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(55, 10);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(55, 10, 0, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(80, 40);
            this.titleLabel.TabIndex = 18;
            this.titleLabel.Text = "Title";
            // 
            // musicianLabel
            // 
            this.musicianLabel.AutoSize = true;
            this.musicianLabel.Font = new System.Drawing.Font("思源黑体 Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.musicianLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.musicianLabel.Location = new System.Drawing.Point(59, 55);
            this.musicianLabel.Margin = new System.Windows.Forms.Padding(59, 5, 15, 0);
            this.musicianLabel.Name = "musicianLabel";
            this.musicianLabel.Size = new System.Drawing.Size(75, 24);
            this.musicianLabel.TabIndex = 17;
            this.musicianLabel.Text = "Musician";
            // 
            // sourceLabel
            // 
            this.sourceLabel.AutoSize = true;
            this.sourceLabel.Font = new System.Drawing.Font("思源黑体 Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sourceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.sourceLabel.Location = new System.Drawing.Point(154, 55);
            this.sourceLabel.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.sourceLabel.Name = "sourceLabel";
            this.sourceLabel.Size = new System.Drawing.Size(63, 24);
            this.sourceLabel.TabIndex = 16;
            this.sourceLabel.Text = "Source";
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.Color.Transparent;
            this.updateBtn.BaseColor = System.Drawing.Color.Transparent;
            this.updateBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.updateBtn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.updateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateBtn.DownBack = null;
            this.updateBtn.DownBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(159)))), ((int)(((byte)(234)))));
            this.updateBtn.FadeGlow = false;
            this.updateBtn.Font = new System.Drawing.Font("思源黑体 Regular", 12F);
            this.updateBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.updateBtn.GlowColor = System.Drawing.Color.Transparent;
            this.updateBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.updateBtn.InnerBorderColor = System.Drawing.Color.Transparent;
            this.updateBtn.IsDrawGlass = false;
            this.updateBtn.Location = new System.Drawing.Point(37, 50);
            this.updateBtn.Margin = new System.Windows.Forms.Padding(3, 50, 3, 0);
            this.updateBtn.MouseBack = null;
            this.updateBtn.MouseBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(159)))), ((int)(((byte)(234)))));
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.NormlBack = null;
            this.updateBtn.Size = new System.Drawing.Size(83, 34);
            this.updateBtn.TabIndex = 19;
            this.updateBtn.TabStop = false;
            this.updateBtn.Text = "Update";
            this.updateBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.Transparent;
            this.deleteBtn.BaseColor = System.Drawing.Color.Transparent;
            this.deleteBtn.BorderColor = System.Drawing.Color.Transparent;
            this.deleteBtn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.deleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteBtn.DownBack = null;
            this.deleteBtn.DownBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(159)))), ((int)(((byte)(234)))));
            this.deleteBtn.FadeGlow = false;
            this.deleteBtn.Font = new System.Drawing.Font("思源黑体 Regular", 12F);
            this.deleteBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.deleteBtn.GlowColor = System.Drawing.Color.Transparent;
            this.deleteBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteBtn.InnerBorderColor = System.Drawing.Color.Transparent;
            this.deleteBtn.IsDrawBorder = false;
            this.deleteBtn.IsDrawGlass = false;
            this.deleteBtn.Location = new System.Drawing.Point(128, 50);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(5, 50, 3, 0);
            this.deleteBtn.MouseBack = null;
            this.deleteBtn.MouseBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(159)))), ((int)(((byte)(234)))));
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.NormlBack = null;
            this.deleteBtn.Size = new System.Drawing.Size(68, 34);
            this.deleteBtn.TabIndex = 20;
            this.deleteBtn.TabStop = false;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // Content
            // 
            this.Content.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.Content.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Content.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Content.DetectUrls = false;
            this.Content.Font = new System.Drawing.Font("思源黑体 Normal", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Content.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Content.Location = new System.Drawing.Point(63, 89);
            this.Content.Margin = new System.Windows.Forms.Padding(0);
            this.Content.Name = "Content";
            this.Content.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.Content.Size = new System.Drawing.Size(907, 676);
            this.Content.TabIndex = 11;
            this.Content.TabStop = false;
            this.Content.Text = "";
            this.Content.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtBox_MouseClick);
            this.Content.TextChanged += new System.EventHandler(this.txtBox_TextChanged);
            this.Content.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Content_KeyPress);
            // 
            // editorBtn
            // 
            this.editorBtn.BackColor = System.Drawing.Color.Transparent;
            this.editorBtn.BaseColor = System.Drawing.Color.Transparent;
            this.editorBtn.BorderColor = System.Drawing.Color.White;
            this.editorBtn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.editorBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editorBtn.DownBack = null;
            this.editorBtn.DownBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(159)))), ((int)(((byte)(234)))));
            this.editorBtn.FadeGlow = false;
            this.editorBtn.Font = new System.Drawing.Font("思源黑体 Regular", 12F);
            this.editorBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.editorBtn.GlowColor = System.Drawing.Color.Transparent;
            this.editorBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editorBtn.InnerBorderColor = System.Drawing.Color.Transparent;
            this.editorBtn.IsDrawGlass = false;
            this.editorBtn.Location = new System.Drawing.Point(204, 50);
            this.editorBtn.Margin = new System.Windows.Forms.Padding(5, 50, 5, 0);
            this.editorBtn.MouseBack = null;
            this.editorBtn.MouseBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(159)))), ((int)(((byte)(234)))));
            this.editorBtn.Name = "editorBtn";
            this.editorBtn.NormlBack = null;
            this.editorBtn.Size = new System.Drawing.Size(95, 34);
            this.editorBtn.TabIndex = 21;
            this.editorBtn.TabStop = false;
            this.editorBtn.Text = "To Editor";
            this.editorBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.editorBtn.UseVisualStyleBackColor = false;
            this.editorBtn.Click += new System.EventHandler(this.editorBtn_Click);
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Font = new System.Drawing.Font("思源黑体 Regular", 12F);
            this.infoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.infoLabel.Location = new System.Drawing.Point(690, 101);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(0, 24);
            this.infoLabel.TabIndex = 12;
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // demoLabel
            // 
            this.demoLabel.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.demoLabel.AutoSize = true;
            this.demoLabel.BackColor = System.Drawing.Color.Transparent;
            this.demoLabel.DisabledLinkColor = System.Drawing.Color.Transparent;
            this.demoLabel.Font = new System.Drawing.Font("思源黑体 Regular", 12F);
            this.demoLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.demoLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.demoLabel.Location = new System.Drawing.Point(610, 101);
            this.demoLabel.Name = "demoLabel";
            this.demoLabel.Size = new System.Drawing.Size(0, 24);
            this.demoLabel.TabIndex = 14;
            this.demoLabel.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.demoLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.demoLabel_LinkClicked);
            // 
            // skinFlowLayoutPanel1
            // 
            this.skinFlowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.skinFlowLayoutPanel1.Controls.Add(this.titleLabel);
            this.skinFlowLayoutPanel1.Controls.Add(this.musicianLabel);
            this.skinFlowLayoutPanel1.Controls.Add(this.sourceLabel);
            this.skinFlowLayoutPanel1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinFlowLayoutPanel1.DownBack = null;
            this.skinFlowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.skinFlowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.skinFlowLayoutPanel1.MouseBack = null;
            this.skinFlowLayoutPanel1.Name = "skinFlowLayoutPanel1";
            this.skinFlowLayoutPanel1.NormlBack = null;
            this.skinFlowLayoutPanel1.Size = new System.Drawing.Size(666, 89);
            this.skinFlowLayoutPanel1.TabIndex = 10;
            // 
            // skinFlowLayoutPanel2
            // 
            this.skinFlowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.skinFlowLayoutPanel2.Controls.Add(this.favoriteBtn);
            this.skinFlowLayoutPanel2.Controls.Add(this.updateBtn);
            this.skinFlowLayoutPanel2.Controls.Add(this.deleteBtn);
            this.skinFlowLayoutPanel2.Controls.Add(this.editorBtn);
            this.skinFlowLayoutPanel2.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinFlowLayoutPanel2.DownBack = null;
            this.skinFlowLayoutPanel2.Location = new System.Drawing.Point(666, 0);
            this.skinFlowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.skinFlowLayoutPanel2.MouseBack = null;
            this.skinFlowLayoutPanel2.Name = "skinFlowLayoutPanel2";
            this.skinFlowLayoutPanel2.NormlBack = null;
            this.skinFlowLayoutPanel2.Size = new System.Drawing.Size(304, 89);
            this.skinFlowLayoutPanel2.TabIndex = 13;
            // 
            // favoriteBtn
            // 
            this.favoriteBtn.BackColor = System.Drawing.Color.Transparent;
            this.favoriteBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("favoriteBtn.BackgroundImage")));
            this.favoriteBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.favoriteBtn.BaseColor = System.Drawing.Color.Transparent;
            this.favoriteBtn.BorderColor = System.Drawing.Color.Transparent;
            this.favoriteBtn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.favoriteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.favoriteBtn.DownBack = ((System.Drawing.Image)(resources.GetObject("favoriteBtn.DownBack")));
            this.favoriteBtn.DownBaseColor = System.Drawing.Color.Transparent;
            this.favoriteBtn.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.favoriteBtn.FadeGlow = false;
            this.favoriteBtn.ForeColor = System.Drawing.Color.Transparent;
            this.favoriteBtn.GlowColor = System.Drawing.Color.Transparent;
            this.favoriteBtn.InnerBorderColor = System.Drawing.Color.Transparent;
            this.favoriteBtn.IsDrawBorder = false;
            this.favoriteBtn.IsDrawGlass = false;
            this.favoriteBtn.Location = new System.Drawing.Point(0, 57);
            this.favoriteBtn.Margin = new System.Windows.Forms.Padding(0, 57, 10, 10);
            this.favoriteBtn.MouseBack = ((System.Drawing.Image)(resources.GetObject("favoriteBtn.MouseBack")));
            this.favoriteBtn.MouseBaseColor = System.Drawing.Color.Transparent;
            this.favoriteBtn.Name = "favoriteBtn";
            this.favoriteBtn.NormlBack = null;
            this.favoriteBtn.Size = new System.Drawing.Size(24, 24);
            this.favoriteBtn.TabIndex = 22;
            this.favoriteBtn.UseVisualStyleBackColor = false;
            this.favoriteBtn.Click += new System.EventHandler(this.favoriteBtn_Click);
            // 
            // ScoreControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.demoLabel);
            this.Controls.Add(this.skinFlowLayoutPanel2);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.Content);
            this.Controls.Add(this.skinFlowLayoutPanel1);
            this.DoubleBuffered = true;
            this.Name = "ScoreControl";
            this.Size = new System.Drawing.Size(970, 765);
            this.skinFlowLayoutPanel1.ResumeLayout(false);
            this.skinFlowLayoutPanel1.PerformLayout();
            this.skinFlowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox Content;
        private CCWin.SkinControl.SkinButton updateBtn;
        private CCWin.SkinControl.SkinButton deleteBtn;
        private System.Windows.Forms.Label sourceLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label musicianLabel;
        private CCWin.SkinControl.SkinButton editorBtn;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.LinkLabel demoLabel;
        private CCWin.SkinControl.SkinButton favoriteBtn;
        private CCWin.SkinControl.SkinFlowLayoutPanel skinFlowLayoutPanel1;
        private CCWin.SkinControl.SkinFlowLayoutPanel skinFlowLayoutPanel2;
    }
}
