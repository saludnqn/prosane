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
    /// Controller class for FAC_Capitulo
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class FacCapituloController
    {
        // Preload our schema..
        FacCapitulo thisSchemaLoad = new FacCapitulo();
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
        public FacCapituloCollection FetchAll()
        {
            FacCapituloCollection coll = new FacCapituloCollection();
            Query qry = new Query(FacCapitulo.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public FacCapituloCollection FetchByID(object IdCapitulo)
        {
            FacCapituloCollection coll = new FacCapituloCollection().Where("idCapitulo", IdCapitulo).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public FacCapituloCollection FetchByQuery(Query qry)
        {
            FacCapituloCollection coll = new FacCapituloCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object IdCapitulo)
        {
            return (FacCapitulo.Delete(IdCapitulo) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object IdCapitulo)
        {
            return (FacCapitulo.Destroy(IdCapitulo) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string Nombre,string CodigoDesde,string CodigoHasta)
	    {
		    FacCapitulo item = new FacCapitulo();
		    
            item.Nombre = Nombre;
            
            item.CodigoDesde = CodigoDesde;
            
            item.CodigoHasta = CodigoHasta;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int IdCapitulo,string Nombre,string CodigoDesde,string CodigoHasta)
	    {
		    FacCapitulo item = new FacCapitulo();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.IdCapitulo = IdCapitulo;
				
			item.Nombre = Nombre;
				
			item.CodigoDesde = CodigoDesde;
				
			item.CodigoHasta = CodigoHasta;
				
	        item.Save(UserName);
	    }
    }
}
