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
    /// Controller class for Aut_Presupuesto
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class AutPresupuestoController
    {
        // Preload our schema..
        AutPresupuesto thisSchemaLoad = new AutPresupuesto();
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
        public AutPresupuestoCollection FetchAll()
        {
            AutPresupuestoCollection coll = new AutPresupuestoCollection();
            Query qry = new Query(AutPresupuesto.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public AutPresupuestoCollection FetchByID(object IdPresupuesto)
        {
            AutPresupuestoCollection coll = new AutPresupuestoCollection().Where("idPresupuesto", IdPresupuesto).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public AutPresupuestoCollection FetchByQuery(Query qry)
        {
            AutPresupuestoCollection coll = new AutPresupuestoCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object IdPresupuesto)
        {
            return (AutPresupuesto.Delete(IdPresupuesto) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object IdPresupuesto)
        {
            return (AutPresupuesto.Destroy(IdPresupuesto) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(decimal IdPresupuesto,decimal? IdProveedor,DateTime? Fecha,decimal? IdVehiculo,decimal? IdNotaPedido,decimal? Total,string Observaciones,string TiempoEntrega)
	    {
		    AutPresupuesto item = new AutPresupuesto();
		    
            item.IdPresupuesto = IdPresupuesto;
            
            item.IdProveedor = IdProveedor;
            
            item.Fecha = Fecha;
            
            item.IdVehiculo = IdVehiculo;
            
            item.IdNotaPedido = IdNotaPedido;
            
            item.Total = Total;
            
            item.Observaciones = Observaciones;
            
            item.TiempoEntrega = TiempoEntrega;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(decimal IdPresupuesto,decimal? IdProveedor,DateTime? Fecha,decimal? IdVehiculo,decimal? IdNotaPedido,decimal? Total,string Observaciones,string TiempoEntrega)
	    {
		    AutPresupuesto item = new AutPresupuesto();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.IdPresupuesto = IdPresupuesto;
				
			item.IdProveedor = IdProveedor;
				
			item.Fecha = Fecha;
				
			item.IdVehiculo = IdVehiculo;
				
			item.IdNotaPedido = IdNotaPedido;
				
			item.Total = Total;
				
			item.Observaciones = Observaciones;
				
			item.TiempoEntrega = TiempoEntrega;
				
	        item.Save(UserName);
	    }
    }
}
