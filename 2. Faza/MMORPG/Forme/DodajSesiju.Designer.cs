namespace MMORPG.Forme
{
    partial class DodajSesiju
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DodajSesiju));
            this.groupBoxDodajSesiju = new System.Windows.Forms.GroupBox();
            this.labIgrac = new System.Windows.Forms.Label();
            this.labVremeTrajanja = new System.Windows.Forms.Label();
            this.labVremePocetka = new System.Windows.Forms.Label();
            this.labKolicinaZlata = new System.Windows.Forms.Label();
            this.labXpPoeni = new System.Windows.Forms.Label();
            this.sesije = new System.Windows.Forms.ListView();
            this.columnHeaderID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderVremePocetka = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderVremeTrajanja = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderIgrac = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.numXpPoeni = new System.Windows.Forms.NumericUpDown();
            this.numKolicinaZlata = new System.Windows.Forms.NumericUpDown();
            this.numVremeTrajanja = new System.Windows.Forms.NumericUpDown();
            this.dateTimeVremePocetka = new System.Windows.Forms.DateTimePicker();
            this.comboBoxIgrac = new System.Windows.Forms.ComboBox();
            this.btnDodajSesiju = new System.Windows.Forms.Button();
            this.btnObrisiSesiju = new System.Windows.Forms.Button();
            this.groupBoxDodajSesiju.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numXpPoeni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKolicinaZlata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVremeTrajanja)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxDodajSesiju
            // 
            this.groupBoxDodajSesiju.Controls.Add(this.btnDodajSesiju);
            this.groupBoxDodajSesiju.Controls.Add(this.comboBoxIgrac);
            this.groupBoxDodajSesiju.Controls.Add(this.dateTimeVremePocetka);
            this.groupBoxDodajSesiju.Controls.Add(this.numVremeTrajanja);
            this.groupBoxDodajSesiju.Controls.Add(this.numKolicinaZlata);
            this.groupBoxDodajSesiju.Controls.Add(this.numXpPoeni);
            this.groupBoxDodajSesiju.Controls.Add(this.labIgrac);
            this.groupBoxDodajSesiju.Controls.Add(this.labVremeTrajanja);
            this.groupBoxDodajSesiju.Controls.Add(this.labVremePocetka);
            this.groupBoxDodajSesiju.Controls.Add(this.labKolicinaZlata);
            this.groupBoxDodajSesiju.Controls.Add(this.labXpPoeni);
            this.groupBoxDodajSesiju.Location = new System.Drawing.Point(12, 12);
            this.groupBoxDodajSesiju.Name = "groupBoxDodajSesiju";
            this.groupBoxDodajSesiju.Size = new System.Drawing.Size(317, 313);
            this.groupBoxDodajSesiju.TabIndex = 0;
            this.groupBoxDodajSesiju.TabStop = false;
            // 
            // labIgrac
            // 
            this.labIgrac.AutoSize = true;
            this.labIgrac.Location = new System.Drawing.Point(7, 205);
            this.labIgrac.Name = "labIgrac";
            this.labIgrac.Size = new System.Drawing.Size(34, 13);
            this.labIgrac.TabIndex = 4;
            this.labIgrac.Text = "Igrac:";
            // 
            // labVremeTrajanja
            // 
            this.labVremeTrajanja.AutoSize = true;
            this.labVremeTrajanja.Location = new System.Drawing.Point(7, 157);
            this.labVremeTrajanja.Name = "labVremeTrajanja";
            this.labVremeTrajanja.Size = new System.Drawing.Size(77, 13);
            this.labVremeTrajanja.TabIndex = 3;
            this.labVremeTrajanja.Text = "Vreme trajanja:";
            // 
            // labVremePocetka
            // 
            this.labVremePocetka.AutoSize = true;
            this.labVremePocetka.Location = new System.Drawing.Point(7, 109);
            this.labVremePocetka.Name = "labVremePocetka";
            this.labVremePocetka.Size = new System.Drawing.Size(82, 13);
            this.labVremePocetka.TabIndex = 2;
            this.labVremePocetka.Text = "Vreme pocetka:";
            // 
            // labKolicinaZlata
            // 
            this.labKolicinaZlata.AutoSize = true;
            this.labKolicinaZlata.Location = new System.Drawing.Point(7, 63);
            this.labKolicinaZlata.Name = "labKolicinaZlata";
            this.labKolicinaZlata.Size = new System.Drawing.Size(72, 13);
            this.labKolicinaZlata.TabIndex = 1;
            this.labKolicinaZlata.Text = "Kolicina zlata:";
            // 
            // labXpPoeni
            // 
            this.labXpPoeni.AutoSize = true;
            this.labXpPoeni.Location = new System.Drawing.Point(7, 20);
            this.labXpPoeni.Name = "labXpPoeni";
            this.labXpPoeni.Size = new System.Drawing.Size(54, 13);
            this.labXpPoeni.TabIndex = 0;
            this.labXpPoeni.Text = "XP Poeni:";
            // 
            // sesije
            // 
            this.sesije.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderID,
            this.columnHeaderVremePocetka,
            this.columnHeaderVremeTrajanja,
            this.columnHeaderIgrac});
            this.sesije.FullRowSelect = true;
            this.sesije.GridLines = true;
            this.sesije.HideSelection = false;
            this.sesije.Location = new System.Drawing.Point(348, 12);
            this.sesije.Name = "sesije";
            this.sesije.Size = new System.Drawing.Size(314, 224);
            this.sesije.TabIndex = 1;
            this.sesije.UseCompatibleStateImageBehavior = false;
            this.sesije.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderID
            // 
            this.columnHeaderID.Text = "ID";
            // 
            // columnHeaderVremePocetka
            // 
            this.columnHeaderVremePocetka.Text = "Vreme pocetka";
            this.columnHeaderVremePocetka.Width = 93;
            // 
            // columnHeaderVremeTrajanja
            // 
            this.columnHeaderVremeTrajanja.Text = "Vreme trajanja";
            this.columnHeaderVremeTrajanja.Width = 93;
            // 
            // columnHeaderIgrac
            // 
            this.columnHeaderIgrac.Text = "Igrac";
            // 
            // numXpPoeni
            // 
            this.numXpPoeni.Location = new System.Drawing.Point(95, 13);
            this.numXpPoeni.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numXpPoeni.Name = "numXpPoeni";
            this.numXpPoeni.Size = new System.Drawing.Size(200, 20);
            this.numXpPoeni.TabIndex = 5;
            // 
            // numKolicinaZlata
            // 
            this.numKolicinaZlata.Location = new System.Drawing.Point(95, 56);
            this.numKolicinaZlata.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numKolicinaZlata.Name = "numKolicinaZlata";
            this.numKolicinaZlata.Size = new System.Drawing.Size(200, 20);
            this.numKolicinaZlata.TabIndex = 6;
            // 
            // numVremeTrajanja
            // 
            this.numVremeTrajanja.DecimalPlaces = 3;
            this.numVremeTrajanja.Location = new System.Drawing.Point(95, 150);
            this.numVremeTrajanja.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numVremeTrajanja.Name = "numVremeTrajanja";
            this.numVremeTrajanja.Size = new System.Drawing.Size(200, 20);
            this.numVremeTrajanja.TabIndex = 7;
            // 
            // dateTimeVremePocetka
            // 
            this.dateTimeVremePocetka.Location = new System.Drawing.Point(95, 102);
            this.dateTimeVremePocetka.Name = "dateTimeVremePocetka";
            this.dateTimeVremePocetka.Size = new System.Drawing.Size(200, 20);
            this.dateTimeVremePocetka.TabIndex = 8;
            // 
            // comboBoxIgrac
            // 
            this.comboBoxIgrac.FormattingEnabled = true;
            this.comboBoxIgrac.Location = new System.Drawing.Point(95, 197);
            this.comboBoxIgrac.Name = "comboBoxIgrac";
            this.comboBoxIgrac.Size = new System.Drawing.Size(200, 21);
            this.comboBoxIgrac.TabIndex = 9;
            // 
            // btnDodajSesiju
            // 
            this.btnDodajSesiju.Location = new System.Drawing.Point(10, 259);
            this.btnDodajSesiju.Name = "btnDodajSesiju";
            this.btnDodajSesiju.Size = new System.Drawing.Size(285, 32);
            this.btnDodajSesiju.TabIndex = 10;
            this.btnDodajSesiju.Text = "Dodaj Sesiju";
            this.btnDodajSesiju.UseVisualStyleBackColor = true;
            this.btnDodajSesiju.Click += new System.EventHandler(this.btnDodajSesiju_Click);
            // 
            // btnObrisiSesiju
            // 
            this.btnObrisiSesiju.Location = new System.Drawing.Point(521, 252);
            this.btnObrisiSesiju.Name = "btnObrisiSesiju";
            this.btnObrisiSesiju.Size = new System.Drawing.Size(141, 51);
            this.btnObrisiSesiju.TabIndex = 11;
            this.btnObrisiSesiju.Text = "Obrisi Sesiju";
            this.btnObrisiSesiju.UseVisualStyleBackColor = true;
            this.btnObrisiSesiju.Click += new System.EventHandler(this.btnObrisiSesiju_Click);
            // 
            // DodajSesiju
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 394);
            this.Controls.Add(this.btnObrisiSesiju);
            this.Controls.Add(this.sesije);
            this.Controls.Add(this.groupBoxDodajSesiju);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DodajSesiju";
            this.Text = "Dodaj Sesiju";
            this.Load += new System.EventHandler(this.DodajSesiju_Load);
            this.groupBoxDodajSesiju.ResumeLayout(false);
            this.groupBoxDodajSesiju.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numXpPoeni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKolicinaZlata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVremeTrajanja)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDodajSesiju;
        private System.Windows.Forms.ListView sesije;
        private System.Windows.Forms.Label labIgrac;
        private System.Windows.Forms.Label labVremeTrajanja;
        private System.Windows.Forms.Label labVremePocetka;
        private System.Windows.Forms.Label labKolicinaZlata;
        private System.Windows.Forms.Label labXpPoeni;
        private System.Windows.Forms.ColumnHeader columnHeaderID;
        private System.Windows.Forms.ColumnHeader columnHeaderVremePocetka;
        private System.Windows.Forms.ColumnHeader columnHeaderVremeTrajanja;
        private System.Windows.Forms.ColumnHeader columnHeaderIgrac;
        private System.Windows.Forms.ComboBox comboBoxIgrac;
        private System.Windows.Forms.DateTimePicker dateTimeVremePocetka;
        private System.Windows.Forms.NumericUpDown numVremeTrajanja;
        private System.Windows.Forms.NumericUpDown numKolicinaZlata;
        private System.Windows.Forms.NumericUpDown numXpPoeni;
        private System.Windows.Forms.Button btnDodajSesiju;
        private System.Windows.Forms.Button btnObrisiSesiju;
    }
}