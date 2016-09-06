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
    /// Controller class for TAM_ObservacionPap
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class TamObservacionPapController
    {
        // Preload our schema..
        TamObservacionPap thisSchemaLoad = new TamObservacionPap();
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
        public TamObservacionPapCollection FetchAll()
        {
            TamObservacionPapCollection coll = new TamObservacionPapCollection();
            Query qry = new Query(TamObservacionPap.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public TamObservacionPapCollection FetchByID(object IdObservacionPap)
        {
            TamObservacionPapCollection coll = new TamObservacionPapCollection().Where("idObservacionPap", IdObservacionPap).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public TamObservacionPapCollection FetchByQuery(Query qry)
        {
            TamObservacionPapCollection coll = new TamObservacionPapCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object IdObservacionPap)
        {
            return (TamObservacionPap.Delete(IdObservacionPap) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object IdObservacionPap)
        {
            return (TamObservacionPap.Destroy(IdObservacionPap) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string Nombre)
	    {
		    TamObservacionPap item = new TamObservacionPap();
		    
            item.Nombre = Nombre;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int IdObservacionPap,string Nombre)
	    {
		    TamObservacionPap item = new TamObservacionPap();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.IdObservacionPap = IdObservacionPap;
				
			item.Nombre = Nombre;
				
	        item.Save(UserName);
	    }
    }
}
