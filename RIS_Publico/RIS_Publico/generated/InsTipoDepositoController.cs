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
    /// Controller class for INS_TipoDeposito
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class InsTipoDepositoController
    {
        // Preload our schema..
        InsTipoDeposito thisSchemaLoad = new InsTipoDeposito();
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
        public InsTipoDepositoCollection FetchAll()
        {
            InsTipoDepositoCollection coll = new InsTipoDepositoCollection();
            Query qry = new Query(InsTipoDeposito.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public InsTipoDepositoCollection FetchByID(object IdTipoDeposito)
        {
            InsTipoDepositoCollection coll = new InsTipoDepositoCollection().Where("idTipoDeposito", IdTipoDeposito).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public InsTipoDepositoCollection FetchByQuery(Query qry)
        {
            InsTipoDepositoCollection coll = new InsTipoDepositoCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object IdTipoDeposito)
        {
            return (InsTipoDeposito.Delete(IdTipoDeposito) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object IdTipoDeposito)
        {
            return (InsTipoDeposito.Destroy(IdTipoDeposito) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string Nombre,string Descripcion,bool Baja)
	    {
		    InsTipoDeposito item = new InsTipoDeposito();
		    
            item.Nombre = Nombre;
            
            item.Descripcion = Descripcion;
            
            item.Baja = Baja;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int IdTipoDeposito,string Nombre,string Descripcion,bool Baja)
	    {
		    InsTipoDeposito item = new InsTipoDeposito();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.IdTipoDeposito = IdTipoDeposito;
				
			item.Nombre = Nombre;
				
			item.Descripcion = Descripcion;
				
			item.Baja = Baja;
				
	        item.Save(UserName);
	    }
    }
}
