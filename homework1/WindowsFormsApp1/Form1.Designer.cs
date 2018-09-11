namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button = new System.Windows.Forms.Button();
            this.text1 = new System.Windows.Forms.TextBox();
            this.text2 = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button
            // 
            this.button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button.Font = new System.Drawing.Font("Adobe 黑体 Std R", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button.Location = new System.Drawing.Point(0, 0);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(751, 183);
            this.button.TabIndex = 0;
            this.button.Text = "求乘积";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // text1
            // 
            this.text1.Dock = System.Windows.Forms.DockStyle.Top;
            this.text1.Location = new System.Drawing.Point(0, 0);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(751, 28);
            this.text1.TabIndex = 1;
            this.text1.Text = "输入数据";
            // 
            // text2
            // 
            this.text2.Dock = System.Windows.Forms.DockStyle.Top;
            this.text2.Location = new System.Drawing.Point(0, 28);
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(751, 28);
            this.text2.TabIndex = 2;
            this.text2.Text = "输入数据";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label.Location = new System.Drawing.Point(0, 143);
            this.label.MinimumSize = new System.Drawing.Size(773, 40);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(773, 40);
            this.label.TabIndex = 3;
            this.label.Text = "显示结果";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 183);
            this.Controls.Add(this.label);
            this.Controls.Add(this.text2);
            this.Controls.Add(this.text1);
            this.Controls.Add(this.button);
            this.Name = "Form1";
            this.Text = "计算两个数的积";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button;
        private System.Windows.Forms.TextBox text1;
        private System.Windows.Forms.TextBox text2;
        private System.Windows.Forms.Label label;
    }
}

