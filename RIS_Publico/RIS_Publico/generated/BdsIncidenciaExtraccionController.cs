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
    /// Controller class for BDS_IncidenciaExtraccion
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class BdsIncidenciaExtraccionController
    {
        // Preload our schema..
        BdsIncidenciaExtraccion thisSchemaLoad = new BdsIncidenciaExtraccion();
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
        public BdsIncidenciaExtraccionCollection FetchAll()
        {
            BdsIncidenciaExtraccionCollection coll = new BdsIncidenciaExtraccionCollection();
            Query qry = new Query(BdsIncidenciaExtraccion.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public BdsIncidenciaExtraccionCollection FetchByID(object IdIncidenciaExtraccion)
        {
            BdsIncidenciaExtraccionCollection coll = new BdsIncidenciaExtraccionCollection().Where("idIncidenciaExtraccion", IdIncidenciaExtraccion).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public BdsIncidenciaExtraccionCollection FetchByQuery(Query qry)
        {
            BdsIncidenciaExtraccionCollection coll = new BdsIncidenciaExtraccionCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object IdIncidenciaExtraccion)
        {
            return (BdsIncidenciaExtraccion.Delete(IdIncidenciaExtraccion) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object IdIncidenciaExtraccion)
        {
            return (BdsIncidenciaExtraccion.Destroy(IdIncidenciaExtraccion) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string Nombre)
	    {
		    BdsIncidenciaExtraccion item = new BdsIncidenciaExtraccion();
		    
            item.Nombre = Nombre;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int IdIncidenciaExtraccion,string Nombre)
	    {
		    BdsIncidenciaExtraccion item = new BdsIncidenciaExtraccion();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.IdIncidenciaExtraccion = IdIncidenciaExtraccion;
				
			item.Nombre = Nombre;
				
	        item.Save(UserName);
	    }
    }
}
