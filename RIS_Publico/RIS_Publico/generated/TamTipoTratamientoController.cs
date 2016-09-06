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
    /// Controller class for TAM_TipoTratamiento
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class TamTipoTratamientoController
    {
        // Preload our schema..
        TamTipoTratamiento thisSchemaLoad = new TamTipoTratamiento();
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
        public TamTipoTratamientoCollection FetchAll()
        {
            TamTipoTratamientoCollection coll = new TamTipoTratamientoCollection();
            Query qry = new Query(TamTipoTratamiento.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public TamTipoTratamientoCollection FetchByID(object IdTipoTratamiento)
        {
            TamTipoTratamientoCollection coll = new TamTipoTratamientoCollection().Where("idTipoTratamiento", IdTipoTratamiento).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public TamTipoTratamientoCollection FetchByQuery(Query qry)
        {
            TamTipoTratamientoCollection coll = new TamTipoTratamientoCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object IdTipoTratamiento)
        {
            return (TamTipoTratamiento.Delete(IdTipoTratamiento) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object IdTipoTratamiento)
        {
            return (TamTipoTratamiento.Destroy(IdTipoTratamiento) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string Nombre)
	    {
		    TamTipoTratamiento item = new TamTipoTratamiento();
		    
            item.Nombre = Nombre;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int IdTipoTratamiento,string Nombre)
	    {
		    TamTipoTratamiento item = new TamTipoTratamiento();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.IdTipoTratamiento = IdTipoTratamiento;
				
			item.Nombre = Nombre;
				
	        item.Save(UserName);
	    }
    }
}
