using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Program1;

namespace WindowsFormsApp1
{
    public partial class ChangeForm : Form
    {
        public ChangeForm()
        {
            InitializeComponent();
        }

        public ChangeForm(string s)
        {
            InitializeComponent();
            this.label5.Text = s;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = label5.Text;
            int i = Convert.ToInt32(s);

            if(this.comboBox1.Text=="增加商品")
            {
                //Order od = Form1.service.orderList[i - 1];
                Form1.service.orderList[i - 1].AddProduct(this.textBox1.Text);
                //Form1.service.orderList[i - 1] = od;
            }
            else if(this.comboBox1.Text=="删除商品")
            {
                //Order od = Form1.service.orderList[i - 1];
                //List<OrderDetail> details = od.orderdata;
                foreach(OrderDetail dt in Form1.service.orderList[i - 1].orderdata)
                {
                    if(dt.pdtName==this.textBox1.Text)
                    {
                        Form1.service.orderList[i - 1].DeleteProductOrderDataList(dt);
                        break;
                    }
                }
                //Form1.service.orderList[i - 1] = od;
            }
            else if(this.comboBox1.Text=="改变某商品的数量")
            {
                //Order od = Form1.service.orderList[i - 1];
                int n = Convert.ToInt32(this.textBox2.Text);
                Form1.service.orderList[i - 1].ChangeProduct(this.textBox1.Text, "number", n);
                //Form1.service.orderList[i - 1] = od;
            }
            else if(this.comboBox1.Text=="改变某商品的单价")
            {
                //Order od = Form1.service.orderList[i - 1];
                int n = Convert.ToInt32(this.textBox3.Text);
                Form1.service.orderList[i - 1].ChangeProduct(this.textBox1.Text, "price", n);
                //Form1.service.orderList[i - 1] = od;
            }
            this.Close();
        }
    }
}
