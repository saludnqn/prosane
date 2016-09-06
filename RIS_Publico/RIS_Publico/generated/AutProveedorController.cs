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
    /// Controller class for AUT_Proveedor
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class AutProveedorController
    {
        // Preload our schema..
        AutProveedor thisSchemaLoad = new AutProveedor();
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
        public AutProveedorCollection FetchAll()
        {
            AutProveedorCollection coll = new AutProveedorCollection();
            Query qry = new Query(AutProveedor.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public AutProveedorCollection FetchByID(object IdProveedor)
        {
            AutProveedorCollection coll = new AutProveedorCollection().Where("idProveedor", IdProveedor).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public AutProveedorCollection FetchByQuery(Query qry)
        {
            AutProveedorCollection coll = new AutProveedorCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object IdProveedor)
        {
            return (AutProveedor.Delete(IdProveedor) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object IdProveedor)
        {
            return (AutProveedor.Destroy(IdProveedor) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string Nombre,string Cuit,string Direccion,string Telefono,decimal? IdTipoProveedor)
	    {
		    AutProveedor item = new AutProveedor();
		    
            item.Nombre = Nombre;
            
            item.Cuit = Cuit;
            
            item.Direccion = Direccion;
            
            item.Telefono = Telefono;
            
            item.IdTipoProveedor = IdTipoProveedor;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int IdProveedor,string Nombre,string Cuit,string Direccion,string Telefono,decimal? IdTipoProveedor)
	    {
		    AutProveedor item = new AutProveedor();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.IdProveedor = IdProveedor;
				
			item.Nombre = Nombre;
				
			item.Cuit = Cuit;
				
			item.Direccion = Direccion;
				
			item.Telefono = Telefono;
				
			item.IdTipoProveedor = IdTipoProveedor;
				
	        item.Save(UserName);
	    }
    }
}
