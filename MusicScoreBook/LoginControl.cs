using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace μScore
{
    public partial class LoginControl : UserControl
    {
        private Sign sign;
        Dictionary<string, User> users = new Dictionary<string, User>();

        public LoginControl(Sign s)
        {
            InitializeComponent();
            sign = s;
            loadInfo();
        }

        //读取保存的用户信息
        public void loadInfo(bool logOut = false)
        {
            FileStream fs = new FileStream("data.bin", FileMode.OpenOrCreate);
            if (fs.Length > 0)
            {
                BinaryFormatter bf = new BinaryFormatter();
                //读出存在Data.bin 里的用户信息
                users = bf.Deserialize(fs) as Dictionary<string, User>;
                UserName.Items.Clear();
                //循环添加到Combox1
                foreach (User user in users.Values)
                {
                    UserName.Items.Add(user.LoginID);
                }

                //combox1 用户名默认选中第一个
                if (UserName.Items.Count > 0)
                {
                    UserName.SelectedIndex = UserName.Items.Count - 1;
                    string u = UserName.Text;
                    password.Text = users[u].Pwd;
                    rememberPwd.Checked = (password.Text != "");
                    autoLogin.Checked = users[u].Auto;
                    MemoryStream buf = new MemoryStream(users[u].Head);
                    Image image = Image.FromStream(buf, true);
                    PictureBox1.Image = image;
                    PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
                    Sign.userTheme = users[u].Theme;
                    main.Setting.setTheme(Sign.userTheme);
                    buf.Close();
                }
            }
            fs.Close();

            if (logOut)
                autoLogin.Checked = false;

            if (autoLogin.Checked)
                loginButton_Click(null, null);
        }

        //登录
        private void loginButton_Click(object sender, EventArgs e)
        {

            #region 检测登录信息是否完整合法

            if (UserName.Text.Length == 0)
            {
                showInfo("Username can't be null");
                return;
            }
            if (password.Text.Length == 0)
            {
                showInfo("Password can't be null");
                return;
            }
            string pattern = "^[a-zA-Z0-9_-]{4,16}$";
            if (!Regex.IsMatch(password.Text, pattern) || !Regex.IsMatch(UserName.Text, pattern))
            {
                showInfo("Illegal username or password");
                return;
            }
            #endregion

            #region 检测该用户是否存在

            string salt;
            string readUser = "select userName,salt from users " +
                              "where userName= '" + UserName.Text + "';";
            using (MySqlCommand cmd = new MySqlCommand(readUser, Sign.conn))
            {
                MySqlDataReader myReader = null;
                myReader = cmd.ExecuteReader();
                myReader.Read();
                if (!myReader.HasRows)
                {
                    myReader.Close();
                    showInfo("The user dones't exist");
                    return;
                }
                salt = myReader.GetString("salt");
                myReader.Close();
            }


            #endregion

            #region 检测密码是否正确

            string checkPwd = "select userID, userName, pwd from users " +
                              "where userName= '" + UserName.Text + "' AND " +
                              "pwd=md5(concat('"
                              + password.Text + "'," + salt + "));";
            using (MySqlCommand cmd = new MySqlCommand(checkPwd, Sign.conn))
            {
                MySqlDataReader myReader = null;
                myReader = cmd.ExecuteReader();
                myReader.Read();
                if (!myReader.HasRows)
                {
                    myReader.Close();
                    showInfo("Wrong password");
                    return;
                }
                Sign.userID = myReader.GetInt32(0);
                Sign.userName = myReader.GetString(1);
                myReader.Close();
            }

            #endregion

            #region 保存登录信息

            User u = new User();
            // 登录时 如果没有Data.bin文件就创建、有就打开
            FileStream fs = new FileStream("data.bin", FileMode.OpenOrCreate);
            BinaryFormatter bf = new BinaryFormatter();

            // 保存在实体类属性中
            u.LoginID = UserName.Text.Trim();
            //保存密码选中状态
            if (rememberPwd.Checked)
                u.Pwd = password.Text.Trim();
            else
                u.Pwd = "";
            //保存自动登录状态
            u.Auto = autoLogin.Checked;
            //保存用户头像
            string readHead = "select picture from users where userName='" + u.LoginID + "';";
            using (MySqlCommand cmd = new MySqlCommand(readHead, Sign.conn))
            {
                MySqlDataReader myReader = null;
                myReader = cmd.ExecuteReader();
                myReader.Read();
                MemoryStream buf = new MemoryStream((byte[])myReader[0]);
                u.Head = new byte[buf.Length];
                buf.Seek(0, SeekOrigin.Begin);
                buf.Read(u.Head, 0, Convert.ToInt32(buf.Length));
                buf.Close();
                myReader.Close();
            }
            //选在集合中是否存在用户名 
            if (users.ContainsKey(u.LoginID))
            {
                //如果有清掉
                u.Theme = users[u.LoginID].Theme;
                Sign.userTheme = users[u.LoginID].Theme;
                users.Remove(u.LoginID);
            }
            Dictionary<string, User> newUsers = new Dictionary<string, User>(users);
            //添加用户信息到集合
            newUsers.Add(u.LoginID, u);
            //写入文件
            bf.Serialize(fs, newUsers);
            //关闭
            fs.Close();

            #endregion

            Sign.userName = UserName.Text;
            Sign.Main.showUser(Sign.userID);
            Sign.Main.changePanel(main.ScoreTable);
            main.Setting.setUserInfo();
            main.Favorite.getScore();
            Sign.Main.Show();
            main.Setting.setTheme(Sign.userTheme);

        }

        //修改选择用户后同步修改用户信息
        private void UserName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string u = UserName.Text;
            password.Text = users[u].Pwd;
            rememberPwd.Checked = (password.Text != "");
            autoLogin.Checked = users[u].Auto;
            Sign.userTheme = users[u].Theme;
            main.Setting.setTheme(Sign.userTheme);
            MemoryStream buf = new MemoryStream(users[u].Head);
            Image image = Image.FromStream(buf, true);
            PictureBox1.Image = image;
            PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            buf.Close();
        }

        //跳转到注册界面
        private void signUpButton_Click(object sender, EventArgs e)
        {
            sign.changePanel(Sign.SignUp);
        }

        //当勾选了自动登陆时，则自动勾选记住密码
        private void autoLogin_CheckedChanged(object sender, EventArgs e)
        {
            if (autoLogin.Checked)
                rememberPwd.Checked = true;
        }

        //当不勾选记住密码时，则自动不勾选自动登陆
        private void rememberPwd_CheckedChanged(object sender, EventArgs e)
        {
            if (!rememberPwd.Checked)
                autoLogin.Checked = false;
        }

        //显示信息文字
        private void showInfo(string info)
        {
            infoLabel.Text = info;
            timer1.Stop();
            timer1.Start();
        }

        //处理文字2秒后消失的计时器
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            infoLabel.Text = "";
        }
    }

    #region 用于保存用户信息的用户类

    [Serializable]
    class User
    {
        public string LoginID { get; set; }

        public string Pwd { get; set; }

        public bool Auto { get; set; }

        public byte[] Head { get; set; }

        public int Theme { get; set; }
    }

    #endregion
}
