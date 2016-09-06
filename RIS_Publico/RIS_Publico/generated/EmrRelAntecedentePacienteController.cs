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
    /// Controller class for EMR_RelAntecedentePaciente
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class EmrRelAntecedentePacienteController
    {
        // Preload our schema..
        EmrRelAntecedentePaciente thisSchemaLoad = new EmrRelAntecedentePaciente();
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
        public EmrRelAntecedentePacienteCollection FetchAll()
        {
            EmrRelAntecedentePacienteCollection coll = new EmrRelAntecedentePacienteCollection();
            Query qry = new Query(EmrRelAntecedentePaciente.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public EmrRelAntecedentePacienteCollection FetchByID(object IdRelAntecedentePaciente)
        {
            EmrRelAntecedentePacienteCollection coll = new EmrRelAntecedentePacienteCollection().Where("idRelAntecedentePaciente", IdRelAntecedentePaciente).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public EmrRelAntecedentePacienteCollection FetchByQuery(Query qry)
        {
            EmrRelAntecedentePacienteCollection coll = new EmrRelAntecedentePacienteCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object IdRelAntecedentePaciente)
        {
            return (EmrRelAntecedentePaciente.Delete(IdRelAntecedentePaciente) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object IdRelAntecedentePaciente)
        {
            return (EmrRelAntecedentePaciente.Destroy(IdRelAntecedentePaciente) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(int? IdAntecedente,int? IdPaciente,int? IdHCPrehospitalaria)
	    {
		    EmrRelAntecedentePaciente item = new EmrRelAntecedentePaciente();
		    
            item.IdAntecedente = IdAntecedente;
            
            item.IdPaciente = IdPaciente;
            
            item.IdHCPrehospitalaria = IdHCPrehospitalaria;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int IdRelAntecedentePaciente,int? IdAntecedente,int? IdPaciente,int? IdHCPrehospitalaria)
	    {
		    EmrRelAntecedentePaciente item = new EmrRelAntecedentePaciente();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.IdRelAntecedentePaciente = IdRelAntecedentePaciente;
				
			item.IdAntecedente = IdAntecedente;
				
			item.IdPaciente = IdPaciente;
				
			item.IdHCPrehospitalaria = IdHCPrehospitalaria;
				
	        item.Save(UserName);
	    }
    }
}
