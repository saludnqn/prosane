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
	/// Strongly-typed collection for the AutPmpItemMovimiento class.
	/// </summary>
    [Serializable]
	public partial class AutPmpItemMovimientoCollection : ActiveList<AutPmpItemMovimiento, AutPmpItemMovimientoCollection>
	{	   
		public AutPmpItemMovimientoCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>AutPmpItemMovimientoCollection</returns>
		public AutPmpItemMovimientoCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                AutPmpItemMovimiento o = this[i];
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
	/// This is an ActiveRecord class which wraps the AUT_PMP_ItemMovimiento table.
	/// </summary>
	[Serializable]
	public partial class AutPmpItemMovimiento : ActiveRecord<AutPmpItemMovimiento>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public AutPmpItemMovimiento()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public AutPmpItemMovimiento(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public AutPmpItemMovimiento(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public AutPmpItemMovimiento(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("AUT_PMP_ItemMovimiento", TableType.Table, DataService.GetInstance("RisProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarIdPMPItemMovimiento = new TableSchema.TableColumn(schema);
				colvarIdPMPItemMovimiento.ColumnName = "idPMPItemMovimiento";
				colvarIdPMPItemMovimiento.DataType = DbType.Int32;
				colvarIdPMPItemMovimiento.MaxLength = 0;
				colvarIdPMPItemMovimiento.AutoIncrement = true;
				colvarIdPMPItemMovimiento.IsNullable = false;
				colvarIdPMPItemMovimiento.IsPrimaryKey = true;
				colvarIdPMPItemMovimiento.IsForeignKey = false;
				colvarIdPMPItemMovimiento.IsReadOnly = false;
				colvarIdPMPItemMovimiento.DefaultSetting = @"";
				colvarIdPMPItemMovimiento.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdPMPItemMovimiento);
				
				TableSchema.TableColumn colvarIdPMP = new TableSchema.TableColumn(schema);
				colvarIdPMP.ColumnName = "idPMP";
				colvarIdPMP.DataType = DbType.Int32;
				colvarIdPMP.MaxLength = 0;
				colvarIdPMP.AutoIncrement = false;
				colvarIdPMP.IsNullable = false;
				colvarIdPMP.IsPrimaryKey = false;
				colvarIdPMP.IsForeignKey = false;
				colvarIdPMP.IsReadOnly = false;
				colvarIdPMP.DefaultSetting = @"";
				colvarIdPMP.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdPMP);
				
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
				DataService.Providers["RisProvider"].AddSchema("AUT_PMP_ItemMovimiento",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("IdPMPItemMovimiento")]
		[Bindable(true)]
		public int IdPMPItemMovimiento 
		{
			get { return GetColumnValue<int>(Columns.IdPMPItemMovimiento); }
			set { SetColumnValue(Columns.IdPMPItemMovimiento, value); }
		}
		  
		[XmlAttribute("IdPMP")]
		[Bindable(true)]
		public int IdPMP 
		{
			get { return GetColumnValue<int>(Columns.IdPMP); }
			set { SetColumnValue(Columns.IdPMP, value); }
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
		public static void Insert(int varIdPMP,int varIdItemMovimiento)
		{
			AutPmpItemMovimiento item = new AutPmpItemMovimiento();
			
			item.IdPMP = varIdPMP;
			
			item.IdItemMovimiento = varIdItemMovimiento;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varIdPMPItemMovimiento,int varIdPMP,int varIdItemMovimiento)
		{
			AutPmpItemMovimiento item = new AutPmpItemMovimiento();
			
				item.IdPMPItemMovimiento = varIdPMPItemMovimiento;
			
				item.IdPMP = varIdPMP;
			
				item.IdItemMovimiento = varIdItemMovimiento;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn IdPMPItemMovimientoColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn IdPMPColumn
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
			 public static string IdPMPItemMovimiento = @"idPMPItemMovimiento";
			 public static string IdPMP = @"idPMP";
			 public static string IdItemMovimiento = @"idItemMovimiento";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
