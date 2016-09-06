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
    /// Controller class for phpss_usertrack_url
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class PhpssUsertrackUrlController
    {
        // Preload our schema..
        PhpssUsertrackUrl thisSchemaLoad = new PhpssUsertrackUrl();
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
        public PhpssUsertrackUrlCollection FetchAll()
        {
            PhpssUsertrackUrlCollection coll = new PhpssUsertrackUrlCollection();
            Query qry = new Query(PhpssUsertrackUrl.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public PhpssUsertrackUrlCollection FetchByID(object Id)
        {
            PhpssUsertrackUrlCollection coll = new PhpssUsertrackUrlCollection().Where("id", Id).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public PhpssUsertrackUrlCollection FetchByQuery(Query qry)
        {
            PhpssUsertrackUrlCollection coll = new PhpssUsertrackUrlCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object Id)
        {
            return (PhpssUsertrackUrl.Delete(Id) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object Id)
        {
            return (PhpssUsertrackUrl.Destroy(Id) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string Url)
	    {
		    PhpssUsertrackUrl item = new PhpssUsertrackUrl();
		    
            item.Url = Url;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int Id,string Url)
	    {
		    PhpssUsertrackUrl item = new PhpssUsertrackUrl();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.Id = Id;
				
			item.Url = Url;
				
	        item.Save(UserName);
	    }
    }
}
