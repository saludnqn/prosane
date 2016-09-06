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
    /// Controller class for FAC_OrdenPaciente
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class FacOrdenPacienteController
    {
        // Preload our schema..
        FacOrdenPaciente thisSchemaLoad = new FacOrdenPaciente();
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
        public FacOrdenPacienteCollection FetchAll()
        {
            FacOrdenPacienteCollection coll = new FacOrdenPacienteCollection();
            Query qry = new Query(FacOrdenPaciente.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public FacOrdenPacienteCollection FetchByID(object IdOrdenPaciente)
        {
            FacOrdenPacienteCollection coll = new FacOrdenPacienteCollection().Where("idOrdenPaciente", IdOrdenPaciente).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public FacOrdenPacienteCollection FetchByQuery(Query qry)
        {
            FacOrdenPacienteCollection coll = new FacOrdenPacienteCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object IdOrdenPaciente)
        {
            return (FacOrdenPaciente.Delete(IdOrdenPaciente) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object IdOrdenPaciente)
        {
            return (FacOrdenPaciente.Destroy(IdOrdenPaciente) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(int IdOrden,int IdPaciente,DateTime FechaPractica,string Diagnostico,int? IdOrdenDetalle)
	    {
		    FacOrdenPaciente item = new FacOrdenPaciente();
		    
            item.IdOrden = IdOrden;
            
            item.IdPaciente = IdPaciente;
            
            item.FechaPractica = FechaPractica;
            
            item.Diagnostico = Diagnostico;
            
            item.IdOrdenDetalle = IdOrdenDetalle;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int IdOrdenPaciente,int IdOrden,int IdPaciente,DateTime FechaPractica,string Diagnostico,int? IdOrdenDetalle)
	    {
		    FacOrdenPaciente item = new FacOrdenPaciente();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.IdOrdenPaciente = IdOrdenPaciente;
				
			item.IdOrden = IdOrden;
				
			item.IdPaciente = IdPaciente;
				
			item.FechaPractica = FechaPractica;
				
			item.Diagnostico = Diagnostico;
				
			item.IdOrdenDetalle = IdOrdenDetalle;
				
	        item.Save(UserName);
	    }
    }
}
