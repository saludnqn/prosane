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
    /// Controller class for EMR_Pupilas
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class EmrPupilaController
    {
        // Preload our schema..
        EmrPupila thisSchemaLoad = new EmrPupila();
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
        public EmrPupilaCollection FetchAll()
        {
            EmrPupilaCollection coll = new EmrPupilaCollection();
            Query qry = new Query(EmrPupila.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public EmrPupilaCollection FetchByID(object IdPupilas)
        {
            EmrPupilaCollection coll = new EmrPupilaCollection().Where("idPupilas", IdPupilas).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public EmrPupilaCollection FetchByQuery(Query qry)
        {
            EmrPupilaCollection coll = new EmrPupilaCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object IdPupilas)
        {
            return (EmrPupila.Delete(IdPupilas) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object IdPupilas)
        {
            return (EmrPupila.Destroy(IdPupilas) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string Nombre,string Descripcion)
	    {
		    EmrPupila item = new EmrPupila();
		    
            item.Nombre = Nombre;
            
            item.Descripcion = Descripcion;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int IdPupilas,string Nombre,string Descripcion)
	    {
		    EmrPupila item = new EmrPupila();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.IdPupilas = IdPupilas;
				
			item.Nombre = Nombre;
				
			item.Descripcion = Descripcion;
				
	        item.Save(UserName);
	    }
    }
}
