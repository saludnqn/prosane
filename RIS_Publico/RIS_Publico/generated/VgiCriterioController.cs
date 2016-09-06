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
    /// Controller class for vgi_Criterios
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class VgiCriterioController
    {
        // Preload our schema..
        VgiCriterio thisSchemaLoad = new VgiCriterio();
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
        public VgiCriterioCollection FetchAll()
        {
            VgiCriterioCollection coll = new VgiCriterioCollection();
            Query qry = new Query(VgiCriterio.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public VgiCriterioCollection FetchByID(object IdVGICriterios)
        {
            VgiCriterioCollection coll = new VgiCriterioCollection().Where("idVGICriterios", IdVGICriterios).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public VgiCriterioCollection FetchByQuery(Query qry)
        {
            VgiCriterioCollection coll = new VgiCriterioCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object IdVGICriterios)
        {
            return (VgiCriterio.Delete(IdVGICriterios) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object IdVGICriterios)
        {
            return (VgiCriterio.Destroy(IdVGICriterios) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(int IdVGIDato,int? IdVGICInterconsultaItems,int? Valor)
	    {
		    VgiCriterio item = new VgiCriterio();
		    
            item.IdVGIDato = IdVGIDato;
            
            item.IdVGICInterconsultaItems = IdVGICInterconsultaItems;
            
            item.Valor = Valor;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int IdVGICriterios,int IdVGIDato,int? IdVGICInterconsultaItems,int? Valor)
	    {
		    VgiCriterio item = new VgiCriterio();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.IdVGICriterios = IdVGICriterios;
				
			item.IdVGIDato = IdVGIDato;
				
			item.IdVGICInterconsultaItems = IdVGICInterconsultaItems;
				
			item.Valor = Valor;
				
	        item.Save(UserName);
	    }
    }
}
