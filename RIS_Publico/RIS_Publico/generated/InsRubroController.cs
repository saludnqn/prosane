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
    /// Controller class for INS_Rubro
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class InsRubroController
    {
        // Preload our schema..
        InsRubro thisSchemaLoad = new InsRubro();
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
        public InsRubroCollection FetchAll()
        {
            InsRubroCollection coll = new InsRubroCollection();
            Query qry = new Query(InsRubro.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public InsRubroCollection FetchByID(object IdRubro)
        {
            InsRubroCollection coll = new InsRubroCollection().Where("idRubro", IdRubro).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public InsRubroCollection FetchByQuery(Query qry)
        {
            InsRubroCollection coll = new InsRubroCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object IdRubro)
        {
            return (InsRubro.Delete(IdRubro) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object IdRubro)
        {
            return (InsRubro.Destroy(IdRubro) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(int Codigo,byte Sistema,int? Padre,string Nombre,byte Especial,int? RubroPrimerNivel,int? IdRubroPadre,int IdEfector,bool Baja,string CreatedBy,DateTime CreatedOn,string ModifiedBy,DateTime ModifiedOn)
	    {
		    InsRubro item = new InsRubro();
		    
            item.Codigo = Codigo;
            
            item.Sistema = Sistema;
            
            item.Padre = Padre;
            
            item.Nombre = Nombre;
            
            item.Especial = Especial;
            
            item.RubroPrimerNivel = RubroPrimerNivel;
            
            item.IdRubroPadre = IdRubroPadre;
            
            item.IdEfector = IdEfector;
            
            item.Baja = Baja;
            
            item.CreatedBy = CreatedBy;
            
            item.CreatedOn = CreatedOn;
            
            item.ModifiedBy = ModifiedBy;
            
            item.ModifiedOn = ModifiedOn;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int IdRubro,int Codigo,byte Sistema,int? Padre,string Nombre,byte Especial,int? RubroPrimerNivel,int? IdRubroPadre,int IdEfector,bool Baja,string CreatedBy,DateTime CreatedOn,string ModifiedBy,DateTime ModifiedOn)
	    {
		    InsRubro item = new InsRubro();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.IdRubro = IdRubro;
				
			item.Codigo = Codigo;
				
			item.Sistema = Sistema;
				
			item.Padre = Padre;
				
			item.Nombre = Nombre;
				
			item.Especial = Especial;
				
			item.RubroPrimerNivel = RubroPrimerNivel;
				
			item.IdRubroPadre = IdRubroPadre;
				
			item.IdEfector = IdEfector;
				
			item.Baja = Baja;
				
			item.CreatedBy = CreatedBy;
				
			item.CreatedOn = CreatedOn;
				
			item.ModifiedBy = ModifiedBy;
				
			item.ModifiedOn = ModifiedOn;
				
	        item.Save(UserName);
	    }
    }
}
