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
            this.cbxDeoRadionice = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnObrisiRadionicu = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
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
            this.label1.Font = new System.Drawing.Font("Segoe Script", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Izaberi deo radionice:";
            // 
            // btnObrisiRadionicu
            // 
            this.btnObrisiRadionicu.Font = new System.Drawing.Font("Segoe Script", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisiRadionicu.Location = new System.Drawing.Point(88, 163);
            this.btnObrisiRadionicu.Name = "btnObrisiRadionicu";
            this.btnObrisiRadionicu.Size = new System.Drawing.Size(180, 41);
            this.btnObrisiRadionicu.TabIndex = 2;
            this.btnObrisiRadionicu.Text = "Obrisi";
            this.btnObrisiRadionicu.UseVisualStyleBackColor = true;
            this.btnObrisiRadionicu.Click += new System.EventHandler(this.btnObrisiRadionicu_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe Script", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(88, 233);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(180, 41);
            this.button2.TabIndex = 3;
            this.button2.Text = "Prikazi radnike";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // ObrisiRadionicuForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnObrisiRadionicu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxDeoRadionice);
            this.Name = "ObrisiRadionicuForma";
            this.Text = "ObrisiRadionicuForma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxDeoRadionice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnObrisiRadionicu;
        private System.Windows.Forms.Button button2;
    }
}