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
    /// Strongly-typed collection for the VwAspnetUsersInRole class.
    /// </summary>
    [Serializable]
    public partial class VwAspnetUsersInRoleCollection : ReadOnlyList<VwAspnetUsersInRole, VwAspnetUsersInRoleCollection>
    {        
        public VwAspnetUsersInRoleCollection() {}
    }
    /// <summary>
    /// This is  Read-only wrapper class for the vw_aspnet_UsersInRoles view.
    /// </summary>
    [Serializable]
    public partial class VwAspnetUsersInRole : ReadOnlyRecord<VwAspnetUsersInRole>, IReadOnlyRecord
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
                TableSchema.Table schema = new TableSchema.Table("vw_aspnet_UsersInRoles", TableType.View, DataService.GetInstance("RisProvider"));
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
                
                
                BaseSchema = schema;
                //add this schema to the provider
                //so we can query it later
                DataService.Providers["RisProvider"].AddSchema("vw_aspnet_UsersInRoles",schema);
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
	    public VwAspnetUsersInRole()
	    {
            SetSQLProps();
            SetDefaults();
            MarkNew();
        }
        public VwAspnetUsersInRole(bool useDatabaseDefaults)
	    {
		    SetSQLProps();
		    if(useDatabaseDefaults)
		    {
				ForceDefaults();
			}
			MarkNew();
	    }
	    
	    public VwAspnetUsersInRole(object keyID)
	    {
		    SetSQLProps();
		    LoadByKey(keyID);
	    }
    	 
	    public VwAspnetUsersInRole(string columnName, object columnValue)
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
	    
	    #endregion
    
	    #region Columns Struct
	    public struct Columns
	    {
		    
		    
            public static string UserId = @"UserId";
            
            public static string RoleId = @"RoleId";
            
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
