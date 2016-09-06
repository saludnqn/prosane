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
	/// Strongly-typed collection for the TamColposcopium class.
	/// </summary>
    [Serializable]
	public partial class TamColposcopiumCollection : ActiveList<TamColposcopium, TamColposcopiumCollection>
	{	   
		public TamColposcopiumCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>TamColposcopiumCollection</returns>
		public TamColposcopiumCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                TamColposcopium o = this[i];
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
	/// This is an ActiveRecord class which wraps the TAM_Colposcopia table.
	/// </summary>
	[Serializable]
	public partial class TamColposcopium : ActiveRecord<TamColposcopium>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public TamColposcopium()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public TamColposcopium(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public TamColposcopium(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public TamColposcopium(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("TAM_Colposcopia", TableType.Table, DataService.GetInstance("RisProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarIdColposcopia = new TableSchema.TableColumn(schema);
				colvarIdColposcopia.ColumnName = "idColposcopia";
				colvarIdColposcopia.DataType = DbType.Int32;
				colvarIdColposcopia.MaxLength = 0;
				colvarIdColposcopia.AutoIncrement = true;
				colvarIdColposcopia.IsNullable = false;
				colvarIdColposcopia.IsPrimaryKey = true;
				colvarIdColposcopia.IsForeignKey = false;
				colvarIdColposcopia.IsReadOnly = false;
				colvarIdColposcopia.DefaultSetting = @"";
				colvarIdColposcopia.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdColposcopia);
				
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
				
				TableSchema.TableColumn colvarFechaRealizacion = new TableSchema.TableColumn(schema);
				colvarFechaRealizacion.ColumnName = "fechaRealizacion";
				colvarFechaRealizacion.DataType = DbType.DateTime;
				colvarFechaRealizacion.MaxLength = 0;
				colvarFechaRealizacion.AutoIncrement = false;
				colvarFechaRealizacion.IsNullable = false;
				colvarFechaRealizacion.IsPrimaryKey = false;
				colvarFechaRealizacion.IsForeignKey = false;
				colvarFechaRealizacion.IsReadOnly = false;
				colvarFechaRealizacion.DefaultSetting = @"";
				colvarFechaRealizacion.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFechaRealizacion);
				
				TableSchema.TableColumn colvarEvaluacionGeneral = new TableSchema.TableColumn(schema);
				colvarEvaluacionGeneral.ColumnName = "evaluacionGeneral";
				colvarEvaluacionGeneral.DataType = DbType.Int32;
				colvarEvaluacionGeneral.MaxLength = 0;
				colvarEvaluacionGeneral.AutoIncrement = false;
				colvarEvaluacionGeneral.IsNullable = false;
				colvarEvaluacionGeneral.IsPrimaryKey = false;
				colvarEvaluacionGeneral.IsForeignKey = false;
				colvarEvaluacionGeneral.IsReadOnly = false;
				
						colvarEvaluacionGeneral.DefaultSetting = @"((0))";
				colvarEvaluacionGeneral.ForeignKeyTableName = "";
				schema.Columns.Add(colvarEvaluacionGeneral);
				
				TableSchema.TableColumn colvarProcedimiento = new TableSchema.TableColumn(schema);
				colvarProcedimiento.ColumnName = "procedimiento";
				colvarProcedimiento.DataType = DbType.AnsiString;
				colvarProcedimiento.MaxLength = 20;
				colvarProcedimiento.AutoIncrement = false;
				colvarProcedimiento.IsNullable = false;
				colvarProcedimiento.IsPrimaryKey = false;
				colvarProcedimiento.IsForeignKey = false;
				colvarProcedimiento.IsReadOnly = false;
				
						colvarProcedimiento.DefaultSetting = @"((0))";
				colvarProcedimiento.ForeignKeyTableName = "";
				schema.Columns.Add(colvarProcedimiento);
				
				TableSchema.TableColumn colvarIdProfesionalExamen = new TableSchema.TableColumn(schema);
				colvarIdProfesionalExamen.ColumnName = "idProfesionalExamen";
				colvarIdProfesionalExamen.DataType = DbType.Int32;
				colvarIdProfesionalExamen.MaxLength = 0;
				colvarIdProfesionalExamen.AutoIncrement = false;
				colvarIdProfesionalExamen.IsNullable = false;
				colvarIdProfesionalExamen.IsPrimaryKey = false;
				colvarIdProfesionalExamen.IsForeignKey = true;
				colvarIdProfesionalExamen.IsReadOnly = false;
				
						colvarIdProfesionalExamen.DefaultSetting = @"((0))";
				
					colvarIdProfesionalExamen.ForeignKeyTableName = "Sys_Profesional";
				schema.Columns.Add(colvarIdProfesionalExamen);
				
				TableSchema.TableColumn colvarIdEfectorExamen = new TableSchema.TableColumn(schema);
				colvarIdEfectorExamen.ColumnName = "idEfectorExamen";
				colvarIdEfectorExamen.DataType = DbType.Int32;
				colvarIdEfectorExamen.MaxLength = 0;
				colvarIdEfectorExamen.AutoIncrement = false;
				colvarIdEfectorExamen.IsNullable = false;
				colvarIdEfectorExamen.IsPrimaryKey = false;
				colvarIdEfectorExamen.IsForeignKey = true;
				colvarIdEfectorExamen.IsReadOnly = false;
				
						colvarIdEfectorExamen.DefaultSetting = @"((0))";
				
					colvarIdEfectorExamen.ForeignKeyTableName = "Sys_Efector";
				schema.Columns.Add(colvarIdEfectorExamen);
				
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
				
				TableSchema.TableColumn colvarZonaTransformacion = new TableSchema.TableColumn(schema);
				colvarZonaTransformacion.ColumnName = "zonaTransformacion";
				colvarZonaTransformacion.DataType = DbType.Int32;
				colvarZonaTransformacion.MaxLength = 0;
				colvarZonaTransformacion.AutoIncrement = false;
				colvarZonaTransformacion.IsNullable = false;
				colvarZonaTransformacion.IsPrimaryKey = false;
				colvarZonaTransformacion.IsForeignKey = false;
				colvarZonaTransformacion.IsReadOnly = false;
				
						colvarZonaTransformacion.DefaultSetting = @"((0))";
				colvarZonaTransformacion.ForeignKeyTableName = "";
				schema.Columns.Add(colvarZonaTransformacion);
				
				TableSchema.TableColumn colvarIdHallazgosColposcopicos = new TableSchema.TableColumn(schema);
				colvarIdHallazgosColposcopicos.ColumnName = "idHallazgosColposcopicos";
				colvarIdHallazgosColposcopicos.DataType = DbType.Int32;
				colvarIdHallazgosColposcopicos.MaxLength = 0;
				colvarIdHallazgosColposcopicos.AutoIncrement = false;
				colvarIdHallazgosColposcopicos.IsNullable = false;
				colvarIdHallazgosColposcopicos.IsPrimaryKey = false;
				colvarIdHallazgosColposcopicos.IsForeignKey = true;
				colvarIdHallazgosColposcopicos.IsReadOnly = false;
				
						colvarIdHallazgosColposcopicos.DefaultSetting = @"((0))";
				
					colvarIdHallazgosColposcopicos.ForeignKeyTableName = "TAM_HallazgosColposcopicos";
				schema.Columns.Add(colvarIdHallazgosColposcopicos);
				
				TableSchema.TableColumn colvarTomoBiopsia = new TableSchema.TableColumn(schema);
				colvarTomoBiopsia.ColumnName = "tomoBiopsia";
				colvarTomoBiopsia.DataType = DbType.Int32;
				colvarTomoBiopsia.MaxLength = 0;
				colvarTomoBiopsia.AutoIncrement = false;
				colvarTomoBiopsia.IsNullable = false;
				colvarTomoBiopsia.IsPrimaryKey = false;
				colvarTomoBiopsia.IsForeignKey = false;
				colvarTomoBiopsia.IsReadOnly = false;
				
						colvarTomoBiopsia.DefaultSetting = @"((0))";
				colvarTomoBiopsia.ForeignKeyTableName = "";
				schema.Columns.Add(colvarTomoBiopsia);
				
				TableSchema.TableColumn colvarEcc = new TableSchema.TableColumn(schema);
				colvarEcc.ColumnName = "Ecc";
				colvarEcc.DataType = DbType.Int32;
				colvarEcc.MaxLength = 0;
				colvarEcc.AutoIncrement = false;
				colvarEcc.IsNullable = false;
				colvarEcc.IsPrimaryKey = false;
				colvarEcc.IsForeignKey = false;
				colvarEcc.IsReadOnly = false;
				
						colvarEcc.DefaultSetting = @"((0))";
				colvarEcc.ForeignKeyTableName = "";
				schema.Columns.Add(colvarEcc);
				
				TableSchema.TableColumn colvarTestSchiller = new TableSchema.TableColumn(schema);
				colvarTestSchiller.ColumnName = "testSchiller";
				colvarTestSchiller.DataType = DbType.AnsiString;
				colvarTestSchiller.MaxLength = 10;
				colvarTestSchiller.AutoIncrement = false;
				colvarTestSchiller.IsNullable = false;
				colvarTestSchiller.IsPrimaryKey = false;
				colvarTestSchiller.IsForeignKey = false;
				colvarTestSchiller.IsReadOnly = false;
				
						colvarTestSchiller.DefaultSetting = @"('')";
				colvarTestSchiller.ForeignKeyTableName = "";
				schema.Columns.Add(colvarTestSchiller);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["RisProvider"].AddSchema("TAM_Colposcopia",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("IdColposcopia")]
		[Bindable(true)]
		public int IdColposcopia 
		{
			get { return GetColumnValue<int>(Columns.IdColposcopia); }
			set { SetColumnValue(Columns.IdColposcopia, value); }
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
		  
		[XmlAttribute("FechaRealizacion")]
		[Bindable(true)]
		public DateTime FechaRealizacion 
		{
			get { return GetColumnValue<DateTime>(Columns.FechaRealizacion); }
			set { SetColumnValue(Columns.FechaRealizacion, value); }
		}
		  
		[XmlAttribute("EvaluacionGeneral")]
		[Bindable(true)]
		public int EvaluacionGeneral 
		{
			get { return GetColumnValue<int>(Columns.EvaluacionGeneral); }
			set { SetColumnValue(Columns.EvaluacionGeneral, value); }
		}
		  
		[XmlAttribute("Procedimiento")]
		[Bindable(true)]
		public string Procedimiento 
		{
			get { return GetColumnValue<string>(Columns.Procedimiento); }
			set { SetColumnValue(Columns.Procedimiento, value); }
		}
		  
		[XmlAttribute("IdProfesionalExamen")]
		[Bindable(true)]
		public int IdProfesionalExamen 
		{
			get { return GetColumnValue<int>(Columns.IdProfesionalExamen); }
			set { SetColumnValue(Columns.IdProfesionalExamen, value); }
		}
		  
		[XmlAttribute("IdEfectorExamen")]
		[Bindable(true)]
		public int IdEfectorExamen 
		{
			get { return GetColumnValue<int>(Columns.IdEfectorExamen); }
			set { SetColumnValue(Columns.IdEfectorExamen, value); }
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
		  
		[XmlAttribute("ZonaTransformacion")]
		[Bindable(true)]
		public int ZonaTransformacion 
		{
			get { return GetColumnValue<int>(Columns.ZonaTransformacion); }
			set { SetColumnValue(Columns.ZonaTransformacion, value); }
		}
		  
		[XmlAttribute("IdHallazgosColposcopicos")]
		[Bindable(true)]
		public int IdHallazgosColposcopicos 
		{
			get { return GetColumnValue<int>(Columns.IdHallazgosColposcopicos); }
			set { SetColumnValue(Columns.IdHallazgosColposcopicos, value); }
		}
		  
		[XmlAttribute("TomoBiopsia")]
		[Bindable(true)]
		public int TomoBiopsia 
		{
			get { return GetColumnValue<int>(Columns.TomoBiopsia); }
			set { SetColumnValue(Columns.TomoBiopsia, value); }
		}
		  
		[XmlAttribute("Ecc")]
		[Bindable(true)]
		public int Ecc 
		{
			get { return GetColumnValue<int>(Columns.Ecc); }
			set { SetColumnValue(Columns.Ecc, value); }
		}
		  
		[XmlAttribute("TestSchiller")]
		[Bindable(true)]
		public string TestSchiller 
		{
			get { return GetColumnValue<string>(Columns.TestSchiller); }
			set { SetColumnValue(Columns.TestSchiller, value); }
		}
		
		#endregion
		
		
			
		
		#region ForeignKey Properties
		
		/// <summary>
		/// Returns a SysEfector ActiveRecord object related to this TamColposcopium
		/// 
		/// </summary>
		public DalRis.SysEfector SysEfector
		{
			get { return DalRis.SysEfector.FetchByID(this.IdEfectorExamen); }
			set { SetColumnValue("idEfectorExamen", value.IdEfector); }
		}
		
		
		/// <summary>
		/// Returns a TamHallazgosColposcopico ActiveRecord object related to this TamColposcopium
		/// 
		/// </summary>
		public DalRis.TamHallazgosColposcopico TamHallazgosColposcopico
		{
			get { return DalRis.TamHallazgosColposcopico.FetchByID(this.IdHallazgosColposcopicos); }
			set { SetColumnValue("idHallazgosColposcopicos", value.IdHallazgosColposcopicos); }
		}
		
		
		/// <summary>
		/// Returns a TamRegistro ActiveRecord object related to this TamColposcopium
		/// 
		/// </summary>
		public DalRis.TamRegistro TamRegistro
		{
			get { return DalRis.TamRegistro.FetchByID(this.IdTam); }
			set { SetColumnValue("idTam", value.IdTam); }
		}
		
		
		/// <summary>
		/// Returns a SysProfesional ActiveRecord object related to this TamColposcopium
		/// 
		/// </summary>
		public DalRis.SysProfesional SysProfesional
		{
			get { return DalRis.SysProfesional.FetchByID(this.IdProfesionalExamen); }
			set { SetColumnValue("idProfesionalExamen", value.IdProfesional); }
		}
		
		
		#endregion
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(int varIdTam,int varIdPaciente,int varEdad,DateTime varFechaRealizacion,int varEvaluacionGeneral,string varProcedimiento,int varIdProfesionalExamen,int varIdEfectorExamen,string varObservaciones,string varCreatedBy,DateTime varCreatedOn,string varModifiedBy,DateTime varModifiedOn,bool varActivo,int varZonaTransformacion,int varIdHallazgosColposcopicos,int varTomoBiopsia,int varEcc,string varTestSchiller)
		{
			TamColposcopium item = new TamColposcopium();
			
			item.IdTam = varIdTam;
			
			item.IdPaciente = varIdPaciente;
			
			item.Edad = varEdad;
			
			item.FechaRealizacion = varFechaRealizacion;
			
			item.EvaluacionGeneral = varEvaluacionGeneral;
			
			item.Procedimiento = varProcedimiento;
			
			item.IdProfesionalExamen = varIdProfesionalExamen;
			
			item.IdEfectorExamen = varIdEfectorExamen;
			
			item.Observaciones = varObservaciones;
			
			item.CreatedBy = varCreatedBy;
			
			item.CreatedOn = varCreatedOn;
			
			item.ModifiedBy = varModifiedBy;
			
			item.ModifiedOn = varModifiedOn;
			
			item.Activo = varActivo;
			
			item.ZonaTransformacion = varZonaTransformacion;
			
			item.IdHallazgosColposcopicos = varIdHallazgosColposcopicos;
			
			item.TomoBiopsia = varTomoBiopsia;
			
			item.Ecc = varEcc;
			
			item.TestSchiller = varTestSchiller;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varIdColposcopia,int varIdTam,int varIdPaciente,int varEdad,DateTime varFechaRealizacion,int varEvaluacionGeneral,string varProcedimiento,int varIdProfesionalExamen,int varIdEfectorExamen,string varObservaciones,string varCreatedBy,DateTime varCreatedOn,string varModifiedBy,DateTime varModifiedOn,bool varActivo,int varZonaTransformacion,int varIdHallazgosColposcopicos,int varTomoBiopsia,int varEcc,string varTestSchiller)
		{
			TamColposcopium item = new TamColposcopium();
			
				item.IdColposcopia = varIdColposcopia;
			
				item.IdTam = varIdTam;
			
				item.IdPaciente = varIdPaciente;
			
				item.Edad = varEdad;
			
				item.FechaRealizacion = varFechaRealizacion;
			
				item.EvaluacionGeneral = varEvaluacionGeneral;
			
				item.Procedimiento = varProcedimiento;
			
				item.IdProfesionalExamen = varIdProfesionalExamen;
			
				item.IdEfectorExamen = varIdEfectorExamen;
			
				item.Observaciones = varObservaciones;
			
				item.CreatedBy = varCreatedBy;
			
				item.CreatedOn = varCreatedOn;
			
				item.ModifiedBy = varModifiedBy;
			
				item.ModifiedOn = varModifiedOn;
			
				item.Activo = varActivo;
			
				item.ZonaTransformacion = varZonaTransformacion;
			
				item.IdHallazgosColposcopicos = varIdHallazgosColposcopicos;
			
				item.TomoBiopsia = varTomoBiopsia;
			
				item.Ecc = varEcc;
			
				item.TestSchiller = varTestSchiller;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn IdColposcopiaColumn
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
        
        
        
        public static TableSchema.TableColumn FechaRealizacionColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn EvaluacionGeneralColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        public static TableSchema.TableColumn ProcedimientoColumn
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        public static TableSchema.TableColumn IdProfesionalExamenColumn
        {
            get { return Schema.Columns[7]; }
        }
        
        
        
        public static TableSchema.TableColumn IdEfectorExamenColumn
        {
            get { return Schema.Columns[8]; }
        }
        
        
        
        public static TableSchema.TableColumn ObservacionesColumn
        {
            get { return Schema.Columns[9]; }
        }
        
        
        
        public static TableSchema.TableColumn CreatedByColumn
        {
            get { return Schema.Columns[10]; }
        }
        
        
        
        public static TableSchema.TableColumn CreatedOnColumn
        {
            get { return Schema.Columns[11]; }
        }
        
        
        
        public static TableSchema.TableColumn ModifiedByColumn
        {
            get { return Schema.Columns[12]; }
        }
        
        
        
        public static TableSchema.TableColumn ModifiedOnColumn
        {
            get { return Schema.Columns[13]; }
        }
        
        
        
        public static TableSchema.TableColumn ActivoColumn
        {
            get { return Schema.Columns[14]; }
        }
        
        
        
        public static TableSchema.TableColumn ZonaTransformacionColumn
        {
            get { return Schema.Columns[15]; }
        }
        
        
        
        public static TableSchema.TableColumn IdHallazgosColposcopicosColumn
        {
            get { return Schema.Columns[16]; }
        }
        
        
        
        public static TableSchema.TableColumn TomoBiopsiaColumn
        {
            get { return Schema.Columns[17]; }
        }
        
        
        
        public static TableSchema.TableColumn EccColumn
        {
            get { return Schema.Columns[18]; }
        }
        
        
        
        public static TableSchema.TableColumn TestSchillerColumn
        {
            get { return Schema.Columns[19]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string IdColposcopia = @"idColposcopia";
			 public static string IdTam = @"idTam";
			 public static string IdPaciente = @"idPaciente";
			 public static string Edad = @"edad";
			 public static string FechaRealizacion = @"fechaRealizacion";
			 public static string EvaluacionGeneral = @"evaluacionGeneral";
			 public static string Procedimiento = @"procedimiento";
			 public static string IdProfesionalExamen = @"idProfesionalExamen";
			 public static string IdEfectorExamen = @"idEfectorExamen";
			 public static string Observaciones = @"observaciones";
			 public static string CreatedBy = @"CreatedBy";
			 public static string CreatedOn = @"CreatedOn";
			 public static string ModifiedBy = @"ModifiedBy";
			 public static string ModifiedOn = @"ModifiedOn";
			 public static string Activo = @"activo";
			 public static string ZonaTransformacion = @"zonaTransformacion";
			 public static string IdHallazgosColposcopicos = @"idHallazgosColposcopicos";
			 public static string TomoBiopsia = @"tomoBiopsia";
			 public static string Ecc = @"Ecc";
			 public static string TestSchiller = @"testSchiller";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
