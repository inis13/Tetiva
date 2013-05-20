namespace PI
{
    partial class Otpremnica
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
            this.MenuOtp = new System.Windows.Forms.MenuStrip();
            this.dodajNoviZapisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ispisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brisiZapisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izlazToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.toolStripContainer2 = new System.Windows.Forms.ToolStripContainer();
            this.MenuOtp.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.toolStripContainer2.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuOtp
            // 
            this.MenuOtp.Dock = System.Windows.Forms.DockStyle.None;
            this.MenuOtp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajNoviZapisToolStripMenuItem,
            this.ispisToolStripMenuItem,
            this.brisiZapisToolStripMenuItem,
            this.izlazToolStripMenuItem});
            this.MenuOtp.Location = new System.Drawing.Point(0, 0);
            this.MenuOtp.Name = "MenuOtp";
            this.MenuOtp.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.MenuOtp.Size = new System.Drawing.Size(384, 24);
            this.MenuOtp.TabIndex = 0;
            this.MenuOtp.Text = "MenuOtp";
            this.MenuOtp.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
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
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(384, 237);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(384, 262);
            this.toolStripContainer1.TabIndex = 1;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer2
            // 
            // 
            // toolStripContainer2.ContentPanel
            // 
            this.toolStripContainer2.ContentPanel.Size = new System.Drawing.Size(384, 238);
            this.toolStripContainer2.ContentPanel.Load += new System.EventHandler(this.toolStripContainer2_ContentPanel_Load);
            this.toolStripContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer2.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer2.Name = "toolStripContainer2";
            this.toolStripContainer2.Size = new System.Drawing.Size(384, 262);
            this.toolStripContainer2.TabIndex = 2;
            this.toolStripContainer2.Text = "toolStripContainer2";
            // 
            // toolStripContainer2.TopToolStripPanel
            // 
            this.toolStripContainer2.TopToolStripPanel.Controls.Add(this.MenuOtp);
            // 
            // Otpremnica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 262);
            this.Controls.Add(this.toolStripContainer2);
            this.Controls.Add(this.toolStripContainer1);
            this.MainMenuStrip = this.MenuOtp;
            this.Name = "Otpremnica";
            this.Text = "Otpremnica";
            this.MenuOtp.ResumeLayout(false);
            this.MenuOtp.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.toolStripContainer2.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer2.TopToolStripPanel.PerformLayout();
            this.toolStripContainer2.ResumeLayout(false);
            this.toolStripContainer2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuOtp;
        private System.Windows.Forms.ToolStripMenuItem dodajNoviZapisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ispisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brisiZapisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izlazToolStripMenuItem;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStripContainer toolStripContainer2;
    }
}