using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using DalRis;
using System.Data;
using System.Text;

namespace RIS_Publico
{
    public partial class InformeEstudio : System.Web.UI.Page
    {
        // -----------------------------------------------------------------------------------------------------------

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;
            cargarDatos();
            chkItemsDesaprobadosCAIBSH.Enabled = false;
        }

        // -----------------------------------------------------------------------------------------------------------

        private void cargarItemsDesaprobadosCAIBSH()
        {
            // Cargo los datos desde RIS_ItemDesaprobados CAIBHS
            chkItemsDesaprobadosCAIBSH.DataSource = SPs.RisCargarCheckBoxItemsDesaprobados().GetDataSet().Tables[0];
            chkItemsDesaprobadosCAIBSH.DataBind();

            // Cargo los checkboxs que corresponden respecto de RIS_EstudioItemsDesaprobado
            DataTable dtCheckboxsItemsDesaprobados = new DataTable();
            dtCheckboxsItemsDesaprobados = SPs.RisCargarCheckBoxEstudioItemsDesaprobados(int.Parse(Request["idEstudio"].ToString())).GetDataSet().Tables[0];

            for (int i = 0; i < chkItemsDesaprobadosCAIBSH.Items.Count; i++)
            {
                int j = 0;
                foreach (DataRow drCheckboxsActivos in dtCheckboxsItemsDesaprobados.Rows)
                {
                    if (int.Parse(chkItemsDesaprobadosCAIBSH.Items[i].Value) == int.Parse(dtCheckboxsItemsDesaprobados.Rows[j][2].ToString()))
                    {
                        chkItemsDesaprobadosCAIBSH.Items[i].Selected = true;
                        break;
                    }
                    j = j + 1;
                }
            }
        }

        // -----------------------------------------------------------------------------------------------------------

        public void cargarDatos()
        {
            RisEstudio oEstudio = new RisEstudio(int.Parse(Request["idEstudio"].ToString().Trim()));

            Label1.Text = "<strong>Nro. de inscripcion: </strong>" + oEstudio.NroOrden.ToString() + "." + oEstudio.Enmienda.ToString() + "." + oEstudio.Anio.ToString();

            // Investigadores
            DataTable dtInvestigadores = new DataTable();
            dtInvestigadores = SPs.RisCargarListaInvestigadores(int.Parse(Request["idEstudio"].ToString().Trim())).GetDataSet().Tables[0];
            gvListaInvestigadores.DataSource = dtInvestigadores;
            gvListaInvestigadores.DataBind();
            
            Label5.Text = "<strong>Título de la investigación: </strong>" + oEstudio.TituloInvestigacion.ToString();
            Label6.Text = "<strong>Nro. de registro nacional: </strong>" + oEstudio.NroRegistroNacional.ToString();
            Label7.Text = "<strong>Tipo de estudio: </strong>" + oEstudio.TipoEstudio.ToString();
            Label8.Text = "<strong>Nro. de expediente: </strong>" + oEstudio.NroExpediente.ToString();
            Label9.Text = "<strong>Nombre abreviado: </strong>" + oEstudio.NombreAbreviado.ToString();
            Label10.Text = "<strong>Drogas en estudio: </strong>" + oEstudio.Drogas.ToString();

            // Entidad
            DataTable dtEntidad = new DataTable();
            dtEntidad = SPs.RisCargarListaEntidades(int.Parse(Request["idEstudio"].ToString().Trim())).GetDataSet().Tables[0];
            gvListaEntidad.DataSource = dtEntidad;
            gvListaEntidad.DataBind();

            // Consentimientos
            DataTable dtConsentimientos = new DataTable();
            dtConsentimientos = SPs.RisCargarListaConcentimientos(int.Parse(Request["idEstudio"].ToString().Trim())).GetDataSet().Tables[0];
            gvListaConsentimiento.DataSource = dtConsentimientos;
            gvListaConsentimiento.DataBind();

            // Enmiendas
            DataTable dtEnmiendas = new DataTable();
            dtEnmiendas = SPs.RisCargarListaEnmiendas(int.Parse(Request["idEstudio"].ToString().Trim())).GetDataSet().Tables[0];
            gvListaEnmiendas.DataSource = dtEnmiendas;
            gvListaEnmiendas.DataBind();

            // Institución de referencia
            Label14.Text = "<strong>Nombre: </strong>" + oEstudio.NombreIntitucionAfiliacion.ToString();
            Label15.Text = "<strong>Referente: </strong>" + oEstudio.ReferenteInstitucionAfiliacion.ToString();
            Label16.Text = "<strong>Teléfono: </strong>" + oEstudio.TelefonoInstitucionAfiliacion.ToString();
            Label17.Text = "<strong>Domicilio: </strong>" + oEstudio.DomicilioInstitucionAfiliacion.ToString();
            Label18.Text = "<strong>E-mail: </strong>" + oEstudio.EmailInstitucionAfiliacion.ToString();

            // Area temática
            Label20.Text = oEstudio.IdAreaTematica.ToString();

            // Tamaño de la muestra
            Label22.Text = oEstudio.TamanioMuestra.ToString().Trim();

            // Duración (tiempo estimado desde el inicio)
            Label24.Text = "Años: " + oEstudio.TiempoEstimadoAnios.ToString();
            Label25.Text = "Meses: " + oEstudio.TiempoEstimadoMeses.ToString();

            // Lugares de realización
            DataTable dtLugaresDeRealizacion = new DataTable();
            dtLugaresDeRealizacion = SPs.RisCargarListaLugaresRealizacion(int.Parse(Request["idEstudio"].ToString().Trim())).GetDataSet().Tables[0];
            gvListaLugaresDeRealizacion.DataSource = dtLugaresDeRealizacion;
            gvListaLugaresDeRealizacion.DataBind();

            // Seguro de daños
            DataTable dtSeguroDanios = new DataTable();
            dtSeguroDanios = SPs.RisCargarListaAseguradoras(int.Parse(Request["idEstudio"].ToString().Trim())).GetDataSet().Tables[0];
            gvListaAseguradora.DataSource = dtSeguroDanios;
            gvListaAseguradora.DataBind();
            
            // Comité de ética
            DataTable dtComiteEtica = new DataTable();
            dtComiteEtica = SPs.RisCargarListaComiteEtica(int.Parse(Request["idEstudio"].ToString().Trim())).GetDataSet().Tables[0];
            gvListaComiteEtica.DataSource = dtComiteEtica;
            gvListaComiteEtica.DataBind();

            // Informe de la comisión de investigaciones biomédicas en seres humanos (CAIBSH)

            // Aprobado
            Label30.Text = "<strong>Fecha Aprobado: </strong>" + oEstudio.FechaAprobadoCAIBSH.ToString();

            DataTable dtListaInformeAprobado = new DataTable();
            dtListaInformeAprobado = SPs.RisCargarListaInformeAprobado(int.Parse(Request["idEstudio"].ToString().Trim())).GetDataSet().Tables[0];
            gvListaInformeAprobado.DataSource = dtListaInformeAprobado;
            gvListaInformeAprobado.DataBind();

            // Rechazado
            Label31.Text = "<strong>Fecha Rechazado: </strong>" + oEstudio.FechaRechazadoCAIBSH.ToString();
            cargarItemsDesaprobadosCAIBSH();

            // Observaciones
            Label34.Text = "<strong>Observaciones: </strong>" + oEstudio.ObservacionesCAIBSH;
        }

        // -----------------------------------------------------------------------------------------------------------

        protected void btnCerrar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx", false);
        }

        // -----------------------------------------------------------------------------------------------------------
    }
}