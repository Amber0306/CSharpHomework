﻿using System;
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
    public partial class CreateForm : Form
    {
        public CreateForm()
        {
            InitializeComponent();
        }

        private void btnNewYes_Click(object sender, EventArgs e)
        {
            Form1.service.AddOrder(tbxNewId.Text, tbxNewCustomer.Text);
            this.Close();
        }

        private void btnNewNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
