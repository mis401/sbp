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
            this.btnKoordinator = new System.Windows.Forms.Button();
            this.labelRadionica = new System.Windows.Forms.Label();
            this.btnSef = new System.Windows.Forms.Button();
            this.grupaIgracke = new System.Windows.Forms.GroupBox();
            this.btnIzmenaTima = new System.Windows.Forms.Button();
            this.cmbRadionice = new System.Windows.Forms.ComboBox();
            this.cmbTimovi = new System.Windows.Forms.ComboBox();
            this.grupaIrvas = new System.Windows.Forms.GroupBox();
            this.btnDodajPesmuVilenjaku = new System.Windows.Forms.Button();
            this.btnPromeniIrvasa = new System.Windows.Forms.Button();
            this.txtImePesme = new System.Windows.Forms.TextBox();
            this.labelPesma = new System.Windows.Forms.Label();
            this.txtPesme = new System.Windows.Forms.RichTextBox();
            this.txtNoviIrvas = new System.Windows.Forms.TextBox();
            this.cmbPesme = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUkloniPesmuVilenjaku = new System.Windows.Forms.Button();
            this.txtTrenutniIrvas = new System.Windows.Forms.TextBox();
            this.labelIrvas = new System.Windows.Forms.Label();
            this.btnNadjiVilenjaka = new System.Windows.Forms.Button();
            this.listVestine = new System.Windows.Forms.ListBox();
            this.labelVestine = new System.Windows.Forms.Label();
            this.panelBasic = new System.Windows.Forms.Panel();
            this.btnPromeniIme = new System.Windows.Forms.Button();
            this.buttonUkloniVestinu = new System.Windows.Forms.Button();
            this.btnDodajVestinu = new System.Windows.Forms.Button();
            this.txtNovaVestina = new System.Windows.Forms.TextBox();
            this.labelPogresnoIme = new System.Windows.Forms.Label();
            this.grupaPokloni = new System.Windows.Forms.GroupBox();
            this.tabelaPoklona = new System.Windows.Forms.DataGridView();
            this.grupaTovari = new System.Windows.Forms.GroupBox();
            this.tabelaTovari = new System.Windows.Forms.DataGridView();
            this.grupaIgracke.SuspendLayout();
            this.grupaIrvas.SuspendLayout();
            this.panelBasic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaPoklona)).BeginInit();
            this.grupaTovari.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaTovari)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(27, 96);
            this.txtIme.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtIme.MinimumSize = new System.Drawing.Size(4, 30);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(224, 26);
            this.txtIme.TabIndex = 0;
            this.txtIme.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelIme
            // 
            this.labelIme.AutoSize = true;
            this.labelIme.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIme.Location = new System.Drawing.Point(21, 36);
            this.labelIme.Name = "labelIme";
            this.labelIme.Size = new System.Drawing.Size(300, 40);
            this.labelIme.TabIndex = 1;
            this.labelIme.Text = "Unesite ime vilenjaka";
            this.labelIme.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Novo ime";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtNovoIme
            // 
            this.txtNovoIme.Location = new System.Drawing.Point(113, 22);
            this.txtNovoIme.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNovoIme.Name = "txtNovoIme";
            this.txtNovoIme.Size = new System.Drawing.Size(181, 26);
            this.txtNovoIme.TabIndex = 3;
            // 
            // labelTim
            // 
            this.labelTim.AutoSize = true;
            this.labelTim.Location = new System.Drawing.Point(196, 22);
            this.labelTim.Name = "labelTim";
            this.labelTim.Size = new System.Drawing.Size(34, 20);
            this.labelTim.TabIndex = 4;
            this.labelTim.Text = "Tim";
            // 
            // btnKoordinator
            // 
            this.btnKoordinator.Location = new System.Drawing.Point(199, 124);
            this.btnKoordinator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnKoordinator.Name = "btnKoordinator";
            this.btnKoordinator.Size = new System.Drawing.Size(112, 82);
            this.btnKoordinator.TabIndex = 6;
            this.btnKoordinator.Text = "Unapredi u koordinatora tima";
            this.btnKoordinator.UseVisualStyleBackColor = true;
            this.btnKoordinator.Click += new System.EventHandler(this.btnKoordinator_Click);
            // 
            // labelRadionica
            // 
            this.labelRadionica.AutoSize = true;
            this.labelRadionica.Location = new System.Drawing.Point(36, 22);
            this.labelRadionica.Name = "labelRadionica";
            this.labelRadionica.Size = new System.Drawing.Size(107, 20);
            this.labelRadionica.TabIndex = 7;
            this.labelRadionica.Text = "Deo radionice";
            // 
            // btnSef
            // 
            this.btnSef.Location = new System.Drawing.Point(39, 124);
            this.btnSef.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSef.Name = "btnSef";
            this.btnSef.Size = new System.Drawing.Size(106, 82);
            this.btnSef.TabIndex = 9;
            this.btnSef.Text = "Unapredi u sefa dela radionice";
            this.btnSef.UseVisualStyleBackColor = true;
            this.btnSef.Click += new System.EventHandler(this.btnSef_Click);
            // 
            // grupaIgracke
            // 
            this.grupaIgracke.Controls.Add(this.btnIzmenaTima);
            this.grupaIgracke.Controls.Add(this.cmbRadionice);
            this.grupaIgracke.Controls.Add(this.cmbTimovi);
            this.grupaIgracke.Controls.Add(this.btnSef);
            this.grupaIgracke.Controls.Add(this.labelRadionica);
            this.grupaIgracke.Controls.Add(this.btnKoordinator);
            this.grupaIgracke.Controls.Add(this.labelTim);
            this.grupaIgracke.Location = new System.Drawing.Point(451, 15);
            this.grupaIgracke.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grupaIgracke.Name = "grupaIgracke";
            this.grupaIgracke.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grupaIgracke.Size = new System.Drawing.Size(381, 228);
            this.grupaIgracke.TabIndex = 10;
            this.grupaIgracke.TabStop = false;
            // 
            // btnIzmenaTima
            // 
            this.btnIzmenaTima.Location = new System.Drawing.Point(326, 68);
            this.btnIzmenaTima.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnIzmenaTima.Name = "btnIzmenaTima";
            this.btnIzmenaTima.Size = new System.Drawing.Size(48, 38);
            this.btnIzmenaTima.TabIndex = 12;
            this.btnIzmenaTima.Text = "OK";
            this.btnIzmenaTima.UseVisualStyleBackColor = true;
            this.btnIzmenaTima.Click += new System.EventHandler(this.btnIzmenaTima_Click);
            // 
            // cmbRadionice
            // 
            this.cmbRadionice.FormattingEnabled = true;
            this.cmbRadionice.Location = new System.Drawing.Point(39, 72);
            this.cmbRadionice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbRadionice.Name = "cmbRadionice";
            this.cmbRadionice.Size = new System.Drawing.Size(110, 28);
            this.cmbRadionice.TabIndex = 11;
            // 
            // cmbTimovi
            // 
            this.cmbTimovi.FormattingEnabled = true;
            this.cmbTimovi.Location = new System.Drawing.Point(199, 72);
            this.cmbTimovi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbTimovi.Name = "cmbTimovi";
            this.cmbTimovi.Size = new System.Drawing.Size(105, 28);
            this.cmbTimovi.TabIndex = 10;
            // 
            // grupaIrvas
            // 
            this.grupaIrvas.Controls.Add(this.btnDodajPesmuVilenjaku);
            this.grupaIrvas.Controls.Add(this.btnPromeniIrvasa);
            this.grupaIrvas.Controls.Add(this.txtImePesme);
            this.grupaIrvas.Controls.Add(this.labelPesma);
            this.grupaIrvas.Controls.Add(this.txtPesme);
            this.grupaIrvas.Controls.Add(this.txtNoviIrvas);
            this.grupaIrvas.Controls.Add(this.cmbPesme);
            this.grupaIrvas.Controls.Add(this.label1);
            this.grupaIrvas.Controls.Add(this.btnUkloniPesmuVilenjaku);
            this.grupaIrvas.Controls.Add(this.txtTrenutniIrvas);
            this.grupaIrvas.Controls.Add(this.labelIrvas);
            this.grupaIrvas.Location = new System.Drawing.Point(475, 15);
            this.grupaIrvas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grupaIrvas.Name = "grupaIrvas";
            this.grupaIrvas.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grupaIrvas.Size = new System.Drawing.Size(512, 532);
            this.grupaIrvas.TabIndex = 11;
            this.grupaIrvas.TabStop = false;
            // 
            // btnDodajPesmuVilenjaku
            // 
            this.btnDodajPesmuVilenjaku.Location = new System.Drawing.Point(191, 478);
            this.btnDodajPesmuVilenjaku.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDodajPesmuVilenjaku.Name = "btnDodajPesmuVilenjaku";
            this.btnDodajPesmuVilenjaku.Size = new System.Drawing.Size(129, 51);
            this.btnDodajPesmuVilenjaku.TabIndex = 4;
            this.btnDodajPesmuVilenjaku.Text = "Dodaj pesmu vilenjaku";
            this.btnDodajPesmuVilenjaku.UseVisualStyleBackColor = true;
            this.btnDodajPesmuVilenjaku.Click += new System.EventHandler(this.btnDodajPesmuVilenjaku_Click);
            // 
            // btnPromeniIrvasa
            // 
            this.btnPromeniIrvasa.Location = new System.Drawing.Point(370, 266);
            this.btnPromeniIrvasa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPromeniIrvasa.Name = "btnPromeniIrvasa";
            this.btnPromeniIrvasa.Size = new System.Drawing.Size(99, 66);
            this.btnPromeniIrvasa.TabIndex = 10;
            this.btnPromeniIrvasa.Text = "Promeni irvasa";
            this.btnPromeniIrvasa.UseVisualStyleBackColor = true;
            this.btnPromeniIrvasa.Click += new System.EventHandler(this.btnPromeniIrvasa_Click);
            // 
            // txtImePesme
            // 
            this.txtImePesme.Location = new System.Drawing.Point(63, 491);
            this.txtImePesme.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtImePesme.Name = "txtImePesme";
            this.txtImePesme.Size = new System.Drawing.Size(121, 26);
            this.txtImePesme.TabIndex = 3;
            this.txtImePesme.TextChanged += new System.EventHandler(this.txtImePesme_TextChanged);
            // 
            // labelPesma
            // 
            this.labelPesma.AutoSize = true;
            this.labelPesma.Location = new System.Drawing.Point(40, 59);
            this.labelPesma.Name = "labelPesma";
            this.labelPesma.Size = new System.Drawing.Size(58, 20);
            this.labelPesma.TabIndex = 0;
            this.labelPesma.Text = "Pesma";
            // 
            // txtPesme
            // 
            this.txtPesme.Location = new System.Drawing.Point(7, 185);
            this.txtPesme.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPesme.Name = "txtPesme";
            this.txtPesme.Size = new System.Drawing.Size(299, 286);
            this.txtPesme.TabIndex = 2;
            this.txtPesme.Text = "";
            // 
            // txtNoviIrvas
            // 
            this.txtNoviIrvas.Location = new System.Drawing.Point(358, 214);
            this.txtNoviIrvas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNoviIrvas.Name = "txtNoviIrvas";
            this.txtNoviIrvas.Size = new System.Drawing.Size(111, 26);
            this.txtNoviIrvas.TabIndex = 9;
            // 
            // cmbPesme
            // 
            this.cmbPesme.FormattingEnabled = true;
            this.cmbPesme.Location = new System.Drawing.Point(19, 101);
            this.cmbPesme.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbPesme.Name = "cmbPesme";
            this.cmbPesme.Size = new System.Drawing.Size(122, 28);
            this.cmbPesme.TabIndex = 1;
            this.cmbPesme.SelectedIndexChanged += new System.EventHandler(this.cmbPesme_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(378, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Novi irvas";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // btnUkloniPesmuVilenjaku
            // 
            this.btnUkloniPesmuVilenjaku.Location = new System.Drawing.Point(161, 88);
            this.btnUkloniPesmuVilenjaku.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUkloniPesmuVilenjaku.Name = "btnUkloniPesmuVilenjaku";
            this.btnUkloniPesmuVilenjaku.Size = new System.Drawing.Size(128, 64);
            this.btnUkloniPesmuVilenjaku.TabIndex = 5;
            this.btnUkloniPesmuVilenjaku.Text = "Ukloni pesmu vilenjaku";
            this.btnUkloniPesmuVilenjaku.UseVisualStyleBackColor = true;
            this.btnUkloniPesmuVilenjaku.Click += new System.EventHandler(this.btnUkloniPesmuVilenjaku_Click);
            // 
            // txtTrenutniIrvas
            // 
            this.txtTrenutniIrvas.Enabled = false;
            this.txtTrenutniIrvas.Location = new System.Drawing.Point(358, 104);
            this.txtTrenutniIrvas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTrenutniIrvas.Name = "txtTrenutniIrvas";
            this.txtTrenutniIrvas.Size = new System.Drawing.Size(111, 26);
            this.txtTrenutniIrvas.TabIndex = 7;
            // 
            // labelIrvas
            // 
            this.labelIrvas.AutoSize = true;
            this.labelIrvas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelIrvas.Location = new System.Drawing.Point(393, 48);
            this.labelIrvas.Name = "labelIrvas";
            this.labelIrvas.Size = new System.Drawing.Size(63, 29);
            this.labelIrvas.TabIndex = 6;
            this.labelIrvas.Text = "Irvas";
            // 
            // btnNadjiVilenjaka
            // 
            this.btnNadjiVilenjaka.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnNadjiVilenjaka.Font = new System.Drawing.Font("Segoe Script", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNadjiVilenjaka.Location = new System.Drawing.Point(274, 96);
            this.btnNadjiVilenjaka.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNadjiVilenjaka.Name = "btnNadjiVilenjaka";
            this.btnNadjiVilenjaka.Size = new System.Drawing.Size(148, 38);
            this.btnNadjiVilenjaka.TabIndex = 12;
            this.btnNadjiVilenjaka.Text = "Nadji";
            this.btnNadjiVilenjaka.UseVisualStyleBackColor = false;
            this.btnNadjiVilenjaka.Click += new System.EventHandler(this.btnNadji_Click);
            // 
            // listVestine
            // 
            this.listVestine.FormattingEnabled = true;
            this.listVestine.ItemHeight = 20;
            this.listVestine.Location = new System.Drawing.Point(11, 102);
            this.listVestine.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listVestine.Name = "listVestine";
            this.listVestine.Size = new System.Drawing.Size(354, 164);
            this.listVestine.TabIndex = 13;
            // 
            // labelVestine
            // 
            this.labelVestine.AutoSize = true;
            this.labelVestine.Font = new System.Drawing.Font("Segoe Script", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVestine.Location = new System.Drawing.Point(8, 68);
            this.labelVestine.Name = "labelVestine";
            this.labelVestine.Size = new System.Drawing.Size(149, 27);
            this.labelVestine.TabIndex = 14;
            this.labelVestine.Text = "Magicne vestine";
            // 
            // panelBasic
            // 
            this.panelBasic.Controls.Add(this.btnPromeniIme);
            this.panelBasic.Controls.Add(this.buttonUkloniVestinu);
            this.panelBasic.Controls.Add(this.btnDodajVestinu);
            this.panelBasic.Controls.Add(this.txtNovaVestina);
            this.panelBasic.Controls.Add(this.labelVestine);
            this.panelBasic.Controls.Add(this.listVestine);
            this.panelBasic.Controls.Add(this.txtNovoIme);
            this.panelBasic.Controls.Add(this.label2);
            this.panelBasic.Location = new System.Drawing.Point(27, 210);
            this.panelBasic.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelBasic.Name = "panelBasic";
            this.panelBasic.Size = new System.Drawing.Size(398, 401);
            this.panelBasic.TabIndex = 15;
            // 
            // btnPromeniIme
            // 
            this.btnPromeniIme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnPromeniIme.Font = new System.Drawing.Font("Segoe Script", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPromeniIme.Location = new System.Drawing.Point(312, 12);
            this.btnPromeniIme.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPromeniIme.Name = "btnPromeniIme";
            this.btnPromeniIme.Size = new System.Drawing.Size(54, 44);
            this.btnPromeniIme.TabIndex = 18;
            this.btnPromeniIme.Text = "OK";
            this.btnPromeniIme.UseVisualStyleBackColor = false;
            this.btnPromeniIme.Click += new System.EventHandler(this.btnPromeniIme_Click);
            // 
            // buttonUkloniVestinu
            // 
            this.buttonUkloniVestinu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonUkloniVestinu.Font = new System.Drawing.Font("Segoe Script", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUkloniVestinu.Location = new System.Drawing.Point(202, 343);
            this.buttonUkloniVestinu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonUkloniVestinu.Name = "buttonUkloniVestinu";
            this.buttonUkloniVestinu.Size = new System.Drawing.Size(163, 34);
            this.buttonUkloniVestinu.TabIndex = 17;
            this.buttonUkloniVestinu.Text = "Ukloni vestinu";
            this.buttonUkloniVestinu.UseVisualStyleBackColor = false;
            this.buttonUkloniVestinu.Click += new System.EventHandler(this.buttonUkloniVestinu_Click);
            // 
            // btnDodajVestinu
            // 
            this.btnDodajVestinu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnDodajVestinu.Font = new System.Drawing.Font("Segoe Script", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajVestinu.Location = new System.Drawing.Point(202, 291);
            this.btnDodajVestinu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDodajVestinu.Name = "btnDodajVestinu";
            this.btnDodajVestinu.Size = new System.Drawing.Size(164, 34);
            this.btnDodajVestinu.TabIndex = 16;
            this.btnDodajVestinu.Text = "Dodaj vestinu";
            this.btnDodajVestinu.UseVisualStyleBackColor = false;
            this.btnDodajVestinu.Click += new System.EventHandler(this.btnDodajVestinu_Click);
            // 
            // txtNovaVestina
            // 
            this.txtNovaVestina.Location = new System.Drawing.Point(11, 292);
            this.txtNovaVestina.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNovaVestina.Name = "txtNovaVestina";
            this.txtNovaVestina.Size = new System.Drawing.Size(173, 26);
            this.txtNovaVestina.TabIndex = 15;
            // 
            // labelPogresnoIme
            // 
            this.labelPogresnoIme.AutoSize = true;
            this.labelPogresnoIme.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPogresnoIme.ForeColor = System.Drawing.Color.Red;
            this.labelPogresnoIme.Location = new System.Drawing.Point(70, 126);
            this.labelPogresnoIme.Name = "labelPogresnoIme";
            this.labelPogresnoIme.Size = new System.Drawing.Size(141, 30);
            this.labelPogresnoIme.TabIndex = 16;
            this.labelPogresnoIme.Text = "Pogresno ime!";
            // 
            // grupaPokloni
            // 
            this.grupaPokloni.Location = new System.Drawing.Point(444, 30);
            this.grupaPokloni.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grupaPokloni.Name = "grupaPokloni";
            this.grupaPokloni.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grupaPokloni.Size = new System.Drawing.Size(788, 574);
            this.grupaPokloni.TabIndex = 17;
            this.grupaPokloni.TabStop = false;
            // 
            // tabelaPoklona
            // 
            this.tabelaPoklona.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelaPoklona.Location = new System.Drawing.Point(-14, 32);
            this.tabelaPoklona.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabelaPoklona.Name = "tabelaPoklona";
            this.tabelaPoklona.RowHeadersWidth = 51;
            this.tabelaPoklona.RowTemplate.Height = 24;
            this.tabelaPoklona.Size = new System.Drawing.Size(765, 512);
            this.tabelaPoklona.TabIndex = 0;
            // 
            // grupaTovari
            // 
            this.grupaTovari.Controls.Add(this.tabelaTovari);
            this.grupaTovari.Controls.Add(this.tabelaPoklona);
            this.grupaTovari.Location = new System.Drawing.Point(475, 5);
            this.grupaTovari.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grupaTovari.Name = "grupaTovari";
            this.grupaTovari.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grupaTovari.Size = new System.Drawing.Size(720, 564);
            this.grupaTovari.TabIndex = 18;
            this.grupaTovari.TabStop = false;
            // 
            // tabelaTovari
            // 
            this.tabelaTovari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelaTovari.Location = new System.Drawing.Point(63, 58);
            this.tabelaTovari.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabelaTovari.Name = "tabelaTovari";
            this.tabelaTovari.RowHeadersWidth = 51;
            this.tabelaTovari.RowTemplate.Height = 24;
            this.tabelaTovari.Size = new System.Drawing.Size(528, 494);
            this.tabelaTovari.TabIndex = 11;
            // 
            // AzuriranjeVilenjakaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 638);
            this.Controls.Add(this.grupaTovari);
            this.Controls.Add(this.grupaIgracke);
            this.Controls.Add(this.grupaPokloni);
            this.Controls.Add(this.labelPogresnoIme);
            this.Controls.Add(this.panelBasic);
            this.Controls.Add(this.btnNadjiVilenjaka);
            this.Controls.Add(this.grupaIrvas);
            this.Controls.Add(this.labelIme);
            this.Controls.Add(this.txtIme);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AzuriranjeVilenjakaForma";
            this.Text = "AzuriranjeVilenjakaForma";
            this.Load += new System.EventHandler(this.AzuriranjeVilenjakaForma_Load);
            this.grupaIgracke.ResumeLayout(false);
            this.grupaIgracke.PerformLayout();
            this.grupaIrvas.ResumeLayout(false);
            this.grupaIrvas.PerformLayout();
            this.panelBasic.ResumeLayout(false);
            this.panelBasic.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaPoklona)).EndInit();
            this.grupaTovari.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabelaTovari)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label labelIme;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNovoIme;
        private System.Windows.Forms.Label labelTim;
        private System.Windows.Forms.Button btnKoordinator;
        private System.Windows.Forms.Label labelRadionica;
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
        private System.Windows.Forms.ComboBox cmbPesme;
        private System.Windows.Forms.Label labelPesma;
        private System.Windows.Forms.Label labelPogresnoIme;
        private System.Windows.Forms.Button buttonUkloniVestinu;
        private System.Windows.Forms.Button btnUkloniPesmuVilenjaku;
        private System.Windows.Forms.Button btnPromeniIme;
        private System.Windows.Forms.Label labelIrvas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTrenutniIrvas;
        private System.Windows.Forms.Button btnPromeniIrvasa;
        private System.Windows.Forms.TextBox txtNoviIrvas;
        private System.Windows.Forms.ComboBox cmbRadionice;
        private System.Windows.Forms.ComboBox cmbTimovi;
        private System.Windows.Forms.Button btnIzmenaTima;
        private System.Windows.Forms.GroupBox grupaPokloni;
        private System.Windows.Forms.DataGridView tabelaPoklona;
        private System.Windows.Forms.GroupBox grupaTovari;
        private System.Windows.Forms.DataGridView tabelaTovari;
    }
}