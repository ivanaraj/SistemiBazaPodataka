namespace MMORPG.Forme
{
    partial class DodajIgraca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DodajIgraca));
            this.igraci = new System.Windows.Forms.ListView();
            this.columnHeaderID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderNadimak = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderIme = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPrezime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderUzrast = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBoxDodajIgraca = new System.Windows.Forms.GroupBox();
            this.comboBoxTim = new System.Windows.Forms.ComboBox();
            this.numUzrast = new System.Windows.Forms.NumericUpDown();
            this.radioButtonM = new System.Windows.Forms.RadioButton();
            this.radioButtonZ = new System.Windows.Forms.RadioButton();
            this.btnDodajIgraca = new System.Windows.Forms.Button();
            this.textBoxPrezime = new System.Windows.Forms.TextBox();
            this.textBoxIme = new System.Windows.Forms.TextBox();
            this.textBoxLozinka = new System.Windows.Forms.TextBox();
            this.textBoxNadimak = new System.Windows.Forms.TextBox();
            this.labTim = new System.Windows.Forms.Label();
            this.labUzrast = new System.Windows.Forms.Label();
            this.labPol = new System.Windows.Forms.Label();
            this.labPrezime = new System.Windows.Forms.Label();
            this.labIme = new System.Windows.Forms.Label();
            this.labNadimak = new System.Windows.Forms.Label();
            this.labLozinka = new System.Windows.Forms.Label();
            this.btnIzmeniIgraca = new System.Windows.Forms.Button();
            this.btnDodajLika = new System.Windows.Forms.Button();
            this.btnDodajTim = new System.Windows.Forms.Button();
            this.btnDodajPomocnika = new System.Windows.Forms.Button();
            this.brnDodajSesiju = new System.Windows.Forms.Button();
            this.btnObrisiIgraca = new System.Windows.Forms.Button();
            this.groupBoxDodajIgraca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUzrast)).BeginInit();
            this.SuspendLayout();
            // 
            // igraci
            // 
            this.igraci.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderID,
            this.columnHeaderNadimak,
            this.columnHeaderIme,
            this.columnHeaderPrezime,
            this.columnHeaderUzrast});
            this.igraci.FullRowSelect = true;
            this.igraci.GridLines = true;
            this.igraci.HideSelection = false;
            this.igraci.Location = new System.Drawing.Point(276, 12);
            this.igraci.Name = "igraci";
            this.igraci.Size = new System.Drawing.Size(360, 325);
            this.igraci.TabIndex = 0;
            this.igraci.UseCompatibleStateImageBehavior = false;
            this.igraci.View = System.Windows.Forms.View.Details;
            this.igraci.SelectedIndexChanged += new System.EventHandler(this.igraci_SelectedIndexChanged);
            // 
            // columnHeaderID
            // 
            this.columnHeaderID.Text = "ID";
            this.columnHeaderID.Width = 67;
            // 
            // columnHeaderNadimak
            // 
            this.columnHeaderNadimak.Text = "Nadimak";
            this.columnHeaderNadimak.Width = 73;
            // 
            // columnHeaderIme
            // 
            this.columnHeaderIme.Text = "Ime";
            this.columnHeaderIme.Width = 77;
            // 
            // columnHeaderPrezime
            // 
            this.columnHeaderPrezime.Text = "Prezime";
            this.columnHeaderPrezime.Width = 90;
            // 
            // columnHeaderUzrast
            // 
            this.columnHeaderUzrast.Text = "Uzrast";
            // 
            // groupBoxDodajIgraca
            // 
            this.groupBoxDodajIgraca.Controls.Add(this.comboBoxTim);
            this.groupBoxDodajIgraca.Controls.Add(this.numUzrast);
            this.groupBoxDodajIgraca.Controls.Add(this.radioButtonM);
            this.groupBoxDodajIgraca.Controls.Add(this.radioButtonZ);
            this.groupBoxDodajIgraca.Controls.Add(this.btnDodajIgraca);
            this.groupBoxDodajIgraca.Controls.Add(this.textBoxPrezime);
            this.groupBoxDodajIgraca.Controls.Add(this.textBoxIme);
            this.groupBoxDodajIgraca.Controls.Add(this.textBoxLozinka);
            this.groupBoxDodajIgraca.Controls.Add(this.textBoxNadimak);
            this.groupBoxDodajIgraca.Controls.Add(this.labTim);
            this.groupBoxDodajIgraca.Controls.Add(this.labUzrast);
            this.groupBoxDodajIgraca.Controls.Add(this.labPol);
            this.groupBoxDodajIgraca.Controls.Add(this.labPrezime);
            this.groupBoxDodajIgraca.Controls.Add(this.labIme);
            this.groupBoxDodajIgraca.Controls.Add(this.labNadimak);
            this.groupBoxDodajIgraca.Controls.Add(this.labLozinka);
            this.groupBoxDodajIgraca.Location = new System.Drawing.Point(13, 12);
            this.groupBoxDodajIgraca.Name = "groupBoxDodajIgraca";
            this.groupBoxDodajIgraca.Size = new System.Drawing.Size(232, 325);
            this.groupBoxDodajIgraca.TabIndex = 1;
            this.groupBoxDodajIgraca.TabStop = false;
            // 
            // comboBoxTim
            // 
            this.comboBoxTim.FormattingEnabled = true;
            this.comboBoxTim.Location = new System.Drawing.Point(101, 220);
            this.comboBoxTim.Name = "comboBoxTim";
            this.comboBoxTim.Size = new System.Drawing.Size(100, 21);
            this.comboBoxTim.TabIndex = 16;
            // 
            // numUzrast
            // 
            this.numUzrast.Location = new System.Drawing.Point(101, 185);
            this.numUzrast.Name = "numUzrast";
            this.numUzrast.Size = new System.Drawing.Size(100, 20);
            this.numUzrast.TabIndex = 15;
            // 
            // radioButtonM
            // 
            this.radioButtonM.AutoSize = true;
            this.radioButtonM.Location = new System.Drawing.Point(150, 155);
            this.radioButtonM.Name = "radioButtonM";
            this.radioButtonM.Size = new System.Drawing.Size(34, 17);
            this.radioButtonM.TabIndex = 14;
            this.radioButtonM.TabStop = true;
            this.radioButtonM.Text = "M";
            this.radioButtonM.UseVisualStyleBackColor = true;
            // 
            // radioButtonZ
            // 
            this.radioButtonZ.AutoSize = true;
            this.radioButtonZ.Location = new System.Drawing.Point(101, 155);
            this.radioButtonZ.Name = "radioButtonZ";
            this.radioButtonZ.Size = new System.Drawing.Size(32, 17);
            this.radioButtonZ.TabIndex = 13;
            this.radioButtonZ.TabStop = true;
            this.radioButtonZ.Text = "Z";
            this.radioButtonZ.UseVisualStyleBackColor = true;
            // 
            // btnDodajIgraca
            // 
            this.btnDodajIgraca.Location = new System.Drawing.Point(9, 271);
            this.btnDodajIgraca.Name = "btnDodajIgraca";
            this.btnDodajIgraca.Size = new System.Drawing.Size(192, 36);
            this.btnDodajIgraca.TabIndex = 2;
            this.btnDodajIgraca.Text = "Dodaj Igraca";
            this.btnDodajIgraca.UseVisualStyleBackColor = true;
            this.btnDodajIgraca.Click += new System.EventHandler(this.btnDodajIgraca_Click);
            // 
            // textBoxPrezime
            // 
            this.textBoxPrezime.Location = new System.Drawing.Point(101, 122);
            this.textBoxPrezime.Name = "textBoxPrezime";
            this.textBoxPrezime.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrezime.TabIndex = 12;
            // 
            // textBoxIme
            // 
            this.textBoxIme.Location = new System.Drawing.Point(101, 92);
            this.textBoxIme.Name = "textBoxIme";
            this.textBoxIme.Size = new System.Drawing.Size(100, 20);
            this.textBoxIme.TabIndex = 11;
            // 
            // textBoxLozinka
            // 
            this.textBoxLozinka.Location = new System.Drawing.Point(101, 60);
            this.textBoxLozinka.Name = "textBoxLozinka";
            this.textBoxLozinka.Size = new System.Drawing.Size(100, 20);
            this.textBoxLozinka.TabIndex = 10;
            // 
            // textBoxNadimak
            // 
            this.textBoxNadimak.Location = new System.Drawing.Point(101, 21);
            this.textBoxNadimak.Name = "textBoxNadimak";
            this.textBoxNadimak.Size = new System.Drawing.Size(100, 20);
            this.textBoxNadimak.TabIndex = 9;
            // 
            // labTim
            // 
            this.labTim.AutoSize = true;
            this.labTim.Location = new System.Drawing.Point(6, 228);
            this.labTim.Name = "labTim";
            this.labTim.Size = new System.Drawing.Size(27, 13);
            this.labTim.TabIndex = 7;
            this.labTim.Text = "Tim:";
            // 
            // labUzrast
            // 
            this.labUzrast.AutoSize = true;
            this.labUzrast.Location = new System.Drawing.Point(6, 192);
            this.labUzrast.Name = "labUzrast";
            this.labUzrast.Size = new System.Drawing.Size(40, 13);
            this.labUzrast.TabIndex = 6;
            this.labUzrast.Text = "Uzrast:";
            // 
            // labPol
            // 
            this.labPol.AutoSize = true;
            this.labPol.Location = new System.Drawing.Point(6, 159);
            this.labPol.Name = "labPol";
            this.labPol.Size = new System.Drawing.Size(25, 13);
            this.labPol.TabIndex = 5;
            this.labPol.Text = "Pol:";
            // 
            // labPrezime
            // 
            this.labPrezime.AutoSize = true;
            this.labPrezime.Location = new System.Drawing.Point(6, 125);
            this.labPrezime.Name = "labPrezime";
            this.labPrezime.Size = new System.Drawing.Size(47, 13);
            this.labPrezime.TabIndex = 4;
            this.labPrezime.Text = "Prezime:";
            // 
            // labIme
            // 
            this.labIme.AutoSize = true;
            this.labIme.Location = new System.Drawing.Point(6, 95);
            this.labIme.Name = "labIme";
            this.labIme.Size = new System.Drawing.Size(27, 13);
            this.labIme.TabIndex = 3;
            this.labIme.Text = "Ime:";
            // 
            // labNadimak
            // 
            this.labNadimak.AutoSize = true;
            this.labNadimak.Location = new System.Drawing.Point(6, 29);
            this.labNadimak.Name = "labNadimak";
            this.labNadimak.Size = new System.Drawing.Size(52, 13);
            this.labNadimak.TabIndex = 2;
            this.labNadimak.Text = "Nadimak:";
            // 
            // labLozinka
            // 
            this.labLozinka.AutoSize = true;
            this.labLozinka.Location = new System.Drawing.Point(6, 63);
            this.labLozinka.Name = "labLozinka";
            this.labLozinka.Size = new System.Drawing.Size(47, 13);
            this.labLozinka.TabIndex = 0;
            this.labLozinka.Text = "Lozinka:";
            // 
            // btnIzmeniIgraca
            // 
            this.btnIzmeniIgraca.Location = new System.Drawing.Point(523, 361);
            this.btnIzmeniIgraca.Name = "btnIzmeniIgraca";
            this.btnIzmeniIgraca.Size = new System.Drawing.Size(113, 45);
            this.btnIzmeniIgraca.TabIndex = 3;
            this.btnIzmeniIgraca.Text = "Izmeni Igraca";
            this.btnIzmeniIgraca.UseVisualStyleBackColor = true;
            this.btnIzmeniIgraca.Click += new System.EventHandler(this.btnIzmeniIgraca_Click);
            // 
            // btnDodajLika
            // 
            this.btnDodajLika.Location = new System.Drawing.Point(12, 361);
            this.btnDodajLika.Name = "btnDodajLika";
            this.btnDodajLika.Size = new System.Drawing.Size(107, 34);
            this.btnDodajLika.TabIndex = 4;
            this.btnDodajLika.Text = "Dodaj Lika";
            this.btnDodajLika.UseVisualStyleBackColor = true;
            this.btnDodajLika.Click += new System.EventHandler(this.btnDodajLika_Click);
            // 
            // btnDodajTim
            // 
            this.btnDodajTim.Location = new System.Drawing.Point(140, 361);
            this.btnDodajTim.Name = "btnDodajTim";
            this.btnDodajTim.Size = new System.Drawing.Size(105, 34);
            this.btnDodajTim.TabIndex = 5;
            this.btnDodajTim.Text = "Dodaj Tim";
            this.btnDodajTim.UseVisualStyleBackColor = true;
            this.btnDodajTim.Click += new System.EventHandler(this.btnDodajTim_Click);
            // 
            // btnDodajPomocnika
            // 
            this.btnDodajPomocnika.Location = new System.Drawing.Point(12, 401);
            this.btnDodajPomocnika.Name = "btnDodajPomocnika";
            this.btnDodajPomocnika.Size = new System.Drawing.Size(233, 34);
            this.btnDodajPomocnika.TabIndex = 6;
            this.btnDodajPomocnika.Text = "Dodaj Pomocnika";
            this.btnDodajPomocnika.UseVisualStyleBackColor = true;
            this.btnDodajPomocnika.Click += new System.EventHandler(this.btnDodajPomocnika_Click);
            // 
            // brnDodajSesiju
            // 
            this.brnDodajSesiju.Location = new System.Drawing.Point(12, 441);
            this.brnDodajSesiju.Name = "brnDodajSesiju";
            this.brnDodajSesiju.Size = new System.Drawing.Size(233, 34);
            this.brnDodajSesiju.TabIndex = 7;
            this.brnDodajSesiju.Text = "Dodaj Sesiju";
            this.brnDodajSesiju.UseVisualStyleBackColor = true;
            this.brnDodajSesiju.Click += new System.EventHandler(this.brnDodajSesiju_Click);
            // 
            // btnObrisiIgraca
            // 
            this.btnObrisiIgraca.Location = new System.Drawing.Point(400, 361);
            this.btnObrisiIgraca.Name = "btnObrisiIgraca";
            this.btnObrisiIgraca.Size = new System.Drawing.Size(104, 45);
            this.btnObrisiIgraca.TabIndex = 8;
            this.btnObrisiIgraca.Text = "Obrisi Igraca";
            this.btnObrisiIgraca.UseVisualStyleBackColor = true;
            this.btnObrisiIgraca.Click += new System.EventHandler(this.btnObrisiIgraca_Click);
            // 
            // DodajIgraca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 503);
            this.Controls.Add(this.btnObrisiIgraca);
            this.Controls.Add(this.brnDodajSesiju);
            this.Controls.Add(this.btnDodajPomocnika);
            this.Controls.Add(this.btnDodajTim);
            this.Controls.Add(this.btnDodajLika);
            this.Controls.Add(this.btnIzmeniIgraca);
            this.Controls.Add(this.groupBoxDodajIgraca);
            this.Controls.Add(this.igraci);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DodajIgraca";
            this.Text = "Igrac";
            this.Load += new System.EventHandler(this.DodajIgraca_Load);
            this.groupBoxDodajIgraca.ResumeLayout(false);
            this.groupBoxDodajIgraca.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUzrast)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView igraci;
        private System.Windows.Forms.ColumnHeader columnHeaderID;
        private System.Windows.Forms.ColumnHeader columnHeaderNadimak;
        private System.Windows.Forms.ColumnHeader columnHeaderIme;
        private System.Windows.Forms.ColumnHeader columnHeaderPrezime;
        private System.Windows.Forms.ColumnHeader columnHeaderUzrast;
        private System.Windows.Forms.GroupBox groupBoxDodajIgraca;
        private System.Windows.Forms.Label labTim;
        private System.Windows.Forms.Label labUzrast;
        private System.Windows.Forms.Label labPol;
        private System.Windows.Forms.Label labPrezime;
        private System.Windows.Forms.Label labIme;
        private System.Windows.Forms.Label labNadimak;
        private System.Windows.Forms.Label labLozinka;
        private System.Windows.Forms.NumericUpDown numUzrast;
        private System.Windows.Forms.RadioButton radioButtonM;
        private System.Windows.Forms.RadioButton radioButtonZ;
        private System.Windows.Forms.TextBox textBoxPrezime;
        private System.Windows.Forms.TextBox textBoxIme;
        private System.Windows.Forms.TextBox textBoxLozinka;
        private System.Windows.Forms.TextBox textBoxNadimak;
        private System.Windows.Forms.ComboBox comboBoxTim;
        private System.Windows.Forms.Button btnDodajIgraca;
        private System.Windows.Forms.Button btnIzmeniIgraca;
        private System.Windows.Forms.Button btnDodajLika;
        private System.Windows.Forms.Button btnDodajTim;
        private System.Windows.Forms.Button btnDodajPomocnika;
        private System.Windows.Forms.Button brnDodajSesiju;
        private System.Windows.Forms.Button btnObrisiIgraca;
    }
}