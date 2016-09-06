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
    /// Controller class for AUT_Direcciones
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class AutDireccioneController
    {
        // Preload our schema..
        AutDireccione thisSchemaLoad = new AutDireccione();
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
        public AutDireccioneCollection FetchAll()
        {
            AutDireccioneCollection coll = new AutDireccioneCollection();
            Query qry = new Query(AutDireccione.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public AutDireccioneCollection FetchByID(object IdDireccion)
        {
            AutDireccioneCollection coll = new AutDireccioneCollection().Where("idDireccion", IdDireccion).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public AutDireccioneCollection FetchByQuery(Query qry)
        {
            AutDireccioneCollection coll = new AutDireccioneCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object IdDireccion)
        {
            return (AutDireccione.Delete(IdDireccion) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object IdDireccion)
        {
            return (AutDireccione.Destroy(IdDireccion) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(decimal IdDireccion,string Nombre,string Responsable,string Telefono,string Email)
	    {
		    AutDireccione item = new AutDireccione();
		    
            item.IdDireccion = IdDireccion;
            
            item.Nombre = Nombre;
            
            item.Responsable = Responsable;
            
            item.Telefono = Telefono;
            
            item.Email = Email;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(decimal IdDireccion,string Nombre,string Responsable,string Telefono,string Email)
	    {
		    AutDireccione item = new AutDireccione();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.IdDireccion = IdDireccion;
				
			item.Nombre = Nombre;
				
			item.Responsable = Responsable;
				
			item.Telefono = Telefono;
				
			item.Email = Email;
				
	        item.Save(UserName);
	    }
    }
}
