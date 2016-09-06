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
    /// Controller class for BDS_Hemocomponente
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class BdsHemocomponenteController
    {
        // Preload our schema..
        BdsHemocomponente thisSchemaLoad = new BdsHemocomponente();
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
        public BdsHemocomponenteCollection FetchAll()
        {
            BdsHemocomponenteCollection coll = new BdsHemocomponenteCollection();
            Query qry = new Query(BdsHemocomponente.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public BdsHemocomponenteCollection FetchByID(object IdHemocomponente)
        {
            BdsHemocomponenteCollection coll = new BdsHemocomponenteCollection().Where("idHemocomponente", IdHemocomponente).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public BdsHemocomponenteCollection FetchByQuery(Query qry)
        {
            BdsHemocomponenteCollection coll = new BdsHemocomponenteCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object IdHemocomponente)
        {
            return (BdsHemocomponente.Delete(IdHemocomponente) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object IdHemocomponente)
        {
            return (BdsHemocomponente.Destroy(IdHemocomponente) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string Nombre)
	    {
		    BdsHemocomponente item = new BdsHemocomponente();
		    
            item.Nombre = Nombre;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int IdHemocomponente,string Nombre)
	    {
		    BdsHemocomponente item = new BdsHemocomponente();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.IdHemocomponente = IdHemocomponente;
				
			item.Nombre = Nombre;
				
	        item.Save(UserName);
	    }
    }
}
