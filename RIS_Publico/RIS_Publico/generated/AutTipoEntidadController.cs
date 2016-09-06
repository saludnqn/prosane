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
    /// Controller class for AUT_TipoEntidad
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class AutTipoEntidadController
    {
        // Preload our schema..
        AutTipoEntidad thisSchemaLoad = new AutTipoEntidad();
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
        public AutTipoEntidadCollection FetchAll()
        {
            AutTipoEntidadCollection coll = new AutTipoEntidadCollection();
            Query qry = new Query(AutTipoEntidad.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public AutTipoEntidadCollection FetchByID(object IdTipoEntidad)
        {
            AutTipoEntidadCollection coll = new AutTipoEntidadCollection().Where("idTipoEntidad", IdTipoEntidad).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public AutTipoEntidadCollection FetchByQuery(Query qry)
        {
            AutTipoEntidadCollection coll = new AutTipoEntidadCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object IdTipoEntidad)
        {
            return (AutTipoEntidad.Delete(IdTipoEntidad) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object IdTipoEntidad)
        {
            return (AutTipoEntidad.Destroy(IdTipoEntidad) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string Nombre)
	    {
		    AutTipoEntidad item = new AutTipoEntidad();
		    
            item.Nombre = Nombre;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int IdTipoEntidad,string Nombre)
	    {
		    AutTipoEntidad item = new AutTipoEntidad();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.IdTipoEntidad = IdTipoEntidad;
				
			item.Nombre = Nombre;
				
	        item.Save(UserName);
	    }
    }
}
