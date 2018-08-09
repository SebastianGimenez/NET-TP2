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
    public partial class frm_ABMcomision : frm_BaseABM
    {
        override
         protected void alta()
        {
            new frm_AltaComision().ShowDialog();
            grd_view.DataSource = null;
            grd_view.DataSource = Business.Logic.ABMcomision.listarComisiones();
        }

        override
        protected void baja()
        {
            new frm_BajaComision().ShowDialog();
            grd_view.DataSource = null;
            grd_view.DataSource = Business.Logic.ABMcomision.listarComisiones();
        }



        public frm_ABMcomision()
        {
            InitializeComponent();
            grd_view.DataSource = Business.Logic.ABMcomision.listarComisiones();
        }
    }
}
