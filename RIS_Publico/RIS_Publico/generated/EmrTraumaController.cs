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
    /// Controller class for EMR_Trauma
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class EmrTraumaController
    {
        // Preload our schema..
        EmrTrauma thisSchemaLoad = new EmrTrauma();
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
        public EmrTraumaCollection FetchAll()
        {
            EmrTraumaCollection coll = new EmrTraumaCollection();
            Query qry = new Query(EmrTrauma.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public EmrTraumaCollection FetchByID(object IdTrauma)
        {
            EmrTraumaCollection coll = new EmrTraumaCollection().Where("idTrauma", IdTrauma).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public EmrTraumaCollection FetchByQuery(Query qry)
        {
            EmrTraumaCollection coll = new EmrTraumaCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object IdTrauma)
        {
            return (EmrTrauma.Delete(IdTrauma) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object IdTrauma)
        {
            return (EmrTrauma.Destroy(IdTrauma) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string Nombre,int IdTipoTrauma)
	    {
		    EmrTrauma item = new EmrTrauma();
		    
            item.Nombre = Nombre;
            
            item.IdTipoTrauma = IdTipoTrauma;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int IdTrauma,string Nombre,int IdTipoTrauma)
	    {
		    EmrTrauma item = new EmrTrauma();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.IdTrauma = IdTrauma;
				
			item.Nombre = Nombre;
				
			item.IdTipoTrauma = IdTipoTrauma;
				
	        item.Save(UserName);
	    }
    }
}
