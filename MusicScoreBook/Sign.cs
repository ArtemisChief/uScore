using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CCWin;
using MySql.Data.MySqlClient;

namespace μScore
{
    public partial class Sign : CCSkinMain
    {
        public static MySqlConnection conn;
        public static main Main;
        public static LoginControl SignIn;
        public static SignUpControl SignUp;
        public static ImageCutControl ImageCut;
       
        public static int userID;
        public static string userName;
        public static int userTheme;

        //连接数据库
        public static void login()
        {
            string connectStr = "server=45.76.193.249;database=uscore;uid=Chief;pwd=www54321;";
            //string connectStr = "server=127.0.0.1;database=μscorebook;uid=root;pwd=12345;";
            //string connectStr = "server=127.0.0.1;database=Chief;uid=root;pwd=yzdxm;";

            try
            {
                conn = new MySqlConnection(connectStr);
                conn.Open();
            }
            catch (MySqlException exception)
            {
                MessageBox.Show("Can not access to the database");
            }
        }

        public Sign()
        {
            InitializeComponent();
            login();
            Main = new main(this);
            SignIn = new LoginControl(this);
            SignUp = new SignUpControl(this);
            ImageCut=new ImageCutControl(this);
            skinPanel1.Controls.Add(SignIn);
        }

        //切换面板
        public void changePanel(Control control)
        {
            skinPanel1.Controls.Clear();
            skinPanel1.Controls.Add(control);
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

        //用于和Main窗口对立出现，一方出现一方就消失
        private void Sign_VisibleChanged(object sender, EventArgs e)
        {
            Main.main_VisibleChanged(null, null);
        }
    }
}
