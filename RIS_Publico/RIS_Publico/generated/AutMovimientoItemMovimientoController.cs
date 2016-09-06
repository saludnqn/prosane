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
    /// Controller class for AUT_Movimiento_ItemMovimiento
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class AutMovimientoItemMovimientoController
    {
        // Preload our schema..
        AutMovimientoItemMovimiento thisSchemaLoad = new AutMovimientoItemMovimiento();
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
        public AutMovimientoItemMovimientoCollection FetchAll()
        {
            AutMovimientoItemMovimientoCollection coll = new AutMovimientoItemMovimientoCollection();
            Query qry = new Query(AutMovimientoItemMovimiento.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public AutMovimientoItemMovimientoCollection FetchByID(object IdMovimientoItemMovimiento)
        {
            AutMovimientoItemMovimientoCollection coll = new AutMovimientoItemMovimientoCollection().Where("idMovimientoItemMovimiento", IdMovimientoItemMovimiento).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public AutMovimientoItemMovimientoCollection FetchByQuery(Query qry)
        {
            AutMovimientoItemMovimientoCollection coll = new AutMovimientoItemMovimientoCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object IdMovimientoItemMovimiento)
        {
            return (AutMovimientoItemMovimiento.Delete(IdMovimientoItemMovimiento) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object IdMovimientoItemMovimiento)
        {
            return (AutMovimientoItemMovimiento.Destroy(IdMovimientoItemMovimiento) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(int IdMovimiento,int IdItemMovimiento)
	    {
		    AutMovimientoItemMovimiento item = new AutMovimientoItemMovimiento();
		    
            item.IdMovimiento = IdMovimiento;
            
            item.IdItemMovimiento = IdItemMovimiento;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int IdMovimientoItemMovimiento,int IdMovimiento,int IdItemMovimiento)
	    {
		    AutMovimientoItemMovimiento item = new AutMovimientoItemMovimiento();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.IdMovimientoItemMovimiento = IdMovimientoItemMovimiento;
				
			item.IdMovimiento = IdMovimiento;
				
			item.IdItemMovimiento = IdItemMovimiento;
				
	        item.Save(UserName);
	    }
    }
}
