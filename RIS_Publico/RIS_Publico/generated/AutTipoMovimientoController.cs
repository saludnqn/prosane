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
    /// Controller class for AUT_TipoMovimiento
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class AutTipoMovimientoController
    {
        // Preload our schema..
        AutTipoMovimiento thisSchemaLoad = new AutTipoMovimiento();
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
        public AutTipoMovimientoCollection FetchAll()
        {
            AutTipoMovimientoCollection coll = new AutTipoMovimientoCollection();
            Query qry = new Query(AutTipoMovimiento.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public AutTipoMovimientoCollection FetchByID(object IdTipoMovimiento)
        {
            AutTipoMovimientoCollection coll = new AutTipoMovimientoCollection().Where("idTipoMovimiento", IdTipoMovimiento).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public AutTipoMovimientoCollection FetchByQuery(Query qry)
        {
            AutTipoMovimientoCollection coll = new AutTipoMovimientoCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object IdTipoMovimiento)
        {
            return (AutTipoMovimiento.Delete(IdTipoMovimiento) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object IdTipoMovimiento)
        {
            return (AutTipoMovimiento.Destroy(IdTipoMovimiento) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string Nombre)
	    {
		    AutTipoMovimiento item = new AutTipoMovimiento();
		    
            item.Nombre = Nombre;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int IdTipoMovimiento,string Nombre)
	    {
		    AutTipoMovimiento item = new AutTipoMovimiento();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.IdTipoMovimiento = IdTipoMovimiento;
				
			item.Nombre = Nombre;
				
	        item.Save(UserName);
	    }
    }
}
