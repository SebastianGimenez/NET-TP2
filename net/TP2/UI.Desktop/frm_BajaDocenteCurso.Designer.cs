namespace UI.Desktop
{
    partial class frm_BajaDocenteCurso
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
            this.lblDocente = new System.Windows.Forms.Label();
            this.lblCurso = new System.Windows.Forms.Label();
            this.txt_legajo = new System.Windows.Forms.TextBox();
            this.txt_nombreCurso = new System.Windows.Forms.TextBox();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDocente
            // 
            this.lblDocente.AutoSize = true;
            this.lblDocente.Location = new System.Drawing.Point(52, 146);
            this.lblDocente.Name = "lblDocente";
            this.lblDocente.Size = new System.Drawing.Size(86, 13);
            this.lblDocente.TabIndex = 0;
            this.lblDocente.Text = "Legajo Docente:";
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Location = new System.Drawing.Point(55, 199);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(77, 13);
            this.lblCurso.TabIndex = 1;
            this.lblCurso.Text = "Nombre Curso:";
            // 
            // txt_legajo
            // 
            this.txt_legajo.Location = new System.Drawing.Point(163, 143);
            this.txt_legajo.Name = "txt_legajo";
            this.txt_legajo.ReadOnly = true;
            this.txt_legajo.Size = new System.Drawing.Size(139, 20);
            this.txt_legajo.TabIndex = 2;
            // 
            // txt_nombreCurso
            // 
            this.txt_nombreCurso.Location = new System.Drawing.Point(163, 191);
            this.txt_nombreCurso.Name = "txt_nombreCurso";
            this.txt_nombreCurso.ReadOnly = true;
            this.txt_nombreCurso.Size = new System.Drawing.Size(139, 20);
            this.txt_nombreCurso.TabIndex = 3;
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Location = new System.Drawing.Point(81, 284);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(75, 23);
            this.btn_Agregar.TabIndex = 4;
            this.btn_Agregar.Text = "Borrar";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(222, 284);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar.TabIndex = 5;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click_1);
            // 
            // frm_BajaDocenteCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 450);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.txt_nombreCurso);
            this.Controls.Add(this.txt_legajo);
            this.Controls.Add(this.lblCurso);
            this.Controls.Add(this.lblDocente);
            this.Name = "frm_BajaDocenteCurso";
            this.Text = "frm_BajaDocenteCurso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDocente;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.TextBox txt_legajo;
        private System.Windows.Forms.TextBox txt_nombreCurso;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Button btn_Cancelar;
    }
}