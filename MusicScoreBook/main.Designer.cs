namespace μScore
{
    partial class main
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.skinPanel1 = new CCWin.SkinControl.SkinPanel();
            this.skinFlowLayoutPanel1 = new CCWin.SkinControl.SkinFlowLayoutPanel();
            this.close = new CCWin.SkinControl.SkinButton();
            this.maximum = new CCWin.SkinControl.SkinButton();
            this.minimal = new CCWin.SkinControl.SkinButton();
            this.skinFlowLayoutPanel2 = new CCWin.SkinControl.SkinFlowLayoutPanel();
            this.skinPanel2 = new CCWin.SkinControl.SkinPanel();
            this.avatar = new System.Windows.Forms.PictureBox();
            this.scoreTabBtn = new CCWin.SkinControl.SkinButton();
            this.favoriteBtn = new CCWin.SkinControl.SkinButton();
            this.scoreBtn = new CCWin.SkinControl.SkinButton();
            this.editorBtn = new CCWin.SkinControl.SkinButton();
            this.transpBtn = new CCWin.SkinControl.SkinButton();
            this.settingBtn = new CCWin.SkinControl.SkinButton();
            this.recordLabel = new System.Windows.Forms.Label();
            this.skinFlowLayoutPanel4 = new CCWin.SkinControl.SkinFlowLayoutPanel();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.skinFlowLayoutPanel3 = new CCWin.SkinControl.SkinFlowLayoutPanel();
            this.searchBox = new CCWin.SkinControl.SkinWaterTextBox();
            this.searchPanel = new CCWin.SkinControl.SkinPanel();
            this.searctBtn = new CCWin.SkinControl.SkinButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.skinFlowLayoutPanel1.SuspendLayout();
            this.skinFlowLayoutPanel2.SuspendLayout();
            this.skinPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).BeginInit();
            this.skinFlowLayoutPanel4.SuspendLayout();
            this.searchPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // skinPanel1
            // 
            this.skinPanel1.AutoScroll = true;
            this.skinPanel1.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel1.DownBack = null;
            this.skinPanel1.Location = new System.Drawing.Point(230, 35);
            this.skinPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.skinPanel1.MouseBack = null;
            this.skinPanel1.Name = "skinPanel1";
            this.skinPanel1.NormlBack = null;
            this.skinPanel1.Radius = 7;
            this.skinPanel1.RoundStyle = CCWin.SkinClass.RoundStyle.BottomRight;
            this.skinPanel1.Size = new System.Drawing.Size(970, 765);
            this.skinPanel1.TabIndex = 1;
            this.skinPanel1.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.skinPanel1_ControlAdded);
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
            this.skinFlowLayoutPanel1.Size = new System.Drawing.Size(1200, 35);
            this.skinFlowLayoutPanel1.TabIndex = 5;
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
            this.close.Location = new System.Drawing.Point(1170, 10);
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
            this.maximum.Location = new System.Drawing.Point(1139, 10);
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
            this.minimal.Location = new System.Drawing.Point(1108, 10);
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
            // skinFlowLayoutPanel2
            // 
            this.skinFlowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.skinFlowLayoutPanel2.Controls.Add(this.skinPanel2);
            this.skinFlowLayoutPanel2.Controls.Add(this.scoreTabBtn);
            this.skinFlowLayoutPanel2.Controls.Add(this.favoriteBtn);
            this.skinFlowLayoutPanel2.Controls.Add(this.scoreBtn);
            this.skinFlowLayoutPanel2.Controls.Add(this.editorBtn);
            this.skinFlowLayoutPanel2.Controls.Add(this.transpBtn);
            this.skinFlowLayoutPanel2.Controls.Add(this.settingBtn);
            this.skinFlowLayoutPanel2.Controls.Add(this.recordLabel);
            this.skinFlowLayoutPanel2.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinFlowLayoutPanel2.DownBack = null;
            this.skinFlowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.skinFlowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.skinFlowLayoutPanel2.MouseBack = null;
            this.skinFlowLayoutPanel2.Name = "skinFlowLayoutPanel2";
            this.skinFlowLayoutPanel2.NormlBack = null;
            this.skinFlowLayoutPanel2.Radius = 7;
            this.skinFlowLayoutPanel2.RoundStyle = CCWin.SkinClass.RoundStyle.Left;
            this.skinFlowLayoutPanel2.Size = new System.Drawing.Size(230, 800);
            this.skinFlowLayoutPanel2.TabIndex = 6;
            // 
            // skinPanel2
            // 
            this.skinPanel2.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel2.Controls.Add(this.avatar);
            this.skinPanel2.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel2.DownBack = null;
            this.skinPanel2.Location = new System.Drawing.Point(43, 145);
            this.skinPanel2.Margin = new System.Windows.Forms.Padding(43, 145, 3, 3);
            this.skinPanel2.MouseBack = null;
            this.skinPanel2.Name = "skinPanel2";
            this.skinPanel2.NormlBack = null;
            this.skinPanel2.Radius = 15;
            this.skinPanel2.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinPanel2.Size = new System.Drawing.Size(140, 140);
            this.skinPanel2.TabIndex = 0;
            // 
            // avatar
            // 
            this.avatar.Image = ((System.Drawing.Image)(resources.GetObject("avatar.Image")));
            this.avatar.Location = new System.Drawing.Point(0, 0);
            this.avatar.Margin = new System.Windows.Forms.Padding(0);
            this.avatar.Name = "avatar";
            this.avatar.Size = new System.Drawing.Size(140, 140);
            this.avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.avatar.TabIndex = 7;
            this.avatar.TabStop = false;
            // 
            // scoreTabBtn
            // 
            this.scoreTabBtn.BackColor = System.Drawing.Color.Transparent;
            this.scoreTabBtn.BaseColor = System.Drawing.Color.Transparent;
            this.scoreTabBtn.BorderColor = System.Drawing.Color.Transparent;
            this.scoreTabBtn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.scoreTabBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.scoreTabBtn.DownBack = null;
            this.scoreTabBtn.DownBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.scoreTabBtn.FadeGlow = false;
            this.scoreTabBtn.Font = new System.Drawing.Font("思源黑体 Normal", 11F);
            this.scoreTabBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.scoreTabBtn.GlowColor = System.Drawing.Color.Transparent;
            this.scoreTabBtn.Image = ((System.Drawing.Image)(resources.GetObject("scoreTabBtn.Image")));
            this.scoreTabBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.scoreTabBtn.ImageSize = new System.Drawing.Size(16, 16);
            this.scoreTabBtn.InnerBorderColor = System.Drawing.Color.Transparent;
            this.scoreTabBtn.IsDrawBorder = false;
            this.scoreTabBtn.IsDrawGlass = false;
            this.scoreTabBtn.Location = new System.Drawing.Point(25, 318);
            this.scoreTabBtn.Margin = new System.Windows.Forms.Padding(25, 30, 3, 3);
            this.scoreTabBtn.MouseBack = ((System.Drawing.Image)(resources.GetObject("scoreTabBtn.MouseBack")));
            this.scoreTabBtn.MouseBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.scoreTabBtn.Name = "scoreTabBtn";
            this.scoreTabBtn.NormlBack = ((System.Drawing.Image)(resources.GetObject("scoreTabBtn.NormlBack")));
            this.scoreTabBtn.Size = new System.Drawing.Size(168, 35);
            this.scoreTabBtn.TabIndex = 0;
            this.scoreTabBtn.TabStop = false;
            this.scoreTabBtn.Text = " Score Table";
            this.scoreTabBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.scoreTabBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.scoreTabBtn.UseVisualStyleBackColor = false;
            this.scoreTabBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.scoreTabBtn_MouseDown);
            // 
            // favoriteBtn
            // 
            this.favoriteBtn.BackColor = System.Drawing.Color.Transparent;
            this.favoriteBtn.BaseColor = System.Drawing.Color.Transparent;
            this.favoriteBtn.BorderColor = System.Drawing.Color.Transparent;
            this.favoriteBtn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.favoriteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.favoriteBtn.DownBack = null;
            this.favoriteBtn.DownBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.favoriteBtn.FadeGlow = false;
            this.favoriteBtn.Font = new System.Drawing.Font("思源黑体 Normal", 11F);
            this.favoriteBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.favoriteBtn.GlowColor = System.Drawing.Color.Transparent;
            this.favoriteBtn.Image = ((System.Drawing.Image)(resources.GetObject("favoriteBtn.Image")));
            this.favoriteBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.favoriteBtn.ImageSize = new System.Drawing.Size(16, 16);
            this.favoriteBtn.InnerBorderColor = System.Drawing.Color.Transparent;
            this.favoriteBtn.IsDrawBorder = false;
            this.favoriteBtn.IsDrawGlass = false;
            this.favoriteBtn.Location = new System.Drawing.Point(25, 371);
            this.favoriteBtn.Margin = new System.Windows.Forms.Padding(25, 15, 3, 3);
            this.favoriteBtn.MouseBack = ((System.Drawing.Image)(resources.GetObject("favoriteBtn.MouseBack")));
            this.favoriteBtn.MouseBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.favoriteBtn.Name = "favoriteBtn";
            this.favoriteBtn.NormlBack = ((System.Drawing.Image)(resources.GetObject("favoriteBtn.NormlBack")));
            this.favoriteBtn.Size = new System.Drawing.Size(168, 35);
            this.favoriteBtn.TabIndex = 5;
            this.favoriteBtn.TabStop = false;
            this.favoriteBtn.Text = " My Favorite";
            this.favoriteBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.favoriteBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.favoriteBtn.UseVisualStyleBackColor = false;
            this.favoriteBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.favoriteBtn_MouseDown);
            // 
            // scoreBtn
            // 
            this.scoreBtn.BackColor = System.Drawing.Color.Transparent;
            this.scoreBtn.BaseColor = System.Drawing.Color.Transparent;
            this.scoreBtn.BorderColor = System.Drawing.Color.Transparent;
            this.scoreBtn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.scoreBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.scoreBtn.DownBack = null;
            this.scoreBtn.DownBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.scoreBtn.FadeGlow = false;
            this.scoreBtn.Font = new System.Drawing.Font("思源黑体 Normal", 11F);
            this.scoreBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.scoreBtn.GlowColor = System.Drawing.Color.Transparent;
            this.scoreBtn.Image = ((System.Drawing.Image)(resources.GetObject("scoreBtn.Image")));
            this.scoreBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.scoreBtn.ImageSize = new System.Drawing.Size(16, 16);
            this.scoreBtn.InnerBorderColor = System.Drawing.Color.Transparent;
            this.scoreBtn.IsDrawBorder = false;
            this.scoreBtn.IsDrawGlass = false;
            this.scoreBtn.Location = new System.Drawing.Point(25, 424);
            this.scoreBtn.Margin = new System.Windows.Forms.Padding(25, 15, 3, 3);
            this.scoreBtn.MouseBack = ((System.Drawing.Image)(resources.GetObject("scoreBtn.MouseBack")));
            this.scoreBtn.MouseBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.scoreBtn.Name = "scoreBtn";
            this.scoreBtn.NormlBack = ((System.Drawing.Image)(resources.GetObject("scoreBtn.NormlBack")));
            this.scoreBtn.Size = new System.Drawing.Size(168, 35);
            this.scoreBtn.TabIndex = 2;
            this.scoreBtn.TabStop = false;
            this.scoreBtn.Text = " Score";
            this.scoreBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.scoreBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.scoreBtn.UseVisualStyleBackColor = false;
            this.scoreBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.scoreBtn_MouseDown);
            // 
            // editorBtn
            // 
            this.editorBtn.BackColor = System.Drawing.Color.Transparent;
            this.editorBtn.BaseColor = System.Drawing.Color.Transparent;
            this.editorBtn.BorderColor = System.Drawing.Color.Transparent;
            this.editorBtn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.editorBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editorBtn.DownBack = null;
            this.editorBtn.DownBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.editorBtn.FadeGlow = false;
            this.editorBtn.Font = new System.Drawing.Font("思源黑体 Normal", 11F);
            this.editorBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.editorBtn.GlowColor = System.Drawing.Color.Transparent;
            this.editorBtn.Image = ((System.Drawing.Image)(resources.GetObject("editorBtn.Image")));
            this.editorBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editorBtn.ImageSize = new System.Drawing.Size(16, 16);
            this.editorBtn.InnerBorderColor = System.Drawing.Color.Transparent;
            this.editorBtn.IsDrawBorder = false;
            this.editorBtn.IsDrawGlass = false;
            this.editorBtn.Location = new System.Drawing.Point(25, 477);
            this.editorBtn.Margin = new System.Windows.Forms.Padding(25, 15, 3, 3);
            this.editorBtn.MouseBack = ((System.Drawing.Image)(resources.GetObject("editorBtn.MouseBack")));
            this.editorBtn.MouseBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.editorBtn.Name = "editorBtn";
            this.editorBtn.NormlBack = ((System.Drawing.Image)(resources.GetObject("editorBtn.NormlBack")));
            this.editorBtn.Size = new System.Drawing.Size(168, 35);
            this.editorBtn.TabIndex = 4;
            this.editorBtn.TabStop = false;
            this.editorBtn.Text = " Editor";
            this.editorBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editorBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.editorBtn.UseVisualStyleBackColor = false;
            this.editorBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.editorBtn_MouseDown);
            // 
            // transpBtn
            // 
            this.transpBtn.BackColor = System.Drawing.Color.Transparent;
            this.transpBtn.BaseColor = System.Drawing.Color.Transparent;
            this.transpBtn.BorderColor = System.Drawing.Color.Transparent;
            this.transpBtn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.transpBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transpBtn.DownBack = null;
            this.transpBtn.DownBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.transpBtn.FadeGlow = false;
            this.transpBtn.Font = new System.Drawing.Font("思源黑体 Normal", 11F);
            this.transpBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.transpBtn.GlowColor = System.Drawing.Color.Transparent;
            this.transpBtn.Image = ((System.Drawing.Image)(resources.GetObject("transpBtn.Image")));
            this.transpBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.transpBtn.ImageSize = new System.Drawing.Size(16, 16);
            this.transpBtn.InnerBorderColor = System.Drawing.Color.Transparent;
            this.transpBtn.IsDrawBorder = false;
            this.transpBtn.IsDrawGlass = false;
            this.transpBtn.Location = new System.Drawing.Point(25, 530);
            this.transpBtn.Margin = new System.Windows.Forms.Padding(25, 15, 3, 3);
            this.transpBtn.MouseBack = ((System.Drawing.Image)(resources.GetObject("transpBtn.MouseBack")));
            this.transpBtn.MouseBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.transpBtn.Name = "transpBtn";
            this.transpBtn.NormlBack = ((System.Drawing.Image)(resources.GetObject("transpBtn.NormlBack")));
            this.transpBtn.Size = new System.Drawing.Size(168, 35);
            this.transpBtn.TabIndex = 3;
            this.transpBtn.TabStop = false;
            this.transpBtn.Text = " Transposition";
            this.transpBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.transpBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.transpBtn.UseVisualStyleBackColor = false;
            this.transpBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.transpBtn_MouseDown);
            // 
            // settingBtn
            // 
            this.settingBtn.BackColor = System.Drawing.Color.Transparent;
            this.settingBtn.BaseColor = System.Drawing.Color.Transparent;
            this.settingBtn.BorderColor = System.Drawing.Color.Transparent;
            this.settingBtn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.settingBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settingBtn.DownBack = null;
            this.settingBtn.DownBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.settingBtn.FadeGlow = false;
            this.settingBtn.Font = new System.Drawing.Font("思源黑体 Normal", 11F);
            this.settingBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.settingBtn.GlowColor = System.Drawing.Color.Transparent;
            this.settingBtn.Image = ((System.Drawing.Image)(resources.GetObject("settingBtn.Image")));
            this.settingBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingBtn.ImageSize = new System.Drawing.Size(16, 16);
            this.settingBtn.InnerBorderColor = System.Drawing.Color.Transparent;
            this.settingBtn.IsDrawBorder = false;
            this.settingBtn.IsDrawGlass = false;
            this.settingBtn.Location = new System.Drawing.Point(25, 583);
            this.settingBtn.Margin = new System.Windows.Forms.Padding(25, 15, 3, 3);
            this.settingBtn.MouseBack = ((System.Drawing.Image)(resources.GetObject("settingBtn.MouseBack")));
            this.settingBtn.MouseBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.settingBtn.Name = "settingBtn";
            this.settingBtn.NormlBack = ((System.Drawing.Image)(resources.GetObject("settingBtn.NormlBack")));
            this.settingBtn.Size = new System.Drawing.Size(168, 35);
            this.settingBtn.TabIndex = 6;
            this.settingBtn.TabStop = false;
            this.settingBtn.Text = " Setting";
            this.settingBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.settingBtn.UseVisualStyleBackColor = false;
            this.settingBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.settingBtn_MouseDown);
            // 
            // recordLabel
            // 
            this.recordLabel.AutoSize = true;
            this.skinFlowLayoutPanel2.SetFlowBreak(this.recordLabel, true);
            this.recordLabel.Font = new System.Drawing.Font("思源黑体 Normal", 11F);
            this.recordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.recordLabel.Location = new System.Drawing.Point(30, 771);
            this.recordLabel.Margin = new System.Windows.Forms.Padding(30, 150, 3, 0);
            this.recordLabel.Name = "recordLabel";
            this.recordLabel.Size = new System.Drawing.Size(81, 22);
            this.recordLabel.TabIndex = 7;
            this.recordLabel.Text = "Use Time: ";
            // 
            // skinFlowLayoutPanel4
            // 
            this.skinFlowLayoutPanel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(155)))), ((int)(((byte)(222)))));
            this.skinFlowLayoutPanel4.Controls.Add(this.skinLabel1);
            this.skinFlowLayoutPanel4.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinFlowLayoutPanel4.DownBack = null;
            this.skinFlowLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.skinFlowLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.skinFlowLayoutPanel4.MouseBack = null;
            this.skinFlowLayoutPanel4.Name = "skinFlowLayoutPanel4";
            this.skinFlowLayoutPanel4.NormlBack = null;
            this.skinFlowLayoutPanel4.RoundStyle = CCWin.SkinClass.RoundStyle.TopLeft;
            this.skinFlowLayoutPanel4.Size = new System.Drawing.Size(230, 124);
            this.skinFlowLayoutPanel4.TabIndex = 8;
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.Transparent;
            this.skinLabel1.Font = new System.Drawing.Font("思源黑体 Heavy", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.skinLabel1.Location = new System.Drawing.Point(40, 55);
            this.skinLabel1.Margin = new System.Windows.Forms.Padding(40, 55, 0, 0);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(129, 46);
            this.skinLabel1.TabIndex = 0;
            this.skinLabel1.Text = "μScore";
            // 
            // skinFlowLayoutPanel3
            // 
            this.skinFlowLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.skinFlowLayoutPanel3.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinFlowLayoutPanel3.DownBack = null;
            this.skinFlowLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.skinFlowLayoutPanel3.MouseBack = null;
            this.skinFlowLayoutPanel3.Name = "skinFlowLayoutPanel3";
            this.skinFlowLayoutPanel3.NormlBack = null;
            this.skinFlowLayoutPanel3.Radius = 7;
            this.skinFlowLayoutPanel3.RoundStyle = CCWin.SkinClass.RoundStyle.Top;
            this.skinFlowLayoutPanel3.Size = new System.Drawing.Size(1200, 124);
            this.skinFlowLayoutPanel3.TabIndex = 7;
            // 
            // searchBox
            // 
            this.searchBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(159)))), ((int)(((byte)(234)))));
            this.searchBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchBox.Font = new System.Drawing.Font("思源黑体 Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.searchBox.ForeColor = System.Drawing.Color.White;
            this.searchBox.Location = new System.Drawing.Point(11, 0);
            this.searchBox.Margin = new System.Windows.Forms.Padding(5);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(270, 30);
            this.searchBox.TabIndex = 4;
            this.searchBox.TabStop = false;
            this.searchBox.WaterColor = System.Drawing.Color.LightBlue;
            this.searchBox.WaterText = "Search by title, musician, source or album";
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // searchPanel
            // 
            this.searchPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(159)))), ((int)(((byte)(234)))));
            this.searchPanel.Controls.Add(this.searctBtn);
            this.searchPanel.Controls.Add(this.searchBox);
            this.searchPanel.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.searchPanel.DownBack = null;
            this.searchPanel.Location = new System.Drawing.Point(890, 46);
            this.searchPanel.Margin = new System.Windows.Forms.Padding(3, 127, 3, 3);
            this.searchPanel.MouseBack = null;
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.NormlBack = null;
            this.searchPanel.Radius = 25;
            this.searchPanel.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.searchPanel.Size = new System.Drawing.Size(295, 30);
            this.searchPanel.TabIndex = 5;
            // 
            // searctBtn
            // 
            this.searctBtn.BackColor = System.Drawing.Color.Transparent;
            this.searctBtn.BackgroundImage = global::μScore.Properties.Resources.searchB;
            this.searctBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.searctBtn.BaseColor = System.Drawing.Color.Transparent;
            this.searctBtn.BorderColor = System.Drawing.Color.Transparent;
            this.searctBtn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.searctBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searctBtn.DownBack = ((System.Drawing.Image)(resources.GetObject("searctBtn.DownBack")));
            this.searctBtn.DownBaseColor = System.Drawing.Color.Transparent;
            this.searctBtn.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.searctBtn.FadeGlow = false;
            this.searctBtn.ForeColor = System.Drawing.Color.Transparent;
            this.searctBtn.GlowColor = System.Drawing.Color.Transparent;
            this.searctBtn.InnerBorderColor = System.Drawing.Color.Transparent;
            this.searctBtn.IsDrawBorder = false;
            this.searctBtn.IsDrawGlass = false;
            this.searctBtn.Location = new System.Drawing.Point(265, 8);
            this.searctBtn.Margin = new System.Windows.Forms.Padding(8, 10, 15, 10);
            this.searctBtn.MouseBack = ((System.Drawing.Image)(resources.GetObject("searctBtn.MouseBack")));
            this.searctBtn.MouseBaseColor = System.Drawing.Color.Transparent;
            this.searctBtn.Name = "searctBtn";
            this.searctBtn.NormlBack = null;
            this.searctBtn.Size = new System.Drawing.Size(16, 16);
            this.searctBtn.TabIndex = 5;
            this.searctBtn.TabStop = false;
            this.searctBtn.UseVisualStyleBackColor = false;
            this.searctBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 300;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.CanResize = false;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.ControlBox = false;
            this.Controls.Add(this.searchPanel);
            this.Controls.Add(this.skinPanel1);
            this.Controls.Add(this.skinFlowLayoutPanel1);
            this.Controls.Add(this.skinFlowLayoutPanel4);
            this.Controls.Add(this.skinFlowLayoutPanel2);
            this.DropBack = false;
            this.EffectCaption = CCWin.TitleType.None;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "main";
            this.Radius = 7;
            this.ShadowWidth = 7;
            this.ShowBorder = false;
            this.ShowDrawIcon = false;
            this.Special = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "";
            this.VisibleChanged += new System.EventHandler(this.main_VisibleChanged);
            this.skinFlowLayoutPanel1.ResumeLayout(false);
            this.skinFlowLayoutPanel2.ResumeLayout(false);
            this.skinFlowLayoutPanel2.PerformLayout();
            this.skinPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).EndInit();
            this.skinFlowLayoutPanel4.ResumeLayout(false);
            this.skinFlowLayoutPanel4.PerformLayout();
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinButton scoreTabBtn;
        private CCWin.SkinControl.SkinPanel skinPanel1;
        private CCWin.SkinControl.SkinButton scoreBtn;
        private CCWin.SkinControl.SkinButton close;
        private CCWin.SkinControl.SkinButton maximum;
        private CCWin.SkinControl.SkinButton minimal;
        private CCWin.SkinControl.SkinFlowLayoutPanel skinFlowLayoutPanel2;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinFlowLayoutPanel skinFlowLayoutPanel3;
        private CCWin.SkinControl.SkinButton transpBtn;
        private CCWin.SkinControl.SkinButton searctBtn;
        private CCWin.SkinControl.SkinButton editorBtn;
        private System.Windows.Forms.Timer timer1;
        private CCWin.SkinControl.SkinButton favoriteBtn;
        private CCWin.SkinControl.SkinButton settingBtn;
        public CCWin.SkinControl.SkinFlowLayoutPanel skinFlowLayoutPanel1;
        public CCWin.SkinControl.SkinFlowLayoutPanel skinFlowLayoutPanel4;
        public CCWin.SkinControl.SkinWaterTextBox searchBox;
        public CCWin.SkinControl.SkinPanel searchPanel;
        private System.Windows.Forms.PictureBox avatar;
        private CCWin.SkinControl.SkinPanel skinPanel2;
        private System.Windows.Forms.Label recordLabel;
        private System.Windows.Forms.Timer timer2;
    }
}

