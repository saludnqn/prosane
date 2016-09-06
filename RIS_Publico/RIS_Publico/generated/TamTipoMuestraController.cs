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
    /// Controller class for TAM_TipoMuestra
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class TamTipoMuestraController
    {
        // Preload our schema..
        TamTipoMuestra thisSchemaLoad = new TamTipoMuestra();
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
        public TamTipoMuestraCollection FetchAll()
        {
            TamTipoMuestraCollection coll = new TamTipoMuestraCollection();
            Query qry = new Query(TamTipoMuestra.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public TamTipoMuestraCollection FetchByID(object IdTipoMuestra)
        {
            TamTipoMuestraCollection coll = new TamTipoMuestraCollection().Where("idTipoMuestra", IdTipoMuestra).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public TamTipoMuestraCollection FetchByQuery(Query qry)
        {
            TamTipoMuestraCollection coll = new TamTipoMuestraCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object IdTipoMuestra)
        {
            return (TamTipoMuestra.Delete(IdTipoMuestra) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object IdTipoMuestra)
        {
            return (TamTipoMuestra.Destroy(IdTipoMuestra) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string Nombre,string Variable)
	    {
		    TamTipoMuestra item = new TamTipoMuestra();
		    
            item.Nombre = Nombre;
            
            item.Variable = Variable;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int IdTipoMuestra,string Nombre,string Variable)
	    {
		    TamTipoMuestra item = new TamTipoMuestra();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.IdTipoMuestra = IdTipoMuestra;
				
			item.Nombre = Nombre;
				
			item.Variable = Variable;
				
	        item.Save(UserName);
	    }
    }
}
