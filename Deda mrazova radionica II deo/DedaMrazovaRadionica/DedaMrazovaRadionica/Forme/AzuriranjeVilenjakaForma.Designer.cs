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
            this.labelIme = new System.Windows.Forms.Label();
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
            this.btnNadjiVilenjaka = new System.Windows.Forms.Button();
            this.listVestine = new System.Windows.Forms.ListBox();
            this.labelVestine = new System.Windows.Forms.Label();
            this.panelBasic = new System.Windows.Forms.Panel();
            this.btnDodajVestinu = new System.Windows.Forms.Button();
            this.txtNovaVestina = new System.Windows.Forms.TextBox();
            this.labelPesma = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtPesme = new System.Windows.Forms.RichTextBox();
            this.txtImePesme = new System.Windows.Forms.TextBox();
            this.btnDodajPesmuVilenjaku = new System.Windows.Forms.Button();
            this.labelPogresnoIme = new System.Windows.Forms.Label();
            this.grupaIgracke.SuspendLayout();
            this.grupaIrvas.SuspendLayout();
            this.panelBasic.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(24, 77);
            this.txtIme.MinimumSize = new System.Drawing.Size(4, 30);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(200, 22);
            this.txtIme.TabIndex = 0;
            this.txtIme.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelIme
            // 
            this.labelIme.AutoSize = true;
            this.labelIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelIme.Location = new System.Drawing.Point(19, 29);
            this.labelIme.Name = "labelIme";
            this.labelIme.Size = new System.Drawing.Size(195, 25);
            this.labelIme.TabIndex = 1;
            this.labelIme.Text = "Unesite ime vilenjaka";
            this.labelIme.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(6, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Novo ime";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtNovoIme
            // 
            this.txtNovoIme.Location = new System.Drawing.Point(94, 16);
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
            this.grupaIrvas.Controls.Add(this.btnDodajPesmuVilenjaku);
            this.grupaIrvas.Controls.Add(this.txtImePesme);
            this.grupaIrvas.Controls.Add(this.txtPesme);
            this.grupaIrvas.Controls.Add(this.comboBox1);
            this.grupaIrvas.Controls.Add(this.labelPesma);
            this.grupaIrvas.Location = new System.Drawing.Point(416, 12);
            this.grupaIrvas.Name = "grupaIrvas";
            this.grupaIrvas.Size = new System.Drawing.Size(333, 426);
            this.grupaIrvas.TabIndex = 11;
            this.grupaIrvas.TabStop = false;
            // 
            // btnNadjiVilenjaka
            // 
            this.btnNadjiVilenjaka.Location = new System.Drawing.Point(244, 77);
            this.btnNadjiVilenjaka.Name = "btnNadjiVilenjaka";
            this.btnNadjiVilenjaka.Size = new System.Drawing.Size(55, 30);
            this.btnNadjiVilenjaka.TabIndex = 12;
            this.btnNadjiVilenjaka.Text = "Nadji";
            this.btnNadjiVilenjaka.UseVisualStyleBackColor = true;
            this.btnNadjiVilenjaka.Click += new System.EventHandler(this.btnNadji_Click);
            // 
            // listVestine
            // 
            this.listVestine.FormattingEnabled = true;
            this.listVestine.ItemHeight = 16;
            this.listVestine.Location = new System.Drawing.Point(10, 82);
            this.listVestine.Name = "listVestine";
            this.listVestine.Size = new System.Drawing.Size(262, 132);
            this.listVestine.TabIndex = 13;
            // 
            // labelVestine
            // 
            this.labelVestine.AutoSize = true;
            this.labelVestine.Location = new System.Drawing.Point(7, 54);
            this.labelVestine.Name = "labelVestine";
            this.labelVestine.Size = new System.Drawing.Size(105, 16);
            this.labelVestine.TabIndex = 14;
            this.labelVestine.Text = "Magicne vestine";
            // 
            // panelBasic
            // 
            this.panelBasic.Controls.Add(this.btnDodajVestinu);
            this.panelBasic.Controls.Add(this.txtNovaVestina);
            this.panelBasic.Controls.Add(this.labelVestine);
            this.panelBasic.Controls.Add(this.listVestine);
            this.panelBasic.Controls.Add(this.txtNovoIme);
            this.panelBasic.Controls.Add(this.label2);
            this.panelBasic.Location = new System.Drawing.Point(24, 168);
            this.panelBasic.Name = "panelBasic";
            this.panelBasic.Size = new System.Drawing.Size(298, 270);
            this.panelBasic.TabIndex = 15;
            // 
            // btnDodajVestinu
            // 
            this.btnDodajVestinu.Location = new System.Drawing.Point(166, 228);
            this.btnDodajVestinu.Name = "btnDodajVestinu";
            this.btnDodajVestinu.Size = new System.Drawing.Size(109, 27);
            this.btnDodajVestinu.TabIndex = 16;
            this.btnDodajVestinu.Text = "Dodaj vestinu";
            this.btnDodajVestinu.UseVisualStyleBackColor = true;
            // 
            // txtNovaVestina
            // 
            this.txtNovaVestina.Location = new System.Drawing.Point(10, 234);
            this.txtNovaVestina.Name = "txtNovaVestina";
            this.txtNovaVestina.Size = new System.Drawing.Size(150, 22);
            this.txtNovaVestina.TabIndex = 15;
            // 
            // labelPesma
            // 
            this.labelPesma.AutoSize = true;
            this.labelPesma.Location = new System.Drawing.Point(31, 32);
            this.labelPesma.Name = "labelPesma";
            this.labelPesma.Size = new System.Drawing.Size(50, 16);
            this.labelPesma.TabIndex = 0;
            this.labelPesma.Text = "Pesma";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(34, 67);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(137, 24);
            this.comboBox1.TabIndex = 1;
            // 
            // txtPesme
            // 
            this.txtPesme.Location = new System.Drawing.Point(33, 128);
            this.txtPesme.Name = "txtPesme";
            this.txtPesme.Size = new System.Drawing.Size(266, 230);
            this.txtPesme.TabIndex = 2;
            this.txtPesme.Text = "";
            // 
            // txtImePesme
            // 
            this.txtImePesme.Location = new System.Drawing.Point(35, 384);
            this.txtImePesme.Name = "txtImePesme";
            this.txtImePesme.Size = new System.Drawing.Size(108, 22);
            this.txtImePesme.TabIndex = 3;
            // 
            // btnDodajPesmuVilenjaku
            // 
            this.btnDodajPesmuVilenjaku.Location = new System.Drawing.Point(185, 381);
            this.btnDodajPesmuVilenjaku.Name = "btnDodajPesmuVilenjaku";
            this.btnDodajPesmuVilenjaku.Size = new System.Drawing.Size(115, 41);
            this.btnDodajPesmuVilenjaku.TabIndex = 4;
            this.btnDodajPesmuVilenjaku.Text = "Dodaj pesmu vilenjaku";
            this.btnDodajPesmuVilenjaku.UseVisualStyleBackColor = true;
            // 
            // labelPogresnoIme
            // 
            this.labelPogresnoIme.AutoSize = true;
            this.labelPogresnoIme.Location = new System.Drawing.Point(30, 112);
            this.labelPogresnoIme.Name = "labelPogresnoIme";
            this.labelPogresnoIme.Size = new System.Drawing.Size(94, 16);
            this.labelPogresnoIme.TabIndex = 16;
            this.labelPogresnoIme.Text = "Pogresno ime!";
            // 
            // AzuriranjeVilenjakaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelPogresnoIme);
            this.Controls.Add(this.panelBasic);
            this.Controls.Add(this.btnNadjiVilenjaka);
            this.Controls.Add(this.grupaIrvas);
            this.Controls.Add(this.grupaIgracke);
            this.Controls.Add(this.labelIme);
            this.Controls.Add(this.txtIme);
            this.Name = "AzuriranjeVilenjakaForma";
            this.Text = "AzuriranjeVilenjakaForma";
            this.Load += new System.EventHandler(this.AzuriranjeVilenjakaForma_Load);
            this.grupaIgracke.ResumeLayout(false);
            this.grupaIgracke.PerformLayout();
            this.grupaIrvas.ResumeLayout(false);
            this.grupaIrvas.PerformLayout();
            this.panelBasic.ResumeLayout(false);
            this.panelBasic.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label labelIme;
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
        private System.Windows.Forms.Button btnNadjiVilenjaka;
        private System.Windows.Forms.ListBox listVestine;
        private System.Windows.Forms.Label labelVestine;
        private System.Windows.Forms.Panel panelBasic;
        private System.Windows.Forms.Button btnDodajVestinu;
        private System.Windows.Forms.TextBox txtNovaVestina;
        private System.Windows.Forms.Button btnDodajPesmuVilenjaku;
        private System.Windows.Forms.TextBox txtImePesme;
        private System.Windows.Forms.RichTextBox txtPesme;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelPesma;
        private System.Windows.Forms.Label labelPogresnoIme;
    }
}