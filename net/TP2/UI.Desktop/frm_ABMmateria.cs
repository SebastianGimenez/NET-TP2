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
    public partial class frm_ABMmateria : frm_BaseABM
    {
        override
          protected void alta()
        {
            new frm_AltaMateria().ShowDialog();
            grd_view.DataSource = null;
            grd_view.DataSource = Business.Logic.ABMmateria.listarMaterias();
        }

        override
        protected void baja()
        {
            new frm_BajaMateria().ShowDialog();
            grd_view.DataSource = null;
            grd_view.DataSource = Business.Logic.ABMmateria.listarMaterias();
        }



        public frm_ABMmateria()
        {
            InitializeComponent();
            grd_view.DataSource = Business.Logic.ABMmateria.listarMaterias();
        }
    }
}
