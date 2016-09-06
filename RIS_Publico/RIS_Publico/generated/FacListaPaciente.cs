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
    /// Strongly-typed collection for the FacListaPaciente class.
    /// </summary>
    [Serializable]
    public partial class FacListaPacienteCollection : ReadOnlyList<FacListaPaciente, FacListaPacienteCollection>
    {        
        public FacListaPacienteCollection() {}
    }
    /// <summary>
    /// This is  Read-only wrapper class for the FAC_ListaPacientes view.
    /// </summary>
    [Serializable]
    public partial class FacListaPaciente : ReadOnlyRecord<FacListaPaciente>, IReadOnlyRecord
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
                TableSchema.Table schema = new TableSchema.Table("FAC_ListaPacientes", TableType.View, DataService.GetInstance("RisProvider"));
                schema.Columns = new TableSchema.TableColumnCollection();
                schema.SchemaName = @"dbo";
                //columns
                
                TableSchema.TableColumn colvarIdPaciente = new TableSchema.TableColumn(schema);
                colvarIdPaciente.ColumnName = "idPaciente";
                colvarIdPaciente.DataType = DbType.Int32;
                colvarIdPaciente.MaxLength = 0;
                colvarIdPaciente.AutoIncrement = false;
                colvarIdPaciente.IsNullable = false;
                colvarIdPaciente.IsPrimaryKey = false;
                colvarIdPaciente.IsForeignKey = false;
                colvarIdPaciente.IsReadOnly = false;
                
                schema.Columns.Add(colvarIdPaciente);
                
                TableSchema.TableColumn colvarDni = new TableSchema.TableColumn(schema);
                colvarDni.ColumnName = "dni";
                colvarDni.DataType = DbType.Int32;
                colvarDni.MaxLength = 0;
                colvarDni.AutoIncrement = false;
                colvarDni.IsNullable = false;
                colvarDni.IsPrimaryKey = false;
                colvarDni.IsForeignKey = false;
                colvarDni.IsReadOnly = false;
                
                schema.Columns.Add(colvarDni);
                
                TableSchema.TableColumn colvarDni2 = new TableSchema.TableColumn(schema);
                colvarDni2.ColumnName = "dni2";
                colvarDni2.DataType = DbType.Int32;
                colvarDni2.MaxLength = 0;
                colvarDni2.AutoIncrement = false;
                colvarDni2.IsNullable = false;
                colvarDni2.IsPrimaryKey = false;
                colvarDni2.IsForeignKey = false;
                colvarDni2.IsReadOnly = false;
                
                schema.Columns.Add(colvarDni2);
                
                TableSchema.TableColumn colvarApellido = new TableSchema.TableColumn(schema);
                colvarApellido.ColumnName = "apellido";
                colvarApellido.DataType = DbType.String;
                colvarApellido.MaxLength = 100;
                colvarApellido.AutoIncrement = false;
                colvarApellido.IsNullable = false;
                colvarApellido.IsPrimaryKey = false;
                colvarApellido.IsForeignKey = false;
                colvarApellido.IsReadOnly = false;
                
                schema.Columns.Add(colvarApellido);
                
                TableSchema.TableColumn colvarNombre = new TableSchema.TableColumn(schema);
                colvarNombre.ColumnName = "nombre";
                colvarNombre.DataType = DbType.String;
                colvarNombre.MaxLength = 100;
                colvarNombre.AutoIncrement = false;
                colvarNombre.IsNullable = false;
                colvarNombre.IsPrimaryKey = false;
                colvarNombre.IsForeignKey = false;
                colvarNombre.IsReadOnly = false;
                
                schema.Columns.Add(colvarNombre);
                
                TableSchema.TableColumn colvarFechaNacimiento = new TableSchema.TableColumn(schema);
                colvarFechaNacimiento.ColumnName = "fechaNacimiento";
                colvarFechaNacimiento.DataType = DbType.AnsiString;
                colvarFechaNacimiento.MaxLength = 10;
                colvarFechaNacimiento.AutoIncrement = false;
                colvarFechaNacimiento.IsNullable = true;
                colvarFechaNacimiento.IsPrimaryKey = false;
                colvarFechaNacimiento.IsForeignKey = false;
                colvarFechaNacimiento.IsReadOnly = false;
                
                schema.Columns.Add(colvarFechaNacimiento);
                
                TableSchema.TableColumn colvarSexo = new TableSchema.TableColumn(schema);
                colvarSexo.ColumnName = "sexo";
                colvarSexo.DataType = DbType.AnsiString;
                colvarSexo.MaxLength = 4;
                colvarSexo.AutoIncrement = false;
                colvarSexo.IsNullable = true;
                colvarSexo.IsPrimaryKey = false;
                colvarSexo.IsForeignKey = false;
                colvarSexo.IsReadOnly = false;
                
                schema.Columns.Add(colvarSexo);
                
                TableSchema.TableColumn colvarFinanciador = new TableSchema.TableColumn(schema);
                colvarFinanciador.ColumnName = "financiador";
                colvarFinanciador.DataType = DbType.String;
                colvarFinanciador.MaxLength = 200;
                colvarFinanciador.AutoIncrement = false;
                colvarFinanciador.IsNullable = false;
                colvarFinanciador.IsPrimaryKey = false;
                colvarFinanciador.IsForeignKey = false;
                colvarFinanciador.IsReadOnly = false;
                
                schema.Columns.Add(colvarFinanciador);
                
                TableSchema.TableColumn colvarIdFinanciador = new TableSchema.TableColumn(schema);
                colvarIdFinanciador.ColumnName = "idFinanciador";
                colvarIdFinanciador.DataType = DbType.Int32;
                colvarIdFinanciador.MaxLength = 0;
                colvarIdFinanciador.AutoIncrement = false;
                colvarIdFinanciador.IsNullable = true;
                colvarIdFinanciador.IsPrimaryKey = false;
                colvarIdFinanciador.IsForeignKey = false;
                colvarIdFinanciador.IsReadOnly = false;
                
                schema.Columns.Add(colvarIdFinanciador);
                
                
                BaseSchema = schema;
                //add this schema to the provider
                //so we can query it later
                DataService.Providers["RisProvider"].AddSchema("FAC_ListaPacientes",schema);
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
	    public FacListaPaciente()
	    {
            SetSQLProps();
            SetDefaults();
            MarkNew();
        }
        public FacListaPaciente(bool useDatabaseDefaults)
	    {
		    SetSQLProps();
		    if(useDatabaseDefaults)
		    {
				ForceDefaults();
			}
			MarkNew();
	    }
	    
	    public FacListaPaciente(object keyID)
	    {
		    SetSQLProps();
		    LoadByKey(keyID);
	    }
    	 
	    public FacListaPaciente(string columnName, object columnValue)
        {
            SetSQLProps();
            LoadByParam(columnName,columnValue);
        }
        
	    #endregion
	    
	    #region Props
	    
          
        [XmlAttribute("IdPaciente")]
        [Bindable(true)]
        public int IdPaciente 
	    {
		    get
		    {
			    return GetColumnValue<int>("idPaciente");
		    }
            set 
		    {
			    SetColumnValue("idPaciente", value);
            }
        }
	      
        [XmlAttribute("Dni")]
        [Bindable(true)]
        public int Dni 
	    {
		    get
		    {
			    return GetColumnValue<int>("dni");
		    }
            set 
		    {
			    SetColumnValue("dni", value);
            }
        }
	      
        [XmlAttribute("Dni2")]
        [Bindable(true)]
        public int Dni2 
	    {
		    get
		    {
			    return GetColumnValue<int>("dni2");
		    }
            set 
		    {
			    SetColumnValue("dni2", value);
            }
        }
	      
        [XmlAttribute("Apellido")]
        [Bindable(true)]
        public string Apellido 
	    {
		    get
		    {
			    return GetColumnValue<string>("apellido");
		    }
            set 
		    {
			    SetColumnValue("apellido", value);
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
	      
        [XmlAttribute("FechaNacimiento")]
        [Bindable(true)]
        public string FechaNacimiento 
	    {
		    get
		    {
			    return GetColumnValue<string>("fechaNacimiento");
		    }
            set 
		    {
			    SetColumnValue("fechaNacimiento", value);
            }
        }
	      
        [XmlAttribute("Sexo")]
        [Bindable(true)]
        public string Sexo 
	    {
		    get
		    {
			    return GetColumnValue<string>("sexo");
		    }
            set 
		    {
			    SetColumnValue("sexo", value);
            }
        }
	      
        [XmlAttribute("Financiador")]
        [Bindable(true)]
        public string Financiador 
	    {
		    get
		    {
			    return GetColumnValue<string>("financiador");
		    }
            set 
		    {
			    SetColumnValue("financiador", value);
            }
        }
	      
        [XmlAttribute("IdFinanciador")]
        [Bindable(true)]
        public int? IdFinanciador 
	    {
		    get
		    {
			    return GetColumnValue<int?>("idFinanciador");
		    }
            set 
		    {
			    SetColumnValue("idFinanciador", value);
            }
        }
	    
	    #endregion
    
	    #region Columns Struct
	    public struct Columns
	    {
		    
		    
            public static string IdPaciente = @"idPaciente";
            
            public static string Dni = @"dni";
            
            public static string Dni2 = @"dni2";
            
            public static string Apellido = @"apellido";
            
            public static string Nombre = @"nombre";
            
            public static string FechaNacimiento = @"fechaNacimiento";
            
            public static string Sexo = @"sexo";
            
            public static string Financiador = @"financiador";
            
            public static string IdFinanciador = @"idFinanciador";
            
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
