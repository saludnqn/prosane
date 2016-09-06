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
    /// Controller class for phpss_svars
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class PhpssSvarController
    {
        // Preload our schema..
        PhpssSvar thisSchemaLoad = new PhpssSvar();
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
        public PhpssSvarCollection FetchAll()
        {
            PhpssSvarCollection coll = new PhpssSvarCollection();
            Query qry = new Query(PhpssSvar.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public PhpssSvarCollection FetchByID(object Id)
        {
            PhpssSvarCollection coll = new PhpssSvarCollection().Where("id", Id).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public PhpssSvarCollection FetchByQuery(Query qry)
        {
            PhpssSvarCollection coll = new PhpssSvarCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object Id)
        {
            return (PhpssSvar.Delete(Id) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object Id)
        {
            return (PhpssSvar.Destroy(Id) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(int Sessionfid,string Name,string Data)
	    {
		    PhpssSvar item = new PhpssSvar();
		    
            item.Sessionfid = Sessionfid;
            
            item.Name = Name;
            
            item.Data = Data;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int Sessionfid,string Name,string Data,int Id)
	    {
		    PhpssSvar item = new PhpssSvar();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.Sessionfid = Sessionfid;
				
			item.Name = Name;
				
			item.Data = Data;
				
			item.Id = Id;
				
	        item.Save(UserName);
	    }
    }
}
