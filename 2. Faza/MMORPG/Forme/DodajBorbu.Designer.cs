namespace MMORPG.Forme
{
    partial class DodajBorbu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DodajBorbu));
            this.borbe = new System.Windows.Forms.ListView();
            this.columnHeaderId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderVremeB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPobednik = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderBonusP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBoxBorba = new System.Windows.Forms.GroupBox();
            this.btnDodajBorbu = new System.Windows.Forms.Button();
            this.numBonusP = new System.Windows.Forms.NumericUpDown();
            this.comboBoxPobednik = new System.Windows.Forms.ComboBox();
            this.dateTimeVremeBorbe = new System.Windows.Forms.DateTimePicker();
            this.labBonusP = new System.Windows.Forms.Label();
            this.labPobednik = new System.Windows.Forms.Label();
            this.labVremeBorbe = new System.Windows.Forms.Label();
            this.btnObrisiBorbu = new System.Windows.Forms.Button();
            this.btnDetaljiOBorbi = new System.Windows.Forms.Button();
            this.groupBoxBorba.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBonusP)).BeginInit();
            this.SuspendLayout();
            // 
            // borbe
            // 
            this.borbe.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderId,
            this.columnHeaderVremeB,
            this.columnHeaderPobednik,
            this.columnHeaderBonusP});
            this.borbe.FullRowSelect = true;
            this.borbe.GridLines = true;
            this.borbe.HideSelection = false;
            this.borbe.Location = new System.Drawing.Point(346, 12);
            this.borbe.Name = "borbe";
            this.borbe.Size = new System.Drawing.Size(346, 229);
            this.borbe.TabIndex = 0;
            this.borbe.UseCompatibleStateImageBehavior = false;
            this.borbe.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderId
            // 
            this.columnHeaderId.Text = "ID";
            this.columnHeaderId.Width = 69;
            // 
            // columnHeaderVremeB
            // 
            this.columnHeaderVremeB.Text = "Vreme borbe";
            this.columnHeaderVremeB.Width = 117;
            // 
            // columnHeaderPobednik
            // 
            this.columnHeaderPobednik.Text = "Pobednik";
            this.columnHeaderPobednik.Width = 72;
            // 
            // columnHeaderBonusP
            // 
            this.columnHeaderBonusP.Text = "Bonus poeni";
            this.columnHeaderBonusP.Width = 74;
            // 
            // groupBoxBorba
            // 
            this.groupBoxBorba.Controls.Add(this.btnDodajBorbu);
            this.groupBoxBorba.Controls.Add(this.numBonusP);
            this.groupBoxBorba.Controls.Add(this.comboBoxPobednik);
            this.groupBoxBorba.Controls.Add(this.dateTimeVremeBorbe);
            this.groupBoxBorba.Controls.Add(this.labBonusP);
            this.groupBoxBorba.Controls.Add(this.labPobednik);
            this.groupBoxBorba.Controls.Add(this.labVremeBorbe);
            this.groupBoxBorba.Location = new System.Drawing.Point(12, 12);
            this.groupBoxBorba.Name = "groupBoxBorba";
            this.groupBoxBorba.Size = new System.Drawing.Size(315, 229);
            this.groupBoxBorba.TabIndex = 1;
            this.groupBoxBorba.TabStop = false;
            // 
            // btnDodajBorbu
            // 
            this.btnDodajBorbu.Location = new System.Drawing.Point(9, 163);
            this.btnDodajBorbu.Name = "btnDodajBorbu";
            this.btnDodajBorbu.Size = new System.Drawing.Size(285, 36);
            this.btnDodajBorbu.TabIndex = 8;
            this.btnDodajBorbu.Text = "Dodaj Borbu";
            this.btnDodajBorbu.UseVisualStyleBackColor = true;
            this.btnDodajBorbu.Click += new System.EventHandler(this.btnDodajBorbu_Click);
            // 
            // numBonusP
            // 
            this.numBonusP.Location = new System.Drawing.Point(103, 112);
            this.numBonusP.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numBonusP.Name = "numBonusP";
            this.numBonusP.Size = new System.Drawing.Size(191, 20);
            this.numBonusP.TabIndex = 6;
            // 
            // comboBoxPobednik
            // 
            this.comboBoxPobednik.FormattingEnabled = true;
            this.comboBoxPobednik.Location = new System.Drawing.Point(103, 69);
            this.comboBoxPobednik.Name = "comboBoxPobednik";
            this.comboBoxPobednik.Size = new System.Drawing.Size(191, 21);
            this.comboBoxPobednik.TabIndex = 5;
            // 
            // dateTimeVremeBorbe
            // 
            this.dateTimeVremeBorbe.Location = new System.Drawing.Point(103, 23);
            this.dateTimeVremeBorbe.Name = "dateTimeVremeBorbe";
            this.dateTimeVremeBorbe.Size = new System.Drawing.Size(191, 20);
            this.dateTimeVremeBorbe.TabIndex = 4;
            // 
            // labBonusP
            // 
            this.labBonusP.AutoSize = true;
            this.labBonusP.Location = new System.Drawing.Point(6, 119);
            this.labBonusP.Name = "labBonusP";
            this.labBonusP.Size = new System.Drawing.Size(69, 13);
            this.labBonusP.TabIndex = 2;
            this.labBonusP.Text = "Bonus poeni:";
            // 
            // labPobednik
            // 
            this.labPobednik.AutoSize = true;
            this.labPobednik.Location = new System.Drawing.Point(6, 77);
            this.labPobednik.Name = "labPobednik";
            this.labPobednik.Size = new System.Drawing.Size(55, 13);
            this.labPobednik.TabIndex = 1;
            this.labPobednik.Text = "Pobednik:";
            // 
            // labVremeBorbe
            // 
            this.labVremeBorbe.AutoSize = true;
            this.labVremeBorbe.Location = new System.Drawing.Point(6, 29);
            this.labVremeBorbe.Name = "labVremeBorbe";
            this.labVremeBorbe.Size = new System.Drawing.Size(70, 13);
            this.labVremeBorbe.TabIndex = 0;
            this.labVremeBorbe.Text = "Vreme borbe:";
            // 
            // btnObrisiBorbu
            // 
            this.btnObrisiBorbu.Location = new System.Drawing.Point(540, 267);
            this.btnObrisiBorbu.Name = "btnObrisiBorbu";
            this.btnObrisiBorbu.Size = new System.Drawing.Size(152, 36);
            this.btnObrisiBorbu.TabIndex = 10;
            this.btnObrisiBorbu.Text = "Obrisi Borbu";
            this.btnObrisiBorbu.UseVisualStyleBackColor = true;
            this.btnObrisiBorbu.Click += new System.EventHandler(this.btnObrisiBorbu_Click);
            // 
            // btnDetaljiOBorbi
            // 
            this.btnDetaljiOBorbi.Location = new System.Drawing.Point(346, 267);
            this.btnDetaljiOBorbi.Name = "btnDetaljiOBorbi";
            this.btnDetaljiOBorbi.Size = new System.Drawing.Size(152, 36);
            this.btnDetaljiOBorbi.TabIndex = 11;
            this.btnDetaljiOBorbi.Text = "Detalji o Borbi";
            this.btnDetaljiOBorbi.UseVisualStyleBackColor = true;
            this.btnDetaljiOBorbi.Click += new System.EventHandler(this.btnDetaljiOBorbi_Click);
            // 
            // DodajBorbu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 360);
            this.Controls.Add(this.btnDetaljiOBorbi);
            this.Controls.Add(this.btnObrisiBorbu);
            this.Controls.Add(this.groupBoxBorba);
            this.Controls.Add(this.borbe);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DodajBorbu";
            this.Text = "Dodaj Borbu";
            this.Load += new System.EventHandler(this.DodajBorbu_Load);
            this.groupBoxBorba.ResumeLayout(false);
            this.groupBoxBorba.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBonusP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView borbe;
        private System.Windows.Forms.GroupBox groupBoxBorba;
        private System.Windows.Forms.Label labBonusP;
        private System.Windows.Forms.Label labPobednik;
        private System.Windows.Forms.Label labVremeBorbe;
        private System.Windows.Forms.NumericUpDown numBonusP;
        private System.Windows.Forms.ComboBox comboBoxPobednik;
        private System.Windows.Forms.DateTimePicker dateTimeVremeBorbe;
        private System.Windows.Forms.ColumnHeader columnHeaderId;
        private System.Windows.Forms.ColumnHeader columnHeaderVremeB;
        private System.Windows.Forms.ColumnHeader columnHeaderPobednik;
        private System.Windows.Forms.ColumnHeader columnHeaderBonusP;
        private System.Windows.Forms.Button btnDodajBorbu;
        private System.Windows.Forms.Button btnObrisiBorbu;
        private System.Windows.Forms.Button btnDetaljiOBorbi;
    }
}