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
// <auto-generated />
namespace DalRis
{
    /// <summary>
    /// Controller class for PSM_Datos_OLD
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class PsmDatosOldController
    {
        // Preload our schema..
        PsmDatosOld thisSchemaLoad = new PsmDatosOld();
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
        public PsmDatosOldCollection FetchAll()
        {
            PsmDatosOldCollection coll = new PsmDatosOldCollection();
            Query qry = new Query(PsmDatosOld.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public PsmDatosOldCollection FetchByID(object IdProsame)
        {
            PsmDatosOldCollection coll = new PsmDatosOldCollection().Where("idProsame", IdProsame).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public PsmDatosOldCollection FetchByQuery(Query qry)
        {
            PsmDatosOldCollection coll = new PsmDatosOldCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object IdProsame)
        {
            return (PsmDatosOld.Delete(IdProsame) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object IdProsame)
        {
            return (PsmDatosOld.Destroy(IdProsame) == 1);
        }
        
        
        
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(decimal IdProsame,decimal IdPaciente,decimal IdEfector)
        {
            Query qry = new Query(PsmDatosOld.Schema);
            qry.QueryType = QueryType.Delete;
            qry.AddWhere("IdProsame", IdProsame).AND("IdPaciente", IdPaciente).AND("IdEfector", IdEfector);
            qry.Execute();
            return (true);
        }        
       
    	
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(decimal IdProsame,decimal IdPaciente,decimal IdEfector,decimal? IdEstablecimiento,string Prematuro,decimal? TutorDNI,string TutorNombre,string SobreEdad,string Repitente,decimal? Peso,decimal? Talla,decimal? Imc,decimal? TaMax,decimal? TaMin,decimal? PercentiloPeso,decimal? PercentiloTalla,decimal? PercentiloIMC,decimal? PercentiloMax,decimal? PercentiloMin,decimal? EFPielFanera,decimal? EFCardiovascular,decimal? EFRespiratorio,decimal? EFGenital,decimal? EFAbdomen,decimal? EFOsteoarticular,decimal? EFNeurologico,string VacunaCarne,string VacunaCompleta,string VacunaEscuela,string Estravismo,decimal? AgudezaVisualIzq,decimal? AgudezaVisualDer,string Audiometria,string Hipoacusia,string TransFonacion,string Observaciones,string OdontoHabitosPernciosos,string OdontoMaloclusion,string OdontoFluorAplicado,decimal? Cariados,decimal? Obstruidos,decimal? Diente,decimal? C,string UsaLentes,decimal? Extraidos)
	    {
		    PsmDatosOld item = new PsmDatosOld();
		    
            item.IdProsame = IdProsame;
            
            item.IdPaciente = IdPaciente;
            
            item.IdEfector = IdEfector;
            
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
            
            item.VacunaEscuela = VacunaEscuela;
            
            item.Estravismo = Estravismo;
            
            item.AgudezaVisualIzq = AgudezaVisualIzq;
            
            item.AgudezaVisualDer = AgudezaVisualDer;
            
            item.Audiometria = Audiometria;
            
            item.Hipoacusia = Hipoacusia;
            
            item.TransFonacion = TransFonacion;
            
            item.Observaciones = Observaciones;
            
            item.OdontoHabitosPernciosos = OdontoHabitosPernciosos;
            
            item.OdontoMaloclusion = OdontoMaloclusion;
            
            item.OdontoFluorAplicado = OdontoFluorAplicado;
            
            item.Cariados = Cariados;
            
            item.Obstruidos = Obstruidos;
            
            item.Diente = Diente;
            
            item.C = C;
            
            item.UsaLentes = UsaLentes;
            
            item.Extraidos = Extraidos;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(decimal IdProsame,decimal IdPaciente,decimal IdEfector,decimal? IdEstablecimiento,string Prematuro,decimal? TutorDNI,string TutorNombre,string SobreEdad,string Repitente,decimal? Peso,decimal? Talla,decimal? Imc,decimal? TaMax,decimal? TaMin,decimal? PercentiloPeso,decimal? PercentiloTalla,decimal? PercentiloIMC,decimal? PercentiloMax,decimal? PercentiloMin,decimal? EFPielFanera,decimal? EFCardiovascular,decimal? EFRespiratorio,decimal? EFGenital,decimal? EFAbdomen,decimal? EFOsteoarticular,decimal? EFNeurologico,string VacunaCarne,string VacunaCompleta,string VacunaEscuela,string Estravismo,decimal? AgudezaVisualIzq,decimal? AgudezaVisualDer,string Audiometria,string Hipoacusia,string TransFonacion,string Observaciones,string OdontoHabitosPernciosos,string OdontoMaloclusion,string OdontoFluorAplicado,decimal? Cariados,decimal? Obstruidos,decimal? Diente,decimal? C,string UsaLentes,decimal? Extraidos)
	    {
		    PsmDatosOld item = new PsmDatosOld();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.IdProsame = IdProsame;
				
			item.IdPaciente = IdPaciente;
				
			item.IdEfector = IdEfector;
				
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
				
			item.VacunaEscuela = VacunaEscuela;
				
			item.Estravismo = Estravismo;
				
			item.AgudezaVisualIzq = AgudezaVisualIzq;
				
			item.AgudezaVisualDer = AgudezaVisualDer;
				
			item.Audiometria = Audiometria;
				
			item.Hipoacusia = Hipoacusia;
				
			item.TransFonacion = TransFonacion;
				
			item.Observaciones = Observaciones;
				
			item.OdontoHabitosPernciosos = OdontoHabitosPernciosos;
				
			item.OdontoMaloclusion = OdontoMaloclusion;
				
			item.OdontoFluorAplicado = OdontoFluorAplicado;
				
			item.Cariados = Cariados;
				
			item.Obstruidos = Obstruidos;
				
			item.Diente = Diente;
				
			item.C = C;
				
			item.UsaLentes = UsaLentes;
				
			item.Extraidos = Extraidos;
				
	        item.Save(UserName);
	    }
    }
}
