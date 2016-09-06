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
    /// Controller class for EMR_Base
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class EmrBaseController
    {
        // Preload our schema..
        EmrBase thisSchemaLoad = new EmrBase();
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
        public EmrBaseCollection FetchAll()
        {
            EmrBaseCollection coll = new EmrBaseCollection();
            Query qry = new Query(EmrBase.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public EmrBaseCollection FetchByID(object IdBase)
        {
            EmrBaseCollection coll = new EmrBaseCollection().Where("idBase", IdBase).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public EmrBaseCollection FetchByQuery(Query qry)
        {
            EmrBaseCollection coll = new EmrBaseCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object IdBase)
        {
            return (EmrBase.Delete(IdBase) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object IdBase)
        {
            return (EmrBase.Destroy(IdBase) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string Nombre,bool Activa)
	    {
		    EmrBase item = new EmrBase();
		    
            item.Nombre = Nombre;
            
            item.Activa = Activa;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int IdBase,string Nombre,bool Activa)
	    {
		    EmrBase item = new EmrBase();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.IdBase = IdBase;
				
			item.Nombre = Nombre;
				
			item.Activa = Activa;
				
	        item.Save(UserName);
	    }
    }
}
