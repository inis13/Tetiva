namespace PI
{
    partial class Narudzbenica
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dodajNoviZapisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ispisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brisiZapisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izlazToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajNoviZapisToolStripMenuItem,
            this.ispisToolStripMenuItem,
            this.brisiZapisToolStripMenuItem,
            this.izlazToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(383, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dodajNoviZapisToolStripMenuItem
            // 
            this.dodajNoviZapisToolStripMenuItem.Name = "dodajNoviZapisToolStripMenuItem";
            this.dodajNoviZapisToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.dodajNoviZapisToolStripMenuItem.Text = "Dodaj novi zapis";
            // 
            // ispisToolStripMenuItem
            // 
            this.ispisToolStripMenuItem.Name = "ispisToolStripMenuItem";
            this.ispisToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.ispisToolStripMenuItem.Text = "Ispis";
            // 
            // brisiZapisToolStripMenuItem
            // 
            this.brisiZapisToolStripMenuItem.Name = "brisiZapisToolStripMenuItem";
            this.brisiZapisToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.brisiZapisToolStripMenuItem.Text = "Brisi zapis";
            // 
            // izlazToolStripMenuItem
            // 
            this.izlazToolStripMenuItem.Name = "izlazToolStripMenuItem";
            this.izlazToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.izlazToolStripMenuItem.Text = "Izlaz";
            this.izlazToolStripMenuItem.Click += new System.EventHandler(this.izlazToolStripMenuItem_Click);
            // 
            // Narudzbenica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 262);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Narudzbenica";
            this.Text = "Narudzbenica";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dodajNoviZapisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ispisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brisiZapisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izlazToolStripMenuItem;

    }
}