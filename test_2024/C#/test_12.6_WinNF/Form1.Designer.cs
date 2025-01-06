namespace test_12._6_WinNF
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.picTraffic = new System.Windows.Forms.PictureBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnAuto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picTraffic)).BeginInit();
            this.SuspendLayout();
            // 
            // picTraffic
            // 
            this.picTraffic.Image = ((System.Drawing.Image)(resources.GetObject("picTraffic.Image")));
            this.picTraffic.Location = new System.Drawing.Point(128, 143);
            this.picTraffic.Name = "picTraffic";
            this.picTraffic.Size = new System.Drawing.Size(361, 346);
            this.picTraffic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTraffic.TabIndex = 0;
            this.picTraffic.TabStop = false;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("宋体", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTime.Location = new System.Drawing.Point(678, 297);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(63, 44);
            this.lblTime.TabIndex = 1;
            this.lblTime.Text = "30";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnAuto
            // 
            this.btnAuto.Font = new System.Drawing.Font("宋体", 14F);
            this.btnAuto.Location = new System.Drawing.Point(488, 554);
            this.btnAuto.Name = "btnAuto";
            this.btnAuto.Size = new System.Drawing.Size(138, 62);
            this.btnAuto.TabIndex = 2;
            this.btnAuto.Text = "开始";
            this.btnAuto.UseVisualStyleBackColor = true;
            this.btnAuto.Click += new System.EventHandler(this.btnAuto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 743);
            this.Controls.Add(this.btnAuto);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.picTraffic);
            this.Name = "Form1";
            this.Text = "交通灯";
            ((System.ComponentModel.ISupportInitialize)(this.picTraffic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picTraffic;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnAuto;
    }
}

