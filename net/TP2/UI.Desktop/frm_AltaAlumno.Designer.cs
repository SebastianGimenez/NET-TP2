namespace UI.Desktop
{
    partial class frm_AltaAlumno
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
            this.label4 = new System.Windows.Forms.Label();
            this.txt_legajo = new System.Windows.Forms.TextBox();
            this.txt_dni = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grp_datosAlumno = new System.Windows.Forms.GroupBox();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.grp_datosAlumno.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(82, 223);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(208, 223);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(176, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "DNI";
            // 
            // txt_legajo
            // 
            this.txt_legajo.Location = new System.Drawing.Point(12, 89);
            this.txt_legajo.Name = "txt_legajo";
            this.txt_legajo.Size = new System.Drawing.Size(133, 20);
            this.txt_legajo.TabIndex = 5;
            // 
            // txt_dni
            // 
            this.txt_dni.Location = new System.Drawing.Point(176, 88);
            this.txt_dni.Name = "txt_dni";
            this.txt_dni.Size = new System.Drawing.Size(136, 20);
            this.txt_dni.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Legajo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Email";
            // 
            // txt_apellido
            // 
            this.txt_apellido.Location = new System.Drawing.Point(176, 32);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(136, 20);
            this.txt_apellido.TabIndex = 3;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(12, 140);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(136, 20);
            this.txt_email.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellido";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(176, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Telefono";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(9, 32);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(136, 20);
            this.txt_nombre.TabIndex = 1;
            // 
            // txt_telefono
            // 
            this.txt_telefono.Location = new System.Drawing.Point(179, 140);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(136, 20);
            this.txt_telefono.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // grp_datosAlumno
            // 
            this.grp_datosAlumno.Controls.Add(this.lblContraseña);
            this.grp_datosAlumno.Controls.Add(this.lblUsuario);
            this.grp_datosAlumno.Controls.Add(this.txtContraseña);
            this.grp_datosAlumno.Controls.Add(this.txtUsuario);
            this.grp_datosAlumno.Controls.Add(this.label1);
            this.grp_datosAlumno.Controls.Add(this.txt_telefono);
            this.grp_datosAlumno.Controls.Add(this.txt_nombre);
            this.grp_datosAlumno.Controls.Add(this.label5);
            this.grp_datosAlumno.Controls.Add(this.label2);
            this.grp_datosAlumno.Controls.Add(this.txt_email);
            this.grp_datosAlumno.Controls.Add(this.txt_apellido);
            this.grp_datosAlumno.Controls.Add(this.label6);
            this.grp_datosAlumno.Controls.Add(this.label3);
            this.grp_datosAlumno.Controls.Add(this.txt_dni);
            this.grp_datosAlumno.Controls.Add(this.txt_legajo);
            this.grp_datosAlumno.Controls.Add(this.label4);
            this.grp_datosAlumno.Dock = System.Windows.Forms.DockStyle.Top;
            this.grp_datosAlumno.Location = new System.Drawing.Point(0, 0);
            this.grp_datosAlumno.Name = "grp_datosAlumno";
            this.grp_datosAlumno.Size = new System.Drawing.Size(340, 214);
            this.grp_datosAlumno.TabIndex = 14;
            this.grp_datosAlumno.TabStop = false;
            this.grp_datosAlumno.Text = "Datos Alumno";
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Location = new System.Drawing.Point(179, 169);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(61, 13);
            this.lblContraseña.TabIndex = 15;
            this.lblContraseña.Text = "Contraseña";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(13, 169);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblUsuario.TabIndex = 14;
            this.lblUsuario.Text = "Usuario";
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(179, 187);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(136, 20);
            this.txtContraseña.TabIndex = 13;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(13, 188);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(135, 20);
            this.txtUsuario.TabIndex = 12;
            // 
            // frm_AltaAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(340, 264);
            this.Controls.Add(this.grp_datosAlumno);
            this.Name = "frm_AltaAlumno";
            this.Text = "Alta Alumno";
            this.Load += new System.EventHandler(this.frm_AltaAlumno_Load);
            this.Controls.SetChildIndex(this.btn_guardar, 0);
            this.Controls.SetChildIndex(this.btn_cancelar, 0);
            this.Controls.SetChildIndex(this.grp_datosAlumno, 0);
            this.grp_datosAlumno.ResumeLayout(false);
            this.grp_datosAlumno.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_legajo;
        private System.Windows.Forms.TextBox txt_dni;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grp_datosAlumno;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtUsuario;
    }
}
