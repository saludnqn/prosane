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
    /// Controller class for TAB_MedicamentoTabaquismo
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class TabMedicamentoTabaquismoController
    {
        // Preload our schema..
        TabMedicamentoTabaquismo thisSchemaLoad = new TabMedicamentoTabaquismo();
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
        public TabMedicamentoTabaquismoCollection FetchAll()
        {
            TabMedicamentoTabaquismoCollection coll = new TabMedicamentoTabaquismoCollection();
            Query qry = new Query(TabMedicamentoTabaquismo.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public TabMedicamentoTabaquismoCollection FetchByID(object IdMedicamentoControl)
        {
            TabMedicamentoTabaquismoCollection coll = new TabMedicamentoTabaquismoCollection().Where("idMedicamentoControl", IdMedicamentoControl).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public TabMedicamentoTabaquismoCollection FetchByQuery(Query qry)
        {
            TabMedicamentoTabaquismoCollection coll = new TabMedicamentoTabaquismoCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object IdMedicamentoControl)
        {
            return (TabMedicamentoTabaquismo.Delete(IdMedicamentoControl) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object IdMedicamentoControl)
        {
            return (TabMedicamentoTabaquismo.Destroy(IdMedicamentoControl) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(int IdMedicamento)
	    {
		    TabMedicamentoTabaquismo item = new TabMedicamentoTabaquismo();
		    
            item.IdMedicamento = IdMedicamento;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int IdMedicamentoControl,int IdMedicamento)
	    {
		    TabMedicamentoTabaquismo item = new TabMedicamentoTabaquismo();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.IdMedicamentoControl = IdMedicamentoControl;
				
			item.IdMedicamento = IdMedicamento;
				
	        item.Save(UserName);
	    }
    }
}
