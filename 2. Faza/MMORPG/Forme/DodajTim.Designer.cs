namespace MMORPG.Forme
{
    partial class DodajTim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DodajTim));
            this.groupBoxDodajTim = new System.Windows.Forms.GroupBox();
            this.timovi = new System.Windows.Forms.ListView();
            this.columnHeaderNaziv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderBonusP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labNaziv = new System.Windows.Forms.Label();
            this.labMaxIgraca = new System.Windows.Forms.Label();
            this.labMinIgraca = new System.Windows.Forms.Label();
            this.labBonusP = new System.Windows.Forms.Label();
            this.textBoxNaziv = new System.Windows.Forms.TextBox();
            this.numMaxIgraca = new System.Windows.Forms.NumericUpDown();
            this.numMinIgraca = new System.Windows.Forms.NumericUpDown();
            this.numBonusP = new System.Windows.Forms.NumericUpDown();
            this.btnDodajTim = new System.Windows.Forms.Button();
            this.btnIzmeniTim = new System.Windows.Forms.Button();
            this.btnObrisiTim = new System.Windows.Forms.Button();
            this.btnDodajBorbu = new System.Windows.Forms.Button();
            this.groupBoxDodajTim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxIgraca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinIgraca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBonusP)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxDodajTim
            // 
            this.groupBoxDodajTim.Controls.Add(this.btnDodajTim);
            this.groupBoxDodajTim.Controls.Add(this.numBonusP);
            this.groupBoxDodajTim.Controls.Add(this.numMinIgraca);
            this.groupBoxDodajTim.Controls.Add(this.numMaxIgraca);
            this.groupBoxDodajTim.Controls.Add(this.textBoxNaziv);
            this.groupBoxDodajTim.Controls.Add(this.labBonusP);
            this.groupBoxDodajTim.Controls.Add(this.labMinIgraca);
            this.groupBoxDodajTim.Controls.Add(this.labMaxIgraca);
            this.groupBoxDodajTim.Controls.Add(this.labNaziv);
            this.groupBoxDodajTim.Location = new System.Drawing.Point(12, 12);
            this.groupBoxDodajTim.Name = "groupBoxDodajTim";
            this.groupBoxDodajTim.Size = new System.Drawing.Size(228, 239);
            this.groupBoxDodajTim.TabIndex = 0;
            this.groupBoxDodajTim.TabStop = false;
            // 
            // timovi
            // 
            this.timovi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderNaziv,
            this.columnHeaderBonusP});
            this.timovi.FullRowSelect = true;
            this.timovi.GridLines = true;
            this.timovi.HideSelection = false;
            this.timovi.Location = new System.Drawing.Point(259, 12);
            this.timovi.Name = "timovi";
            this.timovi.Size = new System.Drawing.Size(160, 239);
            this.timovi.TabIndex = 1;
            this.timovi.UseCompatibleStateImageBehavior = false;
            this.timovi.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderNaziv
            // 
            this.columnHeaderNaziv.Text = "Naziv";
            // 
            // columnHeaderBonusP
            // 
            this.columnHeaderBonusP.Text = "Bonus poeni";
            this.columnHeaderBonusP.Width = 83;
            // 
            // labNaziv
            // 
            this.labNaziv.AutoSize = true;
            this.labNaziv.Location = new System.Drawing.Point(7, 27);
            this.labNaziv.Name = "labNaziv";
            this.labNaziv.Size = new System.Drawing.Size(37, 13);
            this.labNaziv.TabIndex = 0;
            this.labNaziv.Text = "Naziv:";
            // 
            // labMaxIgraca
            // 
            this.labMaxIgraca.AutoSize = true;
            this.labMaxIgraca.Location = new System.Drawing.Point(7, 69);
            this.labMaxIgraca.Name = "labMaxIgraca";
            this.labMaxIgraca.Size = new System.Drawing.Size(98, 13);
            this.labMaxIgraca.TabIndex = 1;
            this.labMaxIgraca.Text = "Maksimalno igraca:";
            // 
            // labMinIgraca
            // 
            this.labMinIgraca.AutoSize = true;
            this.labMinIgraca.Location = new System.Drawing.Point(7, 113);
            this.labMinIgraca.Name = "labMinIgraca";
            this.labMinIgraca.Size = new System.Drawing.Size(89, 13);
            this.labMinIgraca.TabIndex = 2;
            this.labMinIgraca.Text = "Minimalno igraca:";
            // 
            // labBonusP
            // 
            this.labBonusP.AutoSize = true;
            this.labBonusP.Location = new System.Drawing.Point(7, 158);
            this.labBonusP.Name = "labBonusP";
            this.labBonusP.Size = new System.Drawing.Size(69, 13);
            this.labBonusP.TabIndex = 3;
            this.labBonusP.Text = "Bonus poeni:";
            // 
            // textBoxNaziv
            // 
            this.textBoxNaziv.Location = new System.Drawing.Point(122, 20);
            this.textBoxNaziv.Name = "textBoxNaziv";
            this.textBoxNaziv.Size = new System.Drawing.Size(87, 20);
            this.textBoxNaziv.TabIndex = 4;
            // 
            // numMaxIgraca
            // 
            this.numMaxIgraca.Location = new System.Drawing.Point(122, 67);
            this.numMaxIgraca.Name = "numMaxIgraca";
            this.numMaxIgraca.Size = new System.Drawing.Size(87, 20);
            this.numMaxIgraca.TabIndex = 5;
            // 
            // numMinIgraca
            // 
            this.numMinIgraca.Location = new System.Drawing.Point(122, 111);
            this.numMinIgraca.Name = "numMinIgraca";
            this.numMinIgraca.Size = new System.Drawing.Size(87, 20);
            this.numMinIgraca.TabIndex = 6;
            // 
            // numBonusP
            // 
            this.numBonusP.Location = new System.Drawing.Point(122, 156);
            this.numBonusP.Name = "numBonusP";
            this.numBonusP.Size = new System.Drawing.Size(87, 20);
            this.numBonusP.TabIndex = 7;
            // 
            // btnDodajTim
            // 
            this.btnDodajTim.Location = new System.Drawing.Point(10, 195);
            this.btnDodajTim.Name = "btnDodajTim";
            this.btnDodajTim.Size = new System.Drawing.Size(199, 32);
            this.btnDodajTim.TabIndex = 8;
            this.btnDodajTim.Text = "Dodaj Tim";
            this.btnDodajTim.UseVisualStyleBackColor = true;
            this.btnDodajTim.Click += new System.EventHandler(this.btnDodajTim_Click);
            // 
            // btnIzmeniTim
            // 
            this.btnIzmeniTim.Location = new System.Drawing.Point(259, 261);
            this.btnIzmeniTim.Name = "btnIzmeniTim";
            this.btnIzmeniTim.Size = new System.Drawing.Size(160, 32);
            this.btnIzmeniTim.TabIndex = 9;
            this.btnIzmeniTim.Text = "Izmeni Tim";
            this.btnIzmeniTim.UseVisualStyleBackColor = true;
            this.btnIzmeniTim.Click += new System.EventHandler(this.btnIzmeniTim_Click);
            // 
            // btnObrisiTim
            // 
            this.btnObrisiTim.Location = new System.Drawing.Point(259, 299);
            this.btnObrisiTim.Name = "btnObrisiTim";
            this.btnObrisiTim.Size = new System.Drawing.Size(160, 32);
            this.btnObrisiTim.TabIndex = 10;
            this.btnObrisiTim.Text = "Obrisi Tim";
            this.btnObrisiTim.UseVisualStyleBackColor = true;
            this.btnObrisiTim.Click += new System.EventHandler(this.btnObrisiTim_Click);
            // 
            // btnDodajBorbu
            // 
            this.btnDodajBorbu.Location = new System.Drawing.Point(39, 284);
            this.btnDodajBorbu.Name = "btnDodajBorbu";
            this.btnDodajBorbu.Size = new System.Drawing.Size(160, 32);
            this.btnDodajBorbu.TabIndex = 11;
            this.btnDodajBorbu.Text = "Dodaj Borbu";
            this.btnDodajBorbu.UseVisualStyleBackColor = true;
            this.btnDodajBorbu.Click += new System.EventHandler(this.btnDodajBorbu_Click);
            // 
            // DodajTim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 343);
            this.Controls.Add(this.btnDodajBorbu);
            this.Controls.Add(this.btnIzmeniTim);
            this.Controls.Add(this.btnObrisiTim);
            this.Controls.Add(this.timovi);
            this.Controls.Add(this.groupBoxDodajTim);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DodajTim";
            this.Text = "Dodaj Tim";
            this.Load += new System.EventHandler(this.DodajTim_Load);
            this.groupBoxDodajTim.ResumeLayout(false);
            this.groupBoxDodajTim.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxIgraca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinIgraca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBonusP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDodajTim;
        private System.Windows.Forms.ListView timovi;
        private System.Windows.Forms.ColumnHeader columnHeaderNaziv;
        private System.Windows.Forms.Label labBonusP;
        private System.Windows.Forms.Label labMinIgraca;
        private System.Windows.Forms.Label labMaxIgraca;
        private System.Windows.Forms.Label labNaziv;
        private System.Windows.Forms.ColumnHeader columnHeaderBonusP;
        private System.Windows.Forms.NumericUpDown numBonusP;
        private System.Windows.Forms.NumericUpDown numMinIgraca;
        private System.Windows.Forms.NumericUpDown numMaxIgraca;
        private System.Windows.Forms.TextBox textBoxNaziv;
        private System.Windows.Forms.Button btnDodajTim;
        private System.Windows.Forms.Button btnIzmeniTim;
        private System.Windows.Forms.Button btnObrisiTim;
        private System.Windows.Forms.Button btnDodajBorbu;
    }
}