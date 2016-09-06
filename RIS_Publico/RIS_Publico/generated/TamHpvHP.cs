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
	/// Strongly-typed collection for the TamHpvHP class.
	/// </summary>
    [Serializable]
	public partial class TamHpvHPCollection : ActiveList<TamHpvHP, TamHpvHPCollection>
	{	   
		public TamHpvHPCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>TamHpvHPCollection</returns>
		public TamHpvHPCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                TamHpvHP o = this[i];
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
	/// This is an ActiveRecord class which wraps the TAM_HpvHP table.
	/// </summary>
	[Serializable]
	public partial class TamHpvHP : ActiveRecord<TamHpvHP>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public TamHpvHP()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public TamHpvHP(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public TamHpvHP(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public TamHpvHP(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("TAM_HpvHP", TableType.Table, DataService.GetInstance("RisProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarId = new TableSchema.TableColumn(schema);
				colvarId.ColumnName = "Id";
				colvarId.DataType = DbType.Int32;
				colvarId.MaxLength = 0;
				colvarId.AutoIncrement = true;
				colvarId.IsNullable = false;
				colvarId.IsPrimaryKey = true;
				colvarId.IsForeignKey = false;
				colvarId.IsReadOnly = false;
				colvarId.DefaultSetting = @"";
				colvarId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarId);
				
				TableSchema.TableColumn colvarIdCitologo = new TableSchema.TableColumn(schema);
				colvarIdCitologo.ColumnName = "idCitologo";
				colvarIdCitologo.DataType = DbType.Int32;
				colvarIdCitologo.MaxLength = 0;
				colvarIdCitologo.AutoIncrement = false;
				colvarIdCitologo.IsNullable = true;
				colvarIdCitologo.IsPrimaryKey = false;
				colvarIdCitologo.IsForeignKey = false;
				colvarIdCitologo.IsReadOnly = false;
				colvarIdCitologo.DefaultSetting = @"";
				colvarIdCitologo.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdCitologo);
				
				TableSchema.TableColumn colvarIdMedicoSol = new TableSchema.TableColumn(schema);
				colvarIdMedicoSol.ColumnName = "idMedicoSol";
				colvarIdMedicoSol.DataType = DbType.Int32;
				colvarIdMedicoSol.MaxLength = 0;
				colvarIdMedicoSol.AutoIncrement = false;
				colvarIdMedicoSol.IsNullable = true;
				colvarIdMedicoSol.IsPrimaryKey = false;
				colvarIdMedicoSol.IsForeignKey = false;
				colvarIdMedicoSol.IsReadOnly = false;
				colvarIdMedicoSol.DefaultSetting = @"";
				colvarIdMedicoSol.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdMedicoSol);
				
				TableSchema.TableColumn colvarIdTipoMuestra = new TableSchema.TableColumn(schema);
				colvarIdTipoMuestra.ColumnName = "idTipoMuestra";
				colvarIdTipoMuestra.DataType = DbType.Int32;
				colvarIdTipoMuestra.MaxLength = 0;
				colvarIdTipoMuestra.AutoIncrement = false;
				colvarIdTipoMuestra.IsNullable = true;
				colvarIdTipoMuestra.IsPrimaryKey = false;
				colvarIdTipoMuestra.IsForeignKey = true;
				colvarIdTipoMuestra.IsReadOnly = false;
				colvarIdTipoMuestra.DefaultSetting = @"";
				
					colvarIdTipoMuestra.ForeignKeyTableName = "TAM_TipoMuestra";
				schema.Columns.Add(colvarIdTipoMuestra);
				
				TableSchema.TableColumn colvarFechaMuestra = new TableSchema.TableColumn(schema);
				colvarFechaMuestra.ColumnName = "fechaMuestra";
				colvarFechaMuestra.DataType = DbType.DateTime;
				colvarFechaMuestra.MaxLength = 0;
				colvarFechaMuestra.AutoIncrement = false;
				colvarFechaMuestra.IsNullable = true;
				colvarFechaMuestra.IsPrimaryKey = false;
				colvarFechaMuestra.IsForeignKey = false;
				colvarFechaMuestra.IsReadOnly = false;
				colvarFechaMuestra.DefaultSetting = @"";
				colvarFechaMuestra.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFechaMuestra);
				
				TableSchema.TableColumn colvarFechaInforme = new TableSchema.TableColumn(schema);
				colvarFechaInforme.ColumnName = "fechaInforme";
				colvarFechaInforme.DataType = DbType.DateTime;
				colvarFechaInforme.MaxLength = 0;
				colvarFechaInforme.AutoIncrement = false;
				colvarFechaInforme.IsNullable = true;
				colvarFechaInforme.IsPrimaryKey = false;
				colvarFechaInforme.IsForeignKey = false;
				colvarFechaInforme.IsReadOnly = false;
				colvarFechaInforme.DefaultSetting = @"";
				colvarFechaInforme.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFechaInforme);
				
				TableSchema.TableColumn colvarIdResultado = new TableSchema.TableColumn(schema);
				colvarIdResultado.ColumnName = "idResultado";
				colvarIdResultado.DataType = DbType.Int32;
				colvarIdResultado.MaxLength = 0;
				colvarIdResultado.AutoIncrement = false;
				colvarIdResultado.IsNullable = true;
				colvarIdResultado.IsPrimaryKey = false;
				colvarIdResultado.IsForeignKey = true;
				colvarIdResultado.IsReadOnly = false;
				colvarIdResultado.DefaultSetting = @"";
				
					colvarIdResultado.ForeignKeyTableName = "TAM_ResultadoHpv";
				schema.Columns.Add(colvarIdResultado);
				
				TableSchema.TableColumn colvarFechaRecepcion = new TableSchema.TableColumn(schema);
				colvarFechaRecepcion.ColumnName = "fechaRecepcion";
				colvarFechaRecepcion.DataType = DbType.DateTime;
				colvarFechaRecepcion.MaxLength = 0;
				colvarFechaRecepcion.AutoIncrement = false;
				colvarFechaRecepcion.IsNullable = true;
				colvarFechaRecepcion.IsPrimaryKey = false;
				colvarFechaRecepcion.IsForeignKey = false;
				colvarFechaRecepcion.IsReadOnly = false;
				colvarFechaRecepcion.DefaultSetting = @"";
				colvarFechaRecepcion.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFechaRecepcion);
				
				TableSchema.TableColumn colvarIdPaciente = new TableSchema.TableColumn(schema);
				colvarIdPaciente.ColumnName = "idPaciente";
				colvarIdPaciente.DataType = DbType.Int32;
				colvarIdPaciente.MaxLength = 0;
				colvarIdPaciente.AutoIncrement = false;
				colvarIdPaciente.IsNullable = true;
				colvarIdPaciente.IsPrimaryKey = false;
				colvarIdPaciente.IsForeignKey = false;
				colvarIdPaciente.IsReadOnly = false;
				colvarIdPaciente.DefaultSetting = @"";
				colvarIdPaciente.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdPaciente);
				
				TableSchema.TableColumn colvarNombrePaciente = new TableSchema.TableColumn(schema);
				colvarNombrePaciente.ColumnName = "nombrePaciente";
				colvarNombrePaciente.DataType = DbType.AnsiString;
				colvarNombrePaciente.MaxLength = 200;
				colvarNombrePaciente.AutoIncrement = false;
				colvarNombrePaciente.IsNullable = true;
				colvarNombrePaciente.IsPrimaryKey = false;
				colvarNombrePaciente.IsForeignKey = false;
				colvarNombrePaciente.IsReadOnly = false;
				colvarNombrePaciente.DefaultSetting = @"";
				colvarNombrePaciente.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNombrePaciente);
				
				TableSchema.TableColumn colvarApellidoPaciente = new TableSchema.TableColumn(schema);
				colvarApellidoPaciente.ColumnName = "apellidoPaciente";
				colvarApellidoPaciente.DataType = DbType.AnsiString;
				colvarApellidoPaciente.MaxLength = 200;
				colvarApellidoPaciente.AutoIncrement = false;
				colvarApellidoPaciente.IsNullable = true;
				colvarApellidoPaciente.IsPrimaryKey = false;
				colvarApellidoPaciente.IsForeignKey = false;
				colvarApellidoPaciente.IsReadOnly = false;
				colvarApellidoPaciente.DefaultSetting = @"";
				colvarApellidoPaciente.ForeignKeyTableName = "";
				schema.Columns.Add(colvarApellidoPaciente);
				
				TableSchema.TableColumn colvarDireccionPaciente = new TableSchema.TableColumn(schema);
				colvarDireccionPaciente.ColumnName = "direccionPaciente";
				colvarDireccionPaciente.DataType = DbType.AnsiString;
				colvarDireccionPaciente.MaxLength = 500;
				colvarDireccionPaciente.AutoIncrement = false;
				colvarDireccionPaciente.IsNullable = true;
				colvarDireccionPaciente.IsPrimaryKey = false;
				colvarDireccionPaciente.IsForeignKey = false;
				colvarDireccionPaciente.IsReadOnly = false;
				colvarDireccionPaciente.DefaultSetting = @"";
				colvarDireccionPaciente.ForeignKeyTableName = "";
				schema.Columns.Add(colvarDireccionPaciente);
				
				TableSchema.TableColumn colvarNumeroLaboratorio = new TableSchema.TableColumn(schema);
				colvarNumeroLaboratorio.ColumnName = "numeroLaboratorio";
				colvarNumeroLaboratorio.DataType = DbType.String;
				colvarNumeroLaboratorio.MaxLength = 20;
				colvarNumeroLaboratorio.AutoIncrement = false;
				colvarNumeroLaboratorio.IsNullable = true;
				colvarNumeroLaboratorio.IsPrimaryKey = false;
				colvarNumeroLaboratorio.IsForeignKey = false;
				colvarNumeroLaboratorio.IsReadOnly = false;
				colvarNumeroLaboratorio.DefaultSetting = @"";
				colvarNumeroLaboratorio.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNumeroLaboratorio);
				
				TableSchema.TableColumn colvarIdCentroSaludOrigen = new TableSchema.TableColumn(schema);
				colvarIdCentroSaludOrigen.ColumnName = "idCentroSaludOrigen";
				colvarIdCentroSaludOrigen.DataType = DbType.Int32;
				colvarIdCentroSaludOrigen.MaxLength = 0;
				colvarIdCentroSaludOrigen.AutoIncrement = false;
				colvarIdCentroSaludOrigen.IsNullable = true;
				colvarIdCentroSaludOrigen.IsPrimaryKey = false;
				colvarIdCentroSaludOrigen.IsForeignKey = false;
				colvarIdCentroSaludOrigen.IsReadOnly = false;
				colvarIdCentroSaludOrigen.DefaultSetting = @"";
				colvarIdCentroSaludOrigen.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdCentroSaludOrigen);
				
				TableSchema.TableColumn colvarActivo = new TableSchema.TableColumn(schema);
				colvarActivo.ColumnName = "activo";
				colvarActivo.DataType = DbType.Boolean;
				colvarActivo.MaxLength = 0;
				colvarActivo.AutoIncrement = false;
				colvarActivo.IsNullable = true;
				colvarActivo.IsPrimaryKey = false;
				colvarActivo.IsForeignKey = false;
				colvarActivo.IsReadOnly = false;
				
						colvarActivo.DefaultSetting = @"((1))";
				colvarActivo.ForeignKeyTableName = "";
				schema.Columns.Add(colvarActivo);
				
				TableSchema.TableColumn colvarPasadoSips = new TableSchema.TableColumn(schema);
				colvarPasadoSips.ColumnName = "pasado_Sips";
				colvarPasadoSips.DataType = DbType.Boolean;
				colvarPasadoSips.MaxLength = 0;
				colvarPasadoSips.AutoIncrement = false;
				colvarPasadoSips.IsNullable = true;
				colvarPasadoSips.IsPrimaryKey = false;
				colvarPasadoSips.IsForeignKey = false;
				colvarPasadoSips.IsReadOnly = false;
				
						colvarPasadoSips.DefaultSetting = @"((0))";
				colvarPasadoSips.ForeignKeyTableName = "";
				schema.Columns.Add(colvarPasadoSips);
				
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
				
				TableSchema.TableColumn colvarDocumentoPaciente = new TableSchema.TableColumn(schema);
				colvarDocumentoPaciente.ColumnName = "documentoPaciente";
				colvarDocumentoPaciente.DataType = DbType.Int32;
				colvarDocumentoPaciente.MaxLength = 0;
				colvarDocumentoPaciente.AutoIncrement = false;
				colvarDocumentoPaciente.IsNullable = true;
				colvarDocumentoPaciente.IsPrimaryKey = false;
				colvarDocumentoPaciente.IsForeignKey = false;
				colvarDocumentoPaciente.IsReadOnly = false;
				
						colvarDocumentoPaciente.DefaultSetting = @"((0))";
				colvarDocumentoPaciente.ForeignKeyTableName = "";
				schema.Columns.Add(colvarDocumentoPaciente);
				
				TableSchema.TableColumn colvarTelefonoPaciente = new TableSchema.TableColumn(schema);
				colvarTelefonoPaciente.ColumnName = "telefonoPaciente";
				colvarTelefonoPaciente.DataType = DbType.AnsiString;
				colvarTelefonoPaciente.MaxLength = 100;
				colvarTelefonoPaciente.AutoIncrement = false;
				colvarTelefonoPaciente.IsNullable = true;
				colvarTelefonoPaciente.IsPrimaryKey = false;
				colvarTelefonoPaciente.IsForeignKey = false;
				colvarTelefonoPaciente.IsReadOnly = false;
				colvarTelefonoPaciente.DefaultSetting = @"";
				colvarTelefonoPaciente.ForeignKeyTableName = "";
				schema.Columns.Add(colvarTelefonoPaciente);
				
				TableSchema.TableColumn colvarDireccionNroPaciente = new TableSchema.TableColumn(schema);
				colvarDireccionNroPaciente.ColumnName = "direccionNroPaciente";
				colvarDireccionNroPaciente.DataType = DbType.AnsiString;
				colvarDireccionNroPaciente.MaxLength = 100;
				colvarDireccionNroPaciente.AutoIncrement = false;
				colvarDireccionNroPaciente.IsNullable = true;
				colvarDireccionNroPaciente.IsPrimaryKey = false;
				colvarDireccionNroPaciente.IsForeignKey = false;
				colvarDireccionNroPaciente.IsReadOnly = false;
				colvarDireccionNroPaciente.DefaultSetting = @"";
				colvarDireccionNroPaciente.ForeignKeyTableName = "";
				schema.Columns.Add(colvarDireccionNroPaciente);
				
				TableSchema.TableColumn colvarLocalidadPaciente = new TableSchema.TableColumn(schema);
				colvarLocalidadPaciente.ColumnName = "localidadPaciente";
				colvarLocalidadPaciente.DataType = DbType.AnsiString;
				colvarLocalidadPaciente.MaxLength = 100;
				colvarLocalidadPaciente.AutoIncrement = false;
				colvarLocalidadPaciente.IsNullable = true;
				colvarLocalidadPaciente.IsPrimaryKey = false;
				colvarLocalidadPaciente.IsForeignKey = false;
				colvarLocalidadPaciente.IsReadOnly = false;
				colvarLocalidadPaciente.DefaultSetting = @"";
				colvarLocalidadPaciente.ForeignKeyTableName = "";
				schema.Columns.Add(colvarLocalidadPaciente);
				
				TableSchema.TableColumn colvarIdCentroInforme = new TableSchema.TableColumn(schema);
				colvarIdCentroInforme.ColumnName = "idCentroInforme";
				colvarIdCentroInforme.DataType = DbType.Int32;
				colvarIdCentroInforme.MaxLength = 0;
				colvarIdCentroInforme.AutoIncrement = false;
				colvarIdCentroInforme.IsNullable = true;
				colvarIdCentroInforme.IsPrimaryKey = false;
				colvarIdCentroInforme.IsForeignKey = false;
				colvarIdCentroInforme.IsReadOnly = false;
				colvarIdCentroInforme.DefaultSetting = @"";
				colvarIdCentroInforme.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdCentroInforme);
				
				TableSchema.TableColumn colvarAsociaPap = new TableSchema.TableColumn(schema);
				colvarAsociaPap.ColumnName = "asociaPap";
				colvarAsociaPap.DataType = DbType.Boolean;
				colvarAsociaPap.MaxLength = 0;
				colvarAsociaPap.AutoIncrement = false;
				colvarAsociaPap.IsNullable = true;
				colvarAsociaPap.IsPrimaryKey = false;
				colvarAsociaPap.IsForeignKey = false;
				colvarAsociaPap.IsReadOnly = false;
				
						colvarAsociaPap.DefaultSetting = @"((0))";
				colvarAsociaPap.ForeignKeyTableName = "";
				schema.Columns.Add(colvarAsociaPap);
				
				TableSchema.TableColumn colvarObservaciones = new TableSchema.TableColumn(schema);
				colvarObservaciones.ColumnName = "observaciones";
				colvarObservaciones.DataType = DbType.AnsiString;
				colvarObservaciones.MaxLength = 200;
				colvarObservaciones.AutoIncrement = false;
				colvarObservaciones.IsNullable = true;
				colvarObservaciones.IsPrimaryKey = false;
				colvarObservaciones.IsForeignKey = false;
				colvarObservaciones.IsReadOnly = false;
				colvarObservaciones.DefaultSetting = @"";
				colvarObservaciones.ForeignKeyTableName = "";
				schema.Columns.Add(colvarObservaciones);
				
				TableSchema.TableColumn colvarNota = new TableSchema.TableColumn(schema);
				colvarNota.ColumnName = "nota";
				colvarNota.DataType = DbType.AnsiString;
				colvarNota.MaxLength = 100;
				colvarNota.AutoIncrement = false;
				colvarNota.IsNullable = true;
				colvarNota.IsPrimaryKey = false;
				colvarNota.IsForeignKey = false;
				colvarNota.IsReadOnly = false;
				colvarNota.DefaultSetting = @"";
				colvarNota.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNota);
				
				TableSchema.TableColumn colvarIdPrestacion = new TableSchema.TableColumn(schema);
				colvarIdPrestacion.ColumnName = "idPrestacion";
				colvarIdPrestacion.DataType = DbType.Int32;
				colvarIdPrestacion.MaxLength = 0;
				colvarIdPrestacion.AutoIncrement = false;
				colvarIdPrestacion.IsNullable = true;
				colvarIdPrestacion.IsPrimaryKey = false;
				colvarIdPrestacion.IsForeignKey = false;
				colvarIdPrestacion.IsReadOnly = false;
				colvarIdPrestacion.DefaultSetting = @"";
				colvarIdPrestacion.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdPrestacion);
				
				TableSchema.TableColumn colvarFechaNacimiento = new TableSchema.TableColumn(schema);
				colvarFechaNacimiento.ColumnName = "fechaNacimiento";
				colvarFechaNacimiento.DataType = DbType.DateTime;
				colvarFechaNacimiento.MaxLength = 0;
				colvarFechaNacimiento.AutoIncrement = false;
				colvarFechaNacimiento.IsNullable = true;
				colvarFechaNacimiento.IsPrimaryKey = false;
				colvarFechaNacimiento.IsForeignKey = false;
				colvarFechaNacimiento.IsReadOnly = false;
				colvarFechaNacimiento.DefaultSetting = @"";
				colvarFechaNacimiento.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFechaNacimiento);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["RisProvider"].AddSchema("TAM_HpvHP",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("Id")]
		[Bindable(true)]
		public int Id 
		{
			get { return GetColumnValue<int>(Columns.Id); }
			set { SetColumnValue(Columns.Id, value); }
		}
		  
		[XmlAttribute("IdCitologo")]
		[Bindable(true)]
		public int? IdCitologo 
		{
			get { return GetColumnValue<int?>(Columns.IdCitologo); }
			set { SetColumnValue(Columns.IdCitologo, value); }
		}
		  
		[XmlAttribute("IdMedicoSol")]
		[Bindable(true)]
		public int? IdMedicoSol 
		{
			get { return GetColumnValue<int?>(Columns.IdMedicoSol); }
			set { SetColumnValue(Columns.IdMedicoSol, value); }
		}
		  
		[XmlAttribute("IdTipoMuestra")]
		[Bindable(true)]
		public int? IdTipoMuestra 
		{
			get { return GetColumnValue<int?>(Columns.IdTipoMuestra); }
			set { SetColumnValue(Columns.IdTipoMuestra, value); }
		}
		  
		[XmlAttribute("FechaMuestra")]
		[Bindable(true)]
		public DateTime? FechaMuestra 
		{
			get { return GetColumnValue<DateTime?>(Columns.FechaMuestra); }
			set { SetColumnValue(Columns.FechaMuestra, value); }
		}
		  
		[XmlAttribute("FechaInforme")]
		[Bindable(true)]
		public DateTime? FechaInforme 
		{
			get { return GetColumnValue<DateTime?>(Columns.FechaInforme); }
			set { SetColumnValue(Columns.FechaInforme, value); }
		}
		  
		[XmlAttribute("IdResultado")]
		[Bindable(true)]
		public int? IdResultado 
		{
			get { return GetColumnValue<int?>(Columns.IdResultado); }
			set { SetColumnValue(Columns.IdResultado, value); }
		}
		  
		[XmlAttribute("FechaRecepcion")]
		[Bindable(true)]
		public DateTime? FechaRecepcion 
		{
			get { return GetColumnValue<DateTime?>(Columns.FechaRecepcion); }
			set { SetColumnValue(Columns.FechaRecepcion, value); }
		}
		  
		[XmlAttribute("IdPaciente")]
		[Bindable(true)]
		public int? IdPaciente 
		{
			get { return GetColumnValue<int?>(Columns.IdPaciente); }
			set { SetColumnValue(Columns.IdPaciente, value); }
		}
		  
		[XmlAttribute("NombrePaciente")]
		[Bindable(true)]
		public string NombrePaciente 
		{
			get { return GetColumnValue<string>(Columns.NombrePaciente); }
			set { SetColumnValue(Columns.NombrePaciente, value); }
		}
		  
		[XmlAttribute("ApellidoPaciente")]
		[Bindable(true)]
		public string ApellidoPaciente 
		{
			get { return GetColumnValue<string>(Columns.ApellidoPaciente); }
			set { SetColumnValue(Columns.ApellidoPaciente, value); }
		}
		  
		[XmlAttribute("DireccionPaciente")]
		[Bindable(true)]
		public string DireccionPaciente 
		{
			get { return GetColumnValue<string>(Columns.DireccionPaciente); }
			set { SetColumnValue(Columns.DireccionPaciente, value); }
		}
		  
		[XmlAttribute("NumeroLaboratorio")]
		[Bindable(true)]
		public string NumeroLaboratorio 
		{
			get { return GetColumnValue<string>(Columns.NumeroLaboratorio); }
			set { SetColumnValue(Columns.NumeroLaboratorio, value); }
		}
		  
		[XmlAttribute("IdCentroSaludOrigen")]
		[Bindable(true)]
		public int? IdCentroSaludOrigen 
		{
			get { return GetColumnValue<int?>(Columns.IdCentroSaludOrigen); }
			set { SetColumnValue(Columns.IdCentroSaludOrigen, value); }
		}
		  
		[XmlAttribute("Activo")]
		[Bindable(true)]
		public bool? Activo 
		{
			get { return GetColumnValue<bool?>(Columns.Activo); }
			set { SetColumnValue(Columns.Activo, value); }
		}
		  
		[XmlAttribute("PasadoSips")]
		[Bindable(true)]
		public bool? PasadoSips 
		{
			get { return GetColumnValue<bool?>(Columns.PasadoSips); }
			set { SetColumnValue(Columns.PasadoSips, value); }
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
		  
		[XmlAttribute("DocumentoPaciente")]
		[Bindable(true)]
		public int? DocumentoPaciente 
		{
			get { return GetColumnValue<int?>(Columns.DocumentoPaciente); }
			set { SetColumnValue(Columns.DocumentoPaciente, value); }
		}
		  
		[XmlAttribute("TelefonoPaciente")]
		[Bindable(true)]
		public string TelefonoPaciente 
		{
			get { return GetColumnValue<string>(Columns.TelefonoPaciente); }
			set { SetColumnValue(Columns.TelefonoPaciente, value); }
		}
		  
		[XmlAttribute("DireccionNroPaciente")]
		[Bindable(true)]
		public string DireccionNroPaciente 
		{
			get { return GetColumnValue<string>(Columns.DireccionNroPaciente); }
			set { SetColumnValue(Columns.DireccionNroPaciente, value); }
		}
		  
		[XmlAttribute("LocalidadPaciente")]
		[Bindable(true)]
		public string LocalidadPaciente 
		{
			get { return GetColumnValue<string>(Columns.LocalidadPaciente); }
			set { SetColumnValue(Columns.LocalidadPaciente, value); }
		}
		  
		[XmlAttribute("IdCentroInforme")]
		[Bindable(true)]
		public int? IdCentroInforme 
		{
			get { return GetColumnValue<int?>(Columns.IdCentroInforme); }
			set { SetColumnValue(Columns.IdCentroInforme, value); }
		}
		  
		[XmlAttribute("AsociaPap")]
		[Bindable(true)]
		public bool? AsociaPap 
		{
			get { return GetColumnValue<bool?>(Columns.AsociaPap); }
			set { SetColumnValue(Columns.AsociaPap, value); }
		}
		  
		[XmlAttribute("Observaciones")]
		[Bindable(true)]
		public string Observaciones 
		{
			get { return GetColumnValue<string>(Columns.Observaciones); }
			set { SetColumnValue(Columns.Observaciones, value); }
		}
		  
		[XmlAttribute("Nota")]
		[Bindable(true)]
		public string Nota 
		{
			get { return GetColumnValue<string>(Columns.Nota); }
			set { SetColumnValue(Columns.Nota, value); }
		}
		  
		[XmlAttribute("IdPrestacion")]
		[Bindable(true)]
		public int? IdPrestacion 
		{
			get { return GetColumnValue<int?>(Columns.IdPrestacion); }
			set { SetColumnValue(Columns.IdPrestacion, value); }
		}
		  
		[XmlAttribute("FechaNacimiento")]
		[Bindable(true)]
		public DateTime? FechaNacimiento 
		{
			get { return GetColumnValue<DateTime?>(Columns.FechaNacimiento); }
			set { SetColumnValue(Columns.FechaNacimiento, value); }
		}
		
		#endregion
		
		
			
		
		#region ForeignKey Properties
		
		/// <summary>
		/// Returns a TamTipoMuestra ActiveRecord object related to this TamHpvHP
		/// 
		/// </summary>
		public DalRis.TamTipoMuestra TamTipoMuestra
		{
			get { return DalRis.TamTipoMuestra.FetchByID(this.IdTipoMuestra); }
			set { SetColumnValue("idTipoMuestra", value.IdTipoMuestra); }
		}
		
		
		/// <summary>
		/// Returns a TamResultadoHpv ActiveRecord object related to this TamHpvHP
		/// 
		/// </summary>
		public DalRis.TamResultadoHpv TamResultadoHpv
		{
			get { return DalRis.TamResultadoHpv.FetchByID(this.IdResultado); }
			set { SetColumnValue("idResultado", value.IdResultadoHpv); }
		}
		
		
		#endregion
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(int? varIdCitologo,int? varIdMedicoSol,int? varIdTipoMuestra,DateTime? varFechaMuestra,DateTime? varFechaInforme,int? varIdResultado,DateTime? varFechaRecepcion,int? varIdPaciente,string varNombrePaciente,string varApellidoPaciente,string varDireccionPaciente,string varNumeroLaboratorio,int? varIdCentroSaludOrigen,bool? varActivo,bool? varPasadoSips,string varCreatedBy,DateTime varCreatedOn,string varModifiedBy,DateTime varModifiedOn,int? varDocumentoPaciente,string varTelefonoPaciente,string varDireccionNroPaciente,string varLocalidadPaciente,int? varIdCentroInforme,bool? varAsociaPap,string varObservaciones,string varNota,int? varIdPrestacion,DateTime? varFechaNacimiento)
		{
			TamHpvHP item = new TamHpvHP();
			
			item.IdCitologo = varIdCitologo;
			
			item.IdMedicoSol = varIdMedicoSol;
			
			item.IdTipoMuestra = varIdTipoMuestra;
			
			item.FechaMuestra = varFechaMuestra;
			
			item.FechaInforme = varFechaInforme;
			
			item.IdResultado = varIdResultado;
			
			item.FechaRecepcion = varFechaRecepcion;
			
			item.IdPaciente = varIdPaciente;
			
			item.NombrePaciente = varNombrePaciente;
			
			item.ApellidoPaciente = varApellidoPaciente;
			
			item.DireccionPaciente = varDireccionPaciente;
			
			item.NumeroLaboratorio = varNumeroLaboratorio;
			
			item.IdCentroSaludOrigen = varIdCentroSaludOrigen;
			
			item.Activo = varActivo;
			
			item.PasadoSips = varPasadoSips;
			
			item.CreatedBy = varCreatedBy;
			
			item.CreatedOn = varCreatedOn;
			
			item.ModifiedBy = varModifiedBy;
			
			item.ModifiedOn = varModifiedOn;
			
			item.DocumentoPaciente = varDocumentoPaciente;
			
			item.TelefonoPaciente = varTelefonoPaciente;
			
			item.DireccionNroPaciente = varDireccionNroPaciente;
			
			item.LocalidadPaciente = varLocalidadPaciente;
			
			item.IdCentroInforme = varIdCentroInforme;
			
			item.AsociaPap = varAsociaPap;
			
			item.Observaciones = varObservaciones;
			
			item.Nota = varNota;
			
			item.IdPrestacion = varIdPrestacion;
			
			item.FechaNacimiento = varFechaNacimiento;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varId,int? varIdCitologo,int? varIdMedicoSol,int? varIdTipoMuestra,DateTime? varFechaMuestra,DateTime? varFechaInforme,int? varIdResultado,DateTime? varFechaRecepcion,int? varIdPaciente,string varNombrePaciente,string varApellidoPaciente,string varDireccionPaciente,string varNumeroLaboratorio,int? varIdCentroSaludOrigen,bool? varActivo,bool? varPasadoSips,string varCreatedBy,DateTime varCreatedOn,string varModifiedBy,DateTime varModifiedOn,int? varDocumentoPaciente,string varTelefonoPaciente,string varDireccionNroPaciente,string varLocalidadPaciente,int? varIdCentroInforme,bool? varAsociaPap,string varObservaciones,string varNota,int? varIdPrestacion,DateTime? varFechaNacimiento)
		{
			TamHpvHP item = new TamHpvHP();
			
				item.Id = varId;
			
				item.IdCitologo = varIdCitologo;
			
				item.IdMedicoSol = varIdMedicoSol;
			
				item.IdTipoMuestra = varIdTipoMuestra;
			
				item.FechaMuestra = varFechaMuestra;
			
				item.FechaInforme = varFechaInforme;
			
				item.IdResultado = varIdResultado;
			
				item.FechaRecepcion = varFechaRecepcion;
			
				item.IdPaciente = varIdPaciente;
			
				item.NombrePaciente = varNombrePaciente;
			
				item.ApellidoPaciente = varApellidoPaciente;
			
				item.DireccionPaciente = varDireccionPaciente;
			
				item.NumeroLaboratorio = varNumeroLaboratorio;
			
				item.IdCentroSaludOrigen = varIdCentroSaludOrigen;
			
				item.Activo = varActivo;
			
				item.PasadoSips = varPasadoSips;
			
				item.CreatedBy = varCreatedBy;
			
				item.CreatedOn = varCreatedOn;
			
				item.ModifiedBy = varModifiedBy;
			
				item.ModifiedOn = varModifiedOn;
			
				item.DocumentoPaciente = varDocumentoPaciente;
			
				item.TelefonoPaciente = varTelefonoPaciente;
			
				item.DireccionNroPaciente = varDireccionNroPaciente;
			
				item.LocalidadPaciente = varLocalidadPaciente;
			
				item.IdCentroInforme = varIdCentroInforme;
			
				item.AsociaPap = varAsociaPap;
			
				item.Observaciones = varObservaciones;
			
				item.Nota = varNota;
			
				item.IdPrestacion = varIdPrestacion;
			
				item.FechaNacimiento = varFechaNacimiento;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn IdColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn IdCitologoColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn IdMedicoSolColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn IdTipoMuestraColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn FechaMuestraColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn FechaInformeColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        public static TableSchema.TableColumn IdResultadoColumn
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        public static TableSchema.TableColumn FechaRecepcionColumn
        {
            get { return Schema.Columns[7]; }
        }
        
        
        
        public static TableSchema.TableColumn IdPacienteColumn
        {
            get { return Schema.Columns[8]; }
        }
        
        
        
        public static TableSchema.TableColumn NombrePacienteColumn
        {
            get { return Schema.Columns[9]; }
        }
        
        
        
        public static TableSchema.TableColumn ApellidoPacienteColumn
        {
            get { return Schema.Columns[10]; }
        }
        
        
        
        public static TableSchema.TableColumn DireccionPacienteColumn
        {
            get { return Schema.Columns[11]; }
        }
        
        
        
        public static TableSchema.TableColumn NumeroLaboratorioColumn
        {
            get { return Schema.Columns[12]; }
        }
        
        
        
        public static TableSchema.TableColumn IdCentroSaludOrigenColumn
        {
            get { return Schema.Columns[13]; }
        }
        
        
        
        public static TableSchema.TableColumn ActivoColumn
        {
            get { return Schema.Columns[14]; }
        }
        
        
        
        public static TableSchema.TableColumn PasadoSipsColumn
        {
            get { return Schema.Columns[15]; }
        }
        
        
        
        public static TableSchema.TableColumn CreatedByColumn
        {
            get { return Schema.Columns[16]; }
        }
        
        
        
        public static TableSchema.TableColumn CreatedOnColumn
        {
            get { return Schema.Columns[17]; }
        }
        
        
        
        public static TableSchema.TableColumn ModifiedByColumn
        {
            get { return Schema.Columns[18]; }
        }
        
        
        
        public static TableSchema.TableColumn ModifiedOnColumn
        {
            get { return Schema.Columns[19]; }
        }
        
        
        
        public static TableSchema.TableColumn DocumentoPacienteColumn
        {
            get { return Schema.Columns[20]; }
        }
        
        
        
        public static TableSchema.TableColumn TelefonoPacienteColumn
        {
            get { return Schema.Columns[21]; }
        }
        
        
        
        public static TableSchema.TableColumn DireccionNroPacienteColumn
        {
            get { return Schema.Columns[22]; }
        }
        
        
        
        public static TableSchema.TableColumn LocalidadPacienteColumn
        {
            get { return Schema.Columns[23]; }
        }
        
        
        
        public static TableSchema.TableColumn IdCentroInformeColumn
        {
            get { return Schema.Columns[24]; }
        }
        
        
        
        public static TableSchema.TableColumn AsociaPapColumn
        {
            get { return Schema.Columns[25]; }
        }
        
        
        
        public static TableSchema.TableColumn ObservacionesColumn
        {
            get { return Schema.Columns[26]; }
        }
        
        
        
        public static TableSchema.TableColumn NotaColumn
        {
            get { return Schema.Columns[27]; }
        }
        
        
        
        public static TableSchema.TableColumn IdPrestacionColumn
        {
            get { return Schema.Columns[28]; }
        }
        
        
        
        public static TableSchema.TableColumn FechaNacimientoColumn
        {
            get { return Schema.Columns[29]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string Id = @"Id";
			 public static string IdCitologo = @"idCitologo";
			 public static string IdMedicoSol = @"idMedicoSol";
			 public static string IdTipoMuestra = @"idTipoMuestra";
			 public static string FechaMuestra = @"fechaMuestra";
			 public static string FechaInforme = @"fechaInforme";
			 public static string IdResultado = @"idResultado";
			 public static string FechaRecepcion = @"fechaRecepcion";
			 public static string IdPaciente = @"idPaciente";
			 public static string NombrePaciente = @"nombrePaciente";
			 public static string ApellidoPaciente = @"apellidoPaciente";
			 public static string DireccionPaciente = @"direccionPaciente";
			 public static string NumeroLaboratorio = @"numeroLaboratorio";
			 public static string IdCentroSaludOrigen = @"idCentroSaludOrigen";
			 public static string Activo = @"activo";
			 public static string PasadoSips = @"pasado_Sips";
			 public static string CreatedBy = @"CreatedBy";
			 public static string CreatedOn = @"CreatedOn";
			 public static string ModifiedBy = @"ModifiedBy";
			 public static string ModifiedOn = @"ModifiedOn";
			 public static string DocumentoPaciente = @"documentoPaciente";
			 public static string TelefonoPaciente = @"telefonoPaciente";
			 public static string DireccionNroPaciente = @"direccionNroPaciente";
			 public static string LocalidadPaciente = @"localidadPaciente";
			 public static string IdCentroInforme = @"idCentroInforme";
			 public static string AsociaPap = @"asociaPap";
			 public static string Observaciones = @"observaciones";
			 public static string Nota = @"nota";
			 public static string IdPrestacion = @"idPrestacion";
			 public static string FechaNacimiento = @"fechaNacimiento";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
