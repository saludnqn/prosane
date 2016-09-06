using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//using DALRis;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
using Salud.Security.SSO;

namespace Web
{
    public partial class Site1 : System.Web.UI.MasterPage {

        protected void Page_Load(object sender, EventArgs e)
        {
            SSOHelper.Authenticate();

            if (SSOHelper.CurrentIdentity == null)
            {
                SSOHelper.RedirectToSSOPage("Login.aspx", Request.Url.ToString());
            }

        }
    }

       

   



      

    //}
}
