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
    /// Controller class for AUT_ItemMovimiento
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class AutItemMovimientoController
    {
        // Preload our schema..
        AutItemMovimiento thisSchemaLoad = new AutItemMovimiento();
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
        public AutItemMovimientoCollection FetchAll()
        {
            AutItemMovimientoCollection coll = new AutItemMovimientoCollection();
            Query qry = new Query(AutItemMovimiento.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public AutItemMovimientoCollection FetchByID(object IdItemMovimiento)
        {
            AutItemMovimientoCollection coll = new AutItemMovimientoCollection().Where("idItemMovimiento", IdItemMovimiento).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public AutItemMovimientoCollection FetchByQuery(Query qry)
        {
            AutItemMovimientoCollection coll = new AutItemMovimientoCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object IdItemMovimiento)
        {
            return (AutItemMovimiento.Delete(IdItemMovimiento) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object IdItemMovimiento)
        {
            return (AutItemMovimiento.Destroy(IdItemMovimiento) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string Nombre,int? IdPMPTipo,int IdUsuarioRegistro,DateTime FechaRegistro)
	    {
		    AutItemMovimiento item = new AutItemMovimiento();
		    
            item.Nombre = Nombre;
            
            item.IdPMPTipo = IdPMPTipo;
            
            item.IdUsuarioRegistro = IdUsuarioRegistro;
            
            item.FechaRegistro = FechaRegistro;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int IdItemMovimiento,string Nombre,int? IdPMPTipo,int IdUsuarioRegistro,DateTime FechaRegistro)
	    {
		    AutItemMovimiento item = new AutItemMovimiento();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.IdItemMovimiento = IdItemMovimiento;
				
			item.Nombre = Nombre;
				
			item.IdPMPTipo = IdPMPTipo;
				
			item.IdUsuarioRegistro = IdUsuarioRegistro;
				
			item.FechaRegistro = FechaRegistro;
				
	        item.Save(UserName);
	    }
    }
}
