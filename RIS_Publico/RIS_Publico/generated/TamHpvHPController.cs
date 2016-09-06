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
    /// Controller class for TAM_HpvHP
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class TamHpvHPController
    {
        // Preload our schema..
        TamHpvHP thisSchemaLoad = new TamHpvHP();
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
        public TamHpvHPCollection FetchAll()
        {
            TamHpvHPCollection coll = new TamHpvHPCollection();
            Query qry = new Query(TamHpvHP.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public TamHpvHPCollection FetchByID(object Id)
        {
            TamHpvHPCollection coll = new TamHpvHPCollection().Where("Id", Id).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public TamHpvHPCollection FetchByQuery(Query qry)
        {
            TamHpvHPCollection coll = new TamHpvHPCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object Id)
        {
            return (TamHpvHP.Delete(Id) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object Id)
        {
            return (TamHpvHP.Destroy(Id) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(int? IdCitologo,int? IdMedicoSol,int? IdTipoMuestra,DateTime? FechaMuestra,DateTime? FechaInforme,int? IdResultado,DateTime? FechaRecepcion,int? IdPaciente,string NombrePaciente,string ApellidoPaciente,string DireccionPaciente,string NumeroLaboratorio,int? IdCentroSaludOrigen,bool? Activo,bool? PasadoSips,string CreatedBy,DateTime CreatedOn,string ModifiedBy,DateTime ModifiedOn,int? DocumentoPaciente,string TelefonoPaciente,string DireccionNroPaciente,string LocalidadPaciente,int? IdCentroInforme,bool? AsociaPap,string Observaciones,string Nota,int? IdPrestacion,DateTime? FechaNacimiento)
	    {
		    TamHpvHP item = new TamHpvHP();
		    
            item.IdCitologo = IdCitologo;
            
            item.IdMedicoSol = IdMedicoSol;
            
            item.IdTipoMuestra = IdTipoMuestra;
            
            item.FechaMuestra = FechaMuestra;
            
            item.FechaInforme = FechaInforme;
            
            item.IdResultado = IdResultado;
            
            item.FechaRecepcion = FechaRecepcion;
            
            item.IdPaciente = IdPaciente;
            
            item.NombrePaciente = NombrePaciente;
            
            item.ApellidoPaciente = ApellidoPaciente;
            
            item.DireccionPaciente = DireccionPaciente;
            
            item.NumeroLaboratorio = NumeroLaboratorio;
            
            item.IdCentroSaludOrigen = IdCentroSaludOrigen;
            
            item.Activo = Activo;
            
            item.PasadoSips = PasadoSips;
            
            item.CreatedBy = CreatedBy;
            
            item.CreatedOn = CreatedOn;
            
            item.ModifiedBy = ModifiedBy;
            
            item.ModifiedOn = ModifiedOn;
            
            item.DocumentoPaciente = DocumentoPaciente;
            
            item.TelefonoPaciente = TelefonoPaciente;
            
            item.DireccionNroPaciente = DireccionNroPaciente;
            
            item.LocalidadPaciente = LocalidadPaciente;
            
            item.IdCentroInforme = IdCentroInforme;
            
            item.AsociaPap = AsociaPap;
            
            item.Observaciones = Observaciones;
            
            item.Nota = Nota;
            
            item.IdPrestacion = IdPrestacion;
            
            item.FechaNacimiento = FechaNacimiento;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int Id,int? IdCitologo,int? IdMedicoSol,int? IdTipoMuestra,DateTime? FechaMuestra,DateTime? FechaInforme,int? IdResultado,DateTime? FechaRecepcion,int? IdPaciente,string NombrePaciente,string ApellidoPaciente,string DireccionPaciente,string NumeroLaboratorio,int? IdCentroSaludOrigen,bool? Activo,bool? PasadoSips,string CreatedBy,DateTime CreatedOn,string ModifiedBy,DateTime ModifiedOn,int? DocumentoPaciente,string TelefonoPaciente,string DireccionNroPaciente,string LocalidadPaciente,int? IdCentroInforme,bool? AsociaPap,string Observaciones,string Nota,int? IdPrestacion,DateTime? FechaNacimiento)
	    {
		    TamHpvHP item = new TamHpvHP();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.Id = Id;
				
			item.IdCitologo = IdCitologo;
				
			item.IdMedicoSol = IdMedicoSol;
				
			item.IdTipoMuestra = IdTipoMuestra;
				
			item.FechaMuestra = FechaMuestra;
				
			item.FechaInforme = FechaInforme;
				
			item.IdResultado = IdResultado;
				
			item.FechaRecepcion = FechaRecepcion;
				
			item.IdPaciente = IdPaciente;
				
			item.NombrePaciente = NombrePaciente;
				
			item.ApellidoPaciente = ApellidoPaciente;
				
			item.DireccionPaciente = DireccionPaciente;
				
			item.NumeroLaboratorio = NumeroLaboratorio;
				
			item.IdCentroSaludOrigen = IdCentroSaludOrigen;
				
			item.Activo = Activo;
				
			item.PasadoSips = PasadoSips;
				
			item.CreatedBy = CreatedBy;
				
			item.CreatedOn = CreatedOn;
				
			item.ModifiedBy = ModifiedBy;
				
			item.ModifiedOn = ModifiedOn;
				
			item.DocumentoPaciente = DocumentoPaciente;
				
			item.TelefonoPaciente = TelefonoPaciente;
				
			item.DireccionNroPaciente = DireccionNroPaciente;
				
			item.LocalidadPaciente = LocalidadPaciente;
				
			item.IdCentroInforme = IdCentroInforme;
				
			item.AsociaPap = AsociaPap;
				
			item.Observaciones = Observaciones;
				
			item.Nota = Nota;
				
			item.IdPrestacion = IdPrestacion;
				
			item.FechaNacimiento = FechaNacimiento;
				
	        item.Save(UserName);
	    }
    }
}
