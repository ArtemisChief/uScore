using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;

namespace μScore
{
    public partial class ScoreControl : UserControl
    {
        private main Main;
        private bool isFavorite;

        //本页当前显示的谱子的ID
        private int scoreID;

        public ScoreControl(main m)
        {
            InitializeComponent();
            Main = m;
        }

        //清除本页所有数据
        public void clear()
        {
            titleLabel.Text = "Title";
            musicianLabel.Text = "Musician";
            sourceLabel.Text = "Source";
            Content.Text = "";
            favoriteBtn.BackgroundImage = Properties.Resources.notFavoriteNormal;
            favoriteBtn.DownBack = Properties.Resources.notFavoritePress;
            favoriteBtn.MouseBack = Properties.Resources.notFavoritePress;
            isReadyToModify = false;
            isModified = false;
            scoreID = 0;
        }

        //得到Score表数据并添加到对应位置
        public void showScore(int scoreID)
        {
            this.scoreID = scoreID;
            isReadyToModify = false;
            string read1 = "select scoreTitle, sourceTitle, musicianName, content, demoAddress " +
                           "from score " +
                           "join source on score.sourceID=source.sourceID " +
                           "join musician on score.musicianID=musician.musicianID " +
                           "where scoreID='" + scoreID + "';";
            using (MySqlCommand cmd = new MySqlCommand(read1, Sign.conn))
            {
                MySqlDataReader myReader = null;
                try
                {
                    myReader = cmd.ExecuteReader();
                    myReader.Read();
                    if (myReader.HasRows)
                    {
                        titleLabel.Text = myReader.GetString(0);
                        sourceLabel.Text = "From: 《" + myReader.GetString(1) + "》";
                        musicianLabel.Text = "By: " + myReader.GetString(2);
                        Content.Text = myReader.GetString(3);
                        if (!myReader.IsDBNull(4))
                        {
                            demoLabel.Text = myReader.GetString(4);
                            demoLabel.Location = new Point(942 - demoLabel.Width, 98);
                        }
                        else
                            demoLabel.Text = "";
                    }
                }
                catch (MySqlException exception)
                {
                    MessageBox.Show(exception.ToString());
                }
                finally
                {
                    if (sourceLabel.Text == "From: 《None》" || sourceLabel.Text == "From: 《Unknown》")
                    {
                        sourceLabel.Visible = false;
                    }
                    else
                    {
                        sourceLabel.Visible = true;
                    }
                    myReader.Close();
                }
            }

            string favorite = "select scoreID " +
                              "from favorite " +
                              "where scoreID='" + scoreID + "' and " +
                              "userID='" + Sign.userID + "';";
            using (MySqlCommand cmd = new MySqlCommand(favorite, Sign.conn))
            {
                MySqlDataReader myReader = null;
                try
                {
                    myReader = cmd.ExecuteReader();
                    myReader.Read();
                    if (myReader.HasRows)
                    {
                        isFavorite = true;
                        favoriteBtn.BackgroundImage = Properties.Resources.favoriteNormal;
                        favoriteBtn.DownBack = Properties.Resources.favoritePress;
                        favoriteBtn.MouseBack = Properties.Resources.favoritePress;
                    }
                    else
                    {
                        isFavorite = false;
                        favoriteBtn.BackgroundImage = Properties.Resources.notFavoriteNormal;
                        favoriteBtn.DownBack = Properties.Resources.notFavoritePress;
                        favoriteBtn.MouseBack = Properties.Resources.notFavoritePress;
                    }
                }
                catch (MySqlException exception)
                {
                    MessageBox.Show(exception.ToString());
                }
                finally
                {
                    myReader.Close();
                }
            }

            isModified = false;
        }

        //更新乐谱内容
        private void updateBtn_Click(object sender, EventArgs e)
        {
            #region 检测是否进行了修改

            if (!isModified)
            {
                showInfo("No changes have been made", Theme.MainColor4);
                return;
            }

            #endregion

            if (scoreID == 0)
            {
                showInfo("You can only modify the score here", Theme.MainColor4);
                return;
            }

            string contentChange = "update score set content='" + Content.Text +
                                   "' where scoreID='" + scoreID + "';";
            using (MySqlCommand cmd = new MySqlCommand(contentChange, Sign.conn))
            {
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (MySqlException exp)
                {
                    MessageBox.Show(exp.ToString());
                    return;
                }

                isReadyToModify = false;
                isModified = false;
                showInfo("Update Successfully", Theme.MainColor1);
            }
        }

