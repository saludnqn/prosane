using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using DALAutomotores;

namespace Web.Vehiculos
{
    public partial class VehiculoPMPHistoricoList : System.Web.UI.Page
    {
        // -----------------------------------------------------------------------------------------------------------------

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Session["idUsuario"] == null)// si la sesion está activa
                {
                    Response.Write("<script>window.parent.location='../Finsesion.htm'</script>");
                }
                else
                {
                    int idVehiculo = int.Parse(Request["idVehiculo"].ToString());
                    mostrarDatos(idVehiculo);

                    CargarLista();
                }
            }
        }

        // -----------------------------------------------------------------------------------------------------------

        private void mostrarDatos(int idVehiculo)
        {
            AutVehiculo oVehiculo = new AutVehiculo(idVehiculo);
            lblDatosVehiculo.Text = "Historial de PMP realizados del vehículo dominio: " + oVehiculo.Dominio;
        }

        // -----------------------------------------------------------------------------------------------------------

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)  // Verifica si ingresa un filtro de busqueda            
                CargarLista();
        }

        // -----------------------------------------------------------------------------------------------------------------

        private void CargarLista()
        {
            gvLista.DataSource = SPs.AutListUnVehiculoConSusHistoricosDePMP(int.Parse(Request["idVehiculoPMP"].ToString()), int.Parse(Request["idVehiculo"].ToString())).GetDataSet().Tables[0];

            if (gvLista.DataSource != null)
            {
                gvLista.DataBind();
            }
        }

        // -----------------------------------------------------------------------------------------------------------------

        protected void gvLista_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            switch (e.CommandName)
            {
                case "Modificar": Response.Redirect("VehiculoPMPHistoricoEdit.aspx?idHistoricoVehiculoPMP=" + e.CommandArgument + "&idVehiculoPMP=" + Request["idVehiculoPMP"].ToString() + "&idVehiculo=" + Request["idVehiculo"].ToString(), false);                
                    break;
            }
        }

        // -----------------------------------------------------------------------------------------------------------------

        // ,nota: Cada vez que se carga una fila en el grid se ejecuta el método "gvLista_RowDataBound"

        protected void gvLista_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                ImageButton CmdModificar = (ImageButton)e.Row.Cells[0].Controls[1];
                CmdModificar.CommandArgument = this.gvLista.DataKeys[e.Row.RowIndex].Value.ToString();
                CmdModificar.CommandName = "Modificar";
                CmdModificar.ToolTip = "Modificar Registro";
            }            
        }

        // -----------------------------------------------------------------------------------------------------------------

        protected void IBVolver_Click(object sender, EventArgs e)
        {
            string url = "VehiculoPMP.aspx?idVehiculoPMP=" + Request["idVehiculoPMP"].ToString() + "&idVehiculo=" + Request["idVehiculo"].ToString();
            Response.Redirect(url, false);
        }

        // -----------------------------------------------------------------------------------------------------------------

        protected void lnkBtnNuevoPMPRealizado_Click(object sender, EventArgs e)
        {
            string url = "VehiculoPMPHistoricoEdit.aspx?idHistoricoVehiculoPMP=0" + "&idVehiculoPMP=" + Request["idVehiculoPMP"].ToString() + "&idVehiculo=" + Request["idVehiculo"].ToString();
            Response.Redirect(url, false);
        }

        // -----------------------------------------------------------------------------------------------------------------

        protected void gvLista_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            this.gvLista.PageIndex = e.NewPageIndex;
            CargarLista();
        }

        // -----------------------------------------------------------------------------------------------------------------
    }
}