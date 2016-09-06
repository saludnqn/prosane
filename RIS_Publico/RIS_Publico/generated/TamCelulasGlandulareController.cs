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
    /// Controller class for TAM_CelulasGlandulares
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class TamCelulasGlandulareController
    {
        // Preload our schema..
        TamCelulasGlandulare thisSchemaLoad = new TamCelulasGlandulare();
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
        public TamCelulasGlandulareCollection FetchAll()
        {
            TamCelulasGlandulareCollection coll = new TamCelulasGlandulareCollection();
            Query qry = new Query(TamCelulasGlandulare.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public TamCelulasGlandulareCollection FetchByID(object IdCelulasGlandulares)
        {
            TamCelulasGlandulareCollection coll = new TamCelulasGlandulareCollection().Where("idCelulasGlandulares", IdCelulasGlandulares).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public TamCelulasGlandulareCollection FetchByQuery(Query qry)
        {
            TamCelulasGlandulareCollection coll = new TamCelulasGlandulareCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object IdCelulasGlandulares)
        {
            return (TamCelulasGlandulare.Delete(IdCelulasGlandulares) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object IdCelulasGlandulares)
        {
            return (TamCelulasGlandulare.Destroy(IdCelulasGlandulares) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string Nombre,string Variable)
	    {
		    TamCelulasGlandulare item = new TamCelulasGlandulare();
		    
            item.Nombre = Nombre;
            
            item.Variable = Variable;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int IdCelulasGlandulares,string Nombre,string Variable)
	    {
		    TamCelulasGlandulare item = new TamCelulasGlandulare();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.IdCelulasGlandulares = IdCelulasGlandulares;
				
			item.Nombre = Nombre;
				
			item.Variable = Variable;
				
	        item.Save(UserName);
	    }
    }
}
