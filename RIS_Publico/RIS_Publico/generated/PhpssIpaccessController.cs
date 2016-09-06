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
    /// Controller class for phpss_ipaccess
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class PhpssIpaccessController
    {
        // Preload our schema..
        PhpssIpaccess thisSchemaLoad = new PhpssIpaccess();
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
        public PhpssIpaccessCollection FetchAll()
        {
            PhpssIpaccessCollection coll = new PhpssIpaccessCollection();
            Query qry = new Query(PhpssIpaccess.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public PhpssIpaccessCollection FetchByID(object Id)
        {
            PhpssIpaccessCollection coll = new PhpssIpaccessCollection().Where("id", Id).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public PhpssIpaccessCollection FetchByQuery(Query qry)
        {
            PhpssIpaccessCollection coll = new PhpssIpaccessCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object Id)
        {
            return (PhpssIpaccess.Delete(Id) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object Id)
        {
            return (PhpssIpaccess.Destroy(Id) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string Ip,string Access)
	    {
		    PhpssIpaccess item = new PhpssIpaccess();
		    
            item.Ip = Ip;
            
            item.Access = Access;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(string Ip,string Access,int Id)
	    {
		    PhpssIpaccess item = new PhpssIpaccess();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.Ip = Ip;
				
			item.Access = Access;
				
			item.Id = Id;
				
	        item.Save(UserName);
	    }
    }
}
