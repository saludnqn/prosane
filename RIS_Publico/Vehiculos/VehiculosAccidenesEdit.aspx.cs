using System;
using System.Web.UI;
using DALAutomotores;

namespace Web.Vehiculos
{
    public partial class VehiculosAccidenesEdit : System.Web.UI.Page
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

                    AutVehiculo oVehiculo = new AutVehiculo(int.Parse(Request["idVehiculo"].ToString()));
                    lblDatosVehiculo.Text = "Accidentes del vehículo Dominio: " + oVehiculo.Dominio;

                    int idAccidente = int.Parse(Request["idAccidente"].ToString());

                    if (idAccidente != 0)
                    {
                        MostrarDatos(idAccidente);
                    }
                }
            }
        }

        // -----------------------------------------------------------------------------------------------------------

        private void MostrarDatos(int idAccidente)
        {
            AutAccidente oAccidente = new AutAccidente(idAccidente);

            txtFecha.Text = oAccidente.Fecha.ToShortDateString();
            txtDescripcion.Text = oAccidente.Descripcion;
        }

        // -----------------------------------------------------------------------------------------------------------

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                int idAccidente = int.Parse(Request["idAccidente"].ToString());

                AutAccidente oAccidente = new AutAccidente(idAccidente);

                oAccidente.Fecha = DateTime.Parse(txtFecha.Text);
                oAccidente.Descripcion = txtDescripcion.Text.Trim();
                oAccidente.IdVehiculo = int.Parse(Request["idVehiculo"].ToString());
                oAccidente.Save();

                // Vuelvo a la pantalla de búsqueda
                string url = "VehiculosAccidenesList.aspx?idVehiculo=" + Request["idVehiculo"].ToString();
                Response.Redirect(url, false);
            }
        }

        // -----------------------------------------------------------------------------------------------------------------

        protected void IBVolver_Click(object sender, EventArgs e)
        {
            string url = "VehiculosAccidenesList.aspx?&idVehiculo=" + Request["idVehiculo"].ToString();                          
            Response.Redirect(url, false);
        }

        // -----------------------------------------------------------------------------------------------------------------
    }
}


