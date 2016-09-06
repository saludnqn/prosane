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
    /// Controller class for FAC_NomencladorExclusion
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class FacNomencladorExclusionController
    {
        // Preload our schema..
        FacNomencladorExclusion thisSchemaLoad = new FacNomencladorExclusion();
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
        public FacNomencladorExclusionCollection FetchAll()
        {
            FacNomencladorExclusionCollection coll = new FacNomencladorExclusionCollection();
            Query qry = new Query(FacNomencladorExclusion.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public FacNomencladorExclusionCollection FetchByID(object IdNomencladorExclusion)
        {
            FacNomencladorExclusionCollection coll = new FacNomencladorExclusionCollection().Where("idNomencladorExclusion", IdNomencladorExclusion).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public FacNomencladorExclusionCollection FetchByQuery(Query qry)
        {
            FacNomencladorExclusionCollection coll = new FacNomencladorExclusionCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object IdNomencladorExclusion)
        {
            return (FacNomencladorExclusion.Delete(IdNomencladorExclusion) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object IdNomencladorExclusion)
        {
            return (FacNomencladorExclusion.Destroy(IdNomencladorExclusion) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string Tipo,string Descripcion,string PrecioSugerido)
	    {
		    FacNomencladorExclusion item = new FacNomencladorExclusion();
		    
            item.Tipo = Tipo;
            
            item.Descripcion = Descripcion;
            
            item.PrecioSugerido = PrecioSugerido;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int IdNomencladorExclusion,string Tipo,string Descripcion,string PrecioSugerido)
	    {
		    FacNomencladorExclusion item = new FacNomencladorExclusion();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.IdNomencladorExclusion = IdNomencladorExclusion;
				
			item.Tipo = Tipo;
				
			item.Descripcion = Descripcion;
				
			item.PrecioSugerido = PrecioSugerido;
				
	        item.Save(UserName);
	    }
    }
}
