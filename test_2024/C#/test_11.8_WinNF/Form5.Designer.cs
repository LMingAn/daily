namespace test_11._8_WinNF
{
    partial class Form5
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
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radGLY = new System.Windows.Forms.RadioButton();
            this.radJS = new System.Windows.Forms.RadioButton();
            this.radXS = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCance = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tpLogin = new System.Windows.Forms.TabPage();
            this.tabMIS = new System.Windows.Forms.TabControl();
            this.tpBook = new System.Windows.Forms.TabPage();
            this.pnlBook = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.tpRead = new System.Windows.Forms.TabPage();
            this.pnlRead = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnExit2 = new System.Windows.Forms.Button();
            this.btnLogout2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.pnlLogin.SuspendLayout();
            this.tpLogin.SuspendLayout();
            this.tabMIS.SuspendLayout();
            this.tpBook.SuspendLayout();
            this.tpRead.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(155, 194);
            this.txtPwd.MaxLength = 10;
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(248, 39);
            this.txtPwd.TabIndex = 3;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(155, 78);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(248, 39);
            this.txtUser.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "密  码";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名";
            // 
            // radGLY
            // 
            this.radGLY.AutoSize = true;
            this.radGLY.Location = new System.Drawing.Point(486, 47);
            this.radGLY.Name = "radGLY";
            this.radGLY.Size = new System.Drawing.Size(121, 32);
            this.radGLY.TabIndex = 2;
            this.radGLY.Text = "管理员";
            this.radGLY.UseVisualStyleBackColor = true;
            this.radGLY.CheckedChanged += new System.EventHandler(this.radGLY_CheckedChanged);
            // 
            // radJS
            // 
            this.radJS.AutoSize = true;
            this.radJS.Location = new System.Drawing.Point(276, 47);
            this.radJS.Name = "radJS";
            this.radJS.Size = new System.Drawing.Size(93, 32);
            this.radJS.TabIndex = 1;
            this.radJS.Text = "教师";
            this.radJS.UseVisualStyleBackColor = true;
            this.radJS.CheckedChanged += new System.EventHandler(this.radJS_CheckedChanged);
            // 
            // radXS
            // 
            this.radXS.AutoSize = true;
            this.radXS.Checked = true;
            this.radXS.Location = new System.Drawing.Point(53, 47);
            this.radXS.Name = "radXS";
            this.radXS.Size = new System.Drawing.Size(93, 32);
            this.radXS.TabIndex = 0;
            this.radXS.TabStop = true;
            this.radXS.Text = "学生";
            this.radXS.UseVisualStyleBackColor = true;
            this.radXS.CheckedChanged += new System.EventHandler(this.radXS_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radGLY);
            this.groupBox1.Controls.Add(this.radJS);
            this.groupBox1.Controls.Add(this.radXS);
            this.groupBox1.Location = new System.Drawing.Point(18, 314);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(710, 96);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "身  份";
            // 
            // btnCance
            // 
            this.btnCance.Location = new System.Drawing.Point(518, 531);
            this.btnCance.Name = "btnCance";
            this.btnCance.Size = new System.Drawing.Size(188, 62);
            this.btnCance.TabIndex = 7;
            this.btnCance.Text = "取消(&C)";
            this.btnCance.UseVisualStyleBackColor = true;
            this.btnCance.Click += new System.EventHandler(this.btnCance_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(237, 531);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(188, 62);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "确定(&O)";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // pnlLogin
            // 
            this.pnlLogin.Controls.Add(this.button3);
            this.pnlLogin.Controls.Add(this.button4);
            this.pnlLogin.Controls.Add(this.btnCance);
            this.pnlLogin.Controls.Add(this.btnOK);
            this.pnlLogin.Controls.Add(this.groupBox1);
            this.pnlLogin.Controls.Add(this.txtPwd);
            this.pnlLogin.Controls.Add(this.txtUser);
            this.pnlLogin.Controls.Add(this.label2);
            this.pnlLogin.Controls.Add(this.label1);
            this.pnlLogin.Location = new System.Drawing.Point(6, 27);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(989, 615);
            this.pnlLogin.TabIndex = 0;
            this.pnlLogin.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlLogin_Paint);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(518, 418);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(0, 0);
            this.button3.TabIndex = 10;
            this.button3.Text = "退出系统";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(154, 418);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(0, 0);
            this.button4.TabIndex = 9;
            this.button4.Text = "注销登录";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // tpLogin
            // 
            this.tpLogin.Controls.Add(this.pnlLogin);
            this.tpLogin.Location = new System.Drawing.Point(4, 38);
            this.tpLogin.Name = "tpLogin";
            this.tpLogin.Padding = new System.Windows.Forms.Padding(3);
            this.tpLogin.Size = new System.Drawing.Size(1025, 648);
            this.tpLogin.TabIndex = 0;
            this.tpLogin.Text = "用户登录";
            this.tpLogin.UseVisualStyleBackColor = true;
            // 
            // tabMIS
            // 
            this.tabMIS.Controls.Add(this.tpLogin);
            this.tabMIS.Controls.Add(this.tpBook);
            this.tabMIS.Controls.Add(this.tpRead);
            this.tabMIS.Font = new System.Drawing.Font("宋体", 14F);
            this.tabMIS.Location = new System.Drawing.Point(49, 15);
            this.tabMIS.Name = "tabMIS";
            this.tabMIS.SelectedIndex = 0;
            this.tabMIS.Size = new System.Drawing.Size(1033, 690);
            this.tabMIS.TabIndex = 1;
            // 
            // tpBook
            // 
            this.tpBook.Controls.Add(this.pnlBook);
            this.tpBook.Controls.Add(this.label10);
            this.tpBook.Controls.Add(this.label9);
            this.tpBook.Controls.Add(this.label8);
            this.tpBook.Controls.Add(this.label7);
            this.tpBook.Controls.Add(this.label6);
            this.tpBook.Controls.Add(this.label5);
            this.tpBook.Controls.Add(this.label4);
            this.tpBook.Controls.Add(this.label3);
            this.tpBook.Controls.Add(this.btnExit);
            this.tpBook.Controls.Add(this.btnLogout);
            this.tpBook.Location = new System.Drawing.Point(4, 38);
            this.tpBook.Name = "tpBook";
            this.tpBook.Padding = new System.Windows.Forms.Padding(3);
            this.tpBook.Size = new System.Drawing.Size(1025, 648);
            this.tpBook.TabIndex = 1;
            this.tpBook.Text = "图书信息";
            this.tpBook.UseVisualStyleBackColor = true;
            // 
            // pnlBook
            // 
            this.pnlBook.Location = new System.Drawing.Point(27, 28);
            this.pnlBook.Name = "pnlBook";
            this.pnlBook.Size = new System.Drawing.Size(979, 596);
            this.pnlBook.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(646, 385);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(208, 28);
            this.label10.TabIndex = 16;
            this.label10.Text = "杀死一只知更鸟";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(210, 385);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 28);
            this.label9.TabIndex = 15;
            this.label9.Text = "白夜行";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(646, 274);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 28);
            this.label8.TabIndex = 14;
            this.label8.Text = "百年孤独";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(210, 274);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 28);
            this.label7.TabIndex = 13;
            this.label7.Text = "三体全集";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(646, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 28);
            this.label6.TabIndex = 12;
            this.label6.Text = "活着";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(210, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 28);
            this.label5.TabIndex = 11;
            this.label5.Text = "红楼梦";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(646, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 28);
            this.label4.TabIndex = 10;
            this.label4.Text = "我们一无所有";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(210, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 28);
            this.label3.TabIndex = 9;
            this.label3.Text = "肖申克的救赎";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(605, 562);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(188, 62);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "退出系统";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(241, 562);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(188, 62);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "注销登录";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click_1);
            // 
            // tpRead
            // 
            this.tpRead.Controls.Add(this.pnlRead);
            this.tpRead.Controls.Add(this.label14);
            this.tpRead.Controls.Add(this.label13);
            this.tpRead.Controls.Add(this.label12);
            this.tpRead.Controls.Add(this.label11);
            this.tpRead.Controls.Add(this.btnExit2);
            this.tpRead.Controls.Add(this.btnLogout2);
            this.tpRead.Location = new System.Drawing.Point(4, 38);
            this.tpRead.Name = "tpRead";
            this.tpRead.Padding = new System.Windows.Forms.Padding(3);
            this.tpRead.Size = new System.Drawing.Size(1025, 648);
            this.tpRead.TabIndex = 2;
            this.tpRead.Text = "借阅信息";
            this.tpRead.UseVisualStyleBackColor = true;
            // 
            // pnlRead
            // 
            this.pnlRead.Location = new System.Drawing.Point(50, 41);
            this.pnlRead.Name = "pnlRead";
            this.pnlRead.Size = new System.Drawing.Size(947, 583);
            this.pnlRead.TabIndex = 14;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(162, 392);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(446, 28);
            this.label14.TabIndex = 13;
            this.label14.Text = "王六，123456004，白夜行，借阅中";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(162, 289);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(530, 28);
            this.label13.TabIndex = 12;
            this.label13.Text = "刘五，123456003，肖申克的救赎，借阅中";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(162, 181);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(530, 28);
            this.label12.TabIndex = 11;
            this.label12.Text = "李四，123456002，我们一无所有，借阅中";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(162, 85);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(418, 28);
            this.label11.TabIndex = 10;
            this.label11.Text = "张三，123456001，活着，借阅中";
            // 
            // btnExit2
            // 
            this.btnExit2.Location = new System.Drawing.Point(605, 562);
            this.btnExit2.Name = "btnExit2";
            this.btnExit2.Size = new System.Drawing.Size(188, 62);
            this.btnExit2.TabIndex = 8;
            this.btnExit2.Text = "退出系统";
            this.btnExit2.UseVisualStyleBackColor = true;
            this.btnExit2.Click += new System.EventHandler(this.btnExit2_Click);
            // 
            // btnLogout2
            // 
            this.btnLogout2.Location = new System.Drawing.Point(241, 562);
            this.btnLogout2.Name = "btnLogout2";
            this.btnLogout2.Size = new System.Drawing.Size(188, 62);
            this.btnLogout2.TabIndex = 7;
            this.btnLogout2.Text = "注销登录";
            this.btnLogout2.UseVisualStyleBackColor = true;
            this.btnLogout2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 721);
            this.Controls.Add(this.tabMIS);
            this.Name = "Form5";
            this.Text = "图书借阅管理系统";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.tpLogin.ResumeLayout(false);
            this.tabMIS.ResumeLayout(false);
            this.tpBook.ResumeLayout(false);
            this.tpBook.PerformLayout();
            this.tpRead.ResumeLayout(false);
            this.tpRead.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radGLY;
        private System.Windows.Forms.RadioButton radJS;
        private System.Windows.Forms.RadioButton radXS;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCance;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.TabPage tpLogin;
        private System.Windows.Forms.TabControl tabMIS;
        private System.Windows.Forms.TabPage tpBook;
        private System.Windows.Forms.TabPage tpRead;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnExit2;
        private System.Windows.Forms.Button btnLogout2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel pnlBook;
        private System.Windows.Forms.Panel pnlRead;
    }
}