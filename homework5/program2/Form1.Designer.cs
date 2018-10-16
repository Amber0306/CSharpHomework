namespace program2
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
            this.btnDraw = new System.Windows.Forms.Button();
            this.btnRedraw = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(23, 12);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(100, 46);
            this.btnDraw.TabIndex = 0;
            this.btnDraw.Text = "draw";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // btnRedraw
            // 
            this.btnRedraw.Location = new System.Drawing.Point(169, 13);
            this.btnRedraw.Name = "btnRedraw";
            this.btnRedraw.Size = new System.Drawing.Size(105, 45);
            this.btnRedraw.TabIndex = 1;
            this.btnRedraw.Text = "clear";
            this.btnRedraw.UseVisualStyleBackColor = true;
            this.btnRedraw.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 583);
            this.Controls.Add(this.btnRedraw);
            this.Controls.Add(this.btnDraw);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.Button btnRedraw;
    }
}

