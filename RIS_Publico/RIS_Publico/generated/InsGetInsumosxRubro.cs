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
    /// Strongly-typed collection for the InsGetInsumosxRubro class.
    /// </summary>
    [Serializable]
    public partial class InsGetInsumosxRubroCollection : ReadOnlyList<InsGetInsumosxRubro, InsGetInsumosxRubroCollection>
    {        
        public InsGetInsumosxRubroCollection() {}
    }
    /// <summary>
    /// This is  Read-only wrapper class for the INS_GetInsumosxRubro view.
    /// </summary>
    [Serializable]
    public partial class InsGetInsumosxRubro : ReadOnlyRecord<InsGetInsumosxRubro>, IReadOnlyRecord
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
                TableSchema.Table schema = new TableSchema.Table("INS_GetInsumosxRubro", TableType.View, DataService.GetInstance("RisProvider"));
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
                
                TableSchema.TableColumn colvarCodigoRubro = new TableSchema.TableColumn(schema);
                colvarCodigoRubro.ColumnName = "CodigoRubro";
                colvarCodigoRubro.DataType = DbType.Int32;
                colvarCodigoRubro.MaxLength = 0;
                colvarCodigoRubro.AutoIncrement = false;
                colvarCodigoRubro.IsNullable = false;
                colvarCodigoRubro.IsPrimaryKey = false;
                colvarCodigoRubro.IsForeignKey = false;
                colvarCodigoRubro.IsReadOnly = false;
                
                schema.Columns.Add(colvarCodigoRubro);
                
                TableSchema.TableColumn colvarRubroPadre = new TableSchema.TableColumn(schema);
                colvarRubroPadre.ColumnName = "RubroPadre";
                colvarRubroPadre.DataType = DbType.AnsiString;
                colvarRubroPadre.MaxLength = 50;
                colvarRubroPadre.AutoIncrement = false;
                colvarRubroPadre.IsNullable = false;
                colvarRubroPadre.IsPrimaryKey = false;
                colvarRubroPadre.IsForeignKey = false;
                colvarRubroPadre.IsReadOnly = false;
                
                schema.Columns.Add(colvarRubroPadre);
                
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
                
                TableSchema.TableColumn colvarRubroNivel1 = new TableSchema.TableColumn(schema);
                colvarRubroNivel1.ColumnName = "RubroNivel1";
                colvarRubroNivel1.DataType = DbType.AnsiString;
                colvarRubroNivel1.MaxLength = 50;
                colvarRubroNivel1.AutoIncrement = false;
                colvarRubroNivel1.IsNullable = false;
                colvarRubroNivel1.IsPrimaryKey = false;
                colvarRubroNivel1.IsForeignKey = false;
                colvarRubroNivel1.IsReadOnly = false;
                
                schema.Columns.Add(colvarRubroNivel1);
                
                
                BaseSchema = schema;
                //add this schema to the provider
                //so we can query it later
                DataService.Providers["RisProvider"].AddSchema("INS_GetInsumosxRubro",schema);
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
	    public InsGetInsumosxRubro()
	    {
            SetSQLProps();
            SetDefaults();
            MarkNew();
        }
        public InsGetInsumosxRubro(bool useDatabaseDefaults)
	    {
		    SetSQLProps();
		    if(useDatabaseDefaults)
		    {
				ForceDefaults();
			}
			MarkNew();
	    }
	    
	    public InsGetInsumosxRubro(object keyID)
	    {
		    SetSQLProps();
		    LoadByKey(keyID);
	    }
    	 
	    public InsGetInsumosxRubro(string columnName, object columnValue)
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
	      
        [XmlAttribute("CodigoRubro")]
        [Bindable(true)]
        public int CodigoRubro 
	    {
		    get
		    {
			    return GetColumnValue<int>("CodigoRubro");
		    }
            set 
		    {
			    SetColumnValue("CodigoRubro", value);
            }
        }
	      
        [XmlAttribute("RubroPadre")]
        [Bindable(true)]
        public string RubroPadre 
	    {
		    get
		    {
			    return GetColumnValue<string>("RubroPadre");
		    }
            set 
		    {
			    SetColumnValue("RubroPadre", value);
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
	      
        [XmlAttribute("RubroNivel1")]
        [Bindable(true)]
        public string RubroNivel1 
	    {
		    get
		    {
			    return GetColumnValue<string>("RubroNivel1");
		    }
            set 
		    {
			    SetColumnValue("RubroNivel1", value);
            }
        }
	    
	    #endregion
    
	    #region Columns Struct
	    public struct Columns
	    {
		    
		    
            public static string IdInsumo = @"idInsumo";
            
            public static string Codigo = @"codigo";
            
            public static string Rubro = @"Rubro";
            
            public static string Insumo = @"Insumo";
            
            public static string Descripcion = @"Descripcion";
            
            public static string IdRubro = @"idRubro";
            
            public static string CodigoRubro = @"CodigoRubro";
            
            public static string RubroPadre = @"RubroPadre";
            
            public static string RubroPrimerNivel = @"RubroPrimerNivel";
            
            public static string RubroNivel1 = @"RubroNivel1";
            
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
