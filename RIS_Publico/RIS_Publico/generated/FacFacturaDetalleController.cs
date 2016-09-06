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
    /// Controller class for FAC_FacturaDetalle
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class FacFacturaDetalleController
    {
        // Preload our schema..
        FacFacturaDetalle thisSchemaLoad = new FacFacturaDetalle();
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
        public FacFacturaDetalleCollection FetchAll()
        {
            FacFacturaDetalleCollection coll = new FacFacturaDetalleCollection();
            Query qry = new Query(FacFacturaDetalle.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public FacFacturaDetalleCollection FetchByID(object IdFacturaDetalle)
        {
            FacFacturaDetalleCollection coll = new FacFacturaDetalleCollection().Where("idFacturaDetalle", IdFacturaDetalle).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public FacFacturaDetalleCollection FetchByQuery(Query qry)
        {
            FacFacturaDetalleCollection coll = new FacFacturaDetalleCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object IdFacturaDetalle)
        {
            return (FacFacturaDetalle.Delete(IdFacturaDetalle) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object IdFacturaDetalle)
        {
            return (FacFacturaDetalle.Destroy(IdFacturaDetalle) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(int IdFactura,int Cantidad,string Descripcion,decimal ValorUnidad,decimal ValorTotal)
	    {
		    FacFacturaDetalle item = new FacFacturaDetalle();
		    
            item.IdFactura = IdFactura;
            
            item.Cantidad = Cantidad;
            
            item.Descripcion = Descripcion;
            
            item.ValorUnidad = ValorUnidad;
            
            item.ValorTotal = ValorTotal;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int IdFacturaDetalle,int IdFactura,int Cantidad,string Descripcion,decimal ValorUnidad,decimal ValorTotal)
	    {
		    FacFacturaDetalle item = new FacFacturaDetalle();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.IdFacturaDetalle = IdFacturaDetalle;
				
			item.IdFactura = IdFactura;
				
			item.Cantidad = Cantidad;
				
			item.Descripcion = Descripcion;
				
			item.ValorUnidad = ValorUnidad;
				
			item.ValorTotal = ValorTotal;
				
	        item.Save(UserName);
	    }
    }
}
