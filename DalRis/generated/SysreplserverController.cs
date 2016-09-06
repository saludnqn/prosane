using System; 
using System.Text; 
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration; 
using System.Xml; 
using System.Xml.Serialization;
using SubSonic; 
using SubSonic.Utilities;
namespace DalRis
{
    /// <summary>
    /// Controller class for sysreplservers
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class SysreplserverController
    {
        // Preload our schema..
        Sysreplserver thisSchemaLoad = new Sysreplserver();
        private string userName = String.Empty;
        protected string UserName
        {
            get
            {
				if (userName.Length == 0) 
				{
    				if (System.Web.HttpContext.Current != null)
    				{
						userName=System.Web.HttpContext.Current.User.Identity.Name;
					}
					else
					{
						userName=System.Threading.Thread.CurrentPrincipal.Identity.Name;
					}
				}
				return userName;
            }
        }
        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public SysreplserverCollection FetchAll()
        {
            SysreplserverCollection coll = new SysreplserverCollection();
            Query qry = new Query(Sysreplserver.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public SysreplserverCollection FetchByID(object Srvname)
        {
            SysreplserverCollection coll = new SysreplserverCollection().Where("srvname", Srvname).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public SysreplserverCollection FetchByQuery(Query qry)
        {
            SysreplserverCollection coll = new SysreplserverCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object Srvname)
        {
            return (Sysreplserver.Delete(Srvname) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object Srvname)
        {
            return (Sysreplserver.Destroy(Srvname) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string Srvname,int? Srvid)
	    {
		    Sysreplserver item = new Sysreplserver();
		    
            item.Srvname = Srvname;
            
            item.Srvid = Srvid;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(string Srvname,int? Srvid)
	    {
		    Sysreplserver item = new Sysreplserver();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.Srvname = Srvname;
				
			item.Srvid = Srvid;
				
	        item.Save(UserName);
	    }
    }
}
