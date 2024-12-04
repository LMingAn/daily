namespace test_11._22_WinNF
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
            this.btnOK = new System.Windows.Forms.Button();
            this.lstCourse = new System.Windows.Forms.ListBox();
            this.cboSpec = new System.Windows.Forms.ComboBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.radFemale = new System.Windows.Forms.RadioButton();
            this.radMale = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("宋体", 14F);
            this.btnOK.Location = new System.Drawing.Point(497, 635);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(119, 50);
            this.btnOK.TabIndex = 29;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // lstCourse
            // 
            this.lstCourse.Font = new System.Drawing.Font("宋体", 14F);
            this.lstCourse.FormattingEnabled = true;
            this.lstCourse.ItemHeight = 28;
            this.lstCourse.Location = new System.Drawing.Point(694, 154);
            this.lstCourse.Name = "lstCourse";
            this.lstCourse.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstCourse.Size = new System.Drawing.Size(303, 256);
            this.lstCourse.TabIndex = 27;
            // 
            // cboSpec
            // 
            this.cboSpec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSpec.Font = new System.Drawing.Font("宋体", 14F);
            this.cboSpec.FormattingEnabled = true;
            this.cboSpec.Location = new System.Drawing.Point(694, 52);
            this.cboSpec.Name = "cboSpec";
            this.cboSpec.Size = new System.Drawing.Size(303, 36);
            this.cboSpec.TabIndex = 26;
            this.cboSpec.SelectedIndexChanged += new System.EventHandler(this.cboSpec_SelectedIndexChanged);
            // 
            // txtAge
            // 
            this.txtAge.Font = new System.Drawing.Font("宋体", 14F);
            this.txtAge.Location = new System.Drawing.Point(187, 264);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(65, 39);
            this.txtAge.TabIndex = 24;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("宋体", 14F);
            this.txtName.Location = new System.Drawing.Point(187, 52);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(164, 39);
            this.txtName.TabIndex = 23;
            // 
            // radFemale
            // 
            this.radFemale.AutoSize = true;
            this.radFemale.Font = new System.Drawing.Font("宋体", 14F);
            this.radFemale.Location = new System.Drawing.Point(286, 152);
            this.radFemale.Name = "radFemale";
            this.radFemale.Size = new System.Drawing.Size(65, 32);
            this.radFemale.TabIndex = 22;
            this.radFemale.TabStop = true;
            this.radFemale.Text = "女";
            this.radFemale.UseVisualStyleBackColor = true;
            // 
            // radMale
            // 
            this.radMale.AutoSize = true;
            this.radMale.Font = new System.Drawing.Font("宋体", 14F);
            this.radMale.Location = new System.Drawing.Point(187, 152);
            this.radMale.Name = "radMale";
            this.radMale.Size = new System.Drawing.Size(65, 32);
            this.radMale.TabIndex = 21;
            this.radMale.TabStop = true;
            this.radMale.Text = "男";
            this.radMale.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 14F);
            this.label5.Location = new System.Drawing.Point(558, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 28);
            this.label5.TabIndex = 19;
            this.label5.Text = "市级";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 14F);
            this.label4.Location = new System.Drawing.Point(58, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 28);
            this.label4.TabIndex = 18;
            this.label4.Text = "年龄";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 14F);
            this.label3.Location = new System.Drawing.Point(58, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 28);
            this.label3.TabIndex = 17;
            this.label3.Text = "性别";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 14F);
            this.label2.Location = new System.Drawing.Point(558, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 28);
            this.label2.TabIndex = 16;
            this.label2.Text = "地址";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 14F);
            this.label1.Location = new System.Drawing.Point(58, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 28);
            this.label1.TabIndex = 15;
            this.label1.Text = "姓名";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 736);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lstCourse);
            this.Controls.Add(this.cboSpec);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.radFemale);
            this.Controls.Add(this.radMale);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "收货地址收集系统";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ListBox lstCourse;
        private System.Windows.Forms.ComboBox cboSpec;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.RadioButton radFemale;
        private System.Windows.Forms.RadioButton radMale;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}