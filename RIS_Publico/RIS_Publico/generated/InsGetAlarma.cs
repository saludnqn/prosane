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
    /// Strongly-typed collection for the InsGetAlarma class.
    /// </summary>
    [Serializable]
    public partial class InsGetAlarmaCollection : ReadOnlyList<InsGetAlarma, InsGetAlarmaCollection>
    {        
        public InsGetAlarmaCollection() {}
    }
    /// <summary>
    /// This is  Read-only wrapper class for the INS_GetAlarmas view.
    /// </summary>
    [Serializable]
    public partial class InsGetAlarma : ReadOnlyRecord<InsGetAlarma>, IReadOnlyRecord
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
                TableSchema.Table schema = new TableSchema.Table("INS_GetAlarmas", TableType.View, DataService.GetInstance("RisProvider"));
                schema.Columns = new TableSchema.TableColumnCollection();
                schema.SchemaName = @"dbo";
                //columns
                
                TableSchema.TableColumn colvarIdInsumo = new TableSchema.TableColumn(schema);
                colvarIdInsumo.ColumnName = "idInsumo";
                colvarIdInsumo.DataType = DbType.Int32;
                colvarIdInsumo.MaxLength = 0;
                colvarIdInsumo.AutoIncrement = false;
                colvarIdInsumo.IsNullable = false;
                colvarIdInsumo.IsPrimaryKey = false;
                colvarIdInsumo.IsForeignKey = false;
                colvarIdInsumo.IsReadOnly = false;
                
                schema.Columns.Add(colvarIdInsumo);
                
                TableSchema.TableColumn colvarIdAlarma = new TableSchema.TableColumn(schema);
                colvarIdAlarma.ColumnName = "idAlarma";
                colvarIdAlarma.DataType = DbType.Int32;
                colvarIdAlarma.MaxLength = 0;
                colvarIdAlarma.AutoIncrement = false;
                colvarIdAlarma.IsNullable = false;
                colvarIdAlarma.IsPrimaryKey = false;
                colvarIdAlarma.IsForeignKey = false;
                colvarIdAlarma.IsReadOnly = false;
                
                schema.Columns.Add(colvarIdAlarma);
                
                TableSchema.TableColumn colvarCodigo = new TableSchema.TableColumn(schema);
                colvarCodigo.ColumnName = "codigo";
                colvarCodigo.DataType = DbType.Int32;
                colvarCodigo.MaxLength = 0;
                colvarCodigo.AutoIncrement = false;
                colvarCodigo.IsNullable = false;
                colvarCodigo.IsPrimaryKey = false;
                colvarCodigo.IsForeignKey = false;
                colvarCodigo.IsReadOnly = false;
                
                schema.Columns.Add(colvarCodigo);
                
                TableSchema.TableColumn colvarNombre = new TableSchema.TableColumn(schema);
                colvarNombre.ColumnName = "Nombre";
                colvarNombre.DataType = DbType.AnsiString;
                colvarNombre.MaxLength = 2000;
                colvarNombre.AutoIncrement = false;
                colvarNombre.IsNullable = false;
                colvarNombre.IsPrimaryKey = false;
                colvarNombre.IsForeignKey = false;
                colvarNombre.IsReadOnly = false;
                
                schema.Columns.Add(colvarNombre);
                
                TableSchema.TableColumn colvarDescripcion = new TableSchema.TableColumn(schema);
                colvarDescripcion.ColumnName = "Descripcion";
                colvarDescripcion.DataType = DbType.AnsiString;
                colvarDescripcion.MaxLength = 2000;
                colvarDescripcion.AutoIncrement = false;
                colvarDescripcion.IsNullable = true;
                colvarDescripcion.IsPrimaryKey = false;
                colvarDescripcion.IsForeignKey = false;
                colvarDescripcion.IsReadOnly = false;
                
                schema.Columns.Add(colvarDescripcion);
                
                TableSchema.TableColumn colvarDiasVencimiento = new TableSchema.TableColumn(schema);
                colvarDiasVencimiento.ColumnName = "diasVencimiento";
                colvarDiasVencimiento.DataType = DbType.Int32;
                colvarDiasVencimiento.MaxLength = 0;
                colvarDiasVencimiento.AutoIncrement = false;
                colvarDiasVencimiento.IsNullable = false;
                colvarDiasVencimiento.IsPrimaryKey = false;
                colvarDiasVencimiento.IsForeignKey = false;
                colvarDiasVencimiento.IsReadOnly = false;
                
                schema.Columns.Add(colvarDiasVencimiento);
                
                TableSchema.TableColumn colvarCantidadMinima = new TableSchema.TableColumn(schema);
                colvarCantidadMinima.ColumnName = "cantidadMinima";
                colvarCantidadMinima.DataType = DbType.Int32;
                colvarCantidadMinima.MaxLength = 0;
                colvarCantidadMinima.AutoIncrement = false;
                colvarCantidadMinima.IsNullable = false;
                colvarCantidadMinima.IsPrimaryKey = false;
                colvarCantidadMinima.IsForeignKey = false;
                colvarCantidadMinima.IsReadOnly = false;
                
                schema.Columns.Add(colvarCantidadMinima);
                
                TableSchema.TableColumn colvarVencimiento = new TableSchema.TableColumn(schema);
                colvarVencimiento.ColumnName = "Vencimiento";
                colvarVencimiento.DataType = DbType.Boolean;
                colvarVencimiento.MaxLength = 0;
                colvarVencimiento.AutoIncrement = false;
                colvarVencimiento.IsNullable = false;
                colvarVencimiento.IsPrimaryKey = false;
                colvarVencimiento.IsForeignKey = false;
                colvarVencimiento.IsReadOnly = false;
                
                schema.Columns.Add(colvarVencimiento);
                
                
                BaseSchema = schema;
                //add this schema to the provider
                //so we can query it later
                DataService.Providers["RisProvider"].AddSchema("INS_GetAlarmas",schema);
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
	    public InsGetAlarma()
	    {
            SetSQLProps();
            SetDefaults();
            MarkNew();
        }
        public InsGetAlarma(bool useDatabaseDefaults)
	    {
		    SetSQLProps();
		    if(useDatabaseDefaults)
		    {
				ForceDefaults();
			}
			MarkNew();
	    }
	    
	    public InsGetAlarma(object keyID)
	    {
		    SetSQLProps();
		    LoadByKey(keyID);
	    }
    	 
	    public InsGetAlarma(string columnName, object columnValue)
        {
            SetSQLProps();
            LoadByParam(columnName,columnValue);
        }
        
	    #endregion
	    
	    #region Props
	    
          
        [XmlAttribute("IdInsumo")]
        [Bindable(true)]
        public int IdInsumo 
	    {
		    get
		    {
			    return GetColumnValue<int>("idInsumo");
		    }
            set 
		    {
			    SetColumnValue("idInsumo", value);
            }
        }
	      
        [XmlAttribute("IdAlarma")]
        [Bindable(true)]
        public int IdAlarma 
	    {
		    get
		    {
			    return GetColumnValue<int>("idAlarma");
		    }
            set 
		    {
			    SetColumnValue("idAlarma", value);
            }
        }
	      
        [XmlAttribute("Codigo")]
        [Bindable(true)]
        public int Codigo 
	    {
		    get
		    {
			    return GetColumnValue<int>("codigo");
		    }
            set 
		    {
			    SetColumnValue("codigo", value);
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
	      
        [XmlAttribute("Descripcion")]
        [Bindable(true)]
        public string Descripcion 
	    {
		    get
		    {
			    return GetColumnValue<string>("Descripcion");
		    }
            set 
		    {
			    SetColumnValue("Descripcion", value);
            }
        }
	      
        [XmlAttribute("DiasVencimiento")]
        [Bindable(true)]
        public int DiasVencimiento 
	    {
		    get
		    {
			    return GetColumnValue<int>("diasVencimiento");
		    }
            set 
		    {
			    SetColumnValue("diasVencimiento", value);
            }
        }
	      
        [XmlAttribute("CantidadMinima")]
        [Bindable(true)]
        public int CantidadMinima 
	    {
		    get
		    {
			    return GetColumnValue<int>("cantidadMinima");
		    }
            set 
		    {
			    SetColumnValue("cantidadMinima", value);
            }
        }
	      
        [XmlAttribute("Vencimiento")]
        [Bindable(true)]
        public bool Vencimiento 
	    {
		    get
		    {
			    return GetColumnValue<bool>("Vencimiento");
		    }
            set 
		    {
			    SetColumnValue("Vencimiento", value);
            }
        }
	    
	    #endregion
    
	    #region Columns Struct
	    public struct Columns
	    {
		    
		    
            public static string IdInsumo = @"idInsumo";
            
            public static string IdAlarma = @"idAlarma";
            
            public static string Codigo = @"codigo";
            
            public static string Nombre = @"Nombre";
            
            public static string Descripcion = @"Descripcion";
            
            public static string DiasVencimiento = @"diasVencimiento";
            
            public static string CantidadMinima = @"cantidadMinima";
            
            public static string Vencimiento = @"Vencimiento";
            
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
