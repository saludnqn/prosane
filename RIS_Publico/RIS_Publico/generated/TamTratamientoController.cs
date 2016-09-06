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
    /// Controller class for TAM_Tratamientos
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class TamTratamientoController
    {
        // Preload our schema..
        TamTratamiento thisSchemaLoad = new TamTratamiento();
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
        public TamTratamientoCollection FetchAll()
        {
            TamTratamientoCollection coll = new TamTratamientoCollection();
            Query qry = new Query(TamTratamiento.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public TamTratamientoCollection FetchByID(object IdTratamiento)
        {
            TamTratamientoCollection coll = new TamTratamientoCollection().Where("idTratamiento", IdTratamiento).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public TamTratamientoCollection FetchByQuery(Query qry)
        {
            TamTratamientoCollection coll = new TamTratamientoCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object IdTratamiento)
        {
            return (TamTratamiento.Delete(IdTratamiento) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object IdTratamiento)
        {
            return (TamTratamiento.Destroy(IdTratamiento) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(int IdTam,int IdPaciente,int Edad,DateTime FechaInicio,int IdEstadio,string Grado,int IdTipoTratamiento,int IdProfesionalTratante,int IdEfectorTratante,string Observaciones,string CreatedBy,DateTime CreatedOn,string ModifiedBy,DateTime ModifiedOn,bool Activo)
	    {
		    TamTratamiento item = new TamTratamiento();
		    
            item.IdTam = IdTam;
            
            item.IdPaciente = IdPaciente;
            
            item.Edad = Edad;
            
            item.FechaInicio = FechaInicio;
            
            item.IdEstadio = IdEstadio;
            
            item.Grado = Grado;
            
            item.IdTipoTratamiento = IdTipoTratamiento;
            
            item.IdProfesionalTratante = IdProfesionalTratante;
            
            item.IdEfectorTratante = IdEfectorTratante;
            
            item.Observaciones = Observaciones;
            
            item.CreatedBy = CreatedBy;
            
            item.CreatedOn = CreatedOn;
            
            item.ModifiedBy = ModifiedBy;
            
            item.ModifiedOn = ModifiedOn;
            
            item.Activo = Activo;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int IdTratamiento,int IdTam,int IdPaciente,int Edad,DateTime FechaInicio,int IdEstadio,string Grado,int IdTipoTratamiento,int IdProfesionalTratante,int IdEfectorTratante,string Observaciones,string CreatedBy,DateTime CreatedOn,string ModifiedBy,DateTime ModifiedOn,bool Activo)
	    {
		    TamTratamiento item = new TamTratamiento();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.IdTratamiento = IdTratamiento;
				
			item.IdTam = IdTam;
				
			item.IdPaciente = IdPaciente;
				
			item.Edad = Edad;
				
			item.FechaInicio = FechaInicio;
				
			item.IdEstadio = IdEstadio;
				
			item.Grado = Grado;
				
			item.IdTipoTratamiento = IdTipoTratamiento;
				
			item.IdProfesionalTratante = IdProfesionalTratante;
				
			item.IdEfectorTratante = IdEfectorTratante;
				
			item.Observaciones = Observaciones;
				
			item.CreatedBy = CreatedBy;
				
			item.CreatedOn = CreatedOn;
				
			item.ModifiedBy = ModifiedBy;
				
			item.ModifiedOn = ModifiedOn;
				
			item.Activo = Activo;
				
	        item.Save(UserName);
	    }
    }
}
