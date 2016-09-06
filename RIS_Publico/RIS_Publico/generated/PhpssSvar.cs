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
	/// Strongly-typed collection for the PhpssSvar class.
	/// </summary>
    [Serializable]
	public partial class PhpssSvarCollection : ActiveList<PhpssSvar, PhpssSvarCollection>
	{	   
		public PhpssSvarCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>PhpssSvarCollection</returns>
		public PhpssSvarCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                PhpssSvar o = this[i];
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
	/// This is an ActiveRecord class which wraps the phpss_svars table.
	/// </summary>
	[Serializable]
	public partial class PhpssSvar : ActiveRecord<PhpssSvar>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public PhpssSvar()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public PhpssSvar(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public PhpssSvar(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public PhpssSvar(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("phpss_svars", TableType.Table, DataService.GetInstance("RisProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
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
				
				TableSchema.TableColumn colvarName = new TableSchema.TableColumn(schema);
				colvarName.ColumnName = "name";
				colvarName.DataType = DbType.AnsiString;
				colvarName.MaxLength = 255;
				colvarName.AutoIncrement = false;
				colvarName.IsNullable = false;
				colvarName.IsPrimaryKey = false;
				colvarName.IsForeignKey = false;
				colvarName.IsReadOnly = false;
				colvarName.DefaultSetting = @"";
				colvarName.ForeignKeyTableName = "";
				schema.Columns.Add(colvarName);
				
				TableSchema.TableColumn colvarData = new TableSchema.TableColumn(schema);
				colvarData.ColumnName = "data";
				colvarData.DataType = DbType.AnsiString;
				colvarData.MaxLength = -1;
				colvarData.AutoIncrement = false;
				colvarData.IsNullable = false;
				colvarData.IsPrimaryKey = false;
				colvarData.IsForeignKey = false;
				colvarData.IsReadOnly = false;
				colvarData.DefaultSetting = @"";
				colvarData.ForeignKeyTableName = "";
				schema.Columns.Add(colvarData);
				
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
				DataService.Providers["RisProvider"].AddSchema("phpss_svars",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("Sessionfid")]
		[Bindable(true)]
		public int Sessionfid 
		{
			get { return GetColumnValue<int>(Columns.Sessionfid); }
			set { SetColumnValue(Columns.Sessionfid, value); }
		}
		  
		[XmlAttribute("Name")]
		[Bindable(true)]
		public string Name 
		{
			get { return GetColumnValue<string>(Columns.Name); }
			set { SetColumnValue(Columns.Name, value); }
		}
		  
		[XmlAttribute("Data")]
		[Bindable(true)]
		public string Data 
		{
			get { return GetColumnValue<string>(Columns.Data); }
			set { SetColumnValue(Columns.Data, value); }
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
		public static void Insert(int varSessionfid,string varName,string varData)
		{
			PhpssSvar item = new PhpssSvar();
			
			item.Sessionfid = varSessionfid;
			
			item.Name = varName;
			
			item.Data = varData;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varSessionfid,string varName,string varData,int varId)
		{
			PhpssSvar item = new PhpssSvar();
			
				item.Sessionfid = varSessionfid;
			
				item.Name = varName;
			
				item.Data = varData;
			
				item.Id = varId;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn SessionfidColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn NameColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn DataColumn
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
			 public static string Sessionfid = @"sessionfid";
			 public static string Name = @"name";
			 public static string Data = @"data";
			 public static string Id = @"id";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
