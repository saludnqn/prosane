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
    /// Controller class for EMR_TipoTrauma
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class EmrTipoTraumaController
    {
        // Preload our schema..
        EmrTipoTrauma thisSchemaLoad = new EmrTipoTrauma();
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
        public EmrTipoTraumaCollection FetchAll()
        {
            EmrTipoTraumaCollection coll = new EmrTipoTraumaCollection();
            Query qry = new Query(EmrTipoTrauma.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public EmrTipoTraumaCollection FetchByID(object IdTipoTrauma)
        {
            EmrTipoTraumaCollection coll = new EmrTipoTraumaCollection().Where("idTipoTrauma", IdTipoTrauma).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public EmrTipoTraumaCollection FetchByQuery(Query qry)
        {
            EmrTipoTraumaCollection coll = new EmrTipoTraumaCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object IdTipoTrauma)
        {
            return (EmrTipoTrauma.Delete(IdTipoTrauma) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object IdTipoTrauma)
        {
            return (EmrTipoTrauma.Destroy(IdTipoTrauma) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string Nombre)
	    {
		    EmrTipoTrauma item = new EmrTipoTrauma();
		    
            item.Nombre = Nombre;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int IdTipoTrauma,string Nombre)
	    {
		    EmrTipoTrauma item = new EmrTipoTrauma();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.IdTipoTrauma = IdTipoTrauma;
				
			item.Nombre = Nombre;
				
	        item.Save(UserName);
	    }
    }
}
