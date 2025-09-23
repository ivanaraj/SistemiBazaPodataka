namespace MMORPG.Forme
{
    partial class IzmeniTim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IzmeniTim));
            this.groupBoxDodajTim = new System.Windows.Forms.GroupBox();
            this.btnIzmeniTim = new System.Windows.Forms.Button();
            this.numBonusP = new System.Windows.Forms.NumericUpDown();
            this.numMinIgraca = new System.Windows.Forms.NumericUpDown();
            this.numMaxIgraca = new System.Windows.Forms.NumericUpDown();
            this.labBonusP = new System.Windows.Forms.Label();
            this.labMinIgraca = new System.Windows.Forms.Label();
            this.labMaxIgraca = new System.Windows.Forms.Label();
            this.groupBoxDodajTim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBonusP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinIgraca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxIgraca)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxDodajTim
            // 
            this.groupBoxDodajTim.Controls.Add(this.btnIzmeniTim);
            this.groupBoxDodajTim.Controls.Add(this.numBonusP);
            this.groupBoxDodajTim.Controls.Add(this.numMinIgraca);
            this.groupBoxDodajTim.Controls.Add(this.numMaxIgraca);
            this.groupBoxDodajTim.Controls.Add(this.labBonusP);
            this.groupBoxDodajTim.Controls.Add(this.labMinIgraca);
            this.groupBoxDodajTim.Controls.Add(this.labMaxIgraca);
            this.groupBoxDodajTim.Location = new System.Drawing.Point(29, 21);
            this.groupBoxDodajTim.Name = "groupBoxDodajTim";
            this.groupBoxDodajTim.Size = new System.Drawing.Size(228, 224);
            this.groupBoxDodajTim.TabIndex = 1;
            this.groupBoxDodajTim.TabStop = false;
            // 
            // btnIzmeniTim
            // 
            this.btnIzmeniTim.Location = new System.Drawing.Point(10, 170);
            this.btnIzmeniTim.Name = "btnIzmeniTim";
            this.btnIzmeniTim.Size = new System.Drawing.Size(199, 32);
            this.btnIzmeniTim.TabIndex = 8;
            this.btnIzmeniTim.Text = "Izmeni Tim";
            this.btnIzmeniTim.UseVisualStyleBackColor = true;
            this.btnIzmeniTim.Click += new System.EventHandler(this.btnIzmeniTim_Click);
            // 
            // numBonusP
            // 
            this.numBonusP.Location = new System.Drawing.Point(122, 131);
            this.numBonusP.Name = "numBonusP";
            this.numBonusP.Size = new System.Drawing.Size(87, 20);
            this.numBonusP.TabIndex = 7;
            // 
            // numMinIgraca
            // 
            this.numMinIgraca.Location = new System.Drawing.Point(122, 79);
            this.numMinIgraca.Name = "numMinIgraca";
            this.numMinIgraca.Size = new System.Drawing.Size(87, 20);
            this.numMinIgraca.TabIndex = 6;
            // 
            // numMaxIgraca
            // 
            this.numMaxIgraca.Location = new System.Drawing.Point(122, 33);
            this.numMaxIgraca.Name = "numMaxIgraca";
            this.numMaxIgraca.Size = new System.Drawing.Size(87, 20);
            this.numMaxIgraca.TabIndex = 5;
            // 
            // labBonusP
            // 
            this.labBonusP.AutoSize = true;
            this.labBonusP.Location = new System.Drawing.Point(7, 133);
            this.labBonusP.Name = "labBonusP";
            this.labBonusP.Size = new System.Drawing.Size(69, 13);
            this.labBonusP.TabIndex = 3;
            this.labBonusP.Text = "Bonus poeni:";
            // 
            // labMinIgraca
            // 
            this.labMinIgraca.AutoSize = true;
            this.labMinIgraca.Location = new System.Drawing.Point(7, 81);
            this.labMinIgraca.Name = "labMinIgraca";
            this.labMinIgraca.Size = new System.Drawing.Size(89, 13);
            this.labMinIgraca.TabIndex = 2;
            this.labMinIgraca.Text = "Minimalno igraca:";
            // 
            // labMaxIgraca
            // 
            this.labMaxIgraca.AutoSize = true;
            this.labMaxIgraca.Location = new System.Drawing.Point(6, 35);
            this.labMaxIgraca.Name = "labMaxIgraca";
            this.labMaxIgraca.Size = new System.Drawing.Size(98, 13);
            this.labMaxIgraca.TabIndex = 1;
            this.labMaxIgraca.Text = "Maksimalno igraca:";
            // 
            // IzmeniTim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 278);
            this.Controls.Add(this.groupBoxDodajTim);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "IzmeniTim";
            this.Text = "Izmeni Tim";
            this.Load += new System.EventHandler(this.IzmeniTim_Load);
            this.groupBoxDodajTim.ResumeLayout(false);
            this.groupBoxDodajTim.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBonusP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinIgraca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxIgraca)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDodajTim;
        private System.Windows.Forms.Button btnIzmeniTim;
        private System.Windows.Forms.NumericUpDown numBonusP;
        private System.Windows.Forms.NumericUpDown numMinIgraca;
        private System.Windows.Forms.NumericUpDown numMaxIgraca;
        private System.Windows.Forms.Label labBonusP;
        private System.Windows.Forms.Label labMinIgraca;
        private System.Windows.Forms.Label labMaxIgraca;
    }
}