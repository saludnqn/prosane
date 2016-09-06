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
    /// Strongly-typed collection for the HhhTipoPractica class.
    /// </summary>
    [Serializable]
    public partial class HhhTipoPracticaCollection : ReadOnlyList<HhhTipoPractica, HhhTipoPracticaCollection>
    {        
        public HhhTipoPracticaCollection() {}
    }
    /// <summary>
    /// This is  Read-only wrapper class for the HHH_TipoPractica view.
    /// </summary>
    [Serializable]
    public partial class HhhTipoPractica : ReadOnlyRecord<HhhTipoPractica>, IReadOnlyRecord
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
                TableSchema.Table schema = new TableSchema.Table("HHH_TipoPractica", TableType.View, DataService.GetInstance("RisProvider"));
                schema.Columns = new TableSchema.TableColumnCollection();
                schema.SchemaName = @"dbo";
                //columns
                
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
                
                TableSchema.TableColumn colvarNombre = new TableSchema.TableColumn(schema);
                colvarNombre.ColumnName = "Nombre";
                colvarNombre.DataType = DbType.String;
                colvarNombre.MaxLength = 50;
                colvarNombre.AutoIncrement = false;
                colvarNombre.IsNullable = true;
                colvarNombre.IsPrimaryKey = false;
                colvarNombre.IsForeignKey = false;
                colvarNombre.IsReadOnly = false;
                
                schema.Columns.Add(colvarNombre);
                
                TableSchema.TableColumn colvarBaja = new TableSchema.TableColumn(schema);
                colvarBaja.ColumnName = "baja";
                colvarBaja.DataType = DbType.Boolean;
                colvarBaja.MaxLength = 0;
                colvarBaja.AutoIncrement = false;
                colvarBaja.IsNullable = false;
                colvarBaja.IsPrimaryKey = false;
                colvarBaja.IsForeignKey = false;
                colvarBaja.IsReadOnly = false;
                
                schema.Columns.Add(colvarBaja);
                
                
                BaseSchema = schema;
                //add this schema to the provider
                //so we can query it later
                DataService.Providers["RisProvider"].AddSchema("HHH_TipoPractica",schema);
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
	    public HhhTipoPractica()
	    {
            SetSQLProps();
            SetDefaults();
            MarkNew();
        }
        public HhhTipoPractica(bool useDatabaseDefaults)
	    {
		    SetSQLProps();
		    if(useDatabaseDefaults)
		    {
				ForceDefaults();
			}
			MarkNew();
	    }
	    
	    public HhhTipoPractica(object keyID)
	    {
		    SetSQLProps();
		    LoadByKey(keyID);
	    }
    	 
	    public HhhTipoPractica(string columnName, object columnValue)
        {
            SetSQLProps();
            LoadByParam(columnName,columnValue);
        }
        
	    #endregion
	    
	    #region Props
	    
          
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
	      
        [XmlAttribute("Baja")]
        [Bindable(true)]
        public bool Baja 
	    {
		    get
		    {
			    return GetColumnValue<bool>("baja");
		    }
            set 
		    {
			    SetColumnValue("baja", value);
            }
        }
	    
	    #endregion
    
	    #region Columns Struct
	    public struct Columns
	    {
		    
		    
            public static string IdTipoPractica = @"idTipoPractica";
            
            public static string Nombre = @"Nombre";
            
            public static string Baja = @"baja";
            
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
