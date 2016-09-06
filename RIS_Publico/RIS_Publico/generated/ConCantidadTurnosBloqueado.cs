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
    /// Strongly-typed collection for the ConCantidadTurnosBloqueado class.
    /// </summary>
    [Serializable]
    public partial class ConCantidadTurnosBloqueadoCollection : ReadOnlyList<ConCantidadTurnosBloqueado, ConCantidadTurnosBloqueadoCollection>
    {        
        public ConCantidadTurnosBloqueadoCollection() {}
    }
    /// <summary>
    /// This is  Read-only wrapper class for the CON_CantidadTurnosBloqueados view.
    /// </summary>
    [Serializable]
    public partial class ConCantidadTurnosBloqueado : ReadOnlyRecord<ConCantidadTurnosBloqueado>, IReadOnlyRecord
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
                TableSchema.Table schema = new TableSchema.Table("CON_CantidadTurnosBloqueados", TableType.View, DataService.GetInstance("RisProvider"));
                schema.Columns = new TableSchema.TableColumnCollection();
                schema.SchemaName = @"dbo";
                //columns
                
                TableSchema.TableColumn colvarIdAgenda = new TableSchema.TableColumn(schema);
                colvarIdAgenda.ColumnName = "idAgenda";
                colvarIdAgenda.DataType = DbType.Int32;
                colvarIdAgenda.MaxLength = 0;
                colvarIdAgenda.AutoIncrement = false;
                colvarIdAgenda.IsNullable = false;
                colvarIdAgenda.IsPrimaryKey = false;
                colvarIdAgenda.IsForeignKey = false;
                colvarIdAgenda.IsReadOnly = false;
                
                schema.Columns.Add(colvarIdAgenda);
                
                TableSchema.TableColumn colvarCantidadBloqueado = new TableSchema.TableColumn(schema);
                colvarCantidadBloqueado.ColumnName = "CantidadBloqueado";
                colvarCantidadBloqueado.DataType = DbType.Int32;
                colvarCantidadBloqueado.MaxLength = 0;
                colvarCantidadBloqueado.AutoIncrement = false;
                colvarCantidadBloqueado.IsNullable = true;
                colvarCantidadBloqueado.IsPrimaryKey = false;
                colvarCantidadBloqueado.IsForeignKey = false;
                colvarCantidadBloqueado.IsReadOnly = false;
                
                schema.Columns.Add(colvarCantidadBloqueado);
                
                
                BaseSchema = schema;
                //add this schema to the provider
                //so we can query it later
                DataService.Providers["RisProvider"].AddSchema("CON_CantidadTurnosBloqueados",schema);
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
	    public ConCantidadTurnosBloqueado()
	    {
            SetSQLProps();
            SetDefaults();
            MarkNew();
        }
        public ConCantidadTurnosBloqueado(bool useDatabaseDefaults)
	    {
		    SetSQLProps();
		    if(useDatabaseDefaults)
		    {
				ForceDefaults();
			}
			MarkNew();
	    }
	    
	    public ConCantidadTurnosBloqueado(object keyID)
	    {
		    SetSQLProps();
		    LoadByKey(keyID);
	    }
    	 
	    public ConCantidadTurnosBloqueado(string columnName, object columnValue)
        {
            SetSQLProps();
            LoadByParam(columnName,columnValue);
        }
        
	    #endregion
	    
	    #region Props
	    
          
        [XmlAttribute("IdAgenda")]
        [Bindable(true)]
        public int IdAgenda 
	    {
		    get
		    {
			    return GetColumnValue<int>("idAgenda");
		    }
            set 
		    {
			    SetColumnValue("idAgenda", value);
            }
        }
	      
        [XmlAttribute("CantidadBloqueado")]
        [Bindable(true)]
        public int? CantidadBloqueado 
	    {
		    get
		    {
			    return GetColumnValue<int?>("CantidadBloqueado");
		    }
            set 
		    {
			    SetColumnValue("CantidadBloqueado", value);
            }
        }
	    
	    #endregion
    
	    #region Columns Struct
	    public struct Columns
	    {
		    
		    
            public static string IdAgenda = @"idAgenda";
            
            public static string CantidadBloqueado = @"CantidadBloqueado";
            
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
