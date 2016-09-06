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
        
		
		private DalRis.TabControlCollection colTabControlRecords;
		public DalRis.TabControlCollection TabControlRecords()
		{
			if(colTabControlRecords == null)
			{
				colTabControlRecords = new DalRis.TabControlCollection().Where(TabControl.Columns.IdEfector, IdEfector).Load();
				colTabControlRecords.ListChanged += new ListChangedEventHandler(colTabControlRecords_ListChanged);
			}
			return colTabControlRecords;
		}
				
		void colTabControlRecords_ListChanged(object sender, ListChangedEventArgs e)
		{
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
		        // Set foreign key value
		        colTabControlRecords[e.NewIndex].IdEfector = IdEfector;
				colTabControlRecords.ListChanged += new ListChangedEventHandler(colTabControlRecords_ListChanged);
            }
		}
		private DalRis.AprControlOdontologicoCollection colAprControlOdontologicoRecords;
		public DalRis.AprControlOdontologicoCollection AprControlOdontologicoRecords()
		{
			if(colAprControlOdontologicoRecords == null)
			{
				colAprControlOdontologicoRecords = new DalRis.AprControlOdontologicoCollection().Where(AprControlOdontologico.Columns.IdEfector, IdEfector).Load();
				colAprControlOdontologicoRecords.ListChanged += new ListChangedEventHandler(colAprControlOdontologicoRecords_ListChanged);
			}
			return colAprControlOdontologicoRecords;
		}
				
		void colAprControlOdontologicoRecords_ListChanged(object sender, ListChangedEventArgs e)
		{
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
		        // Set foreign key value
		        colAprControlOdontologicoRecords[e.NewIndex].IdEfector = IdEfector;
				colAprControlOdontologicoRecords.ListChanged += new ListChangedEventHandler(colAprControlOdontologicoRecords_ListChanged);
            }
		}
		private DalRis.MamEstudiosHospitalProvincialCollection colMamEstudiosHospitalProvincialRecords;
		public DalRis.MamEstudiosHospitalProvincialCollection MamEstudiosHospitalProvincialRecords()
		{
			if(colMamEstudiosHospitalProvincialRecords == null)
			{
				colMamEstudiosHospitalProvincialRecords = new DalRis.MamEstudiosHospitalProvincialCollection().Where(MamEstudiosHospitalProvincial.Columns.SolicitudCentroSalud, IdEfector).Load();
				colMamEstudiosHospitalProvincialRecords.ListChanged += new ListChangedEventHandler(colMamEstudiosHospitalProvincialRecords_ListChanged);
			}
			return colMamEstudiosHospitalProvincialRecords;
		}
				
		void colMamEstudiosHospitalProvincialRecords_ListChanged(object sender, ListChangedEventArgs e)
		{
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
		        // Set foreign key value
		        colMamEstudiosHospitalProvincialRecords[e.NewIndex].SolicitudCentroSalud = IdEfector;
				colMamEstudiosHospitalProvincialRecords.ListChanged += new ListChangedEventHandler(colMamEstudiosHospitalProvincialRecords_ListChanged);
            }
		}
		private DalRis.AprInterconsultumCollection colAprInterconsulta;
		public DalRis.AprInterconsultumCollection AprInterconsulta()
		{
			if(colAprInterconsulta == null)
			{
				colAprInterconsulta = new DalRis.AprInterconsultumCollection().Where(AprInterconsultum.Columns.IdEfector, IdEfector).Load();
				colAprInterconsulta.ListChanged += new ListChangedEventHandler(colAprInterconsulta_ListChanged);
			}
			return colAprInterconsulta;
		}
				
		void colAprInterconsulta_ListChanged(object sender, ListChangedEventArgs e)
		{
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
		        // Set foreign key value
		        colAprInterconsulta[e.NewIndex].IdEfector = IdEfector;
				colAprInterconsulta.ListChanged += new ListChangedEventHandler(colAprInterconsulta_ListChanged);
            }
		}
		private DalRis.SysRelServicioEfectorCollection colSysRelServicioEfectorRecords;
		public DalRis.SysRelServicioEfectorCollection SysRelServicioEfectorRecords()
		{
			if(colSysRelServicioEfectorRecords == null)
			{
				colSysRelServicioEfectorRecords = new DalRis.SysRelServicioEfectorCollection().Where(SysRelServicioEfector.Columns.IdEfector, IdEfector).Load();
				colSysRelServicioEfectorRecords.ListChanged += new ListChangedEventHandler(colSysRelServicioEfectorRecords_ListChanged);
			}
			return colSysRelServicioEfectorRecords;
		}
				
		void colSysRelServicioEfectorRecords_ListChanged(object sender, ListChangedEventArgs e)
		{
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
		        // Set foreign key value
		        colSysRelServicioEfectorRecords[e.NewIndex].IdEfector = IdEfector;
				colSysRelServicioEfectorRecords.ListChanged += new ListChangedEventHandler(colSysRelServicioEfectorRecords_ListChanged);
            }
		}
		private DalRis.MamCirugiumCollection colMamCirugia;
		public DalRis.MamCirugiumCollection MamCirugia()
		{
			if(colMamCirugia == null)
			{
				colMamCirugia = new DalRis.MamCirugiumCollection().Where(MamCirugium.Columns.IdCentroSalud, IdEfector).Load();
				colMamCirugia.ListChanged += new ListChangedEventHandler(colMamCirugia_ListChanged);
			}
			return colMamCirugia;
		}
				
		void colMamCirugia_ListChanged(object sender, ListChangedEventArgs e)
		{
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
		        // Set foreign key value
		        colMamCirugia[e.NewIndex].IdCentroSalud = IdEfector;
				colMamCirugia.ListChanged += new ListChangedEventHandler(colMamCirugia_ListChanged);
            }
		}
		private DalRis.ConConsultorioTipoCollection colConConsultorioTipoRecords;
		public DalRis.ConConsultorioTipoCollection ConConsultorioTipoRecords()
		{
			if(colConConsultorioTipoRecords == null)
			{
				colConConsultorioTipoRecords = new DalRis.ConConsultorioTipoCollection().Where(ConConsultorioTipo.Columns.IdEfector, IdEfector).Load();
				colConConsultorioTipoRecords.ListChanged += new ListChangedEventHandler(colConConsultorioTipoRecords_ListChanged);
			}
			return colConConsultorioTipoRecords;
		}
				
		void colConConsultorioTipoRecords_ListChanged(object sender, ListChangedEventArgs e)
		{
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
		        // Set foreign key value
		        colConConsultorioTipoRecords[e.NewIndex].IdEfector = IdEfector;
				colConConsultorioTipoRecords.ListChanged += new ListChangedEventHandler(colConConsultorioTipoRecords_ListChanged);
            }
		}
		private DalRis.ConAgendaGrupalCollection colConAgendaGrupalRecords;
		public DalRis.ConAgendaGrupalCollection ConAgendaGrupalRecords()
		{
			if(colConAgendaGrupalRecords == null)
			{
				colConAgendaGrupalRecords = new DalRis.ConAgendaGrupalCollection().Where(ConAgendaGrupal.Columns.IdEfector, IdEfector).Load();
				colConAgendaGrupalRecords.ListChanged += new ListChangedEventHandler(colConAgendaGrupalRecords_ListChanged);
			}
			return colConAgendaGrupalRecords;
		}
				
		void colConAgendaGrupalRecords_ListChanged(object sender, ListChangedEventArgs e)
		{
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
		        // Set foreign key value
		        colConAgendaGrupalRecords[e.NewIndex].IdEfector = IdEfector;
				colConAgendaGrupalRecords.ListChanged += new ListChangedEventHandler(colConAgendaGrupalRecords_ListChanged);
            }
		}
		private DalRis.LabSolicitudScreeningCollection colLabSolicitudScreeningRecords;
		public DalRis.LabSolicitudScreeningCollection LabSolicitudScreeningRecords()
		{
			if(colLabSolicitudScreeningRecords == null)
			{
				colLabSolicitudScreeningRecords = new DalRis.LabSolicitudScreeningCollection().Where(LabSolicitudScreening.Columns.IdEfectorSolicitante, IdEfector).Load();
				colLabSolicitudScreeningRecords.ListChanged += new ListChangedEventHandler(colLabSolicitudScreeningRecords_ListChanged);
			}
			return colLabSolicitudScreeningRecords;
		}
				
		void colLabSolicitudScreeningRecords_ListChanged(object sender, ListChangedEventArgs e)
		{
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
		        // Set foreign key value
		        colLabSolicitudScreeningRecords[e.NewIndex].IdEfectorSolicitante = IdEfector;
				colLabSolicitudScreeningRecords.ListChanged += new ListChangedEventHandler(colLabSolicitudScreeningRecords_ListChanged);
            }
		}
		private DalRis.LabSolicitudScreeningCollection colLabSolicitudScreeningRecordsFromSysEfector;
		public DalRis.LabSolicitudScreeningCollection LabSolicitudScreeningRecordsFromSysEfector()
		{
			if(colLabSolicitudScreeningRecordsFromSysEfector == null)
			{
				colLabSolicitudScreeningRecordsFromSysEfector = new DalRis.LabSolicitudScreeningCollection().Where(LabSolicitudScreening.Columns.IdLugarControl, IdEfector).Load();
				colLabSolicitudScreeningRecordsFromSysEfector.ListChanged += new ListChangedEventHandler(colLabSolicitudScreeningRecordsFromSysEfector_ListChanged);
			}
			return colLabSolicitudScreeningRecordsFromSysEfector;
		}
				
		void colLabSolicitudScreeningRecordsFromSysEfector_ListChanged(object sender, ListChangedEventArgs e)
		{
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
		        // Set foreign key value
		        colLabSolicitudScreeningRecordsFromSysEfector[e.NewIndex].IdLugarControl = IdEfector;
				colLabSolicitudScreeningRecordsFromSysEfector.ListChanged += new ListChangedEventHandler(colLabSolicitudScreeningRecordsFromSysEfector_ListChanged);
            }
		}
		private DalRis.FacOrdenCollection colFacOrdenRecords;
		public DalRis.FacOrdenCollection FacOrdenRecords()
		{
			if(colFacOrdenRecords == null)
			{
				colFacOrdenRecords = new DalRis.FacOrdenCollection().Where(FacOrden.Columns.IdEfector, IdEfector).Load();
				colFacOrdenRecords.ListChanged += new ListChangedEventHandler(colFacOrdenRecords_ListChanged);
			}
			return colFacOrdenRecords;
		}
				
		void colFacOrdenRecords_ListChanged(object sender, ListChangedEventArgs e)
		{
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
		        // Set foreign key value
		        colFacOrdenRecords[e.NewIndex].IdEfector = IdEfector;
				colFacOrdenRecords.ListChanged += new ListChangedEventHandler(colFacOrdenRecords_ListChanged);
            }
		}
		private DalRis.MamAnatomiaPatologicaCollection colMamAnatomiaPatologicaRecords;
		public DalRis.MamAnatomiaPatologicaCollection MamAnatomiaPatologicaRecords()
		{
			if(colMamAnatomiaPatologicaRecords == null)
			{
				colMamAnatomiaPatologicaRecords = new DalRis.MamAnatomiaPatologicaCollection().Where(MamAnatomiaPatologica.Columns.IdCentroSaludInforme, IdEfector).Load();
				colMamAnatomiaPatologicaRecords.ListChanged += new ListChangedEventHandler(colMamAnatomiaPatologicaRecords_ListChanged);
			}
			return colMamAnatomiaPatologicaRecords;
		}
				
		void colMamAnatomiaPatologicaRecords_ListChanged(object sender, ListChangedEventArgs e)
		{
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
		        // Set foreign key value
		        colMamAnatomiaPatologicaRecords[e.NewIndex].IdCentroSaludInforme = IdEfector;
				colMamAnatomiaPatologicaRecords.ListChanged += new ListChangedEventHandler(colMamAnatomiaPatologicaRecords_ListChanged);
            }
		}
		private DalRis.MamAnatomiaPatologicaCollection colMamAnatomiaPatologicaRecordsFromSysEfector;
		public DalRis.MamAnatomiaPatologicaCollection MamAnatomiaPatologicaRecordsFromSysEfector()
		{
			if(colMamAnatomiaPatologicaRecordsFromSysEfector == null)
			{
				colMamAnatomiaPatologicaRecordsFromSysEfector = new DalRis.MamAnatomiaPatologicaCollection().Where(MamAnatomiaPatologica.Columns.IdCentroSaludMuestra, IdEfector).Load();
				colMamAnatomiaPatologicaRecordsFromSysEfector.ListChanged += new ListChangedEventHandler(colMamAnatomiaPatologicaRecordsFromSysEfector_ListChanged);
			}
			return colMamAnatomiaPatologicaRecordsFromSysEfector;
		}
				
		void colMamAnatomiaPatologicaRecordsFromSysEfector_ListChanged(object sender, ListChangedEventArgs e)
		{
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
		        // Set foreign key value
		        colMamAnatomiaPatologicaRecordsFromSysEfector[e.NewIndex].IdCentroSaludMuestra = IdEfector;
				colMamAnatomiaPatologicaRecordsFromSysEfector.ListChanged += new ListChangedEventHandler(colMamAnatomiaPatologicaRecordsFromSysEfector_ListChanged);
            }
		}
		private DalRis.FacJefeLaboratorioCollection colFacJefeLaboratorioRecords;
		public DalRis.FacJefeLaboratorioCollection FacJefeLaboratorioRecords()
		{
			if(colFacJefeLaboratorioRecords == null)
			{
				colFacJefeLaboratorioRecords = new DalRis.FacJefeLaboratorioCollection().Where(FacJefeLaboratorio.Columns.IdEfector, IdEfector).Load();
				colFacJefeLaboratorioRecords.ListChanged += new ListChangedEventHandler(colFacJefeLaboratorioRecords_ListChanged);
			}
			return colFacJefeLaboratorioRecords;
		}
				
		void colFacJefeLaboratorioRecords_ListChanged(object sender, ListChangedEventArgs e)
		{
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
		        // Set foreign key value
		        colFacJefeLaboratorioRecords[e.NewIndex].IdEfector = IdEfector;
				colFacJefeLaboratorioRecords.ListChanged += new ListChangedEventHandler(colFacJefeLaboratorioRecords_ListChanged);
            }
		}
		private DalRis.TamPapHPCollection colTamPapHPRecords;
		public DalRis.TamPapHPCollection TamPapHPRecords()
		{
			if(colTamPapHPRecords == null)
			{
				colTamPapHPRecords = new DalRis.TamPapHPCollection().Where(TamPapHP.Columns.IdCentroMuestra, IdEfector).Load();
				colTamPapHPRecords.ListChanged += new ListChangedEventHandler(colTamPapHPRecords_ListChanged);
			}
			return colTamPapHPRecords;
		}
				
		void colTamPapHPRecords_ListChanged(object sender, ListChangedEventArgs e)
		{
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
		        // Set foreign key value
		        colTamPapHPRecords[e.NewIndex].IdCentroMuestra = IdEfector;
				colTamPapHPRecords.ListChanged += new ListChangedEventHandler(colTamPapHPRecords_ListChanged);
            }
		}
		private DalRis.RemClasificacionCollection colRemClasificacionRecords;
		public DalRis.RemClasificacionCollection RemClasificacionRecords()
		{
			if(colRemClasificacionRecords == null)
			{
				colRemClasificacionRecords = new DalRis.RemClasificacionCollection().Where(RemClasificacion.Columns.IdEfector, IdEfector).Load();
				colRemClasificacionRecords.ListChanged += new ListChangedEventHandler(colRemClasificacionRecords_ListChanged);
			}
			return colRemClasificacionRecords;
		}
				
		void colRemClasificacionRecords_ListChanged(object sender, ListChangedEventArgs e)
		{
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
		        // Set foreign key value
		        colRemClasificacionRecords[e.NewIndex].IdEfector = IdEfector;
				colRemClasificacionRecords.ListChanged += new ListChangedEventHandler(colRemClasificacionRecords_ListChanged);
            }
		}
		private DalRis.AprActividadControlPerinatalCollection colAprActividadControlPerinatalRecords;
		public DalRis.AprActividadControlPerinatalCollection AprActividadControlPerinatalRecords()
		{
			if(colAprActividadControlPerinatalRecords == null)
			{
				colAprActividadControlPerinatalRecords = new DalRis.AprActividadControlPerinatalCollection().Where(AprActividadControlPerinatal.Columns.IdEfector, IdEfector).Load();
				colAprActividadControlPerinatalRecords.ListChanged += new ListChangedEventHandler(colAprActividadControlPerinatalRecords_ListChanged);
			}
			return colAprActividadControlPerinatalRecords;
		}
				
		void colAprActividadControlPerinatalRecords_ListChanged(object sender, ListChangedEventArgs e)
		{
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
		        // Set foreign key value
		        colAprActividadControlPerinatalRecords[e.NewIndex].IdEfector = IdEfector;
				colAprActividadControlPerinatalRecords.ListChanged += new ListChangedEventHandler(colAprActividadControlPerinatalRecords_ListChanged);
            }
		}
		private DalRis.MamPiezaQuirurgicaCollection colMamPiezaQuirurgicaRecords;
		public DalRis.MamPiezaQuirurgicaCollection MamPiezaQuirurgicaRecords()
		{
			if(colMamPiezaQuirurgicaRecords == null)
			{
				colMamPiezaQuirurgicaRecords = new DalRis.MamPiezaQuirurgicaCollection().Where(MamPiezaQuirurgica.Columns.IdCentroSaludInforme, IdEfector).Load();
				colMamPiezaQuirurgicaRecords.ListChanged += new ListChangedEventHandler(colMamPiezaQuirurgicaRecords_ListChanged);
			}
			return colMamPiezaQuirurgicaRecords;
		}
				
		void colMamPiezaQuirurgicaRecords_ListChanged(object sender, ListChangedEventArgs e)
		{
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
		        // Set foreign key value
		        colMamPiezaQuirurgicaRecords[e.NewIndex].IdCentroSaludInforme = IdEfector;
				colMamPiezaQuirurgicaRecords.ListChanged += new ListChangedEventHandler(colMamPiezaQuirurgicaRecords_ListChanged);
            }
		}
		private DalRis.ConTurnoReservaInterconsultumCollection colConTurnoReservaInterconsulta;
		public DalRis.ConTurnoReservaInterconsultumCollection ConTurnoReservaInterconsulta()
		{
			if(colConTurnoReservaInterconsulta == null)
			{
				colConTurnoReservaInterconsulta = new DalRis.ConTurnoReservaInterconsultumCollection().Where(ConTurnoReservaInterconsultum.Columns.IdEfector, IdEfector).Load();
				colConTurnoReservaInterconsulta.ListChanged += new ListChangedEventHandler(colConTurnoReservaInterconsulta_ListChanged);
			}
			return colConTurnoReservaInterconsulta;
		}
				
		void colConTurnoReservaInterconsulta_ListChanged(object sender, ListChangedEventArgs e)
		{
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
		        // Set foreign key value
		        colConTurnoReservaInterconsulta[e.NewIndex].IdEfector = IdEfector;
				colConTurnoReservaInterconsulta.ListChanged += new ListChangedEventHandler(colConTurnoReservaInterconsulta_ListChanged);
            }
		}
		private DalRis.MamEstudiosAdicionaleCollection colMamEstudiosAdicionales;
		public DalRis.MamEstudiosAdicionaleCollection MamEstudiosAdicionales()
		{
			if(colMamEstudiosAdicionales == null)
			{
				colMamEstudiosAdicionales = new DalRis.MamEstudiosAdicionaleCollection().Where(MamEstudiosAdicionale.Columns.IdCentroSalud, IdEfector).Load();
				colMamEstudiosAdicionales.ListChanged += new ListChangedEventHandler(colMamEstudiosAdicionales_ListChanged);
			}
			return colMamEstudiosAdicionales;
		}
				
		void colMamEstudiosAdicionales_ListChanged(object sender, ListChangedEventArgs e)
		{
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
		        // Set foreign key value
		        colMamEstudiosAdicionales[e.NewIndex].IdCentroSalud = IdEfector;
				colMamEstudiosAdicionales.ListChanged += new ListChangedEventHandler(colMamEstudiosAdicionales_ListChanged);
            }
		}
		private DalRis.TamBiopsiumCollection colTamBiopsia;
		public DalRis.TamBiopsiumCollection TamBiopsia()
		{
			if(colTamBiopsia == null)
			{
				colTamBiopsia = new DalRis.TamBiopsiumCollection().Where(TamBiopsium.Columns.IdEfectorResultado, IdEfector).Load();
				colTamBiopsia.ListChanged += new ListChangedEventHandler(colTamBiopsia_ListChanged);
			}
			return colTamBiopsia;
		}
				
		void colTamBiopsia_ListChanged(object sender, ListChangedEventArgs e)
		{
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
		        // Set foreign key value
		        colTamBiopsia[e.NewIndex].IdEfectorResultado = IdEfector;
				colTamBiopsia.ListChanged += new ListChangedEventHandler(colTamBiopsia_ListChanged);
            }
		}
		private DalRis.SysEfectorCollection colChildSysEfectorRecords;
		public DalRis.SysEfectorCollection ChildSysEfectorRecords()
		{
			if(colChildSysEfectorRecords == null)
			{
				colChildSysEfectorRecords = new DalRis.SysEfectorCollection().Where(SysEfector.Columns.IdEfectorSuperior, IdEfector).Load();
				colChildSysEfectorRecords.ListChanged += new ListChangedEventHandler(colChildSysEfectorRecords_ListChanged);
			}
			return colChildSysEfectorRecords;
		}
				
		void colChildSysEfectorRecords_ListChanged(object sender, ListChangedEventArgs e)
		{
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
		        // Set foreign key value
		        colChildSysEfectorRecords[e.NewIndex].IdEfectorSuperior = IdEfector;
				colChildSysEfectorRecords.ListChanged += new ListChangedEventHandler(colChildSysEfectorRecords_ListChanged);
            }
		}
		private DalRis.EmrPrehospitalariumCollection colEmrPrehospitalaria;
		public DalRis.EmrPrehospitalariumCollection EmrPrehospitalaria()
		{
			if(colEmrPrehospitalaria == null)
			{
				colEmrPrehospitalaria = new DalRis.EmrPrehospitalariumCollection().Where(EmrPrehospitalarium.Columns.IdEfector, IdEfector).Load();
				colEmrPrehospitalaria.ListChanged += new ListChangedEventHandler(colEmrPrehospitalaria_ListChanged);
			}
			return colEmrPrehospitalaria;
		}
				
		void colEmrPrehospitalaria_ListChanged(object sender, ListChangedEventArgs e)
		{
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
		        // Set foreign key value
		        colEmrPrehospitalaria[e.NewIndex].IdEfector = IdEfector;
				colEmrPrehospitalaria.ListChanged += new ListChangedEventHandler(colEmrPrehospitalaria_ListChanged);
            }
		}
		private DalRis.TamPapCollection colTamPapRecords;
		public DalRis.TamPapCollection TamPapRecords()
		{
			if(colTamPapRecords == null)
			{
				colTamPapRecords = new DalRis.TamPapCollection().Where(TamPap.Columns.IdEfectorLaboratorio, IdEfector).Load();
				colTamPapRecords.ListChanged += new ListChangedEventHandler(colTamPapRecords_ListChanged);
			}
			return colTamPapRecords;
		}
				
		void colTamPapRecords_ListChanged(object sender, ListChangedEventArgs e)
		{
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
		        // Set foreign key value
		        colTamPapRecords[e.NewIndex].IdEfectorLaboratorio = IdEfector;
				colTamPapRecords.ListChanged += new ListChangedEventHandler(colTamPapRecords_ListChanged);
            }
		}
		private DalRis.SysRelProfesionalEfectorCollection colSysRelProfesionalEfectorRecords;
		public DalRis.SysRelProfesionalEfectorCollection SysRelProfesionalEfectorRecords()
		{
			if(colSysRelProfesionalEfectorRecords == null)
			{
				colSysRelProfesionalEfectorRecords = new DalRis.SysRelProfesionalEfectorCollection().Where(SysRelProfesionalEfector.Columns.IdEfector, IdEfector).Load();
				colSysRelProfesionalEfectorRecords.ListChanged += new ListChangedEventHandler(colSysRelProfesionalEfectorRecords_ListChanged);
			}
			return colSysRelProfesionalEfectorRecords;
		}
				
		void colSysRelProfesionalEfectorRecords_ListChanged(object sender, ListChangedEventArgs e)
		{
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
		        // Set foreign key value
		        colSysRelProfesionalEfectorRecords[e.NewIndex].IdEfector = IdEfector;
				colSysRelProfesionalEfectorRecords.ListChanged += new ListChangedEventHandler(colSysRelProfesionalEfectorRecords_ListChanged);
            }
		}
		private DalRis.SysRelEspecialidadEfectorCollection colSysRelEspecialidadEfectorRecords;
		public DalRis.SysRelEspecialidadEfectorCollection SysRelEspecialidadEfectorRecords()
		{
			if(colSysRelEspecialidadEfectorRecords == null)
			{
				colSysRelEspecialidadEfectorRecords = new DalRis.SysRelEspecialidadEfectorCollection().Where(SysRelEspecialidadEfector.Columns.IdEfector, IdEfector).Load();
				colSysRelEspecialidadEfectorRecords.ListChanged += new ListChangedEventHandler(colSysRelEspecialidadEfectorRecords_ListChanged);
			}
			return colSysRelEspecialidadEfectorRecords;
		}
				
		void colSysRelEspecialidadEfectorRecords_ListChanged(object sender, ListChangedEventArgs e)
		{
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
		        // Set foreign key value
		        colSysRelEspecialidadEfectorRecords[e.NewIndex].IdEfector = IdEfector;
				colSysRelEspecialidadEfectorRecords.ListChanged += new ListChangedEventHandler(colSysRelEspecialidadEfectorRecords_ListChanged);
            }
		}
		private DalRis.TamHpvCollection colTamHpvRecords;
		public DalRis.TamHpvCollection TamHpvRecords()
		{
			if(colTamHpvRecords == null)
			{
				colTamHpvRecords = new DalRis.TamHpvCollection().Where(TamHpv.Columns.IdEfectorToma, IdEfector).Load();
				colTamHpvRecords.ListChanged += new ListChangedEventHandler(colTamHpvRecords_ListChanged);
			}
			return colTamHpvRecords;
		}
				
		void colTamHpvRecords_ListChanged(object sender, ListChangedEventArgs e)
		{
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
		        // Set foreign key value
		        colTamHpvRecords[e.NewIndex].IdEfectorToma = IdEfector;
				colTamHpvRecords.ListChanged += new ListChangedEventHandler(colTamHpvRecords_ListChanged);
            }
		}
		private DalRis.SysRelHistoriaClinicaEfectorCollection colSysRelHistoriaClinicaEfectorRecords;
		public DalRis.SysRelHistoriaClinicaEfectorCollection SysRelHistoriaClinicaEfectorRecords()
		{
			if(colSysRelHistoriaClinicaEfectorRecords == null)
			{
				colSysRelHistoriaClinicaEfectorRecords = new DalRis.SysRelHistoriaClinicaEfectorCollection().Where(SysRelHistoriaClinicaEfector.Columns.IdEfector, IdEfector).Load();
				colSysRelHistoriaClinicaEfectorRecords.ListChanged += new ListChangedEventHandler(colSysRelHistoriaClinicaEfectorRecords_ListChanged);
			}
			return colSysRelHistoriaClinicaEfectorRecords;
		}
				
		void colSysRelHistoriaClinicaEfectorRecords_ListChanged(object sender, ListChangedEventArgs e)
		{
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
		        // Set foreign key value
		        colSysRelHistoriaClinicaEfectorRecords[e.NewIndex].IdEfector = IdEfector;
				colSysRelHistoriaClinicaEfectorRecords.ListChanged += new ListChangedEventHandler(colSysRelHistoriaClinicaEfectorRecords_ListChanged);
            }
		}
		private DalRis.TamHpvCollection colTamHpvRecordsFromSysEfector;
		public DalRis.TamHpvCollection TamHpvRecordsFromSysEfector()
		{
			if(colTamHpvRecordsFromSysEfector == null)
			{
				colTamHpvRecordsFromSysEfector = new DalRis.TamHpvCollection().Where(TamHpv.Columns.IdEfectorLaboratorio, IdEfector).Load();
				colTamHpvRecordsFromSysEfector.ListChanged += new ListChangedEventHandler(colTamHpvRecordsFromSysEfector_ListChanged);
			}
			return colTamHpvRecordsFromSysEfector;
		}
				
		void colTamHpvRecordsFromSysEfector_ListChanged(object sender, ListChangedEventArgs e)
		{
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
		        // Set foreign key value
		        colTamHpvRecordsFromSysEfector[e.NewIndex].IdEfectorLaboratorio = IdEfector;
				colTamHpvRecordsFromSysEfector.ListChanged += new ListChangedEventHandler(colTamHpvRecordsFromSysEfector_ListChanged);
            }
		}
		private DalRis.TamRegistroCollection colTamRegistroRecords;
		public DalRis.TamRegistroCollection TamRegistroRecords()
		{
			if(colTamRegistroRecords == null)
			{
				colTamRegistroRecords = new DalRis.TamRegistroCollection().Where(TamRegistro.Columns.IdEfectorReferencia, IdEfector).Load();
				colTamRegistroRecords.ListChanged += new ListChangedEventHandler(colTamRegistroRecords_ListChanged);
			}
			return colTamRegistroRecords;
		}
				
		void colTamRegistroRecords_ListChanged(object sender, ListChangedEventArgs e)
		{
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
		        // Set foreign key value
		        colTamRegistroRecords[e.NewIndex].IdEfectorReferencia = IdEfector;
				colTamRegistroRecords.ListChanged += new ListChangedEventHandler(colTamRegistroRecords_ListChanged);
            }
		}
		private DalRis.MamEcografiumCollection colMamEcografia;
		public DalRis.MamEcografiumCollection MamEcografia()
		{
			if(colMamEcografia == null)
			{
				colMamEcografia = new DalRis.MamEcografiumCollection().Where(MamEcografium.Columns.IdEfectorRealizaEstudio, IdEfector).Load();
				colMamEcografia.ListChanged += new ListChangedEventHandler(colMamEcografia_ListChanged);
			}
			return colMamEcografia;
		}
				
		void colMamEcografia_ListChanged(object sender, ListChangedEventArgs e)
		{
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
		        // Set foreign key value
		        colMamEcografia[e.NewIndex].IdEfectorRealizaEstudio = IdEfector;
				colMamEcografia.ListChanged += new ListChangedEventHandler(colMamEcografia_ListChanged);
            }
		}
		private DalRis.TamBiopsiumCollection colTamBiopsiaFromSysEfector;
		public DalRis.TamBiopsiumCollection TamBiopsiaFromSysEfector()
		{
			if(colTamBiopsiaFromSysEfector == null)
			{
				colTamBiopsiaFromSysEfector = new DalRis.TamBiopsiumCollection().Where(TamBiopsium.Columns.IdEfectorMuestra, IdEfector).Load();
				colTamBiopsiaFromSysEfector.ListChanged += new ListChangedEventHandler(colTamBiopsiaFromSysEfector_ListChanged);
			}
			return colTamBiopsiaFromSysEfector;
		}
				
		void colTamBiopsiaFromSysEfector_ListChanged(object sender, ListChangedEventArgs e)
		{
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
		        // Set foreign key value
		        colTamBiopsiaFromSysEfector[e.NewIndex].IdEfectorMuestra = IdEfector;
				colTamBiopsiaFromSysEfector.ListChanged += new ListChangedEventHandler(colTamBiopsiaFromSysEfector_ListChanged);
            }
		}
		private DalRis.MamEcografiumCollection colMamEcografiaFromSysEfector;
		public DalRis.MamEcografiumCollection MamEcografiaFromSysEfector()
		{
			if(colMamEcografiaFromSysEfector == null)
			{
				colMamEcografiaFromSysEfector = new DalRis.MamEcografiumCollection().Where(MamEcografium.Columns.IdEfectorSolicita, IdEfector).Load();
				colMamEcografiaFromSysEfector.ListChanged += new ListChangedEventHandler(colMamEcografiaFromSysEfector_ListChanged);
			}
			return colMamEcografiaFromSysEfector;
		}
				
		void colMamEcografiaFromSysEfector_ListChanged(object sender, ListChangedEventArgs e)
		{
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
		        // Set foreign key value
		        colMamEcografiaFromSysEfector[e.NewIndex].IdEfectorSolicita = IdEfector;
				colMamEcografiaFromSysEfector.ListChanged += new ListChangedEventHandler(colMamEcografiaFromSysEfector_ListChanged);
            }
		}
		private DalRis.TamBiopsiumCollection colTamBiopsiaFromSysEfectorIdEfectorMuestra;
		public DalRis.TamBiopsiumCollection TamBiopsiaFromSysEfectorIdEfectorMuestra()
		{
			if(colTamBiopsiaFromSysEfectorIdEfectorMuestra == null)
			{
				colTamBiopsiaFromSysEfectorIdEfectorMuestra = new DalRis.TamBiopsiumCollection().Where(TamBiopsium.Columns.IdEfectorMuestra, IdEfector).Load();
				colTamBiopsiaFromSysEfectorIdEfectorMuestra.ListChanged += new ListChangedEventHandler(colTamBiopsiaFromSysEfectorIdEfectorMuestra_ListChanged);
			}
			return colTamBiopsiaFromSysEfectorIdEfectorMuestra;
		}
				
		void colTamBiopsiaFromSysEfectorIdEfectorMuestra_ListChanged(object sender, ListChangedEventArgs e)
		{
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
		        // Set foreign key value
		        colTamBiopsiaFromSysEfectorIdEfectorMuestra[e.NewIndex].IdEfectorMuestra = IdEfector;
				colTamBiopsiaFromSysEfectorIdEfectorMuestra.ListChanged += new ListChangedEventHandler(colTamBiopsiaFromSysEfectorIdEfectorMuestra_ListChanged);
            }
		}
		private DalRis.AprHistoriaClinicaPerinatalCollection colAprHistoriaClinicaPerinatalRecords;
		public DalRis.AprHistoriaClinicaPerinatalCollection AprHistoriaClinicaPerinatalRecords()
		{
			if(colAprHistoriaClinicaPerinatalRecords == null)
			{
				colAprHistoriaClinicaPerinatalRecords = new DalRis.AprHistoriaClinicaPerinatalCollection().Where(AprHistoriaClinicaPerinatal.Columns.IdEfectorTrasladoUt, IdEfector).Load();
				colAprHistoriaClinicaPerinatalRecords.ListChanged += new ListChangedEventHandler(colAprHistoriaClinicaPerinatalRecords_ListChanged);
			}
			return colAprHistoriaClinicaPerinatalRecords;
		}
				
		void colAprHistoriaClinicaPerinatalRecords_ListChanged(object sender, ListChangedEventArgs e)
		{
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
		        // Set foreign key value
		        colAprHistoriaClinicaPerinatalRecords[e.NewIndex].IdEfectorTrasladoUt = IdEfector;
				colAprHistoriaClinicaPerinatalRecords.ListChanged += new ListChangedEventHandler(colAprHistoriaClinicaPerinatalRecords_ListChanged);
            }
		}
		private DalRis.MamEstudiosAdicionaleCollection colMamEstudiosAdicionalesFromSysEfector;
		public DalRis.MamEstudiosAdicionaleCollection MamEstudiosAdicionalesFromSysEfector()
		{
			if(colMamEstudiosAdicionalesFromSysEfector == null)
			{
				colMamEstudiosAdicionalesFromSysEfector = new DalRis.MamEstudiosAdicionaleCollection().Where(MamEstudiosAdicionale.Columns.IdEfectorRealizaEstudio, IdEfector).Load();
				colMamEstudiosAdicionalesFromSysEfector.ListChanged += new ListChangedEventHandler(colMamEstudiosAdicionalesFromSysEfector_ListChanged);
			}
			return colMamEstudiosAdicionalesFromSysEfector;
		}
				
		void colMamEstudiosAdicionalesFromSysEfector_ListChanged(object sender, ListChangedEventArgs e)
		{
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
		        // Set foreign key value
		        colMamEstudiosAdicionalesFromSysEfector[e.NewIndex].IdEfectorRealizaEstudio = IdEfector;
				colMamEstudiosAdicionalesFromSysEfector.ListChanged += new ListChangedEventHandler(colMamEstudiosAdicionalesFromSysEfector_ListChanged);
            }
		}
		private DalRis.TamColposcopiumCollection colTamColposcopia;
		public DalRis.TamColposcopiumCollection TamColposcopia()
		{
			if(colTamColposcopia == null)
			{
				colTamColposcopia = new DalRis.TamColposcopiumCollection().Where(TamColposcopium.Columns.IdEfectorExamen, IdEfector).Load();
				colTamColposcopia.ListChanged += new ListChangedEventHandler(colTamColposcopia_ListChanged);
			}
			return colTamColposcopia;
		}
				
		void colTamColposcopia_ListChanged(object sender, ListChangedEventArgs e)
		{
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
		        // Set foreign key value
		        colTamColposcopia[e.NewIndex].IdEfectorExamen = IdEfector;
				colTamColposcopia.ListChanged += new ListChangedEventHandler(colTamColposcopia_ListChanged);
            }
		}
		private DalRis.MamRegistroCollection colMamRegistroRecords;
		public DalRis.MamRegistroCollection MamRegistroRecords()
		{
			if(colMamRegistroRecords == null)
			{
				colMamRegistroRecords = new DalRis.MamRegistroCollection().Where(MamRegistro.Columns.IdEfectorRealizaEstudio, IdEfector).Load();
				colMamRegistroRecords.ListChanged += new ListChangedEventHandler(colMamRegistroRecords_ListChanged);
			}
			return colMamRegistroRecords;
		}
				
		void colMamRegistroRecords_ListChanged(object sender, ListChangedEventArgs e)
		{
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
		        // Set foreign key value
		        colMamRegistroRecords[e.NewIndex].IdEfectorRealizaEstudio = IdEfector;
				colMamRegistroRecords.ListChanged += new ListChangedEventHandler(colMamRegistroRecords_ListChanged);
            }
		}
		private DalRis.MamRegistroCollection colMamRegistroRecordsFromSysEfector;
		public DalRis.MamRegistroCollection MamRegistroRecordsFromSysEfector()
		{
			if(colMamRegistroRecordsFromSysEfector == null)
			{
				colMamRegistroRecordsFromSysEfector = new DalRis.MamRegistroCollection().Where(MamRegistro.Columns.IdEfectorControl, IdEfector).Load();
				colMamRegistroRecordsFromSysEfector.ListChanged += new ListChangedEventHandler(colMamRegistroRecordsFromSysEfector_ListChanged);
			}
			return colMamRegistroRecordsFromSysEfector;
		}
				
		void colMamRegistroRecordsFromSysEfector_ListChanged(object sender, ListChangedEventArgs e)
		{
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
		        // Set foreign key value
		        colMamRegistroRecordsFromSysEfector[e.NewIndex].IdEfectorControl = IdEfector;
				colMamRegistroRecordsFromSysEfector.ListChanged += new ListChangedEventHandler(colMamRegistroRecordsFromSysEfector_ListChanged);
            }
		}
		private DalRis.TamHpvCollection colTamHpvRecordsFromSysEfectorIdEfectorToma;
		public DalRis.TamHpvCollection TamHpvRecordsFromSysEfectorIdEfectorToma()
		{
			if(colTamHpvRecordsFromSysEfectorIdEfectorToma == null)
			{
				colTamHpvRecordsFromSysEfectorIdEfectorToma = new DalRis.TamHpvCollection().Where(TamHpv.Columns.IdEfectorToma, IdEfector).Load();
				colTamHpvRecordsFromSysEfectorIdEfectorToma.ListChanged += new ListChangedEventHandler(colTamHpvRecordsFromSysEfectorIdEfectorToma_ListChanged);
			}
			return colTamHpvRecordsFromSysEfectorIdEfectorToma;
		}
				
		void colTamHpvRecordsFromSysEfectorIdEfectorToma_ListChanged(object sender, ListChangedEventArgs e)
		{
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
		        // Set foreign key value
		        colTamHpvRecordsFromSysEfectorIdEfectorToma[e.NewIndex].IdEfectorToma = IdEfector;
				colTamHpvRecordsFromSysEfectorIdEfectorToma.ListChanged += new ListChangedEventHandler(colTamHpvRecordsFromSysEfectorIdEfectorToma_ListChanged);
            }
		}
		private DalRis.MamRegistroCollection colMamRegistroRecordsFromSysEfectorIdEfectorProcedencia;
		public DalRis.MamRegistroCollection MamRegistroRecordsFromSysEfectorIdEfectorProcedencia()
		{
			if(colMamRegistroRecordsFromSysEfectorIdEfectorProcedencia == null)
			{
				colMamRegistroRecordsFromSysEfectorIdEfectorProcedencia = new DalRis.MamRegistroCollection().Where(MamRegistro.Columns.IdEfectorProcedencia, IdEfector).Load();
				colMamRegistroRecordsFromSysEfectorIdEfectorProcedencia.ListChanged += new ListChangedEventHandler(colMamRegistroRecordsFromSysEfectorIdEfectorProcedencia_ListChanged);
			}
			return colMamRegistroRecordsFromSysEfectorIdEfectorProcedencia;
		}
				
		void colMamRegistroRecordsFromSysEfectorIdEfectorProcedencia_ListChanged(object sender, ListChangedEventArgs e)
		{
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
		        // Set foreign key value
		        colMamRegistroRecordsFromSysEfectorIdEfectorProcedencia[e.NewIndex].IdEfectorProcedencia = IdEfector;
				colMamRegistroRecordsFromSysEfectorIdEfectorProcedencia.ListChanged += new ListChangedEventHandler(colMamRegistroRecordsFromSysEfectorIdEfectorProcedencia_ListChanged);
            }
		}
		private DalRis.TamPapCollection colTamPapRecordsFromSysEfector;
		public DalRis.TamPapCollection TamPapRecordsFromSysEfector()
		{
			if(colTamPapRecordsFromSysEfector == null)
			{
				colTamPapRecordsFromSysEfector = new DalRis.TamPapCollection().Where(TamPap.Columns.IdEfectorMuestra, IdEfector).Load();
				colTamPapRecordsFromSysEfector.ListChanged += new ListChangedEventHandler(colTamPapRecordsFromSysEfector_ListChanged);
			}
			return colTamPapRecordsFromSysEfector;
		}
				
		void colTamPapRecordsFromSysEfector_ListChanged(object sender, ListChangedEventArgs e)
		{
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
		        // Set foreign key value
		        colTamPapRecordsFromSysEfector[e.NewIndex].IdEfectorMuestra = IdEfector;
				colTamPapRecordsFromSysEfector.ListChanged += new ListChangedEventHandler(colTamPapRecordsFromSysEfector_ListChanged);
            }
		}
		private DalRis.MamEcografiumCollection colMamEcografiaFromSysEfectorIdEfectorInforma;
		public DalRis.MamEcografiumCollection MamEcografiaFromSysEfectorIdEfectorInforma()
		{
			if(colMamEcografiaFromSysEfectorIdEfectorInforma == null)
			{
				colMamEcografiaFromSysEfectorIdEfectorInforma = new DalRis.MamEcografiumCollection().Where(MamEcografium.Columns.IdEfectorInforma, IdEfector).Load();
				colMamEcografiaFromSysEfectorIdEfectorInforma.ListChanged += new ListChangedEventHandler(colMamEcografiaFromSysEfectorIdEfectorInforma_ListChanged);
			}
			return colMamEcografiaFromSysEfectorIdEfectorInforma;
		}
				
		void colMamEcografiaFromSysEfectorIdEfectorInforma_ListChanged(object sender, ListChangedEventArgs e)
		{
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
		        // Set foreign key value
		        colMamEcografiaFromSysEfectorIdEfectorInforma[e.NewIndex].IdEfectorInforma = IdEfector;
				colMamEcografiaFromSysEfectorIdEfectorInforma.ListChanged += new ListChangedEventHandler(colMamEcografiaFromSysEfectorIdEfectorInforma_ListChanged);
            }
		}
		private DalRis.MamAntecedenteCollection colMamAntecedentes;
		public DalRis.MamAntecedenteCollection MamAntecedentes()
		{
			if(colMamAntecedentes == null)
			{
				colMamAntecedentes = new DalRis.MamAntecedenteCollection().Where(MamAntecedente.Columns.IdEfector, IdEfector).Load();
				colMamAntecedentes.ListChanged += new ListChangedEventHandler(colMamAntecedentes_ListChanged);
			}
			return colMamAntecedentes;
		}
				
		void colMamAntecedentes_ListChanged(object sender, ListChangedEventArgs e)
		{
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
		        // Set foreign key value
		        colMamAntecedentes[e.NewIndex].IdEfector = IdEfector;
				colMamAntecedentes.ListChanged += new ListChangedEventHandler(colMamAntecedentes_ListChanged);
            }
		}
		private DalRis.SysUsuarioCollection colSysUsuarioRecords;
		public DalRis.SysUsuarioCollection SysUsuarioRecords()
		{
			if(colSysUsuarioRecords == null)
			{
				colSysUsuarioRecords = new DalRis.SysUsuarioCollection().Where(SysUsuario.Columns.IdEfector, IdEfector).Load();
				colSysUsuarioRecords.ListChanged += new ListChangedEventHandler(colSysUsuarioRecords_ListChanged);
			}
			return colSysUsuarioRecords;
		}
				
		void colSysUsuarioRecords_ListChanged(object sender, ListChangedEventArgs e)
		{
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
		        // Set foreign key value
		        colSysUsuarioRecords[e.NewIndex].IdEfector = IdEfector;
				colSysUsuarioRecords.ListChanged += new ListChangedEventHandler(colSysUsuarioRecords_ListChanged);
            }
		}
		private DalRis.AprActividadFisicaCollection colAprActividadFisicaRecords;
		public DalRis.AprActividadFisicaCollection AprActividadFisicaRecords()
		{
			if(colAprActividadFisicaRecords == null)
			{
				colAprActividadFisicaRecords = new DalRis.AprActividadFisicaCollection().Where(AprActividadFisica.Columns.IdEfector, IdEfector).Load();
				colAprActividadFisicaRecords.ListChanged += new ListChangedEventHandler(colAprActividadFisicaRecords_ListChanged);
			}
			return colAprActividadFisicaRecords;
		}
				
		void colAprActividadFisicaRecords_ListChanged(object sender, ListChangedEventArgs e)
		{
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
		        // Set foreign key value
		        colAprActividadFisicaRecords[e.NewIndex].IdEfector = IdEfector;
				colAprActividadFisicaRecords.ListChanged += new ListChangedEventHandler(colAprActividadFisicaRecords_ListChanged);
            }
		}
		private DalRis.TamTratamientoCollection colTamTratamientos;
		public DalRis.TamTratamientoCollection TamTratamientos()
		{
			if(colTamTratamientos == null)
			{
				colTamTratamientos = new DalRis.TamTratamientoCollection().Where(TamTratamiento.Columns.IdEfectorTratante, IdEfector).Load();
				colTamTratamientos.ListChanged += new ListChangedEventHandler(colTamTratamientos_ListChanged);
			}
			return colTamTratamientos;
		}
				
		void colTamTratamientos_ListChanged(object sender, ListChangedEventArgs e)
		{
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
		        // Set foreign key value
		        colTamTratamientos[e.NewIndex].IdEfectorTratante = IdEfector;
				colTamTratamientos.ListChanged += new ListChangedEventHandler(colTamTratamientos_ListChanged);
            }
		}
		private DalRis.MamExamenFisicoCollection colMamExamenFisicoRecords;
		public DalRis.MamExamenFisicoCollection MamExamenFisicoRecords()
		{
			if(colMamExamenFisicoRecords == null)
			{
				colMamExamenFisicoRecords = new DalRis.MamExamenFisicoCollection().Where(MamExamenFisico.Columns.IdCentroSalud, IdEfector).Load();
				colMamExamenFisicoRecords.ListChanged += new ListChangedEventHandler(colMamExamenFisicoRecords_ListChanged);
			}
			return colMamExamenFisicoRecords;
		}
				
		void colMamExamenFisicoRecords_ListChanged(object sender, ListChangedEventArgs e)
		{
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
		        // Set foreign key value
		        colMamExamenFisicoRecords[e.NewIndex].IdCentroSalud = IdEfector;
				colMamExamenFisicoRecords.ListChanged += new ListChangedEventHandler(colMamExamenFisicoRecords_ListChanged);
            }
		}
		private DalRis.AprPartoProvisorioCollection colAprPartoProvisorioRecords;
		public DalRis.AprPartoProvisorioCollection AprPartoProvisorioRecords()
		{
			if(colAprPartoProvisorioRecords == null)
			{
				colAprPartoProvisorioRecords = new DalRis.AprPartoProvisorioCollection().Where(AprPartoProvisorio.Columns.IdEfectorParto, IdEfector).Load();
				colAprPartoProvisorioRecords.ListChanged += new ListChangedEventHandler(colAprPartoProvisorioRecords_ListChanged);
			}
			return colAprPartoProvisorioRecords;
		}
				
		void colAprPartoProvisorioRecords_ListChanged(object sender, ListChangedEventArgs e)
		{
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
		        // Set foreign key value
		        colAprPartoProvisorioRecords[e.NewIndex].IdEfectorParto = IdEfector;
				colAprPartoProvisorioRecords.ListChanged += new ListChangedEventHandler(colAprPartoProvisorioRecords_ListChanged);
            }
		}
		private DalRis.ConAgendaCollection colConAgendaRecords;
		public DalRis.ConAgendaCollection ConAgendaRecords()
		{
			if(colConAgendaRecords == null)
			{
				colConAgendaRecords = new DalRis.ConAgendaCollection().Where(ConAgenda.Columns.IdEfector, IdEfector).Load();
				colConAgendaRecords.ListChanged += new ListChangedEventHandler(colConAgendaRecords_ListChanged);
			}
			return colConAgendaRecords;
		}
				
		void colConAgendaRecords_ListChanged(object sender, ListChangedEventArgs e)
		{
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
		        // Set foreign key value
		        colConAgendaRecords[e.NewIndex].IdEfector = IdEfector;
				colConAgendaRecords.ListChanged += new ListChangedEventHandler(colConAgendaRecords_ListChanged);
            }
		}
		private DalRis.MamTratamientoCollection colMamTratamientos;
		public DalRis.MamTratamientoCollection MamTratamientos()
		{
			if(colMamTratamientos == null)
			{
				colMamTratamientos = new DalRis.MamTratamientoCollection().Where(MamTratamiento.Columns.IdCentroSalud, IdEfector).Load();
				colMamTratamientos.ListChanged += new ListChangedEventHandler(colMamTratamientos_ListChanged);
			}
			return colMamTratamientos;
		}
				
		void colMamTratamientos_ListChanged(object sender, ListChangedEventArgs e)
		{
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
		        // Set foreign key value
		        colMamTratamientos[e.NewIndex].IdCentroSalud = IdEfector;
				colMamTratamientos.ListChanged += new ListChangedEventHandler(colMamTratamientos_ListChanged);
            }
		}
		private DalRis.AprHistoriaClinicaPerinatalCollection colAprHistoriaClinicaPerinatalRecordsFromSysEfector;
		public DalRis.AprHistoriaClinicaPerinatalCollection AprHistoriaClinicaPerinatalRecordsFromSysEfector()
		{
			if(colAprHistoriaClinicaPerinatalRecordsFromSysEfector == null)
			{
				colAprHistoriaClinicaPerinatalRecordsFromSysEfector = new DalRis.AprHistoriaClinicaPerinatalCollection().Where(AprHistoriaClinicaPerinatal.Columns.IdEfector, IdEfector).Load();
				colAprHistoriaClinicaPerinatalRecordsFromSysEfector.ListChanged += new ListChangedEventHandler(colAprHistoriaClinicaPerinatalRecordsFromSysEfector_ListChanged);
			}
			return colAprHistoriaClinicaPerinatalRecordsFromSysEfector;
		}
				
		void colAprHistoriaClinicaPerinatalRecordsFromSysEfector_ListChanged(object sender, ListChangedEventArgs e)
		{
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
		        // Set foreign key value
		        colAprHistoriaClinicaPerinatalRecordsFromSysEfector[e.NewIndex].IdEfector = IdEfector;
				colAprHistoriaClinicaPerinatalRecordsFromSysEfector.ListChanged += new ListChangedEventHandler(colAprHistoriaClinicaPerinatalRecordsFromSysEfector_ListChanged);
            }
		}
		private DalRis.SysProfesionalCollection colSysProfesionalRecords;
		public DalRis.SysProfesionalCollection SysProfesionalRecords()
		{
			if(colSysProfesionalRecords == null)
			{
				colSysProfesionalRecords = new DalRis.SysProfesionalCollection().Where(SysProfesional.Columns.IdEfector, IdEfector).Load();
				colSysProfesionalRecords.ListChanged += new ListChangedEventHandler(colSysProfesionalRecords_ListChanged);
			}
			return colSysProfesionalRecords;
		}
				
		void colSysProfesionalRecords_ListChanged(object sender, ListChangedEventArgs e)
		{
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
		        // Set foreign key value
		        colSysProfesionalRecords[e.NewIndex].IdEfector = IdEfector;
				colSysProfesionalRecords.ListChanged += new ListChangedEventHandler(colSysProfesionalRecords_ListChanged);
            }
		}
		private DalRis.RemFormularioCollection colRemFormularioRecords;
		public DalRis.RemFormularioCollection RemFormularioRecords()
		{
			if(colRemFormularioRecords == null)
			{
				colRemFormularioRecords = new DalRis.RemFormularioCollection().Where(RemFormulario.Columns.IdEfector, IdEfector).Load();
				colRemFormularioRecords.ListChanged += new ListChangedEventHandler(colRemFormularioRecords_ListChanged);
			}
			return colRemFormularioRecords;
		}
				
		void colRemFormularioRecords_ListChanged(object sender, ListChangedEventArgs e)
		{
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
		        // Set foreign key value
		        colRemFormularioRecords[e.NewIndex].IdEfector = IdEfector;
				colRemFormularioRecords.ListChanged += new ListChangedEventHandler(colRemFormularioRecords_ListChanged);
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
                if (colTabControlRecords != null)
                {
                    foreach (DalRis.TabControl item in colTabControlRecords)
                    {
                        if (item.IdEfector != IdEfector)
                        {
                            item.IdEfector = IdEfector;
                        }
                    }
               }
		
                if (colAprControlOdontologicoRecords != null)
                {
                    foreach (DalRis.AprControlOdontologico item in colAprControlOdontologicoRecords)
                    {
                        if (item.IdEfector != IdEfector)
                        {
                            item.IdEfector = IdEfector;
                        }
                    }
               }
		
                if (colMamEstudiosHospitalProvincialRecords != null)
                {
                    foreach (DalRis.MamEstudiosHospitalProvincial item in colMamEstudiosHospitalProvincialRecords)
                    {
                        if (item.SolicitudCentroSalud != IdEfector)
                        {
                            item.SolicitudCentroSalud = IdEfector;
                        }
                    }
               }
		
                if (colAprInterconsulta != null)
                {
                    foreach (DalRis.AprInterconsultum item in colAprInterconsulta)
                    {
                        if (item.IdEfector != IdEfector)
                        {
                            item.IdEfector = IdEfector;
                        }
                    }
               }
		
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
		
                if (colMamCirugia != null)
                {
                    foreach (DalRis.MamCirugium item in colMamCirugia)
                    {
                        if (item.IdCentroSalud != IdEfector)
                        {
                            item.IdCentroSalud = IdEfector;
                        }
                    }
               }
		
                if (colConConsultorioTipoRecords != null)
                {
                    foreach (DalRis.ConConsultorioTipo item in colConConsultorioTipoRecords)
                    {
                        if (item.IdEfector != IdEfector)
                        {
                            item.IdEfector = IdEfector;
                        }
                    }
               }
		
                if (colConAgendaGrupalRecords != null)
                {
                    foreach (DalRis.ConAgendaGrupal item in colConAgendaGrupalRecords)
                    {
                        if (item.IdEfector != IdEfector)
                        {
                            item.IdEfector = IdEfector;
                        }
                    }
               }
		
                if (colLabSolicitudScreeningRecords != null)
                {
                    foreach (DalRis.LabSolicitudScreening item in colLabSolicitudScreeningRecords)
                    {
                        if (item.IdEfectorSolicitante != IdEfector)
                        {
                            item.IdEfectorSolicitante = IdEfector;
                        }
                    }
               }
		
                if (colLabSolicitudScreeningRecordsFromSysEfector != null)
                {
                    foreach (DalRis.LabSolicitudScreening item in colLabSolicitudScreeningRecordsFromSysEfector)
                    {
                        if (item.IdLugarControl != IdEfector)
                        {
                            item.IdLugarControl = IdEfector;
                        }
                    }
               }
		
                if (colFacOrdenRecords != null)
                {
                    foreach (DalRis.FacOrden item in colFacOrdenRecords)
                    {
                        if (item.IdEfector != IdEfector)
                        {
                            item.IdEfector = IdEfector;
                        }
                    }
               }
		
                if (colMamAnatomiaPatologicaRecords != null)
                {
                    foreach (DalRis.MamAnatomiaPatologica item in colMamAnatomiaPatologicaRecords)
                    {
                        if (item.IdCentroSaludInforme != IdEfector)
                        {
                            item.IdCentroSaludInforme = IdEfector;
                        }
                    }
               }
		
                if (colMamAnatomiaPatologicaRecordsFromSysEfector != null)
                {
                    foreach (DalRis.MamAnatomiaPatologica item in colMamAnatomiaPatologicaRecordsFromSysEfector)
                    {
                        if (item.IdCentroSaludMuestra != IdEfector)
                        {
                            item.IdCentroSaludMuestra = IdEfector;
                        }
                    }
               }
		
                if (colFacJefeLaboratorioRecords != null)
                {
                    foreach (DalRis.FacJefeLaboratorio item in colFacJefeLaboratorioRecords)
                    {
                        if (item.IdEfector != IdEfector)
                        {
                            item.IdEfector = IdEfector;
                        }
                    }
               }
		
                if (colTamPapHPRecords != null)
                {
                    foreach (DalRis.TamPapHP item in colTamPapHPRecords)
                    {
                        if (item.IdCentroMuestra != IdEfector)
                        {
                            item.IdCentroMuestra = IdEfector;
                        }
                    }
               }
		
                if (colRemClasificacionRecords != null)
                {
                    foreach (DalRis.RemClasificacion item in colRemClasificacionRecords)
                    {
                        if (item.IdEfector != IdEfector)
                        {
                            item.IdEfector = IdEfector;
                        }
                    }
               }
		
                if (colAprActividadControlPerinatalRecords != null)
                {
                    foreach (DalRis.AprActividadControlPerinatal item in colAprActividadControlPerinatalRecords)
                    {
                        if (item.IdEfector != IdEfector)
                        {
                            item.IdEfector = IdEfector;
                        }
                    }
               }
		
                if (colMamPiezaQuirurgicaRecords != null)
                {
                    foreach (DalRis.MamPiezaQuirurgica item in colMamPiezaQuirurgicaRecords)
                    {
                        if (item.IdCentroSaludInforme != IdEfector)
                        {
                            item.IdCentroSaludInforme = IdEfector;
                        }
                    }
               }
		
                if (colConTurnoReservaInterconsulta != null)
                {
                    foreach (DalRis.ConTurnoReservaInterconsultum item in colConTurnoReservaInterconsulta)
                    {
                        if (item.IdEfector != IdEfector)
                        {
                            item.IdEfector = IdEfector;
                        }
                    }
               }
		
                if (colMamEstudiosAdicionales != null)
                {
                    foreach (DalRis.MamEstudiosAdicionale item in colMamEstudiosAdicionales)
                    {
                        if (item.IdCentroSalud != IdEfector)
                        {
                            item.IdCentroSalud = IdEfector;
                        }
                    }
               }
		
                if (colTamBiopsia != null)
                {
                    foreach (DalRis.TamBiopsium item in colTamBiopsia)
                    {
                        if (item.IdEfectorResultado != IdEfector)
                        {
                            item.IdEfectorResultado = IdEfector;
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
		
                if (colEmrPrehospitalaria != null)
                {
                    foreach (DalRis.EmrPrehospitalarium item in colEmrPrehospitalaria)
                    {
                        if (item.IdEfector != IdEfector)
                        {
                            item.IdEfector = IdEfector;
                        }
                    }
               }
		
                if (colTamPapRecords != null)
                {
                    foreach (DalRis.TamPap item in colTamPapRecords)
                    {
                        if (item.IdEfectorLaboratorio != IdEfector)
                        {
                            item.IdEfectorLaboratorio = IdEfector;
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
		
                if (colTamHpvRecords != null)
                {
                    foreach (DalRis.TamHpv item in colTamHpvRecords)
                    {
                        if (item.IdEfectorToma != IdEfector)
                        {
                            item.IdEfectorToma = IdEfector;
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
		
                if (colTamHpvRecordsFromSysEfector != null)
                {
                    foreach (DalRis.TamHpv item in colTamHpvRecordsFromSysEfector)
                    {
                        if (item.IdEfectorLaboratorio != IdEfector)
                        {
                            item.IdEfectorLaboratorio = IdEfector;
                        }
                    }
               }
		
                if (colTamRegistroRecords != null)
                {
                    foreach (DalRis.TamRegistro item in colTamRegistroRecords)
                    {
                        if (item.IdEfectorReferencia != IdEfector)
                        {
                            item.IdEfectorReferencia = IdEfector;
                        }
                    }
               }
		
                if (colMamEcografia != null)
                {
                    foreach (DalRis.MamEcografium item in colMamEcografia)
                    {
                        if (item.IdEfectorRealizaEstudio != IdEfector)
                        {
                            item.IdEfectorRealizaEstudio = IdEfector;
                        }
                    }
               }
		
                if (colTamBiopsiaFromSysEfector != null)
                {
                    foreach (DalRis.TamBiopsium item in colTamBiopsiaFromSysEfector)
                    {
                        if (item.IdEfectorMuestra != IdEfector)
                        {
                            item.IdEfectorMuestra = IdEfector;
                        }
                    }
               }
		
                if (colMamEcografiaFromSysEfector != null)
                {
                    foreach (DalRis.MamEcografium item in colMamEcografiaFromSysEfector)
                    {
                        if (item.IdEfectorSolicita != IdEfector)
                        {
                            item.IdEfectorSolicita = IdEfector;
                        }
                    }
               }
		
                if (colTamBiopsiaFromSysEfectorIdEfectorMuestra != null)
                {
                    foreach (DalRis.TamBiopsium item in colTamBiopsiaFromSysEfectorIdEfectorMuestra)
                    {
                        if (item.IdEfectorMuestra != IdEfector)
                        {
                            item.IdEfectorMuestra = IdEfector;
                        }
                    }
               }
		
                if (colAprHistoriaClinicaPerinatalRecords != null)
                {
                    foreach (DalRis.AprHistoriaClinicaPerinatal item in colAprHistoriaClinicaPerinatalRecords)
                    {
                        if (item.IdEfectorTrasladoUt != IdEfector)
                        {
                            item.IdEfectorTrasladoUt = IdEfector;
                        }
                    }
               }
		
                if (colMamEstudiosAdicionalesFromSysEfector != null)
                {
                    foreach (DalRis.MamEstudiosAdicionale item in colMamEstudiosAdicionalesFromSysEfector)
                    {
                        if (item.IdEfectorRealizaEstudio != IdEfector)
                        {
                            item.IdEfectorRealizaEstudio = IdEfector;
                        }
                    }
               }
		
                if (colTamColposcopia != null)
                {
                    foreach (DalRis.TamColposcopium item in colTamColposcopia)
                    {
                        if (item.IdEfectorExamen != IdEfector)
                        {
                            item.IdEfectorExamen = IdEfector;
                        }
                    }
               }
		
                if (colMamRegistroRecords != null)
                {
                    foreach (DalRis.MamRegistro item in colMamRegistroRecords)
                    {
                        if (item.IdEfectorRealizaEstudio != IdEfector)
                        {
                            item.IdEfectorRealizaEstudio = IdEfector;
                        }
                    }
               }
		
                if (colMamRegistroRecordsFromSysEfector != null)
                {
                    foreach (DalRis.MamRegistro item in colMamRegistroRecordsFromSysEfector)
                    {
                        if (item.IdEfectorControl != IdEfector)
                        {
                            item.IdEfectorControl = IdEfector;
                        }
                    }
               }
		
                if (colTamHpvRecordsFromSysEfectorIdEfectorToma != null)
                {
                    foreach (DalRis.TamHpv item in colTamHpvRecordsFromSysEfectorIdEfectorToma)
                    {
                        if (item.IdEfectorToma != IdEfector)
                        {
                            item.IdEfectorToma = IdEfector;
                        }
                    }
               }
		
                if (colMamRegistroRecordsFromSysEfectorIdEfectorProcedencia != null)
                {
                    foreach (DalRis.MamRegistro item in colMamRegistroRecordsFromSysEfectorIdEfectorProcedencia)
                    {
                        if (item.IdEfectorProcedencia != IdEfector)
                        {
                            item.IdEfectorProcedencia = IdEfector;
                        }
                    }
               }
		
                if (colTamPapRecordsFromSysEfector != null)
                {
                    foreach (DalRis.TamPap item in colTamPapRecordsFromSysEfector)
                    {
                        if (item.IdEfectorMuestra != IdEfector)
                        {
                            item.IdEfectorMuestra = IdEfector;
                        }
                    }
               }
		
                if (colMamEcografiaFromSysEfectorIdEfectorInforma != null)
                {
                    foreach (DalRis.MamEcografium item in colMamEcografiaFromSysEfectorIdEfectorInforma)
                    {
                        if (item.IdEfectorInforma != IdEfector)
                        {
                            item.IdEfectorInforma = IdEfector;
                        }
                    }
               }
		
                if (colMamAntecedentes != null)
                {
                    foreach (DalRis.MamAntecedente item in colMamAntecedentes)
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
		
                if (colAprActividadFisicaRecords != null)
                {
                    foreach (DalRis.AprActividadFisica item in colAprActividadFisicaRecords)
                    {
                        if (item.IdEfector != IdEfector)
                        {
                            item.IdEfector = IdEfector;
                        }
                    }
               }
		
                if (colTamTratamientos != null)
                {
                    foreach (DalRis.TamTratamiento item in colTamTratamientos)
                    {
                        if (item.IdEfectorTratante != IdEfector)
                        {
                            item.IdEfectorTratante = IdEfector;
                        }
                    }
               }
		
                if (colMamExamenFisicoRecords != null)
                {
                    foreach (DalRis.MamExamenFisico item in colMamExamenFisicoRecords)
                    {
                        if (item.IdCentroSalud != IdEfector)
                        {
                            item.IdCentroSalud = IdEfector;
                        }
                    }
               }
		
                if (colAprPartoProvisorioRecords != null)
                {
                    foreach (DalRis.AprPartoProvisorio item in colAprPartoProvisorioRecords)
                    {
                        if (item.IdEfectorParto != IdEfector)
                        {
                            item.IdEfectorParto = IdEfector;
                        }
                    }
               }
		
                if (colConAgendaRecords != null)
                {
                    foreach (DalRis.ConAgenda item in colConAgendaRecords)
                    {
                        if (item.IdEfector != IdEfector)
                        {
                            item.IdEfector = IdEfector;
                        }
                    }
               }
		
                if (colMamTratamientos != null)
                {
                    foreach (DalRis.MamTratamiento item in colMamTratamientos)
                    {
                        if (item.IdCentroSalud != IdEfector)
                        {
                            item.IdCentroSalud = IdEfector;
                        }
                    }
               }
		
                if (colAprHistoriaClinicaPerinatalRecordsFromSysEfector != null)
                {
                    foreach (DalRis.AprHistoriaClinicaPerinatal item in colAprHistoriaClinicaPerinatalRecordsFromSysEfector)
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
		
                if (colRemFormularioRecords != null)
                {
                    foreach (DalRis.RemFormulario item in colRemFormularioRecords)
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
            
                if (colTabControlRecords != null)
                {
                    colTabControlRecords.SaveAll();
               }
		
                if (colAprControlOdontologicoRecords != null)
                {
                    colAprControlOdontologicoRecords.SaveAll();
               }
		
                if (colMamEstudiosHospitalProvincialRecords != null)
                {
                    colMamEstudiosHospitalProvincialRecords.SaveAll();
               }
		
                if (colAprInterconsulta != null)
                {
                    colAprInterconsulta.SaveAll();
               }
		
                if (colSysRelServicioEfectorRecords != null)
                {
                    colSysRelServicioEfectorRecords.SaveAll();
               }
		
                if (colMamCirugia != null)
                {
                    colMamCirugia.SaveAll();
               }
		
                if (colConConsultorioTipoRecords != null)
                {
                    colConConsultorioTipoRecords.SaveAll();
               }
		
                if (colConAgendaGrupalRecords != null)
                {
                    colConAgendaGrupalRecords.SaveAll();
               }
		
                if (colLabSolicitudScreeningRecords != null)
                {
                    colLabSolicitudScreeningRecords.SaveAll();
               }
		
                if (colLabSolicitudScreeningRecordsFromSysEfector != null)
                {
                    colLabSolicitudScreeningRecordsFromSysEfector.SaveAll();
               }
		
                if (colFacOrdenRecords != null)
                {
                    colFacOrdenRecords.SaveAll();
               }
		
                if (colMamAnatomiaPatologicaRecords != null)
                {
                    colMamAnatomiaPatologicaRecords.SaveAll();
               }
		
                if (colMamAnatomiaPatologicaRecordsFromSysEfector != null)
                {
                    colMamAnatomiaPatologicaRecordsFromSysEfector.SaveAll();
               }
		
                if (colFacJefeLaboratorioRecords != null)
                {
                    colFacJefeLaboratorioRecords.SaveAll();
               }
		
                if (colTamPapHPRecords != null)
                {
                    colTamPapHPRecords.SaveAll();
               }
		
                if (colRemClasificacionRecords != null)
                {
                    colRemClasificacionRecords.SaveAll();
               }
		
                if (colAprActividadControlPerinatalRecords != null)
                {
                    colAprActividadControlPerinatalRecords.SaveAll();
               }
		
                if (colMamPiezaQuirurgicaRecords != null)
                {
                    colMamPiezaQuirurgicaRecords.SaveAll();
               }
		
                if (colConTurnoReservaInterconsulta != null)
                {
                    colConTurnoReservaInterconsulta.SaveAll();
               }
		
                if (colMamEstudiosAdicionales != null)
                {
                    colMamEstudiosAdicionales.SaveAll();
               }
		
                if (colTamBiopsia != null)
                {
                    colTamBiopsia.SaveAll();
               }
		
                if (colChildSysEfectorRecords != null)
                {
                    colChildSysEfectorRecords.SaveAll();
               }
		
                if (colEmrPrehospitalaria != null)
                {
                    colEmrPrehospitalaria.SaveAll();
               }
		
                if (colTamPapRecords != null)
                {
                    colTamPapRecords.SaveAll();
               }
		
                if (colSysRelProfesionalEfectorRecords != null)
                {
                    colSysRelProfesionalEfectorRecords.SaveAll();
               }
		
                if (colSysRelEspecialidadEfectorRecords != null)
                {
                    colSysRelEspecialidadEfectorRecords.SaveAll();
               }
		
                if (colTamHpvRecords != null)
                {
                    colTamHpvRecords.SaveAll();
               }
		
                if (colSysRelHistoriaClinicaEfectorRecords != null)
                {
                    colSysRelHistoriaClinicaEfectorRecords.SaveAll();
               }
		
                if (colTamHpvRecordsFromSysEfector != null)
                {
                    colTamHpvRecordsFromSysEfector.SaveAll();
               }
		
                if (colTamRegistroRecords != null)
                {
                    colTamRegistroRecords.SaveAll();
               }
		
                if (colMamEcografia != null)
                {
                    colMamEcografia.SaveAll();
               }
		
                if (colTamBiopsiaFromSysEfector != null)
                {
                    colTamBiopsiaFromSysEfector.SaveAll();
               }
		
                if (colMamEcografiaFromSysEfector != null)
                {
                    colMamEcografiaFromSysEfector.SaveAll();
               }
		
                if (colTamBiopsiaFromSysEfectorIdEfectorMuestra != null)
                {
                    colTamBiopsiaFromSysEfectorIdEfectorMuestra.SaveAll();
               }
		
                if (colAprHistoriaClinicaPerinatalRecords != null)
                {
                    colAprHistoriaClinicaPerinatalRecords.SaveAll();
               }
		
                if (colMamEstudiosAdicionalesFromSysEfector != null)
                {
                    colMamEstudiosAdicionalesFromSysEfector.SaveAll();
               }
		
                if (colTamColposcopia != null)
                {
                    colTamColposcopia.SaveAll();
               }
		
                if (colMamRegistroRecords != null)
                {
                    colMamRegistroRecords.SaveAll();
               }
		
                if (colMamRegistroRecordsFromSysEfector != null)
                {
                    colMamRegistroRecordsFromSysEfector.SaveAll();
               }
		
                if (colTamHpvRecordsFromSysEfectorIdEfectorToma != null)
                {
                    colTamHpvRecordsFromSysEfectorIdEfectorToma.SaveAll();
               }
		
                if (colMamRegistroRecordsFromSysEfectorIdEfectorProcedencia != null)
                {
                    colMamRegistroRecordsFromSysEfectorIdEfectorProcedencia.SaveAll();
               }
		
                if (colTamPapRecordsFromSysEfector != null)
                {
                    colTamPapRecordsFromSysEfector.SaveAll();
               }
		
                if (colMamEcografiaFromSysEfectorIdEfectorInforma != null)
                {
                    colMamEcografiaFromSysEfectorIdEfectorInforma.SaveAll();
               }
		
                if (colMamAntecedentes != null)
                {
                    colMamAntecedentes.SaveAll();
               }
		
                if (colSysUsuarioRecords != null)
                {
                    colSysUsuarioRecords.SaveAll();
               }
		
                if (colAprActividadFisicaRecords != null)
                {
                    colAprActividadFisicaRecords.SaveAll();
               }
		
                if (colTamTratamientos != null)
                {
                    colTamTratamientos.SaveAll();
               }
		
                if (colMamExamenFisicoRecords != null)
                {
                    colMamExamenFisicoRecords.SaveAll();
               }
		
                if (colAprPartoProvisorioRecords != null)
                {
                    colAprPartoProvisorioRecords.SaveAll();
               }
		
                if (colConAgendaRecords != null)
                {
                    colConAgendaRecords.SaveAll();
               }
		
                if (colMamTratamientos != null)
                {
                    colMamTratamientos.SaveAll();
               }
		
                if (colAprHistoriaClinicaPerinatalRecordsFromSysEfector != null)
                {
                    colAprHistoriaClinicaPerinatalRecordsFromSysEfector.SaveAll();
               }
		
                if (colSysProfesionalRecords != null)
                {
                    colSysProfesionalRecords.SaveAll();
               }
		
                if (colRemFormularioRecords != null)
                {
                    colRemFormularioRecords.SaveAll();
               }
		}
        #endregion
	}
}
