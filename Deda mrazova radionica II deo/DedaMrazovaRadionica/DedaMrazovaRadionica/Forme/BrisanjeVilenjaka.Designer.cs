namespace DedaMrazovaRadionica.Forme
{
    partial class BrisanjeVilenjaka
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
            this.txtImeVilenjaka = new System.Windows.Forms.TextBox();
            this.labelIme = new System.Windows.Forms.Label();
            this.btnObrisiVilenjaka = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtImeVilenjaka
            // 
            this.txtImeVilenjaka.Location = new System.Drawing.Point(51, 79);
            this.txtImeVilenjaka.Name = "txtImeVilenjaka";
            this.txtImeVilenjaka.Size = new System.Drawing.Size(188, 22);
            this.txtImeVilenjaka.TabIndex = 0;
            // 
            // labelIme
            // 
            this.labelIme.AutoSize = true;
            this.labelIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelIme.Location = new System.Drawing.Point(54, 32);
            this.labelIme.Name = "labelIme";
            this.labelIme.Size = new System.Drawing.Size(131, 25);
            this.labelIme.TabIndex = 1;
            this.labelIme.Text = "Ime vilenjaka:";
            // 
            // btnObrisiVilenjaka
            // 
            this.btnObrisiVilenjaka.Location = new System.Drawing.Point(102, 148);
            this.btnObrisiVilenjaka.Name = "btnObrisiVilenjaka";
            this.btnObrisiVilenjaka.Size = new System.Drawing.Size(82, 65);
            this.btnObrisiVilenjaka.TabIndex = 2;
            this.btnObrisiVilenjaka.Text = "Obrisi";
            this.btnObrisiVilenjaka.UseVisualStyleBackColor = true;
            this.btnObrisiVilenjaka.Click += new System.EventHandler(this.btnObrisiVilenjaka_Click);
            // 
            // BrisanjeVilenjaka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnObrisiVilenjaka);
            this.Controls.Add(this.labelIme);
            this.Controls.Add(this.txtImeVilenjaka);
            this.Name = "BrisanjeVilenjaka";
            this.Text = "BrisanjeVilenjaka";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtImeVilenjaka;
        private System.Windows.Forms.Label labelIme;
        private System.Windows.Forms.Button btnObrisiVilenjaka;
    }
}