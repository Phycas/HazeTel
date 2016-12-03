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
            this.label1 = new System.Windows.Forms.Label();
            this.hddlabel = new System.Windows.Forms.Label();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(154, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "voice on";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // hddlabel
            // 
            this.hddlabel.AutoSize = true;
            this.hddlabel.BackColor = System.Drawing.Color.Coral;
            this.hddlabel.Location = new System.Drawing.Point(116, 239);
            this.hddlabel.Name = "hddlabel";
            this.hddlabel.Size = new System.Drawing.Size(31, 13);
            this.hddlabel.TabIndex = 13;
            this.hddlabel.Text = "HDD";
            // 
            // hazeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(222, 367);
            this.ControlBox = false;
            this.Controls.Add(this.hddlabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.upTimeLabel);
            this.Controls.Add(this.loadLabel);
            this.Controls.Add(this.tempLabel);
            this.Controls.Add(this.hazetelForm);
            this.Name = "hazeForm";
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label hddlabel;
    }
}

