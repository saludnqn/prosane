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
	/// Strongly-typed collection for the FacNomencladorExclusion class.
	/// </summary>
    [Serializable]
	public partial class FacNomencladorExclusionCollection : ActiveList<FacNomencladorExclusion, FacNomencladorExclusionCollection>
	{	   
		public FacNomencladorExclusionCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>FacNomencladorExclusionCollection</returns>
		public FacNomencladorExclusionCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                FacNomencladorExclusion o = this[i];
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
	/// This is an ActiveRecord class which wraps the FAC_NomencladorExclusion table.
	/// </summary>
	[Serializable]
	public partial class FacNomencladorExclusion : ActiveRecord<FacNomencladorExclusion>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public FacNomencladorExclusion()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public FacNomencladorExclusion(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public FacNomencladorExclusion(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public FacNomencladorExclusion(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("FAC_NomencladorExclusion", TableType.Table, DataService.GetInstance("RisProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarIdNomencladorExclusion = new TableSchema.TableColumn(schema);
				colvarIdNomencladorExclusion.ColumnName = "idNomencladorExclusion";
				colvarIdNomencladorExclusion.DataType = DbType.Int32;
				colvarIdNomencladorExclusion.MaxLength = 0;
				colvarIdNomencladorExclusion.AutoIncrement = true;
				colvarIdNomencladorExclusion.IsNullable = false;
				colvarIdNomencladorExclusion.IsPrimaryKey = true;
				colvarIdNomencladorExclusion.IsForeignKey = false;
				colvarIdNomencladorExclusion.IsReadOnly = false;
				colvarIdNomencladorExclusion.DefaultSetting = @"";
				colvarIdNomencladorExclusion.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdNomencladorExclusion);
				
				TableSchema.TableColumn colvarTipo = new TableSchema.TableColumn(schema);
				colvarTipo.ColumnName = "tipo";
				colvarTipo.DataType = DbType.AnsiString;
				colvarTipo.MaxLength = 50;
				colvarTipo.AutoIncrement = false;
				colvarTipo.IsNullable = false;
				colvarTipo.IsPrimaryKey = false;
				colvarTipo.IsForeignKey = false;
				colvarTipo.IsReadOnly = false;
				
						colvarTipo.DefaultSetting = @"('')";
				colvarTipo.ForeignKeyTableName = "";
				schema.Columns.Add(colvarTipo);
				
				TableSchema.TableColumn colvarDescripcion = new TableSchema.TableColumn(schema);
				colvarDescripcion.ColumnName = "descripcion";
				colvarDescripcion.DataType = DbType.AnsiString;
				colvarDescripcion.MaxLength = 255;
				colvarDescripcion.AutoIncrement = false;
				colvarDescripcion.IsNullable = false;
				colvarDescripcion.IsPrimaryKey = false;
				colvarDescripcion.IsForeignKey = false;
				colvarDescripcion.IsReadOnly = false;
				
						colvarDescripcion.DefaultSetting = @"('')";
				colvarDescripcion.ForeignKeyTableName = "";
				schema.Columns.Add(colvarDescripcion);
				
				TableSchema.TableColumn colvarPrecioSugerido = new TableSchema.TableColumn(schema);
				colvarPrecioSugerido.ColumnName = "precioSugerido";
				colvarPrecioSugerido.DataType = DbType.AnsiString;
				colvarPrecioSugerido.MaxLength = 200;
				colvarPrecioSugerido.AutoIncrement = false;
				colvarPrecioSugerido.IsNullable = false;
				colvarPrecioSugerido.IsPrimaryKey = false;
				colvarPrecioSugerido.IsForeignKey = false;
				colvarPrecioSugerido.IsReadOnly = false;
				
						colvarPrecioSugerido.DefaultSetting = @"('')";
				colvarPrecioSugerido.ForeignKeyTableName = "";
				schema.Columns.Add(colvarPrecioSugerido);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["RisProvider"].AddSchema("FAC_NomencladorExclusion",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("IdNomencladorExclusion")]
		[Bindable(true)]
		public int IdNomencladorExclusion 
		{
			get { return GetColumnValue<int>(Columns.IdNomencladorExclusion); }
			set { SetColumnValue(Columns.IdNomencladorExclusion, value); }
		}
		  
		[XmlAttribute("Tipo")]
		[Bindable(true)]
		public string Tipo 
		{
			get { return GetColumnValue<string>(Columns.Tipo); }
			set { SetColumnValue(Columns.Tipo, value); }
		}
		  
		[XmlAttribute("Descripcion")]
		[Bindable(true)]
		public string Descripcion 
		{
			get { return GetColumnValue<string>(Columns.Descripcion); }
			set { SetColumnValue(Columns.Descripcion, value); }
		}
		  
		[XmlAttribute("PrecioSugerido")]
		[Bindable(true)]
		public string PrecioSugerido 
		{
			get { return GetColumnValue<string>(Columns.PrecioSugerido); }
			set { SetColumnValue(Columns.PrecioSugerido, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varTipo,string varDescripcion,string varPrecioSugerido)
		{
			FacNomencladorExclusion item = new FacNomencladorExclusion();
			
			item.Tipo = varTipo;
			
			item.Descripcion = varDescripcion;
			
			item.PrecioSugerido = varPrecioSugerido;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varIdNomencladorExclusion,string varTipo,string varDescripcion,string varPrecioSugerido)
		{
			FacNomencladorExclusion item = new FacNomencladorExclusion();
			
				item.IdNomencladorExclusion = varIdNomencladorExclusion;
			
				item.Tipo = varTipo;
			
				item.Descripcion = varDescripcion;
			
				item.PrecioSugerido = varPrecioSugerido;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn IdNomencladorExclusionColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn TipoColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn DescripcionColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn PrecioSugeridoColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string IdNomencladorExclusion = @"idNomencladorExclusion";
			 public static string Tipo = @"tipo";
			 public static string Descripcion = @"descripcion";
			 public static string PrecioSugerido = @"precioSugerido";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
