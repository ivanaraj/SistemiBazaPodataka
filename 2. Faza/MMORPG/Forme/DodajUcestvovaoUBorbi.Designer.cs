namespace MMORPG.Forme
{
    partial class DodajUcestvovaoUBorbi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DodajUcestvovaoUBorbi));
            this.timovi = new System.Windows.Forms.ListView();
            this.groupBoxDetaljiOBorbi = new System.Windows.Forms.GroupBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.labTimovi = new System.Windows.Forms.Label();
            this.labPlasman = new System.Windows.Forms.Label();
            this.columnHeaderTim = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPlasman = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBoxDetaljiOBorbi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // timovi
            // 
            this.timovi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderTim,
            this.columnHeaderPlasman});
            this.timovi.FullRowSelect = true;
            this.timovi.GridLines = true;
            this.timovi.HideSelection = false;
            this.timovi.Location = new System.Drawing.Point(250, 13);
            this.timovi.Name = "timovi";
            this.timovi.Size = new System.Drawing.Size(156, 240);
            this.timovi.TabIndex = 0;
            this.timovi.UseCompatibleStateImageBehavior = false;
            this.timovi.View = System.Windows.Forms.View.Details;
            // 
            // groupBoxDetaljiOBorbi
            // 
            this.groupBoxDetaljiOBorbi.Controls.Add(this.comboBox1);
            this.groupBoxDetaljiOBorbi.Controls.Add(this.button1);
            this.groupBoxDetaljiOBorbi.Controls.Add(this.labPlasman);
            this.groupBoxDetaljiOBorbi.Controls.Add(this.labTimovi);
            this.groupBoxDetaljiOBorbi.Controls.Add(this.numericUpDown1);
            this.groupBoxDetaljiOBorbi.Location = new System.Drawing.Point(13, 13);
            this.groupBoxDetaljiOBorbi.Name = "groupBoxDetaljiOBorbi";
            this.groupBoxDetaljiOBorbi.Size = new System.Drawing.Size(212, 162);
            this.groupBoxDetaljiOBorbi.TabIndex = 1;
            this.groupBoxDetaljiOBorbi.TabStop = false;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(65, 63);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(121, 20);
            this.numericUpDown1.TabIndex = 1;
            // 
            // labTimovi
            // 
            this.labTimovi.AutoSize = true;
            this.labTimovi.Location = new System.Drawing.Point(6, 27);
            this.labTimovi.Name = "labTimovi";
            this.labTimovi.Size = new System.Drawing.Size(41, 13);
            this.labTimovi.TabIndex = 2;
            this.labTimovi.Text = "Timovi:";
            // 
            // labPlasman
            // 
            this.labPlasman.AutoSize = true;
            this.labPlasman.Location = new System.Drawing.Point(6, 65);
            this.labPlasman.Name = "labPlasman";
            this.labPlasman.Size = new System.Drawing.Size(50, 13);
            this.labPlasman.TabIndex = 3;
            this.labPlasman.Text = "Plasman:";
            // 
            // columnHeaderTim
            // 
            this.columnHeaderTim.Text = "Tim";
            // 
            // columnHeaderPlasman
            // 
            this.columnHeaderPlasman.Text = "Plasman";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Dodaj Tim";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(65, 24);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // DodajUcestvovaoUBorbi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 265);
            this.Controls.Add(this.groupBoxDetaljiOBorbi);
            this.Controls.Add(this.timovi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DodajUcestvovaoUBorbi";
            this.Text = "Detalji O Borbi";
            this.Load += new System.EventHandler(this.DodajUcestvovaoUBorbi_Load);
            this.groupBoxDetaljiOBorbi.ResumeLayout(false);
            this.groupBoxDetaljiOBorbi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView timovi;
        private System.Windows.Forms.GroupBox groupBoxDetaljiOBorbi;
        private System.Windows.Forms.Label labPlasman;
        private System.Windows.Forms.Label labTimovi;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ColumnHeader columnHeaderTim;
        private System.Windows.Forms.ColumnHeader columnHeaderPlasman;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
    }
}