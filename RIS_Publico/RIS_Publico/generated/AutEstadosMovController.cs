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
    /// Controller class for AUT_EstadosMov
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class AutEstadosMovController
    {
        // Preload our schema..
        AutEstadosMov thisSchemaLoad = new AutEstadosMov();
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
        public AutEstadosMovCollection FetchAll()
        {
            AutEstadosMovCollection coll = new AutEstadosMovCollection();
            Query qry = new Query(AutEstadosMov.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public AutEstadosMovCollection FetchByID(object IdEstadosMov)
        {
            AutEstadosMovCollection coll = new AutEstadosMovCollection().Where("idEstadosMov", IdEstadosMov).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public AutEstadosMovCollection FetchByQuery(Query qry)
        {
            AutEstadosMovCollection coll = new AutEstadosMovCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object IdEstadosMov)
        {
            return (AutEstadosMov.Delete(IdEstadosMov) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object IdEstadosMov)
        {
            return (AutEstadosMov.Destroy(IdEstadosMov) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(decimal IdEstadosMov,decimal? IdVehiculo,string Estado,DateTime? FechaIngreso,DateTime? FechaEgreso,string Observaciones)
	    {
		    AutEstadosMov item = new AutEstadosMov();
		    
            item.IdEstadosMov = IdEstadosMov;
            
            item.IdVehiculo = IdVehiculo;
            
            item.Estado = Estado;
            
            item.FechaIngreso = FechaIngreso;
            
            item.FechaEgreso = FechaEgreso;
            
            item.Observaciones = Observaciones;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(decimal IdEstadosMov,decimal? IdVehiculo,string Estado,DateTime? FechaIngreso,DateTime? FechaEgreso,string Observaciones)
	    {
		    AutEstadosMov item = new AutEstadosMov();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.IdEstadosMov = IdEstadosMov;
				
			item.IdVehiculo = IdVehiculo;
				
			item.Estado = Estado;
				
			item.FechaIngreso = FechaIngreso;
				
			item.FechaEgreso = FechaEgreso;
				
			item.Observaciones = Observaciones;
				
	        item.Save(UserName);
	    }
    }
}
