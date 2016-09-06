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
    /// Controller class for FAC_Factura
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class FacFacturaController
    {
        // Preload our schema..
        FacFactura thisSchemaLoad = new FacFactura();
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
        public FacFacturaCollection FetchAll()
        {
            FacFacturaCollection coll = new FacFacturaCollection();
            Query qry = new Query(FacFactura.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public FacFacturaCollection FetchByID(object IdFactura)
        {
            FacFacturaCollection coll = new FacFacturaCollection().Where("idFactura", IdFactura).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public FacFacturaCollection FetchByQuery(Query qry)
        {
            FacFacturaCollection coll = new FacFacturaCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object IdFactura)
        {
            return (FacFactura.Delete(IdFactura) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object IdFactura)
        {
            return (FacFactura.Destroy(IdFactura) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(int IdEfector,int IdObraSocial,string Numero,DateTime Fecha,string Periodo,string Observaciones,decimal SubTotal,decimal Descuento,decimal Total,string Estado,int IdUsuarioRegistro,DateTime FechaRegistro)
	    {
		    FacFactura item = new FacFactura();
		    
            item.IdEfector = IdEfector;
            
            item.IdObraSocial = IdObraSocial;
            
            item.Numero = Numero;
            
            item.Fecha = Fecha;
            
            item.Periodo = Periodo;
            
            item.Observaciones = Observaciones;
            
            item.SubTotal = SubTotal;
            
            item.Descuento = Descuento;
            
            item.Total = Total;
            
            item.Estado = Estado;
            
            item.IdUsuarioRegistro = IdUsuarioRegistro;
            
            item.FechaRegistro = FechaRegistro;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int IdFactura,int IdEfector,int IdObraSocial,string Numero,DateTime Fecha,string Periodo,string Observaciones,decimal SubTotal,decimal Descuento,decimal Total,string Estado,int IdUsuarioRegistro,DateTime FechaRegistro)
	    {
		    FacFactura item = new FacFactura();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.IdFactura = IdFactura;
				
			item.IdEfector = IdEfector;
				
			item.IdObraSocial = IdObraSocial;
				
			item.Numero = Numero;
				
			item.Fecha = Fecha;
				
			item.Periodo = Periodo;
				
			item.Observaciones = Observaciones;
				
			item.SubTotal = SubTotal;
				
			item.Descuento = Descuento;
				
			item.Total = Total;
				
			item.Estado = Estado;
				
			item.IdUsuarioRegistro = IdUsuarioRegistro;
				
			item.FechaRegistro = FechaRegistro;
				
	        item.Save(UserName);
	    }
    }
}
