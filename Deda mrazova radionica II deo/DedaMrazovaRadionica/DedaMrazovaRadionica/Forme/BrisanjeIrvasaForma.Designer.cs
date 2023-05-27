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
            this.btnObrisiIrvasa = new System.Windows.Forms.Button();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.labelIme = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnObrisiIrvasa
            // 
            this.btnObrisiIrvasa.Location = new System.Drawing.Point(98, 131);
            this.btnObrisiIrvasa.Name = "btnObrisiIrvasa";
            this.btnObrisiIrvasa.Size = new System.Drawing.Size(136, 50);
            this.btnObrisiIrvasa.TabIndex = 0;
            this.btnObrisiIrvasa.Text = "Obrisi irvasa";
            this.btnObrisiIrvasa.UseVisualStyleBackColor = true;
            this.btnObrisiIrvasa.Click += new System.EventHandler(this.btnObrisiIrvasa_Click);
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(98, 83);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(140, 22);
            this.txtIme.TabIndex = 1;
            // 
            // labelIme
            // 
            this.labelIme.AutoSize = true;
            this.labelIme.Location = new System.Drawing.Point(95, 28);
            this.labelIme.Name = "labelIme";
            this.labelIme.Size = new System.Drawing.Size(69, 16);
            this.labelIme.TabIndex = 2;
            this.labelIme.Text = "Ime irvasa";
            // 
            // BrisanjeIrvasaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelIme);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.btnObrisiIrvasa);
            this.Name = "BrisanjeIrvasaForma";
            this.Text = "BrisanjeIrvasaForma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnObrisiIrvasa;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label labelIme;
    }
}