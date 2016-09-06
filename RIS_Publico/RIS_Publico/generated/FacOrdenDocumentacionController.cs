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
    /// Controller class for FAC_OrdenDocumentacion
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class FacOrdenDocumentacionController
    {
        // Preload our schema..
        FacOrdenDocumentacion thisSchemaLoad = new FacOrdenDocumentacion();
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
        public FacOrdenDocumentacionCollection FetchAll()
        {
            FacOrdenDocumentacionCollection coll = new FacOrdenDocumentacionCollection();
            Query qry = new Query(FacOrdenDocumentacion.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public FacOrdenDocumentacionCollection FetchByID(object IdOrdenDocumentacion)
        {
            FacOrdenDocumentacionCollection coll = new FacOrdenDocumentacionCollection().Where("idOrdenDocumentacion", IdOrdenDocumentacion).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public FacOrdenDocumentacionCollection FetchByQuery(Query qry)
        {
            FacOrdenDocumentacionCollection coll = new FacOrdenDocumentacionCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object IdOrdenDocumentacion)
        {
            return (FacOrdenDocumentacion.Delete(IdOrdenDocumentacion) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object IdOrdenDocumentacion)
        {
            return (FacOrdenDocumentacion.Destroy(IdOrdenDocumentacion) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(int IdOrden,string Nombre,string Ubicacion,string Detalle,int IdUsuarioRegistro,DateTime FechaRegistro)
	    {
		    FacOrdenDocumentacion item = new FacOrdenDocumentacion();
		    
            item.IdOrden = IdOrden;
            
            item.Nombre = Nombre;
            
            item.Ubicacion = Ubicacion;
            
            item.Detalle = Detalle;
            
            item.IdUsuarioRegistro = IdUsuarioRegistro;
            
            item.FechaRegistro = FechaRegistro;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int IdOrdenDocumentacion,int IdOrden,string Nombre,string Ubicacion,string Detalle,int IdUsuarioRegistro,DateTime FechaRegistro)
	    {
		    FacOrdenDocumentacion item = new FacOrdenDocumentacion();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.IdOrdenDocumentacion = IdOrdenDocumentacion;
				
			item.IdOrden = IdOrden;
				
			item.Nombre = Nombre;
				
			item.Ubicacion = Ubicacion;
				
			item.Detalle = Detalle;
				
			item.IdUsuarioRegistro = IdUsuarioRegistro;
				
			item.FechaRegistro = FechaRegistro;
				
	        item.Save(UserName);
	    }
    }
}
