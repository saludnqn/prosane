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
    /// Controller class for AUT_Vehiculo_PMP
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class AutVehiculoPmpController
    {
        // Preload our schema..
        AutVehiculoPmp thisSchemaLoad = new AutVehiculoPmp();
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
        public AutVehiculoPmpCollection FetchAll()
        {
            AutVehiculoPmpCollection coll = new AutVehiculoPmpCollection();
            Query qry = new Query(AutVehiculoPmp.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public AutVehiculoPmpCollection FetchByID(object IdVehiculoPMP)
        {
            AutVehiculoPmpCollection coll = new AutVehiculoPmpCollection().Where("idVehiculoPMP", IdVehiculoPMP).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public AutVehiculoPmpCollection FetchByQuery(Query qry)
        {
            AutVehiculoPmpCollection coll = new AutVehiculoPmpCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object IdVehiculoPMP)
        {
            return (AutVehiculoPmp.Delete(IdVehiculoPMP) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object IdVehiculoPMP)
        {
            return (AutVehiculoPmp.Destroy(IdVehiculoPMP) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(int IdVehiculo,int IdPMP)
	    {
		    AutVehiculoPmp item = new AutVehiculoPmp();
		    
            item.IdVehiculo = IdVehiculo;
            
            item.IdPMP = IdPMP;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int IdVehiculoPMP,int IdVehiculo,int IdPMP)
	    {
		    AutVehiculoPmp item = new AutVehiculoPmp();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.IdVehiculoPMP = IdVehiculoPMP;
				
			item.IdVehiculo = IdVehiculo;
				
			item.IdPMP = IdPMP;
				
	        item.Save(UserName);
	    }
    }
}
