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
    /// Controller class for AUT_Movimiento
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class AutMovimientoController
    {
        // Preload our schema..
        AutMovimiento thisSchemaLoad = new AutMovimiento();
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
        public AutMovimientoCollection FetchAll()
        {
            AutMovimientoCollection coll = new AutMovimientoCollection();
            Query qry = new Query(AutMovimiento.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public AutMovimientoCollection FetchByID(object IdMovimiento)
        {
            AutMovimientoCollection coll = new AutMovimientoCollection().Where("idMovimiento", IdMovimiento).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public AutMovimientoCollection FetchByQuery(Query qry)
        {
            AutMovimientoCollection coll = new AutMovimientoCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object IdMovimiento)
        {
            return (AutMovimiento.Delete(IdMovimiento) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object IdMovimiento)
        {
            return (AutMovimiento.Destroy(IdMovimiento) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(DateTime FechaHoraAltaRegistro,DateTime FechaHoraRealizacion,decimal Importe,int IdVehiculo,int IdTipoMovimiento,int IdProveedor,int IdUsuarioRegistro,DateTime FechaRegistro,string Descripcion)
	    {
		    AutMovimiento item = new AutMovimiento();
		    
            item.FechaHoraAltaRegistro = FechaHoraAltaRegistro;
            
            item.FechaHoraRealizacion = FechaHoraRealizacion;
            
            item.Importe = Importe;
            
            item.IdVehiculo = IdVehiculo;
            
            item.IdTipoMovimiento = IdTipoMovimiento;
            
            item.IdProveedor = IdProveedor;
            
            item.IdUsuarioRegistro = IdUsuarioRegistro;
            
            item.FechaRegistro = FechaRegistro;
            
            item.Descripcion = Descripcion;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int IdMovimiento,DateTime FechaHoraAltaRegistro,DateTime FechaHoraRealizacion,decimal Importe,int IdVehiculo,int IdTipoMovimiento,int IdProveedor,int IdUsuarioRegistro,DateTime FechaRegistro,string Descripcion)
	    {
		    AutMovimiento item = new AutMovimiento();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.IdMovimiento = IdMovimiento;
				
			item.FechaHoraAltaRegistro = FechaHoraAltaRegistro;
				
			item.FechaHoraRealizacion = FechaHoraRealizacion;
				
			item.Importe = Importe;
				
			item.IdVehiculo = IdVehiculo;
				
			item.IdTipoMovimiento = IdTipoMovimiento;
				
			item.IdProveedor = IdProveedor;
				
			item.IdUsuarioRegistro = IdUsuarioRegistro;
				
			item.FechaRegistro = FechaRegistro;
				
			item.Descripcion = Descripcion;
				
	        item.Save(UserName);
	    }
    }
}
