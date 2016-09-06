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
    /// Controller class for AUT_Modelo
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class AutModeloController
    {
        // Preload our schema..
        AutModelo thisSchemaLoad = new AutModelo();
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
        public AutModeloCollection FetchAll()
        {
            AutModeloCollection coll = new AutModeloCollection();
            Query qry = new Query(AutModelo.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public AutModeloCollection FetchByID(object IdModelo)
        {
            AutModeloCollection coll = new AutModeloCollection().Where("idModelo", IdModelo).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public AutModeloCollection FetchByQuery(Query qry)
        {
            AutModeloCollection coll = new AutModeloCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object IdModelo)
        {
            return (AutModelo.Delete(IdModelo) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object IdModelo)
        {
            return (AutModelo.Destroy(IdModelo) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string Nombre,int IdMarca)
	    {
		    AutModelo item = new AutModelo();
		    
            item.Nombre = Nombre;
            
            item.IdMarca = IdMarca;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int IdModelo,string Nombre,int IdMarca)
	    {
		    AutModelo item = new AutModelo();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.IdModelo = IdModelo;
				
			item.Nombre = Nombre;
				
			item.IdMarca = IdMarca;
				
	        item.Save(UserName);
	    }
    }
}
