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
    public partial class frm_ABMespecialidad : frm_BaseABM
    {
        override
         protected void alta()
        {
            new frm_AltaEspecialidad().ShowDialog();
            grd_view.DataSource = null;
            grd_view.DataSource = Business.Logic.ABMespecialidad.listarEspecialidades();
        }

        override
        protected void baja()
        {
            new frm_BajaEspecialidad().ShowDialog();
            grd_view.DataSource = null;
            grd_view.DataSource = Business.Logic.ABMespecialidad.listarEspecialidades();
        }



        public frm_ABMespecialidad()
        {
            InitializeComponent();
            grd_view.DataSource = Business.Logic.ABMespecialidad.listarEspecialidades();
        }

    }
}

