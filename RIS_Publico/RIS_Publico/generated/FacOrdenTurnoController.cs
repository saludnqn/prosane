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
    /// Controller class for FAC_OrdenTurno
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class FacOrdenTurnoController
    {
        // Preload our schema..
        FacOrdenTurno thisSchemaLoad = new FacOrdenTurno();
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
        public FacOrdenTurnoCollection FetchAll()
        {
            FacOrdenTurnoCollection coll = new FacOrdenTurnoCollection();
            Query qry = new Query(FacOrdenTurno.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public FacOrdenTurnoCollection FetchByID(object IdOrdenTurno)
        {
            FacOrdenTurnoCollection coll = new FacOrdenTurnoCollection().Where("idOrdenTurno", IdOrdenTurno).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public FacOrdenTurnoCollection FetchByQuery(Query qry)
        {
            FacOrdenTurnoCollection coll = new FacOrdenTurnoCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object IdOrdenTurno)
        {
            return (FacOrdenTurno.Delete(IdOrdenTurno) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object IdOrdenTurno)
        {
            return (FacOrdenTurno.Destroy(IdOrdenTurno) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(int IdOrden,int IdTurno)
	    {
		    FacOrdenTurno item = new FacOrdenTurno();
		    
            item.IdOrden = IdOrden;
            
            item.IdTurno = IdTurno;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int IdOrdenTurno,int IdOrden,int IdTurno)
	    {
		    FacOrdenTurno item = new FacOrdenTurno();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.IdOrdenTurno = IdOrdenTurno;
				
			item.IdOrden = IdOrden;
				
			item.IdTurno = IdTurno;
				
	        item.Save(UserName);
	    }
    }
}
