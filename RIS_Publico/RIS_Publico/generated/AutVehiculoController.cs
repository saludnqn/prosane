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
    /// Controller class for AUT_Vehiculo
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class AutVehiculoController
    {
        // Preload our schema..
        AutVehiculo thisSchemaLoad = new AutVehiculo();
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
        public AutVehiculoCollection FetchAll()
        {
            AutVehiculoCollection coll = new AutVehiculoCollection();
            Query qry = new Query(AutVehiculo.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public AutVehiculoCollection FetchByID(object IdVehiculo)
        {
            AutVehiculoCollection coll = new AutVehiculoCollection().Where("idVehiculo", IdVehiculo).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public AutVehiculoCollection FetchByQuery(Query qry)
        {
            AutVehiculoCollection coll = new AutVehiculoCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object IdVehiculo)
        {
            return (AutVehiculo.Delete(IdVehiculo) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object IdVehiculo)
        {
            return (AutVehiculo.Destroy(IdVehiculo) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string Matricula,string Dominio,int? Anio,int OdometroActual,DateTime FechaLecturaOdometro,string NumeroMotor,string NumeroChasis,string TieneRadio,string TienePermisoRadio,int IdTipoVehiculo,string Traccion,int IdModelo,int IdEntidad,decimal? IdDireccion,string Estado,string Observaciones,string Condicion)
	    {
		    AutVehiculo item = new AutVehiculo();
		    
            item.Matricula = Matricula;
            
            item.Dominio = Dominio;
            
            item.Anio = Anio;
            
            item.OdometroActual = OdometroActual;
            
            item.FechaLecturaOdometro = FechaLecturaOdometro;
            
            item.NumeroMotor = NumeroMotor;
            
            item.NumeroChasis = NumeroChasis;
            
            item.TieneRadio = TieneRadio;
            
            item.TienePermisoRadio = TienePermisoRadio;
            
            item.IdTipoVehiculo = IdTipoVehiculo;
            
            item.Traccion = Traccion;
            
            item.IdModelo = IdModelo;
            
            item.IdEntidad = IdEntidad;
            
            item.IdDireccion = IdDireccion;
            
            item.Estado = Estado;
            
            item.Observaciones = Observaciones;
            
            item.Condicion = Condicion;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int IdVehiculo,string Matricula,string Dominio,int? Anio,int OdometroActual,DateTime FechaLecturaOdometro,string NumeroMotor,string NumeroChasis,string TieneRadio,string TienePermisoRadio,int IdTipoVehiculo,string Traccion,int IdModelo,int IdEntidad,decimal? IdDireccion,string Estado,string Observaciones,string Condicion)
	    {
		    AutVehiculo item = new AutVehiculo();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.IdVehiculo = IdVehiculo;
				
			item.Matricula = Matricula;
				
			item.Dominio = Dominio;
				
			item.Anio = Anio;
				
			item.OdometroActual = OdometroActual;
				
			item.FechaLecturaOdometro = FechaLecturaOdometro;
				
			item.NumeroMotor = NumeroMotor;
				
			item.NumeroChasis = NumeroChasis;
				
			item.TieneRadio = TieneRadio;
				
			item.TienePermisoRadio = TienePermisoRadio;
				
			item.IdTipoVehiculo = IdTipoVehiculo;
				
			item.Traccion = Traccion;
				
			item.IdModelo = IdModelo;
				
			item.IdEntidad = IdEntidad;
				
			item.IdDireccion = IdDireccion;
				
			item.Estado = Estado;
				
			item.Observaciones = Observaciones;
				
			item.Condicion = Condicion;
				
	        item.Save(UserName);
	    }
    }
}
