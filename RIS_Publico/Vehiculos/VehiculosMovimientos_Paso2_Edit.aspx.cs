using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using DALAutomotores;

namespace Web.Vehiculos
{
    public partial class VehiculosMovimientos_Paso2_Edit : System.Web.UI.Page
    {
        // -----------------------------------------------------------------------------------------------------------

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Session["idUsuario"] != null)
                {
                    int idVehiculo = int.Parse(Request["idVehiculo"].ToString());
                    MostrarDatos(idVehiculo);
                    CargarLista();

                    int idMovimiento = int.Parse(Request["idMovimiento"].ToString());
                    cargarCombo(idMovimiento);
                }
            }
        }

        // -----------------------------------------------------------------------------------------------------------

        private void cargarCombo(int idMovimiento)
        {
            ddlItemMovimiento.DataSource = SPs.AutCargarComboItemsMovimientosDesdeMovimientos(idMovimiento.ToString()).GetDataSet().Tables[0];
            ddlItemMovimiento.DataBind();
        }

        // -----------------------------------------------------------------------------------------------------------

        private void MostrarDatos(int idVehiculo)
        {
            AutVehiculo oVehiculo = new AutVehiculo(idVehiculo);
            lblDatosVehiculo.Text = "Paso 2: Items de Novedades del vehículo Dominio: " + oVehiculo.Dominio;
        }

        // -----------------------------------------------------------------------------------------------------------------

        private void CargarLista()
        {
            int idMovimiento = int.Parse(Request["idMovimiento"].ToString());

            gvLista.DataSource = SPs.AutListUnMovimientoConSusItems(idMovimiento).GetDataSet().Tables[0];

            if (gvLista.DataSource != null)
            {
                gvLista.DataBind();
            }
        }

        // -----------------------------------------------------------------------------------------------------------------

        protected void gvLista_RowCommand(object sender, GridViewCommandEventArgs e)
        {

            //,nota: El método "Delete" es un método de clase.

            switch (e.CommandName)
            {
                case "Eliminar":
                    AutMovimientoItemMovimiento.Delete(e.CommandArgument);
                    break;
            }

            // Refresh de los combos (en particular me interesa el combo de los Items de Movimiento)
            int idMovimiento = int.Parse(Request["idMovimiento"].ToString());
            cargarCombo(idMovimiento);

            // Refresh de la lista
            CargarLista();
        }

        // -----------------------------------------------------------------------------------------------------------------

        // ,nota: Cada vez que se carga una fila en el grid se ejecuta el método "gvLista_RowDataBound"

        protected void gvLista_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                ImageButton CmdEliminar = (ImageButton)e.Row.Cells[0].Controls[1];
                CmdEliminar.CommandArgument = this.gvLista.DataKeys[e.Row.RowIndex].Value.ToString();
                CmdEliminar.CommandName = "Eliminar";
                CmdEliminar.ToolTip = "Eliminar Items";
            }
        }

        // -----------------------------------------------------------------------------------------------------------------

        protected void IBVolver_Click(object sender, EventArgs e)
        {
            string url = "VehiculosMovimientos_Paso1_Edit.aspx?idVehiculo=" + Request["idVehiculo"].ToString() + "&idMovimiento=" + Request["idMovimiento"].ToString();
            Response.Redirect(url, false);
        }

        // -----------------------------------------------------------------------------------------------------------------

        protected void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                string url = "VehiculosMovimientosList.aspx?idVehiculo=" + Request["idVehiculo"].ToString();
                Response.Redirect(url, false);
            }
        }

        // -----------------------------------------------------------------------------------------------------------

        protected void btnAgregarItemMovimiento_Click(object sender, EventArgs e)
        {
            AutMovimientoItemMovimiento oMovimientoItemMovimiento = new AutMovimientoItemMovimiento();

            int idMovimiento = int.Parse(Request["idMovimiento"].ToString());

            if (ddlItemMovimiento.SelectedValue != "") // Para que no dé error...
            {
                oMovimientoItemMovimiento.IdMovimiento = idMovimiento;
                oMovimientoItemMovimiento.IdItemMovimiento = int.Parse(ddlItemMovimiento.SelectedValue.ToString());
                oMovimientoItemMovimiento.Save();

                // Refresh de los combos (en particular me interesa el combo de los Items de Movimiento)                
                cargarCombo(idMovimiento);

                // Refresh de la lista
                CargarLista();
            }
        }

        // -----------------------------------------------------------------------------------------------------------
    }
}

