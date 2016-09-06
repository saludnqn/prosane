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
    /// Controller class for TAM_Pap
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class TamPapController
    {
        // Preload our schema..
        TamPap thisSchemaLoad = new TamPap();
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
        public TamPapCollection FetchAll()
        {
            TamPapCollection coll = new TamPapCollection();
            Query qry = new Query(TamPap.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public TamPapCollection FetchByID(object IdPap)
        {
            TamPapCollection coll = new TamPapCollection().Where("idPap", IdPap).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public TamPapCollection FetchByQuery(Query qry)
        {
            TamPapCollection coll = new TamPapCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object IdPap)
        {
            return (TamPap.Delete(IdPap) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object IdPap)
        {
            return (TamPap.Destroy(IdPap) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(int IdTam,int IdPaciente,int Edad,DateTime Fecha,bool CervixSatisfactorio,bool TratHormonalReemplazo,int IdTipoCirugia,bool TratRadiante,int IdMetodoAnticonceptvo,bool Quimioterapia,int Paridad,bool ParidadInformacion,DateTime FechaFum,bool Menopausia,bool EmbarazoActual,bool Lactancia,int IdTipoPapPrevio,int IdTipoResultado,int IdTipoMuestra,DateTime FechaMuestra,int IdProfesionalMuestra,int IdEfectorMuestra,DateTime FechaRecepcion,string IngresoLetra,int IngresoNro,int IngresoNro2,int IdEfectorLaboratorio,DateTime FechaInforme,int IdProfesionalInforma,int IdCalidadMuestra,int IdCelulasEscamosas,int IdCelulasGLandulares,int IdOtrosHallazgos,int IdObservacionPap,int IdMicrorganismo,string Observaciones,bool Entregado,DateTime FechaEntrega,string CreatedBy,DateTime CreatedOn,string ModifiedBy,DateTime ModifiedOn,int IdTipoTratamientoLocal,string NumeroProtocolo,bool Activo)
	    {
		    TamPap item = new TamPap();
		    
            item.IdTam = IdTam;
            
            item.IdPaciente = IdPaciente;
            
            item.Edad = Edad;
            
            item.Fecha = Fecha;
            
            item.CervixSatisfactorio = CervixSatisfactorio;
            
            item.TratHormonalReemplazo = TratHormonalReemplazo;
            
            item.IdTipoCirugia = IdTipoCirugia;
            
            item.TratRadiante = TratRadiante;
            
            item.IdMetodoAnticonceptvo = IdMetodoAnticonceptvo;
            
            item.Quimioterapia = Quimioterapia;
            
            item.Paridad = Paridad;
            
            item.ParidadInformacion = ParidadInformacion;
            
            item.FechaFum = FechaFum;
            
            item.Menopausia = Menopausia;
            
            item.EmbarazoActual = EmbarazoActual;
            
            item.Lactancia = Lactancia;
            
            item.IdTipoPapPrevio = IdTipoPapPrevio;
            
            item.IdTipoResultado = IdTipoResultado;
            
            item.IdTipoMuestra = IdTipoMuestra;
            
            item.FechaMuestra = FechaMuestra;
            
            item.IdProfesionalMuestra = IdProfesionalMuestra;
            
            item.IdEfectorMuestra = IdEfectorMuestra;
            
            item.FechaRecepcion = FechaRecepcion;
            
            item.IngresoLetra = IngresoLetra;
            
            item.IngresoNro = IngresoNro;
            
            item.IngresoNro2 = IngresoNro2;
            
            item.IdEfectorLaboratorio = IdEfectorLaboratorio;
            
            item.FechaInforme = FechaInforme;
            
            item.IdProfesionalInforma = IdProfesionalInforma;
            
            item.IdCalidadMuestra = IdCalidadMuestra;
            
            item.IdCelulasEscamosas = IdCelulasEscamosas;
            
            item.IdCelulasGLandulares = IdCelulasGLandulares;
            
            item.IdOtrosHallazgos = IdOtrosHallazgos;
            
            item.IdObservacionPap = IdObservacionPap;
            
            item.IdMicrorganismo = IdMicrorganismo;
            
            item.Observaciones = Observaciones;
            
            item.Entregado = Entregado;
            
            item.FechaEntrega = FechaEntrega;
            
            item.CreatedBy = CreatedBy;
            
            item.CreatedOn = CreatedOn;
            
            item.ModifiedBy = ModifiedBy;
            
            item.ModifiedOn = ModifiedOn;
            
            item.IdTipoTratamientoLocal = IdTipoTratamientoLocal;
            
            item.NumeroProtocolo = NumeroProtocolo;
            
            item.Activo = Activo;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int IdPap,int IdTam,int IdPaciente,int Edad,DateTime Fecha,bool CervixSatisfactorio,bool TratHormonalReemplazo,int IdTipoCirugia,bool TratRadiante,int IdMetodoAnticonceptvo,bool Quimioterapia,int Paridad,bool ParidadInformacion,DateTime FechaFum,bool Menopausia,bool EmbarazoActual,bool Lactancia,int IdTipoPapPrevio,int IdTipoResultado,int IdTipoMuestra,DateTime FechaMuestra,int IdProfesionalMuestra,int IdEfectorMuestra,DateTime FechaRecepcion,string IngresoLetra,int IngresoNro,int IngresoNro2,int IdEfectorLaboratorio,DateTime FechaInforme,int IdProfesionalInforma,int IdCalidadMuestra,int IdCelulasEscamosas,int IdCelulasGLandulares,int IdOtrosHallazgos,int IdObservacionPap,int IdMicrorganismo,string Observaciones,bool Entregado,DateTime FechaEntrega,string CreatedBy,DateTime CreatedOn,string ModifiedBy,DateTime ModifiedOn,int IdTipoTratamientoLocal,string NumeroProtocolo,bool Activo)
	    {
		    TamPap item = new TamPap();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.IdPap = IdPap;
				
			item.IdTam = IdTam;
				
			item.IdPaciente = IdPaciente;
				
			item.Edad = Edad;
				
			item.Fecha = Fecha;
				
			item.CervixSatisfactorio = CervixSatisfactorio;
				
			item.TratHormonalReemplazo = TratHormonalReemplazo;
				
			item.IdTipoCirugia = IdTipoCirugia;
				
			item.TratRadiante = TratRadiante;
				
			item.IdMetodoAnticonceptvo = IdMetodoAnticonceptvo;
				
			item.Quimioterapia = Quimioterapia;
				
			item.Paridad = Paridad;
				
			item.ParidadInformacion = ParidadInformacion;
				
			item.FechaFum = FechaFum;
				
			item.Menopausia = Menopausia;
				
			item.EmbarazoActual = EmbarazoActual;
				
			item.Lactancia = Lactancia;
				
			item.IdTipoPapPrevio = IdTipoPapPrevio;
				
			item.IdTipoResultado = IdTipoResultado;
				
			item.IdTipoMuestra = IdTipoMuestra;
				
			item.FechaMuestra = FechaMuestra;
				
			item.IdProfesionalMuestra = IdProfesionalMuestra;
				
			item.IdEfectorMuestra = IdEfectorMuestra;
				
			item.FechaRecepcion = FechaRecepcion;
				
			item.IngresoLetra = IngresoLetra;
				
			item.IngresoNro = IngresoNro;
				
			item.IngresoNro2 = IngresoNro2;
				
			item.IdEfectorLaboratorio = IdEfectorLaboratorio;
				
			item.FechaInforme = FechaInforme;
				
			item.IdProfesionalInforma = IdProfesionalInforma;
				
			item.IdCalidadMuestra = IdCalidadMuestra;
				
			item.IdCelulasEscamosas = IdCelulasEscamosas;
				
			item.IdCelulasGLandulares = IdCelulasGLandulares;
				
			item.IdOtrosHallazgos = IdOtrosHallazgos;
				
			item.IdObservacionPap = IdObservacionPap;
				
			item.IdMicrorganismo = IdMicrorganismo;
				
			item.Observaciones = Observaciones;
				
			item.Entregado = Entregado;
				
			item.FechaEntrega = FechaEntrega;
				
			item.CreatedBy = CreatedBy;
				
			item.CreatedOn = CreatedOn;
				
			item.ModifiedBy = ModifiedBy;
				
			item.ModifiedOn = ModifiedOn;
				
			item.IdTipoTratamientoLocal = IdTipoTratamientoLocal;
				
			item.NumeroProtocolo = NumeroProtocolo;
				
			item.Activo = Activo;
				
	        item.Save(UserName);
	    }
    }
}
