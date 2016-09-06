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
	/// Strongly-typed collection for the SysBorrar class.
	/// </summary>
    [Serializable]
	public partial class SysBorrarCollection : ActiveList<SysBorrar, SysBorrarCollection>
	{	   
		public SysBorrarCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>SysBorrarCollection</returns>
		public SysBorrarCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                SysBorrar o = this[i];
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
	/// This is an ActiveRecord class which wraps the Sys_Borrar table.
	/// </summary>
	[Serializable]
	public partial class SysBorrar : ActiveRecord<SysBorrar>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public SysBorrar()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public SysBorrar(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public SysBorrar(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public SysBorrar(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("Sys_Borrar", TableType.Table, DataService.GetInstance("RisProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarIdBorrar = new TableSchema.TableColumn(schema);
				colvarIdBorrar.ColumnName = "idBorrar";
				colvarIdBorrar.DataType = DbType.Int32;
				colvarIdBorrar.MaxLength = 0;
				colvarIdBorrar.AutoIncrement = true;
				colvarIdBorrar.IsNullable = false;
				colvarIdBorrar.IsPrimaryKey = true;
				colvarIdBorrar.IsForeignKey = false;
				colvarIdBorrar.IsReadOnly = false;
				colvarIdBorrar.DefaultSetting = @"";
				colvarIdBorrar.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdBorrar);
				
				TableSchema.TableColumn colvarNombre = new TableSchema.TableColumn(schema);
				colvarNombre.ColumnName = "nombre";
				colvarNombre.DataType = DbType.AnsiString;
				colvarNombre.MaxLength = 50;
				colvarNombre.AutoIncrement = false;
				colvarNombre.IsNullable = true;
				colvarNombre.IsPrimaryKey = false;
				colvarNombre.IsForeignKey = false;
				colvarNombre.IsReadOnly = false;
				colvarNombre.DefaultSetting = @"";
				colvarNombre.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNombre);
				
				TableSchema.TableColumn colvarCodigoIndec = new TableSchema.TableColumn(schema);
				colvarCodigoIndec.ColumnName = "codigoIndec";
				colvarCodigoIndec.DataType = DbType.AnsiString;
				colvarCodigoIndec.MaxLength = 50;
				colvarCodigoIndec.AutoIncrement = false;
				colvarCodigoIndec.IsNullable = true;
				colvarCodigoIndec.IsPrimaryKey = false;
				colvarCodigoIndec.IsForeignKey = false;
				colvarCodigoIndec.IsReadOnly = false;
				colvarCodigoIndec.DefaultSetting = @"";
				colvarCodigoIndec.ForeignKeyTableName = "";
				schema.Columns.Add(colvarCodigoIndec);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["RisProvider"].AddSchema("Sys_Borrar",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("IdBorrar")]
		[Bindable(true)]
		public int IdBorrar 
		{
			get { return GetColumnValue<int>(Columns.IdBorrar); }
			set { SetColumnValue(Columns.IdBorrar, value); }
		}
		  
		[XmlAttribute("Nombre")]
		[Bindable(true)]
		public string Nombre 
		{
			get { return GetColumnValue<string>(Columns.Nombre); }
			set { SetColumnValue(Columns.Nombre, value); }
		}
		  
		[XmlAttribute("CodigoIndec")]
		[Bindable(true)]
		public string CodigoIndec 
		{
			get { return GetColumnValue<string>(Columns.CodigoIndec); }
			set { SetColumnValue(Columns.CodigoIndec, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varNombre,string varCodigoIndec)
		{
			SysBorrar item = new SysBorrar();
			
			item.Nombre = varNombre;
			
			item.CodigoIndec = varCodigoIndec;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varIdBorrar,string varNombre,string varCodigoIndec)
		{
			SysBorrar item = new SysBorrar();
			
				item.IdBorrar = varIdBorrar;
			
				item.Nombre = varNombre;
			
				item.CodigoIndec = varCodigoIndec;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn IdBorrarColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn NombreColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn CodigoIndecColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string IdBorrar = @"idBorrar";
			 public static string Nombre = @"nombre";
			 public static string CodigoIndec = @"codigoIndec";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
