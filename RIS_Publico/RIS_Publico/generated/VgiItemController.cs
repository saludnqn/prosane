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
    /// Controller class for vgi_Items
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class VgiItemController
    {
        // Preload our schema..
        VgiItem thisSchemaLoad = new VgiItem();
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
        public VgiItemCollection FetchAll()
        {
            VgiItemCollection coll = new VgiItemCollection();
            Query qry = new Query(VgiItem.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public VgiItemCollection FetchByID(object IdItems)
        {
            VgiItemCollection coll = new VgiItemCollection().Where("idItems", IdItems).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public VgiItemCollection FetchByQuery(Query qry)
        {
            VgiItemCollection coll = new VgiItemCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object IdItems)
        {
            return (VgiItem.Delete(IdItems) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object IdItems)
        {
            return (VgiItem.Destroy(IdItems) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(int IdItems,string Nombre)
	    {
		    VgiItem item = new VgiItem();
		    
            item.IdItems = IdItems;
            
            item.Nombre = Nombre;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int IdItems,string Nombre)
	    {
		    VgiItem item = new VgiItem();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.IdItems = IdItems;
				
			item.Nombre = Nombre;
				
	        item.Save(UserName);
	    }
    }
}
