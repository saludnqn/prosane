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
namespace DalRis
{
	/// <summary>
	/// Strongly-typed collection for the AutEstadosMov class.
	/// </summary>
    [Serializable]
	public partial class AutEstadosMovCollection : ActiveList<AutEstadosMov, AutEstadosMovCollection>
	{	   
		public AutEstadosMovCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>AutEstadosMovCollection</returns>
		public AutEstadosMovCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                AutEstadosMov o = this[i];
                foreach (SubSonic.Where w in this.wheres)
                {
                    bool remove = false;
                    System.Reflection.PropertyInfo pi = o.GetType().GetProperty(w.ColumnName);
                    if (pi.CanRead)
                    {
                        object val = pi.GetValue(o, null);
                        switch (w.Comparison)
                        {
                            case SubSonic.Comparison.Equals:
                                if (!val.Equals(w.ParameterValue))
                                {
                                    remove = true;
                                }
                                break;
                        }
                    }
                    if (remove)
                    {
                        this.Remove(o);
                        break;
                    }
                }
            }
            return this;
        }
		
		
	}
	/// <summary>
	/// This is an ActiveRecord class which wraps the AUT_EstadosMov table.
	/// </summary>
	[Serializable]
	public partial class AutEstadosMov : ActiveRecord<AutEstadosMov>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public AutEstadosMov()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public AutEstadosMov(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public AutEstadosMov(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public AutEstadosMov(string columnName, object columnValue)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByParam(columnName,columnValue);
		}
		
		protected static void SetSQLProps() { GetTableSchema(); }
		
		#endregion
		
		#region Schema and Query Accessor	
		public static Query CreateQuery() { return new Query(Schema); }
		public static TableSchema.Table Schema
		{
			get
			{
				if (BaseSchema == null)
					SetSQLProps();
				return BaseSchema;
			}
		}
		
		private static void GetTableSchema() 
		{
			if(!IsSchemaInitialized)
			{
				//Schema declaration
				TableSchema.Table schema = new TableSchema.Table("AUT_EstadosMov", TableType.Table, DataService.GetInstance("RisProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarIdEstadosMov = new TableSchema.TableColumn(schema);
				colvarIdEstadosMov.ColumnName = "idEstadosMov";
				colvarIdEstadosMov.DataType = DbType.Decimal;
				colvarIdEstadosMov.MaxLength = 0;
				colvarIdEstadosMov.AutoIncrement = false;
				colvarIdEstadosMov.IsNullable = false;
				colvarIdEstadosMov.IsPrimaryKey = true;
				colvarIdEstadosMov.IsForeignKey = false;
				colvarIdEstadosMov.IsReadOnly = false;
				colvarIdEstadosMov.DefaultSetting = @"";
				colvarIdEstadosMov.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdEstadosMov);
				
				TableSchema.TableColumn colvarIdVehiculo = new TableSchema.TableColumn(schema);
				colvarIdVehiculo.ColumnName = "idVehiculo";
				colvarIdVehiculo.DataType = DbType.Decimal;
				colvarIdVehiculo.MaxLength = 0;
				colvarIdVehiculo.AutoIncrement = false;
				colvarIdVehiculo.IsNullable = true;
				colvarIdVehiculo.IsPrimaryKey = false;
				colvarIdVehiculo.IsForeignKey = false;
				colvarIdVehiculo.IsReadOnly = false;
				colvarIdVehiculo.DefaultSetting = @"";
				colvarIdVehiculo.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdVehiculo);
				
				TableSchema.TableColumn colvarEstado = new TableSchema.TableColumn(schema);
				colvarEstado.ColumnName = "Estado";
				colvarEstado.DataType = DbType.String;
				colvarEstado.MaxLength = 10;
				colvarEstado.AutoIncrement = false;
				colvarEstado.IsNullable = true;
				colvarEstado.IsPrimaryKey = false;
				colvarEstado.IsForeignKey = false;
				colvarEstado.IsReadOnly = false;
				colvarEstado.DefaultSetting = @"";
				colvarEstado.ForeignKeyTableName = "";
				schema.Columns.Add(colvarEstado);
				
				TableSchema.TableColumn colvarFechaIngreso = new TableSchema.TableColumn(schema);
				colvarFechaIngreso.ColumnName = "FechaIngreso";
				colvarFechaIngreso.DataType = DbType.DateTime;
				colvarFechaIngreso.MaxLength = 0;
				colvarFechaIngreso.AutoIncrement = false;
				colvarFechaIngreso.IsNullable = true;
				colvarFechaIngreso.IsPrimaryKey = false;
				colvarFechaIngreso.IsForeignKey = false;
				colvarFechaIngreso.IsReadOnly = false;
				colvarFechaIngreso.DefaultSetting = @"";
				colvarFechaIngreso.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFechaIngreso);
				
				TableSchema.TableColumn colvarFechaEgreso = new TableSchema.TableColumn(schema);
				colvarFechaEgreso.ColumnName = "FechaEgreso";
				colvarFechaEgreso.DataType = DbType.DateTime;
				colvarFechaEgreso.MaxLength = 0;
				colvarFechaEgreso.AutoIncrement = false;
				colvarFechaEgreso.IsNullable = true;
				colvarFechaEgreso.IsPrimaryKey = false;
				colvarFechaEgreso.IsForeignKey = false;
				colvarFechaEgreso.IsReadOnly = false;
				colvarFechaEgreso.DefaultSetting = @"";
				colvarFechaEgreso.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFechaEgreso);
				
				TableSchema.TableColumn colvarObservaciones = new TableSchema.TableColumn(schema);
				colvarObservaciones.ColumnName = "Observaciones";
				colvarObservaciones.DataType = DbType.AnsiString;
				colvarObservaciones.MaxLength = 2147483647;
				colvarObservaciones.AutoIncrement = false;
				colvarObservaciones.IsNullable = true;
				colvarObservaciones.IsPrimaryKey = false;
				colvarObservaciones.IsForeignKey = false;
				colvarObservaciones.IsReadOnly = false;
				colvarObservaciones.DefaultSetting = @"";
				colvarObservaciones.ForeignKeyTableName = "";
				schema.Columns.Add(colvarObservaciones);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["RisProvider"].AddSchema("AUT_EstadosMov",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("IdEstadosMov")]
		[Bindable(true)]
		public decimal IdEstadosMov 
		{
			get { return GetColumnValue<decimal>(Columns.IdEstadosMov); }
			set { SetColumnValue(Columns.IdEstadosMov, value); }
		}
		  
		[XmlAttribute("IdVehiculo")]
		[Bindable(true)]
		public decimal? IdVehiculo 
		{
			get { return GetColumnValue<decimal?>(Columns.IdVehiculo); }
			set { SetColumnValue(Columns.IdVehiculo, value); }
		}
		  
		[XmlAttribute("Estado")]
		[Bindable(true)]
		public string Estado 
		{
			get { return GetColumnValue<string>(Columns.Estado); }
			set { SetColumnValue(Columns.Estado, value); }
		}
		  
		[XmlAttribute("FechaIngreso")]
		[Bindable(true)]
		public DateTime? FechaIngreso 
		{
			get { return GetColumnValue<DateTime?>(Columns.FechaIngreso); }
			set { SetColumnValue(Columns.FechaIngreso, value); }
		}
		  
		[XmlAttribute("FechaEgreso")]
		[Bindable(true)]
		public DateTime? FechaEgreso 
		{
			get { return GetColumnValue<DateTime?>(Columns.FechaEgreso); }
			set { SetColumnValue(Columns.FechaEgreso, value); }
		}
		  
		[XmlAttribute("Observaciones")]
		[Bindable(true)]
		public string Observaciones 
		{
			get { return GetColumnValue<string>(Columns.Observaciones); }
			set { SetColumnValue(Columns.Observaciones, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(decimal varIdEstadosMov,decimal? varIdVehiculo,string varEstado,DateTime? varFechaIngreso,DateTime? varFechaEgreso,string varObservaciones)
		{
			AutEstadosMov item = new AutEstadosMov();
			
			item.IdEstadosMov = varIdEstadosMov;
			
			item.IdVehiculo = varIdVehiculo;
			
			item.Estado = varEstado;
			
			item.FechaIngreso = varFechaIngreso;
			
			item.FechaEgreso = varFechaEgreso;
			
			item.Observaciones = varObservaciones;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(decimal varIdEstadosMov,decimal? varIdVehiculo,string varEstado,DateTime? varFechaIngreso,DateTime? varFechaEgreso,string varObservaciones)
		{
			AutEstadosMov item = new AutEstadosMov();
			
				item.IdEstadosMov = varIdEstadosMov;
			
				item.IdVehiculo = varIdVehiculo;
			
				item.Estado = varEstado;
			
				item.FechaIngreso = varFechaIngreso;
			
				item.FechaEgreso = varFechaEgreso;
			
				item.Observaciones = varObservaciones;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn IdEstadosMovColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn IdVehiculoColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn EstadoColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn FechaIngresoColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn FechaEgresoColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn ObservacionesColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string IdEstadosMov = @"idEstadosMov";
			 public static string IdVehiculo = @"idVehiculo";
			 public static string Estado = @"Estado";
			 public static string FechaIngreso = @"FechaIngreso";
			 public static string FechaEgreso = @"FechaEgreso";
			 public static string Observaciones = @"Observaciones";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
