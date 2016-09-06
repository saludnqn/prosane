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
	/// Strongly-typed collection for the TamPap class.
	/// </summary>
    [Serializable]
	public partial class TamPapCollection : ActiveList<TamPap, TamPapCollection>
	{	   
		public TamPapCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>TamPapCollection</returns>
		public TamPapCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                TamPap o = this[i];
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
	/// This is an ActiveRecord class which wraps the TAM_Pap table.
	/// </summary>
	[Serializable]
	public partial class TamPap : ActiveRecord<TamPap>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public TamPap()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public TamPap(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public TamPap(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public TamPap(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("TAM_Pap", TableType.Table, DataService.GetInstance("RisProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarIdPap = new TableSchema.TableColumn(schema);
				colvarIdPap.ColumnName = "idPap";
				colvarIdPap.DataType = DbType.Int32;
				colvarIdPap.MaxLength = 0;
				colvarIdPap.AutoIncrement = true;
				colvarIdPap.IsNullable = false;
				colvarIdPap.IsPrimaryKey = true;
				colvarIdPap.IsForeignKey = false;
				colvarIdPap.IsReadOnly = false;
				colvarIdPap.DefaultSetting = @"";
				colvarIdPap.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdPap);
				
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
				
				TableSchema.TableColumn colvarFecha = new TableSchema.TableColumn(schema);
				colvarFecha.ColumnName = "fecha";
				colvarFecha.DataType = DbType.DateTime;
				colvarFecha.MaxLength = 0;
				colvarFecha.AutoIncrement = false;
				colvarFecha.IsNullable = false;
				colvarFecha.IsPrimaryKey = false;
				colvarFecha.IsForeignKey = false;
				colvarFecha.IsReadOnly = false;
				colvarFecha.DefaultSetting = @"";
				colvarFecha.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFecha);
				
				TableSchema.TableColumn colvarCervixSatisfactorio = new TableSchema.TableColumn(schema);
				colvarCervixSatisfactorio.ColumnName = "cervixSatisfactorio";
				colvarCervixSatisfactorio.DataType = DbType.Boolean;
				colvarCervixSatisfactorio.MaxLength = 0;
				colvarCervixSatisfactorio.AutoIncrement = false;
				colvarCervixSatisfactorio.IsNullable = false;
				colvarCervixSatisfactorio.IsPrimaryKey = false;
				colvarCervixSatisfactorio.IsForeignKey = false;
				colvarCervixSatisfactorio.IsReadOnly = false;
				
						colvarCervixSatisfactorio.DefaultSetting = @"((0))";
				colvarCervixSatisfactorio.ForeignKeyTableName = "";
				schema.Columns.Add(colvarCervixSatisfactorio);
				
				TableSchema.TableColumn colvarTratHormonalReemplazo = new TableSchema.TableColumn(schema);
				colvarTratHormonalReemplazo.ColumnName = "tratHormonalReemplazo";
				colvarTratHormonalReemplazo.DataType = DbType.Boolean;
				colvarTratHormonalReemplazo.MaxLength = 0;
				colvarTratHormonalReemplazo.AutoIncrement = false;
				colvarTratHormonalReemplazo.IsNullable = false;
				colvarTratHormonalReemplazo.IsPrimaryKey = false;
				colvarTratHormonalReemplazo.IsForeignKey = false;
				colvarTratHormonalReemplazo.IsReadOnly = false;
				
						colvarTratHormonalReemplazo.DefaultSetting = @"((0))";
				colvarTratHormonalReemplazo.ForeignKeyTableName = "";
				schema.Columns.Add(colvarTratHormonalReemplazo);
				
				TableSchema.TableColumn colvarIdTipoCirugia = new TableSchema.TableColumn(schema);
				colvarIdTipoCirugia.ColumnName = "idTipoCirugia";
				colvarIdTipoCirugia.DataType = DbType.Int32;
				colvarIdTipoCirugia.MaxLength = 0;
				colvarIdTipoCirugia.AutoIncrement = false;
				colvarIdTipoCirugia.IsNullable = false;
				colvarIdTipoCirugia.IsPrimaryKey = false;
				colvarIdTipoCirugia.IsForeignKey = true;
				colvarIdTipoCirugia.IsReadOnly = false;
				
						colvarIdTipoCirugia.DefaultSetting = @"((0))";
				
					colvarIdTipoCirugia.ForeignKeyTableName = "TAM_TipoCirugia";
				schema.Columns.Add(colvarIdTipoCirugia);
				
				TableSchema.TableColumn colvarTratRadiante = new TableSchema.TableColumn(schema);
				colvarTratRadiante.ColumnName = "tratRadiante";
				colvarTratRadiante.DataType = DbType.Boolean;
				colvarTratRadiante.MaxLength = 0;
				colvarTratRadiante.AutoIncrement = false;
				colvarTratRadiante.IsNullable = false;
				colvarTratRadiante.IsPrimaryKey = false;
				colvarTratRadiante.IsForeignKey = false;
				colvarTratRadiante.IsReadOnly = false;
				
						colvarTratRadiante.DefaultSetting = @"((0))";
				colvarTratRadiante.ForeignKeyTableName = "";
				schema.Columns.Add(colvarTratRadiante);
				
				TableSchema.TableColumn colvarIdMetodoAnticonceptvo = new TableSchema.TableColumn(schema);
				colvarIdMetodoAnticonceptvo.ColumnName = "idMetodoAnticonceptvo";
				colvarIdMetodoAnticonceptvo.DataType = DbType.Int32;
				colvarIdMetodoAnticonceptvo.MaxLength = 0;
				colvarIdMetodoAnticonceptvo.AutoIncrement = false;
				colvarIdMetodoAnticonceptvo.IsNullable = false;
				colvarIdMetodoAnticonceptvo.IsPrimaryKey = false;
				colvarIdMetodoAnticonceptvo.IsForeignKey = true;
				colvarIdMetodoAnticonceptvo.IsReadOnly = false;
				
						colvarIdMetodoAnticonceptvo.DefaultSetting = @"((0))";
				
					colvarIdMetodoAnticonceptvo.ForeignKeyTableName = "TAM_MetodoAnticonceptivo";
				schema.Columns.Add(colvarIdMetodoAnticonceptvo);
				
				TableSchema.TableColumn colvarQuimioterapia = new TableSchema.TableColumn(schema);
				colvarQuimioterapia.ColumnName = "quimioterapia";
				colvarQuimioterapia.DataType = DbType.Boolean;
				colvarQuimioterapia.MaxLength = 0;
				colvarQuimioterapia.AutoIncrement = false;
				colvarQuimioterapia.IsNullable = false;
				colvarQuimioterapia.IsPrimaryKey = false;
				colvarQuimioterapia.IsForeignKey = false;
				colvarQuimioterapia.IsReadOnly = false;
				
						colvarQuimioterapia.DefaultSetting = @"((0))";
				colvarQuimioterapia.ForeignKeyTableName = "";
				schema.Columns.Add(colvarQuimioterapia);
				
				TableSchema.TableColumn colvarParidad = new TableSchema.TableColumn(schema);
				colvarParidad.ColumnName = "paridad";
				colvarParidad.DataType = DbType.Int32;
				colvarParidad.MaxLength = 0;
				colvarParidad.AutoIncrement = false;
				colvarParidad.IsNullable = false;
				colvarParidad.IsPrimaryKey = false;
				colvarParidad.IsForeignKey = false;
				colvarParidad.IsReadOnly = false;
				
						colvarParidad.DefaultSetting = @"((0))";
				colvarParidad.ForeignKeyTableName = "";
				schema.Columns.Add(colvarParidad);
				
				TableSchema.TableColumn colvarParidadInformacion = new TableSchema.TableColumn(schema);
				colvarParidadInformacion.ColumnName = "paridadInformacion";
				colvarParidadInformacion.DataType = DbType.Boolean;
				colvarParidadInformacion.MaxLength = 0;
				colvarParidadInformacion.AutoIncrement = false;
				colvarParidadInformacion.IsNullable = false;
				colvarParidadInformacion.IsPrimaryKey = false;
				colvarParidadInformacion.IsForeignKey = false;
				colvarParidadInformacion.IsReadOnly = false;
				
						colvarParidadInformacion.DefaultSetting = @"((0))";
				colvarParidadInformacion.ForeignKeyTableName = "";
				schema.Columns.Add(colvarParidadInformacion);
				
				TableSchema.TableColumn colvarFechaFum = new TableSchema.TableColumn(schema);
				colvarFechaFum.ColumnName = "fechaFum";
				colvarFechaFum.DataType = DbType.DateTime;
				colvarFechaFum.MaxLength = 0;
				colvarFechaFum.AutoIncrement = false;
				colvarFechaFum.IsNullable = false;
				colvarFechaFum.IsPrimaryKey = false;
				colvarFechaFum.IsForeignKey = false;
				colvarFechaFum.IsReadOnly = false;
				colvarFechaFum.DefaultSetting = @"";
				colvarFechaFum.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFechaFum);
				
				TableSchema.TableColumn colvarMenopausia = new TableSchema.TableColumn(schema);
				colvarMenopausia.ColumnName = "menopausia";
				colvarMenopausia.DataType = DbType.Boolean;
				colvarMenopausia.MaxLength = 0;
				colvarMenopausia.AutoIncrement = false;
				colvarMenopausia.IsNullable = false;
				colvarMenopausia.IsPrimaryKey = false;
				colvarMenopausia.IsForeignKey = false;
				colvarMenopausia.IsReadOnly = false;
				
						colvarMenopausia.DefaultSetting = @"((0))";
				colvarMenopausia.ForeignKeyTableName = "";
				schema.Columns.Add(colvarMenopausia);
				
				TableSchema.TableColumn colvarEmbarazoActual = new TableSchema.TableColumn(schema);
				colvarEmbarazoActual.ColumnName = "embarazoActual";
				colvarEmbarazoActual.DataType = DbType.Boolean;
				colvarEmbarazoActual.MaxLength = 0;
				colvarEmbarazoActual.AutoIncrement = false;
				colvarEmbarazoActual.IsNullable = false;
				colvarEmbarazoActual.IsPrimaryKey = false;
				colvarEmbarazoActual.IsForeignKey = false;
				colvarEmbarazoActual.IsReadOnly = false;
				
						colvarEmbarazoActual.DefaultSetting = @"((0))";
				colvarEmbarazoActual.ForeignKeyTableName = "";
				schema.Columns.Add(colvarEmbarazoActual);
				
				TableSchema.TableColumn colvarLactancia = new TableSchema.TableColumn(schema);
				colvarLactancia.ColumnName = "lactancia";
				colvarLactancia.DataType = DbType.Boolean;
				colvarLactancia.MaxLength = 0;
				colvarLactancia.AutoIncrement = false;
				colvarLactancia.IsNullable = false;
				colvarLactancia.IsPrimaryKey = false;
				colvarLactancia.IsForeignKey = false;
				colvarLactancia.IsReadOnly = false;
				
						colvarLactancia.DefaultSetting = @"((0))";
				colvarLactancia.ForeignKeyTableName = "";
				schema.Columns.Add(colvarLactancia);
				
				TableSchema.TableColumn colvarIdTipoPapPrevio = new TableSchema.TableColumn(schema);
				colvarIdTipoPapPrevio.ColumnName = "idTipoPapPrevio";
				colvarIdTipoPapPrevio.DataType = DbType.Int32;
				colvarIdTipoPapPrevio.MaxLength = 0;
				colvarIdTipoPapPrevio.AutoIncrement = false;
				colvarIdTipoPapPrevio.IsNullable = false;
				colvarIdTipoPapPrevio.IsPrimaryKey = false;
				colvarIdTipoPapPrevio.IsForeignKey = true;
				colvarIdTipoPapPrevio.IsReadOnly = false;
				
						colvarIdTipoPapPrevio.DefaultSetting = @"((0))";
				
					colvarIdTipoPapPrevio.ForeignKeyTableName = "TAM_TipoPapPrevio";
				schema.Columns.Add(colvarIdTipoPapPrevio);
				
				TableSchema.TableColumn colvarIdTipoResultado = new TableSchema.TableColumn(schema);
				colvarIdTipoResultado.ColumnName = "idTipoResultado";
				colvarIdTipoResultado.DataType = DbType.Int32;
				colvarIdTipoResultado.MaxLength = 0;
				colvarIdTipoResultado.AutoIncrement = false;
				colvarIdTipoResultado.IsNullable = false;
				colvarIdTipoResultado.IsPrimaryKey = false;
				colvarIdTipoResultado.IsForeignKey = true;
				colvarIdTipoResultado.IsReadOnly = false;
				
						colvarIdTipoResultado.DefaultSetting = @"((0))";
				
					colvarIdTipoResultado.ForeignKeyTableName = "TAM_ResultadoPap";
				schema.Columns.Add(colvarIdTipoResultado);
				
				TableSchema.TableColumn colvarIdTipoMuestra = new TableSchema.TableColumn(schema);
				colvarIdTipoMuestra.ColumnName = "idTipoMuestra";
				colvarIdTipoMuestra.DataType = DbType.Int32;
				colvarIdTipoMuestra.MaxLength = 0;
				colvarIdTipoMuestra.AutoIncrement = false;
				colvarIdTipoMuestra.IsNullable = false;
				colvarIdTipoMuestra.IsPrimaryKey = false;
				colvarIdTipoMuestra.IsForeignKey = true;
				colvarIdTipoMuestra.IsReadOnly = false;
				
						colvarIdTipoMuestra.DefaultSetting = @"((0))";
				
					colvarIdTipoMuestra.ForeignKeyTableName = "TAM_TipoMuestra";
				schema.Columns.Add(colvarIdTipoMuestra);
				
				TableSchema.TableColumn colvarFechaMuestra = new TableSchema.TableColumn(schema);
				colvarFechaMuestra.ColumnName = "fechaMuestra";
				colvarFechaMuestra.DataType = DbType.DateTime;
				colvarFechaMuestra.MaxLength = 0;
				colvarFechaMuestra.AutoIncrement = false;
				colvarFechaMuestra.IsNullable = false;
				colvarFechaMuestra.IsPrimaryKey = false;
				colvarFechaMuestra.IsForeignKey = false;
				colvarFechaMuestra.IsReadOnly = false;
				colvarFechaMuestra.DefaultSetting = @"";
				colvarFechaMuestra.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFechaMuestra);
				
				TableSchema.TableColumn colvarIdProfesionalMuestra = new TableSchema.TableColumn(schema);
				colvarIdProfesionalMuestra.ColumnName = "idProfesionalMuestra";
				colvarIdProfesionalMuestra.DataType = DbType.Int32;
				colvarIdProfesionalMuestra.MaxLength = 0;
				colvarIdProfesionalMuestra.AutoIncrement = false;
				colvarIdProfesionalMuestra.IsNullable = false;
				colvarIdProfesionalMuestra.IsPrimaryKey = false;
				colvarIdProfesionalMuestra.IsForeignKey = true;
				colvarIdProfesionalMuestra.IsReadOnly = false;
				
						colvarIdProfesionalMuestra.DefaultSetting = @"((0))";
				
					colvarIdProfesionalMuestra.ForeignKeyTableName = "Sys_Profesional";
				schema.Columns.Add(colvarIdProfesionalMuestra);
				
				TableSchema.TableColumn colvarIdEfectorMuestra = new TableSchema.TableColumn(schema);
				colvarIdEfectorMuestra.ColumnName = "idEfectorMuestra";
				colvarIdEfectorMuestra.DataType = DbType.Int32;
				colvarIdEfectorMuestra.MaxLength = 0;
				colvarIdEfectorMuestra.AutoIncrement = false;
				colvarIdEfectorMuestra.IsNullable = false;
				colvarIdEfectorMuestra.IsPrimaryKey = false;
				colvarIdEfectorMuestra.IsForeignKey = true;
				colvarIdEfectorMuestra.IsReadOnly = false;
				
						colvarIdEfectorMuestra.DefaultSetting = @"((0))";
				
					colvarIdEfectorMuestra.ForeignKeyTableName = "Sys_Efector";
				schema.Columns.Add(colvarIdEfectorMuestra);
				
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
				
				TableSchema.TableColumn colvarIdCalidadMuestra = new TableSchema.TableColumn(schema);
				colvarIdCalidadMuestra.ColumnName = "idCalidadMuestra";
				colvarIdCalidadMuestra.DataType = DbType.Int32;
				colvarIdCalidadMuestra.MaxLength = 0;
				colvarIdCalidadMuestra.AutoIncrement = false;
				colvarIdCalidadMuestra.IsNullable = false;
				colvarIdCalidadMuestra.IsPrimaryKey = false;
				colvarIdCalidadMuestra.IsForeignKey = true;
				colvarIdCalidadMuestra.IsReadOnly = false;
				
						colvarIdCalidadMuestra.DefaultSetting = @"((0))";
				
					colvarIdCalidadMuestra.ForeignKeyTableName = "TAM_CalidadMuestra";
				schema.Columns.Add(colvarIdCalidadMuestra);
				
				TableSchema.TableColumn colvarIdCelulasEscamosas = new TableSchema.TableColumn(schema);
				colvarIdCelulasEscamosas.ColumnName = "idCelulasEscamosas";
				colvarIdCelulasEscamosas.DataType = DbType.Int32;
				colvarIdCelulasEscamosas.MaxLength = 0;
				colvarIdCelulasEscamosas.AutoIncrement = false;
				colvarIdCelulasEscamosas.IsNullable = false;
				colvarIdCelulasEscamosas.IsPrimaryKey = false;
				colvarIdCelulasEscamosas.IsForeignKey = true;
				colvarIdCelulasEscamosas.IsReadOnly = false;
				
						colvarIdCelulasEscamosas.DefaultSetting = @"((0))";
				
					colvarIdCelulasEscamosas.ForeignKeyTableName = "TAM_CelulasEscamosas";
				schema.Columns.Add(colvarIdCelulasEscamosas);
				
				TableSchema.TableColumn colvarIdCelulasGLandulares = new TableSchema.TableColumn(schema);
				colvarIdCelulasGLandulares.ColumnName = "idCelulasGLandulares";
				colvarIdCelulasGLandulares.DataType = DbType.Int32;
				colvarIdCelulasGLandulares.MaxLength = 0;
				colvarIdCelulasGLandulares.AutoIncrement = false;
				colvarIdCelulasGLandulares.IsNullable = false;
				colvarIdCelulasGLandulares.IsPrimaryKey = false;
				colvarIdCelulasGLandulares.IsForeignKey = true;
				colvarIdCelulasGLandulares.IsReadOnly = false;
				
						colvarIdCelulasGLandulares.DefaultSetting = @"((0))";
				
					colvarIdCelulasGLandulares.ForeignKeyTableName = "TAM_CelulasGlandulares";
				schema.Columns.Add(colvarIdCelulasGLandulares);
				
				TableSchema.TableColumn colvarIdOtrosHallazgos = new TableSchema.TableColumn(schema);
				colvarIdOtrosHallazgos.ColumnName = "idOtrosHallazgos";
				colvarIdOtrosHallazgos.DataType = DbType.Int32;
				colvarIdOtrosHallazgos.MaxLength = 0;
				colvarIdOtrosHallazgos.AutoIncrement = false;
				colvarIdOtrosHallazgos.IsNullable = false;
				colvarIdOtrosHallazgos.IsPrimaryKey = false;
				colvarIdOtrosHallazgos.IsForeignKey = true;
				colvarIdOtrosHallazgos.IsReadOnly = false;
				
						colvarIdOtrosHallazgos.DefaultSetting = @"((0))";
				
					colvarIdOtrosHallazgos.ForeignKeyTableName = "TAM_OtrosHallazgos";
				schema.Columns.Add(colvarIdOtrosHallazgos);
				
				TableSchema.TableColumn colvarIdObservacionPap = new TableSchema.TableColumn(schema);
				colvarIdObservacionPap.ColumnName = "idObservacionPap";
				colvarIdObservacionPap.DataType = DbType.Int32;
				colvarIdObservacionPap.MaxLength = 0;
				colvarIdObservacionPap.AutoIncrement = false;
				colvarIdObservacionPap.IsNullable = false;
				colvarIdObservacionPap.IsPrimaryKey = false;
				colvarIdObservacionPap.IsForeignKey = true;
				colvarIdObservacionPap.IsReadOnly = false;
				
						colvarIdObservacionPap.DefaultSetting = @"((0))";
				
					colvarIdObservacionPap.ForeignKeyTableName = "TAM_ObservacionPap";
				schema.Columns.Add(colvarIdObservacionPap);
				
				TableSchema.TableColumn colvarIdMicrorganismo = new TableSchema.TableColumn(schema);
				colvarIdMicrorganismo.ColumnName = "idMicrorganismo";
				colvarIdMicrorganismo.DataType = DbType.Int32;
				colvarIdMicrorganismo.MaxLength = 0;
				colvarIdMicrorganismo.AutoIncrement = false;
				colvarIdMicrorganismo.IsNullable = false;
				colvarIdMicrorganismo.IsPrimaryKey = false;
				colvarIdMicrorganismo.IsForeignKey = true;
				colvarIdMicrorganismo.IsReadOnly = false;
				
						colvarIdMicrorganismo.DefaultSetting = @"((0))";
				
					colvarIdMicrorganismo.ForeignKeyTableName = "TAM_Microrganismo";
				schema.Columns.Add(colvarIdMicrorganismo);
				
				TableSchema.TableColumn colvarObservaciones = new TableSchema.TableColumn(schema);
				colvarObservaciones.ColumnName = "Observaciones";
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
				
				TableSchema.TableColumn colvarEntregado = new TableSchema.TableColumn(schema);
				colvarEntregado.ColumnName = "entregado";
				colvarEntregado.DataType = DbType.Boolean;
				colvarEntregado.MaxLength = 0;
				colvarEntregado.AutoIncrement = false;
				colvarEntregado.IsNullable = false;
				colvarEntregado.IsPrimaryKey = false;
				colvarEntregado.IsForeignKey = false;
				colvarEntregado.IsReadOnly = false;
				
						colvarEntregado.DefaultSetting = @"((0))";
				colvarEntregado.ForeignKeyTableName = "";
				schema.Columns.Add(colvarEntregado);
				
				TableSchema.TableColumn colvarFechaEntrega = new TableSchema.TableColumn(schema);
				colvarFechaEntrega.ColumnName = "fechaEntrega";
				colvarFechaEntrega.DataType = DbType.DateTime;
				colvarFechaEntrega.MaxLength = 0;
				colvarFechaEntrega.AutoIncrement = false;
				colvarFechaEntrega.IsNullable = false;
				colvarFechaEntrega.IsPrimaryKey = false;
				colvarFechaEntrega.IsForeignKey = false;
				colvarFechaEntrega.IsReadOnly = false;
				colvarFechaEntrega.DefaultSetting = @"";
				colvarFechaEntrega.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFechaEntrega);
				
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
				
				TableSchema.TableColumn colvarIdTipoTratamientoLocal = new TableSchema.TableColumn(schema);
				colvarIdTipoTratamientoLocal.ColumnName = "idTipoTratamientoLocal";
				colvarIdTipoTratamientoLocal.DataType = DbType.Int32;
				colvarIdTipoTratamientoLocal.MaxLength = 0;
				colvarIdTipoTratamientoLocal.AutoIncrement = false;
				colvarIdTipoTratamientoLocal.IsNullable = false;
				colvarIdTipoTratamientoLocal.IsPrimaryKey = false;
				colvarIdTipoTratamientoLocal.IsForeignKey = true;
				colvarIdTipoTratamientoLocal.IsReadOnly = false;
				
						colvarIdTipoTratamientoLocal.DefaultSetting = @"((0))";
				
					colvarIdTipoTratamientoLocal.ForeignKeyTableName = "TAM_TipoTratamientoPap";
				schema.Columns.Add(colvarIdTipoTratamientoLocal);
				
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
				DataService.Providers["RisProvider"].AddSchema("TAM_Pap",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("IdPap")]
		[Bindable(true)]
		public int IdPap 
		{
			get { return GetColumnValue<int>(Columns.IdPap); }
			set { SetColumnValue(Columns.IdPap, value); }
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
		  
		[XmlAttribute("Fecha")]
		[Bindable(true)]
		public DateTime Fecha 
		{
			get { return GetColumnValue<DateTime>(Columns.Fecha); }
			set { SetColumnValue(Columns.Fecha, value); }
		}
		  
		[XmlAttribute("CervixSatisfactorio")]
		[Bindable(true)]
		public bool CervixSatisfactorio 
		{
			get { return GetColumnValue<bool>(Columns.CervixSatisfactorio); }
			set { SetColumnValue(Columns.CervixSatisfactorio, value); }
		}
		  
		[XmlAttribute("TratHormonalReemplazo")]
		[Bindable(true)]
		public bool TratHormonalReemplazo 
		{
			get { return GetColumnValue<bool>(Columns.TratHormonalReemplazo); }
			set { SetColumnValue(Columns.TratHormonalReemplazo, value); }
		}
		  
		[XmlAttribute("IdTipoCirugia")]
		[Bindable(true)]
		public int IdTipoCirugia 
		{
			get { return GetColumnValue<int>(Columns.IdTipoCirugia); }
			set { SetColumnValue(Columns.IdTipoCirugia, value); }
		}
		  
		[XmlAttribute("TratRadiante")]
		[Bindable(true)]
		public bool TratRadiante 
		{
			get { return GetColumnValue<bool>(Columns.TratRadiante); }
			set { SetColumnValue(Columns.TratRadiante, value); }
		}
		  
		[XmlAttribute("IdMetodoAnticonceptvo")]
		[Bindable(true)]
		public int IdMetodoAnticonceptvo 
		{
			get { return GetColumnValue<int>(Columns.IdMetodoAnticonceptvo); }
			set { SetColumnValue(Columns.IdMetodoAnticonceptvo, value); }
		}
		  
		[XmlAttribute("Quimioterapia")]
		[Bindable(true)]
		public bool Quimioterapia 
		{
			get { return GetColumnValue<bool>(Columns.Quimioterapia); }
			set { SetColumnValue(Columns.Quimioterapia, value); }
		}
		  
		[XmlAttribute("Paridad")]
		[Bindable(true)]
		public int Paridad 
		{
			get { return GetColumnValue<int>(Columns.Paridad); }
			set { SetColumnValue(Columns.Paridad, value); }
		}
		  
		[XmlAttribute("ParidadInformacion")]
		[Bindable(true)]
		public bool ParidadInformacion 
		{
			get { return GetColumnValue<bool>(Columns.ParidadInformacion); }
			set { SetColumnValue(Columns.ParidadInformacion, value); }
		}
		  
		[XmlAttribute("FechaFum")]
		[Bindable(true)]
		public DateTime FechaFum 
		{
			get { return GetColumnValue<DateTime>(Columns.FechaFum); }
			set { SetColumnValue(Columns.FechaFum, value); }
		}
		  
		[XmlAttribute("Menopausia")]
		[Bindable(true)]
		public bool Menopausia 
		{
			get { return GetColumnValue<bool>(Columns.Menopausia); }
			set { SetColumnValue(Columns.Menopausia, value); }
		}
		  
		[XmlAttribute("EmbarazoActual")]
		[Bindable(true)]
		public bool EmbarazoActual 
		{
			get { return GetColumnValue<bool>(Columns.EmbarazoActual); }
			set { SetColumnValue(Columns.EmbarazoActual, value); }
		}
		  
		[XmlAttribute("Lactancia")]
		[Bindable(true)]
		public bool Lactancia 
		{
			get { return GetColumnValue<bool>(Columns.Lactancia); }
			set { SetColumnValue(Columns.Lactancia, value); }
		}
		  
		[XmlAttribute("IdTipoPapPrevio")]
		[Bindable(true)]
		public int IdTipoPapPrevio 
		{
			get { return GetColumnValue<int>(Columns.IdTipoPapPrevio); }
			set { SetColumnValue(Columns.IdTipoPapPrevio, value); }
		}
		  
		[XmlAttribute("IdTipoResultado")]
		[Bindable(true)]
		public int IdTipoResultado 
		{
			get { return GetColumnValue<int>(Columns.IdTipoResultado); }
			set { SetColumnValue(Columns.IdTipoResultado, value); }
		}
		  
		[XmlAttribute("IdTipoMuestra")]
		[Bindable(true)]
		public int IdTipoMuestra 
		{
			get { return GetColumnValue<int>(Columns.IdTipoMuestra); }
			set { SetColumnValue(Columns.IdTipoMuestra, value); }
		}
		  
		[XmlAttribute("FechaMuestra")]
		[Bindable(true)]
		public DateTime FechaMuestra 
		{
			get { return GetColumnValue<DateTime>(Columns.FechaMuestra); }
			set { SetColumnValue(Columns.FechaMuestra, value); }
		}
		  
		[XmlAttribute("IdProfesionalMuestra")]
		[Bindable(true)]
		public int IdProfesionalMuestra 
		{
			get { return GetColumnValue<int>(Columns.IdProfesionalMuestra); }
			set { SetColumnValue(Columns.IdProfesionalMuestra, value); }
		}
		  
		[XmlAttribute("IdEfectorMuestra")]
		[Bindable(true)]
		public int IdEfectorMuestra 
		{
			get { return GetColumnValue<int>(Columns.IdEfectorMuestra); }
			set { SetColumnValue(Columns.IdEfectorMuestra, value); }
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
		  
		[XmlAttribute("IdCalidadMuestra")]
		[Bindable(true)]
		public int IdCalidadMuestra 
		{
			get { return GetColumnValue<int>(Columns.IdCalidadMuestra); }
			set { SetColumnValue(Columns.IdCalidadMuestra, value); }
		}
		  
		[XmlAttribute("IdCelulasEscamosas")]
		[Bindable(true)]
		public int IdCelulasEscamosas 
		{
			get { return GetColumnValue<int>(Columns.IdCelulasEscamosas); }
			set { SetColumnValue(Columns.IdCelulasEscamosas, value); }
		}
		  
		[XmlAttribute("IdCelulasGLandulares")]
		[Bindable(true)]
		public int IdCelulasGLandulares 
		{
			get { return GetColumnValue<int>(Columns.IdCelulasGLandulares); }
			set { SetColumnValue(Columns.IdCelulasGLandulares, value); }
		}
		  
		[XmlAttribute("IdOtrosHallazgos")]
		[Bindable(true)]
		public int IdOtrosHallazgos 
		{
			get { return GetColumnValue<int>(Columns.IdOtrosHallazgos); }
			set { SetColumnValue(Columns.IdOtrosHallazgos, value); }
		}
		  
		[XmlAttribute("IdObservacionPap")]
		[Bindable(true)]
		public int IdObservacionPap 
		{
			get { return GetColumnValue<int>(Columns.IdObservacionPap); }
			set { SetColumnValue(Columns.IdObservacionPap, value); }
		}
		  
		[XmlAttribute("IdMicrorganismo")]
		[Bindable(true)]
		public int IdMicrorganismo 
		{
			get { return GetColumnValue<int>(Columns.IdMicrorganismo); }
			set { SetColumnValue(Columns.IdMicrorganismo, value); }
		}
		  
		[XmlAttribute("Observaciones")]
		[Bindable(true)]
		public string Observaciones 
		{
			get { return GetColumnValue<string>(Columns.Observaciones); }
			set { SetColumnValue(Columns.Observaciones, value); }
		}
		  
		[XmlAttribute("Entregado")]
		[Bindable(true)]
		public bool Entregado 
		{
			get { return GetColumnValue<bool>(Columns.Entregado); }
			set { SetColumnValue(Columns.Entregado, value); }
		}
		  
		[XmlAttribute("FechaEntrega")]
		[Bindable(true)]
		public DateTime FechaEntrega 
		{
			get { return GetColumnValue<DateTime>(Columns.FechaEntrega); }
			set { SetColumnValue(Columns.FechaEntrega, value); }
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
		  
		[XmlAttribute("IdTipoTratamientoLocal")]
		[Bindable(true)]
		public int IdTipoTratamientoLocal 
		{
			get { return GetColumnValue<int>(Columns.IdTipoTratamientoLocal); }
			set { SetColumnValue(Columns.IdTipoTratamientoLocal, value); }
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
		/// Returns a SysEfector ActiveRecord object related to this TamPap
		/// 
		/// </summary>
		public DalRis.SysEfector SysEfector
		{
			get { return DalRis.SysEfector.FetchByID(this.IdEfectorLaboratorio); }
			set { SetColumnValue("idEfectorLaboratorio", value.IdEfector); }
		}
		
		
		/// <summary>
		/// Returns a SysEfector ActiveRecord object related to this TamPap
		/// 
		/// </summary>
		public DalRis.SysEfector SysEfectorToIdEfectorMuestra
		{
			get { return DalRis.SysEfector.FetchByID(this.IdEfectorMuestra); }
			set { SetColumnValue("idEfectorMuestra", value.IdEfector); }
		}
		
		
		/// <summary>
		/// Returns a TamTipoCirugium ActiveRecord object related to this TamPap
		/// 
		/// </summary>
		public DalRis.TamTipoCirugium TamTipoCirugium
		{
			get { return DalRis.TamTipoCirugium.FetchByID(this.IdTipoCirugia); }
			set { SetColumnValue("idTipoCirugia", value.IdTipoCirugia); }
		}
		
		
		/// <summary>
		/// Returns a TamTipoMuestra ActiveRecord object related to this TamPap
		/// 
		/// </summary>
		public DalRis.TamTipoMuestra TamTipoMuestra
		{
			get { return DalRis.TamTipoMuestra.FetchByID(this.IdTipoMuestra); }
			set { SetColumnValue("idTipoMuestra", value.IdTipoMuestra); }
		}
		
		
		/// <summary>
		/// Returns a TamMicrorganismo ActiveRecord object related to this TamPap
		/// 
		/// </summary>
		public DalRis.TamMicrorganismo TamMicrorganismo
		{
			get { return DalRis.TamMicrorganismo.FetchByID(this.IdMicrorganismo); }
			set { SetColumnValue("idMicrorganismo", value.IdMicrorganismo); }
		}
		
		
		/// <summary>
		/// Returns a TamObservacionPap ActiveRecord object related to this TamPap
		/// 
		/// </summary>
		public DalRis.TamObservacionPap TamObservacionPap
		{
			get { return DalRis.TamObservacionPap.FetchByID(this.IdObservacionPap); }
			set { SetColumnValue("idObservacionPap", value.IdObservacionPap); }
		}
		
		
		/// <summary>
		/// Returns a TamOtrosHallazgo ActiveRecord object related to this TamPap
		/// 
		/// </summary>
		public DalRis.TamOtrosHallazgo TamOtrosHallazgo
		{
			get { return DalRis.TamOtrosHallazgo.FetchByID(this.IdOtrosHallazgos); }
			set { SetColumnValue("idOtrosHallazgos", value.IdOtrosHallazgos); }
		}
		
		
		/// <summary>
		/// Returns a TamCelulasGlandulare ActiveRecord object related to this TamPap
		/// 
		/// </summary>
		public DalRis.TamCelulasGlandulare TamCelulasGlandulare
		{
			get { return DalRis.TamCelulasGlandulare.FetchByID(this.IdCelulasGLandulares); }
			set { SetColumnValue("idCelulasGLandulares", value.IdCelulasGlandulares); }
		}
		
		
		/// <summary>
		/// Returns a TamCalidadMuestra ActiveRecord object related to this TamPap
		/// 
		/// </summary>
		public DalRis.TamCalidadMuestra TamCalidadMuestra
		{
			get { return DalRis.TamCalidadMuestra.FetchByID(this.IdCalidadMuestra); }
			set { SetColumnValue("idCalidadMuestra", value.IdCalidadMuestra); }
		}
		
		
		/// <summary>
		/// Returns a TamTipoPapPrevio ActiveRecord object related to this TamPap
		/// 
		/// </summary>
		public DalRis.TamTipoPapPrevio TamTipoPapPrevio
		{
			get { return DalRis.TamTipoPapPrevio.FetchByID(this.IdTipoPapPrevio); }
			set { SetColumnValue("idTipoPapPrevio", value.IdTipoPapPrevio); }
		}
		
		
		/// <summary>
		/// Returns a TamResultadoPap ActiveRecord object related to this TamPap
		/// 
		/// </summary>
		public DalRis.TamResultadoPap TamResultadoPap
		{
			get { return DalRis.TamResultadoPap.FetchByID(this.IdTipoResultado); }
			set { SetColumnValue("idTipoResultado", value.IdResultadoPap); }
		}
		
		
		/// <summary>
		/// Returns a TamRegistro ActiveRecord object related to this TamPap
		/// 
		/// </summary>
		public DalRis.TamRegistro TamRegistro
		{
			get { return DalRis.TamRegistro.FetchByID(this.IdTam); }
			set { SetColumnValue("idTam", value.IdTam); }
		}
		
		
		/// <summary>
		/// Returns a SysProfesional ActiveRecord object related to this TamPap
		/// 
		/// </summary>
		public DalRis.SysProfesional SysProfesional
		{
			get { return DalRis.SysProfesional.FetchByID(this.IdProfesionalInforma); }
			set { SetColumnValue("idProfesionalInforma", value.IdProfesional); }
		}
		
		
		/// <summary>
		/// Returns a SysProfesional ActiveRecord object related to this TamPap
		/// 
		/// </summary>
		public DalRis.SysProfesional SysProfesionalToIdProfesionalMuestra
		{
			get { return DalRis.SysProfesional.FetchByID(this.IdProfesionalMuestra); }
			set { SetColumnValue("idProfesionalMuestra", value.IdProfesional); }
		}
		
		
		/// <summary>
		/// Returns a TamTipoTratamientoPap ActiveRecord object related to this TamPap
		/// 
		/// </summary>
		public DalRis.TamTipoTratamientoPap TamTipoTratamientoPap
		{
			get { return DalRis.TamTipoTratamientoPap.FetchByID(this.IdTipoTratamientoLocal); }
			set { SetColumnValue("idTipoTratamientoLocal", value.IdTipoTratamientoPap); }
		}
		
		
		/// <summary>
		/// Returns a TamMetodoAnticonceptivo ActiveRecord object related to this TamPap
		/// 
		/// </summary>
		public DalRis.TamMetodoAnticonceptivo TamMetodoAnticonceptivo
		{
			get { return DalRis.TamMetodoAnticonceptivo.FetchByID(this.IdMetodoAnticonceptvo); }
			set { SetColumnValue("idMetodoAnticonceptvo", value.IdMetodoAnticonceptivo); }
		}
		
		
		/// <summary>
		/// Returns a TamCelulasEscamosa ActiveRecord object related to this TamPap
		/// 
		/// </summary>
		public DalRis.TamCelulasEscamosa TamCelulasEscamosa
		{
			get { return DalRis.TamCelulasEscamosa.FetchByID(this.IdCelulasEscamosas); }
			set { SetColumnValue("idCelulasEscamosas", value.IdCelulasEscamosas); }
		}
		
		
		#endregion
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(int varIdTam,int varIdPaciente,int varEdad,DateTime varFecha,bool varCervixSatisfactorio,bool varTratHormonalReemplazo,int varIdTipoCirugia,bool varTratRadiante,int varIdMetodoAnticonceptvo,bool varQuimioterapia,int varParidad,bool varParidadInformacion,DateTime varFechaFum,bool varMenopausia,bool varEmbarazoActual,bool varLactancia,int varIdTipoPapPrevio,int varIdTipoResultado,int varIdTipoMuestra,DateTime varFechaMuestra,int varIdProfesionalMuestra,int varIdEfectorMuestra,DateTime varFechaRecepcion,string varIngresoLetra,int varIngresoNro,int varIngresoNro2,int varIdEfectorLaboratorio,DateTime varFechaInforme,int varIdProfesionalInforma,int varIdCalidadMuestra,int varIdCelulasEscamosas,int varIdCelulasGLandulares,int varIdOtrosHallazgos,int varIdObservacionPap,int varIdMicrorganismo,string varObservaciones,bool varEntregado,DateTime varFechaEntrega,string varCreatedBy,DateTime varCreatedOn,string varModifiedBy,DateTime varModifiedOn,int varIdTipoTratamientoLocal,string varNumeroProtocolo,bool varActivo)
		{
			TamPap item = new TamPap();
			
			item.IdTam = varIdTam;
			
			item.IdPaciente = varIdPaciente;
			
			item.Edad = varEdad;
			
			item.Fecha = varFecha;
			
			item.CervixSatisfactorio = varCervixSatisfactorio;
			
			item.TratHormonalReemplazo = varTratHormonalReemplazo;
			
			item.IdTipoCirugia = varIdTipoCirugia;
			
			item.TratRadiante = varTratRadiante;
			
			item.IdMetodoAnticonceptvo = varIdMetodoAnticonceptvo;
			
			item.Quimioterapia = varQuimioterapia;
			
			item.Paridad = varParidad;
			
			item.ParidadInformacion = varParidadInformacion;
			
			item.FechaFum = varFechaFum;
			
			item.Menopausia = varMenopausia;
			
			item.EmbarazoActual = varEmbarazoActual;
			
			item.Lactancia = varLactancia;
			
			item.IdTipoPapPrevio = varIdTipoPapPrevio;
			
			item.IdTipoResultado = varIdTipoResultado;
			
			item.IdTipoMuestra = varIdTipoMuestra;
			
			item.FechaMuestra = varFechaMuestra;
			
			item.IdProfesionalMuestra = varIdProfesionalMuestra;
			
			item.IdEfectorMuestra = varIdEfectorMuestra;
			
			item.FechaRecepcion = varFechaRecepcion;
			
			item.IngresoLetra = varIngresoLetra;
			
			item.IngresoNro = varIngresoNro;
			
			item.IngresoNro2 = varIngresoNro2;
			
			item.IdEfectorLaboratorio = varIdEfectorLaboratorio;
			
			item.FechaInforme = varFechaInforme;
			
			item.IdProfesionalInforma = varIdProfesionalInforma;
			
			item.IdCalidadMuestra = varIdCalidadMuestra;
			
			item.IdCelulasEscamosas = varIdCelulasEscamosas;
			
			item.IdCelulasGLandulares = varIdCelulasGLandulares;
			
			item.IdOtrosHallazgos = varIdOtrosHallazgos;
			
			item.IdObservacionPap = varIdObservacionPap;
			
			item.IdMicrorganismo = varIdMicrorganismo;
			
			item.Observaciones = varObservaciones;
			
			item.Entregado = varEntregado;
			
			item.FechaEntrega = varFechaEntrega;
			
			item.CreatedBy = varCreatedBy;
			
			item.CreatedOn = varCreatedOn;
			
			item.ModifiedBy = varModifiedBy;
			
			item.ModifiedOn = varModifiedOn;
			
			item.IdTipoTratamientoLocal = varIdTipoTratamientoLocal;
			
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
		public static void Update(int varIdPap,int varIdTam,int varIdPaciente,int varEdad,DateTime varFecha,bool varCervixSatisfactorio,bool varTratHormonalReemplazo,int varIdTipoCirugia,bool varTratRadiante,int varIdMetodoAnticonceptvo,bool varQuimioterapia,int varParidad,bool varParidadInformacion,DateTime varFechaFum,bool varMenopausia,bool varEmbarazoActual,bool varLactancia,int varIdTipoPapPrevio,int varIdTipoResultado,int varIdTipoMuestra,DateTime varFechaMuestra,int varIdProfesionalMuestra,int varIdEfectorMuestra,DateTime varFechaRecepcion,string varIngresoLetra,int varIngresoNro,int varIngresoNro2,int varIdEfectorLaboratorio,DateTime varFechaInforme,int varIdProfesionalInforma,int varIdCalidadMuestra,int varIdCelulasEscamosas,int varIdCelulasGLandulares,int varIdOtrosHallazgos,int varIdObservacionPap,int varIdMicrorganismo,string varObservaciones,bool varEntregado,DateTime varFechaEntrega,string varCreatedBy,DateTime varCreatedOn,string varModifiedBy,DateTime varModifiedOn,int varIdTipoTratamientoLocal,string varNumeroProtocolo,bool varActivo)
		{
			TamPap item = new TamPap();
			
				item.IdPap = varIdPap;
			
				item.IdTam = varIdTam;
			
				item.IdPaciente = varIdPaciente;
			
				item.Edad = varEdad;
			
				item.Fecha = varFecha;
			
				item.CervixSatisfactorio = varCervixSatisfactorio;
			
				item.TratHormonalReemplazo = varTratHormonalReemplazo;
			
				item.IdTipoCirugia = varIdTipoCirugia;
			
				item.TratRadiante = varTratRadiante;
			
				item.IdMetodoAnticonceptvo = varIdMetodoAnticonceptvo;
			
				item.Quimioterapia = varQuimioterapia;
			
				item.Paridad = varParidad;
			
				item.ParidadInformacion = varParidadInformacion;
			
				item.FechaFum = varFechaFum;
			
				item.Menopausia = varMenopausia;
			
				item.EmbarazoActual = varEmbarazoActual;
			
				item.Lactancia = varLactancia;
			
				item.IdTipoPapPrevio = varIdTipoPapPrevio;
			
				item.IdTipoResultado = varIdTipoResultado;
			
				item.IdTipoMuestra = varIdTipoMuestra;
			
				item.FechaMuestra = varFechaMuestra;
			
				item.IdProfesionalMuestra = varIdProfesionalMuestra;
			
				item.IdEfectorMuestra = varIdEfectorMuestra;
			
				item.FechaRecepcion = varFechaRecepcion;
			
				item.IngresoLetra = varIngresoLetra;
			
				item.IngresoNro = varIngresoNro;
			
				item.IngresoNro2 = varIngresoNro2;
			
				item.IdEfectorLaboratorio = varIdEfectorLaboratorio;
			
				item.FechaInforme = varFechaInforme;
			
				item.IdProfesionalInforma = varIdProfesionalInforma;
			
				item.IdCalidadMuestra = varIdCalidadMuestra;
			
				item.IdCelulasEscamosas = varIdCelulasEscamosas;
			
				item.IdCelulasGLandulares = varIdCelulasGLandulares;
			
				item.IdOtrosHallazgos = varIdOtrosHallazgos;
			
				item.IdObservacionPap = varIdObservacionPap;
			
				item.IdMicrorganismo = varIdMicrorganismo;
			
				item.Observaciones = varObservaciones;
			
				item.Entregado = varEntregado;
			
				item.FechaEntrega = varFechaEntrega;
			
				item.CreatedBy = varCreatedBy;
			
				item.CreatedOn = varCreatedOn;
			
				item.ModifiedBy = varModifiedBy;
			
				item.ModifiedOn = varModifiedOn;
			
				item.IdTipoTratamientoLocal = varIdTipoTratamientoLocal;
			
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
        
        
        public static TableSchema.TableColumn IdPapColumn
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
        
        
        
        public static TableSchema.TableColumn FechaColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn CervixSatisfactorioColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        public static TableSchema.TableColumn TratHormonalReemplazoColumn
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        public static TableSchema.TableColumn IdTipoCirugiaColumn
        {
            get { return Schema.Columns[7]; }
        }
        
        
        
        public static TableSchema.TableColumn TratRadianteColumn
        {
            get { return Schema.Columns[8]; }
        }
        
        
        
        public static TableSchema.TableColumn IdMetodoAnticonceptvoColumn
        {
            get { return Schema.Columns[9]; }
        }
        
        
        
        public static TableSchema.TableColumn QuimioterapiaColumn
        {
            get { return Schema.Columns[10]; }
        }
        
        
        
        public static TableSchema.TableColumn ParidadColumn
        {
            get { return Schema.Columns[11]; }
        }
        
        
        
        public static TableSchema.TableColumn ParidadInformacionColumn
        {
            get { return Schema.Columns[12]; }
        }
        
        
        
        public static TableSchema.TableColumn FechaFumColumn
        {
            get { return Schema.Columns[13]; }
        }
        
        
        
        public static TableSchema.TableColumn MenopausiaColumn
        {
            get { return Schema.Columns[14]; }
        }
        
        
        
        public static TableSchema.TableColumn EmbarazoActualColumn
        {
            get { return Schema.Columns[15]; }
        }
        
        
        
        public static TableSchema.TableColumn LactanciaColumn
        {
            get { return Schema.Columns[16]; }
        }
        
        
        
        public static TableSchema.TableColumn IdTipoPapPrevioColumn
        {
            get { return Schema.Columns[17]; }
        }
        
        
        
        public static TableSchema.TableColumn IdTipoResultadoColumn
        {
            get { return Schema.Columns[18]; }
        }
        
        
        
        public static TableSchema.TableColumn IdTipoMuestraColumn
        {
            get { return Schema.Columns[19]; }
        }
        
        
        
        public static TableSchema.TableColumn FechaMuestraColumn
        {
            get { return Schema.Columns[20]; }
        }
        
        
        
        public static TableSchema.TableColumn IdProfesionalMuestraColumn
        {
            get { return Schema.Columns[21]; }
        }
        
        
        
        public static TableSchema.TableColumn IdEfectorMuestraColumn
        {
            get { return Schema.Columns[22]; }
        }
        
        
        
        public static TableSchema.TableColumn FechaRecepcionColumn
        {
            get { return Schema.Columns[23]; }
        }
        
        
        
        public static TableSchema.TableColumn IngresoLetraColumn
        {
            get { return Schema.Columns[24]; }
        }
        
        
        
        public static TableSchema.TableColumn IngresoNroColumn
        {
            get { return Schema.Columns[25]; }
        }
        
        
        
        public static TableSchema.TableColumn IngresoNro2Column
        {
            get { return Schema.Columns[26]; }
        }
        
        
        
        public static TableSchema.TableColumn IdEfectorLaboratorioColumn
        {
            get { return Schema.Columns[27]; }
        }
        
        
        
        public static TableSchema.TableColumn FechaInformeColumn
        {
            get { return Schema.Columns[28]; }
        }
        
        
        
        public static TableSchema.TableColumn IdProfesionalInformaColumn
        {
            get { return Schema.Columns[29]; }
        }
        
        
        
        public static TableSchema.TableColumn IdCalidadMuestraColumn
        {
            get { return Schema.Columns[30]; }
        }
        
        
        
        public static TableSchema.TableColumn IdCelulasEscamosasColumn
        {
            get { return Schema.Columns[31]; }
        }
        
        
        
        public static TableSchema.TableColumn IdCelulasGLandularesColumn
        {
            get { return Schema.Columns[32]; }
        }
        
        
        
        public static TableSchema.TableColumn IdOtrosHallazgosColumn
        {
            get { return Schema.Columns[33]; }
        }
        
        
        
        public static TableSchema.TableColumn IdObservacionPapColumn
        {
            get { return Schema.Columns[34]; }
        }
        
        
        
        public static TableSchema.TableColumn IdMicrorganismoColumn
        {
            get { return Schema.Columns[35]; }
        }
        
        
        
        public static TableSchema.TableColumn ObservacionesColumn
        {
            get { return Schema.Columns[36]; }
        }
        
        
        
        public static TableSchema.TableColumn EntregadoColumn
        {
            get { return Schema.Columns[37]; }
        }
        
        
        
        public static TableSchema.TableColumn FechaEntregaColumn
        {
            get { return Schema.Columns[38]; }
        }
        
        
        
        public static TableSchema.TableColumn CreatedByColumn
        {
            get { return Schema.Columns[39]; }
        }
        
        
        
        public static TableSchema.TableColumn CreatedOnColumn
        {
            get { return Schema.Columns[40]; }
        }
        
        
        
        public static TableSchema.TableColumn ModifiedByColumn
        {
            get { return Schema.Columns[41]; }
        }
        
        
        
        public static TableSchema.TableColumn ModifiedOnColumn
        {
            get { return Schema.Columns[42]; }
        }
        
        
        
        public static TableSchema.TableColumn IdTipoTratamientoLocalColumn
        {
            get { return Schema.Columns[43]; }
        }
        
        
        
        public static TableSchema.TableColumn NumeroProtocoloColumn
        {
            get { return Schema.Columns[44]; }
        }
        
        
        
        public static TableSchema.TableColumn ActivoColumn
        {
            get { return Schema.Columns[45]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string IdPap = @"idPap";
			 public static string IdTam = @"idTam";
			 public static string IdPaciente = @"idPaciente";
			 public static string Edad = @"edad";
			 public static string Fecha = @"fecha";
			 public static string CervixSatisfactorio = @"cervixSatisfactorio";
			 public static string TratHormonalReemplazo = @"tratHormonalReemplazo";
			 public static string IdTipoCirugia = @"idTipoCirugia";
			 public static string TratRadiante = @"tratRadiante";
			 public static string IdMetodoAnticonceptvo = @"idMetodoAnticonceptvo";
			 public static string Quimioterapia = @"quimioterapia";
			 public static string Paridad = @"paridad";
			 public static string ParidadInformacion = @"paridadInformacion";
			 public static string FechaFum = @"fechaFum";
			 public static string Menopausia = @"menopausia";
			 public static string EmbarazoActual = @"embarazoActual";
			 public static string Lactancia = @"lactancia";
			 public static string IdTipoPapPrevio = @"idTipoPapPrevio";
			 public static string IdTipoResultado = @"idTipoResultado";
			 public static string IdTipoMuestra = @"idTipoMuestra";
			 public static string FechaMuestra = @"fechaMuestra";
			 public static string IdProfesionalMuestra = @"idProfesionalMuestra";
			 public static string IdEfectorMuestra = @"idEfectorMuestra";
			 public static string FechaRecepcion = @"fechaRecepcion";
			 public static string IngresoLetra = @"ingresoLetra";
			 public static string IngresoNro = @"ingresoNro";
			 public static string IngresoNro2 = @"ingresoNro2";
			 public static string IdEfectorLaboratorio = @"idEfectorLaboratorio";
			 public static string FechaInforme = @"fechaInforme";
			 public static string IdProfesionalInforma = @"idProfesionalInforma";
			 public static string IdCalidadMuestra = @"idCalidadMuestra";
			 public static string IdCelulasEscamosas = @"idCelulasEscamosas";
			 public static string IdCelulasGLandulares = @"idCelulasGLandulares";
			 public static string IdOtrosHallazgos = @"idOtrosHallazgos";
			 public static string IdObservacionPap = @"idObservacionPap";
			 public static string IdMicrorganismo = @"idMicrorganismo";
			 public static string Observaciones = @"Observaciones";
			 public static string Entregado = @"entregado";
			 public static string FechaEntrega = @"fechaEntrega";
			 public static string CreatedBy = @"CreatedBy";
			 public static string CreatedOn = @"CreatedOn";
			 public static string ModifiedBy = @"ModifiedBy";
			 public static string ModifiedOn = @"ModifiedOn";
			 public static string IdTipoTratamientoLocal = @"idTipoTratamientoLocal";
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
