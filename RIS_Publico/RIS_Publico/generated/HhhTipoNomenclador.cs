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
    /// Strongly-typed collection for the HhhTipoNomenclador class.
    /// </summary>
    [Serializable]
    public partial class HhhTipoNomencladorCollection : ReadOnlyList<HhhTipoNomenclador, HhhTipoNomencladorCollection>
    {        
        public HhhTipoNomencladorCollection() {}
    }
    /// <summary>
    /// This is  Read-only wrapper class for the HHH_TipoNomenclador view.
    /// </summary>
    [Serializable]
    public partial class HhhTipoNomenclador : ReadOnlyRecord<HhhTipoNomenclador>, IReadOnlyRecord
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
                TableSchema.Table schema = new TableSchema.Table("HHH_TipoNomenclador", TableType.View, DataService.GetInstance("RisProvider"));
                schema.Columns = new TableSchema.TableColumnCollection();
                schema.SchemaName = @"dbo";
                //columns
                
                TableSchema.TableColumn colvarIdTipoNomenclador = new TableSchema.TableColumn(schema);
                colvarIdTipoNomenclador.ColumnName = "idTipoNomenclador";
                colvarIdTipoNomenclador.DataType = DbType.Int32;
                colvarIdTipoNomenclador.MaxLength = 0;
                colvarIdTipoNomenclador.AutoIncrement = false;
                colvarIdTipoNomenclador.IsNullable = false;
                colvarIdTipoNomenclador.IsPrimaryKey = false;
                colvarIdTipoNomenclador.IsForeignKey = false;
                colvarIdTipoNomenclador.IsReadOnly = false;
                
                schema.Columns.Add(colvarIdTipoNomenclador);
                
                TableSchema.TableColumn colvarNombre = new TableSchema.TableColumn(schema);
                colvarNombre.ColumnName = "Nombre";
                colvarNombre.DataType = DbType.String;
                colvarNombre.MaxLength = 50;
                colvarNombre.AutoIncrement = false;
                colvarNombre.IsNullable = true;
                colvarNombre.IsPrimaryKey = false;
                colvarNombre.IsForeignKey = false;
                colvarNombre.IsReadOnly = false;
                
                schema.Columns.Add(colvarNombre);
                
                TableSchema.TableColumn colvarFechaDesde = new TableSchema.TableColumn(schema);
                colvarFechaDesde.ColumnName = "fechaDesde";
                colvarFechaDesde.DataType = DbType.DateTime;
                colvarFechaDesde.MaxLength = 0;
                colvarFechaDesde.AutoIncrement = false;
                colvarFechaDesde.IsNullable = false;
                colvarFechaDesde.IsPrimaryKey = false;
                colvarFechaDesde.IsForeignKey = false;
                colvarFechaDesde.IsReadOnly = false;
                
                schema.Columns.Add(colvarFechaDesde);
                
                TableSchema.TableColumn colvarFechaHasta = new TableSchema.TableColumn(schema);
                colvarFechaHasta.ColumnName = "fechaHasta";
                colvarFechaHasta.DataType = DbType.DateTime;
                colvarFechaHasta.MaxLength = 0;
                colvarFechaHasta.AutoIncrement = false;
                colvarFechaHasta.IsNullable = false;
                colvarFechaHasta.IsPrimaryKey = false;
                colvarFechaHasta.IsForeignKey = false;
                colvarFechaHasta.IsReadOnly = false;
                
                schema.Columns.Add(colvarFechaHasta);
                
                TableSchema.TableColumn colvarActivo = new TableSchema.TableColumn(schema);
                colvarActivo.ColumnName = "activo";
                colvarActivo.DataType = DbType.Boolean;
                colvarActivo.MaxLength = 0;
                colvarActivo.AutoIncrement = false;
                colvarActivo.IsNullable = false;
                colvarActivo.IsPrimaryKey = false;
                colvarActivo.IsForeignKey = false;
                colvarActivo.IsReadOnly = false;
                
                schema.Columns.Add(colvarActivo);
                
                
                BaseSchema = schema;
                //add this schema to the provider
                //so we can query it later
                DataService.Providers["RisProvider"].AddSchema("HHH_TipoNomenclador",schema);
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
	    public HhhTipoNomenclador()
	    {
            SetSQLProps();
            SetDefaults();
            MarkNew();
        }
        public HhhTipoNomenclador(bool useDatabaseDefaults)
	    {
		    SetSQLProps();
		    if(useDatabaseDefaults)
		    {
				ForceDefaults();
			}
			MarkNew();
	    }
	    
	    public HhhTipoNomenclador(object keyID)
	    {
		    SetSQLProps();
		    LoadByKey(keyID);
	    }
    	 
	    public HhhTipoNomenclador(string columnName, object columnValue)
        {
            SetSQLProps();
            LoadByParam(columnName,columnValue);
        }
        
	    #endregion
	    
	    #region Props
	    
          
        [XmlAttribute("IdTipoNomenclador")]
        [Bindable(true)]
        public int IdTipoNomenclador 
	    {
		    get
		    {
			    return GetColumnValue<int>("idTipoNomenclador");
		    }
            set 
		    {
			    SetColumnValue("idTipoNomenclador", value);
            }
        }
	      
        [XmlAttribute("Nombre")]
        [Bindable(true)]
        public string Nombre 
	    {
		    get
		    {
			    return GetColumnValue<string>("Nombre");
		    }
            set 
		    {
			    SetColumnValue("Nombre", value);
            }
        }
	      
        [XmlAttribute("FechaDesde")]
        [Bindable(true)]
        public DateTime FechaDesde 
	    {
		    get
		    {
			    return GetColumnValue<DateTime>("fechaDesde");
		    }
            set 
		    {
			    SetColumnValue("fechaDesde", value);
            }
        }
	      
        [XmlAttribute("FechaHasta")]
        [Bindable(true)]
        public DateTime FechaHasta 
	    {
		    get
		    {
			    return GetColumnValue<DateTime>("fechaHasta");
		    }
            set 
		    {
			    SetColumnValue("fechaHasta", value);
            }
        }
	      
        [XmlAttribute("Activo")]
        [Bindable(true)]
        public bool Activo 
	    {
		    get
		    {
			    return GetColumnValue<bool>("activo");
		    }
            set 
		    {
			    SetColumnValue("activo", value);
            }
        }
	    
	    #endregion
    
	    #region Columns Struct
	    public struct Columns
	    {
		    
		    
            public static string IdTipoNomenclador = @"idTipoNomenclador";
            
            public static string Nombre = @"Nombre";
            
            public static string FechaDesde = @"fechaDesde";
            
            public static string FechaHasta = @"fechaHasta";
            
            public static string Activo = @"activo";
            
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