        //删除该乐谱
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult YN;
            YN = MessageBox.Show("确定要删除该曲谱吗？", "确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (YN == DialogResult.Cancel)
                return;

            if (scoreID == 0)
            {
                showInfo("This score doesn't exist", Theme.MainColor4);
                return;
            }

            #region 检查是否有权限删除该Score
            string chkAuthority = "select createrID " +
                                  "from score " +
                                  "where scoreID=" + scoreID + ";";
            int createrID = 0;
            using (MySqlCommand cmd = new MySqlCommand(chkAuthority, Sign.conn))
            {
                MySqlDataReader myReader = null;
                try
                {
                    myReader = cmd.ExecuteReader();
                    myReader.Read();
                    createrID = myReader.GetInt32(0);
                    if (Sign.userID != createrID)
                    {
                        showInfo("You don't have the authority to delete this score", Theme.MainColor4);
                        return;
                    }
                }
                catch (MySqlException exception)
                {
                    MessageBox.Show(exception.ToString());
                    return;
                }
                finally
                {
                    myReader.Close();
                }
            }
            #endregion

            #region 检查该Score对应的Album是否还有其他Score相应，返回对应的数量和albumID

            string chkAlbum = "select albumID " +
                              "from score " +
                              "where albumID=" +
                              "(select albumID " +
                              "from score " +
                              "where scoreID='" + scoreID + "');";
            int albumQuantity = 0;
            int albumID = 0;
            using (MySqlCommand cmd = new MySqlCommand(chkAlbum, Sign.conn))
            {
                MySqlDataReader myReader = null;
                try
                {
                    myReader = cmd.ExecuteReader();
                    while (myReader.Read())
                    {
                        if (myReader.HasRows)
                        {
                            albumQuantity++;
                            albumID = myReader.GetInt32(0);
                        }
                    }
                }
                catch (MySqlException exception)
                {
                    MessageBox.Show(exception.ToString());
                    return;
                }
                finally
                {
                    myReader.Close();
                }
            }

            #endregion

            #region 检查该Score对应的Musician是否还有其他Score相应，返回对应的数量和musicianID

            string chkMusician = "select musicianID " +
                                 "from score " +
                                 "where musicianID=" +
                                 "(select musicianID " +
                                 "from score " +
                                 "where scoreID='" + scoreID + "');";
            int musicianQuantity = 0;
            int musicianID = 0;
            using (MySqlCommand cmd = new MySqlCommand(chkMusician, Sign.conn))
            {
                MySqlDataReader myReader = null;
                try
                {
                    myReader = cmd.ExecuteReader();
                    while (myReader.Read())
                    {
                        if (myReader.HasRows)
                        {
                            musicianQuantity++;
                            musicianID = myReader.GetInt32(0);
                        }
                    }
                }
                catch (MySqlException exception)
                {
                    MessageBox.Show(exception.ToString());
                    return;
                }
                finally
                {
                    myReader.Close();
                }
            }

            #endregion

            #region 检查该Score对应的source是否还有其他Score相应，返回对应的数量和sourceID

            string chkSource = "select sourceID " +
                               "from score " +
                               "where sourceID=" +
                               "(select sourceID " +
                               "from score " +
                               "where scoreID='" + scoreID + "');";
            int sourceQuantity = 0;
            int sourceID = 0;
            using (MySqlCommand cmd = new MySqlCommand(chkSource, Sign.conn))
            {
                MySqlDataReader myReader = null;
                try
                {
                    myReader = cmd.ExecuteReader();
                    while (myReader.Read())
                    {
                        if (myReader.HasRows)
                        {
                            sourceQuantity++;
                            sourceID = myReader.GetInt32(0);
                        }
                    }
                }
                catch (MySqlException exception)
                {
                    MessageBox.Show(exception.ToString());
                    return;
                }
                finally
                {
                    myReader.Close();
                }
            }

            #endregion

            #region 删除在Favorite中的该ScoreID

            string deleteFavorite = "delete from favorite " +
                                    "where scoreID='" + scoreID + "';";
            using (MySqlCommand cmd2 = new MySqlCommand(deleteFavorite, Sign.conn))
            {
                try
                {
                    cmd2.ExecuteNonQuery();

                }
                catch (MySqlException exp)
                {
                    MessageBox.Show(exp.ToString());
                }
            }

            #endregion

            #region 删除该Score

            string deleteScore = "delete from score " +
                                 "where scoreID='" + scoreID + "';";
            using (MySqlCommand cmd2 = new MySqlCommand(deleteScore, Sign.conn))
            {
                try
                {
                    cmd2.ExecuteNonQuery();

                }
                catch (MySqlException exp)
                {
                    MessageBox.Show(exp.ToString());
                }
            }

            #endregion

            #region 根据Album对应的Score数量决定是否删除该Album

            if (albumQuantity - 1 == 0)
            {
                string deleteAlbum = "delete from album where albumID='" + albumID + "';";
                using (MySqlCommand cmd3 = new MySqlCommand(deleteAlbum, Sign.conn))
                {
                    try
                    {
                        cmd3.ExecuteNonQuery();
                    }
                    catch (MySqlException exp)
                    {
                        MessageBox.Show(exp.ToString());
                        return;
                    }
                }
                main.Editor.getAlbum();
            }

            #endregion

            #region 根据Musician对应的Score数量决定是否删除该Musician

            if (musicianQuantity - 1 == 0)
            {
                string deleteMusician = "delete from musician where musicianID='" + musicianID + "';";
                using (MySqlCommand cmd3 = new MySqlCommand(deleteMusician, Sign.conn))
                {
                    try
                    {
                        cmd3.ExecuteNonQuery();
                    }
                    catch (MySqlException exp)
                    {
                        MessageBox.Show(exp.ToString());
                        return;
                    }
                }
                main.Editor.getMusician();
            }

            #endregion

            #region 根据Source对应的Score数量决定是否删除该Source

            if (sourceQuantity - 1 == 0)
            {
                string deleteSource = "delete from source where sourceID='" + sourceID + "';";
                using (MySqlCommand cmd3 = new MySqlCommand(deleteSource, Sign.conn))
                {
                    try
                    {
                        cmd3.ExecuteNonQuery();
                    }
                    catch (MySqlException exp)
                    {
                        MessageBox.Show(exp.ToString());
                        return;
                    }
                }
                main.Editor.getSource();
            }

            #endregion

            clear();
            main.Editor.clear();

            main.ScoreTable.getScore("");
            main.Favorite.getScore();
            Main.changePanel(main.ScoreTable);
        }

