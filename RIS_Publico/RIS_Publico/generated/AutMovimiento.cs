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
	/// Strongly-typed collection for the AutMovimiento class.
	/// </summary>
    [Serializable]
	public partial class AutMovimientoCollection : ActiveList<AutMovimiento, AutMovimientoCollection>
	{	   
		public AutMovimientoCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>AutMovimientoCollection</returns>
		public AutMovimientoCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                AutMovimiento o = this[i];
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
	/// This is an ActiveRecord class which wraps the AUT_Movimiento table.
	/// </summary>
	[Serializable]
	public partial class AutMovimiento : ActiveRecord<AutMovimiento>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public AutMovimiento()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public AutMovimiento(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public AutMovimiento(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public AutMovimiento(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("AUT_Movimiento", TableType.Table, DataService.GetInstance("RisProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarIdMovimiento = new TableSchema.TableColumn(schema);
				colvarIdMovimiento.ColumnName = "idMovimiento";
				colvarIdMovimiento.DataType = DbType.Int32;
				colvarIdMovimiento.MaxLength = 0;
				colvarIdMovimiento.AutoIncrement = true;
				colvarIdMovimiento.IsNullable = false;
				colvarIdMovimiento.IsPrimaryKey = true;
				colvarIdMovimiento.IsForeignKey = false;
				colvarIdMovimiento.IsReadOnly = false;
				colvarIdMovimiento.DefaultSetting = @"";
				colvarIdMovimiento.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdMovimiento);
				
				TableSchema.TableColumn colvarFechaHoraAltaRegistro = new TableSchema.TableColumn(schema);
				colvarFechaHoraAltaRegistro.ColumnName = "fechaHoraAltaRegistro";
				colvarFechaHoraAltaRegistro.DataType = DbType.DateTime;
				colvarFechaHoraAltaRegistro.MaxLength = 0;
				colvarFechaHoraAltaRegistro.AutoIncrement = false;
				colvarFechaHoraAltaRegistro.IsNullable = false;
				colvarFechaHoraAltaRegistro.IsPrimaryKey = false;
				colvarFechaHoraAltaRegistro.IsForeignKey = false;
				colvarFechaHoraAltaRegistro.IsReadOnly = false;
				colvarFechaHoraAltaRegistro.DefaultSetting = @"";
				colvarFechaHoraAltaRegistro.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFechaHoraAltaRegistro);
				
				TableSchema.TableColumn colvarFechaHoraRealizacion = new TableSchema.TableColumn(schema);
				colvarFechaHoraRealizacion.ColumnName = "fechaHoraRealizacion";
				colvarFechaHoraRealizacion.DataType = DbType.DateTime;
				colvarFechaHoraRealizacion.MaxLength = 0;
				colvarFechaHoraRealizacion.AutoIncrement = false;
				colvarFechaHoraRealizacion.IsNullable = false;
				colvarFechaHoraRealizacion.IsPrimaryKey = false;
				colvarFechaHoraRealizacion.IsForeignKey = false;
				colvarFechaHoraRealizacion.IsReadOnly = false;
				colvarFechaHoraRealizacion.DefaultSetting = @"";
				colvarFechaHoraRealizacion.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFechaHoraRealizacion);
				
				TableSchema.TableColumn colvarImporte = new TableSchema.TableColumn(schema);
				colvarImporte.ColumnName = "importe";
				colvarImporte.DataType = DbType.Decimal;
				colvarImporte.MaxLength = 0;
				colvarImporte.AutoIncrement = false;
				colvarImporte.IsNullable = false;
				colvarImporte.IsPrimaryKey = false;
				colvarImporte.IsForeignKey = false;
				colvarImporte.IsReadOnly = false;
				colvarImporte.DefaultSetting = @"";
				colvarImporte.ForeignKeyTableName = "";
				schema.Columns.Add(colvarImporte);
				
				TableSchema.TableColumn colvarIdVehiculo = new TableSchema.TableColumn(schema);
				colvarIdVehiculo.ColumnName = "idVehiculo";
				colvarIdVehiculo.DataType = DbType.Int32;
				colvarIdVehiculo.MaxLength = 0;
				colvarIdVehiculo.AutoIncrement = false;
				colvarIdVehiculo.IsNullable = false;
				colvarIdVehiculo.IsPrimaryKey = false;
				colvarIdVehiculo.IsForeignKey = true;
				colvarIdVehiculo.IsReadOnly = false;
				colvarIdVehiculo.DefaultSetting = @"";
				
					colvarIdVehiculo.ForeignKeyTableName = "AUT_Vehiculo";
				schema.Columns.Add(colvarIdVehiculo);
				
				TableSchema.TableColumn colvarIdTipoMovimiento = new TableSchema.TableColumn(schema);
				colvarIdTipoMovimiento.ColumnName = "idTipoMovimiento";
				colvarIdTipoMovimiento.DataType = DbType.Int32;
				colvarIdTipoMovimiento.MaxLength = 0;
				colvarIdTipoMovimiento.AutoIncrement = false;
				colvarIdTipoMovimiento.IsNullable = false;
				colvarIdTipoMovimiento.IsPrimaryKey = false;
				colvarIdTipoMovimiento.IsForeignKey = true;
				colvarIdTipoMovimiento.IsReadOnly = false;
				colvarIdTipoMovimiento.DefaultSetting = @"";
				
					colvarIdTipoMovimiento.ForeignKeyTableName = "AUT_TipoMovimiento";
				schema.Columns.Add(colvarIdTipoMovimiento);
				
				TableSchema.TableColumn colvarIdProveedor = new TableSchema.TableColumn(schema);
				colvarIdProveedor.ColumnName = "idProveedor";
				colvarIdProveedor.DataType = DbType.Int32;
				colvarIdProveedor.MaxLength = 0;
				colvarIdProveedor.AutoIncrement = false;
				colvarIdProveedor.IsNullable = false;
				colvarIdProveedor.IsPrimaryKey = false;
				colvarIdProveedor.IsForeignKey = true;
				colvarIdProveedor.IsReadOnly = false;
				colvarIdProveedor.DefaultSetting = @"";
				
					colvarIdProveedor.ForeignKeyTableName = "AUT_Proveedor";
				schema.Columns.Add(colvarIdProveedor);
				
				TableSchema.TableColumn colvarIdUsuarioRegistro = new TableSchema.TableColumn(schema);
				colvarIdUsuarioRegistro.ColumnName = "idUsuarioRegistro";
				colvarIdUsuarioRegistro.DataType = DbType.Int32;
				colvarIdUsuarioRegistro.MaxLength = 0;
				colvarIdUsuarioRegistro.AutoIncrement = false;
				colvarIdUsuarioRegistro.IsNullable = false;
				colvarIdUsuarioRegistro.IsPrimaryKey = false;
				colvarIdUsuarioRegistro.IsForeignKey = true;
				colvarIdUsuarioRegistro.IsReadOnly = false;
				colvarIdUsuarioRegistro.DefaultSetting = @"";
				
					colvarIdUsuarioRegistro.ForeignKeyTableName = "Sys_Usuario";
				schema.Columns.Add(colvarIdUsuarioRegistro);
				
				TableSchema.TableColumn colvarFechaRegistro = new TableSchema.TableColumn(schema);
				colvarFechaRegistro.ColumnName = "fechaRegistro";
				colvarFechaRegistro.DataType = DbType.DateTime;
				colvarFechaRegistro.MaxLength = 0;
				colvarFechaRegistro.AutoIncrement = false;
				colvarFechaRegistro.IsNullable = false;
				colvarFechaRegistro.IsPrimaryKey = false;
				colvarFechaRegistro.IsForeignKey = false;
				colvarFechaRegistro.IsReadOnly = false;
				colvarFechaRegistro.DefaultSetting = @"";
				colvarFechaRegistro.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFechaRegistro);
				
				TableSchema.TableColumn colvarDescripcion = new TableSchema.TableColumn(schema);
				colvarDescripcion.ColumnName = "descripcion";
				colvarDescripcion.DataType = DbType.String;
				colvarDescripcion.MaxLength = 500;
				colvarDescripcion.AutoIncrement = false;
				colvarDescripcion.IsNullable = true;
				colvarDescripcion.IsPrimaryKey = false;
				colvarDescripcion.IsForeignKey = false;
				colvarDescripcion.IsReadOnly = false;
				colvarDescripcion.DefaultSetting = @"";
				colvarDescripcion.ForeignKeyTableName = "";
				schema.Columns.Add(colvarDescripcion);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["RisProvider"].AddSchema("AUT_Movimiento",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("IdMovimiento")]
		[Bindable(true)]
		public int IdMovimiento 
		{
			get { return GetColumnValue<int>(Columns.IdMovimiento); }
			set { SetColumnValue(Columns.IdMovimiento, value); }
		}
		  
		[XmlAttribute("FechaHoraAltaRegistro")]
		[Bindable(true)]
		public DateTime FechaHoraAltaRegistro 
		{
			get { return GetColumnValue<DateTime>(Columns.FechaHoraAltaRegistro); }
			set { SetColumnValue(Columns.FechaHoraAltaRegistro, value); }
		}
		  
		[XmlAttribute("FechaHoraRealizacion")]
		[Bindable(true)]
		public DateTime FechaHoraRealizacion 
		{
			get { return GetColumnValue<DateTime>(Columns.FechaHoraRealizacion); }
			set { SetColumnValue(Columns.FechaHoraRealizacion, value); }
		}
		  
		[XmlAttribute("Importe")]
		[Bindable(true)]
		public decimal Importe 
		{
			get { return GetColumnValue<decimal>(Columns.Importe); }
			set { SetColumnValue(Columns.Importe, value); }
		}
		  
		[XmlAttribute("IdVehiculo")]
		[Bindable(true)]
		public int IdVehiculo 
		{
			get { return GetColumnValue<int>(Columns.IdVehiculo); }
			set { SetColumnValue(Columns.IdVehiculo, value); }
		}
		  
		[XmlAttribute("IdTipoMovimiento")]
		[Bindable(true)]
		public int IdTipoMovimiento 
		{
			get { return GetColumnValue<int>(Columns.IdTipoMovimiento); }
			set { SetColumnValue(Columns.IdTipoMovimiento, value); }
		}
		  
		[XmlAttribute("IdProveedor")]
		[Bindable(true)]
		public int IdProveedor 
		{
			get { return GetColumnValue<int>(Columns.IdProveedor); }
			set { SetColumnValue(Columns.IdProveedor, value); }
		}
		  
		[XmlAttribute("IdUsuarioRegistro")]
		[Bindable(true)]
		public int IdUsuarioRegistro 
		{
			get { return GetColumnValue<int>(Columns.IdUsuarioRegistro); }
			set { SetColumnValue(Columns.IdUsuarioRegistro, value); }
		}
		  
		[XmlAttribute("FechaRegistro")]
		[Bindable(true)]
		public DateTime FechaRegistro 
		{
			get { return GetColumnValue<DateTime>(Columns.FechaRegistro); }
			set { SetColumnValue(Columns.FechaRegistro, value); }
		}
		  
		[XmlAttribute("Descripcion")]
		[Bindable(true)]
		public string Descripcion 
		{
			get { return GetColumnValue<string>(Columns.Descripcion); }
			set { SetColumnValue(Columns.Descripcion, value); }
		}
		
		#endregion
		
		
			
		
		#region ForeignKey Properties
		
		/// <summary>
		/// Returns a AutProveedor ActiveRecord object related to this AutMovimiento
		/// 
		/// </summary>
		public DalRis.AutProveedor AutProveedor
		{
			get { return DalRis.AutProveedor.FetchByID(this.IdProveedor); }
			set { SetColumnValue("idProveedor", value.IdProveedor); }
		}
		
		
		/// <summary>
		/// Returns a AutTipoMovimiento ActiveRecord object related to this AutMovimiento
		/// 
		/// </summary>
		public DalRis.AutTipoMovimiento AutTipoMovimiento
		{
			get { return DalRis.AutTipoMovimiento.FetchByID(this.IdTipoMovimiento); }
			set { SetColumnValue("idTipoMovimiento", value.IdTipoMovimiento); }
		}
		
		
		/// <summary>
		/// Returns a SysUsuario ActiveRecord object related to this AutMovimiento
		/// 
		/// </summary>
		public DalRis.SysUsuario SysUsuario
		{
			get { return DalRis.SysUsuario.FetchByID(this.IdUsuarioRegistro); }
			set { SetColumnValue("idUsuarioRegistro", value.IdUsuario); }
		}
		
		
		/// <summary>
		/// Returns a AutVehiculo ActiveRecord object related to this AutMovimiento
		/// 
		/// </summary>
		public DalRis.AutVehiculo AutVehiculo
		{
			get { return DalRis.AutVehiculo.FetchByID(this.IdVehiculo); }
			set { SetColumnValue("idVehiculo", value.IdVehiculo); }
		}
		
		
		#endregion
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(DateTime varFechaHoraAltaRegistro,DateTime varFechaHoraRealizacion,decimal varImporte,int varIdVehiculo,int varIdTipoMovimiento,int varIdProveedor,int varIdUsuarioRegistro,DateTime varFechaRegistro,string varDescripcion)
		{
			AutMovimiento item = new AutMovimiento();
			
			item.FechaHoraAltaRegistro = varFechaHoraAltaRegistro;
			
			item.FechaHoraRealizacion = varFechaHoraRealizacion;
			
			item.Importe = varImporte;
			
			item.IdVehiculo = varIdVehiculo;
			
			item.IdTipoMovimiento = varIdTipoMovimiento;
			
			item.IdProveedor = varIdProveedor;
			
			item.IdUsuarioRegistro = varIdUsuarioRegistro;
			
			item.FechaRegistro = varFechaRegistro;
			
			item.Descripcion = varDescripcion;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varIdMovimiento,DateTime varFechaHoraAltaRegistro,DateTime varFechaHoraRealizacion,decimal varImporte,int varIdVehiculo,int varIdTipoMovimiento,int varIdProveedor,int varIdUsuarioRegistro,DateTime varFechaRegistro,string varDescripcion)
		{
			AutMovimiento item = new AutMovimiento();
			
				item.IdMovimiento = varIdMovimiento;
			
				item.FechaHoraAltaRegistro = varFechaHoraAltaRegistro;
			
				item.FechaHoraRealizacion = varFechaHoraRealizacion;
			
				item.Importe = varImporte;
			
				item.IdVehiculo = varIdVehiculo;
			
				item.IdTipoMovimiento = varIdTipoMovimiento;
			
				item.IdProveedor = varIdProveedor;
			
				item.IdUsuarioRegistro = varIdUsuarioRegistro;
			
				item.FechaRegistro = varFechaRegistro;
			
				item.Descripcion = varDescripcion;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn IdMovimientoColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn FechaHoraAltaRegistroColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn FechaHoraRealizacionColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn ImporteColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn IdVehiculoColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn IdTipoMovimientoColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        public static TableSchema.TableColumn IdProveedorColumn
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        public static TableSchema.TableColumn IdUsuarioRegistroColumn
        {
            get { return Schema.Columns[7]; }
        }
        
        
        
        public static TableSchema.TableColumn FechaRegistroColumn
        {
            get { return Schema.Columns[8]; }
        }
        
        
        
        public static TableSchema.TableColumn DescripcionColumn
        {
            get { return Schema.Columns[9]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string IdMovimiento = @"idMovimiento";
			 public static string FechaHoraAltaRegistro = @"fechaHoraAltaRegistro";
			 public static string FechaHoraRealizacion = @"fechaHoraRealizacion";
			 public static string Importe = @"importe";
			 public static string IdVehiculo = @"idVehiculo";
			 public static string IdTipoMovimiento = @"idTipoMovimiento";
			 public static string IdProveedor = @"idProveedor";
			 public static string IdUsuarioRegistro = @"idUsuarioRegistro";
			 public static string FechaRegistro = @"fechaRegistro";
			 public static string Descripcion = @"descripcion";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
