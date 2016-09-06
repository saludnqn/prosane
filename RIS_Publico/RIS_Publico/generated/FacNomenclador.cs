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
	/// Strongly-typed collection for the FacNomenclador class.
	/// </summary>
    [Serializable]
	public partial class FacNomencladorCollection : ActiveList<FacNomenclador, FacNomencladorCollection>
	{	   
		public FacNomencladorCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>FacNomencladorCollection</returns>
		public FacNomencladorCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                FacNomenclador o = this[i];
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
	/// This is an ActiveRecord class which wraps the FAC_Nomenclador table.
	/// </summary>
	[Serializable]
	public partial class FacNomenclador : ActiveRecord<FacNomenclador>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public FacNomenclador()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public FacNomenclador(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public FacNomenclador(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public FacNomenclador(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("FAC_Nomenclador", TableType.Table, DataService.GetInstance("RisProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarIdNomenclador = new TableSchema.TableColumn(schema);
				colvarIdNomenclador.ColumnName = "idNomenclador";
				colvarIdNomenclador.DataType = DbType.Int32;
				colvarIdNomenclador.MaxLength = 0;
				colvarIdNomenclador.AutoIncrement = false;
				colvarIdNomenclador.IsNullable = false;
				colvarIdNomenclador.IsPrimaryKey = true;
				colvarIdNomenclador.IsForeignKey = false;
				colvarIdNomenclador.IsReadOnly = false;
				colvarIdNomenclador.DefaultSetting = @"";
				colvarIdNomenclador.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdNomenclador);
				
				TableSchema.TableColumn colvarCodigo = new TableSchema.TableColumn(schema);
				colvarCodigo.ColumnName = "codigo";
				colvarCodigo.DataType = DbType.AnsiString;
				colvarCodigo.MaxLength = 50;
				colvarCodigo.AutoIncrement = false;
				colvarCodigo.IsNullable = false;
				colvarCodigo.IsPrimaryKey = false;
				colvarCodigo.IsForeignKey = false;
				colvarCodigo.IsReadOnly = false;
				colvarCodigo.DefaultSetting = @"";
				colvarCodigo.ForeignKeyTableName = "";
				schema.Columns.Add(colvarCodigo);
				
				TableSchema.TableColumn colvarDescripcion = new TableSchema.TableColumn(schema);
				colvarDescripcion.ColumnName = "descripcion";
				colvarDescripcion.DataType = DbType.AnsiString;
				colvarDescripcion.MaxLength = 255;
				colvarDescripcion.AutoIncrement = false;
				colvarDescripcion.IsNullable = false;
				colvarDescripcion.IsPrimaryKey = false;
				colvarDescripcion.IsForeignKey = false;
				colvarDescripcion.IsReadOnly = false;
				colvarDescripcion.DefaultSetting = @"";
				colvarDescripcion.ForeignKeyTableName = "";
				schema.Columns.Add(colvarDescripcion);
				
				TableSchema.TableColumn colvarIdTipoPractica = new TableSchema.TableColumn(schema);
				colvarIdTipoPractica.ColumnName = "idTipoPractica";
				colvarIdTipoPractica.DataType = DbType.Int32;
				colvarIdTipoPractica.MaxLength = 0;
				colvarIdTipoPractica.AutoIncrement = false;
				colvarIdTipoPractica.IsNullable = false;
				colvarIdTipoPractica.IsPrimaryKey = false;
				colvarIdTipoPractica.IsForeignKey = true;
				colvarIdTipoPractica.IsReadOnly = false;
				colvarIdTipoPractica.DefaultSetting = @"";
				
					colvarIdTipoPractica.ForeignKeyTableName = "FAC_TipoPractica";
				schema.Columns.Add(colvarIdTipoPractica);
				
				TableSchema.TableColumn colvarIdUnidad = new TableSchema.TableColumn(schema);
				colvarIdUnidad.ColumnName = "idUnidad";
				colvarIdUnidad.DataType = DbType.Int32;
				colvarIdUnidad.MaxLength = 0;
				colvarIdUnidad.AutoIncrement = false;
				colvarIdUnidad.IsNullable = false;
				colvarIdUnidad.IsPrimaryKey = false;
				colvarIdUnidad.IsForeignKey = true;
				colvarIdUnidad.IsReadOnly = false;
				colvarIdUnidad.DefaultSetting = @"";
				
					colvarIdUnidad.ForeignKeyTableName = "FAC_Unidad";
				schema.Columns.Add(colvarIdUnidad);
				
				TableSchema.TableColumn colvarIdTipoNomenclador = new TableSchema.TableColumn(schema);
				colvarIdTipoNomenclador.ColumnName = "idTipoNomenclador";
				colvarIdTipoNomenclador.DataType = DbType.Int32;
				colvarIdTipoNomenclador.MaxLength = 0;
				colvarIdTipoNomenclador.AutoIncrement = false;
				colvarIdTipoNomenclador.IsNullable = false;
				colvarIdTipoNomenclador.IsPrimaryKey = false;
				colvarIdTipoNomenclador.IsForeignKey = true;
				colvarIdTipoNomenclador.IsReadOnly = false;
				colvarIdTipoNomenclador.DefaultSetting = @"";
				
					colvarIdTipoNomenclador.ForeignKeyTableName = "FAC_TipoNomenclador";
				schema.Columns.Add(colvarIdTipoNomenclador);
				
				TableSchema.TableColumn colvarValorUnidad = new TableSchema.TableColumn(schema);
				colvarValorUnidad.ColumnName = "valorUnidad";
				colvarValorUnidad.DataType = DbType.Decimal;
				colvarValorUnidad.MaxLength = 0;
				colvarValorUnidad.AutoIncrement = false;
				colvarValorUnidad.IsNullable = false;
				colvarValorUnidad.IsPrimaryKey = false;
				colvarValorUnidad.IsForeignKey = false;
				colvarValorUnidad.IsReadOnly = false;
				colvarValorUnidad.DefaultSetting = @"";
				colvarValorUnidad.ForeignKeyTableName = "";
				schema.Columns.Add(colvarValorUnidad);
				
				TableSchema.TableColumn colvarEsAmbulatorio = new TableSchema.TableColumn(schema);
				colvarEsAmbulatorio.ColumnName = "esAmbulatorio";
				colvarEsAmbulatorio.DataType = DbType.Boolean;
				colvarEsAmbulatorio.MaxLength = 0;
				colvarEsAmbulatorio.AutoIncrement = false;
				colvarEsAmbulatorio.IsNullable = false;
				colvarEsAmbulatorio.IsPrimaryKey = false;
				colvarEsAmbulatorio.IsForeignKey = false;
				colvarEsAmbulatorio.IsReadOnly = false;
				colvarEsAmbulatorio.DefaultSetting = @"";
				colvarEsAmbulatorio.ForeignKeyTableName = "";
				schema.Columns.Add(colvarEsAmbulatorio);
				
				TableSchema.TableColumn colvarActivo = new TableSchema.TableColumn(schema);
				colvarActivo.ColumnName = "activo";
				colvarActivo.DataType = DbType.Boolean;
				colvarActivo.MaxLength = 0;
				colvarActivo.AutoIncrement = false;
				colvarActivo.IsNullable = false;
				colvarActivo.IsPrimaryKey = false;
				colvarActivo.IsForeignKey = false;
				colvarActivo.IsReadOnly = false;
				colvarActivo.DefaultSetting = @"";
				colvarActivo.ForeignKeyTableName = "";
				schema.Columns.Add(colvarActivo);
				
				TableSchema.TableColumn colvarIdCapitulo = new TableSchema.TableColumn(schema);
				colvarIdCapitulo.ColumnName = "idCapitulo";
				colvarIdCapitulo.DataType = DbType.Int32;
				colvarIdCapitulo.MaxLength = 0;
				colvarIdCapitulo.AutoIncrement = false;
				colvarIdCapitulo.IsNullable = false;
				colvarIdCapitulo.IsPrimaryKey = false;
				colvarIdCapitulo.IsForeignKey = true;
				colvarIdCapitulo.IsReadOnly = false;
				colvarIdCapitulo.DefaultSetting = @"";
				
					colvarIdCapitulo.ForeignKeyTableName = "FAC_Capitulo";
				schema.Columns.Add(colvarIdCapitulo);
				
				TableSchema.TableColumn colvarUg = new TableSchema.TableColumn(schema);
				colvarUg.ColumnName = "UG";
				colvarUg.DataType = DbType.Decimal;
				colvarUg.MaxLength = 0;
				colvarUg.AutoIncrement = false;
				colvarUg.IsNullable = true;
				colvarUg.IsPrimaryKey = false;
				colvarUg.IsForeignKey = false;
				colvarUg.IsReadOnly = false;
				colvarUg.DefaultSetting = @"";
				colvarUg.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUg);
				
				TableSchema.TableColumn colvarAnestesia = new TableSchema.TableColumn(schema);
				colvarAnestesia.ColumnName = "Anestesia";
				colvarAnestesia.DataType = DbType.AnsiString;
				colvarAnestesia.MaxLength = 255;
				colvarAnestesia.AutoIncrement = false;
				colvarAnestesia.IsNullable = true;
				colvarAnestesia.IsPrimaryKey = false;
				colvarAnestesia.IsForeignKey = false;
				colvarAnestesia.IsReadOnly = false;
				colvarAnestesia.DefaultSetting = @"";
				colvarAnestesia.ForeignKeyTableName = "";
				schema.Columns.Add(colvarAnestesia);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["RisProvider"].AddSchema("FAC_Nomenclador",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("IdNomenclador")]
		[Bindable(true)]
		public int IdNomenclador 
		{
			get { return GetColumnValue<int>(Columns.IdNomenclador); }
			set { SetColumnValue(Columns.IdNomenclador, value); }
		}
		  
		[XmlAttribute("Codigo")]
		[Bindable(true)]
		public string Codigo 
		{
			get { return GetColumnValue<string>(Columns.Codigo); }
			set { SetColumnValue(Columns.Codigo, value); }
		}
		  
		[XmlAttribute("Descripcion")]
		[Bindable(true)]
		public string Descripcion 
		{
			get { return GetColumnValue<string>(Columns.Descripcion); }
			set { SetColumnValue(Columns.Descripcion, value); }
		}
		  
		[XmlAttribute("IdTipoPractica")]
		[Bindable(true)]
		public int IdTipoPractica 
		{
			get { return GetColumnValue<int>(Columns.IdTipoPractica); }
			set { SetColumnValue(Columns.IdTipoPractica, value); }
		}
		  
		[XmlAttribute("IdUnidad")]
		[Bindable(true)]
		public int IdUnidad 
		{
			get { return GetColumnValue<int>(Columns.IdUnidad); }
			set { SetColumnValue(Columns.IdUnidad, value); }
		}
		  
		[XmlAttribute("IdTipoNomenclador")]
		[Bindable(true)]
		public int IdTipoNomenclador 
		{
			get { return GetColumnValue<int>(Columns.IdTipoNomenclador); }
			set { SetColumnValue(Columns.IdTipoNomenclador, value); }
		}
		  
		[XmlAttribute("ValorUnidad")]
		[Bindable(true)]
		public decimal ValorUnidad 
		{
			get { return GetColumnValue<decimal>(Columns.ValorUnidad); }
			set { SetColumnValue(Columns.ValorUnidad, value); }
		}
		  
		[XmlAttribute("EsAmbulatorio")]
		[Bindable(true)]
		public bool EsAmbulatorio 
		{
			get { return GetColumnValue<bool>(Columns.EsAmbulatorio); }
			set { SetColumnValue(Columns.EsAmbulatorio, value); }
		}
		  
		[XmlAttribute("Activo")]
		[Bindable(true)]
		public bool Activo 
		{
			get { return GetColumnValue<bool>(Columns.Activo); }
			set { SetColumnValue(Columns.Activo, value); }
		}
		  
		[XmlAttribute("IdCapitulo")]
		[Bindable(true)]
		public int IdCapitulo 
		{
			get { return GetColumnValue<int>(Columns.IdCapitulo); }
			set { SetColumnValue(Columns.IdCapitulo, value); }
		}
		  
		[XmlAttribute("Ug")]
		[Bindable(true)]
		public decimal? Ug 
		{
			get { return GetColumnValue<decimal?>(Columns.Ug); }
			set { SetColumnValue(Columns.Ug, value); }
		}
		  
		[XmlAttribute("Anestesia")]
		[Bindable(true)]
		public string Anestesia 
		{
			get { return GetColumnValue<string>(Columns.Anestesia); }
			set { SetColumnValue(Columns.Anestesia, value); }
		}
		
		#endregion
		
		
		#region PrimaryKey Methods		
		
        protected override void SetPrimaryKey(object oValue)
        {
            base.SetPrimaryKey(oValue);
            
            SetPKValues();
        }
        
		
		private DalRis.FacOrdenDetalleCollection colFacOrdenDetalleRecords;
		public DalRis.FacOrdenDetalleCollection FacOrdenDetalleRecords()
		{
			if(colFacOrdenDetalleRecords == null)
			{
				colFacOrdenDetalleRecords = new DalRis.FacOrdenDetalleCollection().Where(FacOrdenDetalle.Columns.IdNomenclador, IdNomenclador).Load();
				colFacOrdenDetalleRecords.ListChanged += new ListChangedEventHandler(colFacOrdenDetalleRecords_ListChanged);
			}
			return colFacOrdenDetalleRecords;
		}
				
		void colFacOrdenDetalleRecords_ListChanged(object sender, ListChangedEventArgs e)
		{
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
		        // Set foreign key value
		        colFacOrdenDetalleRecords[e.NewIndex].IdNomenclador = IdNomenclador;
				colFacOrdenDetalleRecords.ListChanged += new ListChangedEventHandler(colFacOrdenDetalleRecords_ListChanged);
            }
		}
		#endregion
		
			
		
		#region ForeignKey Properties
		
		/// <summary>
		/// Returns a FacCapitulo ActiveRecord object related to this FacNomenclador
		/// 
		/// </summary>
		public DalRis.FacCapitulo FacCapitulo
		{
			get { return DalRis.FacCapitulo.FetchByID(this.IdCapitulo); }
			set { SetColumnValue("idCapitulo", value.IdCapitulo); }
		}
		
		
		/// <summary>
		/// Returns a FacTipoNomenclador ActiveRecord object related to this FacNomenclador
		/// 
		/// </summary>
		public DalRis.FacTipoNomenclador FacTipoNomenclador
		{
			get { return DalRis.FacTipoNomenclador.FetchByID(this.IdTipoNomenclador); }
			set { SetColumnValue("idTipoNomenclador", value.IdTipoNomenclador); }
		}
		
		
		/// <summary>
		/// Returns a FacUnidad ActiveRecord object related to this FacNomenclador
		/// 
		/// </summary>
		public DalRis.FacUnidad FacUnidad
		{
			get { return DalRis.FacUnidad.FetchByID(this.IdUnidad); }
			set { SetColumnValue("idUnidad", value.IdUnidad); }
		}
		
		
		/// <summary>
		/// Returns a FacTipoPractica ActiveRecord object related to this FacNomenclador
		/// 
		/// </summary>
		public DalRis.FacTipoPractica FacTipoPractica
		{
			get { return DalRis.FacTipoPractica.FetchByID(this.IdTipoPractica); }
			set { SetColumnValue("idTipoPractica", value.IdTipoPractica); }
		}
		
		
		#endregion
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(int varIdNomenclador,string varCodigo,string varDescripcion,int varIdTipoPractica,int varIdUnidad,int varIdTipoNomenclador,decimal varValorUnidad,bool varEsAmbulatorio,bool varActivo,int varIdCapitulo,decimal? varUg,string varAnestesia)
		{
			FacNomenclador item = new FacNomenclador();
			
			item.IdNomenclador = varIdNomenclador;
			
			item.Codigo = varCodigo;
			
			item.Descripcion = varDescripcion;
			
			item.IdTipoPractica = varIdTipoPractica;
			
			item.IdUnidad = varIdUnidad;
			
			item.IdTipoNomenclador = varIdTipoNomenclador;
			
			item.ValorUnidad = varValorUnidad;
			
			item.EsAmbulatorio = varEsAmbulatorio;
			
			item.Activo = varActivo;
			
			item.IdCapitulo = varIdCapitulo;
			
			item.Ug = varUg;
			
			item.Anestesia = varAnestesia;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varIdNomenclador,string varCodigo,string varDescripcion,int varIdTipoPractica,int varIdUnidad,int varIdTipoNomenclador,decimal varValorUnidad,bool varEsAmbulatorio,bool varActivo,int varIdCapitulo,decimal? varUg,string varAnestesia)
		{
			FacNomenclador item = new FacNomenclador();
			
				item.IdNomenclador = varIdNomenclador;
			
				item.Codigo = varCodigo;
			
				item.Descripcion = varDescripcion;
			
				item.IdTipoPractica = varIdTipoPractica;
			
				item.IdUnidad = varIdUnidad;
			
				item.IdTipoNomenclador = varIdTipoNomenclador;
			
				item.ValorUnidad = varValorUnidad;
			
				item.EsAmbulatorio = varEsAmbulatorio;
			
				item.Activo = varActivo;
			
				item.IdCapitulo = varIdCapitulo;
			
				item.Ug = varUg;
			
				item.Anestesia = varAnestesia;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn IdNomencladorColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn CodigoColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn DescripcionColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn IdTipoPracticaColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn IdUnidadColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn IdTipoNomencladorColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        public static TableSchema.TableColumn ValorUnidadColumn
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        public static TableSchema.TableColumn EsAmbulatorioColumn
        {
            get { return Schema.Columns[7]; }
        }
        
        
        
        public static TableSchema.TableColumn ActivoColumn
        {
            get { return Schema.Columns[8]; }
        }
        
        
        
        public static TableSchema.TableColumn IdCapituloColumn
        {
            get { return Schema.Columns[9]; }
        }
        
        
        
        public static TableSchema.TableColumn UgColumn
        {
            get { return Schema.Columns[10]; }
        }
        
        
        
        public static TableSchema.TableColumn AnestesiaColumn
        {
            get { return Schema.Columns[11]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string IdNomenclador = @"idNomenclador";
			 public static string Codigo = @"codigo";
			 public static string Descripcion = @"descripcion";
			 public static string IdTipoPractica = @"idTipoPractica";
			 public static string IdUnidad = @"idUnidad";
			 public static string IdTipoNomenclador = @"idTipoNomenclador";
			 public static string ValorUnidad = @"valorUnidad";
			 public static string EsAmbulatorio = @"esAmbulatorio";
			 public static string Activo = @"activo";
			 public static string IdCapitulo = @"idCapitulo";
			 public static string Ug = @"UG";
			 public static string Anestesia = @"Anestesia";
						
		}
		#endregion
		
		#region Update PK Collections
		
        public void SetPKValues()
        {
                if (colFacOrdenDetalleRecords != null)
                {
                    foreach (DalRis.FacOrdenDetalle item in colFacOrdenDetalleRecords)
                    {
                        if (item.IdNomenclador != IdNomenclador)
                        {
                            item.IdNomenclador = IdNomenclador;
                        }
                    }
               }
		}
        #endregion
    
        #region Deep Save
		
        public void DeepSave()
        {
            Save();
            
                if (colFacOrdenDetalleRecords != null)
                {
                    colFacOrdenDetalleRecords.SaveAll();
               }
		}
        #endregion
	}
}
