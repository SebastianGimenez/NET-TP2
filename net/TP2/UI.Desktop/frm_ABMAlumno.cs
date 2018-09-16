using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UI.Desktop
{
    public partial class frm_ABMAlumno : UI.Desktop.frm_BaseABM
    {
        override
        protected void alta()
        {
            new frm_AltaAlumno().ShowDialog();
           // grd_view.DataSource = null;
            grd_view.DataSource = Business.Logic.ABMalumno.listarAlumnos();
           


        }

        override
        protected void baja()
        {
            new frm_bajaAlumno().ShowDialog();
            grd_view.DataSource = null; //
            grd_view.DataSource = Business.Logic.ABMalumno.listarAlumnos();
        }

        override
        protected void modi()
        {

            DataGridViewRow row = grd_view.CurrentRow;
            DataGridViewCellCollection celdas = row.Cells;
            Business.Entities.Alumno al = new Business.Entities.Alumno(
                  celdas["nombre"].Value.ToString(),
                   celdas["apellido"].Value.ToString(),
                    celdas["legajo"].Value.ToString(),
                     celdas["dni"].Value.ToString(),
                      celdas["email"].Value.ToString(),
                       celdas["telefono"].Value.ToString()
                  );
            al.NombreUsuario = celdas["nombreusuario"].Value.ToString();
            al.Contraseña = celdas["contraseña"].Value.ToString();
            int idpersona = (int)celdas["IDPersona"].Value;
            al.IDPersona = idpersona;



            new frm_AltaAlumno(al).ShowDialog();
            grd_view.DataSource = Business.Logic.ABMalumno.listarAlumnos();

        }


        public frm_ABMAlumno() 
        {
            InitializeComponent();
            grd_view.DataSource = Business.Logic.ABMalumno.listarAlumnos();
        }

        
    }
}
