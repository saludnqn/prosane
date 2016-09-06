using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Salud.Security.SSO;

namespace RIS_Publico
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {
                lblUsr.Text = string.Format("{0}, {1}", SSOHelper.CurrentIdentity.Surname, SSOHelper.CurrentIdentity.FirstName);
                lblEfector.Text = string.Format("{0}", SSOHelper.GetNombreEfectorRol(SSOHelper.CurrentIdentity.IdEfectorRol));


                string strsips = SSOHelper.Configuration["Publicacion_Sips"] as string;
                string strsso = SSOHelper.Configuration["Publicacion_SSO"] as string;


                ImgHomeSystem.PostBackUrl = "../" + strsips + "/default.aspx";
                ImgChangePass.PostBackUrl = "/" + strsso + "/Options.aspx";

                string url = HttpContext.Current.Request.QueryString["url"];
                if (string.IsNullOrEmpty(url))
                    url = SSOHelper.Configuration["StartPage"] as string;

                //ImgExit.PostBackUrl = String.Format("/"+strsso+"/Logout.aspx");
                ImgExit.PostBackUrl = "/" + strsso + "/Logout.aspx?relogin=1&url=" + url;

                ////Armo el menú de la Aplicación seleccionada para el efector seleccionado
                //List<SSOMenuItem> menu = SSOHelper.GetApplicationMenuByEfector();
                //lvMenuSSO.DataSource = menu[0].items;
                //lvMenuSSO.DataBind();
            }
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
            string strsso = SSOHelper.Configuration["Publicacion_SSO"] as string;
            //Response.Redirect("~/SSO/Logout.aspx");
            Response.Redirect("~/" + strsso + "/Logout.aspx");
        }   
    }
}