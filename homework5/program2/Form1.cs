using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace program2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            if(graphics==null)
            {
                graphics = this.CreateGraphics();
            }
            DrawCayleyTree(10, 200, 380, 100, -Math.PI / 2);
        }

        //产生随机数
        Random rnd = new Random();
        double rand()
        {
            return rnd.NextDouble();
        }

        private Graphics graphics;
        double th1 = 30 * Math.PI / 180;
        double th2 = 20 * Math.PI / 180;
        double per1 = 0.6;
        double per2 = 0.7;

        void DrawCayleyTree(int n,double x0,double y0,double leng,double th)
        {
            if (n == 0) return;

            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);

            double x2 = x0 + leng * (0.2+rand()) * Math.Cos(th);
            double y2 = y0 + leng * (0.2+rand()) * Math.Sin(th);

            DrawLine(x0, y0, x1, y1, n / 2);
            DrawLine(x0, y0, x2, y2, n / 2);

            //DrawCayleyTree(n - 1, x1, y1, per1 * leng, th + th1);
            //DrawCayleyTree(n - 1, x2, y2, per2 * leng, th - th2);

            DrawCayleyTree(n - 1, x1, y1, per1 * leng * (0.5 + rand()), th + th1 * (0.5 + rand()));
            DrawCayleyTree(n - 1, x2, y2, per2 * leng * (0.4 + rand()), th - th2 * (0.4 + rand()));
        }

        void DrawLine(double x0,double y0,double x1,double y1,int width)
        {
            graphics.DrawLine(new Pen(Color.Blue, width),(int)x0,(int)y0,(int)x1,(int)y1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Invalidate();
            //DrawCayleyTree(10, 200, 380, 100, -Math.PI / 2);
        }
    }
}
