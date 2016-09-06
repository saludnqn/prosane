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
    /// Controller class for FAC_TipoNomenclador
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class FacTipoNomencladorController
    {
        // Preload our schema..
        FacTipoNomenclador thisSchemaLoad = new FacTipoNomenclador();
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
        public FacTipoNomencladorCollection FetchAll()
        {
            FacTipoNomencladorCollection coll = new FacTipoNomencladorCollection();
            Query qry = new Query(FacTipoNomenclador.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public FacTipoNomencladorCollection FetchByID(object IdTipoNomenclador)
        {
            FacTipoNomencladorCollection coll = new FacTipoNomencladorCollection().Where("idTipoNomenclador", IdTipoNomenclador).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public FacTipoNomencladorCollection FetchByQuery(Query qry)
        {
            FacTipoNomencladorCollection coll = new FacTipoNomencladorCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object IdTipoNomenclador)
        {
            return (FacTipoNomenclador.Delete(IdTipoNomenclador) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object IdTipoNomenclador)
        {
            return (FacTipoNomenclador.Destroy(IdTipoNomenclador) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string Nombre,DateTime FechaDesde,DateTime FechaHasta,bool Activo)
	    {
		    FacTipoNomenclador item = new FacTipoNomenclador();
		    
            item.Nombre = Nombre;
            
            item.FechaDesde = FechaDesde;
            
            item.FechaHasta = FechaHasta;
            
            item.Activo = Activo;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int IdTipoNomenclador,string Nombre,DateTime FechaDesde,DateTime FechaHasta,bool Activo)
	    {
		    FacTipoNomenclador item = new FacTipoNomenclador();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.IdTipoNomenclador = IdTipoNomenclador;
				
			item.Nombre = Nombre;
				
			item.FechaDesde = FechaDesde;
				
			item.FechaHasta = FechaHasta;
				
			item.Activo = Activo;
				
	        item.Save(UserName);
	    }
    }
}
