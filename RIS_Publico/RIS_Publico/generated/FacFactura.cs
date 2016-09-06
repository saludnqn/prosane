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
	/// Strongly-typed collection for the FacFactura class.
	/// </summary>
    [Serializable]
	public partial class FacFacturaCollection : ActiveList<FacFactura, FacFacturaCollection>
	{	   
		public FacFacturaCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>FacFacturaCollection</returns>
		public FacFacturaCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                FacFactura o = this[i];
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
	/// This is an ActiveRecord class which wraps the FAC_Factura table.
	/// </summary>
	[Serializable]
	public partial class FacFactura : ActiveRecord<FacFactura>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public FacFactura()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public FacFactura(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public FacFactura(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public FacFactura(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("FAC_Factura", TableType.Table, DataService.GetInstance("RisProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarIdFactura = new TableSchema.TableColumn(schema);
				colvarIdFactura.ColumnName = "idFactura";
				colvarIdFactura.DataType = DbType.Int32;
				colvarIdFactura.MaxLength = 0;
				colvarIdFactura.AutoIncrement = true;
				colvarIdFactura.IsNullable = false;
				colvarIdFactura.IsPrimaryKey = true;
				colvarIdFactura.IsForeignKey = false;
				colvarIdFactura.IsReadOnly = false;
				colvarIdFactura.DefaultSetting = @"";
				colvarIdFactura.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdFactura);
				
				TableSchema.TableColumn colvarIdEfector = new TableSchema.TableColumn(schema);
				colvarIdEfector.ColumnName = "idEfector";
				colvarIdEfector.DataType = DbType.Int32;
				colvarIdEfector.MaxLength = 0;
				colvarIdEfector.AutoIncrement = false;
				colvarIdEfector.IsNullable = false;
				colvarIdEfector.IsPrimaryKey = false;
				colvarIdEfector.IsForeignKey = false;
				colvarIdEfector.IsReadOnly = false;
				colvarIdEfector.DefaultSetting = @"";
				colvarIdEfector.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdEfector);
				
				TableSchema.TableColumn colvarIdObraSocial = new TableSchema.TableColumn(schema);
				colvarIdObraSocial.ColumnName = "idObraSocial";
				colvarIdObraSocial.DataType = DbType.Int32;
				colvarIdObraSocial.MaxLength = 0;
				colvarIdObraSocial.AutoIncrement = false;
				colvarIdObraSocial.IsNullable = false;
				colvarIdObraSocial.IsPrimaryKey = false;
				colvarIdObraSocial.IsForeignKey = false;
				colvarIdObraSocial.IsReadOnly = false;
				colvarIdObraSocial.DefaultSetting = @"";
				colvarIdObraSocial.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdObraSocial);
				
				TableSchema.TableColumn colvarNumero = new TableSchema.TableColumn(schema);
				colvarNumero.ColumnName = "numero";
				colvarNumero.DataType = DbType.AnsiString;
				colvarNumero.MaxLength = 50;
				colvarNumero.AutoIncrement = false;
				colvarNumero.IsNullable = false;
				colvarNumero.IsPrimaryKey = false;
				colvarNumero.IsForeignKey = false;
				colvarNumero.IsReadOnly = false;
				colvarNumero.DefaultSetting = @"";
				colvarNumero.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNumero);
				
				TableSchema.TableColumn colvarFecha = new TableSchema.TableColumn(schema);
				colvarFecha.ColumnName = "fecha";
				colvarFecha.DataType = DbType.DateTime;
				colvarFecha.MaxLength = 0;
				colvarFecha.AutoIncrement = false;
				colvarFecha.IsNullable = false;
				colvarFecha.IsPrimaryKey = false;
				colvarFecha.IsForeignKey = false;
				colvarFecha.IsReadOnly = false;
				
						colvarFecha.DefaultSetting = @"(((1)/(1))/(1900))";
				colvarFecha.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFecha);
				
				TableSchema.TableColumn colvarPeriodo = new TableSchema.TableColumn(schema);
				colvarPeriodo.ColumnName = "periodo";
				colvarPeriodo.DataType = DbType.AnsiStringFixedLength;
				colvarPeriodo.MaxLength = 7;
				colvarPeriodo.AutoIncrement = false;
				colvarPeriodo.IsNullable = false;
				colvarPeriodo.IsPrimaryKey = false;
				colvarPeriodo.IsForeignKey = false;
				colvarPeriodo.IsReadOnly = false;
				
						colvarPeriodo.DefaultSetting = @"('')";
				colvarPeriodo.ForeignKeyTableName = "";
				schema.Columns.Add(colvarPeriodo);
				
				TableSchema.TableColumn colvarObservaciones = new TableSchema.TableColumn(schema);
				colvarObservaciones.ColumnName = "observaciones";
				colvarObservaciones.DataType = DbType.AnsiString;
				colvarObservaciones.MaxLength = 500;
				colvarObservaciones.AutoIncrement = false;
				colvarObservaciones.IsNullable = false;
				colvarObservaciones.IsPrimaryKey = false;
				colvarObservaciones.IsForeignKey = false;
				colvarObservaciones.IsReadOnly = false;
				
						colvarObservaciones.DefaultSetting = @"('')";
				colvarObservaciones.ForeignKeyTableName = "";
				schema.Columns.Add(colvarObservaciones);
				
				TableSchema.TableColumn colvarSubTotal = new TableSchema.TableColumn(schema);
				colvarSubTotal.ColumnName = "subTotal";
				colvarSubTotal.DataType = DbType.Decimal;
				colvarSubTotal.MaxLength = 0;
				colvarSubTotal.AutoIncrement = false;
				colvarSubTotal.IsNullable = false;
				colvarSubTotal.IsPrimaryKey = false;
				colvarSubTotal.IsForeignKey = false;
				colvarSubTotal.IsReadOnly = false;
				
						colvarSubTotal.DefaultSetting = @"((0))";
				colvarSubTotal.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSubTotal);
				
				TableSchema.TableColumn colvarDescuento = new TableSchema.TableColumn(schema);
				colvarDescuento.ColumnName = "descuento";
				colvarDescuento.DataType = DbType.Decimal;
				colvarDescuento.MaxLength = 0;
				colvarDescuento.AutoIncrement = false;
				colvarDescuento.IsNullable = false;
				colvarDescuento.IsPrimaryKey = false;
				colvarDescuento.IsForeignKey = false;
				colvarDescuento.IsReadOnly = false;
				
						colvarDescuento.DefaultSetting = @"((0))";
				colvarDescuento.ForeignKeyTableName = "";
				schema.Columns.Add(colvarDescuento);
				
				TableSchema.TableColumn colvarTotal = new TableSchema.TableColumn(schema);
				colvarTotal.ColumnName = "total";
				colvarTotal.DataType = DbType.Decimal;
				colvarTotal.MaxLength = 0;
				colvarTotal.AutoIncrement = false;
				colvarTotal.IsNullable = false;
				colvarTotal.IsPrimaryKey = false;
				colvarTotal.IsForeignKey = false;
				colvarTotal.IsReadOnly = false;
				
						colvarTotal.DefaultSetting = @"((0))";
				colvarTotal.ForeignKeyTableName = "";
				schema.Columns.Add(colvarTotal);
				
				TableSchema.TableColumn colvarEstado = new TableSchema.TableColumn(schema);
				colvarEstado.ColumnName = "estado";
				colvarEstado.DataType = DbType.AnsiStringFixedLength;
				colvarEstado.MaxLength = 1;
				colvarEstado.AutoIncrement = false;
				colvarEstado.IsNullable = false;
				colvarEstado.IsPrimaryKey = false;
				colvarEstado.IsForeignKey = false;
				colvarEstado.IsReadOnly = false;
				
						colvarEstado.DefaultSetting = @"('A')";
				colvarEstado.ForeignKeyTableName = "";
				schema.Columns.Add(colvarEstado);
				
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
				
						colvarFechaRegistro.DefaultSetting = @"(((1)/(1))/(1900))";
				colvarFechaRegistro.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFechaRegistro);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["RisProvider"].AddSchema("FAC_Factura",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("IdFactura")]
		[Bindable(true)]
		public int IdFactura 
		{
			get { return GetColumnValue<int>(Columns.IdFactura); }
			set { SetColumnValue(Columns.IdFactura, value); }
		}
		  
		[XmlAttribute("IdEfector")]
		[Bindable(true)]
		public int IdEfector 
		{
			get { return GetColumnValue<int>(Columns.IdEfector); }
			set { SetColumnValue(Columns.IdEfector, value); }
		}
		  
		[XmlAttribute("IdObraSocial")]
		[Bindable(true)]
		public int IdObraSocial 
		{
			get { return GetColumnValue<int>(Columns.IdObraSocial); }
			set { SetColumnValue(Columns.IdObraSocial, value); }
		}
		  
		[XmlAttribute("Numero")]
		[Bindable(true)]
		public string Numero 
		{
			get { return GetColumnValue<string>(Columns.Numero); }
			set { SetColumnValue(Columns.Numero, value); }
		}
		  
		[XmlAttribute("Fecha")]
		[Bindable(true)]
		public DateTime Fecha 
		{
			get { return GetColumnValue<DateTime>(Columns.Fecha); }
			set { SetColumnValue(Columns.Fecha, value); }
		}
		  
		[XmlAttribute("Periodo")]
		[Bindable(true)]
		public string Periodo 
		{
			get { return GetColumnValue<string>(Columns.Periodo); }
			set { SetColumnValue(Columns.Periodo, value); }
		}
		  
		[XmlAttribute("Observaciones")]
		[Bindable(true)]
		public string Observaciones 
		{
			get { return GetColumnValue<string>(Columns.Observaciones); }
			set { SetColumnValue(Columns.Observaciones, value); }
		}
		  
		[XmlAttribute("SubTotal")]
		[Bindable(true)]
		public decimal SubTotal 
		{
			get { return GetColumnValue<decimal>(Columns.SubTotal); }
			set { SetColumnValue(Columns.SubTotal, value); }
		}
		  
		[XmlAttribute("Descuento")]
		[Bindable(true)]
		public decimal Descuento 
		{
			get { return GetColumnValue<decimal>(Columns.Descuento); }
			set { SetColumnValue(Columns.Descuento, value); }
		}
		  
		[XmlAttribute("Total")]
		[Bindable(true)]
		public decimal Total 
		{
			get { return GetColumnValue<decimal>(Columns.Total); }
			set { SetColumnValue(Columns.Total, value); }
		}
		  
		[XmlAttribute("Estado")]
		[Bindable(true)]
		public string Estado 
		{
			get { return GetColumnValue<string>(Columns.Estado); }
			set { SetColumnValue(Columns.Estado, value); }
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
		
		#endregion
		
		
		#region PrimaryKey Methods		
		
        protected override void SetPrimaryKey(object oValue)
        {
            base.SetPrimaryKey(oValue);
            
            SetPKValues();
        }
        
		
		private DalRis.FacOrdenCollection colFacOrdenRecords;
		public DalRis.FacOrdenCollection FacOrdenRecords()
		{
			if(colFacOrdenRecords == null)
			{
				colFacOrdenRecords = new DalRis.FacOrdenCollection().Where(FacOrden.Columns.IdFactura, IdFactura).Load();
				colFacOrdenRecords.ListChanged += new ListChangedEventHandler(colFacOrdenRecords_ListChanged);
			}
			return colFacOrdenRecords;
		}
				
		void colFacOrdenRecords_ListChanged(object sender, ListChangedEventArgs e)
		{
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
		        // Set foreign key value
		        colFacOrdenRecords[e.NewIndex].IdFactura = IdFactura;
				colFacOrdenRecords.ListChanged += new ListChangedEventHandler(colFacOrdenRecords_ListChanged);
            }
		}
		private DalRis.FacFacturaDetalleCollection colFacFacturaDetalleRecords;
		public DalRis.FacFacturaDetalleCollection FacFacturaDetalleRecords()
		{
			if(colFacFacturaDetalleRecords == null)
			{
				colFacFacturaDetalleRecords = new DalRis.FacFacturaDetalleCollection().Where(FacFacturaDetalle.Columns.IdFactura, IdFactura).Load();
				colFacFacturaDetalleRecords.ListChanged += new ListChangedEventHandler(colFacFacturaDetalleRecords_ListChanged);
			}
			return colFacFacturaDetalleRecords;
		}
				
		void colFacFacturaDetalleRecords_ListChanged(object sender, ListChangedEventArgs e)
		{
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
		        // Set foreign key value
		        colFacFacturaDetalleRecords[e.NewIndex].IdFactura = IdFactura;
				colFacFacturaDetalleRecords.ListChanged += new ListChangedEventHandler(colFacFacturaDetalleRecords_ListChanged);
            }
		}
		#endregion
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(int varIdEfector,int varIdObraSocial,string varNumero,DateTime varFecha,string varPeriodo,string varObservaciones,decimal varSubTotal,decimal varDescuento,decimal varTotal,string varEstado,int varIdUsuarioRegistro,DateTime varFechaRegistro)
		{
			FacFactura item = new FacFactura();
			
			item.IdEfector = varIdEfector;
			
			item.IdObraSocial = varIdObraSocial;
			
			item.Numero = varNumero;
			
			item.Fecha = varFecha;
			
			item.Periodo = varPeriodo;
			
			item.Observaciones = varObservaciones;
			
			item.SubTotal = varSubTotal;
			
			item.Descuento = varDescuento;
			
			item.Total = varTotal;
			
			item.Estado = varEstado;
			
			item.IdUsuarioRegistro = varIdUsuarioRegistro;
			
			item.FechaRegistro = varFechaRegistro;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varIdFactura,int varIdEfector,int varIdObraSocial,string varNumero,DateTime varFecha,string varPeriodo,string varObservaciones,decimal varSubTotal,decimal varDescuento,decimal varTotal,string varEstado,int varIdUsuarioRegistro,DateTime varFechaRegistro)
		{
			FacFactura item = new FacFactura();
			
				item.IdFactura = varIdFactura;
			
				item.IdEfector = varIdEfector;
			
				item.IdObraSocial = varIdObraSocial;
			
				item.Numero = varNumero;
			
				item.Fecha = varFecha;
			
				item.Periodo = varPeriodo;
			
				item.Observaciones = varObservaciones;
			
				item.SubTotal = varSubTotal;
			
				item.Descuento = varDescuento;
			
				item.Total = varTotal;
			
				item.Estado = varEstado;
			
				item.IdUsuarioRegistro = varIdUsuarioRegistro;
			
				item.FechaRegistro = varFechaRegistro;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn IdFacturaColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn IdEfectorColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn IdObraSocialColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn NumeroColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn FechaColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn PeriodoColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        public static TableSchema.TableColumn ObservacionesColumn
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        public static TableSchema.TableColumn SubTotalColumn
        {
            get { return Schema.Columns[7]; }
        }
        
        
        
        public static TableSchema.TableColumn DescuentoColumn
        {
            get { return Schema.Columns[8]; }
        }
        
        
        
        public static TableSchema.TableColumn TotalColumn
        {
            get { return Schema.Columns[9]; }
        }
        
        
        
        public static TableSchema.TableColumn EstadoColumn
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
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string IdFactura = @"idFactura";
			 public static string IdEfector = @"idEfector";
			 public static string IdObraSocial = @"idObraSocial";
			 public static string Numero = @"numero";
			 public static string Fecha = @"fecha";
			 public static string Periodo = @"periodo";
			 public static string Observaciones = @"observaciones";
			 public static string SubTotal = @"subTotal";
			 public static string Descuento = @"descuento";
			 public static string Total = @"total";
			 public static string Estado = @"estado";
			 public static string IdUsuarioRegistro = @"idUsuarioRegistro";
			 public static string FechaRegistro = @"fechaRegistro";
						
		}
		#endregion
		
		#region Update PK Collections
		
        public void SetPKValues()
        {
                if (colFacOrdenRecords != null)
                {
                    foreach (DalRis.FacOrden item in colFacOrdenRecords)
                    {
                        if (item.IdFactura != IdFactura)
                        {
                            item.IdFactura = IdFactura;
                        }
                    }
               }
		
                if (colFacFacturaDetalleRecords != null)
                {
                    foreach (DalRis.FacFacturaDetalle item in colFacFacturaDetalleRecords)
                    {
                        if (item.IdFactura != IdFactura)
                        {
                            item.IdFactura = IdFactura;
                        }
                    }
               }
		}
        #endregion
    
        #region Deep Save
		
        public void DeepSave()
        {
            Save();
            
                if (colFacOrdenRecords != null)
                {
                    colFacOrdenRecords.SaveAll();
               }
		
                if (colFacFacturaDetalleRecords != null)
                {
                    colFacFacturaDetalleRecords.SaveAll();
               }
		}
        #endregion
	}
}
