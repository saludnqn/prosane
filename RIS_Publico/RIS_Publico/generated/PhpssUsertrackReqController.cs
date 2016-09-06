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
    /// Controller class for phpss_usertrack_req
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class PhpssUsertrackReqController
    {
        // Preload our schema..
        PhpssUsertrackReq thisSchemaLoad = new PhpssUsertrackReq();
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
        public PhpssUsertrackReqCollection FetchAll()
        {
            PhpssUsertrackReqCollection coll = new PhpssUsertrackReqCollection();
            Query qry = new Query(PhpssUsertrackReq.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public PhpssUsertrackReqCollection FetchByID(object Id)
        {
            PhpssUsertrackReqCollection coll = new PhpssUsertrackReqCollection().Where("id", Id).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public PhpssUsertrackReqCollection FetchByQuery(Query qry)
        {
            PhpssUsertrackReqCollection coll = new PhpssUsertrackReqCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object Id)
        {
            return (PhpssUsertrackReq.Delete(Id) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object Id)
        {
            return (PhpssUsertrackReq.Destroy(Id) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(int Sessionfid,short Accountfid,DateTime Timestamp,int UsertrackUrlfid)
	    {
		    PhpssUsertrackReq item = new PhpssUsertrackReq();
		    
            item.Sessionfid = Sessionfid;
            
            item.Accountfid = Accountfid;
            
            item.Timestamp = Timestamp;
            
            item.UsertrackUrlfid = UsertrackUrlfid;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(long Id,int Sessionfid,short Accountfid,DateTime Timestamp,int UsertrackUrlfid)
	    {
		    PhpssUsertrackReq item = new PhpssUsertrackReq();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.Id = Id;
				
			item.Sessionfid = Sessionfid;
				
			item.Accountfid = Accountfid;
				
			item.Timestamp = Timestamp;
				
			item.UsertrackUrlfid = UsertrackUrlfid;
				
	        item.Save(UserName);
	    }
    }
}
