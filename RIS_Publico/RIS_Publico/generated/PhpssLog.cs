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
	/// Strongly-typed collection for the PhpssLog class.
	/// </summary>
    [Serializable]
	public partial class PhpssLogCollection : ActiveList<PhpssLog, PhpssLogCollection>
	{	   
		public PhpssLogCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>PhpssLogCollection</returns>
		public PhpssLogCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                PhpssLog o = this[i];
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
	/// This is an ActiveRecord class which wraps the phpss_log table.
	/// </summary>
	[Serializable]
	public partial class PhpssLog : ActiveRecord<PhpssLog>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public PhpssLog()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public PhpssLog(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public PhpssLog(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public PhpssLog(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("phpss_log", TableType.Table, DataService.GetInstance("RisProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarId = new TableSchema.TableColumn(schema);
				colvarId.ColumnName = "id";
				colvarId.DataType = DbType.Int32;
				colvarId.MaxLength = 0;
				colvarId.AutoIncrement = true;
				colvarId.IsNullable = false;
				colvarId.IsPrimaryKey = true;
				colvarId.IsForeignKey = false;
				colvarId.IsReadOnly = false;
				colvarId.DefaultSetting = @"";
				colvarId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarId);
				
				TableSchema.TableColumn colvarTimestamp = new TableSchema.TableColumn(schema);
				colvarTimestamp.ColumnName = "timestamp";
				colvarTimestamp.DataType = DbType.DateTime;
				colvarTimestamp.MaxLength = 0;
				colvarTimestamp.AutoIncrement = false;
				colvarTimestamp.IsNullable = false;
				colvarTimestamp.IsPrimaryKey = false;
				colvarTimestamp.IsForeignKey = false;
				colvarTimestamp.IsReadOnly = false;
				colvarTimestamp.DefaultSetting = @"";
				colvarTimestamp.ForeignKeyTableName = "";
				schema.Columns.Add(colvarTimestamp);
				
				TableSchema.TableColumn colvarSessionfid = new TableSchema.TableColumn(schema);
				colvarSessionfid.ColumnName = "sessionfid";
				colvarSessionfid.DataType = DbType.Int32;
				colvarSessionfid.MaxLength = 0;
				colvarSessionfid.AutoIncrement = false;
				colvarSessionfid.IsNullable = true;
				colvarSessionfid.IsPrimaryKey = false;
				colvarSessionfid.IsForeignKey = false;
				colvarSessionfid.IsReadOnly = false;
				colvarSessionfid.DefaultSetting = @"";
				colvarSessionfid.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSessionfid);
				
				TableSchema.TableColumn colvarAccountfid = new TableSchema.TableColumn(schema);
				colvarAccountfid.ColumnName = "accountfid";
				colvarAccountfid.DataType = DbType.Int32;
				colvarAccountfid.MaxLength = 0;
				colvarAccountfid.AutoIncrement = false;
				colvarAccountfid.IsNullable = true;
				colvarAccountfid.IsPrimaryKey = false;
				colvarAccountfid.IsForeignKey = false;
				colvarAccountfid.IsReadOnly = false;
				colvarAccountfid.DefaultSetting = @"";
				colvarAccountfid.ForeignKeyTableName = "";
				schema.Columns.Add(colvarAccountfid);
				
				TableSchema.TableColumn colvarIpfid = new TableSchema.TableColumn(schema);
				colvarIpfid.ColumnName = "ipfid";
				colvarIpfid.DataType = DbType.Int32;
				colvarIpfid.MaxLength = 0;
				colvarIpfid.AutoIncrement = false;
				colvarIpfid.IsNullable = false;
				colvarIpfid.IsPrimaryKey = false;
				colvarIpfid.IsForeignKey = false;
				colvarIpfid.IsReadOnly = false;
				colvarIpfid.DefaultSetting = @"";
				colvarIpfid.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIpfid);
				
				TableSchema.TableColumn colvarModuleX = new TableSchema.TableColumn(schema);
				colvarModuleX.ColumnName = "module";
				colvarModuleX.DataType = DbType.AnsiString;
				colvarModuleX.MaxLength = 64;
				colvarModuleX.AutoIncrement = false;
				colvarModuleX.IsNullable = false;
				colvarModuleX.IsPrimaryKey = false;
				colvarModuleX.IsForeignKey = false;
				colvarModuleX.IsReadOnly = false;
				colvarModuleX.DefaultSetting = @"";
				colvarModuleX.ForeignKeyTableName = "";
				schema.Columns.Add(colvarModuleX);
				
				TableSchema.TableColumn colvarMessage = new TableSchema.TableColumn(schema);
				colvarMessage.ColumnName = "message";
				colvarMessage.DataType = DbType.AnsiString;
				colvarMessage.MaxLength = 255;
				colvarMessage.AutoIncrement = false;
				colvarMessage.IsNullable = false;
				colvarMessage.IsPrimaryKey = false;
				colvarMessage.IsForeignKey = false;
				colvarMessage.IsReadOnly = false;
				colvarMessage.DefaultSetting = @"";
				colvarMessage.ForeignKeyTableName = "";
				schema.Columns.Add(colvarMessage);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["RisProvider"].AddSchema("phpss_log",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("Id")]
		[Bindable(true)]
		public int Id 
		{
			get { return GetColumnValue<int>(Columns.Id); }
			set { SetColumnValue(Columns.Id, value); }
		}
		  
		[XmlAttribute("Timestamp")]
		[Bindable(true)]
		public DateTime Timestamp 
		{
			get { return GetColumnValue<DateTime>(Columns.Timestamp); }
			set { SetColumnValue(Columns.Timestamp, value); }
		}
		  
		[XmlAttribute("Sessionfid")]
		[Bindable(true)]
		public int? Sessionfid 
		{
			get { return GetColumnValue<int?>(Columns.Sessionfid); }
			set { SetColumnValue(Columns.Sessionfid, value); }
		}
		  
		[XmlAttribute("Accountfid")]
		[Bindable(true)]
		public int? Accountfid 
		{
			get { return GetColumnValue<int?>(Columns.Accountfid); }
			set { SetColumnValue(Columns.Accountfid, value); }
		}
		  
		[XmlAttribute("Ipfid")]
		[Bindable(true)]
		public int Ipfid 
		{
			get { return GetColumnValue<int>(Columns.Ipfid); }
			set { SetColumnValue(Columns.Ipfid, value); }
		}
		  
		[XmlAttribute("ModuleX")]
		[Bindable(true)]
		public string ModuleX 
		{
			get { return GetColumnValue<string>(Columns.ModuleX); }
			set { SetColumnValue(Columns.ModuleX, value); }
		}
		  
		[XmlAttribute("Message")]
		[Bindable(true)]
		public string Message 
		{
			get { return GetColumnValue<string>(Columns.Message); }
			set { SetColumnValue(Columns.Message, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(DateTime varTimestamp,int? varSessionfid,int? varAccountfid,int varIpfid,string varModuleX,string varMessage)
		{
			PhpssLog item = new PhpssLog();
			
			item.Timestamp = varTimestamp;
			
			item.Sessionfid = varSessionfid;
			
			item.Accountfid = varAccountfid;
			
			item.Ipfid = varIpfid;
			
			item.ModuleX = varModuleX;
			
			item.Message = varMessage;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varId,DateTime varTimestamp,int? varSessionfid,int? varAccountfid,int varIpfid,string varModuleX,string varMessage)
		{
			PhpssLog item = new PhpssLog();
			
				item.Id = varId;
			
				item.Timestamp = varTimestamp;
			
				item.Sessionfid = varSessionfid;
			
				item.Accountfid = varAccountfid;
			
				item.Ipfid = varIpfid;
			
				item.ModuleX = varModuleX;
			
				item.Message = varMessage;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn IdColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn TimestampColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn SessionfidColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn AccountfidColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn IpfidColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn ModuleXColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        public static TableSchema.TableColumn MessageColumn
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string Id = @"id";
			 public static string Timestamp = @"timestamp";
			 public static string Sessionfid = @"sessionfid";
			 public static string Accountfid = @"accountfid";
			 public static string Ipfid = @"ipfid";
			 public static string ModuleX = @"module";
			 public static string Message = @"message";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
