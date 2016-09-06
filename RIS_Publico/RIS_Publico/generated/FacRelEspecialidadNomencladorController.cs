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
    /// Controller class for FAC_RelEspecialidadNomenclador
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class FacRelEspecialidadNomencladorController
    {
        // Preload our schema..
        FacRelEspecialidadNomenclador thisSchemaLoad = new FacRelEspecialidadNomenclador();
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
        public FacRelEspecialidadNomencladorCollection FetchAll()
        {
            FacRelEspecialidadNomencladorCollection coll = new FacRelEspecialidadNomencladorCollection();
            Query qry = new Query(FacRelEspecialidadNomenclador.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public FacRelEspecialidadNomencladorCollection FetchByID(object IdRelEspecialidadNomenclador)
        {
            FacRelEspecialidadNomencladorCollection coll = new FacRelEspecialidadNomencladorCollection().Where("idRelEspecialidadNomenclador", IdRelEspecialidadNomenclador).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public FacRelEspecialidadNomencladorCollection FetchByQuery(Query qry)
        {
            FacRelEspecialidadNomencladorCollection coll = new FacRelEspecialidadNomencladorCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object IdRelEspecialidadNomenclador)
        {
            return (FacRelEspecialidadNomenclador.Delete(IdRelEspecialidadNomenclador) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object IdRelEspecialidadNomenclador)
        {
            return (FacRelEspecialidadNomenclador.Destroy(IdRelEspecialidadNomenclador) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(int IdEspecialidad,string Codigo)
	    {
		    FacRelEspecialidadNomenclador item = new FacRelEspecialidadNomenclador();
		    
            item.IdEspecialidad = IdEspecialidad;
            
            item.Codigo = Codigo;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int IdRelEspecialidadNomenclador,int IdEspecialidad,string Codigo)
	    {
		    FacRelEspecialidadNomenclador item = new FacRelEspecialidadNomenclador();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.IdRelEspecialidadNomenclador = IdRelEspecialidadNomenclador;
				
			item.IdEspecialidad = IdEspecialidad;
				
			item.Codigo = Codigo;
				
	        item.Save(UserName);
	    }
    }
}
