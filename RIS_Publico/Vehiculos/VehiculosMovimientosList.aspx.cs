using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using DALAutomotores;

namespace Web.Vehiculos
{
    public partial class VehiculoMovimientoList : System.Web.UI.Page
    {
        // -----------------------------------------------------------------------------------------------------------------

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                cargarCombos();

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

            lblDatosVehiculo.Text = "Novedades del vehículo Dominio: " + oVehiculo.Dominio;
        }

        // -----------------------------------------------------------------------------------------------------------------

        private void cargarCombos()
        {
            ddlTipoMovimiento.DataSource = AutTipoMovimiento.FetchAll();
                //SPs.AutCargarComboItemMovimientoOrdenado().GetDataSet().Tables[0];
            ddlTipoMovimiento.DataBind();
            ddlTipoMovimiento.Items.Insert(0, new ListItem("Todos", "0"));

            ddlProveedor.DataSource = SPs.AutCargarComboProveedoresOrdenado().GetDataSet().Tables[0];
            ddlProveedor.DataBind();
            ddlProveedor.Items.Insert(0, new ListItem("Todos", "0"));
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
            // Esta sentencia tiene la inteligencia como para tomar el parámetro quer paso en la url.
            // Si no paso un parámetro devuelve 0, caso contrario devuelve el ID que paso como parámetro.                    
            int idVehiculo = SubSonic.Sugar.Web.QueryString<int>("idVehiculo");

            gvLista.DataSource = SPs.AutListMovimientosVehiculo(idVehiculo.ToString(), txtFechaDesde.Text, txtFechaHasta.Text, ddlTipoMovimiento.SelectedValue.ToString(), ddlProveedor.SelectedValue.ToString()).GetDataSet().Tables[0];            

            if (gvLista.DataSource != null)
            {
                gvLista.DataBind();
            }
        }

        // -----------------------------------------------------------------------------------------------------------------

        protected void lnkBtnNuevoMovimiento_Click(object sender, EventArgs e)
        {
            int idVehiculo = SubSonic.Sugar.Web.QueryString<int>("idVehiculo");

            string url = "VehiculosMovimientos_Paso1_Edit.aspx?idVehiculo=" + idVehiculo.ToString() + "&idMovimiento=0";
            Response.Redirect(url, false);
        }

        // -----------------------------------------------------------------------------------------------------------------

        protected void gvLista_RowCommand(object sender, GridViewCommandEventArgs e)
        {

            int id = SubSonic.Sugar.Web.QueryString<int>("idVehiculo");

            switch (e.CommandName)
            {
                case "Modificar": Response.Redirect("VehiculosMovimientos_Paso1_Edit.aspx?idMovimiento=" + e.CommandArgument + "&idVehiculo=" + id.ToString(), false);
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
