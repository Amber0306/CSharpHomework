using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            string s1 = text1.Text;
            string s2 = text2.Text;
            double d1 = double.Parse(s1);
            double d2 = double.Parse(s2);
            double result = d1 * d2;
            label.Text = s1 + "与" + s2 + "的乘积是 " + result;
        }
    }
}
