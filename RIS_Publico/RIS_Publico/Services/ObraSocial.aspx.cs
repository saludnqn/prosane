using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DalRis;
using fastJSON;

namespace RIS_Publico.Services
{
    [Serializable]
    public class oshelper
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string sigla { get; set; }
        public string codigoNacion { get; set; }
    }

    public partial class ObraSocial : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;
            string consulta = String.IsNullOrEmpty(Request.QueryString["term"]) ? "" : Request.QueryString["term"];
            
            SysObraSocialCollection oSociales = new SubSonic.Select().Top("10")
                .From(Schemas.SysObraSocial)
                .Where(SysObraSocial.Columns.Nombre)
                .Like(String.Format("%{0}%", consulta.Replace('*', '%')))
                .Or(SysObraSocial.Columns.Sigla).Like(String.Format("%{0}%", consulta.Replace('*', '%')))
                .Or(SysObraSocial.Columns.CodigoNacion).Like(String.Format("%{0}%", consulta.Replace('*', '%')))
                .ExecuteAsCollection<SysObraSocialCollection>();

            List<oshelper> lstOS = new List<oshelper>();

            foreach (SysObraSocial OS in oSociales)
            {
                oshelper osh = new oshelper();
                osh.id = OS.IdObraSocial;
                osh.nombre = OS.Nombre;
                osh.sigla = OS.Sigla;
                osh.codigoNacion = OS.CodigoNacion;
                lstOS.Add(osh);
            }
            if (lstOS.Count == 0)
            {
                lstOS.Add(new oshelper() { id = -666, nombre = "No hay resultados", sigla = "", codigoNacion = "" });
            }
            Response.Clear();
            Response.Write(JSON.Instance.ToJSON(lstOS));
            Response.Flush();
            Response.End();
        }
    }
}
