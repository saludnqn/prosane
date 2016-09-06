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
    /// Controller class for phpss_ipaccess_group
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class PhpssIpaccessGroupController
    {
        // Preload our schema..
        PhpssIpaccessGroup thisSchemaLoad = new PhpssIpaccessGroup();
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
        public PhpssIpaccessGroupCollection FetchAll()
        {
            PhpssIpaccessGroupCollection coll = new PhpssIpaccessGroupCollection();
            Query qry = new Query(PhpssIpaccessGroup.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public PhpssIpaccessGroupCollection FetchByID(object Id)
        {
            PhpssIpaccessGroupCollection coll = new PhpssIpaccessGroupCollection().Where("id", Id).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public PhpssIpaccessGroupCollection FetchByQuery(Query qry)
        {
            PhpssIpaccessGroupCollection coll = new PhpssIpaccessGroupCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object Id)
        {
            return (PhpssIpaccessGroup.Delete(Id) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object Id)
        {
            return (PhpssIpaccessGroup.Destroy(Id) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string Ip,int Groupfid,string Access)
	    {
		    PhpssIpaccessGroup item = new PhpssIpaccessGroup();
		    
            item.Ip = Ip;
            
            item.Groupfid = Groupfid;
            
            item.Access = Access;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(string Ip,int Groupfid,string Access,int Id)
	    {
		    PhpssIpaccessGroup item = new PhpssIpaccessGroup();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.Ip = Ip;
				
			item.Groupfid = Groupfid;
				
			item.Access = Access;
				
			item.Id = Id;
				
	        item.Save(UserName);
	    }
    }
}
