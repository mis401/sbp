namespace DedaMrazovaRadionica.Forme
{
    partial class BrisanjeIrvasaForma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrisanjeIrvasaForma));
            this.btnObrisiIrvasa = new System.Windows.Forms.Button();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.labelIme = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnObrisiIrvasa
            // 
            this.btnObrisiIrvasa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnObrisiIrvasa.Font = new System.Drawing.Font("Segoe Script", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisiIrvasa.Location = new System.Drawing.Point(99, 134);
            this.btnObrisiIrvasa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnObrisiIrvasa.Name = "btnObrisiIrvasa";
            this.btnObrisiIrvasa.Size = new System.Drawing.Size(153, 62);
            this.btnObrisiIrvasa.TabIndex = 0;
            this.btnObrisiIrvasa.Text = "Obrisi irvasa";
            this.btnObrisiIrvasa.UseVisualStyleBackColor = false;
            this.btnObrisiIrvasa.Click += new System.EventHandler(this.btnObrisiIrvasa_Click);
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(211, 58);
            this.txtIme.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(157, 26);
            this.txtIme.TabIndex = 1;
            // 
            // labelIme
            // 
            this.labelIme.AutoSize = true;
            this.labelIme.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIme.Location = new System.Drawing.Point(38, 54);
            this.labelIme.Name = "labelIme";
            this.labelIme.Size = new System.Drawing.Size(112, 30);
            this.labelIme.TabIndex = 2;
            this.labelIme.Text = "Ime irvasa";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(409, 237);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // BrisanjeIrvasaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 328);
            this.Controls.Add(this.labelIme);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.btnObrisiIrvasa);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "BrisanjeIrvasaForma";
            this.Text = "BrisanjeIrvasaForma";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnObrisiIrvasa;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label labelIme;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}