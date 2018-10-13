namespace UI.Desktop
{
    partial class frm_ABM_DocenteCurso
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
            this.cmb_curso = new System.Windows.Forms.ComboBox();
            this.btn_buscarDocentes = new System.Windows.Forms.Button();
            this.txtComision = new System.Windows.Forms.TextBox();
            this.txtMateria = new System.Windows.Forms.TextBox();
            this.Curso = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).BeginInit();
            this.Curso.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmb_curso
            // 
            this.cmb_curso.FormattingEnabled = true;
            this.cmb_curso.Location = new System.Drawing.Point(27, 28);
            this.cmb_curso.Name = "cmb_curso";
            this.cmb_curso.Size = new System.Drawing.Size(185, 21);
            this.cmb_curso.TabIndex = 5;
            this.cmb_curso.SelectedValueChanged += new System.EventHandler(this.cmb_curso_SelectedValueChanged);
            // 
            // btn_buscarDocentes
            // 
            this.btn_buscarDocentes.Location = new System.Drawing.Point(502, 25);
            this.btn_buscarDocentes.Name = "btn_buscarDocentes";
            this.btn_buscarDocentes.Size = new System.Drawing.Size(75, 23);
            this.btn_buscarDocentes.TabIndex = 6;
            this.btn_buscarDocentes.Text = "Buscar";
            this.btn_buscarDocentes.UseVisualStyleBackColor = true;
            this.btn_buscarDocentes.Click += new System.EventHandler(this.btn_buscarDocentes_Click);
            // 
            // txtComision
            // 
            this.txtComision.Location = new System.Drawing.Point(227, 27);
            this.txtComision.Name = "txtComision";
            this.txtComision.Size = new System.Drawing.Size(118, 20);
            this.txtComision.TabIndex = 7;
            // 
            // txtMateria
            // 
            this.txtMateria.Location = new System.Drawing.Point(361, 27);
            this.txtMateria.Name = "txtMateria";
            this.txtMateria.Size = new System.Drawing.Size(115, 20);
            this.txtMateria.TabIndex = 8;
            // 
            // Curso
            // 
            this.Curso.Controls.Add(this.txtMateria);
            this.Curso.Controls.Add(this.txtComision);
            this.Curso.Controls.Add(this.btn_buscarDocentes);
            this.Curso.Controls.Add(this.cmb_curso);
            this.Curso.Location = new System.Drawing.Point(21, 260);
            this.Curso.Name = "Curso";
            this.Curso.Size = new System.Drawing.Size(613, 64);
            this.Curso.TabIndex = 9;
            this.Curso.TabStop = false;
            this.Curso.Text = "Curso";
            // 
            // frm_ABM_DocenteCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 490);
            this.Controls.Add(this.Curso);
            this.Name = "frm_ABM_DocenteCurso";
            this.Text = "frm_";
            this.Controls.SetChildIndex(this.Curso, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bs)).EndInit();
            this.Curso.ResumeLayout(false);
            this.Curso.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_curso;
        private System.Windows.Forms.Button btn_buscarDocentes;
        private System.Windows.Forms.TextBox txtComision;
        private System.Windows.Forms.TextBox txtMateria;
        private System.Windows.Forms.GroupBox Curso;
    }
}