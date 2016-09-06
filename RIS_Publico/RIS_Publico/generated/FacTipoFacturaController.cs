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
    /// Controller class for FAC_TipoFactura
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class FacTipoFacturaController
    {
        // Preload our schema..
        FacTipoFactura thisSchemaLoad = new FacTipoFactura();
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
        public FacTipoFacturaCollection FetchAll()
        {
            FacTipoFacturaCollection coll = new FacTipoFacturaCollection();
            Query qry = new Query(FacTipoFactura.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public FacTipoFacturaCollection FetchByID(object IdTipoFactura)
        {
            FacTipoFacturaCollection coll = new FacTipoFacturaCollection().Where("idTipoFactura", IdTipoFactura).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public FacTipoFacturaCollection FetchByQuery(Query qry)
        {
            FacTipoFacturaCollection coll = new FacTipoFacturaCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object IdTipoFactura)
        {
            return (FacTipoFactura.Delete(IdTipoFactura) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object IdTipoFactura)
        {
            return (FacTipoFactura.Destroy(IdTipoFactura) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string Nombre,bool Baja)
	    {
		    FacTipoFactura item = new FacTipoFactura();
		    
            item.Nombre = Nombre;
            
            item.Baja = Baja;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int IdTipoFactura,string Nombre,bool Baja)
	    {
		    FacTipoFactura item = new FacTipoFactura();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.IdTipoFactura = IdTipoFactura;
				
			item.Nombre = Nombre;
				
			item.Baja = Baja;
				
	        item.Save(UserName);
	    }
    }
}
