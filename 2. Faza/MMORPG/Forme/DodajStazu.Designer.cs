namespace MMORPG.Forme
{
    partial class DodajStazu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DodajStazu));
            this.groupBoxDodajStazu = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labTipStaze = new System.Windows.Forms.Label();
            this.labBonusPoeni = new System.Windows.Forms.Label();
            this.staze = new System.Windows.Forms.ListView();
            this.columnHeaderNaziv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTipStaze = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderBonusP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxNaziv = new System.Windows.Forms.TextBox();
            this.radioButtonSolo = new System.Windows.Forms.RadioButton();
            this.radioButtonTimska = new System.Windows.Forms.RadioButton();
            this.numBonusPoeni = new System.Windows.Forms.NumericUpDown();
            this.btnDodajStazu = new System.Windows.Forms.Button();
            this.btnObrisiStazu = new System.Windows.Forms.Button();
            this.groupBoxDodajStazu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBonusPoeni)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxDodajStazu
            // 
            this.groupBoxDodajStazu.Controls.Add(this.btnDodajStazu);
            this.groupBoxDodajStazu.Controls.Add(this.numBonusPoeni);
            this.groupBoxDodajStazu.Controls.Add(this.radioButtonTimska);
            this.groupBoxDodajStazu.Controls.Add(this.radioButtonSolo);
            this.groupBoxDodajStazu.Controls.Add(this.textBoxNaziv);
            this.groupBoxDodajStazu.Controls.Add(this.labBonusPoeni);
            this.groupBoxDodajStazu.Controls.Add(this.labTipStaze);
            this.groupBoxDodajStazu.Controls.Add(this.label1);
            this.groupBoxDodajStazu.Location = new System.Drawing.Point(13, 23);
            this.groupBoxDodajStazu.Name = "groupBoxDodajStazu";
            this.groupBoxDodajStazu.Size = new System.Drawing.Size(225, 222);
            this.groupBoxDodajStazu.TabIndex = 0;
            this.groupBoxDodajStazu.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv: ";
            // 
            // labTipStaze
            // 
            this.labTipStaze.AutoSize = true;
            this.labTipStaze.Location = new System.Drawing.Point(7, 68);
            this.labTipStaze.Name = "labTipStaze";
            this.labTipStaze.Size = new System.Drawing.Size(53, 13);
            this.labTipStaze.TabIndex = 1;
            this.labTipStaze.Text = "Tip staze:";
            // 
            // labBonusPoeni
            // 
            this.labBonusPoeni.AutoSize = true;
            this.labBonusPoeni.Location = new System.Drawing.Point(7, 117);
            this.labBonusPoeni.Name = "labBonusPoeni";
            this.labBonusPoeni.Size = new System.Drawing.Size(69, 13);
            this.labBonusPoeni.TabIndex = 2;
            this.labBonusPoeni.Text = "Bonus poeni:";
            // 
            // staze
            // 
            this.staze.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderNaziv,
            this.columnHeaderTipStaze,
            this.columnHeaderBonusP});
            this.staze.FullRowSelect = true;
            this.staze.GridLines = true;
            this.staze.HideSelection = false;
            this.staze.Location = new System.Drawing.Point(276, 23);
            this.staze.Name = "staze";
            this.staze.Size = new System.Drawing.Size(260, 222);
            this.staze.TabIndex = 1;
            this.staze.UseCompatibleStateImageBehavior = false;
            this.staze.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderNaziv
            // 
            this.columnHeaderNaziv.Text = "Naziv";
            // 
            // columnHeaderTipStaze
            // 
            this.columnHeaderTipStaze.Text = "Tip staze";
            this.columnHeaderTipStaze.Width = 84;
            // 
            // columnHeaderBonusP
            // 
            this.columnHeaderBonusP.Text = "Bonus poeni";
            this.columnHeaderBonusP.Width = 97;
            // 
            // textBoxNaziv
            // 
            this.textBoxNaziv.Location = new System.Drawing.Point(94, 12);
            this.textBoxNaziv.Name = "textBoxNaziv";
            this.textBoxNaziv.Size = new System.Drawing.Size(113, 20);
            this.textBoxNaziv.TabIndex = 3;
            // 
            // radioButtonSolo
            // 
            this.radioButtonSolo.AutoSize = true;
            this.radioButtonSolo.Location = new System.Drawing.Point(94, 66);
            this.radioButtonSolo.Name = "radioButtonSolo";
            this.radioButtonSolo.Size = new System.Drawing.Size(46, 17);
            this.radioButtonSolo.TabIndex = 4;
            this.radioButtonSolo.TabStop = true;
            this.radioButtonSolo.Text = "Solo";
            this.radioButtonSolo.UseVisualStyleBackColor = true;
            // 
            // radioButtonTimska
            // 
            this.radioButtonTimska.AutoSize = true;
            this.radioButtonTimska.Location = new System.Drawing.Point(148, 66);
            this.radioButtonTimska.Name = "radioButtonTimska";
            this.radioButtonTimska.Size = new System.Drawing.Size(59, 17);
            this.radioButtonTimska.TabIndex = 5;
            this.radioButtonTimska.TabStop = true;
            this.radioButtonTimska.Text = "Timska";
            this.radioButtonTimska.UseVisualStyleBackColor = true;
            // 
            // numBonusPoeni
            // 
            this.numBonusPoeni.Location = new System.Drawing.Point(94, 115);
            this.numBonusPoeni.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numBonusPoeni.Name = "numBonusPoeni";
            this.numBonusPoeni.Size = new System.Drawing.Size(113, 20);
            this.numBonusPoeni.TabIndex = 6;
            // 
            // btnDodajStazu
            // 
            this.btnDodajStazu.Location = new System.Drawing.Point(10, 171);
            this.btnDodajStazu.Name = "btnDodajStazu";
            this.btnDodajStazu.Size = new System.Drawing.Size(197, 32);
            this.btnDodajStazu.TabIndex = 7;
            this.btnDodajStazu.Text = "Dodaj Stazu";
            this.btnDodajStazu.UseVisualStyleBackColor = true;
            this.btnDodajStazu.Click += new System.EventHandler(this.btnDodajStazu_Click);
            // 
            // btnObrisiStazu
            // 
            this.btnObrisiStazu.Location = new System.Drawing.Point(428, 269);
            this.btnObrisiStazu.Name = "btnObrisiStazu";
            this.btnObrisiStazu.Size = new System.Drawing.Size(108, 33);
            this.btnObrisiStazu.TabIndex = 8;
            this.btnObrisiStazu.Text = "Obrisi Stazu";
            this.btnObrisiStazu.UseVisualStyleBackColor = true;
            this.btnObrisiStazu.Click += new System.EventHandler(this.btnObrisiStazu_Click);
            // 
            // DodajStazu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 341);
            this.Controls.Add(this.btnObrisiStazu);
            this.Controls.Add(this.staze);
            this.Controls.Add(this.groupBoxDodajStazu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DodajStazu";
            this.Text = "Dodaj Stazu";
            this.Load += new System.EventHandler(this.DodajStazu_Load);
            this.groupBoxDodajStazu.ResumeLayout(false);
            this.groupBoxDodajStazu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBonusPoeni)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDodajStazu;
        private System.Windows.Forms.Label labBonusPoeni;
        private System.Windows.Forms.Label labTipStaze;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView staze;
        private System.Windows.Forms.ColumnHeader columnHeaderNaziv;
        private System.Windows.Forms.ColumnHeader columnHeaderTipStaze;
        private System.Windows.Forms.ColumnHeader columnHeaderBonusP;
        private System.Windows.Forms.Button btnDodajStazu;
        private System.Windows.Forms.NumericUpDown numBonusPoeni;
        private System.Windows.Forms.RadioButton radioButtonTimska;
        private System.Windows.Forms.RadioButton radioButtonSolo;
        private System.Windows.Forms.TextBox textBoxNaziv;
        private System.Windows.Forms.Button btnObrisiStazu;
    }
}