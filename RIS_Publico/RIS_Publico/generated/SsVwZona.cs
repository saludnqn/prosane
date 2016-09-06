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
    /// Strongly-typed collection for the SsVwZona class.
    /// </summary>
    [Serializable]
    public partial class SsVwZonaCollection : ReadOnlyList<SsVwZona, SsVwZonaCollection>
    {        
        public SsVwZonaCollection() {}
    }
    /// <summary>
    /// This is  Read-only wrapper class for the SS_VwZona view.
    /// </summary>
    [Serializable]
    public partial class SsVwZona : ReadOnlyRecord<SsVwZona>, IReadOnlyRecord
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
                TableSchema.Table schema = new TableSchema.Table("SS_VwZona", TableType.View, DataService.GetInstance("RisProvider"));
                schema.Columns = new TableSchema.TableColumnCollection();
                schema.SchemaName = @"dbo";
                //columns
                
                TableSchema.TableColumn colvarZona = new TableSchema.TableColumn(schema);
                colvarZona.ColumnName = "Zona";
                colvarZona.DataType = DbType.Int32;
                colvarZona.MaxLength = 0;
                colvarZona.AutoIncrement = false;
                colvarZona.IsNullable = true;
                colvarZona.IsPrimaryKey = false;
                colvarZona.IsForeignKey = false;
                colvarZona.IsReadOnly = false;
                
                schema.Columns.Add(colvarZona);
                
                
                BaseSchema = schema;
                //add this schema to the provider
                //so we can query it later
                DataService.Providers["RisProvider"].AddSchema("SS_VwZona",schema);
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
	    public SsVwZona()
	    {
            SetSQLProps();
            SetDefaults();
            MarkNew();
        }
        public SsVwZona(bool useDatabaseDefaults)
	    {
		    SetSQLProps();
		    if(useDatabaseDefaults)
		    {
				ForceDefaults();
			}
			MarkNew();
	    }
	    
	    public SsVwZona(object keyID)
	    {
		    SetSQLProps();
		    LoadByKey(keyID);
	    }
    	 
	    public SsVwZona(string columnName, object columnValue)
        {
            SetSQLProps();
            LoadByParam(columnName,columnValue);
        }
        
	    #endregion
	    
	    #region Props
	    
          
        [XmlAttribute("Zona")]
        [Bindable(true)]
        public int? Zona 
	    {
		    get
		    {
			    return GetColumnValue<int?>("Zona");
		    }
            set 
		    {
			    SetColumnValue("Zona", value);
            }
        }
	    
	    #endregion
    
	    #region Columns Struct
	    public struct Columns
	    {
		    
		    
            public static string Zona = @"Zona";
            
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
