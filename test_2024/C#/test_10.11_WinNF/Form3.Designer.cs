namespace test_10._11_WinNF
{
    partial class Form3
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
            this.sum = new System.Windows.Forms.Button();
            this.sub = new System.Windows.Forms.Button();
            this.mul = new System.Windows.Forms.Button();
            this.exc = new System.Windows.Forms.Button();
            this.first = new System.Windows.Forms.Label();
            this.second = new System.Windows.Forms.Label();
            this.ans = new System.Windows.Forms.Label();
            this.num1 = new System.Windows.Forms.TextBox();
            this.num2 = new System.Windows.Forms.TextBox();
            this.num3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // sum
            // 
            this.sum.Location = new System.Drawing.Point(243, 375);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(75, 23);
            this.sum.TabIndex = 0;
            this.sum.Text = "+";
            this.sum.UseVisualStyleBackColor = true;
            this.sum.Click += new System.EventHandler(this.sum_Click);
            // 
            // sub
            // 
            this.sub.Location = new System.Drawing.Point(495, 375);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(75, 23);
            this.sub.TabIndex = 1;
            this.sub.Text = "-";
            this.sub.UseVisualStyleBackColor = true;
            this.sub.Click += new System.EventHandler(this.sub_Click);
            // 
            // mul
            // 
            this.mul.Location = new System.Drawing.Point(741, 375);
            this.mul.Name = "mul";
            this.mul.Size = new System.Drawing.Size(75, 23);
            this.mul.TabIndex = 2;
            this.mul.Text = "X";
            this.mul.UseVisualStyleBackColor = true;
            this.mul.Click += new System.EventHandler(this.mul_Click);
            // 
            // exc
            // 
            this.exc.Location = new System.Drawing.Point(988, 375);
            this.exc.Name = "exc";
            this.exc.Size = new System.Drawing.Size(75, 23);
            this.exc.TabIndex = 3;
            this.exc.Text = "/";
            this.exc.UseVisualStyleBackColor = true;
            this.exc.Click += new System.EventHandler(this.exc_Click);
            // 
            // first
            // 
            this.first.AutoSize = true;
            this.first.Location = new System.Drawing.Point(240, 161);
            this.first.Name = "first";
            this.first.Size = new System.Drawing.Size(80, 18);
            this.first.TabIndex = 4;
            this.first.Text = "第一个数";
            // 
            // second
            // 
            this.second.AutoSize = true;
            this.second.Location = new System.Drawing.Point(243, 257);
            this.second.Name = "second";
            this.second.Size = new System.Drawing.Size(80, 18);
            this.second.TabIndex = 5;
            this.second.Text = "第二个数";
            // 
            // ans
            // 
            this.ans.AutoSize = true;
            this.ans.Location = new System.Drawing.Point(243, 500);
            this.ans.Name = "ans";
            this.ans.Size = new System.Drawing.Size(80, 18);
            this.ans.TabIndex = 6;
            this.ans.Text = "运算结果";
            // 
            // num1
            // 
            this.num1.Location = new System.Drawing.Point(414, 161);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(649, 28);
            this.num1.TabIndex = 7;
            // 
            // num2
            // 
            this.num2.Location = new System.Drawing.Point(414, 246);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(649, 28);
            this.num2.TabIndex = 8;
            // 
            // num3
            // 
            this.num3.Location = new System.Drawing.Point(414, 489);
            this.num3.Name = "num3";
            this.num3.ReadOnly = true;
            this.num3.Size = new System.Drawing.Size(649, 28);
            this.num3.TabIndex = 9;
            this.num3.TextChanged += new System.EventHandler(this.num3_TextChanged);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1343, 738);
            this.Controls.Add(this.num3);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.ans);
            this.Controls.Add(this.second);
            this.Controls.Add(this.first);
            this.Controls.Add(this.exc);
            this.Controls.Add(this.mul);
            this.Controls.Add(this.sub);
            this.Controls.Add(this.sum);
            this.Name = "Form3";
            this.Text = "简单计算器";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sum;
        private System.Windows.Forms.Button sub;
        private System.Windows.Forms.Button mul;
        private System.Windows.Forms.Button exc;
        private System.Windows.Forms.Label first;
        private System.Windows.Forms.Label second;
        private System.Windows.Forms.Label ans;
        private System.Windows.Forms.TextBox num1;
        private System.Windows.Forms.TextBox num2;
        private System.Windows.Forms.TextBox num3;
    }
}