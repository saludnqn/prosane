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
	/// Strongly-typed collection for the InsRubro class.
	/// </summary>
    [Serializable]
	public partial class InsRubroCollection : ActiveList<InsRubro, InsRubroCollection>
	{	   
		public InsRubroCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>InsRubroCollection</returns>
		public InsRubroCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                InsRubro o = this[i];
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
	/// This is an ActiveRecord class which wraps the INS_Rubro table.
	/// </summary>
	[Serializable]
	public partial class InsRubro : ActiveRecord<InsRubro>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public InsRubro()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public InsRubro(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public InsRubro(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public InsRubro(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("INS_Rubro", TableType.Table, DataService.GetInstance("RisProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarIdRubro = new TableSchema.TableColumn(schema);
				colvarIdRubro.ColumnName = "idRubro";
				colvarIdRubro.DataType = DbType.Int32;
				colvarIdRubro.MaxLength = 0;
				colvarIdRubro.AutoIncrement = true;
				colvarIdRubro.IsNullable = false;
				colvarIdRubro.IsPrimaryKey = true;
				colvarIdRubro.IsForeignKey = false;
				colvarIdRubro.IsReadOnly = false;
				colvarIdRubro.DefaultSetting = @"";
				colvarIdRubro.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdRubro);
				
				TableSchema.TableColumn colvarCodigo = new TableSchema.TableColumn(schema);
				colvarCodigo.ColumnName = "Codigo";
				colvarCodigo.DataType = DbType.Int32;
				colvarCodigo.MaxLength = 0;
				colvarCodigo.AutoIncrement = false;
				colvarCodigo.IsNullable = false;
				colvarCodigo.IsPrimaryKey = false;
				colvarCodigo.IsForeignKey = false;
				colvarCodigo.IsReadOnly = false;
				colvarCodigo.DefaultSetting = @"";
				colvarCodigo.ForeignKeyTableName = "";
				schema.Columns.Add(colvarCodigo);
				
				TableSchema.TableColumn colvarSistema = new TableSchema.TableColumn(schema);
				colvarSistema.ColumnName = "Sistema";
				colvarSistema.DataType = DbType.Byte;
				colvarSistema.MaxLength = 0;
				colvarSistema.AutoIncrement = false;
				colvarSistema.IsNullable = false;
				colvarSistema.IsPrimaryKey = false;
				colvarSistema.IsForeignKey = false;
				colvarSistema.IsReadOnly = false;
				
						colvarSistema.DefaultSetting = @"((1))";
				colvarSistema.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSistema);
				
				TableSchema.TableColumn colvarPadre = new TableSchema.TableColumn(schema);
				colvarPadre.ColumnName = "Padre";
				colvarPadre.DataType = DbType.Int32;
				colvarPadre.MaxLength = 0;
				colvarPadre.AutoIncrement = false;
				colvarPadre.IsNullable = true;
				colvarPadre.IsPrimaryKey = false;
				colvarPadre.IsForeignKey = false;
				colvarPadre.IsReadOnly = false;
				colvarPadre.DefaultSetting = @"";
				colvarPadre.ForeignKeyTableName = "";
				schema.Columns.Add(colvarPadre);
				
				TableSchema.TableColumn colvarNombre = new TableSchema.TableColumn(schema);
				colvarNombre.ColumnName = "Nombre";
				colvarNombre.DataType = DbType.AnsiString;
				colvarNombre.MaxLength = 50;
				colvarNombre.AutoIncrement = false;
				colvarNombre.IsNullable = false;
				colvarNombre.IsPrimaryKey = false;
				colvarNombre.IsForeignKey = false;
				colvarNombre.IsReadOnly = false;
				colvarNombre.DefaultSetting = @"";
				colvarNombre.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNombre);
				
				TableSchema.TableColumn colvarEspecial = new TableSchema.TableColumn(schema);
				colvarEspecial.ColumnName = "Especial";
				colvarEspecial.DataType = DbType.Byte;
				colvarEspecial.MaxLength = 0;
				colvarEspecial.AutoIncrement = false;
				colvarEspecial.IsNullable = false;
				colvarEspecial.IsPrimaryKey = false;
				colvarEspecial.IsForeignKey = false;
				colvarEspecial.IsReadOnly = false;
				
						colvarEspecial.DefaultSetting = @"((0))";
				colvarEspecial.ForeignKeyTableName = "";
				schema.Columns.Add(colvarEspecial);
				
				TableSchema.TableColumn colvarRubroPrimerNivel = new TableSchema.TableColumn(schema);
				colvarRubroPrimerNivel.ColumnName = "RubroPrimerNivel";
				colvarRubroPrimerNivel.DataType = DbType.Int32;
				colvarRubroPrimerNivel.MaxLength = 0;
				colvarRubroPrimerNivel.AutoIncrement = false;
				colvarRubroPrimerNivel.IsNullable = true;
				colvarRubroPrimerNivel.IsPrimaryKey = false;
				colvarRubroPrimerNivel.IsForeignKey = false;
				colvarRubroPrimerNivel.IsReadOnly = false;
				colvarRubroPrimerNivel.DefaultSetting = @"";
				colvarRubroPrimerNivel.ForeignKeyTableName = "";
				schema.Columns.Add(colvarRubroPrimerNivel);
				
				TableSchema.TableColumn colvarIdRubroPadre = new TableSchema.TableColumn(schema);
				colvarIdRubroPadre.ColumnName = "idRubroPadre";
				colvarIdRubroPadre.DataType = DbType.Int32;
				colvarIdRubroPadre.MaxLength = 0;
				colvarIdRubroPadre.AutoIncrement = false;
				colvarIdRubroPadre.IsNullable = true;
				colvarIdRubroPadre.IsPrimaryKey = false;
				colvarIdRubroPadre.IsForeignKey = true;
				colvarIdRubroPadre.IsReadOnly = false;
				colvarIdRubroPadre.DefaultSetting = @"";
				
					colvarIdRubroPadre.ForeignKeyTableName = "INS_Rubro";
				schema.Columns.Add(colvarIdRubroPadre);
				
				TableSchema.TableColumn colvarIdEfector = new TableSchema.TableColumn(schema);
				colvarIdEfector.ColumnName = "idEfector";
				colvarIdEfector.DataType = DbType.Int32;
				colvarIdEfector.MaxLength = 0;
				colvarIdEfector.AutoIncrement = false;
				colvarIdEfector.IsNullable = false;
				colvarIdEfector.IsPrimaryKey = false;
				colvarIdEfector.IsForeignKey = false;
				colvarIdEfector.IsReadOnly = false;
				
						colvarIdEfector.DefaultSetting = @"((0))";
				colvarIdEfector.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdEfector);
				
				TableSchema.TableColumn colvarBaja = new TableSchema.TableColumn(schema);
				colvarBaja.ColumnName = "baja";
				colvarBaja.DataType = DbType.Boolean;
				colvarBaja.MaxLength = 0;
				colvarBaja.AutoIncrement = false;
				colvarBaja.IsNullable = false;
				colvarBaja.IsPrimaryKey = false;
				colvarBaja.IsForeignKey = false;
				colvarBaja.IsReadOnly = false;
				
						colvarBaja.DefaultSetting = @"((0))";
				colvarBaja.ForeignKeyTableName = "";
				schema.Columns.Add(colvarBaja);
				
				TableSchema.TableColumn colvarCreatedBy = new TableSchema.TableColumn(schema);
				colvarCreatedBy.ColumnName = "createdBy";
				colvarCreatedBy.DataType = DbType.AnsiString;
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
				colvarCreatedOn.ColumnName = "createdOn";
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
				colvarModifiedBy.DataType = DbType.AnsiString;
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
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["RisProvider"].AddSchema("INS_Rubro",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("IdRubro")]
		[Bindable(true)]
		public int IdRubro 
		{
			get { return GetColumnValue<int>(Columns.IdRubro); }
			set { SetColumnValue(Columns.IdRubro, value); }
		}
		  
		[XmlAttribute("Codigo")]
		[Bindable(true)]
		public int Codigo 
		{
			get { return GetColumnValue<int>(Columns.Codigo); }
			set { SetColumnValue(Columns.Codigo, value); }
		}
		  
		[XmlAttribute("Sistema")]
		[Bindable(true)]
		public byte Sistema 
		{
			get { return GetColumnValue<byte>(Columns.Sistema); }
			set { SetColumnValue(Columns.Sistema, value); }
		}
		  
		[XmlAttribute("Padre")]
		[Bindable(true)]
		public int? Padre 
		{
			get { return GetColumnValue<int?>(Columns.Padre); }
			set { SetColumnValue(Columns.Padre, value); }
		}
		  
		[XmlAttribute("Nombre")]
		[Bindable(true)]
		public string Nombre 
		{
			get { return GetColumnValue<string>(Columns.Nombre); }
			set { SetColumnValue(Columns.Nombre, value); }
		}
		  
		[XmlAttribute("Especial")]
		[Bindable(true)]
		public byte Especial 
		{
			get { return GetColumnValue<byte>(Columns.Especial); }
			set { SetColumnValue(Columns.Especial, value); }
		}
		  
		[XmlAttribute("RubroPrimerNivel")]
		[Bindable(true)]
		public int? RubroPrimerNivel 
		{
			get { return GetColumnValue<int?>(Columns.RubroPrimerNivel); }
			set { SetColumnValue(Columns.RubroPrimerNivel, value); }
		}
		  
		[XmlAttribute("IdRubroPadre")]
		[Bindable(true)]
		public int? IdRubroPadre 
		{
			get { return GetColumnValue<int?>(Columns.IdRubroPadre); }
			set { SetColumnValue(Columns.IdRubroPadre, value); }
		}
		  
		[XmlAttribute("IdEfector")]
		[Bindable(true)]
		public int IdEfector 
		{
			get { return GetColumnValue<int>(Columns.IdEfector); }
			set { SetColumnValue(Columns.IdEfector, value); }
		}
		  
		[XmlAttribute("Baja")]
		[Bindable(true)]
		public bool Baja 
		{
			get { return GetColumnValue<bool>(Columns.Baja); }
			set { SetColumnValue(Columns.Baja, value); }
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
		
		#endregion
		
		
		#region PrimaryKey Methods		
		
        protected override void SetPrimaryKey(object oValue)
        {
            base.SetPrimaryKey(oValue);
            
            SetPKValues();
        }
        
		
		private DalRis.InsRubroCollection colChildInsRubroRecords;
		public DalRis.InsRubroCollection ChildInsRubroRecords()
		{
			if(colChildInsRubroRecords == null)
			{
				colChildInsRubroRecords = new DalRis.InsRubroCollection().Where(InsRubro.Columns.IdRubroPadre, IdRubro).Load();
				colChildInsRubroRecords.ListChanged += new ListChangedEventHandler(colChildInsRubroRecords_ListChanged);
			}
			return colChildInsRubroRecords;
		}
				
		void colChildInsRubroRecords_ListChanged(object sender, ListChangedEventArgs e)
		{
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
		        // Set foreign key value
		        colChildInsRubroRecords[e.NewIndex].IdRubroPadre = IdRubro;
				colChildInsRubroRecords.ListChanged += new ListChangedEventHandler(colChildInsRubroRecords_ListChanged);
            }
		}
		#endregion
		
			
		
		#region ForeignKey Properties
		
		/// <summary>
		/// Returns a InsRubro ActiveRecord object related to this InsRubro
		/// 
		/// </summary>
		public DalRis.InsRubro ParentInsRubro
		{
			get { return DalRis.InsRubro.FetchByID(this.IdRubroPadre); }
			set { SetColumnValue("idRubroPadre", value.IdRubro); }
		}
		
		
		#endregion
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(int varCodigo,byte varSistema,int? varPadre,string varNombre,byte varEspecial,int? varRubroPrimerNivel,int? varIdRubroPadre,int varIdEfector,bool varBaja,string varCreatedBy,DateTime varCreatedOn,string varModifiedBy,DateTime varModifiedOn)
		{
			InsRubro item = new InsRubro();
			
			item.Codigo = varCodigo;
			
			item.Sistema = varSistema;
			
			item.Padre = varPadre;
			
			item.Nombre = varNombre;
			
			item.Especial = varEspecial;
			
			item.RubroPrimerNivel = varRubroPrimerNivel;
			
			item.IdRubroPadre = varIdRubroPadre;
			
			item.IdEfector = varIdEfector;
			
			item.Baja = varBaja;
			
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
		public static void Update(int varIdRubro,int varCodigo,byte varSistema,int? varPadre,string varNombre,byte varEspecial,int? varRubroPrimerNivel,int? varIdRubroPadre,int varIdEfector,bool varBaja,string varCreatedBy,DateTime varCreatedOn,string varModifiedBy,DateTime varModifiedOn)
		{
			InsRubro item = new InsRubro();
			
				item.IdRubro = varIdRubro;
			
				item.Codigo = varCodigo;
			
				item.Sistema = varSistema;
			
				item.Padre = varPadre;
			
				item.Nombre = varNombre;
			
				item.Especial = varEspecial;
			
				item.RubroPrimerNivel = varRubroPrimerNivel;
			
				item.IdRubroPadre = varIdRubroPadre;
			
				item.IdEfector = varIdEfector;
			
				item.Baja = varBaja;
			
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
        
        
        public static TableSchema.TableColumn IdRubroColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn CodigoColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn SistemaColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn PadreColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn NombreColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn EspecialColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        public static TableSchema.TableColumn RubroPrimerNivelColumn
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        public static TableSchema.TableColumn IdRubroPadreColumn
        {
            get { return Schema.Columns[7]; }
        }
        
        
        
        public static TableSchema.TableColumn IdEfectorColumn
        {
            get { return Schema.Columns[8]; }
        }
        
        
        
        public static TableSchema.TableColumn BajaColumn
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
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string IdRubro = @"idRubro";
			 public static string Codigo = @"Codigo";
			 public static string Sistema = @"Sistema";
			 public static string Padre = @"Padre";
			 public static string Nombre = @"Nombre";
			 public static string Especial = @"Especial";
			 public static string RubroPrimerNivel = @"RubroPrimerNivel";
			 public static string IdRubroPadre = @"idRubroPadre";
			 public static string IdEfector = @"idEfector";
			 public static string Baja = @"baja";
			 public static string CreatedBy = @"createdBy";
			 public static string CreatedOn = @"createdOn";
			 public static string ModifiedBy = @"ModifiedBy";
			 public static string ModifiedOn = @"ModifiedOn";
						
		}
		#endregion
		
		#region Update PK Collections
		
        public void SetPKValues()
        {
                if (colChildInsRubroRecords != null)
                {
                    foreach (DalRis.InsRubro item in colChildInsRubroRecords)
                    {
                        if (item.IdRubroPadre != IdRubro)
                        {
                            item.IdRubroPadre = IdRubro;
                        }
                    }
               }
		}
        #endregion
    
        #region Deep Save
		
        public void DeepSave()
        {
            Save();
            
                if (colChildInsRubroRecords != null)
                {
                    colChildInsRubroRecords.SaveAll();
               }
		}
        #endregion
	}
}
