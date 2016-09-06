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
    /// Controller class for FAC_Orden
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class FacOrdenController
    {
        // Preload our schema..
        FacOrden thisSchemaLoad = new FacOrden();
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
        public FacOrdenCollection FetchAll()
        {
            FacOrdenCollection coll = new FacOrdenCollection();
            Query qry = new Query(FacOrden.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public FacOrdenCollection FetchByID(object IdOrden)
        {
            FacOrdenCollection coll = new FacOrdenCollection().Where("idOrden", IdOrden).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public FacOrdenCollection FetchByQuery(Query qry)
        {
            FacOrdenCollection coll = new FacOrdenCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object IdOrden)
        {
            return (FacOrden.Delete(IdOrden) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object IdOrden)
        {
            return (FacOrden.Destroy(IdOrden) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(int IdEfector,int Numero,string Periodo,int IdServicio,int IdPaciente,int IdProfesional,DateTime Fecha,DateTime FechaPractica,int IdTipoPractica,int IdObraSocial,string NroAfiliado,string Observaciones,string Estado,int IdUsuarioRegistro,DateTime FechaRegistro,int IdPrefactura,int IdFactura,bool Baja,bool CodificaHIV,decimal Monto,string NumeroSiniestro,DateTime FechaSiniestro,bool FacturaFueraConvenio,bool? EsInternacion)
	    {
		    FacOrden item = new FacOrden();
		    
            item.IdEfector = IdEfector;
            
            item.Numero = Numero;
            
            item.Periodo = Periodo;
            
            item.IdServicio = IdServicio;
            
            item.IdPaciente = IdPaciente;
            
            item.IdProfesional = IdProfesional;
            
            item.Fecha = Fecha;
            
            item.FechaPractica = FechaPractica;
            
            item.IdTipoPractica = IdTipoPractica;
            
            item.IdObraSocial = IdObraSocial;
            
            item.NroAfiliado = NroAfiliado;
            
            item.Observaciones = Observaciones;
            
            item.Estado = Estado;
            
            item.IdUsuarioRegistro = IdUsuarioRegistro;
            
            item.FechaRegistro = FechaRegistro;
            
            item.IdPrefactura = IdPrefactura;
            
            item.IdFactura = IdFactura;
            
            item.Baja = Baja;
            
            item.CodificaHIV = CodificaHIV;
            
            item.Monto = Monto;
            
            item.NumeroSiniestro = NumeroSiniestro;
            
            item.FechaSiniestro = FechaSiniestro;
            
            item.FacturaFueraConvenio = FacturaFueraConvenio;
            
            item.EsInternacion = EsInternacion;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int IdOrden,int IdEfector,int Numero,string Periodo,int IdServicio,int IdPaciente,int IdProfesional,DateTime Fecha,DateTime FechaPractica,int IdTipoPractica,int IdObraSocial,string NroAfiliado,string Observaciones,string Estado,int IdUsuarioRegistro,DateTime FechaRegistro,int IdPrefactura,int IdFactura,bool Baja,bool CodificaHIV,decimal Monto,string NumeroSiniestro,DateTime FechaSiniestro,bool FacturaFueraConvenio,bool? EsInternacion)
	    {
		    FacOrden item = new FacOrden();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.IdOrden = IdOrden;
				
			item.IdEfector = IdEfector;
				
			item.Numero = Numero;
				
			item.Periodo = Periodo;
				
			item.IdServicio = IdServicio;
				
			item.IdPaciente = IdPaciente;
				
			item.IdProfesional = IdProfesional;
				
			item.Fecha = Fecha;
				
			item.FechaPractica = FechaPractica;
				
			item.IdTipoPractica = IdTipoPractica;
				
			item.IdObraSocial = IdObraSocial;
				
			item.NroAfiliado = NroAfiliado;
				
			item.Observaciones = Observaciones;
				
			item.Estado = Estado;
				
			item.IdUsuarioRegistro = IdUsuarioRegistro;
				
			item.FechaRegistro = FechaRegistro;
				
			item.IdPrefactura = IdPrefactura;
				
			item.IdFactura = IdFactura;
				
			item.Baja = Baja;
				
			item.CodificaHIV = CodificaHIV;
				
			item.Monto = Monto;
				
			item.NumeroSiniestro = NumeroSiniestro;
				
			item.FechaSiniestro = FechaSiniestro;
				
			item.FacturaFueraConvenio = FacturaFueraConvenio;
				
			item.EsInternacion = EsInternacion;
				
	        item.Save(UserName);
	    }
    }
}
