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
    /// Strongly-typed collection for the HhhObraSocial class.
    /// </summary>
    [Serializable]
    public partial class HhhObraSocialCollection : ReadOnlyList<HhhObraSocial, HhhObraSocialCollection>
    {        
        public HhhObraSocialCollection() {}
    }
    /// <summary>
    /// This is  Read-only wrapper class for the HHH_ObraSocial view.
    /// </summary>
    [Serializable]
    public partial class HhhObraSocial : ReadOnlyRecord<HhhObraSocial>, IReadOnlyRecord
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
                TableSchema.Table schema = new TableSchema.Table("HHH_ObraSocial", TableType.View, DataService.GetInstance("RisProvider"));
                schema.Columns = new TableSchema.TableColumnCollection();
                schema.SchemaName = @"dbo";
                //columns
                
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
                
                TableSchema.TableColumn colvarNombre = new TableSchema.TableColumn(schema);
                colvarNombre.ColumnName = "nombre";
                colvarNombre.DataType = DbType.String;
                colvarNombre.MaxLength = 200;
                colvarNombre.AutoIncrement = false;
                colvarNombre.IsNullable = false;
                colvarNombre.IsPrimaryKey = false;
                colvarNombre.IsForeignKey = false;
                colvarNombre.IsReadOnly = false;
                
                schema.Columns.Add(colvarNombre);
                
                TableSchema.TableColumn colvarSigla = new TableSchema.TableColumn(schema);
                colvarSigla.ColumnName = "sigla";
                colvarSigla.DataType = DbType.String;
                colvarSigla.MaxLength = 50;
                colvarSigla.AutoIncrement = false;
                colvarSigla.IsNullable = false;
                colvarSigla.IsPrimaryKey = false;
                colvarSigla.IsForeignKey = false;
                colvarSigla.IsReadOnly = false;
                
                schema.Columns.Add(colvarSigla);
                
                TableSchema.TableColumn colvarCodigoNacion = new TableSchema.TableColumn(schema);
                colvarCodigoNacion.ColumnName = "codigoNacion";
                colvarCodigoNacion.DataType = DbType.String;
                colvarCodigoNacion.MaxLength = 200;
                colvarCodigoNacion.AutoIncrement = false;
                colvarCodigoNacion.IsNullable = true;
                colvarCodigoNacion.IsPrimaryKey = false;
                colvarCodigoNacion.IsForeignKey = false;
                colvarCodigoNacion.IsReadOnly = false;
                
                schema.Columns.Add(colvarCodigoNacion);
                
                TableSchema.TableColumn colvarCuenta = new TableSchema.TableColumn(schema);
                colvarCuenta.ColumnName = "cuenta";
                colvarCuenta.DataType = DbType.String;
                colvarCuenta.MaxLength = 50;
                colvarCuenta.AutoIncrement = false;
                colvarCuenta.IsNullable = true;
                colvarCuenta.IsPrimaryKey = false;
                colvarCuenta.IsForeignKey = false;
                colvarCuenta.IsReadOnly = false;
                
                schema.Columns.Add(colvarCuenta);
                
                TableSchema.TableColumn colvarDomicilio = new TableSchema.TableColumn(schema);
                colvarDomicilio.ColumnName = "domicilio";
                colvarDomicilio.DataType = DbType.String;
                colvarDomicilio.MaxLength = 500;
                colvarDomicilio.AutoIncrement = false;
                colvarDomicilio.IsNullable = true;
                colvarDomicilio.IsPrimaryKey = false;
                colvarDomicilio.IsForeignKey = false;
                colvarDomicilio.IsReadOnly = false;
                
                schema.Columns.Add(colvarDomicilio);
                
                TableSchema.TableColumn colvarIdTipoIva = new TableSchema.TableColumn(schema);
                colvarIdTipoIva.ColumnName = "idTipoIva";
                colvarIdTipoIva.DataType = DbType.Int32;
                colvarIdTipoIva.MaxLength = 0;
                colvarIdTipoIva.AutoIncrement = false;
                colvarIdTipoIva.IsNullable = false;
                colvarIdTipoIva.IsPrimaryKey = false;
                colvarIdTipoIva.IsForeignKey = false;
                colvarIdTipoIva.IsReadOnly = false;
                
                schema.Columns.Add(colvarIdTipoIva);
                
                TableSchema.TableColumn colvarCuit = new TableSchema.TableColumn(schema);
                colvarCuit.ColumnName = "cuit";
                colvarCuit.DataType = DbType.String;
                colvarCuit.MaxLength = 50;
                colvarCuit.AutoIncrement = false;
                colvarCuit.IsNullable = true;
                colvarCuit.IsPrimaryKey = false;
                colvarCuit.IsForeignKey = false;
                colvarCuit.IsReadOnly = false;
                
                schema.Columns.Add(colvarCuit);
                
                TableSchema.TableColumn colvarContacto = new TableSchema.TableColumn(schema);
                colvarContacto.ColumnName = "contacto";
                colvarContacto.DataType = DbType.String;
                colvarContacto.MaxLength = 500;
                colvarContacto.AutoIncrement = false;
                colvarContacto.IsNullable = true;
                colvarContacto.IsPrimaryKey = false;
                colvarContacto.IsForeignKey = false;
                colvarContacto.IsReadOnly = false;
                
                schema.Columns.Add(colvarContacto);
                
                TableSchema.TableColumn colvarTelefono = new TableSchema.TableColumn(schema);
                colvarTelefono.ColumnName = "telefono";
                colvarTelefono.DataType = DbType.String;
                colvarTelefono.MaxLength = 50;
                colvarTelefono.AutoIncrement = false;
                colvarTelefono.IsNullable = true;
                colvarTelefono.IsPrimaryKey = false;
                colvarTelefono.IsForeignKey = false;
                colvarTelefono.IsReadOnly = false;
                
                schema.Columns.Add(colvarTelefono);
                
                TableSchema.TableColumn colvarIdTipoObraSocial = new TableSchema.TableColumn(schema);
                colvarIdTipoObraSocial.ColumnName = "idTipoObraSocial";
                colvarIdTipoObraSocial.DataType = DbType.Int32;
                colvarIdTipoObraSocial.MaxLength = 0;
                colvarIdTipoObraSocial.AutoIncrement = false;
                colvarIdTipoObraSocial.IsNullable = false;
                colvarIdTipoObraSocial.IsPrimaryKey = false;
                colvarIdTipoObraSocial.IsForeignKey = false;
                colvarIdTipoObraSocial.IsReadOnly = false;
                
                schema.Columns.Add(colvarIdTipoObraSocial);
                
                TableSchema.TableColumn colvarIdObraSocialDepende = new TableSchema.TableColumn(schema);
                colvarIdObraSocialDepende.ColumnName = "idObraSocialDepende";
                colvarIdObraSocialDepende.DataType = DbType.Int32;
                colvarIdObraSocialDepende.MaxLength = 0;
                colvarIdObraSocialDepende.AutoIncrement = false;
                colvarIdObraSocialDepende.IsNullable = false;
                colvarIdObraSocialDepende.IsPrimaryKey = false;
                colvarIdObraSocialDepende.IsForeignKey = false;
                colvarIdObraSocialDepende.IsReadOnly = false;
                
                schema.Columns.Add(colvarIdObraSocialDepende);
                
                TableSchema.TableColumn colvarFacturaPerCapita = new TableSchema.TableColumn(schema);
                colvarFacturaPerCapita.ColumnName = "facturaPerCapita";
                colvarFacturaPerCapita.DataType = DbType.Boolean;
                colvarFacturaPerCapita.MaxLength = 0;
                colvarFacturaPerCapita.AutoIncrement = false;
                colvarFacturaPerCapita.IsNullable = false;
                colvarFacturaPerCapita.IsPrimaryKey = false;
                colvarFacturaPerCapita.IsForeignKey = false;
                colvarFacturaPerCapita.IsReadOnly = false;
                
                schema.Columns.Add(colvarFacturaPerCapita);
                
                TableSchema.TableColumn colvarFacturaCarteraFija = new TableSchema.TableColumn(schema);
                colvarFacturaCarteraFija.ColumnName = "facturaCarteraFija";
                colvarFacturaCarteraFija.DataType = DbType.Boolean;
                colvarFacturaCarteraFija.MaxLength = 0;
                colvarFacturaCarteraFija.AutoIncrement = false;
                colvarFacturaCarteraFija.IsNullable = false;
                colvarFacturaCarteraFija.IsPrimaryKey = false;
                colvarFacturaCarteraFija.IsForeignKey = false;
                colvarFacturaCarteraFija.IsReadOnly = false;
                
                schema.Columns.Add(colvarFacturaCarteraFija);
                
                TableSchema.TableColumn colvarFacturaAjuste = new TableSchema.TableColumn(schema);
                colvarFacturaAjuste.ColumnName = "facturaAjuste";
                colvarFacturaAjuste.DataType = DbType.Boolean;
                colvarFacturaAjuste.MaxLength = 0;
                colvarFacturaAjuste.AutoIncrement = false;
                colvarFacturaAjuste.IsNullable = false;
                colvarFacturaAjuste.IsPrimaryKey = false;
                colvarFacturaAjuste.IsForeignKey = false;
                colvarFacturaAjuste.IsReadOnly = false;
                
                schema.Columns.Add(colvarFacturaAjuste);
                
                TableSchema.TableColumn colvarFacturaPorcentajeAjuste = new TableSchema.TableColumn(schema);
                colvarFacturaPorcentajeAjuste.ColumnName = "facturaPorcentajeAjuste";
                colvarFacturaPorcentajeAjuste.DataType = DbType.Decimal;
                colvarFacturaPorcentajeAjuste.MaxLength = 0;
                colvarFacturaPorcentajeAjuste.AutoIncrement = false;
                colvarFacturaPorcentajeAjuste.IsNullable = false;
                colvarFacturaPorcentajeAjuste.IsPrimaryKey = false;
                colvarFacturaPorcentajeAjuste.IsForeignKey = false;
                colvarFacturaPorcentajeAjuste.IsReadOnly = false;
                
                schema.Columns.Add(colvarFacturaPorcentajeAjuste);
                
                TableSchema.TableColumn colvarNroOrden = new TableSchema.TableColumn(schema);
                colvarNroOrden.ColumnName = "nroOrden";
                colvarNroOrden.DataType = DbType.Int32;
                colvarNroOrden.MaxLength = 0;
                colvarNroOrden.AutoIncrement = false;
                colvarNroOrden.IsNullable = false;
                colvarNroOrden.IsPrimaryKey = false;
                colvarNroOrden.IsForeignKey = false;
                colvarNroOrden.IsReadOnly = false;
                
                schema.Columns.Add(colvarNroOrden);
                
                TableSchema.TableColumn colvarPermiteFacturaFueraConvenio = new TableSchema.TableColumn(schema);
                colvarPermiteFacturaFueraConvenio.ColumnName = "permiteFacturaFueraConvenio";
                colvarPermiteFacturaFueraConvenio.DataType = DbType.Boolean;
                colvarPermiteFacturaFueraConvenio.MaxLength = 0;
                colvarPermiteFacturaFueraConvenio.AutoIncrement = false;
                colvarPermiteFacturaFueraConvenio.IsNullable = false;
                colvarPermiteFacturaFueraConvenio.IsPrimaryKey = false;
                colvarPermiteFacturaFueraConvenio.IsForeignKey = false;
                colvarPermiteFacturaFueraConvenio.IsReadOnly = false;
                
                schema.Columns.Add(colvarPermiteFacturaFueraConvenio);
                
                
                BaseSchema = schema;
                //add this schema to the provider
                //so we can query it later
                DataService.Providers["RisProvider"].AddSchema("HHH_ObraSocial",schema);
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
	    public HhhObraSocial()
	    {
            SetSQLProps();
            SetDefaults();
            MarkNew();
        }
        public HhhObraSocial(bool useDatabaseDefaults)
	    {
		    SetSQLProps();
		    if(useDatabaseDefaults)
		    {
				ForceDefaults();
			}
			MarkNew();
	    }
	    
	    public HhhObraSocial(object keyID)
	    {
		    SetSQLProps();
		    LoadByKey(keyID);
	    }
    	 
	    public HhhObraSocial(string columnName, object columnValue)
        {
            SetSQLProps();
            LoadByParam(columnName,columnValue);
        }
        
	    #endregion
	    
	    #region Props
	    
          
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
	      
        [XmlAttribute("Sigla")]
        [Bindable(true)]
        public string Sigla 
	    {
		    get
		    {
			    return GetColumnValue<string>("sigla");
		    }
            set 
		    {
			    SetColumnValue("sigla", value);
            }
        }
	      
        [XmlAttribute("CodigoNacion")]
        [Bindable(true)]
        public string CodigoNacion 
	    {
		    get
		    {
			    return GetColumnValue<string>("codigoNacion");
		    }
            set 
		    {
			    SetColumnValue("codigoNacion", value);
            }
        }
	      
        [XmlAttribute("Cuenta")]
        [Bindable(true)]
        public string Cuenta 
	    {
		    get
		    {
			    return GetColumnValue<string>("cuenta");
		    }
            set 
		    {
			    SetColumnValue("cuenta", value);
            }
        }
	      
        [XmlAttribute("Domicilio")]
        [Bindable(true)]
        public string Domicilio 
	    {
		    get
		    {
			    return GetColumnValue<string>("domicilio");
		    }
            set 
		    {
			    SetColumnValue("domicilio", value);
            }
        }
	      
        [XmlAttribute("IdTipoIva")]
        [Bindable(true)]
        public int IdTipoIva 
	    {
		    get
		    {
			    return GetColumnValue<int>("idTipoIva");
		    }
            set 
		    {
			    SetColumnValue("idTipoIva", value);
            }
        }
	      
        [XmlAttribute("Cuit")]
        [Bindable(true)]
        public string Cuit 
	    {
		    get
		    {
			    return GetColumnValue<string>("cuit");
		    }
            set 
		    {
			    SetColumnValue("cuit", value);
            }
        }
	      
        [XmlAttribute("Contacto")]
        [Bindable(true)]
        public string Contacto 
	    {
		    get
		    {
			    return GetColumnValue<string>("contacto");
		    }
            set 
		    {
			    SetColumnValue("contacto", value);
            }
        }
	      
        [XmlAttribute("Telefono")]
        [Bindable(true)]
        public string Telefono 
	    {
		    get
		    {
			    return GetColumnValue<string>("telefono");
		    }
            set 
		    {
			    SetColumnValue("telefono", value);
            }
        }
	      
        [XmlAttribute("IdTipoObraSocial")]
        [Bindable(true)]
        public int IdTipoObraSocial 
	    {
		    get
		    {
			    return GetColumnValue<int>("idTipoObraSocial");
		    }
            set 
		    {
			    SetColumnValue("idTipoObraSocial", value);
            }
        }
	      
        [XmlAttribute("IdObraSocialDepende")]
        [Bindable(true)]
        public int IdObraSocialDepende 
	    {
		    get
		    {
			    return GetColumnValue<int>("idObraSocialDepende");
		    }
            set 
		    {
			    SetColumnValue("idObraSocialDepende", value);
            }
        }
	      
        [XmlAttribute("FacturaPerCapita")]
        [Bindable(true)]
        public bool FacturaPerCapita 
	    {
		    get
		    {
			    return GetColumnValue<bool>("facturaPerCapita");
		    }
            set 
		    {
			    SetColumnValue("facturaPerCapita", value);
            }
        }
	      
        [XmlAttribute("FacturaCarteraFija")]
        [Bindable(true)]
        public bool FacturaCarteraFija 
	    {
		    get
		    {
			    return GetColumnValue<bool>("facturaCarteraFija");
		    }
            set 
		    {
			    SetColumnValue("facturaCarteraFija", value);
            }
        }
	      
        [XmlAttribute("FacturaAjuste")]
        [Bindable(true)]
        public bool FacturaAjuste 
	    {
		    get
		    {
			    return GetColumnValue<bool>("facturaAjuste");
		    }
            set 
		    {
			    SetColumnValue("facturaAjuste", value);
            }
        }
	      
        [XmlAttribute("FacturaPorcentajeAjuste")]
        [Bindable(true)]
        public decimal FacturaPorcentajeAjuste 
	    {
		    get
		    {
			    return GetColumnValue<decimal>("facturaPorcentajeAjuste");
		    }
            set 
		    {
			    SetColumnValue("facturaPorcentajeAjuste", value);
            }
        }
	      
        [XmlAttribute("NroOrden")]
        [Bindable(true)]
        public int NroOrden 
	    {
		    get
		    {
			    return GetColumnValue<int>("nroOrden");
		    }
            set 
		    {
			    SetColumnValue("nroOrden", value);
            }
        }
	      
        [XmlAttribute("PermiteFacturaFueraConvenio")]
        [Bindable(true)]
        public bool PermiteFacturaFueraConvenio 
	    {
		    get
		    {
			    return GetColumnValue<bool>("permiteFacturaFueraConvenio");
		    }
            set 
		    {
			    SetColumnValue("permiteFacturaFueraConvenio", value);
            }
        }
	    
	    #endregion
    
	    #region Columns Struct
	    public struct Columns
	    {
		    
		    
            public static string IdObraSocial = @"idObraSocial";
            
            public static string Nombre = @"nombre";
            
            public static string Sigla = @"sigla";
            
            public static string CodigoNacion = @"codigoNacion";
            
            public static string Cuenta = @"cuenta";
            
            public static string Domicilio = @"domicilio";
            
            public static string IdTipoIva = @"idTipoIva";
            
            public static string Cuit = @"cuit";
            
            public static string Contacto = @"contacto";
            
            public static string Telefono = @"telefono";
            
            public static string IdTipoObraSocial = @"idTipoObraSocial";
            
            public static string IdObraSocialDepende = @"idObraSocialDepende";
            
            public static string FacturaPerCapita = @"facturaPerCapita";
            
            public static string FacturaCarteraFija = @"facturaCarteraFija";
            
            public static string FacturaAjuste = @"facturaAjuste";
            
            public static string FacturaPorcentajeAjuste = @"facturaPorcentajeAjuste";
            
            public static string NroOrden = @"nroOrden";
            
            public static string PermiteFacturaFueraConvenio = @"permiteFacturaFueraConvenio";
            
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
