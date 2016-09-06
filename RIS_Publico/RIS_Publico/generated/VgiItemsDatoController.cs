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
    /// Controller class for vgi_ItemsDatos
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class VgiItemsDatoController
    {
        // Preload our schema..
        VgiItemsDato thisSchemaLoad = new VgiItemsDato();
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
        public VgiItemsDatoCollection FetchAll()
        {
            VgiItemsDatoCollection coll = new VgiItemsDatoCollection();
            Query qry = new Query(VgiItemsDato.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public VgiItemsDatoCollection FetchByID(object IdVGItemDatos)
        {
            VgiItemsDatoCollection coll = new VgiItemsDatoCollection().Where("idVGItemDatos", IdVGItemDatos).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public VgiItemsDatoCollection FetchByQuery(Query qry)
        {
            VgiItemsDatoCollection coll = new VgiItemsDatoCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object IdVGItemDatos)
        {
            return (VgiItemsDato.Delete(IdVGItemDatos) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object IdVGItemDatos)
        {
            return (VgiItemsDato.Destroy(IdVGItemDatos) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(int IdVGItemDatos,int? IdVGIDatos,int? IdItems,int? Valor)
	    {
		    VgiItemsDato item = new VgiItemsDato();
		    
            item.IdVGItemDatos = IdVGItemDatos;
            
            item.IdVGIDatos = IdVGIDatos;
            
            item.IdItems = IdItems;
            
            item.Valor = Valor;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int IdVGItemDatos,int? IdVGIDatos,int? IdItems,int? Valor)
	    {
		    VgiItemsDato item = new VgiItemsDato();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.IdVGItemDatos = IdVGItemDatos;
				
			item.IdVGIDatos = IdVGIDatos;
				
			item.IdItems = IdItems;
				
			item.Valor = Valor;
				
	        item.Save(UserName);
	    }
    }
}
