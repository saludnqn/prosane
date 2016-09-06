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
	/// Strongly-typed collection for the TamRegistro class.
	/// </summary>
    [Serializable]
	public partial class TamRegistroCollection : ActiveList<TamRegistro, TamRegistroCollection>
	{	   
		public TamRegistroCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>TamRegistroCollection</returns>
		public TamRegistroCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                TamRegistro o = this[i];
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
	/// This is an ActiveRecord class which wraps the TAM_Registro table.
	/// </summary>
	[Serializable]
	public partial class TamRegistro : ActiveRecord<TamRegistro>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public TamRegistro()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public TamRegistro(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public TamRegistro(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public TamRegistro(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("TAM_Registro", TableType.Table, DataService.GetInstance("RisProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarIdTam = new TableSchema.TableColumn(schema);
				colvarIdTam.ColumnName = "idTam";
				colvarIdTam.DataType = DbType.Int32;
				colvarIdTam.MaxLength = 0;
				colvarIdTam.AutoIncrement = true;
				colvarIdTam.IsNullable = false;
				colvarIdTam.IsPrimaryKey = true;
				colvarIdTam.IsForeignKey = false;
				colvarIdTam.IsReadOnly = false;
				colvarIdTam.DefaultSetting = @"";
				colvarIdTam.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdTam);
				
				TableSchema.TableColumn colvarIdPaciente = new TableSchema.TableColumn(schema);
				colvarIdPaciente.ColumnName = "idPaciente";
				colvarIdPaciente.DataType = DbType.Int32;
				colvarIdPaciente.MaxLength = 0;
				colvarIdPaciente.AutoIncrement = false;
				colvarIdPaciente.IsNullable = false;
				colvarIdPaciente.IsPrimaryKey = false;
				colvarIdPaciente.IsForeignKey = true;
				colvarIdPaciente.IsReadOnly = false;
				
						colvarIdPaciente.DefaultSetting = @"((0))";
				
					colvarIdPaciente.ForeignKeyTableName = "Sys_Paciente";
				schema.Columns.Add(colvarIdPaciente);
				
				TableSchema.TableColumn colvarIdEfectorReferencia = new TableSchema.TableColumn(schema);
				colvarIdEfectorReferencia.ColumnName = "idEfectorReferencia";
				colvarIdEfectorReferencia.DataType = DbType.Int32;
				colvarIdEfectorReferencia.MaxLength = 0;
				colvarIdEfectorReferencia.AutoIncrement = false;
				colvarIdEfectorReferencia.IsNullable = false;
				colvarIdEfectorReferencia.IsPrimaryKey = false;
				colvarIdEfectorReferencia.IsForeignKey = true;
				colvarIdEfectorReferencia.IsReadOnly = false;
				
						colvarIdEfectorReferencia.DefaultSetting = @"((0))";
				
					colvarIdEfectorReferencia.ForeignKeyTableName = "Sys_Efector";
				schema.Columns.Add(colvarIdEfectorReferencia);
				
				TableSchema.TableColumn colvarNumeroFicha = new TableSchema.TableColumn(schema);
				colvarNumeroFicha.ColumnName = "numeroFicha";
				colvarNumeroFicha.DataType = DbType.Int32;
				colvarNumeroFicha.MaxLength = 0;
				colvarNumeroFicha.AutoIncrement = false;
				colvarNumeroFicha.IsNullable = false;
				colvarNumeroFicha.IsPrimaryKey = false;
				colvarNumeroFicha.IsForeignKey = false;
				colvarNumeroFicha.IsReadOnly = false;
				
						colvarNumeroFicha.DefaultSetting = @"((0))";
				colvarNumeroFicha.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNumeroFicha);
				
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
				
				TableSchema.TableColumn colvarObservaciones = new TableSchema.TableColumn(schema);
				colvarObservaciones.ColumnName = "observaciones";
				colvarObservaciones.DataType = DbType.AnsiString;
				colvarObservaciones.MaxLength = 200;
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
				DataService.Providers["RisProvider"].AddSchema("TAM_Registro",schema);
			}
		}
		#endregion
		
		#region Props
		  
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
		  
		[XmlAttribute("IdEfectorReferencia")]
		[Bindable(true)]
		public int IdEfectorReferencia 
		{
			get { return GetColumnValue<int>(Columns.IdEfectorReferencia); }
			set { SetColumnValue(Columns.IdEfectorReferencia, value); }
		}
		  
		[XmlAttribute("NumeroFicha")]
		[Bindable(true)]
		public int NumeroFicha 
		{
			get { return GetColumnValue<int>(Columns.NumeroFicha); }
			set { SetColumnValue(Columns.NumeroFicha, value); }
		}
		  
		[XmlAttribute("Edad")]
		[Bindable(true)]
		public int Edad 
		{
			get { return GetColumnValue<int>(Columns.Edad); }
			set { SetColumnValue(Columns.Edad, value); }
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
		
		
		#region PrimaryKey Methods		
		
        protected override void SetPrimaryKey(object oValue)
        {
            base.SetPrimaryKey(oValue);
            
            SetPKValues();
        }
        
		
		private DalRis.TamBiopsiumCollection colTamBiopsia;
		public DalRis.TamBiopsiumCollection TamBiopsia()
		{
			if(colTamBiopsia == null)
			{
				colTamBiopsia = new DalRis.TamBiopsiumCollection().Where(TamBiopsium.Columns.IdTam, IdTam).Load();
				colTamBiopsia.ListChanged += new ListChangedEventHandler(colTamBiopsia_ListChanged);
			}
			return colTamBiopsia;
		}
				
		void colTamBiopsia_ListChanged(object sender, ListChangedEventArgs e)
		{
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
		        // Set foreign key value
		        colTamBiopsia[e.NewIndex].IdTam = IdTam;
				colTamBiopsia.ListChanged += new ListChangedEventHandler(colTamBiopsia_ListChanged);
            }
		}
		private DalRis.TamColposcopiumCollection colTamColposcopia;
		public DalRis.TamColposcopiumCollection TamColposcopia()
		{
			if(colTamColposcopia == null)
			{
				colTamColposcopia = new DalRis.TamColposcopiumCollection().Where(TamColposcopium.Columns.IdTam, IdTam).Load();
				colTamColposcopia.ListChanged += new ListChangedEventHandler(colTamColposcopia_ListChanged);
			}
			return colTamColposcopia;
		}
				
		void colTamColposcopia_ListChanged(object sender, ListChangedEventArgs e)
		{
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
		        // Set foreign key value
		        colTamColposcopia[e.NewIndex].IdTam = IdTam;
				colTamColposcopia.ListChanged += new ListChangedEventHandler(colTamColposcopia_ListChanged);
            }
		}
		private DalRis.TamHpvCollection colTamHpvRecords;
		public DalRis.TamHpvCollection TamHpvRecords()
		{
			if(colTamHpvRecords == null)
			{
				colTamHpvRecords = new DalRis.TamHpvCollection().Where(TamHpv.Columns.IdTam, IdTam).Load();
				colTamHpvRecords.ListChanged += new ListChangedEventHandler(colTamHpvRecords_ListChanged);
			}
			return colTamHpvRecords;
		}
				
		void colTamHpvRecords_ListChanged(object sender, ListChangedEventArgs e)
		{
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
		        // Set foreign key value
		        colTamHpvRecords[e.NewIndex].IdTam = IdTam;
				colTamHpvRecords.ListChanged += new ListChangedEventHandler(colTamHpvRecords_ListChanged);
            }
		}
		private DalRis.TamPapCollection colTamPapRecords;
		public DalRis.TamPapCollection TamPapRecords()
		{
			if(colTamPapRecords == null)
			{
				colTamPapRecords = new DalRis.TamPapCollection().Where(TamPap.Columns.IdTam, IdTam).Load();
				colTamPapRecords.ListChanged += new ListChangedEventHandler(colTamPapRecords_ListChanged);
			}
			return colTamPapRecords;
		}
				
		void colTamPapRecords_ListChanged(object sender, ListChangedEventArgs e)
		{
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
		        // Set foreign key value
		        colTamPapRecords[e.NewIndex].IdTam = IdTam;
				colTamPapRecords.ListChanged += new ListChangedEventHandler(colTamPapRecords_ListChanged);
            }
		}
		private DalRis.TamTratamientoCollection colTamTratamientos;
		public DalRis.TamTratamientoCollection TamTratamientos()
		{
			if(colTamTratamientos == null)
			{
				colTamTratamientos = new DalRis.TamTratamientoCollection().Where(TamTratamiento.Columns.IdTam, IdTam).Load();
				colTamTratamientos.ListChanged += new ListChangedEventHandler(colTamTratamientos_ListChanged);
			}
			return colTamTratamientos;
		}
				
		void colTamTratamientos_ListChanged(object sender, ListChangedEventArgs e)
		{
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
		        // Set foreign key value
		        colTamTratamientos[e.NewIndex].IdTam = IdTam;
				colTamTratamientos.ListChanged += new ListChangedEventHandler(colTamTratamientos_ListChanged);
            }
		}
		#endregion
		
			
		
		#region ForeignKey Properties
		
		/// <summary>
		/// Returns a SysEfector ActiveRecord object related to this TamRegistro
		/// 
		/// </summary>
		public DalRis.SysEfector SysEfector
		{
			get { return DalRis.SysEfector.FetchByID(this.IdEfectorReferencia); }
			set { SetColumnValue("idEfectorReferencia", value.IdEfector); }
		}
		
		
		/// <summary>
		/// Returns a SysPaciente ActiveRecord object related to this TamRegistro
		/// 
		/// </summary>
		public DalRis.SysPaciente SysPaciente
		{
			get { return DalRis.SysPaciente.FetchByID(this.IdPaciente); }
			set { SetColumnValue("idPaciente", value.IdPaciente); }
		}
		
		
		#endregion
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(int varIdPaciente,int varIdEfectorReferencia,int varNumeroFicha,int varEdad,string varObservaciones,string varCreatedBy,DateTime varCreatedOn,string varModifiedBy,DateTime varModifiedOn,bool varActivo)
		{
			TamRegistro item = new TamRegistro();
			
			item.IdPaciente = varIdPaciente;
			
			item.IdEfectorReferencia = varIdEfectorReferencia;
			
			item.NumeroFicha = varNumeroFicha;
			
			item.Edad = varEdad;
			
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
		public static void Update(int varIdTam,int varIdPaciente,int varIdEfectorReferencia,int varNumeroFicha,int varEdad,string varObservaciones,string varCreatedBy,DateTime varCreatedOn,string varModifiedBy,DateTime varModifiedOn,bool varActivo)
		{
			TamRegistro item = new TamRegistro();
			
				item.IdTam = varIdTam;
			
				item.IdPaciente = varIdPaciente;
			
				item.IdEfectorReferencia = varIdEfectorReferencia;
			
				item.NumeroFicha = varNumeroFicha;
			
				item.Edad = varEdad;
			
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
        
        
        public static TableSchema.TableColumn IdTamColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn IdPacienteColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn IdEfectorReferenciaColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn NumeroFichaColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn EdadColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn ObservacionesColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        public static TableSchema.TableColumn CreatedByColumn
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        public static TableSchema.TableColumn CreatedOnColumn
        {
            get { return Schema.Columns[7]; }
        }
        
        
        
        public static TableSchema.TableColumn ModifiedByColumn
        {
            get { return Schema.Columns[8]; }
        }
        
        
        
        public static TableSchema.TableColumn ModifiedOnColumn
        {
            get { return Schema.Columns[9]; }
        }
        
        
        
        public static TableSchema.TableColumn ActivoColumn
        {
            get { return Schema.Columns[10]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string IdTam = @"idTam";
			 public static string IdPaciente = @"idPaciente";
			 public static string IdEfectorReferencia = @"idEfectorReferencia";
			 public static string NumeroFicha = @"numeroFicha";
			 public static string Edad = @"edad";
			 public static string Observaciones = @"observaciones";
			 public static string CreatedBy = @"CreatedBy";
			 public static string CreatedOn = @"CreatedOn";
			 public static string ModifiedBy = @"ModifiedBy";
			 public static string ModifiedOn = @"ModifiedOn";
			 public static string Activo = @"activo";
						
		}
		#endregion
		
		#region Update PK Collections
		
        public void SetPKValues()
        {
                if (colTamBiopsia != null)
                {
                    foreach (DalRis.TamBiopsium item in colTamBiopsia)
                    {
                        if (item.IdTam != IdTam)
                        {
                            item.IdTam = IdTam;
                        }
                    }
               }
		
                if (colTamColposcopia != null)
                {
                    foreach (DalRis.TamColposcopium item in colTamColposcopia)
                    {
                        if (item.IdTam != IdTam)
                        {
                            item.IdTam = IdTam;
                        }
                    }
               }
		
                if (colTamHpvRecords != null)
                {
                    foreach (DalRis.TamHpv item in colTamHpvRecords)
                    {
                        if (item.IdTam != IdTam)
                        {
                            item.IdTam = IdTam;
                        }
                    }
               }
		
                if (colTamPapRecords != null)
                {
                    foreach (DalRis.TamPap item in colTamPapRecords)
                    {
                        if (item.IdTam != IdTam)
                        {
                            item.IdTam = IdTam;
                        }
                    }
               }
		
                if (colTamTratamientos != null)
                {
                    foreach (DalRis.TamTratamiento item in colTamTratamientos)
                    {
                        if (item.IdTam != IdTam)
                        {
                            item.IdTam = IdTam;
                        }
                    }
               }
		}
        #endregion
    
        #region Deep Save
		
        public void DeepSave()
        {
            Save();
            
                if (colTamBiopsia != null)
                {
                    colTamBiopsia.SaveAll();
               }
		
                if (colTamColposcopia != null)
                {
                    colTamColposcopia.SaveAll();
               }
		
                if (colTamHpvRecords != null)
                {
                    colTamHpvRecords.SaveAll();
               }
		
                if (colTamPapRecords != null)
                {
                    colTamPapRecords.SaveAll();
               }
		
                if (colTamTratamientos != null)
                {
                    colTamTratamientos.SaveAll();
               }
		}
        #endregion
	}
}
