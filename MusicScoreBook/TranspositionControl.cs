using System;
using System.Drawing;
using System.Windows.Forms;

namespace μScore
{
    public partial class TranspositionControl : UserControl
    {
        //铺子内容
        private string content="";

        //转调次数记录
        private int tCount;

        //调性数组
        private string[] tonality = {"C", "bD", "D", "bE", "E", "F", "bG", "G", "bA", "A", "bB", "B"};

        //指向不同调性的指针
        private int pT;

        public TranspositionControl(main m)
        {
            InitializeComponent();
        }

        //检查是否输入谱子
        private bool check()
        {
            if (originTextBox.Text == "")
            {
                showInfo("Please type your score below", Theme.MainColor4);
                return false;
            }

            if (targetTextBox.Text == "")
            {
                tCount = 0;
                pT = 0;
                content = originTextBox.Text;
                optimize();
            }
            return true;
        }

        //升调
        private void risingTone()
        {
            tCount++;

            if (tCount > 0)
                transLabel.Text = "Transposition:        Rise " + Math.Abs(tCount);
            else if (tCount < 0)
                transLabel.Text = "Transposition:        Fall " + Math.Abs(tCount);
            else
                transLabel.Text = "Transposition:        Original";

            if (pT < 11) pT++;
            else pT = 0;
            tonalityLabel.Text = "Default: C               Now: " + tonality[pT];

            content = content.Replace("#7", "[#1]");

            content = content.Replace("7", "TEMP");

            content = content.Replace("#6", "7");
            content = content.Replace("6", "#6");
            content = content.Replace("#5", "6");
            content = content.Replace("5", "#5");
            content = content.Replace("#4", "5");
            content = content.Replace("4", "#4");
            content = content.Replace("#3", "#4");
            content = content.Replace("3", "4");
            content = content.Replace("#2", "3");
            content = content.Replace("2", "#2");
            content = content.Replace("#1", "2");
            content = content.Replace("1", "#1");

            content = content.Replace("TEMP", "[1]");
            // 整理
            content = content.Replace("([", "");
            content = content.Replace("])", "");
            content = content.Replace("[(", "");
            content = content.Replace(")]", "");
        }

        //降调
        private void fallingTone()
        {
            tCount--;

            if (tCount > 0)
                transLabel.Text = "Transposition:        Rise " + Math.Abs(tCount);
            else if (tCount < 0)
                transLabel.Text = "Transposition:        Fall " + Math.Abs(tCount);
            else
                transLabel.Text = "Transposition:        Original";

            if (pT > 0) pT--;
            else pT = 11;
            tonalityLabel.Text = "Default: C               Now: " + tonality[pT];

            content = content.Replace("#1", "TEMP");
            content = content.Replace("1", "FINAL");//
            content = content.Replace("TEMP", "1");

            content = content.Replace("#2", "TEMP");
            content = content.Replace("2", "#1");
            content = content.Replace("TEMP", "2");

            content = content.Replace("#3", "TEMP");
            content = content.Replace("3", "#2");
            content = content.Replace("TEMP", "3");

            content = content.Replace("#4", "TEMP");
            content = content.Replace("4", "3");
            content = content.Replace("TEMP", "4");

            content = content.Replace("#5", "TEMP");
            content = content.Replace("5", "#4");
            content = content.Replace("TEMP", "5");

            content = content.Replace("#6", "TEMP");
            content = content.Replace("6", "#5");
            content = content.Replace("TEMP", "6");

            content = content.Replace("#7", "TEMP");
            content = content.Replace("7", "#6");//
            content = content.Replace("TEMP", "7");

            content = content.Replace("FINAL", "(7)");//
            // 整理
            content = content.Replace("([", "");
            content = content.Replace("])", "");
            content = content.Replace("[(", "");
            content = content.Replace(")]", "");
        }

        //优化微调
        private void optimize()
        {
            //TODO 调整括号，将连续的低音(1111)或者高音[1111]括号拆解成(1)(1)(1)(1),以方便转调
        }

        //升调按钮
        private void risingBtn_Click(object sender, EventArgs e)
        {
            if (check())
            {
                risingTone();
                targetTextBox.Text = content;
                showInfo("Success", Theme.MainColor1);
            }
        }

