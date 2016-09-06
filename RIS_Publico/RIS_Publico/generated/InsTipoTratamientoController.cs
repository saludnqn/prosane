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
    /// Controller class for INS_TipoTratamiento
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class InsTipoTratamientoController
    {
        // Preload our schema..
        InsTipoTratamiento thisSchemaLoad = new InsTipoTratamiento();
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
        public InsTipoTratamientoCollection FetchAll()
        {
            InsTipoTratamientoCollection coll = new InsTipoTratamientoCollection();
            Query qry = new Query(InsTipoTratamiento.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public InsTipoTratamientoCollection FetchByID(object IdTipoTratamiento)
        {
            InsTipoTratamientoCollection coll = new InsTipoTratamientoCollection().Where("idTipoTratamiento", IdTipoTratamiento).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public InsTipoTratamientoCollection FetchByQuery(Query qry)
        {
            InsTipoTratamientoCollection coll = new InsTipoTratamientoCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object IdTipoTratamiento)
        {
            return (InsTipoTratamiento.Delete(IdTipoTratamiento) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object IdTipoTratamiento)
        {
            return (InsTipoTratamiento.Destroy(IdTipoTratamiento) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string Nombre)
	    {
		    InsTipoTratamiento item = new InsTipoTratamiento();
		    
            item.Nombre = Nombre;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int IdTipoTratamiento,string Nombre)
	    {
		    InsTipoTratamiento item = new InsTipoTratamiento();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.IdTipoTratamiento = IdTipoTratamiento;
				
			item.Nombre = Nombre;
				
	        item.Save(UserName);
	    }
    }
}
