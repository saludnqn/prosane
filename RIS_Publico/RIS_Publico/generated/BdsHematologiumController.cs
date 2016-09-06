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
    /// Controller class for BDS_Hematologia
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class BdsHematologiumController
    {
        // Preload our schema..
        BdsHematologium thisSchemaLoad = new BdsHematologium();
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
        public BdsHematologiumCollection FetchAll()
        {
            BdsHematologiumCollection coll = new BdsHematologiumCollection();
            Query qry = new Query(BdsHematologium.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public BdsHematologiumCollection FetchByID(object IdHematologia)
        {
            BdsHematologiumCollection coll = new BdsHematologiumCollection().Where("idHematologia", IdHematologia).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public BdsHematologiumCollection FetchByQuery(Query qry)
        {
            BdsHematologiumCollection coll = new BdsHematologiumCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object IdHematologia)
        {
            return (BdsHematologium.Delete(IdHematologia) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object IdHematologia)
        {
            return (BdsHematologium.Destroy(IdHematologia) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(int IdAdmision,string Grupo,string Factor,string Pai,string DDebil,string Observaciones,int? IdUsuarioRegistro,DateTime? FechaRegistro)
	    {
		    BdsHematologium item = new BdsHematologium();
		    
            item.IdAdmision = IdAdmision;
            
            item.Grupo = Grupo;
            
            item.Factor = Factor;
            
            item.Pai = Pai;
            
            item.DDebil = DDebil;
            
            item.Observaciones = Observaciones;
            
            item.IdUsuarioRegistro = IdUsuarioRegistro;
            
            item.FechaRegistro = FechaRegistro;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int IdHematologia,int IdAdmision,string Grupo,string Factor,string Pai,string DDebil,string Observaciones,int? IdUsuarioRegistro,DateTime? FechaRegistro)
	    {
		    BdsHematologium item = new BdsHematologium();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.IdHematologia = IdHematologia;
				
			item.IdAdmision = IdAdmision;
				
			item.Grupo = Grupo;
				
			item.Factor = Factor;
				
			item.Pai = Pai;
				
			item.DDebil = DDebil;
				
			item.Observaciones = Observaciones;
				
			item.IdUsuarioRegistro = IdUsuarioRegistro;
				
			item.FechaRegistro = FechaRegistro;
				
	        item.Save(UserName);
	    }
    }
}
