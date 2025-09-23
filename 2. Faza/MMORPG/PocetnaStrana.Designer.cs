namespace MMORPG
{
    partial class PocetnaStrana
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PocetnaStrana));
            this.btnIgraci = new System.Windows.Forms.Button();
            this.btnStaze = new System.Windows.Forms.Button();
            this.btnOprema = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIgraci
            // 
            this.btnIgraci.Location = new System.Drawing.Point(40, 280);
            this.btnIgraci.Name = "btnIgraci";
            this.btnIgraci.Size = new System.Drawing.Size(103, 38);
            this.btnIgraci.TabIndex = 0;
            this.btnIgraci.Text = "Igraci";
            this.btnIgraci.UseVisualStyleBackColor = true;
            this.btnIgraci.Click += new System.EventHandler(this.btnIgraci_Click);
            // 
            // btnStaze
            // 
            this.btnStaze.Location = new System.Drawing.Point(40, 337);
            this.btnStaze.Name = "btnStaze";
            this.btnStaze.Size = new System.Drawing.Size(103, 38);
            this.btnStaze.TabIndex = 1;
            this.btnStaze.Text = "Staze";
            this.btnStaze.UseVisualStyleBackColor = true;
            this.btnStaze.Click += new System.EventHandler(this.btnStaze_Click);
            // 
            // btnOprema
            // 
            this.btnOprema.Location = new System.Drawing.Point(40, 398);
            this.btnOprema.Name = "btnOprema";
            this.btnOprema.Size = new System.Drawing.Size(103, 36);
            this.btnOprema.TabIndex = 2;
            this.btnOprema.Text = "Oprema";
            this.btnOprema.UseVisualStyleBackColor = true;
            // 
            // PocetnaStrana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MMORPG.Properties.Resources.mmorpg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(363, 534);
            this.Controls.Add(this.btnOprema);
            this.Controls.Add(this.btnStaze);
            this.Controls.Add(this.btnIgraci);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PocetnaStrana";
            this.Text = "MMORPG";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIgraci;
        private System.Windows.Forms.Button btnStaze;
        private System.Windows.Forms.Button btnOprema;
    }
}