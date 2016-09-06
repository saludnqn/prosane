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
	/// Strongly-typed collection for the SysMedicamento class.
	/// </summary>
    [Serializable]
	public partial class SysMedicamentoCollection : ActiveList<SysMedicamento, SysMedicamentoCollection>
	{	   
		public SysMedicamentoCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>SysMedicamentoCollection</returns>
		public SysMedicamentoCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                SysMedicamento o = this[i];
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
	/// This is an ActiveRecord class which wraps the Sys_Medicamento table.
	/// </summary>
	[Serializable]
	public partial class SysMedicamento : ActiveRecord<SysMedicamento>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public SysMedicamento()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public SysMedicamento(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public SysMedicamento(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public SysMedicamento(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("Sys_Medicamento", TableType.Table, DataService.GetInstance("RisProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarIdMedicamento = new TableSchema.TableColumn(schema);
				colvarIdMedicamento.ColumnName = "idMedicamento";
				colvarIdMedicamento.DataType = DbType.Int32;
				colvarIdMedicamento.MaxLength = 0;
				colvarIdMedicamento.AutoIncrement = true;
				colvarIdMedicamento.IsNullable = false;
				colvarIdMedicamento.IsPrimaryKey = true;
				colvarIdMedicamento.IsForeignKey = false;
				colvarIdMedicamento.IsReadOnly = false;
				colvarIdMedicamento.DefaultSetting = @"";
				colvarIdMedicamento.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdMedicamento);
				
				TableSchema.TableColumn colvarIdMedicamentoRubro = new TableSchema.TableColumn(schema);
				colvarIdMedicamentoRubro.ColumnName = "idMedicamentoRubro";
				colvarIdMedicamentoRubro.DataType = DbType.Int32;
				colvarIdMedicamentoRubro.MaxLength = 0;
				colvarIdMedicamentoRubro.AutoIncrement = false;
				colvarIdMedicamentoRubro.IsNullable = true;
				colvarIdMedicamentoRubro.IsPrimaryKey = false;
				colvarIdMedicamentoRubro.IsForeignKey = true;
				colvarIdMedicamentoRubro.IsReadOnly = false;
				colvarIdMedicamentoRubro.DefaultSetting = @"";
				
					colvarIdMedicamentoRubro.ForeignKeyTableName = "Sys_MedicamentoRubro";
				schema.Columns.Add(colvarIdMedicamentoRubro);
				
				TableSchema.TableColumn colvarNombre = new TableSchema.TableColumn(schema);
				colvarNombre.ColumnName = "nombre";
				colvarNombre.DataType = DbType.String;
				colvarNombre.MaxLength = 255;
				colvarNombre.AutoIncrement = false;
				colvarNombre.IsNullable = true;
				colvarNombre.IsPrimaryKey = false;
				colvarNombre.IsForeignKey = false;
				colvarNombre.IsReadOnly = false;
				colvarNombre.DefaultSetting = @"";
				colvarNombre.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNombre);
				
				TableSchema.TableColumn colvarUnidad = new TableSchema.TableColumn(schema);
				colvarUnidad.ColumnName = "unidad";
				colvarUnidad.DataType = DbType.String;
				colvarUnidad.MaxLength = 255;
				colvarUnidad.AutoIncrement = false;
				colvarUnidad.IsNullable = true;
				colvarUnidad.IsPrimaryKey = false;
				colvarUnidad.IsForeignKey = false;
				colvarUnidad.IsReadOnly = false;
				colvarUnidad.DefaultSetting = @"";
				colvarUnidad.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUnidad);
				
				TableSchema.TableColumn colvarNecesitaVencimiento = new TableSchema.TableColumn(schema);
				colvarNecesitaVencimiento.ColumnName = "necesitaVencimiento";
				colvarNecesitaVencimiento.DataType = DbType.Boolean;
				colvarNecesitaVencimiento.MaxLength = 0;
				colvarNecesitaVencimiento.AutoIncrement = false;
				colvarNecesitaVencimiento.IsNullable = true;
				colvarNecesitaVencimiento.IsPrimaryKey = false;
				colvarNecesitaVencimiento.IsForeignKey = false;
				colvarNecesitaVencimiento.IsReadOnly = false;
				colvarNecesitaVencimiento.DefaultSetting = @"";
				colvarNecesitaVencimiento.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNecesitaVencimiento);
				
				TableSchema.TableColumn colvarActivo = new TableSchema.TableColumn(schema);
				colvarActivo.ColumnName = "activo";
				colvarActivo.DataType = DbType.Boolean;
				colvarActivo.MaxLength = 0;
				colvarActivo.AutoIncrement = false;
				colvarActivo.IsNullable = true;
				colvarActivo.IsPrimaryKey = false;
				colvarActivo.IsForeignKey = false;
				colvarActivo.IsReadOnly = false;
				colvarActivo.DefaultSetting = @"";
				colvarActivo.ForeignKeyTableName = "";
				schema.Columns.Add(colvarActivo);
				
				TableSchema.TableColumn colvarUltimaModificacion = new TableSchema.TableColumn(schema);
				colvarUltimaModificacion.ColumnName = "ultimaModificacion";
				colvarUltimaModificacion.DataType = DbType.DateTime;
				colvarUltimaModificacion.MaxLength = 0;
				colvarUltimaModificacion.AutoIncrement = false;
				colvarUltimaModificacion.IsNullable = true;
				colvarUltimaModificacion.IsPrimaryKey = false;
				colvarUltimaModificacion.IsForeignKey = false;
				colvarUltimaModificacion.IsReadOnly = false;
				colvarUltimaModificacion.DefaultSetting = @"";
				colvarUltimaModificacion.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUltimaModificacion);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["RisProvider"].AddSchema("Sys_Medicamento",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("IdMedicamento")]
		[Bindable(true)]
		public int IdMedicamento 
		{
			get { return GetColumnValue<int>(Columns.IdMedicamento); }
			set { SetColumnValue(Columns.IdMedicamento, value); }
		}
		  
		[XmlAttribute("IdMedicamentoRubro")]
		[Bindable(true)]
		public int? IdMedicamentoRubro 
		{
			get { return GetColumnValue<int?>(Columns.IdMedicamentoRubro); }
			set { SetColumnValue(Columns.IdMedicamentoRubro, value); }
		}
		  
		[XmlAttribute("Nombre")]
		[Bindable(true)]
		public string Nombre 
		{
			get { return GetColumnValue<string>(Columns.Nombre); }
			set { SetColumnValue(Columns.Nombre, value); }
		}
		  
		[XmlAttribute("Unidad")]
		[Bindable(true)]
		public string Unidad 
		{
			get { return GetColumnValue<string>(Columns.Unidad); }
			set { SetColumnValue(Columns.Unidad, value); }
		}
		  
		[XmlAttribute("NecesitaVencimiento")]
		[Bindable(true)]
		public bool? NecesitaVencimiento 
		{
			get { return GetColumnValue<bool?>(Columns.NecesitaVencimiento); }
			set { SetColumnValue(Columns.NecesitaVencimiento, value); }
		}
		  
		[XmlAttribute("Activo")]
		[Bindable(true)]
		public bool? Activo 
		{
			get { return GetColumnValue<bool?>(Columns.Activo); }
			set { SetColumnValue(Columns.Activo, value); }
		}
		  
		[XmlAttribute("UltimaModificacion")]
		[Bindable(true)]
		public DateTime? UltimaModificacion 
		{
			get { return GetColumnValue<DateTime?>(Columns.UltimaModificacion); }
			set { SetColumnValue(Columns.UltimaModificacion, value); }
		}
		
		#endregion
		
		
		#region PrimaryKey Methods		
		
        protected override void SetPrimaryKey(object oValue)
        {
            base.SetPrimaryKey(oValue);
            
            SetPKValues();
        }
        
		
		private DalRis.TabRelMedicamentoTabCollection colTabRelMedicamentoTabRecords;
		public DalRis.TabRelMedicamentoTabCollection TabRelMedicamentoTabRecords()
		{
			if(colTabRelMedicamentoTabRecords == null)
			{
				colTabRelMedicamentoTabRecords = new DalRis.TabRelMedicamentoTabCollection().Where(TabRelMedicamentoTab.Columns.IdMedicamento, IdMedicamento).Load();
				colTabRelMedicamentoTabRecords.ListChanged += new ListChangedEventHandler(colTabRelMedicamentoTabRecords_ListChanged);
			}
			return colTabRelMedicamentoTabRecords;
		}
				
		void colTabRelMedicamentoTabRecords_ListChanged(object sender, ListChangedEventArgs e)
		{
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
		        // Set foreign key value
		        colTabRelMedicamentoTabRecords[e.NewIndex].IdMedicamento = IdMedicamento;
				colTabRelMedicamentoTabRecords.ListChanged += new ListChangedEventHandler(colTabRelMedicamentoTabRecords_ListChanged);
            }
		}
		private DalRis.TabMedicamentoTabaquismoCollection colTabMedicamentoTabaquismoRecords;
		public DalRis.TabMedicamentoTabaquismoCollection TabMedicamentoTabaquismoRecords()
		{
			if(colTabMedicamentoTabaquismoRecords == null)
			{
				colTabMedicamentoTabaquismoRecords = new DalRis.TabMedicamentoTabaquismoCollection().Where(TabMedicamentoTabaquismo.Columns.IdMedicamento, IdMedicamento).Load();
				colTabMedicamentoTabaquismoRecords.ListChanged += new ListChangedEventHandler(colTabMedicamentoTabaquismoRecords_ListChanged);
			}
			return colTabMedicamentoTabaquismoRecords;
		}
				
		void colTabMedicamentoTabaquismoRecords_ListChanged(object sender, ListChangedEventArgs e)
		{
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
		        // Set foreign key value
		        colTabMedicamentoTabaquismoRecords[e.NewIndex].IdMedicamento = IdMedicamento;
				colTabMedicamentoTabaquismoRecords.ListChanged += new ListChangedEventHandler(colTabMedicamentoTabaquismoRecords_ListChanged);
            }
		}
		private DalRis.AprAplicacionVacunaCollection colAprAplicacionVacunaRecords;
		public DalRis.AprAplicacionVacunaCollection AprAplicacionVacunaRecords()
		{
			if(colAprAplicacionVacunaRecords == null)
			{
				colAprAplicacionVacunaRecords = new DalRis.AprAplicacionVacunaCollection().Where(AprAplicacionVacuna.Columns.IdVacuna, IdMedicamento).Load();
				colAprAplicacionVacunaRecords.ListChanged += new ListChangedEventHandler(colAprAplicacionVacunaRecords_ListChanged);
			}
			return colAprAplicacionVacunaRecords;
		}
				
		void colAprAplicacionVacunaRecords_ListChanged(object sender, ListChangedEventArgs e)
		{
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
		        // Set foreign key value
		        colAprAplicacionVacunaRecords[e.NewIndex].IdVacuna = IdMedicamento;
				colAprAplicacionVacunaRecords.ListChanged += new ListChangedEventHandler(colAprAplicacionVacunaRecords_ListChanged);
            }
		}
		private DalRis.AprCalendarioVacunaCollection colAprCalendarioVacunaRecords;
		public DalRis.AprCalendarioVacunaCollection AprCalendarioVacunaRecords()
		{
			if(colAprCalendarioVacunaRecords == null)
			{
				colAprCalendarioVacunaRecords = new DalRis.AprCalendarioVacunaCollection().Where(AprCalendarioVacuna.Columns.IdVacuna, IdMedicamento).Load();
				colAprCalendarioVacunaRecords.ListChanged += new ListChangedEventHandler(colAprCalendarioVacunaRecords_ListChanged);
			}
			return colAprCalendarioVacunaRecords;
		}
				
		void colAprCalendarioVacunaRecords_ListChanged(object sender, ListChangedEventArgs e)
		{
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
		        // Set foreign key value
		        colAprCalendarioVacunaRecords[e.NewIndex].IdVacuna = IdMedicamento;
				colAprCalendarioVacunaRecords.ListChanged += new ListChangedEventHandler(colAprCalendarioVacunaRecords_ListChanged);
            }
		}
		private DalRis.RemRelMedicamentoSeguimientoCollection colRemRelMedicamentoSeguimientoRecords;
		public DalRis.RemRelMedicamentoSeguimientoCollection RemRelMedicamentoSeguimientoRecords()
		{
			if(colRemRelMedicamentoSeguimientoRecords == null)
			{
				colRemRelMedicamentoSeguimientoRecords = new DalRis.RemRelMedicamentoSeguimientoCollection().Where(RemRelMedicamentoSeguimiento.Columns.IdMedicamento, IdMedicamento).Load();
				colRemRelMedicamentoSeguimientoRecords.ListChanged += new ListChangedEventHandler(colRemRelMedicamentoSeguimientoRecords_ListChanged);
			}
			return colRemRelMedicamentoSeguimientoRecords;
		}
				
		void colRemRelMedicamentoSeguimientoRecords_ListChanged(object sender, ListChangedEventArgs e)
		{
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
		        // Set foreign key value
		        colRemRelMedicamentoSeguimientoRecords[e.NewIndex].IdMedicamento = IdMedicamento;
				colRemRelMedicamentoSeguimientoRecords.ListChanged += new ListChangedEventHandler(colRemRelMedicamentoSeguimientoRecords_ListChanged);
            }
		}
		private DalRis.RemRelMedicamentoClasificacionCollection colRemRelMedicamentoClasificacionRecords;
		public DalRis.RemRelMedicamentoClasificacionCollection RemRelMedicamentoClasificacionRecords()
		{
			if(colRemRelMedicamentoClasificacionRecords == null)
			{
				colRemRelMedicamentoClasificacionRecords = new DalRis.RemRelMedicamentoClasificacionCollection().Where(RemRelMedicamentoClasificacion.Columns.IdMedicamento, IdMedicamento).Load();
				colRemRelMedicamentoClasificacionRecords.ListChanged += new ListChangedEventHandler(colRemRelMedicamentoClasificacionRecords_ListChanged);
			}
			return colRemRelMedicamentoClasificacionRecords;
		}
				
		void colRemRelMedicamentoClasificacionRecords_ListChanged(object sender, ListChangedEventArgs e)
		{
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
		        // Set foreign key value
		        colRemRelMedicamentoClasificacionRecords[e.NewIndex].IdMedicamento = IdMedicamento;
				colRemRelMedicamentoClasificacionRecords.ListChanged += new ListChangedEventHandler(colRemRelMedicamentoClasificacionRecords_ListChanged);
            }
		}
		private DalRis.RemMedicamentoCronicoCollection colRemMedicamentoCronicoRecords;
		public DalRis.RemMedicamentoCronicoCollection RemMedicamentoCronicoRecords()
		{
			if(colRemMedicamentoCronicoRecords == null)
			{
				colRemMedicamentoCronicoRecords = new DalRis.RemMedicamentoCronicoCollection().Where(RemMedicamentoCronico.Columns.IdMedicamento, IdMedicamento).Load();
				colRemMedicamentoCronicoRecords.ListChanged += new ListChangedEventHandler(colRemMedicamentoCronicoRecords_ListChanged);
			}
			return colRemMedicamentoCronicoRecords;
		}
				
		void colRemMedicamentoCronicoRecords_ListChanged(object sender, ListChangedEventArgs e)
		{
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
		        // Set foreign key value
		        colRemMedicamentoCronicoRecords[e.NewIndex].IdMedicamento = IdMedicamento;
				colRemMedicamentoCronicoRecords.ListChanged += new ListChangedEventHandler(colRemMedicamentoCronicoRecords_ListChanged);
            }
		}
		#endregion
		
			
		
		#region ForeignKey Properties
		
		/// <summary>
		/// Returns a SysMedicamentoRubro ActiveRecord object related to this SysMedicamento
		/// 
		/// </summary>
		public DalRis.SysMedicamentoRubro SysMedicamentoRubro
		{
			get { return DalRis.SysMedicamentoRubro.FetchByID(this.IdMedicamentoRubro); }
			set { SetColumnValue("idMedicamentoRubro", value.IdMedicamentoRubro); }
		}
		
		
		#endregion
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(int? varIdMedicamentoRubro,string varNombre,string varUnidad,bool? varNecesitaVencimiento,bool? varActivo,DateTime? varUltimaModificacion)
		{
			SysMedicamento item = new SysMedicamento();
			
			item.IdMedicamentoRubro = varIdMedicamentoRubro;
			
			item.Nombre = varNombre;
			
			item.Unidad = varUnidad;
			
			item.NecesitaVencimiento = varNecesitaVencimiento;
			
			item.Activo = varActivo;
			
			item.UltimaModificacion = varUltimaModificacion;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varIdMedicamento,int? varIdMedicamentoRubro,string varNombre,string varUnidad,bool? varNecesitaVencimiento,bool? varActivo,DateTime? varUltimaModificacion)
		{
			SysMedicamento item = new SysMedicamento();
			
				item.IdMedicamento = varIdMedicamento;
			
				item.IdMedicamentoRubro = varIdMedicamentoRubro;
			
				item.Nombre = varNombre;
			
				item.Unidad = varUnidad;
			
				item.NecesitaVencimiento = varNecesitaVencimiento;
			
				item.Activo = varActivo;
			
				item.UltimaModificacion = varUltimaModificacion;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn IdMedicamentoColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn IdMedicamentoRubroColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn NombreColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn UnidadColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn NecesitaVencimientoColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn ActivoColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        public static TableSchema.TableColumn UltimaModificacionColumn
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string IdMedicamento = @"idMedicamento";
			 public static string IdMedicamentoRubro = @"idMedicamentoRubro";
			 public static string Nombre = @"nombre";
			 public static string Unidad = @"unidad";
			 public static string NecesitaVencimiento = @"necesitaVencimiento";
			 public static string Activo = @"activo";
			 public static string UltimaModificacion = @"ultimaModificacion";
						
		}
		#endregion
		
		#region Update PK Collections
		
        public void SetPKValues()
        {
                if (colTabRelMedicamentoTabRecords != null)
                {
                    foreach (DalRis.TabRelMedicamentoTab item in colTabRelMedicamentoTabRecords)
                    {
                        if (item.IdMedicamento != IdMedicamento)
                        {
                            item.IdMedicamento = IdMedicamento;
                        }
                    }
               }
		
                if (colTabMedicamentoTabaquismoRecords != null)
                {
                    foreach (DalRis.TabMedicamentoTabaquismo item in colTabMedicamentoTabaquismoRecords)
                    {
                        if (item.IdMedicamento != IdMedicamento)
                        {
                            item.IdMedicamento = IdMedicamento;
                        }
                    }
               }
		
                if (colAprAplicacionVacunaRecords != null)
                {
                    foreach (DalRis.AprAplicacionVacuna item in colAprAplicacionVacunaRecords)
                    {
                        if (item.IdVacuna != IdMedicamento)
                        {
                            item.IdVacuna = IdMedicamento;
                        }
                    }
               }
		
                if (colAprCalendarioVacunaRecords != null)
                {
                    foreach (DalRis.AprCalendarioVacuna item in colAprCalendarioVacunaRecords)
                    {
                        if (item.IdVacuna != IdMedicamento)
                        {
                            item.IdVacuna = IdMedicamento;
                        }
                    }
               }
		
                if (colRemRelMedicamentoSeguimientoRecords != null)
                {
                    foreach (DalRis.RemRelMedicamentoSeguimiento item in colRemRelMedicamentoSeguimientoRecords)
                    {
                        if (item.IdMedicamento != IdMedicamento)
                        {
                            item.IdMedicamento = IdMedicamento;
                        }
                    }
               }
		
                if (colRemRelMedicamentoClasificacionRecords != null)
                {
                    foreach (DalRis.RemRelMedicamentoClasificacion item in colRemRelMedicamentoClasificacionRecords)
                    {
                        if (item.IdMedicamento != IdMedicamento)
                        {
                            item.IdMedicamento = IdMedicamento;
                        }
                    }
               }
		
                if (colRemMedicamentoCronicoRecords != null)
                {
                    foreach (DalRis.RemMedicamentoCronico item in colRemMedicamentoCronicoRecords)
                    {
                        if (item.IdMedicamento != IdMedicamento)
                        {
                            item.IdMedicamento = IdMedicamento;
                        }
                    }
               }
		}
        #endregion
    
        #region Deep Save
		
        public void DeepSave()
        {
            Save();
            
                if (colTabRelMedicamentoTabRecords != null)
                {
                    colTabRelMedicamentoTabRecords.SaveAll();
               }
		
                if (colTabMedicamentoTabaquismoRecords != null)
                {
                    colTabMedicamentoTabaquismoRecords.SaveAll();
               }
		
                if (colAprAplicacionVacunaRecords != null)
                {
                    colAprAplicacionVacunaRecords.SaveAll();
               }
		
                if (colAprCalendarioVacunaRecords != null)
                {
                    colAprCalendarioVacunaRecords.SaveAll();
               }
		
                if (colRemRelMedicamentoSeguimientoRecords != null)
                {
                    colRemRelMedicamentoSeguimientoRecords.SaveAll();
               }
		
                if (colRemRelMedicamentoClasificacionRecords != null)
                {
                    colRemRelMedicamentoClasificacionRecords.SaveAll();
               }
		
                if (colRemMedicamentoCronicoRecords != null)
                {
                    colRemMedicamentoCronicoRecords.SaveAll();
               }
		}
        #endregion
	}
}