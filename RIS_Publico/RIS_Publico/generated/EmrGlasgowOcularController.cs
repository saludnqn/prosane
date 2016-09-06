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
    /// Controller class for EMR_GlasgowOcular
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class EmrGlasgowOcularController
    {
        // Preload our schema..
        EmrGlasgowOcular thisSchemaLoad = new EmrGlasgowOcular();
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
        public EmrGlasgowOcularCollection FetchAll()
        {
            EmrGlasgowOcularCollection coll = new EmrGlasgowOcularCollection();
            Query qry = new Query(EmrGlasgowOcular.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public EmrGlasgowOcularCollection FetchByID(object IdGlasgowOcular)
        {
            EmrGlasgowOcularCollection coll = new EmrGlasgowOcularCollection().Where("idGlasgowOcular", IdGlasgowOcular).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public EmrGlasgowOcularCollection FetchByQuery(Query qry)
        {
            EmrGlasgowOcularCollection coll = new EmrGlasgowOcularCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object IdGlasgowOcular)
        {
            return (EmrGlasgowOcular.Delete(IdGlasgowOcular) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object IdGlasgowOcular)
        {
            return (EmrGlasgowOcular.Destroy(IdGlasgowOcular) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string Nombre,int Valor)
	    {
		    EmrGlasgowOcular item = new EmrGlasgowOcular();
		    
            item.Nombre = Nombre;
            
            item.Valor = Valor;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int IdGlasgowOcular,string Nombre,int Valor)
	    {
		    EmrGlasgowOcular item = new EmrGlasgowOcular();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.IdGlasgowOcular = IdGlasgowOcular;
				
			item.Nombre = Nombre;
				
			item.Valor = Valor;
				
	        item.Save(UserName);
	    }
    }
}
