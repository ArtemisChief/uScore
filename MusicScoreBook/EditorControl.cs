using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web.UI.Design.WebControls;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace μScore
{
    public partial class EditorControl : UserControl
    {
        private main Main;

        //本页当前显示的谱子的ID
        private int scoreID;

        public EditorControl(main m)
        {
            InitializeComponent();
            Main = m;
            getMusician();
            getSource();
            getAlbum();
        }

        //清空本页所有数据
        public void clear()
        {
            titleTxtBox.Text = "Title";
            sourceComboBox.Text = "Source";
            musicianComboBox.Text = "Musician";
            albumComboBox.Text = "Album";
            Content.Text = "Type your score here...";
            TonalityComboBox.Text = "Tonality";
            demoTxtBox.Text = "Demo Address (Keep this if none)";
            scoreID = 0;
            isReadyToModify = false;
            isModified = false;
        }

        //得到Score表数据并添加到对应位置
        public void showScore(int scoreID)
        {
            this.scoreID = scoreID;
            isReadyToModify = false;
            string read1 = "select scoreTitle, sourceTitle, musicianName, albumTitle, content, tonality, demoAddress " +
                           "from score " +
                           "join source on score.sourceID=source.sourceID " +
                           "join musician on score.musicianID=musician.musicianID " +
                           "join album on score.albumID=album.albumID " +
                           "join tonality on score.tonalityID=tonality.tonalityID " +
                           "where scoreID=" + scoreID + ";";
            using (MySqlCommand cmd = new MySqlCommand(read1, Sign.conn))
            {
                MySqlDataReader myReader = null;
                try
                {
                    myReader = cmd.ExecuteReader();
                    myReader.Read();
                    if (myReader.HasRows)
                    {
                        titleTxtBox.Text = myReader.GetString(0);
                        sourceComboBox.Text = myReader.GetString(1);
                        musicianComboBox.Text = myReader.GetString(2);
                        albumComboBox.Text = myReader.GetString(3);
                        Content.Text = myReader.GetString(4);
                        TonalityComboBox.Text = myReader.GetString(5);
                        if (!myReader.IsDBNull(6))
                            demoTxtBox.Text = myReader.GetString(6);
                    }
                    else
                        throw new Exception();
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
            contentChanged = true; //奇怪的bug
            isModified = false;
        }

        //得到Musician表数据并添加到相应下拉框中
        public void getMusician()
        {
            musicianComboBox.Items.Clear();
            string selectMusician = "select musicianName from musician order by musicianName;";
            using (MySqlCommand cmd = new MySqlCommand(selectMusician, Sign.conn))
            {
                MySqlDataReader myReader = null;
                try
                {
                    myReader = cmd.ExecuteReader();
                    while (myReader.Read())
                    {
                        if (myReader.HasRows)
                            musicianComboBox.Items.Add(myReader.GetString(0));
                    }
                }
                catch (MySqlException)
                {
                    Sign.conn.Close();
                }
                finally
                {
                    myReader.Close();
                }
            }
        }

        //得到Source表数据并添加到相应下拉框中
        public void getSource()
        {
            sourceComboBox.Items.Clear();
            string selectSource = "select sourceTitle from source order by sourceTitle;";
            using (MySqlCommand cmd = new MySqlCommand(selectSource, Sign.conn))
            {
                MySqlDataReader myReader = null;
                try
                {
                    myReader = cmd.ExecuteReader();
                    while (myReader.Read())
                    {
                        if (myReader.HasRows)
                            sourceComboBox.Items.Add(myReader.GetString(0));
                    }
                }
                catch (MySqlException)
                {
                    Sign.conn.Close();
                }
                finally
                {
                    myReader.Close();
                }
            }
        }

        //得到Album表数据并添加到相应下拉框中
        public void getAlbum()
        {
            albumComboBox.Items.Clear();
            string selectAlbum = "select albumTitle from album order by albumTitle;";
            using (MySqlCommand cmd = new MySqlCommand(selectAlbum, Sign.conn))
            {
                MySqlDataReader myReader = null;
                try
                {
                    myReader = cmd.ExecuteReader();
                    while (myReader.Read())
                    {
                        if (myReader.HasRows)
                            albumComboBox.Items.Add(myReader.GetString(0));
                    }
                }
                catch (MySqlException)
                {
                    Sign.conn.Close();
                }
                finally
                {
                    myReader.Close();
                }
            }
        }

        //上传按钮
        private void uploadBtn_Click(object sender, EventArgs e)
        {
            #region 检测信息完整

            if (string.IsNullOrWhiteSpace(titleTxtBox.Text) || string.IsNullOrWhiteSpace(Content.Text) ||
                string.IsNullOrWhiteSpace(musicianComboBox.Text))
            {
                showInfo("Title, musician and the score can not be null", Theme.MainColor4);
                return;
            }
            if (TonalityComboBox.SelectedIndex == -1)
            {
                showInfo("Wrong Tonality", Theme.MainColor4);
                return;
            }
            if (titleTxtBox.Text.Equals("Title") || Content.Text.Equals("Type your score here...") ||
                musicianComboBox.Text.Equals("Musician"))
            {
                showInfo("You have not edited the title, musician or the score", Theme.MainColor4);
                return;
            }


            #endregion

            #region 检测demoAddress是否是合法地址

            string pattern = "[a-zA-z]+://[^\\s]*";
            if (!demoTxtBox.Text.Equals("Demo Address (Keep this if none)") && !Regex.IsMatch(demoTxtBox.Text, pattern))
            {
                showInfo("Illegel Demo Address", Theme.MainColor4);
                return;
            }

            #endregion

            #region 检测是否进行了修改

            if (!isModified)
            {
                showInfo("No changes have been made", Theme.MainColor4);
                return;
            }

            #endregion

            #region 检测是否存在,存在则记录scoreID

            string chkTitle = "SELECT scoreID " +
                              "from score " +
                              "join musician on score.musicianID=musician.musicianID " +
                              "where scoreTitle='" + titleTxtBox.Text.Replace("'", "''") +
                              "' and musicianName='" + musicianComboBox.Text.Replace("'", "''") + "';";
            using (MySqlCommand cmd = new MySqlCommand(chkTitle, Sign.conn))
            {
                MySqlDataReader myReader = null;
                try
                {
                    myReader = cmd.ExecuteReader();
                    myReader.Read();
                    if (myReader.HasRows)
                    {
                        scoreID = myReader.GetInt32(0);
                    }
                    else
                    {
                        scoreID = 0;
                    }
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.ToString());
                }
                finally
                {
                    myReader.Close();
                }
            }

            #endregion

            #region 检查是否有权限修改该Score

            if (scoreID != 0)
            {
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
                            showInfo("You don't have the authority to edit this score", Theme.MainColor4);
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
            }

            #endregion

            #region 检查Source是否存在，不存在则添加，存在则记录sourceID

            int sourceID = 0;
            if (sourceComboBox.Text.Equals("Source"))
            {
                sourceID = 2;
            }
            else
            {
                string chkSource = "select sourceID " +
                                   "from source " +
                                   "where sourceTitle='" + sourceComboBox.Text.Replace("'", "''") + "';";
                using (MySqlCommand cmd = new MySqlCommand(chkSource, Sign.conn))
                {
                    MySqlDataReader myReader = null;
                    try
                    {
                        myReader = cmd.ExecuteReader();
                        myReader.Read();
                        if (myReader.HasRows)
                        {
                            sourceID = myReader.GetInt32(0);
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

                if (sourceID == 0)
                {
                    string insertSource = "insert into source (sourceTitle) values ('" + sourceComboBox.Text +
                                          "'); Select @@Identity;";
                    using (MySqlCommand cmd3 = new MySqlCommand(insertSource, Sign.conn))
                    {
                        try
                        {
                            sourceID = Convert.ToInt32(cmd3.ExecuteScalar());
                        }
                        catch (MySqlException exp)
                        {
                            MessageBox.Show(exp.ToString());
                        }
                    }
                    getSource();
                }
            }

            #endregion

            #region 检查Musician是否存在，不存在则添加，存在则记录musicianID

            int musicianID = 0;
            string chkMusician = "select musicianID " +
                                 "from musician " +
                                 "where musicianName='" + musicianComboBox.Text.Replace("'", "''") + "';";
            using (MySqlCommand cmd = new MySqlCommand(chkMusician, Sign.conn))
            {
                MySqlDataReader myReader = null;
                try
                {
                    myReader = cmd.ExecuteReader();
                    myReader.Read();
                    if (myReader.HasRows)
                    {
                        musicianID = myReader.GetInt32(0);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("获取出处信息失败");
                    return;
                }
                finally
                {
                    myReader.Close();
                }
            }

            if (musicianID == 0)
            {
                string insertMusician = "insert into musician (musicianName) values ('" + musicianComboBox.Text +
                                        "'); Select @@Identity;";
                using (MySqlCommand cmd3 = new MySqlCommand(insertMusician, Sign.conn))
                {
                    try
                    {
                        musicianID = Convert.ToInt32(cmd3.ExecuteScalar());
                    }
                    catch (MySqlException exp)
                    {
                        MessageBox.Show(exp.ToString());
                    }
                }
                getMusician();
            }

            #endregion

            #region 检查Album是否存在，不存在则添加，存在则记录albumID

            int albumID = 0;
            if (albumComboBox.Text.Equals("Album"))
            {
                albumID = 1;
            }
            else
            {
                string chkAlbum = "select albumID " +
                                  "from album " +
                                  "where albumTitle='" + albumComboBox.Text.Replace("'", "''") + "';";
                using (MySqlCommand cmd = new MySqlCommand(chkAlbum, Sign.conn))
                {
                    MySqlDataReader myReader = null;
                    try
                    {
                        myReader = cmd.ExecuteReader();
                        myReader.Read();
                        if (myReader.HasRows)
                        {
                            albumID = myReader.GetInt32(0);
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("获取出处信息失败");
                        return;
                    }
                    finally
                    {
                        myReader.Close();
                    }
                }

                if (albumID == 0)
                {
                    string insertAlbum = "insert into album (albumTitle) values ('" + albumComboBox.Text +
                                         "'); Select @@Identity;";
                    using (MySqlCommand cmd3 = new MySqlCommand(insertAlbum, Sign.conn))
                    {
                        try
                        {
                            albumID = Convert.ToInt32(cmd3.ExecuteScalar());
                        }
                        catch (MySqlException exp)
                        {
                            MessageBox.Show(exp.ToString());
                        }
                    }
                    getAlbum();
                }
            }

            #endregion

            #region 若已存在该谱，则进行修改，然后返回

            if (scoreID != 0)
            {
                string update;
                if (demoTxtBox.Text.Equals("Demo Address (Keep this if none)"))
                    update = "update score set " +
                             "scoreTitle='" + titleTxtBox.Text.Replace("'", "''") + "', " +
                             "content='" + Content.Text + "', " +
                             "tonalityID='" + (TonalityComboBox.SelectedIndex + 1) + "', " +
                             "sourceID='" + sourceID + "', " +
                             "albumID='" + albumID + "', " +
                             "musicianID='" + musicianID + "' " +
                             "where scoreID='" + scoreID + "';";
                else
                    update = "update score set " +
                             "scoreTitle='" + titleTxtBox.Text.Replace("'", "''") + "', " +
                             "content='" + Content.Text + "', " +
                             "tonalityID='" + (TonalityComboBox.SelectedIndex + 1) + "', " +
                             "sourceID='" + sourceID + "', " +
                             "albumID='" + albumID + "', " +
                             "musicianID='" + musicianID + "', " +
                             "demoAddress='" + demoTxtBox.Text + "' " +
                             "where scoreID='" + scoreID + "';";

                using (MySqlCommand cmd = new MySqlCommand(update, Sign.conn))
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
                    showInfo("Update Successfully", Theme.MainColor1);
                    main.ScoreTable.getScore("");
                }

                isReadyToModify = false;
                isModified = false;
                return;
            }

            #endregion

            #region 若不存在该谱，添加它

            string insertScore;
            if (demoTxtBox.Text.Equals("Demo Address (Keep this if none)"))
                insertScore =
                    "insert into score (scoreTitle, content, tonalityID, sourceID, albumID, musicianID, createrID) values ('"
                    + titleTxtBox.Text.Replace("'", "''") + "', '"
                    + Content.Text + "', "
                    + (TonalityComboBox.SelectedIndex + 1) + ", '"
                    + sourceID + "', '"
                    + albumID + "', '"
                    + musicianID + "', '"
                    + Sign.userID +"'); Select @@Identity;";
            else
                insertScore =
                    "insert into score (scoreTitle, content, tonalityID, sourceID, albumID, musicianID, demoAddress, createrID) values ('"
                    + titleTxtBox.Text.Replace("'", "''") + "', '"
                    + Content.Text + "', "
                    + (TonalityComboBox.SelectedIndex + 1) + ", '"
                    + sourceID + "', '"
                    + albumID + "', '"
                    + musicianID + "', '"
                    + demoTxtBox.Text +"', '"
                    + Sign.userID +"'); Select @@Identity;";

            using (MySqlCommand cmd4 = new MySqlCommand(insertScore, Sign.conn))
            {
                try
                {
                    scoreID = Convert.ToInt32(cmd4.ExecuteScalar());
                }
                catch (MySqlException exp)
                {
                    MessageBox.Show(exp.ToString());
                }

                isReadyToModify = false;
                isModified = false;
                showInfo("Upload Successfully", Theme.MainColor1);
                main.ScoreTable.getScore("");

            }

            #endregion
        }

        //Clear按钮
        private void clearBtn_Click(object sender, EventArgs e)
        {
            clear();
        }

        //删除按钮
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

            isReadyToModify = false;
            isModified = true;

            scoreID = 0;

            showInfo("Delete Successfully", Theme.MainColor1);

            main.ScoreTable.getScore("");
            main.Favorite.getScore();
            main.Score.clear();
        }

        //调性下拉框处理自己填入的值
        private void TonalityComboBox_TextChanged(object sender, EventArgs e)
        {
            tonalityChanged = true;
            if (TonalityComboBox.Text.Equals("Tonality") || string.IsNullOrWhiteSpace(TonalityComboBox.Text))
                tonalityChanged = false;
            else
                TextChanged();

            switch (TonalityComboBox.Text)
            {
                case "C":
                    TonalityComboBox.SelectedIndex = 0;
                    break;
                case "C#":
                    TonalityComboBox.SelectedIndex = 1;
                    break;
                case "D":
                    TonalityComboBox.SelectedIndex = 2;
                    break;
                case "D#":
                    TonalityComboBox.SelectedIndex = 3;
                    break;
                case "E":
                    TonalityComboBox.SelectedIndex = 4;
                    break;
                case "F":
                    TonalityComboBox.SelectedIndex = 5;
                    break;
                case "F#":
                    TonalityComboBox.SelectedIndex = 6;
                    break;
                case "G":
                    TonalityComboBox.SelectedIndex = 7;
                    break;
                case "G#":
                    TonalityComboBox.SelectedIndex = 8;
                    break;
                case "A":
                    TonalityComboBox.SelectedIndex = 9;
                    break;
                case "A#":
                    TonalityComboBox.SelectedIndex = 10;
                    break;
                case "B":
                    TonalityComboBox.SelectedIndex = 11;
                    break;
            }
        }

        #region 处理水印文字

        private bool sourceChanged,
            musicianChanged,
            tonalityChanged,
            albumChanged,
            contentChanged,
            demoChanged,
            titleChanged;

        //获取焦点时
        private void sourceComboBox_Enter(object sender, EventArgs e)
        {
            if (!sourceChanged)
                sourceComboBox.Text = "";
        }

        private void musicianComboBox_Enter(object sender, EventArgs e)
        {
            if (!musicianChanged)
                musicianComboBox.Text = "";
        }

        private void TonalityComboBox_Enter(object sender, EventArgs e)
        {
            if (!tonalityChanged)
                TonalityComboBox.Text = "";
        }

        private void albumComboBox_Enter(object sender, EventArgs e)
        {
            if (!albumChanged)
                albumComboBox.Text = "";
        }

        private void Content_Enter(object sender, EventArgs e)
        {
            if (!contentChanged)
                Content.Text = "";
        }

        private void demoTxtBox_Enter(object sender, EventArgs e)
        {
            if (!demoChanged)
                demoTxtBox.Text = "";
        }

        private void titleTxtBox_Enter(object sender, EventArgs e)
        {
            if (!titleChanged)
                titleTxtBox.Text = "";
        }



        //失去焦点时
        private void sourceComboBox_Leave(object sender, EventArgs e)
        {
            if (!sourceChanged)
                sourceComboBox.Text = "Source";
        }

        private void musicianComboBox_Leave(object sender, EventArgs e)
        {
            if (!musicianChanged)
                musicianComboBox.Text = "Musician";
        }

        private void TonalityComboBox_Leave(object sender, EventArgs e)
        {
            if (!tonalityChanged)
                TonalityComboBox.Text = "Tonality";
        }

        private void albumComboBox_Leave(object sender, EventArgs e)
        {
            if (!albumChanged)
                albumComboBox.Text = "Album";
        }

        private void Content_Leave(object sender, EventArgs e)
        {
            if (!contentChanged)
                Content.Text = "Type your score here...";
        }

        private void demoTxtBox_Leave(object sender, EventArgs e)
        {
            if (!demoChanged)
                demoTxtBox.Text = "Demo Address (Keep this if none)";
        }

        private void titleTxtBox_Leave(object sender, EventArgs e)
        {
            if (!titleChanged)
                titleTxtBox.Text = "Title";
        }



        //更改文字时
        private void sourceComboBox_TextChanged(object sender, EventArgs e)
        {
            sourceChanged = true;
            if (sourceComboBox.Text.Equals("Source") || string.IsNullOrWhiteSpace(sourceComboBox.Text))
                sourceChanged = false;
            else
                TextChanged();
        }

        private void musicianComboBox_TextChanged(object sender, EventArgs e)
        {
            musicianChanged = true;
            if (musicianComboBox.Text.Equals("Musician") || string.IsNullOrWhiteSpace(musicianComboBox.Text))
                musicianChanged = false;
            else
                TextChanged();
        }

        private void albumComboBox_TextChanged(object sender, EventArgs e)
        {
            albumChanged = true;
            if (albumComboBox.Text.Equals("Album") || string.IsNullOrWhiteSpace(albumComboBox.Text))
                albumChanged = false;
            else
                TextChanged();
        }

        private void Content_TextChanged(object sender, EventArgs e)
        {
            contentChanged = true;
            if (Content.Text.Equals("Type your score here...") || string.IsNullOrWhiteSpace(Content.Text))
                contentChanged = false;
            else
                TextChanged();
        }

        private void demoTxtBox_TextChanged(object sender, EventArgs e)
        {
            demoChanged = true;
            if (demoTxtBox.Text.Equals("Demo Address (Keep this if none)") ||
                string.IsNullOrWhiteSpace(demoTxtBox.Text))
                demoChanged = false;
            else
                TextChanged();
        }

        private void titleTxtBox_TextChanged(object sender, EventArgs e)
        {
            titleChanged = true;
            if (titleTxtBox.Text.Equals("Title") || string.IsNullOrWhiteSpace(titleTxtBox.Text))
                titleChanged = false;
            else
                TextChanged();
        }

        #endregion

        //跳转到Score
        private void scoreBtn_Click(object sender, EventArgs e)
        {
            if (scoreID == 0)
            {
                showInfo("This score doesn't exist", Theme.MainColor4);
                return;
            }

            main.Score.showScore(scoreID);
            Main.changePanel(main.Score);
        }

        //显示信息文字
        private void showInfo(string info, Color color)
        {
            infoLabel.ForeColor = color;
            infoLabel.Text = info;
            infoLabel.Location = new Point(900 - infoLabel.Width, 149);
            timer1.Stop();
            timer1.Start();
        }

        //处理文字2秒后消失的计时器
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            infoLabel.Text = "";
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

        private void TextChanged()
        {
            if (isReadyToModify)
            {
                isModified = true;
                showInfo("Modifying...", Theme.MainColor1);
            }
        }

        #endregion

        //部件换色
        public void changeColor()
        {
            skinFlowLayoutPanel1.BackColor = Theme.MainColor1;
            titleTxtBox.BackColor = Theme.MainColor1;
            demoTxtBox.BackColor = Theme.MainColor1;
            uploadBtn.MouseBaseColor = Theme.MainColor3;
            uploadBtn.DownBaseColor = Theme.MainColor3;
            clearBtn.MouseBaseColor = Theme.MainColor3;
            clearBtn.DownBaseColor = Theme.MainColor3;
            deleteBtn.MouseBaseColor = Theme.MainColor3;
            deleteBtn.DownBaseColor = Theme.MainColor3;
            scoreBtn.MouseBaseColor = Theme.MainColor3;
            scoreBtn.DownBaseColor = Theme.MainColor3;
        }

        //限制谱子特殊符号输入
        private void Content_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\'' || e.KeyChar == ';' || e.KeyChar == '"')
                e.Handled = true;
        }

        //调性只能输入大小字母A~G和#
        private void TonalityComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'A' && e.KeyChar <= 'G') || e.KeyChar == '#' || e.KeyChar == 8)
                e.Handled = false;
            else
                e.Handled = true;
        }
    }
}