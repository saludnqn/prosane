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
    /// Strongly-typed collection for the VwAspnetApplication class.
    /// </summary>
    [Serializable]
    public partial class VwAspnetApplicationCollection : ReadOnlyList<VwAspnetApplication, VwAspnetApplicationCollection>
    {        
        public VwAspnetApplicationCollection() {}
    }
    /// <summary>
    /// This is  Read-only wrapper class for the vw_aspnet_Applications view.
    /// </summary>
    [Serializable]
    public partial class VwAspnetApplication : ReadOnlyRecord<VwAspnetApplication>, IReadOnlyRecord
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
                TableSchema.Table schema = new TableSchema.Table("vw_aspnet_Applications", TableType.View, DataService.GetInstance("RisProvider"));
                schema.Columns = new TableSchema.TableColumnCollection();
                schema.SchemaName = @"dbo";
                //columns
                
                TableSchema.TableColumn colvarApplicationName = new TableSchema.TableColumn(schema);
                colvarApplicationName.ColumnName = "ApplicationName";
                colvarApplicationName.DataType = DbType.String;
                colvarApplicationName.MaxLength = 256;
                colvarApplicationName.AutoIncrement = false;
                colvarApplicationName.IsNullable = false;
                colvarApplicationName.IsPrimaryKey = false;
                colvarApplicationName.IsForeignKey = false;
                colvarApplicationName.IsReadOnly = false;
                
                schema.Columns.Add(colvarApplicationName);
                
                TableSchema.TableColumn colvarLoweredApplicationName = new TableSchema.TableColumn(schema);
                colvarLoweredApplicationName.ColumnName = "LoweredApplicationName";
                colvarLoweredApplicationName.DataType = DbType.String;
                colvarLoweredApplicationName.MaxLength = 256;
                colvarLoweredApplicationName.AutoIncrement = false;
                colvarLoweredApplicationName.IsNullable = false;
                colvarLoweredApplicationName.IsPrimaryKey = false;
                colvarLoweredApplicationName.IsForeignKey = false;
                colvarLoweredApplicationName.IsReadOnly = false;
                
                schema.Columns.Add(colvarLoweredApplicationName);
                
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
                
                TableSchema.TableColumn colvarDescription = new TableSchema.TableColumn(schema);
                colvarDescription.ColumnName = "Description";
                colvarDescription.DataType = DbType.String;
                colvarDescription.MaxLength = 256;
                colvarDescription.AutoIncrement = false;
                colvarDescription.IsNullable = true;
                colvarDescription.IsPrimaryKey = false;
                colvarDescription.IsForeignKey = false;
                colvarDescription.IsReadOnly = false;
                
                schema.Columns.Add(colvarDescription);
                
                
                BaseSchema = schema;
                //add this schema to the provider
                //so we can query it later
                DataService.Providers["RisProvider"].AddSchema("vw_aspnet_Applications",schema);
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
	    public VwAspnetApplication()
	    {
            SetSQLProps();
            SetDefaults();
            MarkNew();
        }
        public VwAspnetApplication(bool useDatabaseDefaults)
	    {
		    SetSQLProps();
		    if(useDatabaseDefaults)
		    {
				ForceDefaults();
			}
			MarkNew();
	    }
	    
	    public VwAspnetApplication(object keyID)
	    {
		    SetSQLProps();
		    LoadByKey(keyID);
	    }
    	 
	    public VwAspnetApplication(string columnName, object columnValue)
        {
            SetSQLProps();
            LoadByParam(columnName,columnValue);
        }
        
	    #endregion
	    
	    #region Props
	    
          
        [XmlAttribute("ApplicationName")]
        [Bindable(true)]
        public string ApplicationName 
	    {
		    get
		    {
			    return GetColumnValue<string>("ApplicationName");
		    }
            set 
		    {
			    SetColumnValue("ApplicationName", value);
            }
        }
	      
        [XmlAttribute("LoweredApplicationName")]
        [Bindable(true)]
        public string LoweredApplicationName 
	    {
		    get
		    {
			    return GetColumnValue<string>("LoweredApplicationName");
		    }
            set 
		    {
			    SetColumnValue("LoweredApplicationName", value);
            }
        }
	      
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
	      
        [XmlAttribute("Description")]
        [Bindable(true)]
        public string Description 
	    {
		    get
		    {
			    return GetColumnValue<string>("Description");
		    }
            set 
		    {
			    SetColumnValue("Description", value);
            }
        }
	    
	    #endregion
    
	    #region Columns Struct
	    public struct Columns
	    {
		    
		    
            public static string ApplicationName = @"ApplicationName";
            
            public static string LoweredApplicationName = @"LoweredApplicationName";
            
            public static string ApplicationId = @"ApplicationId";
            
            public static string Description = @"Description";
            
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
