using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business;
using Business.Data;
using Business.Data.Internacion;
using Salud.Security.SSO;
using Negocio;
using Dominio;

namespace WebInternacion.Administracion
{
    public partial class Catastro : System.Web.UI.Page
    {
        ServicioNego servicioNego = new ServicioNego();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Inicializar();
            }
        }

        private void Inicializar()
        {
            CargarArbol();
            if (Request["tipo"] != null)
            {
                switch (Request["tipo"].ToString())
                {
                    case "Piso":
                        {
                            pnlPiso.Visible = true;
                            if (Request["idPiso"] != null)
                                MostrarPiso();
                            else
                            {
                                lblTituloPiso.Text = "NUEVO PISO";
                                btnEliminarPiso.Visible = false;
                            }
                        } break;

                    case "Habitacion":
                        {
                            pnlHabitacion.Visible = true; CargarServicio(Request["tipo"].ToString());
                            if (Request["idHabitacion"] != null)
                                MostrarHabitacion();
                            else
                            {
                                lblTituloHabitacion.Text = "NUEVA HABITACION";
                                btnEliminarHab.Visible = false;
                                Piso oPiso = new Piso();
                                oPiso = (Piso)oPiso.Get(typeof(Piso), int.Parse(Request["idPiso"].ToString()));
                                lblPiso.Text = oPiso.Nombre;
                                lblIdPiso.Text = oPiso.IdPiso.ToString();
                            }
                        }
                        break;
                    case "Cama":
                        {
                            pnlCama.Visible = true;
                            CargarServicio(Request["tipo"].ToString());
                            CargarTipoCama();
                            if (Request["idCama"] != null)
                                MostrarCama();
                            else
                            {
                                lblTituloCama.Text = "NUEVA CAMA";
                                btnEliminarCama.Visible = false;
                                Habitacion oHab = new Habitacion();
                                oHab = (Habitacion)oHab.Get(typeof(Habitacion), int.Parse(Request["idHabitacion"].ToString()));
                                lblHabitacion.Text = oHab.Nombre;
                                lblPiso2.Text = oHab.IdPiso.Nombre;
                                lblIdHabitacion.Text = oHab.IdHabitacion.ToString();
                                //ddlServicioCama.SelectedValue = oHab.IdServicioInternacion.IdServicio.ToString();
                                ExpandirNodoHabitacion(oHab);
                            }
                        }
                        break;
                }
            }

        }

        private void ExpandirNodoHabitacion(Habitacion oHab)
        {
            ///Marca como seleccionado el nodo donde estoy parado
            foreach (TreeNode n in TreeView1.Nodes[0].ChildNodes)
            {
                if (n.Value == oHab.IdPiso.IdPiso.ToString())
                {
                    foreach (TreeNode h in n.ChildNodes[0].ChildNodes)
                    {
                        if (h.Value == oHab.IdHabitacion.ToString())
                        {
                            h.Expand();
                        }
                    }
                }

            }
        }

        private void CargarTipoCama()
        {
            Utility oUtil = new Utility();
            ///Carga de combos de tipos de servicios
            string m_ssql = "select idTipoCama, nombre from int_TipoCama WHERE baja=0 ";
            oUtil.CargarCombo(ddlTipoCama, m_ssql, "idTipoCama", "nombre");
            ddlTipoCama.Items.Insert(0, new ListItem("--Seleccione--", "0"));
        }

        private void MostrarCama()
        {
            lblTituloCama.Text = "CAMA";
            Cama oCama = new Cama();
            oCama = (Cama)oCama.Get(typeof(Cama), int.Parse(Request["idCama"].ToString()));
            txtCama.Text = oCama.Nombre;
            lblHabitacion.Text = oCama.IdHabitacion.Nombre;
            lblIdHabitacion.Text = oCama.IdHabitacion.IdHabitacion.ToString();
            ddlServicioCama.SelectedValue = oCama.IdServicioInternacion.IdServicio.ToString();
            ddlTipoCama.SelectedValue = oCama.IdTipoCama.IdTipoCama.ToString();
            lblPiso2.Text = oCama.IdHabitacion.IdPiso.Nombre;


            ///Marca como seleccionado el nodo donde estoy parado
            foreach (TreeNode n in TreeView1.Nodes[0].ChildNodes)
            {
                if (n.Value == oCama.IdHabitacion.IdPiso.IdPiso.ToString())
                {
                    foreach (TreeNode h in n.ChildNodes[0].ChildNodes)
                    {
                        if (h.Value == oCama.IdHabitacion.IdHabitacion.ToString())
                        {
                            h.Expand();
                            foreach (TreeNode c in h.ChildNodes)
                            {
                                if (c.Value == oCama.IdCama.ToString())
                                {
                                    c.Text = "<b>" + c.Text + "</b>";
                                    c.Selected = true;
                                }
                            }
                        }
                    }
                }

            }
            /////Fin de marca
        }

        private void MostrarHabitacion()
        {
            lblTituloHabitacion.Text = "HABITACION";
            Habitacion oHab = new Habitacion();
            oHab = (Habitacion)oHab.Get(typeof(Habitacion), int.Parse(Request["idHabitacion"].ToString()));
            txtHabitacion.Text = oHab.Nombre;
            lblPiso.Text = oHab.IdPiso.Nombre;
            lblIdPiso.Text = oHab.IdPiso.IdPiso.ToString();
            //ddlServicio.SelectedValue = oHab.IdServicioInternacion.IdServicio.ToString();

            ///Marca como seleccionado el nodo donde estoy parado
            foreach (TreeNode n in TreeView1.Nodes[0].ChildNodes)
            {
                if (n.Value == oHab.IdPiso.IdPiso.ToString())
                {
                    foreach (TreeNode h in n.ChildNodes[0].ChildNodes)
                    {
                        if (h.Value == oHab.IdHabitacion.ToString())
                        {
                            h.Text = "<b class='mytituloRojo'>" + h.Text + "</b>";
                            h.Selected = true;
                            h.Expand();
                        }
                    }
                }

            }
            /////Fin de marca
        }

        private void MostrarPiso()
        {
            lblTituloPiso.Text = "PISO";
            Piso oPiso = new Piso();
            oPiso = (Piso)oPiso.Get(typeof(Piso), int.Parse(Request["idPiso"].ToString()));
            txtPiso.Text = oPiso.Nombre;

            foreach (TreeNode n in TreeView1.Nodes[0].ChildNodes)
            {
                if (n.Value == oPiso.IdPiso.ToString())
                {
                    n.Text = "<b class='mytituloRojo'>" + n.Text + "</b>";
                    n.Selected = true;
                    n.Expand();
                }
            }
        }

        private void CargarServicio(string tipo)
        {
            /*if (tipo == "Habitacion")
            {
                ddlServicio.DataSource = servicioNego.devuelveServicios();
                ddlServicio.DataBind();
                ddlServicio.Items.Insert(0, new ListItem("--Seleccione--", "0"));
            }*/

            if (tipo == "Cama")
            {
                ddlServicioCama.DataSource = servicioNego.devuelveServicios();
                ddlServicioCama.DataBind();
                ddlServicioCama.Items.Insert(0, new ListItem("--Seleccione--", "0"));
            }
        }

        private void CargarArbol()
        {
            TreeNode nodo = new TreeNode();
            TreeView1.Nodes.Clear();
            nodo.Value = "0";
            nodo.Text = string.Format("{0}", SSOHelper.GetNombreEfectorRol(SSOHelper.CurrentIdentity.IdEfectorRol));//oUser.IdEfector.Nombre;
            TreeView1.Nodes.Add(nodo);
            mostrarNodos(nodo);

            pnlPiso.Visible = false;
            pnlHabitacion.Visible = false;
            pnlCama.Visible = false;
        }

        private void mostrarNodos(TreeNode pad)
        {     ////nodos para los PISOS    
            DataSet dts = new DataSet();
            int i = 0;
            int dotacionTotalCamas = 0;
            dts = getdtsPiso("nodos", Convert.ToInt32(pad.Value));
            for (i = 1; i <= dts.Tables[0].Rows.Count; i++)
            {
                string idPiso = dts.Tables[0].Rows[i - 1]["idPiso"].ToString();

                Piso oPiso = new Piso();
                oPiso = (Piso)oPiso.Get(typeof(Piso), int.Parse(idPiso));

                int cantCamasPiso = oPiso.getCantidadCamas();
                dotacionTotalCamas += cantCamasPiso;

                TreeNode nodo = new TreeNode();
                nodo.Text = dts.Tables[0].Rows[i - 1]["nombre"].ToString() + " - Camas: " + cantCamasPiso.ToString(); ;
                nodo.Value = idPiso;

                nodo.NavigateUrl = "Catastro.aspx?tipo=Piso&idPiso=" + nodo.Value;
                nodo.Expand();
                pad.ChildNodes.Add(nodo);
                mostrarNodosHab(nodo);
            }

            TreeNode nodoAgregar = new TreeNode();

            nodoAgregar.Text = "<b>Agregar Piso</b>";
            nodoAgregar.Value = "-1";
            //nodoAgregar.
            nodoAgregar.ImageUrl = "../app_themes/default/images/add.png";
            nodoAgregar.NavigateUrl = "Catastro.aspx?tipo=Piso";
            //            nodoAgregar.ToolTip = "Agregar Piso";


            pad.ChildNodes.Add(nodoAgregar);
            pad.Expand();

            lblDotacion.Text = "TOTAL CAMAS: " + dotacionTotalCamas.ToString();
        }

        private void mostrarNodosHab(TreeNode nodoHab)
        {
            //nodos para Habitaciones
            TreeNode nodoTitulo = new TreeNode();
            nodoTitulo.Text = "HABITACIONES";
            nodoTitulo.Value = nodoHab.Value;

            nodoHab.ChildNodes.Add(nodoTitulo);

            DataSet dts = new DataSet();
            int i = 0;
            dts = getdtsHab("nodos", Convert.ToInt32(nodoHab.Value));
            for (i = 1; i <= dts.Tables[0].Rows.Count; i++)
            {
                string idHabitacion = dts.Tables[0].Rows[i - 1]["idHab"].ToString();

                Habitacion oRegistro = new Habitacion();
                oRegistro = (Habitacion)oRegistro.Get(typeof(Habitacion), int.Parse(idHabitacion));
                int cantCamasHab = oRegistro.getCantidadCamas();

                TreeNode nodo = new TreeNode();
                nodo.Text = "Habitación: " + dts.Tables[0].Rows[i - 1]["nombre"].ToString() + " - Camas: " + cantCamasHab.ToString();
                nodo.Value = idHabitacion;

                nodo.NavigateUrl = "Catastro.aspx?tipo=Habitacion&idHabitacion=" + nodo.Value;
                //   nodo.Expand(); ///nodo que expande las camas
                ///
                nodoTitulo.ChildNodes.Add(nodo);
                nodoTitulo.Expand();

                mostrarNodosCama(nodo);
            }
            TreeNode nodoAgregar = new TreeNode();
            nodoAgregar.Text = "<b>Agregar Habitacion</b>";
            nodoAgregar.Value = "-1";
            nodoAgregar.ImageUrl = "../app_themes/default/images/add.png";
            nodoAgregar.NavigateUrl = "Catastro.aspx?tipo=Habitacion&idPiso=" + nodoHab.Value;

            nodoHab.ChildNodes.Add(nodoAgregar);
            nodoHab.Expand();
        }

        private void mostrarNodosCama(TreeNode nodoCama)
        {
            DataSet dts = new DataSet();
            int i = 0;
            dts = getdtsCama("nodos", Convert.ToInt32(nodoCama.Value));
            for (i = 1; i <= dts.Tables[0].Rows.Count; i++)
            {
                TreeNode nodo = new TreeNode();
                nodo.Text = dts.Tables[0].Rows[i - 1]["nombre"].ToString();
                nodo.Value = dts.Tables[0].Rows[i - 1]["idCama"].ToString();
                nodo.NavigateUrl = "Catastro.aspx?tipo=Cama&idCama=" + nodo.Value;
                nodo.ImageUrl = "../app_themes/default/images/cama.jpg";
                nodoCama.ChildNodes.Add(nodo);
            }

            TreeNode nodoAgregar = new TreeNode();
            nodoAgregar.Text = "<b>Agregar Cama</b>";
            nodoAgregar.Value = "-1";
            nodoAgregar.ImageUrl = "../app_themes/default/images/add.png";
            nodoAgregar.NavigateUrl = "Catastro.aspx?tipo=Cama&idHabitacion=" + nodoCama.Value;

            nodoCama.ChildNodes.Add(nodoAgregar);
        }

        private DataSet getdtsCama(string p, int p_2)
        {
            string m_strSQL = " SELECT nombre AS nombre, idCama  FROM INT_cama where baja=0 and idHabitacion=" + p_2;

            DataSet Ds = new DataSet();
            SqlConnection conn = (SqlConnection)NHibernateHttpModule.CurrentSession.Connection;
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = new SqlCommand(m_strSQL, conn);
            adapter.Fill(Ds);
            return Ds;
        }

        private DataSet getdtsHab(string p, int p_2)
        {
            string m_strSQL = " SELECT nombre AS nombre, idHabitacion as idHab FROM INT_habitacion where baja=0 and idPiso=" + p_2;

            DataSet Ds = new DataSet();
            SqlConnection conn = (SqlConnection)NHibernateHttpModule.CurrentSession.Connection;
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = new SqlCommand(m_strSQL, conn);
            adapter.Fill(Ds);
            return Ds;
        }

        private DataSet getdtsPiso(string p, int p_2)
        {
            string m_strSQL = " SELECT nombre AS nombre, idPiso FROM INT_Piso AS P where baja=0";

            DataSet Ds = new DataSet();
            SqlConnection conn = (SqlConnection)NHibernateHttpModule.CurrentSession.Connection;
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = new SqlCommand(m_strSQL, conn);
            adapter.Fill(Ds);
            return Ds;
        }

        protected void btnAgregarPiso_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                Piso oRegistro = new Piso();
                if (Request["idPiso"] != null) oRegistro = (Piso)oRegistro.Get(typeof(Piso), int.Parse(Request["idPiso"]));

                GuardarPiso(oRegistro);

                CargarArbol();
            }
        }

        private void GuardarPiso(Piso oRegistro)
        {
            oRegistro.Nombre = txtPiso.Text;
            oRegistro.IdUsuarioRegistro = SSOHelper.CurrentIdentity.Id;
            oRegistro.FechaRegistro = DateTime.Now;
            oRegistro.IdEfector.IdEfector = SSOHelper.CurrentIdentity.IdEfector;
            oRegistro.Save();
        }

        protected void btnAgregarHabitacion_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                Habitacion oRegistro = new Habitacion();
                if (Request["idHabitacion"] != null) oRegistro = (Habitacion)oRegistro.Get(typeof(Habitacion), int.Parse(Request["idHabitacion"]));

                GuardarHabitacion(oRegistro);
                Response.Redirect("Catastro.aspx?tipo=Piso&idPiso=" + oRegistro.IdPiso.IdPiso.ToString(), false);
            }
        }

        private void GuardarHabitacion(Habitacion oRegistro)
        {
            Piso oPiso = new Piso();
            oPiso = (Piso)oPiso.Get(typeof(Piso), int.Parse(lblIdPiso.Text));

            /*Servicio oServicio = new Servicio();
            oServicio = (Servicio)oServicio.Get(typeof(Servicio), int.Parse(ddlServicio.SelectedValue));*/

            oRegistro.IdPiso = oPiso;
            oRegistro.Nombre = txtHabitacion.Text;
            //oRegistro.IdServicioInternacion = oServicio;
            oRegistro.IdUsuarioRegistro = SSOHelper.CurrentIdentity.Id;
            oRegistro.FechaRegistro = DateTime.Now;
            oRegistro.IdEfector.IdEfector = SSOHelper.CurrentIdentity.IdEfector;
            oRegistro.Save();
        }

        protected void btnAgregarCama_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                Cama oRegistro = new Cama();

                if (Request["idCama"] != null) oRegistro = (Cama)oRegistro.Get(typeof(Cama), int.Parse(Request["idCama"]));
                GuardarCama(oRegistro);
                Response.Redirect("Catastro.aspx?tipo=Habitacion&idHabitacion=" + oRegistro.IdHabitacion.IdHabitacion.ToString(), false);
            }
        }

        private void GuardarCama(Cama oRegistro)
        {
            Habitacion oHab = new Habitacion();
            oHab = (Habitacion)oHab.Get(typeof(Habitacion), int.Parse(lblIdHabitacion.Text));

            Servicio oServicio = new Servicio();
            oServicio = (Servicio)oServicio.Get(typeof(Servicio), int.Parse(ddlServicioCama.SelectedValue));

            TipoCama oTipo = new TipoCama();
            oTipo = (TipoCama)oTipo.Get(typeof(TipoCama), int.Parse(ddlTipoCama.SelectedValue));

            oRegistro.IdHabitacion = oHab;
            oRegistro.Nombre = txtCama.Text;
            oRegistro.IdServicioInternacion = oServicio;
            oRegistro.IdTipoCama = oTipo;
            oRegistro.IdUsuarioRegistro = SSOHelper.CurrentIdentity.Id;
            oRegistro.FechaRegistro = DateTime.Now;
            oRegistro.IdEfector.IdEfector = SSOHelper.CurrentIdentity.IdEfector;

            oRegistro.Save(oRegistro);
        }

        protected void btnEliminarPiso_Click(object sender, EventArgs e)
        {
            Piso oPiso = new Piso();
            oPiso = (Piso)oPiso.Get(typeof(Piso), int.Parse(Request["idPiso"].ToString()));

            if (oPiso.getCantidadCamas() == 0)
            {
                Piso oRegistro = new Piso();
                oRegistro = (Piso)oRegistro.Get(typeof(Piso), int.Parse(Request["idPiso"].ToString()));
                oRegistro.Baja = true;
                oRegistro.Save();
                CargarArbol();
                string popupScript = "<script language='JavaScript'> alert('Se ha eliminado el piso')</script>";
                ClientScript.RegisterClientScriptBlock(GetType(), "PopupScript", popupScript);
            }
            else
            {
                string popupScript = "<script language='JavaScript'> alert('No es posible eliminar el piso. Tiene habitaciones asociadas.')</script>";
                ClientScript.RegisterClientScriptBlock(GetType(), "PopupScript", popupScript);
            }

        }

        protected void btnEliminarHab_Click(object sender, EventArgs e)
        {
            Habitacion oRegistro = new Habitacion();
            oRegistro = (Habitacion)oRegistro.Get(typeof(Habitacion), int.Parse(Request["idHabitacion"].ToString()));

            if (oRegistro.getCantidadCamas() == 0)
            {
                oRegistro.Baja = true;
                oRegistro.Save();
                CargarArbol();
                string popupScript = "<script language='JavaScript'> alert('Se ha eliminado la habitacion')</script>";
                ClientScript.RegisterClientScriptBlock(GetType(), "PopupScript", popupScript);
            }
            else
            {
                string popupScript = "<script language='JavaScript'> alert('No es posible eliminar la habitación. Tiene camas asociadas.')</script>";
                ClientScript.RegisterClientScriptBlock(GetType(), "PopupScript", popupScript);
            }
        }

        protected void btnEliminarCama_Click(object sender, EventArgs e)
        {
            Cama oRegistro = new Cama();
            oRegistro = (Cama)oRegistro.Get(typeof(Cama), int.Parse(Request["idCama"].ToString()));

            if (oRegistro.getUtilizacionCama() == 0)
            {

                oRegistro.Baja = true;
                oRegistro.Save();
                CargarArbol();
                string popupScript = "<script language='JavaScript'> alert('Se ha eliminado la cama')</script>";
                ClientScript.RegisterClientScriptBlock(GetType(), "PopupScript", popupScript);
            }
            else
            {
                string popupScript = "<script language='JavaScript'> alert('No es posible eliminar la cama. Tiene movimientos de ocupacion asociadas.')</script>";
                ClientScript.RegisterClientScriptBlock(GetType(), "PopupScript", popupScript);
            }

        }

        protected void btnContraer_Click(object sender, EventArgs e)
        {
            this.TreeView1.CollapseAll();
        }

        protected void btnExpander_Click(object sender, EventArgs e)
        {
            this.TreeView1.ExpandAll();
        }

        protected void btnMapaCamas_Click(object sender, EventArgs e)
        {
            Response.Redirect("MapaCamas.aspx", false);
        }

        protected void cvCama_ServerValidate(object source, ServerValidateEventArgs args)
        {
            if (Request["idCama"] != null)
                args.IsValid = true;
            else
            {
                Cama oRegistro = new Cama();
                oRegistro = (Cama)oRegistro.Get(typeof(Cama), "Nombre", txtCama.Text, "Baja", false);

                cvCama.ErrorMessage = "El nombre de la cama ya existe. Verifique";

                if (oRegistro == null)
                    args.IsValid = true;
                else
                    args.IsValid = false;
            }

        }

        protected void cvhABITACION_ServerValidate(object source, ServerValidateEventArgs args)
        {
            if (Request["idHabitacion"]!=null) //modificacion de habitacion
                args.IsValid = true;
            else
            {
            Habitacion oRegistro = new Habitacion();
            oRegistro = (Habitacion)oRegistro.Get(typeof(Habitacion), "Nombre", txtHabitacion.Text, "Baja", false);
            cvhABITACION.ErrorMessage = "El nombre de habitación ya existe. Verifique";
            if (oRegistro == null) args.IsValid = true;
            else args.IsValid = false;
            }
        }

        protected void cvPiso_ServerValidate(object source, ServerValidateEventArgs args)
        {
            if (Request["idPiso"]!=null) ///modificacion no valida
                args.IsValid = true;
            else
            {

            Piso oRegistro = new Piso();
            oRegistro = (Piso)oRegistro.Get(typeof(Piso), "Nombre", txtPiso.Text, "Baja", false);
            cvPiso.ErrorMessage = "El nombre de piso ya existe. Verifique";
            if (oRegistro == null) args.IsValid = true;
            else args.IsValid = false;
        }
        }
    }
}
