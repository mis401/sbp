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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(618, 490);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnAdministracija
            // 
            this.btnAdministracija.Location = new System.Drawing.Point(658, 30);
            this.btnAdministracija.Name = "btnAdministracija";
            this.btnAdministracija.Size = new System.Drawing.Size(277, 65);
            this.btnAdministracija.TabIndex = 1;
            this.btnAdministracija.Text = "ADMINISTRACIJA";
            this.btnAdministracija.UseVisualStyleBackColor = true;
            this.btnAdministracija.Click += new System.EventHandler(this.btnAdministracija_Click);
            // 
            // PocetnaStranica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 819);
            this.Controls.Add(this.btnAdministracija);
            this.Controls.Add(this.pictureBox1);
            this.Name = "PocetnaStranica";
            this.Text = "PocetnaStranica";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAdministracija;
    }
}

