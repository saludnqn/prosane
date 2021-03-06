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
	/// Strongly-typed collection for the PhpssIpaccessGroup class.
	/// </summary>
    [Serializable]
	public partial class PhpssIpaccessGroupCollection : ActiveList<PhpssIpaccessGroup, PhpssIpaccessGroupCollection>
	{	   
		public PhpssIpaccessGroupCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>PhpssIpaccessGroupCollection</returns>
		public PhpssIpaccessGroupCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                PhpssIpaccessGroup o = this[i];
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
	/// This is an ActiveRecord class which wraps the phpss_ipaccess_group table.
	/// </summary>
	[Serializable]
	public partial class PhpssIpaccessGroup : ActiveRecord<PhpssIpaccessGroup>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public PhpssIpaccessGroup()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public PhpssIpaccessGroup(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public PhpssIpaccessGroup(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public PhpssIpaccessGroup(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("phpss_ipaccess_group", TableType.Table, DataService.GetInstance("RisProvider"));
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
				
				TableSchema.TableColumn colvarGroupfid = new TableSchema.TableColumn(schema);
				colvarGroupfid.ColumnName = "groupfid";
				colvarGroupfid.DataType = DbType.Int32;
				colvarGroupfid.MaxLength = 0;
				colvarGroupfid.AutoIncrement = false;
				colvarGroupfid.IsNullable = false;
				colvarGroupfid.IsPrimaryKey = false;
				colvarGroupfid.IsForeignKey = false;
				colvarGroupfid.IsReadOnly = false;
				colvarGroupfid.DefaultSetting = @"";
				colvarGroupfid.ForeignKeyTableName = "";
				schema.Columns.Add(colvarGroupfid);
				
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
				DataService.Providers["RisProvider"].AddSchema("phpss_ipaccess_group",schema);
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
		  
		[XmlAttribute("Groupfid")]
		[Bindable(true)]
		public int Groupfid 
		{
			get { return GetColumnValue<int>(Columns.Groupfid); }
			set { SetColumnValue(Columns.Groupfid, value); }
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
		public static void Insert(string varIp,int varGroupfid,string varAccess)
		{
			PhpssIpaccessGroup item = new PhpssIpaccessGroup();
			
			item.Ip = varIp;
			
			item.Groupfid = varGroupfid;
			
			item.Access = varAccess;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(string varIp,int varGroupfid,string varAccess,int varId)
		{
			PhpssIpaccessGroup item = new PhpssIpaccessGroup();
			
				item.Ip = varIp;
			
				item.Groupfid = varGroupfid;
			
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
        
        
        
        public static TableSchema.TableColumn GroupfidColumn
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
			 public static string Groupfid = @"groupfid";
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
