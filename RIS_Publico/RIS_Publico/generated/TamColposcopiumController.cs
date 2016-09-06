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
    /// Controller class for TAM_Colposcopia
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class TamColposcopiumController
    {
        // Preload our schema..
        TamColposcopium thisSchemaLoad = new TamColposcopium();
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
        public TamColposcopiumCollection FetchAll()
        {
            TamColposcopiumCollection coll = new TamColposcopiumCollection();
            Query qry = new Query(TamColposcopium.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public TamColposcopiumCollection FetchByID(object IdColposcopia)
        {
            TamColposcopiumCollection coll = new TamColposcopiumCollection().Where("idColposcopia", IdColposcopia).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public TamColposcopiumCollection FetchByQuery(Query qry)
        {
            TamColposcopiumCollection coll = new TamColposcopiumCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object IdColposcopia)
        {
            return (TamColposcopium.Delete(IdColposcopia) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object IdColposcopia)
        {
            return (TamColposcopium.Destroy(IdColposcopia) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(int IdTam,int IdPaciente,int Edad,DateTime FechaRealizacion,int EvaluacionGeneral,string Procedimiento,int IdProfesionalExamen,int IdEfectorExamen,string Observaciones,string CreatedBy,DateTime CreatedOn,string ModifiedBy,DateTime ModifiedOn,bool Activo,int ZonaTransformacion,int IdHallazgosColposcopicos,int TomoBiopsia,int Ecc,string TestSchiller)
	    {
		    TamColposcopium item = new TamColposcopium();
		    
            item.IdTam = IdTam;
            
            item.IdPaciente = IdPaciente;
            
            item.Edad = Edad;
            
            item.FechaRealizacion = FechaRealizacion;
            
            item.EvaluacionGeneral = EvaluacionGeneral;
            
            item.Procedimiento = Procedimiento;
            
            item.IdProfesionalExamen = IdProfesionalExamen;
            
            item.IdEfectorExamen = IdEfectorExamen;
            
            item.Observaciones = Observaciones;
            
            item.CreatedBy = CreatedBy;
            
            item.CreatedOn = CreatedOn;
            
            item.ModifiedBy = ModifiedBy;
            
            item.ModifiedOn = ModifiedOn;
            
            item.Activo = Activo;
            
            item.ZonaTransformacion = ZonaTransformacion;
            
            item.IdHallazgosColposcopicos = IdHallazgosColposcopicos;
            
            item.TomoBiopsia = TomoBiopsia;
            
            item.Ecc = Ecc;
            
            item.TestSchiller = TestSchiller;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int IdColposcopia,int IdTam,int IdPaciente,int Edad,DateTime FechaRealizacion,int EvaluacionGeneral,string Procedimiento,int IdProfesionalExamen,int IdEfectorExamen,string Observaciones,string CreatedBy,DateTime CreatedOn,string ModifiedBy,DateTime ModifiedOn,bool Activo,int ZonaTransformacion,int IdHallazgosColposcopicos,int TomoBiopsia,int Ecc,string TestSchiller)
	    {
		    TamColposcopium item = new TamColposcopium();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.IdColposcopia = IdColposcopia;
				
			item.IdTam = IdTam;
				
			item.IdPaciente = IdPaciente;
				
			item.Edad = Edad;
				
			item.FechaRealizacion = FechaRealizacion;
				
			item.EvaluacionGeneral = EvaluacionGeneral;
				
			item.Procedimiento = Procedimiento;
				
			item.IdProfesionalExamen = IdProfesionalExamen;
				
			item.IdEfectorExamen = IdEfectorExamen;
				
			item.Observaciones = Observaciones;
				
			item.CreatedBy = CreatedBy;
				
			item.CreatedOn = CreatedOn;
				
			item.ModifiedBy = ModifiedBy;
				
			item.ModifiedOn = ModifiedOn;
				
			item.Activo = Activo;
				
			item.ZonaTransformacion = ZonaTransformacion;
				
			item.IdHallazgosColposcopicos = IdHallazgosColposcopicos;
				
			item.TomoBiopsia = TomoBiopsia;
				
			item.Ecc = Ecc;
				
			item.TestSchiller = TestSchiller;
				
	        item.Save(UserName);
	    }
    }
}
