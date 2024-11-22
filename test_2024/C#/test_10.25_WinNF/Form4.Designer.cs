namespace test_10._25_WinNF
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Pic = new System.Windows.Forms.Label();
            this.btnRedLeaf1 = new System.Windows.Forms.Button();
            this.btnGirl1 = new System.Windows.Forms.Button();
            this.btnFruit1 = new System.Windows.Forms.Button();
            this.btnUmbrella1 = new System.Windows.Forms.Button();
            this.btnFlower1 = new System.Windows.Forms.Button();
            this.btnView1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "红叶.jpg");
            this.imageList1.Images.SetKeyName(1, "水果.jpg");
            this.imageList1.Images.SetKeyName(2, "鲜花.jpg");
            this.imageList1.Images.SetKeyName(3, "肖像.jpg");
            this.imageList1.Images.SetKeyName(4, "花伞.jpg");
            this.imageList1.Images.SetKeyName(5, "风景.jpg");
            // 
            // Pic
            // 
            this.Pic.Font = new System.Drawing.Font("宋体", 12F);
            this.Pic.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Pic.ImageKey = "风景.jpg";
            this.Pic.ImageList = this.imageList1;
            this.Pic.Location = new System.Drawing.Point(395, 101);
            this.Pic.Name = "Pic";
            this.Pic.Size = new System.Drawing.Size(158, 157);
            this.Pic.TabIndex = 0;
            this.Pic.Text = "小图片展示";
            this.Pic.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnRedLeaf1
            // 
            this.btnRedLeaf1.Font = new System.Drawing.Font("宋体", 12F);
            this.btnRedLeaf1.Location = new System.Drawing.Point(212, 371);
            this.btnRedLeaf1.Name = "btnRedLeaf1";
            this.btnRedLeaf1.Size = new System.Drawing.Size(75, 46);
            this.btnRedLeaf1.TabIndex = 1;
            this.btnRedLeaf1.Text = "红叶";
            this.btnRedLeaf1.UseVisualStyleBackColor = true;
            this.btnRedLeaf1.Click += new System.EventHandler(this.btnRedLeaf1_Click);
            // 
            // btnGirl1
            // 
            this.btnGirl1.Font = new System.Drawing.Font("宋体", 12F);
            this.btnGirl1.Location = new System.Drawing.Point(212, 481);
            this.btnGirl1.Name = "btnGirl1";
            this.btnGirl1.Size = new System.Drawing.Size(75, 47);
            this.btnGirl1.TabIndex = 2;
            this.btnGirl1.Text = "肖像";
            this.btnGirl1.UseVisualStyleBackColor = true;
            this.btnGirl1.Click += new System.EventHandler(this.btnGirl1_Click);
            // 
            // btnFruit1
            // 
            this.btnFruit1.Font = new System.Drawing.Font("宋体", 12F);
            this.btnFruit1.Location = new System.Drawing.Point(436, 371);
            this.btnFruit1.Name = "btnFruit1";
            this.btnFruit1.Size = new System.Drawing.Size(75, 45);
            this.btnFruit1.TabIndex = 3;
            this.btnFruit1.Text = "水果";
            this.btnFruit1.UseVisualStyleBackColor = true;
            this.btnFruit1.Click += new System.EventHandler(this.btnFruit1_Click);
            // 
            // btnUmbrella1
            // 
            this.btnUmbrella1.Font = new System.Drawing.Font("宋体", 12F);
            this.btnUmbrella1.Location = new System.Drawing.Point(436, 481);
            this.btnUmbrella1.Name = "btnUmbrella1";
            this.btnUmbrella1.Size = new System.Drawing.Size(75, 46);
            this.btnUmbrella1.TabIndex = 4;
            this.btnUmbrella1.Text = "花伞";
            this.btnUmbrella1.UseVisualStyleBackColor = true;
            this.btnUmbrella1.Click += new System.EventHandler(this.btnUmbrella1_Click);
            // 
            // btnFlower1
            // 
            this.btnFlower1.Font = new System.Drawing.Font("宋体", 12F);
            this.btnFlower1.Location = new System.Drawing.Point(645, 371);
            this.btnFlower1.Name = "btnFlower1";
            this.btnFlower1.Size = new System.Drawing.Size(75, 46);
            this.btnFlower1.TabIndex = 5;
            this.btnFlower1.Text = "鲜花";
            this.btnFlower1.UseVisualStyleBackColor = true;
            this.btnFlower1.Click += new System.EventHandler(this.btnFlower1_Click);
            // 
            // btnView1
            // 
            this.btnView1.Font = new System.Drawing.Font("宋体", 12F);
            this.btnView1.Location = new System.Drawing.Point(645, 481);
            this.btnView1.Name = "btnView1";
            this.btnView1.Size = new System.Drawing.Size(75, 45);
            this.btnView1.TabIndex = 6;
            this.btnView1.Text = "风景";
            this.btnView1.UseVisualStyleBackColor = true;
            this.btnView1.Click += new System.EventHandler(this.btnView1_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 636);
            this.Controls.Add(this.btnView1);
            this.Controls.Add(this.btnFlower1);
            this.Controls.Add(this.btnUmbrella1);
            this.Controls.Add(this.btnFruit1);
            this.Controls.Add(this.btnGirl1);
            this.Controls.Add(this.btnRedLeaf1);
            this.Controls.Add(this.Pic);
            this.MaximizeBox = false;
            this.Name = "Form4";
            this.Text = "小图片切换";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label Pic;
        private System.Windows.Forms.Button btnRedLeaf1;
        private System.Windows.Forms.Button btnGirl1;
        private System.Windows.Forms.Button btnFruit1;
        private System.Windows.Forms.Button btnUmbrella1;
        private System.Windows.Forms.Button btnFlower1;
        private System.Windows.Forms.Button btnView1;
    }
}