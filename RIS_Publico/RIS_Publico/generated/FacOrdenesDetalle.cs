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
    /// Strongly-typed collection for the FacOrdenesDetalle class.
    /// </summary>
    [Serializable]
    public partial class FacOrdenesDetalleCollection : ReadOnlyList<FacOrdenesDetalle, FacOrdenesDetalleCollection>
    {        
        public FacOrdenesDetalleCollection() {}
    }
    /// <summary>
    /// This is  Read-only wrapper class for the FAC_OrdenesDetalles view.
    /// </summary>
    [Serializable]
    public partial class FacOrdenesDetalle : ReadOnlyRecord<FacOrdenesDetalle>, IReadOnlyRecord
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
                TableSchema.Table schema = new TableSchema.Table("FAC_OrdenesDetalles", TableType.View, DataService.GetInstance("RisProvider"));
                schema.Columns = new TableSchema.TableColumnCollection();
                schema.SchemaName = @"dbo";
                //columns
                
                TableSchema.TableColumn colvarIdOrden = new TableSchema.TableColumn(schema);
                colvarIdOrden.ColumnName = "idOrden";
                colvarIdOrden.DataType = DbType.Int32;
                colvarIdOrden.MaxLength = 0;
                colvarIdOrden.AutoIncrement = false;
                colvarIdOrden.IsNullable = false;
                colvarIdOrden.IsPrimaryKey = false;
                colvarIdOrden.IsForeignKey = false;
                colvarIdOrden.IsReadOnly = false;
                
                schema.Columns.Add(colvarIdOrden);
                
                TableSchema.TableColumn colvarIdEfector = new TableSchema.TableColumn(schema);
                colvarIdEfector.ColumnName = "idEfector";
                colvarIdEfector.DataType = DbType.Int32;
                colvarIdEfector.MaxLength = 0;
                colvarIdEfector.AutoIncrement = false;
                colvarIdEfector.IsNullable = false;
                colvarIdEfector.IsPrimaryKey = false;
                colvarIdEfector.IsForeignKey = false;
                colvarIdEfector.IsReadOnly = false;
                
                schema.Columns.Add(colvarIdEfector);
                
                TableSchema.TableColumn colvarEfector = new TableSchema.TableColumn(schema);
                colvarEfector.ColumnName = "Efector";
                colvarEfector.DataType = DbType.String;
                colvarEfector.MaxLength = 100;
                colvarEfector.AutoIncrement = false;
                colvarEfector.IsNullable = false;
                colvarEfector.IsPrimaryKey = false;
                colvarEfector.IsForeignKey = false;
                colvarEfector.IsReadOnly = false;
                
                schema.Columns.Add(colvarEfector);
                
                TableSchema.TableColumn colvarPeriodo = new TableSchema.TableColumn(schema);
                colvarPeriodo.ColumnName = "periodo";
                colvarPeriodo.DataType = DbType.AnsiStringFixedLength;
                colvarPeriodo.MaxLength = 10;
                colvarPeriodo.AutoIncrement = false;
                colvarPeriodo.IsNullable = false;
                colvarPeriodo.IsPrimaryKey = false;
                colvarPeriodo.IsForeignKey = false;
                colvarPeriodo.IsReadOnly = false;
                
                schema.Columns.Add(colvarPeriodo);
                
                TableSchema.TableColumn colvarIdServicio = new TableSchema.TableColumn(schema);
                colvarIdServicio.ColumnName = "idServicio";
                colvarIdServicio.DataType = DbType.Int32;
                colvarIdServicio.MaxLength = 0;
                colvarIdServicio.AutoIncrement = false;
                colvarIdServicio.IsNullable = false;
                colvarIdServicio.IsPrimaryKey = false;
                colvarIdServicio.IsForeignKey = false;
                colvarIdServicio.IsReadOnly = false;
                
                schema.Columns.Add(colvarIdServicio);
                
                TableSchema.TableColumn colvarServicio = new TableSchema.TableColumn(schema);
                colvarServicio.ColumnName = "Servicio";
                colvarServicio.DataType = DbType.String;
                colvarServicio.MaxLength = 100;
                colvarServicio.AutoIncrement = false;
                colvarServicio.IsNullable = false;
                colvarServicio.IsPrimaryKey = false;
                colvarServicio.IsForeignKey = false;
                colvarServicio.IsReadOnly = false;
                
                schema.Columns.Add(colvarServicio);
                
                TableSchema.TableColumn colvarIdObraSocial = new TableSchema.TableColumn(schema);
                colvarIdObraSocial.ColumnName = "idObraSocial";
                colvarIdObraSocial.DataType = DbType.Int32;
                colvarIdObraSocial.MaxLength = 0;
                colvarIdObraSocial.AutoIncrement = false;
                colvarIdObraSocial.IsNullable = false;
                colvarIdObraSocial.IsPrimaryKey = false;
                colvarIdObraSocial.IsForeignKey = false;
                colvarIdObraSocial.IsReadOnly = false;
                
                schema.Columns.Add(colvarIdObraSocial);
                
                TableSchema.TableColumn colvarObraSocial = new TableSchema.TableColumn(schema);
                colvarObraSocial.ColumnName = "ObraSocial";
                colvarObraSocial.DataType = DbType.String;
                colvarObraSocial.MaxLength = 200;
                colvarObraSocial.AutoIncrement = false;
                colvarObraSocial.IsNullable = false;
                colvarObraSocial.IsPrimaryKey = false;
                colvarObraSocial.IsForeignKey = false;
                colvarObraSocial.IsReadOnly = false;
                
                schema.Columns.Add(colvarObraSocial);
                
                TableSchema.TableColumn colvarIdPrefactura = new TableSchema.TableColumn(schema);
                colvarIdPrefactura.ColumnName = "idPrefactura";
                colvarIdPrefactura.DataType = DbType.Int32;
                colvarIdPrefactura.MaxLength = 0;
                colvarIdPrefactura.AutoIncrement = false;
                colvarIdPrefactura.IsNullable = false;
                colvarIdPrefactura.IsPrimaryKey = false;
                colvarIdPrefactura.IsForeignKey = false;
                colvarIdPrefactura.IsReadOnly = false;
                
                schema.Columns.Add(colvarIdPrefactura);
                
                TableSchema.TableColumn colvarIdFactura = new TableSchema.TableColumn(schema);
                colvarIdFactura.ColumnName = "idFactura";
                colvarIdFactura.DataType = DbType.Int32;
                colvarIdFactura.MaxLength = 0;
                colvarIdFactura.AutoIncrement = false;
                colvarIdFactura.IsNullable = false;
                colvarIdFactura.IsPrimaryKey = false;
                colvarIdFactura.IsForeignKey = false;
                colvarIdFactura.IsReadOnly = false;
                
                schema.Columns.Add(colvarIdFactura);
                
                TableSchema.TableColumn colvarMonto = new TableSchema.TableColumn(schema);
                colvarMonto.ColumnName = "monto";
                colvarMonto.DataType = DbType.Decimal;
                colvarMonto.MaxLength = 0;
                colvarMonto.AutoIncrement = false;
                colvarMonto.IsNullable = false;
                colvarMonto.IsPrimaryKey = false;
                colvarMonto.IsForeignKey = false;
                colvarMonto.IsReadOnly = false;
                
                schema.Columns.Add(colvarMonto);
                
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
                
                TableSchema.TableColumn colvarTipoPractica = new TableSchema.TableColumn(schema);
                colvarTipoPractica.ColumnName = "TipoPractica";
                colvarTipoPractica.DataType = DbType.AnsiString;
                colvarTipoPractica.MaxLength = 50;
                colvarTipoPractica.AutoIncrement = false;
                colvarTipoPractica.IsNullable = false;
                colvarTipoPractica.IsPrimaryKey = false;
                colvarTipoPractica.IsForeignKey = false;
                colvarTipoPractica.IsReadOnly = false;
                
                schema.Columns.Add(colvarTipoPractica);
                
                TableSchema.TableColumn colvarFechaConfeccion = new TableSchema.TableColumn(schema);
                colvarFechaConfeccion.ColumnName = "FechaConfeccion";
                colvarFechaConfeccion.DataType = DbType.DateTime;
                colvarFechaConfeccion.MaxLength = 0;
                colvarFechaConfeccion.AutoIncrement = false;
                colvarFechaConfeccion.IsNullable = false;
                colvarFechaConfeccion.IsPrimaryKey = false;
                colvarFechaConfeccion.IsForeignKey = false;
                colvarFechaConfeccion.IsReadOnly = false;
                
                schema.Columns.Add(colvarFechaConfeccion);
                
                TableSchema.TableColumn colvarFechaPractica = new TableSchema.TableColumn(schema);
                colvarFechaPractica.ColumnName = "fechaPractica";
                colvarFechaPractica.DataType = DbType.DateTime;
                colvarFechaPractica.MaxLength = 0;
                colvarFechaPractica.AutoIncrement = false;
                colvarFechaPractica.IsNullable = false;
                colvarFechaPractica.IsPrimaryKey = false;
                colvarFechaPractica.IsForeignKey = false;
                colvarFechaPractica.IsReadOnly = false;
                
                schema.Columns.Add(colvarFechaPractica);
                
                TableSchema.TableColumn colvarFechaCarga = new TableSchema.TableColumn(schema);
                colvarFechaCarga.ColumnName = "FechaCarga";
                colvarFechaCarga.DataType = DbType.DateTime;
                colvarFechaCarga.MaxLength = 0;
                colvarFechaCarga.AutoIncrement = false;
                colvarFechaCarga.IsNullable = false;
                colvarFechaCarga.IsPrimaryKey = false;
                colvarFechaCarga.IsForeignKey = false;
                colvarFechaCarga.IsReadOnly = false;
                
                schema.Columns.Add(colvarFechaCarga);
                
                TableSchema.TableColumn colvarIdOrdenDetalle = new TableSchema.TableColumn(schema);
                colvarIdOrdenDetalle.ColumnName = "idOrdenDetalle";
                colvarIdOrdenDetalle.DataType = DbType.Int32;
                colvarIdOrdenDetalle.MaxLength = 0;
                colvarIdOrdenDetalle.AutoIncrement = false;
                colvarIdOrdenDetalle.IsNullable = false;
                colvarIdOrdenDetalle.IsPrimaryKey = false;
                colvarIdOrdenDetalle.IsForeignKey = false;
                colvarIdOrdenDetalle.IsReadOnly = false;
                
                schema.Columns.Add(colvarIdOrdenDetalle);
                
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
                colvarCodigo.DataType = DbType.AnsiString;
                colvarCodigo.MaxLength = 50;
                colvarCodigo.AutoIncrement = false;
                colvarCodigo.IsNullable = false;
                colvarCodigo.IsPrimaryKey = false;
                colvarCodigo.IsForeignKey = false;
                colvarCodigo.IsReadOnly = false;
                
                schema.Columns.Add(colvarCodigo);
                
                TableSchema.TableColumn colvarDescripcion = new TableSchema.TableColumn(schema);
                colvarDescripcion.ColumnName = "descripcion";
                colvarDescripcion.DataType = DbType.AnsiString;
                colvarDescripcion.MaxLength = 255;
                colvarDescripcion.AutoIncrement = false;
                colvarDescripcion.IsNullable = false;
                colvarDescripcion.IsPrimaryKey = false;
                colvarDescripcion.IsForeignKey = false;
                colvarDescripcion.IsReadOnly = false;
                
                schema.Columns.Add(colvarDescripcion);
                
                TableSchema.TableColumn colvarIdTipoPracticaNomenclador = new TableSchema.TableColumn(schema);
                colvarIdTipoPracticaNomenclador.ColumnName = "idTipoPracticaNomenclador";
                colvarIdTipoPracticaNomenclador.DataType = DbType.Int32;
                colvarIdTipoPracticaNomenclador.MaxLength = 0;
                colvarIdTipoPracticaNomenclador.AutoIncrement = false;
                colvarIdTipoPracticaNomenclador.IsNullable = false;
                colvarIdTipoPracticaNomenclador.IsPrimaryKey = false;
                colvarIdTipoPracticaNomenclador.IsForeignKey = false;
                colvarIdTipoPracticaNomenclador.IsReadOnly = false;
                
                schema.Columns.Add(colvarIdTipoPracticaNomenclador);
                
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
                
                TableSchema.TableColumn colvarNomenclador = new TableSchema.TableColumn(schema);
                colvarNomenclador.ColumnName = "Nomenclador";
                colvarNomenclador.DataType = DbType.AnsiString;
                colvarNomenclador.MaxLength = 500;
                colvarNomenclador.AutoIncrement = false;
                colvarNomenclador.IsNullable = false;
                colvarNomenclador.IsPrimaryKey = false;
                colvarNomenclador.IsForeignKey = false;
                colvarNomenclador.IsReadOnly = false;
                
                schema.Columns.Add(colvarNomenclador);
                
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
                
                TableSchema.TableColumn colvarValorUnidad = new TableSchema.TableColumn(schema);
                colvarValorUnidad.ColumnName = "valorUnidad";
                colvarValorUnidad.DataType = DbType.Decimal;
                colvarValorUnidad.MaxLength = 0;
                colvarValorUnidad.AutoIncrement = false;
                colvarValorUnidad.IsNullable = false;
                colvarValorUnidad.IsPrimaryKey = false;
                colvarValorUnidad.IsForeignKey = false;
                colvarValorUnidad.IsReadOnly = false;
                
                schema.Columns.Add(colvarValorUnidad);
                
                TableSchema.TableColumn colvarAjuste = new TableSchema.TableColumn(schema);
                colvarAjuste.ColumnName = "ajuste";
                colvarAjuste.DataType = DbType.Decimal;
                colvarAjuste.MaxLength = 0;
                colvarAjuste.AutoIncrement = false;
                colvarAjuste.IsNullable = false;
                colvarAjuste.IsPrimaryKey = false;
                colvarAjuste.IsForeignKey = false;
                colvarAjuste.IsReadOnly = false;
                
                schema.Columns.Add(colvarAjuste);
                
                TableSchema.TableColumn colvarSubtotal = new TableSchema.TableColumn(schema);
                colvarSubtotal.ColumnName = "Subtotal";
                colvarSubtotal.DataType = DbType.Decimal;
                colvarSubtotal.MaxLength = 0;
                colvarSubtotal.AutoIncrement = false;
                colvarSubtotal.IsNullable = true;
                colvarSubtotal.IsPrimaryKey = false;
                colvarSubtotal.IsForeignKey = false;
                colvarSubtotal.IsReadOnly = false;
                
                schema.Columns.Add(colvarSubtotal);
                
                
                BaseSchema = schema;
                //add this schema to the provider
                //so we can query it later
                DataService.Providers["RisProvider"].AddSchema("FAC_OrdenesDetalles",schema);
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
	    public FacOrdenesDetalle()
	    {
            SetSQLProps();
            SetDefaults();
            MarkNew();
        }
        public FacOrdenesDetalle(bool useDatabaseDefaults)
	    {
		    SetSQLProps();
		    if(useDatabaseDefaults)
		    {
				ForceDefaults();
			}
			MarkNew();
	    }
	    
	    public FacOrdenesDetalle(object keyID)
	    {
		    SetSQLProps();
		    LoadByKey(keyID);
	    }
    	 
	    public FacOrdenesDetalle(string columnName, object columnValue)
        {
            SetSQLProps();
            LoadByParam(columnName,columnValue);
        }
        
	    #endregion
	    
	    #region Props
	    
          
        [XmlAttribute("IdOrden")]
        [Bindable(true)]
        public int IdOrden 
	    {
		    get
		    {
			    return GetColumnValue<int>("idOrden");
		    }
            set 
		    {
			    SetColumnValue("idOrden", value);
            }
        }
	      
        [XmlAttribute("IdEfector")]
        [Bindable(true)]
        public int IdEfector 
	    {
		    get
		    {
			    return GetColumnValue<int>("idEfector");
		    }
            set 
		    {
			    SetColumnValue("idEfector", value);
            }
        }
	      
        [XmlAttribute("Efector")]
        [Bindable(true)]
        public string Efector 
	    {
		    get
		    {
			    return GetColumnValue<string>("Efector");
		    }
            set 
		    {
			    SetColumnValue("Efector", value);
            }
        }
	      
        [XmlAttribute("Periodo")]
        [Bindable(true)]
        public string Periodo 
	    {
		    get
		    {
			    return GetColumnValue<string>("periodo");
		    }
            set 
		    {
			    SetColumnValue("periodo", value);
            }
        }
	      
        [XmlAttribute("IdServicio")]
        [Bindable(true)]
        public int IdServicio 
	    {
		    get
		    {
			    return GetColumnValue<int>("idServicio");
		    }
            set 
		    {
			    SetColumnValue("idServicio", value);
            }
        }
	      
        [XmlAttribute("Servicio")]
        [Bindable(true)]
        public string Servicio 
	    {
		    get
		    {
			    return GetColumnValue<string>("Servicio");
		    }
            set 
		    {
			    SetColumnValue("Servicio", value);
            }
        }
	      
        [XmlAttribute("IdObraSocial")]
        [Bindable(true)]
        public int IdObraSocial 
	    {
		    get
		    {
			    return GetColumnValue<int>("idObraSocial");
		    }
            set 
		    {
			    SetColumnValue("idObraSocial", value);
            }
        }
	      
        [XmlAttribute("ObraSocial")]
        [Bindable(true)]
        public string ObraSocial 
	    {
		    get
		    {
			    return GetColumnValue<string>("ObraSocial");
		    }
            set 
		    {
			    SetColumnValue("ObraSocial", value);
            }
        }
	      
        [XmlAttribute("IdPrefactura")]
        [Bindable(true)]
        public int IdPrefactura 
	    {
		    get
		    {
			    return GetColumnValue<int>("idPrefactura");
		    }
            set 
		    {
			    SetColumnValue("idPrefactura", value);
            }
        }
	      
        [XmlAttribute("IdFactura")]
        [Bindable(true)]
        public int IdFactura 
	    {
		    get
		    {
			    return GetColumnValue<int>("idFactura");
		    }
            set 
		    {
			    SetColumnValue("idFactura", value);
            }
        }
	      
        [XmlAttribute("Monto")]
        [Bindable(true)]
        public decimal Monto 
	    {
		    get
		    {
			    return GetColumnValue<decimal>("monto");
		    }
            set 
		    {
			    SetColumnValue("monto", value);
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
	      
        [XmlAttribute("TipoPractica")]
        [Bindable(true)]
        public string TipoPractica 
	    {
		    get
		    {
			    return GetColumnValue<string>("TipoPractica");
		    }
            set 
		    {
			    SetColumnValue("TipoPractica", value);
            }
        }
	      
        [XmlAttribute("FechaConfeccion")]
        [Bindable(true)]
        public DateTime FechaConfeccion 
	    {
		    get
		    {
			    return GetColumnValue<DateTime>("FechaConfeccion");
		    }
            set 
		    {
			    SetColumnValue("FechaConfeccion", value);
            }
        }
	      
        [XmlAttribute("FechaPractica")]
        [Bindable(true)]
        public DateTime FechaPractica 
	    {
		    get
		    {
			    return GetColumnValue<DateTime>("fechaPractica");
		    }
            set 
		    {
			    SetColumnValue("fechaPractica", value);
            }
        }
	      
        [XmlAttribute("FechaCarga")]
        [Bindable(true)]
        public DateTime FechaCarga 
	    {
		    get
		    {
			    return GetColumnValue<DateTime>("FechaCarga");
		    }
            set 
		    {
			    SetColumnValue("FechaCarga", value);
            }
        }
	      
        [XmlAttribute("IdOrdenDetalle")]
        [Bindable(true)]
        public int IdOrdenDetalle 
	    {
		    get
		    {
			    return GetColumnValue<int>("idOrdenDetalle");
		    }
            set 
		    {
			    SetColumnValue("idOrdenDetalle", value);
            }
        }
	      
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
	      
        [XmlAttribute("IdTipoPracticaNomenclador")]
        [Bindable(true)]
        public int IdTipoPracticaNomenclador 
	    {
		    get
		    {
			    return GetColumnValue<int>("idTipoPracticaNomenclador");
		    }
            set 
		    {
			    SetColumnValue("idTipoPracticaNomenclador", value);
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
	      
        [XmlAttribute("Nomenclador")]
        [Bindable(true)]
        public string Nomenclador 
	    {
		    get
		    {
			    return GetColumnValue<string>("Nomenclador");
		    }
            set 
		    {
			    SetColumnValue("Nomenclador", value);
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
	      
        [XmlAttribute("ValorUnidad")]
        [Bindable(true)]
        public decimal ValorUnidad 
	    {
		    get
		    {
			    return GetColumnValue<decimal>("valorUnidad");
		    }
            set 
		    {
			    SetColumnValue("valorUnidad", value);
            }
        }
	      
        [XmlAttribute("Ajuste")]
        [Bindable(true)]
        public decimal Ajuste 
	    {
		    get
		    {
			    return GetColumnValue<decimal>("ajuste");
		    }
            set 
		    {
			    SetColumnValue("ajuste", value);
            }
        }
	      
        [XmlAttribute("Subtotal")]
        [Bindable(true)]
        public decimal? Subtotal 
	    {
		    get
		    {
			    return GetColumnValue<decimal?>("Subtotal");
		    }
            set 
		    {
			    SetColumnValue("Subtotal", value);
            }
        }
	    
	    #endregion
    
	    #region Columns Struct
	    public struct Columns
	    {
		    
		    
            public static string IdOrden = @"idOrden";
            
            public static string IdEfector = @"idEfector";
            
            public static string Efector = @"Efector";
            
            public static string Periodo = @"periodo";
            
            public static string IdServicio = @"idServicio";
            
            public static string Servicio = @"Servicio";
            
            public static string IdObraSocial = @"idObraSocial";
            
            public static string ObraSocial = @"ObraSocial";
            
            public static string IdPrefactura = @"idPrefactura";
            
            public static string IdFactura = @"idFactura";
            
            public static string Monto = @"monto";
            
            public static string IdTipoPractica = @"idTipoPractica";
            
            public static string TipoPractica = @"TipoPractica";
            
            public static string FechaConfeccion = @"FechaConfeccion";
            
            public static string FechaPractica = @"fechaPractica";
            
            public static string FechaCarga = @"FechaCarga";
            
            public static string IdOrdenDetalle = @"idOrdenDetalle";
            
            public static string IdNomenclador = @"idNomenclador";
            
            public static string Codigo = @"codigo";
            
            public static string Descripcion = @"descripcion";
            
            public static string IdTipoPracticaNomenclador = @"idTipoPracticaNomenclador";
            
            public static string IdTipoNomenclador = @"idTipoNomenclador";
            
            public static string Nomenclador = @"Nomenclador";
            
            public static string Cantidad = @"cantidad";
            
            public static string ValorUnidad = @"valorUnidad";
            
            public static string Ajuste = @"ajuste";
            
            public static string Subtotal = @"Subtotal";
            
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
