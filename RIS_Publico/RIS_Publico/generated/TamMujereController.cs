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
    /// Controller class for TAM_Mujeres
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class TamMujereController
    {
        // Preload our schema..
        TamMujere thisSchemaLoad = new TamMujere();
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
        public TamMujereCollection FetchAll()
        {
            TamMujereCollection coll = new TamMujereCollection();
            Query qry = new Query(TamMujere.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public TamMujereCollection FetchByID(object IdMujeres)
        {
            TamMujereCollection coll = new TamMujereCollection().Where("idMujeres", IdMujeres).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public TamMujereCollection FetchByQuery(Query qry)
        {
            TamMujereCollection coll = new TamMujereCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object IdMujeres)
        {
            return (TamMujere.Delete(IdMujeres) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object IdMujeres)
        {
            return (TamMujere.Destroy(IdMujeres) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string NumHc,string Apellido,string Nombres,string FechaNacimiento,int? Edad,int? IdTipoDoc,int? NumeroDocumento,string Telefono,string Domicilio,string Barrio,int? IdProvincia,int? IdDepartamento,int? IdLocalidad,string Cp,int? IdCentro,string Observaciones,int? ZonaSalud,int? IdMujerExporta,string FechaAlta)
	    {
		    TamMujere item = new TamMujere();
		    
            item.NumHc = NumHc;
            
            item.Apellido = Apellido;
            
            item.Nombres = Nombres;
            
            item.FechaNacimiento = FechaNacimiento;
            
            item.Edad = Edad;
            
            item.IdTipoDoc = IdTipoDoc;
            
            item.NumeroDocumento = NumeroDocumento;
            
            item.Telefono = Telefono;
            
            item.Domicilio = Domicilio;
            
            item.Barrio = Barrio;
            
            item.IdProvincia = IdProvincia;
            
            item.IdDepartamento = IdDepartamento;
            
            item.IdLocalidad = IdLocalidad;
            
            item.Cp = Cp;
            
            item.IdCentro = IdCentro;
            
            item.Observaciones = Observaciones;
            
            item.ZonaSalud = ZonaSalud;
            
            item.IdMujerExporta = IdMujerExporta;
            
            item.FechaAlta = FechaAlta;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int IdMujeres,string NumHc,string Apellido,string Nombres,string FechaNacimiento,int? Edad,int? IdTipoDoc,int? NumeroDocumento,string Telefono,string Domicilio,string Barrio,int? IdProvincia,int? IdDepartamento,int? IdLocalidad,string Cp,int? IdCentro,string Observaciones,int? ZonaSalud,int? IdMujerExporta,string FechaAlta)
	    {
		    TamMujere item = new TamMujere();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.IdMujeres = IdMujeres;
				
			item.NumHc = NumHc;
				
			item.Apellido = Apellido;
				
			item.Nombres = Nombres;
				
			item.FechaNacimiento = FechaNacimiento;
				
			item.Edad = Edad;
				
			item.IdTipoDoc = IdTipoDoc;
				
			item.NumeroDocumento = NumeroDocumento;
				
			item.Telefono = Telefono;
				
			item.Domicilio = Domicilio;
				
			item.Barrio = Barrio;
				
			item.IdProvincia = IdProvincia;
				
			item.IdDepartamento = IdDepartamento;
				
			item.IdLocalidad = IdLocalidad;
				
			item.Cp = Cp;
				
			item.IdCentro = IdCentro;
				
			item.Observaciones = Observaciones;
				
			item.ZonaSalud = ZonaSalud;
				
			item.IdMujerExporta = IdMujerExporta;
				
			item.FechaAlta = FechaAlta;
				
	        item.Save(UserName);
	    }
    }
}
