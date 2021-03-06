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
    /// Controller class for APR_ComplicacionAborto
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class AprComplicacionAbortoController
    {
        // Preload our schema..
        AprComplicacionAborto thisSchemaLoad = new AprComplicacionAborto();
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
        public AprComplicacionAbortoCollection FetchAll()
        {
            AprComplicacionAbortoCollection coll = new AprComplicacionAbortoCollection();
            Query qry = new Query(AprComplicacionAborto.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public AprComplicacionAbortoCollection FetchByID(object IdComplicaionAborto)
        {
            AprComplicacionAbortoCollection coll = new AprComplicacionAbortoCollection().Where("idComplicaionAborto", IdComplicaionAborto).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public AprComplicacionAbortoCollection FetchByQuery(Query qry)
        {
            AprComplicacionAbortoCollection coll = new AprComplicacionAbortoCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object IdComplicaionAborto)
        {
            return (AprComplicacionAborto.Delete(IdComplicaionAborto) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object IdComplicaionAborto)
        {
            return (AprComplicacionAborto.Destroy(IdComplicaionAborto) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string Nombre)
	    {
		    AprComplicacionAborto item = new AprComplicacionAborto();
		    
            item.Nombre = Nombre;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int IdComplicaionAborto,string Nombre)
	    {
		    AprComplicacionAborto item = new AprComplicacionAborto();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.IdComplicaionAborto = IdComplicaionAborto;
				
			item.Nombre = Nombre;
				
	        item.Save(UserName);
	    }
    }
}
