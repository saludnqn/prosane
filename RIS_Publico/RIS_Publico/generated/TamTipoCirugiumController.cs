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
    /// Controller class for TAM_TipoCirugia
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class TamTipoCirugiumController
    {
        // Preload our schema..
        TamTipoCirugium thisSchemaLoad = new TamTipoCirugium();
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
        public TamTipoCirugiumCollection FetchAll()
        {
            TamTipoCirugiumCollection coll = new TamTipoCirugiumCollection();
            Query qry = new Query(TamTipoCirugium.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public TamTipoCirugiumCollection FetchByID(object IdTipoCirugia)
        {
            TamTipoCirugiumCollection coll = new TamTipoCirugiumCollection().Where("idTipoCirugia", IdTipoCirugia).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public TamTipoCirugiumCollection FetchByQuery(Query qry)
        {
            TamTipoCirugiumCollection coll = new TamTipoCirugiumCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object IdTipoCirugia)
        {
            return (TamTipoCirugium.Delete(IdTipoCirugia) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object IdTipoCirugia)
        {
            return (TamTipoCirugium.Destroy(IdTipoCirugia) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string Nombre)
	    {
		    TamTipoCirugium item = new TamTipoCirugium();
		    
            item.Nombre = Nombre;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int IdTipoCirugia,string Nombre)
	    {
		    TamTipoCirugium item = new TamTipoCirugium();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.IdTipoCirugia = IdTipoCirugia;
				
			item.Nombre = Nombre;
				
	        item.Save(UserName);
	    }
    }
}
