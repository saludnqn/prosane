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
using SubSonic;
using DalSic;
using Salud.Security.SSO;

namespace SIPS.Paciente
{
    public partial class PacienteList : System.Web.UI.Page
    {
        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
            btnNuevo.Visible = SSOHelper.CurrentIdentity.TestPermissionByEfector("/PacienteList.aspx.btnNuevo");
            gvPacientes.Columns[6].Visible = SSOHelper.CurrentIdentity.TestPermissionByEfector("/PacienteView.aspx");
            gvPacientes.Columns[7].Visible = SSOHelper.CurrentIdentity.TestPermissionByEfector("/PacienteEdit.aspx");
        }

        protected void Page_Load(object sender, EventArgs e)
        {                   
            if (!IsPostBack)
            {
                txtDni.Focus();
            }            
        }

        private string ConvertSortDirectionToSql(SortDirection sortDirection)
        {
            string newSortDirection = String.Empty;

            switch (sortDirection)
            {
                case SortDirection.Ascending:
                    newSortDirection = "ASC";
                    break;
                case SortDirection.Descending:
                    newSortDirection = "DESC";
                    break;
            }
            return newSortDirection;
        }

        protected void gvPacientes_PageIndexChangind(object sender, GridViewPageEventArgs e)
        {
            btnBuscar_Click(null, null);
            gvPacientes.PageIndex = e.NewPageIndex;
            gvPacientes.DataBind();
        }

        protected void gvPersonas_PageIndexChangind(object sender, GridViewPageEventArgs e)
        {
            btnBuscar_Click(null, null);
            gvPersonas.PageIndex = e.NewPageIndex;
            gvPersonas.DataBind();
        }

        protected void gvPadronPaciente_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            btnBuscar_Click(null, null);
            gvPadronPaciente.PageIndex = e.NewPageIndex;
            gvPadronPaciente.DataBind();
        }

        protected void gridView_Sorting(object sender, GridViewSortEventArgs e)
        {
            DataTable dataTable = gvPacientes.DataSource as DataTable;

            if (dataTable != null)
            {
                DataView dataView = new DataView(dataTable);
                dataView.Sort = e.SortExpression + " " + ConvertSortDirectionToSql(e.SortDirection);
                gvPacientes.DataSource = dataView;
                gvPacientes.DataBind();
            }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {

            SubSonic.Select s = new SubSonic.Select();
            s.From(SysPaciente.Schema);

            //busqueda por documento
            if (txtDni.Text.Length > 0)
            {
                int nrodoc = 0;
                nrodoc = Convert.ToInt32(txtDni.Text);

                gvPersonas.DataSource = DalPadron.SPs.ListarObraSocial((Convert.ToInt32(txtDni.Text))).GetDataSet().Tables[0];
                gvPersonas.DataBind();
                //busqueda en Pd_Paciente
                gvPadronPaciente.DataSource = DalPadron.SPs.GetPacientes((Convert.ToInt32(txtDni.Text))).GetDataSet().Tables[0];
                gvPadronPaciente.DataBind();
                //llenado de la grilla
                gvPacientes.DataSource = SPs.GetPacientesPorDocumento(nrodoc).GetDataSet();
                gvPacientes.DataBind();

                return;
            }
            
            DateTime fnac;
            DateTime? fnac2 = null;
            if (DateTime.TryParse(txtFecNacBusqueda.Text, out fnac))
            {
                fnac2 = fnac;
            }
            //Busqueda por Nro Doc de la Madre
            int docM = 0;
            if (txtDocMadre.Text != "")
            {
                docM = Convert.ToInt32(txtDocMadre.Text);
            }
            gvPacientes.DataSource = SPs.GetPacientesPorNombres(fnac2, txtNombreBusqueda.Text.Trim(), txtApellidoBusqueda.Text.Trim(), docM, txtNombreMadreBusqueda.Text.Trim(), txtApellidoMadreBusqueda.Text.Trim()).GetDataSet();
            gvPacientes.DataBind();
        }

        protected void btnNuevo_Click(object sender, EventArgs e)
        {
            if (txtDni.Text.Trim().Length > 0)
                Response.Redirect("PacienteEdit.aspx?dni=" + txtDni.Text.Trim());
            else
                Response.Redirect("PacienteEdit.aspx");
        }

        protected void gvPacientes_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                switch (DataBinder.Eval(e.Row.DataItem, "estado").ToString())
                {
                    case "Identificado":
                        e.Row.BackColor = System.Drawing.Color.LightBlue;
                        e.Row.ToolTip = "Pacientes Identificados";
                        break;
                    case "Temporal":
                        e.Row.BackColor = System.Drawing.Color.AliceBlue;
                        e.Row.ToolTip = "Pacientes Temporales";
                        break;
                    case "Validado":
                        e.Row.BackColor = System.Drawing.Color.LightGoldenrodYellow;
                        e.Row.ToolTip = "Pacientes Validados";
                        break;
                    case "Inactivo":
                        e.Row.BackColor = System.Drawing.Color.Azure;
                        e.Row.ToolTip = "Pacientes Inactivos";
                        break;
                    default: e.Row.BackColor = System.Drawing.Color.White;
                        break;
                }
            }
        }
    }
}