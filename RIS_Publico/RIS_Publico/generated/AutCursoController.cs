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
    /// Controller class for Aut_Cursos
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class AutCursoController
    {
        // Preload our schema..
        AutCurso thisSchemaLoad = new AutCurso();
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
        public AutCursoCollection FetchAll()
        {
            AutCursoCollection coll = new AutCursoCollection();
            Query qry = new Query(AutCurso.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public AutCursoCollection FetchByID(object IdCurso)
        {
            AutCursoCollection coll = new AutCursoCollection().Where("idCurso", IdCurso).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public AutCursoCollection FetchByQuery(Query qry)
        {
            AutCursoCollection coll = new AutCursoCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object IdCurso)
        {
            return (AutCurso.Delete(IdCurso) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object IdCurso)
        {
            return (AutCurso.Destroy(IdCurso) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string Nombre,decimal? Puntos)
	    {
		    AutCurso item = new AutCurso();
		    
            item.Nombre = Nombre;
            
            item.Puntos = Puntos;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(decimal IdCurso,string Nombre,decimal? Puntos)
	    {
		    AutCurso item = new AutCurso();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.IdCurso = IdCurso;
				
			item.Nombre = Nombre;
				
			item.Puntos = Puntos;
				
	        item.Save(UserName);
	    }
    }
}
