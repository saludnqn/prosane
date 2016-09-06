using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using DalRis;
using System.Data;
using System.Text;
using System.IO;
using System.Web.UI.HtmlControls;
using Salud.Security.SSO;

namespace RIS_Publico
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;
            SSOHelper.Authenticate();

            if (SSOHelper.CurrentIdentity == null)
            {
                SSOHelper.RedirectToSSOPage("Login.aspx", Request.Url.ToString());
            }
            cargarCombos();
            cargarListaFichas();
        }

        private void cargarCombos()
        {
            ddlZona.DataSource = SPs.AutCargarComboZona().GetDataSet().Tables[0];
            ddlZona.DataBind();
            ddlZona.Items.Insert(0, new ListItem("Seleccionar", "0"));

            ddlEfector.DataSource = SPs.PsmCargarComboEntidadesOrdenadoParaSubsecretaria().GetDataSet().Tables[0];
            ddlEfector.DataBind();
            ddlEfector.Items.Insert(0, new ListItem("Seleccionar", "0"));

            ddlEstablecimiento.DataSource = SPs.AutCargarComboEstablecimientos().GetDataSet().Tables[0];
            ddlEstablecimiento.DataBind();
            ddlEstablecimiento.Items.Insert(0, new ListItem("Seleccionar", "0"));
        }

        protected void ddlZona_SelectedIndexChanged(object sender, EventArgs e)
        {
            ddlEfector.DataSource = SPs.PsmCargarComboEntidadesOrdenadoParaZona(int.Parse(ddlZona.SelectedValue)).GetDataSet().Tables[0];
            ddlEfector.DataBind();
            ddlEfector.Items.Insert(0, new ListItem("Todos", "0"));
        }

        private void cargarListaFichas()
        {
            DataTable dtTotalPaciente = new DataTable();
            dtTotalPaciente = SPs.PsmGenerarReporteCount(int.Parse(txtDNI.Text), int.Parse(ddlEstablecimiento.SelectedValue), int.Parse(ddlEfector.SelectedValue), int.Parse(ddlZona.SelectedValue)).GetDataSet().Tables[0];
            if (dtTotalPaciente.Rows.Count > 0) // existe al menos un registro
            {
                lblTotalGeneral.Text = dtTotalPaciente.Rows[0][0].ToString();
            }
            gvListaFichasAlumnos.DataSource = SPs.PsmGenerarReporte(int.Parse(txtDNI.Text), int.Parse(ddlEstablecimiento.SelectedValue), int.Parse(ddlEfector.SelectedValue), int.Parse(ddlZona.SelectedValue)).GetDataSet().Tables[0];
            if (gvListaFichasAlumnos.DataSource != null)
            {
                gvListaFichasAlumnos.DataBind();                
            }
        }

        protected void gvListaFichasAlumnos_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                ImageButton CmdEditarrAlumno = (ImageButton)e.Row.Cells[0].Controls[1];
                CmdEditarrAlumno.CommandArgument = this.gvListaFichasAlumnos.DataKeys[e.Row.RowIndex].Value.ToString();
                CmdEditarrAlumno.CommandName = "editarAlumno";
                CmdEditarrAlumno.ToolTip = "Editar";
            }
        }

        protected void gvListaFichasAlumnos_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            switch (e.CommandName)
            {
                case "editarAlumno":
                    PsmDato oPsmDato = new PsmDato(int.Parse(e.CommandArgument.ToString()));
                    Response.Redirect("ProsameEdit.aspx?idProsame=" + e.CommandArgument, false);
                    break;
            }
        }

        protected void gvListaFichasAlumnos_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            this.gvListaFichasAlumnos.PageIndex = e.NewPageIndex;
            cargarListaFichas();
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            if (ddlBusca.SelectedValue == "Total")
            {
                gvListaFichasAlumnos.DataSource = SPs.PsmGenerarReporte(int.Parse(txtDNI.Text), int.Parse(ddlEstablecimiento.SelectedValue), int.Parse(ddlEfector.SelectedValue), int.Parse(ddlZona.SelectedValue)).GetDataSet().Tables[0];

                DataTable dtTotalPaciente = new DataTable();
                dtTotalPaciente = SPs.PsmGenerarReporteCount(int.Parse(txtDNI.Text), int.Parse(ddlEstablecimiento.SelectedValue), int.Parse(ddlEfector.SelectedValue), int.Parse(ddlZona.SelectedValue)).GetDataSet().Tables[0];

                if (dtTotalPaciente.Rows.Count > 0) // existe al menos un registro
                {
                    lblTotal.Text = dtTotalPaciente.Rows[0][0].ToString();
                }
            }

            if (ddlBusca.SelectedValue == "Obecidad")
            {
                DataTable dtTotalPaciente = new DataTable();
                dtTotalPaciente = SPs.PsmObesidadCount(int.Parse(txtDNI.Text), int.Parse(ddlEstablecimiento.SelectedValue), int.Parse(ddlEfector.SelectedValue), int.Parse(ddlZona.SelectedValue)).GetDataSet().Tables[0];

                if (dtTotalPaciente.Rows.Count > 0) // existe al menos un registro
                {
                    lblTotal.Text = dtTotalPaciente.Rows[0][0].ToString();
                }
                gvListaFichasAlumnos.DataSource = SPs.PsmObesidad(int.Parse(txtDNI.Text), int.Parse(ddlEstablecimiento.SelectedValue), int.Parse(ddlEfector.SelectedValue), int.Parse(ddlZona.SelectedValue)).GetDataSet().Tables[0];
            }

            if (ddlBusca.SelectedValue == "Sobrepeso")
            {
                DataTable dtTotalPaciente = new DataTable();
                dtTotalPaciente = SPs.PsmSobrepesoCount(int.Parse(txtDNI.Text), int.Parse(ddlEstablecimiento.SelectedValue), int.Parse(ddlEfector.SelectedValue), int.Parse(ddlZona.SelectedValue)).GetDataSet().Tables[0];

                if (dtTotalPaciente.Rows.Count > 0) // existe al menos un registro
                {
                    lblTotal.Text = dtTotalPaciente.Rows[0][0].ToString();
                }
                gvListaFichasAlumnos.DataSource = SPs.PsmSobrepeso(int.Parse(txtDNI.Text), int.Parse(ddlEstablecimiento.SelectedValue), int.Parse(ddlEfector.SelectedValue), int.Parse(ddlZona.SelectedValue)).GetDataSet().Tables[0];
            }

            if (ddlBusca.SelectedValue == "Oftalmologia")
            {
                DataTable dtTotalPaciente = new DataTable();
                dtTotalPaciente = SPs.PsmAgudezaVisualCount(int.Parse(txtDNI.Text), int.Parse(ddlEstablecimiento.SelectedValue), int.Parse(ddlEfector.SelectedValue), int.Parse(ddlZona.SelectedValue)).GetDataSet().Tables[0];
                if (dtTotalPaciente.Rows.Count > 0) // existe al menos un registro
                {
                    lblTotal.Text = dtTotalPaciente.Rows[0][0].ToString();
                }
                gvListaFichasAlumnos.DataSource = SPs.PsmAgudezaVisual(int.Parse(txtDNI.Text), int.Parse(ddlEstablecimiento.SelectedValue), int.Parse(ddlEfector.SelectedValue), int.Parse(ddlZona.SelectedValue)).GetDataSet().Tables[0];
            }

            if (ddlBusca.SelectedValue == "Fonoaudilogia")
            {
                DataTable dtTotalPaciente = new DataTable();
                dtTotalPaciente = SPs.PsmFonoCount(int.Parse(txtDNI.Text), int.Parse(ddlEstablecimiento.SelectedValue), int.Parse(ddlEfector.SelectedValue), int.Parse(ddlZona.SelectedValue)).GetDataSet().Tables[0];
                if (dtTotalPaciente.Rows.Count > 0) // existe al menos un registro
                {
                    lblTotal.Text = dtTotalPaciente.Rows[0][0].ToString();
                }
                gvListaFichasAlumnos.DataSource = SPs.PsmFono(int.Parse(txtDNI.Text), int.Parse(ddlEstablecimiento.SelectedValue), int.Parse(ddlEfector.SelectedValue), int.Parse(ddlZona.SelectedValue)).GetDataSet().Tables[0];
            }

            if (gvListaFichasAlumnos.DataSource != null)
            {
                gvListaFichasAlumnos.DataBind();
            }
        }

        protected void btnExportarExecl_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            StringWriter sw = new StringWriter(sb);
            HtmlTextWriter htw = new HtmlTextWriter(sw);

            Page page = new Page();
            HtmlForm form = new HtmlForm();
            GridView dg = new GridView();
            dg.EnableViewState = false;
            dg.DataSource = SPs.PsmExportar().GetDataSet().Tables[0]; ;
            dg.DataBind();

            // Deshabilitar la validaci¾n de eventos, s¾lo asp.net 2
            page.EnableEventValidation = false;

            // Realiza las inicializaciones de la instancia de la clase Page que requieran los dise±adores RAD.
            page.DesignerInitialize();
            page.Controls.Add(form);
            form.Controls.Add(dg);
            page.RenderControl(htw);

            Response.Clear();
            Response.Buffer = true;
            Response.ContentType = "application/vnd.ms-excel";
            Response.AddHeader("Content-Disposition", "attachment;filename=ProsaneList.xls");
            Response.Charset = "UTF-8";
            Response.ContentEncoding = Encoding.Default;
            Response.Write(sb.ToString());
            Response.End();
        }

        protected void btn_Exportar_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            StringWriter sw = new StringWriter(sb);
            HtmlTextWriter htw = new HtmlTextWriter(sw);

            Page page = new Page();
            HtmlForm form = new HtmlForm();
            GridView dg = new GridView();
            dg.EnableViewState = false;
            dg.DataSource = SPs.PsmExportarTrasadoraSumar().GetDataSet().Tables[0]; ;
            dg.DataBind();

            // Deshabilitar la validaci¾n de eventos, s¾lo asp.net 2
            page.EnableEventValidation = false;

            // Realiza las inicializaciones de la instancia de la clase Page que requieran los dise±adores RAD.
            page.DesignerInitialize();
            page.Controls.Add(form);
            form.Controls.Add(dg);
            page.RenderControl(htw);

            Response.Clear();
            Response.Buffer = true;
            Response.ContentType = "application/vnd.ms-excel";
            Response.AddHeader("Content-Disposition", "attachment;filename=ProsaneList.xls");
            Response.Charset = "UTF-8";
            Response.ContentEncoding = Encoding.Default;
            Response.Write(sb.ToString());
            Response.End();
        }
      /*  protected void btnAgrega_Click(object sender, EventArgs e)
        {
            int vEfector = ddlEstablecimiento.SelectedIndex;
            string url = "PacienteList.aspx=" + vEfector.ToString();
            Response.Redirect(url, false);
        }*/
    }
}
