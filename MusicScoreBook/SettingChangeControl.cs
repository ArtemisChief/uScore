using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace μScore
{
    public partial class SettingChangeControl : UserControl
    {
        private Point start;
        private bool blnDraw;
        private Rectangle rect;
        private Bitmap sourceImage;
        private Bitmap newHead;

        private SettingControl settingControl;

        public SettingChangeControl(SettingControl sc)
        {
            InitializeComponent();
            settingControl = sc;
        }

        //设置用户名
        public void setUserName()
        {
            userNameLabel.Text = "User Name:      " + Sign.userName;
        }

        //更改部件颜色
        public void changeColor()
        {
            this.label1.ForeColor = Theme.MainColor1;
            this.label2.ForeColor = Theme.MainColor1;
            this.userNameLabel.ForeColor = Theme.MainColor1;
            this.backBtn.BorderColor = Theme.MainColor1;
            this.backBtn.ForeColor = Theme.MainColor1;
            this.selectImageBtn.BorderColor = Theme.MainColor1;
            this.selectImageBtn.ForeColor = Theme.MainColor1;
            this.confirmBtn.BorderColor = Theme.MainColor1;
            this.confirmBtn.ForeColor = Theme.MainColor1;
        }

        //返回按钮
        private void backBtn_Click(object sender, EventArgs e)
        {
            settingControl.changePanel(settingControl.GetNormalControl());
        }

        #region 图片处理

        // 上传图片并等比例压缩到400（图片长的一边设为400，另一边等比例压缩）
        private void selectImageBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofg = new OpenFileDialog();
            ofg.Title = "请选择头像文件";
            ofg.Filter = "图像文件|*.gif;*.jpge;*.jpg;*.png";
            if (ofg.ShowDialog() == DialogResult.OK)
            {
                sourceImage = new Bitmap(ofg.FileName);
                Bitmap newImage;
                if (sourceImage.Height > 250 || sourceImage.Width > 250)
                {
                    newImage = Scale(sourceImage, 250);
                }
                else
                {
                    newImage = sourceImage;
                }
                pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
                pictureBox1.Image = newImage;
            }
        }

        //开始选取
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (sourceImage == null)
                return;
            start = e.Location;
            Invalidate();
            blnDraw = true;
        }

        //移动鼠标绘制选取区域
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (sourceImage == null)
                return;

            if (blnDraw)
            {
                if (e.Button != MouseButtons.Left) //判断是否按下左键
                    return;
                Point tempEndPoint = e.Location; //记录框的位置和大小

                if (tempEndPoint.X < 0)
                    tempEndPoint.X = 0;
                if (tempEndPoint.Y < 0)
                    tempEndPoint.Y = 0;
                if (tempEndPoint.X > pictureBox1.Image.Width)
                    tempEndPoint.X = pictureBox1.Image.Width;
                if (tempEndPoint.Y > pictureBox1.Image.Height)
                    tempEndPoint.Y = pictureBox1.Image.Height;

                rect.Location = new Point(
                    Math.Min(start.X, tempEndPoint.X),
                    Math.Min(start.Y, tempEndPoint.Y));
                rect.Size = new Size(
                    Math.Abs(start.X - tempEndPoint.X),
                    Math.Abs(start.X - tempEndPoint.X));
                if (rect.Y + rect.Height > pictureBox1.Image.Height)
                    rect.Size = new Size(
                        pictureBox1.Image.Height - rect.Y,
                        pictureBox1.Image.Height - rect.Y);
                pictureBox2.Invalidate();
            }
        }

        //结束绘制
        private void PictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (sourceImage == null)
                return;

            blnDraw = false;

            #region 画出选取区域

            pictureBox1.Refresh();
            Graphics recte = pictureBox1.CreateGraphics();
            PaintEventArgs p = new PaintEventArgs(recte, rect);
            Pen pen1 = new Pen(Color.White, 2);
            pen1.DashStyle = DashStyle.Custom;
            pen1.DashPattern = new float[] {1f, 2f};
            p.Graphics.DrawRectangle(pen1, rect);

            #endregion

            #region 将选取区域压缩到140并显示在预览区，选取区域小于140则不压缩

            Bitmap sourceHead = Cut(new Bitmap(pictureBox1.Image), rect.X, rect.Y, rect.Width, rect.Height);
            if (sourceHead == null)
                return;
            if (sourceHead.Height > 140 || sourceHead.Width > 140)
            {
                newHead = Scale(sourceHead, 140);
            }
            else
            {
                newHead = sourceHead;
            }
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            pictureBox2.Image = newHead;

            #endregion

        }

        //裁剪图像
        public static Bitmap Cut(Bitmap b, int StartX, int StartY, int iWidth, int iHeight)
        {
            if (b == null)
            {
                return null;
            }
            int w = b.Width;
            int h = b.Height;
            if (StartX >= w || StartY >= h)
            {
                return null;
            }
            if (StartX + iWidth > w)
            {
                iWidth = w - StartX;
            }
            if (StartY + iHeight > h)
            {
                iHeight = h - StartY;
            }
            try
            {
                Bitmap bmpOut = new Bitmap(iWidth, iHeight, PixelFormat.Format24bppRgb);
                Graphics g = Graphics.FromImage(bmpOut);
                g.DrawImage(b, new Rectangle(0, 0, iWidth, iHeight), new Rectangle(StartX, StartY, iWidth, iHeight),
                    GraphicsUnit.Pixel);
                g.Dispose();
                return bmpOut;
            }
            catch
            {
                return null;
            }
        }

        //按原图比例压缩图像
        public static Bitmap Scale(Bitmap b, double size)
        {
            double ratio = (b.Width > b.Height)
                ? b.Width / size
                : b.Height / size;
            Bitmap newImage = new Bitmap(b,
                Convert.ToInt32(b.Width / ratio),
                Convert.ToInt32(b.Height / ratio));
            return newImage;
        }

        //提交头像
        private void confirmBtn_Click(object sender, EventArgs e)
        {
            if (newHead == null)
            {
                infoLabel.Text = "Please select a image";
                timer1.Stop();
                timer1.Start();
                return;
            }

            #region 将头像转换为byte[]用以存入数据库

            MemoryStream stream = new MemoryStream();
            newHead.Save(stream, ImageFormat.Jpeg);
            byte[] photo = new byte[stream.Length];
            stream.Seek(0, SeekOrigin.Begin);
            stream.Read(photo, 0, Convert.ToInt32(stream.Length));
            stream.Close();

            #endregion

            string update = "update users set picture=@photoBinary where userID=" + Sign.userID + ";";

            using (MySqlCommand cmd2 = new MySqlCommand(update, Sign.conn))
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
            savehead(photo);
            settingControl.GetMain().showUser(Sign.userID);
            settingControl.GetNormalControl().setUserInfo();
            settingControl.changePanel(settingControl.GetNormalControl());
            sourceImage = null;
            pictureBox1.Size = new Size(250, 250);
            pictureBox1.Image = Properties.Resources.head;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.Size = new Size(140, 140);
            pictureBox2.Image = Properties.Resources.head;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;


        }

        #endregion

        //处理文字2秒后消失的计时器
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            infoLabel.Text = "";
        }

        //保存更改后的头像到本地
        private void savehead(byte[] newHead)
        {
            Dictionary<string, User> users = new Dictionary<string, User>();
            User u = new User();
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream("data.bin", FileMode.OpenOrCreate);
            if (fs.Length > 0)
            {
                //读出存在Data.bin 里的用户信息
                users = bf.Deserialize(fs) as Dictionary<string, User>;
                u.LoginID = Sign.userName;
                u.Pwd = users[Sign.userName].Pwd;
                u.Auto = users[Sign.userName].Auto;
                u.Head = newHead;
                u.Theme = Sign.userTheme;
                fs.Close();
                fs = new FileStream("data.bin", FileMode.Create);
            }
            else
            {
                fs.Close();
                return;
            }
            users.Remove(u.LoginID);
            //添加用户信息到集合
            users.Add(u.LoginID, u);
            //写入文件
            bf.Serialize(fs, users);
            //关闭
            fs.Close();
        }
    }
}
