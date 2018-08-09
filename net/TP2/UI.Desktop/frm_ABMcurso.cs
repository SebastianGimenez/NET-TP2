using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Desktop
{
    public partial class frm_ABMcurso : frm_BaseABM
    {
        override
         protected void alta()
        {
            new frm_AltaCurso().ShowDialog();
            grd_view.DataSource = null;
            grd_view.DataSource = Business.Logic.ABMcurso.listarCursos();
        }

        override
        protected void baja()
        {
            new frm_BajaCurso().ShowDialog();
            grd_view.DataSource = null;
            grd_view.DataSource = Business.Logic.ABMcurso.listarCursos();
        }



        public frm_ABMcurso()
        {
            InitializeComponent();
            grd_view.DataSource = Business.Logic.ABMcurso.listarCursos();
        }
    }
}
