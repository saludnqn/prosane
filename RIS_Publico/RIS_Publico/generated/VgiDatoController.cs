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
    /// Controller class for VGI_Datos
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class VgiDatoController
    {
        // Preload our schema..
        VgiDato thisSchemaLoad = new VgiDato();
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
        public VgiDatoCollection FetchAll()
        {
            VgiDatoCollection coll = new VgiDatoCollection();
            Query qry = new Query(VgiDato.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public VgiDatoCollection FetchByID(object IdVGIDato)
        {
            VgiDatoCollection coll = new VgiDatoCollection().Where("idVGIDato", IdVGIDato).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public VgiDatoCollection FetchByQuery(Query qry)
        {
            VgiDatoCollection coll = new VgiDatoCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object IdVGIDato)
        {
            return (VgiDato.Delete(IdVGIDato) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object IdVGIDato)
        {
            return (VgiDato.Destroy(IdVGIDato) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(int? IdPaciente,int? IdTurno,DateTime? Fecha,string Vivienda,decimal? AñosEscolaridad,string TrabajoPrevio,string Ingresos,int? CentroAsistencia,string FamiliarACargo,string Vinculo,int? IdMedicoCabecera,string Contacto,int? TotalClinico,int? TotalRCVG,int? TotalABVD,int? TotalAIVD,int? TotalSocial,int? TotalMental,DateTime? ProximaEvaluacion,int? IdUsuarioCarga,DateTime? FechaCarga,string VisionAlteracion,string AudicionAlteracion,string Medicacion)
	    {
		    VgiDato item = new VgiDato();
		    
            item.IdPaciente = IdPaciente;
            
            item.IdTurno = IdTurno;
            
            item.Fecha = Fecha;
            
            item.Vivienda = Vivienda;
            
            item.AñosEscolaridad = AñosEscolaridad;
            
            item.TrabajoPrevio = TrabajoPrevio;
            
            item.Ingresos = Ingresos;
            
            item.CentroAsistencia = CentroAsistencia;
            
            item.FamiliarACargo = FamiliarACargo;
            
            item.Vinculo = Vinculo;
            
            item.IdMedicoCabecera = IdMedicoCabecera;
            
            item.Contacto = Contacto;
            
            item.TotalClinico = TotalClinico;
            
            item.TotalRCVG = TotalRCVG;
            
            item.TotalABVD = TotalABVD;
            
            item.TotalAIVD = TotalAIVD;
            
            item.TotalSocial = TotalSocial;
            
            item.TotalMental = TotalMental;
            
            item.ProximaEvaluacion = ProximaEvaluacion;
            
            item.IdUsuarioCarga = IdUsuarioCarga;
            
            item.FechaCarga = FechaCarga;
            
            item.VisionAlteracion = VisionAlteracion;
            
            item.AudicionAlteracion = AudicionAlteracion;
            
            item.Medicacion = Medicacion;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int IdVGIDato,int? IdPaciente,int? IdTurno,DateTime? Fecha,string Vivienda,decimal? AñosEscolaridad,string TrabajoPrevio,string Ingresos,int? CentroAsistencia,string FamiliarACargo,string Vinculo,int? IdMedicoCabecera,string Contacto,int? TotalClinico,int? TotalRCVG,int? TotalABVD,int? TotalAIVD,int? TotalSocial,int? TotalMental,DateTime? ProximaEvaluacion,int? IdUsuarioCarga,DateTime? FechaCarga,string VisionAlteracion,string AudicionAlteracion,string Medicacion)
	    {
		    VgiDato item = new VgiDato();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.IdVGIDato = IdVGIDato;
				
			item.IdPaciente = IdPaciente;
				
			item.IdTurno = IdTurno;
				
			item.Fecha = Fecha;
				
			item.Vivienda = Vivienda;
				
			item.AñosEscolaridad = AñosEscolaridad;
				
			item.TrabajoPrevio = TrabajoPrevio;
				
			item.Ingresos = Ingresos;
				
			item.CentroAsistencia = CentroAsistencia;
				
			item.FamiliarACargo = FamiliarACargo;
				
			item.Vinculo = Vinculo;
				
			item.IdMedicoCabecera = IdMedicoCabecera;
				
			item.Contacto = Contacto;
				
			item.TotalClinico = TotalClinico;
				
			item.TotalRCVG = TotalRCVG;
				
			item.TotalABVD = TotalABVD;
				
			item.TotalAIVD = TotalAIVD;
				
			item.TotalSocial = TotalSocial;
				
			item.TotalMental = TotalMental;
				
			item.ProximaEvaluacion = ProximaEvaluacion;
				
			item.IdUsuarioCarga = IdUsuarioCarga;
				
			item.FechaCarga = FechaCarga;
				
			item.VisionAlteracion = VisionAlteracion;
				
			item.AudicionAlteracion = AudicionAlteracion;
				
			item.Medicacion = Medicacion;
				
	        item.Save(UserName);
	    }
    }
}
