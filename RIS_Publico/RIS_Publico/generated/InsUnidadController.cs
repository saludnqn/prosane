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
    /// Controller class for INS_Unidad
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class InsUnidadController
    {
        // Preload our schema..
        InsUnidad thisSchemaLoad = new InsUnidad();
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
        public InsUnidadCollection FetchAll()
        {
            InsUnidadCollection coll = new InsUnidadCollection();
            Query qry = new Query(InsUnidad.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public InsUnidadCollection FetchByID(object IdUnidad)
        {
            InsUnidadCollection coll = new InsUnidadCollection().Where("idUnidad", IdUnidad).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public InsUnidadCollection FetchByQuery(Query qry)
        {
            InsUnidadCollection coll = new InsUnidadCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object IdUnidad)
        {
            return (InsUnidad.Delete(IdUnidad) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object IdUnidad)
        {
            return (InsUnidad.Destroy(IdUnidad) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string Nombre,int? SimelaGrupo,decimal? SimelaRelacion,bool Baja)
	    {
		    InsUnidad item = new InsUnidad();
		    
            item.Nombre = Nombre;
            
            item.SimelaGrupo = SimelaGrupo;
            
            item.SimelaRelacion = SimelaRelacion;
            
            item.Baja = Baja;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int IdUnidad,string Nombre,int? SimelaGrupo,decimal? SimelaRelacion,bool Baja)
	    {
		    InsUnidad item = new InsUnidad();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.IdUnidad = IdUnidad;
				
			item.Nombre = Nombre;
				
			item.SimelaGrupo = SimelaGrupo;
				
			item.SimelaRelacion = SimelaRelacion;
				
			item.Baja = Baja;
				
	        item.Save(UserName);
	    }
    }
}
