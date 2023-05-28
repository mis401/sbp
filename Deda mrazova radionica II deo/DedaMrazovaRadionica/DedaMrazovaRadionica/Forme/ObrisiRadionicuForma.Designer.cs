namespace DedaMrazovaRadionica.Forme
{
    partial class ObrisiRadionicuForma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ObrisiRadionicuForma));
            this.cbxDeoRadionice = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnObrisiRadionicu = new System.Windows.Forms.Button();
            this.listRadnici = new System.Windows.Forms.ListView();
            this.colIme = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colZemljaPor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDatZap = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnPrikaziRadnike = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxDeoRadionice
            // 
            this.cbxDeoRadionice.FormattingEnabled = true;
            this.cbxDeoRadionice.Location = new System.Drawing.Point(87, 85);
            this.cbxDeoRadionice.Name = "cbxDeoRadionice";
            this.cbxDeoRadionice.Size = new System.Drawing.Size(189, 28);
            this.cbxDeoRadionice.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Izaberi deo radionice:";
            // 
            // btnObrisiRadionicu
            // 
            this.btnObrisiRadionicu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnObrisiRadionicu.Font = new System.Drawing.Font("Segoe Script", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisiRadionicu.Location = new System.Drawing.Point(88, 163);
            this.btnObrisiRadionicu.Name = "btnObrisiRadionicu";
            this.btnObrisiRadionicu.Size = new System.Drawing.Size(180, 41);
            this.btnObrisiRadionicu.TabIndex = 2;
            this.btnObrisiRadionicu.Text = "Obrisi";
            this.btnObrisiRadionicu.UseVisualStyleBackColor = false;
            this.btnObrisiRadionicu.Click += new System.EventHandler(this.btnObrisiRadionicu_Click);
            // 
            // listRadnici
            // 
            this.listRadnici.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.listRadnici.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colIme,
            this.colZemljaPor,
            this.colDatZap});
            this.listRadnici.HideSelection = false;
            this.listRadnici.Location = new System.Drawing.Point(350, 24);
            this.listRadnici.Name = "listRadnici";
            this.listRadnici.Size = new System.Drawing.Size(582, 383);
            this.listRadnici.TabIndex = 4;
            this.listRadnici.UseCompatibleStateImageBehavior = false;
            this.listRadnici.View = System.Windows.Forms.View.Details;
            // 
            // colIme
            // 
            this.colIme.Text = "Ime";
            this.colIme.Width = 150;
            // 
            // colZemljaPor
            // 
            this.colZemljaPor.Text = "Zemlja porekla";
            this.colZemljaPor.Width = 150;
            // 
            // colDatZap
            // 
            this.colDatZap.Text = "Datum zaposljavanja";
            this.colDatZap.Width = 150;
            // 
            // btnPrikaziRadnike
            // 
            this.btnPrikaziRadnike.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnPrikaziRadnike.Font = new System.Drawing.Font("Segoe Script", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrikaziRadnike.Location = new System.Drawing.Point(94, 249);
            this.btnPrikaziRadnike.Name = "btnPrikaziRadnike";
            this.btnPrikaziRadnike.Size = new System.Drawing.Size(174, 41);
            this.btnPrikaziRadnike.TabIndex = 5;
            this.btnPrikaziRadnike.Text = "Prikazi radnike";
            this.btnPrikaziRadnike.UseVisualStyleBackColor = false;
            this.btnPrikaziRadnike.Click += new System.EventHandler(this.btnPrikaziRadnike_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(42, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(302, 393);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // ObrisiRadionicuForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 522);
            this.Controls.Add(this.btnPrikaziRadnike);
            this.Controls.Add(this.listRadnici);
            this.Controls.Add(this.btnObrisiRadionicu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxDeoRadionice);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ObrisiRadionicuForma";
            this.Text = "ObrisiRadionicuForma";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxDeoRadionice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnObrisiRadionicu;
        private System.Windows.Forms.ListView listRadnici;
        private System.Windows.Forms.ColumnHeader colIme;
        private System.Windows.Forms.ColumnHeader colZemljaPor;
        private System.Windows.Forms.ColumnHeader colDatZap;
        private System.Windows.Forms.Button btnPrikaziRadnike;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}