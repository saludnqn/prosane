using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RIS_Publico
{
    public partial class WebForm2 : System.Web.UI.Page
    {

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Defalut.aspx", false);
        }

    }
}