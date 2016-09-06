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
    /// Controller class for TAM_PapHP
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class TamPapHPController
    {
        // Preload our schema..
        TamPapHP thisSchemaLoad = new TamPapHP();
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
        public TamPapHPCollection FetchAll()
        {
            TamPapHPCollection coll = new TamPapHPCollection();
            Query qry = new Query(TamPapHP.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public TamPapHPCollection FetchByID(object IdPapHP)
        {
            TamPapHPCollection coll = new TamPapHPCollection().Where("id_PapHP", IdPapHP).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public TamPapHPCollection FetchByQuery(Query qry)
        {
            TamPapHPCollection coll = new TamPapHPCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object IdPapHP)
        {
            return (TamPapHP.Delete(IdPapHP) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object IdPapHP)
        {
            return (TamPapHP.Destroy(IdPapHP) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(int Id,int? IdTipoPapPrevio,int? IdResultadoPapPrevio,int? IdCitologo,int? IdMedicoSol,int? IdTipoMuestra,DateTime? FechaMuestra,int? IdCentroMuestra,DateTime? FechaInforme,int? MujerDni,DateTime? MujerFechaNacimiento,int? MujerEdadPrestacion,string MujerNombre,string MujerApellido,string MujerTelefono,string MujerDireccion,string MujerDireccionNro,string MujerLocalidad,int? IdCalidadMuestra,int? IdMicroorganismo,int? IdOtrosHallazgos,int? IdCelulasEscamosas,int? IdCelulasGlandulares,int? IdObservacion,DateTime? FechaRecepcion,string Observaciones,int? IdCentro,int? IdMujerExporta,string NumeroLaboratorio,DateTime? FechaEntrega,bool? CervixSatisfactorio,bool? TratHormonal,bool? TratRadiante,int? IdTratDestructivo,bool? Quimioterapia,bool? Embarazada,DateTime? FechaFum,int? Paridad,int? IdAnticonceptivo,int? IdCirugia,bool? Menopausia,bool? Lactancia,DateTime? FechaPrevio,bool? PasadoSips,bool? Activo,string Nota,string CreatedBy,DateTime CreatedOn,string ModifiedBy,DateTime ModifiedOn)
	    {
		    TamPapHP item = new TamPapHP();
		    
            item.Id = Id;
            
            item.IdTipoPapPrevio = IdTipoPapPrevio;
            
            item.IdResultadoPapPrevio = IdResultadoPapPrevio;
            
            item.IdCitologo = IdCitologo;
            
            item.IdMedicoSol = IdMedicoSol;
            
            item.IdTipoMuestra = IdTipoMuestra;
            
            item.FechaMuestra = FechaMuestra;
            
            item.IdCentroMuestra = IdCentroMuestra;
            
            item.FechaInforme = FechaInforme;
            
            item.MujerDni = MujerDni;
            
            item.MujerFechaNacimiento = MujerFechaNacimiento;
            
            item.MujerEdadPrestacion = MujerEdadPrestacion;
            
            item.MujerNombre = MujerNombre;
            
            item.MujerApellido = MujerApellido;
            
            item.MujerTelefono = MujerTelefono;
            
            item.MujerDireccion = MujerDireccion;
            
            item.MujerDireccionNro = MujerDireccionNro;
            
            item.MujerLocalidad = MujerLocalidad;
            
            item.IdCalidadMuestra = IdCalidadMuestra;
            
            item.IdMicroorganismo = IdMicroorganismo;
            
            item.IdOtrosHallazgos = IdOtrosHallazgos;
            
            item.IdCelulasEscamosas = IdCelulasEscamosas;
            
            item.IdCelulasGlandulares = IdCelulasGlandulares;
            
            item.IdObservacion = IdObservacion;
            
            item.FechaRecepcion = FechaRecepcion;
            
            item.Observaciones = Observaciones;
            
            item.IdCentro = IdCentro;
            
            item.IdMujerExporta = IdMujerExporta;
            
            item.NumeroLaboratorio = NumeroLaboratorio;
            
            item.FechaEntrega = FechaEntrega;
            
            item.CervixSatisfactorio = CervixSatisfactorio;
            
            item.TratHormonal = TratHormonal;
            
            item.TratRadiante = TratRadiante;
            
            item.IdTratDestructivo = IdTratDestructivo;
            
            item.Quimioterapia = Quimioterapia;
            
            item.Embarazada = Embarazada;
            
            item.FechaFum = FechaFum;
            
            item.Paridad = Paridad;
            
            item.IdAnticonceptivo = IdAnticonceptivo;
            
            item.IdCirugia = IdCirugia;
            
            item.Menopausia = Menopausia;
            
            item.Lactancia = Lactancia;
            
            item.FechaPrevio = FechaPrevio;
            
            item.PasadoSips = PasadoSips;
            
            item.Activo = Activo;
            
            item.Nota = Nota;
            
            item.CreatedBy = CreatedBy;
            
            item.CreatedOn = CreatedOn;
            
            item.ModifiedBy = ModifiedBy;
            
            item.ModifiedOn = ModifiedOn;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int IdPapHP,int Id,int? IdTipoPapPrevio,int? IdResultadoPapPrevio,int? IdCitologo,int? IdMedicoSol,int? IdTipoMuestra,DateTime? FechaMuestra,int? IdCentroMuestra,DateTime? FechaInforme,int? MujerDni,DateTime? MujerFechaNacimiento,int? MujerEdadPrestacion,string MujerNombre,string MujerApellido,string MujerTelefono,string MujerDireccion,string MujerDireccionNro,string MujerLocalidad,int? IdCalidadMuestra,int? IdMicroorganismo,int? IdOtrosHallazgos,int? IdCelulasEscamosas,int? IdCelulasGlandulares,int? IdObservacion,DateTime? FechaRecepcion,string Observaciones,int? IdCentro,int? IdMujerExporta,string NumeroLaboratorio,DateTime? FechaEntrega,bool? CervixSatisfactorio,bool? TratHormonal,bool? TratRadiante,int? IdTratDestructivo,bool? Quimioterapia,bool? Embarazada,DateTime? FechaFum,int? Paridad,int? IdAnticonceptivo,int? IdCirugia,bool? Menopausia,bool? Lactancia,DateTime? FechaPrevio,bool? PasadoSips,bool? Activo,string Nota,string CreatedBy,DateTime CreatedOn,string ModifiedBy,DateTime ModifiedOn)
	    {
		    TamPapHP item = new TamPapHP();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.IdPapHP = IdPapHP;
				
			item.Id = Id;
				
			item.IdTipoPapPrevio = IdTipoPapPrevio;
				
			item.IdResultadoPapPrevio = IdResultadoPapPrevio;
				
			item.IdCitologo = IdCitologo;
				
			item.IdMedicoSol = IdMedicoSol;
				
			item.IdTipoMuestra = IdTipoMuestra;
				
			item.FechaMuestra = FechaMuestra;
				
			item.IdCentroMuestra = IdCentroMuestra;
				
			item.FechaInforme = FechaInforme;
				
			item.MujerDni = MujerDni;
				
			item.MujerFechaNacimiento = MujerFechaNacimiento;
				
			item.MujerEdadPrestacion = MujerEdadPrestacion;
				
			item.MujerNombre = MujerNombre;
				
			item.MujerApellido = MujerApellido;
				
			item.MujerTelefono = MujerTelefono;
				
			item.MujerDireccion = MujerDireccion;
				
			item.MujerDireccionNro = MujerDireccionNro;
				
			item.MujerLocalidad = MujerLocalidad;
				
			item.IdCalidadMuestra = IdCalidadMuestra;
				
			item.IdMicroorganismo = IdMicroorganismo;
				
			item.IdOtrosHallazgos = IdOtrosHallazgos;
				
			item.IdCelulasEscamosas = IdCelulasEscamosas;
				
			item.IdCelulasGlandulares = IdCelulasGlandulares;
				
			item.IdObservacion = IdObservacion;
				
			item.FechaRecepcion = FechaRecepcion;
				
			item.Observaciones = Observaciones;
				
			item.IdCentro = IdCentro;
				
			item.IdMujerExporta = IdMujerExporta;
				
			item.NumeroLaboratorio = NumeroLaboratorio;
				
			item.FechaEntrega = FechaEntrega;
				
			item.CervixSatisfactorio = CervixSatisfactorio;
				
			item.TratHormonal = TratHormonal;
				
			item.TratRadiante = TratRadiante;
				
			item.IdTratDestructivo = IdTratDestructivo;
				
			item.Quimioterapia = Quimioterapia;
				
			item.Embarazada = Embarazada;
				
			item.FechaFum = FechaFum;
				
			item.Paridad = Paridad;
				
			item.IdAnticonceptivo = IdAnticonceptivo;
				
			item.IdCirugia = IdCirugia;
				
			item.Menopausia = Menopausia;
				
			item.Lactancia = Lactancia;
				
			item.FechaPrevio = FechaPrevio;
				
			item.PasadoSips = PasadoSips;
				
			item.Activo = Activo;
				
			item.Nota = Nota;
				
			item.CreatedBy = CreatedBy;
				
			item.CreatedOn = CreatedOn;
				
			item.ModifiedBy = ModifiedBy;
				
			item.ModifiedOn = ModifiedOn;
				
	        item.Save(UserName);
	    }
    }
}
