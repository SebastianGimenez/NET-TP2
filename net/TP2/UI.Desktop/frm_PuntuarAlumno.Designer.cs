namespace UI.Desktop
{
    partial class frm_PuntuarAlumno
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
            this.grv_Alumnos = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cmb_Cursos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Puntuar = new System.Windows.Forms.Button();
            this.btn_Volver = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMateria = new System.Windows.Forms.TextBox();
            this.txtComision = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grv_Alumnos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grv_Alumnos
            // 
            this.grv_Alumnos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grv_Alumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grv_Alumnos.Location = new System.Drawing.Point(0, 0);
            this.grv_Alumnos.Name = "grv_Alumnos";
            this.grv_Alumnos.Size = new System.Drawing.Size(495, 185);
            this.grv_Alumnos.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(93, 209);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // cmb_Cursos
            // 
            this.cmb_Cursos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Cursos.FormattingEnabled = true;
            this.cmb_Cursos.Location = new System.Drawing.Point(40, 19);
            this.cmb_Cursos.Name = "cmb_Cursos";
            this.cmb_Cursos.Size = new System.Drawing.Size(121, 21);
            this.cmb_Cursos.TabIndex = 2;
            this.cmb_Cursos.SelectedValueChanged += new System.EventHandler(this.cmb_Cursos_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Legajo";
            // 
            // btn_Puntuar
            // 
            this.btn_Puntuar.Location = new System.Drawing.Point(0, 298);
            this.btn_Puntuar.Name = "btn_Puntuar";
            this.btn_Puntuar.Size = new System.Drawing.Size(495, 45);
            this.btn_Puntuar.TabIndex = 5;
            this.btn_Puntuar.Text = "Puntuar";
            this.btn_Puntuar.UseVisualStyleBackColor = true;
            this.btn_Puntuar.Click += new System.EventHandler(this.btn_Puntuar_Click);
            // 
            // btn_Volver
            // 
            this.btn_Volver.Location = new System.Drawing.Point(0, 341);
            this.btn_Volver.Name = "btn_Volver";
            this.btn_Volver.Size = new System.Drawing.Size(495, 46);
            this.btn_Volver.TabIndex = 6;
            this.btn_Volver.Text = "Volver";
            this.btn_Volver.UseVisualStyleBackColor = true;
            this.btn_Volver.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMateria);
            this.groupBox1.Controls.Add(this.txtComision);
            this.groupBox1.Controls.Add(this.cmb_Cursos);
            this.groupBox1.Location = new System.Drawing.Point(12, 242);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(471, 46);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Curso";
            // 
            // txtMateria
            // 
            this.txtMateria.Enabled = false;
            this.txtMateria.Location = new System.Drawing.Point(348, 19);
            this.txtMateria.Name = "txtMateria";
            this.txtMateria.Size = new System.Drawing.Size(100, 20);
            this.txtMateria.TabIndex = 6;
            // 
            // txtComision
            // 
            this.txtComision.Enabled = false;
            this.txtComision.Location = new System.Drawing.Point(212, 19);
            this.txtComision.Name = "txtComision";
            this.txtComision.Size = new System.Drawing.Size(100, 20);
            this.txtComision.TabIndex = 5;
            // 
            // frm_PuntuarAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 399);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Volver);
            this.Controls.Add(this.btn_Puntuar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.grv_Alumnos);
            this.Name = "frm_PuntuarAlumno";
            this.Text = "Puntuar Alumno";
            ((System.ComponentModel.ISupportInitialize)(this.grv_Alumnos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grv_Alumnos;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox cmb_Cursos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Puntuar;
        private System.Windows.Forms.Button btn_Volver;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMateria;
        private System.Windows.Forms.TextBox txtComision;
    }
}