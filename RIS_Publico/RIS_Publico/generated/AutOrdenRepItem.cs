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
	/// Strongly-typed collection for the AutOrdenRepItem class.
	/// </summary>
    [Serializable]
	public partial class AutOrdenRepItemCollection : ActiveList<AutOrdenRepItem, AutOrdenRepItemCollection>
	{	   
		public AutOrdenRepItemCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>AutOrdenRepItemCollection</returns>
		public AutOrdenRepItemCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                AutOrdenRepItem o = this[i];
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
	/// This is an ActiveRecord class which wraps the Aut_OrdenRepItem table.
	/// </summary>
	[Serializable]
	public partial class AutOrdenRepItem : ActiveRecord<AutOrdenRepItem>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public AutOrdenRepItem()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public AutOrdenRepItem(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public AutOrdenRepItem(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public AutOrdenRepItem(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("Aut_OrdenRepItem", TableType.Table, DataService.GetInstance("RisProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarIdOrdenRepItem = new TableSchema.TableColumn(schema);
				colvarIdOrdenRepItem.ColumnName = "idOrdenRepItem";
				colvarIdOrdenRepItem.DataType = DbType.Int32;
				colvarIdOrdenRepItem.MaxLength = 0;
				colvarIdOrdenRepItem.AutoIncrement = true;
				colvarIdOrdenRepItem.IsNullable = false;
				colvarIdOrdenRepItem.IsPrimaryKey = true;
				colvarIdOrdenRepItem.IsForeignKey = false;
				colvarIdOrdenRepItem.IsReadOnly = false;
				colvarIdOrdenRepItem.DefaultSetting = @"";
				colvarIdOrdenRepItem.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdOrdenRepItem);
				
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
				
				TableSchema.TableColumn colvarIdOrdenReparacion = new TableSchema.TableColumn(schema);
				colvarIdOrdenReparacion.ColumnName = "idOrdenReparacion";
				colvarIdOrdenReparacion.DataType = DbType.Int32;
				colvarIdOrdenReparacion.MaxLength = 0;
				colvarIdOrdenReparacion.AutoIncrement = false;
				colvarIdOrdenReparacion.IsNullable = false;
				colvarIdOrdenReparacion.IsPrimaryKey = false;
				colvarIdOrdenReparacion.IsForeignKey = false;
				colvarIdOrdenReparacion.IsReadOnly = false;
				colvarIdOrdenReparacion.DefaultSetting = @"";
				colvarIdOrdenReparacion.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdOrdenReparacion);
				
				TableSchema.TableColumn colvarIdItemMovimiento = new TableSchema.TableColumn(schema);
				colvarIdItemMovimiento.ColumnName = "idItemMovimiento";
				colvarIdItemMovimiento.DataType = DbType.Int32;
				colvarIdItemMovimiento.MaxLength = 0;
				colvarIdItemMovimiento.AutoIncrement = false;
				colvarIdItemMovimiento.IsNullable = false;
				colvarIdItemMovimiento.IsPrimaryKey = false;
				colvarIdItemMovimiento.IsForeignKey = false;
				colvarIdItemMovimiento.IsReadOnly = false;
				colvarIdItemMovimiento.DefaultSetting = @"";
				colvarIdItemMovimiento.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdItemMovimiento);
				
				TableSchema.TableColumn colvarIdVehiculo = new TableSchema.TableColumn(schema);
				colvarIdVehiculo.ColumnName = "idVehiculo";
				colvarIdVehiculo.DataType = DbType.Int32;
				colvarIdVehiculo.MaxLength = 0;
				colvarIdVehiculo.AutoIncrement = false;
				colvarIdVehiculo.IsNullable = true;
				colvarIdVehiculo.IsPrimaryKey = false;
				colvarIdVehiculo.IsForeignKey = false;
				colvarIdVehiculo.IsReadOnly = false;
				colvarIdVehiculo.DefaultSetting = @"";
				colvarIdVehiculo.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdVehiculo);
				
				TableSchema.TableColumn colvarIdProveedor = new TableSchema.TableColumn(schema);
				colvarIdProveedor.ColumnName = "idProveedor";
				colvarIdProveedor.DataType = DbType.Int32;
				colvarIdProveedor.MaxLength = 0;
				colvarIdProveedor.AutoIncrement = false;
				colvarIdProveedor.IsNullable = true;
				colvarIdProveedor.IsPrimaryKey = false;
				colvarIdProveedor.IsForeignKey = false;
				colvarIdProveedor.IsReadOnly = false;
				colvarIdProveedor.DefaultSetting = @"";
				colvarIdProveedor.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdProveedor);
				
				TableSchema.TableColumn colvarCantidad = new TableSchema.TableColumn(schema);
				colvarCantidad.ColumnName = "Cantidad";
				colvarCantidad.DataType = DbType.Int32;
				colvarCantidad.MaxLength = 0;
				colvarCantidad.AutoIncrement = false;
				colvarCantidad.IsNullable = true;
				colvarCantidad.IsPrimaryKey = false;
				colvarCantidad.IsForeignKey = false;
				colvarCantidad.IsReadOnly = false;
				colvarCantidad.DefaultSetting = @"";
				colvarCantidad.ForeignKeyTableName = "";
				schema.Columns.Add(colvarCantidad);
				
				TableSchema.TableColumn colvarValor = new TableSchema.TableColumn(schema);
				colvarValor.ColumnName = "Valor";
				colvarValor.DataType = DbType.Decimal;
				colvarValor.MaxLength = 0;
				colvarValor.AutoIncrement = false;
				colvarValor.IsNullable = true;
				colvarValor.IsPrimaryKey = false;
				colvarValor.IsForeignKey = false;
				colvarValor.IsReadOnly = false;
				colvarValor.DefaultSetting = @"";
				colvarValor.ForeignKeyTableName = "";
				schema.Columns.Add(colvarValor);
				
				TableSchema.TableColumn colvarKm = new TableSchema.TableColumn(schema);
				colvarKm.ColumnName = "km";
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
				
				TableSchema.TableColumn colvarEstadoReparacion = new TableSchema.TableColumn(schema);
				colvarEstadoReparacion.ColumnName = "EstadoReparacion";
				colvarEstadoReparacion.DataType = DbType.String;
				colvarEstadoReparacion.MaxLength = 15;
				colvarEstadoReparacion.AutoIncrement = false;
				colvarEstadoReparacion.IsNullable = true;
				colvarEstadoReparacion.IsPrimaryKey = false;
				colvarEstadoReparacion.IsForeignKey = false;
				colvarEstadoReparacion.IsReadOnly = false;
				colvarEstadoReparacion.DefaultSetting = @"";
				colvarEstadoReparacion.ForeignKeyTableName = "";
				schema.Columns.Add(colvarEstadoReparacion);
				
				TableSchema.TableColumn colvarEstado = new TableSchema.TableColumn(schema);
				colvarEstado.ColumnName = "Estado";
				colvarEstado.DataType = DbType.String;
				colvarEstado.MaxLength = 15;
				colvarEstado.AutoIncrement = false;
				colvarEstado.IsNullable = true;
				colvarEstado.IsPrimaryKey = false;
				colvarEstado.IsForeignKey = false;
				colvarEstado.IsReadOnly = false;
				colvarEstado.DefaultSetting = @"";
				colvarEstado.ForeignKeyTableName = "";
				schema.Columns.Add(colvarEstado);
				
				TableSchema.TableColumn colvarObservacion = new TableSchema.TableColumn(schema);
				colvarObservacion.ColumnName = "Observacion";
				colvarObservacion.DataType = DbType.String;
				colvarObservacion.MaxLength = 200;
				colvarObservacion.AutoIncrement = false;
				colvarObservacion.IsNullable = true;
				colvarObservacion.IsPrimaryKey = false;
				colvarObservacion.IsForeignKey = false;
				colvarObservacion.IsReadOnly = false;
				colvarObservacion.DefaultSetting = @"";
				colvarObservacion.ForeignKeyTableName = "";
				schema.Columns.Add(colvarObservacion);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["RisProvider"].AddSchema("Aut_OrdenRepItem",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("IdOrdenRepItem")]
		[Bindable(true)]
		public int IdOrdenRepItem 
		{
			get { return GetColumnValue<int>(Columns.IdOrdenRepItem); }
			set { SetColumnValue(Columns.IdOrdenRepItem, value); }
		}
		  
		[XmlAttribute("Fecha")]
		[Bindable(true)]
		public DateTime? Fecha 
		{
			get { return GetColumnValue<DateTime?>(Columns.Fecha); }
			set { SetColumnValue(Columns.Fecha, value); }
		}
		  
		[XmlAttribute("IdOrdenReparacion")]
		[Bindable(true)]
		public int IdOrdenReparacion 
		{
			get { return GetColumnValue<int>(Columns.IdOrdenReparacion); }
			set { SetColumnValue(Columns.IdOrdenReparacion, value); }
		}
		  
		[XmlAttribute("IdItemMovimiento")]
		[Bindable(true)]
		public int IdItemMovimiento 
		{
			get { return GetColumnValue<int>(Columns.IdItemMovimiento); }
			set { SetColumnValue(Columns.IdItemMovimiento, value); }
		}
		  
		[XmlAttribute("IdVehiculo")]
		[Bindable(true)]
		public int? IdVehiculo 
		{
			get { return GetColumnValue<int?>(Columns.IdVehiculo); }
			set { SetColumnValue(Columns.IdVehiculo, value); }
		}
		  
		[XmlAttribute("IdProveedor")]
		[Bindable(true)]
		public int? IdProveedor 
		{
			get { return GetColumnValue<int?>(Columns.IdProveedor); }
			set { SetColumnValue(Columns.IdProveedor, value); }
		}
		  
		[XmlAttribute("Cantidad")]
		[Bindable(true)]
		public int? Cantidad 
		{
			get { return GetColumnValue<int?>(Columns.Cantidad); }
			set { SetColumnValue(Columns.Cantidad, value); }
		}
		  
		[XmlAttribute("Valor")]
		[Bindable(true)]
		public decimal? Valor 
		{
			get { return GetColumnValue<decimal?>(Columns.Valor); }
			set { SetColumnValue(Columns.Valor, value); }
		}
		  
		[XmlAttribute("Km")]
		[Bindable(true)]
		public decimal? Km 
		{
			get { return GetColumnValue<decimal?>(Columns.Km); }
			set { SetColumnValue(Columns.Km, value); }
		}
		  
		[XmlAttribute("EstadoReparacion")]
		[Bindable(true)]
		public string EstadoReparacion 
		{
			get { return GetColumnValue<string>(Columns.EstadoReparacion); }
			set { SetColumnValue(Columns.EstadoReparacion, value); }
		}
		  
		[XmlAttribute("Estado")]
		[Bindable(true)]
		public string Estado 
		{
			get { return GetColumnValue<string>(Columns.Estado); }
			set { SetColumnValue(Columns.Estado, value); }
		}
		  
		[XmlAttribute("Observacion")]
		[Bindable(true)]
		public string Observacion 
		{
			get { return GetColumnValue<string>(Columns.Observacion); }
			set { SetColumnValue(Columns.Observacion, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(DateTime? varFecha,int varIdOrdenReparacion,int varIdItemMovimiento,int? varIdVehiculo,int? varIdProveedor,int? varCantidad,decimal? varValor,decimal? varKm,string varEstadoReparacion,string varEstado,string varObservacion)
		{
			AutOrdenRepItem item = new AutOrdenRepItem();
			
			item.Fecha = varFecha;
			
			item.IdOrdenReparacion = varIdOrdenReparacion;
			
			item.IdItemMovimiento = varIdItemMovimiento;
			
			item.IdVehiculo = varIdVehiculo;
			
			item.IdProveedor = varIdProveedor;
			
			item.Cantidad = varCantidad;
			
			item.Valor = varValor;
			
			item.Km = varKm;
			
			item.EstadoReparacion = varEstadoReparacion;
			
			item.Estado = varEstado;
			
			item.Observacion = varObservacion;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varIdOrdenRepItem,DateTime? varFecha,int varIdOrdenReparacion,int varIdItemMovimiento,int? varIdVehiculo,int? varIdProveedor,int? varCantidad,decimal? varValor,decimal? varKm,string varEstadoReparacion,string varEstado,string varObservacion)
		{
			AutOrdenRepItem item = new AutOrdenRepItem();
			
				item.IdOrdenRepItem = varIdOrdenRepItem;
			
				item.Fecha = varFecha;
			
				item.IdOrdenReparacion = varIdOrdenReparacion;
			
				item.IdItemMovimiento = varIdItemMovimiento;
			
				item.IdVehiculo = varIdVehiculo;
			
				item.IdProveedor = varIdProveedor;
			
				item.Cantidad = varCantidad;
			
				item.Valor = varValor;
			
				item.Km = varKm;
			
				item.EstadoReparacion = varEstadoReparacion;
			
				item.Estado = varEstado;
			
				item.Observacion = varObservacion;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn IdOrdenRepItemColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn FechaColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn IdOrdenReparacionColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn IdItemMovimientoColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn IdVehiculoColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn IdProveedorColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        public static TableSchema.TableColumn CantidadColumn
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        public static TableSchema.TableColumn ValorColumn
        {
            get { return Schema.Columns[7]; }
        }
        
        
        
        public static TableSchema.TableColumn KmColumn
        {
            get { return Schema.Columns[8]; }
        }
        
        
        
        public static TableSchema.TableColumn EstadoReparacionColumn
        {
            get { return Schema.Columns[9]; }
        }
        
        
        
        public static TableSchema.TableColumn EstadoColumn
        {
            get { return Schema.Columns[10]; }
        }
        
        
        
        public static TableSchema.TableColumn ObservacionColumn
        {
            get { return Schema.Columns[11]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string IdOrdenRepItem = @"idOrdenRepItem";
			 public static string Fecha = @"Fecha";
			 public static string IdOrdenReparacion = @"idOrdenReparacion";
			 public static string IdItemMovimiento = @"idItemMovimiento";
			 public static string IdVehiculo = @"idVehiculo";
			 public static string IdProveedor = @"idProveedor";
			 public static string Cantidad = @"Cantidad";
			 public static string Valor = @"Valor";
			 public static string Km = @"km";
			 public static string EstadoReparacion = @"EstadoReparacion";
			 public static string Estado = @"Estado";
			 public static string Observacion = @"Observacion";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
