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
    /// Controller class for AUT_Chofer
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class AutChoferController
    {
        // Preload our schema..
        AutChofer thisSchemaLoad = new AutChofer();
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
        public AutChoferCollection FetchAll()
        {
            AutChoferCollection coll = new AutChoferCollection();
            Query qry = new Query(AutChofer.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public AutChoferCollection FetchByID(object IdChofer)
        {
            AutChoferCollection coll = new AutChoferCollection().Where("idChofer", IdChofer).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public AutChoferCollection FetchByQuery(Query qry)
        {
            AutChoferCollection coll = new AutChoferCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object IdChofer)
        {
            return (AutChofer.Delete(IdChofer) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object IdChofer)
        {
            return (AutChofer.Destroy(IdChofer) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string Apellido,string Nombre,string Documento,string Legajo)
	    {
		    AutChofer item = new AutChofer();
		    
            item.Apellido = Apellido;
            
            item.Nombre = Nombre;
            
            item.Documento = Documento;
            
            item.Legajo = Legajo;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int IdChofer,string Apellido,string Nombre,string Documento,string Legajo)
	    {
		    AutChofer item = new AutChofer();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.IdChofer = IdChofer;
				
			item.Apellido = Apellido;
				
			item.Nombre = Nombre;
				
			item.Documento = Documento;
				
			item.Legajo = Legajo;
				
	        item.Save(UserName);
	    }
    }
}
