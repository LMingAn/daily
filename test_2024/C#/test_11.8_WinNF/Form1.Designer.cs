namespace test_11._8_WinNF
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtYF = new System.Windows.Forms.TextBox();
            this.txtYF2 = new System.Windows.Forms.TextBox();
            this.txtYH = new System.Windows.Forms.TextBox();
            this.txtSF = new System.Windows.Forms.TextBox();
            this.btnPay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 14F);
            this.label1.Location = new System.Drawing.Point(297, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "请输入应付商品总额：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 14F);
            this.label2.Location = new System.Drawing.Point(353, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "应付款";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 14F);
            this.label3.Location = new System.Drawing.Point(353, 390);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "优惠费";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 14F);
            this.label4.Location = new System.Drawing.Point(353, 518);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "实付款";
            // 
            // txtYF
            // 
            this.txtYF.Font = new System.Drawing.Font("宋体", 14F);
            this.txtYF.Location = new System.Drawing.Point(615, 116);
            this.txtYF.Name = "txtYF";
            this.txtYF.Size = new System.Drawing.Size(277, 39);
            this.txtYF.TabIndex = 4;
            // 
            // txtYF2
            // 
            this.txtYF2.Font = new System.Drawing.Font("宋体", 14F);
            this.txtYF2.Location = new System.Drawing.Point(480, 257);
            this.txtYF2.Name = "txtYF2";
            this.txtYF2.ReadOnly = true;
            this.txtYF2.Size = new System.Drawing.Size(208, 39);
            this.txtYF2.TabIndex = 5;
            // 
            // txtYH
            // 
            this.txtYH.Font = new System.Drawing.Font("宋体", 14F);
            this.txtYH.Location = new System.Drawing.Point(480, 379);
            this.txtYH.Name = "txtYH";
            this.txtYH.ReadOnly = true;
            this.txtYH.Size = new System.Drawing.Size(208, 39);
            this.txtYH.TabIndex = 6;
            // 
            // txtSF
            // 
            this.txtSF.Font = new System.Drawing.Font("宋体", 14F);
            this.txtSF.Location = new System.Drawing.Point(480, 507);
            this.txtSF.Name = "txtSF";
            this.txtSF.ReadOnly = true;
            this.txtSF.Size = new System.Drawing.Size(208, 39);
            this.txtSF.TabIndex = 7;
            // 
            // btnPay
            // 
            this.btnPay.Font = new System.Drawing.Font("宋体", 14F);
            this.btnPay.Location = new System.Drawing.Point(817, 257);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(75, 289);
            this.btnPay.TabIndex = 8;
            this.btnPay.Text = "付款";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 685);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.txtSF);
            this.Controls.Add(this.txtYH);
            this.Controls.Add(this.txtYF2);
            this.Controls.Add(this.txtYF);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "超市折扣付款";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtYF;
        private System.Windows.Forms.TextBox txtYF2;
        private System.Windows.Forms.TextBox txtYH;
        private System.Windows.Forms.TextBox txtSF;
        private System.Windows.Forms.Button btnPay;
    }
}

