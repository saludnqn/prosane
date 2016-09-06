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
	/// Strongly-typed collection for the TamPapm class.
	/// </summary>
    [Serializable]
	public partial class TamPapmCollection : ActiveList<TamPapm, TamPapmCollection>
	{	   
		public TamPapmCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>TamPapmCollection</returns>
		public TamPapmCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                TamPapm o = this[i];
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
	/// This is an ActiveRecord class which wraps the TAM_PAPM table.
	/// </summary>
	[Serializable]
	public partial class TamPapm : ActiveRecord<TamPapm>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public TamPapm()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public TamPapm(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public TamPapm(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public TamPapm(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("TAM_PAPM", TableType.Table, DataService.GetInstance("RisProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarIdPaps = new TableSchema.TableColumn(schema);
				colvarIdPaps.ColumnName = "idPaps";
				colvarIdPaps.DataType = DbType.Int32;
				colvarIdPaps.MaxLength = 0;
				colvarIdPaps.AutoIncrement = true;
				colvarIdPaps.IsNullable = false;
				colvarIdPaps.IsPrimaryKey = true;
				colvarIdPaps.IsForeignKey = false;
				colvarIdPaps.IsReadOnly = false;
				colvarIdPaps.DefaultSetting = @"";
				colvarIdPaps.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdPaps);
				
				TableSchema.TableColumn colvarIdTipoPapPrevio = new TableSchema.TableColumn(schema);
				colvarIdTipoPapPrevio.ColumnName = "id_TipoPapPrevio";
				colvarIdTipoPapPrevio.DataType = DbType.Int32;
				colvarIdTipoPapPrevio.MaxLength = 0;
				colvarIdTipoPapPrevio.AutoIncrement = false;
				colvarIdTipoPapPrevio.IsNullable = true;
				colvarIdTipoPapPrevio.IsPrimaryKey = false;
				colvarIdTipoPapPrevio.IsForeignKey = false;
				colvarIdTipoPapPrevio.IsReadOnly = false;
				colvarIdTipoPapPrevio.DefaultSetting = @"";
				colvarIdTipoPapPrevio.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdTipoPapPrevio);
				
				TableSchema.TableColumn colvarIdResultadoPapPrevio = new TableSchema.TableColumn(schema);
				colvarIdResultadoPapPrevio.ColumnName = "Id_resultado_PAP_Previo";
				colvarIdResultadoPapPrevio.DataType = DbType.Int32;
				colvarIdResultadoPapPrevio.MaxLength = 0;
				colvarIdResultadoPapPrevio.AutoIncrement = false;
				colvarIdResultadoPapPrevio.IsNullable = true;
				colvarIdResultadoPapPrevio.IsPrimaryKey = false;
				colvarIdResultadoPapPrevio.IsForeignKey = false;
				colvarIdResultadoPapPrevio.IsReadOnly = false;
				colvarIdResultadoPapPrevio.DefaultSetting = @"";
				colvarIdResultadoPapPrevio.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdResultadoPapPrevio);
				
				TableSchema.TableColumn colvarIdCitologo = new TableSchema.TableColumn(schema);
				colvarIdCitologo.ColumnName = "Id_Citologo";
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
				colvarIdMedicoSol.ColumnName = "Id_Medico_Sol";
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
				colvarIdTipoMuestra.ColumnName = "Id_TipoMuestra";
				colvarIdTipoMuestra.DataType = DbType.Int32;
				colvarIdTipoMuestra.MaxLength = 0;
				colvarIdTipoMuestra.AutoIncrement = false;
				colvarIdTipoMuestra.IsNullable = true;
				colvarIdTipoMuestra.IsPrimaryKey = false;
				colvarIdTipoMuestra.IsForeignKey = false;
				colvarIdTipoMuestra.IsReadOnly = false;
				colvarIdTipoMuestra.DefaultSetting = @"";
				colvarIdTipoMuestra.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdTipoMuestra);
				
				TableSchema.TableColumn colvarFechaMuestra = new TableSchema.TableColumn(schema);
				colvarFechaMuestra.ColumnName = "Fecha_Muestra";
				colvarFechaMuestra.DataType = DbType.AnsiString;
				colvarFechaMuestra.MaxLength = 10;
				colvarFechaMuestra.AutoIncrement = false;
				colvarFechaMuestra.IsNullable = true;
				colvarFechaMuestra.IsPrimaryKey = false;
				colvarFechaMuestra.IsForeignKey = false;
				colvarFechaMuestra.IsReadOnly = false;
				colvarFechaMuestra.DefaultSetting = @"";
				colvarFechaMuestra.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFechaMuestra);
				
				TableSchema.TableColumn colvarIdCentroMuestra = new TableSchema.TableColumn(schema);
				colvarIdCentroMuestra.ColumnName = "Id_Centro_Muestra";
				colvarIdCentroMuestra.DataType = DbType.Int32;
				colvarIdCentroMuestra.MaxLength = 0;
				colvarIdCentroMuestra.AutoIncrement = false;
				colvarIdCentroMuestra.IsNullable = true;
				colvarIdCentroMuestra.IsPrimaryKey = false;
				colvarIdCentroMuestra.IsForeignKey = false;
				colvarIdCentroMuestra.IsReadOnly = false;
				colvarIdCentroMuestra.DefaultSetting = @"";
				colvarIdCentroMuestra.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdCentroMuestra);
				
				TableSchema.TableColumn colvarFechaInforme = new TableSchema.TableColumn(schema);
				colvarFechaInforme.ColumnName = "Fecha_Informe";
				colvarFechaInforme.DataType = DbType.AnsiString;
				colvarFechaInforme.MaxLength = 10;
				colvarFechaInforme.AutoIncrement = false;
				colvarFechaInforme.IsNullable = true;
				colvarFechaInforme.IsPrimaryKey = false;
				colvarFechaInforme.IsForeignKey = false;
				colvarFechaInforme.IsReadOnly = false;
				colvarFechaInforme.DefaultSetting = @"";
				colvarFechaInforme.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFechaInforme);
				
				TableSchema.TableColumn colvarIdCalidadMuestra = new TableSchema.TableColumn(schema);
				colvarIdCalidadMuestra.ColumnName = "Id_CalidadMuestra";
				colvarIdCalidadMuestra.DataType = DbType.Int32;
				colvarIdCalidadMuestra.MaxLength = 0;
				colvarIdCalidadMuestra.AutoIncrement = false;
				colvarIdCalidadMuestra.IsNullable = true;
				colvarIdCalidadMuestra.IsPrimaryKey = false;
				colvarIdCalidadMuestra.IsForeignKey = false;
				colvarIdCalidadMuestra.IsReadOnly = false;
				colvarIdCalidadMuestra.DefaultSetting = @"";
				colvarIdCalidadMuestra.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdCalidadMuestra);
				
				TableSchema.TableColumn colvarIdMicroorganismo = new TableSchema.TableColumn(schema);
				colvarIdMicroorganismo.ColumnName = "Id_Microorganismo";
				colvarIdMicroorganismo.DataType = DbType.Int32;
				colvarIdMicroorganismo.MaxLength = 0;
				colvarIdMicroorganismo.AutoIncrement = false;
				colvarIdMicroorganismo.IsNullable = true;
				colvarIdMicroorganismo.IsPrimaryKey = false;
				colvarIdMicroorganismo.IsForeignKey = false;
				colvarIdMicroorganismo.IsReadOnly = false;
				colvarIdMicroorganismo.DefaultSetting = @"";
				colvarIdMicroorganismo.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdMicroorganismo);
				
				TableSchema.TableColumn colvarIdOtrosHallazgos = new TableSchema.TableColumn(schema);
				colvarIdOtrosHallazgos.ColumnName = "Id_OtrosHallazgos";
				colvarIdOtrosHallazgos.DataType = DbType.Int32;
				colvarIdOtrosHallazgos.MaxLength = 0;
				colvarIdOtrosHallazgos.AutoIncrement = false;
				colvarIdOtrosHallazgos.IsNullable = true;
				colvarIdOtrosHallazgos.IsPrimaryKey = false;
				colvarIdOtrosHallazgos.IsForeignKey = false;
				colvarIdOtrosHallazgos.IsReadOnly = false;
				colvarIdOtrosHallazgos.DefaultSetting = @"";
				colvarIdOtrosHallazgos.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdOtrosHallazgos);
				
				TableSchema.TableColumn colvarIdCelulasEscamosas = new TableSchema.TableColumn(schema);
				colvarIdCelulasEscamosas.ColumnName = "id_CelulasEscamosas";
				colvarIdCelulasEscamosas.DataType = DbType.Int32;
				colvarIdCelulasEscamosas.MaxLength = 0;
				colvarIdCelulasEscamosas.AutoIncrement = false;
				colvarIdCelulasEscamosas.IsNullable = true;
				colvarIdCelulasEscamosas.IsPrimaryKey = false;
				colvarIdCelulasEscamosas.IsForeignKey = false;
				colvarIdCelulasEscamosas.IsReadOnly = false;
				colvarIdCelulasEscamosas.DefaultSetting = @"";
				colvarIdCelulasEscamosas.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdCelulasEscamosas);
				
				TableSchema.TableColumn colvarIdCelulasGlandulares = new TableSchema.TableColumn(schema);
				colvarIdCelulasGlandulares.ColumnName = "Id_CelulasGlandulares";
				colvarIdCelulasGlandulares.DataType = DbType.Int32;
				colvarIdCelulasGlandulares.MaxLength = 0;
				colvarIdCelulasGlandulares.AutoIncrement = false;
				colvarIdCelulasGlandulares.IsNullable = true;
				colvarIdCelulasGlandulares.IsPrimaryKey = false;
				colvarIdCelulasGlandulares.IsForeignKey = false;
				colvarIdCelulasGlandulares.IsReadOnly = false;
				colvarIdCelulasGlandulares.DefaultSetting = @"";
				colvarIdCelulasGlandulares.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdCelulasGlandulares);
				
				TableSchema.TableColumn colvarIdObservacion = new TableSchema.TableColumn(schema);
				colvarIdObservacion.ColumnName = "Id_Observacion";
				colvarIdObservacion.DataType = DbType.Int32;
				colvarIdObservacion.MaxLength = 0;
				colvarIdObservacion.AutoIncrement = false;
				colvarIdObservacion.IsNullable = true;
				colvarIdObservacion.IsPrimaryKey = false;
				colvarIdObservacion.IsForeignKey = false;
				colvarIdObservacion.IsReadOnly = false;
				colvarIdObservacion.DefaultSetting = @"";
				colvarIdObservacion.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdObservacion);
				
				TableSchema.TableColumn colvarFechaRecepcion = new TableSchema.TableColumn(schema);
				colvarFechaRecepcion.ColumnName = "Fecha_Recepcion";
				colvarFechaRecepcion.DataType = DbType.AnsiString;
				colvarFechaRecepcion.MaxLength = 10;
				colvarFechaRecepcion.AutoIncrement = false;
				colvarFechaRecepcion.IsNullable = true;
				colvarFechaRecepcion.IsPrimaryKey = false;
				colvarFechaRecepcion.IsForeignKey = false;
				colvarFechaRecepcion.IsReadOnly = false;
				colvarFechaRecepcion.DefaultSetting = @"";
				colvarFechaRecepcion.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFechaRecepcion);
				
				TableSchema.TableColumn colvarObservaciones = new TableSchema.TableColumn(schema);
				colvarObservaciones.ColumnName = "observaciones";
				colvarObservaciones.DataType = DbType.String;
				colvarObservaciones.MaxLength = 50;
				colvarObservaciones.AutoIncrement = false;
				colvarObservaciones.IsNullable = true;
				colvarObservaciones.IsPrimaryKey = false;
				colvarObservaciones.IsForeignKey = false;
				colvarObservaciones.IsReadOnly = false;
				colvarObservaciones.DefaultSetting = @"";
				colvarObservaciones.ForeignKeyTableName = "";
				schema.Columns.Add(colvarObservaciones);
				
				TableSchema.TableColumn colvarIdCentro = new TableSchema.TableColumn(schema);
				colvarIdCentro.ColumnName = "Id_Centro";
				colvarIdCentro.DataType = DbType.Int32;
				colvarIdCentro.MaxLength = 0;
				colvarIdCentro.AutoIncrement = false;
				colvarIdCentro.IsNullable = true;
				colvarIdCentro.IsPrimaryKey = false;
				colvarIdCentro.IsForeignKey = false;
				colvarIdCentro.IsReadOnly = false;
				colvarIdCentro.DefaultSetting = @"";
				colvarIdCentro.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdCentro);
				
				TableSchema.TableColumn colvarIdMujerExporta = new TableSchema.TableColumn(schema);
				colvarIdMujerExporta.ColumnName = "Id_Mujer_Exporta";
				colvarIdMujerExporta.DataType = DbType.Int32;
				colvarIdMujerExporta.MaxLength = 0;
				colvarIdMujerExporta.AutoIncrement = false;
				colvarIdMujerExporta.IsNullable = true;
				colvarIdMujerExporta.IsPrimaryKey = false;
				colvarIdMujerExporta.IsForeignKey = false;
				colvarIdMujerExporta.IsReadOnly = false;
				colvarIdMujerExporta.DefaultSetting = @"";
				colvarIdMujerExporta.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdMujerExporta);
				
				TableSchema.TableColumn colvarNumeroLaboratorio = new TableSchema.TableColumn(schema);
				colvarNumeroLaboratorio.ColumnName = "Numero_Laboratorio";
				colvarNumeroLaboratorio.DataType = DbType.String;
				colvarNumeroLaboratorio.MaxLength = 50;
				colvarNumeroLaboratorio.AutoIncrement = false;
				colvarNumeroLaboratorio.IsNullable = true;
				colvarNumeroLaboratorio.IsPrimaryKey = false;
				colvarNumeroLaboratorio.IsForeignKey = false;
				colvarNumeroLaboratorio.IsReadOnly = false;
				colvarNumeroLaboratorio.DefaultSetting = @"";
				colvarNumeroLaboratorio.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNumeroLaboratorio);
				
				TableSchema.TableColumn colvarFechaEntrega = new TableSchema.TableColumn(schema);
				colvarFechaEntrega.ColumnName = "Fecha_Entrega";
				colvarFechaEntrega.DataType = DbType.AnsiString;
				colvarFechaEntrega.MaxLength = 10;
				colvarFechaEntrega.AutoIncrement = false;
				colvarFechaEntrega.IsNullable = true;
				colvarFechaEntrega.IsPrimaryKey = false;
				colvarFechaEntrega.IsForeignKey = false;
				colvarFechaEntrega.IsReadOnly = false;
				colvarFechaEntrega.DefaultSetting = @"";
				colvarFechaEntrega.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFechaEntrega);
				
				TableSchema.TableColumn colvarCervixSatisfactorio = new TableSchema.TableColumn(schema);
				colvarCervixSatisfactorio.ColumnName = "Cervix_Satisfactorio";
				colvarCervixSatisfactorio.DataType = DbType.String;
				colvarCervixSatisfactorio.MaxLength = 50;
				colvarCervixSatisfactorio.AutoIncrement = false;
				colvarCervixSatisfactorio.IsNullable = true;
				colvarCervixSatisfactorio.IsPrimaryKey = false;
				colvarCervixSatisfactorio.IsForeignKey = false;
				colvarCervixSatisfactorio.IsReadOnly = false;
				colvarCervixSatisfactorio.DefaultSetting = @"";
				colvarCervixSatisfactorio.ForeignKeyTableName = "";
				schema.Columns.Add(colvarCervixSatisfactorio);
				
				TableSchema.TableColumn colvarTratHormonal = new TableSchema.TableColumn(schema);
				colvarTratHormonal.ColumnName = "Trat_Hormonal";
				colvarTratHormonal.DataType = DbType.String;
				colvarTratHormonal.MaxLength = 50;
				colvarTratHormonal.AutoIncrement = false;
				colvarTratHormonal.IsNullable = true;
				colvarTratHormonal.IsPrimaryKey = false;
				colvarTratHormonal.IsForeignKey = false;
				colvarTratHormonal.IsReadOnly = false;
				colvarTratHormonal.DefaultSetting = @"";
				colvarTratHormonal.ForeignKeyTableName = "";
				schema.Columns.Add(colvarTratHormonal);
				
				TableSchema.TableColumn colvarTratRadiante = new TableSchema.TableColumn(schema);
				colvarTratRadiante.ColumnName = "Trat_Radiante";
				colvarTratRadiante.DataType = DbType.String;
				colvarTratRadiante.MaxLength = 50;
				colvarTratRadiante.AutoIncrement = false;
				colvarTratRadiante.IsNullable = true;
				colvarTratRadiante.IsPrimaryKey = false;
				colvarTratRadiante.IsForeignKey = false;
				colvarTratRadiante.IsReadOnly = false;
				colvarTratRadiante.DefaultSetting = @"";
				colvarTratRadiante.ForeignKeyTableName = "";
				schema.Columns.Add(colvarTratRadiante);
				
				TableSchema.TableColumn colvarQuimioterapia = new TableSchema.TableColumn(schema);
				colvarQuimioterapia.ColumnName = "quimioterapia";
				colvarQuimioterapia.DataType = DbType.String;
				colvarQuimioterapia.MaxLength = 50;
				colvarQuimioterapia.AutoIncrement = false;
				colvarQuimioterapia.IsNullable = true;
				colvarQuimioterapia.IsPrimaryKey = false;
				colvarQuimioterapia.IsForeignKey = false;
				colvarQuimioterapia.IsReadOnly = false;
				colvarQuimioterapia.DefaultSetting = @"";
				colvarQuimioterapia.ForeignKeyTableName = "";
				schema.Columns.Add(colvarQuimioterapia);
				
				TableSchema.TableColumn colvarTratDestructivo = new TableSchema.TableColumn(schema);
				colvarTratDestructivo.ColumnName = "Trat_Destructivo";
				colvarTratDestructivo.DataType = DbType.String;
				colvarTratDestructivo.MaxLength = 50;
				colvarTratDestructivo.AutoIncrement = false;
				colvarTratDestructivo.IsNullable = true;
				colvarTratDestructivo.IsPrimaryKey = false;
				colvarTratDestructivo.IsForeignKey = false;
				colvarTratDestructivo.IsReadOnly = false;
				colvarTratDestructivo.DefaultSetting = @"";
				colvarTratDestructivo.ForeignKeyTableName = "";
				schema.Columns.Add(colvarTratDestructivo);
				
				TableSchema.TableColumn colvarEmbarazada = new TableSchema.TableColumn(schema);
				colvarEmbarazada.ColumnName = "embarazada";
				colvarEmbarazada.DataType = DbType.String;
				colvarEmbarazada.MaxLength = 50;
				colvarEmbarazada.AutoIncrement = false;
				colvarEmbarazada.IsNullable = true;
				colvarEmbarazada.IsPrimaryKey = false;
				colvarEmbarazada.IsForeignKey = false;
				colvarEmbarazada.IsReadOnly = false;
				colvarEmbarazada.DefaultSetting = @"";
				colvarEmbarazada.ForeignKeyTableName = "";
				schema.Columns.Add(colvarEmbarazada);
				
				TableSchema.TableColumn colvarFechaFum = new TableSchema.TableColumn(schema);
				colvarFechaFum.ColumnName = "Fecha_FUM";
				colvarFechaFum.DataType = DbType.AnsiString;
				colvarFechaFum.MaxLength = 10;
				colvarFechaFum.AutoIncrement = false;
				colvarFechaFum.IsNullable = true;
				colvarFechaFum.IsPrimaryKey = false;
				colvarFechaFum.IsForeignKey = false;
				colvarFechaFum.IsReadOnly = false;
				colvarFechaFum.DefaultSetting = @"";
				colvarFechaFum.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFechaFum);
				
				TableSchema.TableColumn colvarParidad = new TableSchema.TableColumn(schema);
				colvarParidad.ColumnName = "Paridad";
				colvarParidad.DataType = DbType.Int32;
				colvarParidad.MaxLength = 0;
				colvarParidad.AutoIncrement = false;
				colvarParidad.IsNullable = true;
				colvarParidad.IsPrimaryKey = false;
				colvarParidad.IsForeignKey = false;
				colvarParidad.IsReadOnly = false;
				colvarParidad.DefaultSetting = @"";
				colvarParidad.ForeignKeyTableName = "";
				schema.Columns.Add(colvarParidad);
				
				TableSchema.TableColumn colvarIdAnticonceptivo = new TableSchema.TableColumn(schema);
				colvarIdAnticonceptivo.ColumnName = "Id_Anticonceptivo";
				colvarIdAnticonceptivo.DataType = DbType.Int32;
				colvarIdAnticonceptivo.MaxLength = 0;
				colvarIdAnticonceptivo.AutoIncrement = false;
				colvarIdAnticonceptivo.IsNullable = true;
				colvarIdAnticonceptivo.IsPrimaryKey = false;
				colvarIdAnticonceptivo.IsForeignKey = false;
				colvarIdAnticonceptivo.IsReadOnly = false;
				colvarIdAnticonceptivo.DefaultSetting = @"";
				colvarIdAnticonceptivo.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdAnticonceptivo);
				
				TableSchema.TableColumn colvarIdCirugia = new TableSchema.TableColumn(schema);
				colvarIdCirugia.ColumnName = "Id_Cirugia";
				colvarIdCirugia.DataType = DbType.Int32;
				colvarIdCirugia.MaxLength = 0;
				colvarIdCirugia.AutoIncrement = false;
				colvarIdCirugia.IsNullable = true;
				colvarIdCirugia.IsPrimaryKey = false;
				colvarIdCirugia.IsForeignKey = false;
				colvarIdCirugia.IsReadOnly = false;
				colvarIdCirugia.DefaultSetting = @"";
				colvarIdCirugia.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdCirugia);
				
				TableSchema.TableColumn colvarMenopausia = new TableSchema.TableColumn(schema);
				colvarMenopausia.ColumnName = "menopausia";
				colvarMenopausia.DataType = DbType.String;
				colvarMenopausia.MaxLength = 50;
				colvarMenopausia.AutoIncrement = false;
				colvarMenopausia.IsNullable = true;
				colvarMenopausia.IsPrimaryKey = false;
				colvarMenopausia.IsForeignKey = false;
				colvarMenopausia.IsReadOnly = false;
				colvarMenopausia.DefaultSetting = @"";
				colvarMenopausia.ForeignKeyTableName = "";
				schema.Columns.Add(colvarMenopausia);
				
				TableSchema.TableColumn colvarLactancia = new TableSchema.TableColumn(schema);
				colvarLactancia.ColumnName = "lactancia";
				colvarLactancia.DataType = DbType.String;
				colvarLactancia.MaxLength = 50;
				colvarLactancia.AutoIncrement = false;
				colvarLactancia.IsNullable = true;
				colvarLactancia.IsPrimaryKey = false;
				colvarLactancia.IsForeignKey = false;
				colvarLactancia.IsReadOnly = false;
				colvarLactancia.DefaultSetting = @"";
				colvarLactancia.ForeignKeyTableName = "";
				schema.Columns.Add(colvarLactancia);
				
				TableSchema.TableColumn colvarFechaPrevio = new TableSchema.TableColumn(schema);
				colvarFechaPrevio.ColumnName = "Fecha_Previo";
				colvarFechaPrevio.DataType = DbType.AnsiString;
				colvarFechaPrevio.MaxLength = 10;
				colvarFechaPrevio.AutoIncrement = false;
				colvarFechaPrevio.IsNullable = true;
				colvarFechaPrevio.IsPrimaryKey = false;
				colvarFechaPrevio.IsForeignKey = false;
				colvarFechaPrevio.IsReadOnly = false;
				colvarFechaPrevio.DefaultSetting = @"";
				colvarFechaPrevio.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFechaPrevio);
				
				TableSchema.TableColumn colvarIdPaps = new TableSchema.TableColumn(schema);
				colvarIdPaps.ColumnName = "id_Paps";
				colvarIdPaps.DataType = DbType.Int32;
				colvarIdPaps.MaxLength = 0;
				colvarIdPaps.AutoIncrement = false;
				colvarIdPaps.IsNullable = true;
				colvarIdPaps.IsPrimaryKey = false;
				colvarIdPaps.IsForeignKey = false;
				colvarIdPaps.IsReadOnly = false;
				colvarIdPaps.DefaultSetting = @"";
				colvarIdPaps.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdPaps);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["RisProvider"].AddSchema("TAM_PAPM",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("IdPaps")]
		[Bindable(true)]
		public int IdPaps 
		{
			get { return GetColumnValue<int>(Columns.IdPaps); }
			set { SetColumnValue(Columns.IdPaps, value); }
		}
		  
		[XmlAttribute("IdTipoPapPrevio")]
		[Bindable(true)]
		public int? IdTipoPapPrevio 
		{
			get { return GetColumnValue<int?>(Columns.IdTipoPapPrevio); }
			set { SetColumnValue(Columns.IdTipoPapPrevio, value); }
		}
		  
		[XmlAttribute("IdResultadoPapPrevio")]
		[Bindable(true)]
		public int? IdResultadoPapPrevio 
		{
			get { return GetColumnValue<int?>(Columns.IdResultadoPapPrevio); }
			set { SetColumnValue(Columns.IdResultadoPapPrevio, value); }
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
		public string FechaMuestra 
		{
			get { return GetColumnValue<string>(Columns.FechaMuestra); }
			set { SetColumnValue(Columns.FechaMuestra, value); }
		}
		  
		[XmlAttribute("IdCentroMuestra")]
		[Bindable(true)]
		public int? IdCentroMuestra 
		{
			get { return GetColumnValue<int?>(Columns.IdCentroMuestra); }
			set { SetColumnValue(Columns.IdCentroMuestra, value); }
		}
		  
		[XmlAttribute("FechaInforme")]
		[Bindable(true)]
		public string FechaInforme 
		{
			get { return GetColumnValue<string>(Columns.FechaInforme); }
			set { SetColumnValue(Columns.FechaInforme, value); }
		}
		  
		[XmlAttribute("IdCalidadMuestra")]
		[Bindable(true)]
		public int? IdCalidadMuestra 
		{
			get { return GetColumnValue<int?>(Columns.IdCalidadMuestra); }
			set { SetColumnValue(Columns.IdCalidadMuestra, value); }
		}
		  
		[XmlAttribute("IdMicroorganismo")]
		[Bindable(true)]
		public int? IdMicroorganismo 
		{
			get { return GetColumnValue<int?>(Columns.IdMicroorganismo); }
			set { SetColumnValue(Columns.IdMicroorganismo, value); }
		}
		  
		[XmlAttribute("IdOtrosHallazgos")]
		[Bindable(true)]
		public int? IdOtrosHallazgos 
		{
			get { return GetColumnValue<int?>(Columns.IdOtrosHallazgos); }
			set { SetColumnValue(Columns.IdOtrosHallazgos, value); }
		}
		  
		[XmlAttribute("IdCelulasEscamosas")]
		[Bindable(true)]
		public int? IdCelulasEscamosas 
		{
			get { return GetColumnValue<int?>(Columns.IdCelulasEscamosas); }
			set { SetColumnValue(Columns.IdCelulasEscamosas, value); }
		}
		  
		[XmlAttribute("IdCelulasGlandulares")]
		[Bindable(true)]
		public int? IdCelulasGlandulares 
		{
			get { return GetColumnValue<int?>(Columns.IdCelulasGlandulares); }
			set { SetColumnValue(Columns.IdCelulasGlandulares, value); }
		}
		  
		[XmlAttribute("IdObservacion")]
		[Bindable(true)]
		public int? IdObservacion 
		{
			get { return GetColumnValue<int?>(Columns.IdObservacion); }
			set { SetColumnValue(Columns.IdObservacion, value); }
		}
		  
		[XmlAttribute("FechaRecepcion")]
		[Bindable(true)]
		public string FechaRecepcion 
		{
			get { return GetColumnValue<string>(Columns.FechaRecepcion); }
			set { SetColumnValue(Columns.FechaRecepcion, value); }
		}
		  
		[XmlAttribute("Observaciones")]
		[Bindable(true)]
		public string Observaciones 
		{
			get { return GetColumnValue<string>(Columns.Observaciones); }
			set { SetColumnValue(Columns.Observaciones, value); }
		}
		  
		[XmlAttribute("IdCentro")]
		[Bindable(true)]
		public int? IdCentro 
		{
			get { return GetColumnValue<int?>(Columns.IdCentro); }
			set { SetColumnValue(Columns.IdCentro, value); }
		}
		  
		[XmlAttribute("IdMujerExporta")]
		[Bindable(true)]
		public int? IdMujerExporta 
		{
			get { return GetColumnValue<int?>(Columns.IdMujerExporta); }
			set { SetColumnValue(Columns.IdMujerExporta, value); }
		}
		  
		[XmlAttribute("NumeroLaboratorio")]
		[Bindable(true)]
		public string NumeroLaboratorio 
		{
			get { return GetColumnValue<string>(Columns.NumeroLaboratorio); }
			set { SetColumnValue(Columns.NumeroLaboratorio, value); }
		}
		  
		[XmlAttribute("FechaEntrega")]
		[Bindable(true)]
		public string FechaEntrega 
		{
			get { return GetColumnValue<string>(Columns.FechaEntrega); }
			set { SetColumnValue(Columns.FechaEntrega, value); }
		}
		  
		[XmlAttribute("CervixSatisfactorio")]
		[Bindable(true)]
		public string CervixSatisfactorio 
		{
			get { return GetColumnValue<string>(Columns.CervixSatisfactorio); }
			set { SetColumnValue(Columns.CervixSatisfactorio, value); }
		}
		  
		[XmlAttribute("TratHormonal")]
		[Bindable(true)]
		public string TratHormonal 
		{
			get { return GetColumnValue<string>(Columns.TratHormonal); }
			set { SetColumnValue(Columns.TratHormonal, value); }
		}
		  
		[XmlAttribute("TratRadiante")]
		[Bindable(true)]
		public string TratRadiante 
		{
			get { return GetColumnValue<string>(Columns.TratRadiante); }
			set { SetColumnValue(Columns.TratRadiante, value); }
		}
		  
		[XmlAttribute("Quimioterapia")]
		[Bindable(true)]
		public string Quimioterapia 
		{
			get { return GetColumnValue<string>(Columns.Quimioterapia); }
			set { SetColumnValue(Columns.Quimioterapia, value); }
		}
		  
		[XmlAttribute("TratDestructivo")]
		[Bindable(true)]
		public string TratDestructivo 
		{
			get { return GetColumnValue<string>(Columns.TratDestructivo); }
			set { SetColumnValue(Columns.TratDestructivo, value); }
		}
		  
		[XmlAttribute("Embarazada")]
		[Bindable(true)]
		public string Embarazada 
		{
			get { return GetColumnValue<string>(Columns.Embarazada); }
			set { SetColumnValue(Columns.Embarazada, value); }
		}
		  
		[XmlAttribute("FechaFum")]
		[Bindable(true)]
		public string FechaFum 
		{
			get { return GetColumnValue<string>(Columns.FechaFum); }
			set { SetColumnValue(Columns.FechaFum, value); }
		}
		  
		[XmlAttribute("Paridad")]
		[Bindable(true)]
		public int? Paridad 
		{
			get { return GetColumnValue<int?>(Columns.Paridad); }
			set { SetColumnValue(Columns.Paridad, value); }
		}
		  
		[XmlAttribute("IdAnticonceptivo")]
		[Bindable(true)]
		public int? IdAnticonceptivo 
		{
			get { return GetColumnValue<int?>(Columns.IdAnticonceptivo); }
			set { SetColumnValue(Columns.IdAnticonceptivo, value); }
		}
		  
		[XmlAttribute("IdCirugia")]
		[Bindable(true)]
		public int? IdCirugia 
		{
			get { return GetColumnValue<int?>(Columns.IdCirugia); }
			set { SetColumnValue(Columns.IdCirugia, value); }
		}
		  
		[XmlAttribute("Menopausia")]
		[Bindable(true)]
		public string Menopausia 
		{
			get { return GetColumnValue<string>(Columns.Menopausia); }
			set { SetColumnValue(Columns.Menopausia, value); }
		}
		  
		[XmlAttribute("Lactancia")]
		[Bindable(true)]
		public string Lactancia 
		{
			get { return GetColumnValue<string>(Columns.Lactancia); }
			set { SetColumnValue(Columns.Lactancia, value); }
		}
		  
		[XmlAttribute("FechaPrevio")]
		[Bindable(true)]
		public string FechaPrevio 
		{
			get { return GetColumnValue<string>(Columns.FechaPrevio); }
			set { SetColumnValue(Columns.FechaPrevio, value); }
		}
		  
		[XmlAttribute("IdPaps")]
		[Bindable(true)]
		public int? IdPaps 
		{
			get { return GetColumnValue<int?>(Columns.IdPaps); }
			set { SetColumnValue(Columns.IdPaps, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(int? varIdTipoPapPrevio,int? varIdResultadoPapPrevio,int? varIdCitologo,int? varIdMedicoSol,int? varIdTipoMuestra,string varFechaMuestra,int? varIdCentroMuestra,string varFechaInforme,int? varIdCalidadMuestra,int? varIdMicroorganismo,int? varIdOtrosHallazgos,int? varIdCelulasEscamosas,int? varIdCelulasGlandulares,int? varIdObservacion,string varFechaRecepcion,string varObservaciones,int? varIdCentro,int? varIdMujerExporta,string varNumeroLaboratorio,string varFechaEntrega,string varCervixSatisfactorio,string varTratHormonal,string varTratRadiante,string varQuimioterapia,string varTratDestructivo,string varEmbarazada,string varFechaFum,int? varParidad,int? varIdAnticonceptivo,int? varIdCirugia,string varMenopausia,string varLactancia,string varFechaPrevio,int? varIdPaps)
		{
			TamPapm item = new TamPapm();
			
			item.IdTipoPapPrevio = varIdTipoPapPrevio;
			
			item.IdResultadoPapPrevio = varIdResultadoPapPrevio;
			
			item.IdCitologo = varIdCitologo;
			
			item.IdMedicoSol = varIdMedicoSol;
			
			item.IdTipoMuestra = varIdTipoMuestra;
			
			item.FechaMuestra = varFechaMuestra;
			
			item.IdCentroMuestra = varIdCentroMuestra;
			
			item.FechaInforme = varFechaInforme;
			
			item.IdCalidadMuestra = varIdCalidadMuestra;
			
			item.IdMicroorganismo = varIdMicroorganismo;
			
			item.IdOtrosHallazgos = varIdOtrosHallazgos;
			
			item.IdCelulasEscamosas = varIdCelulasEscamosas;
			
			item.IdCelulasGlandulares = varIdCelulasGlandulares;
			
			item.IdObservacion = varIdObservacion;
			
			item.FechaRecepcion = varFechaRecepcion;
			
			item.Observaciones = varObservaciones;
			
			item.IdCentro = varIdCentro;
			
			item.IdMujerExporta = varIdMujerExporta;
			
			item.NumeroLaboratorio = varNumeroLaboratorio;
			
			item.FechaEntrega = varFechaEntrega;
			
			item.CervixSatisfactorio = varCervixSatisfactorio;
			
			item.TratHormonal = varTratHormonal;
			
			item.TratRadiante = varTratRadiante;
			
			item.Quimioterapia = varQuimioterapia;
			
			item.TratDestructivo = varTratDestructivo;
			
			item.Embarazada = varEmbarazada;
			
			item.FechaFum = varFechaFum;
			
			item.Paridad = varParidad;
			
			item.IdAnticonceptivo = varIdAnticonceptivo;
			
			item.IdCirugia = varIdCirugia;
			
			item.Menopausia = varMenopausia;
			
			item.Lactancia = varLactancia;
			
			item.FechaPrevio = varFechaPrevio;
			
			item.IdPaps = varIdPaps;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varIdPaps,int? varIdTipoPapPrevio,int? varIdResultadoPapPrevio,int? varIdCitologo,int? varIdMedicoSol,int? varIdTipoMuestra,string varFechaMuestra,int? varIdCentroMuestra,string varFechaInforme,int? varIdCalidadMuestra,int? varIdMicroorganismo,int? varIdOtrosHallazgos,int? varIdCelulasEscamosas,int? varIdCelulasGlandulares,int? varIdObservacion,string varFechaRecepcion,string varObservaciones,int? varIdCentro,int? varIdMujerExporta,string varNumeroLaboratorio,string varFechaEntrega,string varCervixSatisfactorio,string varTratHormonal,string varTratRadiante,string varQuimioterapia,string varTratDestructivo,string varEmbarazada,string varFechaFum,int? varParidad,int? varIdAnticonceptivo,int? varIdCirugia,string varMenopausia,string varLactancia,string varFechaPrevio,int? varIdPaps)
		{
			TamPapm item = new TamPapm();
			
				item.IdPaps = varIdPaps;
			
				item.IdTipoPapPrevio = varIdTipoPapPrevio;
			
				item.IdResultadoPapPrevio = varIdResultadoPapPrevio;
			
				item.IdCitologo = varIdCitologo;
			
				item.IdMedicoSol = varIdMedicoSol;
			
				item.IdTipoMuestra = varIdTipoMuestra;
			
				item.FechaMuestra = varFechaMuestra;
			
				item.IdCentroMuestra = varIdCentroMuestra;
			
				item.FechaInforme = varFechaInforme;
			
				item.IdCalidadMuestra = varIdCalidadMuestra;
			
				item.IdMicroorganismo = varIdMicroorganismo;
			
				item.IdOtrosHallazgos = varIdOtrosHallazgos;
			
				item.IdCelulasEscamosas = varIdCelulasEscamosas;
			
				item.IdCelulasGlandulares = varIdCelulasGlandulares;
			
				item.IdObservacion = varIdObservacion;
			
				item.FechaRecepcion = varFechaRecepcion;
			
				item.Observaciones = varObservaciones;
			
				item.IdCentro = varIdCentro;
			
				item.IdMujerExporta = varIdMujerExporta;
			
				item.NumeroLaboratorio = varNumeroLaboratorio;
			
				item.FechaEntrega = varFechaEntrega;
			
				item.CervixSatisfactorio = varCervixSatisfactorio;
			
				item.TratHormonal = varTratHormonal;
			
				item.TratRadiante = varTratRadiante;
			
				item.Quimioterapia = varQuimioterapia;
			
				item.TratDestructivo = varTratDestructivo;
			
				item.Embarazada = varEmbarazada;
			
				item.FechaFum = varFechaFum;
			
				item.Paridad = varParidad;
			
				item.IdAnticonceptivo = varIdAnticonceptivo;
			
				item.IdCirugia = varIdCirugia;
			
				item.Menopausia = varMenopausia;
			
				item.Lactancia = varLactancia;
			
				item.FechaPrevio = varFechaPrevio;
			
				item.IdPaps = varIdPaps;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn IdPapsColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn IdTipoPapPrevioColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn IdResultadoPapPrevioColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn IdCitologoColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn IdMedicoSolColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn IdTipoMuestraColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        public static TableSchema.TableColumn FechaMuestraColumn
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        public static TableSchema.TableColumn IdCentroMuestraColumn
        {
            get { return Schema.Columns[7]; }
        }
        
        
        
        public static TableSchema.TableColumn FechaInformeColumn
        {
            get { return Schema.Columns[8]; }
        }
        
        
        
        public static TableSchema.TableColumn IdCalidadMuestraColumn
        {
            get { return Schema.Columns[9]; }
        }
        
        
        
        public static TableSchema.TableColumn IdMicroorganismoColumn
        {
            get { return Schema.Columns[10]; }
        }
        
        
        
        public static TableSchema.TableColumn IdOtrosHallazgosColumn
        {
            get { return Schema.Columns[11]; }
        }
        
        
        
        public static TableSchema.TableColumn IdCelulasEscamosasColumn
        {
            get { return Schema.Columns[12]; }
        }
        
        
        
        public static TableSchema.TableColumn IdCelulasGlandularesColumn
        {
            get { return Schema.Columns[13]; }
        }
        
        
        
        public static TableSchema.TableColumn IdObservacionColumn
        {
            get { return Schema.Columns[14]; }
        }
        
        
        
        public static TableSchema.TableColumn FechaRecepcionColumn
        {
            get { return Schema.Columns[15]; }
        }
        
        
        
        public static TableSchema.TableColumn ObservacionesColumn
        {
            get { return Schema.Columns[16]; }
        }
        
        
        
        public static TableSchema.TableColumn IdCentroColumn
        {
            get { return Schema.Columns[17]; }
        }
        
        
        
        public static TableSchema.TableColumn IdMujerExportaColumn
        {
            get { return Schema.Columns[18]; }
        }
        
        
        
        public static TableSchema.TableColumn NumeroLaboratorioColumn
        {
            get { return Schema.Columns[19]; }
        }
        
        
        
        public static TableSchema.TableColumn FechaEntregaColumn
        {
            get { return Schema.Columns[20]; }
        }
        
        
        
        public static TableSchema.TableColumn CervixSatisfactorioColumn
        {
            get { return Schema.Columns[21]; }
        }
        
        
        
        public static TableSchema.TableColumn TratHormonalColumn
        {
            get { return Schema.Columns[22]; }
        }
        
        
        
        public static TableSchema.TableColumn TratRadianteColumn
        {
            get { return Schema.Columns[23]; }
        }
        
        
        
        public static TableSchema.TableColumn QuimioterapiaColumn
        {
            get { return Schema.Columns[24]; }
        }
        
        
        
        public static TableSchema.TableColumn TratDestructivoColumn
        {
            get { return Schema.Columns[25]; }
        }
        
        
        
        public static TableSchema.TableColumn EmbarazadaColumn
        {
            get { return Schema.Columns[26]; }
        }
        
        
        
        public static TableSchema.TableColumn FechaFumColumn
        {
            get { return Schema.Columns[27]; }
        }
        
        
        
        public static TableSchema.TableColumn ParidadColumn
        {
            get { return Schema.Columns[28]; }
        }
        
        
        
        public static TableSchema.TableColumn IdAnticonceptivoColumn
        {
            get { return Schema.Columns[29]; }
        }
        
        
        
        public static TableSchema.TableColumn IdCirugiaColumn
        {
            get { return Schema.Columns[30]; }
        }
        
        
        
        public static TableSchema.TableColumn MenopausiaColumn
        {
            get { return Schema.Columns[31]; }
        }
        
        
        
        public static TableSchema.TableColumn LactanciaColumn
        {
            get { return Schema.Columns[32]; }
        }
        
        
        
        public static TableSchema.TableColumn FechaPrevioColumn
        {
            get { return Schema.Columns[33]; }
        }
        
        
        
        public static TableSchema.TableColumn IdPapsColumn
        {
            get { return Schema.Columns[34]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string IdPaps = @"idPaps";
			 public static string IdTipoPapPrevio = @"id_TipoPapPrevio";
			 public static string IdResultadoPapPrevio = @"Id_resultado_PAP_Previo";
			 public static string IdCitologo = @"Id_Citologo";
			 public static string IdMedicoSol = @"Id_Medico_Sol";
			 public static string IdTipoMuestra = @"Id_TipoMuestra";
			 public static string FechaMuestra = @"Fecha_Muestra";
			 public static string IdCentroMuestra = @"Id_Centro_Muestra";
			 public static string FechaInforme = @"Fecha_Informe";
			 public static string IdCalidadMuestra = @"Id_CalidadMuestra";
			 public static string IdMicroorganismo = @"Id_Microorganismo";
			 public static string IdOtrosHallazgos = @"Id_OtrosHallazgos";
			 public static string IdCelulasEscamosas = @"id_CelulasEscamosas";
			 public static string IdCelulasGlandulares = @"Id_CelulasGlandulares";
			 public static string IdObservacion = @"Id_Observacion";
			 public static string FechaRecepcion = @"Fecha_Recepcion";
			 public static string Observaciones = @"observaciones";
			 public static string IdCentro = @"Id_Centro";
			 public static string IdMujerExporta = @"Id_Mujer_Exporta";
			 public static string NumeroLaboratorio = @"Numero_Laboratorio";
			 public static string FechaEntrega = @"Fecha_Entrega";
			 public static string CervixSatisfactorio = @"Cervix_Satisfactorio";
			 public static string TratHormonal = @"Trat_Hormonal";
			 public static string TratRadiante = @"Trat_Radiante";
			 public static string Quimioterapia = @"quimioterapia";
			 public static string TratDestructivo = @"Trat_Destructivo";
			 public static string Embarazada = @"embarazada";
			 public static string FechaFum = @"Fecha_FUM";
			 public static string Paridad = @"Paridad";
			 public static string IdAnticonceptivo = @"Id_Anticonceptivo";
			 public static string IdCirugia = @"Id_Cirugia";
			 public static string Menopausia = @"menopausia";
			 public static string Lactancia = @"lactancia";
			 public static string FechaPrevio = @"Fecha_Previo";
			 public static string IdPaps = @"id_Paps";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
