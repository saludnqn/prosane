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
	/// Strongly-typed collection for the Sysreplserver class.
	/// </summary>
    [Serializable]
	public partial class SysreplserverCollection : ActiveList<Sysreplserver, SysreplserverCollection>
	{	   
		public SysreplserverCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>SysreplserverCollection</returns>
		public SysreplserverCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                Sysreplserver o = this[i];
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
	/// This is an ActiveRecord class which wraps the sysreplservers table.
	/// </summary>
	[Serializable]
	public partial class Sysreplserver : ActiveRecord<Sysreplserver>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public Sysreplserver()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public Sysreplserver(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public Sysreplserver(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public Sysreplserver(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("sysreplservers", TableType.Table, DataService.GetInstance("RisProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarSrvname = new TableSchema.TableColumn(schema);
				colvarSrvname.ColumnName = "srvname";
				colvarSrvname.DataType = DbType.String;
				colvarSrvname.MaxLength = 128;
				colvarSrvname.AutoIncrement = false;
				colvarSrvname.IsNullable = false;
				colvarSrvname.IsPrimaryKey = true;
				colvarSrvname.IsForeignKey = false;
				colvarSrvname.IsReadOnly = false;
				colvarSrvname.DefaultSetting = @"";
				colvarSrvname.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSrvname);
				
				TableSchema.TableColumn colvarSrvid = new TableSchema.TableColumn(schema);
				colvarSrvid.ColumnName = "srvid";
				colvarSrvid.DataType = DbType.Int32;
				colvarSrvid.MaxLength = 0;
				colvarSrvid.AutoIncrement = false;
				colvarSrvid.IsNullable = true;
				colvarSrvid.IsPrimaryKey = false;
				colvarSrvid.IsForeignKey = false;
				colvarSrvid.IsReadOnly = false;
				colvarSrvid.DefaultSetting = @"";
				colvarSrvid.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSrvid);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["RisProvider"].AddSchema("sysreplservers",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("Srvname")]
		[Bindable(true)]
		public string Srvname 
		{
			get { return GetColumnValue<string>(Columns.Srvname); }
			set { SetColumnValue(Columns.Srvname, value); }
		}
		  
		[XmlAttribute("Srvid")]
		[Bindable(true)]
		public int? Srvid 
		{
			get { return GetColumnValue<int?>(Columns.Srvid); }
			set { SetColumnValue(Columns.Srvid, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varSrvname,int? varSrvid)
		{
			Sysreplserver item = new Sysreplserver();
			
			item.Srvname = varSrvname;
			
			item.Srvid = varSrvid;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(string varSrvname,int? varSrvid)
		{
			Sysreplserver item = new Sysreplserver();
			
				item.Srvname = varSrvname;
			
				item.Srvid = varSrvid;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn SrvnameColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn SrvidColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string Srvname = @"srvname";
			 public static string Srvid = @"srvid";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
