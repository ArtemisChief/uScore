using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace μScore
{
    public partial class SettingControl : UserControl
    {
        private main Main;
        private SettingNormalControl settingNormal;
        private SettingChangeControl settingChange;
        public bool change = false;

        #region 获取实例对象

        public main GetMain()
        {
            return Main;
        }

        public SettingNormalControl GetNormalControl()
        {
            return settingNormal;
        }

        public SettingChangeControl GetChangeControl()
        {
            return settingChange;
        }

        #endregion

        public SettingControl(main m)
        {
            InitializeComponent();
            settingNormal = new SettingNormalControl(this);
            settingChange = new SettingChangeControl(this);
            Main = m;
            setTheme(Sign.userTheme);
            changePanel(settingNormal);
            changeChecked(Sign.userTheme);
        }

        //更换面板
        public void changePanel(UserControl control)
        {
            skinPanel1.Controls.Clear();
            skinPanel1.Controls.Add(control);
        }

        //更改部件颜色
        private void changeColor()
        {
            this.skinFlowLayoutPanel1.BackColor = Theme.MainColor1;
            this.label1.ForeColor = Theme.MainColor1;
        }

        //设置主题
        public void setTheme(int index)
        {
            Theme.setThemeColor(index);
            this.changeColor();
            settingNormal.changeColor();
            settingChange.changeColor();
            Main.changeColor();
            main.Editor.changeColor();
            main.Favorite.changeColor();
            main.ScoreTable.changeColor();
            main.Score.changeColor();
            main.Transposition.changeColor();

        }

        //设置用户信息
        public void setUserInfo()
        {
            settingNormal.setUserInfo();
        }

        #region 勾选主题处理

        private void themeRB1_CheckedChanged(object sender, EventArgs e)
        {
            if (themeRB1.Checked)
            {
                setTheme(0);
                if (change)
                {
                    Sign.userTheme = 0;
                    saveTheme(0);
                }
            }
        }

        private void themeRB2_CheckedChanged(object sender, EventArgs e)
        {
            if (themeRB2.Checked)
            {
                setTheme(1);
                if (change)
                {
                    Sign.userTheme = 1;
                    saveTheme(1);
                }
            }
        }

        private void themeRB3_CheckedChanged(object sender, EventArgs e)
        {
            if (themeRB3.Checked)
            {
                setTheme(2);
                if (change)
                {
                    Sign.userTheme = 2;
                    saveTheme(2);
                }
            }
        }

        private void themeRB4_CheckedChanged(object sender, EventArgs e)
        {
            if (themeRB4.Checked)
            {
                setTheme(3);
                if (change)
                {
                    Sign.userTheme = 3;
                    saveTheme(3);
                }
            }
        }

        private void themeRB5_CheckedChanged(object sender, EventArgs e)
        {
            if (themeRB5.Checked)
            {
                setTheme(4);
                if (change)
                {
                    Sign.userTheme = 4;
                    saveTheme(4);
                }
            }
        }

        private void themeRB6_CheckedChanged(object sender, EventArgs e)
        {
            if (themeRB6.Checked)
            {
                setTheme(5);
                if (change)
                {
                    Sign.userTheme = 5;
                    saveTheme(5);
                }
            }
        }

        #endregion

        //保存用户主题到本地
        private void saveTheme(int theme)
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
                u.Head = users[Sign.userName].Head;
                u.Theme = theme;
                fs.Close();
                fs= new FileStream("data.bin", FileMode.Create);
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

        //打开时自动勾选用户当前的主题
        public void changeChecked(int theme)
        {
            change = false;

            switch (theme)
            {
                case 0:
                    themeRB1.Checked = true;
                    break;
                case 1:
                    themeRB2.Checked = true;
                    break;
                case 2:
                    themeRB3.Checked = true;
                    break;
                case 3:
                    themeRB4.Checked = true;
                    break;
                case 4:
                    themeRB5.Checked = true;
                    break;
                case 5:
                    themeRB6.Checked = true;
                    break;
            }
            change = true;

        }
    }
}
