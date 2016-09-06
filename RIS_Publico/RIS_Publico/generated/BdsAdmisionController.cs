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
    /// Controller class for BDS_Admision
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class BdsAdmisionController
    {
        // Preload our schema..
        BdsAdmision thisSchemaLoad = new BdsAdmision();
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
        public BdsAdmisionCollection FetchAll()
        {
            BdsAdmisionCollection coll = new BdsAdmisionCollection();
            Query qry = new Query(BdsAdmision.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public BdsAdmisionCollection FetchByID(object IdAdmision)
        {
            BdsAdmisionCollection coll = new BdsAdmisionCollection().Where("idAdmision", IdAdmision).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public BdsAdmisionCollection FetchByQuery(Query qry)
        {
            BdsAdmisionCollection coll = new BdsAdmisionCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object IdAdmision)
        {
            return (BdsAdmision.Delete(IdAdmision) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object IdAdmision)
        {
            return (BdsAdmision.Destroy(IdAdmision) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(DateTime Fecha,string HoraAdmision,int IdDonante,int IdTipoDonante,int IdEfectorExtraccion,string NumeroDeBolsa,string EfectorOrigenBolsa,DateTime FechaExtraccionBolsa,DateTime FechaVencimientoBolsa,string GrupoBolsa,string FactorBolsa,bool SerologiaBolsa,string Receptor,string ObservacionesAdmision,string ResponsableEntrevista,string EstadoEntrevista,int IdTipoExclusion,DateTime FechaFinExclusion,string ObservacionesExclusion,int IdUsuarioRegistro,DateTime FechaRegistro,int IdEfectorSerologia,int IdEfectorHematologia,int IdIncidenciaExtraccion,bool Descartada,DateTime FechaDescarte,int IdUsuarioDescarte,string Extraccion,string Colecta)
	    {
		    BdsAdmision item = new BdsAdmision();
		    
            item.Fecha = Fecha;
            
            item.HoraAdmision = HoraAdmision;
            
            item.IdDonante = IdDonante;
            
            item.IdTipoDonante = IdTipoDonante;
            
            item.IdEfectorExtraccion = IdEfectorExtraccion;
            
            item.NumeroDeBolsa = NumeroDeBolsa;
            
            item.EfectorOrigenBolsa = EfectorOrigenBolsa;
            
            item.FechaExtraccionBolsa = FechaExtraccionBolsa;
            
            item.FechaVencimientoBolsa = FechaVencimientoBolsa;
            
            item.GrupoBolsa = GrupoBolsa;
            
            item.FactorBolsa = FactorBolsa;
            
            item.SerologiaBolsa = SerologiaBolsa;
            
            item.Receptor = Receptor;
            
            item.ObservacionesAdmision = ObservacionesAdmision;
            
            item.ResponsableEntrevista = ResponsableEntrevista;
            
            item.EstadoEntrevista = EstadoEntrevista;
            
            item.IdTipoExclusion = IdTipoExclusion;
            
            item.FechaFinExclusion = FechaFinExclusion;
            
            item.ObservacionesExclusion = ObservacionesExclusion;
            
            item.IdUsuarioRegistro = IdUsuarioRegistro;
            
            item.FechaRegistro = FechaRegistro;
            
            item.IdEfectorSerologia = IdEfectorSerologia;
            
            item.IdEfectorHematologia = IdEfectorHematologia;
            
            item.IdIncidenciaExtraccion = IdIncidenciaExtraccion;
            
            item.Descartada = Descartada;
            
            item.FechaDescarte = FechaDescarte;
            
            item.IdUsuarioDescarte = IdUsuarioDescarte;
            
            item.Extraccion = Extraccion;
            
            item.Colecta = Colecta;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int IdAdmision,DateTime Fecha,string HoraAdmision,int IdDonante,int IdTipoDonante,int IdEfectorExtraccion,string NumeroDeBolsa,string EfectorOrigenBolsa,DateTime FechaExtraccionBolsa,DateTime FechaVencimientoBolsa,string GrupoBolsa,string FactorBolsa,bool SerologiaBolsa,string Receptor,string ObservacionesAdmision,string ResponsableEntrevista,string EstadoEntrevista,int IdTipoExclusion,DateTime FechaFinExclusion,string ObservacionesExclusion,int IdUsuarioRegistro,DateTime FechaRegistro,int IdEfectorSerologia,int IdEfectorHematologia,int IdIncidenciaExtraccion,bool Descartada,DateTime FechaDescarte,int IdUsuarioDescarte,string Extraccion,string Colecta)
	    {
		    BdsAdmision item = new BdsAdmision();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.IdAdmision = IdAdmision;
				
			item.Fecha = Fecha;
				
			item.HoraAdmision = HoraAdmision;
				
			item.IdDonante = IdDonante;
				
			item.IdTipoDonante = IdTipoDonante;
				
			item.IdEfectorExtraccion = IdEfectorExtraccion;
				
			item.NumeroDeBolsa = NumeroDeBolsa;
				
			item.EfectorOrigenBolsa = EfectorOrigenBolsa;
				
			item.FechaExtraccionBolsa = FechaExtraccionBolsa;
				
			item.FechaVencimientoBolsa = FechaVencimientoBolsa;
				
			item.GrupoBolsa = GrupoBolsa;
				
			item.FactorBolsa = FactorBolsa;
				
			item.SerologiaBolsa = SerologiaBolsa;
				
			item.Receptor = Receptor;
				
			item.ObservacionesAdmision = ObservacionesAdmision;
				
			item.ResponsableEntrevista = ResponsableEntrevista;
				
			item.EstadoEntrevista = EstadoEntrevista;
				
			item.IdTipoExclusion = IdTipoExclusion;
				
			item.FechaFinExclusion = FechaFinExclusion;
				
			item.ObservacionesExclusion = ObservacionesExclusion;
				
			item.IdUsuarioRegistro = IdUsuarioRegistro;
				
			item.FechaRegistro = FechaRegistro;
				
			item.IdEfectorSerologia = IdEfectorSerologia;
				
			item.IdEfectorHematologia = IdEfectorHematologia;
				
			item.IdIncidenciaExtraccion = IdIncidenciaExtraccion;
				
			item.Descartada = Descartada;
				
			item.FechaDescarte = FechaDescarte;
				
			item.IdUsuarioDescarte = IdUsuarioDescarte;
				
			item.Extraccion = Extraccion;
				
			item.Colecta = Colecta;
				
	        item.Save(UserName);
	    }
    }
}
