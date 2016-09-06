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
    /// Controller class for TAM_TipoMaterialBiopsia
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class TamTipoMaterialBiopsiumController
    {
        // Preload our schema..
        TamTipoMaterialBiopsium thisSchemaLoad = new TamTipoMaterialBiopsium();
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
        public TamTipoMaterialBiopsiumCollection FetchAll()
        {
            TamTipoMaterialBiopsiumCollection coll = new TamTipoMaterialBiopsiumCollection();
            Query qry = new Query(TamTipoMaterialBiopsium.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public TamTipoMaterialBiopsiumCollection FetchByID(object IdTipoMaterialBiopsia)
        {
            TamTipoMaterialBiopsiumCollection coll = new TamTipoMaterialBiopsiumCollection().Where("idTipoMaterialBiopsia", IdTipoMaterialBiopsia).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public TamTipoMaterialBiopsiumCollection FetchByQuery(Query qry)
        {
            TamTipoMaterialBiopsiumCollection coll = new TamTipoMaterialBiopsiumCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object IdTipoMaterialBiopsia)
        {
            return (TamTipoMaterialBiopsium.Delete(IdTipoMaterialBiopsia) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object IdTipoMaterialBiopsia)
        {
            return (TamTipoMaterialBiopsium.Destroy(IdTipoMaterialBiopsia) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string Nombre,bool Activo)
	    {
		    TamTipoMaterialBiopsium item = new TamTipoMaterialBiopsium();
		    
            item.Nombre = Nombre;
            
            item.Activo = Activo;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int IdTipoMaterialBiopsia,string Nombre,bool Activo)
	    {
		    TamTipoMaterialBiopsium item = new TamTipoMaterialBiopsium();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.IdTipoMaterialBiopsia = IdTipoMaterialBiopsia;
				
			item.Nombre = Nombre;
				
			item.Activo = Activo;
				
	        item.Save(UserName);
	    }
    }
}
