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
    /// Strongly-typed collection for the InsGetInsumosxRubroxEfector class.
    /// </summary>
    [Serializable]
    public partial class InsGetInsumosxRubroxEfectorCollection : ReadOnlyList<InsGetInsumosxRubroxEfector, InsGetInsumosxRubroxEfectorCollection>
    {        
        public InsGetInsumosxRubroxEfectorCollection() {}
    }
    /// <summary>
    /// This is  Read-only wrapper class for the INS_GetInsumosxRubroxEfector view.
    /// </summary>
    [Serializable]
    public partial class InsGetInsumosxRubroxEfector : ReadOnlyRecord<InsGetInsumosxRubroxEfector>, IReadOnlyRecord
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
                TableSchema.Table schema = new TableSchema.Table("INS_GetInsumosxRubroxEfector", TableType.View, DataService.GetInstance("RisProvider"));
                schema.Columns = new TableSchema.TableColumnCollection();
                schema.SchemaName = @"dbo";
                //columns
                
                TableSchema.TableColumn colvarIdRubro = new TableSchema.TableColumn(schema);
                colvarIdRubro.ColumnName = "idRubro";
                colvarIdRubro.DataType = DbType.Int32;
                colvarIdRubro.MaxLength = 0;
                colvarIdRubro.AutoIncrement = false;
                colvarIdRubro.IsNullable = false;
                colvarIdRubro.IsPrimaryKey = false;
                colvarIdRubro.IsForeignKey = false;
                colvarIdRubro.IsReadOnly = false;
                
                schema.Columns.Add(colvarIdRubro);
                
                TableSchema.TableColumn colvarCodigo = new TableSchema.TableColumn(schema);
                colvarCodigo.ColumnName = "Codigo";
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
                colvarNombre.MaxLength = 50;
                colvarNombre.AutoIncrement = false;
                colvarNombre.IsNullable = false;
                colvarNombre.IsPrimaryKey = false;
                colvarNombre.IsForeignKey = false;
                colvarNombre.IsReadOnly = false;
                
                schema.Columns.Add(colvarNombre);
                
                TableSchema.TableColumn colvarRubroPrimerNivel = new TableSchema.TableColumn(schema);
                colvarRubroPrimerNivel.ColumnName = "RubroPrimerNivel";
                colvarRubroPrimerNivel.DataType = DbType.Int32;
                colvarRubroPrimerNivel.MaxLength = 0;
                colvarRubroPrimerNivel.AutoIncrement = false;
                colvarRubroPrimerNivel.IsNullable = true;
                colvarRubroPrimerNivel.IsPrimaryKey = false;
                colvarRubroPrimerNivel.IsForeignKey = false;
                colvarRubroPrimerNivel.IsReadOnly = false;
                
                schema.Columns.Add(colvarRubroPrimerNivel);
                
                TableSchema.TableColumn colvarIdRubroPadre = new TableSchema.TableColumn(schema);
                colvarIdRubroPadre.ColumnName = "idRubroPadre";
                colvarIdRubroPadre.DataType = DbType.Int32;
                colvarIdRubroPadre.MaxLength = 0;
                colvarIdRubroPadre.AutoIncrement = false;
                colvarIdRubroPadre.IsNullable = true;
                colvarIdRubroPadre.IsPrimaryKey = false;
                colvarIdRubroPadre.IsForeignKey = false;
                colvarIdRubroPadre.IsReadOnly = false;
                
                schema.Columns.Add(colvarIdRubroPadre);
                
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
                
                TableSchema.TableColumn colvarCodigoInsumo = new TableSchema.TableColumn(schema);
                colvarCodigoInsumo.ColumnName = "CodigoInsumo";
                colvarCodigoInsumo.DataType = DbType.Int32;
                colvarCodigoInsumo.MaxLength = 0;
                colvarCodigoInsumo.AutoIncrement = false;
                colvarCodigoInsumo.IsNullable = false;
                colvarCodigoInsumo.IsPrimaryKey = false;
                colvarCodigoInsumo.IsForeignKey = false;
                colvarCodigoInsumo.IsReadOnly = false;
                
                schema.Columns.Add(colvarCodigoInsumo);
                
                TableSchema.TableColumn colvarRubro = new TableSchema.TableColumn(schema);
                colvarRubro.ColumnName = "Rubro";
                colvarRubro.DataType = DbType.Int32;
                colvarRubro.MaxLength = 0;
                colvarRubro.AutoIncrement = false;
                colvarRubro.IsNullable = false;
                colvarRubro.IsPrimaryKey = false;
                colvarRubro.IsForeignKey = false;
                colvarRubro.IsReadOnly = false;
                
                schema.Columns.Add(colvarRubro);
                
                TableSchema.TableColumn colvarInsumo = new TableSchema.TableColumn(schema);
                colvarInsumo.ColumnName = "Insumo";
                colvarInsumo.DataType = DbType.AnsiString;
                colvarInsumo.MaxLength = 2000;
                colvarInsumo.AutoIncrement = false;
                colvarInsumo.IsNullable = false;
                colvarInsumo.IsPrimaryKey = false;
                colvarInsumo.IsForeignKey = false;
                colvarInsumo.IsReadOnly = false;
                
                schema.Columns.Add(colvarInsumo);
                
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
                
                TableSchema.TableColumn colvarUnidad = new TableSchema.TableColumn(schema);
                colvarUnidad.ColumnName = "Unidad";
                colvarUnidad.DataType = DbType.AnsiString;
                colvarUnidad.MaxLength = 100;
                colvarUnidad.AutoIncrement = false;
                colvarUnidad.IsNullable = false;
                colvarUnidad.IsPrimaryKey = false;
                colvarUnidad.IsForeignKey = false;
                colvarUnidad.IsReadOnly = false;
                
                schema.Columns.Add(colvarUnidad);
                
                TableSchema.TableColumn colvarIdRelInsumoEfector = new TableSchema.TableColumn(schema);
                colvarIdRelInsumoEfector.ColumnName = "idRelInsumoEfector";
                colvarIdRelInsumoEfector.DataType = DbType.Int32;
                colvarIdRelInsumoEfector.MaxLength = 0;
                colvarIdRelInsumoEfector.AutoIncrement = false;
                colvarIdRelInsumoEfector.IsNullable = false;
                colvarIdRelInsumoEfector.IsPrimaryKey = false;
                colvarIdRelInsumoEfector.IsForeignKey = false;
                colvarIdRelInsumoEfector.IsReadOnly = false;
                
                schema.Columns.Add(colvarIdRelInsumoEfector);
                
                TableSchema.TableColumn colvarIdEfector = new TableSchema.TableColumn(schema);
                colvarIdEfector.ColumnName = "idEfector";
                colvarIdEfector.DataType = DbType.Int32;
                colvarIdEfector.MaxLength = 0;
                colvarIdEfector.AutoIncrement = false;
                colvarIdEfector.IsNullable = true;
                colvarIdEfector.IsPrimaryKey = false;
                colvarIdEfector.IsForeignKey = false;
                colvarIdEfector.IsReadOnly = false;
                
                schema.Columns.Add(colvarIdEfector);
                
                TableSchema.TableColumn colvarIdInsumoRel = new TableSchema.TableColumn(schema);
                colvarIdInsumoRel.ColumnName = "idInsumoRel";
                colvarIdInsumoRel.DataType = DbType.Int32;
                colvarIdInsumoRel.MaxLength = 0;
                colvarIdInsumoRel.AutoIncrement = false;
                colvarIdInsumoRel.IsNullable = true;
                colvarIdInsumoRel.IsPrimaryKey = false;
                colvarIdInsumoRel.IsForeignKey = false;
                colvarIdInsumoRel.IsReadOnly = false;
                
                schema.Columns.Add(colvarIdInsumoRel);
                
                
                BaseSchema = schema;
                //add this schema to the provider
                //so we can query it later
                DataService.Providers["RisProvider"].AddSchema("INS_GetInsumosxRubroxEfector",schema);
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
	    public InsGetInsumosxRubroxEfector()
	    {
            SetSQLProps();
            SetDefaults();
            MarkNew();
        }
        public InsGetInsumosxRubroxEfector(bool useDatabaseDefaults)
	    {
		    SetSQLProps();
		    if(useDatabaseDefaults)
		    {
				ForceDefaults();
			}
			MarkNew();
	    }
	    
	    public InsGetInsumosxRubroxEfector(object keyID)
	    {
		    SetSQLProps();
		    LoadByKey(keyID);
	    }
    	 
	    public InsGetInsumosxRubroxEfector(string columnName, object columnValue)
        {
            SetSQLProps();
            LoadByParam(columnName,columnValue);
        }
        
	    #endregion
	    
	    #region Props
	    
          
        [XmlAttribute("IdRubro")]
        [Bindable(true)]
        public int IdRubro 
	    {
		    get
		    {
			    return GetColumnValue<int>("idRubro");
		    }
            set 
		    {
			    SetColumnValue("idRubro", value);
            }
        }
	      
        [XmlAttribute("Codigo")]
        [Bindable(true)]
        public int Codigo 
	    {
		    get
		    {
			    return GetColumnValue<int>("Codigo");
		    }
            set 
		    {
			    SetColumnValue("Codigo", value);
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
	      
        [XmlAttribute("RubroPrimerNivel")]
        [Bindable(true)]
        public int? RubroPrimerNivel 
	    {
		    get
		    {
			    return GetColumnValue<int?>("RubroPrimerNivel");
		    }
            set 
		    {
			    SetColumnValue("RubroPrimerNivel", value);
            }
        }
	      
        [XmlAttribute("IdRubroPadre")]
        [Bindable(true)]
        public int? IdRubroPadre 
	    {
		    get
		    {
			    return GetColumnValue<int?>("idRubroPadre");
		    }
            set 
		    {
			    SetColumnValue("idRubroPadre", value);
            }
        }
	      
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
	      
        [XmlAttribute("CodigoInsumo")]
        [Bindable(true)]
        public int CodigoInsumo 
	    {
		    get
		    {
			    return GetColumnValue<int>("CodigoInsumo");
		    }
            set 
		    {
			    SetColumnValue("CodigoInsumo", value);
            }
        }
	      
        [XmlAttribute("Rubro")]
        [Bindable(true)]
        public int Rubro 
	    {
		    get
		    {
			    return GetColumnValue<int>("Rubro");
		    }
            set 
		    {
			    SetColumnValue("Rubro", value);
            }
        }
	      
        [XmlAttribute("Insumo")]
        [Bindable(true)]
        public string Insumo 
	    {
		    get
		    {
			    return GetColumnValue<string>("Insumo");
		    }
            set 
		    {
			    SetColumnValue("Insumo", value);
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
	      
        [XmlAttribute("Unidad")]
        [Bindable(true)]
        public string Unidad 
	    {
		    get
		    {
			    return GetColumnValue<string>("Unidad");
		    }
            set 
		    {
			    SetColumnValue("Unidad", value);
            }
        }
	      
        [XmlAttribute("IdRelInsumoEfector")]
        [Bindable(true)]
        public int IdRelInsumoEfector 
	    {
		    get
		    {
			    return GetColumnValue<int>("idRelInsumoEfector");
		    }
            set 
		    {
			    SetColumnValue("idRelInsumoEfector", value);
            }
        }
	      
        [XmlAttribute("IdEfector")]
        [Bindable(true)]
        public int? IdEfector 
	    {
		    get
		    {
			    return GetColumnValue<int?>("idEfector");
		    }
            set 
		    {
			    SetColumnValue("idEfector", value);
            }
        }
	      
        [XmlAttribute("IdInsumoRel")]
        [Bindable(true)]
        public int? IdInsumoRel 
	    {
		    get
		    {
			    return GetColumnValue<int?>("idInsumoRel");
		    }
            set 
		    {
			    SetColumnValue("idInsumoRel", value);
            }
        }
	    
	    #endregion
    
	    #region Columns Struct
	    public struct Columns
	    {
		    
		    
            public static string IdRubro = @"idRubro";
            
            public static string Codigo = @"Codigo";
            
            public static string Nombre = @"Nombre";
            
            public static string RubroPrimerNivel = @"RubroPrimerNivel";
            
            public static string IdRubroPadre = @"idRubroPadre";
            
            public static string IdInsumo = @"idInsumo";
            
            public static string CodigoInsumo = @"CodigoInsumo";
            
            public static string Rubro = @"Rubro";
            
            public static string Insumo = @"Insumo";
            
            public static string Descripcion = @"Descripcion";
            
            public static string Unidad = @"Unidad";
            
            public static string IdRelInsumoEfector = @"idRelInsumoEfector";
            
            public static string IdEfector = @"idEfector";
            
            public static string IdInsumoRel = @"idInsumoRel";
            
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
