using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Ciudad.SW;

namespace Ciudad
{
    public partial class Formulario_web11 : System.Web.UI.Page
    {
        DataTable dtDenuncias;
        DataTable dtSectores;
        ServiciosWeb sv = new ServiciosWeb();

        protected void Page_Load(object sender, EventArgs e)
        {

                dtSectores = sv.ObtenerSectores();
                ddlSector.DataSource = dtSectores;
                ddlSector.DataTextField = "nombreSector";
                ddlSector.DataValueField = "idSectorCiudad";
                ddlSector.DataBind();
                dtDenuncias = sv.ObtenerDenuncias();
                gvDenuncias.DataSource = dtDenuncias;
                if (Session["username"] == null)
                {
                    gvDenuncias.Columns[4].Visible = false;
                }
                gvDenuncias.DataBind();
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            DataTable resultado = new DataTable();
            resultado.Columns.Add("id");
            resultado.Columns.Add("idSectorCiudad");
            resultado.Columns.Add("nombreSector");
            resultado.Columns.Add("fecha");
            resultado.Columns.Add("idEstado");
            resultado.Columns.Add("archivo");
            resultado.Columns.Add("tipo");
            resultado.Columns.Add("link");
            resultado.Columns.Add("linkb");

            DateTime dtbus = DateTime.Parse(tbFecha.Text);
            int idSector = int.Parse(ddlSector.SelectedValue);
            var resul= dtDenuncias.AsEnumerable().Where(r => (r.Field<DateTime>("fecha") >= dtbus && r.Field<int>("idSectorCiudad") == idSector));
            DataRow[] rows = resul.Cast<DataRow>().ToArray();
            foreach (DataRow dr in rows)
            {
                resultado.ImportRow(dr);
            }
            gvDenuncias.DataSource = resultado;
            if (Session["username"] == null)
            {
                gvDenuncias.Columns[4].Visible = false;
            }
            gvDenuncias.DataBind();
        }
    }
}