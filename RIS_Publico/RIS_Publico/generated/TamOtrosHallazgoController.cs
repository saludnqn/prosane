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
    /// Controller class for TAM_OtrosHallazgos
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class TamOtrosHallazgoController
    {
        // Preload our schema..
        TamOtrosHallazgo thisSchemaLoad = new TamOtrosHallazgo();
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
        public TamOtrosHallazgoCollection FetchAll()
        {
            TamOtrosHallazgoCollection coll = new TamOtrosHallazgoCollection();
            Query qry = new Query(TamOtrosHallazgo.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public TamOtrosHallazgoCollection FetchByID(object IdOtrosHallazgos)
        {
            TamOtrosHallazgoCollection coll = new TamOtrosHallazgoCollection().Where("idOtrosHallazgos", IdOtrosHallazgos).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public TamOtrosHallazgoCollection FetchByQuery(Query qry)
        {
            TamOtrosHallazgoCollection coll = new TamOtrosHallazgoCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object IdOtrosHallazgos)
        {
            return (TamOtrosHallazgo.Delete(IdOtrosHallazgos) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object IdOtrosHallazgos)
        {
            return (TamOtrosHallazgo.Destroy(IdOtrosHallazgos) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string Nombre)
	    {
		    TamOtrosHallazgo item = new TamOtrosHallazgo();
		    
            item.Nombre = Nombre;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int IdOtrosHallazgos,string Nombre)
	    {
		    TamOtrosHallazgo item = new TamOtrosHallazgo();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.IdOtrosHallazgos = IdOtrosHallazgos;
				
			item.Nombre = Nombre;
				
	        item.Save(UserName);
	    }
    }
}
