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
    /// Controller class for EMR_GlasgowMotor
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class EmrGlasgowMotorController
    {
        // Preload our schema..
        EmrGlasgowMotor thisSchemaLoad = new EmrGlasgowMotor();
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
        public EmrGlasgowMotorCollection FetchAll()
        {
            EmrGlasgowMotorCollection coll = new EmrGlasgowMotorCollection();
            Query qry = new Query(EmrGlasgowMotor.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public EmrGlasgowMotorCollection FetchByID(object IdGlasgowMotor)
        {
            EmrGlasgowMotorCollection coll = new EmrGlasgowMotorCollection().Where("idGlasgowMotor", IdGlasgowMotor).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public EmrGlasgowMotorCollection FetchByQuery(Query qry)
        {
            EmrGlasgowMotorCollection coll = new EmrGlasgowMotorCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object IdGlasgowMotor)
        {
            return (EmrGlasgowMotor.Delete(IdGlasgowMotor) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object IdGlasgowMotor)
        {
            return (EmrGlasgowMotor.Destroy(IdGlasgowMotor) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string Nombre,int Valor)
	    {
		    EmrGlasgowMotor item = new EmrGlasgowMotor();
		    
            item.Nombre = Nombre;
            
            item.Valor = Valor;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int IdGlasgowMotor,string Nombre,int Valor)
	    {
		    EmrGlasgowMotor item = new EmrGlasgowMotor();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.IdGlasgowMotor = IdGlasgowMotor;
				
			item.Nombre = Nombre;
				
			item.Valor = Valor;
				
	        item.Save(UserName);
	    }
    }
}
