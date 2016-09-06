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
	/// Strongly-typed collection for the AutMovimientoItemMovimiento class.
	/// </summary>
    [Serializable]
	public partial class AutMovimientoItemMovimientoCollection : ActiveList<AutMovimientoItemMovimiento, AutMovimientoItemMovimientoCollection>
	{	   
		public AutMovimientoItemMovimientoCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>AutMovimientoItemMovimientoCollection</returns>
		public AutMovimientoItemMovimientoCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                AutMovimientoItemMovimiento o = this[i];
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
	/// This is an ActiveRecord class which wraps the AUT_Movimiento_ItemMovimiento table.
	/// </summary>
	[Serializable]
	public partial class AutMovimientoItemMovimiento : ActiveRecord<AutMovimientoItemMovimiento>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public AutMovimientoItemMovimiento()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public AutMovimientoItemMovimiento(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public AutMovimientoItemMovimiento(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public AutMovimientoItemMovimiento(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("AUT_Movimiento_ItemMovimiento", TableType.Table, DataService.GetInstance("RisProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarIdMovimientoItemMovimiento = new TableSchema.TableColumn(schema);
				colvarIdMovimientoItemMovimiento.ColumnName = "idMovimientoItemMovimiento";
				colvarIdMovimientoItemMovimiento.DataType = DbType.Int32;
				colvarIdMovimientoItemMovimiento.MaxLength = 0;
				colvarIdMovimientoItemMovimiento.AutoIncrement = true;
				colvarIdMovimientoItemMovimiento.IsNullable = false;
				colvarIdMovimientoItemMovimiento.IsPrimaryKey = true;
				colvarIdMovimientoItemMovimiento.IsForeignKey = false;
				colvarIdMovimientoItemMovimiento.IsReadOnly = false;
				colvarIdMovimientoItemMovimiento.DefaultSetting = @"";
				colvarIdMovimientoItemMovimiento.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdMovimientoItemMovimiento);
				
				TableSchema.TableColumn colvarIdMovimiento = new TableSchema.TableColumn(schema);
				colvarIdMovimiento.ColumnName = "idMovimiento";
				colvarIdMovimiento.DataType = DbType.Int32;
				colvarIdMovimiento.MaxLength = 0;
				colvarIdMovimiento.AutoIncrement = false;
				colvarIdMovimiento.IsNullable = false;
				colvarIdMovimiento.IsPrimaryKey = false;
				colvarIdMovimiento.IsForeignKey = false;
				colvarIdMovimiento.IsReadOnly = false;
				colvarIdMovimiento.DefaultSetting = @"";
				colvarIdMovimiento.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdMovimiento);
				
				TableSchema.TableColumn colvarIdItemMovimiento = new TableSchema.TableColumn(schema);
				colvarIdItemMovimiento.ColumnName = "idItemMovimiento";
				colvarIdItemMovimiento.DataType = DbType.Int32;
				colvarIdItemMovimiento.MaxLength = 0;
				colvarIdItemMovimiento.AutoIncrement = false;
				colvarIdItemMovimiento.IsNullable = false;
				colvarIdItemMovimiento.IsPrimaryKey = false;
				colvarIdItemMovimiento.IsForeignKey = false;
				colvarIdItemMovimiento.IsReadOnly = false;
				colvarIdItemMovimiento.DefaultSetting = @"";
				colvarIdItemMovimiento.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdItemMovimiento);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["RisProvider"].AddSchema("AUT_Movimiento_ItemMovimiento",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("IdMovimientoItemMovimiento")]
		[Bindable(true)]
		public int IdMovimientoItemMovimiento 
		{
			get { return GetColumnValue<int>(Columns.IdMovimientoItemMovimiento); }
			set { SetColumnValue(Columns.IdMovimientoItemMovimiento, value); }
		}
		  
		[XmlAttribute("IdMovimiento")]
		[Bindable(true)]
		public int IdMovimiento 
		{
			get { return GetColumnValue<int>(Columns.IdMovimiento); }
			set { SetColumnValue(Columns.IdMovimiento, value); }
		}
		  
		[XmlAttribute("IdItemMovimiento")]
		[Bindable(true)]
		public int IdItemMovimiento 
		{
			get { return GetColumnValue<int>(Columns.IdItemMovimiento); }
			set { SetColumnValue(Columns.IdItemMovimiento, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(int varIdMovimiento,int varIdItemMovimiento)
		{
			AutMovimientoItemMovimiento item = new AutMovimientoItemMovimiento();
			
			item.IdMovimiento = varIdMovimiento;
			
			item.IdItemMovimiento = varIdItemMovimiento;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varIdMovimientoItemMovimiento,int varIdMovimiento,int varIdItemMovimiento)
		{
			AutMovimientoItemMovimiento item = new AutMovimientoItemMovimiento();
			
				item.IdMovimientoItemMovimiento = varIdMovimientoItemMovimiento;
			
				item.IdMovimiento = varIdMovimiento;
			
				item.IdItemMovimiento = varIdItemMovimiento;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn IdMovimientoItemMovimientoColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn IdMovimientoColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn IdItemMovimientoColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string IdMovimientoItemMovimiento = @"idMovimientoItemMovimiento";
			 public static string IdMovimiento = @"idMovimiento";
			 public static string IdItemMovimiento = @"idItemMovimiento";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
