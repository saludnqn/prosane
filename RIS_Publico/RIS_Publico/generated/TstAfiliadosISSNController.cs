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
    /// Controller class for TST_AfiliadosISSN
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class TstAfiliadosISSNController
    {
        // Preload our schema..
        TstAfiliadosISSN thisSchemaLoad = new TstAfiliadosISSN();
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
        public TstAfiliadosISSNCollection FetchAll()
        {
            TstAfiliadosISSNCollection coll = new TstAfiliadosISSNCollection();
            Query qry = new Query(TstAfiliadosISSN.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public TstAfiliadosISSNCollection FetchByID(object Id)
        {
            TstAfiliadosISSNCollection coll = new TstAfiliadosISSNCollection().Where("id", Id).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public TstAfiliadosISSNCollection FetchByQuery(Query qry)
        {
            TstAfiliadosISSNCollection coll = new TstAfiliadosISSNCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object Id)
        {
            return (TstAfiliadosISSN.Delete(Id) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object Id)
        {
            return (TstAfiliadosISSN.Destroy(Id) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string TipoDoc,int? NroDoc,string ApeNom,string Domicilio,float? SimilarityLocalidad,string Reparticion,string NroAfiliado,string Carga,string FechaNacimiento,string FechaIngreso,string FechaVencimiento,string LocalidadOriginal,string SysLocalidad,int? IdLocalidad,float? Similarity,float? Confidence,string Apellido,string Nombre,DateTime? FechaNacimiento2,DateTime? FechaIngreso2,string NumeroAfiliado)
	    {
		    TstAfiliadosISSN item = new TstAfiliadosISSN();
		    
            item.TipoDoc = TipoDoc;
            
            item.NroDoc = NroDoc;
            
            item.ApeNom = ApeNom;
            
            item.Domicilio = Domicilio;
            
            item.SimilarityLocalidad = SimilarityLocalidad;
            
            item.Reparticion = Reparticion;
            
            item.NroAfiliado = NroAfiliado;
            
            item.Carga = Carga;
            
            item.FechaNacimiento = FechaNacimiento;
            
            item.FechaIngreso = FechaIngreso;
            
            item.FechaVencimiento = FechaVencimiento;
            
            item.LocalidadOriginal = LocalidadOriginal;
            
            item.SysLocalidad = SysLocalidad;
            
            item.IdLocalidad = IdLocalidad;
            
            item.Similarity = Similarity;
            
            item.Confidence = Confidence;
            
            item.Apellido = Apellido;
            
            item.Nombre = Nombre;
            
            item.FechaNacimiento2 = FechaNacimiento2;
            
            item.FechaIngreso2 = FechaIngreso2;
            
            item.NumeroAfiliado = NumeroAfiliado;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int Id,string TipoDoc,int? NroDoc,string ApeNom,string Domicilio,float? SimilarityLocalidad,string Reparticion,string NroAfiliado,string Carga,string FechaNacimiento,string FechaIngreso,string FechaVencimiento,string LocalidadOriginal,string SysLocalidad,int? IdLocalidad,float? Similarity,float? Confidence,string Apellido,string Nombre,DateTime? FechaNacimiento2,DateTime? FechaIngreso2,string NumeroAfiliado)
	    {
		    TstAfiliadosISSN item = new TstAfiliadosISSN();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.Id = Id;
				
			item.TipoDoc = TipoDoc;
				
			item.NroDoc = NroDoc;
				
			item.ApeNom = ApeNom;
				
			item.Domicilio = Domicilio;
				
			item.SimilarityLocalidad = SimilarityLocalidad;
				
			item.Reparticion = Reparticion;
				
			item.NroAfiliado = NroAfiliado;
				
			item.Carga = Carga;
				
			item.FechaNacimiento = FechaNacimiento;
				
			item.FechaIngreso = FechaIngreso;
				
			item.FechaVencimiento = FechaVencimiento;
				
			item.LocalidadOriginal = LocalidadOriginal;
				
			item.SysLocalidad = SysLocalidad;
				
			item.IdLocalidad = IdLocalidad;
				
			item.Similarity = Similarity;
				
			item.Confidence = Confidence;
				
			item.Apellido = Apellido;
				
			item.Nombre = Nombre;
				
			item.FechaNacimiento2 = FechaNacimiento2;
				
			item.FechaIngreso2 = FechaIngreso2;
				
			item.NumeroAfiliado = NumeroAfiliado;
				
	        item.Save(UserName);
	    }
    }
}
