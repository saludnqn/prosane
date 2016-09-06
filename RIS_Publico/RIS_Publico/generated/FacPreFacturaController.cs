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
    /// Controller class for FAC_PreFactura
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class FacPreFacturaController
    {
        // Preload our schema..
        FacPreFactura thisSchemaLoad = new FacPreFactura();
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
        public FacPreFacturaCollection FetchAll()
        {
            FacPreFacturaCollection coll = new FacPreFacturaCollection();
            Query qry = new Query(FacPreFactura.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public FacPreFacturaCollection FetchByID(object IdPreFactura)
        {
            FacPreFacturaCollection coll = new FacPreFacturaCollection().Where("idPreFactura", IdPreFactura).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public FacPreFacturaCollection FetchByQuery(Query qry)
        {
            FacPreFacturaCollection coll = new FacPreFacturaCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object IdPreFactura)
        {
            return (FacPreFactura.Delete(IdPreFactura) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object IdPreFactura)
        {
            return (FacPreFactura.Destroy(IdPreFactura) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(int IdEfector,int IdObraSocial,int Numero,DateTime Fecha,string Periodo,string Observaciones,decimal Monto,string Estado,int IdUsuarioRegistro,DateTime FechaRegistro)
	    {
		    FacPreFactura item = new FacPreFactura();
		    
            item.IdEfector = IdEfector;
            
            item.IdObraSocial = IdObraSocial;
            
            item.Numero = Numero;
            
            item.Fecha = Fecha;
            
            item.Periodo = Periodo;
            
            item.Observaciones = Observaciones;
            
            item.Monto = Monto;
            
            item.Estado = Estado;
            
            item.IdUsuarioRegistro = IdUsuarioRegistro;
            
            item.FechaRegistro = FechaRegistro;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int IdPreFactura,int IdEfector,int IdObraSocial,int Numero,DateTime Fecha,string Periodo,string Observaciones,decimal Monto,string Estado,int IdUsuarioRegistro,DateTime FechaRegistro)
	    {
		    FacPreFactura item = new FacPreFactura();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.IdPreFactura = IdPreFactura;
				
			item.IdEfector = IdEfector;
				
			item.IdObraSocial = IdObraSocial;
				
			item.Numero = Numero;
				
			item.Fecha = Fecha;
				
			item.Periodo = Periodo;
				
			item.Observaciones = Observaciones;
				
			item.Monto = Monto;
				
			item.Estado = Estado;
				
			item.IdUsuarioRegistro = IdUsuarioRegistro;
				
			item.FechaRegistro = FechaRegistro;
				
	        item.Save(UserName);
	    }
    }
}
