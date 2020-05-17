namespace Gif_Maker
{
    partial class btnScramble
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(btnScramble));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.photo = new System.Windows.Forms.PictureBox();
            this.btnSelectPhoto = new System.Windows.Forms.Button();
            this.selectPhoto = new System.Windows.Forms.OpenFileDialog();
            this.btnExport = new System.Windows.Forms.Button();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.Variations = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.delay = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Variations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delay)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.photo);
            this.groupBox1.Location = new System.Drawing.Point(389, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(509, 509);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Preview";
            // 
            // photo
            // 
            this.photo.Location = new System.Drawing.Point(15, 19);
            this.photo.Name = "photo";
            this.photo.Size = new System.Drawing.Size(480, 480);
            this.photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.photo.TabIndex = 0;
            this.photo.TabStop = false;
            // 
            // btnSelectPhoto
            // 
            this.btnSelectPhoto.Location = new System.Drawing.Point(23, 46);
            this.btnSelectPhoto.Name = "btnSelectPhoto";
            this.btnSelectPhoto.Size = new System.Drawing.Size(100, 33);
            this.btnSelectPhoto.TabIndex = 11;
            this.btnSelectPhoto.Text = "Select Photo";
            this.btnSelectPhoto.UseVisualStyleBackColor = true;
            this.btnSelectPhoto.Click += new System.EventHandler(this.btnSelectPhoto_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(23, 153);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(100, 33);
            this.btnExport.TabIndex = 12;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // Variations
            // 
            this.Variations.Location = new System.Drawing.Point(85, 90);
            this.Variations.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Variations.Name = "Variations";
            this.Variations.Size = new System.Drawing.Size(50, 20);
            this.Variations.TabIndex = 13;
            this.Variations.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Variations: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Delay: ";
            // 
            // delay
            // 
            this.delay.Location = new System.Drawing.Point(85, 116);
            this.delay.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.delay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.delay.Name = "delay";
            this.delay.Size = new System.Drawing.Size(50, 20);
            this.delay.TabIndex = 15;
            this.delay.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // btnScramble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 545);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.delay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Variations);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnSelectPhoto);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "btnScramble";
            this.Text = "Spencer\'s Gif Maker";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.photo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Variations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox photo;
        private System.Windows.Forms.Button btnSelectPhoto;
        private System.Windows.Forms.OpenFileDialog selectPhoto;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.SaveFileDialog saveFile;
        private System.Windows.Forms.NumericUpDown Variations;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown delay;
    }
}

