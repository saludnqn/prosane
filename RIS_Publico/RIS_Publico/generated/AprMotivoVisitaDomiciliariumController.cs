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
    /// Controller class for APR_MotivoVisitaDomiciliaria
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class AprMotivoVisitaDomiciliariumController
    {
        // Preload our schema..
        AprMotivoVisitaDomiciliarium thisSchemaLoad = new AprMotivoVisitaDomiciliarium();
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
        public AprMotivoVisitaDomiciliariumCollection FetchAll()
        {
            AprMotivoVisitaDomiciliariumCollection coll = new AprMotivoVisitaDomiciliariumCollection();
            Query qry = new Query(AprMotivoVisitaDomiciliarium.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public AprMotivoVisitaDomiciliariumCollection FetchByID(object IdMotivoVisitaDomiciliaria)
        {
            AprMotivoVisitaDomiciliariumCollection coll = new AprMotivoVisitaDomiciliariumCollection().Where("idMotivoVisitaDomiciliaria", IdMotivoVisitaDomiciliaria).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public AprMotivoVisitaDomiciliariumCollection FetchByQuery(Query qry)
        {
            AprMotivoVisitaDomiciliariumCollection coll = new AprMotivoVisitaDomiciliariumCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object IdMotivoVisitaDomiciliaria)
        {
            return (AprMotivoVisitaDomiciliarium.Delete(IdMotivoVisitaDomiciliaria) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object IdMotivoVisitaDomiciliaria)
        {
            return (AprMotivoVisitaDomiciliarium.Destroy(IdMotivoVisitaDomiciliaria) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string Nombre,string CreatedBy,DateTime? CreatedOn,string ModifiedBy,DateTime? ModifiedOn)
	    {
		    AprMotivoVisitaDomiciliarium item = new AprMotivoVisitaDomiciliarium();
		    
            item.Nombre = Nombre;
            
            item.CreatedBy = CreatedBy;
            
            item.CreatedOn = CreatedOn;
            
            item.ModifiedBy = ModifiedBy;
            
            item.ModifiedOn = ModifiedOn;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int IdMotivoVisitaDomiciliaria,string Nombre,string CreatedBy,DateTime? CreatedOn,string ModifiedBy,DateTime? ModifiedOn)
	    {
		    AprMotivoVisitaDomiciliarium item = new AprMotivoVisitaDomiciliarium();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.IdMotivoVisitaDomiciliaria = IdMotivoVisitaDomiciliaria;
				
			item.Nombre = Nombre;
				
			item.CreatedBy = CreatedBy;
				
			item.CreatedOn = CreatedOn;
				
			item.ModifiedBy = ModifiedBy;
				
			item.ModifiedOn = ModifiedOn;
				
	        item.Save(UserName);
	    }
    }
}
