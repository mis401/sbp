namespace DedaMrazovaRadionica.Forme
{
    partial class AdministracijaForma
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnDodajNovogVilenjaka = new System.Windows.Forms.Button();
            this.btnObrisiPostojecegVilenjaka = new System.Windows.Forms.Button();
            this.btnAzurirajPodatkeOVilenjaku = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "VILENJACI";
            // 
            // btnDodajNovogVilenjaka
            // 
            this.btnDodajNovogVilenjaka.Location = new System.Drawing.Point(25, 78);
            this.btnDodajNovogVilenjaka.Name = "btnDodajNovogVilenjaka";
            this.btnDodajNovogVilenjaka.Size = new System.Drawing.Size(220, 40);
            this.btnDodajNovogVilenjaka.TabIndex = 1;
            this.btnDodajNovogVilenjaka.Text = "Dodaj novog vilenjaka";
            this.btnDodajNovogVilenjaka.UseVisualStyleBackColor = true;
            this.btnDodajNovogVilenjaka.Click += new System.EventHandler(this.btnDodajNovogVilenjaka_Click);
            // 
            // btnObrisiPostojecegVilenjaka
            // 
            this.btnObrisiPostojecegVilenjaka.Location = new System.Drawing.Point(25, 124);
            this.btnObrisiPostojecegVilenjaka.Name = "btnObrisiPostojecegVilenjaka";
            this.btnObrisiPostojecegVilenjaka.Size = new System.Drawing.Size(220, 39);
            this.btnObrisiPostojecegVilenjaka.TabIndex = 2;
            this.btnObrisiPostojecegVilenjaka.Text = "Obriši postojećeg vilenjaka";
            this.btnObrisiPostojecegVilenjaka.UseVisualStyleBackColor = true;
            // 
            // btnAzurirajPodatkeOVilenjaku
            // 
            this.btnAzurirajPodatkeOVilenjaku.Location = new System.Drawing.Point(25, 169);
            this.btnAzurirajPodatkeOVilenjaku.Name = "btnAzurirajPodatkeOVilenjaku";
            this.btnAzurirajPodatkeOVilenjaku.Size = new System.Drawing.Size(220, 41);
            this.btnAzurirajPodatkeOVilenjaku.TabIndex = 3;
            this.btnAzurirajPodatkeOVilenjaku.Text = "Ažuriraj podatke o vilenjaku";
            this.btnAzurirajPodatkeOVilenjaku.UseVisualStyleBackColor = true;
            // 
            // AdministracijaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAzurirajPodatkeOVilenjaku);
            this.Controls.Add(this.btnObrisiPostojecegVilenjaka);
            this.Controls.Add(this.btnDodajNovogVilenjaka);
            this.Controls.Add(this.label1);
            this.Name = "AdministracijaForma";
            this.Text = "AdministracijaForma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDodajNovogVilenjaka;
        private System.Windows.Forms.Button btnObrisiPostojecegVilenjaka;
        private System.Windows.Forms.Button btnAzurirajPodatkeOVilenjaku;
    }
}