        //跳转到Editor
        private void editorBtn_Click(object sender, EventArgs e)
        {
            if (scoreID == 0)
            {
                showInfo("This score doesn't exist", Theme.MainColor4);
                return;
            }

            main.Editor.showScore(scoreID);
            Main.changePanel(main.Editor);

        }

        //显示信息文字
        private void showInfo(string info, Color color)
        {
            infoLabel.ForeColor = color;
            infoLabel.Text = info;
            if (demoLabel.Text.Equals(""))
                infoLabel.Location = new Point(942 - infoLabel.Width, 98);
            else
                infoLabel.Location = new Point(942 - infoLabel.Width, 128);
            timer1.Stop();
            timer1.Start();
        }

        //处理文字2秒后消失的计时器
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            infoLabel.Text = "";
        }

        //点击链接打开默认浏览器跳转页面
        private void demoLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(demoLabel.Text);
        }

        #region 在本地检测是否修改了谱子

        private bool isReadyToModify;
        private bool isModified;

        private void txtBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (isReadyToModify)
                return;

            isReadyToModify = true;
        }

        private void txtBox_TextChanged(object sender, EventArgs e)
        {
            if (isReadyToModify)
            {
                isModified = true;
                showInfo("Modifying...", Theme.MainColor1);
            }
        }

        #endregion

        //收藏按钮
        private void favoriteBtn_Click(object sender, EventArgs e)
        {
            if (scoreID == 0)
            {
                showInfo("This score doesn't exist", Theme.MainColor4);
                return;
            }

            if (isFavorite)
            {
                string deleteFavorite = "delete from favorite " +
                                        "where userID='" + Sign.userID + "' " +
                                        "and scoreID='" + scoreID + "';";
                using (MySqlCommand cmd = new MySqlCommand(deleteFavorite, Sign.conn))
                {
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (MySqlException exp)
                    {
                        MessageBox.Show(exp.ToString());
                        return;
                    }
                }
                favoriteBtn.BackgroundImage = Properties.Resources.notFavoriteNormal;
                favoriteBtn.DownBack = Properties.Resources.notFavoritePress;
                favoriteBtn.MouseBack = Properties.Resources.notFavoritePress;
                isFavorite = false;
                showInfo("Cancel from favorite Successfully", Theme.MainColor1);
            }
            else
            {
                string addFavorite = "insert into favorite (userID, scoreID) values ('"
                                     + Sign.userID + "', '"
                                     + scoreID + "');";
                using (MySqlCommand cmd = new MySqlCommand(addFavorite, Sign.conn))
                {
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (MySqlException exp)
                    {
                        MessageBox.Show(exp.ToString());
                        return;
                    }
                }
                favoriteBtn.BackgroundImage = Properties.Resources.favoriteNormal;
                favoriteBtn.DownBack = Properties.Resources.favoritePress;
                favoriteBtn.MouseBack = Properties.Resources.favoritePress;
                isFavorite = true;
                showInfo("Add to favorite Successfully", Theme.MainColor1);
            }

            main.Favorite.getScore();
        }

        //部件换色
        public void changeColor()
        {
            skinFlowLayoutPanel1.BackColor = Theme.MainColor1;
            skinFlowLayoutPanel2.BackColor = Theme.MainColor1;
            updateBtn.MouseBaseColor = Theme.MainColor3;
            updateBtn.DownBaseColor = Theme.MainColor3;
            deleteBtn.MouseBaseColor = Theme.MainColor3;
            deleteBtn.DownBaseColor = Theme.MainColor3;
            editorBtn.MouseBaseColor = Theme.MainColor3;
            editorBtn.DownBaseColor = Theme.MainColor3;
            demoLabel.LinkColor = Theme.MainColor1;
            demoLabel.ActiveLinkColor = Theme.MainColor1;
            demoLabel.VisitedLinkColor = Theme.MainColor1;
        }

        //限制输入
        private void Content_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\'' || e.KeyChar == ';' || e.KeyChar == '"')
            {
                e.Handled = true;
            }
        }
    }
}