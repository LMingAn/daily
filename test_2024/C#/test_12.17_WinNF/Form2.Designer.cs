namespace test_12._17_WinNF
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
            this.txtQuery = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radNo = new System.Windows.Forms.RadioButton();
            this.radName = new System.Windows.Forms.RadioButton();
            this.btnConn = new System.Windows.Forms.Button();
            this.btnQuery = new System.Windows.Forms.Button();
            this.btnQSex = new System.Windows.Forms.Button();
            this.btnQCollege = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtQuery
            // 
            this.txtQuery.Font = new System.Drawing.Font("宋体", 14F);
            this.txtQuery.Location = new System.Drawing.Point(506, 326);
            this.txtQuery.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.Size = new System.Drawing.Size(259, 39);
            this.txtQuery.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 14F);
            this.label1.Location = new System.Drawing.Point(262, 337);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 28);
            this.label1.TabIndex = 9;
            this.label1.Text = "请输入查询内容：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radNo);
            this.groupBox1.Controls.Add(this.radName);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 14F);
            this.groupBox1.Location = new System.Drawing.Point(297, 109);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(474, 150);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "请选择查询依据";
            // 
            // radNo
            // 
            this.radNo.AutoSize = true;
            this.radNo.Location = new System.Drawing.Point(237, 62);
            this.radNo.Margin = new System.Windows.Forms.Padding(4);
            this.radNo.Name = "radNo";
            this.radNo.Size = new System.Drawing.Size(177, 32);
            this.radNo.TabIndex = 1;
            this.radNo.Text = "按学号查询";
            this.radNo.UseVisualStyleBackColor = true;
            // 
            // radName
            // 
            this.radName.AutoSize = true;
            this.radName.Checked = true;
            this.radName.Location = new System.Drawing.Point(24, 62);
            this.radName.Margin = new System.Windows.Forms.Padding(4);
            this.radName.Name = "radName";
            this.radName.Size = new System.Drawing.Size(177, 32);
            this.radName.TabIndex = 0;
            this.radName.TabStop = true;
            this.radName.Text = "按姓名查询";
            this.radName.UseVisualStyleBackColor = true;
            // 
            // btnConn
            // 
            this.btnConn.Font = new System.Drawing.Font("宋体", 14F);
            this.btnConn.Location = new System.Drawing.Point(270, 396);
            this.btnConn.Margin = new System.Windows.Forms.Padding(4);
            this.btnConn.Name = "btnConn";
            this.btnConn.Size = new System.Drawing.Size(147, 60);
            this.btnConn.TabIndex = 13;
            this.btnConn.Text = "断开连接";
            this.btnConn.UseVisualStyleBackColor = true;
            this.btnConn.Click += new System.EventHandler(this.btnConn_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.Font = new System.Drawing.Font("宋体", 14F);
            this.btnQuery.Location = new System.Drawing.Point(644, 396);
            this.btnQuery.Margin = new System.Windows.Forms.Padding(4);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(121, 60);
            this.btnQuery.TabIndex = 12;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // btnQSex
            // 
            this.btnQSex.Font = new System.Drawing.Font("宋体", 14F);
            this.btnQSex.Location = new System.Drawing.Point(270, 483);
            this.btnQSex.Margin = new System.Windows.Forms.Padding(4);
            this.btnQSex.Name = "btnQSex";
            this.btnQSex.Size = new System.Drawing.Size(467, 60);
            this.btnQSex.TabIndex = 14;
            this.btnQSex.Text = "查询性别为男的姓名、专业，地址";
            this.btnQSex.UseVisualStyleBackColor = true;
            this.btnQSex.Click += new System.EventHandler(this.btnQSex_Click);
            // 
            // btnQCollege
            // 
            this.btnQCollege.Font = new System.Drawing.Font("宋体", 14F);
            this.btnQCollege.Location = new System.Drawing.Point(267, 564);
            this.btnQCollege.Margin = new System.Windows.Forms.Padding(4);
            this.btnQCollege.Name = "btnQCollege";
            this.btnQCollege.Size = new System.Drawing.Size(555, 60);
            this.btnQCollege.TabIndex = 15;
            this.btnQCollege.Text = "查询电气学院的姓名、性别，地址，爱好";
            this.btnQCollege.UseVisualStyleBackColor = true;
            this.btnQCollege.Click += new System.EventHandler(this.btnQCollege_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 669);
            this.Controls.Add(this.btnQCollege);
            this.Controls.Add(this.btnQSex);
            this.Controls.Add(this.btnConn);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.txtQuery);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "学生信息模糊查询";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtQuery;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radNo;
        private System.Windows.Forms.RadioButton radName;
        private System.Windows.Forms.Button btnConn;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Button btnQSex;
        private System.Windows.Forms.Button btnQCollege;
    }
}