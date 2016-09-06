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
	/// Strongly-typed collection for the AprControlNiñoSanoConsultorio class.
	/// </summary>
    [Serializable]
	public partial class AprControlNiñoSanoConsultorioCollection : ActiveList<AprControlNiñoSanoConsultorio, AprControlNiñoSanoConsultorioCollection>
	{	   
		public AprControlNiñoSanoConsultorioCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>AprControlNiñoSanoConsultorioCollection</returns>
		public AprControlNiñoSanoConsultorioCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                AprControlNiñoSanoConsultorio o = this[i];
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
	/// This is an ActiveRecord class which wraps the APR_ControlNiñoSanoConsultorio table.
	/// </summary>
	[Serializable]
	public partial class AprControlNiñoSanoConsultorio : ActiveRecord<AprControlNiñoSanoConsultorio>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public AprControlNiñoSanoConsultorio()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public AprControlNiñoSanoConsultorio(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public AprControlNiñoSanoConsultorio(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public AprControlNiñoSanoConsultorio(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("APR_ControlNiñoSanoConsultorio", TableType.Table, DataService.GetInstance("RisProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarIdControlNiñoSanoConsultorio = new TableSchema.TableColumn(schema);
				colvarIdControlNiñoSanoConsultorio.ColumnName = "idControlNiñoSanoConsultorio";
				colvarIdControlNiñoSanoConsultorio.DataType = DbType.Int32;
				colvarIdControlNiñoSanoConsultorio.MaxLength = 0;
				colvarIdControlNiñoSanoConsultorio.AutoIncrement = true;
				colvarIdControlNiñoSanoConsultorio.IsNullable = false;
				colvarIdControlNiñoSanoConsultorio.IsPrimaryKey = true;
				colvarIdControlNiñoSanoConsultorio.IsForeignKey = false;
				colvarIdControlNiñoSanoConsultorio.IsReadOnly = false;
				colvarIdControlNiñoSanoConsultorio.DefaultSetting = @"";
				colvarIdControlNiñoSanoConsultorio.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdControlNiñoSanoConsultorio);
				
				TableSchema.TableColumn colvarIdControlNiñoSano = new TableSchema.TableColumn(schema);
				colvarIdControlNiñoSano.ColumnName = "idControlNiñoSano";
				colvarIdControlNiñoSano.DataType = DbType.Int32;
				colvarIdControlNiñoSano.MaxLength = 0;
				colvarIdControlNiñoSano.AutoIncrement = false;
				colvarIdControlNiñoSano.IsNullable = false;
				colvarIdControlNiñoSano.IsPrimaryKey = false;
				colvarIdControlNiñoSano.IsForeignKey = true;
				colvarIdControlNiñoSano.IsReadOnly = false;
				colvarIdControlNiñoSano.DefaultSetting = @"";
				
					colvarIdControlNiñoSano.ForeignKeyTableName = "APR_ControlNiñoSano";
				schema.Columns.Add(colvarIdControlNiñoSano);
				
				TableSchema.TableColumn colvarIdTipoLactancia = new TableSchema.TableColumn(schema);
				colvarIdTipoLactancia.ColumnName = "idTipoLactancia";
				colvarIdTipoLactancia.DataType = DbType.Int32;
				colvarIdTipoLactancia.MaxLength = 0;
				colvarIdTipoLactancia.AutoIncrement = false;
				colvarIdTipoLactancia.IsNullable = true;
				colvarIdTipoLactancia.IsPrimaryKey = false;
				colvarIdTipoLactancia.IsForeignKey = true;
				colvarIdTipoLactancia.IsReadOnly = false;
				colvarIdTipoLactancia.DefaultSetting = @"";
				
					colvarIdTipoLactancia.ForeignKeyTableName = "APR_TipoLactancia";
				schema.Columns.Add(colvarIdTipoLactancia);
				
				TableSchema.TableColumn colvarIdIntervencion = new TableSchema.TableColumn(schema);
				colvarIdIntervencion.ColumnName = "idIntervencion";
				colvarIdIntervencion.DataType = DbType.Int32;
				colvarIdIntervencion.MaxLength = 0;
				colvarIdIntervencion.AutoIncrement = false;
				colvarIdIntervencion.IsNullable = true;
				colvarIdIntervencion.IsPrimaryKey = false;
				colvarIdIntervencion.IsForeignKey = true;
				colvarIdIntervencion.IsReadOnly = false;
				colvarIdIntervencion.DefaultSetting = @"";
				
					colvarIdIntervencion.ForeignKeyTableName = "APR_Intervencion";
				schema.Columns.Add(colvarIdIntervencion);
				
				TableSchema.TableColumn colvarFechaProximoControl = new TableSchema.TableColumn(schema);
				colvarFechaProximoControl.ColumnName = "FechaProximoControl";
				colvarFechaProximoControl.DataType = DbType.DateTime;
				colvarFechaProximoControl.MaxLength = 0;
				colvarFechaProximoControl.AutoIncrement = false;
				colvarFechaProximoControl.IsNullable = true;
				colvarFechaProximoControl.IsPrimaryKey = false;
				colvarFechaProximoControl.IsForeignKey = false;
				colvarFechaProximoControl.IsReadOnly = false;
				colvarFechaProximoControl.DefaultSetting = @"";
				colvarFechaProximoControl.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFechaProximoControl);
				
				TableSchema.TableColumn colvarObservacion = new TableSchema.TableColumn(schema);
				colvarObservacion.ColumnName = "Observacion";
				colvarObservacion.DataType = DbType.AnsiString;
				colvarObservacion.MaxLength = 2147483647;
				colvarObservacion.AutoIncrement = false;
				colvarObservacion.IsNullable = true;
				colvarObservacion.IsPrimaryKey = false;
				colvarObservacion.IsForeignKey = false;
				colvarObservacion.IsReadOnly = false;
				colvarObservacion.DefaultSetting = @"";
				colvarObservacion.ForeignKeyTableName = "";
				schema.Columns.Add(colvarObservacion);
				
				TableSchema.TableColumn colvarCreatedBy = new TableSchema.TableColumn(schema);
				colvarCreatedBy.ColumnName = "CreatedBy";
				colvarCreatedBy.DataType = DbType.AnsiString;
				colvarCreatedBy.MaxLength = 50;
				colvarCreatedBy.AutoIncrement = false;
				colvarCreatedBy.IsNullable = true;
				colvarCreatedBy.IsPrimaryKey = false;
				colvarCreatedBy.IsForeignKey = false;
				colvarCreatedBy.IsReadOnly = false;
				colvarCreatedBy.DefaultSetting = @"";
				colvarCreatedBy.ForeignKeyTableName = "";
				schema.Columns.Add(colvarCreatedBy);
				
				TableSchema.TableColumn colvarCreatedOn = new TableSchema.TableColumn(schema);
				colvarCreatedOn.ColumnName = "CreatedOn";
				colvarCreatedOn.DataType = DbType.DateTime;
				colvarCreatedOn.MaxLength = 0;
				colvarCreatedOn.AutoIncrement = false;
				colvarCreatedOn.IsNullable = true;
				colvarCreatedOn.IsPrimaryKey = false;
				colvarCreatedOn.IsForeignKey = false;
				colvarCreatedOn.IsReadOnly = false;
				colvarCreatedOn.DefaultSetting = @"";
				colvarCreatedOn.ForeignKeyTableName = "";
				schema.Columns.Add(colvarCreatedOn);
				
				TableSchema.TableColumn colvarModifiedBy = new TableSchema.TableColumn(schema);
				colvarModifiedBy.ColumnName = "ModifiedBy";
				colvarModifiedBy.DataType = DbType.AnsiString;
				colvarModifiedBy.MaxLength = 50;
				colvarModifiedBy.AutoIncrement = false;
				colvarModifiedBy.IsNullable = true;
				colvarModifiedBy.IsPrimaryKey = false;
				colvarModifiedBy.IsForeignKey = false;
				colvarModifiedBy.IsReadOnly = false;
				colvarModifiedBy.DefaultSetting = @"";
				colvarModifiedBy.ForeignKeyTableName = "";
				schema.Columns.Add(colvarModifiedBy);
				
				TableSchema.TableColumn colvarModifiedOn = new TableSchema.TableColumn(schema);
				colvarModifiedOn.ColumnName = "ModifiedOn";
				colvarModifiedOn.DataType = DbType.DateTime;
				colvarModifiedOn.MaxLength = 0;
				colvarModifiedOn.AutoIncrement = false;
				colvarModifiedOn.IsNullable = true;
				colvarModifiedOn.IsPrimaryKey = false;
				colvarModifiedOn.IsForeignKey = false;
				colvarModifiedOn.IsReadOnly = false;
				colvarModifiedOn.DefaultSetting = @"";
				colvarModifiedOn.ForeignKeyTableName = "";
				schema.Columns.Add(colvarModifiedOn);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["RisProvider"].AddSchema("APR_ControlNiñoSanoConsultorio",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("IdControlNiñoSanoConsultorio")]
		[Bindable(true)]
		public int IdControlNiñoSanoConsultorio 
		{
			get { return GetColumnValue<int>(Columns.IdControlNiñoSanoConsultorio); }
			set { SetColumnValue(Columns.IdControlNiñoSanoConsultorio, value); }
		}
		  
		[XmlAttribute("IdControlNiñoSano")]
		[Bindable(true)]
		public int IdControlNiñoSano 
		{
			get { return GetColumnValue<int>(Columns.IdControlNiñoSano); }
			set { SetColumnValue(Columns.IdControlNiñoSano, value); }
		}
		  
		[XmlAttribute("IdTipoLactancia")]
		[Bindable(true)]
		public int? IdTipoLactancia 
		{
			get { return GetColumnValue<int?>(Columns.IdTipoLactancia); }
			set { SetColumnValue(Columns.IdTipoLactancia, value); }
		}
		  
		[XmlAttribute("IdIntervencion")]
		[Bindable(true)]
		public int? IdIntervencion 
		{
			get { return GetColumnValue<int?>(Columns.IdIntervencion); }
			set { SetColumnValue(Columns.IdIntervencion, value); }
		}
		  
		[XmlAttribute("FechaProximoControl")]
		[Bindable(true)]
		public DateTime? FechaProximoControl 
		{
			get { return GetColumnValue<DateTime?>(Columns.FechaProximoControl); }
			set { SetColumnValue(Columns.FechaProximoControl, value); }
		}
		  
		[XmlAttribute("Observacion")]
		[Bindable(true)]
		public string Observacion 
		{
			get { return GetColumnValue<string>(Columns.Observacion); }
			set { SetColumnValue(Columns.Observacion, value); }
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
		public DateTime? CreatedOn 
		{
			get { return GetColumnValue<DateTime?>(Columns.CreatedOn); }
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
		public DateTime? ModifiedOn 
		{
			get { return GetColumnValue<DateTime?>(Columns.ModifiedOn); }
			set { SetColumnValue(Columns.ModifiedOn, value); }
		}
		
		#endregion
		
		
		#region PrimaryKey Methods		
		
        protected override void SetPrimaryKey(object oValue)
        {
            base.SetPrimaryKey(oValue);
            
            SetPKValues();
        }
        
		
		private DalRis.AprRelControlNiñoSanoFactorRiesgoCollection colAprRelControlNiñoSanoFactorRiesgoRecords;
		public DalRis.AprRelControlNiñoSanoFactorRiesgoCollection AprRelControlNiñoSanoFactorRiesgoRecords()
		{
			if(colAprRelControlNiñoSanoFactorRiesgoRecords == null)
			{
				colAprRelControlNiñoSanoFactorRiesgoRecords = new DalRis.AprRelControlNiñoSanoFactorRiesgoCollection().Where(AprRelControlNiñoSanoFactorRiesgo.Columns.IdControlNiñoSanoConsultorio, IdControlNiñoSanoConsultorio).Load();
				colAprRelControlNiñoSanoFactorRiesgoRecords.ListChanged += new ListChangedEventHandler(colAprRelControlNiñoSanoFactorRiesgoRecords_ListChanged);
			}
			return colAprRelControlNiñoSanoFactorRiesgoRecords;
		}
				
		void colAprRelControlNiñoSanoFactorRiesgoRecords_ListChanged(object sender, ListChangedEventArgs e)
		{
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
		        // Set foreign key value
		        colAprRelControlNiñoSanoFactorRiesgoRecords[e.NewIndex].IdControlNiñoSanoConsultorio = IdControlNiñoSanoConsultorio;
				colAprRelControlNiñoSanoFactorRiesgoRecords.ListChanged += new ListChangedEventHandler(colAprRelControlNiñoSanoFactorRiesgoRecords_ListChanged);
            }
		}
		private DalRis.AprRelControNiñoSanoFactorProtectorCollection colAprRelControNiñoSanoFactorProtectorRecords;
		public DalRis.AprRelControNiñoSanoFactorProtectorCollection AprRelControNiñoSanoFactorProtectorRecords()
		{
			if(colAprRelControNiñoSanoFactorProtectorRecords == null)
			{
				colAprRelControNiñoSanoFactorProtectorRecords = new DalRis.AprRelControNiñoSanoFactorProtectorCollection().Where(AprRelControNiñoSanoFactorProtector.Columns.IdControlNiñoSanoConsultorio, IdControlNiñoSanoConsultorio).Load();
				colAprRelControNiñoSanoFactorProtectorRecords.ListChanged += new ListChangedEventHandler(colAprRelControNiñoSanoFactorProtectorRecords_ListChanged);
			}
			return colAprRelControNiñoSanoFactorProtectorRecords;
		}
				
		void colAprRelControNiñoSanoFactorProtectorRecords_ListChanged(object sender, ListChangedEventArgs e)
		{
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
		        // Set foreign key value
		        colAprRelControNiñoSanoFactorProtectorRecords[e.NewIndex].IdControlNiñoSanoConsultorio = IdControlNiñoSanoConsultorio;
				colAprRelControNiñoSanoFactorProtectorRecords.ListChanged += new ListChangedEventHandler(colAprRelControNiñoSanoFactorProtectorRecords_ListChanged);
            }
		}
		private DalRis.AprRelControlNiñoSanoAreaDesarrolloCollection colAprRelControlNiñoSanoAreaDesarrolloRecords;
		public DalRis.AprRelControlNiñoSanoAreaDesarrolloCollection AprRelControlNiñoSanoAreaDesarrolloRecords()
		{
			if(colAprRelControlNiñoSanoAreaDesarrolloRecords == null)
			{
				colAprRelControlNiñoSanoAreaDesarrolloRecords = new DalRis.AprRelControlNiñoSanoAreaDesarrolloCollection().Where(AprRelControlNiñoSanoAreaDesarrollo.Columns.IdControlNiñoSanoConsultorio, IdControlNiñoSanoConsultorio).Load();
				colAprRelControlNiñoSanoAreaDesarrolloRecords.ListChanged += new ListChangedEventHandler(colAprRelControlNiñoSanoAreaDesarrolloRecords_ListChanged);
			}
			return colAprRelControlNiñoSanoAreaDesarrolloRecords;
		}
				
		void colAprRelControlNiñoSanoAreaDesarrolloRecords_ListChanged(object sender, ListChangedEventArgs e)
		{
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
		        // Set foreign key value
		        colAprRelControlNiñoSanoAreaDesarrolloRecords[e.NewIndex].IdControlNiñoSanoConsultorio = IdControlNiñoSanoConsultorio;
				colAprRelControlNiñoSanoAreaDesarrolloRecords.ListChanged += new ListChangedEventHandler(colAprRelControlNiñoSanoAreaDesarrolloRecords_ListChanged);
            }
		}
		#endregion
		
			
		
		#region ForeignKey Properties
		
		/// <summary>
		/// Returns a AprTipoLactancium ActiveRecord object related to this AprControlNiñoSanoConsultorio
		/// 
		/// </summary>
		public DalRis.AprTipoLactancium AprTipoLactancium
		{
			get { return DalRis.AprTipoLactancium.FetchByID(this.IdTipoLactancia); }
			set { SetColumnValue("idTipoLactancia", value.IdTipoLactancia); }
		}
		
		
		/// <summary>
		/// Returns a AprControlNiñoSano ActiveRecord object related to this AprControlNiñoSanoConsultorio
		/// 
		/// </summary>
		public DalRis.AprControlNiñoSano AprControlNiñoSano
		{
			get { return DalRis.AprControlNiñoSano.FetchByID(this.IdControlNiñoSano); }
			set { SetColumnValue("idControlNiñoSano", value.IdControlNiñoSano); }
		}
		
		
		/// <summary>
		/// Returns a AprIntervencion ActiveRecord object related to this AprControlNiñoSanoConsultorio
		/// 
		/// </summary>
		public DalRis.AprIntervencion AprIntervencion
		{
			get { return DalRis.AprIntervencion.FetchByID(this.IdIntervencion); }
			set { SetColumnValue("idIntervencion", value.IdIntervencion); }
		}
		
		
		#endregion
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(int varIdControlNiñoSano,int? varIdTipoLactancia,int? varIdIntervencion,DateTime? varFechaProximoControl,string varObservacion,string varCreatedBy,DateTime? varCreatedOn,string varModifiedBy,DateTime? varModifiedOn)
		{
			AprControlNiñoSanoConsultorio item = new AprControlNiñoSanoConsultorio();
			
			item.IdControlNiñoSano = varIdControlNiñoSano;
			
			item.IdTipoLactancia = varIdTipoLactancia;
			
			item.IdIntervencion = varIdIntervencion;
			
			item.FechaProximoControl = varFechaProximoControl;
			
			item.Observacion = varObservacion;
			
			item.CreatedBy = varCreatedBy;
			
			item.CreatedOn = varCreatedOn;
			
			item.ModifiedBy = varModifiedBy;
			
			item.ModifiedOn = varModifiedOn;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varIdControlNiñoSanoConsultorio,int varIdControlNiñoSano,int? varIdTipoLactancia,int? varIdIntervencion,DateTime? varFechaProximoControl,string varObservacion,string varCreatedBy,DateTime? varCreatedOn,string varModifiedBy,DateTime? varModifiedOn)
		{
			AprControlNiñoSanoConsultorio item = new AprControlNiñoSanoConsultorio();
			
				item.IdControlNiñoSanoConsultorio = varIdControlNiñoSanoConsultorio;
			
				item.IdControlNiñoSano = varIdControlNiñoSano;
			
				item.IdTipoLactancia = varIdTipoLactancia;
			
				item.IdIntervencion = varIdIntervencion;
			
				item.FechaProximoControl = varFechaProximoControl;
			
				item.Observacion = varObservacion;
			
				item.CreatedBy = varCreatedBy;
			
				item.CreatedOn = varCreatedOn;
			
				item.ModifiedBy = varModifiedBy;
			
				item.ModifiedOn = varModifiedOn;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn IdControlNiñoSanoConsultorioColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn IdControlNiñoSanoColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn IdTipoLactanciaColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn IdIntervencionColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn FechaProximoControlColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn ObservacionColumn
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
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string IdControlNiñoSanoConsultorio = @"idControlNiñoSanoConsultorio";
			 public static string IdControlNiñoSano = @"idControlNiñoSano";
			 public static string IdTipoLactancia = @"idTipoLactancia";
			 public static string IdIntervencion = @"idIntervencion";
			 public static string FechaProximoControl = @"FechaProximoControl";
			 public static string Observacion = @"Observacion";
			 public static string CreatedBy = @"CreatedBy";
			 public static string CreatedOn = @"CreatedOn";
			 public static string ModifiedBy = @"ModifiedBy";
			 public static string ModifiedOn = @"ModifiedOn";
						
		}
		#endregion
		
		#region Update PK Collections
		
        public void SetPKValues()
        {
                if (colAprRelControlNiñoSanoFactorRiesgoRecords != null)
                {
                    foreach (DalRis.AprRelControlNiñoSanoFactorRiesgo item in colAprRelControlNiñoSanoFactorRiesgoRecords)
                    {
                        if (item.IdControlNiñoSanoConsultorio != IdControlNiñoSanoConsultorio)
                        {
                            item.IdControlNiñoSanoConsultorio = IdControlNiñoSanoConsultorio;
                        }
                    }
               }
		
                if (colAprRelControNiñoSanoFactorProtectorRecords != null)
                {
                    foreach (DalRis.AprRelControNiñoSanoFactorProtector item in colAprRelControNiñoSanoFactorProtectorRecords)
                    {
                        if (item.IdControlNiñoSanoConsultorio != IdControlNiñoSanoConsultorio)
                        {
                            item.IdControlNiñoSanoConsultorio = IdControlNiñoSanoConsultorio;
                        }
                    }
               }
		
                if (colAprRelControlNiñoSanoAreaDesarrolloRecords != null)
                {
                    foreach (DalRis.AprRelControlNiñoSanoAreaDesarrollo item in colAprRelControlNiñoSanoAreaDesarrolloRecords)
                    {
                        if (item.IdControlNiñoSanoConsultorio != IdControlNiñoSanoConsultorio)
                        {
                            item.IdControlNiñoSanoConsultorio = IdControlNiñoSanoConsultorio;
                        }
                    }
               }
		}
        #endregion
    
        #region Deep Save
		
        public void DeepSave()
        {
            Save();
            
                if (colAprRelControlNiñoSanoFactorRiesgoRecords != null)
                {
                    colAprRelControlNiñoSanoFactorRiesgoRecords.SaveAll();
               }
		
                if (colAprRelControNiñoSanoFactorProtectorRecords != null)
                {
                    colAprRelControNiñoSanoFactorProtectorRecords.SaveAll();
               }
		
                if (colAprRelControlNiñoSanoAreaDesarrolloRecords != null)
                {
                    colAprRelControlNiñoSanoAreaDesarrolloRecords.SaveAll();
               }
		}
        #endregion
	}
}
