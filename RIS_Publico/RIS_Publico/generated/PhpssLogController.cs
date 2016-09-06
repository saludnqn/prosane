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
    /// Controller class for phpss_log
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class PhpssLogController
    {
        // Preload our schema..
        PhpssLog thisSchemaLoad = new PhpssLog();
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
        public PhpssLogCollection FetchAll()
        {
            PhpssLogCollection coll = new PhpssLogCollection();
            Query qry = new Query(PhpssLog.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public PhpssLogCollection FetchByID(object Id)
        {
            PhpssLogCollection coll = new PhpssLogCollection().Where("id", Id).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public PhpssLogCollection FetchByQuery(Query qry)
        {
            PhpssLogCollection coll = new PhpssLogCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object Id)
        {
            return (PhpssLog.Delete(Id) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object Id)
        {
            return (PhpssLog.Destroy(Id) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(DateTime Timestamp,int? Sessionfid,int? Accountfid,int Ipfid,string ModuleX,string Message)
	    {
		    PhpssLog item = new PhpssLog();
		    
            item.Timestamp = Timestamp;
            
            item.Sessionfid = Sessionfid;
            
            item.Accountfid = Accountfid;
            
            item.Ipfid = Ipfid;
            
            item.ModuleX = ModuleX;
            
            item.Message = Message;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int Id,DateTime Timestamp,int? Sessionfid,int? Accountfid,int Ipfid,string ModuleX,string Message)
	    {
		    PhpssLog item = new PhpssLog();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.Id = Id;
				
			item.Timestamp = Timestamp;
				
			item.Sessionfid = Sessionfid;
				
			item.Accountfid = Accountfid;
				
			item.Ipfid = Ipfid;
				
			item.ModuleX = ModuleX;
				
			item.Message = Message;
				
	        item.Save(UserName);
	    }
    }
}
