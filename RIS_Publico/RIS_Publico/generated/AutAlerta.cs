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
    /// Strongly-typed collection for the AutAlerta class.
    /// </summary>
    [Serializable]
    public partial class AutAlertaCollection : ReadOnlyList<AutAlerta, AutAlertaCollection>
    {        
        public AutAlertaCollection() {}
    }
    /// <summary>
    /// This is  Read-only wrapper class for the AUT_Alertas view.
    /// </summary>
    [Serializable]
    public partial class AutAlerta : ReadOnlyRecord<AutAlerta>, IReadOnlyRecord
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
                TableSchema.Table schema = new TableSchema.Table("AUT_Alertas", TableType.View, DataService.GetInstance("RisProvider"));
                schema.Columns = new TableSchema.TableColumnCollection();
                schema.SchemaName = @"dbo";
                //columns
                
                TableSchema.TableColumn colvarIdVehiculo = new TableSchema.TableColumn(schema);
                colvarIdVehiculo.ColumnName = "idVehiculo";
                colvarIdVehiculo.DataType = DbType.Int32;
                colvarIdVehiculo.MaxLength = 0;
                colvarIdVehiculo.AutoIncrement = false;
                colvarIdVehiculo.IsNullable = false;
                colvarIdVehiculo.IsPrimaryKey = false;
                colvarIdVehiculo.IsForeignKey = false;
                colvarIdVehiculo.IsReadOnly = false;
                
                schema.Columns.Add(colvarIdVehiculo);
                
                TableSchema.TableColumn colvarOdometroActual = new TableSchema.TableColumn(schema);
                colvarOdometroActual.ColumnName = "odometroActual";
                colvarOdometroActual.DataType = DbType.Int32;
                colvarOdometroActual.MaxLength = 0;
                colvarOdometroActual.AutoIncrement = false;
                colvarOdometroActual.IsNullable = false;
                colvarOdometroActual.IsPrimaryKey = false;
                colvarOdometroActual.IsForeignKey = false;
                colvarOdometroActual.IsReadOnly = false;
                
                schema.Columns.Add(colvarOdometroActual);
                
                TableSchema.TableColumn colvarDominio = new TableSchema.TableColumn(schema);
                colvarDominio.ColumnName = "dominio";
                colvarDominio.DataType = DbType.String;
                colvarDominio.MaxLength = 50;
                colvarDominio.AutoIncrement = false;
                colvarDominio.IsNullable = false;
                colvarDominio.IsPrimaryKey = false;
                colvarDominio.IsForeignKey = false;
                colvarDominio.IsReadOnly = false;
                
                schema.Columns.Add(colvarDominio);
                
                TableSchema.TableColumn colvarIdModelo = new TableSchema.TableColumn(schema);
                colvarIdModelo.ColumnName = "idModelo";
                colvarIdModelo.DataType = DbType.Int32;
                colvarIdModelo.MaxLength = 0;
                colvarIdModelo.AutoIncrement = false;
                colvarIdModelo.IsNullable = false;
                colvarIdModelo.IsPrimaryKey = false;
                colvarIdModelo.IsForeignKey = false;
                colvarIdModelo.IsReadOnly = false;
                
                schema.Columns.Add(colvarIdModelo);
                
                TableSchema.TableColumn colvarModelo = new TableSchema.TableColumn(schema);
                colvarModelo.ColumnName = "modelo";
                colvarModelo.DataType = DbType.String;
                colvarModelo.MaxLength = 50;
                colvarModelo.AutoIncrement = false;
                colvarModelo.IsNullable = false;
                colvarModelo.IsPrimaryKey = false;
                colvarModelo.IsForeignKey = false;
                colvarModelo.IsReadOnly = false;
                
                schema.Columns.Add(colvarModelo);
                
                TableSchema.TableColumn colvarIdMarca = new TableSchema.TableColumn(schema);
                colvarIdMarca.ColumnName = "idMarca";
                colvarIdMarca.DataType = DbType.Int32;
                colvarIdMarca.MaxLength = 0;
                colvarIdMarca.AutoIncrement = false;
                colvarIdMarca.IsNullable = false;
                colvarIdMarca.IsPrimaryKey = false;
                colvarIdMarca.IsForeignKey = false;
                colvarIdMarca.IsReadOnly = false;
                
                schema.Columns.Add(colvarIdMarca);
                
                TableSchema.TableColumn colvarMarca = new TableSchema.TableColumn(schema);
                colvarMarca.ColumnName = "marca";
                colvarMarca.DataType = DbType.String;
                colvarMarca.MaxLength = 50;
                colvarMarca.AutoIncrement = false;
                colvarMarca.IsNullable = false;
                colvarMarca.IsPrimaryKey = false;
                colvarMarca.IsForeignKey = false;
                colvarMarca.IsReadOnly = false;
                
                schema.Columns.Add(colvarMarca);
                
                TableSchema.TableColumn colvarIdTipoVehiculo = new TableSchema.TableColumn(schema);
                colvarIdTipoVehiculo.ColumnName = "idTipoVehiculo";
                colvarIdTipoVehiculo.DataType = DbType.Int32;
                colvarIdTipoVehiculo.MaxLength = 0;
                colvarIdTipoVehiculo.AutoIncrement = false;
                colvarIdTipoVehiculo.IsNullable = false;
                colvarIdTipoVehiculo.IsPrimaryKey = false;
                colvarIdTipoVehiculo.IsForeignKey = false;
                colvarIdTipoVehiculo.IsReadOnly = false;
                
                schema.Columns.Add(colvarIdTipoVehiculo);
                
                TableSchema.TableColumn colvarTipoVehiculo = new TableSchema.TableColumn(schema);
                colvarTipoVehiculo.ColumnName = "tipoVehiculo";
                colvarTipoVehiculo.DataType = DbType.String;
                colvarTipoVehiculo.MaxLength = 50;
                colvarTipoVehiculo.AutoIncrement = false;
                colvarTipoVehiculo.IsNullable = false;
                colvarTipoVehiculo.IsPrimaryKey = false;
                colvarTipoVehiculo.IsForeignKey = false;
                colvarTipoVehiculo.IsReadOnly = false;
                
                schema.Columns.Add(colvarTipoVehiculo);
                
                TableSchema.TableColumn colvarIdEntidad = new TableSchema.TableColumn(schema);
                colvarIdEntidad.ColumnName = "idEntidad";
                colvarIdEntidad.DataType = DbType.Int32;
                colvarIdEntidad.MaxLength = 0;
                colvarIdEntidad.AutoIncrement = false;
                colvarIdEntidad.IsNullable = false;
                colvarIdEntidad.IsPrimaryKey = false;
                colvarIdEntidad.IsForeignKey = false;
                colvarIdEntidad.IsReadOnly = false;
                
                schema.Columns.Add(colvarIdEntidad);
                
                TableSchema.TableColumn colvarEfectorEntidad = new TableSchema.TableColumn(schema);
                colvarEfectorEntidad.ColumnName = "efectorEntidad";
                colvarEfectorEntidad.DataType = DbType.String;
                colvarEfectorEntidad.MaxLength = 100;
                colvarEfectorEntidad.AutoIncrement = false;
                colvarEfectorEntidad.IsNullable = false;
                colvarEfectorEntidad.IsPrimaryKey = false;
                colvarEfectorEntidad.IsForeignKey = false;
                colvarEfectorEntidad.IsReadOnly = false;
                
                schema.Columns.Add(colvarEfectorEntidad);
                
                TableSchema.TableColumn colvarIdZona = new TableSchema.TableColumn(schema);
                colvarIdZona.ColumnName = "idZona";
                colvarIdZona.DataType = DbType.Int32;
                colvarIdZona.MaxLength = 0;
                colvarIdZona.AutoIncrement = false;
                colvarIdZona.IsNullable = false;
                colvarIdZona.IsPrimaryKey = false;
                colvarIdZona.IsForeignKey = false;
                colvarIdZona.IsReadOnly = false;
                
                schema.Columns.Add(colvarIdZona);
                
                TableSchema.TableColumn colvarZona = new TableSchema.TableColumn(schema);
                colvarZona.ColumnName = "zona";
                colvarZona.DataType = DbType.String;
                colvarZona.MaxLength = 50;
                colvarZona.AutoIncrement = false;
                colvarZona.IsNullable = false;
                colvarZona.IsPrimaryKey = false;
                colvarZona.IsForeignKey = false;
                colvarZona.IsReadOnly = false;
                
                schema.Columns.Add(colvarZona);
                
                TableSchema.TableColumn colvarIdVehiculoPMP = new TableSchema.TableColumn(schema);
                colvarIdVehiculoPMP.ColumnName = "idVehiculoPMP";
                colvarIdVehiculoPMP.DataType = DbType.Int32;
                colvarIdVehiculoPMP.MaxLength = 0;
                colvarIdVehiculoPMP.AutoIncrement = false;
                colvarIdVehiculoPMP.IsNullable = false;
                colvarIdVehiculoPMP.IsPrimaryKey = false;
                colvarIdVehiculoPMP.IsForeignKey = false;
                colvarIdVehiculoPMP.IsReadOnly = false;
                
                schema.Columns.Add(colvarIdVehiculoPMP);
                
                TableSchema.TableColumn colvarFecha = new TableSchema.TableColumn(schema);
                colvarFecha.ColumnName = "fecha";
                colvarFecha.DataType = DbType.DateTime;
                colvarFecha.MaxLength = 0;
                colvarFecha.AutoIncrement = false;
                colvarFecha.IsNullable = false;
                colvarFecha.IsPrimaryKey = false;
                colvarFecha.IsForeignKey = false;
                colvarFecha.IsReadOnly = false;
                
                schema.Columns.Add(colvarFecha);
                
                TableSchema.TableColumn colvarKilometraje = new TableSchema.TableColumn(schema);
                colvarKilometraje.ColumnName = "kilometraje";
                colvarKilometraje.DataType = DbType.Int32;
                colvarKilometraje.MaxLength = 0;
                colvarKilometraje.AutoIncrement = false;
                colvarKilometraje.IsNullable = false;
                colvarKilometraje.IsPrimaryKey = false;
                colvarKilometraje.IsForeignKey = false;
                colvarKilometraje.IsReadOnly = false;
                
                schema.Columns.Add(colvarKilometraje);
                
                TableSchema.TableColumn colvarIdPMP = new TableSchema.TableColumn(schema);
                colvarIdPMP.ColumnName = "idPMP";
                colvarIdPMP.DataType = DbType.Int32;
                colvarIdPMP.MaxLength = 0;
                colvarIdPMP.AutoIncrement = false;
                colvarIdPMP.IsNullable = false;
                colvarIdPMP.IsPrimaryKey = false;
                colvarIdPMP.IsForeignKey = false;
                colvarIdPMP.IsReadOnly = false;
                
                schema.Columns.Add(colvarIdPMP);
                
                TableSchema.TableColumn colvarKilometrajePMP = new TableSchema.TableColumn(schema);
                colvarKilometrajePMP.ColumnName = "KilometrajePMP";
                colvarKilometrajePMP.DataType = DbType.Int32;
                colvarKilometrajePMP.MaxLength = 0;
                colvarKilometrajePMP.AutoIncrement = false;
                colvarKilometrajePMP.IsNullable = false;
                colvarKilometrajePMP.IsPrimaryKey = false;
                colvarKilometrajePMP.IsForeignKey = false;
                colvarKilometrajePMP.IsReadOnly = false;
                
                schema.Columns.Add(colvarKilometrajePMP);
                
                
                BaseSchema = schema;
                //add this schema to the provider
                //so we can query it later
                DataService.Providers["RisProvider"].AddSchema("AUT_Alertas",schema);
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
	    public AutAlerta()
	    {
            SetSQLProps();
            SetDefaults();
            MarkNew();
        }
        public AutAlerta(bool useDatabaseDefaults)
	    {
		    SetSQLProps();
		    if(useDatabaseDefaults)
		    {
				ForceDefaults();
			}
			MarkNew();
	    }
	    
	    public AutAlerta(object keyID)
	    {
		    SetSQLProps();
		    LoadByKey(keyID);
	    }
    	 
	    public AutAlerta(string columnName, object columnValue)
        {
            SetSQLProps();
            LoadByParam(columnName,columnValue);
        }
        
	    #endregion
	    
	    #region Props
	    
          
        [XmlAttribute("IdVehiculo")]
        [Bindable(true)]
        public int IdVehiculo 
	    {
		    get
		    {
			    return GetColumnValue<int>("idVehiculo");
		    }
            set 
		    {
			    SetColumnValue("idVehiculo", value);
            }
        }
	      
        [XmlAttribute("OdometroActual")]
        [Bindable(true)]
        public int OdometroActual 
	    {
		    get
		    {
			    return GetColumnValue<int>("odometroActual");
		    }
            set 
		    {
			    SetColumnValue("odometroActual", value);
            }
        }
	      
        [XmlAttribute("Dominio")]
        [Bindable(true)]
        public string Dominio 
	    {
		    get
		    {
			    return GetColumnValue<string>("dominio");
		    }
            set 
		    {
			    SetColumnValue("dominio", value);
            }
        }
	      
        [XmlAttribute("IdModelo")]
        [Bindable(true)]
        public int IdModelo 
	    {
		    get
		    {
			    return GetColumnValue<int>("idModelo");
		    }
            set 
		    {
			    SetColumnValue("idModelo", value);
            }
        }
	      
        [XmlAttribute("Modelo")]
        [Bindable(true)]
        public string Modelo 
	    {
		    get
		    {
			    return GetColumnValue<string>("modelo");
		    }
            set 
		    {
			    SetColumnValue("modelo", value);
            }
        }
	      
        [XmlAttribute("IdMarca")]
        [Bindable(true)]
        public int IdMarca 
	    {
		    get
		    {
			    return GetColumnValue<int>("idMarca");
		    }
            set 
		    {
			    SetColumnValue("idMarca", value);
            }
        }
	      
        [XmlAttribute("Marca")]
        [Bindable(true)]
        public string Marca 
	    {
		    get
		    {
			    return GetColumnValue<string>("marca");
		    }
            set 
		    {
			    SetColumnValue("marca", value);
            }
        }
	      
        [XmlAttribute("IdTipoVehiculo")]
        [Bindable(true)]
        public int IdTipoVehiculo 
	    {
		    get
		    {
			    return GetColumnValue<int>("idTipoVehiculo");
		    }
            set 
		    {
			    SetColumnValue("idTipoVehiculo", value);
            }
        }
	      
        [XmlAttribute("TipoVehiculo")]
        [Bindable(true)]
        public string TipoVehiculo 
	    {
		    get
		    {
			    return GetColumnValue<string>("tipoVehiculo");
		    }
            set 
		    {
			    SetColumnValue("tipoVehiculo", value);
            }
        }
	      
        [XmlAttribute("IdEntidad")]
        [Bindable(true)]
        public int IdEntidad 
	    {
		    get
		    {
			    return GetColumnValue<int>("idEntidad");
		    }
            set 
		    {
			    SetColumnValue("idEntidad", value);
            }
        }
	      
        [XmlAttribute("EfectorEntidad")]
        [Bindable(true)]
        public string EfectorEntidad 
	    {
		    get
		    {
			    return GetColumnValue<string>("efectorEntidad");
		    }
            set 
		    {
			    SetColumnValue("efectorEntidad", value);
            }
        }
	      
        [XmlAttribute("IdZona")]
        [Bindable(true)]
        public int IdZona 
	    {
		    get
		    {
			    return GetColumnValue<int>("idZona");
		    }
            set 
		    {
			    SetColumnValue("idZona", value);
            }
        }
	      
        [XmlAttribute("Zona")]
        [Bindable(true)]
        public string Zona 
	    {
		    get
		    {
			    return GetColumnValue<string>("zona");
		    }
            set 
		    {
			    SetColumnValue("zona", value);
            }
        }
	      
        [XmlAttribute("IdVehiculoPMP")]
        [Bindable(true)]
        public int IdVehiculoPMP 
	    {
		    get
		    {
			    return GetColumnValue<int>("idVehiculoPMP");
		    }
            set 
		    {
			    SetColumnValue("idVehiculoPMP", value);
            }
        }
	      
        [XmlAttribute("Fecha")]
        [Bindable(true)]
        public DateTime Fecha 
	    {
		    get
		    {
			    return GetColumnValue<DateTime>("fecha");
		    }
            set 
		    {
			    SetColumnValue("fecha", value);
            }
        }
	      
        [XmlAttribute("Kilometraje")]
        [Bindable(true)]
        public int Kilometraje 
	    {
		    get
		    {
			    return GetColumnValue<int>("kilometraje");
		    }
            set 
		    {
			    SetColumnValue("kilometraje", value);
            }
        }
	      
        [XmlAttribute("IdPMP")]
        [Bindable(true)]
        public int IdPMP 
	    {
		    get
		    {
			    return GetColumnValue<int>("idPMP");
		    }
            set 
		    {
			    SetColumnValue("idPMP", value);
            }
        }
	      
        [XmlAttribute("KilometrajePMP")]
        [Bindable(true)]
        public int KilometrajePMP 
	    {
		    get
		    {
			    return GetColumnValue<int>("KilometrajePMP");
		    }
            set 
		    {
			    SetColumnValue("KilometrajePMP", value);
            }
        }
	    
	    #endregion
    
	    #region Columns Struct
	    public struct Columns
	    {
		    
		    
            public static string IdVehiculo = @"idVehiculo";
            
            public static string OdometroActual = @"odometroActual";
            
            public static string Dominio = @"dominio";
            
            public static string IdModelo = @"idModelo";
            
            public static string Modelo = @"modelo";
            
            public static string IdMarca = @"idMarca";
            
            public static string Marca = @"marca";
            
            public static string IdTipoVehiculo = @"idTipoVehiculo";
            
            public static string TipoVehiculo = @"tipoVehiculo";
            
            public static string IdEntidad = @"idEntidad";
            
            public static string EfectorEntidad = @"efectorEntidad";
            
            public static string IdZona = @"idZona";
            
            public static string Zona = @"zona";
            
            public static string IdVehiculoPMP = @"idVehiculoPMP";
            
            public static string Fecha = @"fecha";
            
            public static string Kilometraje = @"kilometraje";
            
            public static string IdPMP = @"idPMP";
            
            public static string KilometrajePMP = @"KilometrajePMP";
            
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
