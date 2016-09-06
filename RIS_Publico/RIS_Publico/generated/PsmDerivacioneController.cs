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
    /// Controller class for PSM_Derivaciones
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class PsmDerivacioneController
    {
        // Preload our schema..
        PsmDerivacione thisSchemaLoad = new PsmDerivacione();
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
        public PsmDerivacioneCollection FetchAll()
        {
            PsmDerivacioneCollection coll = new PsmDerivacioneCollection();
            Query qry = new Query(PsmDerivacione.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public PsmDerivacioneCollection FetchByID(object IdDericiones)
        {
            PsmDerivacioneCollection coll = new PsmDerivacioneCollection().Where("idDericiones", IdDericiones).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public PsmDerivacioneCollection FetchByQuery(Query qry)
        {
            PsmDerivacioneCollection coll = new PsmDerivacioneCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object IdDericiones)
        {
            return (PsmDerivacione.Delete(IdDericiones) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object IdDericiones)
        {
            return (PsmDerivacione.Destroy(IdDericiones) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(int IdProsame,int IdEspecialidad)
	    {
		    PsmDerivacione item = new PsmDerivacione();
		    
            item.IdProsame = IdProsame;
            
            item.IdEspecialidad = IdEspecialidad;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int IdDericiones,int IdProsame,int IdEspecialidad)
	    {
		    PsmDerivacione item = new PsmDerivacione();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.IdDericiones = IdDericiones;
				
			item.IdProsame = IdProsame;
				
			item.IdEspecialidad = IdEspecialidad;
				
	        item.Save(UserName);
	    }
    }
}
