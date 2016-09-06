using System;
using System.Web.UI;
using DALAutomotores;

namespace Web.Vehiculos
{
    public partial class VehiculoPMPHistoricoEdit : System.Web.UI.Page
    {
        // -----------------------------------------------------------------------------------------------------------

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Session["idUsuario"] != null)
                {
                    // Esta sentencia tiene la inteligencia como para tomar el parámetro quer paso en la url.
                    // Si no paso un parámetro devuelve 0, caso contrario devuelve el ID que paso como parámetro.                    
                    
                    int idHistoricoVehiculoPMP = int.Parse(Request["idHistoricoVehiculoPMP"].ToString());

                    if (idHistoricoVehiculoPMP != 0)
                    {
                        MostrarDatos(idHistoricoVehiculoPMP);
                    }
                }
            }
        }

        // -----------------------------------------------------------------------------------------------------------

        private void MostrarDatos(int idHistoricoVehiculoPMP)
        {
            AutHistoricoVehiculoPmp oHistoricoVahiculoPMP = new AutHistoricoVehiculoPmp(idHistoricoVehiculoPMP);

            txtFechaPMP.Text = oHistoricoVahiculoPMP.Fecha.ToShortDateString();
            txtKilometraje.Text = oHistoricoVahiculoPMP.Kilometraje.ToString();
        }

        // -----------------------------------------------------------------------------------------------------------

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                int idHistoricoVehiculoPMP = int.Parse(Request["idHistoricoVehiculoPMP"].ToString());

                AutHistoricoVehiculoPmp oHistoricoVahiculoPMP = new AutHistoricoVehiculoPmp(idHistoricoVehiculoPMP);

                oHistoricoVahiculoPMP.IdVehiculoPMP = int.Parse(Request["idVehiculoPMP"].ToString());
                oHistoricoVahiculoPMP.Fecha = DateTime.Parse(txtFechaPMP.Text);
                oHistoricoVahiculoPMP.Kilometraje = int.Parse(txtKilometraje.Text);
                oHistoricoVahiculoPMP.Save();

                // Vuelvo a la pantalla de búsqueda
                string url = "VehiculoPMPHistoricoList.aspx?idVehiculoPMP=" + Request["idVehiculoPMP"].ToString() + "&idVehiculo=" + Request["idVehiculo"].ToString();
                Response.Redirect(url, false);
            }
        }

        // -----------------------------------------------------------------------------------------------------------------

        protected void IBVolver_Click(object sender, EventArgs e)
        {
            string url = "VehiculoPMPHistoricoList.aspx?idVehiculoPMP=" + Request["idVehiculoPMP"].ToString() + "&idVehiculo=" + Request["idVehiculo"].ToString();
            Response.Redirect(url, false);
        }

        // -----------------------------------------------------------------------------------------------------------------
    }
}

