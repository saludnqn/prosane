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
	/// Strongly-typed collection for the AutViaje class.
	/// </summary>
    [Serializable]
	public partial class AutViajeCollection : ActiveList<AutViaje, AutViajeCollection>
	{	   
		public AutViajeCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>AutViajeCollection</returns>
		public AutViajeCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                AutViaje o = this[i];
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
	/// This is an ActiveRecord class which wraps the AUT_Viaje table.
	/// </summary>
	[Serializable]
	public partial class AutViaje : ActiveRecord<AutViaje>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public AutViaje()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public AutViaje(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public AutViaje(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public AutViaje(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("AUT_Viaje", TableType.Table, DataService.GetInstance("RisProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarIdViaje = new TableSchema.TableColumn(schema);
				colvarIdViaje.ColumnName = "idViaje";
				colvarIdViaje.DataType = DbType.Int32;
				colvarIdViaje.MaxLength = 0;
				colvarIdViaje.AutoIncrement = true;
				colvarIdViaje.IsNullable = false;
				colvarIdViaje.IsPrimaryKey = true;
				colvarIdViaje.IsForeignKey = false;
				colvarIdViaje.IsReadOnly = false;
				colvarIdViaje.DefaultSetting = @"";
				colvarIdViaje.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdViaje);
				
				TableSchema.TableColumn colvarFechaInicio = new TableSchema.TableColumn(schema);
				colvarFechaInicio.ColumnName = "fechaInicio";
				colvarFechaInicio.DataType = DbType.DateTime;
				colvarFechaInicio.MaxLength = 0;
				colvarFechaInicio.AutoIncrement = false;
				colvarFechaInicio.IsNullable = false;
				colvarFechaInicio.IsPrimaryKey = false;
				colvarFechaInicio.IsForeignKey = false;
				colvarFechaInicio.IsReadOnly = false;
				colvarFechaInicio.DefaultSetting = @"";
				colvarFechaInicio.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFechaInicio);
				
				TableSchema.TableColumn colvarHoraInicio = new TableSchema.TableColumn(schema);
				colvarHoraInicio.ColumnName = "horaInicio";
				colvarHoraInicio.DataType = DbType.String;
				colvarHoraInicio.MaxLength = 5;
				colvarHoraInicio.AutoIncrement = false;
				colvarHoraInicio.IsNullable = false;
				colvarHoraInicio.IsPrimaryKey = false;
				colvarHoraInicio.IsForeignKey = false;
				colvarHoraInicio.IsReadOnly = false;
				colvarHoraInicio.DefaultSetting = @"";
				colvarHoraInicio.ForeignKeyTableName = "";
				schema.Columns.Add(colvarHoraInicio);
				
				TableSchema.TableColumn colvarFechaFin = new TableSchema.TableColumn(schema);
				colvarFechaFin.ColumnName = "fechaFin";
				colvarFechaFin.DataType = DbType.DateTime;
				colvarFechaFin.MaxLength = 0;
				colvarFechaFin.AutoIncrement = false;
				colvarFechaFin.IsNullable = false;
				colvarFechaFin.IsPrimaryKey = false;
				colvarFechaFin.IsForeignKey = false;
				colvarFechaFin.IsReadOnly = false;
				colvarFechaFin.DefaultSetting = @"";
				colvarFechaFin.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFechaFin);
				
				TableSchema.TableColumn colvarHoraFin = new TableSchema.TableColumn(schema);
				colvarHoraFin.ColumnName = "horaFin";
				colvarHoraFin.DataType = DbType.String;
				colvarHoraFin.MaxLength = 5;
				colvarHoraFin.AutoIncrement = false;
				colvarHoraFin.IsNullable = false;
				colvarHoraFin.IsPrimaryKey = false;
				colvarHoraFin.IsForeignKey = false;
				colvarHoraFin.IsReadOnly = false;
				colvarHoraFin.DefaultSetting = @"";
				colvarHoraFin.ForeignKeyTableName = "";
				schema.Columns.Add(colvarHoraFin);
				
				TableSchema.TableColumn colvarOdometroInicio = new TableSchema.TableColumn(schema);
				colvarOdometroInicio.ColumnName = "odometroInicio";
				colvarOdometroInicio.DataType = DbType.Int32;
				colvarOdometroInicio.MaxLength = 0;
				colvarOdometroInicio.AutoIncrement = false;
				colvarOdometroInicio.IsNullable = false;
				colvarOdometroInicio.IsPrimaryKey = false;
				colvarOdometroInicio.IsForeignKey = false;
				colvarOdometroInicio.IsReadOnly = false;
				colvarOdometroInicio.DefaultSetting = @"";
				colvarOdometroInicio.ForeignKeyTableName = "";
				schema.Columns.Add(colvarOdometroInicio);
				
				TableSchema.TableColumn colvarOdometroFin = new TableSchema.TableColumn(schema);
				colvarOdometroFin.ColumnName = "odometroFin";
				colvarOdometroFin.DataType = DbType.Int32;
				colvarOdometroFin.MaxLength = 0;
				colvarOdometroFin.AutoIncrement = false;
				colvarOdometroFin.IsNullable = false;
				colvarOdometroFin.IsPrimaryKey = false;
				colvarOdometroFin.IsForeignKey = false;
				colvarOdometroFin.IsReadOnly = false;
				colvarOdometroFin.DefaultSetting = @"";
				colvarOdometroFin.ForeignKeyTableName = "";
				schema.Columns.Add(colvarOdometroFin);
				
				TableSchema.TableColumn colvarOrigen = new TableSchema.TableColumn(schema);
				colvarOrigen.ColumnName = "origen";
				colvarOrigen.DataType = DbType.Int32;
				colvarOrigen.MaxLength = 0;
				colvarOrigen.AutoIncrement = false;
				colvarOrigen.IsNullable = false;
				colvarOrigen.IsPrimaryKey = false;
				colvarOrigen.IsForeignKey = false;
				colvarOrigen.IsReadOnly = false;
				colvarOrigen.DefaultSetting = @"";
				colvarOrigen.ForeignKeyTableName = "";
				schema.Columns.Add(colvarOrigen);
				
				TableSchema.TableColumn colvarDestino = new TableSchema.TableColumn(schema);
				colvarDestino.ColumnName = "destino";
				colvarDestino.DataType = DbType.Int32;
				colvarDestino.MaxLength = 0;
				colvarDestino.AutoIncrement = false;
				colvarDestino.IsNullable = false;
				colvarDestino.IsPrimaryKey = false;
				colvarDestino.IsForeignKey = false;
				colvarDestino.IsReadOnly = false;
				colvarDestino.DefaultSetting = @"";
				colvarDestino.ForeignKeyTableName = "";
				schema.Columns.Add(colvarDestino);
				
				TableSchema.TableColumn colvarIdChofer = new TableSchema.TableColumn(schema);
				colvarIdChofer.ColumnName = "idChofer";
				colvarIdChofer.DataType = DbType.Int32;
				colvarIdChofer.MaxLength = 0;
				colvarIdChofer.AutoIncrement = false;
				colvarIdChofer.IsNullable = false;
				colvarIdChofer.IsPrimaryKey = false;
				colvarIdChofer.IsForeignKey = false;
				colvarIdChofer.IsReadOnly = false;
				colvarIdChofer.DefaultSetting = @"";
				colvarIdChofer.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdChofer);
				
				TableSchema.TableColumn colvarIdVehiculo = new TableSchema.TableColumn(schema);
				colvarIdVehiculo.ColumnName = "idVehiculo";
				colvarIdVehiculo.DataType = DbType.Int32;
				colvarIdVehiculo.MaxLength = 0;
				colvarIdVehiculo.AutoIncrement = false;
				colvarIdVehiculo.IsNullable = false;
				colvarIdVehiculo.IsPrimaryKey = false;
				colvarIdVehiculo.IsForeignKey = false;
				colvarIdVehiculo.IsReadOnly = false;
				colvarIdVehiculo.DefaultSetting = @"";
				colvarIdVehiculo.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdVehiculo);
				
				TableSchema.TableColumn colvarIdUsuarioRegistro = new TableSchema.TableColumn(schema);
				colvarIdUsuarioRegistro.ColumnName = "idUsuarioRegistro";
				colvarIdUsuarioRegistro.DataType = DbType.Int32;
				colvarIdUsuarioRegistro.MaxLength = 0;
				colvarIdUsuarioRegistro.AutoIncrement = false;
				colvarIdUsuarioRegistro.IsNullable = false;
				colvarIdUsuarioRegistro.IsPrimaryKey = false;
				colvarIdUsuarioRegistro.IsForeignKey = false;
				colvarIdUsuarioRegistro.IsReadOnly = false;
				colvarIdUsuarioRegistro.DefaultSetting = @"";
				colvarIdUsuarioRegistro.ForeignKeyTableName = "";
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
				
				TableSchema.TableColumn colvarObservaciones = new TableSchema.TableColumn(schema);
				colvarObservaciones.ColumnName = "observaciones";
				colvarObservaciones.DataType = DbType.String;
				colvarObservaciones.MaxLength = 500;
				colvarObservaciones.AutoIncrement = false;
				colvarObservaciones.IsNullable = true;
				colvarObservaciones.IsPrimaryKey = false;
				colvarObservaciones.IsForeignKey = false;
				colvarObservaciones.IsReadOnly = false;
				colvarObservaciones.DefaultSetting = @"";
				colvarObservaciones.ForeignKeyTableName = "";
				schema.Columns.Add(colvarObservaciones);
				
				TableSchema.TableColumn colvarIdTipoViaje = new TableSchema.TableColumn(schema);
				colvarIdTipoViaje.ColumnName = "idTipoViaje";
				colvarIdTipoViaje.DataType = DbType.Int32;
				colvarIdTipoViaje.MaxLength = 0;
				colvarIdTipoViaje.AutoIncrement = false;
				colvarIdTipoViaje.IsNullable = true;
				colvarIdTipoViaje.IsPrimaryKey = false;
				colvarIdTipoViaje.IsForeignKey = false;
				colvarIdTipoViaje.IsReadOnly = false;
				colvarIdTipoViaje.DefaultSetting = @"";
				colvarIdTipoViaje.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdTipoViaje);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["RisProvider"].AddSchema("AUT_Viaje",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("IdViaje")]
		[Bindable(true)]
		public int IdViaje 
		{
			get { return GetColumnValue<int>(Columns.IdViaje); }
			set { SetColumnValue(Columns.IdViaje, value); }
		}
		  
		[XmlAttribute("FechaInicio")]
		[Bindable(true)]
		public DateTime FechaInicio 
		{
			get { return GetColumnValue<DateTime>(Columns.FechaInicio); }
			set { SetColumnValue(Columns.FechaInicio, value); }
		}
		  
		[XmlAttribute("HoraInicio")]
		[Bindable(true)]
		public string HoraInicio 
		{
			get { return GetColumnValue<string>(Columns.HoraInicio); }
			set { SetColumnValue(Columns.HoraInicio, value); }
		}
		  
		[XmlAttribute("FechaFin")]
		[Bindable(true)]
		public DateTime FechaFin 
		{
			get { return GetColumnValue<DateTime>(Columns.FechaFin); }
			set { SetColumnValue(Columns.FechaFin, value); }
		}
		  
		[XmlAttribute("HoraFin")]
		[Bindable(true)]
		public string HoraFin 
		{
			get { return GetColumnValue<string>(Columns.HoraFin); }
			set { SetColumnValue(Columns.HoraFin, value); }
		}
		  
		[XmlAttribute("OdometroInicio")]
		[Bindable(true)]
		public int OdometroInicio 
		{
			get { return GetColumnValue<int>(Columns.OdometroInicio); }
			set { SetColumnValue(Columns.OdometroInicio, value); }
		}
		  
		[XmlAttribute("OdometroFin")]
		[Bindable(true)]
		public int OdometroFin 
		{
			get { return GetColumnValue<int>(Columns.OdometroFin); }
			set { SetColumnValue(Columns.OdometroFin, value); }
		}
		  
		[XmlAttribute("Origen")]
		[Bindable(true)]
		public int Origen 
		{
			get { return GetColumnValue<int>(Columns.Origen); }
			set { SetColumnValue(Columns.Origen, value); }
		}
		  
		[XmlAttribute("Destino")]
		[Bindable(true)]
		public int Destino 
		{
			get { return GetColumnValue<int>(Columns.Destino); }
			set { SetColumnValue(Columns.Destino, value); }
		}
		  
		[XmlAttribute("IdChofer")]
		[Bindable(true)]
		public int IdChofer 
		{
			get { return GetColumnValue<int>(Columns.IdChofer); }
			set { SetColumnValue(Columns.IdChofer, value); }
		}
		  
		[XmlAttribute("IdVehiculo")]
		[Bindable(true)]
		public int IdVehiculo 
		{
			get { return GetColumnValue<int>(Columns.IdVehiculo); }
			set { SetColumnValue(Columns.IdVehiculo, value); }
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
		  
		[XmlAttribute("Observaciones")]
		[Bindable(true)]
		public string Observaciones 
		{
			get { return GetColumnValue<string>(Columns.Observaciones); }
			set { SetColumnValue(Columns.Observaciones, value); }
		}
		  
		[XmlAttribute("IdTipoViaje")]
		[Bindable(true)]
		public int? IdTipoViaje 
		{
			get { return GetColumnValue<int?>(Columns.IdTipoViaje); }
			set { SetColumnValue(Columns.IdTipoViaje, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(DateTime varFechaInicio,string varHoraInicio,DateTime varFechaFin,string varHoraFin,int varOdometroInicio,int varOdometroFin,int varOrigen,int varDestino,int varIdChofer,int varIdVehiculo,int varIdUsuarioRegistro,DateTime varFechaRegistro,string varObservaciones,int? varIdTipoViaje)
		{
			AutViaje item = new AutViaje();
			
			item.FechaInicio = varFechaInicio;
			
			item.HoraInicio = varHoraInicio;
			
			item.FechaFin = varFechaFin;
			
			item.HoraFin = varHoraFin;
			
			item.OdometroInicio = varOdometroInicio;
			
			item.OdometroFin = varOdometroFin;
			
			item.Origen = varOrigen;
			
			item.Destino = varDestino;
			
			item.IdChofer = varIdChofer;
			
			item.IdVehiculo = varIdVehiculo;
			
			item.IdUsuarioRegistro = varIdUsuarioRegistro;
			
			item.FechaRegistro = varFechaRegistro;
			
			item.Observaciones = varObservaciones;
			
			item.IdTipoViaje = varIdTipoViaje;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varIdViaje,DateTime varFechaInicio,string varHoraInicio,DateTime varFechaFin,string varHoraFin,int varOdometroInicio,int varOdometroFin,int varOrigen,int varDestino,int varIdChofer,int varIdVehiculo,int varIdUsuarioRegistro,DateTime varFechaRegistro,string varObservaciones,int? varIdTipoViaje)
		{
			AutViaje item = new AutViaje();
			
				item.IdViaje = varIdViaje;
			
				item.FechaInicio = varFechaInicio;
			
				item.HoraInicio = varHoraInicio;
			
				item.FechaFin = varFechaFin;
			
				item.HoraFin = varHoraFin;
			
				item.OdometroInicio = varOdometroInicio;
			
				item.OdometroFin = varOdometroFin;
			
				item.Origen = varOrigen;
			
				item.Destino = varDestino;
			
				item.IdChofer = varIdChofer;
			
				item.IdVehiculo = varIdVehiculo;
			
				item.IdUsuarioRegistro = varIdUsuarioRegistro;
			
				item.FechaRegistro = varFechaRegistro;
			
				item.Observaciones = varObservaciones;
			
				item.IdTipoViaje = varIdTipoViaje;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn IdViajeColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn FechaInicioColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn HoraInicioColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn FechaFinColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn HoraFinColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn OdometroInicioColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        public static TableSchema.TableColumn OdometroFinColumn
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        public static TableSchema.TableColumn OrigenColumn
        {
            get { return Schema.Columns[7]; }
        }
        
        
        
        public static TableSchema.TableColumn DestinoColumn
        {
            get { return Schema.Columns[8]; }
        }
        
        
        
        public static TableSchema.TableColumn IdChoferColumn
        {
            get { return Schema.Columns[9]; }
        }
        
        
        
        public static TableSchema.TableColumn IdVehiculoColumn
        {
            get { return Schema.Columns[10]; }
        }
        
        
        
        public static TableSchema.TableColumn IdUsuarioRegistroColumn
        {
            get { return Schema.Columns[11]; }
        }
        
        
        
        public static TableSchema.TableColumn FechaRegistroColumn
        {
            get { return Schema.Columns[12]; }
        }
        
        
        
        public static TableSchema.TableColumn ObservacionesColumn
        {
            get { return Schema.Columns[13]; }
        }
        
        
        
        public static TableSchema.TableColumn IdTipoViajeColumn
        {
            get { return Schema.Columns[14]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string IdViaje = @"idViaje";
			 public static string FechaInicio = @"fechaInicio";
			 public static string HoraInicio = @"horaInicio";
			 public static string FechaFin = @"fechaFin";
			 public static string HoraFin = @"horaFin";
			 public static string OdometroInicio = @"odometroInicio";
			 public static string OdometroFin = @"odometroFin";
			 public static string Origen = @"origen";
			 public static string Destino = @"destino";
			 public static string IdChofer = @"idChofer";
			 public static string IdVehiculo = @"idVehiculo";
			 public static string IdUsuarioRegistro = @"idUsuarioRegistro";
			 public static string FechaRegistro = @"fechaRegistro";
			 public static string Observaciones = @"observaciones";
			 public static string IdTipoViaje = @"idTipoViaje";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
