namespace DedaMrazovaRadionica.Forme
{
    partial class DodajIrvasaForma
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
            this.labelIme = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.labelNadimak = new System.Windows.Forms.Label();
            this.txtNadimak = new System.Windows.Forms.TextBox();
            this.radioMuski = new System.Windows.Forms.RadioButton();
            this.radioZenski = new System.Windows.Forms.RadioButton();
            this.labelPol = new System.Windows.Forms.Label();
            this.labelDatumRodjenja = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelIme
            // 
            this.labelIme.AutoSize = true;
            this.labelIme.Location = new System.Drawing.Point(43, 29);
            this.labelIme.Name = "labelIme";
            this.labelIme.Size = new System.Drawing.Size(29, 16);
            this.labelIme.TabIndex = 0;
            this.labelIme.Text = "Ime";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(46, 63);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(120, 22);
            this.txtIme.TabIndex = 1;
            // 
            // labelNadimak
            // 
            this.labelNadimak.AutoSize = true;
            this.labelNadimak.Location = new System.Drawing.Point(43, 107);
            this.labelNadimak.Name = "labelNadimak";
            this.labelNadimak.Size = new System.Drawing.Size(62, 16);
            this.labelNadimak.TabIndex = 2;
            this.labelNadimak.Text = "Nadimak";
            // 
            // txtNadimak
            // 
            this.txtNadimak.Location = new System.Drawing.Point(46, 136);
            this.txtNadimak.Name = "txtNadimak";
            this.txtNadimak.Size = new System.Drawing.Size(120, 22);
            this.txtNadimak.TabIndex = 3;
            // 
            // radioMuski
            // 
            this.radioMuski.AutoSize = true;
            this.radioMuski.Location = new System.Drawing.Point(46, 207);
            this.radioMuski.Name = "radioMuski";
            this.radioMuski.Size = new System.Drawing.Size(39, 20);
            this.radioMuski.TabIndex = 4;
            this.radioMuski.TabStop = true;
            this.radioMuski.Text = "M";
            this.radioMuski.UseVisualStyleBackColor = true;
            this.radioMuski.CheckedChanged += new System.EventHandler(this.radioMuski_CheckedChanged);
            // 
            // radioZenski
            // 
            this.radioZenski.AutoSize = true;
            this.radioZenski.Location = new System.Drawing.Point(130, 207);
            this.radioZenski.Name = "radioZenski";
            this.radioZenski.Size = new System.Drawing.Size(36, 20);
            this.radioZenski.TabIndex = 5;
            this.radioZenski.TabStop = true;
            this.radioZenski.Text = "Z";
            this.radioZenski.UseVisualStyleBackColor = true;
            // 
            // labelPol
            // 
            this.labelPol.AutoSize = true;
            this.labelPol.Location = new System.Drawing.Point(43, 179);
            this.labelPol.Name = "labelPol";
            this.labelPol.Size = new System.Drawing.Size(27, 16);
            this.labelPol.TabIndex = 6;
            this.labelPol.Text = "Pol";
            // 
            // labelDatumRodjenja
            // 
            this.labelDatumRodjenja.AutoSize = true;
            this.labelDatumRodjenja.Location = new System.Drawing.Point(43, 247);
            this.labelDatumRodjenja.Name = "labelDatumRodjenja";
            this.labelDatumRodjenja.Size = new System.Drawing.Size(98, 16);
            this.labelDatumRodjenja.TabIndex = 7;
            this.labelDatumRodjenja.Text = "Datum rodjenja";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(46, 283);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(231, 22);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(46, 342);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(69, 44);
            this.btnDodaj.TabIndex = 9;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // DodajIrvasaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.labelDatumRodjenja);
            this.Controls.Add(this.labelPol);
            this.Controls.Add(this.radioZenski);
            this.Controls.Add(this.radioMuski);
            this.Controls.Add(this.txtNadimak);
            this.Controls.Add(this.labelNadimak);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.labelIme);
            this.Name = "DodajIrvasaForma";
            this.Text = "DodajIrvasaForma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelIme;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label labelNadimak;
        private System.Windows.Forms.TextBox txtNadimak;
        private System.Windows.Forms.RadioButton radioMuski;
        private System.Windows.Forms.RadioButton radioZenski;
        private System.Windows.Forms.Label labelPol;
        private System.Windows.Forms.Label labelDatumRodjenja;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnDodaj;
    }
}