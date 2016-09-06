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
    /// Controller class for TAM_CalidadMuestra
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class TamCalidadMuestraController
    {
        // Preload our schema..
        TamCalidadMuestra thisSchemaLoad = new TamCalidadMuestra();
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
        public TamCalidadMuestraCollection FetchAll()
        {
            TamCalidadMuestraCollection coll = new TamCalidadMuestraCollection();
            Query qry = new Query(TamCalidadMuestra.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public TamCalidadMuestraCollection FetchByID(object IdCalidadMuestra)
        {
            TamCalidadMuestraCollection coll = new TamCalidadMuestraCollection().Where("idCalidadMuestra", IdCalidadMuestra).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public TamCalidadMuestraCollection FetchByQuery(Query qry)
        {
            TamCalidadMuestraCollection coll = new TamCalidadMuestraCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object IdCalidadMuestra)
        {
            return (TamCalidadMuestra.Delete(IdCalidadMuestra) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object IdCalidadMuestra)
        {
            return (TamCalidadMuestra.Destroy(IdCalidadMuestra) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string Nombre,string Variable)
	    {
		    TamCalidadMuestra item = new TamCalidadMuestra();
		    
            item.Nombre = Nombre;
            
            item.Variable = Variable;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int IdCalidadMuestra,string Nombre,string Variable)
	    {
		    TamCalidadMuestra item = new TamCalidadMuestra();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.IdCalidadMuestra = IdCalidadMuestra;
				
			item.Nombre = Nombre;
				
			item.Variable = Variable;
				
	        item.Save(UserName);
	    }
    }
}
