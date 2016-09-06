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
    /// Controller class for AUT_Entidad
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class AutEntidadController
    {
        // Preload our schema..
        AutEntidad thisSchemaLoad = new AutEntidad();
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
        public AutEntidadCollection FetchAll()
        {
            AutEntidadCollection coll = new AutEntidadCollection();
            Query qry = new Query(AutEntidad.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public AutEntidadCollection FetchByID(object IdEntidad)
        {
            AutEntidadCollection coll = new AutEntidadCollection().Where("idEntidad", IdEntidad).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public AutEntidadCollection FetchByQuery(Query qry)
        {
            AutEntidadCollection coll = new AutEntidadCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object IdEntidad)
        {
            return (AutEntidad.Delete(IdEntidad) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object IdEntidad)
        {
            return (AutEntidad.Destroy(IdEntidad) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string Nombre,int IdZona,int IdEntidadSuperior,int IdTipoEntidad)
	    {
		    AutEntidad item = new AutEntidad();
		    
            item.Nombre = Nombre;
            
            item.IdZona = IdZona;
            
            item.IdEntidadSuperior = IdEntidadSuperior;
            
            item.IdTipoEntidad = IdTipoEntidad;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int IdEntidad,string Nombre,int IdZona,int IdEntidadSuperior,int IdTipoEntidad)
	    {
		    AutEntidad item = new AutEntidad();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.IdEntidad = IdEntidad;
				
			item.Nombre = Nombre;
				
			item.IdZona = IdZona;
				
			item.IdEntidadSuperior = IdEntidadSuperior;
				
			item.IdTipoEntidad = IdTipoEntidad;
				
	        item.Save(UserName);
	    }
    }
}
