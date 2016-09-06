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
    /// Controller class for FAC_Unidad
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class FacUnidadController
    {
        // Preload our schema..
        FacUnidad thisSchemaLoad = new FacUnidad();
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
        public FacUnidadCollection FetchAll()
        {
            FacUnidadCollection coll = new FacUnidadCollection();
            Query qry = new Query(FacUnidad.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public FacUnidadCollection FetchByID(object IdUnidad)
        {
            FacUnidadCollection coll = new FacUnidadCollection().Where("idUnidad", IdUnidad).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public FacUnidadCollection FetchByQuery(Query qry)
        {
            FacUnidadCollection coll = new FacUnidadCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object IdUnidad)
        {
            return (FacUnidad.Delete(IdUnidad) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object IdUnidad)
        {
            return (FacUnidad.Destroy(IdUnidad) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string Nombre,string Simbolo)
	    {
		    FacUnidad item = new FacUnidad();
		    
            item.Nombre = Nombre;
            
            item.Simbolo = Simbolo;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int IdUnidad,string Nombre,string Simbolo)
	    {
		    FacUnidad item = new FacUnidad();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.IdUnidad = IdUnidad;
				
			item.Nombre = Nombre;
				
			item.Simbolo = Simbolo;
				
	        item.Save(UserName);
	    }
    }
}
