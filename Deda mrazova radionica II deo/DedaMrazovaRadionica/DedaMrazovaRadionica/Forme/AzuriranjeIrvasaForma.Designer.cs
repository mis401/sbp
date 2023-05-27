namespace DedaMrazovaRadionica.Forme
{
    partial class AzuriranjeIrvasaForma
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
            this.cmbIrvasi = new System.Windows.Forms.ComboBox();
            this.labelIme = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelDatumRodjenja = new System.Windows.Forms.Label();
            this.labelPol = new System.Windows.Forms.Label();
            this.radioZenski = new System.Windows.Forms.RadioButton();
            this.radioMuski = new System.Windows.Forms.RadioButton();
            this.txtNadimak = new System.Windows.Forms.TextBox();
            this.labelNadimak = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grupaInfo = new System.Windows.Forms.GroupBox();
            this.btnAzuriraj = new System.Windows.Forms.Button();
            this.grupaInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbIrvasi
            // 
            this.cmbIrvasi.FormattingEnabled = true;
            this.cmbIrvasi.Location = new System.Drawing.Point(57, 64);
            this.cmbIrvasi.Name = "cmbIrvasi";
            this.cmbIrvasi.Size = new System.Drawing.Size(173, 24);
            this.cmbIrvasi.TabIndex = 0;
            this.cmbIrvasi.SelectedIndexChanged += new System.EventHandler(this.cmbIrvasi_SelectedIndexChanged);
            // 
            // labelIme
            // 
            this.labelIme.AutoSize = true;
            this.labelIme.Location = new System.Drawing.Point(54, 34);
            this.labelIme.Name = "labelIme";
            this.labelIme.Size = new System.Drawing.Size(87, 16);
            this.labelIme.TabIndex = 1;
            this.labelIme.Text = "Izaberi irvasa";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(22, 270);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(231, 22);
            this.dateTimePicker1.TabIndex = 17;
            // 
            // labelDatumRodjenja
            // 
            this.labelDatumRodjenja.AutoSize = true;
            this.labelDatumRodjenja.Location = new System.Drawing.Point(19, 234);
            this.labelDatumRodjenja.Name = "labelDatumRodjenja";
            this.labelDatumRodjenja.Size = new System.Drawing.Size(98, 16);
            this.labelDatumRodjenja.TabIndex = 16;
            this.labelDatumRodjenja.Text = "Datum rodjenja";
            // 
            // labelPol
            // 
            this.labelPol.AutoSize = true;
            this.labelPol.Location = new System.Drawing.Point(19, 166);
            this.labelPol.Name = "labelPol";
            this.labelPol.Size = new System.Drawing.Size(27, 16);
            this.labelPol.TabIndex = 15;
            this.labelPol.Text = "Pol";
            // 
            // radioZenski
            // 
            this.radioZenski.AutoSize = true;
            this.radioZenski.Location = new System.Drawing.Point(106, 194);
            this.radioZenski.Name = "radioZenski";
            this.radioZenski.Size = new System.Drawing.Size(36, 20);
            this.radioZenski.TabIndex = 14;
            this.radioZenski.TabStop = true;
            this.radioZenski.Text = "Z";
            this.radioZenski.UseVisualStyleBackColor = true;
            // 
            // radioMuski
            // 
            this.radioMuski.AutoSize = true;
            this.radioMuski.Location = new System.Drawing.Point(22, 194);
            this.radioMuski.Name = "radioMuski";
            this.radioMuski.Size = new System.Drawing.Size(39, 20);
            this.radioMuski.TabIndex = 13;
            this.radioMuski.TabStop = true;
            this.radioMuski.Text = "M";
            this.radioMuski.UseVisualStyleBackColor = true;
            // 
            // txtNadimak
            // 
            this.txtNadimak.Location = new System.Drawing.Point(22, 123);
            this.txtNadimak.Name = "txtNadimak";
            this.txtNadimak.Size = new System.Drawing.Size(120, 22);
            this.txtNadimak.TabIndex = 12;
            // 
            // labelNadimak
            // 
            this.labelNadimak.AutoSize = true;
            this.labelNadimak.Location = new System.Drawing.Point(19, 94);
            this.labelNadimak.Name = "labelNadimak";
            this.labelNadimak.Size = new System.Drawing.Size(62, 16);
            this.labelNadimak.TabIndex = 11;
            this.labelNadimak.Text = "Nadimak";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(22, 52);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(120, 22);
            this.txtIme.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ime";
            // 
            // grupaInfo
            // 
            this.grupaInfo.Controls.Add(this.dateTimePicker1);
            this.grupaInfo.Controls.Add(this.labelDatumRodjenja);
            this.grupaInfo.Controls.Add(this.labelPol);
            this.grupaInfo.Controls.Add(this.radioZenski);
            this.grupaInfo.Controls.Add(this.radioMuski);
            this.grupaInfo.Controls.Add(this.txtNadimak);
            this.grupaInfo.Controls.Add(this.labelNadimak);
            this.grupaInfo.Controls.Add(this.txtIme);
            this.grupaInfo.Controls.Add(this.label1);
            this.grupaInfo.Location = new System.Drawing.Point(361, 30);
            this.grupaInfo.Name = "grupaInfo";
            this.grupaInfo.Size = new System.Drawing.Size(297, 345);
            this.grupaInfo.TabIndex = 18;
            this.grupaInfo.TabStop = false;
            // 
            // btnAzuriraj
            // 
            this.btnAzuriraj.Location = new System.Drawing.Point(434, 389);
            this.btnAzuriraj.Name = "btnAzuriraj";
            this.btnAzuriraj.Size = new System.Drawing.Size(99, 31);
            this.btnAzuriraj.TabIndex = 19;
            this.btnAzuriraj.Text = "Azuriraj";
            this.btnAzuriraj.UseVisualStyleBackColor = true;
            this.btnAzuriraj.Click += new System.EventHandler(this.btnAzuriraj_Click);
            // 
            // AzuriranjeIrvasaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAzuriraj);
            this.Controls.Add(this.grupaInfo);
            this.Controls.Add(this.labelIme);
            this.Controls.Add(this.cmbIrvasi);
            this.Name = "AzuriranjeIrvasaForma";
            this.Text = "AzuriranjeIrvasaForma";
            this.grupaInfo.ResumeLayout(false);
            this.grupaInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbIrvasi;
        private System.Windows.Forms.Label labelIme;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label labelDatumRodjenja;
        private System.Windows.Forms.Label labelPol;
        private System.Windows.Forms.RadioButton radioZenski;
        private System.Windows.Forms.RadioButton radioMuski;
        private System.Windows.Forms.TextBox txtNadimak;
        private System.Windows.Forms.Label labelNadimak;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grupaInfo;
        private System.Windows.Forms.Button btnAzuriraj;
    }
}