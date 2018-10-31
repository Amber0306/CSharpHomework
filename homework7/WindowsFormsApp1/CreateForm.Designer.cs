namespace WindowsFormsApp1
{
    partial class CreateForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNewId = new System.Windows.Forms.Label();
            this.lblNewCustomer = new System.Windows.Forms.Label();
            this.tbxNewId = new System.Windows.Forms.TextBox();
            this.tbxNewCustomer = new System.Windows.Forms.TextBox();
            this.btnNewYes = new System.Windows.Forms.Button();
            this.btnNewNo = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnNewNo);
            this.panel1.Controls.Add(this.btnNewYes);
            this.panel1.Controls.Add(this.tbxNewCustomer);
            this.panel1.Controls.Add(this.tbxNewId);
            this.panel1.Controls.Add(this.lblNewCustomer);
            this.panel1.Controls.Add(this.lblNewId);
            this.panel1.Location = new System.Drawing.Point(32, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(647, 426);
            this.panel1.TabIndex = 0;
            // 
            // lblNewId
            // 
            this.lblNewId.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNewId.AutoSize = true;
            this.lblNewId.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblNewId.Location = new System.Drawing.Point(84, 96);
            this.lblNewId.Name = "lblNewId";
            this.lblNewId.Size = new System.Drawing.Size(118, 30);
            this.lblNewId.TabIndex = 0;
            this.lblNewId.Text = "订单号:";
            // 
            // lblNewCustomer
            // 
            this.lblNewCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNewCustomer.AutoSize = true;
            this.lblNewCustomer.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblNewCustomer.Location = new System.Drawing.Point(84, 254);
            this.lblNewCustomer.Name = "lblNewCustomer";
            this.lblNewCustomer.Size = new System.Drawing.Size(133, 30);
            this.lblNewCustomer.TabIndex = 1;
            this.lblNewCustomer.Text = "客户名：";
            // 
            // tbxNewId
            // 
            this.tbxNewId.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxNewId.Location = new System.Drawing.Point(340, 96);
            this.tbxNewId.Name = "tbxNewId";
            this.tbxNewId.Size = new System.Drawing.Size(194, 28);
            this.tbxNewId.TabIndex = 2;
            // 
            // tbxNewCustomer
            // 
            this.tbxNewCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxNewCustomer.Location = new System.Drawing.Point(340, 256);
            this.tbxNewCustomer.Name = "tbxNewCustomer";
            this.tbxNewCustomer.Size = new System.Drawing.Size(194, 28);
            this.tbxNewCustomer.TabIndex = 3;
            // 
            // btnNewYes
            // 
            this.btnNewYes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewYes.Location = new System.Drawing.Point(107, 354);
            this.btnNewYes.Name = "btnNewYes";
            this.btnNewYes.Size = new System.Drawing.Size(110, 37);
            this.btnNewYes.TabIndex = 4;
            this.btnNewYes.Text = "确定";
            this.btnNewYes.UseVisualStyleBackColor = true;
            this.btnNewYes.Click += new System.EventHandler(this.btnNewYes_Click);
            // 
            // btnNewNo
            // 
            this.btnNewNo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewNo.Location = new System.Drawing.Point(352, 354);
            this.btnNewNo.Name = "btnNewNo";
            this.btnNewNo.Size = new System.Drawing.Size(97, 37);
            this.btnNewNo.TabIndex = 5;
            this.btnNewNo.Text = "取消";
            this.btnNewNo.UseVisualStyleBackColor = true;
            this.btnNewNo.Click += new System.EventHandler(this.btnNewNo_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "新建订单";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbxNewCustomer;
        private System.Windows.Forms.TextBox tbxNewId;
        private System.Windows.Forms.Label lblNewCustomer;
        private System.Windows.Forms.Label lblNewId;
        private System.Windows.Forms.Button btnNewNo;
        private System.Windows.Forms.Button btnNewYes;
    }
}