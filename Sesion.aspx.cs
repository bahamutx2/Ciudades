using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Ciudad.SW;

namespace Ciudad
{
    public partial class Formulario_web1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            ServiciosWeb sw = new ServiciosWeb();
            bool core = sw.IniciarSesion(tbUser.Text, tbPass.Text);
            if (core)
            {
                Session.Add("username", tbUser.Text);
                Response.Redirect("Sitio.aspx");
            }
            else
            {
                ResponseNo.Visible = true;
            }
           
        }
    }
}