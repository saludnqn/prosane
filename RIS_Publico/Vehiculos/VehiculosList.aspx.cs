using System;
using System.Data;
using System.IO;
using System.Web.UI;
using System.Web.UI.WebControls;
using CrystalDecisions.Web;
using DALAutomotores;

namespace Web.Vehiculos
{
    public partial class VehiculosList : System.Web.UI.Page
    {

        // -----------------------------------------------------------------------------------------------------------------

        // La defino como "Global" ;-)
        CrystalReportSource oCr = new CrystalReportSource();

        // -----------------------------------------------------------------------------------------------------------------

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Session["idUsuario"] == null)// si la sesion está activa
                {
                    Response.Write("<script>window.parent.location='../Finsesion.htm'</script>");
                }
                else
                {
                    cargarCombos();
                    inicializar();
                    cargarLista();
                }
            }
        }

        // -----------------------------------------------------------------------------------------------------------------

        private void inicializar()
        {
            // Por el momento lo deshabilitamos (a pedido del usuario) 
            // -------------------------------------------------------

            //if (Session["dominio_VehiculoList"] != null)
            //    txtDominio.Text = Session["dominio_VehiculoList"].ToString();

            //if (Session["tipo_VehiculoList"] != null)
            //    ddlTipo.SelectedValue = Session["tipo_VehiculoList"].ToString();

            //if (Session["efector_VehiculoList"] != null)
            //    ddlEfector.SelectedValue = Session["efector_VehiculoList"].ToString();

            //if (Session["zona_VehiculoList"] != null)
            //    ddlZona.SelectedValue = Session["zona_VehiculoList"].ToString();
        }

        // -----------------------------------------------------------------------------------------------------------------

        private void cargarCombos()
        {

            // -------------------------------------------------------------------------------

            ddlTipo.DataSource = AutTipoVehiculo.FetchAll();
            ddlTipo.DataBind();
            ddlTipo.Items.Insert(0, new ListItem("Todos", "0"));

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
                    ddlEfector.Enabled = false ;
                    break;
                case 2:
                    ddlEfector.DataSource = SPs.AutCargarComboEntidadesOrdenadoParaHospital(oEntidad.IdEntidad).GetDataSet().Tables[0];
                    ddlEfector.DataBind();
                    ddlEfector.Items.Insert(0, new ListItem("Todos", "0"));
                    break;
                case 3:
                    ddlEfector.Enabled = false;
                    break;
                case 4:
                    ddlEfector.DataSource = SPs.AutCargarComboEntidadesOrdenadoParaZona(oEntidad.IdZona).GetDataSet().Tables[0];
                    ddlEfector.DataBind();
                    ddlEfector.Items.Insert(0, new ListItem("Todos", "0"));
                    break;
                case 5:
                    ddlEfector.DataSource = SPs.AutCargarComboEntidadesOrdenadoParaSubsecretaria().GetDataSet().Tables[0];
                    ddlEfector.DataBind();
                    ddlEfector.Items.Insert(0, new ListItem("Todos", "0"));
                    break;
                case 6:
                    // ,nota: No considero este caso, ya que no existe un usuario en (Sys_Usuarios) que tenga este valor (6).
                    //        El valor es exclusivo de este sistema.
                    break;
            }

            // -------------------------------------------------------------------------------

            // Solo habilito este combo cuando se trata de la Subsecretaría
            if (oEntidad.IdTipoEntidad == 5)
            {
                ddlZona.DataSource = SysZona.FetchAll();
                ddlZona.DataBind();
                ddlZona.Items.Insert(0, new ListItem("Todas", "0"));
            }
            else 
            {
                ddlZona.Enabled = false;
            }            

            // -------------------------------------------------------------------------------

            ddlMarca.DataSource = SPs.AutCargarComboMarcasOrdenado().GetDataSet().Tables[0];
            ddlMarca.DataBind();
            ddlMarca.Items.Insert(0, new ListItem("Todas", "0"));

            // -------------------------------------------------------------------------------

            ddlModelo.DataSource = SPs.AutCargarComboModelosOrdenado2().GetDataSet().Tables[0];
            ddlModelo.DataBind();
            ddlModelo.Items.Insert(0, new ListItem("Todos", "0"));

            // -------------------------------------------------------------------------------
        }

        // -----------------------------------------------------------------------------------------------------------

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)  // Verifica si ingresa un filtro de busqueda
            {
                // Por el momento lo deshabilitamos (a pedido del usuario) 
                // -------------------------------------------------------
                //Session["dominio_VehiculoList"] = txtDominio.Text;
                //Session["tipo_VehiculoList"] = ddlTipo.SelectedValue;
                //Session["efector_VehiculoList"] = ddlEfector.SelectedValue;
                //Session["zona_VehiculoList"] = ddlZona.SelectedValue;                

                txtDominio.Text = txtDominio.Text.Trim();

                cargarLista();
            }
        }

        // ------------------------------------------------------------------------------------------------------------

        private void cargarLista()
        {
            SysUsuario oUsuario = new SysUsuario(int.Parse(Session["idUsuario"].ToString()));
            int entidad = oUsuario.IdEfector;

            AutEntidad oEntidad = new AutEntidad(entidad);
            int zona = oEntidad.IdZona;

            // *******************************************************************************************************
            // *******************************************************************************************************
            // ,nota: (07/01/2013). A pedido de Mariano Panicia (vía Esteban Mango) hago las modificaciones 
            //        necesarias poder utilizar lo filtros (solo algunos). Luego, cuando Flavio vuelva de su
            //        licencia puede retomarlo.
            //
            //        Daniel.
            // *******************************************************************************************************
            // *******************************************************************************************************

            gvLista.DataSource = SPs.AutListVehiculosDani(txtDominio.Text, ddlEfector.SelectedValue, ddlZona.SelectedValue, ddlMarca.SelectedValue, ddlModelo.SelectedValue, ddlTipo.SelectedValue).GetDataSet().Tables[0];

            //// 1 Centro de Salud
            //// 2 Hospital
            //// 3 Puesto Sanitario
            //// 4 Zona Sanitaria
            //// 5 SubSecretaria de Salud
            //// 6 Otro

            //switch (oEntidad.IdTipoEntidad)
            //{
            //    case 1:
            //        gvLista.DataSource = SPs.AutListVehiculos(txtDominio.Text, ddlComienzaCon.SelectedValue, ddlTipo.SelectedValue, entidad.ToString(), zona.ToString(), ddlMarca.SelectedValue, ddlModelo.SelectedValue, oEntidad.IdEntidad, oEntidad.IdTipoEntidad, zona).GetDataSet().Tables[0];
            //        break;
            //    case 2:
            //        gvLista.DataSource = SPs.AutListVehiculos(txtDominio.Text, ddlComienzaCon.SelectedValue, ddlTipo.SelectedValue, ddlEfector.SelectedValue, zona.ToString(), ddlMarca.SelectedValue, ddlModelo.SelectedValue, oEntidad.IdEntidad, oEntidad.IdTipoEntidad, zona).GetDataSet().Tables[0];
            //        break;
            //    case 3:
            //        gvLista.DataSource = SPs.AutListVehiculos(txtDominio.Text, ddlComienzaCon.SelectedValue, ddlTipo.SelectedValue, entidad.ToString(), zona.ToString(), ddlMarca.SelectedValue, ddlModelo.SelectedValue, oEntidad.IdEntidad, oEntidad.IdTipoEntidad, zona).GetDataSet().Tables[0];
            //        break;
            //    case 4:
            //        gvLista.DataSource = SPs.AutListVehiculos(txtDominio.Text, ddlComienzaCon.SelectedValue, ddlTipo.SelectedValue, ddlEfector.SelectedValue, zona.ToString(), ddlMarca.SelectedValue, ddlModelo.SelectedValue, oEntidad.IdEntidad, oEntidad.IdTipoEntidad, zona).GetDataSet().Tables[0];
            //        break;
            //    case 5:
            //        gvLista.DataSource = SPs.AutListVehiculos(txtDominio.Text, ddlComienzaCon.SelectedValue, ddlTipo.SelectedValue, ddlEfector.SelectedValue, ddlZona.SelectedValue, ddlMarca.SelectedValue, ddlModelo.SelectedValue, oEntidad.IdEntidad, oEntidad.IdTipoEntidad, zona).GetDataSet().Tables[0];
            //        break;
            //    case 6:
            //        // ,nota: No considero este caso, ya que no existe un usuario en (Sys_Usuarios) que tenga este valor (6).
            //        //        El valor es exclusivo de este sistema.
            //        break;
            //}

            if (gvLista.DataSource != null)
            {
                gvLista.DataBind();
            }
        }

        // ***********************************************************************************************************
        // ***********************************************************************************************************
        // ***********************************************************************************************************
            // Por las dudas ....

            //gvLista.DataSource = SPs.AutListVehiculos(txtDominio.Text, ddlComienzaCon.SelectedValue, ddlTipo.SelectedValue, ddlEfector.SelectedValue, ddlZona.SelectedValue, ddlMarca.SelectedValue, ddlModelo.SelectedValue).GetDataSet().Tables[0];

            //if (gvLista.DataSource != null)
            //{
            //    gvLista.DataBind();
            //}
        // ***********************************************************************************************************
        // ***********************************************************************************************************
        // ***********************************************************************************************************        

        // -----------------------------------------------------------------------------------------------------------------

        protected void gvLista_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            switch (e.CommandName)
            {
                case "Modificar": Response.Redirect("VehiculosEdit.aspx?idVehiculo=" + e.CommandArgument, false);
                    break;
                case "PMP": Response.Redirect("VehiculoPMP.aspx?idVehiculo=" + e.CommandArgument, false);
                    break;
                case "Viajes": Response.Redirect("VehiculosViajesList.aspx?idVehiculo=" + e.CommandArgument, false);
                    break;
                case "Movimientos": Response.Redirect("VehiculosMovimientosList.aspx?idVehiculo=" + e.CommandArgument, false);
                    break;
                case "Accidentes": Response.Redirect("VehiculosAccidenesList.aspx?idVehiculo=" + e.CommandArgument, false);
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
                CmdModificar.ToolTip = "Modificar vehículo";

                ImageButton CmdPMP = (ImageButton)e.Row.Cells[8].Controls[1];
                CmdPMP.CommandArgument = this.gvLista.DataKeys[e.Row.RowIndex].Value.ToString();
                CmdPMP.CommandName = "PMP";
                CmdPMP.ToolTip = "Modificar programa de mantenimiento preventivo";

                ImageButton CmdViajes = (ImageButton)e.Row.Cells[9].Controls[1];
                CmdViajes.CommandArgument = this.gvLista.DataKeys[e.Row.RowIndex].Value.ToString();
                CmdViajes.CommandName = "Viajes";
                CmdViajes.ToolTip = "Modificar viajes";

                ImageButton CmdMovimientos = (ImageButton)e.Row.Cells[10].Controls[1];
                CmdMovimientos.CommandArgument = this.gvLista.DataKeys[e.Row.RowIndex].Value.ToString();
                CmdMovimientos.CommandName = "Movimientos";
                CmdMovimientos.ToolTip = "Modificar movimientos";

                ImageButton CmdAccidentes = (ImageButton)e.Row.Cells[11].Controls[1];
                CmdAccidentes.CommandArgument = this.gvLista.DataKeys[e.Row.RowIndex].Value.ToString();
                CmdAccidentes.CommandName = "Accidentes";
                CmdAccidentes.ToolTip = "Modificar accidentes";
            }
        }

        // -----------------------------------------------------------------------------------------------------------------

        protected void gvLista_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            this.gvLista.PageIndex = e.NewPageIndex;
            cargarLista();
        }

        // -----------------------------------------------------------------------------------------------------------

        protected void btnImprimirListadoDeVehiculos_Click(object sender, EventArgs e)
        {
            oCr.Report.FileName = "../Reportes/ListadoDeVehiculos.rpt";
            oCr.CacheDuration = 0;
            oCr.EnableCaching = false;            

            SysUsuario oUsuario = new SysUsuario(int.Parse(Session["idUsuario"].ToString()));
            int entidad = oUsuario.IdEfector;

            AutEntidad oEntidad = new AutEntidad(entidad);
            int zona = oEntidad.IdZona;

            DataTable listadoDeVehiculos = SPs.AutListVehiculosDani(txtDominio.Text, ddlEfector.SelectedValue, ddlZona.SelectedValue, ddlMarca.SelectedValue, ddlModelo.SelectedValue, ddlTipo.SelectedValue).GetDataSet().Tables[0];
            oCr.ReportDocument.SetDataSource(listadoDeVehiculos);

            // 1 Centro de Salud
            // 2 Hospital
            // 3 Puesto Sanitario
            // 4 Zona Sanitaria
            // 5 SubSecretaria de Salud
            // 6 Otro

            //switch (oEntidad.IdTipoEntidad)
            //{
            //    case 1:
            //        DataTable listadoDeVehiculosCaso1 = SPs.AutListVehiculos(txtDominio.Text, ddlComienzaCon.SelectedValue, ddlTipo.SelectedValue, entidad.ToString(), zona.ToString(), ddlMarca.SelectedValue, ddlModelo.SelectedValue, oEntidad.IdEntidad, oEntidad.IdTipoEntidad, zona).GetDataSet().Tables[0];
            //        oCr.ReportDocument.SetDataSource(listadoDeVehiculosCaso1);
            //        break;
            //    case 2:
            //        DataTable listadoDeVehiculosCaso2 = SPs.AutListVehiculos(txtDominio.Text, ddlComienzaCon.SelectedValue, ddlTipo.SelectedValue, ddlEfector.SelectedValue, zona.ToString(), ddlMarca.SelectedValue, ddlModelo.SelectedValue, oEntidad.IdEntidad, oEntidad.IdTipoEntidad, zona).GetDataSet().Tables[0];
            //        oCr.ReportDocument.SetDataSource(listadoDeVehiculosCaso2);
            //        break;
            //    case 3:
            //        DataTable listadoDeVehiculosCaso3 = SPs.AutListVehiculos(txtDominio.Text, ddlComienzaCon.SelectedValue, ddlTipo.SelectedValue, entidad.ToString(), zona.ToString(), ddlMarca.SelectedValue, ddlModelo.SelectedValue, oEntidad.IdEntidad, oEntidad.IdTipoEntidad, zona).GetDataSet().Tables[0];
            //        oCr.ReportDocument.SetDataSource(listadoDeVehiculosCaso3);
            //        break;
            //    case 4:
            //        DataTable listadoDeVehiculosCaso4 = SPs.AutListVehiculos(txtDominio.Text, ddlComienzaCon.SelectedValue, ddlTipo.SelectedValue, ddlEfector.SelectedValue, zona.ToString(), ddlMarca.SelectedValue, ddlModelo.SelectedValue, oEntidad.IdEntidad, oEntidad.IdTipoEntidad, zona).GetDataSet().Tables[0];
            //        oCr.ReportDocument.SetDataSource(listadoDeVehiculosCaso4);
            //        break;
            //    case 5:
            //        DataTable listadoDeVehiculosCaso5 = SPs.AutListVehiculos(txtDominio.Text, ddlComienzaCon.SelectedValue, ddlTipo.SelectedValue, ddlEfector.SelectedValue, ddlZona.SelectedValue, ddlMarca.SelectedValue, ddlModelo.SelectedValue, oEntidad.IdEntidad, oEntidad.IdTipoEntidad, zona).GetDataSet().Tables[0];
            //        oCr.ReportDocument.SetDataSource(listadoDeVehiculosCaso5);
            //        break;
            //    case 6:
            //        // ,nota: No considero este caso, ya que no existe un usuario en (Sys_Usuarios) que tenga este valor (6).
            //        //        El valor es exclusivo de este sistema.
            //        break;
            //}
            
            // Hago "Bind" ...
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

        // -------------------------------------------------------------------------------------------------------------
    }
}
