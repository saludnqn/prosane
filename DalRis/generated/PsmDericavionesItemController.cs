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
    /// Controller class for PSM_DericavionesItems
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class PsmDericavionesItemController
    {
        // Preload our schema..
        PsmDericavionesItem thisSchemaLoad = new PsmDericavionesItem();
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
        public PsmDericavionesItemCollection FetchAll()
        {
            PsmDericavionesItemCollection coll = new PsmDericavionesItemCollection();
            Query qry = new Query(PsmDericavionesItem.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public PsmDericavionesItemCollection FetchByID(object IdPSMDerivacines)
        {
            PsmDericavionesItemCollection coll = new PsmDericavionesItemCollection().Where("idPSMDerivacines", IdPSMDerivacines).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public PsmDericavionesItemCollection FetchByQuery(Query qry)
        {
            PsmDericavionesItemCollection coll = new PsmDericavionesItemCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object IdPSMDerivacines)
        {
            return (PsmDericavionesItem.Delete(IdPSMDerivacines) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object IdPSMDerivacines)
        {
            return (PsmDericavionesItem.Destroy(IdPSMDerivacines) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string IdPSMDerivacines,string Nombre)
	    {
		    PsmDericavionesItem item = new PsmDericavionesItem();
		    
            item.IdPSMDerivacines = IdPSMDerivacines;
            
            item.Nombre = Nombre;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(string IdPSMDerivacines,string Nombre)
	    {
		    PsmDericavionesItem item = new PsmDericavionesItem();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.IdPSMDerivacines = IdPSMDerivacines;
				
			item.Nombre = Nombre;
				
	        item.Save(UserName);
	    }
    }
}
