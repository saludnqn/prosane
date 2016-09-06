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
    /// Controller class for FAC_TipoIva
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class FacTipoIvaController
    {
        // Preload our schema..
        FacTipoIva thisSchemaLoad = new FacTipoIva();
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
        public FacTipoIvaCollection FetchAll()
        {
            FacTipoIvaCollection coll = new FacTipoIvaCollection();
            Query qry = new Query(FacTipoIva.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public FacTipoIvaCollection FetchByID(object IdTipoIva)
        {
            FacTipoIvaCollection coll = new FacTipoIvaCollection().Where("idTipoIva", IdTipoIva).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public FacTipoIvaCollection FetchByQuery(Query qry)
        {
            FacTipoIvaCollection coll = new FacTipoIvaCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object IdTipoIva)
        {
            return (FacTipoIva.Delete(IdTipoIva) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object IdTipoIva)
        {
            return (FacTipoIva.Destroy(IdTipoIva) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string Nombre,string Abreviatura,string RecibeComprobante,string EmiteComprobante)
	    {
		    FacTipoIva item = new FacTipoIva();
		    
            item.Nombre = Nombre;
            
            item.Abreviatura = Abreviatura;
            
            item.RecibeComprobante = RecibeComprobante;
            
            item.EmiteComprobante = EmiteComprobante;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int IdTipoIva,string Nombre,string Abreviatura,string RecibeComprobante,string EmiteComprobante)
	    {
		    FacTipoIva item = new FacTipoIva();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.IdTipoIva = IdTipoIva;
				
			item.Nombre = Nombre;
				
			item.Abreviatura = Abreviatura;
				
			item.RecibeComprobante = RecibeComprobante;
				
			item.EmiteComprobante = EmiteComprobante;
				
	        item.Save(UserName);
	    }
    }
}
