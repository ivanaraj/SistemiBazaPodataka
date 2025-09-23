namespace MMORPG.Forme
{
    partial class DodajPomocnika
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DodajPomocnika));
            this.groupBoxDodajPomocnika = new System.Windows.Forms.GroupBox();
            this.pomocnici = new System.Windows.Forms.ListView();
            this.labIme = new System.Windows.Forms.Label();
            this.labBonusZastite = new System.Windows.Forms.Label();
            this.labIgrac = new System.Windows.Forms.Label();
            this.labRasa = new System.Windows.Forms.Label();
            this.labKlasa = new System.Windows.Forms.Label();
            this.textBoxIme = new System.Windows.Forms.TextBox();
            this.numBonusZastite = new System.Windows.Forms.NumericUpDown();
            this.comboBoxIgrac = new System.Windows.Forms.ComboBox();
            this.comboBoxRasa = new System.Windows.Forms.ComboBox();
            this.comboBoxKlasa = new System.Windows.Forms.ComboBox();
            this.columnHeaderID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderIgrac = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderIme = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderBonusZ = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDodajPomocnika = new System.Windows.Forms.Button();
            this.btnObrisiPomocnika = new System.Windows.Forms.Button();
            this.groupBoxDodajPomocnika.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBonusZastite)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxDodajPomocnika
            // 
            this.groupBoxDodajPomocnika.Controls.Add(this.btnDodajPomocnika);
            this.groupBoxDodajPomocnika.Controls.Add(this.comboBoxKlasa);
            this.groupBoxDodajPomocnika.Controls.Add(this.comboBoxRasa);
            this.groupBoxDodajPomocnika.Controls.Add(this.comboBoxIgrac);
            this.groupBoxDodajPomocnika.Controls.Add(this.numBonusZastite);
            this.groupBoxDodajPomocnika.Controls.Add(this.textBoxIme);
            this.groupBoxDodajPomocnika.Controls.Add(this.labKlasa);
            this.groupBoxDodajPomocnika.Controls.Add(this.labRasa);
            this.groupBoxDodajPomocnika.Controls.Add(this.labIgrac);
            this.groupBoxDodajPomocnika.Controls.Add(this.labBonusZastite);
            this.groupBoxDodajPomocnika.Controls.Add(this.labIme);
            this.groupBoxDodajPomocnika.Location = new System.Drawing.Point(22, 23);
            this.groupBoxDodajPomocnika.Name = "groupBoxDodajPomocnika";
            this.groupBoxDodajPomocnika.Size = new System.Drawing.Size(221, 291);
            this.groupBoxDodajPomocnika.TabIndex = 0;
            this.groupBoxDodajPomocnika.TabStop = false;
            // 
            // pomocnici
            // 
            this.pomocnici.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderID,
            this.columnHeaderIgrac,
            this.columnHeaderIme,
            this.columnHeaderBonusZ});
            this.pomocnici.FullRowSelect = true;
            this.pomocnici.GridLines = true;
            this.pomocnici.HideSelection = false;
            this.pomocnici.Location = new System.Drawing.Point(269, 23);
            this.pomocnici.Name = "pomocnici";
            this.pomocnici.Size = new System.Drawing.Size(349, 291);
            this.pomocnici.TabIndex = 1;
            this.pomocnici.UseCompatibleStateImageBehavior = false;
            this.pomocnici.View = System.Windows.Forms.View.Details;
            // 
            // labIme
            // 
            this.labIme.AutoSize = true;
            this.labIme.Location = new System.Drawing.Point(7, 20);
            this.labIme.Name = "labIme";
            this.labIme.Size = new System.Drawing.Size(27, 13);
            this.labIme.TabIndex = 0;
            this.labIme.Text = "Ime:";
            // 
            // labBonusZastite
            // 
            this.labBonusZastite.AutoSize = true;
            this.labBonusZastite.Location = new System.Drawing.Point(6, 63);
            this.labBonusZastite.Name = "labBonusZastite";
            this.labBonusZastite.Size = new System.Drawing.Size(73, 13);
            this.labBonusZastite.TabIndex = 1;
            this.labBonusZastite.Text = "Bonus zastite:";
            // 
            // labIgrac
            // 
            this.labIgrac.AutoSize = true;
            this.labIgrac.Location = new System.Drawing.Point(7, 115);
            this.labIgrac.Name = "labIgrac";
            this.labIgrac.Size = new System.Drawing.Size(34, 13);
            this.labIgrac.TabIndex = 2;
            this.labIgrac.Text = "Igrac:";
            // 
            // labRasa
            // 
            this.labRasa.AutoSize = true;
            this.labRasa.Location = new System.Drawing.Point(7, 161);
            this.labRasa.Name = "labRasa";
            this.labRasa.Size = new System.Drawing.Size(35, 13);
            this.labRasa.TabIndex = 3;
            this.labRasa.Text = "Rasa:";
            // 
            // labKlasa
            // 
            this.labKlasa.AutoSize = true;
            this.labKlasa.Location = new System.Drawing.Point(7, 205);
            this.labKlasa.Name = "labKlasa";
            this.labKlasa.Size = new System.Drawing.Size(36, 13);
            this.labKlasa.TabIndex = 4;
            this.labKlasa.Text = "Klasa:";
            // 
            // textBoxIme
            // 
            this.textBoxIme.Location = new System.Drawing.Point(97, 17);
            this.textBoxIme.Name = "textBoxIme";
            this.textBoxIme.Size = new System.Drawing.Size(97, 20);
            this.textBoxIme.TabIndex = 5;
            // 
            // numBonusZastite
            // 
            this.numBonusZastite.Location = new System.Drawing.Point(98, 61);
            this.numBonusZastite.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numBonusZastite.Name = "numBonusZastite";
            this.numBonusZastite.Size = new System.Drawing.Size(96, 20);
            this.numBonusZastite.TabIndex = 6;
            // 
            // comboBoxIgrac
            // 
            this.comboBoxIgrac.FormattingEnabled = true;
            this.comboBoxIgrac.Location = new System.Drawing.Point(97, 107);
            this.comboBoxIgrac.Name = "comboBoxIgrac";
            this.comboBoxIgrac.Size = new System.Drawing.Size(97, 21);
            this.comboBoxIgrac.TabIndex = 7;
            // 
            // comboBoxRasa
            // 
            this.comboBoxRasa.FormattingEnabled = true;
            this.comboBoxRasa.Location = new System.Drawing.Point(97, 153);
            this.comboBoxRasa.Name = "comboBoxRasa";
            this.comboBoxRasa.Size = new System.Drawing.Size(97, 21);
            this.comboBoxRasa.TabIndex = 8;
            // 
            // comboBoxKlasa
            // 
            this.comboBoxKlasa.FormattingEnabled = true;
            this.comboBoxKlasa.Location = new System.Drawing.Point(97, 197);
            this.comboBoxKlasa.Name = "comboBoxKlasa";
            this.comboBoxKlasa.Size = new System.Drawing.Size(97, 21);
            this.comboBoxKlasa.TabIndex = 9;
            // 
            // columnHeaderID
            // 
            this.columnHeaderID.Text = "ID";
            this.columnHeaderID.Width = 81;
            // 
            // columnHeaderIgrac
            // 
            this.columnHeaderIgrac.Text = "Igrac";
            this.columnHeaderIgrac.Width = 67;
            // 
            // columnHeaderIme
            // 
            this.columnHeaderIme.Text = "Ime";
            // 
            // columnHeaderBonusZ
            // 
            this.columnHeaderBonusZ.Text = "Bonus zastite";
            this.columnHeaderBonusZ.Width = 94;
            // 
            // btnDodajPomocnika
            // 
            this.btnDodajPomocnika.Location = new System.Drawing.Point(10, 247);
            this.btnDodajPomocnika.Name = "btnDodajPomocnika";
            this.btnDodajPomocnika.Size = new System.Drawing.Size(184, 29);
            this.btnDodajPomocnika.TabIndex = 10;
            this.btnDodajPomocnika.Text = "Dodaj Pomocnika";
            this.btnDodajPomocnika.UseVisualStyleBackColor = true;
            this.btnDodajPomocnika.Click += new System.EventHandler(this.btnDodajPomocnika_Click);
            // 
            // btnObrisiPomocnika
            // 
            this.btnObrisiPomocnika.Location = new System.Drawing.Point(474, 334);
            this.btnObrisiPomocnika.Name = "btnObrisiPomocnika";
            this.btnObrisiPomocnika.Size = new System.Drawing.Size(144, 43);
            this.btnObrisiPomocnika.TabIndex = 11;
            this.btnObrisiPomocnika.Text = "Obrisi Pomocnika";
            this.btnObrisiPomocnika.UseVisualStyleBackColor = true;
            this.btnObrisiPomocnika.Click += new System.EventHandler(this.btnObrisiPomocnika_Click);
            // 
            // DodajPomocnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 420);
            this.Controls.Add(this.btnObrisiPomocnika);
            this.Controls.Add(this.pomocnici);
            this.Controls.Add(this.groupBoxDodajPomocnika);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DodajPomocnika";
            this.Text = "Dodaj Pomocnika";
            this.Load += new System.EventHandler(this.DodajPomocnika_Load);
            this.groupBoxDodajPomocnika.ResumeLayout(false);
            this.groupBoxDodajPomocnika.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBonusZastite)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDodajPomocnika;
        private System.Windows.Forms.ComboBox comboBoxIgrac;
        private System.Windows.Forms.NumericUpDown numBonusZastite;
        private System.Windows.Forms.TextBox textBoxIme;
        private System.Windows.Forms.Label labKlasa;
        private System.Windows.Forms.Label labRasa;
        private System.Windows.Forms.Label labIgrac;
        private System.Windows.Forms.Label labBonusZastite;
        private System.Windows.Forms.Label labIme;
        private System.Windows.Forms.ListView pomocnici;
        private System.Windows.Forms.ComboBox comboBoxKlasa;
        private System.Windows.Forms.ComboBox comboBoxRasa;
        private System.Windows.Forms.ColumnHeader columnHeaderID;
        private System.Windows.Forms.ColumnHeader columnHeaderIgrac;
        private System.Windows.Forms.ColumnHeader columnHeaderIme;
        private System.Windows.Forms.ColumnHeader columnHeaderBonusZ;
        private System.Windows.Forms.Button btnDodajPomocnika;
        private System.Windows.Forms.Button btnObrisiPomocnika;
    }
}