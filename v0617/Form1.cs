using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace v0617
{
    public partial class Form1 : Form
    {
        int vx = -10;
        int vy = -10;
        int score = 100;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Point spos = MousePosition;
            Point fpos = PointToClient(spos);
            label3.Text = $"{fpos.X},{fpos.Y}";
            label3.Left = spos.X;
            label3.Top = spos.Y;

            label1.Top += vy;//左(-)の方向に進み続ける
            label1.Left += vx;//上(-)の方向に進み続ける
            //ラベルがフォームの端で跳ね返るようにする
            if (label1.Left < 0)
            {
                vx = Math.Abs(vx);//Math.Abs()で()内の値を絶対値(正の数に変える)
            }
            if (label1.Right > ClientSize.Width)
            {
                vx = -Math.Abs(vx);
            }
            if (label1.Top < 0)
            {
                vy = Math.Abs(vy);
            }
            if (label1.Bottom > ClientSize.Height)
            {
                vy = -Math.Abs(vy);
            }
            
            score--;
            label2.Text = $"Score {score}";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
