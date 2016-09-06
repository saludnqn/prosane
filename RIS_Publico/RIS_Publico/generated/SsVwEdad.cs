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
    /// Strongly-typed collection for the SsVwEdad class.
    /// </summary>
    [Serializable]
    public partial class SsVwEdadCollection : ReadOnlyList<SsVwEdad, SsVwEdadCollection>
    {        
        public SsVwEdadCollection() {}
    }
    /// <summary>
    /// This is  Read-only wrapper class for the SS_VwEdad view.
    /// </summary>
    [Serializable]
    public partial class SsVwEdad : ReadOnlyRecord<SsVwEdad>, IReadOnlyRecord
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
                TableSchema.Table schema = new TableSchema.Table("SS_VwEdad", TableType.View, DataService.GetInstance("RisProvider"));
                schema.Columns = new TableSchema.TableColumnCollection();
                schema.SchemaName = @"dbo";
                //columns
                
                TableSchema.TableColumn colvarEdad = new TableSchema.TableColumn(schema);
                colvarEdad.ColumnName = "Edad";
                colvarEdad.DataType = DbType.Int32;
                colvarEdad.MaxLength = 0;
                colvarEdad.AutoIncrement = false;
                colvarEdad.IsNullable = true;
                colvarEdad.IsPrimaryKey = false;
                colvarEdad.IsForeignKey = false;
                colvarEdad.IsReadOnly = false;
                
                schema.Columns.Add(colvarEdad);
                
                
                BaseSchema = schema;
                //add this schema to the provider
                //so we can query it later
                DataService.Providers["RisProvider"].AddSchema("SS_VwEdad",schema);
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
	    public SsVwEdad()
	    {
            SetSQLProps();
            SetDefaults();
            MarkNew();
        }
        public SsVwEdad(bool useDatabaseDefaults)
	    {
		    SetSQLProps();
		    if(useDatabaseDefaults)
		    {
				ForceDefaults();
			}
			MarkNew();
	    }
	    
	    public SsVwEdad(object keyID)
	    {
		    SetSQLProps();
		    LoadByKey(keyID);
	    }
    	 
	    public SsVwEdad(string columnName, object columnValue)
        {
            SetSQLProps();
            LoadByParam(columnName,columnValue);
        }
        
	    #endregion
	    
	    #region Props
	    
          
        [XmlAttribute("Edad")]
        [Bindable(true)]
        public int? Edad 
	    {
		    get
		    {
			    return GetColumnValue<int?>("Edad");
		    }
            set 
		    {
			    SetColumnValue("Edad", value);
            }
        }
	    
	    #endregion
    
	    #region Columns Struct
	    public struct Columns
	    {
		    
		    
            public static string Edad = @"Edad";
            
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
