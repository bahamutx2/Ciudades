using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Ciudad.SW;

namespace Ciudad
{
    public partial class Formulario_web13 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] == null)
            {
                Response.Redirect("Sitio.aspx");
            }
        }

        protected void btnCambiarPwd_Click(object sender, EventArgs e)
        {
            ServiciosWeb sw = new ServiciosWeb();
            if (sw.cambiarContrasena(Session["username"].ToString(), pwdActual.Text, pwdN1.Text, pwdN2.Text))
            {
                Respons.ForeColor = System.Drawing.Color.Green;
                Respons.Text = "Se ha cambiado correctamente";
            }
            else
            {
                Respons.Text = "Error. Verifique los datos";
            }
        }
    }
}