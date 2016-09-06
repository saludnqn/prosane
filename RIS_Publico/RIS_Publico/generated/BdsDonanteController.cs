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
    /// Controller class for BDS_Donante
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class BdsDonanteController
    {
        // Preload our schema..
        BdsDonante thisSchemaLoad = new BdsDonante();
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
        public BdsDonanteCollection FetchAll()
        {
            BdsDonanteCollection coll = new BdsDonanteCollection();
            Query qry = new Query(BdsDonante.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public BdsDonanteCollection FetchByID(object IdDonante)
        {
            BdsDonanteCollection coll = new BdsDonanteCollection().Where("idDonante", IdDonante).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public BdsDonanteCollection FetchByQuery(Query qry)
        {
            BdsDonanteCollection coll = new BdsDonanteCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object IdDonante)
        {
            return (BdsDonante.Delete(IdDonante) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object IdDonante)
        {
            return (BdsDonante.Destroy(IdDonante) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(bool Extranjero,int NumeroDocumento,string Apellido,string Nombre,int IdSexo,DateTime FechaNacimiento,string LugarNacimiento,string Domicilio,string Telefono,int IdUsuarioRegistro,DateTime FechaRegistro)
	    {
		    BdsDonante item = new BdsDonante();
		    
            item.Extranjero = Extranjero;
            
            item.NumeroDocumento = NumeroDocumento;
            
            item.Apellido = Apellido;
            
            item.Nombre = Nombre;
            
            item.IdSexo = IdSexo;
            
            item.FechaNacimiento = FechaNacimiento;
            
            item.LugarNacimiento = LugarNacimiento;
            
            item.Domicilio = Domicilio;
            
            item.Telefono = Telefono;
            
            item.IdUsuarioRegistro = IdUsuarioRegistro;
            
            item.FechaRegistro = FechaRegistro;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int IdDonante,bool Extranjero,int NumeroDocumento,string Apellido,string Nombre,int IdSexo,DateTime FechaNacimiento,string LugarNacimiento,string Domicilio,string Telefono,int IdUsuarioRegistro,DateTime FechaRegistro)
	    {
		    BdsDonante item = new BdsDonante();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.IdDonante = IdDonante;
				
			item.Extranjero = Extranjero;
				
			item.NumeroDocumento = NumeroDocumento;
				
			item.Apellido = Apellido;
				
			item.Nombre = Nombre;
				
			item.IdSexo = IdSexo;
				
			item.FechaNacimiento = FechaNacimiento;
				
			item.LugarNacimiento = LugarNacimiento;
				
			item.Domicilio = Domicilio;
				
			item.Telefono = Telefono;
				
			item.IdUsuarioRegistro = IdUsuarioRegistro;
				
			item.FechaRegistro = FechaRegistro;
				
	        item.Save(UserName);
	    }
    }
}
