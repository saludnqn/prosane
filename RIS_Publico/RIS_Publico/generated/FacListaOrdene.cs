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
    /// Strongly-typed collection for the FacListaOrdene class.
    /// </summary>
    [Serializable]
    public partial class FacListaOrdeneCollection : ReadOnlyList<FacListaOrdene, FacListaOrdeneCollection>
    {        
        public FacListaOrdeneCollection() {}
    }
    /// <summary>
    /// This is  Read-only wrapper class for the FAC_ListaOrdenes view.
    /// </summary>
    [Serializable]
    public partial class FacListaOrdene : ReadOnlyRecord<FacListaOrdene>, IReadOnlyRecord
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
                TableSchema.Table schema = new TableSchema.Table("FAC_ListaOrdenes", TableType.View, DataService.GetInstance("RisProvider"));
                schema.Columns = new TableSchema.TableColumnCollection();
                schema.SchemaName = @"dbo";
                //columns
                
                TableSchema.TableColumn colvarOrdIdEfector = new TableSchema.TableColumn(schema);
                colvarOrdIdEfector.ColumnName = "Ord_idEfector";
                colvarOrdIdEfector.DataType = DbType.Int32;
                colvarOrdIdEfector.MaxLength = 0;
                colvarOrdIdEfector.AutoIncrement = false;
                colvarOrdIdEfector.IsNullable = false;
                colvarOrdIdEfector.IsPrimaryKey = false;
                colvarOrdIdEfector.IsForeignKey = false;
                colvarOrdIdEfector.IsReadOnly = false;
                
                schema.Columns.Add(colvarOrdIdEfector);
                
                TableSchema.TableColumn colvarOrdNumeroOrden = new TableSchema.TableColumn(schema);
                colvarOrdNumeroOrden.ColumnName = "Ord_NumeroOrden";
                colvarOrdNumeroOrden.DataType = DbType.Int32;
                colvarOrdNumeroOrden.MaxLength = 0;
                colvarOrdNumeroOrden.AutoIncrement = false;
                colvarOrdNumeroOrden.IsNullable = false;
                colvarOrdNumeroOrden.IsPrimaryKey = false;
                colvarOrdNumeroOrden.IsForeignKey = false;
                colvarOrdNumeroOrden.IsReadOnly = false;
                
                schema.Columns.Add(colvarOrdNumeroOrden);
                
                TableSchema.TableColumn colvarOrdIdServicio = new TableSchema.TableColumn(schema);
                colvarOrdIdServicio.ColumnName = "Ord_IdServicio";
                colvarOrdIdServicio.DataType = DbType.Int32;
                colvarOrdIdServicio.MaxLength = 0;
                colvarOrdIdServicio.AutoIncrement = false;
                colvarOrdIdServicio.IsNullable = false;
                colvarOrdIdServicio.IsPrimaryKey = false;
                colvarOrdIdServicio.IsForeignKey = false;
                colvarOrdIdServicio.IsReadOnly = false;
                
                schema.Columns.Add(colvarOrdIdServicio);
                
                TableSchema.TableColumn colvarOrdIdTipoPractica = new TableSchema.TableColumn(schema);
                colvarOrdIdTipoPractica.ColumnName = "Ord_IdTipoPractica";
                colvarOrdIdTipoPractica.DataType = DbType.Int32;
                colvarOrdIdTipoPractica.MaxLength = 0;
                colvarOrdIdTipoPractica.AutoIncrement = false;
                colvarOrdIdTipoPractica.IsNullable = false;
                colvarOrdIdTipoPractica.IsPrimaryKey = false;
                colvarOrdIdTipoPractica.IsForeignKey = false;
                colvarOrdIdTipoPractica.IsReadOnly = false;
                
                schema.Columns.Add(colvarOrdIdTipoPractica);
                
                TableSchema.TableColumn colvarOrdIdObraSocial = new TableSchema.TableColumn(schema);
                colvarOrdIdObraSocial.ColumnName = "Ord_IdObraSocial";
                colvarOrdIdObraSocial.DataType = DbType.Int32;
                colvarOrdIdObraSocial.MaxLength = 0;
                colvarOrdIdObraSocial.AutoIncrement = false;
                colvarOrdIdObraSocial.IsNullable = false;
                colvarOrdIdObraSocial.IsPrimaryKey = false;
                colvarOrdIdObraSocial.IsForeignKey = false;
                colvarOrdIdObraSocial.IsReadOnly = false;
                
                schema.Columns.Add(colvarOrdIdObraSocial);
                
                TableSchema.TableColumn colvarOrdFechaConfeccion = new TableSchema.TableColumn(schema);
                colvarOrdFechaConfeccion.ColumnName = "Ord_FechaConfeccion";
                colvarOrdFechaConfeccion.DataType = DbType.DateTime;
                colvarOrdFechaConfeccion.MaxLength = 0;
                colvarOrdFechaConfeccion.AutoIncrement = false;
                colvarOrdFechaConfeccion.IsNullable = false;
                colvarOrdFechaConfeccion.IsPrimaryKey = false;
                colvarOrdFechaConfeccion.IsForeignKey = false;
                colvarOrdFechaConfeccion.IsReadOnly = false;
                
                schema.Columns.Add(colvarOrdFechaConfeccion);
                
                TableSchema.TableColumn colvarOrdFechaPractica = new TableSchema.TableColumn(schema);
                colvarOrdFechaPractica.ColumnName = "Ord_FechaPractica";
                colvarOrdFechaPractica.DataType = DbType.DateTime;
                colvarOrdFechaPractica.MaxLength = 0;
                colvarOrdFechaPractica.AutoIncrement = false;
                colvarOrdFechaPractica.IsNullable = false;
                colvarOrdFechaPractica.IsPrimaryKey = false;
                colvarOrdFechaPractica.IsForeignKey = false;
                colvarOrdFechaPractica.IsReadOnly = false;
                
                schema.Columns.Add(colvarOrdFechaPractica);
                
                TableSchema.TableColumn colvarOrdNumeroSiniestro = new TableSchema.TableColumn(schema);
                colvarOrdNumeroSiniestro.ColumnName = "Ord_NumeroSiniestro";
                colvarOrdNumeroSiniestro.DataType = DbType.AnsiString;
                colvarOrdNumeroSiniestro.MaxLength = 50;
                colvarOrdNumeroSiniestro.AutoIncrement = false;
                colvarOrdNumeroSiniestro.IsNullable = false;
                colvarOrdNumeroSiniestro.IsPrimaryKey = false;
                colvarOrdNumeroSiniestro.IsForeignKey = false;
                colvarOrdNumeroSiniestro.IsReadOnly = false;
                
                schema.Columns.Add(colvarOrdNumeroSiniestro);
                
                TableSchema.TableColumn colvarOrdFechaSiniestro = new TableSchema.TableColumn(schema);
                colvarOrdFechaSiniestro.ColumnName = "Ord_FechaSiniestro";
                colvarOrdFechaSiniestro.DataType = DbType.DateTime;
                colvarOrdFechaSiniestro.MaxLength = 0;
                colvarOrdFechaSiniestro.AutoIncrement = false;
                colvarOrdFechaSiniestro.IsNullable = false;
                colvarOrdFechaSiniestro.IsPrimaryKey = false;
                colvarOrdFechaSiniestro.IsForeignKey = false;
                colvarOrdFechaSiniestro.IsReadOnly = false;
                
                schema.Columns.Add(colvarOrdFechaSiniestro);
                
                TableSchema.TableColumn colvarOrdFacturaFueraConvenio = new TableSchema.TableColumn(schema);
                colvarOrdFacturaFueraConvenio.ColumnName = "Ord_FacturaFueraConvenio";
                colvarOrdFacturaFueraConvenio.DataType = DbType.Boolean;
                colvarOrdFacturaFueraConvenio.MaxLength = 0;
                colvarOrdFacturaFueraConvenio.AutoIncrement = false;
                colvarOrdFacturaFueraConvenio.IsNullable = false;
                colvarOrdFacturaFueraConvenio.IsPrimaryKey = false;
                colvarOrdFacturaFueraConvenio.IsForeignKey = false;
                colvarOrdFacturaFueraConvenio.IsReadOnly = false;
                
                schema.Columns.Add(colvarOrdFacturaFueraConvenio);
                
                TableSchema.TableColumn colvarOrdCodificaHIV = new TableSchema.TableColumn(schema);
                colvarOrdCodificaHIV.ColumnName = "Ord_CodificaHIV";
                colvarOrdCodificaHIV.DataType = DbType.Boolean;
                colvarOrdCodificaHIV.MaxLength = 0;
                colvarOrdCodificaHIV.AutoIncrement = false;
                colvarOrdCodificaHIV.IsNullable = false;
                colvarOrdCodificaHIV.IsPrimaryKey = false;
                colvarOrdCodificaHIV.IsForeignKey = false;
                colvarOrdCodificaHIV.IsReadOnly = false;
                
                schema.Columns.Add(colvarOrdCodificaHIV);
                
                TableSchema.TableColumn colvarOrdDiagnostico = new TableSchema.TableColumn(schema);
                colvarOrdDiagnostico.ColumnName = "Ord_Diagnostico";
                colvarOrdDiagnostico.DataType = DbType.AnsiString;
                colvarOrdDiagnostico.MaxLength = 500;
                colvarOrdDiagnostico.AutoIncrement = false;
                colvarOrdDiagnostico.IsNullable = false;
                colvarOrdDiagnostico.IsPrimaryKey = false;
                colvarOrdDiagnostico.IsForeignKey = false;
                colvarOrdDiagnostico.IsReadOnly = false;
                
                schema.Columns.Add(colvarOrdDiagnostico);
                
                TableSchema.TableColumn colvarDetIdNomenclador = new TableSchema.TableColumn(schema);
                colvarDetIdNomenclador.ColumnName = "Det_idNomenclador";
                colvarDetIdNomenclador.DataType = DbType.Int32;
                colvarDetIdNomenclador.MaxLength = 0;
                colvarDetIdNomenclador.AutoIncrement = false;
                colvarDetIdNomenclador.IsNullable = false;
                colvarDetIdNomenclador.IsPrimaryKey = false;
                colvarDetIdNomenclador.IsForeignKey = false;
                colvarDetIdNomenclador.IsReadOnly = false;
                
                schema.Columns.Add(colvarDetIdNomenclador);
                
                TableSchema.TableColumn colvarDetDescripcion = new TableSchema.TableColumn(schema);
                colvarDetDescripcion.ColumnName = "Det_Descripcion";
                colvarDetDescripcion.DataType = DbType.AnsiString;
                colvarDetDescripcion.MaxLength = 500;
                colvarDetDescripcion.AutoIncrement = false;
                colvarDetDescripcion.IsNullable = false;
                colvarDetDescripcion.IsPrimaryKey = false;
                colvarDetDescripcion.IsForeignKey = false;
                colvarDetDescripcion.IsReadOnly = false;
                
                schema.Columns.Add(colvarDetDescripcion);
                
                TableSchema.TableColumn colvarDetCantidad = new TableSchema.TableColumn(schema);
                colvarDetCantidad.ColumnName = "Det_Cantidad";
                colvarDetCantidad.DataType = DbType.Int32;
                colvarDetCantidad.MaxLength = 0;
                colvarDetCantidad.AutoIncrement = false;
                colvarDetCantidad.IsNullable = false;
                colvarDetCantidad.IsPrimaryKey = false;
                colvarDetCantidad.IsForeignKey = false;
                colvarDetCantidad.IsReadOnly = false;
                
                schema.Columns.Add(colvarDetCantidad);
                
                TableSchema.TableColumn colvarDetValorUnidad = new TableSchema.TableColumn(schema);
                colvarDetValorUnidad.ColumnName = "Det_ValorUnidad";
                colvarDetValorUnidad.DataType = DbType.Decimal;
                colvarDetValorUnidad.MaxLength = 0;
                colvarDetValorUnidad.AutoIncrement = false;
                colvarDetValorUnidad.IsNullable = false;
                colvarDetValorUnidad.IsPrimaryKey = false;
                colvarDetValorUnidad.IsForeignKey = false;
                colvarDetValorUnidad.IsReadOnly = false;
                
                schema.Columns.Add(colvarDetValorUnidad);
                
                TableSchema.TableColumn colvarDetAjuste = new TableSchema.TableColumn(schema);
                colvarDetAjuste.ColumnName = "Det_Ajuste";
                colvarDetAjuste.DataType = DbType.Decimal;
                colvarDetAjuste.MaxLength = 0;
                colvarDetAjuste.AutoIncrement = false;
                colvarDetAjuste.IsNullable = false;
                colvarDetAjuste.IsPrimaryKey = false;
                colvarDetAjuste.IsForeignKey = false;
                colvarDetAjuste.IsReadOnly = false;
                
                schema.Columns.Add(colvarDetAjuste);
                
                TableSchema.TableColumn colvarPacNumeroDocumento = new TableSchema.TableColumn(schema);
                colvarPacNumeroDocumento.ColumnName = "Pac_NumeroDocumento";
                colvarPacNumeroDocumento.DataType = DbType.Int32;
                colvarPacNumeroDocumento.MaxLength = 0;
                colvarPacNumeroDocumento.AutoIncrement = false;
                colvarPacNumeroDocumento.IsNullable = false;
                colvarPacNumeroDocumento.IsPrimaryKey = false;
                colvarPacNumeroDocumento.IsForeignKey = false;
                colvarPacNumeroDocumento.IsReadOnly = false;
                
                schema.Columns.Add(colvarPacNumeroDocumento);
                
                TableSchema.TableColumn colvarPacNumeroAfiliado = new TableSchema.TableColumn(schema);
                colvarPacNumeroAfiliado.ColumnName = "Pac_NumeroAfiliado";
                colvarPacNumeroAfiliado.DataType = DbType.AnsiString;
                colvarPacNumeroAfiliado.MaxLength = 50;
                colvarPacNumeroAfiliado.AutoIncrement = false;
                colvarPacNumeroAfiliado.IsNullable = true;
                colvarPacNumeroAfiliado.IsPrimaryKey = false;
                colvarPacNumeroAfiliado.IsForeignKey = false;
                colvarPacNumeroAfiliado.IsReadOnly = false;
                
                schema.Columns.Add(colvarPacNumeroAfiliado);
                
                TableSchema.TableColumn colvarPacApellido = new TableSchema.TableColumn(schema);
                colvarPacApellido.ColumnName = "Pac_Apellido";
                colvarPacApellido.DataType = DbType.String;
                colvarPacApellido.MaxLength = 100;
                colvarPacApellido.AutoIncrement = false;
                colvarPacApellido.IsNullable = false;
                colvarPacApellido.IsPrimaryKey = false;
                colvarPacApellido.IsForeignKey = false;
                colvarPacApellido.IsReadOnly = false;
                
                schema.Columns.Add(colvarPacApellido);
                
                TableSchema.TableColumn colvarPacNombre = new TableSchema.TableColumn(schema);
                colvarPacNombre.ColumnName = "Pac_Nombre";
                colvarPacNombre.DataType = DbType.String;
                colvarPacNombre.MaxLength = 100;
                colvarPacNombre.AutoIncrement = false;
                colvarPacNombre.IsNullable = false;
                colvarPacNombre.IsPrimaryKey = false;
                colvarPacNombre.IsForeignKey = false;
                colvarPacNombre.IsReadOnly = false;
                
                schema.Columns.Add(colvarPacNombre);
                
                TableSchema.TableColumn colvarPacIdSexo = new TableSchema.TableColumn(schema);
                colvarPacIdSexo.ColumnName = "Pac_IdSexo";
                colvarPacIdSexo.DataType = DbType.Int32;
                colvarPacIdSexo.MaxLength = 0;
                colvarPacIdSexo.AutoIncrement = false;
                colvarPacIdSexo.IsNullable = false;
                colvarPacIdSexo.IsPrimaryKey = false;
                colvarPacIdSexo.IsForeignKey = false;
                colvarPacIdSexo.IsReadOnly = false;
                
                schema.Columns.Add(colvarPacIdSexo);
                
                TableSchema.TableColumn colvarPacFechaNacimiento = new TableSchema.TableColumn(schema);
                colvarPacFechaNacimiento.ColumnName = "Pac_fechaNacimiento";
                colvarPacFechaNacimiento.DataType = DbType.DateTime;
                colvarPacFechaNacimiento.MaxLength = 0;
                colvarPacFechaNacimiento.AutoIncrement = false;
                colvarPacFechaNacimiento.IsNullable = false;
                colvarPacFechaNacimiento.IsPrimaryKey = false;
                colvarPacFechaNacimiento.IsForeignKey = false;
                colvarPacFechaNacimiento.IsReadOnly = false;
                
                schema.Columns.Add(colvarPacFechaNacimiento);
                
                TableSchema.TableColumn colvarProIdTipoDocumento = new TableSchema.TableColumn(schema);
                colvarProIdTipoDocumento.ColumnName = "Pro_IdTipoDocumento";
                colvarProIdTipoDocumento.DataType = DbType.Int32;
                colvarProIdTipoDocumento.MaxLength = 0;
                colvarProIdTipoDocumento.AutoIncrement = false;
                colvarProIdTipoDocumento.IsNullable = false;
                colvarProIdTipoDocumento.IsPrimaryKey = false;
                colvarProIdTipoDocumento.IsForeignKey = false;
                colvarProIdTipoDocumento.IsReadOnly = false;
                
                schema.Columns.Add(colvarProIdTipoDocumento);
                
                TableSchema.TableColumn colvarProNumeroDocumento = new TableSchema.TableColumn(schema);
                colvarProNumeroDocumento.ColumnName = "Pro_NumeroDocumento";
                colvarProNumeroDocumento.DataType = DbType.Int32;
                colvarProNumeroDocumento.MaxLength = 0;
                colvarProNumeroDocumento.AutoIncrement = false;
                colvarProNumeroDocumento.IsNullable = false;
                colvarProNumeroDocumento.IsPrimaryKey = false;
                colvarProNumeroDocumento.IsForeignKey = false;
                colvarProNumeroDocumento.IsReadOnly = false;
                
                schema.Columns.Add(colvarProNumeroDocumento);
                
                TableSchema.TableColumn colvarProApellido = new TableSchema.TableColumn(schema);
                colvarProApellido.ColumnName = "Pro_Apellido";
                colvarProApellido.DataType = DbType.String;
                colvarProApellido.MaxLength = 50;
                colvarProApellido.AutoIncrement = false;
                colvarProApellido.IsNullable = false;
                colvarProApellido.IsPrimaryKey = false;
                colvarProApellido.IsForeignKey = false;
                colvarProApellido.IsReadOnly = false;
                
                schema.Columns.Add(colvarProApellido);
                
                TableSchema.TableColumn colvarProNombre = new TableSchema.TableColumn(schema);
                colvarProNombre.ColumnName = "Pro_Nombre";
                colvarProNombre.DataType = DbType.String;
                colvarProNombre.MaxLength = 50;
                colvarProNombre.AutoIncrement = false;
                colvarProNombre.IsNullable = false;
                colvarProNombre.IsPrimaryKey = false;
                colvarProNombre.IsForeignKey = false;
                colvarProNombre.IsReadOnly = false;
                
                schema.Columns.Add(colvarProNombre);
                
                TableSchema.TableColumn colvarProMatricula = new TableSchema.TableColumn(schema);
                colvarProMatricula.ColumnName = "Pro_Matricula";
                colvarProMatricula.DataType = DbType.String;
                colvarProMatricula.MaxLength = 20;
                colvarProMatricula.AutoIncrement = false;
                colvarProMatricula.IsNullable = false;
                colvarProMatricula.IsPrimaryKey = false;
                colvarProMatricula.IsForeignKey = false;
                colvarProMatricula.IsReadOnly = false;
                
                schema.Columns.Add(colvarProMatricula);
                
                
                BaseSchema = schema;
                //add this schema to the provider
                //so we can query it later
                DataService.Providers["RisProvider"].AddSchema("FAC_ListaOrdenes",schema);
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
	    public FacListaOrdene()
	    {
            SetSQLProps();
            SetDefaults();
            MarkNew();
        }
        public FacListaOrdene(bool useDatabaseDefaults)
	    {
		    SetSQLProps();
		    if(useDatabaseDefaults)
		    {
				ForceDefaults();
			}
			MarkNew();
	    }
	    
	    public FacListaOrdene(object keyID)
	    {
		    SetSQLProps();
		    LoadByKey(keyID);
	    }
    	 
	    public FacListaOrdene(string columnName, object columnValue)
        {
            SetSQLProps();
            LoadByParam(columnName,columnValue);
        }
        
	    #endregion
	    
	    #region Props
	    
          
        [XmlAttribute("OrdIdEfector")]
        [Bindable(true)]
        public int OrdIdEfector 
	    {
		    get
		    {
			    return GetColumnValue<int>("Ord_idEfector");
		    }
            set 
		    {
			    SetColumnValue("Ord_idEfector", value);
            }
        }
	      
        [XmlAttribute("OrdNumeroOrden")]
        [Bindable(true)]
        public int OrdNumeroOrden 
	    {
		    get
		    {
			    return GetColumnValue<int>("Ord_NumeroOrden");
		    }
            set 
		    {
			    SetColumnValue("Ord_NumeroOrden", value);
            }
        }
	      
        [XmlAttribute("OrdIdServicio")]
        [Bindable(true)]
        public int OrdIdServicio 
	    {
		    get
		    {
			    return GetColumnValue<int>("Ord_IdServicio");
		    }
            set 
		    {
			    SetColumnValue("Ord_IdServicio", value);
            }
        }
	      
        [XmlAttribute("OrdIdTipoPractica")]
        [Bindable(true)]
        public int OrdIdTipoPractica 
	    {
		    get
		    {
			    return GetColumnValue<int>("Ord_IdTipoPractica");
		    }
            set 
		    {
			    SetColumnValue("Ord_IdTipoPractica", value);
            }
        }
	      
        [XmlAttribute("OrdIdObraSocial")]
        [Bindable(true)]
        public int OrdIdObraSocial 
	    {
		    get
		    {
			    return GetColumnValue<int>("Ord_IdObraSocial");
		    }
            set 
		    {
			    SetColumnValue("Ord_IdObraSocial", value);
            }
        }
	      
        [XmlAttribute("OrdFechaConfeccion")]
        [Bindable(true)]
        public DateTime OrdFechaConfeccion 
	    {
		    get
		    {
			    return GetColumnValue<DateTime>("Ord_FechaConfeccion");
		    }
            set 
		    {
			    SetColumnValue("Ord_FechaConfeccion", value);
            }
        }
	      
        [XmlAttribute("OrdFechaPractica")]
        [Bindable(true)]
        public DateTime OrdFechaPractica 
	    {
		    get
		    {
			    return GetColumnValue<DateTime>("Ord_FechaPractica");
		    }
            set 
		    {
			    SetColumnValue("Ord_FechaPractica", value);
            }
        }
	      
        [XmlAttribute("OrdNumeroSiniestro")]
        [Bindable(true)]
        public string OrdNumeroSiniestro 
	    {
		    get
		    {
			    return GetColumnValue<string>("Ord_NumeroSiniestro");
		    }
            set 
		    {
			    SetColumnValue("Ord_NumeroSiniestro", value);
            }
        }
	      
        [XmlAttribute("OrdFechaSiniestro")]
        [Bindable(true)]
        public DateTime OrdFechaSiniestro 
	    {
		    get
		    {
			    return GetColumnValue<DateTime>("Ord_FechaSiniestro");
		    }
            set 
		    {
			    SetColumnValue("Ord_FechaSiniestro", value);
            }
        }
	      
        [XmlAttribute("OrdFacturaFueraConvenio")]
        [Bindable(true)]
        public bool OrdFacturaFueraConvenio 
	    {
		    get
		    {
			    return GetColumnValue<bool>("Ord_FacturaFueraConvenio");
		    }
            set 
		    {
			    SetColumnValue("Ord_FacturaFueraConvenio", value);
            }
        }
	      
        [XmlAttribute("OrdCodificaHIV")]
        [Bindable(true)]
        public bool OrdCodificaHIV 
	    {
		    get
		    {
			    return GetColumnValue<bool>("Ord_CodificaHIV");
		    }
            set 
		    {
			    SetColumnValue("Ord_CodificaHIV", value);
            }
        }
	      
        [XmlAttribute("OrdDiagnostico")]
        [Bindable(true)]
        public string OrdDiagnostico 
	    {
		    get
		    {
			    return GetColumnValue<string>("Ord_Diagnostico");
		    }
            set 
		    {
			    SetColumnValue("Ord_Diagnostico", value);
            }
        }
	      
        [XmlAttribute("DetIdNomenclador")]
        [Bindable(true)]
        public int DetIdNomenclador 
	    {
		    get
		    {
			    return GetColumnValue<int>("Det_idNomenclador");
		    }
            set 
		    {
			    SetColumnValue("Det_idNomenclador", value);
            }
        }
	      
        [XmlAttribute("DetDescripcion")]
        [Bindable(true)]
        public string DetDescripcion 
	    {
		    get
		    {
			    return GetColumnValue<string>("Det_Descripcion");
		    }
            set 
		    {
			    SetColumnValue("Det_Descripcion", value);
            }
        }
	      
        [XmlAttribute("DetCantidad")]
        [Bindable(true)]
        public int DetCantidad 
	    {
		    get
		    {
			    return GetColumnValue<int>("Det_Cantidad");
		    }
            set 
		    {
			    SetColumnValue("Det_Cantidad", value);
            }
        }
	      
        [XmlAttribute("DetValorUnidad")]
        [Bindable(true)]
        public decimal DetValorUnidad 
	    {
		    get
		    {
			    return GetColumnValue<decimal>("Det_ValorUnidad");
		    }
            set 
		    {
			    SetColumnValue("Det_ValorUnidad", value);
            }
        }
	      
        [XmlAttribute("DetAjuste")]
        [Bindable(true)]
        public decimal DetAjuste 
	    {
		    get
		    {
			    return GetColumnValue<decimal>("Det_Ajuste");
		    }
            set 
		    {
			    SetColumnValue("Det_Ajuste", value);
            }
        }
	      
        [XmlAttribute("PacNumeroDocumento")]
        [Bindable(true)]
        public int PacNumeroDocumento 
	    {
		    get
		    {
			    return GetColumnValue<int>("Pac_NumeroDocumento");
		    }
            set 
		    {
			    SetColumnValue("Pac_NumeroDocumento", value);
            }
        }
	      
        [XmlAttribute("PacNumeroAfiliado")]
        [Bindable(true)]
        public string PacNumeroAfiliado 
	    {
		    get
		    {
			    return GetColumnValue<string>("Pac_NumeroAfiliado");
		    }
            set 
		    {
			    SetColumnValue("Pac_NumeroAfiliado", value);
            }
        }
	      
        [XmlAttribute("PacApellido")]
        [Bindable(true)]
        public string PacApellido 
	    {
		    get
		    {
			    return GetColumnValue<string>("Pac_Apellido");
		    }
            set 
		    {
			    SetColumnValue("Pac_Apellido", value);
            }
        }
	      
        [XmlAttribute("PacNombre")]
        [Bindable(true)]
        public string PacNombre 
	    {
		    get
		    {
			    return GetColumnValue<string>("Pac_Nombre");
		    }
            set 
		    {
			    SetColumnValue("Pac_Nombre", value);
            }
        }
	      
        [XmlAttribute("PacIdSexo")]
        [Bindable(true)]
        public int PacIdSexo 
	    {
		    get
		    {
			    return GetColumnValue<int>("Pac_IdSexo");
		    }
            set 
		    {
			    SetColumnValue("Pac_IdSexo", value);
            }
        }
	      
        [XmlAttribute("PacFechaNacimiento")]
        [Bindable(true)]
        public DateTime PacFechaNacimiento 
	    {
		    get
		    {
			    return GetColumnValue<DateTime>("Pac_fechaNacimiento");
		    }
            set 
		    {
			    SetColumnValue("Pac_fechaNacimiento", value);
            }
        }
	      
        [XmlAttribute("ProIdTipoDocumento")]
        [Bindable(true)]
        public int ProIdTipoDocumento 
	    {
		    get
		    {
			    return GetColumnValue<int>("Pro_IdTipoDocumento");
		    }
            set 
		    {
			    SetColumnValue("Pro_IdTipoDocumento", value);
            }
        }
	      
        [XmlAttribute("ProNumeroDocumento")]
        [Bindable(true)]
        public int ProNumeroDocumento 
	    {
		    get
		    {
			    return GetColumnValue<int>("Pro_NumeroDocumento");
		    }
            set 
		    {
			    SetColumnValue("Pro_NumeroDocumento", value);
            }
        }
	      
        [XmlAttribute("ProApellido")]
        [Bindable(true)]
        public string ProApellido 
	    {
		    get
		    {
			    return GetColumnValue<string>("Pro_Apellido");
		    }
            set 
		    {
			    SetColumnValue("Pro_Apellido", value);
            }
        }
	      
        [XmlAttribute("ProNombre")]
        [Bindable(true)]
        public string ProNombre 
	    {
		    get
		    {
			    return GetColumnValue<string>("Pro_Nombre");
		    }
            set 
		    {
			    SetColumnValue("Pro_Nombre", value);
            }
        }
	      
        [XmlAttribute("ProMatricula")]
        [Bindable(true)]
        public string ProMatricula 
	    {
		    get
		    {
			    return GetColumnValue<string>("Pro_Matricula");
		    }
            set 
		    {
			    SetColumnValue("Pro_Matricula", value);
            }
        }
	    
	    #endregion
    
	    #region Columns Struct
	    public struct Columns
	    {
		    
		    
            public static string OrdIdEfector = @"Ord_idEfector";
            
            public static string OrdNumeroOrden = @"Ord_NumeroOrden";
            
            public static string OrdIdServicio = @"Ord_IdServicio";
            
            public static string OrdIdTipoPractica = @"Ord_IdTipoPractica";
            
            public static string OrdIdObraSocial = @"Ord_IdObraSocial";
            
            public static string OrdFechaConfeccion = @"Ord_FechaConfeccion";
            
            public static string OrdFechaPractica = @"Ord_FechaPractica";
            
            public static string OrdNumeroSiniestro = @"Ord_NumeroSiniestro";
            
            public static string OrdFechaSiniestro = @"Ord_FechaSiniestro";
            
            public static string OrdFacturaFueraConvenio = @"Ord_FacturaFueraConvenio";
            
            public static string OrdCodificaHIV = @"Ord_CodificaHIV";
            
            public static string OrdDiagnostico = @"Ord_Diagnostico";
            
            public static string DetIdNomenclador = @"Det_idNomenclador";
            
            public static string DetDescripcion = @"Det_Descripcion";
            
            public static string DetCantidad = @"Det_Cantidad";
            
            public static string DetValorUnidad = @"Det_ValorUnidad";
            
            public static string DetAjuste = @"Det_Ajuste";
            
            public static string PacNumeroDocumento = @"Pac_NumeroDocumento";
            
            public static string PacNumeroAfiliado = @"Pac_NumeroAfiliado";
            
            public static string PacApellido = @"Pac_Apellido";
            
            public static string PacNombre = @"Pac_Nombre";
            
            public static string PacIdSexo = @"Pac_IdSexo";
            
            public static string PacFechaNacimiento = @"Pac_fechaNacimiento";
            
            public static string ProIdTipoDocumento = @"Pro_IdTipoDocumento";
            
            public static string ProNumeroDocumento = @"Pro_NumeroDocumento";
            
            public static string ProApellido = @"Pro_Apellido";
            
            public static string ProNombre = @"Pro_Nombre";
            
            public static string ProMatricula = @"Pro_Matricula";
            
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
