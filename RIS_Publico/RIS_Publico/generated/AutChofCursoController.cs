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
    /// Controller class for Aut_ChofCursos
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class AutChofCursoController
    {
        // Preload our schema..
        AutChofCurso thisSchemaLoad = new AutChofCurso();
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
        public AutChofCursoCollection FetchAll()
        {
            AutChofCursoCollection coll = new AutChofCursoCollection();
            Query qry = new Query(AutChofCurso.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public AutChofCursoCollection FetchByID(object IdCurso)
        {
            AutChofCursoCollection coll = new AutChofCursoCollection().Where("idCurso", IdCurso).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public AutChofCursoCollection FetchByQuery(Query qry)
        {
            AutChofCursoCollection coll = new AutChofCursoCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object IdCurso)
        {
            return (AutChofCurso.Delete(IdCurso) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object IdCurso)
        {
            return (AutChofCurso.Destroy(IdCurso) == 1);
        }
        
        
        
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(decimal IdCurso,decimal IdChofer)
        {
            Query qry = new Query(AutChofCurso.Schema);
            qry.QueryType = QueryType.Delete;
            qry.AddWhere("IdCurso", IdCurso).AND("IdChofer", IdChofer);
            qry.Execute();
            return (true);
        }        
       
    	
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(decimal IdCurso,decimal IdChofer,decimal? Año)
	    {
		    AutChofCurso item = new AutChofCurso();
		    
            item.IdCurso = IdCurso;
            
            item.IdChofer = IdChofer;
            
            item.Año = Año;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(decimal IdCurso,decimal IdChofer,decimal? Año)
	    {
		    AutChofCurso item = new AutChofCurso();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.IdCurso = IdCurso;
				
			item.IdChofer = IdChofer;
				
			item.Año = Año;
				
	        item.Save(UserName);
	    }
    }
}
