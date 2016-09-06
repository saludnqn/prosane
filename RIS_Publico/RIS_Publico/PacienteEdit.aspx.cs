using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;
using DalSic;
using Salud.Security.SSO;
using SubSonic;
using System.Net;
using System.IO;
using System.Xml;
using System.Web.Script.Serialization;

namespace SIPS.Paciente
{
    public partial class PacienteEdit : System.Web.UI.Page
    {

        #region Atributos

        private string IdArgentina
        {
            get
            {
                return ConfigurationManager.AppSettings["idArgentina"].ToString();
            }
        }
        private string IdNeuquen
        {
            get
            {
                return ConfigurationManager.AppSettings["idNeuquen"].ToString();
            }
        }
        private string IdConfluencia
        {
            get
            {
                return ConfigurationManager.AppSettings["idConfluencia"].ToString();
            }
        }
        private string IdNqn
        {
            get
            {
                return ConfigurationManager.AppSettings["idNqn"].ToString();
            }
        }
        private int idObraSocial { get; set; }

        #endregion

        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);

            btnGuardarRem.Visible = SSOHelper.CurrentIdentity.TestPermissionByEfector("/PacienteEdit.aspx.btnGuardarRem");
            btnGuardarClasif.Visible = SSOHelper.CurrentIdentity.TestPermissionByEfector("/PacienteEdit.aspx.btnGuardarClasif");
            btnGuardarCP.Visible = SSOHelper.CurrentIdentity.TestPermissionByEfector("/PacienteEdit.aspx.btnGuardarCP");
            btnGuardarCM.Visible = SSOHelper.CurrentIdentity.TestPermissionByEfector("/PacienteEdit.aspx.btnGuardarCM");
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                string strIdHospital = SSOHelper.Configuration["idHospital"] as string;             
                if (strIdHospital != "0")
                    btnPadronPcial.Visible = true;
                else btnPadronPcial.Visible = false;

                txtNumeroDocumento.Focus();

                CargarCombos();

                int id = Convert.ToInt32(Request.QueryString["id"]);
                DalSic.SysPaciente pac = new DalSic.SysPaciente(id);

