namespace test_10._25_WinNF
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
            this.picChange = new System.Windows.Forms.PictureBox();
            this.btnRedLeaf = new System.Windows.Forms.Button();
            this.btnFruit = new System.Windows.Forms.Button();
            this.btnFlower = new System.Windows.Forms.Button();
            this.btnGirl = new System.Windows.Forms.Button();
            this.btnUmbrella = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picChange)).BeginInit();
            this.SuspendLayout();
            // 
            // picChange
            // 
            this.picChange.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picChange.Image = global::test_10._25_WinNF.Properties.Resources.风景;
            this.picChange.Location = new System.Drawing.Point(80, 29);
            this.picChange.Name = "picChange";
            this.picChange.Size = new System.Drawing.Size(905, 537);
            this.picChange.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picChange.TabIndex = 0;
            this.picChange.TabStop = false;
            // 
            // btnRedLeaf
            // 
            this.btnRedLeaf.Font = new System.Drawing.Font("宋体", 12F);
            this.btnRedLeaf.Location = new System.Drawing.Point(80, 601);
            this.btnRedLeaf.Name = "btnRedLeaf";
            this.btnRedLeaf.Size = new System.Drawing.Size(75, 49);
            this.btnRedLeaf.TabIndex = 1;
            this.btnRedLeaf.Text = "红叶";
            this.btnRedLeaf.UseVisualStyleBackColor = true;
            this.btnRedLeaf.Click += new System.EventHandler(this.btnRedLeaf_Click);
            // 
            // btnFruit
            // 
            this.btnFruit.Font = new System.Drawing.Font("宋体", 12F);
            this.btnFruit.Location = new System.Drawing.Point(248, 601);
            this.btnFruit.Name = "btnFruit";
            this.btnFruit.Size = new System.Drawing.Size(74, 49);
            this.btnFruit.TabIndex = 2;
            this.btnFruit.Text = "水果";
            this.btnFruit.UseVisualStyleBackColor = true;
            this.btnFruit.Click += new System.EventHandler(this.btnFruit_Click);
            // 
            // btnFlower
            // 
            this.btnFlower.Font = new System.Drawing.Font("宋体", 12F);
            this.btnFlower.Location = new System.Drawing.Point(414, 601);
            this.btnFlower.Name = "btnFlower";
            this.btnFlower.Size = new System.Drawing.Size(75, 49);
            this.btnFlower.TabIndex = 3;
            this.btnFlower.Text = "鲜花";
            this.btnFlower.UseVisualStyleBackColor = true;
            this.btnFlower.Click += new System.EventHandler(this.btnFlower_Click);
            // 
            // btnGirl
            // 
            this.btnGirl.Font = new System.Drawing.Font("宋体", 12F);
            this.btnGirl.Location = new System.Drawing.Point(577, 601);
            this.btnGirl.Name = "btnGirl";
            this.btnGirl.Size = new System.Drawing.Size(75, 49);
            this.btnGirl.TabIndex = 4;
            this.btnGirl.Text = "肖像";
            this.btnGirl.UseVisualStyleBackColor = true;
            this.btnGirl.Click += new System.EventHandler(this.btnGirl_Click);
            // 
            // btnUmbrella
            // 
            this.btnUmbrella.Font = new System.Drawing.Font("宋体", 12F);
            this.btnUmbrella.Location = new System.Drawing.Point(746, 601);
            this.btnUmbrella.Name = "btnUmbrella";
            this.btnUmbrella.Size = new System.Drawing.Size(75, 49);
            this.btnUmbrella.TabIndex = 5;
            this.btnUmbrella.Text = "花伞";
            this.btnUmbrella.UseVisualStyleBackColor = true;
            this.btnUmbrella.Click += new System.EventHandler(this.btnUmbrella_Click);
            // 
            // btnView
            // 
            this.btnView.Font = new System.Drawing.Font("宋体", 12F);
            this.btnView.Location = new System.Drawing.Point(910, 601);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(75, 49);
            this.btnView.TabIndex = 6;
            this.btnView.Text = "风景";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 704);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnUmbrella);
            this.Controls.Add(this.btnGirl);
            this.Controls.Add(this.btnFlower);
            this.Controls.Add(this.btnFruit);
            this.Controls.Add(this.btnRedLeaf);
            this.Controls.Add(this.picChange);
            this.MaximizeBox = false;
            this.Name = "Form3";
            this.Text = "图片切换";
            ((System.ComponentModel.ISupportInitialize)(this.picChange)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picChange;
        private System.Windows.Forms.Button btnRedLeaf;
        private System.Windows.Forms.Button btnFruit;
        private System.Windows.Forms.Button btnFlower;
        private System.Windows.Forms.Button btnGirl;
        private System.Windows.Forms.Button btnUmbrella;
        private System.Windows.Forms.Button btnView;
    }
}