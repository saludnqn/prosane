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
    /// Controller class for Aut_NotaPedido
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class AutNotaPedidoController
    {
        // Preload our schema..
        AutNotaPedido thisSchemaLoad = new AutNotaPedido();
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
        public AutNotaPedidoCollection FetchAll()
        {
            AutNotaPedidoCollection coll = new AutNotaPedidoCollection();
            Query qry = new Query(AutNotaPedido.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public AutNotaPedidoCollection FetchByID(object IdNotaPedido)
        {
            AutNotaPedidoCollection coll = new AutNotaPedidoCollection().Where("idNotaPedido", IdNotaPedido).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public AutNotaPedidoCollection FetchByQuery(Query qry)
        {
            AutNotaPedidoCollection coll = new AutNotaPedidoCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object IdNotaPedido)
        {
            return (AutNotaPedido.Delete(IdNotaPedido) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object IdNotaPedido)
        {
            return (AutNotaPedido.Destroy(IdNotaPedido) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(DateTime? Fecha,decimal? IdEntidad,decimal? IdZona,string Firmante,decimal IdVehiculo,string Dominio,string TipoSolicitud,string Expediente,string Detalle,decimal? IdOrdenReparacion,string Obsevacion)
	    {
		    AutNotaPedido item = new AutNotaPedido();
		    
            item.Fecha = Fecha;
            
            item.IdEntidad = IdEntidad;
            
            item.IdZona = IdZona;
            
            item.Firmante = Firmante;
            
            item.IdVehiculo = IdVehiculo;
            
            item.Dominio = Dominio;
            
            item.TipoSolicitud = TipoSolicitud;
            
            item.Expediente = Expediente;
            
            item.Detalle = Detalle;
            
            item.IdOrdenReparacion = IdOrdenReparacion;
            
            item.Obsevacion = Obsevacion;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(DateTime? Fecha,decimal? IdEntidad,decimal? IdZona,decimal IdNotaPedido,string Firmante,decimal IdVehiculo,string Dominio,string TipoSolicitud,string Expediente,string Detalle,decimal? IdOrdenReparacion,string Obsevacion)
	    {
		    AutNotaPedido item = new AutNotaPedido();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.Fecha = Fecha;
				
			item.IdEntidad = IdEntidad;
				
			item.IdZona = IdZona;
				
			item.IdNotaPedido = IdNotaPedido;
				
			item.Firmante = Firmante;
				
			item.IdVehiculo = IdVehiculo;
				
			item.Dominio = Dominio;
				
			item.TipoSolicitud = TipoSolicitud;
				
			item.Expediente = Expediente;
				
			item.Detalle = Detalle;
				
			item.IdOrdenReparacion = IdOrdenReparacion;
				
			item.Obsevacion = Obsevacion;
				
	        item.Save(UserName);
	    }
    }
}
