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
    /// Strongly-typed collection for the VwAspnetProfile class.
    /// </summary>
    [Serializable]
    public partial class VwAspnetProfileCollection : ReadOnlyList<VwAspnetProfile, VwAspnetProfileCollection>
    {        
        public VwAspnetProfileCollection() {}
    }
    /// <summary>
    /// This is  Read-only wrapper class for the vw_aspnet_Profiles view.
    /// </summary>
    [Serializable]
    public partial class VwAspnetProfile : ReadOnlyRecord<VwAspnetProfile>, IReadOnlyRecord
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
                TableSchema.Table schema = new TableSchema.Table("vw_aspnet_Profiles", TableType.View, DataService.GetInstance("RisProvider"));
                schema.Columns = new TableSchema.TableColumnCollection();
                schema.SchemaName = @"dbo";
                //columns
                
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
                
                
                BaseSchema = schema;
                //add this schema to the provider
                //so we can query it later
                DataService.Providers["RisProvider"].AddSchema("vw_aspnet_Profiles",schema);
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
	    public VwAspnetProfile()
	    {
            SetSQLProps();
            SetDefaults();
            MarkNew();
        }
        public VwAspnetProfile(bool useDatabaseDefaults)
	    {
		    SetSQLProps();
		    if(useDatabaseDefaults)
		    {
				ForceDefaults();
			}
			MarkNew();
	    }
	    
	    public VwAspnetProfile(object keyID)
	    {
		    SetSQLProps();
		    LoadByKey(keyID);
	    }
    	 
	    public VwAspnetProfile(string columnName, object columnValue)
        {
            SetSQLProps();
            LoadByParam(columnName,columnValue);
        }
        
	    #endregion
	    
	    #region Props
	    
          
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
	    
	    #endregion
    
	    #region Columns Struct
	    public struct Columns
	    {
		    
		    
            public static string UserId = @"UserId";
            
            public static string LastUpdatedDate = @"LastUpdatedDate";
            
            public static string DataSize = @"DataSize";
            
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
