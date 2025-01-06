namespace test_12._17_WinNF
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
            this.btnQGoods = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnQGoods
            // 
            this.btnQGoods.Font = new System.Drawing.Font("宋体", 14F);
            this.btnQGoods.Location = new System.Drawing.Point(339, 224);
            this.btnQGoods.Margin = new System.Windows.Forms.Padding(4);
            this.btnQGoods.Name = "btnQGoods";
            this.btnQGoods.Size = new System.Drawing.Size(438, 60);
            this.btnQGoods.TabIndex = 15;
            this.btnQGoods.Text = "一键查询货物名称、价格、产地";
            this.btnQGoods.UseVisualStyleBackColor = true;
            this.btnQGoods.Click += new System.EventHandler(this.btnQGoods_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 734);
            this.Controls.Add(this.btnQGoods);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnQGoods;
    }
}