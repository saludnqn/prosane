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
    /// Controller class for INS_TipoProveedor
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class InsTipoProveedorController
    {
        // Preload our schema..
        InsTipoProveedor thisSchemaLoad = new InsTipoProveedor();
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
        public InsTipoProveedorCollection FetchAll()
        {
            InsTipoProveedorCollection coll = new InsTipoProveedorCollection();
            Query qry = new Query(InsTipoProveedor.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public InsTipoProveedorCollection FetchByID(object IdTipoProveedor)
        {
            InsTipoProveedorCollection coll = new InsTipoProveedorCollection().Where("idTipoProveedor", IdTipoProveedor).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public InsTipoProveedorCollection FetchByQuery(Query qry)
        {
            InsTipoProveedorCollection coll = new InsTipoProveedorCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object IdTipoProveedor)
        {
            return (InsTipoProveedor.Delete(IdTipoProveedor) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object IdTipoProveedor)
        {
            return (InsTipoProveedor.Destroy(IdTipoProveedor) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string Nombre,bool Baja)
	    {
		    InsTipoProveedor item = new InsTipoProveedor();
		    
            item.Nombre = Nombre;
            
            item.Baja = Baja;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int IdTipoProveedor,string Nombre,bool Baja)
	    {
		    InsTipoProveedor item = new InsTipoProveedor();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.IdTipoProveedor = IdTipoProveedor;
				
			item.Nombre = Nombre;
				
			item.Baja = Baja;
				
	        item.Save(UserName);
	    }
    }
}
