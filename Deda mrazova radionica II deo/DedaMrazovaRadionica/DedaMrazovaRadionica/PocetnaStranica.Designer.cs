namespace DedaMrazovaRadionica
{
    partial class PocetnaStranica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PocetnaStranica));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAdministracija = new System.Windows.Forms.Button();
            this.btnSlanjePoklona = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(618, 490);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnAdministracija
            // 
            this.btnAdministracija.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAdministracija.Font = new System.Drawing.Font("Segoe Script", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdministracija.Location = new System.Drawing.Point(659, 210);
            this.btnAdministracija.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdministracija.Name = "btnAdministracija";
            this.btnAdministracija.Size = new System.Drawing.Size(277, 65);
            this.btnAdministracija.TabIndex = 1;
            this.btnAdministracija.Text = "ADMINISTRACIJA";
            this.btnAdministracija.UseVisualStyleBackColor = false;
            this.btnAdministracija.Click += new System.EventHandler(this.btnAdministracija_Click);
            // 
            // btnSlanjePoklona
            // 
<<<<<<< HEAD
<<<<<<< HEAD
            this.btnSlanjePoklona.Location = new System.Drawing.Point(658, 153);
            this.btnSlanjePoklona.Name = "btnSlanjePoklona";
            this.btnSlanjePoklona.Size = new System.Drawing.Size(277, 61);
            this.btnSlanjePoklona.TabIndex = 3;
=======
            this.btnSlanjePoklona.Location = new System.Drawing.Point(585, 128);
=======
            this.btnSlanjePoklona.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSlanjePoklona.Font = new System.Drawing.Font("Segoe Script", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSlanjePoklona.Location = new System.Drawing.Point(659, 349);
            this.btnSlanjePoklona.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
>>>>>>> aebf600b1526cf479c91654d3bcc5672263a2347
            this.btnSlanjePoklona.Name = "btnSlanjePoklona";
            this.btnSlanjePoklona.Size = new System.Drawing.Size(276, 72);
            this.btnSlanjePoklona.TabIndex = 2;
>>>>>>> eea386a205e3fabf15af7496aa13cd7212f619f5
            this.btnSlanjePoklona.Text = "SLANJE POKLONA";
            this.btnSlanjePoklona.UseVisualStyleBackColor = false;
            this.btnSlanjePoklona.Click += new System.EventHandler(this.btnSlanjePoklona_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(64, 504);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(807, 76);
            this.label1.TabIndex = 3;
            this.label1.Text = "DEDA MRAZOVA RADIONICA";
            // 
            // PocetnaStranica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(979, 819);
=======
            this.ClientSize = new System.Drawing.Size(870, 655);
>>>>>>> eea386a205e3fabf15af7496aa13cd7212f619f5
=======
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(979, 819);
            this.Controls.Add(this.label1);
>>>>>>> aebf600b1526cf479c91654d3bcc5672263a2347
            this.Controls.Add(this.btnSlanjePoklona);
            this.Controls.Add(this.btnAdministracija);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PocetnaStranica";
            this.Text = "PocetnaStranica";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAdministracija;
        private System.Windows.Forms.Button btnSlanjePoklona;
        private System.Windows.Forms.Label label1;
    }
}

