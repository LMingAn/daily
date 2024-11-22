namespace test_10._25_WinNF
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.PicBox = new System.Windows.Forms.PictureBox();
            this.picName = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // PicBox
            // 
            this.PicBox.Location = new System.Drawing.Point(229, 12);
            this.PicBox.Name = "PicBox";
            this.PicBox.Size = new System.Drawing.Size(776, 510);
            this.PicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicBox.TabIndex = 0;
            this.PicBox.TabStop = false;
            this.PicBox.WaitOnLoad = true;
            // 
            // picName
            // 
            this.picName.AutoSize = true;
            this.picName.Font = new System.Drawing.Font("宋体", 12F);
            this.picName.Location = new System.Drawing.Point(560, 544);
            this.picName.Name = "picName";
            this.picName.Size = new System.Drawing.Size(106, 24);
            this.picName.TabIndex = 1;
            this.picName.Text = "图片名称";
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("宋体", 12F);
            this.btnNext.Location = new System.Drawing.Point(562, 600);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(104, 40);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "下一幅";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "风景.jpg");
            this.imageList1.Images.SetKeyName(1, "红叶.jpg");
            this.imageList1.Images.SetKeyName(2, "花伞.jpg");
            this.imageList1.Images.SetKeyName(3, "水果.jpg");
            this.imageList1.Images.SetKeyName(4, "鲜花.jpg");
            this.imageList1.Images.SetKeyName(5, "肖像.jpg");
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 704);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.picName);
            this.Controls.Add(this.PicBox);
            this.Name = "Form6";
            this.Text = "展示图片及其名称";
            ((System.ComponentModel.ISupportInitialize)(this.PicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PicBox;
        private System.Windows.Forms.Label picName;
        private System.Windows.Forms.Button btnNext;
        public System.Windows.Forms.ImageList imageList1;
    }
}