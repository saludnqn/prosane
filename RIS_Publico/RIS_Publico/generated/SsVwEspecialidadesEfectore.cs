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
    /// Strongly-typed collection for the SsVwEspecialidadesEfectore class.
    /// </summary>
    [Serializable]
    public partial class SsVwEspecialidadesEfectoreCollection : ReadOnlyList<SsVwEspecialidadesEfectore, SsVwEspecialidadesEfectoreCollection>
    {        
        public SsVwEspecialidadesEfectoreCollection() {}
    }
    /// <summary>
    /// This is  Read-only wrapper class for the SS_VwEspecialidadesEfectores view.
    /// </summary>
    [Serializable]
    public partial class SsVwEspecialidadesEfectore : ReadOnlyRecord<SsVwEspecialidadesEfectore>, IReadOnlyRecord
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
                TableSchema.Table schema = new TableSchema.Table("SS_VwEspecialidadesEfectores", TableType.View, DataService.GetInstance("RisProvider"));
                schema.Columns = new TableSchema.TableColumnCollection();
                schema.SchemaName = @"dbo";
                //columns
                
                TableSchema.TableColumn colvarIdEspecialidad = new TableSchema.TableColumn(schema);
                colvarIdEspecialidad.ColumnName = "idEspecialidad";
                colvarIdEspecialidad.DataType = DbType.Int32;
                colvarIdEspecialidad.MaxLength = 0;
                colvarIdEspecialidad.AutoIncrement = false;
                colvarIdEspecialidad.IsNullable = false;
                colvarIdEspecialidad.IsPrimaryKey = false;
                colvarIdEspecialidad.IsForeignKey = false;
                colvarIdEspecialidad.IsReadOnly = false;
                
                schema.Columns.Add(colvarIdEspecialidad);
                
                TableSchema.TableColumn colvarNombre = new TableSchema.TableColumn(schema);
                colvarNombre.ColumnName = "nombre";
                colvarNombre.DataType = DbType.String;
                colvarNombre.MaxLength = 50;
                colvarNombre.AutoIncrement = false;
                colvarNombre.IsNullable = false;
                colvarNombre.IsPrimaryKey = false;
                colvarNombre.IsForeignKey = false;
                colvarNombre.IsReadOnly = false;
                
                schema.Columns.Add(colvarNombre);
                
                
                BaseSchema = schema;
                //add this schema to the provider
                //so we can query it later
                DataService.Providers["RisProvider"].AddSchema("SS_VwEspecialidadesEfectores",schema);
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
	    public SsVwEspecialidadesEfectore()
	    {
            SetSQLProps();
            SetDefaults();
            MarkNew();
        }
        public SsVwEspecialidadesEfectore(bool useDatabaseDefaults)
	    {
		    SetSQLProps();
		    if(useDatabaseDefaults)
		    {
				ForceDefaults();
			}
			MarkNew();
	    }
	    
	    public SsVwEspecialidadesEfectore(object keyID)
	    {
		    SetSQLProps();
		    LoadByKey(keyID);
	    }
    	 
	    public SsVwEspecialidadesEfectore(string columnName, object columnValue)
        {
            SetSQLProps();
            LoadByParam(columnName,columnValue);
        }
        
	    #endregion
	    
	    #region Props
	    
          
        [XmlAttribute("IdEspecialidad")]
        [Bindable(true)]
        public int IdEspecialidad 
	    {
		    get
		    {
			    return GetColumnValue<int>("idEspecialidad");
		    }
            set 
		    {
			    SetColumnValue("idEspecialidad", value);
            }
        }
	      
        [XmlAttribute("Nombre")]
        [Bindable(true)]
        public string Nombre 
	    {
		    get
		    {
			    return GetColumnValue<string>("nombre");
		    }
            set 
		    {
			    SetColumnValue("nombre", value);
            }
        }
	    
	    #endregion
    
	    #region Columns Struct
	    public struct Columns
	    {
		    
		    
            public static string IdEspecialidad = @"idEspecialidad";
            
            public static string Nombre = @"nombre";
            
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
