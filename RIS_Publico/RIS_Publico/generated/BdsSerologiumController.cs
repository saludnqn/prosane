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
    /// Controller class for BDS_Serologia
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class BdsSerologiumController
    {
        // Preload our schema..
        BdsSerologium thisSchemaLoad = new BdsSerologium();
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
        public BdsSerologiumCollection FetchAll()
        {
            BdsSerologiumCollection coll = new BdsSerologiumCollection();
            Query qry = new Query(BdsSerologium.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public BdsSerologiumCollection FetchByID(object IdSerologia)
        {
            BdsSerologiumCollection coll = new BdsSerologiumCollection().Where("idSerologia", IdSerologia).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public BdsSerologiumCollection FetchByQuery(Query qry)
        {
            BdsSerologiumCollection coll = new BdsSerologiumCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object IdSerologia)
        {
            return (BdsSerologium.Delete(IdSerologia) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object IdSerologia)
        {
            return (BdsSerologium.Destroy(IdSerologia) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(int IdAdmision,DateTime FechaYHora,string Bvdr,string Bhud,string Bche,string Bchha,string Bhc,string BHBsa,string BHBc,string Bhiva,string Bhtl,string AgP26)
	    {
		    BdsSerologium item = new BdsSerologium();
		    
            item.IdAdmision = IdAdmision;
            
            item.FechaYHora = FechaYHora;
            
            item.Bvdr = Bvdr;
            
            item.Bhud = Bhud;
            
            item.Bche = Bche;
            
            item.Bchha = Bchha;
            
            item.Bhc = Bhc;
            
            item.BHBsa = BHBsa;
            
            item.BHBc = BHBc;
            
            item.Bhiva = Bhiva;
            
            item.Bhtl = Bhtl;
            
            item.AgP26 = AgP26;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int IdSerologia,int IdAdmision,DateTime FechaYHora,string Bvdr,string Bhud,string Bche,string Bchha,string Bhc,string BHBsa,string BHBc,string Bhiva,string Bhtl,string AgP26)
	    {
		    BdsSerologium item = new BdsSerologium();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.IdSerologia = IdSerologia;
				
			item.IdAdmision = IdAdmision;
				
			item.FechaYHora = FechaYHora;
				
			item.Bvdr = Bvdr;
				
			item.Bhud = Bhud;
				
			item.Bche = Bche;
				
			item.Bchha = Bchha;
				
			item.Bhc = Bhc;
				
			item.BHBsa = BHBsa;
				
			item.BHBc = BHBc;
				
			item.Bhiva = Bhiva;
				
			item.Bhtl = Bhtl;
				
			item.AgP26 = AgP26;
				
	        item.Save(UserName);
	    }
    }
}
