using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Ciudad.SW;

namespace Ciudad
{
    public partial class Bloquear : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string tipo = Request.QueryString["tipo"];
            int id = int.Parse(Request.QueryString["id"]);
            ServiciosWeb ws = new ServiciosWeb();
            if (tipo == "Video")
            {
                ws.bloquearVideo(id);
            }
            else
            {
                ws.bloquearDenuncia(id);
            }
            Response.Redirect("Sitio.aspx");
        }
    }
}