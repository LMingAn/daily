namespace test_12._6_WinNF
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.picShow = new System.Windows.Forms.PictureBox();
            this.prgPic = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picShow)).BeginInit();
            this.SuspendLayout();
            // 
            // picShow
            // 
            this.picShow.Image = ((System.Drawing.Image)(resources.GetObject("picShow.Image")));
            this.picShow.Location = new System.Drawing.Point(155, 12);
            this.picShow.Name = "picShow";
            this.picShow.Size = new System.Drawing.Size(818, 578);
            this.picShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picShow.TabIndex = 0;
            this.picShow.TabStop = false;
            this.picShow.DoubleClick += new System.EventHandler(this.picShow_DoubleClick);
            // 
            // prgPic
            // 
            this.prgPic.ForeColor = System.Drawing.Color.Lime;
            this.prgPic.Location = new System.Drawing.Point(45, 605);
            this.prgPic.Maximum = 25;
            this.prgPic.Name = "prgPic";
            this.prgPic.Size = new System.Drawing.Size(1042, 38);
            this.prgPic.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 655);
            this.Controls.Add(this.prgPic);
            this.Controls.Add(this.picShow);
            this.Name = "Form2";
            this.Text = "花框展示";
            ((System.ComponentModel.ISupportInitialize)(this.picShow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picShow;
        private System.Windows.Forms.ProgressBar prgPic;
        private System.Windows.Forms.Timer timer1;
    }
}