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
    /// Controller class for TAM_Biopsia
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class TamBiopsiumController
    {
        // Preload our schema..
        TamBiopsium thisSchemaLoad = new TamBiopsium();
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
        public TamBiopsiumCollection FetchAll()
        {
            TamBiopsiumCollection coll = new TamBiopsiumCollection();
            Query qry = new Query(TamBiopsium.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public TamBiopsiumCollection FetchByID(object IdBiopsia)
        {
            TamBiopsiumCollection coll = new TamBiopsiumCollection().Where("idBiopsia", IdBiopsia).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public TamBiopsiumCollection FetchByQuery(Query qry)
        {
            TamBiopsiumCollection coll = new TamBiopsiumCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object IdBiopsia)
        {
            return (TamBiopsium.Delete(IdBiopsia) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object IdBiopsia)
        {
            return (TamBiopsium.Destroy(IdBiopsia) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(int IdTam,int IdPaciente,int Edad,DateTime FechaRealizacion,string Origen,int IdProfesionalMuestra,int IdEfectorMuestra,DateTime FechaRecepcion,DateTime FechaInforme,int NumeroIngreso,int IdProfesionalPatologo,int IdEfectorResultado,string Macroscopia,string Microscopia,int IdDiagnostico,string DiagnosticoAdicional,string Observaciones,string CreatedBy,DateTime CreatedOn,string ModifiedBy,DateTime ModifiedOn,int IdTipoMaterial,bool Activo)
	    {
		    TamBiopsium item = new TamBiopsium();
		    
            item.IdTam = IdTam;
            
            item.IdPaciente = IdPaciente;
            
            item.Edad = Edad;
            
            item.FechaRealizacion = FechaRealizacion;
            
            item.Origen = Origen;
            
            item.IdProfesionalMuestra = IdProfesionalMuestra;
            
            item.IdEfectorMuestra = IdEfectorMuestra;
            
            item.FechaRecepcion = FechaRecepcion;
            
            item.FechaInforme = FechaInforme;
            
            item.NumeroIngreso = NumeroIngreso;
            
            item.IdProfesionalPatologo = IdProfesionalPatologo;
            
            item.IdEfectorResultado = IdEfectorResultado;
            
            item.Macroscopia = Macroscopia;
            
            item.Microscopia = Microscopia;
            
            item.IdDiagnostico = IdDiagnostico;
            
            item.DiagnosticoAdicional = DiagnosticoAdicional;
            
            item.Observaciones = Observaciones;
            
            item.CreatedBy = CreatedBy;
            
            item.CreatedOn = CreatedOn;
            
            item.ModifiedBy = ModifiedBy;
            
            item.ModifiedOn = ModifiedOn;
            
            item.IdTipoMaterial = IdTipoMaterial;
            
            item.Activo = Activo;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int IdBiopsia,int IdTam,int IdPaciente,int Edad,DateTime FechaRealizacion,string Origen,int IdProfesionalMuestra,int IdEfectorMuestra,DateTime FechaRecepcion,DateTime FechaInforme,int NumeroIngreso,int IdProfesionalPatologo,int IdEfectorResultado,string Macroscopia,string Microscopia,int IdDiagnostico,string DiagnosticoAdicional,string Observaciones,string CreatedBy,DateTime CreatedOn,string ModifiedBy,DateTime ModifiedOn,int IdTipoMaterial,bool Activo)
	    {
		    TamBiopsium item = new TamBiopsium();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.IdBiopsia = IdBiopsia;
				
			item.IdTam = IdTam;
				
			item.IdPaciente = IdPaciente;
				
			item.Edad = Edad;
				
			item.FechaRealizacion = FechaRealizacion;
				
			item.Origen = Origen;
				
			item.IdProfesionalMuestra = IdProfesionalMuestra;
				
			item.IdEfectorMuestra = IdEfectorMuestra;
				
			item.FechaRecepcion = FechaRecepcion;
				
			item.FechaInforme = FechaInforme;
				
			item.NumeroIngreso = NumeroIngreso;
				
			item.IdProfesionalPatologo = IdProfesionalPatologo;
				
			item.IdEfectorResultado = IdEfectorResultado;
				
			item.Macroscopia = Macroscopia;
				
			item.Microscopia = Microscopia;
				
			item.IdDiagnostico = IdDiagnostico;
				
			item.DiagnosticoAdicional = DiagnosticoAdicional;
				
			item.Observaciones = Observaciones;
				
			item.CreatedBy = CreatedBy;
				
			item.CreatedOn = CreatedOn;
				
			item.ModifiedBy = ModifiedBy;
				
			item.ModifiedOn = ModifiedOn;
				
			item.IdTipoMaterial = IdTipoMaterial;
				
			item.Activo = Activo;
				
	        item.Save(UserName);
	    }
    }
}
