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
    /// Controller class for BDS_ProductoAdmision
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class BdsProductoAdmisionController
    {
        // Preload our schema..
        BdsProductoAdmision thisSchemaLoad = new BdsProductoAdmision();
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
        public BdsProductoAdmisionCollection FetchAll()
        {
            BdsProductoAdmisionCollection coll = new BdsProductoAdmisionCollection();
            Query qry = new Query(BdsProductoAdmision.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public BdsProductoAdmisionCollection FetchByID(object IdProductoAdmision)
        {
            BdsProductoAdmisionCollection coll = new BdsProductoAdmisionCollection().Where("idProductoAdmision", IdProductoAdmision).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public BdsProductoAdmisionCollection FetchByQuery(Query qry)
        {
            BdsProductoAdmisionCollection coll = new BdsProductoAdmisionCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object IdProductoAdmision)
        {
            return (BdsProductoAdmision.Delete(IdProductoAdmision) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object IdProductoAdmision)
        {
            return (BdsProductoAdmision.Destroy(IdProductoAdmision) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(int IdAdmision,int IdHemocomponente,int IdUsoHemocomponente,int IdUsuarioLibera,DateTime FechaLiberacion,decimal? Peso)
	    {
		    BdsProductoAdmision item = new BdsProductoAdmision();
		    
            item.IdAdmision = IdAdmision;
            
            item.IdHemocomponente = IdHemocomponente;
            
            item.IdUsoHemocomponente = IdUsoHemocomponente;
            
            item.IdUsuarioLibera = IdUsuarioLibera;
            
            item.FechaLiberacion = FechaLiberacion;
            
            item.Peso = Peso;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int IdProductoAdmision,int IdAdmision,int IdHemocomponente,int IdUsoHemocomponente,int IdUsuarioLibera,DateTime FechaLiberacion,decimal? Peso)
	    {
		    BdsProductoAdmision item = new BdsProductoAdmision();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.IdProductoAdmision = IdProductoAdmision;
				
			item.IdAdmision = IdAdmision;
				
			item.IdHemocomponente = IdHemocomponente;
				
			item.IdUsoHemocomponente = IdUsoHemocomponente;
				
			item.IdUsuarioLibera = IdUsuarioLibera;
				
			item.FechaLiberacion = FechaLiberacion;
				
			item.Peso = Peso;
				
	        item.Save(UserName);
	    }
    }
}
