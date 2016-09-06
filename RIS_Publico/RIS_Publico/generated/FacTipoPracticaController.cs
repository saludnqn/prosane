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
    /// Controller class for FAC_TipoPractica
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class FacTipoPracticaController
    {
        // Preload our schema..
        FacTipoPractica thisSchemaLoad = new FacTipoPractica();
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
        public FacTipoPracticaCollection FetchAll()
        {
            FacTipoPracticaCollection coll = new FacTipoPracticaCollection();
            Query qry = new Query(FacTipoPractica.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public FacTipoPracticaCollection FetchByID(object IdTipoPractica)
        {
            FacTipoPracticaCollection coll = new FacTipoPracticaCollection().Where("idTipoPractica", IdTipoPractica).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public FacTipoPracticaCollection FetchByQuery(Query qry)
        {
            FacTipoPracticaCollection coll = new FacTipoPracticaCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object IdTipoPractica)
        {
            return (FacTipoPractica.Delete(IdTipoPractica) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object IdTipoPractica)
        {
            return (FacTipoPractica.Destroy(IdTipoPractica) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string Nombre,bool Baja)
	    {
		    FacTipoPractica item = new FacTipoPractica();
		    
            item.Nombre = Nombre;
            
            item.Baja = Baja;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int IdTipoPractica,string Nombre,bool Baja)
	    {
		    FacTipoPractica item = new FacTipoPractica();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.IdTipoPractica = IdTipoPractica;
				
			item.Nombre = Nombre;
				
			item.Baja = Baja;
				
	        item.Save(UserName);
	    }
    }
}
