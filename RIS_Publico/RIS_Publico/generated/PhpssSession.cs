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
	/// Strongly-typed collection for the PhpssSession class.
	/// </summary>
    [Serializable]
	public partial class PhpssSessionCollection : ActiveList<PhpssSession, PhpssSessionCollection>
	{	   
		public PhpssSessionCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>PhpssSessionCollection</returns>
		public PhpssSessionCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                PhpssSession o = this[i];
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
	/// This is an ActiveRecord class which wraps the phpss_session table.
	/// </summary>
	[Serializable]
	public partial class PhpssSession : ActiveRecord<PhpssSession>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public PhpssSession()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public PhpssSession(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public PhpssSession(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public PhpssSession(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("phpss_session", TableType.Table, DataService.GetInstance("RisProvider"));
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
				
				TableSchema.TableColumn colvarSessionkey = new TableSchema.TableColumn(schema);
				colvarSessionkey.ColumnName = "sessionkey";
				colvarSessionkey.DataType = DbType.AnsiStringFixedLength;
				colvarSessionkey.MaxLength = 32;
				colvarSessionkey.AutoIncrement = false;
				colvarSessionkey.IsNullable = false;
				colvarSessionkey.IsPrimaryKey = false;
				colvarSessionkey.IsForeignKey = false;
				colvarSessionkey.IsReadOnly = false;
				colvarSessionkey.DefaultSetting = @"";
				colvarSessionkey.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSessionkey);
				
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
				colvarIpfid.DataType = DbType.Int64;
				colvarIpfid.MaxLength = 0;
				colvarIpfid.AutoIncrement = false;
				colvarIpfid.IsNullable = false;
				colvarIpfid.IsPrimaryKey = false;
				colvarIpfid.IsForeignKey = false;
				colvarIpfid.IsReadOnly = false;
				colvarIpfid.DefaultSetting = @"";
				colvarIpfid.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIpfid);
				
				TableSchema.TableColumn colvarCreated = new TableSchema.TableColumn(schema);
				colvarCreated.ColumnName = "created";
				colvarCreated.DataType = DbType.DateTime;
				colvarCreated.MaxLength = 0;
				colvarCreated.AutoIncrement = false;
				colvarCreated.IsNullable = false;
				colvarCreated.IsPrimaryKey = false;
				colvarCreated.IsForeignKey = false;
				colvarCreated.IsReadOnly = false;
				colvarCreated.DefaultSetting = @"";
				colvarCreated.ForeignKeyTableName = "";
				schema.Columns.Add(colvarCreated);
				
				TableSchema.TableColumn colvarLastrequest = new TableSchema.TableColumn(schema);
				colvarLastrequest.ColumnName = "lastrequest";
				colvarLastrequest.DataType = DbType.DateTime;
				colvarLastrequest.MaxLength = 0;
				colvarLastrequest.AutoIncrement = false;
				colvarLastrequest.IsNullable = false;
				colvarLastrequest.IsPrimaryKey = false;
				colvarLastrequest.IsForeignKey = false;
				colvarLastrequest.IsReadOnly = false;
				colvarLastrequest.DefaultSetting = @"";
				colvarLastrequest.ForeignKeyTableName = "";
				schema.Columns.Add(colvarLastrequest);
				
				TableSchema.TableColumn colvarActive = new TableSchema.TableColumn(schema);
				colvarActive.ColumnName = "active";
				colvarActive.DataType = DbType.AnsiString;
				colvarActive.MaxLength = 5;
				colvarActive.AutoIncrement = false;
				colvarActive.IsNullable = false;
				colvarActive.IsPrimaryKey = false;
				colvarActive.IsForeignKey = false;
				colvarActive.IsReadOnly = false;
				colvarActive.DefaultSetting = @"";
				colvarActive.ForeignKeyTableName = "";
				schema.Columns.Add(colvarActive);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["RisProvider"].AddSchema("phpss_session",schema);
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
		  
		[XmlAttribute("Sessionkey")]
		[Bindable(true)]
		public string Sessionkey 
		{
			get { return GetColumnValue<string>(Columns.Sessionkey); }
			set { SetColumnValue(Columns.Sessionkey, value); }
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
		public long Ipfid 
		{
			get { return GetColumnValue<long>(Columns.Ipfid); }
			set { SetColumnValue(Columns.Ipfid, value); }
		}
		  
		[XmlAttribute("Created")]
		[Bindable(true)]
		public DateTime Created 
		{
			get { return GetColumnValue<DateTime>(Columns.Created); }
			set { SetColumnValue(Columns.Created, value); }
		}
		  
		[XmlAttribute("Lastrequest")]
		[Bindable(true)]
		public DateTime Lastrequest 
		{
			get { return GetColumnValue<DateTime>(Columns.Lastrequest); }
			set { SetColumnValue(Columns.Lastrequest, value); }
		}
		  
		[XmlAttribute("Active")]
		[Bindable(true)]
		public string Active 
		{
			get { return GetColumnValue<string>(Columns.Active); }
			set { SetColumnValue(Columns.Active, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varSessionkey,int? varAccountfid,long varIpfid,DateTime varCreated,DateTime varLastrequest,string varActive)
		{
			PhpssSession item = new PhpssSession();
			
			item.Sessionkey = varSessionkey;
			
			item.Accountfid = varAccountfid;
			
			item.Ipfid = varIpfid;
			
			item.Created = varCreated;
			
			item.Lastrequest = varLastrequest;
			
			item.Active = varActive;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varId,string varSessionkey,int? varAccountfid,long varIpfid,DateTime varCreated,DateTime varLastrequest,string varActive)
		{
			PhpssSession item = new PhpssSession();
			
				item.Id = varId;
			
				item.Sessionkey = varSessionkey;
			
				item.Accountfid = varAccountfid;
			
				item.Ipfid = varIpfid;
			
				item.Created = varCreated;
			
				item.Lastrequest = varLastrequest;
			
				item.Active = varActive;
			
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
        
        
        
        public static TableSchema.TableColumn SessionkeyColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn AccountfidColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn IpfidColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn CreatedColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn LastrequestColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        public static TableSchema.TableColumn ActiveColumn
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string Id = @"id";
			 public static string Sessionkey = @"sessionkey";
			 public static string Accountfid = @"accountfid";
			 public static string Ipfid = @"ipfid";
			 public static string Created = @"created";
			 public static string Lastrequest = @"lastrequest";
			 public static string Active = @"active";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
