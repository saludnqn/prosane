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
    /// Controller class for TAM_Microrganismo
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class TamMicrorganismoController
    {
        // Preload our schema..
        TamMicrorganismo thisSchemaLoad = new TamMicrorganismo();
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
        public TamMicrorganismoCollection FetchAll()
        {
            TamMicrorganismoCollection coll = new TamMicrorganismoCollection();
            Query qry = new Query(TamMicrorganismo.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public TamMicrorganismoCollection FetchByID(object IdMicrorganismo)
        {
            TamMicrorganismoCollection coll = new TamMicrorganismoCollection().Where("idMicrorganismo", IdMicrorganismo).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public TamMicrorganismoCollection FetchByQuery(Query qry)
        {
            TamMicrorganismoCollection coll = new TamMicrorganismoCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object IdMicrorganismo)
        {
            return (TamMicrorganismo.Delete(IdMicrorganismo) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object IdMicrorganismo)
        {
            return (TamMicrorganismo.Destroy(IdMicrorganismo) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string Nombre)
	    {
		    TamMicrorganismo item = new TamMicrorganismo();
		    
            item.Nombre = Nombre;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int IdMicrorganismo,string Nombre)
	    {
		    TamMicrorganismo item = new TamMicrorganismo();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.IdMicrorganismo = IdMicrorganismo;
				
			item.Nombre = Nombre;
				
	        item.Save(UserName);
	    }
    }
}
