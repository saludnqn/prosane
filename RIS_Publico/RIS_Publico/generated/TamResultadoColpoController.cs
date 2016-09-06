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
    /// Controller class for TAM_ResultadoColpos
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class TamResultadoColpoController
    {
        // Preload our schema..
        TamResultadoColpo thisSchemaLoad = new TamResultadoColpo();
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
        public TamResultadoColpoCollection FetchAll()
        {
            TamResultadoColpoCollection coll = new TamResultadoColpoCollection();
            Query qry = new Query(TamResultadoColpo.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public TamResultadoColpoCollection FetchByID(object IdResultadoColpos)
        {
            TamResultadoColpoCollection coll = new TamResultadoColpoCollection().Where("idResultadoColpos", IdResultadoColpos).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public TamResultadoColpoCollection FetchByQuery(Query qry)
        {
            TamResultadoColpoCollection coll = new TamResultadoColpoCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object IdResultadoColpos)
        {
            return (TamResultadoColpo.Delete(IdResultadoColpos) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object IdResultadoColpos)
        {
            return (TamResultadoColpo.Destroy(IdResultadoColpos) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string Nombre)
	    {
		    TamResultadoColpo item = new TamResultadoColpo();
		    
            item.Nombre = Nombre;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int IdResultadoColpos,string Nombre)
	    {
		    TamResultadoColpo item = new TamResultadoColpo();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.IdResultadoColpos = IdResultadoColpos;
				
			item.Nombre = Nombre;
				
	        item.Save(UserName);
	    }
    }
}
