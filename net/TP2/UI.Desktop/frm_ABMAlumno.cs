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
            for(int i = 0; i < celdas.Count; i++)
            {
                MessageBox.Show(this.Owner, celdas[i].ToString(), "");
            }
            new frm_AltaAlumno().ShowDialog();

        }


        public frm_ABMAlumno() 
        {
            InitializeComponent();
            grd_view.DataSource = Business.Logic.ABMalumno.listarAlumnos();
        }

        
    }
}
