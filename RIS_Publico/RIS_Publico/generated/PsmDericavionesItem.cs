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
	/// Strongly-typed collection for the PsmDericavionesItem class.
	/// </summary>
    [Serializable]
	public partial class PsmDericavionesItemCollection : ActiveList<PsmDericavionesItem, PsmDericavionesItemCollection>
	{	   
		public PsmDericavionesItemCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>PsmDericavionesItemCollection</returns>
		public PsmDericavionesItemCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                PsmDericavionesItem o = this[i];
                foreach (SubSonic.Where w in this.wheres)
                {
                    bool remove = false;
                    System.Reflection.PropertyInfo pi = o.GetType().GetProperty(w.ColumnName);
                    if (pi.CanRead)
                    {
                        object val = pi.GetValue(o, null);
                        switch (w.Comparison)
                        {
                            case SubSonic.Comparison.Equals:
                                if (!val.Equals(w.ParameterValue))
                                {
                                    remove = true;
                                }
                                break;
                        }
                    }
                    if (remove)
                    {
                        this.Remove(o);
                        break;
                    }
                }
            }
            return this;
        }
		
		
	}
	/// <summary>
	/// This is an ActiveRecord class which wraps the PSM_DericavionesItems table.
	/// </summary>
	[Serializable]
	public partial class PsmDericavionesItem : ActiveRecord<PsmDericavionesItem>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public PsmDericavionesItem()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public PsmDericavionesItem(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public PsmDericavionesItem(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public PsmDericavionesItem(string columnName, object columnValue)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByParam(columnName,columnValue);
		}
		
		protected static void SetSQLProps() { GetTableSchema(); }
		
		#endregion
		
		#region Schema and Query Accessor	
		public static Query CreateQuery() { return new Query(Schema); }
		public static TableSchema.Table Schema
		{
			get
			{
				if (BaseSchema == null)
					SetSQLProps();
				return BaseSchema;
			}
		}
		
		private static void GetTableSchema() 
		{
			if(!IsSchemaInitialized)
			{
				//Schema declaration
				TableSchema.Table schema = new TableSchema.Table("PSM_DericavionesItems", TableType.Table, DataService.GetInstance("RisProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarIdPSMDerivacines = new TableSchema.TableColumn(schema);
				colvarIdPSMDerivacines.ColumnName = "idPSMDerivacines";
				colvarIdPSMDerivacines.DataType = DbType.String;
				colvarIdPSMDerivacines.MaxLength = 10;
				colvarIdPSMDerivacines.AutoIncrement = false;
				colvarIdPSMDerivacines.IsNullable = false;
				colvarIdPSMDerivacines.IsPrimaryKey = true;
				colvarIdPSMDerivacines.IsForeignKey = false;
				colvarIdPSMDerivacines.IsReadOnly = false;
				colvarIdPSMDerivacines.DefaultSetting = @"";
				colvarIdPSMDerivacines.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdPSMDerivacines);
				
				TableSchema.TableColumn colvarNombre = new TableSchema.TableColumn(schema);
				colvarNombre.ColumnName = "Nombre";
				colvarNombre.DataType = DbType.String;
				colvarNombre.MaxLength = 100;
				colvarNombre.AutoIncrement = false;
				colvarNombre.IsNullable = true;
				colvarNombre.IsPrimaryKey = false;
				colvarNombre.IsForeignKey = false;
				colvarNombre.IsReadOnly = false;
				colvarNombre.DefaultSetting = @"";
				colvarNombre.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNombre);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["RisProvider"].AddSchema("PSM_DericavionesItems",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("IdPSMDerivacines")]
		[Bindable(true)]
		public string IdPSMDerivacines 
		{
			get { return GetColumnValue<string>(Columns.IdPSMDerivacines); }
			set { SetColumnValue(Columns.IdPSMDerivacines, value); }
		}
		  
		[XmlAttribute("Nombre")]
		[Bindable(true)]
		public string Nombre 
		{
			get { return GetColumnValue<string>(Columns.Nombre); }
			set { SetColumnValue(Columns.Nombre, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varIdPSMDerivacines,string varNombre)
		{
			PsmDericavionesItem item = new PsmDericavionesItem();
			
			item.IdPSMDerivacines = varIdPSMDerivacines;
			
			item.Nombre = varNombre;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(string varIdPSMDerivacines,string varNombre)
		{
			PsmDericavionesItem item = new PsmDericavionesItem();
			
				item.IdPSMDerivacines = varIdPSMDerivacines;
			
				item.Nombre = varNombre;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn IdPSMDerivacinesColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn NombreColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string IdPSMDerivacines = @"idPSMDerivacines";
			 public static string Nombre = @"Nombre";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
