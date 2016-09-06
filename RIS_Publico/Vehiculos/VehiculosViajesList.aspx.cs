using System;
using System.Data;
using System.IO;
using System.Web.UI;
using System.Web.UI.WebControls;
using CrystalDecisions.Web;
using DALAutomotores;

namespace Web.Vehiculos
{
    public partial class VehiculosViajesList : System.Web.UI.Page
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
                    int idVehiculo = SubSonic.Sugar.Web.QueryString<int>("idVehiculo");

                    MostrarDatos(idVehiculo);
                    CargarLista();
                }
            }
        }

        // -----------------------------------------------------------------------------------------------------------

        private void MostrarDatos(int idVehiculo)
        {
            AutVehiculo oVehiculo = new AutVehiculo(idVehiculo);

            lblDatosVehiculo.Text = "Movimientos del vehículo Dominio: " + oVehiculo.Dominio;
        }

        // -----------------------------------------------------------------------------------------------------------

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)  // Verifica si ingresa un filtro de búsqueda            
                CargarLista();
        }

        // -----------------------------------------------------------------------------------------------------------------

        protected void lnkBtnNuevoViaje_Click(object sender, EventArgs e)
        {
            string url = "VehiculosViajesEdit.aspx?idVehiculo=" + Request["idVehiculo"].ToString() + "&idViaje=0";
            Response.Redirect(url, false);
        }

        // -----------------------------------------------------------------------------------------------------------------

        private void CargarLista()
        {
            int idVehiculo = SubSonic.Sugar.Web.QueryString<int>("idVehiculo");

            gvLista.DataSource = SPs.AutListViajes(idVehiculo, txtFechaDesde.Text, txtFechaHasta.Text).GetDataSet().Tables[0];

            if (gvLista.DataSource != null)
            {
                gvLista.DataBind();
            }
        }

        // -----------------------------------------------------------------------------------------------------------------

        protected void gvLista_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int idVehiculo = SubSonic.Sugar.Web.QueryString<int>("idVehiculo");

            switch (e.CommandName)
            {
                case "Modificar":
                    Response.Redirect("VehiculosViajesEdit.aspx?idViaje=" + e.CommandArgument + "&idVehiculo=" + idVehiculo.ToString(), false);
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
                CmdModificar.ToolTip = "Modificar movimiento";
            }
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
