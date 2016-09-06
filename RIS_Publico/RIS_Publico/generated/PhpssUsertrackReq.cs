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
	/// Strongly-typed collection for the PhpssUsertrackReq class.
	/// </summary>
    [Serializable]
	public partial class PhpssUsertrackReqCollection : ActiveList<PhpssUsertrackReq, PhpssUsertrackReqCollection>
	{	   
		public PhpssUsertrackReqCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>PhpssUsertrackReqCollection</returns>
		public PhpssUsertrackReqCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                PhpssUsertrackReq o = this[i];
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
	/// This is an ActiveRecord class which wraps the phpss_usertrack_req table.
	/// </summary>
	[Serializable]
	public partial class PhpssUsertrackReq : ActiveRecord<PhpssUsertrackReq>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public PhpssUsertrackReq()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public PhpssUsertrackReq(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public PhpssUsertrackReq(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public PhpssUsertrackReq(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("phpss_usertrack_req", TableType.Table, DataService.GetInstance("RisProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarId = new TableSchema.TableColumn(schema);
				colvarId.ColumnName = "id";
				colvarId.DataType = DbType.Int64;
				colvarId.MaxLength = 0;
				colvarId.AutoIncrement = true;
				colvarId.IsNullable = false;
				colvarId.IsPrimaryKey = true;
				colvarId.IsForeignKey = false;
				colvarId.IsReadOnly = false;
				colvarId.DefaultSetting = @"";
				colvarId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarId);
				
				TableSchema.TableColumn colvarSessionfid = new TableSchema.TableColumn(schema);
				colvarSessionfid.ColumnName = "sessionfid";
				colvarSessionfid.DataType = DbType.Int32;
				colvarSessionfid.MaxLength = 0;
				colvarSessionfid.AutoIncrement = false;
				colvarSessionfid.IsNullable = false;
				colvarSessionfid.IsPrimaryKey = false;
				colvarSessionfid.IsForeignKey = false;
				colvarSessionfid.IsReadOnly = false;
				colvarSessionfid.DefaultSetting = @"";
				colvarSessionfid.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSessionfid);
				
				TableSchema.TableColumn colvarAccountfid = new TableSchema.TableColumn(schema);
				colvarAccountfid.ColumnName = "accountfid";
				colvarAccountfid.DataType = DbType.Int16;
				colvarAccountfid.MaxLength = 0;
				colvarAccountfid.AutoIncrement = false;
				colvarAccountfid.IsNullable = false;
				colvarAccountfid.IsPrimaryKey = false;
				colvarAccountfid.IsForeignKey = false;
				colvarAccountfid.IsReadOnly = false;
				colvarAccountfid.DefaultSetting = @"";
				colvarAccountfid.ForeignKeyTableName = "";
				schema.Columns.Add(colvarAccountfid);
				
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
				
				TableSchema.TableColumn colvarUsertrackUrlfid = new TableSchema.TableColumn(schema);
				colvarUsertrackUrlfid.ColumnName = "usertrack_urlfid";
				colvarUsertrackUrlfid.DataType = DbType.Int32;
				colvarUsertrackUrlfid.MaxLength = 0;
				colvarUsertrackUrlfid.AutoIncrement = false;
				colvarUsertrackUrlfid.IsNullable = false;
				colvarUsertrackUrlfid.IsPrimaryKey = false;
				colvarUsertrackUrlfid.IsForeignKey = false;
				colvarUsertrackUrlfid.IsReadOnly = false;
				colvarUsertrackUrlfid.DefaultSetting = @"";
				colvarUsertrackUrlfid.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUsertrackUrlfid);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["RisProvider"].AddSchema("phpss_usertrack_req",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("Id")]
		[Bindable(true)]
		public long Id 
		{
			get { return GetColumnValue<long>(Columns.Id); }
			set { SetColumnValue(Columns.Id, value); }
		}
		  
		[XmlAttribute("Sessionfid")]
		[Bindable(true)]
		public int Sessionfid 
		{
			get { return GetColumnValue<int>(Columns.Sessionfid); }
			set { SetColumnValue(Columns.Sessionfid, value); }
		}
		  
		[XmlAttribute("Accountfid")]
		[Bindable(true)]
		public short Accountfid 
		{
			get { return GetColumnValue<short>(Columns.Accountfid); }
			set { SetColumnValue(Columns.Accountfid, value); }
		}
		  
		[XmlAttribute("Timestamp")]
		[Bindable(true)]
		public DateTime Timestamp 
		{
			get { return GetColumnValue<DateTime>(Columns.Timestamp); }
			set { SetColumnValue(Columns.Timestamp, value); }
		}
		  
		[XmlAttribute("UsertrackUrlfid")]
		[Bindable(true)]
		public int UsertrackUrlfid 
		{
			get { return GetColumnValue<int>(Columns.UsertrackUrlfid); }
			set { SetColumnValue(Columns.UsertrackUrlfid, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(int varSessionfid,short varAccountfid,DateTime varTimestamp,int varUsertrackUrlfid)
		{
			PhpssUsertrackReq item = new PhpssUsertrackReq();
			
			item.Sessionfid = varSessionfid;
			
			item.Accountfid = varAccountfid;
			
			item.Timestamp = varTimestamp;
			
			item.UsertrackUrlfid = varUsertrackUrlfid;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(long varId,int varSessionfid,short varAccountfid,DateTime varTimestamp,int varUsertrackUrlfid)
		{
			PhpssUsertrackReq item = new PhpssUsertrackReq();
			
				item.Id = varId;
			
				item.Sessionfid = varSessionfid;
			
				item.Accountfid = varAccountfid;
			
				item.Timestamp = varTimestamp;
			
				item.UsertrackUrlfid = varUsertrackUrlfid;
			
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
        
        
        
        public static TableSchema.TableColumn SessionfidColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn AccountfidColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn TimestampColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn UsertrackUrlfidColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string Id = @"id";
			 public static string Sessionfid = @"sessionfid";
			 public static string Accountfid = @"accountfid";
			 public static string Timestamp = @"timestamp";
			 public static string UsertrackUrlfid = @"usertrack_urlfid";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
