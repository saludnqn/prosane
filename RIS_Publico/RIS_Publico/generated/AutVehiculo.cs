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
	/// Strongly-typed collection for the AutVehiculo class.
	/// </summary>
    [Serializable]
	public partial class AutVehiculoCollection : ActiveList<AutVehiculo, AutVehiculoCollection>
	{	   
		public AutVehiculoCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>AutVehiculoCollection</returns>
		public AutVehiculoCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                AutVehiculo o = this[i];
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
	/// This is an ActiveRecord class which wraps the AUT_Vehiculo table.
	/// </summary>
	[Serializable]
	public partial class AutVehiculo : ActiveRecord<AutVehiculo>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public AutVehiculo()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public AutVehiculo(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public AutVehiculo(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public AutVehiculo(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("AUT_Vehiculo", TableType.Table, DataService.GetInstance("RisProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarIdVehiculo = new TableSchema.TableColumn(schema);
				colvarIdVehiculo.ColumnName = "idVehiculo";
				colvarIdVehiculo.DataType = DbType.Int32;
				colvarIdVehiculo.MaxLength = 0;
				colvarIdVehiculo.AutoIncrement = true;
				colvarIdVehiculo.IsNullable = false;
				colvarIdVehiculo.IsPrimaryKey = true;
				colvarIdVehiculo.IsForeignKey = false;
				colvarIdVehiculo.IsReadOnly = false;
				colvarIdVehiculo.DefaultSetting = @"";
				colvarIdVehiculo.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdVehiculo);
				
				TableSchema.TableColumn colvarMatricula = new TableSchema.TableColumn(schema);
				colvarMatricula.ColumnName = "matricula";
				colvarMatricula.DataType = DbType.String;
				colvarMatricula.MaxLength = 50;
				colvarMatricula.AutoIncrement = false;
				colvarMatricula.IsNullable = false;
				colvarMatricula.IsPrimaryKey = false;
				colvarMatricula.IsForeignKey = false;
				colvarMatricula.IsReadOnly = false;
				colvarMatricula.DefaultSetting = @"";
				colvarMatricula.ForeignKeyTableName = "";
				schema.Columns.Add(colvarMatricula);
				
				TableSchema.TableColumn colvarDominio = new TableSchema.TableColumn(schema);
				colvarDominio.ColumnName = "dominio";
				colvarDominio.DataType = DbType.String;
				colvarDominio.MaxLength = 50;
				colvarDominio.AutoIncrement = false;
				colvarDominio.IsNullable = false;
				colvarDominio.IsPrimaryKey = false;
				colvarDominio.IsForeignKey = false;
				colvarDominio.IsReadOnly = false;
				colvarDominio.DefaultSetting = @"";
				colvarDominio.ForeignKeyTableName = "";
				schema.Columns.Add(colvarDominio);
				
				TableSchema.TableColumn colvarAnio = new TableSchema.TableColumn(schema);
				colvarAnio.ColumnName = "Anio";
				colvarAnio.DataType = DbType.Int32;
				colvarAnio.MaxLength = 0;
				colvarAnio.AutoIncrement = false;
				colvarAnio.IsNullable = true;
				colvarAnio.IsPrimaryKey = false;
				colvarAnio.IsForeignKey = false;
				colvarAnio.IsReadOnly = false;
				colvarAnio.DefaultSetting = @"";
				colvarAnio.ForeignKeyTableName = "";
				schema.Columns.Add(colvarAnio);
				
				TableSchema.TableColumn colvarOdometroActual = new TableSchema.TableColumn(schema);
				colvarOdometroActual.ColumnName = "odometroActual";
				colvarOdometroActual.DataType = DbType.Int32;
				colvarOdometroActual.MaxLength = 0;
				colvarOdometroActual.AutoIncrement = false;
				colvarOdometroActual.IsNullable = false;
				colvarOdometroActual.IsPrimaryKey = false;
				colvarOdometroActual.IsForeignKey = false;
				colvarOdometroActual.IsReadOnly = false;
				colvarOdometroActual.DefaultSetting = @"";
				colvarOdometroActual.ForeignKeyTableName = "";
				schema.Columns.Add(colvarOdometroActual);
				
				TableSchema.TableColumn colvarFechaLecturaOdometro = new TableSchema.TableColumn(schema);
				colvarFechaLecturaOdometro.ColumnName = "fechaLecturaOdometro";
				colvarFechaLecturaOdometro.DataType = DbType.DateTime;
				colvarFechaLecturaOdometro.MaxLength = 0;
				colvarFechaLecturaOdometro.AutoIncrement = false;
				colvarFechaLecturaOdometro.IsNullable = false;
				colvarFechaLecturaOdometro.IsPrimaryKey = false;
				colvarFechaLecturaOdometro.IsForeignKey = false;
				colvarFechaLecturaOdometro.IsReadOnly = false;
				colvarFechaLecturaOdometro.DefaultSetting = @"";
				colvarFechaLecturaOdometro.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFechaLecturaOdometro);
				
				TableSchema.TableColumn colvarNumeroMotor = new TableSchema.TableColumn(schema);
				colvarNumeroMotor.ColumnName = "numeroMotor";
				colvarNumeroMotor.DataType = DbType.String;
				colvarNumeroMotor.MaxLength = 50;
				colvarNumeroMotor.AutoIncrement = false;
				colvarNumeroMotor.IsNullable = false;
				colvarNumeroMotor.IsPrimaryKey = false;
				colvarNumeroMotor.IsForeignKey = false;
				colvarNumeroMotor.IsReadOnly = false;
				colvarNumeroMotor.DefaultSetting = @"";
				colvarNumeroMotor.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNumeroMotor);
				
				TableSchema.TableColumn colvarNumeroChasis = new TableSchema.TableColumn(schema);
				colvarNumeroChasis.ColumnName = "numeroChasis";
				colvarNumeroChasis.DataType = DbType.String;
				colvarNumeroChasis.MaxLength = 50;
				colvarNumeroChasis.AutoIncrement = false;
				colvarNumeroChasis.IsNullable = false;
				colvarNumeroChasis.IsPrimaryKey = false;
				colvarNumeroChasis.IsForeignKey = false;
				colvarNumeroChasis.IsReadOnly = false;
				colvarNumeroChasis.DefaultSetting = @"";
				colvarNumeroChasis.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNumeroChasis);
				
				TableSchema.TableColumn colvarTieneRadio = new TableSchema.TableColumn(schema);
				colvarTieneRadio.ColumnName = "tieneRadio";
				colvarTieneRadio.DataType = DbType.String;
				colvarTieneRadio.MaxLength = 50;
				colvarTieneRadio.AutoIncrement = false;
				colvarTieneRadio.IsNullable = false;
				colvarTieneRadio.IsPrimaryKey = false;
				colvarTieneRadio.IsForeignKey = false;
				colvarTieneRadio.IsReadOnly = false;
				colvarTieneRadio.DefaultSetting = @"";
				colvarTieneRadio.ForeignKeyTableName = "";
				schema.Columns.Add(colvarTieneRadio);
				
				TableSchema.TableColumn colvarTienePermisoRadio = new TableSchema.TableColumn(schema);
				colvarTienePermisoRadio.ColumnName = "tienePermisoRadio";
				colvarTienePermisoRadio.DataType = DbType.String;
				colvarTienePermisoRadio.MaxLength = 50;
				colvarTienePermisoRadio.AutoIncrement = false;
				colvarTienePermisoRadio.IsNullable = false;
				colvarTienePermisoRadio.IsPrimaryKey = false;
				colvarTienePermisoRadio.IsForeignKey = false;
				colvarTienePermisoRadio.IsReadOnly = false;
				colvarTienePermisoRadio.DefaultSetting = @"";
				colvarTienePermisoRadio.ForeignKeyTableName = "";
				schema.Columns.Add(colvarTienePermisoRadio);
				
				TableSchema.TableColumn colvarIdTipoVehiculo = new TableSchema.TableColumn(schema);
				colvarIdTipoVehiculo.ColumnName = "idTipoVehiculo";
				colvarIdTipoVehiculo.DataType = DbType.Int32;
				colvarIdTipoVehiculo.MaxLength = 0;
				colvarIdTipoVehiculo.AutoIncrement = false;
				colvarIdTipoVehiculo.IsNullable = false;
				colvarIdTipoVehiculo.IsPrimaryKey = false;
				colvarIdTipoVehiculo.IsForeignKey = true;
				colvarIdTipoVehiculo.IsReadOnly = false;
				colvarIdTipoVehiculo.DefaultSetting = @"";
				
					colvarIdTipoVehiculo.ForeignKeyTableName = "AUT_TipoVehiculo";
				schema.Columns.Add(colvarIdTipoVehiculo);
				
				TableSchema.TableColumn colvarTraccion = new TableSchema.TableColumn(schema);
				colvarTraccion.ColumnName = "Traccion";
				colvarTraccion.DataType = DbType.String;
				colvarTraccion.MaxLength = 50;
				colvarTraccion.AutoIncrement = false;
				colvarTraccion.IsNullable = true;
				colvarTraccion.IsPrimaryKey = false;
				colvarTraccion.IsForeignKey = false;
				colvarTraccion.IsReadOnly = false;
				colvarTraccion.DefaultSetting = @"";
				colvarTraccion.ForeignKeyTableName = "";
				schema.Columns.Add(colvarTraccion);
				
				TableSchema.TableColumn colvarIdModelo = new TableSchema.TableColumn(schema);
				colvarIdModelo.ColumnName = "idModelo";
				colvarIdModelo.DataType = DbType.Int32;
				colvarIdModelo.MaxLength = 0;
				colvarIdModelo.AutoIncrement = false;
				colvarIdModelo.IsNullable = false;
				colvarIdModelo.IsPrimaryKey = false;
				colvarIdModelo.IsForeignKey = true;
				colvarIdModelo.IsReadOnly = false;
				colvarIdModelo.DefaultSetting = @"";
				
					colvarIdModelo.ForeignKeyTableName = "AUT_Modelo";
				schema.Columns.Add(colvarIdModelo);
				
				TableSchema.TableColumn colvarIdEntidad = new TableSchema.TableColumn(schema);
				colvarIdEntidad.ColumnName = "idEntidad";
				colvarIdEntidad.DataType = DbType.Int32;
				colvarIdEntidad.MaxLength = 0;
				colvarIdEntidad.AutoIncrement = false;
				colvarIdEntidad.IsNullable = false;
				colvarIdEntidad.IsPrimaryKey = false;
				colvarIdEntidad.IsForeignKey = true;
				colvarIdEntidad.IsReadOnly = false;
				colvarIdEntidad.DefaultSetting = @"";
				
					colvarIdEntidad.ForeignKeyTableName = "AUT_Entidad";
				schema.Columns.Add(colvarIdEntidad);
				
				TableSchema.TableColumn colvarIdDireccion = new TableSchema.TableColumn(schema);
				colvarIdDireccion.ColumnName = "idDireccion";
				colvarIdDireccion.DataType = DbType.Decimal;
				colvarIdDireccion.MaxLength = 0;
				colvarIdDireccion.AutoIncrement = false;
				colvarIdDireccion.IsNullable = true;
				colvarIdDireccion.IsPrimaryKey = false;
				colvarIdDireccion.IsForeignKey = false;
				colvarIdDireccion.IsReadOnly = false;
				colvarIdDireccion.DefaultSetting = @"";
				colvarIdDireccion.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdDireccion);
				
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
				
				TableSchema.TableColumn colvarCondicion = new TableSchema.TableColumn(schema);
				colvarCondicion.ColumnName = "Condicion";
				colvarCondicion.DataType = DbType.String;
				colvarCondicion.MaxLength = 30;
				colvarCondicion.AutoIncrement = false;
				colvarCondicion.IsNullable = true;
				colvarCondicion.IsPrimaryKey = false;
				colvarCondicion.IsForeignKey = false;
				colvarCondicion.IsReadOnly = false;
				colvarCondicion.DefaultSetting = @"";
				colvarCondicion.ForeignKeyTableName = "";
				schema.Columns.Add(colvarCondicion);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["RisProvider"].AddSchema("AUT_Vehiculo",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("IdVehiculo")]
		[Bindable(true)]
		public int IdVehiculo 
		{
			get { return GetColumnValue<int>(Columns.IdVehiculo); }
			set { SetColumnValue(Columns.IdVehiculo, value); }
		}
		  
		[XmlAttribute("Matricula")]
		[Bindable(true)]
		public string Matricula 
		{
			get { return GetColumnValue<string>(Columns.Matricula); }
			set { SetColumnValue(Columns.Matricula, value); }
		}
		  
		[XmlAttribute("Dominio")]
		[Bindable(true)]
		public string Dominio 
		{
			get { return GetColumnValue<string>(Columns.Dominio); }
			set { SetColumnValue(Columns.Dominio, value); }
		}
		  
		[XmlAttribute("Anio")]
		[Bindable(true)]
		public int? Anio 
		{
			get { return GetColumnValue<int?>(Columns.Anio); }
			set { SetColumnValue(Columns.Anio, value); }
		}
		  
		[XmlAttribute("OdometroActual")]
		[Bindable(true)]
		public int OdometroActual 
		{
			get { return GetColumnValue<int>(Columns.OdometroActual); }
			set { SetColumnValue(Columns.OdometroActual, value); }
		}
		  
		[XmlAttribute("FechaLecturaOdometro")]
		[Bindable(true)]
		public DateTime FechaLecturaOdometro 
		{
			get { return GetColumnValue<DateTime>(Columns.FechaLecturaOdometro); }
			set { SetColumnValue(Columns.FechaLecturaOdometro, value); }
		}
		  
		[XmlAttribute("NumeroMotor")]
		[Bindable(true)]
		public string NumeroMotor 
		{
			get { return GetColumnValue<string>(Columns.NumeroMotor); }
			set { SetColumnValue(Columns.NumeroMotor, value); }
		}
		  
		[XmlAttribute("NumeroChasis")]
		[Bindable(true)]
		public string NumeroChasis 
		{
			get { return GetColumnValue<string>(Columns.NumeroChasis); }
			set { SetColumnValue(Columns.NumeroChasis, value); }
		}
		  
		[XmlAttribute("TieneRadio")]
		[Bindable(true)]
		public string TieneRadio 
		{
			get { return GetColumnValue<string>(Columns.TieneRadio); }
			set { SetColumnValue(Columns.TieneRadio, value); }
		}
		  
		[XmlAttribute("TienePermisoRadio")]
		[Bindable(true)]
		public string TienePermisoRadio 
		{
			get { return GetColumnValue<string>(Columns.TienePermisoRadio); }
			set { SetColumnValue(Columns.TienePermisoRadio, value); }
		}
		  
		[XmlAttribute("IdTipoVehiculo")]
		[Bindable(true)]
		public int IdTipoVehiculo 
		{
			get { return GetColumnValue<int>(Columns.IdTipoVehiculo); }
			set { SetColumnValue(Columns.IdTipoVehiculo, value); }
		}
		  
		[XmlAttribute("Traccion")]
		[Bindable(true)]
		public string Traccion 
		{
			get { return GetColumnValue<string>(Columns.Traccion); }
			set { SetColumnValue(Columns.Traccion, value); }
		}
		  
		[XmlAttribute("IdModelo")]
		[Bindable(true)]
		public int IdModelo 
		{
			get { return GetColumnValue<int>(Columns.IdModelo); }
			set { SetColumnValue(Columns.IdModelo, value); }
		}
		  
		[XmlAttribute("IdEntidad")]
		[Bindable(true)]
		public int IdEntidad 
		{
			get { return GetColumnValue<int>(Columns.IdEntidad); }
			set { SetColumnValue(Columns.IdEntidad, value); }
		}
		  
		[XmlAttribute("IdDireccion")]
		[Bindable(true)]
		public decimal? IdDireccion 
		{
			get { return GetColumnValue<decimal?>(Columns.IdDireccion); }
			set { SetColumnValue(Columns.IdDireccion, value); }
		}
		  
		[XmlAttribute("Estado")]
		[Bindable(true)]
		public string Estado 
		{
			get { return GetColumnValue<string>(Columns.Estado); }
			set { SetColumnValue(Columns.Estado, value); }
		}
		  
		[XmlAttribute("Observaciones")]
		[Bindable(true)]
		public string Observaciones 
		{
			get { return GetColumnValue<string>(Columns.Observaciones); }
			set { SetColumnValue(Columns.Observaciones, value); }
		}
		  
		[XmlAttribute("Condicion")]
		[Bindable(true)]
		public string Condicion 
		{
			get { return GetColumnValue<string>(Columns.Condicion); }
			set { SetColumnValue(Columns.Condicion, value); }
		}
		
		#endregion
		
		
		#region PrimaryKey Methods		
		
        protected override void SetPrimaryKey(object oValue)
        {
            base.SetPrimaryKey(oValue);
            
            SetPKValues();
        }
        
		
		private DalRis.AutAccidenteCollection colAutAccidenteRecords;
		public DalRis.AutAccidenteCollection AutAccidenteRecords()
		{
			if(colAutAccidenteRecords == null)
			{
				colAutAccidenteRecords = new DalRis.AutAccidenteCollection().Where(AutAccidente.Columns.IdVehiculo, IdVehiculo).Load();
				colAutAccidenteRecords.ListChanged += new ListChangedEventHandler(colAutAccidenteRecords_ListChanged);
			}
			return colAutAccidenteRecords;
		}
				
		void colAutAccidenteRecords_ListChanged(object sender, ListChangedEventArgs e)
		{
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
		        // Set foreign key value
		        colAutAccidenteRecords[e.NewIndex].IdVehiculo = IdVehiculo;
				colAutAccidenteRecords.ListChanged += new ListChangedEventHandler(colAutAccidenteRecords_ListChanged);
            }
		}
		private DalRis.AutMovimientoCollection colAutMovimientoRecords;
		public DalRis.AutMovimientoCollection AutMovimientoRecords()
		{
			if(colAutMovimientoRecords == null)
			{
				colAutMovimientoRecords = new DalRis.AutMovimientoCollection().Where(AutMovimiento.Columns.IdVehiculo, IdVehiculo).Load();
				colAutMovimientoRecords.ListChanged += new ListChangedEventHandler(colAutMovimientoRecords_ListChanged);
			}
			return colAutMovimientoRecords;
		}
				
		void colAutMovimientoRecords_ListChanged(object sender, ListChangedEventArgs e)
		{
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
		        // Set foreign key value
		        colAutMovimientoRecords[e.NewIndex].IdVehiculo = IdVehiculo;
				colAutMovimientoRecords.ListChanged += new ListChangedEventHandler(colAutMovimientoRecords_ListChanged);
            }
		}
		private DalRis.AutVehiculoPmpCollection colAutVehiculoPmpRecords;
		public DalRis.AutVehiculoPmpCollection AutVehiculoPmpRecords()
		{
			if(colAutVehiculoPmpRecords == null)
			{
				colAutVehiculoPmpRecords = new DalRis.AutVehiculoPmpCollection().Where(AutVehiculoPmp.Columns.IdVehiculo, IdVehiculo).Load();
				colAutVehiculoPmpRecords.ListChanged += new ListChangedEventHandler(colAutVehiculoPmpRecords_ListChanged);
			}
			return colAutVehiculoPmpRecords;
		}
				
		void colAutVehiculoPmpRecords_ListChanged(object sender, ListChangedEventArgs e)
		{
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
		        // Set foreign key value
		        colAutVehiculoPmpRecords[e.NewIndex].IdVehiculo = IdVehiculo;
				colAutVehiculoPmpRecords.ListChanged += new ListChangedEventHandler(colAutVehiculoPmpRecords_ListChanged);
            }
		}
		#endregion
		
			
		
		#region ForeignKey Properties
		
		/// <summary>
		/// Returns a AutModelo ActiveRecord object related to this AutVehiculo
		/// 
		/// </summary>
		public DalRis.AutModelo AutModelo
		{
			get { return DalRis.AutModelo.FetchByID(this.IdModelo); }
			set { SetColumnValue("idModelo", value.IdModelo); }
		}
		
		
		/// <summary>
		/// Returns a AutTipoVehiculo ActiveRecord object related to this AutVehiculo
		/// 
		/// </summary>
		public DalRis.AutTipoVehiculo AutTipoVehiculo
		{
			get { return DalRis.AutTipoVehiculo.FetchByID(this.IdTipoVehiculo); }
			set { SetColumnValue("idTipoVehiculo", value.IdTipoVehiculo); }
		}
		
		
		/// <summary>
		/// Returns a AutEntidad ActiveRecord object related to this AutVehiculo
		/// 
		/// </summary>
		public DalRis.AutEntidad AutEntidad
		{
			get { return DalRis.AutEntidad.FetchByID(this.IdEntidad); }
			set { SetColumnValue("idEntidad", value.IdEntidad); }
		}
		
		
		#endregion
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varMatricula,string varDominio,int? varAnio,int varOdometroActual,DateTime varFechaLecturaOdometro,string varNumeroMotor,string varNumeroChasis,string varTieneRadio,string varTienePermisoRadio,int varIdTipoVehiculo,string varTraccion,int varIdModelo,int varIdEntidad,decimal? varIdDireccion,string varEstado,string varObservaciones,string varCondicion)
		{
			AutVehiculo item = new AutVehiculo();
			
			item.Matricula = varMatricula;
			
			item.Dominio = varDominio;
			
			item.Anio = varAnio;
			
			item.OdometroActual = varOdometroActual;
			
			item.FechaLecturaOdometro = varFechaLecturaOdometro;
			
			item.NumeroMotor = varNumeroMotor;
			
			item.NumeroChasis = varNumeroChasis;
			
			item.TieneRadio = varTieneRadio;
			
			item.TienePermisoRadio = varTienePermisoRadio;
			
			item.IdTipoVehiculo = varIdTipoVehiculo;
			
			item.Traccion = varTraccion;
			
			item.IdModelo = varIdModelo;
			
			item.IdEntidad = varIdEntidad;
			
			item.IdDireccion = varIdDireccion;
			
			item.Estado = varEstado;
			
			item.Observaciones = varObservaciones;
			
			item.Condicion = varCondicion;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varIdVehiculo,string varMatricula,string varDominio,int? varAnio,int varOdometroActual,DateTime varFechaLecturaOdometro,string varNumeroMotor,string varNumeroChasis,string varTieneRadio,string varTienePermisoRadio,int varIdTipoVehiculo,string varTraccion,int varIdModelo,int varIdEntidad,decimal? varIdDireccion,string varEstado,string varObservaciones,string varCondicion)
		{
			AutVehiculo item = new AutVehiculo();
			
				item.IdVehiculo = varIdVehiculo;
			
				item.Matricula = varMatricula;
			
				item.Dominio = varDominio;
			
				item.Anio = varAnio;
			
				item.OdometroActual = varOdometroActual;
			
				item.FechaLecturaOdometro = varFechaLecturaOdometro;
			
				item.NumeroMotor = varNumeroMotor;
			
				item.NumeroChasis = varNumeroChasis;
			
				item.TieneRadio = varTieneRadio;
			
				item.TienePermisoRadio = varTienePermisoRadio;
			
				item.IdTipoVehiculo = varIdTipoVehiculo;
			
				item.Traccion = varTraccion;
			
				item.IdModelo = varIdModelo;
			
				item.IdEntidad = varIdEntidad;
			
				item.IdDireccion = varIdDireccion;
			
				item.Estado = varEstado;
			
				item.Observaciones = varObservaciones;
			
				item.Condicion = varCondicion;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn IdVehiculoColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn MatriculaColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn DominioColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn AnioColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn OdometroActualColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn FechaLecturaOdometroColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        public static TableSchema.TableColumn NumeroMotorColumn
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        public static TableSchema.TableColumn NumeroChasisColumn
        {
            get { return Schema.Columns[7]; }
        }
        
        
        
        public static TableSchema.TableColumn TieneRadioColumn
        {
            get { return Schema.Columns[8]; }
        }
        
        
        
        public static TableSchema.TableColumn TienePermisoRadioColumn
        {
            get { return Schema.Columns[9]; }
        }
        
        
        
        public static TableSchema.TableColumn IdTipoVehiculoColumn
        {
            get { return Schema.Columns[10]; }
        }
        
        
        
        public static TableSchema.TableColumn TraccionColumn
        {
            get { return Schema.Columns[11]; }
        }
        
        
        
        public static TableSchema.TableColumn IdModeloColumn
        {
            get { return Schema.Columns[12]; }
        }
        
        
        
        public static TableSchema.TableColumn IdEntidadColumn
        {
            get { return Schema.Columns[13]; }
        }
        
        
        
        public static TableSchema.TableColumn IdDireccionColumn
        {
            get { return Schema.Columns[14]; }
        }
        
        
        
        public static TableSchema.TableColumn EstadoColumn
        {
            get { return Schema.Columns[15]; }
        }
        
        
        
        public static TableSchema.TableColumn ObservacionesColumn
        {
            get { return Schema.Columns[16]; }
        }
        
        
        
        public static TableSchema.TableColumn CondicionColumn
        {
            get { return Schema.Columns[17]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string IdVehiculo = @"idVehiculo";
			 public static string Matricula = @"matricula";
			 public static string Dominio = @"dominio";
			 public static string Anio = @"Anio";
			 public static string OdometroActual = @"odometroActual";
			 public static string FechaLecturaOdometro = @"fechaLecturaOdometro";
			 public static string NumeroMotor = @"numeroMotor";
			 public static string NumeroChasis = @"numeroChasis";
			 public static string TieneRadio = @"tieneRadio";
			 public static string TienePermisoRadio = @"tienePermisoRadio";
			 public static string IdTipoVehiculo = @"idTipoVehiculo";
			 public static string Traccion = @"Traccion";
			 public static string IdModelo = @"idModelo";
			 public static string IdEntidad = @"idEntidad";
			 public static string IdDireccion = @"idDireccion";
			 public static string Estado = @"Estado";
			 public static string Observaciones = @"Observaciones";
			 public static string Condicion = @"Condicion";
						
		}
		#endregion
		
		#region Update PK Collections
		
        public void SetPKValues()
        {
                if (colAutAccidenteRecords != null)
                {
                    foreach (DalRis.AutAccidente item in colAutAccidenteRecords)
                    {
                        if (item.IdVehiculo != IdVehiculo)
                        {
                            item.IdVehiculo = IdVehiculo;
                        }
                    }
               }
		
                if (colAutMovimientoRecords != null)
                {
                    foreach (DalRis.AutMovimiento item in colAutMovimientoRecords)
                    {
                        if (item.IdVehiculo != IdVehiculo)
                        {
                            item.IdVehiculo = IdVehiculo;
                        }
                    }
               }
		
                if (colAutVehiculoPmpRecords != null)
                {
                    foreach (DalRis.AutVehiculoPmp item in colAutVehiculoPmpRecords)
                    {
                        if (item.IdVehiculo != IdVehiculo)
                        {
                            item.IdVehiculo = IdVehiculo;
                        }
                    }
               }
		}
        #endregion
    
        #region Deep Save
		
        public void DeepSave()
        {
            Save();
            
                if (colAutAccidenteRecords != null)
                {
                    colAutAccidenteRecords.SaveAll();
               }
		
                if (colAutMovimientoRecords != null)
                {
                    colAutMovimientoRecords.SaveAll();
               }
		
                if (colAutVehiculoPmpRecords != null)
                {
                    colAutVehiculoPmpRecords.SaveAll();
               }
		}
        #endregion
	}
}
