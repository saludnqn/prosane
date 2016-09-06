using System;
using System.Data;
using System.Web.UI;
using DALAutomotores;
using System.Web.UI.WebControls;

namespace Web.Vehiculos
{
    public partial class VehiculoPMPEdit : System.Web.UI.Page
    {
        // -----------------------------------------------------------------------------------------------------------

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Session["idUsuario"] != null)
                {
                    int idVehiculo = int.Parse(Request["idVehiculo"].ToString());
                    mostrarDatos(idVehiculo);
                    cargarCombo(idVehiculo);
                    cargarLista();                    

                }
            }
        }

        // -----------------------------------------------------------------------------------------------------------

        private void cargarCombo(int idVehiculo)
        {            
            ddlPMP.DataSource = SPs.AutCargarComboPmpDesdeVehiculo(idVehiculo).GetDataSet().Tables[0];
            ddlPMP.DataBind();
        }

        // -----------------------------------------------------------------------------------------------------------

        private void mostrarDatos(int idVehiculo)
        {
            AutVehiculo oVehiculo = new AutVehiculo(idVehiculo);
            lblDatosVehiculo.Text = "PMP del vehículo dominio: " + oVehiculo.Dominio;
        }

        // -----------------------------------------------------------------------------------------------------------

        private void cargarLista()
        {
            int idVehiculo = int.Parse(Request["idVehiculo"].ToString());

            gvLista.DataSource = SPs.AutListUnVehiculoConSusPMP(idVehiculo).GetDataSet().Tables[0];

            if (gvLista.DataSource != null)
            {
                gvLista.DataBind();
            }
        }

        // -----------------------------------------------------------------------------------------------------------------

        protected void gvLista_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            // *********************************************************************************
            // *********************************************************************************
            // ,nota: Por el momento deshabilito la posibilidad de borrar, pero hay que tener en cuneta
            //        que por un tema de integridad referencial, si el registro tiene otros registros
            //        históricos asociados no se puede borrar, dá error. Lo correcto es borarlos primero
            //        y luego borrar el registro. Necesito hacer otras cosas mas importantes en el sistema
            //        ,por tal motivo lo relego.
            // *********************************************************************************
            // *********************************************************************************

            ////,nota: El método "Delete" es un método de clase.

            switch (e.CommandName)
            {
                //    case "Eliminar":
                //        AutVehiculoPmp.Delete(e.CommandArgument);                    
                //        break;
                case "Historial":
                    Response.Redirect("VehiculoPMPHistoricoList.aspx?idVehiculoPMP=" + e.CommandArgument + "&idVehiculo=" + Request["idVehiculo"].ToString(), false);
                    break;
            }

            //// Refresh de los combos (en particular me interesa el combo de los Items de Movimiento)            
            //int idVehiculo = int.Parse(Request["idVehiculo"].ToString());
            //cargarCombo(idVehiculo);

            //// Refresh de la lista
            //cargarLista();
        }

        // -----------------------------------------------------------------------------------------------------------------

        // ,nota: Cada vez que se carga una fila en el grid se ejecuta el método "gvLista_RowDataBound"

        protected void gvLista_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                ImageButton CmdHistorial = (ImageButton)e.Row.Cells[5].Controls[1];
                CmdHistorial.CommandArgument = this.gvLista.DataKeys[e.Row.RowIndex].Value.ToString();
                CmdHistorial.CommandName = "Historial";
                CmdHistorial.ToolTip = "Historial";
            }
        }

        // -----------------------------------------------------------------------------------------------------------------

        protected void IBVolver_Click(object sender, EventArgs e)
        {
            string url = "VehiculosList.aspx";
            Response.Redirect(url, false);
        }

        // -----------------------------------------------------------------------------------------------------------------

        protected void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                string url = "VehiculosList.aspx";
                Response.Redirect(url, false);
            }
        }

        // -----------------------------------------------------------------------------------------------------------------

        protected void btnAgregarItemMovimiento_Click(object sender, EventArgs e)
        {
            AutVehiculoPmp oVehiculoPMP = new AutVehiculoPmp();
            
            int idVehiculo = int.Parse(Request["idVehiculo"].ToString());

            if (ddlPMP.SelectedValue != "") // Para que no dé error...
            {
                oVehiculoPMP.IdVehiculo = idVehiculo;
                oVehiculoPMP.IdPMP = int.Parse(ddlPMP.SelectedValue.ToString());
                oVehiculoPMP.Save();

                // Refresh de los combos (en particular me interesa el combo de los Items de Movimiento)                
                cargarCombo(idVehiculo);

                // Refresh de la lista
                cargarLista();
            }
        }

        // -----------------------------------------------------------------------------------------------------------
    }
}

