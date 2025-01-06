namespace test_12._6_WinNF
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
            this.num3 = new System.Windows.Forms.TextBox();
            this.num2 = new System.Windows.Forms.TextBox();
            this.num1 = new System.Windows.Forms.TextBox();
            this.ans = new System.Windows.Forms.Label();
            this.second = new System.Windows.Forms.Label();
            this.first = new System.Windows.Forms.Label();
            this.radSum = new System.Windows.Forms.RadioButton();
            this.radSub = new System.Windows.Forms.RadioButton();
            this.radMul = new System.Windows.Forms.RadioButton();
            this.radExc = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // num3
            // 
            this.num3.Font = new System.Drawing.Font("宋体", 14F);
            this.num3.Location = new System.Drawing.Point(261, 460);
            this.num3.Name = "num3";
            this.num3.ReadOnly = true;
            this.num3.Size = new System.Drawing.Size(649, 39);
            this.num3.TabIndex = 19;
            // 
            // num2
            // 
            this.num2.Font = new System.Drawing.Font("宋体", 14F);
            this.num2.Location = new System.Drawing.Point(261, 251);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(649, 39);
            this.num2.TabIndex = 18;
            // 
            // num1
            // 
            this.num1.Font = new System.Drawing.Font("宋体", 14F);
            this.num1.Location = new System.Drawing.Point(264, 76);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(649, 39);
            this.num1.TabIndex = 17;
            // 
            // ans
            // 
            this.ans.AutoSize = true;
            this.ans.Font = new System.Drawing.Font("宋体", 14F);
            this.ans.Location = new System.Drawing.Point(90, 471);
            this.ans.Name = "ans";
            this.ans.Size = new System.Drawing.Size(124, 28);
            this.ans.TabIndex = 16;
            this.ans.Text = "运算结果";
            // 
            // second
            // 
            this.second.AutoSize = true;
            this.second.Font = new System.Drawing.Font("宋体", 14F);
            this.second.Location = new System.Drawing.Point(90, 262);
            this.second.Name = "second";
            this.second.Size = new System.Drawing.Size(124, 28);
            this.second.TabIndex = 15;
            this.second.Text = "第二个数";
            // 
            // first
            // 
            this.first.AutoSize = true;
            this.first.Font = new System.Drawing.Font("宋体", 14F);
            this.first.Location = new System.Drawing.Point(90, 76);
            this.first.Name = "first";
            this.first.Size = new System.Drawing.Size(124, 28);
            this.first.TabIndex = 14;
            this.first.Text = "第一个数";
            // 
            // radSum
            // 
            this.radSum.AutoSize = true;
            this.radSum.Font = new System.Drawing.Font("宋体", 14F);
            this.radSum.Location = new System.Drawing.Point(95, 168);
            this.radSum.Name = "radSum";
            this.radSum.Size = new System.Drawing.Size(51, 32);
            this.radSum.TabIndex = 20;
            this.radSum.TabStop = true;
            this.radSum.Text = "+";
            this.radSum.UseVisualStyleBackColor = true;
            // 
            // radSub
            // 
            this.radSub.AutoSize = true;
            this.radSub.Font = new System.Drawing.Font("宋体", 14F);
            this.radSub.Location = new System.Drawing.Point(306, 168);
            this.radSub.Name = "radSub";
            this.radSub.Size = new System.Drawing.Size(51, 32);
            this.radSub.TabIndex = 21;
            this.radSub.TabStop = true;
            this.radSub.Text = "-";
            this.radSub.UseVisualStyleBackColor = true;
            // 
            // radMul
            // 
            this.radMul.AutoSize = true;
            this.radMul.Font = new System.Drawing.Font("宋体", 14F);
            this.radMul.Location = new System.Drawing.Point(517, 168);
            this.radMul.Name = "radMul";
            this.radMul.Size = new System.Drawing.Size(65, 32);
            this.radMul.TabIndex = 22;
            this.radMul.TabStop = true;
            this.radMul.Text = "×";
            this.radMul.UseVisualStyleBackColor = true;
            // 
            // radExc
            // 
            this.radExc.AutoSize = true;
            this.radExc.Font = new System.Drawing.Font("宋体", 14F);
            this.radExc.Location = new System.Drawing.Point(728, 168);
            this.radExc.Name = "radExc";
            this.radExc.Size = new System.Drawing.Size(65, 32);
            this.radExc.TabIndex = 23;
            this.radExc.TabStop = true;
            this.radExc.Text = "÷";
            this.radExc.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 14F);
            this.button1.Location = new System.Drawing.Point(442, 350);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 51);
            this.button1.TabIndex = 24;
            this.button1.Text = "运算";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 638);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radExc);
            this.Controls.Add(this.radMul);
            this.Controls.Add(this.radSub);
            this.Controls.Add(this.radSum);
            this.Controls.Add(this.num3);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.ans);
            this.Controls.Add(this.second);
            this.Controls.Add(this.first);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox num3;
        private System.Windows.Forms.TextBox num2;
        private System.Windows.Forms.TextBox num1;
        private System.Windows.Forms.Label ans;
        private System.Windows.Forms.Label second;
        private System.Windows.Forms.Label first;
        private System.Windows.Forms.RadioButton radSum;
        private System.Windows.Forms.RadioButton radSub;
        private System.Windows.Forms.RadioButton radMul;
        private System.Windows.Forms.RadioButton radExc;
        private System.Windows.Forms.Button button1;
    }
}