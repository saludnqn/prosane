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
namespace DalRis{
    /// <summary>
    /// Strongly-typed collection for the VwAspnetUser class.
    /// </summary>
    [Serializable]
    public partial class VwAspnetUserCollection : ReadOnlyList<VwAspnetUser, VwAspnetUserCollection>
    {        
        public VwAspnetUserCollection() {}
    }
    /// <summary>
    /// This is  Read-only wrapper class for the vw_aspnet_Users view.
    /// </summary>
    [Serializable]
    public partial class VwAspnetUser : ReadOnlyRecord<VwAspnetUser>, IReadOnlyRecord
    {
    
	    #region Default Settings
	    protected static void SetSQLProps() 
	    {
		    GetTableSchema();
	    }
	    #endregion
        #region Schema Accessor
	    public static TableSchema.Table Schema
        {
            get
            {
                if (BaseSchema == null)
                {
                    SetSQLProps();
                }
                return BaseSchema;
            }
        }
    	
        private static void GetTableSchema() 
        {
            if(!IsSchemaInitialized)
            {
                //Schema declaration
                TableSchema.Table schema = new TableSchema.Table("vw_aspnet_Users", TableType.View, DataService.GetInstance("RisProvider"));
                schema.Columns = new TableSchema.TableColumnCollection();
                schema.SchemaName = @"dbo";
                //columns
                
                TableSchema.TableColumn colvarApplicationId = new TableSchema.TableColumn(schema);
                colvarApplicationId.ColumnName = "ApplicationId";
                colvarApplicationId.DataType = DbType.Guid;
                colvarApplicationId.MaxLength = 0;
                colvarApplicationId.AutoIncrement = false;
                colvarApplicationId.IsNullable = false;
                colvarApplicationId.IsPrimaryKey = false;
                colvarApplicationId.IsForeignKey = false;
                colvarApplicationId.IsReadOnly = false;
                
                schema.Columns.Add(colvarApplicationId);
                
                TableSchema.TableColumn colvarUserId = new TableSchema.TableColumn(schema);
                colvarUserId.ColumnName = "UserId";
                colvarUserId.DataType = DbType.Guid;
                colvarUserId.MaxLength = 0;
                colvarUserId.AutoIncrement = false;
                colvarUserId.IsNullable = false;
                colvarUserId.IsPrimaryKey = false;
                colvarUserId.IsForeignKey = false;
                colvarUserId.IsReadOnly = false;
                
                schema.Columns.Add(colvarUserId);
                
                TableSchema.TableColumn colvarUserName = new TableSchema.TableColumn(schema);
                colvarUserName.ColumnName = "UserName";
                colvarUserName.DataType = DbType.String;
                colvarUserName.MaxLength = 256;
                colvarUserName.AutoIncrement = false;
                colvarUserName.IsNullable = false;
                colvarUserName.IsPrimaryKey = false;
                colvarUserName.IsForeignKey = false;
                colvarUserName.IsReadOnly = false;
                
                schema.Columns.Add(colvarUserName);
                
                TableSchema.TableColumn colvarLoweredUserName = new TableSchema.TableColumn(schema);
                colvarLoweredUserName.ColumnName = "LoweredUserName";
                colvarLoweredUserName.DataType = DbType.String;
                colvarLoweredUserName.MaxLength = 256;
                colvarLoweredUserName.AutoIncrement = false;
                colvarLoweredUserName.IsNullable = false;
                colvarLoweredUserName.IsPrimaryKey = false;
                colvarLoweredUserName.IsForeignKey = false;
                colvarLoweredUserName.IsReadOnly = false;
                
                schema.Columns.Add(colvarLoweredUserName);
                
                TableSchema.TableColumn colvarMobileAlias = new TableSchema.TableColumn(schema);
                colvarMobileAlias.ColumnName = "MobileAlias";
                colvarMobileAlias.DataType = DbType.String;
                colvarMobileAlias.MaxLength = 16;
                colvarMobileAlias.AutoIncrement = false;
                colvarMobileAlias.IsNullable = true;
                colvarMobileAlias.IsPrimaryKey = false;
                colvarMobileAlias.IsForeignKey = false;
                colvarMobileAlias.IsReadOnly = false;
                
                schema.Columns.Add(colvarMobileAlias);
                
                TableSchema.TableColumn colvarIsAnonymous = new TableSchema.TableColumn(schema);
                colvarIsAnonymous.ColumnName = "IsAnonymous";
                colvarIsAnonymous.DataType = DbType.Boolean;
                colvarIsAnonymous.MaxLength = 0;
                colvarIsAnonymous.AutoIncrement = false;
                colvarIsAnonymous.IsNullable = false;
                colvarIsAnonymous.IsPrimaryKey = false;
                colvarIsAnonymous.IsForeignKey = false;
                colvarIsAnonymous.IsReadOnly = false;
                
                schema.Columns.Add(colvarIsAnonymous);
                
                TableSchema.TableColumn colvarLastActivityDate = new TableSchema.TableColumn(schema);
                colvarLastActivityDate.ColumnName = "LastActivityDate";
                colvarLastActivityDate.DataType = DbType.DateTime;
                colvarLastActivityDate.MaxLength = 0;
                colvarLastActivityDate.AutoIncrement = false;
                colvarLastActivityDate.IsNullable = false;
                colvarLastActivityDate.IsPrimaryKey = false;
                colvarLastActivityDate.IsForeignKey = false;
                colvarLastActivityDate.IsReadOnly = false;
                
                schema.Columns.Add(colvarLastActivityDate);
                
                
                BaseSchema = schema;
                //add this schema to the provider
                //so we can query it later
                DataService.Providers["RisProvider"].AddSchema("vw_aspnet_Users",schema);
            }
        }
        #endregion
        
