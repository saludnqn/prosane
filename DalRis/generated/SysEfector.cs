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
// <auto-generated />
namespace DalRis
{
	/// <summary>
	/// Strongly-typed collection for the SysEfector class.
	/// </summary>
    [Serializable]
	public partial class SysEfectorCollection : ActiveList<SysEfector, SysEfectorCollection>
	{	   
		public SysEfectorCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>SysEfectorCollection</returns>
		public SysEfectorCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                SysEfector o = this[i];
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
	/// This is an ActiveRecord class which wraps the Sys_Efector table.
	/// </summary>
	[Serializable]
	public partial class SysEfector : ActiveRecord<SysEfector>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public SysEfector()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public SysEfector(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public SysEfector(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public SysEfector(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("Sys_Efector", TableType.Table, DataService.GetInstance("RisProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarIdEfector = new TableSchema.TableColumn(schema);
				colvarIdEfector.ColumnName = "idEfector";
				colvarIdEfector.DataType = DbType.Int32;
				colvarIdEfector.MaxLength = 0;
				colvarIdEfector.AutoIncrement = true;
				colvarIdEfector.IsNullable = false;
				colvarIdEfector.IsPrimaryKey = true;
				colvarIdEfector.IsForeignKey = false;
				colvarIdEfector.IsReadOnly = false;
				colvarIdEfector.DefaultSetting = @"";
				colvarIdEfector.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdEfector);
				
				TableSchema.TableColumn colvarNombre = new TableSchema.TableColumn(schema);
				colvarNombre.ColumnName = "nombre";
				colvarNombre.DataType = DbType.String;
				colvarNombre.MaxLength = 100;
				colvarNombre.AutoIncrement = false;
				colvarNombre.IsNullable = false;
				colvarNombre.IsPrimaryKey = false;
				colvarNombre.IsForeignKey = false;
				colvarNombre.IsReadOnly = false;
				colvarNombre.DefaultSetting = @"";
				colvarNombre.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNombre);
				
				TableSchema.TableColumn colvarIdZona = new TableSchema.TableColumn(schema);
				colvarIdZona.ColumnName = "idZona";
				colvarIdZona.DataType = DbType.Int32;
				colvarIdZona.MaxLength = 0;
				colvarIdZona.AutoIncrement = false;
				colvarIdZona.IsNullable = false;
				colvarIdZona.IsPrimaryKey = false;
				colvarIdZona.IsForeignKey = true;
				colvarIdZona.IsReadOnly = false;
				colvarIdZona.DefaultSetting = @"";
				
					colvarIdZona.ForeignKeyTableName = "Sys_Zona";
				schema.Columns.Add(colvarIdZona);
				
				TableSchema.TableColumn colvarNombreNacion = new TableSchema.TableColumn(schema);
				colvarNombreNacion.ColumnName = "nombreNacion";
				colvarNombreNacion.DataType = DbType.String;
				colvarNombreNacion.MaxLength = 100;
				colvarNombreNacion.AutoIncrement = false;
				colvarNombreNacion.IsNullable = false;
				colvarNombreNacion.IsPrimaryKey = false;
				colvarNombreNacion.IsForeignKey = false;
				colvarNombreNacion.IsReadOnly = false;
				
						colvarNombreNacion.DefaultSetting = @"('')";
				colvarNombreNacion.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNombreNacion);
				
				TableSchema.TableColumn colvarComplejidad = new TableSchema.TableColumn(schema);
				colvarComplejidad.ColumnName = "complejidad";
				colvarComplejidad.DataType = DbType.String;
				colvarComplejidad.MaxLength = 10;
				colvarComplejidad.AutoIncrement = false;
				colvarComplejidad.IsNullable = false;
				colvarComplejidad.IsPrimaryKey = false;
				colvarComplejidad.IsForeignKey = false;
				colvarComplejidad.IsReadOnly = false;
				
						colvarComplejidad.DefaultSetting = @"('')";
				colvarComplejidad.ForeignKeyTableName = "";
				schema.Columns.Add(colvarComplejidad);
				
				TableSchema.TableColumn colvarIdEfectorSuperior = new TableSchema.TableColumn(schema);
				colvarIdEfectorSuperior.ColumnName = "idEfectorSuperior";
				colvarIdEfectorSuperior.DataType = DbType.Int32;
				colvarIdEfectorSuperior.MaxLength = 0;
				colvarIdEfectorSuperior.AutoIncrement = false;
				colvarIdEfectorSuperior.IsNullable = false;
				colvarIdEfectorSuperior.IsPrimaryKey = false;
				colvarIdEfectorSuperior.IsForeignKey = true;
				colvarIdEfectorSuperior.IsReadOnly = false;
				
						colvarIdEfectorSuperior.DefaultSetting = @"('')";
				
					colvarIdEfectorSuperior.ForeignKeyTableName = "Sys_Efector";
				schema.Columns.Add(colvarIdEfectorSuperior);
				
				TableSchema.TableColumn colvarDomicilio = new TableSchema.TableColumn(schema);
				colvarDomicilio.ColumnName = "domicilio";
				colvarDomicilio.DataType = DbType.String;
				colvarDomicilio.MaxLength = 200;
				colvarDomicilio.AutoIncrement = false;
				colvarDomicilio.IsNullable = false;
				colvarDomicilio.IsPrimaryKey = false;
				colvarDomicilio.IsForeignKey = false;
				colvarDomicilio.IsReadOnly = false;
				
						colvarDomicilio.DefaultSetting = @"('')";
				colvarDomicilio.ForeignKeyTableName = "";
				schema.Columns.Add(colvarDomicilio);
				
				TableSchema.TableColumn colvarTelefono = new TableSchema.TableColumn(schema);
				colvarTelefono.ColumnName = "telefono";
				colvarTelefono.DataType = DbType.String;
				colvarTelefono.MaxLength = 10;
				colvarTelefono.AutoIncrement = false;
				colvarTelefono.IsNullable = false;
				colvarTelefono.IsPrimaryKey = false;
				colvarTelefono.IsForeignKey = false;
				colvarTelefono.IsReadOnly = false;
				
						colvarTelefono.DefaultSetting = @"('')";
				colvarTelefono.ForeignKeyTableName = "";
				schema.Columns.Add(colvarTelefono);
				
				TableSchema.TableColumn colvarReponsable = new TableSchema.TableColumn(schema);
				colvarReponsable.ColumnName = "reponsable";
				colvarReponsable.DataType = DbType.String;
				colvarReponsable.MaxLength = 100;
				colvarReponsable.AutoIncrement = false;
				colvarReponsable.IsNullable = false;
				colvarReponsable.IsPrimaryKey = false;
				colvarReponsable.IsForeignKey = false;
				colvarReponsable.IsReadOnly = false;
				
						colvarReponsable.DefaultSetting = @"('')";
				colvarReponsable.ForeignKeyTableName = "";
				schema.Columns.Add(colvarReponsable);
				
				TableSchema.TableColumn colvarCodigoRemediar = new TableSchema.TableColumn(schema);
				colvarCodigoRemediar.ColumnName = "codigoRemediar";
				colvarCodigoRemediar.DataType = DbType.String;
				colvarCodigoRemediar.MaxLength = 10;
				colvarCodigoRemediar.AutoIncrement = false;
				colvarCodigoRemediar.IsNullable = true;
				colvarCodigoRemediar.IsPrimaryKey = false;
				colvarCodigoRemediar.IsForeignKey = false;
				colvarCodigoRemediar.IsReadOnly = false;
				colvarCodigoRemediar.DefaultSetting = @"";
				colvarCodigoRemediar.ForeignKeyTableName = "";
				schema.Columns.Add(colvarCodigoRemediar);
				
				TableSchema.TableColumn colvarCuie = new TableSchema.TableColumn(schema);
				colvarCuie.ColumnName = "cuie";
				colvarCuie.DataType = DbType.AnsiString;
				colvarCuie.MaxLength = 10;
				colvarCuie.AutoIncrement = false;
				colvarCuie.IsNullable = true;
				colvarCuie.IsPrimaryKey = false;
				colvarCuie.IsForeignKey = false;
				colvarCuie.IsReadOnly = false;
				colvarCuie.DefaultSetting = @"";
				colvarCuie.ForeignKeyTableName = "";
				schema.Columns.Add(colvarCuie);
				
				TableSchema.TableColumn colvarIdTipoEfector = new TableSchema.TableColumn(schema);
				colvarIdTipoEfector.ColumnName = "idTipoEfector";
				colvarIdTipoEfector.DataType = DbType.Int32;
				colvarIdTipoEfector.MaxLength = 0;
				colvarIdTipoEfector.AutoIncrement = false;
				colvarIdTipoEfector.IsNullable = true;
				colvarIdTipoEfector.IsPrimaryKey = false;
				colvarIdTipoEfector.IsForeignKey = false;
				colvarIdTipoEfector.IsReadOnly = false;
				colvarIdTipoEfector.DefaultSetting = @"";
				colvarIdTipoEfector.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdTipoEfector);
				
				TableSchema.TableColumn colvarCodigoSisa = new TableSchema.TableColumn(schema);
				colvarCodigoSisa.ColumnName = "codigoSisa";
				colvarCodigoSisa.DataType = DbType.AnsiString;
				colvarCodigoSisa.MaxLength = 50;
				colvarCodigoSisa.AutoIncrement = false;
				colvarCodigoSisa.IsNullable = true;
				colvarCodigoSisa.IsPrimaryKey = false;
				colvarCodigoSisa.IsForeignKey = false;
				colvarCodigoSisa.IsReadOnly = false;
				
						colvarCodigoSisa.DefaultSetting = @"((0))";
				colvarCodigoSisa.ForeignKeyTableName = "";
				schema.Columns.Add(colvarCodigoSisa);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["RisProvider"].AddSchema("Sys_Efector",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("IdEfector")]
		[Bindable(true)]
		public int IdEfector 
		{
			get { return GetColumnValue<int>(Columns.IdEfector); }
			set { SetColumnValue(Columns.IdEfector, value); }
		}
		  
		[XmlAttribute("Nombre")]
		[Bindable(true)]
		public string Nombre 
		{
			get { return GetColumnValue<string>(Columns.Nombre); }
			set { SetColumnValue(Columns.Nombre, value); }
		}
		  
		[XmlAttribute("IdZona")]
		[Bindable(true)]
		public int IdZona 
		{
			get { return GetColumnValue<int>(Columns.IdZona); }
			set { SetColumnValue(Columns.IdZona, value); }
		}
		  
		[XmlAttribute("NombreNacion")]
		[Bindable(true)]
		public string NombreNacion 
		{
			get { return GetColumnValue<string>(Columns.NombreNacion); }
			set { SetColumnValue(Columns.NombreNacion, value); }
		}
		  
		[XmlAttribute("Complejidad")]
		[Bindable(true)]
		public string Complejidad 
		{
			get { return GetColumnValue<string>(Columns.Complejidad); }
			set { SetColumnValue(Columns.Complejidad, value); }
		}
		  
		[XmlAttribute("IdEfectorSuperior")]
		[Bindable(true)]
		public int IdEfectorSuperior 
		{
			get { return GetColumnValue<int>(Columns.IdEfectorSuperior); }
			set { SetColumnValue(Columns.IdEfectorSuperior, value); }
		}
		  
		[XmlAttribute("Domicilio")]
		[Bindable(true)]
		public string Domicilio 
		{
			get { return GetColumnValue<string>(Columns.Domicilio); }
			set { SetColumnValue(Columns.Domicilio, value); }
		}
		  
		[XmlAttribute("Telefono")]
		[Bindable(true)]
		public string Telefono 
		{
			get { return GetColumnValue<string>(Columns.Telefono); }
			set { SetColumnValue(Columns.Telefono, value); }
		}
		  
		[XmlAttribute("Reponsable")]
		[Bindable(true)]
		public string Reponsable 
		{
			get { return GetColumnValue<string>(Columns.Reponsable); }
			set { SetColumnValue(Columns.Reponsable, value); }
		}
		  
		[XmlAttribute("CodigoRemediar")]
		[Bindable(true)]
		public string CodigoRemediar 
		{
			get { return GetColumnValue<string>(Columns.CodigoRemediar); }
			set { SetColumnValue(Columns.CodigoRemediar, value); }
		}
		  
		[XmlAttribute("Cuie")]
		[Bindable(true)]
		public string Cuie 
		{
			get { return GetColumnValue<string>(Columns.Cuie); }
			set { SetColumnValue(Columns.Cuie, value); }
		}
		  
		[XmlAttribute("IdTipoEfector")]
		[Bindable(true)]
		public int? IdTipoEfector 
		{
			get { return GetColumnValue<int?>(Columns.IdTipoEfector); }
			set { SetColumnValue(Columns.IdTipoEfector, value); }
		}
		  
		[XmlAttribute("CodigoSisa")]
		[Bindable(true)]
		public string CodigoSisa 
		{
			get { return GetColumnValue<string>(Columns.CodigoSisa); }
			set { SetColumnValue(Columns.CodigoSisa, value); }
		}
		
		#endregion
		
		
		#region PrimaryKey Methods		
		
        protected override void SetPrimaryKey(object oValue)
        {
            base.SetPrimaryKey(oValue);
            
            SetPKValues();
        }
        
				
		private DalRis.SysRelServicioEfectorCollection colSysRelServicioEfectorRecords;
		public DalRis.SysRelServicioEfectorCollection SysRelServicioEfectorRecords
		{
			get
			{
				if(colSysRelServicioEfectorRecords == null)
				{
					colSysRelServicioEfectorRecords = new DalRis.SysRelServicioEfectorCollection().Where(SysRelServicioEfector.Columns.IdEfector, IdEfector).Load();
					colSysRelServicioEfectorRecords.ListChanged += new ListChangedEventHandler(colSysRelServicioEfectorRecords_ListChanged);
				}
				return colSysRelServicioEfectorRecords;			
			}
			set 
			{ 
					colSysRelServicioEfectorRecords = value; 
					colSysRelServicioEfectorRecords.ListChanged += new ListChangedEventHandler(colSysRelServicioEfectorRecords_ListChanged);
			}
		}
		
		void colSysRelServicioEfectorRecords_ListChanged(object sender, ListChangedEventArgs e)
		{
		    if (e.ListChangedType == ListChangedType.ItemAdded)
		    {
		        // Set foreign key value
		        colSysRelServicioEfectorRecords[e.NewIndex].IdEfector = IdEfector;
		    }
		}
				
		private DalRis.SysEfectorCollection colChildSysEfectorRecords;
		public DalRis.SysEfectorCollection ChildSysEfectorRecords
		{
			get
			{
				if(colChildSysEfectorRecords == null)
				{
					colChildSysEfectorRecords = new DalRis.SysEfectorCollection().Where(SysEfector.Columns.IdEfectorSuperior, IdEfector).Load();
					colChildSysEfectorRecords.ListChanged += new ListChangedEventHandler(colChildSysEfectorRecords_ListChanged);
				}
				return colChildSysEfectorRecords;			
			}
			set 
			{ 
					colChildSysEfectorRecords = value; 
					colChildSysEfectorRecords.ListChanged += new ListChangedEventHandler(colChildSysEfectorRecords_ListChanged);
			}
		}
		
		void colChildSysEfectorRecords_ListChanged(object sender, ListChangedEventArgs e)
		{
		    if (e.ListChangedType == ListChangedType.ItemAdded)
		    {
		        // Set foreign key value
		        colChildSysEfectorRecords[e.NewIndex].IdEfectorSuperior = IdEfector;
		    }
		}
				
		private DalRis.SysRelProfesionalEfectorCollection colSysRelProfesionalEfectorRecords;
		public DalRis.SysRelProfesionalEfectorCollection SysRelProfesionalEfectorRecords
		{
			get
			{
				if(colSysRelProfesionalEfectorRecords == null)
				{
					colSysRelProfesionalEfectorRecords = new DalRis.SysRelProfesionalEfectorCollection().Where(SysRelProfesionalEfector.Columns.IdEfector, IdEfector).Load();
					colSysRelProfesionalEfectorRecords.ListChanged += new ListChangedEventHandler(colSysRelProfesionalEfectorRecords_ListChanged);
				}
				return colSysRelProfesionalEfectorRecords;			
			}
			set 
			{ 
					colSysRelProfesionalEfectorRecords = value; 
					colSysRelProfesionalEfectorRecords.ListChanged += new ListChangedEventHandler(colSysRelProfesionalEfectorRecords_ListChanged);
			}
		}
		
		void colSysRelProfesionalEfectorRecords_ListChanged(object sender, ListChangedEventArgs e)
		{
		    if (e.ListChangedType == ListChangedType.ItemAdded)
		    {
		        // Set foreign key value
		        colSysRelProfesionalEfectorRecords[e.NewIndex].IdEfector = IdEfector;
		    }
		}
				
		private DalRis.SysEstablecimientoCollection colSysEstablecimientoRecords;
		public DalRis.SysEstablecimientoCollection SysEstablecimientoRecords
		{
			get
			{
				if(colSysEstablecimientoRecords == null)
				{
					colSysEstablecimientoRecords = new DalRis.SysEstablecimientoCollection().Where(SysEstablecimiento.Columns.IdEfector, IdEfector).Load();
					colSysEstablecimientoRecords.ListChanged += new ListChangedEventHandler(colSysEstablecimientoRecords_ListChanged);
				}
				return colSysEstablecimientoRecords;			
			}
			set 
			{ 
					colSysEstablecimientoRecords = value; 
					colSysEstablecimientoRecords.ListChanged += new ListChangedEventHandler(colSysEstablecimientoRecords_ListChanged);
			}
		}
		
		void colSysEstablecimientoRecords_ListChanged(object sender, ListChangedEventArgs e)
		{
		    if (e.ListChangedType == ListChangedType.ItemAdded)
		    {
		        // Set foreign key value
		        colSysEstablecimientoRecords[e.NewIndex].IdEfector = IdEfector;
		    }
		}
				
		private DalRis.SysRelEspecialidadEfectorCollection colSysRelEspecialidadEfectorRecords;
		public DalRis.SysRelEspecialidadEfectorCollection SysRelEspecialidadEfectorRecords
		{
			get
			{
				if(colSysRelEspecialidadEfectorRecords == null)
				{
					colSysRelEspecialidadEfectorRecords = new DalRis.SysRelEspecialidadEfectorCollection().Where(SysRelEspecialidadEfector.Columns.IdEfector, IdEfector).Load();
					colSysRelEspecialidadEfectorRecords.ListChanged += new ListChangedEventHandler(colSysRelEspecialidadEfectorRecords_ListChanged);
				}
				return colSysRelEspecialidadEfectorRecords;			
			}
			set 
			{ 
					colSysRelEspecialidadEfectorRecords = value; 
					colSysRelEspecialidadEfectorRecords.ListChanged += new ListChangedEventHandler(colSysRelEspecialidadEfectorRecords_ListChanged);
			}
		}
		
		void colSysRelEspecialidadEfectorRecords_ListChanged(object sender, ListChangedEventArgs e)
		{
		    if (e.ListChangedType == ListChangedType.ItemAdded)
		    {
		        // Set foreign key value
		        colSysRelEspecialidadEfectorRecords[e.NewIndex].IdEfector = IdEfector;
		    }
		}
				
		private DalRis.SysRelHistoriaClinicaEfectorCollection colSysRelHistoriaClinicaEfectorRecords;
		public DalRis.SysRelHistoriaClinicaEfectorCollection SysRelHistoriaClinicaEfectorRecords
		{
			get
			{
				if(colSysRelHistoriaClinicaEfectorRecords == null)
				{
					colSysRelHistoriaClinicaEfectorRecords = new DalRis.SysRelHistoriaClinicaEfectorCollection().Where(SysRelHistoriaClinicaEfector.Columns.IdEfector, IdEfector).Load();
					colSysRelHistoriaClinicaEfectorRecords.ListChanged += new ListChangedEventHandler(colSysRelHistoriaClinicaEfectorRecords_ListChanged);
				}
				return colSysRelHistoriaClinicaEfectorRecords;			
			}
			set 
			{ 
					colSysRelHistoriaClinicaEfectorRecords = value; 
					colSysRelHistoriaClinicaEfectorRecords.ListChanged += new ListChangedEventHandler(colSysRelHistoriaClinicaEfectorRecords_ListChanged);
			}
		}
		
		void colSysRelHistoriaClinicaEfectorRecords_ListChanged(object sender, ListChangedEventArgs e)
		{
		    if (e.ListChangedType == ListChangedType.ItemAdded)
		    {
		        // Set foreign key value
		        colSysRelHistoriaClinicaEfectorRecords[e.NewIndex].IdEfector = IdEfector;
		    }
		}
				
		private DalRis.SysUsuarioCollection colSysUsuarioRecords;
		public DalRis.SysUsuarioCollection SysUsuarioRecords
		{
			get
			{
				if(colSysUsuarioRecords == null)
				{
					colSysUsuarioRecords = new DalRis.SysUsuarioCollection().Where(SysUsuario.Columns.IdEfector, IdEfector).Load();
					colSysUsuarioRecords.ListChanged += new ListChangedEventHandler(colSysUsuarioRecords_ListChanged);
				}
				return colSysUsuarioRecords;			
			}
			set 
			{ 
					colSysUsuarioRecords = value; 
					colSysUsuarioRecords.ListChanged += new ListChangedEventHandler(colSysUsuarioRecords_ListChanged);
			}
		}
		
		void colSysUsuarioRecords_ListChanged(object sender, ListChangedEventArgs e)
		{
		    if (e.ListChangedType == ListChangedType.ItemAdded)
		    {
		        // Set foreign key value
		        colSysUsuarioRecords[e.NewIndex].IdEfector = IdEfector;
		    }
		}
				
		private DalRis.SysProfesionalCollection colSysProfesionalRecords;
		public DalRis.SysProfesionalCollection SysProfesionalRecords
		{
			get
			{
				if(colSysProfesionalRecords == null)
				{
					colSysProfesionalRecords = new DalRis.SysProfesionalCollection().Where(SysProfesional.Columns.IdEfector, IdEfector).Load();
					colSysProfesionalRecords.ListChanged += new ListChangedEventHandler(colSysProfesionalRecords_ListChanged);
				}
				return colSysProfesionalRecords;			
			}
			set 
			{ 
					colSysProfesionalRecords = value; 
					colSysProfesionalRecords.ListChanged += new ListChangedEventHandler(colSysProfesionalRecords_ListChanged);
			}
		}
		
		void colSysProfesionalRecords_ListChanged(object sender, ListChangedEventArgs e)
		{
		    if (e.ListChangedType == ListChangedType.ItemAdded)
		    {
		        // Set foreign key value
		        colSysProfesionalRecords[e.NewIndex].IdEfector = IdEfector;
		    }
		}
		
		#endregion
		
			
		
		#region ForeignKey Properties
		
		/// <summary>
		/// Returns a SysEfector ActiveRecord object related to this SysEfector
		/// 
		/// </summary>
		public DalRis.SysEfector ParentSysEfector
		{
			get { return DalRis.SysEfector.FetchByID(this.IdEfectorSuperior); }
			set { SetColumnValue("idEfectorSuperior", value.IdEfector); }
		}
		
		
		/// <summary>
		/// Returns a SysZona ActiveRecord object related to this SysEfector
		/// 
		/// </summary>
		public DalRis.SysZona SysZona
		{
			get { return DalRis.SysZona.FetchByID(this.IdZona); }
			set { SetColumnValue("idZona", value.IdZona); }
		}
		
		
		#endregion
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varNombre,int varIdZona,string varNombreNacion,string varComplejidad,int varIdEfectorSuperior,string varDomicilio,string varTelefono,string varReponsable,string varCodigoRemediar,string varCuie,int? varIdTipoEfector,string varCodigoSisa)
		{
			SysEfector item = new SysEfector();
			
			item.Nombre = varNombre;
			
			item.IdZona = varIdZona;
			
			item.NombreNacion = varNombreNacion;
			
			item.Complejidad = varComplejidad;
			
			item.IdEfectorSuperior = varIdEfectorSuperior;
			
			item.Domicilio = varDomicilio;
			
			item.Telefono = varTelefono;
			
			item.Reponsable = varReponsable;
			
			item.CodigoRemediar = varCodigoRemediar;
			
			item.Cuie = varCuie;
			
			item.IdTipoEfector = varIdTipoEfector;
			
			item.CodigoSisa = varCodigoSisa;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varIdEfector,string varNombre,int varIdZona,string varNombreNacion,string varComplejidad,int varIdEfectorSuperior,string varDomicilio,string varTelefono,string varReponsable,string varCodigoRemediar,string varCuie,int? varIdTipoEfector,string varCodigoSisa)
		{
			SysEfector item = new SysEfector();
			
				item.IdEfector = varIdEfector;
			
				item.Nombre = varNombre;
			
				item.IdZona = varIdZona;
			
				item.NombreNacion = varNombreNacion;
			
				item.Complejidad = varComplejidad;
			
				item.IdEfectorSuperior = varIdEfectorSuperior;
			
				item.Domicilio = varDomicilio;
			
				item.Telefono = varTelefono;
			
				item.Reponsable = varReponsable;
			
				item.CodigoRemediar = varCodigoRemediar;
			
				item.Cuie = varCuie;
			
				item.IdTipoEfector = varIdTipoEfector;
			
				item.CodigoSisa = varCodigoSisa;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn IdEfectorColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn NombreColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn IdZonaColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn NombreNacionColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn ComplejidadColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn IdEfectorSuperiorColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        public static TableSchema.TableColumn DomicilioColumn
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        public static TableSchema.TableColumn TelefonoColumn
        {
            get { return Schema.Columns[7]; }
        }
        
        
        
        public static TableSchema.TableColumn ReponsableColumn
        {
            get { return Schema.Columns[8]; }
        }
        
        
        
        public static TableSchema.TableColumn CodigoRemediarColumn
        {
            get { return Schema.Columns[9]; }
        }
        
        
        
        public static TableSchema.TableColumn CuieColumn
        {
            get { return Schema.Columns[10]; }
        }
        
        
        
        public static TableSchema.TableColumn IdTipoEfectorColumn
        {
            get { return Schema.Columns[11]; }
        }
        
        
        
        public static TableSchema.TableColumn CodigoSisaColumn
        {
            get { return Schema.Columns[12]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string IdEfector = @"idEfector";
			 public static string Nombre = @"nombre";
			 public static string IdZona = @"idZona";
			 public static string NombreNacion = @"nombreNacion";
			 public static string Complejidad = @"complejidad";
			 public static string IdEfectorSuperior = @"idEfectorSuperior";
			 public static string Domicilio = @"domicilio";
			 public static string Telefono = @"telefono";
			 public static string Reponsable = @"reponsable";
			 public static string CodigoRemediar = @"codigoRemediar";
			 public static string Cuie = @"cuie";
			 public static string IdTipoEfector = @"idTipoEfector";
			 public static string CodigoSisa = @"codigoSisa";
						
		}
		#endregion
		
		#region Update PK Collections
		
        public void SetPKValues()
        {
                if (colSysRelServicioEfectorRecords != null)
                {
                    foreach (DalRis.SysRelServicioEfector item in colSysRelServicioEfectorRecords)
                    {
                        if (item.IdEfector != IdEfector)
                        {
                            item.IdEfector = IdEfector;
                        }
                    }
               }
		
                if (colChildSysEfectorRecords != null)
                {
                    foreach (DalRis.SysEfector item in colChildSysEfectorRecords)
                    {
                        if (item.IdEfectorSuperior != IdEfector)
                        {
                            item.IdEfectorSuperior = IdEfector;
                        }
                    }
               }
		
                if (colSysRelProfesionalEfectorRecords != null)
                {
                    foreach (DalRis.SysRelProfesionalEfector item in colSysRelProfesionalEfectorRecords)
                    {
                        if (item.IdEfector != IdEfector)
                        {
                            item.IdEfector = IdEfector;
                        }
                    }
               }
		
                if (colSysEstablecimientoRecords != null)
                {
                    foreach (DalRis.SysEstablecimiento item in colSysEstablecimientoRecords)
                    {
                        if (item.IdEfector == null ||item.IdEfector != IdEfector)
                        {
                            item.IdEfector = IdEfector;
                        }
                    }
               }
		
                if (colSysRelEspecialidadEfectorRecords != null)
                {
                    foreach (DalRis.SysRelEspecialidadEfector item in colSysRelEspecialidadEfectorRecords)
                    {
                        if (item.IdEfector != IdEfector)
                        {
                            item.IdEfector = IdEfector;
                        }
                    }
               }
		
                if (colSysRelHistoriaClinicaEfectorRecords != null)
                {
                    foreach (DalRis.SysRelHistoriaClinicaEfector item in colSysRelHistoriaClinicaEfectorRecords)
                    {
                        if (item.IdEfector != IdEfector)
                        {
                            item.IdEfector = IdEfector;
                        }
                    }
               }
		
                if (colSysUsuarioRecords != null)
                {
                    foreach (DalRis.SysUsuario item in colSysUsuarioRecords)
                    {
                        if (item.IdEfector != IdEfector)
                        {
                            item.IdEfector = IdEfector;
                        }
                    }
               }
		
                if (colSysProfesionalRecords != null)
                {
                    foreach (DalRis.SysProfesional item in colSysProfesionalRecords)
                    {
                        if (item.IdEfector != IdEfector)
                        {
                            item.IdEfector = IdEfector;
                        }
                    }
               }
		}
        #endregion
    
        #region Deep Save
		
        public void DeepSave()
        {
            Save();
            
                if (colSysRelServicioEfectorRecords != null)
                {
                    colSysRelServicioEfectorRecords.SaveAll();
               }
		
                if (colChildSysEfectorRecords != null)
                {
                    colChildSysEfectorRecords.SaveAll();
               }
		
                if (colSysRelProfesionalEfectorRecords != null)
                {
                    colSysRelProfesionalEfectorRecords.SaveAll();
               }
		
                if (colSysEstablecimientoRecords != null)
                {
                    colSysEstablecimientoRecords.SaveAll();
               }
		
                if (colSysRelEspecialidadEfectorRecords != null)
                {
                    colSysRelEspecialidadEfectorRecords.SaveAll();
               }
		
                if (colSysRelHistoriaClinicaEfectorRecords != null)
                {
                    colSysRelHistoriaClinicaEfectorRecords.SaveAll();
               }
		
                if (colSysUsuarioRecords != null)
                {
                    colSysUsuarioRecords.SaveAll();
               }
		
                if (colSysProfesionalRecords != null)
                {
                    colSysProfesionalRecords.SaveAll();
               }
		}
        #endregion
	}
}
