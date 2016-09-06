using System;
using System.Data;
using System.Web.UI;
using DALAutomotores;
u

namespace Web.Vehiculos
{
    public partial class VehiculosEdit : System.Web.UI.Page
    {
        // -----------------------------------------------------------------------------------------------------------

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                TablaErrores.Visible = false;
                cargarCombos();

                if (Request["idVehiculo"] != null) // modificación del vehículo
                {
                    inputFechaLecturaOdometro.Disabled = true;
                    panelFechaUltimaLectura.Visible = false;
                    lblFechaUltimaLectura.Visible = true;
                }
                else
                {
                    inputFechaLecturaOdometro.Disabled = false;
                    inputFechaLecturaOdometro.Value = DateTime.Now.ToShortDateString();
                    panelFechaUltimaLectura.Visible = true;
                    lblFechaUltimaLectura.Visible = false;
                }

                if (Session["idUsuario"] != null)
                {
                    // Esta sentencia tiene la inteligencia como para tomar el parámetro quer paso en la url.
                    // Si no paso un parámetro devuelve 0, caso contrario devuelve el ID que paso como parámetro.                    
                    int idVehiculo = SubSonic.Sugar.Web.QueryString<int>("idVehiculo");

                    MostrarDatos(idVehiculo);
                }
            }
        }

        // -----------------------------------------------------------------------------------------------------------

        private void cargarCombos()
        {
            // -------------------------------------------------------------------------------

            ddlTipoVehiculo.DataSource = AutTipoVehiculo.FetchAll();
            ddlTipoVehiculo.DataBind();

            // -------------------------------------------------------------------------------

            ddlModelo.DataSource = SPs.AutCargarComboModelosOrdenado().GetDataSet().Tables[0];
            ddlModelo.DataBind();

            // -------------------------------------------------------------------------------

            SysUsuario oUsuario = new SysUsuario(int.Parse(Session["idUsuario"].ToString()));
            int entidad = oUsuario.IdEfector;
            AutEntidad oEntidad = new AutEntidad(entidad);

            // 1 Centro de Salud
            // 2 Hospital
            // 3 Puesto Sanitario
            // 4 Zona Sanitaria
            // 5 SubSecretaria de Salud
            // 6 Otro

            switch (oEntidad.IdTipoEntidad)
            {
                case 1:
                    ddlEfector.Enabled = false;
                    break;
                case 2:
                    ddlEfector.DataSource = SPs.AutCargarComboEntidadesOrdenadoParaHospital(oEntidad.IdEntidad).GetDataSet().Tables[0];
                    ddlEfector.DataBind();
                    break;
                case 3:
                    ddlEfector.Enabled = false;
                    break;
                case 4:
                    ddlEfector.DataSource = SPs.AutCargarComboEntidadesOrdenadoParaZona(oEntidad.IdZona).GetDataSet().Tables[0];
                    ddlEfector.DataBind();
                    break;
                case 5:
                    ddlEfector.DataSource = SPs.AutCargarComboEntidadesOrdenadoParaSubsecretaria().GetDataSet().Tables[0];
                    ddlEfector.DataBind();
                    break;
                case 6:
                    // ,nota: No considero este caso, ya que no existe un usuario en (Sys_Usuarios) que tenga este valor (6).
                    //        El valor es exclusivo de este sistema.
                    break;
            }

            // -------------------------------------------------------------------------------
        }

        // -----------------------------------------------------------------------------------------------------------

        private void MostrarDatos(int idVehiculo)
        {

            AutVehiculo oVehiculo = new AutVehiculo(idVehiculo);

            if (Request["idVehiculo"] != null) // Modificación del vehículo
            {
                // ,nota: La idea es que cuando el usuario edita el registro, no debe poder modificar el odómetro y la fecha
                //        de actualización. Estos valores se modifican en forma automática, con cada viaje.
                //        Solo son editables cuando se crea el vehículo.

                txtMatricula.Text = oVehiculo.Matricula;
                txtDominio.Text = oVehiculo.Dominio;
                txtAnio.Text = oVehiculo.Anio.ToString();
                ddlTipoVehiculo.SelectedValue = oVehiculo.IdTipoVehiculo.ToString();
                ddlTraccion.SelectedValue = oVehiculo.Traccion;

                lblOdometro.Text = oVehiculo.OdometroActual.ToString();
                txtOdometroActual.Visible = false;
                lblFechaUltimaLectura.Text = oVehiculo.FechaLecturaOdometro.ToShortDateString();
                inputFechaLecturaOdometro.Visible = false;                

                ddlModelo.Text = oVehiculo.IdModelo.ToString();

                ddlEfector.SelectedValue = oVehiculo.AutEntidad.IdEntidad.ToString();

                txtNumeroMotor.Text = oVehiculo.NumeroMotor;
                txtNumeroChasis.Text = oVehiculo.NumeroChasis;

                ddlTieneRadio.Text = oVehiculo.TieneRadio;
                ddlTienePermisoRadio.Text = oVehiculo.TienePermisoRadio;
            }
            else
            {                
                lblOdometro.Visible = false;
                txtOdometroActual.Text = oVehiculo.OdometroActual.ToString();
                lblFechaUltimaLectura.Visible = false;
                inputFechaLecturaOdometro.Value = DateTime.Now.ToShortDateString();                
            }
        }

        // -----------------------------------------------------------------------------------------------------------

        private bool hayError()
        {
            bool hayError = false;
            lblMensaje.Text = "";
            TablaErrores.Visible = false;

            // ------------------------------------------------------------------------
            // Verifico que el año no sea vacío
            // ------------------------------------------------------------------------

            if (txtAnio.Text == "") 
            {
                lblMensaje.Text += "El Año no puede ser vacío. <br/>";
                hayError = true;
                TablaErrores.Visible = true;
            }

            // ------------------------------------------------------------------------
            // Verifico que no exista el nro. de Matrícula en otro registro en la base.
            // ------------------------------------------------------------------------
            if (txtMatricula.Text != "")
            {
                SubSonic.Select pMatricula = new SubSonic.Select();
                pMatricula.From(AutVehiculo.Schema);
                pMatricula.Where(AutVehiculo.Columns.Matricula).IsEqualTo(txtMatricula.Text);

                DataTable dtMatricula = pMatricula.ExecuteDataSet().Tables[0];

                if ((Request["idVehiculo"] == null) && (dtMatricula.Rows.Count > 0))
                {
                    lblMensaje.Text += "El Número de Matrícula ya esta asignado a un vehículo. <br/>";
                    hayError = true;
                    TablaErrores.Visible = true;
                }
            }

            // --------------------------------------------------------------
            // Verifico que no exista el Dominio en otro registro en la base.
            // --------------------------------------------------------------
            if (txtDominio.Text != "")
            {
                SubSonic.Select pDominio = new SubSonic.Select();
                pDominio.From(AutVehiculo.Schema);
                pDominio.Where(AutVehiculo.Columns.Dominio).IsEqualTo(txtDominio.Text);

                DataTable dtDominio = pDominio.ExecuteDataSet().Tables[0];

                if ((Request["idVehiculo"] == null) && (dtDominio.Rows.Count > 0))
                {
                    lblMensaje.Text += "El Dominio ya esta asignado a un vehículo. <br/>";
                    hayError = true;
                    TablaErrores.Visible = true;
                }
            }
            else
            {
                lblMensaje.Text += "El Dominio no puede ser vacío. <br/>";
                hayError = true;
                TablaErrores.Visible = true;
            }

            // ----------------------------------------------------------------
            // Fecha del odómetro
            // ----------------------------------------------------------------
            if (Request["idVehiculo"] == null) // Nuevo Vehículo
            {
                if (inputFechaLecturaOdometro.Value == "")
                {
                    lblMensaje.Text += "El campo 'Fecha de la última lectura' del odómetro no puede ser vacío. <br/>";
                    hayError = true;
                    TablaErrores.Visible = true;
                }
            }

            // ----------------------------------------------------------------
            // Verifico que el Nro. de Motor y el Nro. de Chasis no sean vacíos
            // ----------------------------------------------------------------
            if (txtNumeroMotor.Text == "")
            {
                lblMensaje.Text += "El campo 'Nro. de Motor' no puede ser vacío. <br/>";
                hayError = true;
                TablaErrores.Visible = true;
            }

            if (txtNumeroChasis.Text == "")
            {
                lblMensaje.Text += "El campo 'Nro. de Chasis' no puede ser vacío. <br/>";
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
                int idVehiculo = SubSonic.Sugar.Web.QueryString<int>("idVehiculo");

                AutVehiculo oVehiculo = new AutVehiculo(idVehiculo);

                oVehiculo.Matricula = txtMatricula.Text;
                oVehiculo.Dominio = txtDominio.Text;
                oVehiculo.Anio = int.Parse(txtAnio.Text);
                oVehiculo.IdTipoVehiculo = int.Parse(ddlTipoVehiculo.SelectedValue);
                oVehiculo.Traccion = ddlTraccion.SelectedValue;

                if (txtOdometroActual.Text != "")
                    oVehiculo.OdometroActual = int.Parse(txtOdometroActual.Text);

                if (inputFechaLecturaOdometro.Value != "")
                    oVehiculo.FechaLecturaOdometro = DateTime.Parse(inputFechaLecturaOdometro.Value);

                oVehiculo.IdModelo = int.Parse(ddlModelo.SelectedValue);

                // --------------------------------------------------------------------------------------------------------------
                // ,nota: Cuando el tipo de usuario es un centro de salud o puesto sanitario lo asigno como efector del vehículo.
                //
                // 1 Centro de Salud
                // 2 Hospital
                // 3 Puesto Sanitario
                // 4 Zona Sanitaria
                // 5 SubSecretaria de Salud
                // 6 Otro

                SysUsuario oUsuario = new SysUsuario(int.Parse(Session["idUsuario"].ToString()));
                int entidad = oUsuario.IdEfector;
                AutEntidad oEntidad = new AutEntidad(entidad);

                if ((oEntidad.IdTipoEntidad == 1) || (oEntidad.IdTipoEntidad == 3))
                {
                    oVehiculo.IdEntidad = entidad;
                }
                else 
                {
                    oVehiculo.IdEntidad = int.Parse(ddlEfector.SelectedValue);
                }

                // --------------------------------------------------------------------------------------------------------------

                oVehiculo.NumeroMotor = txtNumeroMotor.Text;
                oVehiculo.NumeroChasis = txtNumeroChasis.Text;

                oVehiculo.TieneRadio = ddlTieneRadio.SelectedValue;
                oVehiculo.TienePermisoRadio = ddlTienePermisoRadio.SelectedValue;

                oVehiculo.Save();

                // Vuelvo a la pantalla de búsqueda
                Response.Redirect("VehiculosList.aspx", false);

            }
        }

        // -----------------------------------------------------------------------------------------------------------

    }
}


