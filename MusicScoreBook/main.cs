using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using CCWin;
using MySql.Data.MySqlClient;

namespace μScore
{
    public partial class main : CCSkinMain
    {
        public static Sign sign;
        public static ScoreControl Score;
        public static ScoreTableControl ScoreTable;
        public static FavoriteControl Favorite;
        public static TranspositionControl Transposition;
        public static EditorControl Editor;
        public static SettingControl Setting;

        public static Image avatarImage;

        public main(Sign s)
        {
            InitializeComponent();
            sign = s;
            Score = new ScoreControl(this);
            ScoreTable = new ScoreTableControl(this);
            Favorite = new FavoriteControl(this);
            Transposition = new TranspositionControl(this);
            Editor = new EditorControl(this);
            Setting=new SettingControl(this);
            changePanel(ScoreTable);
        }

        //显示头像
        public void showUser(int userID)
        {
            string readHead = "select picture from users where userID='" + userID + "';";
            using (MySqlCommand cmd = new MySqlCommand(readHead, Sign.conn))
            {
                MySqlDataReader myReader = null;
                myReader = cmd.ExecuteReader();
                myReader.Read();
                MemoryStream buf = new MemoryStream((byte[])myReader[0]);
                avatarImage = Image.FromStream(buf, true);
                avatar.Image = avatarImage;
                myReader.Close();
            }
        }

        #region 自定义标题栏移动
        private bool isMouseDown = false;
        private Point FormLocation;
        private Point mouseOffset;

