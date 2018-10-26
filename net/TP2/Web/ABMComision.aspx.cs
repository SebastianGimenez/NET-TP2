using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web
{
    public partial class ABMComision : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.gv_comisiones.DataSource = Business.Logic.ABMcomision.listarComisiones();
            this.gv_comisiones.DataBind();
        }

        protected void btn_Alta_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/frm_altaComision.aspx");
        }

        protected void btn_modificar_Click(object sender, EventArgs e)
        {
            try
            {
                GridViewRow row = gv_comisiones.SelectedRow;
                string idCom = row.Cells[1].Text;
                Session["idCom"] = idCom;
                Response.Redirect("~/frm_modificarComision.aspx");
            }
            catch (Exception)
            {
                Response.Write("<script type='text/javascript'> alert('no se ha seleccionado ninguna comision') </script>");
            }
        }

        protected void btn_baja_Click(object sender, EventArgs e)
        {
            try
            {
                GridViewRow row = gv_comisiones.SelectedRow;
                string idCom = row.Cells[1].Text;
                Session["idCom"] = idCom;
                Response.Redirect("~/frm_bajaComision.aspx");
            }
            catch (Exception)
            {
                Response.Write("<script type='text/javascript'> alert('no se ha seleccionado ninguna comision') </script>");
            }
        }

        protected void btn_volver_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/indexAdmin.aspx");
        }
    }
}