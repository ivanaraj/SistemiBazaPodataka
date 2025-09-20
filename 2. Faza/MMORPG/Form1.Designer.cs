namespace MMORPG
{
    partial class Form1
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
            this.cmdUcitavanjeIgraca = new System.Windows.Forms.Button();
            this.cmdDodavanjeIgraca = new System.Windows.Forms.Button();
            this.cmdManyToOne = new System.Windows.Forms.Button();
            this.cmdOneToMany = new System.Windows.Forms.Button();
            this.cmdDodavanjeTima = new System.Windows.Forms.Button();
            this.cmdDodavanjeTimaNaStazi = new System.Windows.Forms.Button();
            this.cmdUcitavanjeIgracaNaStazi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdUcitavanjeIgraca
            // 
            this.cmdUcitavanjeIgraca.Location = new System.Drawing.Point(24, 28);
            this.cmdUcitavanjeIgraca.Name = "cmdUcitavanjeIgraca";
            this.cmdUcitavanjeIgraca.Size = new System.Drawing.Size(214, 23);
            this.cmdUcitavanjeIgraca.TabIndex = 0;
            this.cmdUcitavanjeIgraca.Text = "Ucitavanje Igraca";
            this.cmdUcitavanjeIgraca.UseVisualStyleBackColor = true;
            this.cmdUcitavanjeIgraca.Click += new System.EventHandler(this.cmdUcitavanjeIgraca_Click);
            // 
            // cmdDodavanjeIgraca
            // 
            this.cmdDodavanjeIgraca.Location = new System.Drawing.Point(24, 57);
            this.cmdDodavanjeIgraca.Name = "cmdDodavanjeIgraca";
            this.cmdDodavanjeIgraca.Size = new System.Drawing.Size(214, 23);
            this.cmdDodavanjeIgraca.TabIndex = 1;
            this.cmdDodavanjeIgraca.Text = "Dodavanje novog Igraca";
            this.cmdDodavanjeIgraca.UseVisualStyleBackColor = true;
            this.cmdDodavanjeIgraca.Click += new System.EventHandler(this.cmdDodavanjeIgraca_Click);
            // 
            // cmdManyToOne
            // 
            this.cmdManyToOne.Location = new System.Drawing.Point(24, 86);
            this.cmdManyToOne.Name = "cmdManyToOne";
            this.cmdManyToOne.Size = new System.Drawing.Size(214, 23);
            this.cmdManyToOne.TabIndex = 2;
            this.cmdManyToOne.Text = "Veza many-to-one";
            this.cmdManyToOne.UseVisualStyleBackColor = true;
            this.cmdManyToOne.Click += new System.EventHandler(this.cmdManyToOne_Click);
            // 
            // cmdOneToMany
            // 
            this.cmdOneToMany.Location = new System.Drawing.Point(24, 115);
            this.cmdOneToMany.Name = "cmdOneToMany";
            this.cmdOneToMany.Size = new System.Drawing.Size(214, 23);
            this.cmdOneToMany.TabIndex = 3;
            this.cmdOneToMany.Text = "Veza one-to-many";
            this.cmdOneToMany.UseVisualStyleBackColor = true;
            this.cmdOneToMany.Click += new System.EventHandler(this.cmdOneToMany_Click);
            // 
            // cmdDodavanjeTima
            // 
            this.cmdDodavanjeTima.Location = new System.Drawing.Point(24, 145);
            this.cmdDodavanjeTima.Name = "cmdDodavanjeTima";
            this.cmdDodavanjeTima.Size = new System.Drawing.Size(214, 23);
            this.cmdDodavanjeTima.TabIndex = 4;
            this.cmdDodavanjeTima.Text = "Dodavanje Tima";
            this.cmdDodavanjeTima.UseVisualStyleBackColor = true;
            this.cmdDodavanjeTima.Click += new System.EventHandler(this.cmdDodavanjeTima_Click);
            // 
            // cmdDodavanjeTimaNaStazi
            // 
            this.cmdDodavanjeTimaNaStazi.Location = new System.Drawing.Point(24, 175);
            this.cmdDodavanjeTimaNaStazi.Name = "cmdDodavanjeTimaNaStazi";
            this.cmdDodavanjeTimaNaStazi.Size = new System.Drawing.Size(214, 23);
            this.cmdDodavanjeTimaNaStazi.TabIndex = 5;
            this.cmdDodavanjeTimaNaStazi.Text = "Dodavanje Tima na Stazi";
            this.cmdDodavanjeTimaNaStazi.UseVisualStyleBackColor = true;
            this.cmdDodavanjeTimaNaStazi.Click += new System.EventHandler(this.cmdDodavanjeTimaNaStazi_Click);
            // 
            // cmdUcitavanjeIgracaNaStazi
            // 
            this.cmdUcitavanjeIgracaNaStazi.Location = new System.Drawing.Point(24, 205);
            this.cmdUcitavanjeIgracaNaStazi.Name = "cmdUcitavanjeIgracaNaStazi";
            this.cmdUcitavanjeIgracaNaStazi.Size = new System.Drawing.Size(214, 23);
            this.cmdUcitavanjeIgracaNaStazi.TabIndex = 6;
            this.cmdUcitavanjeIgracaNaStazi.Text = "Ucitavanje Staza na kojima je igrao Igrac";
            this.cmdUcitavanjeIgracaNaStazi.UseVisualStyleBackColor = true;
            this.cmdUcitavanjeIgracaNaStazi.Click += new System.EventHandler(this.cmdUcitavanjeIgracaNaStazi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 450);
            this.Controls.Add(this.cmdUcitavanjeIgracaNaStazi);
            this.Controls.Add(this.cmdDodavanjeTimaNaStazi);
            this.Controls.Add(this.cmdDodavanjeTima);
            this.Controls.Add(this.cmdOneToMany);
            this.Controls.Add(this.cmdManyToOne);
            this.Controls.Add(this.cmdDodavanjeIgraca);
            this.Controls.Add(this.cmdUcitavanjeIgraca);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdUcitavanjeIgraca;
        private System.Windows.Forms.Button cmdDodavanjeIgraca;
        private System.Windows.Forms.Button cmdManyToOne;
        private System.Windows.Forms.Button cmdOneToMany;
        private System.Windows.Forms.Button cmdDodavanjeTima;
        private System.Windows.Forms.Button cmdDodavanjeTimaNaStazi;
        private System.Windows.Forms.Button cmdUcitavanjeIgracaNaStazi;
    }
}

