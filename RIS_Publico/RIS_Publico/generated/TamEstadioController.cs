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
    /// Controller class for TAM_Estadio
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class TamEstadioController
    {
        // Preload our schema..
        TamEstadio thisSchemaLoad = new TamEstadio();
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
        public TamEstadioCollection FetchAll()
        {
            TamEstadioCollection coll = new TamEstadioCollection();
            Query qry = new Query(TamEstadio.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public TamEstadioCollection FetchByID(object IdEstadio)
        {
            TamEstadioCollection coll = new TamEstadioCollection().Where("idEstadio", IdEstadio).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public TamEstadioCollection FetchByQuery(Query qry)
        {
            TamEstadioCollection coll = new TamEstadioCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object IdEstadio)
        {
            return (TamEstadio.Delete(IdEstadio) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object IdEstadio)
        {
            return (TamEstadio.Destroy(IdEstadio) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string Nombre)
	    {
		    TamEstadio item = new TamEstadio();
		    
            item.Nombre = Nombre;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int IdEstadio,string Nombre)
	    {
		    TamEstadio item = new TamEstadio();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.IdEstadio = IdEstadio;
				
			item.Nombre = Nombre;
				
	        item.Save(UserName);
	    }
    }
}
