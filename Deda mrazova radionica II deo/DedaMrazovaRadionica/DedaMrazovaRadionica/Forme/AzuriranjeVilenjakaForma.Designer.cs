namespace DedaMrazovaRadionica.Forme
{
    partial class AzuriranjeVilenjakaForma
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
            this.txtIme = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNovoIme = new System.Windows.Forms.TextBox();
            this.labelTim = new System.Windows.Forms.Label();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.btnKoordinator = new System.Windows.Forms.Button();
            this.labelRadionica = new System.Windows.Forms.Label();
            this.txtRadionica = new System.Windows.Forms.TextBox();
            this.btnSef = new System.Windows.Forms.Button();
            this.grupaIgracke = new System.Windows.Forms.GroupBox();
            this.grupaIrvas = new System.Windows.Forms.GroupBox();
            this.labelPesma = new System.Windows.Forms.Label();
            this.grupaIgracke.SuspendLayout();
            this.grupaIrvas.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(69, 92);
            this.txtIme.MinimumSize = new System.Drawing.Size(0, 30);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(200, 22);
            this.txtIme.TabIndex = 0;
            this.txtIme.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(64, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Unesite ime vilenjaka";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Novo ime";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtNovoIme
            // 
            this.txtNovoIme.Location = new System.Drawing.Point(108, 180);
            this.txtNovoIme.Name = "txtNovoIme";
            this.txtNovoIme.Size = new System.Drawing.Size(161, 22);
            this.txtNovoIme.TabIndex = 3;
            // 
            // labelTim
            // 
            this.labelTim.AutoSize = true;
            this.labelTim.Location = new System.Drawing.Point(41, 18);
            this.labelTim.Name = "labelTim";
            this.labelTim.Size = new System.Drawing.Size(30, 16);
            this.labelTim.TabIndex = 4;
            this.labelTim.Text = "Tim";
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(44, 57);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(100, 22);
            this.txtTim.TabIndex = 5;
            // 
            // btnKoordinator
            // 
            this.btnKoordinator.Location = new System.Drawing.Point(44, 99);
            this.btnKoordinator.Name = "btnKoordinator";
            this.btnKoordinator.Size = new System.Drawing.Size(100, 66);
            this.btnKoordinator.TabIndex = 6;
            this.btnKoordinator.Text = "Unapredi u koordinatora tima";
            this.btnKoordinator.UseVisualStyleBackColor = true;
            // 
            // labelRadionica
            // 
            this.labelRadionica.AutoSize = true;
            this.labelRadionica.Location = new System.Drawing.Point(208, 18);
            this.labelRadionica.Name = "labelRadionica";
            this.labelRadionica.Size = new System.Drawing.Size(92, 16);
            this.labelRadionica.TabIndex = 7;
            this.labelRadionica.Text = "Deo radionice";
            // 
            // txtRadionica
            // 
            this.txtRadionica.Location = new System.Drawing.Point(211, 57);
            this.txtRadionica.Name = "txtRadionica";
            this.txtRadionica.Size = new System.Drawing.Size(94, 22);
            this.txtRadionica.TabIndex = 8;
            // 
            // btnSef
            // 
            this.btnSef.Location = new System.Drawing.Point(211, 99);
            this.btnSef.Name = "btnSef";
            this.btnSef.Size = new System.Drawing.Size(94, 66);
            this.btnSef.TabIndex = 9;
            this.btnSef.Text = "Unapredi u sefa dela radionice";
            this.btnSef.UseVisualStyleBackColor = true;
            // 
            // grupaIgracke
            // 
            this.grupaIgracke.Controls.Add(this.btnSef);
            this.grupaIgracke.Controls.Add(this.txtRadionica);
            this.grupaIgracke.Controls.Add(this.labelRadionica);
            this.grupaIgracke.Controls.Add(this.btnKoordinator);
            this.grupaIgracke.Controls.Add(this.txtTim);
            this.grupaIgracke.Controls.Add(this.labelTim);
            this.grupaIgracke.Location = new System.Drawing.Point(416, 20);
            this.grupaIgracke.Name = "grupaIgracke";
            this.grupaIgracke.Size = new System.Drawing.Size(339, 182);
            this.grupaIgracke.TabIndex = 10;
            this.grupaIgracke.TabStop = false;
            // 
            // grupaIrvas
            // 
            this.grupaIrvas.Controls.Add(this.labelPesma);
            this.grupaIrvas.Location = new System.Drawing.Point(416, 20);
            this.grupaIrvas.Name = "grupaIrvas";
            this.grupaIrvas.Size = new System.Drawing.Size(338, 181);
            this.grupaIrvas.TabIndex = 11;
            this.grupaIrvas.TabStop = false;
            // 
            // labelPesma
            // 
            this.labelPesma.AutoSize = true;
            this.labelPesma.Location = new System.Drawing.Point(41, 18);
            this.labelPesma.Name = "labelPesma";
            this.labelPesma.Size = new System.Drawing.Size(74, 16);
            this.labelPesma.TabIndex = 0;
            this.labelPesma.Text = "Ime pesme";
            // 
            // AzuriranjeVilenjakaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grupaIrvas);
            this.Controls.Add(this.grupaIgracke);
            this.Controls.Add(this.txtNovoIme);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIme);
            this.Name = "AzuriranjeVilenjakaForma";
            this.Text = "AzuriranjeVilenjakaForma";
            this.grupaIgracke.ResumeLayout(false);
            this.grupaIgracke.PerformLayout();
            this.grupaIrvas.ResumeLayout(false);
            this.grupaIrvas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNovoIme;
        private System.Windows.Forms.Label labelTim;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Button btnKoordinator;
        private System.Windows.Forms.Label labelRadionica;
        private System.Windows.Forms.TextBox txtRadionica;
        private System.Windows.Forms.Button btnSef;
        private System.Windows.Forms.GroupBox grupaIgracke;
        private System.Windows.Forms.GroupBox grupaIrvas;
        private System.Windows.Forms.Label labelPesma;
    }
}