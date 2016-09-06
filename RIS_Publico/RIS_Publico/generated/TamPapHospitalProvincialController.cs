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
    /// Controller class for TAM_PapHospitalProvincial
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class TamPapHospitalProvincialController
    {
        // Preload our schema..
        TamPapHospitalProvincial thisSchemaLoad = new TamPapHospitalProvincial();
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
        public TamPapHospitalProvincialCollection FetchAll()
        {
            TamPapHospitalProvincialCollection coll = new TamPapHospitalProvincialCollection();
            Query qry = new Query(TamPapHospitalProvincial.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public TamPapHospitalProvincialCollection FetchByID(object IdPapHP)
        {
            TamPapHospitalProvincialCollection coll = new TamPapHospitalProvincialCollection().Where("idPapHP", IdPapHP).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public TamPapHospitalProvincialCollection FetchByQuery(Query qry)
        {
            TamPapHospitalProvincialCollection coll = new TamPapHospitalProvincialCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object IdPapHP)
        {
            return (TamPapHospitalProvincial.Delete(IdPapHP) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object IdPapHP)
        {
            return (TamPapHospitalProvincial.Destroy(IdPapHP) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(DateTime? FechaIngreso,string Protocolo,string Apellido,string Nombre,int Documento,DateTime? FechaNacimiento,int Edad,string ObraSocial,string EstadoPrestacion,DateTime? FechaDiagnostico,int? IdCelulasEscamosas,string CelulasEscamosas,int? IdCelulasGlandulares,string CelulasGlandulares,string Resultado,string Codigo,int? Cantidad,int? IdEfectorOrigen,string Origen,string Zona,string Firmado,string UsuarioHP,bool Activo,string CreatedBy,DateTime? CreatedOn,string ModifiedBy,DateTime? ModifiedOn,string Observaciones,bool? PasadoSips)
	    {
		    TamPapHospitalProvincial item = new TamPapHospitalProvincial();
		    
            item.FechaIngreso = FechaIngreso;
            
            item.Protocolo = Protocolo;
            
            item.Apellido = Apellido;
            
            item.Nombre = Nombre;
            
            item.Documento = Documento;
            
            item.FechaNacimiento = FechaNacimiento;
            
            item.Edad = Edad;
            
            item.ObraSocial = ObraSocial;
            
            item.EstadoPrestacion = EstadoPrestacion;
            
            item.FechaDiagnostico = FechaDiagnostico;
            
            item.IdCelulasEscamosas = IdCelulasEscamosas;
            
            item.CelulasEscamosas = CelulasEscamosas;
            
            item.IdCelulasGlandulares = IdCelulasGlandulares;
            
            item.CelulasGlandulares = CelulasGlandulares;
            
            item.Resultado = Resultado;
            
            item.Codigo = Codigo;
            
            item.Cantidad = Cantidad;
            
            item.IdEfectorOrigen = IdEfectorOrigen;
            
            item.Origen = Origen;
            
            item.Zona = Zona;
            
            item.Firmado = Firmado;
            
            item.UsuarioHP = UsuarioHP;
            
            item.Activo = Activo;
            
            item.CreatedBy = CreatedBy;
            
            item.CreatedOn = CreatedOn;
            
            item.ModifiedBy = ModifiedBy;
            
            item.ModifiedOn = ModifiedOn;
            
            item.Observaciones = Observaciones;
            
            item.PasadoSips = PasadoSips;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int IdPapHP,DateTime? FechaIngreso,string Protocolo,string Apellido,string Nombre,int Documento,DateTime? FechaNacimiento,int Edad,string ObraSocial,string EstadoPrestacion,DateTime? FechaDiagnostico,int? IdCelulasEscamosas,string CelulasEscamosas,int? IdCelulasGlandulares,string CelulasGlandulares,string Resultado,string Codigo,int? Cantidad,int? IdEfectorOrigen,string Origen,string Zona,string Firmado,string UsuarioHP,bool Activo,string CreatedBy,DateTime? CreatedOn,string ModifiedBy,DateTime? ModifiedOn,string Observaciones,bool? PasadoSips)
	    {
		    TamPapHospitalProvincial item = new TamPapHospitalProvincial();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.IdPapHP = IdPapHP;
				
			item.FechaIngreso = FechaIngreso;
				
			item.Protocolo = Protocolo;
				
			item.Apellido = Apellido;
				
			item.Nombre = Nombre;
				
			item.Documento = Documento;
				
			item.FechaNacimiento = FechaNacimiento;
				
			item.Edad = Edad;
				
			item.ObraSocial = ObraSocial;
				
			item.EstadoPrestacion = EstadoPrestacion;
				
			item.FechaDiagnostico = FechaDiagnostico;
				
			item.IdCelulasEscamosas = IdCelulasEscamosas;
				
			item.CelulasEscamosas = CelulasEscamosas;
				
			item.IdCelulasGlandulares = IdCelulasGlandulares;
				
			item.CelulasGlandulares = CelulasGlandulares;
				
			item.Resultado = Resultado;
				
			item.Codigo = Codigo;
				
			item.Cantidad = Cantidad;
				
			item.IdEfectorOrigen = IdEfectorOrigen;
				
			item.Origen = Origen;
				
			item.Zona = Zona;
				
			item.Firmado = Firmado;
				
			item.UsuarioHP = UsuarioHP;
				
			item.Activo = Activo;
				
			item.CreatedBy = CreatedBy;
				
			item.CreatedOn = CreatedOn;
				
			item.ModifiedBy = ModifiedBy;
				
			item.ModifiedOn = ModifiedOn;
				
			item.Observaciones = Observaciones;
				
			item.PasadoSips = PasadoSips;
				
	        item.Save(UserName);
	    }
    }
}
