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
    /// Controller class for TAM_ResultadoPap
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class TamResultadoPapController
    {
        // Preload our schema..
        TamResultadoPap thisSchemaLoad = new TamResultadoPap();
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
        public TamResultadoPapCollection FetchAll()
        {
            TamResultadoPapCollection coll = new TamResultadoPapCollection();
            Query qry = new Query(TamResultadoPap.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public TamResultadoPapCollection FetchByID(object IdResultadoPap)
        {
            TamResultadoPapCollection coll = new TamResultadoPapCollection().Where("idResultadoPap", IdResultadoPap).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public TamResultadoPapCollection FetchByQuery(Query qry)
        {
            TamResultadoPapCollection coll = new TamResultadoPapCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object IdResultadoPap)
        {
            return (TamResultadoPap.Delete(IdResultadoPap) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object IdResultadoPap)
        {
            return (TamResultadoPap.Destroy(IdResultadoPap) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string Nombre,int Orden)
	    {
		    TamResultadoPap item = new TamResultadoPap();
		    
            item.Nombre = Nombre;
            
            item.Orden = Orden;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int IdResultadoPap,string Nombre,int Orden)
	    {
		    TamResultadoPap item = new TamResultadoPap();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.IdResultadoPap = IdResultadoPap;
				
			item.Nombre = Nombre;
				
			item.Orden = Orden;
				
	        item.Save(UserName);
	    }
    }
}
