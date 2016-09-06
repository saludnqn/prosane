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
    /// Controller class for EMR_Prehospitalaria
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class EmrPrehospitalariumController
    {
        // Preload our schema..
        EmrPrehospitalarium thisSchemaLoad = new EmrPrehospitalarium();
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
        public EmrPrehospitalariumCollection FetchAll()
        {
            EmrPrehospitalariumCollection coll = new EmrPrehospitalariumCollection();
            Query qry = new Query(EmrPrehospitalarium.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public EmrPrehospitalariumCollection FetchByID(object IdHCPrehospitalaria)
        {
            EmrPrehospitalariumCollection coll = new EmrPrehospitalariumCollection().Where("idHCPrehospitalaria", IdHCPrehospitalaria).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public EmrPrehospitalariumCollection FetchByQuery(Query qry)
        {
            EmrPrehospitalariumCollection coll = new EmrPrehospitalariumCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object IdHCPrehospitalaria)
        {
            return (EmrPrehospitalarium.Delete(IdHCPrehospitalaria) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object IdHCPrehospitalaria)
        {
            return (EmrPrehospitalarium.Destroy(IdHCPrehospitalaria) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string NumeroAuxilio,DateTime Fecha,string HoraTrasmitido,string Movil,int IdBase,string HoraArribo,string CodigoLlamado,string TipoCodigo,int IdPaciente,int Edad,int IdObraSocial,string NumeroAfiliado,string OtraObraSocial,string Patente,string Seguro,string ViaPublica,string Domicilio,int Transito,int Derrumbe,int Prevension,int Incendio,int Explosion,int ViolenciaSocial,int Trauma,int MovilApoyo,string MovilApoyoCual,int IntervencionPolicial,string Comisaria,string OficialComisaria,int IntervencionBomberos,string Cuartel,string OficialCuartel,string ObservacionesIncidentes,int NumeroMuertos,int NumeroVehiculos,string ObservacionesMuertes,string AmortiguadoPor,string ObservacionesTrauma,int VictimasMultiples,int NumeroVictimas,bool FallecidoInSitu,bool FallecidoEnMovil,string OtrasCausas,string ObservacionesCausas,int Actitud,int Fc,int Fr,int Saturacion,string RellenoCapilar,int TensionArterialD,int TensionArterialS,int SignosVitales,int Respiratorio,int Abdomen,int Circulatorios,int Urogenital,int PerdidaConocimiento,int IdGlasgowOcular,int IdGlasgowVerbal,int IdGlasgowMotor,string ValorGlasgow,int IdPupilas,int FocoMotor,int Paresia,int Plejia,int LadoID,bool Cabeza,bool Axila,bool Amputacion,bool Ingimal,bool Cuello,bool Dorso,bool Torax,bool MSuperior,bool MInferior,bool LesionesAbdomen,string OtrasLesiones,string TipoQuemadura,string PorcentajeQuemadura,string DiagnosticoPresuntivo,int IdCODCie10,string Procedimiento,string Tratamiento,int AntecedentesPersonales,int CategorizacionFinal,int Destino,int Trasladado,int IdEfector,string Sanatorio,string TrasladadoMovil,bool FirmaAfirmativa,bool FirmaNegativa,string OtroGlasgow,string OtrosAntecedentes,string OtroDiagnostico,bool AntecedenteDiabetes,int IdProfesional,int IdProfesionalRecibe,string Enfermero,bool Activa,string CreatedBy,DateTime CreatedOn,string ModifiedBy,DateTime ModifiedOn)
	    {
		    EmrPrehospitalarium item = new EmrPrehospitalarium();
		    
            item.NumeroAuxilio = NumeroAuxilio;
            
            item.Fecha = Fecha;
            
            item.HoraTrasmitido = HoraTrasmitido;
            
            item.Movil = Movil;
            
            item.IdBase = IdBase;
            
            item.HoraArribo = HoraArribo;
            
            item.CodigoLlamado = CodigoLlamado;
            
            item.TipoCodigo = TipoCodigo;
            
            item.IdPaciente = IdPaciente;
            
            item.Edad = Edad;
            
            item.IdObraSocial = IdObraSocial;
            
            item.NumeroAfiliado = NumeroAfiliado;
            
            item.OtraObraSocial = OtraObraSocial;
            
            item.Patente = Patente;
            
            item.Seguro = Seguro;
            
            item.ViaPublica = ViaPublica;
            
            item.Domicilio = Domicilio;
            
            item.Transito = Transito;
            
            item.Derrumbe = Derrumbe;
            
            item.Prevension = Prevension;
            
            item.Incendio = Incendio;
            
            item.Explosion = Explosion;
            
            item.ViolenciaSocial = ViolenciaSocial;
            
            item.Trauma = Trauma;
            
            item.MovilApoyo = MovilApoyo;
            
            item.MovilApoyoCual = MovilApoyoCual;
            
            item.IntervencionPolicial = IntervencionPolicial;
            
            item.Comisaria = Comisaria;
            
            item.OficialComisaria = OficialComisaria;
            
            item.IntervencionBomberos = IntervencionBomberos;
            
            item.Cuartel = Cuartel;
            
            item.OficialCuartel = OficialCuartel;
            
            item.ObservacionesIncidentes = ObservacionesIncidentes;
            
            item.NumeroMuertos = NumeroMuertos;
            
            item.NumeroVehiculos = NumeroVehiculos;
            
            item.ObservacionesMuertes = ObservacionesMuertes;
            
            item.AmortiguadoPor = AmortiguadoPor;
            
            item.ObservacionesTrauma = ObservacionesTrauma;
            
            item.VictimasMultiples = VictimasMultiples;
            
            item.NumeroVictimas = NumeroVictimas;
            
            item.FallecidoInSitu = FallecidoInSitu;
            
            item.FallecidoEnMovil = FallecidoEnMovil;
            
            item.OtrasCausas = OtrasCausas;
            
            item.ObservacionesCausas = ObservacionesCausas;
            
            item.Actitud = Actitud;
            
            item.Fc = Fc;
            
            item.Fr = Fr;
            
            item.Saturacion = Saturacion;
            
            item.RellenoCapilar = RellenoCapilar;
            
            item.TensionArterialD = TensionArterialD;
            
            item.TensionArterialS = TensionArterialS;
            
            item.SignosVitales = SignosVitales;
            
            item.Respiratorio = Respiratorio;
            
            item.Abdomen = Abdomen;
            
            item.Circulatorios = Circulatorios;
            
            item.Urogenital = Urogenital;
            
            item.PerdidaConocimiento = PerdidaConocimiento;
            
            item.IdGlasgowOcular = IdGlasgowOcular;
            
            item.IdGlasgowVerbal = IdGlasgowVerbal;
            
            item.IdGlasgowMotor = IdGlasgowMotor;
            
            item.ValorGlasgow = ValorGlasgow;
            
            item.IdPupilas = IdPupilas;
            
            item.FocoMotor = FocoMotor;
            
            item.Paresia = Paresia;
            
            item.Plejia = Plejia;
            
            item.LadoID = LadoID;
            
            item.Cabeza = Cabeza;
            
            item.Axila = Axila;
            
            item.Amputacion = Amputacion;
            
            item.Ingimal = Ingimal;
            
            item.Cuello = Cuello;
            
            item.Dorso = Dorso;
            
            item.Torax = Torax;
            
            item.MSuperior = MSuperior;
            
            item.MInferior = MInferior;
            
            item.LesionesAbdomen = LesionesAbdomen;
            
            item.OtrasLesiones = OtrasLesiones;
            
            item.TipoQuemadura = TipoQuemadura;
            
            item.PorcentajeQuemadura = PorcentajeQuemadura;
            
            item.DiagnosticoPresuntivo = DiagnosticoPresuntivo;
            
            item.IdCODCie10 = IdCODCie10;
            
            item.Procedimiento = Procedimiento;
            
            item.Tratamiento = Tratamiento;
            
            item.AntecedentesPersonales = AntecedentesPersonales;
            
            item.CategorizacionFinal = CategorizacionFinal;
            
            item.Destino = Destino;
            
            item.Trasladado = Trasladado;
            
            item.IdEfector = IdEfector;
            
            item.Sanatorio = Sanatorio;
            
            item.TrasladadoMovil = TrasladadoMovil;
            
            item.FirmaAfirmativa = FirmaAfirmativa;
            
            item.FirmaNegativa = FirmaNegativa;
            
            item.OtroGlasgow = OtroGlasgow;
            
            item.OtrosAntecedentes = OtrosAntecedentes;
            
            item.OtroDiagnostico = OtroDiagnostico;
            
            item.AntecedenteDiabetes = AntecedenteDiabetes;
            
            item.IdProfesional = IdProfesional;
            
            item.IdProfesionalRecibe = IdProfesionalRecibe;
            
            item.Enfermero = Enfermero;
            
            item.Activa = Activa;
            
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
	    public void Update(int IdHCPrehospitalaria,string NumeroAuxilio,DateTime Fecha,string HoraTrasmitido,string Movil,int IdBase,string HoraArribo,string CodigoLlamado,string TipoCodigo,int IdPaciente,int Edad,int IdObraSocial,string NumeroAfiliado,string OtraObraSocial,string Patente,string Seguro,string ViaPublica,string Domicilio,int Transito,int Derrumbe,int Prevension,int Incendio,int Explosion,int ViolenciaSocial,int Trauma,int MovilApoyo,string MovilApoyoCual,int IntervencionPolicial,string Comisaria,string OficialComisaria,int IntervencionBomberos,string Cuartel,string OficialCuartel,string ObservacionesIncidentes,int NumeroMuertos,int NumeroVehiculos,string ObservacionesMuertes,string AmortiguadoPor,string ObservacionesTrauma,int VictimasMultiples,int NumeroVictimas,bool FallecidoInSitu,bool FallecidoEnMovil,string OtrasCausas,string ObservacionesCausas,int Actitud,int Fc,int Fr,int Saturacion,string RellenoCapilar,int TensionArterialD,int TensionArterialS,int SignosVitales,int Respiratorio,int Abdomen,int Circulatorios,int Urogenital,int PerdidaConocimiento,int IdGlasgowOcular,int IdGlasgowVerbal,int IdGlasgowMotor,string ValorGlasgow,int IdPupilas,int FocoMotor,int Paresia,int Plejia,int LadoID,bool Cabeza,bool Axila,bool Amputacion,bool Ingimal,bool Cuello,bool Dorso,bool Torax,bool MSuperior,bool MInferior,bool LesionesAbdomen,string OtrasLesiones,string TipoQuemadura,string PorcentajeQuemadura,string DiagnosticoPresuntivo,int IdCODCie10,string Procedimiento,string Tratamiento,int AntecedentesPersonales,int CategorizacionFinal,int Destino,int Trasladado,int IdEfector,string Sanatorio,string TrasladadoMovil,bool FirmaAfirmativa,bool FirmaNegativa,string OtroGlasgow,string OtrosAntecedentes,string OtroDiagnostico,bool AntecedenteDiabetes,int IdProfesional,int IdProfesionalRecibe,string Enfermero,bool Activa,string CreatedBy,DateTime CreatedOn,string ModifiedBy,DateTime ModifiedOn)
	    {
		    EmrPrehospitalarium item = new EmrPrehospitalarium();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.IdHCPrehospitalaria = IdHCPrehospitalaria;
				
			item.NumeroAuxilio = NumeroAuxilio;
				
			item.Fecha = Fecha;
				
			item.HoraTrasmitido = HoraTrasmitido;
				
			item.Movil = Movil;
				
			item.IdBase = IdBase;
				
			item.HoraArribo = HoraArribo;
				
			item.CodigoLlamado = CodigoLlamado;
				
			item.TipoCodigo = TipoCodigo;
				
			item.IdPaciente = IdPaciente;
				
			item.Edad = Edad;
				
			item.IdObraSocial = IdObraSocial;
				
			item.NumeroAfiliado = NumeroAfiliado;
				
			item.OtraObraSocial = OtraObraSocial;
				
			item.Patente = Patente;
				
			item.Seguro = Seguro;
				
			item.ViaPublica = ViaPublica;
				
			item.Domicilio = Domicilio;
				
			item.Transito = Transito;
				
			item.Derrumbe = Derrumbe;
				
			item.Prevension = Prevension;
				
			item.Incendio = Incendio;
				
			item.Explosion = Explosion;
				
			item.ViolenciaSocial = ViolenciaSocial;
				
			item.Trauma = Trauma;
				
			item.MovilApoyo = MovilApoyo;
				
			item.MovilApoyoCual = MovilApoyoCual;
				
			item.IntervencionPolicial = IntervencionPolicial;
				
			item.Comisaria = Comisaria;
				
			item.OficialComisaria = OficialComisaria;
				
			item.IntervencionBomberos = IntervencionBomberos;
				
			item.Cuartel = Cuartel;
				
			item.OficialCuartel = OficialCuartel;
				
			item.ObservacionesIncidentes = ObservacionesIncidentes;
				
			item.NumeroMuertos = NumeroMuertos;
				
			item.NumeroVehiculos = NumeroVehiculos;
				
			item.ObservacionesMuertes = ObservacionesMuertes;
				
			item.AmortiguadoPor = AmortiguadoPor;
				
			item.ObservacionesTrauma = ObservacionesTrauma;
				
			item.VictimasMultiples = VictimasMultiples;
				
			item.NumeroVictimas = NumeroVictimas;
				
			item.FallecidoInSitu = FallecidoInSitu;
				
			item.FallecidoEnMovil = FallecidoEnMovil;
				
			item.OtrasCausas = OtrasCausas;
				
			item.ObservacionesCausas = ObservacionesCausas;
				
			item.Actitud = Actitud;
				
			item.Fc = Fc;
				
			item.Fr = Fr;
				
			item.Saturacion = Saturacion;
				
			item.RellenoCapilar = RellenoCapilar;
				
			item.TensionArterialD = TensionArterialD;
				
			item.TensionArterialS = TensionArterialS;
				
			item.SignosVitales = SignosVitales;
				
			item.Respiratorio = Respiratorio;
				
			item.Abdomen = Abdomen;
				
			item.Circulatorios = Circulatorios;
				
			item.Urogenital = Urogenital;
				
			item.PerdidaConocimiento = PerdidaConocimiento;
				
			item.IdGlasgowOcular = IdGlasgowOcular;
				
			item.IdGlasgowVerbal = IdGlasgowVerbal;
				
			item.IdGlasgowMotor = IdGlasgowMotor;
				
			item.ValorGlasgow = ValorGlasgow;
				
			item.IdPupilas = IdPupilas;
				
			item.FocoMotor = FocoMotor;
				
			item.Paresia = Paresia;
				
			item.Plejia = Plejia;
				
			item.LadoID = LadoID;
				
			item.Cabeza = Cabeza;
				
			item.Axila = Axila;
				
			item.Amputacion = Amputacion;
				
			item.Ingimal = Ingimal;
				
			item.Cuello = Cuello;
				
			item.Dorso = Dorso;
				
			item.Torax = Torax;
				
			item.MSuperior = MSuperior;
				
			item.MInferior = MInferior;
				
			item.LesionesAbdomen = LesionesAbdomen;
				
			item.OtrasLesiones = OtrasLesiones;
				
			item.TipoQuemadura = TipoQuemadura;
				
			item.PorcentajeQuemadura = PorcentajeQuemadura;
				
			item.DiagnosticoPresuntivo = DiagnosticoPresuntivo;
				
			item.IdCODCie10 = IdCODCie10;
				
			item.Procedimiento = Procedimiento;
				
			item.Tratamiento = Tratamiento;
				
			item.AntecedentesPersonales = AntecedentesPersonales;
				
			item.CategorizacionFinal = CategorizacionFinal;
				
			item.Destino = Destino;
				
			item.Trasladado = Trasladado;
				
			item.IdEfector = IdEfector;
				
			item.Sanatorio = Sanatorio;
				
			item.TrasladadoMovil = TrasladadoMovil;
				
			item.FirmaAfirmativa = FirmaAfirmativa;
				
			item.FirmaNegativa = FirmaNegativa;
				
			item.OtroGlasgow = OtroGlasgow;
				
			item.OtrosAntecedentes = OtrosAntecedentes;
				
			item.OtroDiagnostico = OtroDiagnostico;
				
			item.AntecedenteDiabetes = AntecedenteDiabetes;
				
			item.IdProfesional = IdProfesional;
				
			item.IdProfesionalRecibe = IdProfesionalRecibe;
				
			item.Enfermero = Enfermero;
				
			item.Activa = Activa;
				
			item.CreatedBy = CreatedBy;
				
			item.CreatedOn = CreatedOn;
				
			item.ModifiedBy = ModifiedBy;
				
			item.ModifiedOn = ModifiedOn;
				
	        item.Save(UserName);
	    }
    }
}
