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
    /// Strongly-typed collection for the SsVwLocalidad class.
    /// </summary>
    [Serializable]
    public partial class SsVwLocalidadCollection : ReadOnlyList<SsVwLocalidad, SsVwLocalidadCollection>
    {        
        public SsVwLocalidadCollection() {}
    }
    /// <summary>
    /// This is  Read-only wrapper class for the SS_VwLocalidad view.
    /// </summary>
    [Serializable]
    public partial class SsVwLocalidad : ReadOnlyRecord<SsVwLocalidad>, IReadOnlyRecord
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
                TableSchema.Table schema = new TableSchema.Table("SS_VwLocalidad", TableType.View, DataService.GetInstance("RisProvider"));
                schema.Columns = new TableSchema.TableColumnCollection();
                schema.SchemaName = @"dbo";
                //columns
                
                TableSchema.TableColumn colvarIdLocalidad = new TableSchema.TableColumn(schema);
                colvarIdLocalidad.ColumnName = "IdLocalidad";
                colvarIdLocalidad.DataType = DbType.Int32;
                colvarIdLocalidad.MaxLength = 0;
                colvarIdLocalidad.AutoIncrement = false;
                colvarIdLocalidad.IsNullable = false;
                colvarIdLocalidad.IsPrimaryKey = false;
                colvarIdLocalidad.IsForeignKey = false;
                colvarIdLocalidad.IsReadOnly = false;
                
                schema.Columns.Add(colvarIdLocalidad);
                
                TableSchema.TableColumn colvarLocalidad = new TableSchema.TableColumn(schema);
                colvarLocalidad.ColumnName = "Localidad";
                colvarLocalidad.DataType = DbType.String;
                colvarLocalidad.MaxLength = 255;
                colvarLocalidad.AutoIncrement = false;
                colvarLocalidad.IsNullable = true;
                colvarLocalidad.IsPrimaryKey = false;
                colvarLocalidad.IsForeignKey = false;
                colvarLocalidad.IsReadOnly = false;
                
                schema.Columns.Add(colvarLocalidad);
                
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
                DataService.Providers["RisProvider"].AddSchema("SS_VwLocalidad",schema);
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
	    public SsVwLocalidad()
	    {
            SetSQLProps();
            SetDefaults();
            MarkNew();
        }
        public SsVwLocalidad(bool useDatabaseDefaults)
	    {
		    SetSQLProps();
		    if(useDatabaseDefaults)
		    {
				ForceDefaults();
			}
			MarkNew();
	    }
	    
	    public SsVwLocalidad(object keyID)
	    {
		    SetSQLProps();
		    LoadByKey(keyID);
	    }
    	 
	    public SsVwLocalidad(string columnName, object columnValue)
        {
            SetSQLProps();
            LoadByParam(columnName,columnValue);
        }
        
	    #endregion
	    
	    #region Props
	    
          
        [XmlAttribute("IdLocalidad")]
        [Bindable(true)]
        public int IdLocalidad 
	    {
		    get
		    {
			    return GetColumnValue<int>("IdLocalidad");
		    }
            set 
		    {
			    SetColumnValue("IdLocalidad", value);
            }
        }
	      
        [XmlAttribute("Localidad")]
        [Bindable(true)]
        public string Localidad 
	    {
		    get
		    {
			    return GetColumnValue<string>("Localidad");
		    }
            set 
		    {
			    SetColumnValue("Localidad", value);
            }
        }
	      
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
		    
		    
            public static string IdLocalidad = @"IdLocalidad";
            
            public static string Localidad = @"Localidad";
            
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
