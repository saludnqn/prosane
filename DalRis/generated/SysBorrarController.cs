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
    /// Controller class for Sys_Borrar
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class SysBorrarController
    {
        // Preload our schema..
        SysBorrar thisSchemaLoad = new SysBorrar();
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
        public SysBorrarCollection FetchAll()
        {
            SysBorrarCollection coll = new SysBorrarCollection();
            Query qry = new Query(SysBorrar.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public SysBorrarCollection FetchByID(object IdBorrar)
        {
            SysBorrarCollection coll = new SysBorrarCollection().Where("idBorrar", IdBorrar).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public SysBorrarCollection FetchByQuery(Query qry)
        {
            SysBorrarCollection coll = new SysBorrarCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object IdBorrar)
        {
            return (SysBorrar.Delete(IdBorrar) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object IdBorrar)
        {
            return (SysBorrar.Destroy(IdBorrar) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string Nombre,string CodigoIndec)
	    {
		    SysBorrar item = new SysBorrar();
		    
            item.Nombre = Nombre;
            
            item.CodigoIndec = CodigoIndec;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int IdBorrar,string Nombre,string CodigoIndec)
	    {
		    SysBorrar item = new SysBorrar();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.IdBorrar = IdBorrar;
				
			item.Nombre = Nombre;
				
			item.CodigoIndec = CodigoIndec;
				
	        item.Save(UserName);
	    }
    }
}
