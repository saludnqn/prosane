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
    /// Controller class for BDS_UsoHemocomponente
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class BdsUsoHemocomponenteController
    {
        // Preload our schema..
        BdsUsoHemocomponente thisSchemaLoad = new BdsUsoHemocomponente();
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
        public BdsUsoHemocomponenteCollection FetchAll()
        {
            BdsUsoHemocomponenteCollection coll = new BdsUsoHemocomponenteCollection();
            Query qry = new Query(BdsUsoHemocomponente.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public BdsUsoHemocomponenteCollection FetchByID(object IdUsoHemocomponente)
        {
            BdsUsoHemocomponenteCollection coll = new BdsUsoHemocomponenteCollection().Where("idUsoHemocomponente", IdUsoHemocomponente).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public BdsUsoHemocomponenteCollection FetchByQuery(Query qry)
        {
            BdsUsoHemocomponenteCollection coll = new BdsUsoHemocomponenteCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object IdUsoHemocomponente)
        {
            return (BdsUsoHemocomponente.Delete(IdUsoHemocomponente) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object IdUsoHemocomponente)
        {
            return (BdsUsoHemocomponente.Destroy(IdUsoHemocomponente) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string Nombre)
	    {
		    BdsUsoHemocomponente item = new BdsUsoHemocomponente();
		    
            item.Nombre = Nombre;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int IdUsoHemocomponente,string Nombre)
	    {
		    BdsUsoHemocomponente item = new BdsUsoHemocomponente();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.IdUsoHemocomponente = IdUsoHemocomponente;
				
			item.Nombre = Nombre;
				
	        item.Save(UserName);
	    }
    }
}
