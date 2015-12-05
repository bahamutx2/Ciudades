using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ciudad
{
    public partial class Maestra : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] != null)
            {
                smPerfil.Visible = true;
                smInformes.Visible = true;
                smIniciar.Visible = false;
                smCerrar2.Visible = true;
               
            }
            else
            {
                smPerfil.Visible = false;
                smInformes.Visible = false;
                smIniciar.Visible = true;
                smCerrar2.Visible = false;
            }
        }

        protected void smCerrar2_Click(object sender, EventArgs e)
        {
            Session["username"] = null;
            Response.Redirect("Sesion.aspx");
        }

        
    }
}