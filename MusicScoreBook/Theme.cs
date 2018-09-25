using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace μScore
{
    class Theme
    {
        //1 3 5 2由深到浅
        public static Color MainColor1;
        public static Color MainColor3;
        public static Color MainColor5;
        public static Color MainColor2;

        public static Color MainColor4;
        public static Color MainColor6;

        public static Image CloseImage;
        public static Image MaximumImage;
        public static Image MinimalImage;
        public static Image SearchImage;

        //设置主题色
        public static void setThemeColor(int index)
        {
            switch (index)
            {
                case 0:
                    MainColor1 = Color.FromArgb(3, 169, 244);
                    MainColor2 = Color.FromArgb(2, 136, 209);
                    MainColor3 = Color.FromArgb(1, 159, 234);
                    MainColor4 = Color.FromArgb(232, 17, 35);
                    MainColor5 = Color.FromArgb(6, 155, 222);
                    MainColor6 = Color.FromArgb(173,216,230);
                    CloseImage = Properties.Resources.closeB;
                    MaximumImage = Properties.Resources.maximumB;
                    MinimalImage = Properties.Resources.minimalB;
                    SearchImage = Properties.Resources.searchB;
                    break;
                case 1:
                    MainColor1 = Color.FromArgb(130, 99, 171);
                    MainColor2 = Color.FromArgb(108, 83, 165);
                    MainColor3 = Color.FromArgb(120, 92, 168);
                    MainColor4 = Color.FromArgb(232, 17, 35);
                    MainColor5 = Color.FromArgb(117, 90, 168);
                    MainColor6 = Color.FromArgb(172, 130, 183);
                    CloseImage = Properties.Resources.closeP;
                    MaximumImage = Properties.Resources.maximumP;
                    MinimalImage = Properties.Resources.minimalP;
                    SearchImage = Properties.Resources.searchP;
                    break;
                case 2:
                    MainColor1 = Color.FromArgb(47,47,47);
                    MainColor2 = Color.FromArgb(35,35,35);
                    MainColor3 = Color.FromArgb(42,42,42);
                    MainColor4 = Color.FromArgb(232, 17, 35);
                    MainColor5 = Color.FromArgb(40,40,40);
                    MainColor6 = Color.FromArgb(90,90,90);
                    CloseImage = Properties.Resources.closeBl;
                    MaximumImage = Properties.Resources.maximumBl;
                    MinimalImage = Properties.Resources.minimalBl;
                    SearchImage = Properties.Resources.searchBl;
                    break;
                case 3:
                    MainColor1 = Color.FromArgb(141, 194, 111);
                    MainColor2 = Color.FromArgb(115, 175, 80);
                    MainColor3 = Color.FromArgb(130, 190, 100);
                    MainColor4 = Color.FromArgb(232, 17, 35);
                    MainColor5 = Color.FromArgb(127, 188, 94);
                    MainColor6 = Color.FromArgb(170, 220, 130);
                    CloseImage = Properties.Resources.closeG;
                    MaximumImage = Properties.Resources.maximumG;
                    MinimalImage = Properties.Resources.minimalG;
                    SearchImage = Properties.Resources.searchG;
                    break;
                case 4:
                    MainColor1 = Color.FromArgb(241, 190, 122);
                    MainColor2 = Color.FromArgb(228, 172, 97);
                    MainColor3 = Color.FromArgb(234, 180, 108);
                    MainColor4 = Color.FromArgb(232, 17, 35);
                    MainColor5 = Color.FromArgb(237, 184, 113);
                    MainColor6 = Color.FromArgb(255, 209, 148);
                    CloseImage = Properties.Resources.closeY;
                    MaximumImage = Properties.Resources.maximumY;
                    MinimalImage = Properties.Resources.minimalY;
                    SearchImage = Properties.Resources.searchY;
                    break;
                case 5:
                    MainColor1 = Color.FromArgb(228, 75, 72);
                    MainColor2 = Color.FromArgb(228, 53, 50);
                    MainColor3 = Color.FromArgb(228, 63, 60);
                    MainColor4 = Color.FromArgb(124, 16, 3);
                    MainColor5 = Color.FromArgb(228, 62, 59);
                    MainColor6 = Color.FromArgb(227, 113, 111);
                    CloseImage = Properties.Resources.closeR;
                    MaximumImage = Properties.Resources.maximumR;
                    MinimalImage = Properties.Resources.minimalR;
                    SearchImage = Properties.Resources.searchR;
                    break;
            }
        }
    }
}
