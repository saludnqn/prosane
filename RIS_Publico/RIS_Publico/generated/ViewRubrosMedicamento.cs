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
    /// Strongly-typed collection for the ViewRubrosMedicamento class.
    /// </summary>
    [Serializable]
    public partial class ViewRubrosMedicamentoCollection : ReadOnlyList<ViewRubrosMedicamento, ViewRubrosMedicamentoCollection>
    {        
        public ViewRubrosMedicamentoCollection() {}
    }
    /// <summary>
    /// This is  Read-only wrapper class for the View_RubrosMedicamentos view.
    /// </summary>
    [Serializable]
    public partial class ViewRubrosMedicamento : ReadOnlyRecord<ViewRubrosMedicamento>, IReadOnlyRecord
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
                TableSchema.Table schema = new TableSchema.Table("View_RubrosMedicamentos", TableType.View, DataService.GetInstance("RisProvider"));
                schema.Columns = new TableSchema.TableColumnCollection();
                schema.SchemaName = @"dbo";
                //columns
                
                TableSchema.TableColumn colvarIdMedicamento = new TableSchema.TableColumn(schema);
                colvarIdMedicamento.ColumnName = "idMedicamento";
                colvarIdMedicamento.DataType = DbType.Int32;
                colvarIdMedicamento.MaxLength = 0;
                colvarIdMedicamento.AutoIncrement = false;
                colvarIdMedicamento.IsNullable = false;
                colvarIdMedicamento.IsPrimaryKey = false;
                colvarIdMedicamento.IsForeignKey = false;
                colvarIdMedicamento.IsReadOnly = false;
                
                schema.Columns.Add(colvarIdMedicamento);
                
                TableSchema.TableColumn colvarCodigo = new TableSchema.TableColumn(schema);
                colvarCodigo.ColumnName = "codigo";
                colvarCodigo.DataType = DbType.Int32;
                colvarCodigo.MaxLength = 0;
                colvarCodigo.AutoIncrement = false;
                colvarCodigo.IsNullable = true;
                colvarCodigo.IsPrimaryKey = false;
                colvarCodigo.IsForeignKey = false;
                colvarCodigo.IsReadOnly = false;
                
                schema.Columns.Add(colvarCodigo);
                
                TableSchema.TableColumn colvarNombre = new TableSchema.TableColumn(schema);
                colvarNombre.ColumnName = "nombre";
                colvarNombre.DataType = DbType.String;
                colvarNombre.MaxLength = 255;
                colvarNombre.AutoIncrement = false;
                colvarNombre.IsNullable = true;
                colvarNombre.IsPrimaryKey = false;
                colvarNombre.IsForeignKey = false;
                colvarNombre.IsReadOnly = false;
                
                schema.Columns.Add(colvarNombre);
                
                TableSchema.TableColumn colvarUnidad = new TableSchema.TableColumn(schema);
                colvarUnidad.ColumnName = "unidad";
                colvarUnidad.DataType = DbType.String;
                colvarUnidad.MaxLength = 255;
                colvarUnidad.AutoIncrement = false;
                colvarUnidad.IsNullable = true;
                colvarUnidad.IsPrimaryKey = false;
                colvarUnidad.IsForeignKey = false;
                colvarUnidad.IsReadOnly = false;
                
                schema.Columns.Add(colvarUnidad);
                
                TableSchema.TableColumn colvarNecesitaVencimiento = new TableSchema.TableColumn(schema);
                colvarNecesitaVencimiento.ColumnName = "necesitaVencimiento";
                colvarNecesitaVencimiento.DataType = DbType.Boolean;
                colvarNecesitaVencimiento.MaxLength = 0;
                colvarNecesitaVencimiento.AutoIncrement = false;
                colvarNecesitaVencimiento.IsNullable = true;
                colvarNecesitaVencimiento.IsPrimaryKey = false;
                colvarNecesitaVencimiento.IsForeignKey = false;
                colvarNecesitaVencimiento.IsReadOnly = false;
                
                schema.Columns.Add(colvarNecesitaVencimiento);
                
                TableSchema.TableColumn colvarActivo = new TableSchema.TableColumn(schema);
                colvarActivo.ColumnName = "activo";
                colvarActivo.DataType = DbType.Boolean;
                colvarActivo.MaxLength = 0;
                colvarActivo.AutoIncrement = false;
                colvarActivo.IsNullable = true;
                colvarActivo.IsPrimaryKey = false;
                colvarActivo.IsForeignKey = false;
                colvarActivo.IsReadOnly = false;
                
                schema.Columns.Add(colvarActivo);
                
                TableSchema.TableColumn colvarUltimaModificacion = new TableSchema.TableColumn(schema);
                colvarUltimaModificacion.ColumnName = "ultimaModificacion";
                colvarUltimaModificacion.DataType = DbType.DateTime;
                colvarUltimaModificacion.MaxLength = 0;
                colvarUltimaModificacion.AutoIncrement = false;
                colvarUltimaModificacion.IsNullable = true;
                colvarUltimaModificacion.IsPrimaryKey = false;
                colvarUltimaModificacion.IsForeignKey = false;
                colvarUltimaModificacion.IsReadOnly = false;
                
                schema.Columns.Add(colvarUltimaModificacion);
                
                TableSchema.TableColumn colvarIdMedicamentoRubro = new TableSchema.TableColumn(schema);
                colvarIdMedicamentoRubro.ColumnName = "idMedicamentoRubro";
                colvarIdMedicamentoRubro.DataType = DbType.Int32;
                colvarIdMedicamentoRubro.MaxLength = 0;
                colvarIdMedicamentoRubro.AutoIncrement = false;
                colvarIdMedicamentoRubro.IsNullable = false;
                colvarIdMedicamentoRubro.IsPrimaryKey = false;
                colvarIdMedicamentoRubro.IsForeignKey = false;
                colvarIdMedicamentoRubro.IsReadOnly = false;
                
                schema.Columns.Add(colvarIdMedicamentoRubro);
                
                TableSchema.TableColumn colvarExpr1 = new TableSchema.TableColumn(schema);
                colvarExpr1.ColumnName = "Expr1";
                colvarExpr1.DataType = DbType.Int32;
                colvarExpr1.MaxLength = 0;
                colvarExpr1.AutoIncrement = false;
                colvarExpr1.IsNullable = true;
                colvarExpr1.IsPrimaryKey = false;
                colvarExpr1.IsForeignKey = false;
                colvarExpr1.IsReadOnly = false;
                
                schema.Columns.Add(colvarExpr1);
                
                TableSchema.TableColumn colvarPadre = new TableSchema.TableColumn(schema);
                colvarPadre.ColumnName = "padre";
                colvarPadre.DataType = DbType.Int32;
                colvarPadre.MaxLength = 0;
                colvarPadre.AutoIncrement = false;
                colvarPadre.IsNullable = true;
                colvarPadre.IsPrimaryKey = false;
                colvarPadre.IsForeignKey = false;
                colvarPadre.IsReadOnly = false;
                
                schema.Columns.Add(colvarPadre);
                
                TableSchema.TableColumn colvarExpr2 = new TableSchema.TableColumn(schema);
                colvarExpr2.ColumnName = "Expr2";
                colvarExpr2.DataType = DbType.String;
                colvarExpr2.MaxLength = 255;
                colvarExpr2.AutoIncrement = false;
                colvarExpr2.IsNullable = true;
                colvarExpr2.IsPrimaryKey = false;
                colvarExpr2.IsForeignKey = false;
                colvarExpr2.IsReadOnly = false;
                
                schema.Columns.Add(colvarExpr2);
                
                TableSchema.TableColumn colvarRubroPrimerNivel = new TableSchema.TableColumn(schema);
                colvarRubroPrimerNivel.ColumnName = "rubroPrimerNivel";
                colvarRubroPrimerNivel.DataType = DbType.Int32;
                colvarRubroPrimerNivel.MaxLength = 0;
                colvarRubroPrimerNivel.AutoIncrement = false;
                colvarRubroPrimerNivel.IsNullable = true;
                colvarRubroPrimerNivel.IsPrimaryKey = false;
                colvarRubroPrimerNivel.IsForeignKey = false;
                colvarRubroPrimerNivel.IsReadOnly = false;
                
                schema.Columns.Add(colvarRubroPrimerNivel);
                
                TableSchema.TableColumn colvarRubro = new TableSchema.TableColumn(schema);
                colvarRubro.ColumnName = "rubro";
                colvarRubro.DataType = DbType.Int32;
                colvarRubro.MaxLength = 0;
                colvarRubro.AutoIncrement = false;
                colvarRubro.IsNullable = true;
                colvarRubro.IsPrimaryKey = false;
                colvarRubro.IsForeignKey = false;
                colvarRubro.IsReadOnly = false;
                
                schema.Columns.Add(colvarRubro);
                
                
                BaseSchema = schema;
                //add this schema to the provider
                //so we can query it later
                DataService.Providers["RisProvider"].AddSchema("View_RubrosMedicamentos",schema);
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
	    public ViewRubrosMedicamento()
	    {
            SetSQLProps();
            SetDefaults();
            MarkNew();
        }
        public ViewRubrosMedicamento(bool useDatabaseDefaults)
	    {
		    SetSQLProps();
		    if(useDatabaseDefaults)
		    {
				ForceDefaults();
			}
			MarkNew();
	    }
	    
	    public ViewRubrosMedicamento(object keyID)
	    {
		    SetSQLProps();
		    LoadByKey(keyID);
	    }
    	 
	    public ViewRubrosMedicamento(string columnName, object columnValue)
        {
            SetSQLProps();
            LoadByParam(columnName,columnValue);
        }
        
	    #endregion
	    
	    #region Props
	    
          
        [XmlAttribute("IdMedicamento")]
        [Bindable(true)]
        public int IdMedicamento 
	    {
		    get
		    {
			    return GetColumnValue<int>("idMedicamento");
		    }
            set 
		    {
			    SetColumnValue("idMedicamento", value);
            }
        }
	      
        [XmlAttribute("Codigo")]
        [Bindable(true)]
        public int? Codigo 
	    {
		    get
		    {
			    return GetColumnValue<int?>("codigo");
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
			    return GetColumnValue<string>("nombre");
		    }
            set 
		    {
			    SetColumnValue("nombre", value);
            }
        }
	      
        [XmlAttribute("Unidad")]
        [Bindable(true)]
        public string Unidad 
	    {
		    get
		    {
			    return GetColumnValue<string>("unidad");
		    }
            set 
		    {
			    SetColumnValue("unidad", value);
            }
        }
	      
        [XmlAttribute("NecesitaVencimiento")]
        [Bindable(true)]
        public bool? NecesitaVencimiento 
	    {
		    get
		    {
			    return GetColumnValue<bool?>("necesitaVencimiento");
		    }
            set 
		    {
			    SetColumnValue("necesitaVencimiento", value);
            }
        }
	      
        [XmlAttribute("Activo")]
        [Bindable(true)]
        public bool? Activo 
	    {
		    get
		    {
			    return GetColumnValue<bool?>("activo");
		    }
            set 
		    {
			    SetColumnValue("activo", value);
            }
        }
	      
        [XmlAttribute("UltimaModificacion")]
        [Bindable(true)]
        public DateTime? UltimaModificacion 
	    {
		    get
		    {
			    return GetColumnValue<DateTime?>("ultimaModificacion");
		    }
            set 
		    {
			    SetColumnValue("ultimaModificacion", value);
            }
        }
	      
        [XmlAttribute("IdMedicamentoRubro")]
        [Bindable(true)]
        public int IdMedicamentoRubro 
	    {
		    get
		    {
			    return GetColumnValue<int>("idMedicamentoRubro");
		    }
            set 
		    {
			    SetColumnValue("idMedicamentoRubro", value);
            }
        }
	      
        [XmlAttribute("Expr1")]
        [Bindable(true)]
        public int? Expr1 
	    {
		    get
		    {
			    return GetColumnValue<int?>("Expr1");
		    }
            set 
		    {
			    SetColumnValue("Expr1", value);
            }
        }
	      
        [XmlAttribute("Padre")]
        [Bindable(true)]
        public int? Padre 
	    {
		    get
		    {
			    return GetColumnValue<int?>("padre");
		    }
            set 
		    {
			    SetColumnValue("padre", value);
            }
        }
	      
        [XmlAttribute("Expr2")]
        [Bindable(true)]
        public string Expr2 
	    {
		    get
		    {
			    return GetColumnValue<string>("Expr2");
		    }
            set 
		    {
			    SetColumnValue("Expr2", value);
            }
        }
	      
        [XmlAttribute("RubroPrimerNivel")]
        [Bindable(true)]
        public int? RubroPrimerNivel 
	    {
		    get
		    {
			    return GetColumnValue<int?>("rubroPrimerNivel");
		    }
            set 
		    {
			    SetColumnValue("rubroPrimerNivel", value);
            }
        }
	      
        [XmlAttribute("Rubro")]
        [Bindable(true)]
        public int? Rubro 
	    {
		    get
		    {
			    return GetColumnValue<int?>("rubro");
		    }
            set 
		    {
			    SetColumnValue("rubro", value);
            }
        }
	    
	    #endregion
    
	    #region Columns Struct
	    public struct Columns
	    {
		    
		    
            public static string IdMedicamento = @"idMedicamento";
            
            public static string Codigo = @"codigo";
            
            public static string Nombre = @"nombre";
            
            public static string Unidad = @"unidad";
            
            public static string NecesitaVencimiento = @"necesitaVencimiento";
            
            public static string Activo = @"activo";
            
            public static string UltimaModificacion = @"ultimaModificacion";
            
            public static string IdMedicamentoRubro = @"idMedicamentoRubro";
            
            public static string Expr1 = @"Expr1";
            
            public static string Padre = @"padre";
            
            public static string Expr2 = @"Expr2";
            
            public static string RubroPrimerNivel = @"rubroPrimerNivel";
            
            public static string Rubro = @"rubro";
            
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
