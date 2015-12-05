using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Web;
using System.Web.UI;
using System.Web.UI.DataVisualization.Charting;
using System.Web.UI.WebControls;
using iTextSharp.text;
using iTextSharp.text.html.simpleparser;
using iTextSharp.text.pdf;
using System.Data;
using Ciudad.SW;

namespace Ciudad
{
    public partial class Formulario_web14 : System.Web.UI.Page
    {
        DataTable s = new DataTable();
        DataTable s2 = new DataTable();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] == null)
            {
                Response.Redirect("Sitio.aspx");
            }
            else
            {
                ServiciosWeb ws = new ServiciosWeb();
                DataTable dt = ws.ObtenerReporteVideos();
                s.Columns.Add("Estado");
                s.Columns.Add("Cantidad");
                s.Rows.Add("Totales", int.Parse(dt.Rows[0]["Total"].ToString()));
                s.Rows.Add("Bloqueados", int.Parse(dt.Rows[0]["Bloqueados"].ToString()));
                s.Rows.Add("Activos", int.Parse(dt.Rows[0]["Activos"].ToString()));
                Chart1.DataSource = s;
                Chart1.DataBind();

                dt = ws.ObtenerReporteDenuncia();
                s2.Columns.Add("Estado");
                s2.Columns.Add("Cantidad");
                s2.Rows.Add("Totales", int.Parse(dt.Rows[0]["Total"].ToString()));
                s2.Rows.Add("Bloqueadas", int.Parse(dt.Rows[0]["Bloqueados"].ToString()));
                s2.Rows.Add("Activas", int.Parse(dt.Rows[0]["Activos"].ToString()));
                Chart2.DataSource = s2;
                Chart2.DataBind();
            }
        }

        protected void btnRepVi_Click(object sender, EventArgs e)
        {

            ServiciosWeb ws = new ServiciosWeb();
            DataTable dt = ws.ObtenerReporteVideos();
            string cadena = "<table><tr><th colspan='3'>Reporte de videos</tr><tr><th>Totales</th><th>Activos</th><th>Bloqueados</th></tr><tr><td>{0}</td><td>{1}</td><td>{2}</td></tr></table>";
            string codigopdf = string.Format(cadena, dt.Rows[0]["Total"].ToString(), dt.Rows[0]["Activos"].ToString(), dt.Rows[0]["Bloqueados"].ToString());
            
            Document pdfDoc = new Document(PageSize.A4, 10, 10, 10, 10);
            
            try
            {
                PdfWriter.GetInstance(pdfDoc, System.Web.HttpContext.Current.Response.OutputStream);
                pdfDoc.Open();

                //Assign Html content in a string to write in PDF 
                string strContent = codigopdf;

                //Read string contents using stream reader and convert html to parsed conent 
                var parsedHtmlElements = HTMLWorker.ParseToList(new StringReader(strContent), null);

                //Get each array values from parsed elements and add to the PDF document 
                foreach (var htmlElement in parsedHtmlElements)
                    pdfDoc.Add(htmlElement as IElement);

                //Close your PDF 
                pdfDoc.Close();

                Response.ContentType = "application/pdf";

                //Set default file Name as current datetime 
                Response.AddHeader("content-disposition", "attachment; filename=ReporteVideos.pdf");
                System.Web.HttpContext.Current.Response.Write(pdfDoc);

                Response.Flush();
                Response.End();

            }
            catch (Exception ex)
            {
                Response.Write(ex.ToString());
            }
        }

        protected void btnRepDe_Click(object sender, EventArgs e)
        {
            ServiciosWeb ws = new ServiciosWeb();
            DataTable dt = ws.ObtenerReporteDenuncia();
            string cadena = "<table><tr><th colspan='3'>Reporte de denuncias</tr><tr><th>Totales</th><th>Activos</th><th>Bloqueados</th></tr><tr><td>{0}</td><td>{1}</td><td>{2}</td></tr></table>";
            string codigopdf = string.Format(cadena, dt.Rows[0]["Total"].ToString(), dt.Rows[0]["Activos"].ToString(), dt.Rows[0]["Bloqueados"].ToString());

            Document pdfDoc = new Document(PageSize.A4, 10, 10, 10, 10);

            try
            {
                PdfWriter.GetInstance(pdfDoc, System.Web.HttpContext.Current.Response.OutputStream);
                pdfDoc.Open();

                //Assign Html content in a string to write in PDF 
                string strContent = codigopdf;

                //Read string contents using stream reader and convert html to parsed conent 
                var parsedHtmlElements = HTMLWorker.ParseToList(new StringReader(strContent), null);

                //Get each array values from parsed elements and add to the PDF document 
                foreach (var htmlElement in parsedHtmlElements)
                    pdfDoc.Add(htmlElement as IElement);

                //Close your PDF 
                pdfDoc.Close();

                Response.ContentType = "application/pdf";

                //Set default file Name as current datetime 
                Response.AddHeader("content-disposition", "attachment; filename=ReporteDenuncias.pdf");
                System.Web.HttpContext.Current.Response.Write(pdfDoc);

                Response.Flush();
                Response.End();

            }
            catch (Exception ex)
            {
                Response.Write(ex.ToString());
            }
        }
    }
}