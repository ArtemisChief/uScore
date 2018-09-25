using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CCWin.SkinClass;
using CCWin.SkinControl;

namespace μScore
{
    public partial class ImageCutControl : UserControl
    {
        private Sign sign;
        Point start;
        bool blnDraw;
        Rectangle rect;
        private Bitmap sourceImage;
        Bitmap newHead;

        public ImageCutControl(Sign s)
        {
            InitializeComponent();
            sign = s;
        }

        // 上传图片并等比例压缩到250（图片长的一边设为250，另一边等比例压缩）
        private void upLoadPhoto_Click(object sender, EventArgs e)
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

            #region 将选取区域压缩到100并显示在预览区，选取区域小于100则不压缩

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
        private void skinButton1_Click(object sender, EventArgs e)
        {
            if (newHead == null)
            {
                infoLabel.Text = "Please select a image";
                timer1.Stop();
                timer1.Start();
                return;
            }

            Sign.SignUp.changeHead(newHead);
            newHead = null;
            sourceImage = null;
            pictureBox1.Size = new Size(250, 250);
            pictureBox2.Size = new Size(140, 140);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = Properties.Resources.head;
            pictureBox2.Image = Properties.Resources.head;

            sign.changePanel(Sign.SignUp);
        }

        //处理文字2秒后消失的计时器
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            infoLabel.Text = "";
        }
    }
}