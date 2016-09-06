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
    /// Controller class for PSM_EfisicoItems
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class PsmEfisicoItemController
    {
        // Preload our schema..
        PsmEfisicoItem thisSchemaLoad = new PsmEfisicoItem();
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
        public PsmEfisicoItemCollection FetchAll()
        {
            PsmEfisicoItemCollection coll = new PsmEfisicoItemCollection();
            Query qry = new Query(PsmEfisicoItem.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public PsmEfisicoItemCollection FetchByID(object IdPSMEfisicoItems)
        {
            PsmEfisicoItemCollection coll = new PsmEfisicoItemCollection().Where("idPSMEfisicoItems", IdPSMEfisicoItems).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public PsmEfisicoItemCollection FetchByQuery(Query qry)
        {
            PsmEfisicoItemCollection coll = new PsmEfisicoItemCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object IdPSMEfisicoItems)
        {
            return (PsmEfisicoItem.Delete(IdPSMEfisicoItems) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object IdPSMEfisicoItems)
        {
            return (PsmEfisicoItem.Destroy(IdPSMEfisicoItems) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(decimal IdPSMEfisicoItems,string Nombre)
	    {
		    PsmEfisicoItem item = new PsmEfisicoItem();
		    
            item.IdPSMEfisicoItems = IdPSMEfisicoItems;
            
            item.Nombre = Nombre;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(decimal IdPSMEfisicoItems,string Nombre)
	    {
		    PsmEfisicoItem item = new PsmEfisicoItem();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.IdPSMEfisicoItems = IdPSMEfisicoItems;
				
			item.Nombre = Nombre;
				
	        item.Save(UserName);
	    }
    }
}
