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
    /// Controller class for TAM_TipoTratamientoPap
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class TamTipoTratamientoPapController
    {
        // Preload our schema..
        TamTipoTratamientoPap thisSchemaLoad = new TamTipoTratamientoPap();
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
        public TamTipoTratamientoPapCollection FetchAll()
        {
            TamTipoTratamientoPapCollection coll = new TamTipoTratamientoPapCollection();
            Query qry = new Query(TamTipoTratamientoPap.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public TamTipoTratamientoPapCollection FetchByID(object IdTipoTratamientoPap)
        {
            TamTipoTratamientoPapCollection coll = new TamTipoTratamientoPapCollection().Where("idTipoTratamientoPap", IdTipoTratamientoPap).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public TamTipoTratamientoPapCollection FetchByQuery(Query qry)
        {
            TamTipoTratamientoPapCollection coll = new TamTipoTratamientoPapCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object IdTipoTratamientoPap)
        {
            return (TamTipoTratamientoPap.Delete(IdTipoTratamientoPap) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object IdTipoTratamientoPap)
        {
            return (TamTipoTratamientoPap.Destroy(IdTipoTratamientoPap) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string Nombre)
	    {
		    TamTipoTratamientoPap item = new TamTipoTratamientoPap();
		    
            item.Nombre = Nombre;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int IdTipoTratamientoPap,string Nombre)
	    {
		    TamTipoTratamientoPap item = new TamTipoTratamientoPap();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.IdTipoTratamientoPap = IdTipoTratamientoPap;
				
			item.Nombre = Nombre;
				
	        item.Save(UserName);
	    }
    }
}
