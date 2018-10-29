namespace UI.Desktop
{
    partial class frm_Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.docentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.especialidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comisionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cursoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.docenteCursoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alumnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inscripcionACursoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verMisCursosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.docenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verMisCursosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.puntuarAlumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lnk_salir = new System.Windows.Forms.LinkLabel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.alumnoToolStripMenuItem,
            this.docenteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(450, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alumnosToolStripMenuItem,
            this.docentesToolStripMenuItem,
            this.especialidadToolStripMenuItem,
            this.comisionToolStripMenuItem,
            this.planToolStripMenuItem,
            this.materiaToolStripMenuItem,
            this.cursoToolStripMenuItem,
            this.docenteCursoToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.archivoToolStripMenuItem.Text = "Carga";
            this.archivoToolStripMenuItem.Click += new System.EventHandler(this.archivoToolStripMenuItem_Click);
            // 
            // alumnosToolStripMenuItem
            // 
            this.alumnosToolStripMenuItem.Name = "alumnosToolStripMenuItem";
            this.alumnosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.alumnosToolStripMenuItem.Text = "Alumnos";
            this.alumnosToolStripMenuItem.Click += new System.EventHandler(this.alumnosToolStripMenuItem_Click);
            // 
            // docentesToolStripMenuItem
            // 
            this.docentesToolStripMenuItem.Name = "docentesToolStripMenuItem";
            this.docentesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.docentesToolStripMenuItem.Text = "Docentes";
            this.docentesToolStripMenuItem.Click += new System.EventHandler(this.docentesToolStripMenuItem_Click);
            // 
            // especialidadToolStripMenuItem
            // 
            this.especialidadToolStripMenuItem.Name = "especialidadToolStripMenuItem";
            this.especialidadToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.especialidadToolStripMenuItem.Text = "Especialidad";
            this.especialidadToolStripMenuItem.Click += new System.EventHandler(this.especialidadToolStripMenuItem_Click);
            // 
            // comisionToolStripMenuItem
            // 
            this.comisionToolStripMenuItem.Name = "comisionToolStripMenuItem";
            this.comisionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.comisionToolStripMenuItem.Text = "Comision";
            this.comisionToolStripMenuItem.Click += new System.EventHandler(this.comisionToolStripMenuItem_Click);
            // 
            // planToolStripMenuItem
            // 
            this.planToolStripMenuItem.Name = "planToolStripMenuItem";
            this.planToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.planToolStripMenuItem.Text = "Plan";
            this.planToolStripMenuItem.Click += new System.EventHandler(this.planToolStripMenuItem_Click);
            // 
            // materiaToolStripMenuItem
            // 
            this.materiaToolStripMenuItem.Name = "materiaToolStripMenuItem";
            this.materiaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.materiaToolStripMenuItem.Text = "Materia";
            this.materiaToolStripMenuItem.Click += new System.EventHandler(this.materiaToolStripMenuItem_Click);
            // 
            // cursoToolStripMenuItem
            // 
            this.cursoToolStripMenuItem.Name = "cursoToolStripMenuItem";
            this.cursoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cursoToolStripMenuItem.Text = "Curso";
            this.cursoToolStripMenuItem.Click += new System.EventHandler(this.cursoToolStripMenuItem_Click);
            // 
            // docenteCursoToolStripMenuItem
            // 
            this.docenteCursoToolStripMenuItem.Name = "docenteCursoToolStripMenuItem";
            this.docenteCursoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.docenteCursoToolStripMenuItem.Text = "Docente-Curso";
            this.docenteCursoToolStripMenuItem.Click += new System.EventHandler(this.docenteCursoToolStripMenuItem_Click);
            // 
            // alumnoToolStripMenuItem
            // 
            this.alumnoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inscripcionACursoToolStripMenuItem,
            this.verMisCursosToolStripMenuItem});
            this.alumnoToolStripMenuItem.Name = "alumnoToolStripMenuItem";
            this.alumnoToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.alumnoToolStripMenuItem.Text = "Alumno";
            // 
            // inscripcionACursoToolStripMenuItem
            // 
            this.inscripcionACursoToolStripMenuItem.Name = "inscripcionACursoToolStripMenuItem";
            this.inscripcionACursoToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.inscripcionACursoToolStripMenuItem.Text = "Inscripcion a curso";
            this.inscripcionACursoToolStripMenuItem.Click += new System.EventHandler(this.inscripcionACursoToolStripMenuItem_Click);
            // 
            // verMisCursosToolStripMenuItem
            // 
            this.verMisCursosToolStripMenuItem.Name = "verMisCursosToolStripMenuItem";
            this.verMisCursosToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.verMisCursosToolStripMenuItem.Text = "Ver mis cursos";
            this.verMisCursosToolStripMenuItem.Click += new System.EventHandler(this.verMisCursosToolStripMenuItem_Click);
            // 
            // docenteToolStripMenuItem
            // 
            this.docenteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verMisCursosToolStripMenuItem1,
            this.puntuarAlumnosToolStripMenuItem});
            this.docenteToolStripMenuItem.Name = "docenteToolStripMenuItem";
            this.docenteToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.docenteToolStripMenuItem.Text = "Docente";
            // 
            // verMisCursosToolStripMenuItem1
            // 
            this.verMisCursosToolStripMenuItem1.Name = "verMisCursosToolStripMenuItem1";
            this.verMisCursosToolStripMenuItem1.Size = new System.Drawing.Size(167, 22);
            this.verMisCursosToolStripMenuItem1.Text = "Ver mis cursos";
            this.verMisCursosToolStripMenuItem1.Click += new System.EventHandler(this.verMisCursosToolStripMenuItem1_Click);
            // 
            // puntuarAlumnosToolStripMenuItem
            // 
            this.puntuarAlumnosToolStripMenuItem.Name = "puntuarAlumnosToolStripMenuItem";
            this.puntuarAlumnosToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.puntuarAlumnosToolStripMenuItem.Text = "Puntuar Alumnos";
            this.puntuarAlumnosToolStripMenuItem.Click += new System.EventHandler(this.puntuarAlumnosToolStripMenuItem_Click);
            // 
            // lnk_salir
            // 
            this.lnk_salir.AutoSize = true;
            this.lnk_salir.Location = new System.Drawing.Point(411, 9);
            this.lnk_salir.Name = "lnk_salir";
            this.lnk_salir.Size = new System.Drawing.Size(27, 13);
            this.lnk_salir.TabIndex = 1;
            this.lnk_salir.TabStop = true;
            this.lnk_salir.Text = "Salir";
            this.lnk_salir.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_salir_LinkClicked);
            // 
            // frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 366);
            this.Controls.Add(this.lnk_salir);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_Principal";
            this.ShowIcon = false;
            this.Text = "Principal";
            this.Activated += new System.EventHandler(this.frm_Principal_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_Principal_FormClosing);
            this.Load += new System.EventHandler(this.frm_Principal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alumnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem docentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cursoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem especialidadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem materiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem planToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comisionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem docenteCursoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alumnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inscripcionACursoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verMisCursosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem docenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verMisCursosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem puntuarAlumnosToolStripMenuItem;
        private System.Windows.Forms.LinkLabel lnk_salir;
    }
}