        //降调按钮
        private void fallingBtn_Click(object sender, EventArgs e)
        {
            if (check())
            {
                fallingTone();
                targetTextBox.Text = content;
                showInfo("Success", Theme.MainColor1);
            }
        }

        //升八度按钮
        private void ottavaAltaBtn_Click(object sender, EventArgs e)
        {
            if (check())
            {
                for (int i = 0; i < 12; i++)
                    risingTone();

                targetTextBox.Text = content;
                showInfo("Success", Theme.MainColor1);
            }
        }

        //降八度按钮
        private void ottavaBassaBtn_Click(object sender, EventArgs e)
        {
            if (check())
            {
                for (int i = 0; i < 12; i++)
                    fallingTone();

                targetTextBox.Text = content;
                showInfo("Success", Theme.MainColor1);
            }
        }

        //直接转掉按钮
        private void directBtn_Click(object sender, EventArgs e)
        {
            if (originTextBox.Text == "")
            {
                infoLabel.ForeColor = Theme.MainColor4;
                infoLabel.Text = "Please type your score below";
                return;
            }
            tCount = 0;
            pT = 0;
            content = originTextBox.Text;
            optimize();

            int originTonality = originTonaCombo.SelectedIndex;
            int targetTonality = targetTonaCombo.SelectedIndex;
            int count;

            if (originTonality == -1 || targetTonality == -1 || originTonality == 12 || targetTonality == 12)
            {
                infoLabel.ForeColor = Theme.MainColor4;
                infoLabel.Text = "Wrong Tonality";
                return;
            }

            if (originTonality < 12 && targetTonality < 12) count = targetTonality - originTonality;
            else if (originTonality > 12 && targetTonality > 12) count = targetTonality - originTonality;
            else if (originTonality < 12 && targetTonality > 12) count = (targetTonality - 13) - originTonality;
            else if (originTonality > 12 && targetTonality < 12) count = targetTonality - (originTonality - 13);
            else count = 0;

            if (count > 0)
            {
                for (int i = 0; i < count; i++)
                    risingTone();
                transLabel.Text = "Transposition:        Rise " + Math.Abs(count);
            }
            else if (count < 0)
            {
                for (int i = 0; i > count; i--)
                    fallingTone();
                transLabel.Text = "Transposition:        Fall " + Math.Abs(count);
            }
            else
            {
                transLabel.Text = "Transposition:        Original";
            }

            if (originTonality != 12 && targetTonality != 12)
                tonalityLabel.Text = "Origin: " + originTonaCombo.Text + "                Now: " + targetTonaCombo.Text;

            targetTextBox.Text = content;
            showInfo("Success", Theme.MainColor1);
        }

        //自动清空转调后的谱子内容
        private void originTextBox_TextChanged(object sender, EventArgs e)
        {
            content = "";
            targetTextBox.Text = "";
        }

        //处理文字2秒后消失的计时器
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            infoLabel.Text = "";
        }

        //显示信息文字
        private void showInfo(string info, Color color)
        {
            infoLabel.ForeColor = color;
            infoLabel.Text = info;
            timer1.Stop();
            timer1.Start();
        }

        //部件换色
        public void changeColor()
        {
            skinFlowLayoutPanel1.BackColor = Theme.MainColor1;
            skinFlowLayoutPanel2.BackColor = Theme.MainColor1;
            directBtn.MouseBaseColor = Theme.MainColor3;
            directBtn.DownBaseColor = Theme.MainColor3;
            risingBtn.MouseBaseColor = Theme.MainColor3;
            risingBtn.DownBaseColor = Theme.MainColor3;
            fallingBtn.MouseBaseColor = Theme.MainColor3;
            fallingBtn.DownBaseColor = Theme.MainColor3;
            ottavaAltaBtn.MouseBaseColor = Theme.MainColor3;
            ottavaAltaBtn.DownBaseColor = Theme.MainColor3;
            ottavaBassaBtn.MouseBaseColor = Theme.MainColor3;
            ottavaBassaBtn.DownBaseColor = Theme.MainColor3;
        }
    }
}
