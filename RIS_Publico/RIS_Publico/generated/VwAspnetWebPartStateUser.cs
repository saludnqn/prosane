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
    /// Strongly-typed collection for the VwAspnetWebPartStateUser class.
    /// </summary>
    [Serializable]
    public partial class VwAspnetWebPartStateUserCollection : ReadOnlyList<VwAspnetWebPartStateUser, VwAspnetWebPartStateUserCollection>
    {        
        public VwAspnetWebPartStateUserCollection() {}
    }
    /// <summary>
    /// This is  Read-only wrapper class for the vw_aspnet_WebPartState_User view.
    /// </summary>
    [Serializable]
    public partial class VwAspnetWebPartStateUser : ReadOnlyRecord<VwAspnetWebPartStateUser>, IReadOnlyRecord
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
                TableSchema.Table schema = new TableSchema.Table("vw_aspnet_WebPartState_User", TableType.View, DataService.GetInstance("RisProvider"));
                schema.Columns = new TableSchema.TableColumnCollection();
                schema.SchemaName = @"dbo";
                //columns
                
                TableSchema.TableColumn colvarPathId = new TableSchema.TableColumn(schema);
                colvarPathId.ColumnName = "PathId";
                colvarPathId.DataType = DbType.Guid;
                colvarPathId.MaxLength = 0;
                colvarPathId.AutoIncrement = false;
                colvarPathId.IsNullable = true;
                colvarPathId.IsPrimaryKey = false;
                colvarPathId.IsForeignKey = false;
                colvarPathId.IsReadOnly = false;
                
                schema.Columns.Add(colvarPathId);
                
                TableSchema.TableColumn colvarUserId = new TableSchema.TableColumn(schema);
                colvarUserId.ColumnName = "UserId";
                colvarUserId.DataType = DbType.Guid;
                colvarUserId.MaxLength = 0;
                colvarUserId.AutoIncrement = false;
                colvarUserId.IsNullable = true;
                colvarUserId.IsPrimaryKey = false;
                colvarUserId.IsForeignKey = false;
                colvarUserId.IsReadOnly = false;
                
                schema.Columns.Add(colvarUserId);
                
                TableSchema.TableColumn colvarDataSize = new TableSchema.TableColumn(schema);
                colvarDataSize.ColumnName = "DataSize";
                colvarDataSize.DataType = DbType.Int32;
                colvarDataSize.MaxLength = 0;
                colvarDataSize.AutoIncrement = false;
                colvarDataSize.IsNullable = true;
                colvarDataSize.IsPrimaryKey = false;
                colvarDataSize.IsForeignKey = false;
                colvarDataSize.IsReadOnly = false;
                
                schema.Columns.Add(colvarDataSize);
                
                TableSchema.TableColumn colvarLastUpdatedDate = new TableSchema.TableColumn(schema);
                colvarLastUpdatedDate.ColumnName = "LastUpdatedDate";
                colvarLastUpdatedDate.DataType = DbType.DateTime;
                colvarLastUpdatedDate.MaxLength = 0;
                colvarLastUpdatedDate.AutoIncrement = false;
                colvarLastUpdatedDate.IsNullable = false;
                colvarLastUpdatedDate.IsPrimaryKey = false;
                colvarLastUpdatedDate.IsForeignKey = false;
                colvarLastUpdatedDate.IsReadOnly = false;
                
                schema.Columns.Add(colvarLastUpdatedDate);
                
                
                BaseSchema = schema;
                //add this schema to the provider
                //so we can query it later
                DataService.Providers["RisProvider"].AddSchema("vw_aspnet_WebPartState_User",schema);
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
	    public VwAspnetWebPartStateUser()
	    {
            SetSQLProps();
            SetDefaults();
            MarkNew();
        }
        public VwAspnetWebPartStateUser(bool useDatabaseDefaults)
	    {
		    SetSQLProps();
		    if(useDatabaseDefaults)
		    {
				ForceDefaults();
			}
			MarkNew();
	    }
	    
	    public VwAspnetWebPartStateUser(object keyID)
	    {
		    SetSQLProps();
		    LoadByKey(keyID);
	    }
    	 
	    public VwAspnetWebPartStateUser(string columnName, object columnValue)
        {
            SetSQLProps();
            LoadByParam(columnName,columnValue);
        }
        
	    #endregion
	    
	    #region Props
	    
          
        [XmlAttribute("PathId")]
        [Bindable(true)]
        public Guid? PathId 
	    {
		    get
		    {
			    return GetColumnValue<Guid?>("PathId");
		    }
            set 
		    {
			    SetColumnValue("PathId", value);
            }
        }
	      
        [XmlAttribute("UserId")]
        [Bindable(true)]
        public Guid? UserId 
	    {
		    get
		    {
			    return GetColumnValue<Guid?>("UserId");
		    }
            set 
		    {
			    SetColumnValue("UserId", value);
            }
        }
	      
        [XmlAttribute("DataSize")]
        [Bindable(true)]
        public int? DataSize 
	    {
		    get
		    {
			    return GetColumnValue<int?>("DataSize");
		    }
            set 
		    {
			    SetColumnValue("DataSize", value);
            }
        }
	      
        [XmlAttribute("LastUpdatedDate")]
        [Bindable(true)]
        public DateTime LastUpdatedDate 
	    {
		    get
		    {
			    return GetColumnValue<DateTime>("LastUpdatedDate");
		    }
            set 
		    {
			    SetColumnValue("LastUpdatedDate", value);
            }
        }
	    
	    #endregion
    
	    #region Columns Struct
	    public struct Columns
	    {
		    
		    
            public static string PathId = @"PathId";
            
            public static string UserId = @"UserId";
            
            public static string DataSize = @"DataSize";
            
            public static string LastUpdatedDate = @"LastUpdatedDate";
            
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
