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
    /// Controller class for TAM_ResultadoHpv
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class TamResultadoHpvController
    {
        // Preload our schema..
        TamResultadoHpv thisSchemaLoad = new TamResultadoHpv();
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
        public TamResultadoHpvCollection FetchAll()
        {
            TamResultadoHpvCollection coll = new TamResultadoHpvCollection();
            Query qry = new Query(TamResultadoHpv.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public TamResultadoHpvCollection FetchByID(object IdResultadoHpv)
        {
            TamResultadoHpvCollection coll = new TamResultadoHpvCollection().Where("idResultadoHpv", IdResultadoHpv).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public TamResultadoHpvCollection FetchByQuery(Query qry)
        {
            TamResultadoHpvCollection coll = new TamResultadoHpvCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object IdResultadoHpv)
        {
            return (TamResultadoHpv.Delete(IdResultadoHpv) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object IdResultadoHpv)
        {
            return (TamResultadoHpv.Destroy(IdResultadoHpv) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string Nombre)
	    {
		    TamResultadoHpv item = new TamResultadoHpv();
		    
            item.Nombre = Nombre;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int IdResultadoHpv,string Nombre)
	    {
		    TamResultadoHpv item = new TamResultadoHpv();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.IdResultadoHpv = IdResultadoHpv;
				
			item.Nombre = Nombre;
				
	        item.Save(UserName);
	    }
    }
}
