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
    /// Controller class for AUT_TipoVehiculo
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class AutTipoVehiculoController
    {
        // Preload our schema..
        AutTipoVehiculo thisSchemaLoad = new AutTipoVehiculo();
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
        public AutTipoVehiculoCollection FetchAll()
        {
            AutTipoVehiculoCollection coll = new AutTipoVehiculoCollection();
            Query qry = new Query(AutTipoVehiculo.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public AutTipoVehiculoCollection FetchByID(object IdTipoVehiculo)
        {
            AutTipoVehiculoCollection coll = new AutTipoVehiculoCollection().Where("idTipoVehiculo", IdTipoVehiculo).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public AutTipoVehiculoCollection FetchByQuery(Query qry)
        {
            AutTipoVehiculoCollection coll = new AutTipoVehiculoCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object IdTipoVehiculo)
        {
            return (AutTipoVehiculo.Delete(IdTipoVehiculo) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object IdTipoVehiculo)
        {
            return (AutTipoVehiculo.Destroy(IdTipoVehiculo) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string Nombre)
	    {
		    AutTipoVehiculo item = new AutTipoVehiculo();
		    
            item.Nombre = Nombre;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int IdTipoVehiculo,string Nombre)
	    {
		    AutTipoVehiculo item = new AutTipoVehiculo();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.IdTipoVehiculo = IdTipoVehiculo;
				
			item.Nombre = Nombre;
				
	        item.Save(UserName);
	    }
    }
}
