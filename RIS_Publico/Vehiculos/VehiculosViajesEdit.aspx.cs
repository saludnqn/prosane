using System;
using System.Web.UI;
using DALAutomotores;
namespace Web.Vehiculos
{
    public partial class VehiculosViajesEdit : System.Web.UI.Page
    {
        // -----------------------------------------------------------------------------------------------------------

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                TablaErrores.Visible = false;
                cargarCombos();

                if (Session["idUsuario"] != null)
                {

                    AutVehiculo oVehiculo = new AutVehiculo(int.Parse(Request["idVehiculo"].ToString()));
                    lblDatosVehiculo.Text = "Movimiento del vehículo Dominio: " + oVehiculo.Dominio;
                    lblOdometroActual.Text = oVehiculo.OdometroActual.ToString();
                    
                    int idViaje = SubSonic.Sugar.Web.QueryString<int>("idViaje");

                    if (Request["idViaje"] != "0") // Editar viaje
                    {
                        MostrarDatos(idViaje);
                        txtOdometroFin.Enabled = false;
                    }
                    else // Nuevo viaje
                    {
                        txtFechaInicio.Value = DateTime.Now.ToShortDateString();
                        txtFechaFin.Value = DateTime.Now.ToShortDateString();
                    }                    
                }
            }
        }

        // -----------------------------------------------------------------------------------------------------------

        private void cargarCombos()
        {
            ddlOrigen.DataSource = SPs.AutCargarComboOrigenDestinoOrdenado().GetDataSet().Tables[0];
            ddlOrigen.DataBind();

            ddlDestino.DataSource = SPs.AutCargarComboOrigenDestinoOrdenado().GetDataSet().Tables[0];
            ddlDestino.DataBind();

            ddlChofer.DataSource = SPs.AutCargarComboChoferOrdenado().GetDataSet().Tables[0];
            ddlChofer.DataBind();
        }

        // -----------------------------------------------------------------------------------------------------------

        private void MostrarDatos(int idViaje)
        {
            AutViaje oViaje = new AutViaje(idViaje);

            txtFechaInicio.Value = oViaje.FechaInicio.ToShortDateString();
            txtHoraInicio.Value = oViaje.HoraInicio;

            txtFechaFin.Value = oViaje.FechaFin.ToShortDateString();
            txtHoraFin.Value = oViaje.HoraFin;           
            
            txtOdometroFin.Text = oViaje.OdometroFin.ToString();

            if (Request["idViaje"].ToString() != "0")
            {
                ddlOrigen.SelectedValue = oViaje.Origen.ToString();
                ddlDestino.SelectedValue = oViaje.Destino.ToString();

                ddlChofer.SelectedValue = oViaje.IdChofer.ToString();

                txtObservaciones.Text = oViaje.Observaciones;
            }
        }

        // -----------------------------------------------------------------------------------------------------------------

        protected void IBVolver_Click(object sender, EventArgs e)
        {
            string url = "VehiculosViajesList.aspx?idVehiculo=" + Request["idVehiculo"].ToString();
            Response.Redirect(url, false);
        }

        // -----------------------------------------------------------------------------------------------------------

        private bool hayError()
        {
            bool hayError = false;
            lblMensaje.Text = "";
            TablaErrores.Visible = false;

            // ------------------------------------------------------------------------
            // Controlo que algunos campos no sean vacíos
            // ------------------------------------------------------------------------

            if ((txtFechaInicio.Value == "") || (txtHoraInicio.Value == "") || (txtFechaFin.Value == "") || (txtHoraFin.Value == "") || (txtOdometroFin.Text == ""))
            {
                lblMensaje.Text += "Debe completar todos los campos. <br/>";
                hayError = true;
                TablaErrores.Visible = true;            
            }

            // ------------------------------------------------------------------------
            // Comparo las fechas
            // ------------------------------------------------------------------------

            if ((txtFechaInicio.Value != "") && (txtFechaFin.Value != "") && (DateTime.Parse(txtFechaFin.Value) < DateTime.Parse(txtFechaInicio.Value)))
            {
                lblMensaje.Text += "El campo 'Fecha Fin' no puede ser menor que el campo 'Fecha Inicio'. <br/>";
                hayError = true;
                TablaErrores.Visible = true;
            }

            // ------------------------------------------------------------------------
            // Comparo los valores de los odómetros
            // ------------------------------------------------------------------------
            if (txtOdometroFin.Text == "") 
            {
                txtOdometroFin.Text = "0";  // Des esta forma no dá error en el "if" que está debajo.
            }

            if (int.Parse(lblOdometroActual.Text) > int.Parse(txtOdometroFin.Text))
            {
                lblMensaje.Text += "El campo 'Odómetro Actual (km.)' no puede ser mayor que el campo 'Odómetro Nuevo (km.)'. <br/>";
                hayError = true;
                TablaErrores.Visible = true;
            }

            // Respondo ...
            return hayError;
        }

        // -----------------------------------------------------------------------------------------------------------

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            if ((Page.IsValid) && (!hayError()))
            {
                int idViaje = SubSonic.Sugar.Web.QueryString<int>("idViaje");

                AutViaje oViaje = new AutViaje(idViaje);

                oViaje.FechaInicio = DateTime.Parse(txtFechaInicio.Value);
                oViaje.HoraInicio = txtHoraInicio.Value;

                oViaje.FechaFin = DateTime.Parse(txtFechaFin.Value);
                oViaje.HoraFin = txtHoraFin.Value;

                oViaje.OdometroInicio = int.Parse(lblOdometroActual.Text);
                oViaje.OdometroFin = int.Parse(txtOdometroFin.Text);

                oViaje.Origen = int.Parse(ddlOrigen.SelectedValue);
                oViaje.Destino = int.Parse(ddlDestino.SelectedValue);

                oViaje.IdChofer = int.Parse(ddlChofer.SelectedValue);
                oViaje.IdVehiculo = int.Parse(Request["idVehiculo"].ToString());

                oViaje.Observaciones = txtObservaciones.Text.Trim();

                oViaje.IdUsuarioRegistro = int.Parse(Session["idUsuario"].ToString());
                oViaje.FechaRegistro = DateTime.Now;

                oViaje.Save();

                // Incremento el odómetro del veículo respecto del valor ingresado por el usuario
                // y actualizo la fecha a hoy.
                AutVehiculo oVehiculo = new AutVehiculo(int.Parse(Request["idVehiculo"].ToString()));
                oVehiculo.OdometroActual = int.Parse(txtOdometroFin.Text);
                oVehiculo.FechaLecturaOdometro = DateTime.Now;
                oVehiculo.Save();

                // Vuelvo a la pantalla de búsqueda
                string url = "VehiculosViajesList.aspx?idVehiculo=" + oViaje.IdVehiculo.ToString();
                Response.Redirect(url, false);
            }
        }

        // -----------------------------------------------------------------------------------------------------------

    }
}
