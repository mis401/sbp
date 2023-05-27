namespace DedaMrazovaRadionica.Forme
{
    partial class BrisanjeVilenjaka
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrisanjeVilenjaka));
            this.txtImeVilenjaka = new System.Windows.Forms.TextBox();
            this.labelIme = new System.Windows.Forms.Label();
            this.btnObrisiVilenjaka = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtImeVilenjaka
            // 
            this.txtImeVilenjaka.Location = new System.Drawing.Point(57, 99);
            this.txtImeVilenjaka.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtImeVilenjaka.Name = "txtImeVilenjaka";
            this.txtImeVilenjaka.Size = new System.Drawing.Size(211, 26);
            this.txtImeVilenjaka.TabIndex = 0;
            // 
            // labelIme
            // 
            this.labelIme.AutoSize = true;
            this.labelIme.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIme.Location = new System.Drawing.Point(61, 40);
            this.labelIme.Name = "labelIme";
            this.labelIme.Size = new System.Drawing.Size(198, 40);
            this.labelIme.TabIndex = 1;
            this.labelIme.Text = "Ime vilenjaka:";
            // 
            // btnObrisiVilenjaka
            // 
            this.btnObrisiVilenjaka.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnObrisiVilenjaka.Font = new System.Drawing.Font("Segoe Script", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisiVilenjaka.Location = new System.Drawing.Point(305, 44);
            this.btnObrisiVilenjaka.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnObrisiVilenjaka.Name = "btnObrisiVilenjaka";
            this.btnObrisiVilenjaka.Size = new System.Drawing.Size(92, 81);
            this.btnObrisiVilenjaka.TabIndex = 2;
            this.btnObrisiVilenjaka.Text = "Obrisi";
            this.btnObrisiVilenjaka.UseVisualStyleBackColor = false;
            this.btnObrisiVilenjaka.Click += new System.EventHandler(this.btnObrisiVilenjaka_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(37, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(407, 236);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // BrisanjeVilenjaka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 314);
            this.Controls.Add(this.btnObrisiVilenjaka);
            this.Controls.Add(this.labelIme);
            this.Controls.Add(this.txtImeVilenjaka);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "BrisanjeVilenjaka";
            this.Text = "BrisanjeVilenjaka";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtImeVilenjaka;
        private System.Windows.Forms.Label labelIme;
        private System.Windows.Forms.Button btnObrisiVilenjaka;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}