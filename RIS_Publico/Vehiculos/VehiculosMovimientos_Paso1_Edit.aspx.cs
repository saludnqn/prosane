using System;
using System.Data;
using System.IO;
using System.Web.UI;
using System.Web.UI.WebControls;
using DALAutomotores;

namespace Web.Vehiculos
{
    public partial class VehiculosMovimientos_Paso1_Edit : System.Web.UI.Page
    {
        // -----------------------------------------------------------------------------------------------------------

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                cargarCombos();

                if (Session["idUsuario"] != null)
                {
                    int idVehiculo = int.Parse(Request["idVehiculo"].ToString());

                    MostrarDatos(idVehiculo);
                }
            }
        }

        // -----------------------------------------------------------------------------------------------------------

        private void cargarCombos()
        {
            ddlTipoMovimiento.DataSource = AutTipoMovimiento.FetchAll();
            ddlTipoMovimiento.DataBind();
            
            ddlProveedor.DataSource = SPs.AutCargarComboProveedoresOrdenado().GetDataSet().Tables[0];            
            ddlProveedor.DataBind();
            ddlProveedor.Items.Insert(0, new ListItem("<Seleccionar>", "0"));
        }

        // -----------------------------------------------------------------------------------------------------------

        private void MostrarDatos(int idVehiculo)
        {
            AutVehiculo oVehiculo = new AutVehiculo(idVehiculo);
            lblDatosVehiculo.Text = "Paso 1: Items de Novedades del vehículo Dominio: " + oVehiculo.Dominio;

            int idMovimiento = int.Parse(Request["idMovimiento"].ToString());
            AutMovimiento oMovimiento = new AutMovimiento(idMovimiento);

            if (oMovimiento.FechaHoraRealizacion.ToShortDateString() == "01/01/1900")
            {
                txtFechaRealizacion.Text = "";
            }
            else 
            {
                txtFechaRealizacion.Text = oMovimiento.FechaHoraRealizacion.ToShortDateString();
            }
            
            ddlTipoMovimiento.Text = oMovimiento.IdTipoMovimiento.ToString();
            ddlProveedor.Text = oMovimiento.IdProveedor.ToString();
            txtImporte.Text = oMovimiento.Importe.ToString();
            txtDescripcion.Text = oMovimiento.Descripcion;
        }

        // -----------------------------------------------------------------------------------------------------------------

        protected void IBVolver_Click(object sender, EventArgs e)
        {
            string url = "VehiculosMovimientosList.aspx?idVehiculo=" + Request["idVehiculo"].ToString();
            Response.Redirect(url, false);
        }

        // -----------------------------------------------------------------------------------------------------------------

        protected void btnGuardarYPaso2_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                int idMovimiento = int.Parse(Request["idMovimiento"].ToString());

                AutMovimiento oMovimiento = new AutMovimiento(idMovimiento);

                oMovimiento.FechaHoraAltaRegistro = DateTime.Now;
                oMovimiento.FechaHoraRealizacion = DateTime.Parse(txtFechaRealizacion.Text);
                oMovimiento.IdTipoMovimiento = int.Parse(ddlTipoMovimiento.SelectedValue);
                oMovimiento.IdProveedor = int.Parse(ddlProveedor.SelectedValue.ToString());
                oMovimiento.Importe = int.Parse(txtImporte.Text);
                oMovimiento.Descripcion = txtDescripcion.Text.ToString();
                oMovimiento.IdVehiculo = int.Parse(Request["idVehiculo"].ToString());

                oMovimiento.IdUsuarioRegistro = int.Parse(Session["idUsuario"].ToString());
                oMovimiento.FechaRegistro = DateTime.Now;

                oMovimiento.Save();

                // Voy al Paso 2
                string url = "VehiculosMovimientos_Paso2_Edit.aspx?idVehiculo=" + oMovimiento.IdVehiculo.ToString() + "&idMovimiento=" + oMovimiento.IdMovimiento.ToString();
                Response.Redirect(url, false);
            }
        }

        // -----------------------------------------------------------------------------------------------------------
    }
}
