namespace UI.Desktop
{
    partial class frm_Alumno
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
            this.inscribirseAUnaMateriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verMisNotasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lnk_salir = new System.Windows.Forms.LinkLabel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(391, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inscribirseAUnaMateriaToolStripMenuItem,
            this.verMisNotasToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // inscribirseAUnaMateriaToolStripMenuItem
            // 
            this.inscribirseAUnaMateriaToolStripMenuItem.Name = "inscribirseAUnaMateriaToolStripMenuItem";
            this.inscribirseAUnaMateriaToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.inscribirseAUnaMateriaToolStripMenuItem.Text = "Inscribirse a una materia";
            this.inscribirseAUnaMateriaToolStripMenuItem.Click += new System.EventHandler(this.inscribirseAUnaMateriaToolStripMenuItem_Click);
            // 
            // verMisNotasToolStripMenuItem
            // 
            this.verMisNotasToolStripMenuItem.Name = "verMisNotasToolStripMenuItem";
            this.verMisNotasToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.verMisNotasToolStripMenuItem.Text = "Ver mis notas";
            this.verMisNotasToolStripMenuItem.Click += new System.EventHandler(this.verMisNotasToolStripMenuItem_Click);
            // 
            // lnk_salir
            // 
            this.lnk_salir.AutoSize = true;
            this.lnk_salir.Location = new System.Drawing.Point(352, 9);
            this.lnk_salir.Name = "lnk_salir";
            this.lnk_salir.Size = new System.Drawing.Size(27, 13);
            this.lnk_salir.TabIndex = 1;
            this.lnk_salir.TabStop = true;
            this.lnk_salir.Text = "Salir";
            this.lnk_salir.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_salir_LinkClicked);
            // 
            // frm_Alumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 450);
            this.Controls.Add(this.lnk_salir);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_Alumno";
            this.Text = "Alumno Principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_Alumno_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inscribirseAUnaMateriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verMisNotasToolStripMenuItem;
        private System.Windows.Forms.LinkLabel lnk_salir;
    }
}