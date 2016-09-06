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
    /// Controller class for Aut_OrdenReparacion
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class AutOrdenReparacionController
    {
        // Preload our schema..
        AutOrdenReparacion thisSchemaLoad = new AutOrdenReparacion();
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
        public AutOrdenReparacionCollection FetchAll()
        {
            AutOrdenReparacionCollection coll = new AutOrdenReparacionCollection();
            Query qry = new Query(AutOrdenReparacion.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public AutOrdenReparacionCollection FetchByID(object IdOrdenReparacion)
        {
            AutOrdenReparacionCollection coll = new AutOrdenReparacionCollection().Where("idOrdenReparacion", IdOrdenReparacion).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public AutOrdenReparacionCollection FetchByQuery(Query qry)
        {
            AutOrdenReparacionCollection coll = new AutOrdenReparacionCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object IdOrdenReparacion)
        {
            return (AutOrdenReparacion.Delete(IdOrdenReparacion) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object IdOrdenReparacion)
        {
            return (AutOrdenReparacion.Destroy(IdOrdenReparacion) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(DateTime? Fecha,decimal? IdVehiculo,decimal? IdEfector,decimal? IdNotaPedido,decimal? IdProveedor,decimal? IdPresupuesto,DateTime? FechaInicio,DateTime? FechaFin,string Descripcion,string Observacion,string Estado,decimal? Km)
	    {
		    AutOrdenReparacion item = new AutOrdenReparacion();
		    
            item.Fecha = Fecha;
            
            item.IdVehiculo = IdVehiculo;
            
            item.IdEfector = IdEfector;
            
            item.IdNotaPedido = IdNotaPedido;
            
            item.IdProveedor = IdProveedor;
            
            item.IdPresupuesto = IdPresupuesto;
            
            item.FechaInicio = FechaInicio;
            
            item.FechaFin = FechaFin;
            
            item.Descripcion = Descripcion;
            
            item.Observacion = Observacion;
            
            item.Estado = Estado;
            
            item.Km = Km;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(decimal IdOrdenReparacion,DateTime? Fecha,decimal? IdVehiculo,decimal? IdEfector,decimal? IdNotaPedido,decimal? IdProveedor,decimal? IdPresupuesto,DateTime? FechaInicio,DateTime? FechaFin,string Descripcion,string Observacion,string Estado,decimal? Km)
	    {
		    AutOrdenReparacion item = new AutOrdenReparacion();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.IdOrdenReparacion = IdOrdenReparacion;
				
			item.Fecha = Fecha;
				
			item.IdVehiculo = IdVehiculo;
				
			item.IdEfector = IdEfector;
				
			item.IdNotaPedido = IdNotaPedido;
				
			item.IdProveedor = IdProveedor;
				
			item.IdPresupuesto = IdPresupuesto;
				
			item.FechaInicio = FechaInicio;
				
			item.FechaFin = FechaFin;
				
			item.Descripcion = Descripcion;
				
			item.Observacion = Observacion;
				
			item.Estado = Estado;
				
			item.Km = Km;
				
	        item.Save(UserName);
	    }
    }
}
