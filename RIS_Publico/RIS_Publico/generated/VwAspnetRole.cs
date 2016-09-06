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
    /// Strongly-typed collection for the VwAspnetRole class.
    /// </summary>
    [Serializable]
    public partial class VwAspnetRoleCollection : ReadOnlyList<VwAspnetRole, VwAspnetRoleCollection>
    {        
        public VwAspnetRoleCollection() {}
    }
    /// <summary>
    /// This is  Read-only wrapper class for the vw_aspnet_Roles view.
    /// </summary>
    [Serializable]
    public partial class VwAspnetRole : ReadOnlyRecord<VwAspnetRole>, IReadOnlyRecord
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
                TableSchema.Table schema = new TableSchema.Table("vw_aspnet_Roles", TableType.View, DataService.GetInstance("RisProvider"));
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
                
                TableSchema.TableColumn colvarRoleId = new TableSchema.TableColumn(schema);
                colvarRoleId.ColumnName = "RoleId";
                colvarRoleId.DataType = DbType.Guid;
                colvarRoleId.MaxLength = 0;
                colvarRoleId.AutoIncrement = false;
                colvarRoleId.IsNullable = false;
                colvarRoleId.IsPrimaryKey = false;
                colvarRoleId.IsForeignKey = false;
                colvarRoleId.IsReadOnly = false;
                
                schema.Columns.Add(colvarRoleId);
                
                TableSchema.TableColumn colvarRoleName = new TableSchema.TableColumn(schema);
                colvarRoleName.ColumnName = "RoleName";
                colvarRoleName.DataType = DbType.String;
                colvarRoleName.MaxLength = 256;
                colvarRoleName.AutoIncrement = false;
                colvarRoleName.IsNullable = false;
                colvarRoleName.IsPrimaryKey = false;
                colvarRoleName.IsForeignKey = false;
                colvarRoleName.IsReadOnly = false;
                
                schema.Columns.Add(colvarRoleName);
                
                TableSchema.TableColumn colvarLoweredRoleName = new TableSchema.TableColumn(schema);
                colvarLoweredRoleName.ColumnName = "LoweredRoleName";
                colvarLoweredRoleName.DataType = DbType.String;
                colvarLoweredRoleName.MaxLength = 256;
                colvarLoweredRoleName.AutoIncrement = false;
                colvarLoweredRoleName.IsNullable = false;
                colvarLoweredRoleName.IsPrimaryKey = false;
                colvarLoweredRoleName.IsForeignKey = false;
                colvarLoweredRoleName.IsReadOnly = false;
                
                schema.Columns.Add(colvarLoweredRoleName);
                
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
                DataService.Providers["RisProvider"].AddSchema("vw_aspnet_Roles",schema);
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
	    public VwAspnetRole()
	    {
            SetSQLProps();
            SetDefaults();
            MarkNew();
        }
        public VwAspnetRole(bool useDatabaseDefaults)
	    {
		    SetSQLProps();
		    if(useDatabaseDefaults)
		    {
				ForceDefaults();
			}
			MarkNew();
	    }
	    
	    public VwAspnetRole(object keyID)
	    {
		    SetSQLProps();
		    LoadByKey(keyID);
	    }
    	 
	    public VwAspnetRole(string columnName, object columnValue)
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
	      
        [XmlAttribute("RoleId")]
        [Bindable(true)]
        public Guid RoleId 
	    {
		    get
		    {
			    return GetColumnValue<Guid>("RoleId");
		    }
            set 
		    {
			    SetColumnValue("RoleId", value);
            }
        }
	      
        [XmlAttribute("RoleName")]
        [Bindable(true)]
        public string RoleName 
	    {
		    get
		    {
			    return GetColumnValue<string>("RoleName");
		    }
            set 
		    {
			    SetColumnValue("RoleName", value);
            }
        }
	      
        [XmlAttribute("LoweredRoleName")]
        [Bindable(true)]
        public string LoweredRoleName 
	    {
		    get
		    {
			    return GetColumnValue<string>("LoweredRoleName");
		    }
            set 
		    {
			    SetColumnValue("LoweredRoleName", value);
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
		    
		    
            public static string ApplicationId = @"ApplicationId";
            
            public static string RoleId = @"RoleId";
            
            public static string RoleName = @"RoleName";
            
            public static string LoweredRoleName = @"LoweredRoleName";
            
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
