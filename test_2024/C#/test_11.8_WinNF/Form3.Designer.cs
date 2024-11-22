namespace test_11._8_WinNF
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
            this.tabMIS = new System.Windows.Forms.TabControl();
            this.tpLogin = new System.Windows.Forms.TabPage();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.btnCance = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chk5 = new System.Windows.Forms.CheckBox();
            this.chk4 = new System.Windows.Forms.CheckBox();
            this.chk3 = new System.Windows.Forms.CheckBox();
            this.chk2 = new System.Windows.Forms.CheckBox();
            this.chk1 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radGLY = new System.Windows.Forms.RadioButton();
            this.radJS = new System.Windows.Forms.RadioButton();
            this.radXS = new System.Windows.Forms.RadioButton();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tpRecord = new System.Windows.Forms.TabPage();
            this.pnlRecord = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnMod = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnIns = new System.Windows.Forms.Button();
            this.btnBro = new System.Windows.Forms.Button();
            this.btnSel = new System.Windows.Forms.Button();
            this.tabMIS.SuspendLayout();
            this.tpLogin.SuspendLayout();
            this.pnlLogin.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tpRecord.SuspendLayout();
            this.pnlRecord.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMIS
            // 
            this.tabMIS.Controls.Add(this.tpLogin);
            this.tabMIS.Controls.Add(this.tpRecord);
            this.tabMIS.Font = new System.Drawing.Font("宋体", 14F);
            this.tabMIS.Location = new System.Drawing.Point(12, 12);
            this.tabMIS.Name = "tabMIS";
            this.tabMIS.SelectedIndex = 0;
            this.tabMIS.Size = new System.Drawing.Size(1033, 690);
            this.tabMIS.TabIndex = 0;
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
            // pnlLogin
            // 
            this.pnlLogin.Controls.Add(this.btnCance);
            this.pnlLogin.Controls.Add(this.btnOK);
            this.pnlLogin.Controls.Add(this.groupBox2);
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
            // btnCance
            // 
            this.btnCance.Location = new System.Drawing.Point(421, 535);
            this.btnCance.Name = "btnCance";
            this.btnCance.Size = new System.Drawing.Size(124, 47);
            this.btnCance.TabIndex = 7;
            this.btnCance.Text = "取消(&C)";
            this.btnCance.UseVisualStyleBackColor = true;
            this.btnCance.Click += new System.EventHandler(this.btnCance_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(155, 535);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(124, 47);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "确定(&O)";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chk5);
            this.groupBox2.Controls.Add(this.chk4);
            this.groupBox2.Controls.Add(this.chk3);
            this.groupBox2.Controls.Add(this.chk2);
            this.groupBox2.Controls.Add(this.chk1);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(18, 324);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(710, 188);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "权  限";
            // 
            // chk5
            // 
            this.chk5.AutoSize = true;
            this.chk5.Location = new System.Drawing.Point(259, 122);
            this.chk5.Name = "chk5";
            this.chk5.Size = new System.Drawing.Size(94, 32);
            this.chk5.TabIndex = 4;
            this.chk5.Text = "修改";
            this.chk5.UseVisualStyleBackColor = true;
            // 
            // chk4
            // 
            this.chk4.AutoSize = true;
            this.chk4.Location = new System.Drawing.Point(31, 122);
            this.chk4.Name = "chk4";
            this.chk4.Size = new System.Drawing.Size(94, 32);
            this.chk4.TabIndex = 3;
            this.chk4.Text = "删除";
            this.chk4.UseVisualStyleBackColor = true;
            // 
            // chk3
            // 
            this.chk3.AutoSize = true;
            this.chk3.Location = new System.Drawing.Point(486, 55);
            this.chk3.Name = "chk3";
            this.chk3.Size = new System.Drawing.Size(94, 32);
            this.chk3.TabIndex = 2;
            this.chk3.Text = "添加";
            this.chk3.UseVisualStyleBackColor = true;
            // 
            // chk2
            // 
            this.chk2.AutoSize = true;
            this.chk2.Location = new System.Drawing.Point(259, 55);
            this.chk2.Name = "chk2";
            this.chk2.Size = new System.Drawing.Size(94, 32);
            this.chk2.TabIndex = 1;
            this.chk2.Text = "浏览";
            this.chk2.UseVisualStyleBackColor = true;
            // 
            // chk1
            // 
            this.chk1.AutoSize = true;
            this.chk1.Checked = true;
            this.chk1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk1.Location = new System.Drawing.Point(31, 55);
            this.chk1.Name = "chk1";
            this.chk1.Size = new System.Drawing.Size(94, 32);
            this.chk1.TabIndex = 0;
            this.chk1.Text = "查询";
            this.chk1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radGLY);
            this.groupBox1.Controls.Add(this.radJS);
            this.groupBox1.Controls.Add(this.radXS);
            this.groupBox1.Location = new System.Drawing.Point(18, 203);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(710, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "身  份";
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
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(155, 122);
            this.txtPwd.MaxLength = 10;
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(248, 39);
            this.txtPwd.TabIndex = 3;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(155, 38);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(248, 39);
            this.txtUser.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "密  码";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名";
            // 
            // tpRecord
            // 
            this.tpRecord.Controls.Add(this.pnlRecord);
            this.tpRecord.Location = new System.Drawing.Point(4, 38);
            this.tpRecord.Name = "tpRecord";
            this.tpRecord.Padding = new System.Windows.Forms.Padding(3);
            this.tpRecord.Size = new System.Drawing.Size(1025, 648);
            this.tpRecord.TabIndex = 1;
            this.tpRecord.Text = "学生档案";
            this.tpRecord.UseVisualStyleBackColor = true;
            // 
            // pnlRecord
            // 
            this.pnlRecord.Controls.Add(this.btnExit);
            this.pnlRecord.Controls.Add(this.btnLogout);
            this.pnlRecord.Controls.Add(this.btnMod);
            this.pnlRecord.Controls.Add(this.btnDel);
            this.pnlRecord.Controls.Add(this.btnIns);
            this.pnlRecord.Controls.Add(this.btnBro);
            this.pnlRecord.Controls.Add(this.btnSel);
            this.pnlRecord.Location = new System.Drawing.Point(6, 27);
            this.pnlRecord.Name = "pnlRecord";
            this.pnlRecord.Size = new System.Drawing.Size(989, 615);
            this.pnlRecord.TabIndex = 1;
            this.pnlRecord.Visible = false;
            this.pnlRecord.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlRecord_Paint);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(576, 439);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(188, 62);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "退出系统";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(212, 439);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(188, 62);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "注销登录";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnMod
            // 
            this.btnMod.Image = global::test_11._8_WinNF.Properties.Resources.Pokemon_039;
            this.btnMod.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMod.Location = new System.Drawing.Point(398, 244);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(150, 95);
            this.btnMod.TabIndex = 4;
            this.btnMod.Text = "修改";
            this.btnMod.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMod.UseVisualStyleBackColor = true;
            this.btnMod.Click += new System.EventHandler(this.btnMod_Click);
            // 
            // btnDel
            // 
            this.btnDel.Image = global::test_11._8_WinNF.Properties.Resources.no_dog2;
            this.btnDel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDel.Location = new System.Drawing.Point(91, 244);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(150, 95);
            this.btnDel.TabIndex = 3;
            this.btnDel.Text = "删除";
            this.btnDel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnIns
            // 
            this.btnIns.Image = global::test_11._8_WinNF.Properties.Resources.ki_con;
            this.btnIns.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIns.Location = new System.Drawing.Point(692, 61);
            this.btnIns.Name = "btnIns";
            this.btnIns.Size = new System.Drawing.Size(150, 95);
            this.btnIns.TabIndex = 2;
            this.btnIns.Text = "插入";
            this.btnIns.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIns.UseVisualStyleBackColor = true;
            this.btnIns.Click += new System.EventHandler(this.btnIns_Click);
            // 
            // btnBro
            // 
            this.btnBro.Image = global::test_11._8_WinNF.Properties.Resources.BINOS;
            this.btnBro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBro.Location = new System.Drawing.Point(398, 61);
            this.btnBro.Name = "btnBro";
            this.btnBro.Size = new System.Drawing.Size(150, 95);
            this.btnBro.TabIndex = 1;
            this.btnBro.Text = "浏览";
            this.btnBro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBro.UseVisualStyleBackColor = true;
            this.btnBro.Click += new System.EventHandler(this.btnBro_Click);
            // 
            // btnSel
            // 
            this.btnSel.Image = global::test_11._8_WinNF.Properties.Resources._41;
            this.btnSel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSel.Location = new System.Drawing.Point(91, 61);
            this.btnSel.Name = "btnSel";
            this.btnSel.Size = new System.Drawing.Size(150, 95);
            this.btnSel.TabIndex = 0;
            this.btnSel.Text = "查询";
            this.btnSel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSel.UseVisualStyleBackColor = true;
            this.btnSel.Click += new System.EventHandler(this.btnSel_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 714);
            this.Controls.Add(this.tabMIS);
            this.MaximizeBox = false;
            this.Name = "Form3";
            this.Text = "学生档案管理系统";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.tabMIS.ResumeLayout(false);
            this.tpLogin.ResumeLayout(false);
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tpRecord.ResumeLayout(false);
            this.pnlRecord.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMIS;
        private System.Windows.Forms.TabPage tpLogin;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.TabPage tpRecord;
        private System.Windows.Forms.Panel pnlRecord;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.RadioButton radGLY;
        private System.Windows.Forms.RadioButton radJS;
        private System.Windows.Forms.RadioButton radXS;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chk5;
        private System.Windows.Forms.CheckBox chk4;
        private System.Windows.Forms.CheckBox chk3;
        private System.Windows.Forms.CheckBox chk2;
        private System.Windows.Forms.CheckBox chk1;
        private System.Windows.Forms.Button btnCance;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnIns;
        private System.Windows.Forms.Button btnBro;
        private System.Windows.Forms.Button btnSel;
    }
}