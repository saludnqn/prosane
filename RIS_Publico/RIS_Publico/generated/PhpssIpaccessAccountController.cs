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
    /// Controller class for phpss_ipaccess_account
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class PhpssIpaccessAccountController
    {
        // Preload our schema..
        PhpssIpaccessAccount thisSchemaLoad = new PhpssIpaccessAccount();
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
        public PhpssIpaccessAccountCollection FetchAll()
        {
            PhpssIpaccessAccountCollection coll = new PhpssIpaccessAccountCollection();
            Query qry = new Query(PhpssIpaccessAccount.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public PhpssIpaccessAccountCollection FetchByID(object Id)
        {
            PhpssIpaccessAccountCollection coll = new PhpssIpaccessAccountCollection().Where("id", Id).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public PhpssIpaccessAccountCollection FetchByQuery(Query qry)
        {
            PhpssIpaccessAccountCollection coll = new PhpssIpaccessAccountCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object Id)
        {
            return (PhpssIpaccessAccount.Delete(Id) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object Id)
        {
            return (PhpssIpaccessAccount.Destroy(Id) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string Ip,int Accountfid,string Access)
	    {
		    PhpssIpaccessAccount item = new PhpssIpaccessAccount();
		    
            item.Ip = Ip;
            
            item.Accountfid = Accountfid;
            
            item.Access = Access;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(string Ip,int Accountfid,string Access,int Id)
	    {
		    PhpssIpaccessAccount item = new PhpssIpaccessAccount();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.Ip = Ip;
				
			item.Accountfid = Accountfid;
				
			item.Access = Access;
				
			item.Id = Id;
				
	        item.Save(UserName);
	    }
    }
}
