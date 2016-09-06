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
	/// Strongly-typed collection for the TamHpv class.
	/// </summary>
    [Serializable]
	public partial class TamHpvCollection : ActiveList<TamHpv, TamHpvCollection>
	{	   
		public TamHpvCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>TamHpvCollection</returns>
		public TamHpvCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                TamHpv o = this[i];
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
	/// This is an ActiveRecord class which wraps the TAM_Hpv table.
	/// </summary>
	[Serializable]
	public partial class TamHpv : ActiveRecord<TamHpv>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public TamHpv()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public TamHpv(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public TamHpv(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public TamHpv(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("TAM_Hpv", TableType.Table, DataService.GetInstance("RisProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarIdHpv = new TableSchema.TableColumn(schema);
				colvarIdHpv.ColumnName = "idHpv";
				colvarIdHpv.DataType = DbType.Int32;
				colvarIdHpv.MaxLength = 0;
				colvarIdHpv.AutoIncrement = true;
				colvarIdHpv.IsNullable = false;
				colvarIdHpv.IsPrimaryKey = true;
				colvarIdHpv.IsForeignKey = false;
				colvarIdHpv.IsReadOnly = false;
				colvarIdHpv.DefaultSetting = @"";
				colvarIdHpv.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdHpv);
				
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
				
				TableSchema.TableColumn colvarFechaPrevioHpv = new TableSchema.TableColumn(schema);
				colvarFechaPrevioHpv.ColumnName = "fechaPrevioHpv";
				colvarFechaPrevioHpv.DataType = DbType.DateTime;
				colvarFechaPrevioHpv.MaxLength = 0;
				colvarFechaPrevioHpv.AutoIncrement = false;
				colvarFechaPrevioHpv.IsNullable = false;
				colvarFechaPrevioHpv.IsPrimaryKey = false;
				colvarFechaPrevioHpv.IsForeignKey = false;
				colvarFechaPrevioHpv.IsReadOnly = false;
				colvarFechaPrevioHpv.DefaultSetting = @"";
				colvarFechaPrevioHpv.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFechaPrevioHpv);
				
				TableSchema.TableColumn colvarHpvPrevio = new TableSchema.TableColumn(schema);
				colvarHpvPrevio.ColumnName = "hpvPrevio";
				colvarHpvPrevio.DataType = DbType.Boolean;
				colvarHpvPrevio.MaxLength = 0;
				colvarHpvPrevio.AutoIncrement = false;
				colvarHpvPrevio.IsNullable = false;
				colvarHpvPrevio.IsPrimaryKey = false;
				colvarHpvPrevio.IsForeignKey = false;
				colvarHpvPrevio.IsReadOnly = false;
				
						colvarHpvPrevio.DefaultSetting = @"((0))";
				colvarHpvPrevio.ForeignKeyTableName = "";
				schema.Columns.Add(colvarHpvPrevio);
				
				TableSchema.TableColumn colvarIdTipoHpvPrevio = new TableSchema.TableColumn(schema);
				colvarIdTipoHpvPrevio.ColumnName = "idTipoHpvPrevio";
				colvarIdTipoHpvPrevio.DataType = DbType.Int32;
				colvarIdTipoHpvPrevio.MaxLength = 0;
				colvarIdTipoHpvPrevio.AutoIncrement = false;
				colvarIdTipoHpvPrevio.IsNullable = false;
				colvarIdTipoHpvPrevio.IsPrimaryKey = false;
				colvarIdTipoHpvPrevio.IsForeignKey = true;
				colvarIdTipoHpvPrevio.IsReadOnly = false;
				
						colvarIdTipoHpvPrevio.DefaultSetting = @"((0))";
				
					colvarIdTipoHpvPrevio.ForeignKeyTableName = "TAM_TipoHpv";
				schema.Columns.Add(colvarIdTipoHpvPrevio);
				
				TableSchema.TableColumn colvarIdResultadoPrevioHpv = new TableSchema.TableColumn(schema);
				colvarIdResultadoPrevioHpv.ColumnName = "idResultadoPrevioHpv";
				colvarIdResultadoPrevioHpv.DataType = DbType.Int32;
				colvarIdResultadoPrevioHpv.MaxLength = 0;
				colvarIdResultadoPrevioHpv.AutoIncrement = false;
				colvarIdResultadoPrevioHpv.IsNullable = false;
				colvarIdResultadoPrevioHpv.IsPrimaryKey = false;
				colvarIdResultadoPrevioHpv.IsForeignKey = true;
				colvarIdResultadoPrevioHpv.IsReadOnly = false;
				
						colvarIdResultadoPrevioHpv.DefaultSetting = @"((0))";
				
					colvarIdResultadoPrevioHpv.ForeignKeyTableName = "TAM_ResultadoHpv";
				schema.Columns.Add(colvarIdResultadoPrevioHpv);
				
				TableSchema.TableColumn colvarMetodoToma = new TableSchema.TableColumn(schema);
				colvarMetodoToma.ColumnName = "metodoToma";
				colvarMetodoToma.DataType = DbType.AnsiString;
				colvarMetodoToma.MaxLength = 20;
				colvarMetodoToma.AutoIncrement = false;
				colvarMetodoToma.IsNullable = false;
				colvarMetodoToma.IsPrimaryKey = false;
				colvarMetodoToma.IsForeignKey = false;
				colvarMetodoToma.IsReadOnly = false;
				
						colvarMetodoToma.DefaultSetting = @"('')";
				colvarMetodoToma.ForeignKeyTableName = "";
				schema.Columns.Add(colvarMetodoToma);
				
				TableSchema.TableColumn colvarFechaToma = new TableSchema.TableColumn(schema);
				colvarFechaToma.ColumnName = "fechaToma";
				colvarFechaToma.DataType = DbType.DateTime;
				colvarFechaToma.MaxLength = 0;
				colvarFechaToma.AutoIncrement = false;
				colvarFechaToma.IsNullable = false;
				colvarFechaToma.IsPrimaryKey = false;
				colvarFechaToma.IsForeignKey = false;
				colvarFechaToma.IsReadOnly = false;
				colvarFechaToma.DefaultSetting = @"";
				colvarFechaToma.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFechaToma);
				
				TableSchema.TableColumn colvarAsociaPap = new TableSchema.TableColumn(schema);
				colvarAsociaPap.ColumnName = "asociaPap";
				colvarAsociaPap.DataType = DbType.Boolean;
				colvarAsociaPap.MaxLength = 0;
				colvarAsociaPap.AutoIncrement = false;
				colvarAsociaPap.IsNullable = false;
				colvarAsociaPap.IsPrimaryKey = false;
				colvarAsociaPap.IsForeignKey = false;
				colvarAsociaPap.IsReadOnly = false;
				
						colvarAsociaPap.DefaultSetting = @"((0))";
				colvarAsociaPap.ForeignKeyTableName = "";
				schema.Columns.Add(colvarAsociaPap);
				
				TableSchema.TableColumn colvarIdProfesionalToma = new TableSchema.TableColumn(schema);
				colvarIdProfesionalToma.ColumnName = "idProfesionalToma";
				colvarIdProfesionalToma.DataType = DbType.Int32;
				colvarIdProfesionalToma.MaxLength = 0;
				colvarIdProfesionalToma.AutoIncrement = false;
				colvarIdProfesionalToma.IsNullable = false;
				colvarIdProfesionalToma.IsPrimaryKey = false;
				colvarIdProfesionalToma.IsForeignKey = true;
				colvarIdProfesionalToma.IsReadOnly = false;
				
						colvarIdProfesionalToma.DefaultSetting = @"((0))";
				
					colvarIdProfesionalToma.ForeignKeyTableName = "Sys_Profesional";
				schema.Columns.Add(colvarIdProfesionalToma);
				
				TableSchema.TableColumn colvarIdEfectorToma = new TableSchema.TableColumn(schema);
				colvarIdEfectorToma.ColumnName = "idEfectorToma";
				colvarIdEfectorToma.DataType = DbType.Int32;
				colvarIdEfectorToma.MaxLength = 0;
				colvarIdEfectorToma.AutoIncrement = false;
				colvarIdEfectorToma.IsNullable = false;
				colvarIdEfectorToma.IsPrimaryKey = false;
				colvarIdEfectorToma.IsForeignKey = true;
				colvarIdEfectorToma.IsReadOnly = false;
				
						colvarIdEfectorToma.DefaultSetting = @"((0))";
				
					colvarIdEfectorToma.ForeignKeyTableName = "Sys_Efector";
				schema.Columns.Add(colvarIdEfectorToma);
				
				TableSchema.TableColumn colvarFechaRecepcion = new TableSchema.TableColumn(schema);
				colvarFechaRecepcion.ColumnName = "fechaRecepcion";
				colvarFechaRecepcion.DataType = DbType.DateTime;
				colvarFechaRecepcion.MaxLength = 0;
				colvarFechaRecepcion.AutoIncrement = false;
				colvarFechaRecepcion.IsNullable = false;
				colvarFechaRecepcion.IsPrimaryKey = false;
				colvarFechaRecepcion.IsForeignKey = false;
				colvarFechaRecepcion.IsReadOnly = false;
				colvarFechaRecepcion.DefaultSetting = @"";
				colvarFechaRecepcion.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFechaRecepcion);
				
				TableSchema.TableColumn colvarIngresoLetra = new TableSchema.TableColumn(schema);
				colvarIngresoLetra.ColumnName = "ingresoLetra";
				colvarIngresoLetra.DataType = DbType.AnsiStringFixedLength;
				colvarIngresoLetra.MaxLength = 3;
				colvarIngresoLetra.AutoIncrement = false;
				colvarIngresoLetra.IsNullable = false;
				colvarIngresoLetra.IsPrimaryKey = false;
				colvarIngresoLetra.IsForeignKey = false;
				colvarIngresoLetra.IsReadOnly = false;
				
						colvarIngresoLetra.DefaultSetting = @"('')";
				colvarIngresoLetra.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIngresoLetra);
				
				TableSchema.TableColumn colvarIngresoNro = new TableSchema.TableColumn(schema);
				colvarIngresoNro.ColumnName = "ingresoNro";
				colvarIngresoNro.DataType = DbType.Int32;
				colvarIngresoNro.MaxLength = 0;
				colvarIngresoNro.AutoIncrement = false;
				colvarIngresoNro.IsNullable = false;
				colvarIngresoNro.IsPrimaryKey = false;
				colvarIngresoNro.IsForeignKey = false;
				colvarIngresoNro.IsReadOnly = false;
				
						colvarIngresoNro.DefaultSetting = @"((0))";
				colvarIngresoNro.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIngresoNro);
				
				TableSchema.TableColumn colvarIngresoNro2 = new TableSchema.TableColumn(schema);
				colvarIngresoNro2.ColumnName = "ingresoNro2";
				colvarIngresoNro2.DataType = DbType.Int32;
				colvarIngresoNro2.MaxLength = 0;
				colvarIngresoNro2.AutoIncrement = false;
				colvarIngresoNro2.IsNullable = false;
				colvarIngresoNro2.IsPrimaryKey = false;
				colvarIngresoNro2.IsForeignKey = false;
				colvarIngresoNro2.IsReadOnly = false;
				
						colvarIngresoNro2.DefaultSetting = @"((0))";
				colvarIngresoNro2.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIngresoNro2);
				
				TableSchema.TableColumn colvarIdEfectorLaboratorio = new TableSchema.TableColumn(schema);
				colvarIdEfectorLaboratorio.ColumnName = "idEfectorLaboratorio";
				colvarIdEfectorLaboratorio.DataType = DbType.Int32;
				colvarIdEfectorLaboratorio.MaxLength = 0;
				colvarIdEfectorLaboratorio.AutoIncrement = false;
				colvarIdEfectorLaboratorio.IsNullable = false;
				colvarIdEfectorLaboratorio.IsPrimaryKey = false;
				colvarIdEfectorLaboratorio.IsForeignKey = true;
				colvarIdEfectorLaboratorio.IsReadOnly = false;
				
						colvarIdEfectorLaboratorio.DefaultSetting = @"((0))";
				
					colvarIdEfectorLaboratorio.ForeignKeyTableName = "Sys_Efector";
				schema.Columns.Add(colvarIdEfectorLaboratorio);
				
				TableSchema.TableColumn colvarFechaInforme = new TableSchema.TableColumn(schema);
				colvarFechaInforme.ColumnName = "fechaInforme";
				colvarFechaInforme.DataType = DbType.DateTime;
				colvarFechaInforme.MaxLength = 0;
				colvarFechaInforme.AutoIncrement = false;
				colvarFechaInforme.IsNullable = false;
				colvarFechaInforme.IsPrimaryKey = false;
				colvarFechaInforme.IsForeignKey = false;
				colvarFechaInforme.IsReadOnly = false;
				colvarFechaInforme.DefaultSetting = @"";
				colvarFechaInforme.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFechaInforme);
				
				TableSchema.TableColumn colvarIdProfesionalInforma = new TableSchema.TableColumn(schema);
				colvarIdProfesionalInforma.ColumnName = "idProfesionalInforma";
				colvarIdProfesionalInforma.DataType = DbType.Int32;
				colvarIdProfesionalInforma.MaxLength = 0;
				colvarIdProfesionalInforma.AutoIncrement = false;
				colvarIdProfesionalInforma.IsNullable = false;
				colvarIdProfesionalInforma.IsPrimaryKey = false;
				colvarIdProfesionalInforma.IsForeignKey = true;
				colvarIdProfesionalInforma.IsReadOnly = false;
				
						colvarIdProfesionalInforma.DefaultSetting = @"((0))";
				
					colvarIdProfesionalInforma.ForeignKeyTableName = "Sys_Profesional";
				schema.Columns.Add(colvarIdProfesionalInforma);
				
				TableSchema.TableColumn colvarIdResultadoHpv = new TableSchema.TableColumn(schema);
				colvarIdResultadoHpv.ColumnName = "idResultadoHpv";
				colvarIdResultadoHpv.DataType = DbType.Int32;
				colvarIdResultadoHpv.MaxLength = 0;
				colvarIdResultadoHpv.AutoIncrement = false;
				colvarIdResultadoHpv.IsNullable = false;
				colvarIdResultadoHpv.IsPrimaryKey = false;
				colvarIdResultadoHpv.IsForeignKey = true;
				colvarIdResultadoHpv.IsReadOnly = false;
				
						colvarIdResultadoHpv.DefaultSetting = @"((0))";
				
					colvarIdResultadoHpv.ForeignKeyTableName = "TAM_ResultadoHpv";
				schema.Columns.Add(colvarIdResultadoHpv);
				
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
				
				TableSchema.TableColumn colvarNumeroProtocolo = new TableSchema.TableColumn(schema);
				colvarNumeroProtocolo.ColumnName = "numeroProtocolo";
				colvarNumeroProtocolo.DataType = DbType.AnsiString;
				colvarNumeroProtocolo.MaxLength = 10;
				colvarNumeroProtocolo.AutoIncrement = false;
				colvarNumeroProtocolo.IsNullable = false;
				colvarNumeroProtocolo.IsPrimaryKey = false;
				colvarNumeroProtocolo.IsForeignKey = false;
				colvarNumeroProtocolo.IsReadOnly = false;
				
						colvarNumeroProtocolo.DefaultSetting = @"((0))";
				colvarNumeroProtocolo.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNumeroProtocolo);
				
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
				DataService.Providers["RisProvider"].AddSchema("TAM_Hpv",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("IdHpv")]
		[Bindable(true)]
		public int IdHpv 
		{
			get { return GetColumnValue<int>(Columns.IdHpv); }
			set { SetColumnValue(Columns.IdHpv, value); }
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
		  
		[XmlAttribute("FechaPrevioHpv")]
		[Bindable(true)]
		public DateTime FechaPrevioHpv 
		{
			get { return GetColumnValue<DateTime>(Columns.FechaPrevioHpv); }
			set { SetColumnValue(Columns.FechaPrevioHpv, value); }
		}
		  
		[XmlAttribute("HpvPrevio")]
		[Bindable(true)]
		public bool HpvPrevio 
		{
			get { return GetColumnValue<bool>(Columns.HpvPrevio); }
			set { SetColumnValue(Columns.HpvPrevio, value); }
		}
		  
		[XmlAttribute("IdTipoHpvPrevio")]
		[Bindable(true)]
		public int IdTipoHpvPrevio 
		{
			get { return GetColumnValue<int>(Columns.IdTipoHpvPrevio); }
			set { SetColumnValue(Columns.IdTipoHpvPrevio, value); }
		}
		  
		[XmlAttribute("IdResultadoPrevioHpv")]
		[Bindable(true)]
		public int IdResultadoPrevioHpv 
		{
			get { return GetColumnValue<int>(Columns.IdResultadoPrevioHpv); }
			set { SetColumnValue(Columns.IdResultadoPrevioHpv, value); }
		}
		  
		[XmlAttribute("MetodoToma")]
		[Bindable(true)]
		public string MetodoToma 
		{
			get { return GetColumnValue<string>(Columns.MetodoToma); }
			set { SetColumnValue(Columns.MetodoToma, value); }
		}
		  
		[XmlAttribute("FechaToma")]
		[Bindable(true)]
		public DateTime FechaToma 
		{
			get { return GetColumnValue<DateTime>(Columns.FechaToma); }
			set { SetColumnValue(Columns.FechaToma, value); }
		}
		  
		[XmlAttribute("AsociaPap")]
		[Bindable(true)]
		public bool AsociaPap 
		{
			get { return GetColumnValue<bool>(Columns.AsociaPap); }
			set { SetColumnValue(Columns.AsociaPap, value); }
		}
		  
		[XmlAttribute("IdProfesionalToma")]
		[Bindable(true)]
		public int IdProfesionalToma 
		{
			get { return GetColumnValue<int>(Columns.IdProfesionalToma); }
			set { SetColumnValue(Columns.IdProfesionalToma, value); }
		}
		  
		[XmlAttribute("IdEfectorToma")]
		[Bindable(true)]
		public int IdEfectorToma 
		{
			get { return GetColumnValue<int>(Columns.IdEfectorToma); }
			set { SetColumnValue(Columns.IdEfectorToma, value); }
		}
		  
		[XmlAttribute("FechaRecepcion")]
		[Bindable(true)]
		public DateTime FechaRecepcion 
		{
			get { return GetColumnValue<DateTime>(Columns.FechaRecepcion); }
			set { SetColumnValue(Columns.FechaRecepcion, value); }
		}
		  
		[XmlAttribute("IngresoLetra")]
		[Bindable(true)]
		public string IngresoLetra 
		{
			get { return GetColumnValue<string>(Columns.IngresoLetra); }
			set { SetColumnValue(Columns.IngresoLetra, value); }
		}
		  
		[XmlAttribute("IngresoNro")]
		[Bindable(true)]
		public int IngresoNro 
		{
			get { return GetColumnValue<int>(Columns.IngresoNro); }
			set { SetColumnValue(Columns.IngresoNro, value); }
		}
		  
		[XmlAttribute("IngresoNro2")]
		[Bindable(true)]
		public int IngresoNro2 
		{
			get { return GetColumnValue<int>(Columns.IngresoNro2); }
			set { SetColumnValue(Columns.IngresoNro2, value); }
		}
		  
		[XmlAttribute("IdEfectorLaboratorio")]
		[Bindable(true)]
		public int IdEfectorLaboratorio 
		{
			get { return GetColumnValue<int>(Columns.IdEfectorLaboratorio); }
			set { SetColumnValue(Columns.IdEfectorLaboratorio, value); }
		}
		  
		[XmlAttribute("FechaInforme")]
		[Bindable(true)]
		public DateTime FechaInforme 
		{
			get { return GetColumnValue<DateTime>(Columns.FechaInforme); }
			set { SetColumnValue(Columns.FechaInforme, value); }
		}
		  
		[XmlAttribute("IdProfesionalInforma")]
		[Bindable(true)]
		public int IdProfesionalInforma 
		{
			get { return GetColumnValue<int>(Columns.IdProfesionalInforma); }
			set { SetColumnValue(Columns.IdProfesionalInforma, value); }
		}
		  
		[XmlAttribute("IdResultadoHpv")]
		[Bindable(true)]
		public int IdResultadoHpv 
		{
			get { return GetColumnValue<int>(Columns.IdResultadoHpv); }
			set { SetColumnValue(Columns.IdResultadoHpv, value); }
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
		  
		[XmlAttribute("NumeroProtocolo")]
		[Bindable(true)]
		public string NumeroProtocolo 
		{
			get { return GetColumnValue<string>(Columns.NumeroProtocolo); }
			set { SetColumnValue(Columns.NumeroProtocolo, value); }
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
		/// Returns a SysEfector ActiveRecord object related to this TamHpv
		/// 
		/// </summary>
		public DalRis.SysEfector SysEfector
		{
			get { return DalRis.SysEfector.FetchByID(this.IdEfectorToma); }
			set { SetColumnValue("idEfectorToma", value.IdEfector); }
		}
		
		
		/// <summary>
		/// Returns a SysEfector ActiveRecord object related to this TamHpv
		/// 
		/// </summary>
		public DalRis.SysEfector SysEfectorToIdEfectorLaboratorio
		{
			get { return DalRis.SysEfector.FetchByID(this.IdEfectorLaboratorio); }
			set { SetColumnValue("idEfectorLaboratorio", value.IdEfector); }
		}
		
		
		/// <summary>
		/// Returns a SysEfector ActiveRecord object related to this TamHpv
		/// 
		/// </summary>
		public DalRis.SysEfector SysEfectorToIdEfectorToma
		{
			get { return DalRis.SysEfector.FetchByID(this.IdEfectorToma); }
			set { SetColumnValue("idEfectorToma", value.IdEfector); }
		}
		
		
		/// <summary>
		/// Returns a TamRegistro ActiveRecord object related to this TamHpv
		/// 
		/// </summary>
		public DalRis.TamRegistro TamRegistro
		{
			get { return DalRis.TamRegistro.FetchByID(this.IdTam); }
			set { SetColumnValue("idTam", value.IdTam); }
		}
		
		
		/// <summary>
		/// Returns a TamResultadoHpv ActiveRecord object related to this TamHpv
		/// 
		/// </summary>
		public DalRis.TamResultadoHpv TamResultadoHpv
		{
			get { return DalRis.TamResultadoHpv.FetchByID(this.IdResultadoPrevioHpv); }
			set { SetColumnValue("idResultadoPrevioHpv", value.IdResultadoHpv); }
		}
		
		
		/// <summary>
		/// Returns a TamResultadoHpv ActiveRecord object related to this TamHpv
		/// 
		/// </summary>
		public DalRis.TamResultadoHpv TamResultadoHpvToIdResultadoHpv
		{
			get { return DalRis.TamResultadoHpv.FetchByID(this.IdResultadoHpv); }
			set { SetColumnValue("idResultadoHpv", value.IdResultadoHpv); }
		}
		
		
		/// <summary>
		/// Returns a SysProfesional ActiveRecord object related to this TamHpv
		/// 
		/// </summary>
		public DalRis.SysProfesional SysProfesional
		{
			get { return DalRis.SysProfesional.FetchByID(this.IdProfesionalInforma); }
			set { SetColumnValue("idProfesionalInforma", value.IdProfesional); }
		}
		
		
		/// <summary>
		/// Returns a SysProfesional ActiveRecord object related to this TamHpv
		/// 
		/// </summary>
		public DalRis.SysProfesional SysProfesionalToIdProfesionalToma
		{
			get { return DalRis.SysProfesional.FetchByID(this.IdProfesionalToma); }
			set { SetColumnValue("idProfesionalToma", value.IdProfesional); }
		}
		
		
		/// <summary>
		/// Returns a TamTipoHpv ActiveRecord object related to this TamHpv
		/// 
		/// </summary>
		public DalRis.TamTipoHpv TamTipoHpv
		{
			get { return DalRis.TamTipoHpv.FetchByID(this.IdTipoHpvPrevio); }
			set { SetColumnValue("idTipoHpvPrevio", value.IdTipoHpv); }
		}
		
		
		#endregion
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(int varIdTam,int varIdPaciente,int varEdad,DateTime varFechaPrevioHpv,bool varHpvPrevio,int varIdTipoHpvPrevio,int varIdResultadoPrevioHpv,string varMetodoToma,DateTime varFechaToma,bool varAsociaPap,int varIdProfesionalToma,int varIdEfectorToma,DateTime varFechaRecepcion,string varIngresoLetra,int varIngresoNro,int varIngresoNro2,int varIdEfectorLaboratorio,DateTime varFechaInforme,int varIdProfesionalInforma,int varIdResultadoHpv,string varObservaciones,string varCreatedBy,DateTime varCreatedOn,string varModifiedBy,DateTime varModifiedOn,string varNumeroProtocolo,bool varActivo)
		{
			TamHpv item = new TamHpv();
			
			item.IdTam = varIdTam;
			
			item.IdPaciente = varIdPaciente;
			
			item.Edad = varEdad;
			
			item.FechaPrevioHpv = varFechaPrevioHpv;
			
			item.HpvPrevio = varHpvPrevio;
			
			item.IdTipoHpvPrevio = varIdTipoHpvPrevio;
			
			item.IdResultadoPrevioHpv = varIdResultadoPrevioHpv;
			
			item.MetodoToma = varMetodoToma;
			
			item.FechaToma = varFechaToma;
			
			item.AsociaPap = varAsociaPap;
			
			item.IdProfesionalToma = varIdProfesionalToma;
			
			item.IdEfectorToma = varIdEfectorToma;
			
			item.FechaRecepcion = varFechaRecepcion;
			
			item.IngresoLetra = varIngresoLetra;
			
			item.IngresoNro = varIngresoNro;
			
			item.IngresoNro2 = varIngresoNro2;
			
			item.IdEfectorLaboratorio = varIdEfectorLaboratorio;
			
			item.FechaInforme = varFechaInforme;
			
			item.IdProfesionalInforma = varIdProfesionalInforma;
			
			item.IdResultadoHpv = varIdResultadoHpv;
			
			item.Observaciones = varObservaciones;
			
			item.CreatedBy = varCreatedBy;
			
			item.CreatedOn = varCreatedOn;
			
			item.ModifiedBy = varModifiedBy;
			
			item.ModifiedOn = varModifiedOn;
			
			item.NumeroProtocolo = varNumeroProtocolo;
			
			item.Activo = varActivo;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varIdHpv,int varIdTam,int varIdPaciente,int varEdad,DateTime varFechaPrevioHpv,bool varHpvPrevio,int varIdTipoHpvPrevio,int varIdResultadoPrevioHpv,string varMetodoToma,DateTime varFechaToma,bool varAsociaPap,int varIdProfesionalToma,int varIdEfectorToma,DateTime varFechaRecepcion,string varIngresoLetra,int varIngresoNro,int varIngresoNro2,int varIdEfectorLaboratorio,DateTime varFechaInforme,int varIdProfesionalInforma,int varIdResultadoHpv,string varObservaciones,string varCreatedBy,DateTime varCreatedOn,string varModifiedBy,DateTime varModifiedOn,string varNumeroProtocolo,bool varActivo)
		{
			TamHpv item = new TamHpv();
			
				item.IdHpv = varIdHpv;
			
				item.IdTam = varIdTam;
			
				item.IdPaciente = varIdPaciente;
			
				item.Edad = varEdad;
			
				item.FechaPrevioHpv = varFechaPrevioHpv;
			
				item.HpvPrevio = varHpvPrevio;
			
				item.IdTipoHpvPrevio = varIdTipoHpvPrevio;
			
				item.IdResultadoPrevioHpv = varIdResultadoPrevioHpv;
			
				item.MetodoToma = varMetodoToma;
			
				item.FechaToma = varFechaToma;
			
				item.AsociaPap = varAsociaPap;
			
				item.IdProfesionalToma = varIdProfesionalToma;
			
				item.IdEfectorToma = varIdEfectorToma;
			
				item.FechaRecepcion = varFechaRecepcion;
			
				item.IngresoLetra = varIngresoLetra;
			
				item.IngresoNro = varIngresoNro;
			
				item.IngresoNro2 = varIngresoNro2;
			
				item.IdEfectorLaboratorio = varIdEfectorLaboratorio;
			
				item.FechaInforme = varFechaInforme;
			
				item.IdProfesionalInforma = varIdProfesionalInforma;
			
				item.IdResultadoHpv = varIdResultadoHpv;
			
				item.Observaciones = varObservaciones;
			
				item.CreatedBy = varCreatedBy;
			
				item.CreatedOn = varCreatedOn;
			
				item.ModifiedBy = varModifiedBy;
			
				item.ModifiedOn = varModifiedOn;
			
				item.NumeroProtocolo = varNumeroProtocolo;
			
				item.Activo = varActivo;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn IdHpvColumn
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
        
        
        
        public static TableSchema.TableColumn FechaPrevioHpvColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn HpvPrevioColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        public static TableSchema.TableColumn IdTipoHpvPrevioColumn
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        public static TableSchema.TableColumn IdResultadoPrevioHpvColumn
        {
            get { return Schema.Columns[7]; }
        }
        
        
        
        public static TableSchema.TableColumn MetodoTomaColumn
        {
            get { return Schema.Columns[8]; }
        }
        
        
        
        public static TableSchema.TableColumn FechaTomaColumn
        {
            get { return Schema.Columns[9]; }
        }
        
        
        
        public static TableSchema.TableColumn AsociaPapColumn
        {
            get { return Schema.Columns[10]; }
        }
        
        
        
        public static TableSchema.TableColumn IdProfesionalTomaColumn
        {
            get { return Schema.Columns[11]; }
        }
        
        
        
        public static TableSchema.TableColumn IdEfectorTomaColumn
        {
            get { return Schema.Columns[12]; }
        }
        
        
        
        public static TableSchema.TableColumn FechaRecepcionColumn
        {
            get { return Schema.Columns[13]; }
        }
        
        
        
        public static TableSchema.TableColumn IngresoLetraColumn
        {
            get { return Schema.Columns[14]; }
        }
        
        
        
        public static TableSchema.TableColumn IngresoNroColumn
        {
            get { return Schema.Columns[15]; }
        }
        
        
        
        public static TableSchema.TableColumn IngresoNro2Column
        {
            get { return Schema.Columns[16]; }
        }
        
        
        
        public static TableSchema.TableColumn IdEfectorLaboratorioColumn
        {
            get { return Schema.Columns[17]; }
        }
        
        
        
        public static TableSchema.TableColumn FechaInformeColumn
        {
            get { return Schema.Columns[18]; }
        }
        
        
        
        public static TableSchema.TableColumn IdProfesionalInformaColumn
        {
            get { return Schema.Columns[19]; }
        }
        
        
        
        public static TableSchema.TableColumn IdResultadoHpvColumn
        {
            get { return Schema.Columns[20]; }
        }
        
        
        
        public static TableSchema.TableColumn ObservacionesColumn
        {
            get { return Schema.Columns[21]; }
        }
        
        
        
        public static TableSchema.TableColumn CreatedByColumn
        {
            get { return Schema.Columns[22]; }
        }
        
        
        
        public static TableSchema.TableColumn CreatedOnColumn
        {
            get { return Schema.Columns[23]; }
        }
        
        
        
        public static TableSchema.TableColumn ModifiedByColumn
        {
            get { return Schema.Columns[24]; }
        }
        
        
        
        public static TableSchema.TableColumn ModifiedOnColumn
        {
            get { return Schema.Columns[25]; }
        }
        
        
        
        public static TableSchema.TableColumn NumeroProtocoloColumn
        {
            get { return Schema.Columns[26]; }
        }
        
        
        
        public static TableSchema.TableColumn ActivoColumn
        {
            get { return Schema.Columns[27]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string IdHpv = @"idHpv";
			 public static string IdTam = @"idTam";
			 public static string IdPaciente = @"idPaciente";
			 public static string Edad = @"edad";
			 public static string FechaPrevioHpv = @"fechaPrevioHpv";
			 public static string HpvPrevio = @"hpvPrevio";
			 public static string IdTipoHpvPrevio = @"idTipoHpvPrevio";
			 public static string IdResultadoPrevioHpv = @"idResultadoPrevioHpv";
			 public static string MetodoToma = @"metodoToma";
			 public static string FechaToma = @"fechaToma";
			 public static string AsociaPap = @"asociaPap";
			 public static string IdProfesionalToma = @"idProfesionalToma";
			 public static string IdEfectorToma = @"idEfectorToma";
			 public static string FechaRecepcion = @"fechaRecepcion";
			 public static string IngresoLetra = @"ingresoLetra";
			 public static string IngresoNro = @"ingresoNro";
			 public static string IngresoNro2 = @"ingresoNro2";
			 public static string IdEfectorLaboratorio = @"idEfectorLaboratorio";
			 public static string FechaInforme = @"fechaInforme";
			 public static string IdProfesionalInforma = @"idProfesionalInforma";
			 public static string IdResultadoHpv = @"idResultadoHpv";
			 public static string Observaciones = @"observaciones";
			 public static string CreatedBy = @"CreatedBy";
			 public static string CreatedOn = @"CreatedOn";
			 public static string ModifiedBy = @"ModifiedBy";
			 public static string ModifiedOn = @"ModifiedOn";
			 public static string NumeroProtocolo = @"numeroProtocolo";
			 public static string Activo = @"activo";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
