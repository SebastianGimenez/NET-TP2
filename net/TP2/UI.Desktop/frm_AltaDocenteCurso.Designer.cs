namespace UI.Desktop
{
    partial class frm_AltaDocenteCurso
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
            this.txt_NombreCurso = new System.Windows.Forms.TextBox();
            this.lbl_nombreCurso = new System.Windows.Forms.Label();
            this.lbl_legajo = new System.Windows.Forms.Label();
            this.cmb_Legajos = new System.Windows.Forms.ComboBox();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_NombreCurso
            // 
            this.txt_NombreCurso.Location = new System.Drawing.Point(162, 116);
            this.txt_NombreCurso.Name = "txt_NombreCurso";
            this.txt_NombreCurso.Size = new System.Drawing.Size(121, 20);
            this.txt_NombreCurso.TabIndex = 0;
            // 
            // lbl_nombreCurso
            // 
            this.lbl_nombreCurso.AutoSize = true;
            this.lbl_nombreCurso.Location = new System.Drawing.Point(39, 123);
            this.lbl_nombreCurso.Name = "lbl_nombreCurso";
            this.lbl_nombreCurso.Size = new System.Drawing.Size(37, 13);
            this.lbl_nombreCurso.TabIndex = 1;
            this.lbl_nombreCurso.Text = "Curso:";
            // 
            // lbl_legajo
            // 
            this.lbl_legajo.AutoSize = true;
            this.lbl_legajo.Location = new System.Drawing.Point(42, 184);
            this.lbl_legajo.Name = "lbl_legajo";
            this.lbl_legajo.Size = new System.Drawing.Size(86, 13);
            this.lbl_legajo.TabIndex = 2;
            this.lbl_legajo.Text = "Legajo Docente:";
            // 
            // cmb_Legajos
            // 
            this.cmb_Legajos.FormattingEnabled = true;
            this.cmb_Legajos.Location = new System.Drawing.Point(162, 175);
            this.cmb_Legajos.Name = "cmb_Legajos";
            this.cmb_Legajos.Size = new System.Drawing.Size(121, 21);
            this.cmb_Legajos.TabIndex = 3;
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(70, 285);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(75, 23);
            this.btn_agregar.TabIndex = 4;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(180, 284);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar.TabIndex = 5;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // frm_AltaDocenteCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 420);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.cmb_Legajos);
            this.Controls.Add(this.lbl_legajo);
            this.Controls.Add(this.lbl_nombreCurso);
            this.Controls.Add(this.txt_NombreCurso);
            this.Name = "frm_AltaDocenteCurso";
            this.Text = "Alta Docente a un Curso";
            this.Load += new System.EventHandler(this.frm_AltaDocenteCurso_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_NombreCurso;
        private System.Windows.Forms.Label lbl_nombreCurso;
        private System.Windows.Forms.Label lbl_legajo;
        private System.Windows.Forms.ComboBox cmb_Legajos;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Button btn_Cancelar;
    }
}