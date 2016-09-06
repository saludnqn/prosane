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
    /// Controller class for TAM_Registro
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class TamRegistroController
    {
        // Preload our schema..
        TamRegistro thisSchemaLoad = new TamRegistro();
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
        public TamRegistroCollection FetchAll()
        {
            TamRegistroCollection coll = new TamRegistroCollection();
            Query qry = new Query(TamRegistro.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public TamRegistroCollection FetchByID(object IdTam)
        {
            TamRegistroCollection coll = new TamRegistroCollection().Where("idTam", IdTam).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public TamRegistroCollection FetchByQuery(Query qry)
        {
            TamRegistroCollection coll = new TamRegistroCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object IdTam)
        {
            return (TamRegistro.Delete(IdTam) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object IdTam)
        {
            return (TamRegistro.Destroy(IdTam) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(int IdPaciente,int IdEfectorReferencia,int NumeroFicha,int Edad,string Observaciones,string CreatedBy,DateTime CreatedOn,string ModifiedBy,DateTime ModifiedOn,bool Activo)
	    {
		    TamRegistro item = new TamRegistro();
		    
            item.IdPaciente = IdPaciente;
            
            item.IdEfectorReferencia = IdEfectorReferencia;
            
            item.NumeroFicha = NumeroFicha;
            
            item.Edad = Edad;
            
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
	    public void Update(int IdTam,int IdPaciente,int IdEfectorReferencia,int NumeroFicha,int Edad,string Observaciones,string CreatedBy,DateTime CreatedOn,string ModifiedBy,DateTime ModifiedOn,bool Activo)
	    {
		    TamRegistro item = new TamRegistro();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.IdTam = IdTam;
				
			item.IdPaciente = IdPaciente;
				
			item.IdEfectorReferencia = IdEfectorReferencia;
				
			item.NumeroFicha = NumeroFicha;
				
			item.Edad = Edad;
				
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
