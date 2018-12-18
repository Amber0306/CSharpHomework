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
    public partial class DetailForm : Form
    {
        public DetailForm()
        {
            InitializeComponent();
        }

        public DetailForm(string s)
        {
            InitializeComponent();
            int i = Convert.ToInt32(s);
            orderDetailBindingSource.DataSource = Form1.service.
                orderList[i-1].orderdata;
            this.label2.Text = Form1.service.orderList[i-1].id;
            this.label4.Text = Form1.service.orderList[i-1].customer;
        }

    }
}
