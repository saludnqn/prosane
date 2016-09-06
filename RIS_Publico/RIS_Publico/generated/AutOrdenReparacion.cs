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
	/// Strongly-typed collection for the AutOrdenReparacion class.
	/// </summary>
    [Serializable]
	public partial class AutOrdenReparacionCollection : ActiveList<AutOrdenReparacion, AutOrdenReparacionCollection>
	{	   
		public AutOrdenReparacionCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>AutOrdenReparacionCollection</returns>
		public AutOrdenReparacionCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                AutOrdenReparacion o = this[i];
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
	/// This is an ActiveRecord class which wraps the Aut_OrdenReparacion table.
	/// </summary>
	[Serializable]
	public partial class AutOrdenReparacion : ActiveRecord<AutOrdenReparacion>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public AutOrdenReparacion()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public AutOrdenReparacion(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public AutOrdenReparacion(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public AutOrdenReparacion(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("Aut_OrdenReparacion", TableType.Table, DataService.GetInstance("RisProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarIdOrdenReparacion = new TableSchema.TableColumn(schema);
				colvarIdOrdenReparacion.ColumnName = "idOrdenReparacion";
				colvarIdOrdenReparacion.DataType = DbType.Decimal;
				colvarIdOrdenReparacion.MaxLength = 0;
				colvarIdOrdenReparacion.AutoIncrement = true;
				colvarIdOrdenReparacion.IsNullable = false;
				colvarIdOrdenReparacion.IsPrimaryKey = true;
				colvarIdOrdenReparacion.IsForeignKey = false;
				colvarIdOrdenReparacion.IsReadOnly = false;
				colvarIdOrdenReparacion.DefaultSetting = @"";
				colvarIdOrdenReparacion.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdOrdenReparacion);
				
				TableSchema.TableColumn colvarFecha = new TableSchema.TableColumn(schema);
				colvarFecha.ColumnName = "Fecha";
				colvarFecha.DataType = DbType.DateTime;
				colvarFecha.MaxLength = 0;
				colvarFecha.AutoIncrement = false;
				colvarFecha.IsNullable = true;
				colvarFecha.IsPrimaryKey = false;
				colvarFecha.IsForeignKey = false;
				colvarFecha.IsReadOnly = false;
				colvarFecha.DefaultSetting = @"";
				colvarFecha.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFecha);
				
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
				
				TableSchema.TableColumn colvarIdEfector = new TableSchema.TableColumn(schema);
				colvarIdEfector.ColumnName = "idEfector";
				colvarIdEfector.DataType = DbType.Decimal;
				colvarIdEfector.MaxLength = 0;
				colvarIdEfector.AutoIncrement = false;
				colvarIdEfector.IsNullable = true;
				colvarIdEfector.IsPrimaryKey = false;
				colvarIdEfector.IsForeignKey = false;
				colvarIdEfector.IsReadOnly = false;
				colvarIdEfector.DefaultSetting = @"";
				colvarIdEfector.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdEfector);
				
				TableSchema.TableColumn colvarIdNotaPedido = new TableSchema.TableColumn(schema);
				colvarIdNotaPedido.ColumnName = "idNotaPedido";
				colvarIdNotaPedido.DataType = DbType.Decimal;
				colvarIdNotaPedido.MaxLength = 0;
				colvarIdNotaPedido.AutoIncrement = false;
				colvarIdNotaPedido.IsNullable = true;
				colvarIdNotaPedido.IsPrimaryKey = false;
				colvarIdNotaPedido.IsForeignKey = false;
				colvarIdNotaPedido.IsReadOnly = false;
				colvarIdNotaPedido.DefaultSetting = @"";
				colvarIdNotaPedido.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdNotaPedido);
				
				TableSchema.TableColumn colvarIdProveedor = new TableSchema.TableColumn(schema);
				colvarIdProveedor.ColumnName = "idProveedor";
				colvarIdProveedor.DataType = DbType.Decimal;
				colvarIdProveedor.MaxLength = 0;
				colvarIdProveedor.AutoIncrement = false;
				colvarIdProveedor.IsNullable = true;
				colvarIdProveedor.IsPrimaryKey = false;
				colvarIdProveedor.IsForeignKey = false;
				colvarIdProveedor.IsReadOnly = false;
				colvarIdProveedor.DefaultSetting = @"";
				colvarIdProveedor.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdProveedor);
				
				TableSchema.TableColumn colvarIdPresupuesto = new TableSchema.TableColumn(schema);
				colvarIdPresupuesto.ColumnName = "idPresupuesto";
				colvarIdPresupuesto.DataType = DbType.Decimal;
				colvarIdPresupuesto.MaxLength = 0;
				colvarIdPresupuesto.AutoIncrement = false;
				colvarIdPresupuesto.IsNullable = true;
				colvarIdPresupuesto.IsPrimaryKey = false;
				colvarIdPresupuesto.IsForeignKey = false;
				colvarIdPresupuesto.IsReadOnly = false;
				colvarIdPresupuesto.DefaultSetting = @"";
				colvarIdPresupuesto.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdPresupuesto);
				
				TableSchema.TableColumn colvarFechaInicio = new TableSchema.TableColumn(schema);
				colvarFechaInicio.ColumnName = "FechaInicio";
				colvarFechaInicio.DataType = DbType.DateTime;
				colvarFechaInicio.MaxLength = 0;
				colvarFechaInicio.AutoIncrement = false;
				colvarFechaInicio.IsNullable = true;
				colvarFechaInicio.IsPrimaryKey = false;
				colvarFechaInicio.IsForeignKey = false;
				colvarFechaInicio.IsReadOnly = false;
				colvarFechaInicio.DefaultSetting = @"";
				colvarFechaInicio.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFechaInicio);
				
				TableSchema.TableColumn colvarFechaFin = new TableSchema.TableColumn(schema);
				colvarFechaFin.ColumnName = "FechaFin";
				colvarFechaFin.DataType = DbType.DateTime;
				colvarFechaFin.MaxLength = 0;
				colvarFechaFin.AutoIncrement = false;
				colvarFechaFin.IsNullable = true;
				colvarFechaFin.IsPrimaryKey = false;
				colvarFechaFin.IsForeignKey = false;
				colvarFechaFin.IsReadOnly = false;
				colvarFechaFin.DefaultSetting = @"";
				colvarFechaFin.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFechaFin);
				
				TableSchema.TableColumn colvarDescripcion = new TableSchema.TableColumn(schema);
				colvarDescripcion.ColumnName = "Descripcion";
				colvarDescripcion.DataType = DbType.AnsiString;
				colvarDescripcion.MaxLength = 2147483647;
				colvarDescripcion.AutoIncrement = false;
				colvarDescripcion.IsNullable = true;
				colvarDescripcion.IsPrimaryKey = false;
				colvarDescripcion.IsForeignKey = false;
				colvarDescripcion.IsReadOnly = false;
				colvarDescripcion.DefaultSetting = @"";
				colvarDescripcion.ForeignKeyTableName = "";
				schema.Columns.Add(colvarDescripcion);
				
				TableSchema.TableColumn colvarObservacion = new TableSchema.TableColumn(schema);
				colvarObservacion.ColumnName = "Observacion";
				colvarObservacion.DataType = DbType.AnsiString;
				colvarObservacion.MaxLength = 2147483647;
				colvarObservacion.AutoIncrement = false;
				colvarObservacion.IsNullable = true;
				colvarObservacion.IsPrimaryKey = false;
				colvarObservacion.IsForeignKey = false;
				colvarObservacion.IsReadOnly = false;
				colvarObservacion.DefaultSetting = @"";
				colvarObservacion.ForeignKeyTableName = "";
				schema.Columns.Add(colvarObservacion);
				
				TableSchema.TableColumn colvarEstado = new TableSchema.TableColumn(schema);
				colvarEstado.ColumnName = "Estado";
				colvarEstado.DataType = DbType.String;
				colvarEstado.MaxLength = 50;
				colvarEstado.AutoIncrement = false;
				colvarEstado.IsNullable = true;
				colvarEstado.IsPrimaryKey = false;
				colvarEstado.IsForeignKey = false;
				colvarEstado.IsReadOnly = false;
				colvarEstado.DefaultSetting = @"";
				colvarEstado.ForeignKeyTableName = "";
				schema.Columns.Add(colvarEstado);
				
				TableSchema.TableColumn colvarKm = new TableSchema.TableColumn(schema);
				colvarKm.ColumnName = "Km";
				colvarKm.DataType = DbType.Decimal;
				colvarKm.MaxLength = 0;
				colvarKm.AutoIncrement = false;
				colvarKm.IsNullable = true;
				colvarKm.IsPrimaryKey = false;
				colvarKm.IsForeignKey = false;
				colvarKm.IsReadOnly = false;
				colvarKm.DefaultSetting = @"";
				colvarKm.ForeignKeyTableName = "";
				schema.Columns.Add(colvarKm);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["RisProvider"].AddSchema("Aut_OrdenReparacion",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("IdOrdenReparacion")]
		[Bindable(true)]
		public decimal IdOrdenReparacion 
		{
			get { return GetColumnValue<decimal>(Columns.IdOrdenReparacion); }
			set { SetColumnValue(Columns.IdOrdenReparacion, value); }
		}
		  
		[XmlAttribute("Fecha")]
		[Bindable(true)]
		public DateTime? Fecha 
		{
			get { return GetColumnValue<DateTime?>(Columns.Fecha); }
			set { SetColumnValue(Columns.Fecha, value); }
		}
		  
		[XmlAttribute("IdVehiculo")]
		[Bindable(true)]
		public decimal? IdVehiculo 
		{
			get { return GetColumnValue<decimal?>(Columns.IdVehiculo); }
			set { SetColumnValue(Columns.IdVehiculo, value); }
		}
		  
		[XmlAttribute("IdEfector")]
		[Bindable(true)]
		public decimal? IdEfector 
		{
			get { return GetColumnValue<decimal?>(Columns.IdEfector); }
			set { SetColumnValue(Columns.IdEfector, value); }
		}
		  
		[XmlAttribute("IdNotaPedido")]
		[Bindable(true)]
		public decimal? IdNotaPedido 
		{
			get { return GetColumnValue<decimal?>(Columns.IdNotaPedido); }
			set { SetColumnValue(Columns.IdNotaPedido, value); }
		}
		  
		[XmlAttribute("IdProveedor")]
		[Bindable(true)]
		public decimal? IdProveedor 
		{
			get { return GetColumnValue<decimal?>(Columns.IdProveedor); }
			set { SetColumnValue(Columns.IdProveedor, value); }
		}
		  
		[XmlAttribute("IdPresupuesto")]
		[Bindable(true)]
		public decimal? IdPresupuesto 
		{
			get { return GetColumnValue<decimal?>(Columns.IdPresupuesto); }
			set { SetColumnValue(Columns.IdPresupuesto, value); }
		}
		  
		[XmlAttribute("FechaInicio")]
		[Bindable(true)]
		public DateTime? FechaInicio 
		{
			get { return GetColumnValue<DateTime?>(Columns.FechaInicio); }
			set { SetColumnValue(Columns.FechaInicio, value); }
		}
		  
		[XmlAttribute("FechaFin")]
		[Bindable(true)]
		public DateTime? FechaFin 
		{
			get { return GetColumnValue<DateTime?>(Columns.FechaFin); }
			set { SetColumnValue(Columns.FechaFin, value); }
		}
		  
		[XmlAttribute("Descripcion")]
		[Bindable(true)]
		public string Descripcion 
		{
			get { return GetColumnValue<string>(Columns.Descripcion); }
			set { SetColumnValue(Columns.Descripcion, value); }
		}
		  
		[XmlAttribute("Observacion")]
		[Bindable(true)]
		public string Observacion 
		{
			get { return GetColumnValue<string>(Columns.Observacion); }
			set { SetColumnValue(Columns.Observacion, value); }
		}
		  
		[XmlAttribute("Estado")]
		[Bindable(true)]
		public string Estado 
		{
			get { return GetColumnValue<string>(Columns.Estado); }
			set { SetColumnValue(Columns.Estado, value); }
		}
		  
		[XmlAttribute("Km")]
		[Bindable(true)]
		public decimal? Km 
		{
			get { return GetColumnValue<decimal?>(Columns.Km); }
			set { SetColumnValue(Columns.Km, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(DateTime? varFecha,decimal? varIdVehiculo,decimal? varIdEfector,decimal? varIdNotaPedido,decimal? varIdProveedor,decimal? varIdPresupuesto,DateTime? varFechaInicio,DateTime? varFechaFin,string varDescripcion,string varObservacion,string varEstado,decimal? varKm)
		{
			AutOrdenReparacion item = new AutOrdenReparacion();
			
			item.Fecha = varFecha;
			
			item.IdVehiculo = varIdVehiculo;
			
			item.IdEfector = varIdEfector;
			
			item.IdNotaPedido = varIdNotaPedido;
			
			item.IdProveedor = varIdProveedor;
			
			item.IdPresupuesto = varIdPresupuesto;
			
			item.FechaInicio = varFechaInicio;
			
			item.FechaFin = varFechaFin;
			
			item.Descripcion = varDescripcion;
			
			item.Observacion = varObservacion;
			
			item.Estado = varEstado;
			
			item.Km = varKm;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(decimal varIdOrdenReparacion,DateTime? varFecha,decimal? varIdVehiculo,decimal? varIdEfector,decimal? varIdNotaPedido,decimal? varIdProveedor,decimal? varIdPresupuesto,DateTime? varFechaInicio,DateTime? varFechaFin,string varDescripcion,string varObservacion,string varEstado,decimal? varKm)
		{
			AutOrdenReparacion item = new AutOrdenReparacion();
			
				item.IdOrdenReparacion = varIdOrdenReparacion;
			
				item.Fecha = varFecha;
			
				item.IdVehiculo = varIdVehiculo;
			
				item.IdEfector = varIdEfector;
			
				item.IdNotaPedido = varIdNotaPedido;
			
				item.IdProveedor = varIdProveedor;
			
				item.IdPresupuesto = varIdPresupuesto;
			
				item.FechaInicio = varFechaInicio;
			
				item.FechaFin = varFechaFin;
			
				item.Descripcion = varDescripcion;
			
				item.Observacion = varObservacion;
			
				item.Estado = varEstado;
			
				item.Km = varKm;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn IdOrdenReparacionColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn FechaColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn IdVehiculoColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn IdEfectorColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn IdNotaPedidoColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn IdProveedorColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        public static TableSchema.TableColumn IdPresupuestoColumn
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        public static TableSchema.TableColumn FechaInicioColumn
        {
            get { return Schema.Columns[7]; }
        }
        
        
        
        public static TableSchema.TableColumn FechaFinColumn
        {
            get { return Schema.Columns[8]; }
        }
        
        
        
        public static TableSchema.TableColumn DescripcionColumn
        {
            get { return Schema.Columns[9]; }
        }
        
        
        
        public static TableSchema.TableColumn ObservacionColumn
        {
            get { return Schema.Columns[10]; }
        }
        
        
        
        public static TableSchema.TableColumn EstadoColumn
        {
            get { return Schema.Columns[11]; }
        }
        
        
        
        public static TableSchema.TableColumn KmColumn
        {
            get { return Schema.Columns[12]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string IdOrdenReparacion = @"idOrdenReparacion";
			 public static string Fecha = @"Fecha";
			 public static string IdVehiculo = @"idVehiculo";
			 public static string IdEfector = @"idEfector";
			 public static string IdNotaPedido = @"idNotaPedido";
			 public static string IdProveedor = @"idProveedor";
			 public static string IdPresupuesto = @"idPresupuesto";
			 public static string FechaInicio = @"FechaInicio";
			 public static string FechaFin = @"FechaFin";
			 public static string Descripcion = @"Descripcion";
			 public static string Observacion = @"Observacion";
			 public static string Estado = @"Estado";
			 public static string Km = @"Km";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
