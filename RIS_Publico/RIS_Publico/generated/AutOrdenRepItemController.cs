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
    /// Controller class for Aut_OrdenRepItem
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class AutOrdenRepItemController
    {
        // Preload our schema..
        AutOrdenRepItem thisSchemaLoad = new AutOrdenRepItem();
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
        public AutOrdenRepItemCollection FetchAll()
        {
            AutOrdenRepItemCollection coll = new AutOrdenRepItemCollection();
            Query qry = new Query(AutOrdenRepItem.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public AutOrdenRepItemCollection FetchByID(object IdOrdenRepItem)
        {
            AutOrdenRepItemCollection coll = new AutOrdenRepItemCollection().Where("idOrdenRepItem", IdOrdenRepItem).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public AutOrdenRepItemCollection FetchByQuery(Query qry)
        {
            AutOrdenRepItemCollection coll = new AutOrdenRepItemCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object IdOrdenRepItem)
        {
            return (AutOrdenRepItem.Delete(IdOrdenRepItem) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object IdOrdenRepItem)
        {
            return (AutOrdenRepItem.Destroy(IdOrdenRepItem) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(DateTime? Fecha,int IdOrdenReparacion,int IdItemMovimiento,int? IdVehiculo,int? IdProveedor,int? Cantidad,decimal? Valor,decimal? Km,string EstadoReparacion,string Estado,string Observacion)
	    {
		    AutOrdenRepItem item = new AutOrdenRepItem();
		    
            item.Fecha = Fecha;
            
            item.IdOrdenReparacion = IdOrdenReparacion;
            
            item.IdItemMovimiento = IdItemMovimiento;
            
            item.IdVehiculo = IdVehiculo;
            
            item.IdProveedor = IdProveedor;
            
            item.Cantidad = Cantidad;
            
            item.Valor = Valor;
            
            item.Km = Km;
            
            item.EstadoReparacion = EstadoReparacion;
            
            item.Estado = Estado;
            
            item.Observacion = Observacion;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int IdOrdenRepItem,DateTime? Fecha,int IdOrdenReparacion,int IdItemMovimiento,int? IdVehiculo,int? IdProveedor,int? Cantidad,decimal? Valor,decimal? Km,string EstadoReparacion,string Estado,string Observacion)
	    {
		    AutOrdenRepItem item = new AutOrdenRepItem();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.IdOrdenRepItem = IdOrdenRepItem;
				
			item.Fecha = Fecha;
				
			item.IdOrdenReparacion = IdOrdenReparacion;
				
			item.IdItemMovimiento = IdItemMovimiento;
				
			item.IdVehiculo = IdVehiculo;
				
			item.IdProveedor = IdProveedor;
				
			item.Cantidad = Cantidad;
				
			item.Valor = Valor;
				
			item.Km = Km;
				
			item.EstadoReparacion = EstadoReparacion;
				
			item.Estado = Estado;
				
			item.Observacion = Observacion;
				
	        item.Save(UserName);
	    }
    }
}
