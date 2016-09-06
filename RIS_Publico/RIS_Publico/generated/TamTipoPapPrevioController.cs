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
    /// Controller class for TAM_TipoPapPrevio
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class TamTipoPapPrevioController
    {
        // Preload our schema..
        TamTipoPapPrevio thisSchemaLoad = new TamTipoPapPrevio();
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
        public TamTipoPapPrevioCollection FetchAll()
        {
            TamTipoPapPrevioCollection coll = new TamTipoPapPrevioCollection();
            Query qry = new Query(TamTipoPapPrevio.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public TamTipoPapPrevioCollection FetchByID(object IdTipoPapPrevio)
        {
            TamTipoPapPrevioCollection coll = new TamTipoPapPrevioCollection().Where("idTipoPapPrevio", IdTipoPapPrevio).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public TamTipoPapPrevioCollection FetchByQuery(Query qry)
        {
            TamTipoPapPrevioCollection coll = new TamTipoPapPrevioCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object IdTipoPapPrevio)
        {
            return (TamTipoPapPrevio.Delete(IdTipoPapPrevio) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object IdTipoPapPrevio)
        {
            return (TamTipoPapPrevio.Destroy(IdTipoPapPrevio) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string Nombre)
	    {
		    TamTipoPapPrevio item = new TamTipoPapPrevio();
		    
            item.Nombre = Nombre;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int IdTipoPapPrevio,string Nombre)
	    {
		    TamTipoPapPrevio item = new TamTipoPapPrevio();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.IdTipoPapPrevio = IdTipoPapPrevio;
				
			item.Nombre = Nombre;
				
	        item.Save(UserName);
	    }
    }
}
