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
    /// Controller class for TAM_TipoHpv
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class TamTipoHpvController
    {
        // Preload our schema..
        TamTipoHpv thisSchemaLoad = new TamTipoHpv();
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
        public TamTipoHpvCollection FetchAll()
        {
            TamTipoHpvCollection coll = new TamTipoHpvCollection();
            Query qry = new Query(TamTipoHpv.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public TamTipoHpvCollection FetchByID(object IdTipoHpv)
        {
            TamTipoHpvCollection coll = new TamTipoHpvCollection().Where("idTipoHpv", IdTipoHpv).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public TamTipoHpvCollection FetchByQuery(Query qry)
        {
            TamTipoHpvCollection coll = new TamTipoHpvCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object IdTipoHpv)
        {
            return (TamTipoHpv.Delete(IdTipoHpv) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object IdTipoHpv)
        {
            return (TamTipoHpv.Destroy(IdTipoHpv) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string Nombre)
	    {
		    TamTipoHpv item = new TamTipoHpv();
		    
            item.Nombre = Nombre;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int IdTipoHpv,string Nombre)
	    {
		    TamTipoHpv item = new TamTipoHpv();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.IdTipoHpv = IdTipoHpv;
				
			item.Nombre = Nombre;
				
	        item.Save(UserName);
	    }
    }
}
