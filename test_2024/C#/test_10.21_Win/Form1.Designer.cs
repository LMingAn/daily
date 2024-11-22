namespace test_10._21_Win
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            lnkForm = new LinkLabel();
            lnkFile = new LinkLabel();
            lnkWeb = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(417, 86);
            label1.Name = "label1";
            label1.Size = new Size(307, 24);
            label1.TabIndex = 0;
            label1.Text = "使用LinkLabel控件链接到对象或网页";
            label1.Click += label1_Click;
            // 
            // lnkForm
            // 
            lnkForm.AutoSize = true;
            lnkForm.LinkArea = new LinkArea(3, 4);
            lnkForm.Location = new Point(507, 216);
            lnkForm.Name = "lnkForm";
            lnkForm.Size = new Size(145, 29);
            lnkForm.TabIndex = 1;
            lnkForm.TabStop = true;
            lnkForm.Text = "链接到Form窗体";
            lnkForm.UseCompatibleTextRendering = true;
            lnkForm.LinkClicked += lnkForm_LinkClicked;
            // 
            // lnkFile
            // 
            lnkFile.AutoSize = true;
            lnkFile.LinkArea = new LinkArea(3, 2);
            lnkFile.Location = new Point(507, 370);
            lnkFile.Name = "lnkFile";
            lnkFile.Size = new Size(136, 29);
            lnkFile.TabIndex = 2;
            lnkFile.TabStop = true;
            lnkFile.Text = "链接到本地文件";
            lnkFile.UseCompatibleTextRendering = true;
            lnkFile.LinkClicked += lnkFile_LinkClicked;
            // 
            // lnkWeb
            // 
            lnkWeb.AutoSize = true;
            lnkWeb.LinkArea = new LinkArea(3, 2);
            lnkWeb.Location = new Point(507, 538);
            lnkWeb.Name = "lnkWeb";
            lnkWeb.Size = new Size(136, 29);
            lnkWeb.TabIndex = 3;
            lnkWeb.TabStop = true;
            lnkWeb.Text = "链接到百度网站";
            lnkWeb.UseCompatibleTextRendering = true;
            lnkWeb.LinkClicked += lnkWeb_LinkClicked;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1180, 737);
            Controls.Add(lnkWeb);
            Controls.Add(lnkFile);
            Controls.Add(lnkForm);
            Controls.Add(label1);
            ForeColor = Color.Red;
            Name = "Form1";
            Text = "使用链接标签";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private LinkLabel lnkForm;
        private LinkLabel lnkFile;
        private LinkLabel lnkWeb;
    }
}
