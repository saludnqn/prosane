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
    /// Strongly-typed collection for the InsGetInsumo class.
    /// </summary>
    [Serializable]
    public partial class InsGetInsumoCollection : ReadOnlyList<InsGetInsumo, InsGetInsumoCollection>
    {        
        public InsGetInsumoCollection() {}
    }
    /// <summary>
    /// This is  Read-only wrapper class for the INS_GetInsumos view.
    /// </summary>
    [Serializable]
    public partial class InsGetInsumo : ReadOnlyRecord<InsGetInsumo>, IReadOnlyRecord
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
                TableSchema.Table schema = new TableSchema.Table("INS_GetInsumos", TableType.View, DataService.GetInstance("RisProvider"));
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
                
                TableSchema.TableColumn colvarIdPedidoDetalle = new TableSchema.TableColumn(schema);
                colvarIdPedidoDetalle.ColumnName = "idPedidoDetalle";
                colvarIdPedidoDetalle.DataType = DbType.Int32;
                colvarIdPedidoDetalle.MaxLength = 0;
                colvarIdPedidoDetalle.AutoIncrement = false;
                colvarIdPedidoDetalle.IsNullable = false;
                colvarIdPedidoDetalle.IsPrimaryKey = false;
                colvarIdPedidoDetalle.IsForeignKey = false;
                colvarIdPedidoDetalle.IsReadOnly = false;
                
                schema.Columns.Add(colvarIdPedidoDetalle);
                
                TableSchema.TableColumn colvarIdPedido = new TableSchema.TableColumn(schema);
                colvarIdPedido.ColumnName = "idPedido";
                colvarIdPedido.DataType = DbType.Int32;
                colvarIdPedido.MaxLength = 0;
                colvarIdPedido.AutoIncrement = false;
                colvarIdPedido.IsNullable = false;
                colvarIdPedido.IsPrimaryKey = false;
                colvarIdPedido.IsForeignKey = false;
                colvarIdPedido.IsReadOnly = false;
                
                schema.Columns.Add(colvarIdPedido);
                
                TableSchema.TableColumn colvarCantidadRecibida = new TableSchema.TableColumn(schema);
                colvarCantidadRecibida.ColumnName = "cantidadRecibida";
                colvarCantidadRecibida.DataType = DbType.Int32;
                colvarCantidadRecibida.MaxLength = 0;
                colvarCantidadRecibida.AutoIncrement = false;
                colvarCantidadRecibida.IsNullable = false;
                colvarCantidadRecibida.IsPrimaryKey = false;
                colvarCantidadRecibida.IsForeignKey = false;
                colvarCantidadRecibida.IsReadOnly = false;
                
                schema.Columns.Add(colvarCantidadRecibida);
                
                TableSchema.TableColumn colvarPrecioUnitario = new TableSchema.TableColumn(schema);
                colvarPrecioUnitario.ColumnName = "precioUnitario";
                colvarPrecioUnitario.DataType = DbType.Decimal;
                colvarPrecioUnitario.MaxLength = 0;
                colvarPrecioUnitario.AutoIncrement = false;
                colvarPrecioUnitario.IsNullable = false;
                colvarPrecioUnitario.IsPrimaryKey = false;
                colvarPrecioUnitario.IsForeignKey = false;
                colvarPrecioUnitario.IsReadOnly = false;
                
                schema.Columns.Add(colvarPrecioUnitario);
                
                TableSchema.TableColumn colvarRenglonOC = new TableSchema.TableColumn(schema);
                colvarRenglonOC.ColumnName = "renglonOC";
                colvarRenglonOC.DataType = DbType.Int32;
                colvarRenglonOC.MaxLength = 0;
                colvarRenglonOC.AutoIncrement = false;
                colvarRenglonOC.IsNullable = false;
                colvarRenglonOC.IsPrimaryKey = false;
                colvarRenglonOC.IsForeignKey = false;
                colvarRenglonOC.IsReadOnly = false;
                
                schema.Columns.Add(colvarRenglonOC);
                
                TableSchema.TableColumn colvarNumeroLote = new TableSchema.TableColumn(schema);
                colvarNumeroLote.ColumnName = "numeroLote";
                colvarNumeroLote.DataType = DbType.AnsiString;
                colvarNumeroLote.MaxLength = 50;
                colvarNumeroLote.AutoIncrement = false;
                colvarNumeroLote.IsNullable = false;
                colvarNumeroLote.IsPrimaryKey = false;
                colvarNumeroLote.IsForeignKey = false;
                colvarNumeroLote.IsReadOnly = false;
                
                schema.Columns.Add(colvarNumeroLote);
                
                TableSchema.TableColumn colvarFechaVencimiento = new TableSchema.TableColumn(schema);
                colvarFechaVencimiento.ColumnName = "fechaVencimiento";
                colvarFechaVencimiento.DataType = DbType.DateTime;
                colvarFechaVencimiento.MaxLength = 0;
                colvarFechaVencimiento.AutoIncrement = false;
                colvarFechaVencimiento.IsNullable = false;
                colvarFechaVencimiento.IsPrimaryKey = false;
                colvarFechaVencimiento.IsForeignKey = false;
                colvarFechaVencimiento.IsReadOnly = false;
                
                schema.Columns.Add(colvarFechaVencimiento);
                
                TableSchema.TableColumn colvarModifiedOn = new TableSchema.TableColumn(schema);
                colvarModifiedOn.ColumnName = "ModifiedOn";
                colvarModifiedOn.DataType = DbType.DateTime;
                colvarModifiedOn.MaxLength = 0;
                colvarModifiedOn.AutoIncrement = false;
                colvarModifiedOn.IsNullable = false;
                colvarModifiedOn.IsPrimaryKey = false;
                colvarModifiedOn.IsForeignKey = false;
                colvarModifiedOn.IsReadOnly = false;
                
                schema.Columns.Add(colvarModifiedOn);
                
                
                BaseSchema = schema;
                //add this schema to the provider
                //so we can query it later
                DataService.Providers["RisProvider"].AddSchema("INS_GetInsumos",schema);
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
	    public InsGetInsumo()
	    {
            SetSQLProps();
            SetDefaults();
            MarkNew();
        }
        public InsGetInsumo(bool useDatabaseDefaults)
	    {
		    SetSQLProps();
		    if(useDatabaseDefaults)
		    {
				ForceDefaults();
			}
			MarkNew();
	    }
	    
	    public InsGetInsumo(object keyID)
	    {
		    SetSQLProps();
		    LoadByKey(keyID);
	    }
    	 
	    public InsGetInsumo(string columnName, object columnValue)
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
	      
        [XmlAttribute("IdPedidoDetalle")]
        [Bindable(true)]
        public int IdPedidoDetalle 
	    {
		    get
		    {
			    return GetColumnValue<int>("idPedidoDetalle");
		    }
            set 
		    {
			    SetColumnValue("idPedidoDetalle", value);
            }
        }
	      
        [XmlAttribute("IdPedido")]
        [Bindable(true)]
        public int IdPedido 
	    {
		    get
		    {
			    return GetColumnValue<int>("idPedido");
		    }
            set 
		    {
			    SetColumnValue("idPedido", value);
            }
        }
	      
        [XmlAttribute("CantidadRecibida")]
        [Bindable(true)]
        public int CantidadRecibida 
	    {
		    get
		    {
			    return GetColumnValue<int>("cantidadRecibida");
		    }
            set 
		    {
			    SetColumnValue("cantidadRecibida", value);
            }
        }
	      
        [XmlAttribute("PrecioUnitario")]
        [Bindable(true)]
        public decimal PrecioUnitario 
	    {
		    get
		    {
			    return GetColumnValue<decimal>("precioUnitario");
		    }
            set 
		    {
			    SetColumnValue("precioUnitario", value);
            }
        }
	      
        [XmlAttribute("RenglonOC")]
        [Bindable(true)]
        public int RenglonOC 
	    {
		    get
		    {
			    return GetColumnValue<int>("renglonOC");
		    }
            set 
		    {
			    SetColumnValue("renglonOC", value);
            }
        }
	      
        [XmlAttribute("NumeroLote")]
        [Bindable(true)]
        public string NumeroLote 
	    {
		    get
		    {
			    return GetColumnValue<string>("numeroLote");
		    }
            set 
		    {
			    SetColumnValue("numeroLote", value);
            }
        }
	      
        [XmlAttribute("FechaVencimiento")]
        [Bindable(true)]
        public DateTime FechaVencimiento 
	    {
		    get
		    {
			    return GetColumnValue<DateTime>("fechaVencimiento");
		    }
            set 
		    {
			    SetColumnValue("fechaVencimiento", value);
            }
        }
	      
        [XmlAttribute("ModifiedOn")]
        [Bindable(true)]
        public DateTime ModifiedOn 
	    {
		    get
		    {
			    return GetColumnValue<DateTime>("ModifiedOn");
		    }
            set 
		    {
			    SetColumnValue("ModifiedOn", value);
            }
        }
	    
	    #endregion
    
	    #region Columns Struct
	    public struct Columns
	    {
		    
		    
            public static string IdInsumo = @"idInsumo";
            
            public static string Codigo = @"codigo";
            
            public static string IdPedidoDetalle = @"idPedidoDetalle";
            
            public static string IdPedido = @"idPedido";
            
            public static string CantidadRecibida = @"cantidadRecibida";
            
            public static string PrecioUnitario = @"precioUnitario";
            
            public static string RenglonOC = @"renglonOC";
            
            public static string NumeroLote = @"numeroLote";
            
            public static string FechaVencimiento = @"fechaVencimiento";
            
            public static string ModifiedOn = @"ModifiedOn";
            
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
