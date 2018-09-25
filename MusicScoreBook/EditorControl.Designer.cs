namespace μScore
{
    partial class EditorControl
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
            this.skinFlowLayoutPanel1 = new CCWin.SkinControl.SkinFlowLayoutPanel();
            this.titleTxtBox = new System.Windows.Forms.TextBox();
            this.demoTxtBox = new System.Windows.Forms.TextBox();
            this.uploadBtn = new CCWin.SkinControl.SkinButton();
            this.clearBtn = new CCWin.SkinControl.SkinButton();
            this.deleteBtn = new CCWin.SkinControl.SkinButton();
            this.scoreBtn = new CCWin.SkinControl.SkinButton();
            this.musicianComboBox = new System.Windows.Forms.ComboBox();
            this.sourceComboBox = new System.Windows.Forms.ComboBox();
            this.Content = new System.Windows.Forms.RichTextBox();
            this.TonalityComboBox = new System.Windows.Forms.ComboBox();
            this.albumComboBox = new System.Windows.Forms.ComboBox();
            this.infoLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.skinFlowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // skinFlowLayoutPanel1
            // 
            this.skinFlowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.skinFlowLayoutPanel1.Controls.Add(this.titleTxtBox);
            this.skinFlowLayoutPanel1.Controls.Add(this.demoTxtBox);
            this.skinFlowLayoutPanel1.Controls.Add(this.uploadBtn);
            this.skinFlowLayoutPanel1.Controls.Add(this.clearBtn);
            this.skinFlowLayoutPanel1.Controls.Add(this.deleteBtn);
            this.skinFlowLayoutPanel1.Controls.Add(this.scoreBtn);
            this.skinFlowLayoutPanel1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinFlowLayoutPanel1.DownBack = null;
            this.skinFlowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.skinFlowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.skinFlowLayoutPanel1.MouseBack = null;
            this.skinFlowLayoutPanel1.Name = "skinFlowLayoutPanel1";
            this.skinFlowLayoutPanel1.NormlBack = null;
            this.skinFlowLayoutPanel1.Size = new System.Drawing.Size(970, 89);
            this.skinFlowLayoutPanel1.TabIndex = 11;
            // 
            // titleTxtBox
            // 
            this.titleTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.titleTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinFlowLayoutPanel1.SetFlowBreak(this.titleTxtBox, true);
            this.titleTxtBox.Font = new System.Drawing.Font("思源黑体 Medium", 20.25F, System.Drawing.FontStyle.Bold);
            this.titleTxtBox.ForeColor = System.Drawing.Color.White;
            this.titleTxtBox.Location = new System.Drawing.Point(62, 10);
            this.titleTxtBox.Margin = new System.Windows.Forms.Padding(62, 10, 0, 0);
            this.titleTxtBox.Name = "titleTxtBox";
            this.titleTxtBox.Size = new System.Drawing.Size(254, 40);
            this.titleTxtBox.TabIndex = 23;
            this.titleTxtBox.TabStop = false;
            this.titleTxtBox.Text = "Title";
            this.titleTxtBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtBox_MouseClick);
            this.titleTxtBox.TextChanged += new System.EventHandler(this.titleTxtBox_TextChanged);
            this.titleTxtBox.Enter += new System.EventHandler(this.titleTxtBox_Enter);
            this.titleTxtBox.Leave += new System.EventHandler(this.titleTxtBox_Leave);
            // 
            // demoTxtBox
            // 
            this.demoTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.demoTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.demoTxtBox.Font = new System.Drawing.Font("思源黑体 Regular", 12F, System.Drawing.FontStyle.Underline);
            this.demoTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.demoTxtBox.Location = new System.Drawing.Point(64, 55);
            this.demoTxtBox.Margin = new System.Windows.Forms.Padding(64, 5, 0, 0);
            this.demoTxtBox.Name = "demoTxtBox";
            this.demoTxtBox.Size = new System.Drawing.Size(389, 24);
            this.demoTxtBox.TabIndex = 31;
            this.demoTxtBox.TabStop = false;
            this.demoTxtBox.Text = "Demo Address (Keep this if none)";
            this.demoTxtBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtBox_MouseClick);
            this.demoTxtBox.TextChanged += new System.EventHandler(this.demoTxtBox_TextChanged);
            this.demoTxtBox.Enter += new System.EventHandler(this.demoTxtBox_Enter);
            this.demoTxtBox.Leave += new System.EventHandler(this.demoTxtBox_Leave);
            // 
            // uploadBtn
            // 
            this.uploadBtn.BackColor = System.Drawing.Color.Transparent;
            this.uploadBtn.BaseColor = System.Drawing.Color.Transparent;
            this.uploadBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.uploadBtn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.uploadBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uploadBtn.DownBack = null;
            this.uploadBtn.DownBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(155)))), ((int)(((byte)(229)))));
            this.uploadBtn.FadeGlow = false;
            this.uploadBtn.Font = new System.Drawing.Font("思源黑体 Regular", 12F);
            this.uploadBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.uploadBtn.GlowColor = System.Drawing.Color.Transparent;
            this.uploadBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uploadBtn.InnerBorderColor = System.Drawing.Color.Transparent;
            this.uploadBtn.IsDrawGlass = false;
            this.uploadBtn.Location = new System.Drawing.Point(629, 50);
            this.uploadBtn.Margin = new System.Windows.Forms.Padding(176, 0, 3, 0);
            this.uploadBtn.MouseBack = null;
            this.uploadBtn.MouseBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(155)))), ((int)(((byte)(229)))));
            this.uploadBtn.Name = "uploadBtn";
            this.uploadBtn.NormlBack = null;
            this.uploadBtn.Size = new System.Drawing.Size(83, 34);
            this.uploadBtn.TabIndex = 19;
            this.uploadBtn.TabStop = false;
            this.uploadBtn.Text = "Upload";
            this.uploadBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.uploadBtn.UseVisualStyleBackColor = false;
            this.uploadBtn.Click += new System.EventHandler(this.uploadBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.Transparent;
            this.clearBtn.BaseColor = System.Drawing.Color.Transparent;
            this.clearBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.clearBtn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.clearBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearBtn.DownBack = null;
            this.clearBtn.DownBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(155)))), ((int)(((byte)(229)))));
            this.clearBtn.FadeGlow = false;
            this.clearBtn.Font = new System.Drawing.Font("思源黑体 Regular", 12F);
            this.clearBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.clearBtn.GlowColor = System.Drawing.Color.Transparent;
            this.clearBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clearBtn.InnerBorderColor = System.Drawing.Color.Transparent;
            this.clearBtn.IsDrawBorder = false;
            this.clearBtn.IsDrawGlass = false;
            this.clearBtn.Location = new System.Drawing.Point(718, 50);
            this.clearBtn.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.clearBtn.MouseBack = null;
            this.clearBtn.MouseBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(155)))), ((int)(((byte)(229)))));
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.NormlBack = null;
            this.clearBtn.Size = new System.Drawing.Size(68, 34);
            this.clearBtn.TabIndex = 33;
            this.clearBtn.TabStop = false;
            this.clearBtn.Text = "Clear";
            this.clearBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.Transparent;
            this.deleteBtn.BaseColor = System.Drawing.Color.Transparent;
            this.deleteBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.deleteBtn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.deleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteBtn.DownBack = null;
            this.deleteBtn.DownBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(155)))), ((int)(((byte)(229)))));
            this.deleteBtn.FadeGlow = false;
            this.deleteBtn.Font = new System.Drawing.Font("思源黑体 Regular", 12F);
            this.deleteBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.deleteBtn.GlowColor = System.Drawing.Color.Transparent;
            this.deleteBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteBtn.InnerBorderColor = System.Drawing.Color.Transparent;
            this.deleteBtn.IsDrawBorder = false;
            this.deleteBtn.IsDrawGlass = false;
            this.deleteBtn.Location = new System.Drawing.Point(792, 50);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(3, 0, 5, 0);
            this.deleteBtn.MouseBack = null;
            this.deleteBtn.MouseBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(155)))), ((int)(((byte)(229)))));
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
            // scoreBtn
            // 
            this.scoreBtn.BackColor = System.Drawing.Color.Transparent;
            this.scoreBtn.BaseColor = System.Drawing.Color.Transparent;
            this.scoreBtn.BorderColor = System.Drawing.Color.White;
            this.scoreBtn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.scoreBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.scoreBtn.DownBack = null;
            this.scoreBtn.DownBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(155)))), ((int)(((byte)(229)))));
            this.scoreBtn.FadeGlow = false;
            this.scoreBtn.Font = new System.Drawing.Font("思源黑体 Regular", 12F);
            this.scoreBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.scoreBtn.GlowColor = System.Drawing.Color.Transparent;
            this.scoreBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.scoreBtn.InnerBorderColor = System.Drawing.Color.Transparent;
            this.scoreBtn.IsDrawGlass = false;
            this.scoreBtn.Location = new System.Drawing.Point(875, 50);
            this.scoreBtn.Margin = new System.Windows.Forms.Padding(10, 0, 5, 0);
            this.scoreBtn.MouseBack = null;
            this.scoreBtn.MouseBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(155)))), ((int)(((byte)(229)))));
            this.scoreBtn.Name = "scoreBtn";
            this.scoreBtn.NormlBack = null;
            this.scoreBtn.Size = new System.Drawing.Size(90, 34);
            this.scoreBtn.TabIndex = 32;
            this.scoreBtn.TabStop = false;
            this.scoreBtn.Text = "To Score";
            this.scoreBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.scoreBtn.UseVisualStyleBackColor = false;
            this.scoreBtn.Click += new System.EventHandler(this.scoreBtn_Click);
            // 
            // musicianComboBox
            // 
            this.musicianComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.musicianComboBox.DropDownHeight = 360;
            this.musicianComboBox.Font = new System.Drawing.Font("思源黑体 Regular", 12F);
            this.musicianComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.musicianComboBox.FormattingEnabled = true;
            this.musicianComboBox.IntegralHeight = false;
            this.musicianComboBox.Items.AddRange(new object[] {
            "C",
            "C#",
            "D",
            "D#",
            "E",
            "F",
            "F#",
            "G",
            "G#",
            "A",
            "A#",
            "B"});
            this.musicianComboBox.Location = new System.Drawing.Point(281, 102);
            this.musicianComboBox.Margin = new System.Windows.Forms.Padding(20);
            this.musicianComboBox.Name = "musicianComboBox";
            this.musicianComboBox.Size = new System.Drawing.Size(178, 32);
            this.musicianComboBox.TabIndex = 31;
            this.musicianComboBox.TabStop = false;
            this.musicianComboBox.Text = "Musician";
            this.musicianComboBox.TextChanged += new System.EventHandler(this.musicianComboBox_TextChanged);
            this.musicianComboBox.Enter += new System.EventHandler(this.musicianComboBox_Enter);
            this.musicianComboBox.Leave += new System.EventHandler(this.musicianComboBox_Leave);
            this.musicianComboBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtBox_MouseClick);
            // 
            // sourceComboBox
            // 
            this.sourceComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.sourceComboBox.DropDownHeight = 360;
            this.sourceComboBox.Font = new System.Drawing.Font("思源黑体 Regular", 12F);
            this.sourceComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.sourceComboBox.FormattingEnabled = true;
            this.sourceComboBox.IntegralHeight = false;
            this.sourceComboBox.Items.AddRange(new object[] {
            "C",
            "C#",
            "D",
            "D#",
            "E",
            "F",
            "F#",
            "G",
            "G#",
            "A",
            "A#",
            "B"});
            this.sourceComboBox.Location = new System.Drawing.Point(63, 102);
            this.sourceComboBox.Margin = new System.Windows.Forms.Padding(20);
            this.sourceComboBox.Name = "sourceComboBox";
            this.sourceComboBox.Size = new System.Drawing.Size(178, 32);
            this.sourceComboBox.TabIndex = 32;
            this.sourceComboBox.TabStop = false;
            this.sourceComboBox.Text = "Source";
            this.sourceComboBox.TextChanged += new System.EventHandler(this.sourceComboBox_TextChanged);
            this.sourceComboBox.Enter += new System.EventHandler(this.sourceComboBox_Enter);
            this.sourceComboBox.Leave += new System.EventHandler(this.sourceComboBox_Leave);
            this.sourceComboBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtBox_MouseClick);
            // 
            // Content
            // 
            this.Content.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.Content.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Content.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Content.DetectUrls = false;
            this.Content.Font = new System.Drawing.Font("思源黑体 Normal", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Content.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Content.Location = new System.Drawing.Point(63, 141);
            this.Content.Margin = new System.Windows.Forms.Padding(5);
            this.Content.Name = "Content";
            this.Content.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.Content.Size = new System.Drawing.Size(900, 624);
            this.Content.TabIndex = 27;
            this.Content.TabStop = false;
            this.Content.Text = "Type your score here...";
            this.Content.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtBox_MouseClick);
            this.Content.TextChanged += new System.EventHandler(this.Content_TextChanged);
            this.Content.Enter += new System.EventHandler(this.Content_Enter);
            this.Content.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Content_KeyPress);
            this.Content.Leave += new System.EventHandler(this.Content_Leave);
            // 
            // TonalityComboBox
            // 
            this.TonalityComboBox.DropDownHeight = 360;
            this.TonalityComboBox.Font = new System.Drawing.Font("思源黑体 Regular", 12F);
            this.TonalityComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.TonalityComboBox.FormattingEnabled = true;
            this.TonalityComboBox.IntegralHeight = false;
            this.TonalityComboBox.Items.AddRange(new object[] {
            "C",
            "C#",
            "D",
            "D#",
            "E",
            "F",
            "F#",
            "G",
            "G#",
            "A",
            "A#",
            "B"});
            this.TonalityComboBox.Location = new System.Drawing.Point(499, 102);
            this.TonalityComboBox.Margin = new System.Windows.Forms.Padding(20);
            this.TonalityComboBox.Name = "TonalityComboBox";
            this.TonalityComboBox.Size = new System.Drawing.Size(178, 32);
            this.TonalityComboBox.TabIndex = 29;
            this.TonalityComboBox.TabStop = false;
            this.TonalityComboBox.Text = "Tonality";
            this.TonalityComboBox.TextChanged += new System.EventHandler(this.TonalityComboBox_TextChanged);
            this.TonalityComboBox.Enter += new System.EventHandler(this.TonalityComboBox_Enter);
            this.TonalityComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TonalityComboBox_KeyPress);
            this.TonalityComboBox.Leave += new System.EventHandler(this.TonalityComboBox_Leave);
            this.TonalityComboBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtBox_MouseClick);
            // 
            // albumComboBox
            // 
            this.albumComboBox.DropDownHeight = 360;
            this.albumComboBox.Font = new System.Drawing.Font("思源黑体 Regular", 12F);
            this.albumComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.albumComboBox.FormattingEnabled = true;
            this.albumComboBox.IntegralHeight = false;
            this.albumComboBox.Items.AddRange(new object[] {
            "C",
            "C#",
            "D",
            "D#",
            "E",
            "F",
            "F#",
            "G",
            "G#",
            "A",
            "A#",
            "B"});
            this.albumComboBox.Location = new System.Drawing.Point(717, 102);
            this.albumComboBox.Margin = new System.Windows.Forms.Padding(20);
            this.albumComboBox.Name = "albumComboBox";
            this.albumComboBox.Size = new System.Drawing.Size(178, 32);
            this.albumComboBox.TabIndex = 30;
            this.albumComboBox.TabStop = false;
            this.albumComboBox.Text = "Album";
            this.albumComboBox.TextChanged += new System.EventHandler(this.albumComboBox_TextChanged);
            this.albumComboBox.Enter += new System.EventHandler(this.albumComboBox_Enter);
            this.albumComboBox.Leave += new System.EventHandler(this.albumComboBox_Leave);
            this.albumComboBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtBox_MouseClick);
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Font = new System.Drawing.Font("思源黑体 Regular", 12F);
            this.infoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.infoLabel.Location = new System.Drawing.Point(723, 149);
            this.infoLabel.Margin = new System.Windows.Forms.Padding(15);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(0, 24);
            this.infoLabel.TabIndex = 31;
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // EditorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.albumComboBox);
            this.Controls.Add(this.musicianComboBox);
            this.Controls.Add(this.sourceComboBox);
            this.Controls.Add(this.TonalityComboBox);
            this.Controls.Add(this.Content);
            this.Controls.Add(this.skinFlowLayoutPanel1);
            this.DoubleBuffered = true;
            this.Name = "EditorControl";
            this.Size = new System.Drawing.Size(970, 765);
            this.skinFlowLayoutPanel1.ResumeLayout(false);
            this.skinFlowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CCWin.SkinControl.SkinButton uploadBtn;
        private CCWin.SkinControl.SkinButton deleteBtn;
        private System.Windows.Forms.TextBox titleTxtBox;
        private System.Windows.Forms.RichTextBox Content;
        private System.Windows.Forms.ComboBox TonalityComboBox;
        private System.Windows.Forms.ComboBox albumComboBox;
        private System.Windows.Forms.ComboBox musicianComboBox;
        private System.Windows.Forms.ComboBox sourceComboBox;
        private System.Windows.Forms.TextBox demoTxtBox;
        private System.Windows.Forms.Label infoLabel;
        private CCWin.SkinControl.SkinButton scoreBtn;
        private System.Windows.Forms.Timer timer1;
        private CCWin.SkinControl.SkinButton clearBtn;
        private CCWin.SkinControl.SkinFlowLayoutPanel skinFlowLayoutPanel1;
    }
}
