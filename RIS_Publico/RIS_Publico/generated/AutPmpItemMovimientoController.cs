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
    /// Controller class for AUT_PMP_ItemMovimiento
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class AutPmpItemMovimientoController
    {
        // Preload our schema..
        AutPmpItemMovimiento thisSchemaLoad = new AutPmpItemMovimiento();
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
        public AutPmpItemMovimientoCollection FetchAll()
        {
            AutPmpItemMovimientoCollection coll = new AutPmpItemMovimientoCollection();
            Query qry = new Query(AutPmpItemMovimiento.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public AutPmpItemMovimientoCollection FetchByID(object IdPMPItemMovimiento)
        {
            AutPmpItemMovimientoCollection coll = new AutPmpItemMovimientoCollection().Where("idPMPItemMovimiento", IdPMPItemMovimiento).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public AutPmpItemMovimientoCollection FetchByQuery(Query qry)
        {
            AutPmpItemMovimientoCollection coll = new AutPmpItemMovimientoCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object IdPMPItemMovimiento)
        {
            return (AutPmpItemMovimiento.Delete(IdPMPItemMovimiento) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object IdPMPItemMovimiento)
        {
            return (AutPmpItemMovimiento.Destroy(IdPMPItemMovimiento) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(int IdPMP,int IdItemMovimiento)
	    {
		    AutPmpItemMovimiento item = new AutPmpItemMovimiento();
		    
            item.IdPMP = IdPMP;
            
            item.IdItemMovimiento = IdItemMovimiento;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int IdPMPItemMovimiento,int IdPMP,int IdItemMovimiento)
	    {
		    AutPmpItemMovimiento item = new AutPmpItemMovimiento();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.IdPMPItemMovimiento = IdPMPItemMovimiento;
				
			item.IdPMP = IdPMP;
				
			item.IdItemMovimiento = IdItemMovimiento;
				
	        item.Save(UserName);
	    }
    }
}
