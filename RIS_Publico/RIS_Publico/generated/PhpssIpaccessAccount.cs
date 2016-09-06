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
	/// Strongly-typed collection for the PhpssIpaccessAccount class.
	/// </summary>
    [Serializable]
	public partial class PhpssIpaccessAccountCollection : ActiveList<PhpssIpaccessAccount, PhpssIpaccessAccountCollection>
	{	   
		public PhpssIpaccessAccountCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>PhpssIpaccessAccountCollection</returns>
		public PhpssIpaccessAccountCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                PhpssIpaccessAccount o = this[i];
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
	/// This is an ActiveRecord class which wraps the phpss_ipaccess_account table.
	/// </summary>
	[Serializable]
	public partial class PhpssIpaccessAccount : ActiveRecord<PhpssIpaccessAccount>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public PhpssIpaccessAccount()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public PhpssIpaccessAccount(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public PhpssIpaccessAccount(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public PhpssIpaccessAccount(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("phpss_ipaccess_account", TableType.Table, DataService.GetInstance("RisProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarIp = new TableSchema.TableColumn(schema);
				colvarIp.ColumnName = "ip";
				colvarIp.DataType = DbType.AnsiString;
				colvarIp.MaxLength = 15;
				colvarIp.AutoIncrement = false;
				colvarIp.IsNullable = false;
				colvarIp.IsPrimaryKey = false;
				colvarIp.IsForeignKey = false;
				colvarIp.IsReadOnly = false;
				colvarIp.DefaultSetting = @"";
				colvarIp.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIp);
				
				TableSchema.TableColumn colvarAccountfid = new TableSchema.TableColumn(schema);
				colvarAccountfid.ColumnName = "accountfid";
				colvarAccountfid.DataType = DbType.Int32;
				colvarAccountfid.MaxLength = 0;
				colvarAccountfid.AutoIncrement = false;
				colvarAccountfid.IsNullable = false;
				colvarAccountfid.IsPrimaryKey = false;
				colvarAccountfid.IsForeignKey = false;
				colvarAccountfid.IsReadOnly = false;
				colvarAccountfid.DefaultSetting = @"";
				colvarAccountfid.ForeignKeyTableName = "";
				schema.Columns.Add(colvarAccountfid);
				
				TableSchema.TableColumn colvarAccess = new TableSchema.TableColumn(schema);
				colvarAccess.ColumnName = "access";
				colvarAccess.DataType = DbType.AnsiString;
				colvarAccess.MaxLength = 8;
				colvarAccess.AutoIncrement = false;
				colvarAccess.IsNullable = false;
				colvarAccess.IsPrimaryKey = false;
				colvarAccess.IsForeignKey = false;
				colvarAccess.IsReadOnly = false;
				colvarAccess.DefaultSetting = @"";
				colvarAccess.ForeignKeyTableName = "";
				schema.Columns.Add(colvarAccess);
				
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
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["RisProvider"].AddSchema("phpss_ipaccess_account",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("Ip")]
		[Bindable(true)]
		public string Ip 
		{
			get { return GetColumnValue<string>(Columns.Ip); }
			set { SetColumnValue(Columns.Ip, value); }
		}
		  
		[XmlAttribute("Accountfid")]
		[Bindable(true)]
		public int Accountfid 
		{
			get { return GetColumnValue<int>(Columns.Accountfid); }
			set { SetColumnValue(Columns.Accountfid, value); }
		}
		  
		[XmlAttribute("Access")]
		[Bindable(true)]
		public string Access 
		{
			get { return GetColumnValue<string>(Columns.Access); }
			set { SetColumnValue(Columns.Access, value); }
		}
		  
		[XmlAttribute("Id")]
		[Bindable(true)]
		public int Id 
		{
			get { return GetColumnValue<int>(Columns.Id); }
			set { SetColumnValue(Columns.Id, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varIp,int varAccountfid,string varAccess)
		{
			PhpssIpaccessAccount item = new PhpssIpaccessAccount();
			
			item.Ip = varIp;
			
			item.Accountfid = varAccountfid;
			
			item.Access = varAccess;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(string varIp,int varAccountfid,string varAccess,int varId)
		{
			PhpssIpaccessAccount item = new PhpssIpaccessAccount();
			
				item.Ip = varIp;
			
				item.Accountfid = varAccountfid;
			
				item.Access = varAccess;
			
				item.Id = varId;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn IpColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn AccountfidColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn AccessColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn IdColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string Ip = @"ip";
			 public static string Accountfid = @"accountfid";
			 public static string Access = @"access";
			 public static string Id = @"id";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
