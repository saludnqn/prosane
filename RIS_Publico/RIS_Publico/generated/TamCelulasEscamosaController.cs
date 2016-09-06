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
    /// Controller class for TAM_CelulasEscamosas
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class TamCelulasEscamosaController
    {
        // Preload our schema..
        TamCelulasEscamosa thisSchemaLoad = new TamCelulasEscamosa();
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
        public TamCelulasEscamosaCollection FetchAll()
        {
            TamCelulasEscamosaCollection coll = new TamCelulasEscamosaCollection();
            Query qry = new Query(TamCelulasEscamosa.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public TamCelulasEscamosaCollection FetchByID(object IdCelulasEscamosas)
        {
            TamCelulasEscamosaCollection coll = new TamCelulasEscamosaCollection().Where("idCelulasEscamosas", IdCelulasEscamosas).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public TamCelulasEscamosaCollection FetchByQuery(Query qry)
        {
            TamCelulasEscamosaCollection coll = new TamCelulasEscamosaCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object IdCelulasEscamosas)
        {
            return (TamCelulasEscamosa.Delete(IdCelulasEscamosas) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object IdCelulasEscamosas)
        {
            return (TamCelulasEscamosa.Destroy(IdCelulasEscamosas) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string Nombre,string Variable)
	    {
		    TamCelulasEscamosa item = new TamCelulasEscamosa();
		    
            item.Nombre = Nombre;
            
            item.Variable = Variable;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int IdCelulasEscamosas,string Nombre,string Variable)
	    {
		    TamCelulasEscamosa item = new TamCelulasEscamosa();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.IdCelulasEscamosas = IdCelulasEscamosas;
				
			item.Nombre = Nombre;
				
			item.Variable = Variable;
				
	        item.Save(UserName);
	    }
    }
}
