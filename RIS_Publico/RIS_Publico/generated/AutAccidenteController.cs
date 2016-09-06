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
    /// Controller class for AUT_Accidente
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class AutAccidenteController
    {
        // Preload our schema..
        AutAccidente thisSchemaLoad = new AutAccidente();
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
        public AutAccidenteCollection FetchAll()
        {
            AutAccidenteCollection coll = new AutAccidenteCollection();
            Query qry = new Query(AutAccidente.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public AutAccidenteCollection FetchByID(object IdAccidente)
        {
            AutAccidenteCollection coll = new AutAccidenteCollection().Where("idAccidente", IdAccidente).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public AutAccidenteCollection FetchByQuery(Query qry)
        {
            AutAccidenteCollection coll = new AutAccidenteCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object IdAccidente)
        {
            return (AutAccidente.Delete(IdAccidente) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object IdAccidente)
        {
            return (AutAccidente.Destroy(IdAccidente) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(DateTime Fecha,string Descripcion,int IdVehiculo)
	    {
		    AutAccidente item = new AutAccidente();
		    
            item.Fecha = Fecha;
            
            item.Descripcion = Descripcion;
            
            item.IdVehiculo = IdVehiculo;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int IdAccidente,DateTime Fecha,string Descripcion,int IdVehiculo)
	    {
		    AutAccidente item = new AutAccidente();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.IdAccidente = IdAccidente;
				
			item.Fecha = Fecha;
				
			item.Descripcion = Descripcion;
				
			item.IdVehiculo = IdVehiculo;
				
	        item.Save(UserName);
	    }
    }
}
