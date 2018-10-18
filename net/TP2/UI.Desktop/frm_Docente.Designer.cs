namespace UI.Desktop
{
    partial class frm_Docente
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
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.misCursosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.puntuarAlumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(397, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.misCursosToolStripMenuItem,
            this.puntuarAlumnosToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // misCursosToolStripMenuItem
            // 
            this.misCursosToolStripMenuItem.Name = "misCursosToolStripMenuItem";
            this.misCursosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.misCursosToolStripMenuItem.Text = "Mis cursos";
            this.misCursosToolStripMenuItem.Click += new System.EventHandler(this.misCursosToolStripMenuItem_Click);
            // 
            // puntuarAlumnosToolStripMenuItem
            // 
            this.puntuarAlumnosToolStripMenuItem.Name = "puntuarAlumnosToolStripMenuItem";
            this.puntuarAlumnosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.puntuarAlumnosToolStripMenuItem.Text = "Puntuar Alumnos";
            this.puntuarAlumnosToolStripMenuItem.Click += new System.EventHandler(this.puntuarAlumnosToolStripMenuItem_Click);
            // 
            // frm_Docente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_Docente";
            this.Text = "frm_Docente";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem misCursosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem puntuarAlumnosToolStripMenuItem;
    }
}