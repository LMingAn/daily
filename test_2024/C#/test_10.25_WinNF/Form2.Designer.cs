namespace test_10._25_WinNF
{
    partial class Form2
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
            this.txtName = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtName1 = new System.Windows.Forms.TextBox();
            this.txtAge1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.AutoSize = true;
            this.txtName.Font = new System.Drawing.Font("宋体", 12F);
            this.txtName.Location = new System.Drawing.Point(254, 218);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(58, 24);
            this.txtName.TabIndex = 0;
            this.txtName.Text = "姓名";
            // 
            // txtAge
            // 
            this.txtAge.AutoSize = true;
            this.txtAge.Font = new System.Drawing.Font("宋体", 12F);
            this.txtAge.Location = new System.Drawing.Point(254, 406);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(58, 24);
            this.txtAge.TabIndex = 1;
            this.txtAge.Text = "年龄";
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("宋体", 12F);
            this.btnOk.Location = new System.Drawing.Point(437, 547);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(180, 59);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "确定";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtName1
            // 
            this.txtName1.Font = new System.Drawing.Font("宋体", 12F);
            this.txtName1.Location = new System.Drawing.Point(437, 207);
            this.txtName1.Name = "txtName1";
            this.txtName1.Size = new System.Drawing.Size(180, 35);
            this.txtName1.TabIndex = 3;
            // 
            // txtAge1
            // 
            this.txtAge1.Font = new System.Drawing.Font("宋体", 12F);
            this.txtAge1.Location = new System.Drawing.Point(437, 395);
            this.txtAge1.Name = "txtAge1";
            this.txtAge1.Size = new System.Drawing.Size(180, 35);
            this.txtAge1.TabIndex = 4;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 728);
            this.Controls.Add(this.txtAge1);
            this.Controls.Add(this.txtName1);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtName);
            this.Name = "Form2";
            this.Text = "姓名和年龄的输入输出";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtName;
        private System.Windows.Forms.Label txtAge;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtName1;
        private System.Windows.Forms.TextBox txtAge1;
    }
}