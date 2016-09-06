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
using System.IO;
using CrystalDecisions.Web;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;
using Salud.Security.SSO;
using DalRis;

namespace VGI
{
    public partial class AntecedentesFamiliares : System.Web.UI.Page
   
    {
        int vCuenta = 0;
        bool vChekError = false;
        int vABVD = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            //super sso

            if (!Page.IsPostBack)
            {
                if (Request["idPaciente"] != null)
                    //MostrarDatosPaciente(idpaciente);
                    //ExisteVGI(318925);
                    
                    //txtProximaEvaluacion.Value = System.DateTime.Now.ToString("dd/MM/yyyy");




                    //MostrarDatosPaciente(int.Parse(Request["idPaciente"].ToString()));
                    //ExisteVGI(int.Parse(Request["idPaciente"].ToString()));
                    

                //lblUsuario.Text = string.Format("{0}, {1}", SSOHelper.CurrentIdentity.Surname, SSOHelper.CurrentIdentity.FirstName);
                cargarCombos();
               Arbol();
                //TablaErrores.Visible = false;
            }
        }

        private void Arbol() 
        {
            TreeNode nodo = new TreeNode();
            TreeView1.Nodes.Clear();
            nodo.Value = "0";
            nodo.Text = "Antecedentes Familiares";
            TreeView1.Nodes.Add(nodo);
            mostrarNodos(nodo);

            

            //DataTable dtFamiliarT = new DataTable();
            //dtFamiliarT = SPs.SysParentescoT().GetDataSet().Tables[0];

            //TreeView1.DataSource = dtFamiliarT;
            //TreeView1.DataBind();

            //DataView dataViewHijos = new DataView(dataSetArbol.Tables["SysParentescoT"]);
            //dataViewHijos.RowFilter = dataSetArbol.Tables["TablaArbol"].Columns["IdentificadorPadre"].ColumnName + " = " + indicePadre;
                

        }

        private void mostrarNodos(TreeNode pad)
        {  
            DataSet dts = new DataSet();
         
           
            dts = SPs.SysParentescoT().GetDataSet();

            for (int i = 1; i <= dts.Tables[0].Rows.Count; i++)
            {
                string id = dts.Tables[0].Rows[i - 1]["id"].ToString();
                //Session["idParentesco"] = id;
                TreeNode nodo = new TreeNode();
                nodo.Text = dts.Tables[0].Rows[i - 1]["nombre"].ToString()  ;
                nodo.Value = id;

                nodo.Expand();
                pad.ChildNodes.Add(nodo);
               mostrarNodosAntecedente(nodo,int.Parse(id));
            }

          
        }

        private void mostrarNodosAntecedente(TreeNode pad,int id)
        {
            DataSet dts = new DataSet();
            dts = SPs.SysPacAntecedentesFamiliares(idPaciente,id).GetDataSet();

            //dts = SPs.SysPacAntFamiliares(cargarCombos idPaciente,int.Parse(Session["idParentesco"].ToString())).GetDataSet();

            for (int i = 1; i <= dts.Tables[0].Rows.Count; i++)
            {
                string idA = dts.Tables[0].Rows[i - 1]["id"].ToString();

                TreeNode nodo = new TreeNode();
                nodo.Text = dts.Tables[0].Rows[i - 1]["Diagnostico"].ToString();
                nodo.Value = idA;

                nodo.Expand();
                pad.ChildNodes.Add(nodo);
            }
        }

        //private void mostrarNodosAntecedente1(TreeNode nodoHab)
        //{
        //   recorre los datos del paciente con el index

        //    DataSet dts = new DataSet();
        //    int i = 0;
        //    int idparen=Convert.ToInt32(nodoHab.Value);
        //    dts = getdtsHab("nodos", );
        //    for (i = 1; i <= dts.Tables[0].Rows.Count; i++)
        //    {
        //        string idHabitacion = dts.Tables[0].Rows[i - 1]["idHab"].ToString();

        //        Habitacion oRegistro = new Habitacion();
        //        oRegistro = (Habitacion)oRegistro.Get(typeof(Habitacion), int.Parse(idHabitacion));
        //        int cantCamasHab = oRegistro.getCantidadCamas();

        //        TreeNode nodo = new TreeNode();
        //        nodo.Text = "Habitación: " + dts.Tables[0].Rows[i - 1]["nombre"].ToString() + " - Camas: " + cantCamasHab.ToString();
        //        nodo.Value = idHabitacion;

        //        nodo.NavigateUrl = "Catastro.aspx?tipo=Habitacion&idHabitacion=" + nodo.Value;
        //           nodo.Expand(); ///nodo que expande las camas
                
        //        nodoTitulo.ChildNodes.Add(nodo);
        //        nodoTitulo.Expand();

        //        mostrarNodosCama(nodo);
        //    }
        //    TreeNode nodoAgregar = new TreeNode();
        //    nodoAgregar.Text = "<b>Agregar Habitacion</b>";
        //    nodoAgregar.Value = "-1";
        //    nodoAgregar.ImageUrl = "../app_themes/default/images/add.png";
        //    nodoAgregar.NavigateUrl = "Catastro.aspx?tipo=Habitacion&idPiso=" + nodoHab.Value;

        //    nodoHab.ChildNodes.Add(nodoAgregar);
        //    nodoHab.Expand();
        //}


 



        private void cargarCombos()
        {
          
            ddlParentesco.DataSource = SPs.SysParentescoT().GetDataSet().Tables[0];
            ddlParentesco.DataBind();
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            //if ((Page.IsValid) && (!hayError()))
            //{
                //int idVGIDatos = SubSonic.Sugar.Web.QueryString<int>("idVGIDatos");
                SysPacienteAntecedentesFamiliare oDato = new SysPacienteAntecedentesFamiliare();
                
                oDato.IdPaciente = 670890;
                oDato.IdParentesco = int.Parse(ddlParentesco.SelectedValue.ToString());
                int i_Cie10 = SIPS.ConsultaAmbulatoria.UserControls.DiagnosticoPrincipal.getObraSocial();
                oDato.IdCie10 = i_Cie10;



                oDato.Id = (int.Parse(Request["idPaciente"].ToString()));
                //oDato.IdTurno = 21;
                    //oDato.IdPaciente = 318925;
                
                oDato.IdUsuarioCarga = 1;
                //oDato.IdUsuarioCarga = SSOHelper.CurrentIdentity.Id;
                oDato.FechaCarga = DateTime.Now;

                oDato.Save();
                
                //}
        }


        public int? idPaciente { get; set; }

        public object idParentesco { get; set; }
    }
}