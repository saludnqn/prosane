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
    /// Controller class for Hid_Hidatidosis
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class HidHidatidosiController
    {
        // Preload our schema..
        HidHidatidosi thisSchemaLoad = new HidHidatidosi();
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
        public HidHidatidosiCollection FetchAll()
        {
            HidHidatidosiCollection coll = new HidHidatidosiCollection();
            Query qry = new Query(HidHidatidosi.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public HidHidatidosiCollection FetchByID(object IdHidatidosis)
        {
            HidHidatidosiCollection coll = new HidHidatidosiCollection().Where("idHidatidosis", IdHidatidosis).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public HidHidatidosiCollection FetchByQuery(Query qry)
        {
            HidHidatidosiCollection coll = new HidHidatidosiCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object IdHidatidosis)
        {
            return (HidHidatidosi.Delete(IdHidatidosis) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object IdHidatidosis)
        {
            return (HidHidatidosi.Destroy(IdHidatidosis) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(int IdEstablecimiento,string Docente,string NombrePaciente,string ApellidoPaciente,string DniPaciente,DateTime? FechaNacimiento,string DomicilioPaciente,string TelefonoPaciente,string Observaciones,string NombrePadre,string ApellidoPadre,string DniPadre,string ResultadoRastreo,string Profesional,DateTime FechaAlta,bool DadoDeBaja,int? IdUsuario,int? IdUsuarioBaja,DateTime? FechaEcografia)
	    {
		    HidHidatidosi item = new HidHidatidosi();
		    
            item.IdEstablecimiento = IdEstablecimiento;
            
            item.Docente = Docente;
            
            item.NombrePaciente = NombrePaciente;
            
            item.ApellidoPaciente = ApellidoPaciente;
            
            item.DniPaciente = DniPaciente;
            
            item.FechaNacimiento = FechaNacimiento;
            
            item.DomicilioPaciente = DomicilioPaciente;
            
            item.TelefonoPaciente = TelefonoPaciente;
            
            item.Observaciones = Observaciones;
            
            item.NombrePadre = NombrePadre;
            
            item.ApellidoPadre = ApellidoPadre;
            
            item.DniPadre = DniPadre;
            
            item.ResultadoRastreo = ResultadoRastreo;
            
            item.Profesional = Profesional;
            
            item.FechaAlta = FechaAlta;
            
            item.DadoDeBaja = DadoDeBaja;
            
            item.IdUsuario = IdUsuario;
            
            item.IdUsuarioBaja = IdUsuarioBaja;
            
            item.FechaEcografia = FechaEcografia;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int IdHidatidosis,int IdEstablecimiento,string Docente,string NombrePaciente,string ApellidoPaciente,string DniPaciente,DateTime? FechaNacimiento,string DomicilioPaciente,string TelefonoPaciente,string Observaciones,string NombrePadre,string ApellidoPadre,string DniPadre,string ResultadoRastreo,string Profesional,DateTime FechaAlta,bool DadoDeBaja,int? IdUsuario,int? IdUsuarioBaja,DateTime? FechaEcografia)
	    {
		    HidHidatidosi item = new HidHidatidosi();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.IdHidatidosis = IdHidatidosis;
				
			item.IdEstablecimiento = IdEstablecimiento;
				
			item.Docente = Docente;
				
			item.NombrePaciente = NombrePaciente;
				
			item.ApellidoPaciente = ApellidoPaciente;
				
			item.DniPaciente = DniPaciente;
				
			item.FechaNacimiento = FechaNacimiento;
				
			item.DomicilioPaciente = DomicilioPaciente;
				
			item.TelefonoPaciente = TelefonoPaciente;
				
			item.Observaciones = Observaciones;
				
			item.NombrePadre = NombrePadre;
				
			item.ApellidoPadre = ApellidoPadre;
				
			item.DniPadre = DniPadre;
				
			item.ResultadoRastreo = ResultadoRastreo;
				
			item.Profesional = Profesional;
				
			item.FechaAlta = FechaAlta;
				
			item.DadoDeBaja = DadoDeBaja;
				
			item.IdUsuario = IdUsuario;
				
			item.IdUsuarioBaja = IdUsuarioBaja;
				
			item.FechaEcografia = FechaEcografia;
				
	        item.Save(UserName);
	    }
    }
}
