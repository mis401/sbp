namespace DedaMrazovaRadionica.Forme
{
    partial class DodajTimForma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DodajTimForma));
            this.label1 = new System.Windows.Forms.Label();
            this.txtNazivTima = new System.Windows.Forms.TextBox();
            this.btnDodajTim = new System.Windows.Forms.Button();
            this.labNaziv = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv tima:";
            // 
            // txtNazivTima
            // 
            this.txtNazivTima.Location = new System.Drawing.Point(143, 81);
            this.txtNazivTima.Name = "txtNazivTima";
            this.txtNazivTima.Size = new System.Drawing.Size(147, 26);
            this.txtNazivTima.TabIndex = 1;
            // 
            // btnDodajTim
            // 
            this.btnDodajTim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnDodajTim.Font = new System.Drawing.Font("Segoe Script", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajTim.Location = new System.Drawing.Point(114, 187);
            this.btnDodajTim.Name = "btnDodajTim";
            this.btnDodajTim.Size = new System.Drawing.Size(84, 41);
            this.btnDodajTim.TabIndex = 2;
            this.btnDodajTim.Text = "Dodaj";
            this.btnDodajTim.UseVisualStyleBackColor = false;
            this.btnDodajTim.Click += new System.EventHandler(this.btnDodajTim_Click);
            // 
            // labNaziv
            // 
            this.labNaziv.AutoSize = true;
            this.labNaziv.BackColor = System.Drawing.Color.White;
            this.labNaziv.Font = new System.Drawing.Font("Segoe Script", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNaziv.ForeColor = System.Drawing.Color.Red;
            this.labNaziv.Location = new System.Drawing.Point(120, 127);
            this.labNaziv.Name = "labNaziv";
            this.labNaziv.Size = new System.Drawing.Size(161, 27);
            this.labNaziv.TabIndex = 3;
            this.labNaziv.Text = "Naziv vec postoji!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(17, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(336, 220);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // DodajTimForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 367);
            this.Controls.Add(this.labNaziv);
            this.Controls.Add(this.btnDodajTim);
            this.Controls.Add(this.txtNazivTima);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "DodajTimForma";
            this.Text = "DodajTimForma";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNazivTima;
        private System.Windows.Forms.Button btnDodajTim;
        private System.Windows.Forms.Label labNaziv;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}