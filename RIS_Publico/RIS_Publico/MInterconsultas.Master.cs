using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;
using DalRis;
using Salud.Security.SSO;
using System.Web;

using System.Web.Security;
using System.Linq;
using System.Web.UI;


namespace RIS_Publico
{
    public partial class mInterconsultas : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           SSOHelper.Authenticate();

            if (SSOHelper.CurrentIdentity == null)
            {
                SSOHelper.RedirectToSSOPage("Login.aspx", Request.Url.ToString());
            }
            SysEfector efector = null;
            efector = new SysEfector(SSOHelper.CurrentIdentity.IdEfector);

            //lblUsr.Text = string.Format("{0}, {1}", SSOHelper.CurrentIdentity.Surname, SSOHelper.CurrentIdentity.FirstName);
            lblUsr.Text = string.Format(" {0}", SSOHelper.CurrentIdentity.Surname + " " + SSOHelper.CurrentIdentity.FirstName);
            lblEfector.Text = string.Format("{0}", efector.Nombre);
            //lblEfector.Text = string.Format("{0}", SSOHelper.GetNombreEfectorRol(SSOHelper.CurrentIdentity.IdEfectorRol));
            Session["SessionEfector"] = lblEfector.Text;


            ImgHomeSip.PostBackUrl = "/Sips/Default.aspx";
            ImgHomeSystem.PostBackUrl = "Default.aspx";
            ImgChangePass.PostBackUrl = "/SSO/Options.aspx";

            string url = HttpContext.Current.Request.QueryString["url"];
            if (string.IsNullOrEmpty(url))
                url = SSOHelper.Configuration["StartPage"] as string;

            ImgExit.PostBackUrl = "/SSO/Logout.aspx?relogin=1&url=" + url + "/sips";

            ////Armo el menú de la Aplicación seleccionada para el efector seleccionado
          /*  List<SSOMenuItem> menu = SSOHelper.GetApplicationMenuByEfector();
            lvMenuSSO.DataSource = menu[0].items;
            lvMenuSSO.DataBind();
           */
        }

       protected void lvMenuSSO_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                ListView lv = (ListView)e.Item.FindControl("lvSubMenuSSO");
                if (lv != null)
                {
                    ListViewDataItem dataItem = (ListViewDataItem)e.Item;
                    if (dataItem != null)
                    {
                        SSOMenuItem node = (SSOMenuItem)dataItem.DataItem;
                        List<SSOMenuItem> dv = node.items;
                        if (dv.Count > 0)
                        {
                            lv.DataSource = dv;
                            lv.DataBind();
                            HyperLink hl = (HyperLink)lv.Parent.FindControl("hlMenu2");
                            if (hl != null)
                                hl.Text = node.text;
                        }
                        else
                        {
                            lv.Visible = false;
                        }
                    }
                }
            }
        }

        protected void hkbSesion_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/SSO/Logout.aspx");
        }
    }
}
