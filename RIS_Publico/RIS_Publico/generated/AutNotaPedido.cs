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
	/// Strongly-typed collection for the AutNotaPedido class.
	/// </summary>
    [Serializable]
	public partial class AutNotaPedidoCollection : ActiveList<AutNotaPedido, AutNotaPedidoCollection>
	{	   
		public AutNotaPedidoCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>AutNotaPedidoCollection</returns>
		public AutNotaPedidoCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                AutNotaPedido o = this[i];
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
	/// This is an ActiveRecord class which wraps the Aut_NotaPedido table.
	/// </summary>
	[Serializable]
	public partial class AutNotaPedido : ActiveRecord<AutNotaPedido>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public AutNotaPedido()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public AutNotaPedido(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public AutNotaPedido(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public AutNotaPedido(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("Aut_NotaPedido", TableType.Table, DataService.GetInstance("RisProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
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
				
				TableSchema.TableColumn colvarIdEntidad = new TableSchema.TableColumn(schema);
				colvarIdEntidad.ColumnName = "idEntidad";
				colvarIdEntidad.DataType = DbType.Decimal;
				colvarIdEntidad.MaxLength = 0;
				colvarIdEntidad.AutoIncrement = false;
				colvarIdEntidad.IsNullable = true;
				colvarIdEntidad.IsPrimaryKey = false;
				colvarIdEntidad.IsForeignKey = false;
				colvarIdEntidad.IsReadOnly = false;
				colvarIdEntidad.DefaultSetting = @"";
				colvarIdEntidad.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdEntidad);
				
				TableSchema.TableColumn colvarIdZona = new TableSchema.TableColumn(schema);
				colvarIdZona.ColumnName = "idZona";
				colvarIdZona.DataType = DbType.Decimal;
				colvarIdZona.MaxLength = 0;
				colvarIdZona.AutoIncrement = false;
				colvarIdZona.IsNullable = true;
				colvarIdZona.IsPrimaryKey = false;
				colvarIdZona.IsForeignKey = false;
				colvarIdZona.IsReadOnly = false;
				colvarIdZona.DefaultSetting = @"";
				colvarIdZona.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdZona);
				
				TableSchema.TableColumn colvarIdNotaPedido = new TableSchema.TableColumn(schema);
				colvarIdNotaPedido.ColumnName = "idNotaPedido";
				colvarIdNotaPedido.DataType = DbType.Decimal;
				colvarIdNotaPedido.MaxLength = 0;
				colvarIdNotaPedido.AutoIncrement = true;
				colvarIdNotaPedido.IsNullable = false;
				colvarIdNotaPedido.IsPrimaryKey = true;
				colvarIdNotaPedido.IsForeignKey = false;
				colvarIdNotaPedido.IsReadOnly = false;
				colvarIdNotaPedido.DefaultSetting = @"";
				colvarIdNotaPedido.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdNotaPedido);
				
				TableSchema.TableColumn colvarFirmante = new TableSchema.TableColumn(schema);
				colvarFirmante.ColumnName = "Firmante";
				colvarFirmante.DataType = DbType.String;
				colvarFirmante.MaxLength = 50;
				colvarFirmante.AutoIncrement = false;
				colvarFirmante.IsNullable = true;
				colvarFirmante.IsPrimaryKey = false;
				colvarFirmante.IsForeignKey = false;
				colvarFirmante.IsReadOnly = false;
				colvarFirmante.DefaultSetting = @"";
				colvarFirmante.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFirmante);
				
				TableSchema.TableColumn colvarIdVehiculo = new TableSchema.TableColumn(schema);
				colvarIdVehiculo.ColumnName = "idVehiculo";
				colvarIdVehiculo.DataType = DbType.Decimal;
				colvarIdVehiculo.MaxLength = 0;
				colvarIdVehiculo.AutoIncrement = false;
				colvarIdVehiculo.IsNullable = false;
				colvarIdVehiculo.IsPrimaryKey = false;
				colvarIdVehiculo.IsForeignKey = false;
				colvarIdVehiculo.IsReadOnly = false;
				colvarIdVehiculo.DefaultSetting = @"";
				colvarIdVehiculo.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdVehiculo);
				
				TableSchema.TableColumn colvarDominio = new TableSchema.TableColumn(schema);
				colvarDominio.ColumnName = "Dominio";
				colvarDominio.DataType = DbType.String;
				colvarDominio.MaxLength = 10;
				colvarDominio.AutoIncrement = false;
				colvarDominio.IsNullable = true;
				colvarDominio.IsPrimaryKey = false;
				colvarDominio.IsForeignKey = false;
				colvarDominio.IsReadOnly = false;
				colvarDominio.DefaultSetting = @"";
				colvarDominio.ForeignKeyTableName = "";
				schema.Columns.Add(colvarDominio);
				
				TableSchema.TableColumn colvarTipoSolicitud = new TableSchema.TableColumn(schema);
				colvarTipoSolicitud.ColumnName = "TipoSolicitud";
				colvarTipoSolicitud.DataType = DbType.String;
				colvarTipoSolicitud.MaxLength = 30;
				colvarTipoSolicitud.AutoIncrement = false;
				colvarTipoSolicitud.IsNullable = true;
				colvarTipoSolicitud.IsPrimaryKey = false;
				colvarTipoSolicitud.IsForeignKey = false;
				colvarTipoSolicitud.IsReadOnly = false;
				colvarTipoSolicitud.DefaultSetting = @"";
				colvarTipoSolicitud.ForeignKeyTableName = "";
				schema.Columns.Add(colvarTipoSolicitud);
				
				TableSchema.TableColumn colvarExpediente = new TableSchema.TableColumn(schema);
				colvarExpediente.ColumnName = "Expediente";
				colvarExpediente.DataType = DbType.String;
				colvarExpediente.MaxLength = 50;
				colvarExpediente.AutoIncrement = false;
				colvarExpediente.IsNullable = true;
				colvarExpediente.IsPrimaryKey = false;
				colvarExpediente.IsForeignKey = false;
				colvarExpediente.IsReadOnly = false;
				colvarExpediente.DefaultSetting = @"";
				colvarExpediente.ForeignKeyTableName = "";
				schema.Columns.Add(colvarExpediente);
				
				TableSchema.TableColumn colvarDetalle = new TableSchema.TableColumn(schema);
				colvarDetalle.ColumnName = "Detalle";
				colvarDetalle.DataType = DbType.AnsiString;
				colvarDetalle.MaxLength = 2147483647;
				colvarDetalle.AutoIncrement = false;
				colvarDetalle.IsNullable = true;
				colvarDetalle.IsPrimaryKey = false;
				colvarDetalle.IsForeignKey = false;
				colvarDetalle.IsReadOnly = false;
				colvarDetalle.DefaultSetting = @"";
				colvarDetalle.ForeignKeyTableName = "";
				schema.Columns.Add(colvarDetalle);
				
				TableSchema.TableColumn colvarIdOrdenReparacion = new TableSchema.TableColumn(schema);
				colvarIdOrdenReparacion.ColumnName = "idOrdenReparacion";
				colvarIdOrdenReparacion.DataType = DbType.Decimal;
				colvarIdOrdenReparacion.MaxLength = 0;
				colvarIdOrdenReparacion.AutoIncrement = false;
				colvarIdOrdenReparacion.IsNullable = true;
				colvarIdOrdenReparacion.IsPrimaryKey = false;
				colvarIdOrdenReparacion.IsForeignKey = false;
				colvarIdOrdenReparacion.IsReadOnly = false;
				colvarIdOrdenReparacion.DefaultSetting = @"";
				colvarIdOrdenReparacion.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdOrdenReparacion);
				
				TableSchema.TableColumn colvarObsevacion = new TableSchema.TableColumn(schema);
				colvarObsevacion.ColumnName = "Obsevacion";
				colvarObsevacion.DataType = DbType.String;
				colvarObsevacion.MaxLength = 100;
				colvarObsevacion.AutoIncrement = false;
				colvarObsevacion.IsNullable = true;
				colvarObsevacion.IsPrimaryKey = false;
				colvarObsevacion.IsForeignKey = false;
				colvarObsevacion.IsReadOnly = false;
				colvarObsevacion.DefaultSetting = @"";
				colvarObsevacion.ForeignKeyTableName = "";
				schema.Columns.Add(colvarObsevacion);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["RisProvider"].AddSchema("Aut_NotaPedido",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("Fecha")]
		[Bindable(true)]
		public DateTime? Fecha 
		{
			get { return GetColumnValue<DateTime?>(Columns.Fecha); }
			set { SetColumnValue(Columns.Fecha, value); }
		}
		  
		[XmlAttribute("IdEntidad")]
		[Bindable(true)]
		public decimal? IdEntidad 
		{
			get { return GetColumnValue<decimal?>(Columns.IdEntidad); }
			set { SetColumnValue(Columns.IdEntidad, value); }
		}
		  
		[XmlAttribute("IdZona")]
		[Bindable(true)]
		public decimal? IdZona 
		{
			get { return GetColumnValue<decimal?>(Columns.IdZona); }
			set { SetColumnValue(Columns.IdZona, value); }
		}
		  
		[XmlAttribute("IdNotaPedido")]
		[Bindable(true)]
		public decimal IdNotaPedido 
		{
			get { return GetColumnValue<decimal>(Columns.IdNotaPedido); }
			set { SetColumnValue(Columns.IdNotaPedido, value); }
		}
		  
		[XmlAttribute("Firmante")]
		[Bindable(true)]
		public string Firmante 
		{
			get { return GetColumnValue<string>(Columns.Firmante); }
			set { SetColumnValue(Columns.Firmante, value); }
		}
		  
		[XmlAttribute("IdVehiculo")]
		[Bindable(true)]
		public decimal IdVehiculo 
		{
			get { return GetColumnValue<decimal>(Columns.IdVehiculo); }
			set { SetColumnValue(Columns.IdVehiculo, value); }
		}
		  
		[XmlAttribute("Dominio")]
		[Bindable(true)]
		public string Dominio 
		{
			get { return GetColumnValue<string>(Columns.Dominio); }
			set { SetColumnValue(Columns.Dominio, value); }
		}
		  
		[XmlAttribute("TipoSolicitud")]
		[Bindable(true)]
		public string TipoSolicitud 
		{
			get { return GetColumnValue<string>(Columns.TipoSolicitud); }
			set { SetColumnValue(Columns.TipoSolicitud, value); }
		}
		  
		[XmlAttribute("Expediente")]
		[Bindable(true)]
		public string Expediente 
		{
			get { return GetColumnValue<string>(Columns.Expediente); }
			set { SetColumnValue(Columns.Expediente, value); }
		}
		  
		[XmlAttribute("Detalle")]
		[Bindable(true)]
		public string Detalle 
		{
			get { return GetColumnValue<string>(Columns.Detalle); }
			set { SetColumnValue(Columns.Detalle, value); }
		}
		  
		[XmlAttribute("IdOrdenReparacion")]
		[Bindable(true)]
		public decimal? IdOrdenReparacion 
		{
			get { return GetColumnValue<decimal?>(Columns.IdOrdenReparacion); }
			set { SetColumnValue(Columns.IdOrdenReparacion, value); }
		}
		  
		[XmlAttribute("Obsevacion")]
		[Bindable(true)]
		public string Obsevacion 
		{
			get { return GetColumnValue<string>(Columns.Obsevacion); }
			set { SetColumnValue(Columns.Obsevacion, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(DateTime? varFecha,decimal? varIdEntidad,decimal? varIdZona,string varFirmante,decimal varIdVehiculo,string varDominio,string varTipoSolicitud,string varExpediente,string varDetalle,decimal? varIdOrdenReparacion,string varObsevacion)
		{
			AutNotaPedido item = new AutNotaPedido();
			
			item.Fecha = varFecha;
			
			item.IdEntidad = varIdEntidad;
			
			item.IdZona = varIdZona;
			
			item.Firmante = varFirmante;
			
			item.IdVehiculo = varIdVehiculo;
			
			item.Dominio = varDominio;
			
			item.TipoSolicitud = varTipoSolicitud;
			
			item.Expediente = varExpediente;
			
			item.Detalle = varDetalle;
			
			item.IdOrdenReparacion = varIdOrdenReparacion;
			
			item.Obsevacion = varObsevacion;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(DateTime? varFecha,decimal? varIdEntidad,decimal? varIdZona,decimal varIdNotaPedido,string varFirmante,decimal varIdVehiculo,string varDominio,string varTipoSolicitud,string varExpediente,string varDetalle,decimal? varIdOrdenReparacion,string varObsevacion)
		{
			AutNotaPedido item = new AutNotaPedido();
			
				item.Fecha = varFecha;
			
				item.IdEntidad = varIdEntidad;
			
				item.IdZona = varIdZona;
			
				item.IdNotaPedido = varIdNotaPedido;
			
				item.Firmante = varFirmante;
			
				item.IdVehiculo = varIdVehiculo;
			
				item.Dominio = varDominio;
			
				item.TipoSolicitud = varTipoSolicitud;
			
				item.Expediente = varExpediente;
			
				item.Detalle = varDetalle;
			
				item.IdOrdenReparacion = varIdOrdenReparacion;
			
				item.Obsevacion = varObsevacion;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn FechaColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn IdEntidadColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn IdZonaColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn IdNotaPedidoColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn FirmanteColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn IdVehiculoColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        public static TableSchema.TableColumn DominioColumn
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        public static TableSchema.TableColumn TipoSolicitudColumn
        {
            get { return Schema.Columns[7]; }
        }
        
        
        
        public static TableSchema.TableColumn ExpedienteColumn
        {
            get { return Schema.Columns[8]; }
        }
        
        
        
        public static TableSchema.TableColumn DetalleColumn
        {
            get { return Schema.Columns[9]; }
        }
        
        
        
        public static TableSchema.TableColumn IdOrdenReparacionColumn
        {
            get { return Schema.Columns[10]; }
        }
        
        
        
        public static TableSchema.TableColumn ObsevacionColumn
        {
            get { return Schema.Columns[11]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string Fecha = @"Fecha";
			 public static string IdEntidad = @"idEntidad";
			 public static string IdZona = @"idZona";
			 public static string IdNotaPedido = @"idNotaPedido";
			 public static string Firmante = @"Firmante";
			 public static string IdVehiculo = @"idVehiculo";
			 public static string Dominio = @"Dominio";
			 public static string TipoSolicitud = @"TipoSolicitud";
			 public static string Expediente = @"Expediente";
			 public static string Detalle = @"Detalle";
			 public static string IdOrdenReparacion = @"idOrdenReparacion";
			 public static string Obsevacion = @"Obsevacion";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
