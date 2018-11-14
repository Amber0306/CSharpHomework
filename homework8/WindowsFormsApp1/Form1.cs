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
   
    public partial class Form1 : Form
    {
        public string KeyWord { get; set; }
        public  static OrderService service = new OrderService();
        public Form1()
        {
            InitializeComponent();

            Order myOrder01 = service.AddOrder("20181111001", "Lily","13245678901");
            Order myOrder02 = service.AddOrder("20181111002", "Mike","15567896666");
            //给订单添加条目(商品)
            myOrder01.AddProduct("apple");
            myOrder01.AddProduct("sofa");
            myOrder02.AddProduct("banana");
            //修改订单中的内容 
            myOrder01.ChangeProduct("apple", "number", 12);//使apple的数量变为12
            myOrder01.ChangeProduct("apple", "price", 5);//使apple单价变为5
            myOrder01.ChangeProduct("sofa", "number", 3);
            myOrder01.ChangeProduct("sofa", "price", 5000);
            myOrder02.AddProduct("banana");//再增加一个banana
            myOrder02.ChangeProduct("banana", "price", 7);

            orderBindingSource.DataSource = service.orderList;
            //绑定查询条件
            txbQueryInput.DataBindings.Add("Text", this, "KeyWord");
        }

        public void InitializeForm1()
        {
            this.Close();
            Form1 newForm1 = new Form1();
            newForm1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(cbxChoose.Text=="按订单号")
            {
                orderBindingSource.DataSource = service.orderList.
                    Where(od => od.id == KeyWord);
            }
            else if(cbxChoose.Text == "按客户")
            {
                orderBindingSource.DataSource = service.orderList.
                    Where(od => od.customer == KeyWord);
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            string s = this.lblSearch.Text;
            //string s = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            new DetailForm(s).ShowDialog();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            new CreateForm().ShowDialog();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            string s = this.lblSearch.Text;
            new ChangeForm(s).ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        { 
            if (DialogResult.Yes ==
                MessageBox.Show("是否删除选中订单？", "提示",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information))
            {
                foreach (Order od in service.orderList)
                {
                    if (od.id == this.lblSearch.Text)
                    {
                        service.DeleteOrder(od);
                        break;
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {    
            BindingSource bs = new BindingSource();
            bs.DataSource = service.orderList;
            orderBindingSource.DataSource = bs;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            service.ShowExploration();
        }
    }
}