        private void skinFlowLayoutPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = true;
                FormLocation = this.Location;
                mouseOffset = Control.MousePosition;
            }
        }

        private void skinFlowLayoutPanel1_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
        }

        private void skinFlowLayoutPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            int _x = 0;
            int _y = 0;
            if (isMouseDown)
            {
                Point pt = Control.MousePosition;
                _x = mouseOffset.X - pt.X;
                _y = mouseOffset.Y - pt.Y;

                this.Location = new Point(FormLocation.X - _x, FormLocation.Y - _y);
            }
        }
        #endregion

        #region 自定义标题栏按钮
        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void maximum_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void minimal_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        #endregion

        //切换面板
        public void changePanel(UserControl control)
        {
            skinPanel1.Controls.Clear();
            skinPanel1.Controls.Add(control);
        }

        //Score Table按钮
        private void scoreTabBtn_MouseDown(object sender, MouseEventArgs e)
        {
            if (skinPanel1.Contains(ScoreTable))
                return;

            changePanel(ScoreTable);
        }

        //Favorite按钮
        private void favoriteBtn_MouseDown(object sender, MouseEventArgs e)
        {
            if (skinPanel1.Contains(Favorite))
                return;

            changePanel(Favorite);
        }

        //Score按钮
        private void scoreBtn_MouseDown(object sender, MouseEventArgs e)
        {
            if (skinPanel1.Contains(Score))
                return;

            changePanel(Score);
        }

        //Transposition按钮
        private void transpBtn_MouseDown(object sender, MouseEventArgs e)
        {
            if (skinPanel1.Contains(Transposition))
                return;

            changePanel(Transposition);
        }

        //Editor按钮
        private void editorBtn_MouseDown(object sender, MouseEventArgs e)
        {
            if (skinPanel1.Contains(Editor))
                return;

            changePanel(Editor);
        }

        //Setting按钮
        private void settingBtn_MouseDown(object sender, MouseEventArgs e)
        {
            if (skinPanel1.Contains(Setting))
                return;

            changePanel(Setting);

            Setting.changeChecked(Sign.userTheme);


        }

        //按钮变色
        private void skinPanel1_ControlAdded(object sender, ControlEventArgs e)
        {
            //Score Table
            if (skinPanel1.Contains(ScoreTable))
            {
                scoreTabBtn.BackColor = Theme.MainColor1;
                scoreTabBtn.MouseBaseColor = Theme.MainColor1;
                scoreTabBtn.ForeColor = Color.FromArgb(250,250,250);
                scoreTabBtn.Image = scoreTabBtn.NormlBack;
            }
            else
            {
                scoreTabBtn.BackColor = Color.Transparent;
                scoreTabBtn.MouseBaseColor = Color.FromArgb(228, 228, 228);
                scoreTabBtn.ForeColor = Color.FromArgb(102, 102, 102);
                scoreTabBtn.Image = scoreTabBtn.MouseBack;
            }

            //My Favorite
            if (skinPanel1.Contains(Favorite))
            {
                favoriteBtn.BackColor = Theme.MainColor1;
                favoriteBtn.MouseBaseColor = Theme.MainColor1;
                favoriteBtn.ForeColor = Color.FromArgb(250, 250, 250);
                favoriteBtn.Image = favoriteBtn.NormlBack;
            }
            else
            {
                favoriteBtn.BackColor = Color.Transparent;
                favoriteBtn.MouseBaseColor = Color.FromArgb(228, 228, 228);
                favoriteBtn.ForeColor = Color.FromArgb(102, 102, 102);
                favoriteBtn.Image = favoriteBtn.MouseBack;
            }

            //Score
            if (skinPanel1.Contains(Score))
            {
                scoreBtn.BackColor = Theme.MainColor1;
                scoreBtn.MouseBaseColor = Theme.MainColor1;
                scoreBtn.ForeColor = Color.FromArgb(250, 250, 250);
                scoreBtn.Image = scoreBtn.NormlBack;
            }
            else
            {
                scoreBtn.BackColor = Color.Transparent;
                scoreBtn.MouseBaseColor = Color.FromArgb(228, 228, 228);
                scoreBtn.ForeColor = Color.FromArgb(102, 102, 102);
                scoreBtn.Image = scoreBtn.MouseBack;
            }

            //Editor
            if (skinPanel1.Contains(Editor))
            {
                editorBtn.BackColor = Theme.MainColor1;
                editorBtn.MouseBaseColor = Theme.MainColor1;
                editorBtn.ForeColor = Color.FromArgb(250, 250, 250);
                editorBtn.Image = editorBtn.NormlBack;
            }
            else
            {
                editorBtn.BackColor = Color.Transparent;
                editorBtn.MouseBaseColor = Color.FromArgb(228, 228, 228);
                editorBtn.ForeColor = Color.FromArgb(102, 102, 102);
                editorBtn.Image = editorBtn.MouseBack;
            }

            //Transportation
            if (skinPanel1.Contains(Transposition))
            {
                transpBtn.BackColor = Theme.MainColor1;
                transpBtn.MouseBaseColor = Theme.MainColor1;
                transpBtn.ForeColor = Color.FromArgb(250, 250, 250);
                transpBtn.Image = transpBtn.NormlBack;
            }
            else
            {
                transpBtn.BackColor = Color.Transparent;
                transpBtn.MouseBaseColor = Color.FromArgb(228, 228, 228);
                transpBtn.ForeColor = Color.FromArgb(102, 102, 102);
                transpBtn.Image = transpBtn.MouseBack;
            }

            //Setting
            if (skinPanel1.Contains(Setting))
            {
                settingBtn.BackColor = Theme.MainColor1;
                settingBtn.MouseBaseColor = Theme.MainColor1;
                settingBtn.ForeColor = Color.FromArgb(250, 250, 250);
                settingBtn.Image = settingBtn.NormlBack;
            }
            else
            {
                settingBtn.BackColor = Color.Transparent;
                settingBtn.MouseBaseColor = Color.FromArgb(228, 228, 228);
                settingBtn.ForeColor = Color.FromArgb(102, 102, 102);
                settingBtn.Image = settingBtn.MouseBack;
            }
        }

        //搜索框文字输入触发计时器
        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            timer1.Stop();     //每一次改变文字先停止计时器
            timer1.Start();    //然后启动计时器，相当于每一次改变文字会打断之前的计时
        }

        //搜索框文字停止输入0.3秒之后显示结果
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();     //必须先停下计时器，否则仍在不断倒计时

            ScoreTable.getScore(searchBox.Text);

            if (skinPanel1.Contains(ScoreTable))
                return;
            changePanel(ScoreTable);
        }

        //点击搜索按钮 （毫无存在意义的搜索按钮)
        private void searchBtn_Click(object sender, EventArgs e)
        {
            ScoreTable.getScore(searchBox.Text);

            if (skinPanel1.Contains(ScoreTable))
                return;
            changePanel(ScoreTable);
        }

        //部件换色
        public void changeColor()
        {
            skinFlowLayoutPanel1.BackColor = Theme.MainColor2;
            skinFlowLayoutPanel4.BackColor = Theme.MainColor5;
            searchPanel.BackColor = Theme.MainColor3;
            searchBox.BackColor = Theme.MainColor3;
            searchBox.WaterColor = Theme.MainColor6;
            close.BackgroundImage = Theme.CloseImage;
            minimal.BackgroundImage = Theme.MinimalImage;
            maximum.BackgroundImage = Theme.MaximumImage;
            searctBtn.BackgroundImage = Theme.SearchImage;

            if (skinPanel1.Contains(Setting))
            {
                settingBtn.BackColor = Theme.MainColor1;
                settingBtn.MouseBaseColor = Theme.MainColor1;
                settingBtn.ForeColor = Color.FromArgb(250, 250, 250);
                settingBtn.Image = settingBtn.NormlBack;
            }

            scoreTabBtn.DownBaseColor = Theme.MainColor1;
            favoriteBtn.DownBaseColor = Theme.MainColor1;
            scoreBtn.DownBaseColor = Theme.MainColor1;
            editorBtn.DownBaseColor = Theme.MainColor1;
            transpBtn.DownBaseColor = Theme.MainColor1;
            settingBtn.DownBaseColor = Theme.MainColor1;
        }

        //用于和Sign窗口对立出现，一方出现一方就消失
        public void main_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible)
                sign.Visible = false;
            else
                sign.Visible = true;
        }

        //记录使用时间
        private int recordTime;
        private void timer2_Tick(object sender, EventArgs e)
        {
            recordTime += 1;
            if (recordTime < 60)
            {
                recordLabel.Text = "Use Time: " + recordTime + " s";
                return;
            }
            if (recordTime < 60 * 60)
            {
                recordLabel.Text = "Use Time: " + Math.Round(recordTime / 60.0) + " min  " +
                                   Math.Round(recordTime % 60.0) + " s";
                return;
            }
            recordLabel.Text = "Use Time: " + Math.Round(recordTime / (60.0 * 60.0)) + " h  " +
                               Math.Round((recordTime % (60.0 * 60.0)) / 60) + " min";
        }
        
    }
}
