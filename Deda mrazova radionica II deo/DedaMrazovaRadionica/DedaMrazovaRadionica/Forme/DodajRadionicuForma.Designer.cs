namespace DedaMrazovaRadionica.Forme
{
    partial class DodajRadionicuForma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DodajRadionicuForma));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.txtTipIgracke = new System.Windows.Forms.TextBox();
            this.btnDodajRadionicu = new System.Windows.Forms.Button();
            this.labNaziv = new System.Windows.Forms.Label();
            this.labTipIgracke = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tip igracke:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Naziv:";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(151, 45);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(182, 26);
            this.txtNaziv.TabIndex = 3;
            // 
            // txtTipIgracke
            // 
            this.txtTipIgracke.Location = new System.Drawing.Point(151, 145);
            this.txtTipIgracke.Name = "txtTipIgracke";
            this.txtTipIgracke.Size = new System.Drawing.Size(182, 26);
            this.txtTipIgracke.TabIndex = 4;
            // 
            // btnDodajRadionicu
            // 
            this.btnDodajRadionicu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnDodajRadionicu.Font = new System.Drawing.Font("Segoe Script", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajRadionicu.Location = new System.Drawing.Point(151, 261);
            this.btnDodajRadionicu.Name = "btnDodajRadionicu";
            this.btnDodajRadionicu.Size = new System.Drawing.Size(115, 55);
            this.btnDodajRadionicu.TabIndex = 5;
            this.btnDodajRadionicu.Text = "Dodaj";
            this.btnDodajRadionicu.UseVisualStyleBackColor = false;
            this.btnDodajRadionicu.Click += new System.EventHandler(this.btnDodajRadionicu_Click);
            // 
            // labNaziv
            // 
            this.labNaziv.AutoSize = true;
            this.labNaziv.BackColor = System.Drawing.Color.White;
            this.labNaziv.Font = new System.Drawing.Font("Segoe Script", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNaziv.ForeColor = System.Drawing.Color.Red;
            this.labNaziv.Location = new System.Drawing.Point(52, 92);
            this.labNaziv.Name = "labNaziv";
            this.labNaziv.Size = new System.Drawing.Size(354, 27);
            this.labNaziv.TabIndex = 6;
            this.labNaziv.Text = "Radionica sa ovim nazivom vec postoji!";
            // 
            // labTipIgracke
            // 
            this.labTipIgracke.AutoSize = true;
            this.labTipIgracke.BackColor = System.Drawing.Color.White;
            this.labTipIgracke.Font = new System.Drawing.Font("Segoe Script", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTipIgracke.ForeColor = System.Drawing.Color.Red;
            this.labTipIgracke.Location = new System.Drawing.Point(43, 188);
            this.labTipIgracke.Name = "labTipIgracke";
            this.labTipIgracke.Size = new System.Drawing.Size(450, 27);
            this.labTipIgracke.TabIndex = 7;
            this.labTipIgracke.Text = "Radionica za izradu ovog tipa igracaka vec postoji!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(36, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(468, 356);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // DodajRadionicuForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labTipIgracke);
            this.Controls.Add(this.labNaziv);
            this.Controls.Add(this.btnDodajRadionicu);
            this.Controls.Add(this.txtTipIgracke);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "DodajRadionicuForma";
            this.Text = "DodajRadionicuForma";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.TextBox txtTipIgracke;
        private System.Windows.Forms.Button btnDodajRadionicu;
        private System.Windows.Forms.Label labNaziv;
        private System.Windows.Forms.Label labTipIgracke;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}