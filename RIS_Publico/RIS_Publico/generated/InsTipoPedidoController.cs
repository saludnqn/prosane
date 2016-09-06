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
    /// Controller class for INS_TipoPedido
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class InsTipoPedidoController
    {
        // Preload our schema..
        InsTipoPedido thisSchemaLoad = new InsTipoPedido();
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
        public InsTipoPedidoCollection FetchAll()
        {
            InsTipoPedidoCollection coll = new InsTipoPedidoCollection();
            Query qry = new Query(InsTipoPedido.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public InsTipoPedidoCollection FetchByID(object IdTipoPedido)
        {
            InsTipoPedidoCollection coll = new InsTipoPedidoCollection().Where("idTipoPedido", IdTipoPedido).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public InsTipoPedidoCollection FetchByQuery(Query qry)
        {
            InsTipoPedidoCollection coll = new InsTipoPedidoCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object IdTipoPedido)
        {
            return (InsTipoPedido.Delete(IdTipoPedido) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object IdTipoPedido)
        {
            return (InsTipoPedido.Destroy(IdTipoPedido) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string Nombre)
	    {
		    InsTipoPedido item = new InsTipoPedido();
		    
            item.Nombre = Nombre;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int IdTipoPedido,string Nombre)
	    {
		    InsTipoPedido item = new InsTipoPedido();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.IdTipoPedido = IdTipoPedido;
				
			item.Nombre = Nombre;
				
	        item.Save(UserName);
	    }
    }
}
