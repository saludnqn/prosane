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
    /// Controller class for BDS_TipoExclusion
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class BdsTipoExclusionController
    {
        // Preload our schema..
        BdsTipoExclusion thisSchemaLoad = new BdsTipoExclusion();
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
        public BdsTipoExclusionCollection FetchAll()
        {
            BdsTipoExclusionCollection coll = new BdsTipoExclusionCollection();
            Query qry = new Query(BdsTipoExclusion.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public BdsTipoExclusionCollection FetchByID(object IdTipoExclusion)
        {
            BdsTipoExclusionCollection coll = new BdsTipoExclusionCollection().Where("idTipoExclusion", IdTipoExclusion).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public BdsTipoExclusionCollection FetchByQuery(Query qry)
        {
            BdsTipoExclusionCollection coll = new BdsTipoExclusionCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object IdTipoExclusion)
        {
            return (BdsTipoExclusion.Delete(IdTipoExclusion) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object IdTipoExclusion)
        {
            return (BdsTipoExclusion.Destroy(IdTipoExclusion) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string Nombre)
	    {
		    BdsTipoExclusion item = new BdsTipoExclusion();
		    
            item.Nombre = Nombre;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int IdTipoExclusion,string Nombre)
	    {
		    BdsTipoExclusion item = new BdsTipoExclusion();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.IdTipoExclusion = IdTipoExclusion;
				
			item.Nombre = Nombre;
				
	        item.Save(UserName);
	    }
    }
}
