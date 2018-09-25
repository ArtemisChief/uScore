using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace μScore
{
    public partial class SettingNormalControl : UserControl
    {
        private SettingControl settingControl;

        public SettingNormalControl(SettingControl sc)
        {
            InitializeComponent();
            settingControl = sc;
        }

        //更改部件颜色
        public void changeColor()
        {
            this.userAvatarLabel.ForeColor = Theme.MainColor1;
            this.userNameLabel.ForeColor = Theme.MainColor1;
            this.changePhotoBtn.BorderColor = Theme.MainColor1;
            this.changePhotoBtn.ForeColor = Theme.MainColor1;
            this.signOutBtn.BorderColor = Theme.MainColor4;
            this.signOutBtn.ForeColor = Theme.MainColor4;
        }

        //设置用户信息
        public void setUserInfo()
        {
            avatar.Image = main.avatarImage;
            userNameLabel.Text = "User Name:      " + Sign.userName;
            settingControl.GetChangeControl().setUserName();
        }

        //登出按钮
        private void signOutBtn_Click(object sender, EventArgs e)
        {
            settingControl.GetMain().Hide();
            Sign.SignIn.loadInfo(true);
        }

        //换头像按钮
        private void changePhotoBtn_Click(object sender, EventArgs e)
        {
            settingControl.changePanel(settingControl.GetChangeControl());
        }
    }
}
