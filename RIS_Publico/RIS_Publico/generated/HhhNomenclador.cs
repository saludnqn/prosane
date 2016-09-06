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
    /// Strongly-typed collection for the HhhNomenclador class.
    /// </summary>
    [Serializable]
    public partial class HhhNomencladorCollection : ReadOnlyList<HhhNomenclador, HhhNomencladorCollection>
    {        
        public HhhNomencladorCollection() {}
    }
    /// <summary>
    /// This is  Read-only wrapper class for the HHH_Nomenclador view.
    /// </summary>
    [Serializable]
    public partial class HhhNomenclador : ReadOnlyRecord<HhhNomenclador>, IReadOnlyRecord
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
                TableSchema.Table schema = new TableSchema.Table("HHH_Nomenclador", TableType.View, DataService.GetInstance("RisProvider"));
                schema.Columns = new TableSchema.TableColumnCollection();
                schema.SchemaName = @"dbo";
                //columns
                
                TableSchema.TableColumn colvarIdNomenclador = new TableSchema.TableColumn(schema);
                colvarIdNomenclador.ColumnName = "idNomenclador";
                colvarIdNomenclador.DataType = DbType.Int32;
                colvarIdNomenclador.MaxLength = 0;
                colvarIdNomenclador.AutoIncrement = false;
                colvarIdNomenclador.IsNullable = false;
                colvarIdNomenclador.IsPrimaryKey = false;
                colvarIdNomenclador.IsForeignKey = false;
                colvarIdNomenclador.IsReadOnly = false;
                
                schema.Columns.Add(colvarIdNomenclador);
                
                TableSchema.TableColumn colvarCodigo = new TableSchema.TableColumn(schema);
                colvarCodigo.ColumnName = "codigo";
                colvarCodigo.DataType = DbType.String;
                colvarCodigo.MaxLength = 50;
                colvarCodigo.AutoIncrement = false;
                colvarCodigo.IsNullable = true;
                colvarCodigo.IsPrimaryKey = false;
                colvarCodigo.IsForeignKey = false;
                colvarCodigo.IsReadOnly = false;
                
                schema.Columns.Add(colvarCodigo);
                
                TableSchema.TableColumn colvarDescripcion = new TableSchema.TableColumn(schema);
                colvarDescripcion.ColumnName = "descripcion";
                colvarDescripcion.DataType = DbType.String;
                colvarDescripcion.MaxLength = 50;
                colvarDescripcion.AutoIncrement = false;
                colvarDescripcion.IsNullable = true;
                colvarDescripcion.IsPrimaryKey = false;
                colvarDescripcion.IsForeignKey = false;
                colvarDescripcion.IsReadOnly = false;
                
                schema.Columns.Add(colvarDescripcion);
                
                TableSchema.TableColumn colvarIdTipoPractica = new TableSchema.TableColumn(schema);
                colvarIdTipoPractica.ColumnName = "idTipoPractica";
                colvarIdTipoPractica.DataType = DbType.Int32;
                colvarIdTipoPractica.MaxLength = 0;
                colvarIdTipoPractica.AutoIncrement = false;
                colvarIdTipoPractica.IsNullable = false;
                colvarIdTipoPractica.IsPrimaryKey = false;
                colvarIdTipoPractica.IsForeignKey = false;
                colvarIdTipoPractica.IsReadOnly = false;
                
                schema.Columns.Add(colvarIdTipoPractica);
                
                TableSchema.TableColumn colvarIdUnidad = new TableSchema.TableColumn(schema);
                colvarIdUnidad.ColumnName = "idUnidad";
                colvarIdUnidad.DataType = DbType.Int32;
                colvarIdUnidad.MaxLength = 0;
                colvarIdUnidad.AutoIncrement = false;
                colvarIdUnidad.IsNullable = false;
                colvarIdUnidad.IsPrimaryKey = false;
                colvarIdUnidad.IsForeignKey = false;
                colvarIdUnidad.IsReadOnly = false;
                
                schema.Columns.Add(colvarIdUnidad);
                
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
                
                TableSchema.TableColumn colvarValorUnidad = new TableSchema.TableColumn(schema);
                colvarValorUnidad.ColumnName = "valorUnidad";
                colvarValorUnidad.DataType = DbType.Double;
                colvarValorUnidad.MaxLength = 0;
                colvarValorUnidad.AutoIncrement = false;
                colvarValorUnidad.IsNullable = false;
                colvarValorUnidad.IsPrimaryKey = false;
                colvarValorUnidad.IsForeignKey = false;
                colvarValorUnidad.IsReadOnly = false;
                
                schema.Columns.Add(colvarValorUnidad);
                
                TableSchema.TableColumn colvarEsAmbulatorio = new TableSchema.TableColumn(schema);
                colvarEsAmbulatorio.ColumnName = "esAmbulatorio";
                colvarEsAmbulatorio.DataType = DbType.Boolean;
                colvarEsAmbulatorio.MaxLength = 0;
                colvarEsAmbulatorio.AutoIncrement = false;
                colvarEsAmbulatorio.IsNullable = false;
                colvarEsAmbulatorio.IsPrimaryKey = false;
                colvarEsAmbulatorio.IsForeignKey = false;
                colvarEsAmbulatorio.IsReadOnly = false;
                
                schema.Columns.Add(colvarEsAmbulatorio);
                
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
                DataService.Providers["RisProvider"].AddSchema("HHH_Nomenclador",schema);
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
	    public HhhNomenclador()
	    {
            SetSQLProps();
            SetDefaults();
            MarkNew();
        }
        public HhhNomenclador(bool useDatabaseDefaults)
	    {
		    SetSQLProps();
		    if(useDatabaseDefaults)
		    {
				ForceDefaults();
			}
			MarkNew();
	    }
	    
	    public HhhNomenclador(object keyID)
	    {
		    SetSQLProps();
		    LoadByKey(keyID);
	    }
    	 
	    public HhhNomenclador(string columnName, object columnValue)
        {
            SetSQLProps();
            LoadByParam(columnName,columnValue);
        }
        
	    #endregion
	    
	    #region Props
	    
          
        [XmlAttribute("IdNomenclador")]
        [Bindable(true)]
        public int IdNomenclador 
	    {
		    get
		    {
			    return GetColumnValue<int>("idNomenclador");
		    }
            set 
		    {
			    SetColumnValue("idNomenclador", value);
            }
        }
	      
        [XmlAttribute("Codigo")]
        [Bindable(true)]
        public string Codigo 
	    {
		    get
		    {
			    return GetColumnValue<string>("codigo");
		    }
            set 
		    {
			    SetColumnValue("codigo", value);
            }
        }
	      
        [XmlAttribute("Descripcion")]
        [Bindable(true)]
        public string Descripcion 
	    {
		    get
		    {
			    return GetColumnValue<string>("descripcion");
		    }
            set 
		    {
			    SetColumnValue("descripcion", value);
            }
        }
	      
        [XmlAttribute("IdTipoPractica")]
        [Bindable(true)]
        public int IdTipoPractica 
	    {
		    get
		    {
			    return GetColumnValue<int>("idTipoPractica");
		    }
            set 
		    {
			    SetColumnValue("idTipoPractica", value);
            }
        }
	      
        [XmlAttribute("IdUnidad")]
        [Bindable(true)]
        public int IdUnidad 
	    {
		    get
		    {
			    return GetColumnValue<int>("idUnidad");
		    }
            set 
		    {
			    SetColumnValue("idUnidad", value);
            }
        }
	      
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
	      
        [XmlAttribute("ValorUnidad")]
        [Bindable(true)]
        public double ValorUnidad 
	    {
		    get
		    {
			    return GetColumnValue<double>("valorUnidad");
		    }
            set 
		    {
			    SetColumnValue("valorUnidad", value);
            }
        }
	      
        [XmlAttribute("EsAmbulatorio")]
        [Bindable(true)]
        public bool EsAmbulatorio 
	    {
		    get
		    {
			    return GetColumnValue<bool>("esAmbulatorio");
		    }
            set 
		    {
			    SetColumnValue("esAmbulatorio", value);
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
		    
		    
            public static string IdNomenclador = @"idNomenclador";
            
            public static string Codigo = @"codigo";
            
            public static string Descripcion = @"descripcion";
            
            public static string IdTipoPractica = @"idTipoPractica";
            
            public static string IdUnidad = @"idUnidad";
            
            public static string IdTipoNomenclador = @"idTipoNomenclador";
            
            public static string ValorUnidad = @"valorUnidad";
            
            public static string EsAmbulatorio = @"esAmbulatorio";
            
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
