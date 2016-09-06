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
    /// Controller class for TAM_Hpv
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class TamHpvController
    {
        // Preload our schema..
        TamHpv thisSchemaLoad = new TamHpv();
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
        public TamHpvCollection FetchAll()
        {
            TamHpvCollection coll = new TamHpvCollection();
            Query qry = new Query(TamHpv.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public TamHpvCollection FetchByID(object IdHpv)
        {
            TamHpvCollection coll = new TamHpvCollection().Where("idHpv", IdHpv).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public TamHpvCollection FetchByQuery(Query qry)
        {
            TamHpvCollection coll = new TamHpvCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object IdHpv)
        {
            return (TamHpv.Delete(IdHpv) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object IdHpv)
        {
            return (TamHpv.Destroy(IdHpv) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(int IdTam,int IdPaciente,int Edad,DateTime FechaPrevioHpv,bool HpvPrevio,int IdTipoHpvPrevio,int IdResultadoPrevioHpv,string MetodoToma,DateTime FechaToma,bool AsociaPap,int IdProfesionalToma,int IdEfectorToma,DateTime FechaRecepcion,string IngresoLetra,int IngresoNro,int IngresoNro2,int IdEfectorLaboratorio,DateTime FechaInforme,int IdProfesionalInforma,int IdResultadoHpv,string Observaciones,string CreatedBy,DateTime CreatedOn,string ModifiedBy,DateTime ModifiedOn,string NumeroProtocolo,bool Activo)
	    {
		    TamHpv item = new TamHpv();
		    
            item.IdTam = IdTam;
            
            item.IdPaciente = IdPaciente;
            
            item.Edad = Edad;
            
            item.FechaPrevioHpv = FechaPrevioHpv;
            
            item.HpvPrevio = HpvPrevio;
            
            item.IdTipoHpvPrevio = IdTipoHpvPrevio;
            
            item.IdResultadoPrevioHpv = IdResultadoPrevioHpv;
            
            item.MetodoToma = MetodoToma;
            
            item.FechaToma = FechaToma;
            
            item.AsociaPap = AsociaPap;
            
            item.IdProfesionalToma = IdProfesionalToma;
            
            item.IdEfectorToma = IdEfectorToma;
            
            item.FechaRecepcion = FechaRecepcion;
            
            item.IngresoLetra = IngresoLetra;
            
            item.IngresoNro = IngresoNro;
            
            item.IngresoNro2 = IngresoNro2;
            
            item.IdEfectorLaboratorio = IdEfectorLaboratorio;
            
            item.FechaInforme = FechaInforme;
            
            item.IdProfesionalInforma = IdProfesionalInforma;
            
            item.IdResultadoHpv = IdResultadoHpv;
            
            item.Observaciones = Observaciones;
            
            item.CreatedBy = CreatedBy;
            
            item.CreatedOn = CreatedOn;
            
            item.ModifiedBy = ModifiedBy;
            
            item.ModifiedOn = ModifiedOn;
            
            item.NumeroProtocolo = NumeroProtocolo;
            
            item.Activo = Activo;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int IdHpv,int IdTam,int IdPaciente,int Edad,DateTime FechaPrevioHpv,bool HpvPrevio,int IdTipoHpvPrevio,int IdResultadoPrevioHpv,string MetodoToma,DateTime FechaToma,bool AsociaPap,int IdProfesionalToma,int IdEfectorToma,DateTime FechaRecepcion,string IngresoLetra,int IngresoNro,int IngresoNro2,int IdEfectorLaboratorio,DateTime FechaInforme,int IdProfesionalInforma,int IdResultadoHpv,string Observaciones,string CreatedBy,DateTime CreatedOn,string ModifiedBy,DateTime ModifiedOn,string NumeroProtocolo,bool Activo)
	    {
		    TamHpv item = new TamHpv();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.IdHpv = IdHpv;
				
			item.IdTam = IdTam;
				
			item.IdPaciente = IdPaciente;
				
			item.Edad = Edad;
				
			item.FechaPrevioHpv = FechaPrevioHpv;
				
			item.HpvPrevio = HpvPrevio;
				
			item.IdTipoHpvPrevio = IdTipoHpvPrevio;
				
			item.IdResultadoPrevioHpv = IdResultadoPrevioHpv;
				
			item.MetodoToma = MetodoToma;
				
			item.FechaToma = FechaToma;
				
			item.AsociaPap = AsociaPap;
				
			item.IdProfesionalToma = IdProfesionalToma;
				
			item.IdEfectorToma = IdEfectorToma;
				
			item.FechaRecepcion = FechaRecepcion;
				
			item.IngresoLetra = IngresoLetra;
				
			item.IngresoNro = IngresoNro;
				
			item.IngresoNro2 = IngresoNro2;
				
			item.IdEfectorLaboratorio = IdEfectorLaboratorio;
				
			item.FechaInforme = FechaInforme;
				
			item.IdProfesionalInforma = IdProfesionalInforma;
				
			item.IdResultadoHpv = IdResultadoHpv;
				
			item.Observaciones = Observaciones;
				
			item.CreatedBy = CreatedBy;
				
			item.CreatedOn = CreatedOn;
				
			item.ModifiedBy = ModifiedBy;
				
			item.ModifiedOn = ModifiedOn;
				
			item.NumeroProtocolo = NumeroProtocolo;
				
			item.Activo = Activo;
				
	        item.Save(UserName);
	    }
    }
}
