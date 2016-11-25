namespace HazeTel
{
    partial class hazeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(hazeForm));
            this.tempLabel = new System.Windows.Forms.Label();
            this.loadLabel = new System.Windows.Forms.Label();
            this.upTimeLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.hazetelForm = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hazetelForm)).BeginInit();
            this.SuspendLayout();
            // 
            // tempLabel
            // 
            this.tempLabel.AutoSize = true;
            this.tempLabel.Font = new System.Drawing.Font("Consolas", 20F);
            this.tempLabel.ForeColor = System.Drawing.SystemColors.InfoText;
            this.tempLabel.Location = new System.Drawing.Point(33, 39);
            this.tempLabel.Name = "tempLabel";
            this.tempLabel.Size = new System.Drawing.Size(45, 32);
            this.tempLabel.TabIndex = 1;
            this.tempLabel.Text = "00";
            this.tempLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tempLabel.Click += new System.EventHandler(this.tempLabel_Click);
            // 
            // loadLabel
            // 
            this.loadLabel.AutoSize = true;
            this.loadLabel.Font = new System.Drawing.Font("Consolas", 20F);
            this.loadLabel.ForeColor = System.Drawing.SystemColors.InfoText;
            this.loadLabel.Location = new System.Drawing.Point(145, 39);
            this.loadLabel.Name = "loadLabel";
            this.loadLabel.Size = new System.Drawing.Size(45, 32);
            this.loadLabel.TabIndex = 2;
            this.loadLabel.Text = "00";
            this.loadLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.loadLabel.Click += new System.EventHandler(this.loadLabel_Click);
            // 
            // upTimeLabel
            // 
            this.upTimeLabel.AutoSize = true;
            this.upTimeLabel.Font = new System.Drawing.Font("Consolas", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upTimeLabel.ForeColor = System.Drawing.SystemColors.InfoText;
            this.upTimeLabel.Location = new System.Drawing.Point(-1, 111);
            this.upTimeLabel.Name = "upTimeLabel";
            this.upTimeLabel.Size = new System.Drawing.Size(226, 40);
            this.upTimeLabel.TabIndex = 3;
            this.upTimeLabel.Text = "00:00:00:00";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(202, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(13, 13);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // hazetelForm
            // 
            this.hazetelForm.Image = ((System.Drawing.Image)(resources.GetObject("hazetelForm.Image")));
            this.hazetelForm.Location = new System.Drawing.Point(1, 0);
            this.hazetelForm.Name = "hazetelForm";
            this.hazetelForm.Size = new System.Drawing.Size(224, 139);
            this.hazetelForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.hazetelForm.TabIndex = 11;
            this.hazetelForm.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(222, 149);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.upTimeLabel);
            this.Controls.Add(this.loadLabel);
            this.Controls.Add(this.tempLabel);
            this.Controls.Add(this.hazetelForm);
            this.Name = "Form1";
            this.Opacity = 0.75D;
            this.Text = "HazeTel ";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hazetelForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label tempLabel;
        private System.Windows.Forms.Label loadLabel;
        private System.Windows.Forms.Label upTimeLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox hazetelForm;
    }
}

