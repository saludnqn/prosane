using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using DALAutomotores;
using System.IO;
using CrystalDecisions.Web;
using Salud.Security.SSO;

namespace Web.Vehiculos
{
    public partial class Prosame : System.Web.UI.Page
    {
        // La defino como "Global" ;-)

         CrystalReportSource oCr = new  CrystalReportSource();
        // -----------------------------------------------------------------------------------------------------------

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                TablaErrores.Visible = false;
                cargarCombos();

                if (Request["idNotaPedido"] != null) // m o d i f i c a c i ó n   d e l   v e h í c u l o
                {
                    inputFecha.Disabled = true;
                    //panelFechaUltimaLectura.Visible = false;
                    //lblFechaUltimaLectura.Visible = true;
                }
                else
                {
                    //inputFecha.Disabled = false;
                    inputFecha.Value = DateTime.Now.ToShortDateString();
                    //panelFechaUltimaLectura.Visible = true;
                    //lblFechaUltimaLectura.Visible = false;
                }

                if (Session["idUsuario"] != null)
                {
                    // Esta sentencia tiene la inteligencia como para tomar el parámetro quer paso en la url.
                    // Si no paso un parámetro devuelve 0, caso contrario devuelve el ID que paso como parámetro.                    
                    int idOrdenReparacion = SubSonic.Sugar.Web.QueryString<int>("idOrdenReparacion");

                    MostrarDatos(idOrdenReparacion);
                }
            }
        }

        // -----------------------------------------------------------------------------------------------------------
        private void cargarCombos()
        {
            // -------------------------------------------------------------------------------

            //ddlTipoVehiculo.DataSource = AutTipoVehiculo.FetchAll();
            //ddlTipoVehiculo.DataBind();

            // -------------------------------------------------------------------------------

            //ddlDireccion.DataSource = AutDireccione.FetchAll();
            //ddlDireccion.DataBind();


            ddlDominio.DataSource = AutVehiculo.FetchAll();
            ddlDominio.DataBind();
            ddlDominio.Items.Insert(0, new ListItem("Seleccionar", "0"));


            ddlProveedor.DataSource = AutProveedor.FetchAll();
            ddlProveedor.DataBind();
            ddlProveedor.Items.Insert(0, new ListItem("Seleccionar", "0"));

            ddlEfector.DataSource = AutEntidad.FetchAll();
            ddlEfector.DataBind();
            ddlEfector.Items.Insert(0, new ListItem("Seleccionar", "0"));



            // -------------------------------------------------------------------------------

            //ddlModelo.DataSource = SPs.AutCargarComboModelosOrdenado().GetDataSet().Tables[0];
            //ddlModelo.DataBind();

            // -------------------------------------------------------------------------------

            //SysUsuario oUsuario = new SysUsuario(int.Parse(Session["idUsuario"].ToString()));
            //int entidad = oUsuario.IdEfector;
            int entidad = SSOHelper.CurrentIdentity.IdEfector;
            AutEntidad oEntidad = new AutEntidad(entidad);

            // 1 Centro de Salud
            // 2 Hospital
            // 3 Puesto Sanitario
            // 4 Zona Sanitaria
            // 5 SubSecretaria de Salud
            // 6 Otro

            switch (oEntidad.IdTipoEntidad)
            {
            //    case 1:
            //        ddlEfector.Enabled = false;
            //        break;
            //    case 2:
            //        ddlEfector.DataSource = SPs.AutCargarComboEntidadesOrdenadoParaHospital(oEntidad.IdEntidad).GetDataSet().Tables[0];
            //        ddlEfector.DataBind();
            //        ddlEfector.Items.Insert(0, new ListItem("Seleccionar", "0"));

            //        break;
            //    case 3:
            //        ddlEfector.Enabled = false;
            //        break;
            //    case 4:
            //        ddlEfector.DataSource = SPs.AutCargarComboEntidadesOrdenadoParaZona(oEntidad.IdZona).GetDataSet().Tables[0];
            //        ddlEfector.DataBind();
            //        ddlEfector.Items.Insert(0, new ListItem("Seleccionar", "0"));

            //        break;
            //    case 5:
            //        ddlEfector.DataSource = SPs.AutCargarComboEntidadesOrdenadoParaSubsecretaria().GetDataSet().Tables[0];
            //        ddlEfector.DataBind();
            //        ddlEfector.Items.Insert(0, new ListItem("Seleccionar", "0"));

            //        break;
            //    case 6:
            //        // ,nota: No considero este caso, ya que no existe un usuario en (Sys_Usuarios) que tenga este valor (6).
            //        //        El valor es exclusivo de este sistema.
            //        break;
            }

            // -------------------------------------------------------------------------------------------------------
        }


        protected void LinkNuevoVehiculo_Click(object sender, EventArgs e)
        {
            int idOrdenReparacion = SubSonic.Sugar.Web.QueryString<int>("idOrdenReparacion");

            string url = "OrdenReparacionItems.aspx?idOrdenReparacion=" + idOrdenReparacion.ToString() + "&idOrdenReparacion=0";
            Response.Redirect(url, false);
        }


        // -----------------------------------------------------------------------------------------------------------

        private void MostrarDatos(int idOrdenReparacion)
        {
            //AutNotaPedido oNotaPedido = new AutNotaPedido(idNotaPedido);
            AutOrdenReparacion oOrdenReparacion = new AutOrdenReparacion(idOrdenReparacion);




            if (Request["idOrdenReparacion"] != null) // Modificación del vehículo
            {
                // ,nota: La idea es que cuando el usuario edita el registro, no debe poder modificar el odómetro y la fecha
                //        de actualización. Estos valores s e modifican en forma automática, con cada viaje.
                //        Solo son editables cuando se crea el vehículo.
                

                inputFecha.Value = oOrdenReparacion.Fecha.ToString();
                ddlDominio.SelectedValue = oOrdenReparacion.IdVehiculo.ToString();
                txtNotaPedido.Text = oOrdenReparacion.IdNotaPedido.ToString();
                txtKm.Text = oOrdenReparacion.Km.ToString();
                ddlProveedor.SelectedValue = oOrdenReparacion.IdProveedor.ToString();
                txtPresupuesto.Text = oOrdenReparacion.IdPresupuesto.ToString();
                ddlEfector.SelectedValue = oOrdenReparacion.IdEfector.ToString();
                //ddlEfector.SelectedValue = oOrdenReparacion.idIdEntidad.ToString();

                txtDescripcion.Text = oOrdenReparacion.Descripcion.ToString();
             
                txtObservacion.Text = oOrdenReparacion.Observacion.ToString();
                inputFechaInicio.Value = oOrdenReparacion.FechaInicio.ToString();
                inputFechaFin.Value=oOrdenReparacion.FechaFin.ToString();
                ddlEstadoORep.SelectedValue = oOrdenReparacion.Estado.ToString();

                DataTable dtBuscaVehiculo = new DataTable();
                dtBuscaVehiculo = SPs.AutBuscaVehiculo(oOrdenReparacion.IdVehiculo.ToString()).GetDataSet().Tables[0];
                lblDatoVehiculo.Text = dtBuscaVehiculo.Rows[0].ItemArray[2].ToString() + "   " + dtBuscaVehiculo.Rows[0].ItemArray[1].ToString(); //ddlEfector.DataSource = SPs.AutCargarComboEntidadesOrdenadoParaZona(int.Parse(ddlZona.SelectedValue)).GetDataSet().Tables[0];





                




            }
            else
            {
                //lblOdometro.Visible = false;
                //txtOdometroActual.Text = oVehiculo.OdometroActual.ToString();
                //lblFechaUltimaLectura.Visible = false;
                //inputFechaLecturaOdometro.Value = DateTime.Now.ToShortDateString();
            }
        }

        // -----------------------------------------------------------------------------------------------------------

        private bool hayError()
        {
            bool hayError = false;
            lblMensaje.Text = "";
            TablaErrores.Visible = false;


            // ------------------------------------------------------------------------
            // Verifico nota de pedido que no este en otra orden de reparacion
            // ------------------------------------------------------------------------

            //int idOrdenReparacion = SubSonic.Sugar.Web.QueryString<int>("idOrdenReparacion");
            //AutOrdenReparacion oOrdenReparacion = new AutOrdenReparacion(idOrdenReparacion);



            //DataTable dtBuscaNotaPedidoORep = new DataTable();

            //dtBuscaNotaPedidoORep = SPs.AutpBuscaNotaPedidoORep(txtNotaPedido.Text).GetDataSet().Tables[0];
            lMensaje.Text = "";

            //if (inputFecha.Value < inputFechaFin.Value)





            if (txtNotaPedido.Text == "")
            {
                //MessageBox.Show("Seleccione Dominio del Vehiculo");
                lblMensaje.Text = "Nro de nota de Pedido Incompleta";
                hayError = true;
                TablaErrores.Visible = true;
            }   

        
            DataTable dtNotaPedido = new DataTable();
            dtNotaPedido = SPs.AutpBuscaNotaPedido(txtNotaPedido.Text).GetDataSet().Tables[0];
            lMensaje.Text = "";

            if (dtNotaPedido.Rows.Count == 0)  // ,nota: Verifico si existen resultados para el paciente.
            {
                //ddlDominio.SelectedIndex = int.Parse(dtNotaPedido.Rows[0].ItemArray[5].ToString());

                lblMensaje.Text = "Seleccione Nro de Nota de Pedido existente";
                hayError = true;
                TablaErrores.Visible = true;

            }


            if (this.inputFecha.Value.CompareTo(this.inputFechaFin.Value) == 0) 
                {
                    lblMensaje.Text = "Fecha de inicio no puede ser menor a la fecha de fin del trabajo";
                    hayError = true;
                    TablaErrores.Visible = true;
                }

            if (ddlDominio.SelectedValue == "0")
            {
                lblMensaje.Text = "Seleccione Dominio del Vehiculo";
                hayError = true;
                TablaErrores.Visible = true;
            }

            if (ddlEfector.SelectedValue == "0")
            {
                lblMensaje.Text = "Seleccione Efector";
                hayError = true;
                TablaErrores.Visible = true;
            }

            if (ddlProveedor.SelectedValue == "0")
            {
                //MessageBox.Show("Seleccione Dominio del Vehiculo");
                lblMensaje.Text = "Seleccione Proveedor";
                hayError = true;
                TablaErrores.Visible = true;
            }
            if (txtKm.Text == "")
            {
                //MessageBox.Show("Seleccione Dominio del Vehiculo");
                lblMensaje.Text = "Ingrese algun valor a los km";
                hayError = true;
                TablaErrores.Visible = true;
            }        




            //daniel san, decime como hago para comparar el valor de esta varible idordenreparacion en este if
            //if (idOrdenReparacion = 0) 
            //    {
            //    if (dtBuscaNotaPedidoORep.Rows.Count != 0)  // ,nota: Verifico si existen resultados para el paciente.
            //        {
            //            lblMensaje.Text = "Nota Pedido usada en Orden reparacion " + int.Parse(dtBuscaNotaPedidoORep.Rows[0].ItemArray[0].ToString()) + " Vehiculo " + dtBuscaNotaPedidoORep.Rows[0].ItemArray[2].ToString() + " Efector " + dtBuscaNotaPedidoORep.Rows[0].ItemArray[3].ToString();
            //            hayError = true;
            //            TablaErrores.Visible = true;
            //        }
            //    }
            // ------------------------------------------------------------------------
            // Verifico que el año no sea vacío
            // ------------------------------------------------------------------------

            //if (txtAnio.Text == "")

            //{
            //    lblMensaje.Text += "El Año no puede ser vacío. <br/>";
            //    hayError = true;
            //    TablaErrores.Visible = true;
            //}

            // ------------------------------------------------------------------------
            // Verifico que no exista el nro. de Matrícula en otro registro en la base.
            // ------------------------------------------------------------------------

            //if (txtMatricula.Text != "")
            //{
            //    SubSonic.Select pMatricula = new SubSonic.Select();
            //    pMatricula.From(AutVehiculo.Schema);
            //    pMatricula.Where(AutVehiculo.Columns.Matricula).IsEqualTo(txtMatricula.Text);

            //    DataTable dtMatricula = pMatricula.ExecuteDataSet().Tables[0];

            //    if ((Request["idVehiculo"] == null) && (dtMatricula.Rows.Count > 0))
            //    {
            //        lblMensaje.Text += "El Número de Matrícula ya esta asignado a un vehículo. <br/>";
            //        hayError = true;
            //        TablaErrores.Visible = true;
            //    }
            //}

            // --------------------------------------------------------------
            // Verifico que no exista el Dominio en otro registro en la base.
            // --------------------------------------------------------------
            //if (txtDominio.Text != "")
            //{
            //    SubSonic.Select pDominio = new SubSonic.Select();
            //    pDominio.From(AutVehiculo.Schema);
            //    pDominio.Where(AutVehiculo.Columns.Dominio).IsEqualTo(txtDominio.Text);

            //    DataTable dtDominio = pDominio.ExecuteDataSet().Tables[0];

            //    if ((Request["idVehiculo"] == null) && (dtDominio.Rows.Count > 0))
            //    {
            //        lblMensaje.Text += "El Dominio ya esta asignado a un vehículo. <br/>";
            //        hayError = true;
            //        TablaErrores.Visible = true;
            //    }
            //}
            //else
            //{
            //    lblMensaje.Text += "El Dominio no puede ser vacío. <br/>";
            //    hayError = true;
            //    TablaErrores.Visible = true;
            //}

            // ----------------------------------------------------------------
            // Fecha del odómetro
            // ----------------------------------------------------------------
            if (Request["idVehiculo"] == null) // Nuevo Vehículo
            {
                //if (inputFechaLecturaOdometro.Value == "")
                //{
                //    lblMensaje.Text += "El campo 'Fecha de la última lectura' del odómetro no puede ser vacío. <br/>";
                //    hayError = true;
                //    TablaErrores.Visible = true;
                //}
            }

            // ----------------------------------------------------------------
            // Verifico que el Nro. de Motor y el Nro. de Chasis no sean vacíos
            // ----------------------------------------------------------------
            //if (txtNumeroMotor.Text == "")
            //{
            //    lblMensaje.Text += "El campo 'Nro. de Motor' no puede ser vacío. <br/>";
            //    hayError = true;
            //    TablaErrores.Visible = true;
            //}

            //if (txtNumeroChasis.Text == "")
            //{
            //    lblMensaje.Text += "El campo 'Nro. de Chasis' no puede ser vacío. <br/>";
            //    hayError = true;

            //    TablaErrores.Visible = true;
            //}

            // Respondo ...
            return hayError;
        }

        // -----------------------------------------------------------------------------------------------------------

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
           


            if ((Page.IsValid) && (!hayError()))
            {
                int idOrdenReparacion = SubSonic.Sugar.Web.QueryString<int>("idOrdenReparacion");

                AutOrdenReparacion oOrdenReparacion = new AutOrdenReparacion(idOrdenReparacion);

                oOrdenReparacion.Fecha = DateTime.Parse(inputFecha.Value)  ;
                oOrdenReparacion.IdVehiculo = int.Parse(ddlDominio.SelectedValue)  ;
                oOrdenReparacion.Km = int.Parse(txtKm.Text);
                oOrdenReparacion.IdNotaPedido = int.Parse(txtNotaPedido.Text);
                oOrdenReparacion.IdEfector = int.Parse(ddlEfector.SelectedValue);
                oOrdenReparacion.IdPresupuesto = int.Parse(txtPresupuesto.Text)  ;
                oOrdenReparacion.IdProveedor = int.Parse(ddlProveedor.SelectedValue);
                oOrdenReparacion.Descripcion = txtDescripcion.Text  ;
                oOrdenReparacion.Observacion = txtObservacion.Text;
                oOrdenReparacion.FechaInicio = DateTime.Parse(inputFechaInicio.Value);
                oOrdenReparacion.FechaFin = DateTime.Parse(inputFechaFin.Value);
                oOrdenReparacion.Estado = ddlEstadoORep.SelectedValue.ToString();
                oOrdenReparacion.Observacion = txtObservacion.Text;
                
                oOrdenReparacion.Save();

                // Vuelvo a la pantalla de búsqueda
                Response.Redirect("OrdenReparacion.aspx", false);
            }
        }

        protected void ddlEfector_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        protected void ddlProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        protected void txtNotaPedido_TextChanged(object sender, EventArgs e)
        {
            //DataTable dtNotaPedido = new DataTable();
            //dtNotaPedido = SPs.AutpBuscaNotaPedido(txtNotaPedido.Text).GetDataSet().Tables[0];
            //ddlDominio.SelectedIndex = int.Parse(dtNotaPedido.Rows[0].ItemArray[5].ToString());
            //DataTable dtDocumentoProfesional = new DataTable();
            //dtDocumentoProfesional = SPs.IcoObtenerIDProfesionalSegunDocumento(oUsuario.Documento).GetDataSet().Tables[0];
            //string IdDelProfesional = dtDocumentoProfesional.Rows[0].ItemArray[0].ToString().Trim(); // ,nota: Asumo que devuelve solo una fila.

            
            //ddlDominio.Text = SPs.autpb
            //ddlEfector.DataSource = SPs.AutCargarComboEntidadesOrdenadoParaZona(int.Parse(ddlZona.SelectedValue)).GetDataSet().Tables[0];
            //ddlEfector.DataBind();
            //ddlEfector.Items.Insert(0, new ListItem("Todos", "0"));
        }

        protected void txtNotaPedido_Disposed(object sender, EventArgs e)
        {
        }

        protected void btnBucaNotaPedido_Click(object sender, EventArgs e)
        {
            DataTable dtNotaPedido = new DataTable();
            dtNotaPedido = SPs.AutpBuscaNotaPedido(txtNotaPedido.Text).GetDataSet().Tables[0];
            lMensaje.Text = "";

            if (dtNotaPedido.Rows.Count != 0)  // ,nota: Verifico si existen resultados para el paciente.
            {
                ddlDominio.SelectedValue = dtNotaPedido.Rows[0].ItemArray[5].ToString();

                ddlEfector.SelectedValue = dtNotaPedido.Rows[0].ItemArray[2].ToString();
                txtObservacion.Text = dtNotaPedido.Rows[0].ItemArray[2].ToString();
            }
            else
            {
               lMensaje.Text = "No existe Nota de pedido " + txtNotaPedido.Text ;
               cargarCombos();
               txtObservacion.Text = "";



               //inputFecha.Value = oOrdenReparacion.Fecha.ToString();
               //ddlDominio.SelectedValue = oOrdenReparacion.IdVehiculo.ToString();
               //txtNotaPedido.Text = oOrdenReparacion.IdNotaPedido.ToString();
               //ddlProveedor.SelectedValue = oOrdenReparacion.IdProveedor.ToString();
               //txtPresupuesto.Text = oOrdenReparacion.IdPresupuesto.ToString();
               //txtDescripcion.Text = oOrdenReparacion.Descripcion.ToString();
               //txtObservacion.Text = oOrdenReparacion.Observacion.ToString();
               //inputFechaInicio.Value = oOrdenReparacion.FechaInicio.ToString();
               //inputFechaFin.Value = oOrdenReparacion.FechaFin.ToString();




            }
                

        }

        protected void ddlDominio_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            DataTable dtBuscaVehiculo = new DataTable();
            
                dtBuscaVehiculo = SPs.AutBuscaVehiculo(ddlDominio.SelectedValue.ToString()).GetDataSet().Tables[0];

            lblDatoVehiculo.Text = dtBuscaVehiculo.Rows[0].ItemArray[2].ToString() + "   " + dtBuscaVehiculo.Rows[0].ItemArray[1].ToString(); //ddlEfector.DataSource = SPs.AutCargarComboEntidadesOrdenadoParaZona(int.Parse(ddlZona.SelectedValue)).GetDataSet().Tables[0];
            //ddlEfector.DataBind();
            //ddlEfector.Items.Insert(0, new ListItem("Todos", "0"));
        }

        protected void btnImprimirListadoDeVehiculos_Click(object sender, EventArgs e)
        {


            int idOrdenReparacion = SubSonic.Sugar.Web.QueryString<int>("idOrdenReparacion");
            AutOrdenReparacion oOrdenReparacion = new AutOrdenReparacion(idOrdenReparacion);

            { oCr.Report.FileName = "../Reportes/FormOrdenReparacion.rpt"; }

            oCr.CacheDuration = 0;
            oCr.EnableCaching = false;

            //SysUsuario oUsuario = new SysUsuario(int.Parse(Session["idUsuario"].ToString()));
            //int entidad = oUsuario.IdEfector;
            int entidad = SSOHelper.CurrentIdentity.IdEfector;
            

            AutEntidad oEntidad = new AutEntidad(entidad);
            int zona = oEntidad.IdZona;

            DataTable dt = SPs.AutpListOrdenReparacion(idOrdenReparacion.ToString()).GetDataSet().Tables[0];

            oCr.ReportDocument.SetDataSource(dt);

            oCr.DataBind();

            MemoryStream oStream; // using System.IO
            oStream = (MemoryStream)oCr.ReportDocument.ExportToStream(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat);
            Response.Buffer = true;
            Response.ClearContent();
            Response.ClearHeaders();
            Response.ContentType = "application/pdf";

            Response.AddHeader("Content-Disposition", "attachment;filename=ListadoDeVehiculos.pdf");
            Response.BinaryWrite(oStream.ToArray());
            Response.End();            

        }

        protected void lnkBtnNuevoItems_Click(object sender, EventArgs e)
        {
            //int idOrdenReparaciom = SubSonic.Sugar.Web.QueryString<int>("idOrdenReparacion");

            string url = "OrdenReparacionItems.aspx?idOrdenReparacion=" + Request["idOrdenReparacion"].ToString();
            Response.Redirect(url, false);
        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {

        }







        // -----------------------------------------------------------------------------------------------------------
    }
}
