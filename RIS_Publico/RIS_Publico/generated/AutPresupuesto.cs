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
	/// Strongly-typed collection for the AutPresupuesto class.
	/// </summary>
    [Serializable]
	public partial class AutPresupuestoCollection : ActiveList<AutPresupuesto, AutPresupuestoCollection>
	{	   
		public AutPresupuestoCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>AutPresupuestoCollection</returns>
		public AutPresupuestoCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                AutPresupuesto o = this[i];
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
	/// This is an ActiveRecord class which wraps the Aut_Presupuesto table.
	/// </summary>
	[Serializable]
	public partial class AutPresupuesto : ActiveRecord<AutPresupuesto>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public AutPresupuesto()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public AutPresupuesto(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public AutPresupuesto(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public AutPresupuesto(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("Aut_Presupuesto", TableType.Table, DataService.GetInstance("RisProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarIdPresupuesto = new TableSchema.TableColumn(schema);
				colvarIdPresupuesto.ColumnName = "idPresupuesto";
				colvarIdPresupuesto.DataType = DbType.Decimal;
				colvarIdPresupuesto.MaxLength = 0;
				colvarIdPresupuesto.AutoIncrement = false;
				colvarIdPresupuesto.IsNullable = false;
				colvarIdPresupuesto.IsPrimaryKey = true;
				colvarIdPresupuesto.IsForeignKey = false;
				colvarIdPresupuesto.IsReadOnly = false;
				colvarIdPresupuesto.DefaultSetting = @"";
				colvarIdPresupuesto.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdPresupuesto);
				
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
				
				TableSchema.TableColumn colvarTotal = new TableSchema.TableColumn(schema);
				colvarTotal.ColumnName = "Total";
				colvarTotal.DataType = DbType.Decimal;
				colvarTotal.MaxLength = 0;
				colvarTotal.AutoIncrement = false;
				colvarTotal.IsNullable = true;
				colvarTotal.IsPrimaryKey = false;
				colvarTotal.IsForeignKey = false;
				colvarTotal.IsReadOnly = false;
				colvarTotal.DefaultSetting = @"";
				colvarTotal.ForeignKeyTableName = "";
				schema.Columns.Add(colvarTotal);
				
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
				
				TableSchema.TableColumn colvarTiempoEntrega = new TableSchema.TableColumn(schema);
				colvarTiempoEntrega.ColumnName = "TiempoEntrega";
				colvarTiempoEntrega.DataType = DbType.AnsiString;
				colvarTiempoEntrega.MaxLength = 2147483647;
				colvarTiempoEntrega.AutoIncrement = false;
				colvarTiempoEntrega.IsNullable = true;
				colvarTiempoEntrega.IsPrimaryKey = false;
				colvarTiempoEntrega.IsForeignKey = false;
				colvarTiempoEntrega.IsReadOnly = false;
				colvarTiempoEntrega.DefaultSetting = @"";
				colvarTiempoEntrega.ForeignKeyTableName = "";
				schema.Columns.Add(colvarTiempoEntrega);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["RisProvider"].AddSchema("Aut_Presupuesto",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("IdPresupuesto")]
		[Bindable(true)]
		public decimal IdPresupuesto 
		{
			get { return GetColumnValue<decimal>(Columns.IdPresupuesto); }
			set { SetColumnValue(Columns.IdPresupuesto, value); }
		}
		  
		[XmlAttribute("IdProveedor")]
		[Bindable(true)]
		public decimal? IdProveedor 
		{
			get { return GetColumnValue<decimal?>(Columns.IdProveedor); }
			set { SetColumnValue(Columns.IdProveedor, value); }
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
		  
		[XmlAttribute("IdNotaPedido")]
		[Bindable(true)]
		public decimal? IdNotaPedido 
		{
			get { return GetColumnValue<decimal?>(Columns.IdNotaPedido); }
			set { SetColumnValue(Columns.IdNotaPedido, value); }
		}
		  
		[XmlAttribute("Total")]
		[Bindable(true)]
		public decimal? Total 
		{
			get { return GetColumnValue<decimal?>(Columns.Total); }
			set { SetColumnValue(Columns.Total, value); }
		}
		  
		[XmlAttribute("Observaciones")]
		[Bindable(true)]
		public string Observaciones 
		{
			get { return GetColumnValue<string>(Columns.Observaciones); }
			set { SetColumnValue(Columns.Observaciones, value); }
		}
		  
		[XmlAttribute("TiempoEntrega")]
		[Bindable(true)]
		public string TiempoEntrega 
		{
			get { return GetColumnValue<string>(Columns.TiempoEntrega); }
			set { SetColumnValue(Columns.TiempoEntrega, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(decimal varIdPresupuesto,decimal? varIdProveedor,DateTime? varFecha,decimal? varIdVehiculo,decimal? varIdNotaPedido,decimal? varTotal,string varObservaciones,string varTiempoEntrega)
		{
			AutPresupuesto item = new AutPresupuesto();
			
			item.IdPresupuesto = varIdPresupuesto;
			
			item.IdProveedor = varIdProveedor;
			
			item.Fecha = varFecha;
			
			item.IdVehiculo = varIdVehiculo;
			
			item.IdNotaPedido = varIdNotaPedido;
			
			item.Total = varTotal;
			
			item.Observaciones = varObservaciones;
			
			item.TiempoEntrega = varTiempoEntrega;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(decimal varIdPresupuesto,decimal? varIdProveedor,DateTime? varFecha,decimal? varIdVehiculo,decimal? varIdNotaPedido,decimal? varTotal,string varObservaciones,string varTiempoEntrega)
		{
			AutPresupuesto item = new AutPresupuesto();
			
				item.IdPresupuesto = varIdPresupuesto;
			
				item.IdProveedor = varIdProveedor;
			
				item.Fecha = varFecha;
			
				item.IdVehiculo = varIdVehiculo;
			
				item.IdNotaPedido = varIdNotaPedido;
			
				item.Total = varTotal;
			
				item.Observaciones = varObservaciones;
			
				item.TiempoEntrega = varTiempoEntrega;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn IdPresupuestoColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn IdProveedorColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn FechaColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn IdVehiculoColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn IdNotaPedidoColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn TotalColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        public static TableSchema.TableColumn ObservacionesColumn
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        public static TableSchema.TableColumn TiempoEntregaColumn
        {
            get { return Schema.Columns[7]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string IdPresupuesto = @"idPresupuesto";
			 public static string IdProveedor = @"idProveedor";
			 public static string Fecha = @"Fecha";
			 public static string IdVehiculo = @"idVehiculo";
			 public static string IdNotaPedido = @"idNotaPedido";
			 public static string Total = @"Total";
			 public static string Observaciones = @"Observaciones";
			 public static string TiempoEntrega = @"TiempoEntrega";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
