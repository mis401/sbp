namespace DedaMrazovaRadionica.Forme
{
    partial class DodavanjeIgracakaForma
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
            this.listPisma = new System.Windows.Forms.ListView();
            this.columnID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTekst = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnIndDob = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnImeDeteta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPrezimeDeteta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxRbrPisma = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBojaPoklona = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPosveta = new System.Windows.Forms.TextBox();
            this.btnKreirajPoklon = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDodajIgrackeUPoklon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listPisma
            // 
            this.listPisma.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnID,
            this.columnTekst,
            this.columnIndDob,
            this.columnImeDeteta,
            this.columnPrezimeDeteta});
            this.listPisma.HideSelection = false;
            this.listPisma.Location = new System.Drawing.Point(32, 60);
            this.listPisma.Name = "listPisma";
            this.listPisma.Size = new System.Drawing.Size(1019, 252);
            this.listPisma.TabIndex = 0;
            this.listPisma.UseCompatibleStateImageBehavior = false;
            this.listPisma.View = System.Windows.Forms.View.Details;
            // 
            // columnID
            // 
            this.columnID.Text = "Redni broj";
            this.columnID.Width = 100;
            // 
            // columnTekst
            // 
            this.columnTekst.Text = "Tekst";
            this.columnTekst.Width = 300;
            // 
            // columnIndDob
            // 
            this.columnIndDob.Text = "Indeks dobrote";
            this.columnIndDob.Width = 135;
            // 
            // columnImeDeteta
            // 
            this.columnImeDeteta.Text = "Ime deteta";
            this.columnImeDeteta.Width = 100;
            // 
            // columnPrezimeDeteta
            // 
            this.columnPrezimeDeteta.Text = "Prezime deteta";
            this.columnPrezimeDeteta.Width = 120;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nepročitana pisma:\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 356);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Izaberi redni broj pisma:";
            // 
            // cbxRbrPisma
            // 
            this.cbxRbrPisma.FormattingEnabled = true;
            this.cbxRbrPisma.Location = new System.Drawing.Point(253, 348);
            this.cbxRbrPisma.Name = "cbxRbrPisma";
            this.cbxRbrPisma.Size = new System.Drawing.Size(121, 28);
            this.cbxRbrPisma.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 413);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Izaberi boju poklona:";
            // 
            // txtBojaPoklona
            // 
            this.txtBojaPoklona.Location = new System.Drawing.Point(253, 413);
            this.txtBojaPoklona.Name = "txtBojaPoklona";
            this.txtBojaPoklona.Size = new System.Drawing.Size(121, 26);
            this.txtBojaPoklona.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(153, 480);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Posveta:";
            // 
            // txtPosveta
            // 
            this.txtPosveta.Location = new System.Drawing.Point(253, 477);
            this.txtPosveta.Multiline = true;
            this.txtPosveta.Name = "txtPosveta";
            this.txtPosveta.Size = new System.Drawing.Size(203, 124);
            this.txtPosveta.TabIndex = 8;
            // 
            // btnKreirajPoklon
            // 
            this.btnKreirajPoklon.Location = new System.Drawing.Point(559, 348);
            this.btnKreirajPoklon.Name = "btnKreirajPoklon";
            this.btnKreirajPoklon.Size = new System.Drawing.Size(213, 51);
            this.btnKreirajPoklon.TabIndex = 9;
            this.btnKreirajPoklon.Text = "Kreiraj poklon";
            this.btnKreirajPoklon.UseVisualStyleBackColor = true;
            this.btnKreirajPoklon.Click += new System.EventHandler(this.btnKreirajPoklon_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(555, 499);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Nakon kreiranja poklona:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(555, 435);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(194, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Poklon je uspešno kreiran!";
            // 
            // btnDodajIgrackeUPoklon
            // 
            this.btnDodajIgrackeUPoklon.Location = new System.Drawing.Point(559, 536);
            this.btnDodajIgrackeUPoklon.Name = "btnDodajIgrackeUPoklon";
            this.btnDodajIgrackeUPoklon.Size = new System.Drawing.Size(213, 48);
            this.btnDodajIgrackeUPoklon.TabIndex = 13;
            this.btnDodajIgrackeUPoklon.Text = "Dodaj igračke u poklon";
            this.btnDodajIgrackeUPoklon.UseVisualStyleBackColor = true;
            // 
            // DodavanjeIgracakaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 662);
            this.Controls.Add(this.btnDodajIgrackeUPoklon);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnKreirajPoklon);
            this.Controls.Add(this.txtPosveta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBojaPoklona);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxRbrPisma);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listPisma);
            this.Name = "DodavanjeIgracakaForma";
            this.Text = "DodavanjeIgracakaForma";
            this.Load += new System.EventHandler(this.DodavanjeIgracakaForma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listPisma;
        private System.Windows.Forms.ColumnHeader columnID;
        private System.Windows.Forms.ColumnHeader columnTekst;
        private System.Windows.Forms.ColumnHeader columnIndDob;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnImeDeteta;
        private System.Windows.Forms.ColumnHeader columnPrezimeDeteta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxRbrPisma;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBojaPoklona;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPosveta;
        private System.Windows.Forms.Button btnKreirajPoklon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDodajIgrackeUPoklon;
    }
}