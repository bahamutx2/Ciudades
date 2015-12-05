using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ciudad
{
    public partial class Formulario_web12 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string tipo = Request.QueryString["tipo"];
            string url = Request.QueryString["arc"];
            string code = "";
            string code2;
            if (tipo == "Video")
            {
                code = "<object id='MediaPlayer' width='192' height='190' type='video/x-ms-asf'>";
                code += "<param name='FileName'value='{0}'>";
                code += "<param name='autostart' value='false'>";
                code += "<param name='ShowControls' value='true'>";
                code += "<param name='ShowStatusBar' value='false'>";
                code += "<param name='ShowDisplay' value='false'>";
                code += "<embed type='application/x-mplayer2' src='{1}' ";
                code += "width='192' height='190' ShowControls='1' ShowStatusBar='0' ShowDisplay='0' autostart='0' />";
                code += "</object>";
                code2 = string.Format(code, "http://www.ciudadcontradelincuencia.somee.com/archivos/" + url.ToString(), "http://www.ciudadcontradelincuencia.somee.com/archivos/" + url.ToString());
            }
            else
            {
                code = "<img src='{0}' width='100%' />";
                code2 = string.Format(code, "http://www.ciudadcontradelincuencia.somee.com/archivos/" + url.ToString());
            }
            divMostrar.InnerHtml = code2;
        }
    }
}