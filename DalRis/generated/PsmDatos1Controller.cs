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
    /// Controller class for PSM_Datos1
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class PsmDatos1Controller
    {
        // Preload our schema..
        PsmDatos1 thisSchemaLoad = new PsmDatos1();
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
        public PsmDatos1Collection FetchAll()
        {
            PsmDatos1Collection coll = new PsmDatos1Collection();
            Query qry = new Query(PsmDatos1.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public PsmDatos1Collection FetchByID(object IdProsame)
        {
            PsmDatos1Collection coll = new PsmDatos1Collection().Where("idProsame", IdProsame).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public PsmDatos1Collection FetchByQuery(Query qry)
        {
            PsmDatos1Collection coll = new PsmDatos1Collection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object IdProsame)
        {
            return (PsmDatos1.Delete(IdProsame) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object IdProsame)
        {
            return (PsmDatos1.Destroy(IdProsame) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(decimal IdPaciente,decimal IdEfector,int? DNIPaciente,decimal? IdEstablecimiento,string Prematuro,decimal? TutorDNI,string TutorNombre,string SobreEdad,string Repitente,decimal? Peso,decimal? Talla,decimal? Imc,decimal? TaMax,decimal? TaMin,decimal? PercentiloPeso,decimal? PercentiloTalla,decimal? PercentiloIMC,decimal? PercentiloMax,decimal? PercentiloMin,decimal? EFPielFanera,decimal? EFCardiovascular,decimal? EFRespiratorio,decimal? EFGenital,decimal? EFAbdomen,decimal? EFOsteoarticular,decimal? EFNeurologico,string VacunaCarne,string VacunaCompleta,string Estravismo,string AgudezaVisualIzq,string AgudezaVisualDer,string Audiometria,string Hipoacusia,string TransFonacion,string ObservacionesGeneral,string OdontoHabitosPernciosos,string OdontoMaloclusion,string OdontoFluorAplicado,string UsaLentes,string Grado,string Division,string Turno,string Sexo,string ZonaEstudio,string PacNombre,DateTime? FechaNac,string Domicilio,string Celular,int? PacOSocial,DateTime? Fecha,string Telefono,int? Ceod,int? Cpod,string Observaciones,string OSocialTiene,string VacRestanAplicar,string ResponsableOdonto,string ResponsableFicha,decimal? AudiometriaValor,decimal? PesoAlumno,string VacSevacEsc,int? OdontoCariado,int? IdProfesionalFicha,int? IdProfesionalOdonto,string FonoAudiometria,string FonoTato,string FonoDiapason,string TatoValor,string Autorizado,int? IdProvincia,int? IdDepartamento,int? IdDLocalidad,int? IdLocalidad,int? TatoValor1,int IdUsuarioCarga,DateTime FechaCarga)
	    {
		    PsmDatos1 item = new PsmDatos1();
		    
            item.IdPaciente = IdPaciente;
            
            item.IdEfector = IdEfector;
            
            item.DNIPaciente = DNIPaciente;
            
            item.IdEstablecimiento = IdEstablecimiento;
            
            item.Prematuro = Prematuro;
            
            item.TutorDNI = TutorDNI;
            
            item.TutorNombre = TutorNombre;
            
            item.SobreEdad = SobreEdad;
            
            item.Repitente = Repitente;
            
            item.Peso = Peso;
            
            item.Talla = Talla;
            
            item.Imc = Imc;
            
            item.TaMax = TaMax;
            
            item.TaMin = TaMin;
            
            item.PercentiloPeso = PercentiloPeso;
            
            item.PercentiloTalla = PercentiloTalla;
            
            item.PercentiloIMC = PercentiloIMC;
            
            item.PercentiloMax = PercentiloMax;
            
            item.PercentiloMin = PercentiloMin;
            
            item.EFPielFanera = EFPielFanera;
            
            item.EFCardiovascular = EFCardiovascular;
            
            item.EFRespiratorio = EFRespiratorio;
            
            item.EFGenital = EFGenital;
            
            item.EFAbdomen = EFAbdomen;
            
            item.EFOsteoarticular = EFOsteoarticular;
            
            item.EFNeurologico = EFNeurologico;
            
            item.VacunaCarne = VacunaCarne;
            
            item.VacunaCompleta = VacunaCompleta;
            
            item.Estravismo = Estravismo;
            
            item.AgudezaVisualIzq = AgudezaVisualIzq;
            
            item.AgudezaVisualDer = AgudezaVisualDer;
            
            item.Audiometria = Audiometria;
            
            item.Hipoacusia = Hipoacusia;
            
            item.TransFonacion = TransFonacion;
            
            item.ObservacionesGeneral = ObservacionesGeneral;
            
            item.OdontoHabitosPernciosos = OdontoHabitosPernciosos;
            
            item.OdontoMaloclusion = OdontoMaloclusion;
            
            item.OdontoFluorAplicado = OdontoFluorAplicado;
            
            item.UsaLentes = UsaLentes;
            
            item.Grado = Grado;
            
            item.Division = Division;
            
            item.Turno = Turno;
            
            item.Sexo = Sexo;
            
            item.ZonaEstudio = ZonaEstudio;
            
            item.PacNombre = PacNombre;
            
            item.FechaNac = FechaNac;
            
            item.Domicilio = Domicilio;
            
            item.Celular = Celular;
            
            item.PacOSocial = PacOSocial;
            
            item.Fecha = Fecha;
            
            item.Telefono = Telefono;
            
            item.Ceod = Ceod;
            
            item.Cpod = Cpod;
            
            item.Observaciones = Observaciones;
            
            item.OSocialTiene = OSocialTiene;
            
            item.VacRestanAplicar = VacRestanAplicar;
            
            item.ResponsableOdonto = ResponsableOdonto;
            
            item.ResponsableFicha = ResponsableFicha;
            
            item.AudiometriaValor = AudiometriaValor;
            
            item.PesoAlumno = PesoAlumno;
            
            item.VacSevacEsc = VacSevacEsc;
            
            item.OdontoCariado = OdontoCariado;
            
            item.IdProfesionalFicha = IdProfesionalFicha;
            
            item.IdProfesionalOdonto = IdProfesionalOdonto;
            
            item.FonoAudiometria = FonoAudiometria;
            
            item.FonoTato = FonoTato;
            
            item.FonoDiapason = FonoDiapason;
            
            item.TatoValor = TatoValor;
            
            item.Autorizado = Autorizado;
            
            item.IdProvincia = IdProvincia;
            
            item.IdDepartamento = IdDepartamento;
            
            item.IdDLocalidad = IdDLocalidad;
            
            item.IdLocalidad = IdLocalidad;
            
            item.TatoValor1 = TatoValor1;
            
            item.IdUsuarioCarga = IdUsuarioCarga;
            
            item.FechaCarga = FechaCarga;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int IdProsame,decimal IdPaciente,decimal IdEfector,int? DNIPaciente,decimal? IdEstablecimiento,string Prematuro,decimal? TutorDNI,string TutorNombre,string SobreEdad,string Repitente,decimal? Peso,decimal? Talla,decimal? Imc,decimal? TaMax,decimal? TaMin,decimal? PercentiloPeso,decimal? PercentiloTalla,decimal? PercentiloIMC,decimal? PercentiloMax,decimal? PercentiloMin,decimal? EFPielFanera,decimal? EFCardiovascular,decimal? EFRespiratorio,decimal? EFGenital,decimal? EFAbdomen,decimal? EFOsteoarticular,decimal? EFNeurologico,string VacunaCarne,string VacunaCompleta,string Estravismo,string AgudezaVisualIzq,string AgudezaVisualDer,string Audiometria,string Hipoacusia,string TransFonacion,string ObservacionesGeneral,string OdontoHabitosPernciosos,string OdontoMaloclusion,string OdontoFluorAplicado,string UsaLentes,string Grado,string Division,string Turno,string Sexo,string ZonaEstudio,string PacNombre,DateTime? FechaNac,string Domicilio,string Celular,int? PacOSocial,DateTime? Fecha,string Telefono,int? Ceod,int? Cpod,string Observaciones,string OSocialTiene,string VacRestanAplicar,string ResponsableOdonto,string ResponsableFicha,decimal? AudiometriaValor,decimal? PesoAlumno,string VacSevacEsc,int? OdontoCariado,int? IdProfesionalFicha,int? IdProfesionalOdonto,string FonoAudiometria,string FonoTato,string FonoDiapason,string TatoValor,string Autorizado,int? IdProvincia,int? IdDepartamento,int? IdDLocalidad,int? IdLocalidad,int? TatoValor1,int IdUsuarioCarga,DateTime FechaCarga)
	    {
		    PsmDatos1 item = new PsmDatos1();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.IdProsame = IdProsame;
				
			item.IdPaciente = IdPaciente;
				
			item.IdEfector = IdEfector;
				
			item.DNIPaciente = DNIPaciente;
				
			item.IdEstablecimiento = IdEstablecimiento;
				
			item.Prematuro = Prematuro;
				
			item.TutorDNI = TutorDNI;
				
			item.TutorNombre = TutorNombre;
				
			item.SobreEdad = SobreEdad;
				
			item.Repitente = Repitente;
				
			item.Peso = Peso;
				
			item.Talla = Talla;
				
			item.Imc = Imc;
				
			item.TaMax = TaMax;
				
			item.TaMin = TaMin;
				
			item.PercentiloPeso = PercentiloPeso;
				
			item.PercentiloTalla = PercentiloTalla;
				
			item.PercentiloIMC = PercentiloIMC;
				
			item.PercentiloMax = PercentiloMax;
				
			item.PercentiloMin = PercentiloMin;
				
			item.EFPielFanera = EFPielFanera;
				
			item.EFCardiovascular = EFCardiovascular;
				
			item.EFRespiratorio = EFRespiratorio;
				
			item.EFGenital = EFGenital;
				
			item.EFAbdomen = EFAbdomen;
				
			item.EFOsteoarticular = EFOsteoarticular;
				
			item.EFNeurologico = EFNeurologico;
				
			item.VacunaCarne = VacunaCarne;
				
			item.VacunaCompleta = VacunaCompleta;
				
			item.Estravismo = Estravismo;
				
			item.AgudezaVisualIzq = AgudezaVisualIzq;
				
			item.AgudezaVisualDer = AgudezaVisualDer;
				
			item.Audiometria = Audiometria;
				
			item.Hipoacusia = Hipoacusia;
				
			item.TransFonacion = TransFonacion;
				
			item.ObservacionesGeneral = ObservacionesGeneral;
				
			item.OdontoHabitosPernciosos = OdontoHabitosPernciosos;
				
			item.OdontoMaloclusion = OdontoMaloclusion;
				
			item.OdontoFluorAplicado = OdontoFluorAplicado;
				
			item.UsaLentes = UsaLentes;
				
			item.Grado = Grado;
				
			item.Division = Division;
				
			item.Turno = Turno;
				
			item.Sexo = Sexo;
				
			item.ZonaEstudio = ZonaEstudio;
				
			item.PacNombre = PacNombre;
				
			item.FechaNac = FechaNac;
				
			item.Domicilio = Domicilio;
				
			item.Celular = Celular;
				
			item.PacOSocial = PacOSocial;
				
			item.Fecha = Fecha;
				
			item.Telefono = Telefono;
				
			item.Ceod = Ceod;
				
			item.Cpod = Cpod;
				
			item.Observaciones = Observaciones;
				
			item.OSocialTiene = OSocialTiene;
				
			item.VacRestanAplicar = VacRestanAplicar;
				
			item.ResponsableOdonto = ResponsableOdonto;
				
			item.ResponsableFicha = ResponsableFicha;
				
			item.AudiometriaValor = AudiometriaValor;
				
			item.PesoAlumno = PesoAlumno;
				
			item.VacSevacEsc = VacSevacEsc;
				
			item.OdontoCariado = OdontoCariado;
				
			item.IdProfesionalFicha = IdProfesionalFicha;
				
			item.IdProfesionalOdonto = IdProfesionalOdonto;
				
			item.FonoAudiometria = FonoAudiometria;
				
			item.FonoTato = FonoTato;
				
			item.FonoDiapason = FonoDiapason;
				
			item.TatoValor = TatoValor;
				
			item.Autorizado = Autorizado;
				
			item.IdProvincia = IdProvincia;
				
			item.IdDepartamento = IdDepartamento;
				
			item.IdDLocalidad = IdDLocalidad;
				
			item.IdLocalidad = IdLocalidad;
				
			item.TatoValor1 = TatoValor1;
				
			item.IdUsuarioCarga = IdUsuarioCarga;
				
			item.FechaCarga = FechaCarga;
				
	        item.Save(UserName);
	    }
    }
}
