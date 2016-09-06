using System;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;
using DalRis;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;
using Salud.Security.SSO;
using System.Collections.Generic;

namespace RIS_Publico
{
    public partial class ProsameEdit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SSOHelper.Authenticate();
            if (!Page.IsPostBack)
            {
                lblEfector.Text = SSOHelper.CurrentIdentity.IdEfector.ToString().Trim();
                txtFechaInicio.Value = DateTime.Now.ToShortDateString();
                txtFechaOdonto.Value = DateTime.Now.ToShortDateString();
                if (Request["idPaciente"] != null)
                {
                    int idPaciente = SubSonic.Sugar.Web.QueryString<int>("idPaciente"); // Request["idPaciente"].TryParseInt();
                    MostrarDatosPaciente(idPaciente);
                }
                cargarCombos();
                TablaErrores.Visible = false;
                int idProsame = SubSonic.Sugar.Web.QueryString<int>("idProsame");
                if (idProsame > 0)
                {
                    MostrarDatos(idProsame);
                }
            }
        }

        private void CargarDerivaciones(int idProsame)
        {
            PsmDerivacioneCollection derivaciones = new SubSonic.Select()
            .From(PsmDerivacione.Schema)
            .Where(PsmDerivacione.IdProsameColumn).IsEqualTo(idProsame)
            .ExecuteAsCollection<PsmDerivacioneCollection>();

            foreach (PsmDerivacione d in derivaciones)
            {
                if (d.IdEspecialidad == 24) ChkDerPediatria.Checked = true;
                if (d.IdEspecialidad == 34) ChkDerOdonto.Checked = true;
                if (d.IdEspecialidad == 21) ChkOftalmologia.Checked = true;
                if (d.IdEspecialidad == 999) ChkDerORL.Checked = true;     //ver en tabla 22
                if (d.IdEspecialidad == 6) ChkDermatologia.Checked = true;
                if (d.IdEspecialidad == 20) ChkDerNeurologia.Checked = true;
                if (d.IdEspecialidad == 54) ChkDerFono.Checked = true;
                if (d.IdEspecialidad == 3) ChkDerCardiologia.Checked = true;
                if (d.IdEspecialidad == 28) ChkDerTrauma.Checked = true;
                if (d.IdEspecialidad == 52) ChkDerTrabSocial.Checked = true;
                if (d.IdEspecialidad == 50) ChkDerPsicologia.Checked = true;
                if (d.IdEspecialidad == 999) ChkDerPsicopedagogia.Checked = true; //ver en tabla 22
                if (d.IdEspecialidad == 53) ChkDerNutricion.Checked = true;
                if (d.IdEspecialidad == 71) ChkDerCirugia.Checked = true;
                if (d.IdEspecialidad == 29) ChkDerUrologia.Checked = true;
                if (d.IdEspecialidad == 999) ChkAgenteSanitario.Checked = true; //ver en tabla 22
                if (d.IdEspecialidad == 999) ChkDerOtros.Checked = true; //ver en tabla 22
            }
        }

        private void MostrarDatosPaciente(int idpaciente)
        {
            DataTable dtDatosPaciente = SPs.PsmBuscarPacExistenteSipsDNI(idpaciente).GetDataSet().Tables[0];

            if (dtDatosPaciente.Rows.Count != 0) // existe al menos un registro
            {
                ldniPaciente.Text = dtDatosPaciente.Rows[0].ItemArray[3].ToString().Trim();
                lPaciente.Text = dtDatosPaciente.Rows[0].ItemArray[2].ToString().Trim() + ',' + dtDatosPaciente.Rows[0].ItemArray[1].ToString().Trim();
                lSexo.Text = dtDatosPaciente.Rows[0].ItemArray[4].ToString().Trim();

                if ((lSexo.Text == "I") || (lSexo.Text == "Indeterminado")) ddlSexo.Visible = true;

                lidPaciente.Text = dtDatosPaciente.Rows[0].ItemArray[0].ToString().Trim();
                lFechaNacimiento.Text = dtDatosPaciente.Rows[0].ItemArray[5].ToString().Trim();
                lTelefono.Text = dtDatosPaciente.Rows[0].ItemArray[13].ToString();
                lblCelular.Text = dtDatosPaciente.Rows[0].ItemArray[14].ToString();
                DateTime nac = DateTime.Parse(dtDatosPaciente.Rows[0].ItemArray[5].ToString().Trim());

                lEdad.Text = dtDatosPaciente.Rows[0].ItemArray[15].ToString().Trim();

                if (dtDatosPaciente.Rows[0][15].ToString() != "")
                {
                    int edad = int.Parse(dtDatosPaciente.Rows[0][15].ToString());
                    if (edad < 7) // 
                    {
                        txtOMaloC.Enabled = false;
                        txtOMaloP.Enabled = false;
                        txtOMaloO.Enabled = false;
                        txtOHPerC.Enabled = true;
                        txtOHPerE.Enabled = true;
                        txtOHPerO.Enabled = true;
                    }
                    else
                    {
                        txtOMaloC.Enabled = true;
                        txtOMaloP.Enabled = true;
                        txtOMaloO.Enabled = true;
                        txtOHPerC.Enabled = false;
                        txtOHPerE.Enabled = false;
                        txtOHPerO.Enabled = false;
                    }
                }

                lDomicilio.Text = dtDatosPaciente.Rows[0].ItemArray[11].ToString().Trim() + ' ' + dtDatosPaciente.Rows[0].ItemArray[7].ToString().Trim() + ' ' + dtDatosPaciente.Rows[0].ItemArray[8].ToString().Trim() + ' ' + dtDatosPaciente.Rows[0].ItemArray[9].ToString().Trim() + ' ' + dtDatosPaciente.Rows[0].ItemArray[10].ToString().Trim();

                //traigo lo datos del tutor si es que tiene               
                txtTutorDNI.Text = dtDatosPaciente.Rows[0].ItemArray[16].ToString();
                txtNombre.Text = dtDatosPaciente.Rows[0].ItemArray[17].ToString();
                txtApellido.Text = dtDatosPaciente.Rows[0].ItemArray[18].ToString();
                //parentesco
                string tipoparentesco = dtDatosPaciente.Rows[0][19].ToString();
                switch (tipoparentesco)
                {
                    case "MADRE": ddlTipoParentesco.SelectedValue = "MADRE";
                        break;
                    case "PADRE": ddlTipoParentesco.SelectedValue = "PADRE";
                        break;
                    case "OTRO": ddlTipoParentesco.SelectedValue = "OTRO";
                        break;
                }

                if ((txtTutorDNI.Text != "0") || (txtNombre.Text != "") || (txtApellido.Text != ""))
                    btnGuardarParentezco.Visible = false;
                //TablaErrores.Visible = true;
            }
            //si el paciente ya fue ingresado en prosane, lo muestro
            DataTable dt = SPs.PsmBuscarPacExistente(int.Parse(lidPaciente.Text)).GetDataSet().Tables[0];

            if (dt.Rows.Count > 0) // existe al menos un registro
            {
                pnProsameanterior.Visible = true;
                lblMensaje.Text = "El paciente ya posee un registro de prosane en Sips<br/>";
                gvProsane.DataSource = dt;
                gvProsane.DataBind();
            }
        }

        private void cargarCombos()
        {
            //ddlLocalidad.DataSource = SPs.PsmCargarListaLocalidades().GetDataSet().Tables[0];
            //ddlLocalidad.DataBind();
            ddlProvincia.Items.Insert(0, new ListItem("NEUQUEN", "139"));

            ddlDepartamento.DataSource = SPs.PsmCargarListaDepartamentos().GetDataSet().Tables[0];
            ddlDepartamento.DataBind();
            ddlDepartamento.SelectedValue = "557";

            ddlLocalidad.Items.Insert(0, new ListItem("NEUQUEN", "52"));

            ddlResponsableFicha.DataSource = SPs.PsmCargarListaProfesionales().GetDataSet().Tables[0];
            ddlResponsableFicha.DataBind();
            ddlResponsableFicha.Items.Insert(0, new ListItem("Seleccionar", "0"));

            ddlResponsableOdonto.DataSource = SPs.PsmCargarListaProfesionales().GetDataSet().Tables[0];
            ddlResponsableOdonto.DataBind();
            ddlResponsableOdonto.Items.Insert(0, new ListItem("Seleccionar", "0"));

            if (int.Parse(lblEfector.Text) == 227)
            {
                ddlEstablecimiento.DataSource = SPs.PsmCargarListaEstablecimientos(227).GetDataSet().Tables[0];
                ddlEstablecimiento.DataBind();
                ddlEstablecimiento.Items.Insert(0, new ListItem("Seleccionar", "0"));
            }
            else
            {
                ddlEstablecimiento.DataSource = SPs.PsmCargarListaEstablecimientos(int.Parse(lblEfector.Text)).GetDataSet().Tables[0];
                ddlEstablecimiento.DataBind();
                ddlEstablecimiento.Items.Insert(0, new ListItem("Seleccionar", "0"));
            }

            //ddlEstablecimiento.DataSource = SPs.PsmCargarListaEstablecimientos().GetDataSet().Tables[0];
            //ddlEstablecimiento.DataBind();
            //ddlEstablecimiento.Items.Insert(0, new ListItem("Seleccionar", "0"));

            //ddlProvincia.DataSource = SPs.PSMCargarComboProvincia().GetDataSet().Tables[0];
            //ddlProvincia.DataBind();
            //ddlProvincia.Items.Insert(0, new ListItem("NEUQUEN", "0"));

            ddlPielFaneras.DataSource = SPs.PsmExamenFisico("Piel y Fanera").GetDataSet().Tables[0];
            ddlPielFaneras.DataBind();

            ddlCardiovascular.DataSource = SPs.PsmExamenFisico("Cardiovascular").GetDataSet().Tables[0];
            ddlCardiovascular.DataBind();

            ddlRespiratorio.DataSource = SPs.PsmExamenFisico("Respiratorio").GetDataSet().Tables[0];
            ddlRespiratorio.DataBind();
            if ((lSexo.Text == "Femenino") || (lSexo.Text == "F"))
            {
                pnGenitourinarioF.Visible = true;
                ddlGenitalF.DataSource = SPs.PsmExamenFisico("GenitourinarioF").GetDataSet().Tables[0];
                ddlGenitalF.DataBind();
            }

            if ((lSexo.Text == "Masculino") || (lSexo.Text == "Indeterminado") || (lSexo.Text == "M") || (lSexo.Text == "I") || (lSexo.Text == "sd"))
            {
                pnGenitourinarioM.Visible = true;
                ddlGenitalM.DataSource = SPs.PsmExamenFisico("GenitourinarioM").GetDataSet().Tables[0];
                ddlGenitalM.DataBind();
            }

            ddlAbdomen.DataSource = SPs.PsmExamenFisico("Abdomen").GetDataSet().Tables[0];
            ddlAbdomen.DataBind();

            ddlOstocular.DataSource = SPs.PsmExamenFisico("Osteroticular").GetDataSet().Tables[0];
            ddlOstocular.DataBind();

            ddlNeurologico.DataSource = SPs.PsmExamenFisico("Neurologico").GetDataSet().Tables[0];
            ddlNeurologico.DataBind();

            ddlPartesBlandas.DataSource = SPs.PsmExamenFisico("Partes Blandas").GetDataSet().Tables[0];
            ddlPartesBlandas.DataBind();

            ddlSaludVisual.DataSource = SPs.PsmExamenFisico("Salud Visual").GetDataSet().Tables[0];
            ddlSaludVisual.DataBind();

            ddlSaludFonoAudiologica.DataSource = SPs.PsmExamenFisico("Salud Fonoaudiologica").GetDataSet().Tables[0];
            ddlSaludFonoAudiologica.DataBind();

            SubSonic.Select escolaridad = new SubSonic.Select();
            escolaridad.From(PsmEscolaridad.Schema);
            ddlEscolaridad.DataSource = escolaridad.ExecuteReader();
            ddlEscolaridad.DataBind();
            ddlEscolaridad.Items.Insert(0, new ListItem("Seleccionar >>", "0"));

            SubSonic.Select grado = new SubSonic.Select();
            grado.From(PsmGrado.Schema);
            ddlGrado.DataSource = grado.ExecuteReader();
            ddlGrado.DataBind();
            ddlGrado.Items.Insert(0, new ListItem("Seleccionar >>", "0"));

            SubSonic.Select division = new SubSonic.Select();
            division.From(PsmDivision.Schema);
            ddlDivision.DataSource = division.ExecuteReader();
            ddlDivision.DataBind();
            ddlDivision.Items.Insert(0, new ListItem("Seleccionar >>", "0"));
        }

        protected void btnGuardarParentezco_Click(object sender, EventArgs e)
        {
            //string username = SSOHelper.CurrentIdentity.Username;
            //guardo los datos del tutor en Sys_Parentesco
            int idPaciente = SubSonic.Sugar.Web.QueryString<int>("idPaciente");

            if ((txtApellido.Text != "") || (txtNombre.Text != "") || (txtTutorDNI.Text != "0"))
            {
                SysParentesco P = new SysParentesco();
                P.Nombre = txtNombre.Text.ToUpper();
                P.Apellido = txtApellido.Text.ToUpper();
                P.IdTipoDocumento = 1;
                if ((txtTutorDNI.Text != "") && (txtTutorDNI.Text != "0")) P.NumeroDocumento = int.Parse(txtTutorDNI.Text);
                else P.NumeroDocumento = 0;
                P.TipoParentesco = ddlTipoParentesco.SelectedValue;

                P.FechaNacimiento = Convert.ToDateTime("1900-01-01");
                P.IdProvincia = -1;
                P.IdPais = -1;
                P.IdSituacionLaboral = 0;
                P.IdNivelInstruccion = 0;
                P.IdProfesion = 0;
                P.IdPaciente = idPaciente;
                P.IdUsuario = Convert.ToInt32(SSOHelper.CurrentIdentity.Username);
                P.FechaModificacion = DateTime.Now;
                P.Save();

                lblMensajeTutor.Text = "Los datos del tutor se guardaron correctamente.";
                btnGuardarParentezco.Visible = false;
                //Response.Redirect("ProsameEdit.aspx?idPaciente=" + idPaciente);
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            int idProsame = SubSonic.Sugar.Web.QueryString<int>("idProsame");
            if ((Page.IsValid) && (!hayError()))
            {
                DalRis.PsmDato oDato = new DalRis.PsmDato(idProsame);
                oDato.IdPaciente = int.Parse(lidPaciente.Text);
                oDato.DNIPaciente = int.Parse(ldniPaciente.Text);
                oDato.PacNombre = lPaciente.Text;
                oDato.Domicilio = lDomicilio.Text;
                oDato.FechaNac = Convert.ToDateTime(lFechaNacimiento.Text);
                oDato.Telefono = lTelefono.Text;
                oDato.Celular = lblCelular.Text;

                if (lEdad.Text != null)
                    oDato.Edad = int.Parse(lEdad.Text);
                else oDato.Edad = 0;
                oDato.FechaFicha = DateTime.Parse(txtFechaInicio.Value);

                oDato.IdLocalidad = int.Parse(ddlLocalidad.SelectedValue);
                oDato.IdProvincia = int.Parse(ddlProvincia.SelectedValue);
                oDato.IdDepartamento = int.Parse(ddlDepartamento.SelectedValue);
                if ((lSexo.Text == "I") || (lSexo.Text == "Indeterminado") || (lSexo.Text == "sd"))
                {
                    ddlSexo.Visible = true;
                    switch (ddlSexo.SelectedValue)
                    {
                        case "F": oDato.Sexo = "F"; //si
                            break;
                        case "M": oDato.Sexo = "M";
                            break;
                        default: oDato.Sexo = "I";
                            break;
                    }
                }
                else oDato.Sexo = lSexo.Text;

                oDato.OSocialTiene = "";// ddlOSocialTiene.SelectedValue.ToString();

                //oDato.Fecha = DateTime.Parse(txtFechaInicio.Value);

                oDato.IdEstablecimiento = int.Parse(ddlEstablecimiento.SelectedValue.ToString());
                oDato.Prematuro = ddlPrematuro.SelectedValue.ToString();
                CultureInfo ci = CultureInfo.InvariantCulture;
                //rcla.Peso = decimal.Parse(txtPeso.Text.Replace(",", "."), ci);
                oDato.Peso = decimal.Parse(txtPesoNacimiento.Text.Replace(",", "."), ci);
                if (txtTutorDNI.Text != "") oDato.TutorDNI = decimal.Parse(txtTutorDNI.Text);
                oDato.TutorNombre = txtNombre.Text.Trim();
                oDato.SobreEdad = ddlSobreedad.SelectedValue.ToString();
                oDato.Repitente = ddlRepitente.SelectedValue.ToString();
                oDato.ZonaEstudio = ddlZonaEstudio.SelectedValue.ToString();
                oDato.PesoAlumno = decimal.Parse(txtPesoAlumno.Text.Replace(",", "."), ci);
                oDato.Talla = decimal.Parse(txtTalla.Text.Replace(",", "."), ci);
                oDato.Imc = decimal.Parse(txtIMC.Text.Replace(",", "."), ci);
                if (txtTAMax.Text != "")
                    oDato.TaMax = decimal.Parse(txtTAMax.Text.Replace(",", "."), ci);
                else oDato.TaMax = 0;
                if (txtTAMin.Text != "")
                    oDato.TaMin = decimal.Parse(txtTAMin.Text.Replace(",", "."), ci);
                else oDato.TaMax = 0;
                // oDato.PercentiloPeso = decimal.Parse(txtPersentiloPeso.Text.Replace(",", "."), ci); ;
                // oDato.PercentiloIMC = decimal.Parse(txtPercentiloIMC.Text.Replace(",", "."), ci);
                // oDato.PercentiloTalla = decimal.Parse(txtPercentiloTalla.Text.Replace(",", "."), ci);

                oDato.PercenTalla = ddlPercentiloTalla.SelectedValue;
                oDato.PercentiloMaxValor = ddlPerPas.SelectedValue.ToString();
                oDato.PercentiloMinValor = ddlPerPad.SelectedValue.ToString();
                oDato.EFPielFanera = int.Parse(ddlPielFaneras.SelectedValue.ToString());
                oDato.EFCardiovascular = int.Parse(ddlCardiovascular.SelectedValue.ToString());
                oDato.EFRespiratorio = int.Parse(ddlRespiratorio.SelectedValue.ToString());

                //validar segun sexo y edad
                if ((lSexo.Text == "Masculino") || (lSexo.Text == "Indeterminado") || (lSexo.Text == "M") || (lSexo.Text == "I"))
                {
                    pnGenitourinarioM.Visible = true;
                    pnGenitourinarioF.Visible = false;
                    oDato.EFOtroGenitourinarioM = txtGenitourinarioM.Text.ToString();
                    if (ddlGenitalM.SelectedValue != "Seleccione")
                        oDato.EFGenitalM = int.Parse(ddlGenitalM.SelectedValue);
                    else oDato.EFGenitalM = 0;
                    oDato.EFOtroGenitourinarioF = "";
                    oDato.EFGenitalF = 0;
                }
                else
                {
                    pnGenitourinarioF.Visible = true;
                    pnGenitourinarioM.Visible = false;
                    oDato.EFOtroGenitourinarioF = txtGenitourinarioF.Text.ToString();
                    if (ddlGenitalF.SelectedValue != "Seleccione")
                        oDato.EFGenitalF = int.Parse(ddlGenitalF.SelectedValue);
                    else oDato.EFGenitalF = 0;
                    oDato.EFOtroGenitourinarioM = "";
                    oDato.EFGenitalM = 0;
                }

                oDato.EFAbdomen = int.Parse(ddlAbdomen.SelectedValue.ToString());
                oDato.EFOsteoarticular = int.Parse(ddlOstocular.SelectedValue.ToString());
                oDato.EFNeurologico = int.Parse(ddlNeurologico.SelectedValue.ToString());
                oDato.EFPartesBlandas = int.Parse(ddlPartesBlandas.SelectedValue.ToString());
                oDato.EFSaludVisual = int.Parse(ddlSaludVisual.SelectedValue.ToString());
                oDato.EFSaludFonoAudio = int.Parse(ddlSaludFonoAudiologica.SelectedValue.ToString());

                oDato.EFOtroPielFanera = txtPielFanera.Text.ToString();
                oDato.EFOtroPartesBlandas = txtPartesBlandas.Text.ToString();
                oDato.EFOtroCardiovascular = txtCardiovascular.Text.ToString();
                oDato.EFOtroRespiratorio = txtRespiratorio.Text.ToString();
                oDato.EFOtroAbdominal = txtAbdominal.Text.ToString();

                oDato.EFOtroOstreocular = txtOsteoarticular.Text.ToString();
                oDato.EFOtroNeurologico = txtNeurologico.Text.ToString();
                oDato.EFOtroSaludVisual = txtSaludVisual.Text.ToString();
                oDato.EFOtroSaludFonoAudio = txtSaludFono.Text.ToString();
                oDato.VacunaCarne = ddlTrajoCarnet.SelectedValue.ToString();
                oDato.VacunaCompleta = ddlVaunaCompleto.SelectedValue.ToString();
                oDato.VacSevacEsc = ddlSeVacunoEscuela.SelectedValue.ToString();
                oDato.Estravismo = ddlEstravismo.Text.ToString();
                oDato.UsaLentes = ddlUsaLentes.Text.ToString();

                oDato.AgudezaVisualIzq = txtAgudezaVisualIzq.Text.ToString();
                oDato.AgudezaVisualDer = txtAgudezaVisualDer.Text.ToString();

                if (chekAudimotria.Checked == true)
                {
                    oDato.FonoAudiometria = "Si";
                }
                else
                {
                    oDato.FonoAudiometria = "No";
                }

                if (chekTato.Checked == true)
                {
                    oDato.FonoTato = "Si";
                }
                else
                {
                    oDato.FonoTato = "No";
                }

                if (txtValorTato.Text != "")
                    oDato.TatoValor = txtValorTato.Text.ToString();
                else oDato.TatoValor = "";

                if (chekDiapason.Checked == true)
                {
                    oDato.FonoDiapason = "Si";
                }
                else
                {
                    oDato.FonoDiapason = "No";
                }

                oDato.Hipoacusia = ddlHipoacusia.SelectedValue.ToString();
                oDato.TransFonacion = ddlFonacion.SelectedValue.ToString();

                if (txtFechaOdonto.Value != "")
                    oDato.FechaOdonto = DateTime.Parse(txtFechaOdonto.Value);
                oDato.OdontoHabitosPernciosos = ddlHabitPerniciosos.SelectedValue.ToString();
                oDato.OdontoMaloclusion = ddlMaloclusion.SelectedValue.ToString();
                oDato.OdontoFluorAplicado = ddlFluorAplicado.SelectedValue.ToString();
                oDato.OdontoEnsTecnicaBucal = ddlTecnicaHigBucal.SelectedValue.ToString();

                oDato.IdEscolaridad = int.Parse(ddlEscolaridad.SelectedValue);
                oDato.IdGrado = int.Parse(ddlGrado.SelectedValue);
                oDato.IdDivision = int.Parse(ddlDivision.SelectedValue);
                oDato.Turno = ddlTurno.SelectedValue.ToString();
                //oDato.Ceod = int.Parse(txtCEOD.Text);
                //oDato.Cpod = int.Parse(txtCPOD.Text);

                oDato.OdontoCEODCareado = int.Parse(txtOHPerC.Text);
                oDato.OdontoCEODPerdido = int.Parse(txtOHPerE.Text);
                oDato.OdontoCEODObstruido = int.Parse(txtOHPerO.Text);

                oDato.OdontoCPODCareado = int.Parse(txtOMaloC.Text);
                oDato.OdontoCPODPerdido = int.Parse(txtOMaloP.Text);
                oDato.OdontoCPODObstruido = int.Parse(txtOMaloO.Text);

                oDato.OdontoCariado = int.Parse(txtCareado.Text);
                oDato.Observaciones = txtObservaciones.Text;
                oDato.ObservacionesGeneral = txtObservacionesGenerales.Text.ToString();
                oDato.IdProfesionalFicha = int.Parse(ddlResponsableFicha.SelectedValue);
                oDato.IdProfesionalOdonto = int.Parse(ddlResponsableOdonto.SelectedValue);
                // graba obra social desde user crontrol
                //int i_obrasocial = OSociales.getObraSocial(); // i_obrasocial;
                if (OSociales.getObraSocial() > 0) oDato.PacOSocial = OSociales.getObraSocial();
                else oDato.PacOSocial = -1;

                oDato.MotivoRechazo = ddlMotivoRechazo.SelectedIndex.ToString();
                oDato.IdUsuarioCarga = SSOHelper.CurrentIdentity.Id;
                oDato.FechaCarga = DateTime.Now;
                oDato.Activo = true;
                oDato.Autorizado = "";

                oDato.Save();

                int valorIdProsame = oDato.IdProsame;

                //elimino los items anteriores para guardar los nuevos
                SPs.PsmDeleteDerivaciones(valorIdProsame).Execute();

                PsmDerivacione oDerivaciones = new PsmDerivacione(oDato.IdProsame);

                if (ChkDerPediatria.Checked == true)
                {
                    oDerivaciones.IdProsame = valorIdProsame;
                    oDerivaciones.IdEspecialidad = 24;
                    oDerivaciones.Save();
                }

                PsmDerivacione oDerivaciones1 = new PsmDerivacione(valorIdProsame);

                if (ChkDerOdonto.Checked == true)
                {
                    oDerivaciones1.IdProsame = valorIdProsame;
                    oDerivaciones1.IdEspecialidad = 34;
                    oDerivaciones1.Save();
                }

                PsmDerivacione oDerivaciones2 = new PsmDerivacione(valorIdProsame);

                if (ChkOftalmologia.Checked == true)
                {
                    oDerivaciones2.IdProsame = valorIdProsame;
                    oDerivaciones2.IdEspecialidad = 21;
                    oDerivaciones2.Save();
                }

                PsmDerivacione oDerivaciones3 = new PsmDerivacione(valorIdProsame);

                if (ChkDerORL.Checked == true)
                {
                    oDerivaciones3.IdProsame = valorIdProsame;
                    oDerivaciones3.IdEspecialidad = 999;
                    oDerivaciones3.Save();
                }

                PsmDerivacione oDerivaciones4 = new PsmDerivacione(valorIdProsame);

                if (ChkDermatologia.Checked == true)
                {
                    oDerivaciones4.IdProsame = valorIdProsame;
                    oDerivaciones4.IdEspecialidad = 6;
                    oDerivaciones4.Save();
                }

                PsmDerivacione oDerivaciones5 = new PsmDerivacione(valorIdProsame);

                if (ChkDerNeurologia.Checked == true)
                {
                    oDerivaciones5.IdProsame = valorIdProsame;
                    oDerivaciones5.IdEspecialidad = 20;
                    oDerivaciones5.Save();
                }

                PsmDerivacione oDerivaciones6 = new PsmDerivacione(valorIdProsame);
                if (ChkDerFono.Checked == true)
                {
                    oDerivaciones6.IdProsame = valorIdProsame;
                    oDerivaciones6.IdEspecialidad = 54;
                    oDerivaciones6.Save();
                }

                PsmDerivacione oDerivaciones7 = new PsmDerivacione(valorIdProsame);

                if (ChkDerCardiologia.Checked == true)
                {
                    oDerivaciones7.IdProsame = valorIdProsame;
                    oDerivaciones7.IdEspecialidad = 3;
                    oDerivaciones7.Save();
                }

                PsmDerivacione oDerivaciones8 = new PsmDerivacione(valorIdProsame);

                if (ChkDerTrauma.Checked == true)
                {
                    oDerivaciones8.IdProsame = valorIdProsame;
                    oDerivaciones8.IdEspecialidad = 28;
                    oDerivaciones8.Save();
                }

                PsmDerivacione oDerivaciones9 = new PsmDerivacione(valorIdProsame);

                if (ChkDerTrabSocial.Checked == true)
                {
                    oDerivaciones9.IdProsame = valorIdProsame;
                    oDerivaciones9.IdEspecialidad = 52;
                    oDerivaciones9.Save();
                }

                PsmDerivacione oDerivaciones10 = new PsmDerivacione(valorIdProsame);

                if (ChkDerPsicologia.Checked == true)
                {
                    oDerivaciones10.IdProsame = valorIdProsame;
                    oDerivaciones10.IdEspecialidad = 50;
                    oDerivaciones10.Save();
                }

                PsmDerivacione oDerivaciones11 = new PsmDerivacione(valorIdProsame);

                if (ChkDerPsicopedagogia.Checked == true)
                {
                    oDerivaciones11.IdProsame = valorIdProsame;
                    oDerivaciones11.IdEspecialidad = 999;
                    oDerivaciones11.Save();
                }

                PsmDerivacione oDerivaciones12 = new PsmDerivacione(valorIdProsame);

                if (ChkDerNutricion.Checked == true)
                {
                    oDerivaciones12.IdProsame = valorIdProsame;
                    oDerivaciones12.IdEspecialidad = 53;
                    oDerivaciones12.Save();
                }

                PsmDerivacione oDerivaciones13 = new PsmDerivacione(valorIdProsame);

                if (ChkDerCirugia.Checked == true)
                {
                    oDerivaciones13.IdProsame = valorIdProsame;
                    oDerivaciones13.IdEspecialidad = 71;
                    oDerivaciones13.Save();
                }

                PsmDerivacione oDerivaciones14 = new PsmDerivacione(valorIdProsame);

                if (ChkDerUrologia.Checked == true)
                {
                    oDerivaciones14.IdProsame = valorIdProsame;
                    oDerivaciones14.IdEspecialidad = 29;
                    oDerivaciones14.Save();
                }

                PsmDerivacione oDerivaciones15 = new PsmDerivacione(valorIdProsame);

                if (ChkAgenteSanitario.Checked == true)
                {
                    oDerivaciones15.IdProsame = valorIdProsame;
                    oDerivaciones15.IdEspecialidad = 999;
                    oDerivaciones15.Save();
                }

                PsmDerivacione oDerivaciones16 = new PsmDerivacione(valorIdProsame);

                if (ChkDerOtros.Checked == true)
                {
                    oDerivaciones16.IdProsame = valorIdProsame;
                    oDerivaciones16.IdEspecialidad = 999;
                    oDerivaciones16.Save();
                }

                string script = @"alerta('Alta realizada correctamente');
  			    window.location.href= 'Default.aspx';";

                ScriptManager.RegisterStartupScript(this, typeof(System.Web.UI.Page), "alerta", script, true);
                Type cstype = this.GetType();
                string nombreScript = "alertar";
                ClientScriptManager cs = Page.ClientScript;
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("if(alert('Paciente añadido con éxito'))");
                sb.AppendLine("{");
                sb.AppendLine("location.href='Default.aspx';");
                sb.AppendLine("}");
                if (!cs.IsStartupScriptRegistered(nombreScript))
                {
                    cs.RegisterStartupScript(cstype, nombreScript, sb.ToString(), true);
                }
                Response.Redirect("PacienteCargado.aspx", false);
                //ClientScript.RegisterStartupScript(this.GetType(), "myScript", "<script>javascript: alert('Se guardaron los datos satisfactoriamente');</script>");
            }
        }

        private bool hayError()
        {
            bool hayError = false;
            lblMensaje.Text = "";
            TablaErrores.Visible = false;

            // ------------------------------------------------------------------------
            // Verifico que el año no sea vacío
            if (lSexo.Text == "Indeterminado")
            {
                lblMensaje.Text += "Debe seleccionar Sexo. <br/>";
                hayError = true;
                TablaErrores.Visible = true;
            }

            if (txtFechaInicio.Value == "")
            {
                lblMensaje.Text += "El campo Fecha Ficha no puede estar vacío. <br/>";
                hayError = true;
                TablaErrores.Visible = true;
            }

            if (OSociales.getObraSocial() < 1)
            {
                lblMensaje.Text += "Debe seleccionar la Obra Social. <br/>";
                hayError = true;
                TablaErrores.Visible = true;
            }

            if ((ddlEstablecimiento.SelectedValue == "Seleccionar") || (ddlEstablecimiento.SelectedValue == "0"))
            {
                lblMensaje.Text += "El campo Establecimiento no puede estar vacío. <br/>";
                hayError = true;
                TablaErrores.Visible = true;
            }

            if (ddlResponsableFicha.SelectedValue == "Seleccionar")
            {
                lblMensaje.Text += "Debe seleccionar el Profesional responsable de la ficha. <br/>";
                hayError = true;
                TablaErrores.Visible = true;
            }

            if (txtNombre.Text == "")
            {
                lblMensaje.Text += "El campo Nombre Tutor no puede estar vacío. <br/>";
                hayError = true;
                TablaErrores.Visible = true;
            }

            if (txtPesoAlumno.Text == "")
            {
                lblMensaje.Text += "El campo Peso Alumno no puede estar vacío. <br/>";
                hayError = true;
                TablaErrores.Visible = true;
            }

            if (txtTalla.Text == "")
            {
                lblMensaje.Text += "El campo Talla Alumno no puede estar vacío. <br/>";
                hayError = true;
                TablaErrores.Visible = true;
            }

            if (txtIMC.Text == "")
            {
                lblMensaje.Text += "El campo IMC Alumno no puede estar vacío. <br/>";
                hayError = true;
                TablaErrores.Visible = true;
            }

            if (txtTAMax.Text == "")
            {
                lblMensaje.Text += "El campo TA Maxima Alumno no puede estar vacío. <br/>";
                hayError = true;
                TablaErrores.Visible = true;
            }

            if (txtTAMin.Text == "")
            {
                lblMensaje.Text += "El campo TA Minima Alumno no puede estar vacío. <br/>";
                hayError = true;
                TablaErrores.Visible = true;
            }

            if (txtAgudezaVisualIzq.Text == "")
            {
                lblMensaje.Text += "El campo Agudeza Visual Izq. Alumno no puede estar vacío. <br/>";
                hayError = true;
                TablaErrores.Visible = true;
            }

            if ((int.Parse(txtAgudezaVisualIzq.Text) < 1) || (int.Parse(txtAgudezaVisualIzq.Text) > 10))
            {
                lblMensaje.Text += "El campo Agudeza visual Izquierda debe ser mayor a 1 y menor a 10. <br/>";
                hayError = true;
                TablaErrores.Visible = true;
            }

            if (txtAgudezaVisualDer.Text == "")
            {
                lblMensaje.Text += "El campo Agudeza Visual Der. Alumno no puede estar vacío. <br/>";
                hayError = true;
                TablaErrores.Visible = true;
            }

            if ((int.Parse(txtAgudezaVisualDer.Text) < 1) || (int.Parse(txtAgudezaVisualDer.Text) > 10))
            {
                lblMensaje.Text += "El campo Agudeza visual Derecha debe ser mayor a 1 y menor a 10. <br/>";
                hayError = true;
                TablaErrores.Visible = true;
            }

            if ((int.Parse(txtTalla.Text) < 75) || (int.Parse(txtTalla.Text) > 190))
            {
                lblMensaje.Text += "El campo Talla alumno no pude ser menor a 75 o mayor de 190. <br/>";
                hayError = true;
                TablaErrores.Visible = true;
            }

            if (ddlPercentiloIMC.SelectedValue == "SD")
            {
                lblMensaje.Text += "El campo Percentilo IMC Alumno no puede estar vacío. <br/>";
                hayError = true;
                TablaErrores.Visible = true;
            }

            if (ddlPercentiloTalla.SelectedValue == "SD")
            {
                lblMensaje.Text += "El campo Percentilo Talla no puede estar vacío. <br/>";
                hayError = true;
                TablaErrores.Visible = true;
            }

            if (int.Parse(txtValorTato.Text) > 20)
            {
                lblMensaje.Text += "El campo valor Tato no puede ser > 20 <br/>";
                hayError = true;
                TablaErrores.Visible = true;
            }

            return hayError;
        }

        protected void chekVacCompleta0_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void MostrarDatos(int idProsame)
        {
            bool ver = SubSonic.Sugar.Web.QueryString<bool>("ver");
            //si es una lectura de datos desabilito el boton guardar
            if (ver == true)
            {
                btnGuardar.Visible = false;
                btnCancelar.Visible = false;
                btnCerrar.Visible = true;
                btnGuardarParentezco.Visible = false;
            }

            DalRis.PsmDato oDato = new DalRis.PsmDato(idProsame);
            if (!oDato.IsNew)
            {
                txtFechaInicio.Value = DateTime.Parse(oDato.FechaFicha.ToString()).ToShortDateString();
                lidPaciente.Text = oDato.IdPaciente.ToString();
                ldniPaciente.Text = oDato.DNIPaciente.ToString();
                lPaciente.Text = oDato.PacNombre.ToString();
                lSexo.Text = oDato.Sexo;
                lFechaNacimiento.Text = DateTime.Parse(oDato.FechaNac.ToString()).ToShortDateString();
                if (oDato.Edad != null)
                {
                    lEdad.Text = oDato.Edad.ToString();
                    int age = int.Parse(oDato.Edad.ToString());
                    if (age > 6) // 
                    {
                        txtOMaloC.Enabled = true;
                        txtOMaloP.Enabled = true;
                        txtOMaloO.Enabled = true;
                        txtOHPerC.Enabled = false;
                        txtOHPerE.Enabled = false;
                        txtOHPerO.Enabled = false;
                    }
                    else
                    {
                        txtOMaloC.Enabled = false;
                        txtOMaloP.Enabled = false;
                        txtOMaloO.Enabled = false;
                        txtOHPerC.Enabled = true;
                        txtOHPerE.Enabled = true;
                        txtOHPerO.Enabled = true;
                    }
                }
                else
                {
                    lEdad.Text = "";
                    //muestro estos datos como si fuese edad > 6
                    txtOMaloC.Enabled = false;
                    txtOMaloP.Enabled = false;
                    txtOMaloO.Enabled = false;
                    txtOHPerC.Enabled = true;
                    txtOHPerE.Enabled = true;
                    txtOHPerO.Enabled = true;
                }

                lDomicilio.Text = oDato.Domicilio;
                lTelefono.Text = oDato.Telefono;
                lblCelular.Text = oDato.Celular;

                //OSociales.setOS(int.Parse(oDato.PacOSocial.ToString()));
                if (oDato.PacOSocial > 0) OSociales.setOS(int.Parse(oDato.PacOSocial.ToString()));

                ddlLocalidad.SelectedValue = oDato.IdLocalidad.ToString();
                ddlProvincia.SelectedValue = oDato.IdProvincia.ToString();
                ddlDepartamento.SelectedValue = oDato.IdDepartamento.ToString();

                ddlEstablecimiento.SelectedValue = oDato.IdEstablecimiento.ToString();
                ddlPrematuro.SelectedValue = oDato.Prematuro.ToString();
                txtPesoNacimiento.Text = oDato.Peso.ToString();
                txtTutorDNI.Text = oDato.TutorDNI.ToString();
                txtNombre.Text = oDato.TutorNombre.ToString();
                ddlSobreedad.SelectedValue = oDato.SobreEdad;
                ddlRepitente.SelectedValue = oDato.Repitente;
                //ddlZonaEstudio.SelectedValue = oDato.ZonaEstudio.ToString();
                switch (oDato.ZonaEstudio.ToString())
                {
                    case "SD": ddlZonaEstudio.SelectedValue = "SD";
                        break;
                    case "Urb": ddlZonaEstudio.SelectedValue = "Urb";
                        break;
                    case "Rur": ddlZonaEstudio.SelectedValue = "Rur";
                        break;
                }

                //evaluacion antropologica
                txtPesoAlumno.Text = oDato.PesoAlumno.ToString();
                txtTalla.Text = oDato.Talla.ToString();
                txtIMC.Text = oDato.Imc.ToString();
                txtTAMax.Text = oDato.TaMax.ToString();
                txtTAMin.Text = oDato.TaMin.ToString();
                //txtPersentiloPeso.Text = oDato.PercentiloPeso.ToString();

                //ddlPercentiloTalla.SelectedValue = oDato.PercentiloTalla.ToString();
                if (oDato.PercenTalla != null)
                {
                    switch (oDato.PercenTalla.ToString())
                    {
                        case "SD": ddlPercentiloTalla.SelectedValue = "SD";
                            break;
                        case "<3": ddlPercentiloTalla.SelectedValue = "<3";
                            break;
                        case ">=3": ddlPercentiloTalla.SelectedValue = ">=3";
                            break;
                    }
                }

                if (oDato.PercentiloIMC != null)
                {
                    switch (oDato.PercentiloTalla.ToString())
                    {
                        case "SD": ddlPercentiloIMC.SelectedValue = "SD";
                            break;
                        case "Menor a 3": ddlPercentiloIMC.SelectedValue = "Menor a 3";
                            break;
                        case "Entre 3 y 9": ddlPercentiloIMC.SelectedValue = "Entre 3 y 9";
                            break;

                        case "Entre 10 y 84": ddlPercentiloIMC.SelectedValue = "Entre 10 y 84";
                            break;

                        case "Entre 85 y 97": ddlPercentiloIMC.SelectedValue = "Entre 85 y 97";
                            break;

                        case "Mayor a 97": ddlPercentiloIMC.SelectedValue = "Mayor a 97";
                            break;
                    }
                }

                //ddlPerPas.SelectedValue = oDato.PercentiloMax.ToString();
                switch (oDato.PercentiloMax.ToString())
                {
                    case "SD": ddlPerPas.SelectedValue = "SD";
                        break;
                    case "<90": ddlPerPas.SelectedValue = "<90";
                        break;
                    case ">=90": ddlPerPas.SelectedValue = ">=90";
                        break;
                }
                //ddlPerPad.SelectedValue = oDato.PercentiloMin.ToString();
                switch (oDato.PercentiloMin.ToString())
                {
                    case "SD": ddlPerPad.SelectedValue = "SD";
                        break;
                    case "<90": ddlPerPad.SelectedValue = "<90";
                        break;
                    case ">=90": ddlPerPad.SelectedValue = ">=90";
                        break;
                }

                ddlPielFaneras.SelectedValue = oDato.EFPielFanera.ToString();
                ddlCardiovascular.SelectedValue = oDato.EFCardiovascular.ToString();
                ddlRespiratorio.SelectedValue = oDato.EFRespiratorio.ToString();

                if (lSexo.Text != "sd")
                {
                    if ((lSexo.Text == "M") || (lSexo.Text == "I"))
                    {
                        pnGenitourinarioM.Visible = true;
                        pnGenitourinarioF.Visible = false;
                        ddlGenitalM.SelectedValue = oDato.EFGenitalM.ToString();
                        txtGenitourinarioM.Text = oDato.EFOtroGenitourinarioM.ToString();
                    }
                    else
                    {
                        pnGenitourinarioF.Visible = true;
                        pnGenitourinarioM.Visible = false;
                        ddlGenitalF.SelectedValue = oDato.EFGenitalF.ToString();
                        txtGenitourinarioF.Text = oDato.EFOtroGenitourinarioF.ToString();
                    }
                }

                ddlAbdomen.SelectedValue = oDato.EFAbdomen.ToString();
                //ddlAbdomen.SelectedValue = oDato.EFAbdomen.ToString();
                ddlOstocular.SelectedValue = oDato.EFOsteoarticular.ToString();
                ddlNeurologico.SelectedValue = oDato.EFNeurologico.ToString();
                ddlPartesBlandas.SelectedValue = oDato.EFPartesBlandas.ToString();
                ddlSaludVisual.SelectedValue = oDato.EFSaludVisual.ToString();
                ddlFonacion.SelectedValue = oDato.EFSaludFonoAudio.ToString();

                txtPielFanera.Text = oDato.EFOtroPielFanera.ToString();
                txtPartesBlandas.Text = oDato.EFOtroPartesBlandas.ToString();
                txtCardiovascular.Text = oDato.EFOtroCardiovascular.ToString();
                txtRespiratorio.Text = oDato.EFOtroRespiratorio.ToString();
                txtAbdominal.Text = oDato.EFOtroAbdominal.ToString();

                txtOsteoarticular.Text = oDato.EFOtroOstreocular.ToString();
                txtNeurologico.Text = oDato.EFOtroNeurologico.ToString();
                txtSaludVisual.Text = oDato.EFOtroSaludVisual.ToString();
                txtSaludFono.Text = oDato.EFOtroSaludFonoAudio.ToString();

                ddlTrajoCarnet.SelectedValue = oDato.VacunaCarne.ToString();
                ddlVaunaCompleto.SelectedValue = oDato.VacunaCompleta.ToString();
                ddlVaunaCompleto.SelectedValue = oDato.VacunaCompleta.ToString();
                ddlSeVacunoEscuela.SelectedValue = oDato.VacSevacEsc.ToString();

                ddlEstravismo.Text = oDato.Estravismo.ToString();
                ddlUsaLentes.Text = oDato.UsaLentes.ToString();
                txtAgudezaVisualIzq.Text = oDato.AgudezaVisualIzq.ToString();
                txtAgudezaVisualDer.Text = oDato.AgudezaVisualDer.ToString();

                if (oDato.FonoAudiometria == "Si")
                {
                    chekAudimotria.Checked = true;
                }
                else
                {
                    chekAudimotria.Checked = false;
                }
                if (oDato.FonoTato == "Si")
                {
                    chekTato.Checked = true;
                }
                else
                {
                    chekTato.Checked = false;
                }
                if (chekDiapason.Checked == true)
                {
                    oDato.FonoDiapason = "Si";
                }
                else
                {
                    oDato.FonoDiapason = "No";
                }

                txtValorTato.Text = oDato.TatoValor.ToString();
                ddlHipoacusia.SelectedValue = oDato.Hipoacusia.ToString();
                ddlFonacion.SelectedValue = oDato.TransFonacion.ToString();
                lSexo.Text = oDato.Sexo.ToString();

                ddlEstravismo.Text = oDato.Estravismo.ToString();

                if (oDato.FechaOdonto != Convert.ToDateTime("01/01/1900"))
                    txtFechaOdonto.Value = DateTime.Parse(oDato.FechaOdonto.ToString()).ToShortDateString();
                else txtFechaOdonto.Value = "";
                ddlHabitPerniciosos.SelectedValue = oDato.OdontoHabitosPernciosos.ToString();
                ddlMaloclusion.SelectedValue = oDato.OdontoMaloclusion.ToString();
                ddlFluorAplicado.SelectedValue = oDato.OdontoFluorAplicado.ToString();
                ddlTecnicaHigBucal.SelectedValue = oDato.OdontoEnsTecnicaBucal.ToString();

                ddlEscolaridad.SelectedValue = oDato.IdEscolaridad.ToString();
                ddlGrado.SelectedValue = oDato.IdGrado.ToString();
                ddlDivision.SelectedValue = oDato.IdDivision.ToString();
                ddlTurno.SelectedValue = oDato.Turno.ToString();

                txtOHPerC.Text = oDato.OHPerC.ToString();
                txtOHPerE.Text = oDato.OHPerE.ToString();
                txtOHPerO.Text = oDato.OHPerO.ToString();

                txtOMaloC.Text = oDato.OMaloC.ToString();
                txtOMaloP.Text = oDato.OMaloP.ToString();
                txtOMaloO.Text = oDato.OMaloO.ToString();

                //txtOHPerO.Text = oDato.OHPerO.ToString();
                if (oDato.OdontoCariado != null)
                    txtCareado.Text = oDato.OdontoCariado.ToString();
                else txtCareado.Text = "";
                txtObservaciones.Text = oDato.Observaciones.ToString();
                txtObservacionesGenerales.Text = oDato.ObservacionesGeneral.ToString();
                ddlResponsableFicha.SelectedValue = oDato.IdProfesionalFicha.ToString();
                ddlResponsableOdonto.SelectedValue = oDato.IdProfesionalOdonto.ToString();
                oDato.MotivoRechazo = ddlMotivoRechazo.SelectedIndex.ToString();
                ddlMotivoRechazo.SelectedValue = oDato.MotivoRechazo.ToString();

                //traer las derivaciones en check
                CargarDerivaciones(idProsame);
            }
        }

        protected void ChkDerTrabSocial_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void calculaIMC()
        {
            Boolean vVerificaNumerico = true;
            if (vVerificaNumerico == true)
            {
                CultureInfo ci = CultureInfo.InvariantCulture;

                //calculo interno del IMC, si tengo peso y talle
                decimal peso = decimal.Parse(txtPesoAlumno.Text.Replace(",", "."), ci); //kilogramos
                decimal talle = decimal.Parse(txtTalla.Text.Replace(",", "."), ci); //metros
                if ((peso > 0) && (talle > 0))
                {
                    decimal calculotalle = talle / 100;
                    decimal imc = Math.Round((peso / (calculotalle * calculotalle)), 2);
                    //imc = decimal.Parse(txtImc.Text.Replace(",","."),ci);
                    txtIMC.Text = imc.ToString();
                    txtTAMax.Focus();
                }
                else return;
            }
        }

        protected void btnCalcula_Click(object sender, EventArgs e)
        {
            calculaIMC();
        }

        //verifica expreciones regulares
        public Boolean verificarExpresionRegular(string tipoExpresion, string cadena)
        {
            Boolean resultado = false;

            if (cadena != "")
            {
                switch (tipoExpresion)
                {
                    case "Numerica":
                        Regex rex = new Regex("^[0-9]*$");
                        if (rex.IsMatch(cadena))
                            resultado = true;
                        break;
                }
            }
            return resultado;
        }

        protected void txtOHPerC_TextChanged(object sender, EventArgs e)
        {
            int vCariados = 0;
            vCariados = int.Parse(txtOHPerC.Text) + int.Parse(txtOMaloC.Text);
            txtCareado.Text = vCariados.ToString();
        }

        protected void ChkDerORL_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void ddlAllazgoPiel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlAllazgoPiel.SelectedValue == "Sin hallazgos ")
            {
                ddlPielFaneras.Enabled = false;
                txtPielFanera.Visible = false;
            }
            else
            {
                ddlPielFaneras.Enabled = true;
                txtPielFanera.Visible = true;
            }
        }

        protected void ddlHallazgoPartesBlandas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlHallazgoPartesBlandas.SelectedValue == "Sin hallazgos ")
            {
                ddlPartesBlandas.Enabled = false;
                txtPartesBlandas.Visible = false;
            }
            else
            {
                ddlPartesBlandas.Enabled = true;
                txtPartesBlandas.Visible = true;
            }
        }

        protected void ddHallazgoslCardiovascular_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddHallazgoslCardiovascular.SelectedValue == "Sin hallazgos ")
            {
                ddlCardiovascular.Enabled = false;
                txtCardiovascular.Visible = false;
            }
            else
            {
                ddlCardiovascular.Enabled = true;
                txtCardiovascular.Visible = true;
            }
        }

        protected void ddHallazgosRespiratorio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddHallazgosRespiratorio.SelectedValue == "Sin hallazgos ")
            {
                ddlRespiratorio.Enabled = false;
                txtRespiratorio.Visible = false;
            }
            else
            {
                ddlRespiratorio.Enabled = true;
                txtRespiratorio.Visible = true;
            }
        }

        protected void ddHallazgosAbdominal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddHallazgosAbdominal.SelectedValue == "Sin hallazgos ")
            {
                ddlAbdomen.Enabled = false;
                txtAbdominal.Visible = false;
            }
            else
            {
                ddlAbdomen.Enabled = true;
                txtAbdominal.Visible = true;
            }
        }

        protected void ddHallazgosGenitourinarioM_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddHallazgosGenitourinarioM.SelectedValue == "Sin hallazgos ")
            {
                ddlGenitalM.Enabled = false;
                txtGenitourinarioM.Visible = false;
            }
            else
            {
                ddlGenitalM.Enabled = true;
                txtGenitourinarioM.Visible = true;
            }
        }

        protected void ddHallazgosGenitourinarioF_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddHallazgosGenitourinarioF.SelectedValue == "Sin hallazgos ")
            {
                ddlGenitalF.Enabled = false;
                txtGenitourinarioF.Visible = false;
            }
            else
            {
                ddlGenitalF.Enabled = true;
                txtGenitourinarioF.Visible = true;
            }
        }

        protected void ddHallazgosOsteoarticular_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddHallazgosOsteoarticular.SelectedValue == "Sin hallazgos ")
            {
                ddlOstocular.Enabled = false;
                txtOsteoarticular.Visible = false;
            }
            else
            {
                ddlOstocular.Enabled = true;
                txtOsteoarticular.Visible = true;
            }
        }

        protected void ddHallazgosNeurologico_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddHallazgosNeurologico.SelectedValue == "Sin hallazgos ")
            {
                ddlNeurologico.Enabled = false;
                txtNeurologico.Visible = false;
            }
            else
            {
                ddlNeurologico.Enabled = true;
                txtNeurologico.Visible = true;
            }
        }

        protected void ddHallazgosSaludVisual_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddHallazgosSaludVisual.SelectedValue == "Sin hallazgos ")
            {
                ddlSaludVisual.Enabled = false;
                txtSaludVisual.Visible = false;
            }
            else
            {
                ddlSaludVisual.Enabled = true;
                txtSaludVisual.Visible = true;
            }
        }

        protected void ddHallazgosSaludFono_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddHallazgosSaludFono.SelectedValue == "Sin hallazgos ")
            {
                ddlSaludFonoAudiologica.Enabled = false;
                txtSaludFono.Visible = false;
            }
            else
            {
                ddlSaludFonoAudiologica.Enabled = true;
                txtSaludFono.Visible = true;
            }
        }

        protected void ddlPielFaneras_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void txtTalla_TextChanged(object sender, EventArgs e)
        {
            calculaIMC();
            //calculo automatico Percentilo Talla
            //esto hay que sacarlo de las tablas del niño sano

            //calculo automatico Percentilo IMC
            if (txtIMC.Text != "")
            {
                decimal imc = Convert.ToDecimal(txtIMC.Text);
                imc = Math.Round(imc);
                int vimc = Convert.ToInt32(imc);

                if (vimc < 3) ddlPercentiloIMC.SelectedValue = "Menor a 3";
                else
                {
                    if ((vimc >= 3) && (vimc <= 9)) ddlPercentiloIMC.SelectedValue = "Entre 3 y 9";
                    else
                    {
                        if ((vimc >= 10) && (vimc <= 84)) ddlPercentiloIMC.SelectedValue = "Entre 10 y 84";
                        else
                        {
                            if ((vimc >= 85) && (vimc <= 97)) ddlPercentiloIMC.SelectedValue = "Entre 85 y 97";
                            else
                            {
                                if (vimc > 97) ddlPercentiloIMC.SelectedValue = "Mayor a 97";
                            }
                        }
                    }
                }
            }
        }

        protected void txtTAMax_TextChanged(object sender, EventArgs e)
        {
            //calculo el Percentilo PAS segun valor del Pas
            if (txtTAMax.Text != "")
            {
                int pas = Convert.ToInt32(txtTAMax.Text);
                if (pas < 90) ddlPerPas.SelectedValue = "<90";
                else
                {
                    if (pas >= 90) ddlPerPas.SelectedValue = ">=90";
                    else ddlPerPas.SelectedValue = "SD";
                }
            }
        }

        protected void txtTAMin_TextChanged(object sender, EventArgs e)
        {
            //calculo el Percentilo PAD segun valor del Pad
            if (txtTAMin.Text != "")
            {
                int pad = Convert.ToInt32(txtTAMin.Text);
                if (pad < 90) ddlPerPad.SelectedValue = "<90";
                else
                {
                    if (pad >= 90) ddlPerPad.SelectedValue = ">=90";
                    else ddlPerPad.SelectedValue = "SD";
                }
            }
        }
    }
}