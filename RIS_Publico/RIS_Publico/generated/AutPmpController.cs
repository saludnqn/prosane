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
    /// Controller class for AUT_PMP
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class AutPmpController
    {
        // Preload our schema..
        AutPmp thisSchemaLoad = new AutPmp();
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
        public AutPmpCollection FetchAll()
        {
            AutPmpCollection coll = new AutPmpCollection();
            Query qry = new Query(AutPmp.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public AutPmpCollection FetchByID(object IdPMP)
        {
            AutPmpCollection coll = new AutPmpCollection().Where("idPMP", IdPMP).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public AutPmpCollection FetchByQuery(Query qry)
        {
            AutPmpCollection coll = new AutPmpCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object IdPMP)
        {
            return (AutPmp.Delete(IdPMP) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object IdPMP)
        {
            return (AutPmp.Destroy(IdPMP) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string Nombre,int Kilometraje,int? IdPMPTipo,int IdUsuarioRegistro,DateTime FechaRegistro,int? IdTipoPNP)
	    {
		    AutPmp item = new AutPmp();
		    
            item.Nombre = Nombre;
            
            item.Kilometraje = Kilometraje;
            
            item.IdPMPTipo = IdPMPTipo;
            
            item.IdUsuarioRegistro = IdUsuarioRegistro;
            
            item.FechaRegistro = FechaRegistro;
            
            item.IdTipoPNP = IdTipoPNP;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int IdPMP,string Nombre,int Kilometraje,int? IdPMPTipo,int IdUsuarioRegistro,DateTime FechaRegistro,int? IdTipoPNP)
	    {
		    AutPmp item = new AutPmp();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.IdPMP = IdPMP;
				
			item.Nombre = Nombre;
				
			item.Kilometraje = Kilometraje;
				
			item.IdPMPTipo = IdPMPTipo;
				
			item.IdUsuarioRegistro = IdUsuarioRegistro;
				
			item.FechaRegistro = FechaRegistro;
				
			item.IdTipoPNP = IdTipoPNP;
				
	        item.Save(UserName);
	    }
    }
}
