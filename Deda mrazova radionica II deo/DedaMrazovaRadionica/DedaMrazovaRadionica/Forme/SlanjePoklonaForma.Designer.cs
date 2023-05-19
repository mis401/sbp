namespace DedaMrazovaRadionica.Forme
{
    partial class SlanjePoklonaForma
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
            this.columnInd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDodajIgracke = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listPisma
            // 
            this.listPisma.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnID,
            this.columnTekst,
            this.columnInd});
            this.listPisma.HideSelection = false;
            this.listPisma.Location = new System.Drawing.Point(24, 25);
            this.listPisma.Name = "listPisma";
            this.listPisma.Size = new System.Drawing.Size(424, 308);
            this.listPisma.TabIndex = 0;
            this.listPisma.UseCompatibleStateImageBehavior = false;
            this.listPisma.View = System.Windows.Forms.View.Details;
            this.listPisma.SelectedIndexChanged += new System.EventHandler(this.listPisma_SelectedIndexChanged);
            // 
            // columnID
            // 
            this.columnID.Text = "ID";
            // 
            // columnTekst
            // 
            this.columnTekst.Text = "Tekst";
            this.columnTekst.Width = 200;
            // 
            // columnInd
            // 
            this.columnInd.Text = "Indeks dobrote";
            // 
            // btnDodajIgracke
            // 
            this.btnDodajIgracke.Location = new System.Drawing.Point(24, 403);
            this.btnDodajIgracke.Name = "btnDodajIgracke";
            this.btnDodajIgracke.Size = new System.Drawing.Size(424, 58);
            this.btnDodajIgracke.TabIndex = 1;
            this.btnDodajIgracke.Text = "Dodaj igračke";
            this.btnDodajIgracke.UseVisualStyleBackColor = true;
            this.btnDodajIgracke.Click += new System.EventHandler(this.btnDodajIgracke_Click);
            // 
            // SlanjePoklonaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1295, 508);
            this.Controls.Add(this.btnDodajIgracke);
            this.Controls.Add(this.listPisma);
            this.Name = "SlanjePoklonaForma";
            this.Text = "SlanjePoklonaForma";
            this.Load += new System.EventHandler(this.SlanjePoklonaForma_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listPisma;
        private System.Windows.Forms.ColumnHeader columnID;
        private System.Windows.Forms.ColumnHeader columnTekst;
        private System.Windows.Forms.ColumnHeader columnInd;
        private System.Windows.Forms.Button btnDodajIgracke;
    }
}