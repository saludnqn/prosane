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
	/// Strongly-typed collection for the TamTratamiento class.
	/// </summary>
    [Serializable]
	public partial class TamTratamientoCollection : ActiveList<TamTratamiento, TamTratamientoCollection>
	{	   
		public TamTratamientoCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>TamTratamientoCollection</returns>
		public TamTratamientoCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                TamTratamiento o = this[i];
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
	/// This is an ActiveRecord class which wraps the TAM_Tratamientos table.
	/// </summary>
	[Serializable]
	public partial class TamTratamiento : ActiveRecord<TamTratamiento>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public TamTratamiento()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public TamTratamiento(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public TamTratamiento(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public TamTratamiento(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("TAM_Tratamientos", TableType.Table, DataService.GetInstance("RisProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarIdTratamiento = new TableSchema.TableColumn(schema);
				colvarIdTratamiento.ColumnName = "idTratamiento";
				colvarIdTratamiento.DataType = DbType.Int32;
				colvarIdTratamiento.MaxLength = 0;
				colvarIdTratamiento.AutoIncrement = true;
				colvarIdTratamiento.IsNullable = false;
				colvarIdTratamiento.IsPrimaryKey = true;
				colvarIdTratamiento.IsForeignKey = false;
				colvarIdTratamiento.IsReadOnly = false;
				colvarIdTratamiento.DefaultSetting = @"";
				colvarIdTratamiento.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdTratamiento);
				
				TableSchema.TableColumn colvarIdTam = new TableSchema.TableColumn(schema);
				colvarIdTam.ColumnName = "idTam";
				colvarIdTam.DataType = DbType.Int32;
				colvarIdTam.MaxLength = 0;
				colvarIdTam.AutoIncrement = false;
				colvarIdTam.IsNullable = false;
				colvarIdTam.IsPrimaryKey = false;
				colvarIdTam.IsForeignKey = true;
				colvarIdTam.IsReadOnly = false;
				
						colvarIdTam.DefaultSetting = @"((0))";
				
					colvarIdTam.ForeignKeyTableName = "TAM_Registro";
				schema.Columns.Add(colvarIdTam);
				
				TableSchema.TableColumn colvarIdPaciente = new TableSchema.TableColumn(schema);
				colvarIdPaciente.ColumnName = "idPaciente";
				colvarIdPaciente.DataType = DbType.Int32;
				colvarIdPaciente.MaxLength = 0;
				colvarIdPaciente.AutoIncrement = false;
				colvarIdPaciente.IsNullable = false;
				colvarIdPaciente.IsPrimaryKey = false;
				colvarIdPaciente.IsForeignKey = false;
				colvarIdPaciente.IsReadOnly = false;
				
						colvarIdPaciente.DefaultSetting = @"((0))";
				colvarIdPaciente.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdPaciente);
				
				TableSchema.TableColumn colvarEdad = new TableSchema.TableColumn(schema);
				colvarEdad.ColumnName = "edad";
				colvarEdad.DataType = DbType.Int32;
				colvarEdad.MaxLength = 0;
				colvarEdad.AutoIncrement = false;
				colvarEdad.IsNullable = false;
				colvarEdad.IsPrimaryKey = false;
				colvarEdad.IsForeignKey = false;
				colvarEdad.IsReadOnly = false;
				
						colvarEdad.DefaultSetting = @"((0))";
				colvarEdad.ForeignKeyTableName = "";
				schema.Columns.Add(colvarEdad);
				
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
				
				TableSchema.TableColumn colvarIdEstadio = new TableSchema.TableColumn(schema);
				colvarIdEstadio.ColumnName = "idEstadio";
				colvarIdEstadio.DataType = DbType.Int32;
				colvarIdEstadio.MaxLength = 0;
				colvarIdEstadio.AutoIncrement = false;
				colvarIdEstadio.IsNullable = false;
				colvarIdEstadio.IsPrimaryKey = false;
				colvarIdEstadio.IsForeignKey = true;
				colvarIdEstadio.IsReadOnly = false;
				
						colvarIdEstadio.DefaultSetting = @"((0))";
				
					colvarIdEstadio.ForeignKeyTableName = "TAM_Estadio";
				schema.Columns.Add(colvarIdEstadio);
				
				TableSchema.TableColumn colvarGrado = new TableSchema.TableColumn(schema);
				colvarGrado.ColumnName = "grado";
				colvarGrado.DataType = DbType.AnsiString;
				colvarGrado.MaxLength = 50;
				colvarGrado.AutoIncrement = false;
				colvarGrado.IsNullable = false;
				colvarGrado.IsPrimaryKey = false;
				colvarGrado.IsForeignKey = false;
				colvarGrado.IsReadOnly = false;
				
						colvarGrado.DefaultSetting = @"('')";
				colvarGrado.ForeignKeyTableName = "";
				schema.Columns.Add(colvarGrado);
				
				TableSchema.TableColumn colvarIdTipoTratamiento = new TableSchema.TableColumn(schema);
				colvarIdTipoTratamiento.ColumnName = "idTipoTratamiento";
				colvarIdTipoTratamiento.DataType = DbType.Int32;
				colvarIdTipoTratamiento.MaxLength = 0;
				colvarIdTipoTratamiento.AutoIncrement = false;
				colvarIdTipoTratamiento.IsNullable = false;
				colvarIdTipoTratamiento.IsPrimaryKey = false;
				colvarIdTipoTratamiento.IsForeignKey = true;
				colvarIdTipoTratamiento.IsReadOnly = false;
				
						colvarIdTipoTratamiento.DefaultSetting = @"((0))";
				
					colvarIdTipoTratamiento.ForeignKeyTableName = "TAM_TipoTratamiento";
				schema.Columns.Add(colvarIdTipoTratamiento);
				
				TableSchema.TableColumn colvarIdProfesionalTratante = new TableSchema.TableColumn(schema);
				colvarIdProfesionalTratante.ColumnName = "idProfesionalTratante";
				colvarIdProfesionalTratante.DataType = DbType.Int32;
				colvarIdProfesionalTratante.MaxLength = 0;
				colvarIdProfesionalTratante.AutoIncrement = false;
				colvarIdProfesionalTratante.IsNullable = false;
				colvarIdProfesionalTratante.IsPrimaryKey = false;
				colvarIdProfesionalTratante.IsForeignKey = true;
				colvarIdProfesionalTratante.IsReadOnly = false;
				
						colvarIdProfesionalTratante.DefaultSetting = @"((0))";
				
					colvarIdProfesionalTratante.ForeignKeyTableName = "Sys_Profesional";
				schema.Columns.Add(colvarIdProfesionalTratante);
				
				TableSchema.TableColumn colvarIdEfectorTratante = new TableSchema.TableColumn(schema);
				colvarIdEfectorTratante.ColumnName = "idEfectorTratante";
				colvarIdEfectorTratante.DataType = DbType.Int32;
				colvarIdEfectorTratante.MaxLength = 0;
				colvarIdEfectorTratante.AutoIncrement = false;
				colvarIdEfectorTratante.IsNullable = false;
				colvarIdEfectorTratante.IsPrimaryKey = false;
				colvarIdEfectorTratante.IsForeignKey = true;
				colvarIdEfectorTratante.IsReadOnly = false;
				
						colvarIdEfectorTratante.DefaultSetting = @"((0))";
				
					colvarIdEfectorTratante.ForeignKeyTableName = "Sys_Efector";
				schema.Columns.Add(colvarIdEfectorTratante);
				
				TableSchema.TableColumn colvarObservaciones = new TableSchema.TableColumn(schema);
				colvarObservaciones.ColumnName = "observaciones";
				colvarObservaciones.DataType = DbType.AnsiString;
				colvarObservaciones.MaxLength = -1;
				colvarObservaciones.AutoIncrement = false;
				colvarObservaciones.IsNullable = false;
				colvarObservaciones.IsPrimaryKey = false;
				colvarObservaciones.IsForeignKey = false;
				colvarObservaciones.IsReadOnly = false;
				
						colvarObservaciones.DefaultSetting = @"('')";
				colvarObservaciones.ForeignKeyTableName = "";
				schema.Columns.Add(colvarObservaciones);
				
				TableSchema.TableColumn colvarCreatedBy = new TableSchema.TableColumn(schema);
				colvarCreatedBy.ColumnName = "CreatedBy";
				colvarCreatedBy.DataType = DbType.String;
				colvarCreatedBy.MaxLength = 50;
				colvarCreatedBy.AutoIncrement = false;
				colvarCreatedBy.IsNullable = false;
				colvarCreatedBy.IsPrimaryKey = false;
				colvarCreatedBy.IsForeignKey = false;
				colvarCreatedBy.IsReadOnly = false;
				
						colvarCreatedBy.DefaultSetting = @"('')";
				colvarCreatedBy.ForeignKeyTableName = "";
				schema.Columns.Add(colvarCreatedBy);
				
				TableSchema.TableColumn colvarCreatedOn = new TableSchema.TableColumn(schema);
				colvarCreatedOn.ColumnName = "CreatedOn";
				colvarCreatedOn.DataType = DbType.DateTime;
				colvarCreatedOn.MaxLength = 0;
				colvarCreatedOn.AutoIncrement = false;
				colvarCreatedOn.IsNullable = false;
				colvarCreatedOn.IsPrimaryKey = false;
				colvarCreatedOn.IsForeignKey = false;
				colvarCreatedOn.IsReadOnly = false;
				
						colvarCreatedOn.DefaultSetting = @"(((1)/(1))/(1900))";
				colvarCreatedOn.ForeignKeyTableName = "";
				schema.Columns.Add(colvarCreatedOn);
				
				TableSchema.TableColumn colvarModifiedBy = new TableSchema.TableColumn(schema);
				colvarModifiedBy.ColumnName = "ModifiedBy";
				colvarModifiedBy.DataType = DbType.String;
				colvarModifiedBy.MaxLength = 50;
				colvarModifiedBy.AutoIncrement = false;
				colvarModifiedBy.IsNullable = false;
				colvarModifiedBy.IsPrimaryKey = false;
				colvarModifiedBy.IsForeignKey = false;
				colvarModifiedBy.IsReadOnly = false;
				
						colvarModifiedBy.DefaultSetting = @"('')";
				colvarModifiedBy.ForeignKeyTableName = "";
				schema.Columns.Add(colvarModifiedBy);
				
				TableSchema.TableColumn colvarModifiedOn = new TableSchema.TableColumn(schema);
				colvarModifiedOn.ColumnName = "ModifiedOn";
				colvarModifiedOn.DataType = DbType.DateTime;
				colvarModifiedOn.MaxLength = 0;
				colvarModifiedOn.AutoIncrement = false;
				colvarModifiedOn.IsNullable = false;
				colvarModifiedOn.IsPrimaryKey = false;
				colvarModifiedOn.IsForeignKey = false;
				colvarModifiedOn.IsReadOnly = false;
				
						colvarModifiedOn.DefaultSetting = @"(((1)/(1))/(1900))";
				colvarModifiedOn.ForeignKeyTableName = "";
				schema.Columns.Add(colvarModifiedOn);
				
				TableSchema.TableColumn colvarActivo = new TableSchema.TableColumn(schema);
				colvarActivo.ColumnName = "activo";
				colvarActivo.DataType = DbType.Boolean;
				colvarActivo.MaxLength = 0;
				colvarActivo.AutoIncrement = false;
				colvarActivo.IsNullable = false;
				colvarActivo.IsPrimaryKey = false;
				colvarActivo.IsForeignKey = false;
				colvarActivo.IsReadOnly = false;
				
						colvarActivo.DefaultSetting = @"((1))";
				colvarActivo.ForeignKeyTableName = "";
				schema.Columns.Add(colvarActivo);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["RisProvider"].AddSchema("TAM_Tratamientos",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("IdTratamiento")]
		[Bindable(true)]
		public int IdTratamiento 
		{
			get { return GetColumnValue<int>(Columns.IdTratamiento); }
			set { SetColumnValue(Columns.IdTratamiento, value); }
		}
		  
		[XmlAttribute("IdTam")]
		[Bindable(true)]
		public int IdTam 
		{
			get { return GetColumnValue<int>(Columns.IdTam); }
			set { SetColumnValue(Columns.IdTam, value); }
		}
		  
		[XmlAttribute("IdPaciente")]
		[Bindable(true)]
		public int IdPaciente 
		{
			get { return GetColumnValue<int>(Columns.IdPaciente); }
			set { SetColumnValue(Columns.IdPaciente, value); }
		}
		  
		[XmlAttribute("Edad")]
		[Bindable(true)]
		public int Edad 
		{
			get { return GetColumnValue<int>(Columns.Edad); }
			set { SetColumnValue(Columns.Edad, value); }
		}
		  
		[XmlAttribute("FechaInicio")]
		[Bindable(true)]
		public DateTime FechaInicio 
		{
			get { return GetColumnValue<DateTime>(Columns.FechaInicio); }
			set { SetColumnValue(Columns.FechaInicio, value); }
		}
		  
		[XmlAttribute("IdEstadio")]
		[Bindable(true)]
		public int IdEstadio 
		{
			get { return GetColumnValue<int>(Columns.IdEstadio); }
			set { SetColumnValue(Columns.IdEstadio, value); }
		}
		  
		[XmlAttribute("Grado")]
		[Bindable(true)]
		public string Grado 
		{
			get { return GetColumnValue<string>(Columns.Grado); }
			set { SetColumnValue(Columns.Grado, value); }
		}
		  
		[XmlAttribute("IdTipoTratamiento")]
		[Bindable(true)]
		public int IdTipoTratamiento 
		{
			get { return GetColumnValue<int>(Columns.IdTipoTratamiento); }
			set { SetColumnValue(Columns.IdTipoTratamiento, value); }
		}
		  
		[XmlAttribute("IdProfesionalTratante")]
		[Bindable(true)]
		public int IdProfesionalTratante 
		{
			get { return GetColumnValue<int>(Columns.IdProfesionalTratante); }
			set { SetColumnValue(Columns.IdProfesionalTratante, value); }
		}
		  
		[XmlAttribute("IdEfectorTratante")]
		[Bindable(true)]
		public int IdEfectorTratante 
		{
			get { return GetColumnValue<int>(Columns.IdEfectorTratante); }
			set { SetColumnValue(Columns.IdEfectorTratante, value); }
		}
		  
		[XmlAttribute("Observaciones")]
		[Bindable(true)]
		public string Observaciones 
		{
			get { return GetColumnValue<string>(Columns.Observaciones); }
			set { SetColumnValue(Columns.Observaciones, value); }
		}
		  
		[XmlAttribute("CreatedBy")]
		[Bindable(true)]
		public string CreatedBy 
		{
			get { return GetColumnValue<string>(Columns.CreatedBy); }
			set { SetColumnValue(Columns.CreatedBy, value); }
		}
		  
		[XmlAttribute("CreatedOn")]
		[Bindable(true)]
		public DateTime CreatedOn 
		{
			get { return GetColumnValue<DateTime>(Columns.CreatedOn); }
			set { SetColumnValue(Columns.CreatedOn, value); }
		}
		  
		[XmlAttribute("ModifiedBy")]
		[Bindable(true)]
		public string ModifiedBy 
		{
			get { return GetColumnValue<string>(Columns.ModifiedBy); }
			set { SetColumnValue(Columns.ModifiedBy, value); }
		}
		  
		[XmlAttribute("ModifiedOn")]
		[Bindable(true)]
		public DateTime ModifiedOn 
		{
			get { return GetColumnValue<DateTime>(Columns.ModifiedOn); }
			set { SetColumnValue(Columns.ModifiedOn, value); }
		}
		  
		[XmlAttribute("Activo")]
		[Bindable(true)]
		public bool Activo 
		{
			get { return GetColumnValue<bool>(Columns.Activo); }
			set { SetColumnValue(Columns.Activo, value); }
		}
		
		#endregion
		
		
			
		
		#region ForeignKey Properties
		
		/// <summary>
		/// Returns a SysEfector ActiveRecord object related to this TamTratamiento
		/// 
		/// </summary>
		public DalRis.SysEfector SysEfector
		{
			get { return DalRis.SysEfector.FetchByID(this.IdEfectorTratante); }
			set { SetColumnValue("idEfectorTratante", value.IdEfector); }
		}
		
		
		/// <summary>
		/// Returns a TamTipoTratamiento ActiveRecord object related to this TamTratamiento
		/// 
		/// </summary>
		public DalRis.TamTipoTratamiento TamTipoTratamiento
		{
			get { return DalRis.TamTipoTratamiento.FetchByID(this.IdTipoTratamiento); }
			set { SetColumnValue("idTipoTratamiento", value.IdTipoTratamiento); }
		}
		
		
		/// <summary>
		/// Returns a TamEstadio ActiveRecord object related to this TamTratamiento
		/// 
		/// </summary>
		public DalRis.TamEstadio TamEstadio
		{
			get { return DalRis.TamEstadio.FetchByID(this.IdEstadio); }
			set { SetColumnValue("idEstadio", value.IdEstadio); }
		}
		
		
		/// <summary>
		/// Returns a TamRegistro ActiveRecord object related to this TamTratamiento
		/// 
		/// </summary>
		public DalRis.TamRegistro TamRegistro
		{
			get { return DalRis.TamRegistro.FetchByID(this.IdTam); }
			set { SetColumnValue("idTam", value.IdTam); }
		}
		
		
		/// <summary>
		/// Returns a SysProfesional ActiveRecord object related to this TamTratamiento
		/// 
		/// </summary>
		public DalRis.SysProfesional SysProfesional
		{
			get { return DalRis.SysProfesional.FetchByID(this.IdProfesionalTratante); }
			set { SetColumnValue("idProfesionalTratante", value.IdProfesional); }
		}
		
		
		#endregion
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(int varIdTam,int varIdPaciente,int varEdad,DateTime varFechaInicio,int varIdEstadio,string varGrado,int varIdTipoTratamiento,int varIdProfesionalTratante,int varIdEfectorTratante,string varObservaciones,string varCreatedBy,DateTime varCreatedOn,string varModifiedBy,DateTime varModifiedOn,bool varActivo)
		{
			TamTratamiento item = new TamTratamiento();
			
			item.IdTam = varIdTam;
			
			item.IdPaciente = varIdPaciente;
			
			item.Edad = varEdad;
			
			item.FechaInicio = varFechaInicio;
			
			item.IdEstadio = varIdEstadio;
			
			item.Grado = varGrado;
			
			item.IdTipoTratamiento = varIdTipoTratamiento;
			
			item.IdProfesionalTratante = varIdProfesionalTratante;
			
			item.IdEfectorTratante = varIdEfectorTratante;
			
			item.Observaciones = varObservaciones;
			
			item.CreatedBy = varCreatedBy;
			
			item.CreatedOn = varCreatedOn;
			
			item.ModifiedBy = varModifiedBy;
			
			item.ModifiedOn = varModifiedOn;
			
			item.Activo = varActivo;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varIdTratamiento,int varIdTam,int varIdPaciente,int varEdad,DateTime varFechaInicio,int varIdEstadio,string varGrado,int varIdTipoTratamiento,int varIdProfesionalTratante,int varIdEfectorTratante,string varObservaciones,string varCreatedBy,DateTime varCreatedOn,string varModifiedBy,DateTime varModifiedOn,bool varActivo)
		{
			TamTratamiento item = new TamTratamiento();
			
				item.IdTratamiento = varIdTratamiento;
			
				item.IdTam = varIdTam;
			
				item.IdPaciente = varIdPaciente;
			
				item.Edad = varEdad;
			
				item.FechaInicio = varFechaInicio;
			
				item.IdEstadio = varIdEstadio;
			
				item.Grado = varGrado;
			
				item.IdTipoTratamiento = varIdTipoTratamiento;
			
				item.IdProfesionalTratante = varIdProfesionalTratante;
			
				item.IdEfectorTratante = varIdEfectorTratante;
			
				item.Observaciones = varObservaciones;
			
				item.CreatedBy = varCreatedBy;
			
				item.CreatedOn = varCreatedOn;
			
				item.ModifiedBy = varModifiedBy;
			
				item.ModifiedOn = varModifiedOn;
			
				item.Activo = varActivo;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn IdTratamientoColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn IdTamColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn IdPacienteColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn EdadColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn FechaInicioColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn IdEstadioColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        public static TableSchema.TableColumn GradoColumn
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        public static TableSchema.TableColumn IdTipoTratamientoColumn
        {
            get { return Schema.Columns[7]; }
        }
        
        
        
        public static TableSchema.TableColumn IdProfesionalTratanteColumn
        {
            get { return Schema.Columns[8]; }
        }
        
        
        
        public static TableSchema.TableColumn IdEfectorTratanteColumn
        {
            get { return Schema.Columns[9]; }
        }
        
        
        
        public static TableSchema.TableColumn ObservacionesColumn
        {
            get { return Schema.Columns[10]; }
        }
        
        
        
        public static TableSchema.TableColumn CreatedByColumn
        {
            get { return Schema.Columns[11]; }
        }
        
        
        
        public static TableSchema.TableColumn CreatedOnColumn
        {
            get { return Schema.Columns[12]; }
        }
        
        
        
        public static TableSchema.TableColumn ModifiedByColumn
        {
            get { return Schema.Columns[13]; }
        }
        
        
        
        public static TableSchema.TableColumn ModifiedOnColumn
        {
            get { return Schema.Columns[14]; }
        }
        
        
        
        public static TableSchema.TableColumn ActivoColumn
        {
            get { return Schema.Columns[15]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string IdTratamiento = @"idTratamiento";
			 public static string IdTam = @"idTam";
			 public static string IdPaciente = @"idPaciente";
			 public static string Edad = @"edad";
			 public static string FechaInicio = @"fechaInicio";
			 public static string IdEstadio = @"idEstadio";
			 public static string Grado = @"grado";
			 public static string IdTipoTratamiento = @"idTipoTratamiento";
			 public static string IdProfesionalTratante = @"idProfesionalTratante";
			 public static string IdEfectorTratante = @"idEfectorTratante";
			 public static string Observaciones = @"observaciones";
			 public static string CreatedBy = @"CreatedBy";
			 public static string CreatedOn = @"CreatedOn";
			 public static string ModifiedBy = @"ModifiedBy";
			 public static string ModifiedOn = @"ModifiedOn";
			 public static string Activo = @"activo";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
