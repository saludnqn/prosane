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
    /// Controller class for EMR_GlasgowVerbal
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class EmrGlasgowVerbalController
    {
        // Preload our schema..
        EmrGlasgowVerbal thisSchemaLoad = new EmrGlasgowVerbal();
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
        public EmrGlasgowVerbalCollection FetchAll()
        {
            EmrGlasgowVerbalCollection coll = new EmrGlasgowVerbalCollection();
            Query qry = new Query(EmrGlasgowVerbal.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public EmrGlasgowVerbalCollection FetchByID(object IdGlasgowVerbal)
        {
            EmrGlasgowVerbalCollection coll = new EmrGlasgowVerbalCollection().Where("idGlasgowVerbal", IdGlasgowVerbal).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public EmrGlasgowVerbalCollection FetchByQuery(Query qry)
        {
            EmrGlasgowVerbalCollection coll = new EmrGlasgowVerbalCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object IdGlasgowVerbal)
        {
            return (EmrGlasgowVerbal.Delete(IdGlasgowVerbal) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object IdGlasgowVerbal)
        {
            return (EmrGlasgowVerbal.Destroy(IdGlasgowVerbal) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string Nombre,int Valor)
	    {
		    EmrGlasgowVerbal item = new EmrGlasgowVerbal();
		    
            item.Nombre = Nombre;
            
            item.Valor = Valor;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int IdGlasgowVerbal,string Nombre,int Valor)
	    {
		    EmrGlasgowVerbal item = new EmrGlasgowVerbal();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.IdGlasgowVerbal = IdGlasgowVerbal;
				
			item.Nombre = Nombre;
				
			item.Valor = Valor;
				
	        item.Save(UserName);
	    }
    }
}