        #region Query Accessor
	    public static Query CreateQuery()
	    {
		    return new Query(Schema);
	    }
	    #endregion
	    
	    #region .ctors
	    public VwAspnetUser()
	    {
            SetSQLProps();
            SetDefaults();
            MarkNew();
        }
        public VwAspnetUser(bool useDatabaseDefaults)
	    {
		    SetSQLProps();
		    if(useDatabaseDefaults)
		    {
				ForceDefaults();
			}
			MarkNew();
	    }
	    
	    public VwAspnetUser(object keyID)
	    {
		    SetSQLProps();
		    LoadByKey(keyID);
	    }
    	 
	    public VwAspnetUser(string columnName, object columnValue)
        {
            SetSQLProps();
            LoadByParam(columnName,columnValue);
        }
        
	    #endregion
	    
	    #region Props
	    
          
        [XmlAttribute("ApplicationId")]
        [Bindable(true)]
        public Guid ApplicationId 
	    {
		    get
		    {
			    return GetColumnValue<Guid>("ApplicationId");
		    }
            set 
		    {
			    SetColumnValue("ApplicationId", value);
            }
        }
	      
        [XmlAttribute("UserId")]
        [Bindable(true)]
        public Guid UserId 
	    {
		    get
		    {
			    return GetColumnValue<Guid>("UserId");
		    }
            set 
		    {
			    SetColumnValue("UserId", value);
            }
        }
	      
        [XmlAttribute("UserName")]
        [Bindable(true)]
        public string UserName 
	    {
		    get
		    {
			    return GetColumnValue<string>("UserName");
		    }
            set 
		    {
			    SetColumnValue("UserName", value);
            }
        }
	      
        [XmlAttribute("LoweredUserName")]
        [Bindable(true)]
        public string LoweredUserName 
	    {
		    get
		    {
			    return GetColumnValue<string>("LoweredUserName");
		    }
            set 
		    {
			    SetColumnValue("LoweredUserName", value);
            }
        }
	      
        [XmlAttribute("MobileAlias")]
        [Bindable(true)]
        public string MobileAlias 
	    {
		    get
		    {
			    return GetColumnValue<string>("MobileAlias");
		    }
            set 
		    {
			    SetColumnValue("MobileAlias", value);
            }
        }
	      
        [XmlAttribute("IsAnonymous")]
        [Bindable(true)]
        public bool IsAnonymous 
	    {
		    get
		    {
			    return GetColumnValue<bool>("IsAnonymous");
		    }
            set 
		    {
			    SetColumnValue("IsAnonymous", value);
            }
        }
	      
        [XmlAttribute("LastActivityDate")]
        [Bindable(true)]
        public DateTime LastActivityDate 
	    {
		    get
		    {
			    return GetColumnValue<DateTime>("LastActivityDate");
		    }
            set 
		    {
			    SetColumnValue("LastActivityDate", value);
            }
        }
	    
	    #endregion
    
	    #region Columns Struct
	    public struct Columns
	    {
		    
		    
            public static string ApplicationId = @"ApplicationId";
            
            public static string UserId = @"UserId";
            
            public static string UserName = @"UserName";
            
            public static string LoweredUserName = @"LoweredUserName";
            
            public static string MobileAlias = @"MobileAlias";
            
            public static string IsAnonymous = @"IsAnonymous";
            
            public static string LastActivityDate = @"LastActivityDate";
            
	    }
	    #endregion
	    
	    
	    #region IAbstractRecord Members
        public new CT GetColumnValue<CT>(string columnName) {
            return base.GetColumnValue<CT>(columnName);
        }
        public object GetColumnValue(string columnName) {
            return base.GetColumnValue<object>(columnName);
        }
        #endregion
	    
    }
}
