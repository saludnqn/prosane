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
    /// Controller class for INS_TipoPrescripcion
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class InsTipoPrescripcionController
    {
        // Preload our schema..
        InsTipoPrescripcion thisSchemaLoad = new InsTipoPrescripcion();
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
        public InsTipoPrescripcionCollection FetchAll()
        {
            InsTipoPrescripcionCollection coll = new InsTipoPrescripcionCollection();
            Query qry = new Query(InsTipoPrescripcion.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public InsTipoPrescripcionCollection FetchByID(object IdTipoPrescripcion)
        {
            InsTipoPrescripcionCollection coll = new InsTipoPrescripcionCollection().Where("idTipoPrescripcion", IdTipoPrescripcion).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public InsTipoPrescripcionCollection FetchByQuery(Query qry)
        {
            InsTipoPrescripcionCollection coll = new InsTipoPrescripcionCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object IdTipoPrescripcion)
        {
            return (InsTipoPrescripcion.Delete(IdTipoPrescripcion) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object IdTipoPrescripcion)
        {
            return (InsTipoPrescripcion.Destroy(IdTipoPrescripcion) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string Nombre)
	    {
		    InsTipoPrescripcion item = new InsTipoPrescripcion();
		    
            item.Nombre = Nombre;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int IdTipoPrescripcion,string Nombre)
	    {
		    InsTipoPrescripcion item = new InsTipoPrescripcion();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.IdTipoPrescripcion = IdTipoPrescripcion;
				
			item.Nombre = Nombre;
				
	        item.Save(UserName);
	    }
    }
}
