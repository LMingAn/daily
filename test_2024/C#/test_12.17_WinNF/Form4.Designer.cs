namespace test_12._17_WinNF
{
    partial class Form4
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
            this.btnQBooks = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnQBooks
            // 
            this.btnQBooks.Font = new System.Drawing.Font("宋体", 14F);
            this.btnQBooks.Location = new System.Drawing.Point(237, 190);
            this.btnQBooks.Margin = new System.Windows.Forms.Padding(4);
            this.btnQBooks.Name = "btnQBooks";
            this.btnQBooks.Size = new System.Drawing.Size(438, 114);
            this.btnQBooks.TabIndex = 16;
            this.btnQBooks.Text = "一键查询图书的名称，价格，出版社，作者";
            this.btnQBooks.UseVisualStyleBackColor = true;
            this.btnQBooks.Click += new System.EventHandler(this.btnQBooks_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 532);
            this.Controls.Add(this.btnQBooks);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnQBooks;
    }
}