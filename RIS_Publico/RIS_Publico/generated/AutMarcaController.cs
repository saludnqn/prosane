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
    /// Controller class for AUT_Marca
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class AutMarcaController
    {
        // Preload our schema..
        AutMarca thisSchemaLoad = new AutMarca();
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
        public AutMarcaCollection FetchAll()
        {
            AutMarcaCollection coll = new AutMarcaCollection();
            Query qry = new Query(AutMarca.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public AutMarcaCollection FetchByID(object IdMarca)
        {
            AutMarcaCollection coll = new AutMarcaCollection().Where("idMarca", IdMarca).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public AutMarcaCollection FetchByQuery(Query qry)
        {
            AutMarcaCollection coll = new AutMarcaCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object IdMarca)
        {
            return (AutMarca.Delete(IdMarca) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object IdMarca)
        {
            return (AutMarca.Destroy(IdMarca) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string Nombre)
	    {
		    AutMarca item = new AutMarca();
		    
            item.Nombre = Nombre;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int IdMarca,string Nombre)
	    {
		    AutMarca item = new AutMarca();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.IdMarca = IdMarca;
				
			item.Nombre = Nombre;
				
	        item.Save(UserName);
	    }
    }
}
