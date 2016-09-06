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
    /// Controller class for TAM_PAPM
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class TamPapmController
    {
        // Preload our schema..
        TamPapm thisSchemaLoad = new TamPapm();
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
        public TamPapmCollection FetchAll()
        {
            TamPapmCollection coll = new TamPapmCollection();
            Query qry = new Query(TamPapm.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public TamPapmCollection FetchByID(object IdPaps)
        {
            TamPapmCollection coll = new TamPapmCollection().Where("idPaps", IdPaps).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public TamPapmCollection FetchByQuery(Query qry)
        {
            TamPapmCollection coll = new TamPapmCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object IdPaps)
        {
            return (TamPapm.Delete(IdPaps) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object IdPaps)
        {
            return (TamPapm.Destroy(IdPaps) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(int? IdTipoPapPrevio,int? IdResultadoPapPrevio,int? IdCitologo,int? IdMedicoSol,int? IdTipoMuestra,string FechaMuestra,int? IdCentroMuestra,string FechaInforme,int? IdCalidadMuestra,int? IdMicroorganismo,int? IdOtrosHallazgos,int? IdCelulasEscamosas,int? IdCelulasGlandulares,int? IdObservacion,string FechaRecepcion,string Observaciones,int? IdCentro,int? IdMujerExporta,string NumeroLaboratorio,string FechaEntrega,string CervixSatisfactorio,string TratHormonal,string TratRadiante,string Quimioterapia,string TratDestructivo,string Embarazada,string FechaFum,int? Paridad,int? IdAnticonceptivo,int? IdCirugia,string Menopausia,string Lactancia,string FechaPrevio,int? IdPaps)
	    {
		    TamPapm item = new TamPapm();
		    
            item.IdTipoPapPrevio = IdTipoPapPrevio;
            
            item.IdResultadoPapPrevio = IdResultadoPapPrevio;
            
            item.IdCitologo = IdCitologo;
            
            item.IdMedicoSol = IdMedicoSol;
            
            item.IdTipoMuestra = IdTipoMuestra;
            
            item.FechaMuestra = FechaMuestra;
            
            item.IdCentroMuestra = IdCentroMuestra;
            
            item.FechaInforme = FechaInforme;
            
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
            
            item.Quimioterapia = Quimioterapia;
            
            item.TratDestructivo = TratDestructivo;
            
            item.Embarazada = Embarazada;
            
            item.FechaFum = FechaFum;
            
            item.Paridad = Paridad;
            
            item.IdAnticonceptivo = IdAnticonceptivo;
            
            item.IdCirugia = IdCirugia;
            
            item.Menopausia = Menopausia;
            
            item.Lactancia = Lactancia;
            
            item.FechaPrevio = FechaPrevio;
            
            item.IdPaps = IdPaps;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int IdPaps,int? IdTipoPapPrevio,int? IdResultadoPapPrevio,int? IdCitologo,int? IdMedicoSol,int? IdTipoMuestra,string FechaMuestra,int? IdCentroMuestra,string FechaInforme,int? IdCalidadMuestra,int? IdMicroorganismo,int? IdOtrosHallazgos,int? IdCelulasEscamosas,int? IdCelulasGlandulares,int? IdObservacion,string FechaRecepcion,string Observaciones,int? IdCentro,int? IdMujerExporta,string NumeroLaboratorio,string FechaEntrega,string CervixSatisfactorio,string TratHormonal,string TratRadiante,string Quimioterapia,string TratDestructivo,string Embarazada,string FechaFum,int? Paridad,int? IdAnticonceptivo,int? IdCirugia,string Menopausia,string Lactancia,string FechaPrevio,int? IdPaps)
	    {
		    TamPapm item = new TamPapm();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.IdPaps = IdPaps;
				
			item.IdTipoPapPrevio = IdTipoPapPrevio;
				
			item.IdResultadoPapPrevio = IdResultadoPapPrevio;
				
			item.IdCitologo = IdCitologo;
				
			item.IdMedicoSol = IdMedicoSol;
				
			item.IdTipoMuestra = IdTipoMuestra;
				
			item.FechaMuestra = FechaMuestra;
				
			item.IdCentroMuestra = IdCentroMuestra;
				
			item.FechaInforme = FechaInforme;
				
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
				
			item.Quimioterapia = Quimioterapia;
				
			item.TratDestructivo = TratDestructivo;
				
			item.Embarazada = Embarazada;
				
			item.FechaFum = FechaFum;
				
			item.Paridad = Paridad;
				
			item.IdAnticonceptivo = IdAnticonceptivo;
				
			item.IdCirugia = IdCirugia;
				
			item.Menopausia = Menopausia;
				
			item.Lactancia = Lactancia;
				
			item.FechaPrevio = FechaPrevio;
				
			item.IdPaps = IdPaps;
				
	        item.Save(UserName);
	    }
    }
}