                if (!pac.IsNew)
                {
                    cargarPaciente(id);
                }
                else
                {
                    // Aqui entra si es un paciente nuevo
                    txtNumeroDocumento.Text = Request.QueryString["dni"];
                    ddlNacionalidad.SelectedValue = IdArgentina;
                    ddlNacionalidad_SelectedIndexChanged(null, null);
                    ddlProvinciaDomicilio.SelectedValue = IdNeuquen;
                    ddlProvinciaDomicilio_SelectedIndexChanged(null, null);
                    ddlDepartamento.SelectedValue = IdConfluencia;
                    ddlDepartamento_SelectedIndexChanged(null, null);
                    ddlLocalidad.SelectedValue = IdNqn;
                    ddlLocalidad_SelectedIndexChanged(null, null);
                }
            }
        }

        private void CargarCombos()
        {
            SubSonic.Select pa = new SubSonic.Select();
            pa.From(SysPai.Schema);
            List<SysPai> paises = pa.ExecuteTypedList<SysPai>();
            ddlNacionalidad.DataSource = paises;
            ddlNacionalidad.DataBind();

            ddlNacionalidadM.DataSource = paises;
            ddlNacionalidadM.DataBind();
            ddlNacionalidadM.Items.Insert(0, new ListItem("SELECCIONAR", "-1"));

            ddlNacionalidadP.DataSource = paises;
            ddlNacionalidadP.DataBind();
            ddlNacionalidadP.Items.Insert(0, new ListItem("SELECCIONAR", "-1"));

            SubSonic.Select pd = new SubSonic.Select();
            pd.From(SysProvincium.Schema);
            pd.Where(SysProvincium.Columns.IdPais).IsEqualTo(IdArgentina);
            ddlProvinciaDomicilio.DataSource = pd.ExecuteTypedList<SysProvincium>();
            ddlProvinciaDomicilio.DataBind();
            ddlProvinciaDomicilio.Items.Insert(0, new ListItem("SELECCIONAR", "-1"));

            ddlLugarNacimientoP.DataSource = pd.ExecuteTypedList<SysProvincium>();
            ddlLugarNacimientoP.DataBind();
            ddlLugarNacimientoP.Items.Insert(0, new ListItem("SELECCIONAR", "-1"));

            ddlLugarNacimientoM.DataSource = pd.ExecuteTypedList<SysProvincium>();
            ddlLugarNacimientoM.DataBind();
            ddlLugarNacimientoM.Items.Insert(0, new ListItem("SELECCIONAR", "-1"));

            SubSonic.Select e = new SubSonic.Select();
            e.From(SysEstado.Schema);
            List<SysEstado> estados = e.ExecuteTypedList<SysEstado>();
            ddlEstadoP.DataSource = estados;
            ddlEstadoP.DataBind();

            SubSonic.Select m = new SubSonic.Select();
            m.From(SysMotivoNI.Schema);
            m.InnerJoin(SysRelEstadoMotivoNI.Schema);
            m.Where(SysRelEstadoMotivoNI.IdEstadoColumn).IsEqualTo(ddlEstadoP.SelectedValue);
            ddlMotivoNI.DataSource = m.ExecuteTypedList<SysMotivoNI>();
            ddlMotivoNI.DataBind();
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(Request.QueryString["id"]);
            if (id == 0) id = int.Parse(hfIdPaciente.Value);

            validate_me(null, new ServerValidateEventArgs("", true));
            //switch (ddlEstadoP.SelectedValue)
            //{
            //    case "1":
            //        Page.Validate("I");
            //        break;
            //    case "2":
            //        Page.Validate("T");
            //        break;
            //    case "3":
            //        Page.Validate("V");
            //        break;
            //}

            // if (ddlMotivoNI.SelectedValue == "1") Page.Validate("TBB");
            if (Page.IsValid)
            {

                DalSic.SysPaciente pac = new DalSic.SysPaciente(id);

                pac.FechaAlta = DateTime.Now;
                pac.Apellido = txtApellido.Text.ToUpper();
                pac.Nombre = txtNombre.Text.ToUpper();
                if (id == 0) pac.FechaAlta = DateTime.Now;
                pac.IdSexo = Convert.ToInt32(ddlSexo.SelectedValue);
                //valido que la fecha no se mayor a la actual
                DateTime fec = Convert.ToDateTime("01/01/1900");
                DateTime.TryParse(txtFechaNac.Text, out fec);
                if ((fec <= DateTime.Now) && (txtFechaNac.Text != ""))
                {
                    pac.FechaNacimiento = Convert.ToDateTime(txtFechaNac.Text);
                }
                //nacionalidad
                pac.IdPais = Convert.ToInt32(ddlNacionalidad.SelectedValue);
                //lugar de nacimiento
                pac.IdProvincia = Convert.ToInt32(ddlProvincia.SelectedValue);
                pac.Calle = txtCalle.Text.ToUpper();
                if (!string.IsNullOrEmpty(txtNumero.Text))
                {
                    pac.Numero = Convert.ToInt32(txtNumero.Text);
                }
                else
                {
                    pac.Numero = 0;
                }
                pac.Edificio = txtEdificio.Text.ToUpper();
                pac.Piso = txtPiso.Text.ToUpper();
                pac.Departamento = txtDepartamento.Text.ToUpper();
                pac.Manzana = txtManzana.Text.ToUpper();
                pac.IdProvinciaDomicilio = Convert.ToInt32(ddlProvinciaDomicilio.SelectedValue);
                pac.IdDepartamento = Convert.ToInt32(ddlDepartamento.SelectedValue);
                if (ddlLocalidad.SelectedValue != "") pac.IdLocalidad = Convert.ToInt32(ddlLocalidad.SelectedValue);
                else pac.IdLocalidad = -1;
                if (ddlBarrio.SelectedValue != "") pac.IdBarrio = Convert.ToInt32(ddlBarrio.SelectedValue);
                else pac.IdBarrio = -1;
                //modifico permitiendo el ingreso de Otro Barrio
                pac.OtroBarrio = txtOBarrio.Text.ToUpper();
                pac.Referencia = txtReferencia.Text.ToUpper();

                //if (!string.IsNullOrEmpty(txtContacto.Text))
                    pac.InformacionContacto = txtContacto.Text.ToUpper();

                pac.TelefonoFijo = txtTFijo.Text;
                pac.TelefonoCelular = txtTCelular.Text;
                pac.Email = txtEmail.Text;

                if (txtDefuncion.Text != "")
                {
                    pac.FechaDefuncion = Convert.ToDateTime(txtDefuncion.Text);
                }
                //si es un nuevo Paciente guardamos por defecto el estadoPaciente=Activo y desabilito el combo
                switch (rbUrbano.SelectedValue)
                {
                    case "0": pac.EsUrbano = false;
                        break;
                    case "1": pac.EsUrbano = true;
                        break;
                }

                pac.Latitud = txtLatitud.Text;
                pac.Longitud = txtLongitud.Text;

                pac.Campo = txtCampo.Text.ToUpper();
                pac.Camino = txtCamino.Text.ToUpper();
                pac.Lote = txtLote.Text.ToUpper();
                pac.Parcela = txtParcela.Text.ToUpper();
                pac.Activo = true;

                pac.IdUsuario = SSOHelper.CurrentIdentity.Id;
                pac.IdEfector = Convert.ToInt32(SSOHelper.CurrentIdentity.IdEfector);
                pac.FechaUltimaActualizacion = DateTime.Now;

                //Guardo los datos del Parentesco. Traigo con lblbIdParentesco el idParentesco asociado al paciente
                //datos de la madre
                SysParentesco parM = new SysParentesco(lblIdParentescoM.Text);
                if ((txtApellidoM.Text != "") && (txtNombreM.Text != ""))// & (txtNumeroM.Text != "") & (txtFNacMadre.Text != ""))
                {
                    parM.Apellido = txtApellidoM.Text.ToUpper();
                    parM.Nombre = txtNombreM.Text.ToUpper();
                    parM.TipoParentesco = "MADRE";
                    parM.IdTipoDocumento = 1;

                    if (txtNumeroM.Text!="")   parM.NumeroDocumento = Convert.ToInt32(txtNumeroM.Text); else parM.NumeroDocumento = 0;
                    if (txtFNacMadre.Text != "") parM.FechaNacimiento = Convert.ToDateTime(txtFNacMadre.Text); //else parM.FechaNacimiento = Convert.ToDateTime("01/01/1900");

                    parM.IdPais = Convert.ToInt32(ddlNacionalidadM.SelectedValue);
                    parM.IdProvincia = Convert.ToInt32(ddlLugarNacimientoM.SelectedValue);
                    parM.IdUsuario = SSOHelper.CurrentIdentity.Id;
                    //guardo la fecha actual de modificacion
                    parM.FechaModificacion = DateTime.Now;
                }
                //datos del padre
                SysParentesco parP = new SysParentesco(lblIdParentescoP.Text);
                if ((txtApellidoPadre.Text != "") & (txtNombrePadre.Text != ""))// & (txtDUPadre.Text != "") & (txtFNacPadre.Text != ""))
                {
                    parP.Apellido = txtApellidoPadre.Text.ToUpper();
                    parP.Nombre = txtNombrePadre.Text.ToUpper();
                    parP.TipoParentesco = "PADRE";
                    parP.IdTipoDocumento = 1;

                    if (!string.IsNullOrEmpty(txtDUPadre.Text))  parP.NumeroDocumento = Convert.ToInt32(txtDUPadre.Text);    else parP.NumeroDocumento = 0;
                    if (!string.IsNullOrEmpty(txtFNacPadre.Text)) parP.FechaNacimiento = Convert.ToDateTime(txtFNacPadre.Text); //else parP.FechaNacimiento = DateTime.Parse("01/01/1900");

                    parP.IdPais = Convert.ToInt32(ddlNacionalidadP.SelectedValue);
                    parP.IdProvincia = Convert.ToInt32(ddlLugarNacimientoP.SelectedValue);
                    parP.IdUsuario = SSOHelper.CurrentIdentity.Id;
                    //guardo la fecha actual de modificacion
                    parP.FechaModificacion = DateTime.Now;
                }

                // Estado 2=Temporal
                if (ddlEstadoP.SelectedValue == "2")
                {
                    //no guardo el nro extranjero                        
                    int doc = new Select("numeroDocumento")
                            .From(SysPaciente.Schema)
                            .Where(SysPaciente.Columns.IdEstado).IsEqualTo(2)
                            .GetRecordCount();
                    if (doc > 0)
                    {
                        pac.NumeroDocumento = doc + 1;
                    }
                    if (ddlMotivoNI.SelectedValue == "2")
                    {
                        lblExtranjero.Text = "Doc. Extranjero: ";
                        txtNumeroExtranjero.Visible = true;
                        pac.NumeroExtranjero = txtNumeroExtranjero.Text;
                    }
                }
                else
                {
                    if (txtNumeroDocumento.Text != "") pac.NumeroDocumento = Convert.ToInt32(txtNumeroDocumento.Text);
                }
                pac.IdEstado = Convert.ToInt32(ddlEstadoP.SelectedValue);
                pac.IdMotivoNI = Convert.ToInt32(ddlMotivoNI.SelectedValue);

                //try
                //{
                    int i_obrasocial = OSociales.getObraSocial();
                    pac.IdObraSocial = i_obrasocial;
                    pac.Save();
                    
                    
                    // guardo el id obra social en la Sys_RelPacienteObraSocial
                    if (i_obrasocial > -1)
                    {
                        // si el paciente ya tiene cargada la obra social en la relación no la vuelvo a cargar.
                        int existeOS = new SubSonic.Select()
                        .From(Schemas.SysRelPacienteObraSocial)
                        .Where(SysRelPacienteObraSocial.Columns.IdPaciente).IsEqualTo(pac.IdPaciente)
                        .And(SysRelPacienteObraSocial.Columns.IdObraSocial).IsEqualTo(i_obrasocial)
                        .GetRecordCount();

                        if (existeOS <= 0)
                        {
                            SysRelPacienteObraSocial relObraSocial = new SysRelPacienteObraSocial();

                            relObraSocial.FechaAlta = DateTime.Now;
                            relObraSocial.IdObraSocial = i_obrasocial;
                            relObraSocial.IdPaciente = pac.IdPaciente;
                            relObraSocial.NumeroAfiliado = (pac.NumeroAfiliado == null ? "" : pac.NumeroAfiliado);
                            relObraSocial.Save();
                        }
                    }

                    if ((txtApellidoM.Text != "") & (txtNombreM.Text != ""))// & (txtNumeroM.Text != "") & (txtFNacMadre.Text != ""))
                    {
                        parM.IdPaciente = pac.IdPaciente;
                        parM.Save();
                    }
                    if ((txtApellidoPadre.Text != "") & (txtNombrePadre.Text != ""))// & (txtDUPadre.Text != "") & (txtFNacPadre.Text != ""))
                    {
                        parP.IdPaciente = pac.IdPaciente;
                        parP.Save();
                    }
                    if (Request.QueryString["llamada"] == "Recupero")
                        Response.Redirect("/Recupero/OrdenPrestacion/PacienteList.aspx?PacienteRetorno=" + pac.IdPaciente.ToString() + "&idUsuario=" + Session["idUsuario"]);
                    if (Request.QueryString["llamada"] == "LaboTurno")
                        Response.Redirect("/Laboratorio/Turnos/TurnosEdit2.aspx?idPaciente=" + pac.IdPaciente.ToString() + "&Modifica=0");
                    if (Request.QueryString["llamada"] == "Consultorio")
                        Response.Redirect("../Consultorio/Turnos/TurnoNuevo.aspx?idPaciente=" + pac.IdPaciente.ToString());
                    if (Request.QueryString["llamada"] == "Screening")
                        Response.Redirect("~/Laboratorio/Neonatal/IngresoEdit.aspx?idPaciente=" + pac.IdPaciente.ToString());
                    if (Request.QueryString["llamada"] == "LaboProtocolo")
                        Response.Redirect("/Laboratorio/Protocolos/ProtocoloEdit2.aspx?idPaciente=" + pac.IdPaciente.ToString() + "&Operacion=" + Request.QueryString["Operacion"] + "&idServicio=" + Request.QueryString["idServicio"] + "&idUrgencia=" + Request.QueryString["idUrgencia"]);
                    if (Request.QueryString["llamada"] == "ConsultaPaciente")
                        Response.Redirect("../Paciente/PacienteReporte.aspx?idPaciente=" + pac.IdPaciente.ToString());
                    if (Request.QueryString["llamada"] == "RegistroMx")
                        Response.Redirect("/Mamas/Default.aspx?idPaciente=" + pac.IdPaciente.ToString() + "&idUsuario=" + Session["idUsuario"]);
                    Response.Redirect("PacienteList.aspx", false);
                //}
                //catch (Exception ex)
                //{
                //    // Poner la logica de error
                //    lblMensaje.Text = "Los datos no fueron guardados, verifique los datos olbigatorios.";
                //    throw;
                //}
            }
        }

        protected void validate_me(object sender, ServerValidateEventArgs e)
        {
            switch (ddlEstadoP.SelectedValue)
            {
                case "1":
                    Page.Validate("I");
                    break;
                case "2":
                    Page.Validate("T");
                    break;
                case "3":
                    Page.Validate("V");
                    break;
            }

            if (ddlMotivoNI.SelectedValue == "1") Page.Validate("TBB");
            if (ddlMotivoNI.SelectedValue == "2") Page.Validate("TE");
        }

        private bool DatosValidos(int id)
        {
            lblMensaje.Text = string.Empty;

            DateTime fec = Convert.ToDateTime("01/01/1900");
            DateTime.TryParse(txtFechaNac.Text, out fec);
            if ((fec > DateTime.Now) && (txtFechaNac.Text == ""))
            {
                lblMensaje.Text = "Debe ingresar una fecha válida. <br/>";
            }

            switch (ddlEstadoP.SelectedValue)
            {
                case "1":
                    Page.Validate("I");
                    break;
                case "2":
                    Page.Validate("T");
                    break;
                case "3":
                    Page.Validate("V");
                    break;
            }

            if (ddlMotivoNI.SelectedValue == "1") Page.Validate("TBB");

            // SI el estado es 1 o 3 Busco los posible duplicados, sino, no me interesa y no los busco
            if ((ddlEstadoP.SelectedValue == "1") || (ddlEstadoP.SelectedValue == "3"))
            {
                // Me fijo si ha llenado el nro de doc q es requerido en estos casos
                if (!string.IsNullOrEmpty(txtNumeroDocumento.Text.Trim()))
                {
                    //consulto en la tabla paciente si el tipo y numero de documento ingresado ya existe
                    DataTable dtd = BuscarNumeroDoc(id);
                    if (dtd.Rows.Count > 0)
                    {
                        lblMensaje.Text += "El número ingresado ya existe! <br/>";
                        txtNumeroDocumento.Focus();
                    }
                }
                else
                {
                    lblMensaje.Text += "El DNI es requerido! <br/>";
                    Page.Validate("I");
                    Label1.Text += "<br />Estado Identificado: " + Page.IsValid.ToString();
                }
            }
            if (lblMensaje.Text == string.Empty)
            {
                return true;
            }
            return false;
        }

        protected void ddlNacionalidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarProvincia();
        }

        private void CargarProvincia()
        {
            // Busco las provincias de la nacionalidad seleccionada
            SubSonic.Select n = new SubSonic.Select();
            n.From(DalSic.SysProvincium.Schema);
            n.Where(SysProvincium.Columns.IdPais).IsEqualTo(ddlNacionalidad.SelectedValue);
            n.Or(SysProvincium.Columns.IdProvincia).IsEqualTo(0);
            n.Or(SysProvincium.Columns.IdProvincia).IsEqualTo(-1);
            ddlProvincia.DataSource = n.ExecuteTypedList<SysProvincium>();
            ddlProvincia.DataBind();
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            string strServer = ConfigurationManager.AppSettings["ipServer"];
            if (Request.QueryString["llamada"] == "Recupero")
                Response.Redirect("/Recupero/OrdenPrestacion/PacienteList.aspx?idUsuario=" + Session["idUsuario"]);
            if (Request.QueryString["llamada"] == "LaboTurno")
                Response.Redirect("/Laboratorio/Turnos/Default.aspx?id={0}&idUsuario=" + Session["idUsuario"]);
            if (Request.QueryString["llamada"] == "ConsultaPaciente")
                Response.Redirect("../Paciente/PacienteReporte.aspx?idUsuario=" + Session["idUsuario"]);
            if (Request.QueryString["llamada"] == "RegistroMx")
                Response.Redirect("/Mamas/Default.aspx?idUsuario=" + Session["idUsuario"]);
            Response.Redirect("PacienteList.aspx", false);
        }

        protected void ddlProvinciaDomicilio_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarDepartamento();
        }

        private void CargarDepartamento()
        {
            ddlDepartamento.Items.Clear();
            //Selecciono el item del combo Provincia y filtro los departamentos de la provincia
            SubSonic.Select p = new SubSonic.Select();
            p.From(DalSic.SysDepartamento.Schema);
            p.Where(SysDepartamento.Columns.IdProvincia).IsEqualTo(ddlProvinciaDomicilio.SelectedValue);
            p.Or(SysDepartamento.Columns.IdDepartamento).IsEqualTo(0);
            p.Or(SysDepartamento.Columns.IdDepartamento).IsEqualTo(-1);
            ddlDepartamento.DataSource = p.ExecuteTypedList<SysDepartamento>();
            ddlDepartamento.DataBind();
        }

        protected void ddlProvinciaDomicilio_DataBound(object sender, EventArgs e)
        {
            ddlProvinciaDomicilio.SelectedValue = ddlProvinciaDomicilio.Items.IndexOf(ddlProvinciaDomicilio.Items.FindByValue(IdNeuquen)).ToString();
            ddlProvinciaDomicilio_SelectedIndexChanged(null, null);
        }

        protected void ddlNacionalidad_DataBound(object sender, EventArgs e)
        {
            ddlNacionalidad.SelectedValue = ddlNacionalidad.Items.IndexOf(ddlNacionalidad.Items.FindByValue(IdArgentina)).ToString();
            ddlNacionalidad_SelectedIndexChanged(null, null);
        }

        protected void ddlDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarLocalidad();
        }

        private void CargarLocalidad()
        {
            //ddlLocalidad.Items.Clear();
            //Selecciono el item del combo Departamento y filtro las localidades del departamento
            SubSonic.Select p = new SubSonic.Select();
            p.From(DalSic.SysLocalidad.Schema);
            p.Where(SysLocalidad.Columns.IdDepartamento).IsEqualTo(ddlDepartamento.SelectedValue);
            p.Or(SysLocalidad.Columns.IdLocalidad).IsEqualTo(0);
            p.Or(SysLocalidad.Columns.IdLocalidad).IsEqualTo(-1);
            ddlLocalidad.DataSource = p.ExecuteTypedList<SysLocalidad>();
            ddlLocalidad.DataBind();
        }

        protected void ddlLocalidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarBarrio();
        }

        private void CargarBarrio()
        {
            //Selecciono el item del combo Localidad y filtro los barrios de la localidad
            SubSonic.Select b = new SubSonic.Select();
            b.From(DalSic.SysBarrio.Schema);
            b.Where(SysBarrio.Columns.IdLocalidad).IsEqualTo(ddlLocalidad.SelectedValue);
            b.Or(SysBarrio.Columns.IdBarrio).IsEqualTo(0);
            b.Or(SysBarrio.Columns.IdBarrio).IsEqualTo(-1);
            ddlBarrio.DataSource = b.ExecuteTypedList<SysBarrio>();
            ddlBarrio.DataBind();

            if ((ddlLocalidad.SelectedItem.Value != "-1") && (ddlLocalidad.SelectedItem.Value != "0"))
            {
                SubSonic.Select cod = new SubSonic.Select();
                cod.From(SysLocalidad.Schema);
                cod.Where(SysLocalidad.Columns.IdLocalidad).IsEqualTo(ddlLocalidad.SelectedValue);
                SysLocalidad l = new SysLocalidad();
                l = cod.ExecuteSingle<SysLocalidad>();
                txtCPostal.Text = l.CodigoPostal.ToString();
            }
        }

        protected void ddlLocalidad_DataBound(object sender, EventArgs e)
        {
            ddlLocalidad.SelectedValue = ddlLocalidad.Items.IndexOf(ddlLocalidad.Items.FindByValue(IdNqn)).ToString();
            ddlLocalidad_SelectedIndexChanged(null, null);
        }

        protected void VerificarNumeroDoc(object sender, EventArgs e)
        {
            if ((ddlEstadoP.SelectedValue == "1") || (ddlEstadoP.SelectedValue == "3"))
            {

                lblMensaje.Text = string.Empty;

                int id = Convert.ToInt32(Request.QueryString["id"]);
                //consulto en la tabla paciente si el tipo y numero de documento ingresado ya existe
                DataTable dtd = BuscarNumeroDoc(id);
                if (dtd.Rows.Count > 0)
                {
                    lblMensaje.Text += "El número ingresado ya existe! <br/>Si quiere actualizar sus datos; salga de esta pantalla; busque el mismo y seleccione Editar.";
                }
                else
                {
                    lblMensaje.Text += "";
                }

                //Verifico que el DNI no traiga letras
                int intParsed;
                if (int.TryParse(txtNumeroDocumento.Text.Trim(), out intParsed))
                {
                    //busqueda de pacientes por documento
                    if (txtNumeroDocumento.Text.Length > 0)
                    {
                        int nrodoc = 0;
                        nrodoc = Convert.ToInt32(txtNumeroDocumento.Text);
                        int Doc = nrodoc;
                        //Busqueda en Sys_Paciente
                        DataTable dtpac = DalSic.SPs.GetPacientesPorDocumento((Convert.ToInt32(txtNumeroDocumento.Text))).GetDataSet().Tables[0];
                        if (dtpac.Rows.Count > 0)
                        {
                            hfIdPaciente.Value = dtpac.Rows[0][0].ToString();
                            id = int.Parse(dtpac.Rows[0][0].ToString());
                            cargarPaciente(id);
                            lblMensaje.Text = "El Paciente ya fue ingresado! Si quiere actualizar sus datos; salga de esta pantalla; busque el mismo y seleccione Editar.";
                            btnGuardar.Visible = false;
                            upBotones.Update();
                        }
                        else
                        {
                            btnGuardar.Visible = true;
                            upBotones.Update();
                        }

                        ////Posibles ObrasSociales según padrón.
                        //if (txtNumeroDocumento.Text.Length > 0 & int.Parse(txtNumeroDocumento.Text) > 0)
                        //{
                        //    //WebRequest request = WebRequest.Create("http://10.1.232.8/wspadron/padron.asmx/Consultar?dni=" + txtNumeroDocumento.Text);

                        //    //Posibles datos según padrón sintys.
                        //    Label2.Text = "Datos obtenidos del Sistema de Identificacion Nacional Tributario y Social (SINTyS) ";
                        //    WebRequest requestPS = WebRequest.Create("http://10.1.232.8/WCFSINTyS/wsPersona.asmx/GetPersona?dni=" + txtNumeroDocumento.Text);
                        //    WebResponse wsPS = requestPS.GetResponse();
                        //    JavaScriptSerializer jsonSerializer = new JavaScriptSerializer();
                        //    Stream stPS = wsPS.GetResponseStream();
                        //    StreamReader srPS = new StreamReader(stPS);
                        //    string sPS = srPS.ReadToEnd();
                        //    int inicio = sPS.IndexOf("[");
                        //    int fin = sPS.IndexOf("]") + 1;
                        //    string aux = sPS.Substring(inicio, fin - inicio);
                        //    List<Persona> profesionales = jsonSerializer.Deserialize<List<Persona>>(aux);
                        //    GrdPersona.DataSource = profesionales;
                        //    GrdPersona.DataBind();

                        //}
                    }
                }
            }
        }


        public class Persona
        {
            public int idPersona { get; set; }
            public string TipoDocumento { get; set; }
            public int Documento { get; set; }
            public string NombreCompleto { get; set; }
            public string FechaNacimiento { get; set; }
            public string Sexo { get; set; }


        }

        public class ObSocial
        {
            public string obraSocial { get; set; }
            public string baseOrigen { get; set; }
        }


        protected void GrdPersona_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                ImageButton CmdPersona = (ImageButton)e.Row.Cells[5].Controls[1];
                CmdPersona.CommandArgument = this.GrdPersona.DataKeys[e.Row.RowIndex].Value.ToString();
                CmdPersona.ToolTip = "Ver Obra Sociales";
                CmdPersona.CommandName = "Persona";
            }
        }

        protected void GrdPersona_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Persona")
            {        //Posibles datos de OS según padrón sintys.
                string idpersona = e.CommandArgument.ToString();

                string s_urlWFC = ConfigurationManager.AppSettings["Sintys_WebService"].ToString();
                string s_url = s_urlWFC + "/GetObraSociales?idPersona=" + idpersona;


                WebRequest request = WebRequest.Create(s_url);

               // WebRequest request = WebRequest.Create("http://10.1.232.8/WCFSINTyS/wsPersona.asmx/GetObraSociales?idPersona=" + idpersona);
                WebResponse ws = request.GetResponse();
                JavaScriptSerializer jsonSerializerOS = new JavaScriptSerializer();
                Stream st = ws.GetResponseStream();
                StreamReader sr = new StreamReader(st);
                string s = sr.ReadToEnd();
                int inicios = s.IndexOf("[");
                int fins = s.IndexOf("]") + 1;
                string auxs = s.Substring(inicios, fins - inicios);
                List<ObSocial> obrasociales = jsonSerializerOS.Deserialize<List<ObSocial>>(auxs);
                grdOSociales.DataSource = obrasociales;
                grdOSociales.DataBind();
            }

        }


        private DataTable BuscarNumeroDoc(int id)
        {
            DataTable dtd = new DataTable();

            if (id > 0)
            {
                int intParsed;
                if (int.TryParse(txtNumeroDocumento.Text.Trim(), out intParsed))
                {
                    SubSonic.Select td = new SubSonic.Select();
                    td.From(DalSic.SysPaciente.Schema);
                    td.Where(SysPaciente.Columns.IdEstado).IsEqualTo(ddlEstadoP.SelectedValue);
                    td.And(SysPaciente.Columns.NumeroDocumento).IsEqualTo(intParsed);
                    td.And(SysPaciente.Columns.IdPaciente).IsNotEqualTo(id);
                    dtd = td.ExecuteDataSet().Tables[0];
                }
            }

            return dtd;
        }

        protected void ddlEstadoP_SelectedIndexChanged(object sender, EventArgs e)
        {
            SubSonic.Select m = new SubSonic.Select();
            m.From(SysMotivoNI.Schema);
            m.InnerJoin(SysRelEstadoMotivoNI.Schema);
            m.Where(SysRelEstadoMotivoNI.IdEstadoColumn).IsEqualTo(ddlEstadoP.SelectedValue);
            ddlMotivoNI.DataSource = m.ExecuteTypedList<SysMotivoNI>();
            ddlMotivoNI.DataBind();

            // Si tiene estado 1 o 3 habilito la carga de un nro de DNI, 1=Identificado , 3=Validado
            Boolean habilitado = ((ddlEstadoP.SelectedValue == "1") || (ddlEstadoP.SelectedValue == "3"));
            txtNumeroDocumento.Text = habilitado ? txtNumeroDocumento.Text : "";
            //pregunto si el tipo de doc es <> de SD e inhabilito el control
            txtNumeroDocumento.Enabled = habilitado;
            validate_me(null, new ServerValidateEventArgs("", true));
        }

        protected void ddlMotivoNI_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlMotivoNI.SelectedValue == "2")
            {
                lblExtranjero.Text = "Doc. Extranjero:";
                txtNumeroExtranjero.Visible = true;
                txtNumeroExtranjero.Focus();
            }
            else
            {
                lblExtranjero.Text = "";
                txtNumeroExtranjero.Visible = false;
            }
        }

        protected void btnGuardarRem_Click(object sender, EventArgs e)
        {
            btnGuardar_Click(sender, e);
            if (txtNumeroDocumento.Text.Trim().Length > 0)
                Response.Redirect("~/RemediarRedes/Preclasificacion/Editar.aspx?dni=" + txtNumeroDocumento.Text.Trim());
            else
                Response.Redirect("~/RemediarRedes/Preclasificacion/Editar.aspx");

        }

        protected void btnGuardarClasif_Click(object sender, EventArgs e)
        {
            btnGuardar_Click(sender, e);
            if (txtNumeroDocumento.Text.Trim().Length > 0)
                Response.Redirect("~/Clasificacion/Buscar.aspx?dni=" + txtNumeroDocumento.Text.Trim());
            else
                Response.Redirect("~/Clasificacion/Buscar.aspx");
        }

        protected void btnGuardarCP_Click(object sender, EventArgs e)
        {
            btnGuardar_Click(sender, e);
            if (txtNumeroDocumento.Text.Trim().Length > 0)
                Response.Redirect("~/ConsultaAmbulatoria/BuscarEmbarazada.aspx?dni=" + txtNumeroDocumento.Text.Trim());
            else
                Response.Redirect("~/ConsultaAmbulatoria/BuscarEmbarazada.aspx");
        }

        protected void btnGuardarCM_Click(object sender, EventArgs e)
        {
            btnGuardar_Click(sender, e);
            if (txtNumeroDocumento.Text.Trim().Length > 0)
                Response.Redirect("~/ConsultaAmbulatoria/BuscarMenor.aspx?dni=" + txtNumeroDocumento.Text.Trim());
            else
                Response.Redirect("~/ConsultaAmbulatoria/BuscarMenor.aspx");
        }

        private int CalcularEdad()
        {
            DateTime fec = Convert.ToDateTime("01/01/1900");
            DateTime.TryParse(txtFechaNac.Text, out fec);
            if ((fec > DateTime.Now) && (txtFechaNac.Text == ""))
            {
                return -1;
            }
            else
            {
                int edad = DateTime.Now.Year - fec.Year;
                DateTime nacimientoEsteAnio = fec.AddYears(edad);
                if (DateTime.Now.CompareTo(nacimientoEsteAnio) < 0)
                {
                    edad--;
                }
                return edad;
            }
        }

        private void cargarPaciente(int id)
        {
            DalSic.SysPaciente pac = new DalSic.SysPaciente(id);

            txtNumeroDocumento.Text = pac.NumeroDocumento.ToString();
            int Doc = Convert.ToInt32(txtNumeroDocumento.Text);
            ddlEstadoP.SelectedValue = pac.IdEstado.ToString();
            ddlEstadoP_SelectedIndexChanged(null, null);
            ddlMotivoNI.SelectedValue = pac.IdMotivoNI.ToString();
            if (pac.IdMotivoNI == 2)
            {
                if (pac.NumeroExtranjero != "")
                {
                    lblExtranjero.Text = "Doc. Extranjero: ";
                    txtNumeroExtranjero.Visible = true;
                    txtNumeroExtranjero.Text = pac.NumeroExtranjero;
                }
            }
            txtApellido.Text = pac.Apellido;
            txtNombre.Text = pac.Nombre;
            ddlSexo.SelectedValue = pac.IdSexo.ToString();
            txtFechaNac.Text = pac.FechaNacimiento.ToShortDateString();
            hlkHClinica.NavigateUrl = "HistoriaClinica/NroHistoriaClinicaEdit.aspx?idPac=" + pac.IdPaciente;



            //NAcionalidad -> Pais
            ddlNacionalidad.SelectedValue = pac.IdPais.ToString();
            ddlNacionalidad_SelectedIndexChanged(null, null);
            //Provincia -> lugar de nacimiento
            ddlProvincia.SelectedValue = pac.IdProvincia.ToString();
            OSociales.setOS(pac.IdObraSocial);
            txtTFijo.Text = pac.TelefonoFijo;
            txtTCelular.Text = pac.TelefonoCelular;
            txtEmail.Text = pac.Email;
            //observaciones
            txtContacto.Text = pac.InformacionContacto;
            //domicilio

            if (pac.IdProvinciaDomicilio != 0)
                ddlProvinciaDomicilio.SelectedValue = pac.IdProvinciaDomicilio.ToString();
            else
                ddlProvinciaDomicilio.SelectedValue = "-1";

            ddlProvinciaDomicilio_SelectedIndexChanged(null, null);
            //traigo el departamento correspondiente a la provincia seleccionada
            ddlDepartamento.SelectedValue = pac.IdDepartamento.ToString();
            ddlDepartamento_SelectedIndexChanged(null, null);
            //traigo la localidad correspondiente a la provincia seleccionada
            ddlLocalidad.SelectedValue = pac.IdLocalidad.ToString();
            ddlLocalidad_SelectedIndexChanged(null, null);
            txtCPostal.Text = pac.SysLocalidad.CodigoPostal.ToString();
            ddlBarrio.SelectedValue = pac.IdBarrio.ToString();
            txtOBarrio.Text = pac.OtroBarrio.ToString();
            txtCalle.Text = pac.Calle;
            txtNumero.Text = Convert.ToString(pac.Numero);
            txtEdificio.Text = pac.Edificio;
            txtPiso.Text = pac.Piso;
            txtDepartamento.Text = pac.Departamento;
            txtManzana.Text = pac.Manzana;
            switch (pac.EsUrbano)
            {
                case false: rbUrbano.SelectedValue = "0";
                    break;
                case true: rbUrbano.SelectedValue = "1";
                    break;
            }
            txtLatitud.Text = pac.Latitud;
            txtLongitud.Text = pac.Longitud;
            txtReferencia.Text = pac.Referencia;
            txtCampo.Text = pac.Campo.ToString();
            txtCamino.Text = pac.Camino.ToString();
            txtLote.Text = pac.Lote.ToString();
            txtParcela.Text = pac.Parcela.ToString();
            if (pac.FechaDefuncion.ToShortDateString() == "01/01/1900")
                txtDefuncion.Text = "";
            else txtDefuncion.Text = pac.FechaDefuncion.ToShortDateString();
            //traigo en un label la obra social detectada en la base Padron
            pac.FechaUltimaActualizacion = DateTime.Now;

            //traigo los datos del primer pariente que encuentra
            if (pac.SysParentescoRecords.Count > 0)
            {
                SysParentesco par = pac.SysParentescoRecords[0];
                txtApellidoM.Text = par.Apellido;
                txtNombreM.Text = par.Nombre;
                txtNumeroM.Text = par.NumeroDocumento.ToString();
                if (par.FechaNacimiento.ToShortDateString() == "01/01/1900") txtFNacMadre.Text = "";
                else txtFNacMadre.Text = par.FechaNacimiento.ToShortDateString();
                ddlNacionalidadM.SelectedValue = par.IdPais.ToString();
                ddlLugarNacimientoM.SelectedValue = par.IdProvincia.ToString();
                lblIdParentescoM.Text = par.IdParentesco.ToString();
                par.FechaModificacion = DateTime.Now;
                //datos del padre
                if (pac.SysParentescoRecords.Count > 1)
                {
                    SysParentesco parP = pac.SysParentescoRecords[1];
                    txtApellidoPadre.Text = parP.Apellido;
                    txtNombrePadre.Text = parP.Nombre;
                    txtDUPadre.Text = parP.NumeroDocumento.ToString();
                    if (parP.FechaNacimiento.ToShortDateString() == "01/01/1900") txtFNacPadre.Text = "";
                    else txtFNacPadre.Text = parP.FechaNacimiento.ToShortDateString();
                    ddlNacionalidadP.SelectedValue = parP.IdPais.ToString();
                    ddlLugarNacimientoP.SelectedValue = parP.IdProvincia.ToString();
                    lblIdParentescoP.Text = parP.IdParentesco.ToString();
                    parP.FechaModificacion = DateTime.Now;
                }
            }
        }

        protected void btnSintys_Click(object sender, EventArgs e)
        {
            try
            {
                ////Posibles ObrasSociales según padrón.
                if (txtNumeroDocumento.Text.Length > 0)
                {
                    string s_urlWFC = ConfigurationManager.AppSettings["Sintys_WebService"].ToString();
                    string s_url = s_urlWFC + "/GetPersona?dni=" + txtNumeroDocumento.Text;

                    //Posibles datos según padrón sintys.
                    Label2.Text = "Datos obtenidos del Sistema de Identificacion Nacional Tributario y Social (SINTyS) ";
                    WebRequest requestPS = WebRequest.Create(s_url);
                    WebResponse wsPS = requestPS.GetResponse();
                    JavaScriptSerializer jsonSerializer = new JavaScriptSerializer();
                    Stream stPS = wsPS.GetResponseStream();
                    StreamReader srPS = new StreamReader(stPS);
                    string sPS = srPS.ReadToEnd();
                    int inicio = sPS.IndexOf("[");
                    int fin = sPS.IndexOf("]") + 1;
                    string aux = sPS.Substring(inicio, fin - inicio);
                    List<Persona> personitas = jsonSerializer.Deserialize<List<Persona>>(aux);
                    GrdPersona.DataSource = personitas;
                    GrdPersona.DataBind();

                }
            }
            catch (Exception ex)
            {
                // Poner la logica de error
                Label2.Text = "error de conexion de sintys:" + ex.Message;
                throw;
            }
        }

        protected void btnPadronPcial_Click(object sender, EventArgs e)
        {
            try
            {
                ////Posibles ObrasSociales según padrón.
                if (txtNumeroDocumento.Text.Length > 0)
                {
                    PacienteProvincial.Visible = true;
                    bool h=   PacienteProvincial.MostrarDatos(txtNumeroDocumento.Text);                                        
                    btnCopiarTodo.Visible = h;
                     if (hayDatosMadre()) btnCopiarMadre.Visible = h;
                     if (hayDatosPadre())
                    btnCopiarPadre.Visible = h;
                    btnCopiarDomicilio.Visible = h;
                    btnCopiarDatosPrincipales.Visible = h;
                    btnCopiarProgenitor.Visible = h;

                }
            }
            catch (Exception ex)
            {
                // Poner la logica de error
                Label2.Text = "error de conexion con servidor remoto:" + ex.Message;
                throw;
            }

        }

        private bool hayDatosPadre()
        {
            string datos = PacienteProvincial.TraerDatosPadre();
            string[] oDatos = datos.Split(';');

            if ((oDatos[0].ToString() == "") && (oDatos[1].ToString() == "") && (oDatos[2].ToString() == "") && (oDatos[3].ToString() == ""))
                return false;
            else return true;
        }

        private bool hayDatosMadre()
        {
         
            string datos = PacienteProvincial.TraerDatosMadre();
            string[] oDatos = datos.Split(';');

            if ((oDatos[0].ToString() == "") && (oDatos[1].ToString() == "") && (oDatos[2].ToString() == "") && (oDatos[3].ToString()==""))
                return false;
            else return true;
        }

        protected void btnCopiarTodo_Click(object sender, EventArgs e)
        {
            CopiarDatosPrincipales();
            CopiarDomicilio();
            CopiarMadre();
            CopiarPadre();
        }
        protected void btnCopiarDatosPrincipales_Click(object sender, EventArgs e)
        {
            CopiarDatosPrincipales();


        }

        private void CopiarDatosPrincipales()
        {
            //try
            //{
            string datos = PacienteProvincial.TraerDatosPrincipales();
            string[] oDatos = datos.Split(';');
            txtNumeroDocumento.Text = oDatos[0].ToString();
            txtApellido.Text = oDatos[1].ToString();
            txtNombre.Text = oDatos[2].ToString();
            
            ddlSexo.SelectedValue = oDatos[3].ToString();
            txtFechaNac.Text = oDatos[4].ToString();
            if (oDatos[5].ToString() != "0")
            {
                ddlNacionalidad.SelectedValue = oDatos[5].ToString(); CargarProvincia();
            }
            if (oDatos[6].ToString() != "0") ddlProvincia.SelectedValue = oDatos[6].ToString();

            OSociales.setOS(int.Parse(oDatos[7].ToString()));
      
            txtTFijo.Text = oDatos[8].ToString();
            txtTCelular.Text = oDatos[9].ToString();
            txtEmail.Text = oDatos[10].ToString();
            txtContacto.Text = oDatos[11].ToString();
            txtDefuncion.Text = oDatos[12].ToString();
        //    }
        //catch (Exception ex)
        //{
        //    //    // Poner la logica de error
        //    //    lblMensaje.Text = "Los datos no fueron guardados, verifique los datos olbigatorios.";
        //   // throw;
        //}
        }
        protected void btnCopiarDomicilio_Click(object sender, EventArgs e)
        {

            CopiarDomicilio();

        }

        private void CopiarDomicilio()
        {
            //try
            //{
                string datos = PacienteProvincial.TraerDomicilio();
                string[] oDatos = datos.Split(';');

                if (oDatos[0].ToString() != "0")
                { ddlProvinciaDomicilio.SelectedValue = oDatos[0].ToString();  }
                if (oDatos[1].ToString() != "0")
                { CargarDepartamento(); ddlDepartamento.SelectedValue = oDatos[1].ToString(); }
                if ((oDatos[2].ToString() != "0")|| (oDatos[2].ToString() != ""))
                {
                    CargarLocalidad(); ddlLocalidad.SelectedValue = oDatos[2].ToString();
                }

                txtCPostal.Text = oDatos[3].ToString();
                if (oDatos[4].ToString() != "0")
                {
                    CargarBarrio();
                    ddlBarrio.SelectedValue = oDatos[4].ToString();
                }

                txtOBarrio.Text = oDatos[5].ToString();
                txtCalle.Text = oDatos[6].ToString();
                if (oDatos[7].ToString() == "")
                    txtNumero.Text = "0";else          txtNumero.Text = oDatos[7].ToString();
                txtEdificio.Text = oDatos[8].ToString();
                txtPiso.Text = oDatos[9].ToString();
                txtDepartamento.Text = oDatos[10].ToString();
                txtManzana.Text = oDatos[11].ToString();
                txtReferencia.Text = oDatos[12].ToString();
                if (oDatos[13].ToString() == "Urbano")
                    rbUrbano.SelectedValue = "1";
                else rbUrbano.SelectedValue = "0";

                txtLatitud.Text = oDatos[14].ToString();
                txtLongitud.Text = oDatos[15].ToString();
                txtCampo.Text = oDatos[16].ToString();
                txtCamino.Text = oDatos[17].ToString();
                txtLote.Text = oDatos[18].ToString();
                txtParcela.Text = oDatos[19].ToString();
            //}
            //catch (Exception ex)
            //{
            ////    // Poner la logica de error
            ////    lblMensaje.Text = "Los datos no fueron guardados, verifique los datos olbigatorios.";
            ////    throw;
            //}
        }



        protected void btnCopiarProgenitor_Click(object sender, EventArgs e)
        {
            CopiarMadre();
            CopiarPadre();
            
        }
        protected void btnCopiarMadre_Click(object sender, EventArgs e)
        {
            CopiarMadre();
            
        }

        private void CopiarMadre()
        {
            string datos = PacienteProvincial.TraerDatosMadre();
            string[] oDatos = datos.Split(';');

            txtNumeroM.Text = oDatos[0].ToString();
            txtApellidoM.Text = oDatos[1].ToString();
            txtNombreM.Text = oDatos[2].ToString();
            txtFNacMadre.Text = oDatos[3].ToString();
            if ( oDatos[4].ToString()!="0") ddlNacionalidadM.SelectedValue = oDatos[4].ToString();
            if (oDatos[5].ToString() != "0") ddlLugarNacimientoM.SelectedValue = oDatos[5].ToString();
        }

        protected void btnCopiarPadre_Click(object sender, EventArgs e)
        {
            CopiarPadre();

        }

        private void CopiarPadre()
        {
            string datos = PacienteProvincial.TraerDatosPadre();
            string[] oDatos = datos.Split(';');

            txtDUPadre.Text = oDatos[0].ToString();
            txtApellidoPadre.Text = oDatos[1].ToString();
            txtNombrePadre.Text = oDatos[2].ToString();
            txtFNacPadre.Text = oDatos[3].ToString();
            if (oDatos[4].ToString() != "0") ddlNacionalidadP.SelectedValue = oDatos[4].ToString();
            if (oDatos[5].ToString() != "0") ddlLugarNacimientoP.SelectedValue = oDatos[5].ToString();
        }
    }
}