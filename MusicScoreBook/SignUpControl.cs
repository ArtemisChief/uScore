using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace μScore
{
    public partial class SignUpControl : UserControl
    {
        private Sign sign;
        private Bitmap head;

        public SignUpControl(Sign s)
        {
            InitializeComponent();
            sign = s;
        }

        //用于从上传头像界面返回改变头像
        public void changeHead(Bitmap bitmap)
        {
            head = bitmap;
            PictureBox1.Image = bitmap;
        }

        //跳转到图像裁剪上传窗口
        private void upLoadPhoto_Click(object sender, EventArgs e)
        {
            sign.changePanel(Sign.ImageCut);
        }

        //注册
        private void signUpButton_Click(object sender, EventArgs e)
        {
            #region 检测注册信息是否完整

            if (SUsername.Text.Length == 0)
            {
                showInfo("Username can't be empty");
                return;
            }
            if (SPassword.Text.Length == 0)
            {
                showInfo("Password can't be empty");
                return;
            }
            if (SCPassword.Text.Length == 0)
            {
                showInfo("Confirm password can't be empty");
                return;
            }

            if (!SCPassword.Text.Equals(SPassword.Text))
            {
                showInfo("Two password is inconsistent");
                return;
            }
            string pattern = "^[a-zA-Z0-9_-]{4,16}$";
            if (!Regex.IsMatch(SPassword.Text, pattern) || !Regex.IsMatch(SUsername.Text, pattern))
            {
                showInfo("Username or password contains special symbol, or beyond 4-16 digits");
                return;
            }
            if (head == null)
            {
                showInfo("Please choose your avatar");
                return;
            }

            #endregion

            #region 检测该用户名是否已存在

            string readUser = "select userName from users " +
                              "where userName= '" + SUsername.Text + "';";
            using (MySqlCommand cmd = new MySqlCommand(readUser, Sign.conn))
            {
                MySqlDataReader myReader = null;
                myReader = cmd.ExecuteReader();
                myReader.Read();
                if (myReader.HasRows)
                {
                    myReader.Close();
                    showInfo("The username already exists");
                    return;
                }
                myReader.Close();
            }

            #endregion

            //随机生成盐值
            Random r = new Random();
            string salt = Convert.ToString(r.Next(0, 100));

            #region 将头像转换为byte[]用以存入数据库

            MemoryStream stream = new MemoryStream();
            head.Save(stream, ImageFormat.Jpeg);
            byte[] photo = new byte[stream.Length];
            stream.Seek(0, SeekOrigin.Begin);
            stream.Read(photo, 0, Convert.ToInt32(stream.Length));
            stream.Close();

            #endregion

            #region 新建用户

            string sign = "insert into users(salt,pwd,userName,picture) " +
                          "values(" + salt + ",md5(concat('"
                          + SPassword.Text + "'," + salt + ")),'"
                          + SUsername.Text + "',"
                          + "@photoBinary); ";

            using (MySqlCommand cmd2 = new MySqlCommand(sign, Sign.conn))
            {
                try
                {
                    cmd2.Parameters.Add("@photoBinary", MySqlDbType.Binary, photo.Length);
                    cmd2.Parameters["@photoBinary"].Value = photo;
                    cmd2.ExecuteNonQuery();
                }
                catch (MySqlException exp)
                {
                    MessageBox.Show(exp.ToString());
                    return;
                }
            }

            #endregion

            SUsername.Text = "";
            SCPassword.Text = "";
            SPassword.Text = "";
            PictureBox1.Image=Properties.Resources.head;
            head = null;
            this.sign.changePanel(Sign.SignIn);
        }

        //返回登录窗口
        private void skinButton1_Click(object sender, EventArgs e)
        {
            sign.changePanel(Sign.SignIn);
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
}
