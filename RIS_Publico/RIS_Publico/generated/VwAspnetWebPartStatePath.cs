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
    /// Strongly-typed collection for the VwAspnetWebPartStatePath class.
    /// </summary>
    [Serializable]
    public partial class VwAspnetWebPartStatePathCollection : ReadOnlyList<VwAspnetWebPartStatePath, VwAspnetWebPartStatePathCollection>
    {        
        public VwAspnetWebPartStatePathCollection() {}
    }
    /// <summary>
    /// This is  Read-only wrapper class for the vw_aspnet_WebPartState_Paths view.
    /// </summary>
    [Serializable]
    public partial class VwAspnetWebPartStatePath : ReadOnlyRecord<VwAspnetWebPartStatePath>, IReadOnlyRecord
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
                TableSchema.Table schema = new TableSchema.Table("vw_aspnet_WebPartState_Paths", TableType.View, DataService.GetInstance("RisProvider"));
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
                
                TableSchema.TableColumn colvarPathId = new TableSchema.TableColumn(schema);
                colvarPathId.ColumnName = "PathId";
                colvarPathId.DataType = DbType.Guid;
                colvarPathId.MaxLength = 0;
                colvarPathId.AutoIncrement = false;
                colvarPathId.IsNullable = false;
                colvarPathId.IsPrimaryKey = false;
                colvarPathId.IsForeignKey = false;
                colvarPathId.IsReadOnly = false;
                
                schema.Columns.Add(colvarPathId);
                
                TableSchema.TableColumn colvarPath = new TableSchema.TableColumn(schema);
                colvarPath.ColumnName = "Path";
                colvarPath.DataType = DbType.String;
                colvarPath.MaxLength = 256;
                colvarPath.AutoIncrement = false;
                colvarPath.IsNullable = false;
                colvarPath.IsPrimaryKey = false;
                colvarPath.IsForeignKey = false;
                colvarPath.IsReadOnly = false;
                
                schema.Columns.Add(colvarPath);
                
                TableSchema.TableColumn colvarLoweredPath = new TableSchema.TableColumn(schema);
                colvarLoweredPath.ColumnName = "LoweredPath";
                colvarLoweredPath.DataType = DbType.String;
                colvarLoweredPath.MaxLength = 256;
                colvarLoweredPath.AutoIncrement = false;
                colvarLoweredPath.IsNullable = false;
                colvarLoweredPath.IsPrimaryKey = false;
                colvarLoweredPath.IsForeignKey = false;
                colvarLoweredPath.IsReadOnly = false;
                
                schema.Columns.Add(colvarLoweredPath);
                
                
                BaseSchema = schema;
                //add this schema to the provider
                //so we can query it later
                DataService.Providers["RisProvider"].AddSchema("vw_aspnet_WebPartState_Paths",schema);
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
	    public VwAspnetWebPartStatePath()
	    {
            SetSQLProps();
            SetDefaults();
            MarkNew();
        }
        public VwAspnetWebPartStatePath(bool useDatabaseDefaults)
	    {
		    SetSQLProps();
		    if(useDatabaseDefaults)
		    {
				ForceDefaults();
			}
			MarkNew();
	    }
	    
	    public VwAspnetWebPartStatePath(object keyID)
	    {
		    SetSQLProps();
		    LoadByKey(keyID);
	    }
    	 
	    public VwAspnetWebPartStatePath(string columnName, object columnValue)
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
	      
        [XmlAttribute("PathId")]
        [Bindable(true)]
        public Guid PathId 
	    {
		    get
		    {
			    return GetColumnValue<Guid>("PathId");
		    }
            set 
		    {
			    SetColumnValue("PathId", value);
            }
        }
	      
        [XmlAttribute("Path")]
        [Bindable(true)]
        public string Path 
	    {
		    get
		    {
			    return GetColumnValue<string>("Path");
		    }
            set 
		    {
			    SetColumnValue("Path", value);
            }
        }
	      
        [XmlAttribute("LoweredPath")]
        [Bindable(true)]
        public string LoweredPath 
	    {
		    get
		    {
			    return GetColumnValue<string>("LoweredPath");
		    }
            set 
		    {
			    SetColumnValue("LoweredPath", value);
            }
        }
	    
	    #endregion
    
	    #region Columns Struct
	    public struct Columns
	    {
		    
		    
            public static string ApplicationId = @"ApplicationId";
            
            public static string PathId = @"PathId";
            
            public static string Path = @"Path";
            
            public static string LoweredPath = @"LoweredPath";
            
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
