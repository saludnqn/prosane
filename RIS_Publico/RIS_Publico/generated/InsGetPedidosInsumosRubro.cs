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
    /// Strongly-typed collection for the InsGetPedidosInsumosRubro class.
    /// </summary>
    [Serializable]
    public partial class InsGetPedidosInsumosRubroCollection : ReadOnlyList<InsGetPedidosInsumosRubro, InsGetPedidosInsumosRubroCollection>
    {        
        public InsGetPedidosInsumosRubroCollection() {}
    }
    /// <summary>
    /// This is  Read-only wrapper class for the INS_GetPedidosInsumosRubro view.
    /// </summary>
    [Serializable]
    public partial class InsGetPedidosInsumosRubro : ReadOnlyRecord<InsGetPedidosInsumosRubro>, IReadOnlyRecord
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
                TableSchema.Table schema = new TableSchema.Table("INS_GetPedidosInsumosRubro", TableType.View, DataService.GetInstance("RisProvider"));
                schema.Columns = new TableSchema.TableColumnCollection();
                schema.SchemaName = @"dbo";
                //columns
                
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
                
                TableSchema.TableColumn colvarIdEfectorProveedor = new TableSchema.TableColumn(schema);
                colvarIdEfectorProveedor.ColumnName = "idEfectorProveedor";
                colvarIdEfectorProveedor.DataType = DbType.Int32;
                colvarIdEfectorProveedor.MaxLength = 0;
                colvarIdEfectorProveedor.AutoIncrement = false;
                colvarIdEfectorProveedor.IsNullable = true;
                colvarIdEfectorProveedor.IsPrimaryKey = false;
                colvarIdEfectorProveedor.IsForeignKey = false;
                colvarIdEfectorProveedor.IsReadOnly = false;
                
                schema.Columns.Add(colvarIdEfectorProveedor);
                
                TableSchema.TableColumn colvarIdDeposito = new TableSchema.TableColumn(schema);
                colvarIdDeposito.ColumnName = "idDeposito";
                colvarIdDeposito.DataType = DbType.Int32;
                colvarIdDeposito.MaxLength = 0;
                colvarIdDeposito.AutoIncrement = false;
                colvarIdDeposito.IsNullable = true;
                colvarIdDeposito.IsPrimaryKey = false;
                colvarIdDeposito.IsForeignKey = false;
                colvarIdDeposito.IsReadOnly = false;
                
                schema.Columns.Add(colvarIdDeposito);
                
                TableSchema.TableColumn colvarIdDepositoProveedor = new TableSchema.TableColumn(schema);
                colvarIdDepositoProveedor.ColumnName = "idDepositoProveedor";
                colvarIdDepositoProveedor.DataType = DbType.Int32;
                colvarIdDepositoProveedor.MaxLength = 0;
                colvarIdDepositoProveedor.AutoIncrement = false;
                colvarIdDepositoProveedor.IsNullable = true;
                colvarIdDepositoProveedor.IsPrimaryKey = false;
                colvarIdDepositoProveedor.IsForeignKey = false;
                colvarIdDepositoProveedor.IsReadOnly = false;
                
                schema.Columns.Add(colvarIdDepositoProveedor);
                
                TableSchema.TableColumn colvarFecha = new TableSchema.TableColumn(schema);
                colvarFecha.ColumnName = "fecha";
                colvarFecha.DataType = DbType.DateTime;
                colvarFecha.MaxLength = 0;
                colvarFecha.AutoIncrement = false;
                colvarFecha.IsNullable = true;
                colvarFecha.IsPrimaryKey = false;
                colvarFecha.IsForeignKey = false;
                colvarFecha.IsReadOnly = false;
                
                schema.Columns.Add(colvarFecha);
                
                TableSchema.TableColumn colvarFechaRecepcion = new TableSchema.TableColumn(schema);
                colvarFechaRecepcion.ColumnName = "fechaRecepcion";
                colvarFechaRecepcion.DataType = DbType.DateTime;
                colvarFechaRecepcion.MaxLength = 0;
                colvarFechaRecepcion.AutoIncrement = false;
                colvarFechaRecepcion.IsNullable = true;
                colvarFechaRecepcion.IsPrimaryKey = false;
                colvarFechaRecepcion.IsForeignKey = false;
                colvarFechaRecepcion.IsReadOnly = false;
                
                schema.Columns.Add(colvarFechaRecepcion);
                
                TableSchema.TableColumn colvarIdTipoPedido = new TableSchema.TableColumn(schema);
                colvarIdTipoPedido.ColumnName = "idTipoPedido";
                colvarIdTipoPedido.DataType = DbType.Int32;
                colvarIdTipoPedido.MaxLength = 0;
                colvarIdTipoPedido.AutoIncrement = false;
                colvarIdTipoPedido.IsNullable = true;
                colvarIdTipoPedido.IsPrimaryKey = false;
                colvarIdTipoPedido.IsForeignKey = false;
                colvarIdTipoPedido.IsReadOnly = false;
                
                schema.Columns.Add(colvarIdTipoPedido);
                
                TableSchema.TableColumn colvarIdEstadoPedido = new TableSchema.TableColumn(schema);
                colvarIdEstadoPedido.ColumnName = "idEstadoPedido";
                colvarIdEstadoPedido.DataType = DbType.Int32;
                colvarIdEstadoPedido.MaxLength = 0;
                colvarIdEstadoPedido.AutoIncrement = false;
                colvarIdEstadoPedido.IsNullable = true;
                colvarIdEstadoPedido.IsPrimaryKey = false;
                colvarIdEstadoPedido.IsForeignKey = false;
                colvarIdEstadoPedido.IsReadOnly = false;
                
                schema.Columns.Add(colvarIdEstadoPedido);
                
                TableSchema.TableColumn colvarIdRubro = new TableSchema.TableColumn(schema);
                colvarIdRubro.ColumnName = "idRubro";
                colvarIdRubro.DataType = DbType.Int32;
                colvarIdRubro.MaxLength = 0;
                colvarIdRubro.AutoIncrement = false;
                colvarIdRubro.IsNullable = true;
                colvarIdRubro.IsPrimaryKey = false;
                colvarIdRubro.IsForeignKey = false;
                colvarIdRubro.IsReadOnly = false;
                
                schema.Columns.Add(colvarIdRubro);
                
                TableSchema.TableColumn colvarObservaciones = new TableSchema.TableColumn(schema);
                colvarObservaciones.ColumnName = "observaciones";
                colvarObservaciones.DataType = DbType.AnsiString;
                colvarObservaciones.MaxLength = 1000;
                colvarObservaciones.AutoIncrement = false;
                colvarObservaciones.IsNullable = true;
                colvarObservaciones.IsPrimaryKey = false;
                colvarObservaciones.IsForeignKey = false;
                colvarObservaciones.IsReadOnly = false;
                
                schema.Columns.Add(colvarObservaciones);
                
                TableSchema.TableColumn colvarResponsable = new TableSchema.TableColumn(schema);
                colvarResponsable.ColumnName = "responsable";
                colvarResponsable.DataType = DbType.AnsiString;
                colvarResponsable.MaxLength = 200;
                colvarResponsable.AutoIncrement = false;
                colvarResponsable.IsNullable = true;
                colvarResponsable.IsPrimaryKey = false;
                colvarResponsable.IsForeignKey = false;
                colvarResponsable.IsReadOnly = false;
                
                schema.Columns.Add(colvarResponsable);
                
                TableSchema.TableColumn colvarAutorizado = new TableSchema.TableColumn(schema);
                colvarAutorizado.ColumnName = "autorizado";
                colvarAutorizado.DataType = DbType.Boolean;
                colvarAutorizado.MaxLength = 0;
                colvarAutorizado.AutoIncrement = false;
                colvarAutorizado.IsNullable = true;
                colvarAutorizado.IsPrimaryKey = false;
                colvarAutorizado.IsForeignKey = false;
                colvarAutorizado.IsReadOnly = false;
                
                schema.Columns.Add(colvarAutorizado);
                
                TableSchema.TableColumn colvarIdProveedor = new TableSchema.TableColumn(schema);
                colvarIdProveedor.ColumnName = "idProveedor";
                colvarIdProveedor.DataType = DbType.Int32;
                colvarIdProveedor.MaxLength = 0;
                colvarIdProveedor.AutoIncrement = false;
                colvarIdProveedor.IsNullable = true;
                colvarIdProveedor.IsPrimaryKey = false;
                colvarIdProveedor.IsForeignKey = false;
                colvarIdProveedor.IsReadOnly = false;
                
                schema.Columns.Add(colvarIdProveedor);
                
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
                
                TableSchema.TableColumn colvarCantidad = new TableSchema.TableColumn(schema);
                colvarCantidad.ColumnName = "cantidad";
                colvarCantidad.DataType = DbType.Int32;
                colvarCantidad.MaxLength = 0;
                colvarCantidad.AutoIncrement = false;
                colvarCantidad.IsNullable = false;
                colvarCantidad.IsPrimaryKey = false;
                colvarCantidad.IsForeignKey = false;
                colvarCantidad.IsReadOnly = false;
                
                schema.Columns.Add(colvarCantidad);
                
                TableSchema.TableColumn colvarPresentacion = new TableSchema.TableColumn(schema);
                colvarPresentacion.ColumnName = "presentacion";
                colvarPresentacion.DataType = DbType.Int32;
                colvarPresentacion.MaxLength = 0;
                colvarPresentacion.AutoIncrement = false;
                colvarPresentacion.IsNullable = false;
                colvarPresentacion.IsPrimaryKey = false;
                colvarPresentacion.IsForeignKey = false;
                colvarPresentacion.IsReadOnly = false;
                
                schema.Columns.Add(colvarPresentacion);
                
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
                
                TableSchema.TableColumn colvarStock = new TableSchema.TableColumn(schema);
                colvarStock.ColumnName = "stock";
                colvarStock.DataType = DbType.Int32;
                colvarStock.MaxLength = 0;
                colvarStock.AutoIncrement = false;
                colvarStock.IsNullable = false;
                colvarStock.IsPrimaryKey = false;
                colvarStock.IsForeignKey = false;
                colvarStock.IsReadOnly = false;
                
                schema.Columns.Add(colvarStock);
                
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
                
                TableSchema.TableColumn colvarObservacion = new TableSchema.TableColumn(schema);
                colvarObservacion.ColumnName = "observacion";
                colvarObservacion.DataType = DbType.AnsiString;
                colvarObservacion.MaxLength = 500;
                colvarObservacion.AutoIncrement = false;
                colvarObservacion.IsNullable = false;
                colvarObservacion.IsPrimaryKey = false;
                colvarObservacion.IsForeignKey = false;
                colvarObservacion.IsReadOnly = false;
                
                schema.Columns.Add(colvarObservacion);
                
                TableSchema.TableColumn colvarRenglon = new TableSchema.TableColumn(schema);
                colvarRenglon.ColumnName = "renglon";
                colvarRenglon.DataType = DbType.Int32;
                colvarRenglon.MaxLength = 0;
                colvarRenglon.AutoIncrement = false;
                colvarRenglon.IsNullable = false;
                colvarRenglon.IsPrimaryKey = false;
                colvarRenglon.IsForeignKey = false;
                colvarRenglon.IsReadOnly = false;
                
                schema.Columns.Add(colvarRenglon);
                
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
                
                TableSchema.TableColumn colvarNRubro = new TableSchema.TableColumn(schema);
                colvarNRubro.ColumnName = "NRubro";
                colvarNRubro.DataType = DbType.AnsiString;
                colvarNRubro.MaxLength = 50;
                colvarNRubro.AutoIncrement = false;
                colvarNRubro.IsNullable = false;
                colvarNRubro.IsPrimaryKey = false;
                colvarNRubro.IsForeignKey = false;
                colvarNRubro.IsReadOnly = false;
                
                schema.Columns.Add(colvarNRubro);
                
                
                BaseSchema = schema;
                //add this schema to the provider
                //so we can query it later
                DataService.Providers["RisProvider"].AddSchema("INS_GetPedidosInsumosRubro",schema);
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
	    public InsGetPedidosInsumosRubro()
	    {
            SetSQLProps();
            SetDefaults();
            MarkNew();
        }
        public InsGetPedidosInsumosRubro(bool useDatabaseDefaults)
	    {
		    SetSQLProps();
		    if(useDatabaseDefaults)
		    {
				ForceDefaults();
			}
			MarkNew();
	    }
	    
	    public InsGetPedidosInsumosRubro(object keyID)
	    {
		    SetSQLProps();
		    LoadByKey(keyID);
	    }
    	 
	    public InsGetPedidosInsumosRubro(string columnName, object columnValue)
        {
            SetSQLProps();
            LoadByParam(columnName,columnValue);
        }
        
	    #endregion
	    
	    #region Props
	    
          
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
	      
        [XmlAttribute("IdEfectorProveedor")]
        [Bindable(true)]
        public int? IdEfectorProveedor 
	    {
		    get
		    {
			    return GetColumnValue<int?>("idEfectorProveedor");
		    }
            set 
		    {
			    SetColumnValue("idEfectorProveedor", value);
            }
        }
	      
        [XmlAttribute("IdDeposito")]
        [Bindable(true)]
        public int? IdDeposito 
	    {
		    get
		    {
			    return GetColumnValue<int?>("idDeposito");
		    }
            set 
		    {
			    SetColumnValue("idDeposito", value);
            }
        }
	      
        [XmlAttribute("IdDepositoProveedor")]
        [Bindable(true)]
        public int? IdDepositoProveedor 
	    {
		    get
		    {
			    return GetColumnValue<int?>("idDepositoProveedor");
		    }
            set 
		    {
			    SetColumnValue("idDepositoProveedor", value);
            }
        }
	      
        [XmlAttribute("Fecha")]
        [Bindable(true)]
        public DateTime? Fecha 
	    {
		    get
		    {
			    return GetColumnValue<DateTime?>("fecha");
		    }
            set 
		    {
			    SetColumnValue("fecha", value);
            }
        }
	      
        [XmlAttribute("FechaRecepcion")]
        [Bindable(true)]
        public DateTime? FechaRecepcion 
	    {
		    get
		    {
			    return GetColumnValue<DateTime?>("fechaRecepcion");
		    }
            set 
		    {
			    SetColumnValue("fechaRecepcion", value);
            }
        }
	      
        [XmlAttribute("IdTipoPedido")]
        [Bindable(true)]
        public int? IdTipoPedido 
	    {
		    get
		    {
			    return GetColumnValue<int?>("idTipoPedido");
		    }
            set 
		    {
			    SetColumnValue("idTipoPedido", value);
            }
        }
	      
        [XmlAttribute("IdEstadoPedido")]
        [Bindable(true)]
        public int? IdEstadoPedido 
	    {
		    get
		    {
			    return GetColumnValue<int?>("idEstadoPedido");
		    }
            set 
		    {
			    SetColumnValue("idEstadoPedido", value);
            }
        }
	      
        [XmlAttribute("IdRubro")]
        [Bindable(true)]
        public int? IdRubro 
	    {
		    get
		    {
			    return GetColumnValue<int?>("idRubro");
		    }
            set 
		    {
			    SetColumnValue("idRubro", value);
            }
        }
	      
        [XmlAttribute("Observaciones")]
        [Bindable(true)]
        public string Observaciones 
	    {
		    get
		    {
			    return GetColumnValue<string>("observaciones");
		    }
            set 
		    {
			    SetColumnValue("observaciones", value);
            }
        }
	      
        [XmlAttribute("Responsable")]
        [Bindable(true)]
        public string Responsable 
	    {
		    get
		    {
			    return GetColumnValue<string>("responsable");
		    }
            set 
		    {
			    SetColumnValue("responsable", value);
            }
        }
	      
        [XmlAttribute("Autorizado")]
        [Bindable(true)]
        public bool? Autorizado 
	    {
		    get
		    {
			    return GetColumnValue<bool?>("autorizado");
		    }
            set 
		    {
			    SetColumnValue("autorizado", value);
            }
        }
	      
        [XmlAttribute("IdProveedor")]
        [Bindable(true)]
        public int? IdProveedor 
	    {
		    get
		    {
			    return GetColumnValue<int?>("idProveedor");
		    }
            set 
		    {
			    SetColumnValue("idProveedor", value);
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
	      
        [XmlAttribute("Cantidad")]
        [Bindable(true)]
        public int Cantidad 
	    {
		    get
		    {
			    return GetColumnValue<int>("cantidad");
		    }
            set 
		    {
			    SetColumnValue("cantidad", value);
            }
        }
	      
        [XmlAttribute("Presentacion")]
        [Bindable(true)]
        public int Presentacion 
	    {
		    get
		    {
			    return GetColumnValue<int>("presentacion");
		    }
            set 
		    {
			    SetColumnValue("presentacion", value);
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
	      
        [XmlAttribute("Stock")]
        [Bindable(true)]
        public int Stock 
	    {
		    get
		    {
			    return GetColumnValue<int>("stock");
		    }
            set 
		    {
			    SetColumnValue("stock", value);
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
	      
        [XmlAttribute("Observacion")]
        [Bindable(true)]
        public string Observacion 
	    {
		    get
		    {
			    return GetColumnValue<string>("observacion");
		    }
            set 
		    {
			    SetColumnValue("observacion", value);
            }
        }
	      
        [XmlAttribute("Renglon")]
        [Bindable(true)]
        public int Renglon 
	    {
		    get
		    {
			    return GetColumnValue<int>("renglon");
		    }
            set 
		    {
			    SetColumnValue("renglon", value);
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
	      
        [XmlAttribute("NRubro")]
        [Bindable(true)]
        public string NRubro 
	    {
		    get
		    {
			    return GetColumnValue<string>("NRubro");
		    }
            set 
		    {
			    SetColumnValue("NRubro", value);
            }
        }
	    
	    #endregion
    
	    #region Columns Struct
	    public struct Columns
	    {
		    
		    
            public static string IdPedido = @"idPedido";
            
            public static string IdEfector = @"idEfector";
            
            public static string IdEfectorProveedor = @"idEfectorProveedor";
            
            public static string IdDeposito = @"idDeposito";
            
            public static string IdDepositoProveedor = @"idDepositoProveedor";
            
            public static string Fecha = @"fecha";
            
            public static string FechaRecepcion = @"fechaRecepcion";
            
            public static string IdTipoPedido = @"idTipoPedido";
            
            public static string IdEstadoPedido = @"idEstadoPedido";
            
            public static string IdRubro = @"idRubro";
            
            public static string Observaciones = @"observaciones";
            
            public static string Responsable = @"responsable";
            
            public static string Autorizado = @"autorizado";
            
            public static string IdProveedor = @"idProveedor";
            
            public static string IdPedidoDetalle = @"idPedidoDetalle";
            
            public static string Cantidad = @"cantidad";
            
            public static string Presentacion = @"presentacion";
            
            public static string CantidadRecibida = @"cantidadRecibida";
            
            public static string Stock = @"stock";
            
            public static string PrecioUnitario = @"precioUnitario";
            
            public static string Observacion = @"observacion";
            
            public static string Renglon = @"renglon";
            
            public static string NumeroLote = @"numeroLote";
            
            public static string FechaVencimiento = @"fechaVencimiento";
            
            public static string IdInsumo = @"idInsumo";
            
            public static string Codigo = @"codigo";
            
            public static string Rubro = @"Rubro";
            
            public static string Nombre = @"Nombre";
            
            public static string Descripcion = @"Descripcion";
            
            public static string Unidad = @"Unidad";
            
            public static string NRubro = @"NRubro";
            
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
