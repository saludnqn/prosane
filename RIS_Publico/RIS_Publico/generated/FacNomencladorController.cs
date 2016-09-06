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
    /// Controller class for FAC_Nomenclador
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class FacNomencladorController
    {
        // Preload our schema..
        FacNomenclador thisSchemaLoad = new FacNomenclador();
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
        public FacNomencladorCollection FetchAll()
        {
            FacNomencladorCollection coll = new FacNomencladorCollection();
            Query qry = new Query(FacNomenclador.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public FacNomencladorCollection FetchByID(object IdNomenclador)
        {
            FacNomencladorCollection coll = new FacNomencladorCollection().Where("idNomenclador", IdNomenclador).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public FacNomencladorCollection FetchByQuery(Query qry)
        {
            FacNomencladorCollection coll = new FacNomencladorCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object IdNomenclador)
        {
            return (FacNomenclador.Delete(IdNomenclador) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object IdNomenclador)
        {
            return (FacNomenclador.Destroy(IdNomenclador) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(int IdNomenclador,string Codigo,string Descripcion,int IdTipoPractica,int IdUnidad,int IdTipoNomenclador,decimal ValorUnidad,bool EsAmbulatorio,bool Activo,int IdCapitulo,decimal? Ug,string Anestesia)
	    {
		    FacNomenclador item = new FacNomenclador();
		    
            item.IdNomenclador = IdNomenclador;
            
            item.Codigo = Codigo;
            
            item.Descripcion = Descripcion;
            
            item.IdTipoPractica = IdTipoPractica;
            
            item.IdUnidad = IdUnidad;
            
            item.IdTipoNomenclador = IdTipoNomenclador;
            
            item.ValorUnidad = ValorUnidad;
            
            item.EsAmbulatorio = EsAmbulatorio;
            
            item.Activo = Activo;
            
            item.IdCapitulo = IdCapitulo;
            
            item.Ug = Ug;
            
            item.Anestesia = Anestesia;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int IdNomenclador,string Codigo,string Descripcion,int IdTipoPractica,int IdUnidad,int IdTipoNomenclador,decimal ValorUnidad,bool EsAmbulatorio,bool Activo,int IdCapitulo,decimal? Ug,string Anestesia)
	    {
		    FacNomenclador item = new FacNomenclador();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.IdNomenclador = IdNomenclador;
				
			item.Codigo = Codigo;
				
			item.Descripcion = Descripcion;
				
			item.IdTipoPractica = IdTipoPractica;
				
			item.IdUnidad = IdUnidad;
				
			item.IdTipoNomenclador = IdTipoNomenclador;
				
			item.ValorUnidad = ValorUnidad;
				
			item.EsAmbulatorio = EsAmbulatorio;
				
			item.Activo = Activo;
				
			item.IdCapitulo = IdCapitulo;
				
			item.Ug = Ug;
				
			item.Anestesia = Anestesia;
				
	        item.Save(UserName);
	    }
    }
}
