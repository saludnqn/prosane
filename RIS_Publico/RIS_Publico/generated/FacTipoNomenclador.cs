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
	/// Strongly-typed collection for the FacTipoNomenclador class.
	/// </summary>
    [Serializable]
	public partial class FacTipoNomencladorCollection : ActiveList<FacTipoNomenclador, FacTipoNomencladorCollection>
	{	   
		public FacTipoNomencladorCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>FacTipoNomencladorCollection</returns>
		public FacTipoNomencladorCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                FacTipoNomenclador o = this[i];
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
	/// This is an ActiveRecord class which wraps the FAC_TipoNomenclador table.
	/// </summary>
	[Serializable]
	public partial class FacTipoNomenclador : ActiveRecord<FacTipoNomenclador>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public FacTipoNomenclador()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public FacTipoNomenclador(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public FacTipoNomenclador(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public FacTipoNomenclador(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("FAC_TipoNomenclador", TableType.Table, DataService.GetInstance("RisProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarIdTipoNomenclador = new TableSchema.TableColumn(schema);
				colvarIdTipoNomenclador.ColumnName = "idTipoNomenclador";
				colvarIdTipoNomenclador.DataType = DbType.Int32;
				colvarIdTipoNomenclador.MaxLength = 0;
				colvarIdTipoNomenclador.AutoIncrement = true;
				colvarIdTipoNomenclador.IsNullable = false;
				colvarIdTipoNomenclador.IsPrimaryKey = true;
				colvarIdTipoNomenclador.IsForeignKey = false;
				colvarIdTipoNomenclador.IsReadOnly = false;
				colvarIdTipoNomenclador.DefaultSetting = @"";
				colvarIdTipoNomenclador.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdTipoNomenclador);
				
				TableSchema.TableColumn colvarNombre = new TableSchema.TableColumn(schema);
				colvarNombre.ColumnName = "nombre";
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
				
				TableSchema.TableColumn colvarFechaDesde = new TableSchema.TableColumn(schema);
				colvarFechaDesde.ColumnName = "fechaDesde";
				colvarFechaDesde.DataType = DbType.DateTime;
				colvarFechaDesde.MaxLength = 0;
				colvarFechaDesde.AutoIncrement = false;
				colvarFechaDesde.IsNullable = false;
				colvarFechaDesde.IsPrimaryKey = false;
				colvarFechaDesde.IsForeignKey = false;
				colvarFechaDesde.IsReadOnly = false;
				colvarFechaDesde.DefaultSetting = @"";
				colvarFechaDesde.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFechaDesde);
				
				TableSchema.TableColumn colvarFechaHasta = new TableSchema.TableColumn(schema);
				colvarFechaHasta.ColumnName = "fechaHasta";
				colvarFechaHasta.DataType = DbType.DateTime;
				colvarFechaHasta.MaxLength = 0;
				colvarFechaHasta.AutoIncrement = false;
				colvarFechaHasta.IsNullable = false;
				colvarFechaHasta.IsPrimaryKey = false;
				colvarFechaHasta.IsForeignKey = false;
				colvarFechaHasta.IsReadOnly = false;
				colvarFechaHasta.DefaultSetting = @"";
				colvarFechaHasta.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFechaHasta);
				
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
				DataService.Providers["RisProvider"].AddSchema("FAC_TipoNomenclador",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("IdTipoNomenclador")]
		[Bindable(true)]
		public int IdTipoNomenclador 
		{
			get { return GetColumnValue<int>(Columns.IdTipoNomenclador); }
			set { SetColumnValue(Columns.IdTipoNomenclador, value); }
		}
		  
		[XmlAttribute("Nombre")]
		[Bindable(true)]
		public string Nombre 
		{
			get { return GetColumnValue<string>(Columns.Nombre); }
			set { SetColumnValue(Columns.Nombre, value); }
		}
		  
		[XmlAttribute("FechaDesde")]
		[Bindable(true)]
		public DateTime FechaDesde 
		{
			get { return GetColumnValue<DateTime>(Columns.FechaDesde); }
			set { SetColumnValue(Columns.FechaDesde, value); }
		}
		  
		[XmlAttribute("FechaHasta")]
		[Bindable(true)]
		public DateTime FechaHasta 
		{
			get { return GetColumnValue<DateTime>(Columns.FechaHasta); }
			set { SetColumnValue(Columns.FechaHasta, value); }
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
        
		
		private DalRis.FacContratoObraSocialCollection colFacContratoObraSocialRecords;
		public DalRis.FacContratoObraSocialCollection FacContratoObraSocialRecords()
		{
			if(colFacContratoObraSocialRecords == null)
			{
				colFacContratoObraSocialRecords = new DalRis.FacContratoObraSocialCollection().Where(FacContratoObraSocial.Columns.IdTipoNomenclador, IdTipoNomenclador).Load();
				colFacContratoObraSocialRecords.ListChanged += new ListChangedEventHandler(colFacContratoObraSocialRecords_ListChanged);
			}
			return colFacContratoObraSocialRecords;
		}
				
		void colFacContratoObraSocialRecords_ListChanged(object sender, ListChangedEventArgs e)
		{
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
		        // Set foreign key value
		        colFacContratoObraSocialRecords[e.NewIndex].IdTipoNomenclador = IdTipoNomenclador;
				colFacContratoObraSocialRecords.ListChanged += new ListChangedEventHandler(colFacContratoObraSocialRecords_ListChanged);
            }
		}
		private DalRis.FacNomencladorCollection colFacNomencladorRecords;
		public DalRis.FacNomencladorCollection FacNomencladorRecords()
		{
			if(colFacNomencladorRecords == null)
			{
				colFacNomencladorRecords = new DalRis.FacNomencladorCollection().Where(FacNomenclador.Columns.IdTipoNomenclador, IdTipoNomenclador).Load();
				colFacNomencladorRecords.ListChanged += new ListChangedEventHandler(colFacNomencladorRecords_ListChanged);
			}
			return colFacNomencladorRecords;
		}
				
		void colFacNomencladorRecords_ListChanged(object sender, ListChangedEventArgs e)
		{
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
		        // Set foreign key value
		        colFacNomencladorRecords[e.NewIndex].IdTipoNomenclador = IdTipoNomenclador;
				colFacNomencladorRecords.ListChanged += new ListChangedEventHandler(colFacNomencladorRecords_ListChanged);
            }
		}
		#endregion
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varNombre,DateTime varFechaDesde,DateTime varFechaHasta,bool varActivo)
		{
			FacTipoNomenclador item = new FacTipoNomenclador();
			
			item.Nombre = varNombre;
			
			item.FechaDesde = varFechaDesde;
			
			item.FechaHasta = varFechaHasta;
			
			item.Activo = varActivo;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varIdTipoNomenclador,string varNombre,DateTime varFechaDesde,DateTime varFechaHasta,bool varActivo)
		{
			FacTipoNomenclador item = new FacTipoNomenclador();
			
				item.IdTipoNomenclador = varIdTipoNomenclador;
			
				item.Nombre = varNombre;
			
				item.FechaDesde = varFechaDesde;
			
				item.FechaHasta = varFechaHasta;
			
				item.Activo = varActivo;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn IdTipoNomencladorColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn NombreColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn FechaDesdeColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn FechaHastaColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn ActivoColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string IdTipoNomenclador = @"idTipoNomenclador";
			 public static string Nombre = @"nombre";
			 public static string FechaDesde = @"fechaDesde";
			 public static string FechaHasta = @"fechaHasta";
			 public static string Activo = @"activo";
						
		}
		#endregion
		
		#region Update PK Collections
		
        public void SetPKValues()
        {
                if (colFacContratoObraSocialRecords != null)
                {
                    foreach (DalRis.FacContratoObraSocial item in colFacContratoObraSocialRecords)
                    {
                        if (item.IdTipoNomenclador != IdTipoNomenclador)
                        {
                            item.IdTipoNomenclador = IdTipoNomenclador;
                        }
                    }
               }
		
                if (colFacNomencladorRecords != null)
                {
                    foreach (DalRis.FacNomenclador item in colFacNomencladorRecords)
                    {
                        if (item.IdTipoNomenclador != IdTipoNomenclador)
                        {
                            item.IdTipoNomenclador = IdTipoNomenclador;
                        }
                    }
               }
		}
        #endregion
    
        #region Deep Save
		
        public void DeepSave()
        {
            Save();
            
                if (colFacContratoObraSocialRecords != null)
                {
                    colFacContratoObraSocialRecords.SaveAll();
               }
		
                if (colFacNomencladorRecords != null)
                {
                    colFacNomencladorRecords.SaveAll();
               }
		}
        #endregion
	}
}
