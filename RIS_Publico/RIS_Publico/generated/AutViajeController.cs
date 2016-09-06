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
    /// Controller class for AUT_Viaje
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class AutViajeController
    {
        // Preload our schema..
        AutViaje thisSchemaLoad = new AutViaje();
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
        public AutViajeCollection FetchAll()
        {
            AutViajeCollection coll = new AutViajeCollection();
            Query qry = new Query(AutViaje.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public AutViajeCollection FetchByID(object IdViaje)
        {
            AutViajeCollection coll = new AutViajeCollection().Where("idViaje", IdViaje).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public AutViajeCollection FetchByQuery(Query qry)
        {
            AutViajeCollection coll = new AutViajeCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object IdViaje)
        {
            return (AutViaje.Delete(IdViaje) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object IdViaje)
        {
            return (AutViaje.Destroy(IdViaje) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(DateTime FechaInicio,string HoraInicio,DateTime FechaFin,string HoraFin,int OdometroInicio,int OdometroFin,int Origen,int Destino,int IdChofer,int IdVehiculo,int IdUsuarioRegistro,DateTime FechaRegistro,string Observaciones,int? IdTipoViaje)
	    {
		    AutViaje item = new AutViaje();
		    
            item.FechaInicio = FechaInicio;
            
            item.HoraInicio = HoraInicio;
            
            item.FechaFin = FechaFin;
            
            item.HoraFin = HoraFin;
            
            item.OdometroInicio = OdometroInicio;
            
            item.OdometroFin = OdometroFin;
            
            item.Origen = Origen;
            
            item.Destino = Destino;
            
            item.IdChofer = IdChofer;
            
            item.IdVehiculo = IdVehiculo;
            
            item.IdUsuarioRegistro = IdUsuarioRegistro;
            
            item.FechaRegistro = FechaRegistro;
            
            item.Observaciones = Observaciones;
            
            item.IdTipoViaje = IdTipoViaje;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int IdViaje,DateTime FechaInicio,string HoraInicio,DateTime FechaFin,string HoraFin,int OdometroInicio,int OdometroFin,int Origen,int Destino,int IdChofer,int IdVehiculo,int IdUsuarioRegistro,DateTime FechaRegistro,string Observaciones,int? IdTipoViaje)
	    {
		    AutViaje item = new AutViaje();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.IdViaje = IdViaje;
				
			item.FechaInicio = FechaInicio;
				
			item.HoraInicio = HoraInicio;
				
			item.FechaFin = FechaFin;
				
			item.HoraFin = HoraFin;
				
			item.OdometroInicio = OdometroInicio;
				
			item.OdometroFin = OdometroFin;
				
			item.Origen = Origen;
				
			item.Destino = Destino;
				
			item.IdChofer = IdChofer;
				
			item.IdVehiculo = IdVehiculo;
				
			item.IdUsuarioRegistro = IdUsuarioRegistro;
				
			item.FechaRegistro = FechaRegistro;
				
			item.Observaciones = Observaciones;
				
			item.IdTipoViaje = IdTipoViaje;
				
	        item.Save(UserName);
	    }
    }
}
