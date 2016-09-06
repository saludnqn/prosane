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
    /// Strongly-typed collection for the SsVwDepartamento class.
    /// </summary>
    [Serializable]
    public partial class SsVwDepartamentoCollection : ReadOnlyList<SsVwDepartamento, SsVwDepartamentoCollection>
    {        
        public SsVwDepartamentoCollection() {}
    }
    /// <summary>
    /// This is  Read-only wrapper class for the SS_VwDepartamentos view.
    /// </summary>
    [Serializable]
    public partial class SsVwDepartamento : ReadOnlyRecord<SsVwDepartamento>, IReadOnlyRecord
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
                TableSchema.Table schema = new TableSchema.Table("SS_VwDepartamentos", TableType.View, DataService.GetInstance("RisProvider"));
                schema.Columns = new TableSchema.TableColumnCollection();
                schema.SchemaName = @"dbo";
                //columns
                
                TableSchema.TableColumn colvarDepartamentos = new TableSchema.TableColumn(schema);
                colvarDepartamentos.ColumnName = "Departamentos";
                colvarDepartamentos.DataType = DbType.String;
                colvarDepartamentos.MaxLength = 255;
                colvarDepartamentos.AutoIncrement = false;
                colvarDepartamentos.IsNullable = true;
                colvarDepartamentos.IsPrimaryKey = false;
                colvarDepartamentos.IsForeignKey = false;
                colvarDepartamentos.IsReadOnly = false;
                
                schema.Columns.Add(colvarDepartamentos);
                
                
                BaseSchema = schema;
                //add this schema to the provider
                //so we can query it later
                DataService.Providers["RisProvider"].AddSchema("SS_VwDepartamentos",schema);
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
	    public SsVwDepartamento()
	    {
            SetSQLProps();
            SetDefaults();
            MarkNew();
        }
        public SsVwDepartamento(bool useDatabaseDefaults)
	    {
		    SetSQLProps();
		    if(useDatabaseDefaults)
		    {
				ForceDefaults();
			}
			MarkNew();
	    }
	    
	    public SsVwDepartamento(object keyID)
	    {
		    SetSQLProps();
		    LoadByKey(keyID);
	    }
    	 
	    public SsVwDepartamento(string columnName, object columnValue)
        {
            SetSQLProps();
            LoadByParam(columnName,columnValue);
        }
        
	    #endregion
	    
	    #region Props
	    
          
        [XmlAttribute("Departamentos")]
        [Bindable(true)]
        public string Departamentos 
	    {
		    get
		    {
			    return GetColumnValue<string>("Departamentos");
		    }
            set 
		    {
			    SetColumnValue("Departamentos", value);
            }
        }
	    
	    #endregion
    
	    #region Columns Struct
	    public struct Columns
	    {
		    
		    
            public static string Departamentos = @"Departamentos";
            
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
