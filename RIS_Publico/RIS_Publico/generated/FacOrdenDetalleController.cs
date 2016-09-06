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
    /// Controller class for FAC_OrdenDetalle
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class FacOrdenDetalleController
    {
        // Preload our schema..
        FacOrdenDetalle thisSchemaLoad = new FacOrdenDetalle();
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
        public FacOrdenDetalleCollection FetchAll()
        {
            FacOrdenDetalleCollection coll = new FacOrdenDetalleCollection();
            Query qry = new Query(FacOrdenDetalle.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public FacOrdenDetalleCollection FetchByID(object IdOrdenDetalle)
        {
            FacOrdenDetalleCollection coll = new FacOrdenDetalleCollection().Where("idOrdenDetalle", IdOrdenDetalle).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public FacOrdenDetalleCollection FetchByQuery(Query qry)
        {
            FacOrdenDetalleCollection coll = new FacOrdenDetalleCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object IdOrdenDetalle)
        {
            return (FacOrdenDetalle.Delete(IdOrdenDetalle) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object IdOrdenDetalle)
        {
            return (FacOrdenDetalle.Destroy(IdOrdenDetalle) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(int IdOrden,int IdEfector,int IdNomenclador,string Descripcion,int Cantidad,decimal ValorUnidad,decimal Ajuste,decimal? Total)
	    {
		    FacOrdenDetalle item = new FacOrdenDetalle();
		    
            item.IdOrden = IdOrden;
            
            item.IdEfector = IdEfector;
            
            item.IdNomenclador = IdNomenclador;
            
            item.Descripcion = Descripcion;
            
            item.Cantidad = Cantidad;
            
            item.ValorUnidad = ValorUnidad;
            
            item.Ajuste = Ajuste;
            
            item.Total = Total;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int IdOrdenDetalle,int IdOrden,int IdEfector,int IdNomenclador,string Descripcion,int Cantidad,decimal ValorUnidad,decimal Ajuste,decimal? Total)
	    {
		    FacOrdenDetalle item = new FacOrdenDetalle();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.IdOrdenDetalle = IdOrdenDetalle;
				
			item.IdOrden = IdOrden;
				
			item.IdEfector = IdEfector;
				
			item.IdNomenclador = IdNomenclador;
				
			item.Descripcion = Descripcion;
				
			item.Cantidad = Cantidad;
				
			item.ValorUnidad = ValorUnidad;
				
			item.Ajuste = Ajuste;
				
			item.Total = Total;
				
	        item.Save(UserName);
	    }
    }
}
