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
    /// Controller class for phpss_session
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class PhpssSessionController
    {
        // Preload our schema..
        PhpssSession thisSchemaLoad = new PhpssSession();
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
        public PhpssSessionCollection FetchAll()
        {
            PhpssSessionCollection coll = new PhpssSessionCollection();
            Query qry = new Query(PhpssSession.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public PhpssSessionCollection FetchByID(object Id)
        {
            PhpssSessionCollection coll = new PhpssSessionCollection().Where("id", Id).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public PhpssSessionCollection FetchByQuery(Query qry)
        {
            PhpssSessionCollection coll = new PhpssSessionCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object Id)
        {
            return (PhpssSession.Delete(Id) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object Id)
        {
            return (PhpssSession.Destroy(Id) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string Sessionkey,int? Accountfid,long Ipfid,DateTime Created,DateTime Lastrequest,string Active)
	    {
		    PhpssSession item = new PhpssSession();
		    
            item.Sessionkey = Sessionkey;
            
            item.Accountfid = Accountfid;
            
            item.Ipfid = Ipfid;
            
            item.Created = Created;
            
            item.Lastrequest = Lastrequest;
            
            item.Active = Active;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int Id,string Sessionkey,int? Accountfid,long Ipfid,DateTime Created,DateTime Lastrequest,string Active)
	    {
		    PhpssSession item = new PhpssSession();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.Id = Id;
				
			item.Sessionkey = Sessionkey;
				
			item.Accountfid = Accountfid;
				
			item.Ipfid = Ipfid;
				
			item.Created = Created;
				
			item.Lastrequest = Lastrequest;
				
			item.Active = Active;
				
	        item.Save(UserName);
	    }
    }
}
