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
	/// Strongly-typed collection for the PsmDatos1 class.
	/// </summary>
    [Serializable]
	public partial class PsmDatos1Collection : ActiveList<PsmDatos1, PsmDatos1Collection>
	{	   
		public PsmDatos1Collection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>PsmDatos1Collection</returns>
		public PsmDatos1Collection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                PsmDatos1 o = this[i];
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
	/// This is an ActiveRecord class which wraps the PSM_Datos1 table.
	/// </summary>
	[Serializable]
	public partial class PsmDatos1 : ActiveRecord<PsmDatos1>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public PsmDatos1()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public PsmDatos1(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public PsmDatos1(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public PsmDatos1(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("PSM_Datos1", TableType.Table, DataService.GetInstance("RisProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarIdProsame = new TableSchema.TableColumn(schema);
				colvarIdProsame.ColumnName = "idProsame";
				colvarIdProsame.DataType = DbType.Int32;
				colvarIdProsame.MaxLength = 0;
				colvarIdProsame.AutoIncrement = true;
				colvarIdProsame.IsNullable = false;
				colvarIdProsame.IsPrimaryKey = true;
				colvarIdProsame.IsForeignKey = false;
				colvarIdProsame.IsReadOnly = false;
				colvarIdProsame.DefaultSetting = @"";
				colvarIdProsame.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdProsame);
				
				TableSchema.TableColumn colvarIdPaciente = new TableSchema.TableColumn(schema);
				colvarIdPaciente.ColumnName = "idPaciente";
				colvarIdPaciente.DataType = DbType.Decimal;
				colvarIdPaciente.MaxLength = 0;
				colvarIdPaciente.AutoIncrement = false;
				colvarIdPaciente.IsNullable = false;
				colvarIdPaciente.IsPrimaryKey = false;
				colvarIdPaciente.IsForeignKey = false;
				colvarIdPaciente.IsReadOnly = false;
				colvarIdPaciente.DefaultSetting = @"";
				colvarIdPaciente.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdPaciente);
				
				TableSchema.TableColumn colvarIdEfector = new TableSchema.TableColumn(schema);
				colvarIdEfector.ColumnName = "idEfector";
				colvarIdEfector.DataType = DbType.Decimal;
				colvarIdEfector.MaxLength = 0;
				colvarIdEfector.AutoIncrement = false;
				colvarIdEfector.IsNullable = false;
				colvarIdEfector.IsPrimaryKey = false;
				colvarIdEfector.IsForeignKey = false;
				colvarIdEfector.IsReadOnly = false;
				colvarIdEfector.DefaultSetting = @"";
				colvarIdEfector.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdEfector);
				
				TableSchema.TableColumn colvarDNIPaciente = new TableSchema.TableColumn(schema);
				colvarDNIPaciente.ColumnName = "DNIPaciente";
				colvarDNIPaciente.DataType = DbType.Int32;
				colvarDNIPaciente.MaxLength = 0;
				colvarDNIPaciente.AutoIncrement = false;
				colvarDNIPaciente.IsNullable = true;
				colvarDNIPaciente.IsPrimaryKey = false;
				colvarDNIPaciente.IsForeignKey = false;
				colvarDNIPaciente.IsReadOnly = false;
				colvarDNIPaciente.DefaultSetting = @"";
				colvarDNIPaciente.ForeignKeyTableName = "";
				schema.Columns.Add(colvarDNIPaciente);
				
				TableSchema.TableColumn colvarIdEstablecimiento = new TableSchema.TableColumn(schema);
				colvarIdEstablecimiento.ColumnName = "idEstablecimiento";
				colvarIdEstablecimiento.DataType = DbType.Decimal;
				colvarIdEstablecimiento.MaxLength = 0;
				colvarIdEstablecimiento.AutoIncrement = false;
				colvarIdEstablecimiento.IsNullable = true;
				colvarIdEstablecimiento.IsPrimaryKey = false;
				colvarIdEstablecimiento.IsForeignKey = false;
				colvarIdEstablecimiento.IsReadOnly = false;
				colvarIdEstablecimiento.DefaultSetting = @"";
				colvarIdEstablecimiento.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdEstablecimiento);
				
				TableSchema.TableColumn colvarPrematuro = new TableSchema.TableColumn(schema);
				colvarPrematuro.ColumnName = "Prematuro";
				colvarPrematuro.DataType = DbType.String;
				colvarPrematuro.MaxLength = 2;
				colvarPrematuro.AutoIncrement = false;
				colvarPrematuro.IsNullable = true;
				colvarPrematuro.IsPrimaryKey = false;
				colvarPrematuro.IsForeignKey = false;
				colvarPrematuro.IsReadOnly = false;
				colvarPrematuro.DefaultSetting = @"";
				colvarPrematuro.ForeignKeyTableName = "";
				schema.Columns.Add(colvarPrematuro);
				
				TableSchema.TableColumn colvarTutorDNI = new TableSchema.TableColumn(schema);
				colvarTutorDNI.ColumnName = "TutorDNI";
				colvarTutorDNI.DataType = DbType.Decimal;
				colvarTutorDNI.MaxLength = 0;
				colvarTutorDNI.AutoIncrement = false;
				colvarTutorDNI.IsNullable = true;
				colvarTutorDNI.IsPrimaryKey = false;
				colvarTutorDNI.IsForeignKey = false;
				colvarTutorDNI.IsReadOnly = false;
				colvarTutorDNI.DefaultSetting = @"";
				colvarTutorDNI.ForeignKeyTableName = "";
				schema.Columns.Add(colvarTutorDNI);
				
				TableSchema.TableColumn colvarTutorNombre = new TableSchema.TableColumn(schema);
				colvarTutorNombre.ColumnName = "TutorNombre";
				colvarTutorNombre.DataType = DbType.String;
				colvarTutorNombre.MaxLength = 100;
				colvarTutorNombre.AutoIncrement = false;
				colvarTutorNombre.IsNullable = true;
				colvarTutorNombre.IsPrimaryKey = false;
				colvarTutorNombre.IsForeignKey = false;
				colvarTutorNombre.IsReadOnly = false;
				colvarTutorNombre.DefaultSetting = @"";
				colvarTutorNombre.ForeignKeyTableName = "";
				schema.Columns.Add(colvarTutorNombre);
				
				TableSchema.TableColumn colvarSobreEdad = new TableSchema.TableColumn(schema);
				colvarSobreEdad.ColumnName = "SobreEdad";
				colvarSobreEdad.DataType = DbType.String;
				colvarSobreEdad.MaxLength = 2;
				colvarSobreEdad.AutoIncrement = false;
				colvarSobreEdad.IsNullable = true;
				colvarSobreEdad.IsPrimaryKey = false;
				colvarSobreEdad.IsForeignKey = false;
				colvarSobreEdad.IsReadOnly = false;
				colvarSobreEdad.DefaultSetting = @"";
				colvarSobreEdad.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSobreEdad);
				
				TableSchema.TableColumn colvarRepitente = new TableSchema.TableColumn(schema);
				colvarRepitente.ColumnName = "Repitente";
				colvarRepitente.DataType = DbType.String;
				colvarRepitente.MaxLength = 2;
				colvarRepitente.AutoIncrement = false;
				colvarRepitente.IsNullable = true;
				colvarRepitente.IsPrimaryKey = false;
				colvarRepitente.IsForeignKey = false;
				colvarRepitente.IsReadOnly = false;
				colvarRepitente.DefaultSetting = @"";
				colvarRepitente.ForeignKeyTableName = "";
				schema.Columns.Add(colvarRepitente);
				
				TableSchema.TableColumn colvarPeso = new TableSchema.TableColumn(schema);
				colvarPeso.ColumnName = "Peso";
				colvarPeso.DataType = DbType.Decimal;
				colvarPeso.MaxLength = 0;
				colvarPeso.AutoIncrement = false;
				colvarPeso.IsNullable = true;
				colvarPeso.IsPrimaryKey = false;
				colvarPeso.IsForeignKey = false;
				colvarPeso.IsReadOnly = false;
				colvarPeso.DefaultSetting = @"";
				colvarPeso.ForeignKeyTableName = "";
				schema.Columns.Add(colvarPeso);
				
				TableSchema.TableColumn colvarTalla = new TableSchema.TableColumn(schema);
				colvarTalla.ColumnName = "Talla";
				colvarTalla.DataType = DbType.Decimal;
				colvarTalla.MaxLength = 0;
				colvarTalla.AutoIncrement = false;
				colvarTalla.IsNullable = true;
				colvarTalla.IsPrimaryKey = false;
				colvarTalla.IsForeignKey = false;
				colvarTalla.IsReadOnly = false;
				colvarTalla.DefaultSetting = @"";
				colvarTalla.ForeignKeyTableName = "";
				schema.Columns.Add(colvarTalla);
				
				TableSchema.TableColumn colvarImc = new TableSchema.TableColumn(schema);
				colvarImc.ColumnName = "IMC";
				colvarImc.DataType = DbType.Decimal;
				colvarImc.MaxLength = 0;
				colvarImc.AutoIncrement = false;
				colvarImc.IsNullable = true;
				colvarImc.IsPrimaryKey = false;
				colvarImc.IsForeignKey = false;
				colvarImc.IsReadOnly = false;
				colvarImc.DefaultSetting = @"";
				colvarImc.ForeignKeyTableName = "";
				schema.Columns.Add(colvarImc);
				
				TableSchema.TableColumn colvarTaMax = new TableSchema.TableColumn(schema);
				colvarTaMax.ColumnName = "TaMax";
				colvarTaMax.DataType = DbType.Decimal;
				colvarTaMax.MaxLength = 0;
				colvarTaMax.AutoIncrement = false;
				colvarTaMax.IsNullable = true;
				colvarTaMax.IsPrimaryKey = false;
				colvarTaMax.IsForeignKey = false;
				colvarTaMax.IsReadOnly = false;
				colvarTaMax.DefaultSetting = @"";
				colvarTaMax.ForeignKeyTableName = "";
				schema.Columns.Add(colvarTaMax);
				
				TableSchema.TableColumn colvarTaMin = new TableSchema.TableColumn(schema);
				colvarTaMin.ColumnName = "TaMin";
				colvarTaMin.DataType = DbType.Decimal;
				colvarTaMin.MaxLength = 0;
				colvarTaMin.AutoIncrement = false;
				colvarTaMin.IsNullable = true;
				colvarTaMin.IsPrimaryKey = false;
				colvarTaMin.IsForeignKey = false;
				colvarTaMin.IsReadOnly = false;
				colvarTaMin.DefaultSetting = @"";
				colvarTaMin.ForeignKeyTableName = "";
				schema.Columns.Add(colvarTaMin);
				
				TableSchema.TableColumn colvarPercentiloPeso = new TableSchema.TableColumn(schema);
				colvarPercentiloPeso.ColumnName = "PercentiloPeso";
				colvarPercentiloPeso.DataType = DbType.Decimal;
				colvarPercentiloPeso.MaxLength = 0;
				colvarPercentiloPeso.AutoIncrement = false;
				colvarPercentiloPeso.IsNullable = true;
				colvarPercentiloPeso.IsPrimaryKey = false;
				colvarPercentiloPeso.IsForeignKey = false;
				colvarPercentiloPeso.IsReadOnly = false;
				colvarPercentiloPeso.DefaultSetting = @"";
				colvarPercentiloPeso.ForeignKeyTableName = "";
				schema.Columns.Add(colvarPercentiloPeso);
				
				TableSchema.TableColumn colvarPercentiloTalla = new TableSchema.TableColumn(schema);
				colvarPercentiloTalla.ColumnName = "PercentiloTalla";
				colvarPercentiloTalla.DataType = DbType.Decimal;
				colvarPercentiloTalla.MaxLength = 0;
				colvarPercentiloTalla.AutoIncrement = false;
				colvarPercentiloTalla.IsNullable = true;
				colvarPercentiloTalla.IsPrimaryKey = false;
				colvarPercentiloTalla.IsForeignKey = false;
				colvarPercentiloTalla.IsReadOnly = false;
				colvarPercentiloTalla.DefaultSetting = @"";
				colvarPercentiloTalla.ForeignKeyTableName = "";
				schema.Columns.Add(colvarPercentiloTalla);
				
				TableSchema.TableColumn colvarPercentiloIMC = new TableSchema.TableColumn(schema);
				colvarPercentiloIMC.ColumnName = "PercentiloIMC";
				colvarPercentiloIMC.DataType = DbType.Decimal;
				colvarPercentiloIMC.MaxLength = 0;
				colvarPercentiloIMC.AutoIncrement = false;
				colvarPercentiloIMC.IsNullable = true;
				colvarPercentiloIMC.IsPrimaryKey = false;
				colvarPercentiloIMC.IsForeignKey = false;
				colvarPercentiloIMC.IsReadOnly = false;
				colvarPercentiloIMC.DefaultSetting = @"";
				colvarPercentiloIMC.ForeignKeyTableName = "";
				schema.Columns.Add(colvarPercentiloIMC);
				
				TableSchema.TableColumn colvarPercentiloMax = new TableSchema.TableColumn(schema);
				colvarPercentiloMax.ColumnName = "PercentiloMax";
				colvarPercentiloMax.DataType = DbType.Decimal;
				colvarPercentiloMax.MaxLength = 0;
				colvarPercentiloMax.AutoIncrement = false;
				colvarPercentiloMax.IsNullable = true;
				colvarPercentiloMax.IsPrimaryKey = false;
				colvarPercentiloMax.IsForeignKey = false;
				colvarPercentiloMax.IsReadOnly = false;
				colvarPercentiloMax.DefaultSetting = @"";
				colvarPercentiloMax.ForeignKeyTableName = "";
				schema.Columns.Add(colvarPercentiloMax);
				
				TableSchema.TableColumn colvarPercentiloMin = new TableSchema.TableColumn(schema);
				colvarPercentiloMin.ColumnName = "PercentiloMin";
				colvarPercentiloMin.DataType = DbType.Decimal;
				colvarPercentiloMin.MaxLength = 0;
				colvarPercentiloMin.AutoIncrement = false;
				colvarPercentiloMin.IsNullable = true;
				colvarPercentiloMin.IsPrimaryKey = false;
				colvarPercentiloMin.IsForeignKey = false;
				colvarPercentiloMin.IsReadOnly = false;
				colvarPercentiloMin.DefaultSetting = @"";
				colvarPercentiloMin.ForeignKeyTableName = "";
				schema.Columns.Add(colvarPercentiloMin);
				
				TableSchema.TableColumn colvarEFPielFanera = new TableSchema.TableColumn(schema);
				colvarEFPielFanera.ColumnName = "EFPielFanera";
				colvarEFPielFanera.DataType = DbType.Decimal;
				colvarEFPielFanera.MaxLength = 0;
				colvarEFPielFanera.AutoIncrement = false;
				colvarEFPielFanera.IsNullable = true;
				colvarEFPielFanera.IsPrimaryKey = false;
				colvarEFPielFanera.IsForeignKey = false;
				colvarEFPielFanera.IsReadOnly = false;
				colvarEFPielFanera.DefaultSetting = @"";
				colvarEFPielFanera.ForeignKeyTableName = "";
				schema.Columns.Add(colvarEFPielFanera);
				
				TableSchema.TableColumn colvarEFCardiovascular = new TableSchema.TableColumn(schema);
				colvarEFCardiovascular.ColumnName = "EFCardiovascular";
				colvarEFCardiovascular.DataType = DbType.Decimal;
				colvarEFCardiovascular.MaxLength = 0;
				colvarEFCardiovascular.AutoIncrement = false;
				colvarEFCardiovascular.IsNullable = true;
				colvarEFCardiovascular.IsPrimaryKey = false;
				colvarEFCardiovascular.IsForeignKey = false;
				colvarEFCardiovascular.IsReadOnly = false;
				colvarEFCardiovascular.DefaultSetting = @"";
				colvarEFCardiovascular.ForeignKeyTableName = "";
				schema.Columns.Add(colvarEFCardiovascular);
				
				TableSchema.TableColumn colvarEFRespiratorio = new TableSchema.TableColumn(schema);
				colvarEFRespiratorio.ColumnName = "EFRespiratorio";
				colvarEFRespiratorio.DataType = DbType.Decimal;
				colvarEFRespiratorio.MaxLength = 0;
				colvarEFRespiratorio.AutoIncrement = false;
				colvarEFRespiratorio.IsNullable = true;
				colvarEFRespiratorio.IsPrimaryKey = false;
				colvarEFRespiratorio.IsForeignKey = false;
				colvarEFRespiratorio.IsReadOnly = false;
				colvarEFRespiratorio.DefaultSetting = @"";
				colvarEFRespiratorio.ForeignKeyTableName = "";
				schema.Columns.Add(colvarEFRespiratorio);
				
				TableSchema.TableColumn colvarEFGenital = new TableSchema.TableColumn(schema);
				colvarEFGenital.ColumnName = "EFGenital";
				colvarEFGenital.DataType = DbType.Decimal;
				colvarEFGenital.MaxLength = 0;
				colvarEFGenital.AutoIncrement = false;
				colvarEFGenital.IsNullable = true;
				colvarEFGenital.IsPrimaryKey = false;
				colvarEFGenital.IsForeignKey = false;
				colvarEFGenital.IsReadOnly = false;
				colvarEFGenital.DefaultSetting = @"";
				colvarEFGenital.ForeignKeyTableName = "";
				schema.Columns.Add(colvarEFGenital);
				
				TableSchema.TableColumn colvarEFAbdomen = new TableSchema.TableColumn(schema);
				colvarEFAbdomen.ColumnName = "EFAbdomen";
				colvarEFAbdomen.DataType = DbType.Decimal;
				colvarEFAbdomen.MaxLength = 0;
				colvarEFAbdomen.AutoIncrement = false;
				colvarEFAbdomen.IsNullable = true;
				colvarEFAbdomen.IsPrimaryKey = false;
				colvarEFAbdomen.IsForeignKey = false;
				colvarEFAbdomen.IsReadOnly = false;
				colvarEFAbdomen.DefaultSetting = @"";
				colvarEFAbdomen.ForeignKeyTableName = "";
				schema.Columns.Add(colvarEFAbdomen);
				
				TableSchema.TableColumn colvarEFOsteoarticular = new TableSchema.TableColumn(schema);
				colvarEFOsteoarticular.ColumnName = "EFOsteoarticular";
				colvarEFOsteoarticular.DataType = DbType.Decimal;
				colvarEFOsteoarticular.MaxLength = 0;
				colvarEFOsteoarticular.AutoIncrement = false;
				colvarEFOsteoarticular.IsNullable = true;
				colvarEFOsteoarticular.IsPrimaryKey = false;
				colvarEFOsteoarticular.IsForeignKey = false;
				colvarEFOsteoarticular.IsReadOnly = false;
				colvarEFOsteoarticular.DefaultSetting = @"";
				colvarEFOsteoarticular.ForeignKeyTableName = "";
				schema.Columns.Add(colvarEFOsteoarticular);
				
				TableSchema.TableColumn colvarEFNeurologico = new TableSchema.TableColumn(schema);
				colvarEFNeurologico.ColumnName = "EFNeurologico";
				colvarEFNeurologico.DataType = DbType.Decimal;
				colvarEFNeurologico.MaxLength = 0;
				colvarEFNeurologico.AutoIncrement = false;
				colvarEFNeurologico.IsNullable = true;
				colvarEFNeurologico.IsPrimaryKey = false;
				colvarEFNeurologico.IsForeignKey = false;
				colvarEFNeurologico.IsReadOnly = false;
				colvarEFNeurologico.DefaultSetting = @"";
				colvarEFNeurologico.ForeignKeyTableName = "";
				schema.Columns.Add(colvarEFNeurologico);
				
				TableSchema.TableColumn colvarVacunaCarne = new TableSchema.TableColumn(schema);
				colvarVacunaCarne.ColumnName = "VacunaCarne";
				colvarVacunaCarne.DataType = DbType.String;
				colvarVacunaCarne.MaxLength = 2;
				colvarVacunaCarne.AutoIncrement = false;
				colvarVacunaCarne.IsNullable = true;
				colvarVacunaCarne.IsPrimaryKey = false;
				colvarVacunaCarne.IsForeignKey = false;
				colvarVacunaCarne.IsReadOnly = false;
				colvarVacunaCarne.DefaultSetting = @"";
				colvarVacunaCarne.ForeignKeyTableName = "";
				schema.Columns.Add(colvarVacunaCarne);
				
				TableSchema.TableColumn colvarVacunaCompleta = new TableSchema.TableColumn(schema);
				colvarVacunaCompleta.ColumnName = "VacunaCompleta";
				colvarVacunaCompleta.DataType = DbType.String;
				colvarVacunaCompleta.MaxLength = 2;
				colvarVacunaCompleta.AutoIncrement = false;
				colvarVacunaCompleta.IsNullable = true;
				colvarVacunaCompleta.IsPrimaryKey = false;
				colvarVacunaCompleta.IsForeignKey = false;
				colvarVacunaCompleta.IsReadOnly = false;
				colvarVacunaCompleta.DefaultSetting = @"";
				colvarVacunaCompleta.ForeignKeyTableName = "";
				schema.Columns.Add(colvarVacunaCompleta);
				
				TableSchema.TableColumn colvarEstravismo = new TableSchema.TableColumn(schema);
				colvarEstravismo.ColumnName = "Estravismo";
				colvarEstravismo.DataType = DbType.String;
				colvarEstravismo.MaxLength = 2;
				colvarEstravismo.AutoIncrement = false;
				colvarEstravismo.IsNullable = true;
				colvarEstravismo.IsPrimaryKey = false;
				colvarEstravismo.IsForeignKey = false;
				colvarEstravismo.IsReadOnly = false;
				colvarEstravismo.DefaultSetting = @"";
				colvarEstravismo.ForeignKeyTableName = "";
				schema.Columns.Add(colvarEstravismo);
				
				TableSchema.TableColumn colvarAgudezaVisualIzq = new TableSchema.TableColumn(schema);
				colvarAgudezaVisualIzq.ColumnName = "AgudezaVisualIzq";
				colvarAgudezaVisualIzq.DataType = DbType.AnsiString;
				colvarAgudezaVisualIzq.MaxLength = 10;
				colvarAgudezaVisualIzq.AutoIncrement = false;
				colvarAgudezaVisualIzq.IsNullable = true;
				colvarAgudezaVisualIzq.IsPrimaryKey = false;
				colvarAgudezaVisualIzq.IsForeignKey = false;
				colvarAgudezaVisualIzq.IsReadOnly = false;
				colvarAgudezaVisualIzq.DefaultSetting = @"";
				colvarAgudezaVisualIzq.ForeignKeyTableName = "";
				schema.Columns.Add(colvarAgudezaVisualIzq);
				
				TableSchema.TableColumn colvarAgudezaVisualDer = new TableSchema.TableColumn(schema);
				colvarAgudezaVisualDer.ColumnName = "AgudezaVisualDer";
				colvarAgudezaVisualDer.DataType = DbType.AnsiString;
				colvarAgudezaVisualDer.MaxLength = 10;
				colvarAgudezaVisualDer.AutoIncrement = false;
				colvarAgudezaVisualDer.IsNullable = true;
				colvarAgudezaVisualDer.IsPrimaryKey = false;
				colvarAgudezaVisualDer.IsForeignKey = false;
				colvarAgudezaVisualDer.IsReadOnly = false;
				colvarAgudezaVisualDer.DefaultSetting = @"";
				colvarAgudezaVisualDer.ForeignKeyTableName = "";
				schema.Columns.Add(colvarAgudezaVisualDer);
				
				TableSchema.TableColumn colvarAudiometria = new TableSchema.TableColumn(schema);
				colvarAudiometria.ColumnName = "Audiometria";
				colvarAudiometria.DataType = DbType.String;
				colvarAudiometria.MaxLength = 50;
				colvarAudiometria.AutoIncrement = false;
				colvarAudiometria.IsNullable = true;
				colvarAudiometria.IsPrimaryKey = false;
				colvarAudiometria.IsForeignKey = false;
				colvarAudiometria.IsReadOnly = false;
				colvarAudiometria.DefaultSetting = @"";
				colvarAudiometria.ForeignKeyTableName = "";
				schema.Columns.Add(colvarAudiometria);
				
				TableSchema.TableColumn colvarHipoacusia = new TableSchema.TableColumn(schema);
				colvarHipoacusia.ColumnName = "Hipoacusia";
				colvarHipoacusia.DataType = DbType.String;
				colvarHipoacusia.MaxLength = 2;
				colvarHipoacusia.AutoIncrement = false;
				colvarHipoacusia.IsNullable = true;
				colvarHipoacusia.IsPrimaryKey = false;
				colvarHipoacusia.IsForeignKey = false;
				colvarHipoacusia.IsReadOnly = false;
				colvarHipoacusia.DefaultSetting = @"";
				colvarHipoacusia.ForeignKeyTableName = "";
				schema.Columns.Add(colvarHipoacusia);
				
				TableSchema.TableColumn colvarTransFonacion = new TableSchema.TableColumn(schema);
				colvarTransFonacion.ColumnName = "TransFonacion";
				colvarTransFonacion.DataType = DbType.String;
				colvarTransFonacion.MaxLength = 2;
				colvarTransFonacion.AutoIncrement = false;
				colvarTransFonacion.IsNullable = true;
				colvarTransFonacion.IsPrimaryKey = false;
				colvarTransFonacion.IsForeignKey = false;
				colvarTransFonacion.IsReadOnly = false;
				colvarTransFonacion.DefaultSetting = @"";
				colvarTransFonacion.ForeignKeyTableName = "";
				schema.Columns.Add(colvarTransFonacion);
				
				TableSchema.TableColumn colvarObservacionesGeneral = new TableSchema.TableColumn(schema);
				colvarObservacionesGeneral.ColumnName = "ObservacionesGeneral";
				colvarObservacionesGeneral.DataType = DbType.String;
				colvarObservacionesGeneral.MaxLength = 500;
				colvarObservacionesGeneral.AutoIncrement = false;
				colvarObservacionesGeneral.IsNullable = true;
				colvarObservacionesGeneral.IsPrimaryKey = false;
				colvarObservacionesGeneral.IsForeignKey = false;
				colvarObservacionesGeneral.IsReadOnly = false;
				colvarObservacionesGeneral.DefaultSetting = @"";
				colvarObservacionesGeneral.ForeignKeyTableName = "";
				schema.Columns.Add(colvarObservacionesGeneral);
				
				TableSchema.TableColumn colvarOdontoHabitosPernciosos = new TableSchema.TableColumn(schema);
				colvarOdontoHabitosPernciosos.ColumnName = "OdontoHabitosPernciosos";
				colvarOdontoHabitosPernciosos.DataType = DbType.String;
				colvarOdontoHabitosPernciosos.MaxLength = 2;
				colvarOdontoHabitosPernciosos.AutoIncrement = false;
				colvarOdontoHabitosPernciosos.IsNullable = true;
				colvarOdontoHabitosPernciosos.IsPrimaryKey = false;
				colvarOdontoHabitosPernciosos.IsForeignKey = false;
				colvarOdontoHabitosPernciosos.IsReadOnly = false;
				colvarOdontoHabitosPernciosos.DefaultSetting = @"";
				colvarOdontoHabitosPernciosos.ForeignKeyTableName = "";
				schema.Columns.Add(colvarOdontoHabitosPernciosos);
				
				TableSchema.TableColumn colvarOdontoMaloclusion = new TableSchema.TableColumn(schema);
				colvarOdontoMaloclusion.ColumnName = "OdontoMaloclusion";
				colvarOdontoMaloclusion.DataType = DbType.String;
				colvarOdontoMaloclusion.MaxLength = 2;
				colvarOdontoMaloclusion.AutoIncrement = false;
				colvarOdontoMaloclusion.IsNullable = true;
				colvarOdontoMaloclusion.IsPrimaryKey = false;
				colvarOdontoMaloclusion.IsForeignKey = false;
				colvarOdontoMaloclusion.IsReadOnly = false;
				colvarOdontoMaloclusion.DefaultSetting = @"";
				colvarOdontoMaloclusion.ForeignKeyTableName = "";
				schema.Columns.Add(colvarOdontoMaloclusion);
				
				TableSchema.TableColumn colvarOdontoFluorAplicado = new TableSchema.TableColumn(schema);
				colvarOdontoFluorAplicado.ColumnName = "OdontoFluorAplicado";
				colvarOdontoFluorAplicado.DataType = DbType.String;
				colvarOdontoFluorAplicado.MaxLength = 2;
				colvarOdontoFluorAplicado.AutoIncrement = false;
				colvarOdontoFluorAplicado.IsNullable = true;
				colvarOdontoFluorAplicado.IsPrimaryKey = false;
				colvarOdontoFluorAplicado.IsForeignKey = false;
				colvarOdontoFluorAplicado.IsReadOnly = false;
				colvarOdontoFluorAplicado.DefaultSetting = @"";
				colvarOdontoFluorAplicado.ForeignKeyTableName = "";
				schema.Columns.Add(colvarOdontoFluorAplicado);
				
				TableSchema.TableColumn colvarUsaLentes = new TableSchema.TableColumn(schema);
				colvarUsaLentes.ColumnName = "UsaLentes";
				colvarUsaLentes.DataType = DbType.AnsiString;
				colvarUsaLentes.MaxLength = 2;
				colvarUsaLentes.AutoIncrement = false;
				colvarUsaLentes.IsNullable = true;
				colvarUsaLentes.IsPrimaryKey = false;
				colvarUsaLentes.IsForeignKey = false;
				colvarUsaLentes.IsReadOnly = false;
				colvarUsaLentes.DefaultSetting = @"";
				colvarUsaLentes.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUsaLentes);
				
				TableSchema.TableColumn colvarGrado = new TableSchema.TableColumn(schema);
				colvarGrado.ColumnName = "Grado";
				colvarGrado.DataType = DbType.AnsiString;
				colvarGrado.MaxLength = 20;
				colvarGrado.AutoIncrement = false;
				colvarGrado.IsNullable = true;
				colvarGrado.IsPrimaryKey = false;
				colvarGrado.IsForeignKey = false;
				colvarGrado.IsReadOnly = false;
				colvarGrado.DefaultSetting = @"";
				colvarGrado.ForeignKeyTableName = "";
				schema.Columns.Add(colvarGrado);
				
				TableSchema.TableColumn colvarDivision = new TableSchema.TableColumn(schema);
				colvarDivision.ColumnName = "Division";
				colvarDivision.DataType = DbType.AnsiString;
				colvarDivision.MaxLength = 20;
				colvarDivision.AutoIncrement = false;
				colvarDivision.IsNullable = true;
				colvarDivision.IsPrimaryKey = false;
				colvarDivision.IsForeignKey = false;
				colvarDivision.IsReadOnly = false;
				colvarDivision.DefaultSetting = @"";
				colvarDivision.ForeignKeyTableName = "";
				schema.Columns.Add(colvarDivision);
				
				TableSchema.TableColumn colvarTurno = new TableSchema.TableColumn(schema);
				colvarTurno.ColumnName = "Turno";
				colvarTurno.DataType = DbType.AnsiString;
				colvarTurno.MaxLength = 20;
				colvarTurno.AutoIncrement = false;
				colvarTurno.IsNullable = true;
				colvarTurno.IsPrimaryKey = false;
				colvarTurno.IsForeignKey = false;
				colvarTurno.IsReadOnly = false;
				colvarTurno.DefaultSetting = @"";
				colvarTurno.ForeignKeyTableName = "";
				schema.Columns.Add(colvarTurno);
				
				TableSchema.TableColumn colvarSexo = new TableSchema.TableColumn(schema);
				colvarSexo.ColumnName = "Sexo";
				colvarSexo.DataType = DbType.AnsiString;
				colvarSexo.MaxLength = 5;
				colvarSexo.AutoIncrement = false;
				colvarSexo.IsNullable = true;
				colvarSexo.IsPrimaryKey = false;
				colvarSexo.IsForeignKey = false;
				colvarSexo.IsReadOnly = false;
				colvarSexo.DefaultSetting = @"";
				colvarSexo.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSexo);
				
				TableSchema.TableColumn colvarZonaEstudio = new TableSchema.TableColumn(schema);
				colvarZonaEstudio.ColumnName = "ZonaEstudio";
				colvarZonaEstudio.DataType = DbType.AnsiString;
				colvarZonaEstudio.MaxLength = 3;
				colvarZonaEstudio.AutoIncrement = false;
				colvarZonaEstudio.IsNullable = true;
				colvarZonaEstudio.IsPrimaryKey = false;
				colvarZonaEstudio.IsForeignKey = false;
				colvarZonaEstudio.IsReadOnly = false;
				colvarZonaEstudio.DefaultSetting = @"";
				colvarZonaEstudio.ForeignKeyTableName = "";
				schema.Columns.Add(colvarZonaEstudio);
				
				TableSchema.TableColumn colvarPacNombre = new TableSchema.TableColumn(schema);
				colvarPacNombre.ColumnName = "PacNombre";
				colvarPacNombre.DataType = DbType.AnsiString;
				colvarPacNombre.MaxLength = 100;
				colvarPacNombre.AutoIncrement = false;
				colvarPacNombre.IsNullable = true;
				colvarPacNombre.IsPrimaryKey = false;
				colvarPacNombre.IsForeignKey = false;
				colvarPacNombre.IsReadOnly = false;
				colvarPacNombre.DefaultSetting = @"";
				colvarPacNombre.ForeignKeyTableName = "";
				schema.Columns.Add(colvarPacNombre);
				
				TableSchema.TableColumn colvarFechaNac = new TableSchema.TableColumn(schema);
				colvarFechaNac.ColumnName = "FechaNac";
				colvarFechaNac.DataType = DbType.DateTime;
				colvarFechaNac.MaxLength = 0;
				colvarFechaNac.AutoIncrement = false;
				colvarFechaNac.IsNullable = true;
				colvarFechaNac.IsPrimaryKey = false;
				colvarFechaNac.IsForeignKey = false;
				colvarFechaNac.IsReadOnly = false;
				colvarFechaNac.DefaultSetting = @"";
				colvarFechaNac.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFechaNac);
				
				TableSchema.TableColumn colvarDomicilio = new TableSchema.TableColumn(schema);
				colvarDomicilio.ColumnName = "Domicilio";
				colvarDomicilio.DataType = DbType.AnsiString;
				colvarDomicilio.MaxLength = 100;
				colvarDomicilio.AutoIncrement = false;
				colvarDomicilio.IsNullable = true;
				colvarDomicilio.IsPrimaryKey = false;
				colvarDomicilio.IsForeignKey = false;
				colvarDomicilio.IsReadOnly = false;
				colvarDomicilio.DefaultSetting = @"";
				colvarDomicilio.ForeignKeyTableName = "";
				schema.Columns.Add(colvarDomicilio);
				
				TableSchema.TableColumn colvarCelular = new TableSchema.TableColumn(schema);
				colvarCelular.ColumnName = "Celular";
				colvarCelular.DataType = DbType.AnsiString;
				colvarCelular.MaxLength = 100;
				colvarCelular.AutoIncrement = false;
				colvarCelular.IsNullable = true;
				colvarCelular.IsPrimaryKey = false;
				colvarCelular.IsForeignKey = false;
				colvarCelular.IsReadOnly = false;
				colvarCelular.DefaultSetting = @"";
				colvarCelular.ForeignKeyTableName = "";
				schema.Columns.Add(colvarCelular);
				
				TableSchema.TableColumn colvarPacOSocial = new TableSchema.TableColumn(schema);
				colvarPacOSocial.ColumnName = "PacOSocial";
				colvarPacOSocial.DataType = DbType.Int32;
				colvarPacOSocial.MaxLength = 0;
				colvarPacOSocial.AutoIncrement = false;
				colvarPacOSocial.IsNullable = true;
				colvarPacOSocial.IsPrimaryKey = false;
				colvarPacOSocial.IsForeignKey = false;
				colvarPacOSocial.IsReadOnly = false;
				colvarPacOSocial.DefaultSetting = @"";
				colvarPacOSocial.ForeignKeyTableName = "";
				schema.Columns.Add(colvarPacOSocial);
				
				TableSchema.TableColumn colvarFecha = new TableSchema.TableColumn(schema);
				colvarFecha.ColumnName = "Fecha";
				colvarFecha.DataType = DbType.DateTime;
				colvarFecha.MaxLength = 0;
				colvarFecha.AutoIncrement = false;
				colvarFecha.IsNullable = true;
				colvarFecha.IsPrimaryKey = false;
				colvarFecha.IsForeignKey = false;
				colvarFecha.IsReadOnly = false;
				colvarFecha.DefaultSetting = @"";
				colvarFecha.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFecha);
				
				TableSchema.TableColumn colvarTelefono = new TableSchema.TableColumn(schema);
				colvarTelefono.ColumnName = "Telefono";
				colvarTelefono.DataType = DbType.AnsiString;
				colvarTelefono.MaxLength = 100;
				colvarTelefono.AutoIncrement = false;
				colvarTelefono.IsNullable = true;
				colvarTelefono.IsPrimaryKey = false;
				colvarTelefono.IsForeignKey = false;
				colvarTelefono.IsReadOnly = false;
				colvarTelefono.DefaultSetting = @"";
				colvarTelefono.ForeignKeyTableName = "";
				schema.Columns.Add(colvarTelefono);
				
				TableSchema.TableColumn colvarCeod = new TableSchema.TableColumn(schema);
				colvarCeod.ColumnName = "CEOD";
				colvarCeod.DataType = DbType.Int32;
				colvarCeod.MaxLength = 0;
				colvarCeod.AutoIncrement = false;
				colvarCeod.IsNullable = true;
				colvarCeod.IsPrimaryKey = false;
				colvarCeod.IsForeignKey = false;
				colvarCeod.IsReadOnly = false;
				colvarCeod.DefaultSetting = @"";
				colvarCeod.ForeignKeyTableName = "";
				schema.Columns.Add(colvarCeod);
				
				TableSchema.TableColumn colvarCpod = new TableSchema.TableColumn(schema);
				colvarCpod.ColumnName = "CPOD";
				colvarCpod.DataType = DbType.Int32;
				colvarCpod.MaxLength = 0;
				colvarCpod.AutoIncrement = false;
				colvarCpod.IsNullable = true;
				colvarCpod.IsPrimaryKey = false;
				colvarCpod.IsForeignKey = false;
				colvarCpod.IsReadOnly = false;
				colvarCpod.DefaultSetting = @"";
				colvarCpod.ForeignKeyTableName = "";
				schema.Columns.Add(colvarCpod);
				
				TableSchema.TableColumn colvarObservaciones = new TableSchema.TableColumn(schema);
				colvarObservaciones.ColumnName = "Observaciones";
				colvarObservaciones.DataType = DbType.String;
				colvarObservaciones.MaxLength = 500;
				colvarObservaciones.AutoIncrement = false;
				colvarObservaciones.IsNullable = true;
				colvarObservaciones.IsPrimaryKey = false;
				colvarObservaciones.IsForeignKey = false;
				colvarObservaciones.IsReadOnly = false;
				colvarObservaciones.DefaultSetting = @"";
				colvarObservaciones.ForeignKeyTableName = "";
				schema.Columns.Add(colvarObservaciones);
				
				TableSchema.TableColumn colvarOSocialTiene = new TableSchema.TableColumn(schema);
				colvarOSocialTiene.ColumnName = "oSocialTiene";
				colvarOSocialTiene.DataType = DbType.AnsiString;
				colvarOSocialTiene.MaxLength = 2;
				colvarOSocialTiene.AutoIncrement = false;
				colvarOSocialTiene.IsNullable = true;
				colvarOSocialTiene.IsPrimaryKey = false;
				colvarOSocialTiene.IsForeignKey = false;
				colvarOSocialTiene.IsReadOnly = false;
				colvarOSocialTiene.DefaultSetting = @"";
				colvarOSocialTiene.ForeignKeyTableName = "";
				schema.Columns.Add(colvarOSocialTiene);
				
				TableSchema.TableColumn colvarVacRestanAplicar = new TableSchema.TableColumn(schema);
				colvarVacRestanAplicar.ColumnName = "vacRestanAplicar";
				colvarVacRestanAplicar.DataType = DbType.String;
				colvarVacRestanAplicar.MaxLength = 500;
				colvarVacRestanAplicar.AutoIncrement = false;
				colvarVacRestanAplicar.IsNullable = true;
				colvarVacRestanAplicar.IsPrimaryKey = false;
				colvarVacRestanAplicar.IsForeignKey = false;
				colvarVacRestanAplicar.IsReadOnly = false;
				colvarVacRestanAplicar.DefaultSetting = @"";
				colvarVacRestanAplicar.ForeignKeyTableName = "";
				schema.Columns.Add(colvarVacRestanAplicar);
				
				TableSchema.TableColumn colvarResponsableOdonto = new TableSchema.TableColumn(schema);
				colvarResponsableOdonto.ColumnName = "ResponsableOdonto";
				colvarResponsableOdonto.DataType = DbType.String;
				colvarResponsableOdonto.MaxLength = 100;
				colvarResponsableOdonto.AutoIncrement = false;
				colvarResponsableOdonto.IsNullable = true;
				colvarResponsableOdonto.IsPrimaryKey = false;
				colvarResponsableOdonto.IsForeignKey = false;
				colvarResponsableOdonto.IsReadOnly = false;
				colvarResponsableOdonto.DefaultSetting = @"";
				colvarResponsableOdonto.ForeignKeyTableName = "";
				schema.Columns.Add(colvarResponsableOdonto);
				
				TableSchema.TableColumn colvarResponsableFicha = new TableSchema.TableColumn(schema);
				colvarResponsableFicha.ColumnName = "ResponsableFicha";
				colvarResponsableFicha.DataType = DbType.String;
				colvarResponsableFicha.MaxLength = 100;
				colvarResponsableFicha.AutoIncrement = false;
				colvarResponsableFicha.IsNullable = true;
				colvarResponsableFicha.IsPrimaryKey = false;
				colvarResponsableFicha.IsForeignKey = false;
				colvarResponsableFicha.IsReadOnly = false;
				colvarResponsableFicha.DefaultSetting = @"";
				colvarResponsableFicha.ForeignKeyTableName = "";
				schema.Columns.Add(colvarResponsableFicha);
				
				TableSchema.TableColumn colvarAudiometriaValor = new TableSchema.TableColumn(schema);
				colvarAudiometriaValor.ColumnName = "audiometriaValor";
				colvarAudiometriaValor.DataType = DbType.Decimal;
				colvarAudiometriaValor.MaxLength = 0;
				colvarAudiometriaValor.AutoIncrement = false;
				colvarAudiometriaValor.IsNullable = true;
				colvarAudiometriaValor.IsPrimaryKey = false;
				colvarAudiometriaValor.IsForeignKey = false;
				colvarAudiometriaValor.IsReadOnly = false;
				colvarAudiometriaValor.DefaultSetting = @"";
				colvarAudiometriaValor.ForeignKeyTableName = "";
				schema.Columns.Add(colvarAudiometriaValor);
				
				TableSchema.TableColumn colvarPesoAlumno = new TableSchema.TableColumn(schema);
				colvarPesoAlumno.ColumnName = "PesoAlumno";
				colvarPesoAlumno.DataType = DbType.Decimal;
				colvarPesoAlumno.MaxLength = 0;
				colvarPesoAlumno.AutoIncrement = false;
				colvarPesoAlumno.IsNullable = true;
				colvarPesoAlumno.IsPrimaryKey = false;
				colvarPesoAlumno.IsForeignKey = false;
				colvarPesoAlumno.IsReadOnly = false;
				colvarPesoAlumno.DefaultSetting = @"";
				colvarPesoAlumno.ForeignKeyTableName = "";
				schema.Columns.Add(colvarPesoAlumno);
				
				TableSchema.TableColumn colvarVacSevacEsc = new TableSchema.TableColumn(schema);
				colvarVacSevacEsc.ColumnName = "VacSevacEsc";
				colvarVacSevacEsc.DataType = DbType.String;
				colvarVacSevacEsc.MaxLength = 2;
				colvarVacSevacEsc.AutoIncrement = false;
				colvarVacSevacEsc.IsNullable = true;
				colvarVacSevacEsc.IsPrimaryKey = false;
				colvarVacSevacEsc.IsForeignKey = false;
				colvarVacSevacEsc.IsReadOnly = false;
				colvarVacSevacEsc.DefaultSetting = @"";
				colvarVacSevacEsc.ForeignKeyTableName = "";
				schema.Columns.Add(colvarVacSevacEsc);
				
				TableSchema.TableColumn colvarOdontoCariado = new TableSchema.TableColumn(schema);
				colvarOdontoCariado.ColumnName = "OdontoCariado";
				colvarOdontoCariado.DataType = DbType.Int32;
				colvarOdontoCariado.MaxLength = 0;
				colvarOdontoCariado.AutoIncrement = false;
				colvarOdontoCariado.IsNullable = true;
				colvarOdontoCariado.IsPrimaryKey = false;
				colvarOdontoCariado.IsForeignKey = false;
				colvarOdontoCariado.IsReadOnly = false;
				colvarOdontoCariado.DefaultSetting = @"";
				colvarOdontoCariado.ForeignKeyTableName = "";
				schema.Columns.Add(colvarOdontoCariado);
				
				TableSchema.TableColumn colvarIdProfesionalFicha = new TableSchema.TableColumn(schema);
				colvarIdProfesionalFicha.ColumnName = "idProfesionalFicha";
				colvarIdProfesionalFicha.DataType = DbType.Int32;
				colvarIdProfesionalFicha.MaxLength = 0;
				colvarIdProfesionalFicha.AutoIncrement = false;
				colvarIdProfesionalFicha.IsNullable = true;
				colvarIdProfesionalFicha.IsPrimaryKey = false;
				colvarIdProfesionalFicha.IsForeignKey = false;
				colvarIdProfesionalFicha.IsReadOnly = false;
				colvarIdProfesionalFicha.DefaultSetting = @"";
				colvarIdProfesionalFicha.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdProfesionalFicha);
				
				TableSchema.TableColumn colvarIdProfesionalOdonto = new TableSchema.TableColumn(schema);
				colvarIdProfesionalOdonto.ColumnName = "idProfesionalOdonto";
				colvarIdProfesionalOdonto.DataType = DbType.Int32;
				colvarIdProfesionalOdonto.MaxLength = 0;
				colvarIdProfesionalOdonto.AutoIncrement = false;
				colvarIdProfesionalOdonto.IsNullable = true;
				colvarIdProfesionalOdonto.IsPrimaryKey = false;
				colvarIdProfesionalOdonto.IsForeignKey = false;
				colvarIdProfesionalOdonto.IsReadOnly = false;
				colvarIdProfesionalOdonto.DefaultSetting = @"";
				colvarIdProfesionalOdonto.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdProfesionalOdonto);
				
				TableSchema.TableColumn colvarFonoAudiometria = new TableSchema.TableColumn(schema);
				colvarFonoAudiometria.ColumnName = "FonoAudiometria";
				colvarFonoAudiometria.DataType = DbType.String;
				colvarFonoAudiometria.MaxLength = 2;
				colvarFonoAudiometria.AutoIncrement = false;
				colvarFonoAudiometria.IsNullable = true;
				colvarFonoAudiometria.IsPrimaryKey = false;
				colvarFonoAudiometria.IsForeignKey = false;
				colvarFonoAudiometria.IsReadOnly = false;
				colvarFonoAudiometria.DefaultSetting = @"";
				colvarFonoAudiometria.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFonoAudiometria);
				
				TableSchema.TableColumn colvarFonoTato = new TableSchema.TableColumn(schema);
				colvarFonoTato.ColumnName = "FonoTato";
				colvarFonoTato.DataType = DbType.String;
				colvarFonoTato.MaxLength = 2;
				colvarFonoTato.AutoIncrement = false;
				colvarFonoTato.IsNullable = true;
				colvarFonoTato.IsPrimaryKey = false;
				colvarFonoTato.IsForeignKey = false;
				colvarFonoTato.IsReadOnly = false;
				colvarFonoTato.DefaultSetting = @"";
				colvarFonoTato.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFonoTato);
				
				TableSchema.TableColumn colvarFonoDiapason = new TableSchema.TableColumn(schema);
				colvarFonoDiapason.ColumnName = "FonoDiapason";
				colvarFonoDiapason.DataType = DbType.String;
				colvarFonoDiapason.MaxLength = 2;
				colvarFonoDiapason.AutoIncrement = false;
				colvarFonoDiapason.IsNullable = true;
				colvarFonoDiapason.IsPrimaryKey = false;
				colvarFonoDiapason.IsForeignKey = false;
				colvarFonoDiapason.IsReadOnly = false;
				colvarFonoDiapason.DefaultSetting = @"";
				colvarFonoDiapason.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFonoDiapason);
				
				TableSchema.TableColumn colvarTatoValor = new TableSchema.TableColumn(schema);
				colvarTatoValor.ColumnName = "TatoValor";
				colvarTatoValor.DataType = DbType.String;
				colvarTatoValor.MaxLength = 10;
				colvarTatoValor.AutoIncrement = false;
				colvarTatoValor.IsNullable = true;
				colvarTatoValor.IsPrimaryKey = false;
				colvarTatoValor.IsForeignKey = false;
				colvarTatoValor.IsReadOnly = false;
				colvarTatoValor.DefaultSetting = @"";
				colvarTatoValor.ForeignKeyTableName = "";
				schema.Columns.Add(colvarTatoValor);
				
				TableSchema.TableColumn colvarAutorizado = new TableSchema.TableColumn(schema);
				colvarAutorizado.ColumnName = "Autorizado";
				colvarAutorizado.DataType = DbType.String;
				colvarAutorizado.MaxLength = 2;
				colvarAutorizado.AutoIncrement = false;
				colvarAutorizado.IsNullable = true;
				colvarAutorizado.IsPrimaryKey = false;
				colvarAutorizado.IsForeignKey = false;
				colvarAutorizado.IsReadOnly = false;
				colvarAutorizado.DefaultSetting = @"";
				colvarAutorizado.ForeignKeyTableName = "";
				schema.Columns.Add(colvarAutorizado);
				
				TableSchema.TableColumn colvarIdProvincia = new TableSchema.TableColumn(schema);
				colvarIdProvincia.ColumnName = "idProvincia";
				colvarIdProvincia.DataType = DbType.Int32;
				colvarIdProvincia.MaxLength = 0;
				colvarIdProvincia.AutoIncrement = false;
				colvarIdProvincia.IsNullable = true;
				colvarIdProvincia.IsPrimaryKey = false;
				colvarIdProvincia.IsForeignKey = false;
				colvarIdProvincia.IsReadOnly = false;
				colvarIdProvincia.DefaultSetting = @"";
				colvarIdProvincia.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdProvincia);
				
				TableSchema.TableColumn colvarIdDepartamento = new TableSchema.TableColumn(schema);
				colvarIdDepartamento.ColumnName = "idDepartamento";
				colvarIdDepartamento.DataType = DbType.Int32;
				colvarIdDepartamento.MaxLength = 0;
				colvarIdDepartamento.AutoIncrement = false;
				colvarIdDepartamento.IsNullable = true;
				colvarIdDepartamento.IsPrimaryKey = false;
				colvarIdDepartamento.IsForeignKey = false;
				colvarIdDepartamento.IsReadOnly = false;
				colvarIdDepartamento.DefaultSetting = @"";
				colvarIdDepartamento.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdDepartamento);
				
				TableSchema.TableColumn colvarIdDLocalidad = new TableSchema.TableColumn(schema);
				colvarIdDLocalidad.ColumnName = "idDLocalidad";
				colvarIdDLocalidad.DataType = DbType.Int32;
				colvarIdDLocalidad.MaxLength = 0;
				colvarIdDLocalidad.AutoIncrement = false;
				colvarIdDLocalidad.IsNullable = true;
				colvarIdDLocalidad.IsPrimaryKey = false;
				colvarIdDLocalidad.IsForeignKey = false;
				colvarIdDLocalidad.IsReadOnly = false;
				colvarIdDLocalidad.DefaultSetting = @"";
				colvarIdDLocalidad.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdDLocalidad);
				
				TableSchema.TableColumn colvarIdLocalidad = new TableSchema.TableColumn(schema);
				colvarIdLocalidad.ColumnName = "idLocalidad";
				colvarIdLocalidad.DataType = DbType.Int32;
				colvarIdLocalidad.MaxLength = 0;
				colvarIdLocalidad.AutoIncrement = false;
				colvarIdLocalidad.IsNullable = true;
				colvarIdLocalidad.IsPrimaryKey = false;
				colvarIdLocalidad.IsForeignKey = false;
				colvarIdLocalidad.IsReadOnly = false;
				colvarIdLocalidad.DefaultSetting = @"";
				colvarIdLocalidad.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdLocalidad);
				
				TableSchema.TableColumn colvarTatoValor1 = new TableSchema.TableColumn(schema);
				colvarTatoValor1.ColumnName = "tatoValor1";
				colvarTatoValor1.DataType = DbType.Int32;
				colvarTatoValor1.MaxLength = 0;
				colvarTatoValor1.AutoIncrement = false;
				colvarTatoValor1.IsNullable = true;
				colvarTatoValor1.IsPrimaryKey = false;
				colvarTatoValor1.IsForeignKey = false;
				colvarTatoValor1.IsReadOnly = false;
				colvarTatoValor1.DefaultSetting = @"";
				colvarTatoValor1.ForeignKeyTableName = "";
				schema.Columns.Add(colvarTatoValor1);
				
				TableSchema.TableColumn colvarIdUsuarioCarga = new TableSchema.TableColumn(schema);
				colvarIdUsuarioCarga.ColumnName = "idUsuarioCarga";
				colvarIdUsuarioCarga.DataType = DbType.Int32;
				colvarIdUsuarioCarga.MaxLength = 0;
				colvarIdUsuarioCarga.AutoIncrement = false;
				colvarIdUsuarioCarga.IsNullable = false;
				colvarIdUsuarioCarga.IsPrimaryKey = false;
				colvarIdUsuarioCarga.IsForeignKey = false;
				colvarIdUsuarioCarga.IsReadOnly = false;
				
						colvarIdUsuarioCarga.DefaultSetting = @"((0))";
				colvarIdUsuarioCarga.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdUsuarioCarga);
				
				TableSchema.TableColumn colvarFechaCarga = new TableSchema.TableColumn(schema);
				colvarFechaCarga.ColumnName = "fechaCarga";
				colvarFechaCarga.DataType = DbType.DateTime;
				colvarFechaCarga.MaxLength = 0;
				colvarFechaCarga.AutoIncrement = false;
				colvarFechaCarga.IsNullable = false;
				colvarFechaCarga.IsPrimaryKey = false;
				colvarFechaCarga.IsForeignKey = false;
				colvarFechaCarga.IsReadOnly = false;
				
						colvarFechaCarga.DefaultSetting = @"(((1)/(1))/(1900))";
				colvarFechaCarga.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFechaCarga);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["RisProvider"].AddSchema("PSM_Datos1",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("IdProsame")]
		[Bindable(true)]
		public int IdProsame 
		{
			get { return GetColumnValue<int>(Columns.IdProsame); }
			set { SetColumnValue(Columns.IdProsame, value); }
		}
		  
		[XmlAttribute("IdPaciente")]
		[Bindable(true)]
		public decimal IdPaciente 
		{
			get { return GetColumnValue<decimal>(Columns.IdPaciente); }
			set { SetColumnValue(Columns.IdPaciente, value); }
		}
		  
		[XmlAttribute("IdEfector")]
		[Bindable(true)]
		public decimal IdEfector 
		{
			get { return GetColumnValue<decimal>(Columns.IdEfector); }
			set { SetColumnValue(Columns.IdEfector, value); }
		}
		  
		[XmlAttribute("DNIPaciente")]
		[Bindable(true)]
		public int? DNIPaciente 
		{
			get { return GetColumnValue<int?>(Columns.DNIPaciente); }
			set { SetColumnValue(Columns.DNIPaciente, value); }
		}
		  
		[XmlAttribute("IdEstablecimiento")]
		[Bindable(true)]
		public decimal? IdEstablecimiento 
		{
			get { return GetColumnValue<decimal?>(Columns.IdEstablecimiento); }
			set { SetColumnValue(Columns.IdEstablecimiento, value); }
		}
		  
		[XmlAttribute("Prematuro")]
		[Bindable(true)]
		public string Prematuro 
		{
			get { return GetColumnValue<string>(Columns.Prematuro); }
			set { SetColumnValue(Columns.Prematuro, value); }
		}
		  
		[XmlAttribute("TutorDNI")]
		[Bindable(true)]
		public decimal? TutorDNI 
		{
			get { return GetColumnValue<decimal?>(Columns.TutorDNI); }
			set { SetColumnValue(Columns.TutorDNI, value); }
		}
		  
		[XmlAttribute("TutorNombre")]
		[Bindable(true)]
		public string TutorNombre 
		{
			get { return GetColumnValue<string>(Columns.TutorNombre); }
			set { SetColumnValue(Columns.TutorNombre, value); }
		}
		  
		[XmlAttribute("SobreEdad")]
		[Bindable(true)]
		public string SobreEdad 
		{
			get { return GetColumnValue<string>(Columns.SobreEdad); }
			set { SetColumnValue(Columns.SobreEdad, value); }
		}
		  
		[XmlAttribute("Repitente")]
		[Bindable(true)]
		public string Repitente 
		{
			get { return GetColumnValue<string>(Columns.Repitente); }
			set { SetColumnValue(Columns.Repitente, value); }
		}
		  
		[XmlAttribute("Peso")]
		[Bindable(true)]
		public decimal? Peso 
		{
			get { return GetColumnValue<decimal?>(Columns.Peso); }
			set { SetColumnValue(Columns.Peso, value); }
		}
		  
		[XmlAttribute("Talla")]
		[Bindable(true)]
		public decimal? Talla 
		{
			get { return GetColumnValue<decimal?>(Columns.Talla); }
			set { SetColumnValue(Columns.Talla, value); }
		}
		  
		[XmlAttribute("Imc")]
		[Bindable(true)]
		public decimal? Imc 
		{
			get { return GetColumnValue<decimal?>(Columns.Imc); }
			set { SetColumnValue(Columns.Imc, value); }
		}
		  
		[XmlAttribute("TaMax")]
		[Bindable(true)]
		public decimal? TaMax 
		{
			get { return GetColumnValue<decimal?>(Columns.TaMax); }
			set { SetColumnValue(Columns.TaMax, value); }
		}
		  
		[XmlAttribute("TaMin")]
		[Bindable(true)]
		public decimal? TaMin 
		{
			get { return GetColumnValue<decimal?>(Columns.TaMin); }
			set { SetColumnValue(Columns.TaMin, value); }
		}
		  
		[XmlAttribute("PercentiloPeso")]
		[Bindable(true)]
		public decimal? PercentiloPeso 
		{
			get { return GetColumnValue<decimal?>(Columns.PercentiloPeso); }
			set { SetColumnValue(Columns.PercentiloPeso, value); }
		}
		  
		[XmlAttribute("PercentiloTalla")]
		[Bindable(true)]
		public decimal? PercentiloTalla 
		{
			get { return GetColumnValue<decimal?>(Columns.PercentiloTalla); }
			set { SetColumnValue(Columns.PercentiloTalla, value); }
		}
		  
		[XmlAttribute("PercentiloIMC")]
		[Bindable(true)]
		public decimal? PercentiloIMC 
		{
			get { return GetColumnValue<decimal?>(Columns.PercentiloIMC); }
			set { SetColumnValue(Columns.PercentiloIMC, value); }
		}
		  
		[XmlAttribute("PercentiloMax")]
		[Bindable(true)]
		public decimal? PercentiloMax 
		{
			get { return GetColumnValue<decimal?>(Columns.PercentiloMax); }
			set { SetColumnValue(Columns.PercentiloMax, value); }
		}
		  
		[XmlAttribute("PercentiloMin")]
		[Bindable(true)]
		public decimal? PercentiloMin 
		{
			get { return GetColumnValue<decimal?>(Columns.PercentiloMin); }
			set { SetColumnValue(Columns.PercentiloMin, value); }
		}
		  
		[XmlAttribute("EFPielFanera")]
		[Bindable(true)]
		public decimal? EFPielFanera 
		{
			get { return GetColumnValue<decimal?>(Columns.EFPielFanera); }
			set { SetColumnValue(Columns.EFPielFanera, value); }
		}
		  
		[XmlAttribute("EFCardiovascular")]
		[Bindable(true)]
		public decimal? EFCardiovascular 
		{
			get { return GetColumnValue<decimal?>(Columns.EFCardiovascular); }
			set { SetColumnValue(Columns.EFCardiovascular, value); }
		}
		  
		[XmlAttribute("EFRespiratorio")]
		[Bindable(true)]
		public decimal? EFRespiratorio 
		{
			get { return GetColumnValue<decimal?>(Columns.EFRespiratorio); }
			set { SetColumnValue(Columns.EFRespiratorio, value); }
		}
		  
		[XmlAttribute("EFGenital")]
		[Bindable(true)]
		public decimal? EFGenital 
		{
			get { return GetColumnValue<decimal?>(Columns.EFGenital); }
			set { SetColumnValue(Columns.EFGenital, value); }
		}
		  
		[XmlAttribute("EFAbdomen")]
		[Bindable(true)]
		public decimal? EFAbdomen 
		{
			get { return GetColumnValue<decimal?>(Columns.EFAbdomen); }
			set { SetColumnValue(Columns.EFAbdomen, value); }
		}
		  
		[XmlAttribute("EFOsteoarticular")]
		[Bindable(true)]
		public decimal? EFOsteoarticular 
		{
			get { return GetColumnValue<decimal?>(Columns.EFOsteoarticular); }
			set { SetColumnValue(Columns.EFOsteoarticular, value); }
		}
		  
		[XmlAttribute("EFNeurologico")]
		[Bindable(true)]
		public decimal? EFNeurologico 
		{
			get { return GetColumnValue<decimal?>(Columns.EFNeurologico); }
			set { SetColumnValue(Columns.EFNeurologico, value); }
		}
		  
		[XmlAttribute("VacunaCarne")]
		[Bindable(true)]
		public string VacunaCarne 
		{
			get { return GetColumnValue<string>(Columns.VacunaCarne); }
			set { SetColumnValue(Columns.VacunaCarne, value); }
		}
		  
		[XmlAttribute("VacunaCompleta")]
		[Bindable(true)]
		public string VacunaCompleta 
		{
			get { return GetColumnValue<string>(Columns.VacunaCompleta); }
			set { SetColumnValue(Columns.VacunaCompleta, value); }
		}
		  
		[XmlAttribute("Estravismo")]
		[Bindable(true)]
		public string Estravismo 
		{
			get { return GetColumnValue<string>(Columns.Estravismo); }
			set { SetColumnValue(Columns.Estravismo, value); }
		}
		  
		[XmlAttribute("AgudezaVisualIzq")]
		[Bindable(true)]
		public string AgudezaVisualIzq 
		{
			get { return GetColumnValue<string>(Columns.AgudezaVisualIzq); }
			set { SetColumnValue(Columns.AgudezaVisualIzq, value); }
		}
		  
		[XmlAttribute("AgudezaVisualDer")]
		[Bindable(true)]
		public string AgudezaVisualDer 
		{
			get { return GetColumnValue<string>(Columns.AgudezaVisualDer); }
			set { SetColumnValue(Columns.AgudezaVisualDer, value); }
		}
		  
		[XmlAttribute("Audiometria")]
		[Bindable(true)]
		public string Audiometria 
		{
			get { return GetColumnValue<string>(Columns.Audiometria); }
			set { SetColumnValue(Columns.Audiometria, value); }
		}
		  
		[XmlAttribute("Hipoacusia")]
		[Bindable(true)]
		public string Hipoacusia 
		{
			get { return GetColumnValue<string>(Columns.Hipoacusia); }
			set { SetColumnValue(Columns.Hipoacusia, value); }
		}
		  
		[XmlAttribute("TransFonacion")]
		[Bindable(true)]
		public string TransFonacion 
		{
			get { return GetColumnValue<string>(Columns.TransFonacion); }
			set { SetColumnValue(Columns.TransFonacion, value); }
		}
		  
		[XmlAttribute("ObservacionesGeneral")]
		[Bindable(true)]
		public string ObservacionesGeneral 
		{
			get { return GetColumnValue<string>(Columns.ObservacionesGeneral); }
			set { SetColumnValue(Columns.ObservacionesGeneral, value); }
		}
		  
		[XmlAttribute("OdontoHabitosPernciosos")]
		[Bindable(true)]
		public string OdontoHabitosPernciosos 
		{
			get { return GetColumnValue<string>(Columns.OdontoHabitosPernciosos); }
			set { SetColumnValue(Columns.OdontoHabitosPernciosos, value); }
		}
		  
		[XmlAttribute("OdontoMaloclusion")]
		[Bindable(true)]
		public string OdontoMaloclusion 
		{
			get { return GetColumnValue<string>(Columns.OdontoMaloclusion); }
			set { SetColumnValue(Columns.OdontoMaloclusion, value); }
		}
		  
		[XmlAttribute("OdontoFluorAplicado")]
		[Bindable(true)]
		public string OdontoFluorAplicado 
		{
			get { return GetColumnValue<string>(Columns.OdontoFluorAplicado); }
			set { SetColumnValue(Columns.OdontoFluorAplicado, value); }
		}
		  
		[XmlAttribute("UsaLentes")]
		[Bindable(true)]
		public string UsaLentes 
		{
			get { return GetColumnValue<string>(Columns.UsaLentes); }
			set { SetColumnValue(Columns.UsaLentes, value); }
		}
		  
		[XmlAttribute("Grado")]
		[Bindable(true)]
		public string Grado 
		{
			get { return GetColumnValue<string>(Columns.Grado); }
			set { SetColumnValue(Columns.Grado, value); }
		}
		  
		[XmlAttribute("Division")]
		[Bindable(true)]
		public string Division 
		{
			get { return GetColumnValue<string>(Columns.Division); }
			set { SetColumnValue(Columns.Division, value); }
		}
		  
		[XmlAttribute("Turno")]
		[Bindable(true)]
		public string Turno 
		{
			get { return GetColumnValue<string>(Columns.Turno); }
			set { SetColumnValue(Columns.Turno, value); }
		}
		  
		[XmlAttribute("Sexo")]
		[Bindable(true)]
		public string Sexo 
		{
			get { return GetColumnValue<string>(Columns.Sexo); }
			set { SetColumnValue(Columns.Sexo, value); }
		}
		  
		[XmlAttribute("ZonaEstudio")]
		[Bindable(true)]
		public string ZonaEstudio 
		{
			get { return GetColumnValue<string>(Columns.ZonaEstudio); }
			set { SetColumnValue(Columns.ZonaEstudio, value); }
		}
		  
		[XmlAttribute("PacNombre")]
		[Bindable(true)]
		public string PacNombre 
		{
			get { return GetColumnValue<string>(Columns.PacNombre); }
			set { SetColumnValue(Columns.PacNombre, value); }
		}
		  
		[XmlAttribute("FechaNac")]
		[Bindable(true)]
		public DateTime? FechaNac 
		{
			get { return GetColumnValue<DateTime?>(Columns.FechaNac); }
			set { SetColumnValue(Columns.FechaNac, value); }
		}
		  
		[XmlAttribute("Domicilio")]
		[Bindable(true)]
		public string Domicilio 
		{
			get { return GetColumnValue<string>(Columns.Domicilio); }
			set { SetColumnValue(Columns.Domicilio, value); }
		}
		  
		[XmlAttribute("Celular")]
		[Bindable(true)]
		public string Celular 
		{
			get { return GetColumnValue<string>(Columns.Celular); }
			set { SetColumnValue(Columns.Celular, value); }
		}
		  
		[XmlAttribute("PacOSocial")]
		[Bindable(true)]
		public int? PacOSocial 
		{
			get { return GetColumnValue<int?>(Columns.PacOSocial); }
			set { SetColumnValue(Columns.PacOSocial, value); }
		}
		  
		[XmlAttribute("Fecha")]
		[Bindable(true)]
		public DateTime? Fecha 
		{
			get { return GetColumnValue<DateTime?>(Columns.Fecha); }
			set { SetColumnValue(Columns.Fecha, value); }
		}
		  
		[XmlAttribute("Telefono")]
		[Bindable(true)]
		public string Telefono 
		{
			get { return GetColumnValue<string>(Columns.Telefono); }
			set { SetColumnValue(Columns.Telefono, value); }
		}
		  
		[XmlAttribute("Ceod")]
		[Bindable(true)]
		public int? Ceod 
		{
			get { return GetColumnValue<int?>(Columns.Ceod); }
			set { SetColumnValue(Columns.Ceod, value); }
		}
		  
		[XmlAttribute("Cpod")]
		[Bindable(true)]
		public int? Cpod 
		{
			get { return GetColumnValue<int?>(Columns.Cpod); }
			set { SetColumnValue(Columns.Cpod, value); }
		}
		  
		[XmlAttribute("Observaciones")]
		[Bindable(true)]
		public string Observaciones 
		{
			get { return GetColumnValue<string>(Columns.Observaciones); }
			set { SetColumnValue(Columns.Observaciones, value); }
		}
		  
		[XmlAttribute("OSocialTiene")]
		[Bindable(true)]
		public string OSocialTiene 
		{
			get { return GetColumnValue<string>(Columns.OSocialTiene); }
			set { SetColumnValue(Columns.OSocialTiene, value); }
		}
		  
		[XmlAttribute("VacRestanAplicar")]
		[Bindable(true)]
		public string VacRestanAplicar 
		{
			get { return GetColumnValue<string>(Columns.VacRestanAplicar); }
			set { SetColumnValue(Columns.VacRestanAplicar, value); }
		}
		  
		[XmlAttribute("ResponsableOdonto")]
		[Bindable(true)]
		public string ResponsableOdonto 
		{
			get { return GetColumnValue<string>(Columns.ResponsableOdonto); }
			set { SetColumnValue(Columns.ResponsableOdonto, value); }
		}
		  
		[XmlAttribute("ResponsableFicha")]
		[Bindable(true)]
		public string ResponsableFicha 
		{
			get { return GetColumnValue<string>(Columns.ResponsableFicha); }
			set { SetColumnValue(Columns.ResponsableFicha, value); }
		}
		  
		[XmlAttribute("AudiometriaValor")]
		[Bindable(true)]
		public decimal? AudiometriaValor 
		{
			get { return GetColumnValue<decimal?>(Columns.AudiometriaValor); }
			set { SetColumnValue(Columns.AudiometriaValor, value); }
		}
		  
		[XmlAttribute("PesoAlumno")]
		[Bindable(true)]
		public decimal? PesoAlumno 
		{
			get { return GetColumnValue<decimal?>(Columns.PesoAlumno); }
			set { SetColumnValue(Columns.PesoAlumno, value); }
		}
		  
		[XmlAttribute("VacSevacEsc")]
		[Bindable(true)]
		public string VacSevacEsc 
		{
			get { return GetColumnValue<string>(Columns.VacSevacEsc); }
			set { SetColumnValue(Columns.VacSevacEsc, value); }
		}
		  
		[XmlAttribute("OdontoCariado")]
		[Bindable(true)]
		public int? OdontoCariado 
		{
			get { return GetColumnValue<int?>(Columns.OdontoCariado); }
			set { SetColumnValue(Columns.OdontoCariado, value); }
		}
		  
		[XmlAttribute("IdProfesionalFicha")]
		[Bindable(true)]
		public int? IdProfesionalFicha 
		{
			get { return GetColumnValue<int?>(Columns.IdProfesionalFicha); }
			set { SetColumnValue(Columns.IdProfesionalFicha, value); }
		}
		  
		[XmlAttribute("IdProfesionalOdonto")]
		[Bindable(true)]
		public int? IdProfesionalOdonto 
		{
			get { return GetColumnValue<int?>(Columns.IdProfesionalOdonto); }
			set { SetColumnValue(Columns.IdProfesionalOdonto, value); }
		}
		  
		[XmlAttribute("FonoAudiometria")]
		[Bindable(true)]
		public string FonoAudiometria 
		{
			get { return GetColumnValue<string>(Columns.FonoAudiometria); }
			set { SetColumnValue(Columns.FonoAudiometria, value); }
		}
		  
		[XmlAttribute("FonoTato")]
		[Bindable(true)]
		public string FonoTato 
		{
			get { return GetColumnValue<string>(Columns.FonoTato); }
			set { SetColumnValue(Columns.FonoTato, value); }
		}
		  
		[XmlAttribute("FonoDiapason")]
		[Bindable(true)]
		public string FonoDiapason 
		{
			get { return GetColumnValue<string>(Columns.FonoDiapason); }
			set { SetColumnValue(Columns.FonoDiapason, value); }
		}
		  
		[XmlAttribute("TatoValor")]
		[Bindable(true)]
		public string TatoValor 
		{
			get { return GetColumnValue<string>(Columns.TatoValor); }
			set { SetColumnValue(Columns.TatoValor, value); }
		}
		  
		[XmlAttribute("Autorizado")]
		[Bindable(true)]
		public string Autorizado 
		{
			get { return GetColumnValue<string>(Columns.Autorizado); }
			set { SetColumnValue(Columns.Autorizado, value); }
		}
		  
		[XmlAttribute("IdProvincia")]
		[Bindable(true)]
		public int? IdProvincia 
		{
			get { return GetColumnValue<int?>(Columns.IdProvincia); }
			set { SetColumnValue(Columns.IdProvincia, value); }
		}
		  
		[XmlAttribute("IdDepartamento")]
		[Bindable(true)]
		public int? IdDepartamento 
		{
			get { return GetColumnValue<int?>(Columns.IdDepartamento); }
			set { SetColumnValue(Columns.IdDepartamento, value); }
		}
		  
		[XmlAttribute("IdDLocalidad")]
		[Bindable(true)]
		public int? IdDLocalidad 
		{
			get { return GetColumnValue<int?>(Columns.IdDLocalidad); }
			set { SetColumnValue(Columns.IdDLocalidad, value); }
		}
		  
		[XmlAttribute("IdLocalidad")]
		[Bindable(true)]
		public int? IdLocalidad 
		{
			get { return GetColumnValue<int?>(Columns.IdLocalidad); }
			set { SetColumnValue(Columns.IdLocalidad, value); }
		}
		  
		[XmlAttribute("TatoValor1")]
		[Bindable(true)]
		public int? TatoValor1 
		{
			get { return GetColumnValue<int?>(Columns.TatoValor1); }
			set { SetColumnValue(Columns.TatoValor1, value); }
		}
		  
		[XmlAttribute("IdUsuarioCarga")]
		[Bindable(true)]
		public int IdUsuarioCarga 
		{
			get { return GetColumnValue<int>(Columns.IdUsuarioCarga); }
			set { SetColumnValue(Columns.IdUsuarioCarga, value); }
		}
		  
		[XmlAttribute("FechaCarga")]
		[Bindable(true)]
		public DateTime FechaCarga 
		{
			get { return GetColumnValue<DateTime>(Columns.FechaCarga); }
			set { SetColumnValue(Columns.FechaCarga, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(decimal varIdPaciente,decimal varIdEfector,int? varDNIPaciente,decimal? varIdEstablecimiento,string varPrematuro,decimal? varTutorDNI,string varTutorNombre,string varSobreEdad,string varRepitente,decimal? varPeso,decimal? varTalla,decimal? varImc,decimal? varTaMax,decimal? varTaMin,decimal? varPercentiloPeso,decimal? varPercentiloTalla,decimal? varPercentiloIMC,decimal? varPercentiloMax,decimal? varPercentiloMin,decimal? varEFPielFanera,decimal? varEFCardiovascular,decimal? varEFRespiratorio,decimal? varEFGenital,decimal? varEFAbdomen,decimal? varEFOsteoarticular,decimal? varEFNeurologico,string varVacunaCarne,string varVacunaCompleta,string varEstravismo,string varAgudezaVisualIzq,string varAgudezaVisualDer,string varAudiometria,string varHipoacusia,string varTransFonacion,string varObservacionesGeneral,string varOdontoHabitosPernciosos,string varOdontoMaloclusion,string varOdontoFluorAplicado,string varUsaLentes,string varGrado,string varDivision,string varTurno,string varSexo,string varZonaEstudio,string varPacNombre,DateTime? varFechaNac,string varDomicilio,string varCelular,int? varPacOSocial,DateTime? varFecha,string varTelefono,int? varCeod,int? varCpod,string varObservaciones,string varOSocialTiene,string varVacRestanAplicar,string varResponsableOdonto,string varResponsableFicha,decimal? varAudiometriaValor,decimal? varPesoAlumno,string varVacSevacEsc,int? varOdontoCariado,int? varIdProfesionalFicha,int? varIdProfesionalOdonto,string varFonoAudiometria,string varFonoTato,string varFonoDiapason,string varTatoValor,string varAutorizado,int? varIdProvincia,int? varIdDepartamento,int? varIdDLocalidad,int? varIdLocalidad,int? varTatoValor1,int varIdUsuarioCarga,DateTime varFechaCarga)
		{
			PsmDatos1 item = new PsmDatos1();
			
			item.IdPaciente = varIdPaciente;
			
			item.IdEfector = varIdEfector;
			
			item.DNIPaciente = varDNIPaciente;
			
			item.IdEstablecimiento = varIdEstablecimiento;
			
			item.Prematuro = varPrematuro;
			
			item.TutorDNI = varTutorDNI;
			
			item.TutorNombre = varTutorNombre;
			
			item.SobreEdad = varSobreEdad;
			
			item.Repitente = varRepitente;
			
			item.Peso = varPeso;
			
			item.Talla = varTalla;
			
			item.Imc = varImc;
			
			item.TaMax = varTaMax;
			
			item.TaMin = varTaMin;
			
			item.PercentiloPeso = varPercentiloPeso;
			
			item.PercentiloTalla = varPercentiloTalla;
			
			item.PercentiloIMC = varPercentiloIMC;
			
			item.PercentiloMax = varPercentiloMax;
			
			item.PercentiloMin = varPercentiloMin;
			
			item.EFPielFanera = varEFPielFanera;
			
			item.EFCardiovascular = varEFCardiovascular;
			
			item.EFRespiratorio = varEFRespiratorio;
			
			item.EFGenital = varEFGenital;
			
			item.EFAbdomen = varEFAbdomen;
			
			item.EFOsteoarticular = varEFOsteoarticular;
			
			item.EFNeurologico = varEFNeurologico;
			
			item.VacunaCarne = varVacunaCarne;
			
			item.VacunaCompleta = varVacunaCompleta;
			
			item.Estravismo = varEstravismo;
			
			item.AgudezaVisualIzq = varAgudezaVisualIzq;
			
			item.AgudezaVisualDer = varAgudezaVisualDer;
			
			item.Audiometria = varAudiometria;
			
			item.Hipoacusia = varHipoacusia;
			
			item.TransFonacion = varTransFonacion;
			
			item.ObservacionesGeneral = varObservacionesGeneral;
			
			item.OdontoHabitosPernciosos = varOdontoHabitosPernciosos;
			
			item.OdontoMaloclusion = varOdontoMaloclusion;
			
			item.OdontoFluorAplicado = varOdontoFluorAplicado;
			
			item.UsaLentes = varUsaLentes;
			
			item.Grado = varGrado;
			
			item.Division = varDivision;
			
			item.Turno = varTurno;
			
			item.Sexo = varSexo;
			
			item.ZonaEstudio = varZonaEstudio;
			
			item.PacNombre = varPacNombre;
			
			item.FechaNac = varFechaNac;
			
			item.Domicilio = varDomicilio;
			
			item.Celular = varCelular;
			
			item.PacOSocial = varPacOSocial;
			
			item.Fecha = varFecha;
			
			item.Telefono = varTelefono;
			
			item.Ceod = varCeod;
			
			item.Cpod = varCpod;
			
			item.Observaciones = varObservaciones;
			
			item.OSocialTiene = varOSocialTiene;
			
			item.VacRestanAplicar = varVacRestanAplicar;
			
			item.ResponsableOdonto = varResponsableOdonto;
			
			item.ResponsableFicha = varResponsableFicha;
			
			item.AudiometriaValor = varAudiometriaValor;
			
			item.PesoAlumno = varPesoAlumno;
			
			item.VacSevacEsc = varVacSevacEsc;
			
			item.OdontoCariado = varOdontoCariado;
			
			item.IdProfesionalFicha = varIdProfesionalFicha;
			
			item.IdProfesionalOdonto = varIdProfesionalOdonto;
			
			item.FonoAudiometria = varFonoAudiometria;
			
			item.FonoTato = varFonoTato;
			
			item.FonoDiapason = varFonoDiapason;
			
			item.TatoValor = varTatoValor;
			
			item.Autorizado = varAutorizado;
			
			item.IdProvincia = varIdProvincia;
			
			item.IdDepartamento = varIdDepartamento;
			
			item.IdDLocalidad = varIdDLocalidad;
			
			item.IdLocalidad = varIdLocalidad;
			
			item.TatoValor1 = varTatoValor1;
			
			item.IdUsuarioCarga = varIdUsuarioCarga;
			
			item.FechaCarga = varFechaCarga;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varIdProsame,decimal varIdPaciente,decimal varIdEfector,int? varDNIPaciente,decimal? varIdEstablecimiento,string varPrematuro,decimal? varTutorDNI,string varTutorNombre,string varSobreEdad,string varRepitente,decimal? varPeso,decimal? varTalla,decimal? varImc,decimal? varTaMax,decimal? varTaMin,decimal? varPercentiloPeso,decimal? varPercentiloTalla,decimal? varPercentiloIMC,decimal? varPercentiloMax,decimal? varPercentiloMin,decimal? varEFPielFanera,decimal? varEFCardiovascular,decimal? varEFRespiratorio,decimal? varEFGenital,decimal? varEFAbdomen,decimal? varEFOsteoarticular,decimal? varEFNeurologico,string varVacunaCarne,string varVacunaCompleta,string varEstravismo,string varAgudezaVisualIzq,string varAgudezaVisualDer,string varAudiometria,string varHipoacusia,string varTransFonacion,string varObservacionesGeneral,string varOdontoHabitosPernciosos,string varOdontoMaloclusion,string varOdontoFluorAplicado,string varUsaLentes,string varGrado,string varDivision,string varTurno,string varSexo,string varZonaEstudio,string varPacNombre,DateTime? varFechaNac,string varDomicilio,string varCelular,int? varPacOSocial,DateTime? varFecha,string varTelefono,int? varCeod,int? varCpod,string varObservaciones,string varOSocialTiene,string varVacRestanAplicar,string varResponsableOdonto,string varResponsableFicha,decimal? varAudiometriaValor,decimal? varPesoAlumno,string varVacSevacEsc,int? varOdontoCariado,int? varIdProfesionalFicha,int? varIdProfesionalOdonto,string varFonoAudiometria,string varFonoTato,string varFonoDiapason,string varTatoValor,string varAutorizado,int? varIdProvincia,int? varIdDepartamento,int? varIdDLocalidad,int? varIdLocalidad,int? varTatoValor1,int varIdUsuarioCarga,DateTime varFechaCarga)
		{
			PsmDatos1 item = new PsmDatos1();
			
				item.IdProsame = varIdProsame;
			
				item.IdPaciente = varIdPaciente;
			
				item.IdEfector = varIdEfector;
			
				item.DNIPaciente = varDNIPaciente;
			
				item.IdEstablecimiento = varIdEstablecimiento;
			
				item.Prematuro = varPrematuro;
			
				item.TutorDNI = varTutorDNI;
			
				item.TutorNombre = varTutorNombre;
			
				item.SobreEdad = varSobreEdad;
			
				item.Repitente = varRepitente;
			
				item.Peso = varPeso;
			
				item.Talla = varTalla;
			
				item.Imc = varImc;
			
				item.TaMax = varTaMax;
			
				item.TaMin = varTaMin;
			
				item.PercentiloPeso = varPercentiloPeso;
			
				item.PercentiloTalla = varPercentiloTalla;
			
				item.PercentiloIMC = varPercentiloIMC;
			
				item.PercentiloMax = varPercentiloMax;
			
				item.PercentiloMin = varPercentiloMin;
			
				item.EFPielFanera = varEFPielFanera;
			
				item.EFCardiovascular = varEFCardiovascular;
			
				item.EFRespiratorio = varEFRespiratorio;
			
				item.EFGenital = varEFGenital;
			
				item.EFAbdomen = varEFAbdomen;
			
				item.EFOsteoarticular = varEFOsteoarticular;
			
				item.EFNeurologico = varEFNeurologico;
			
				item.VacunaCarne = varVacunaCarne;
			
				item.VacunaCompleta = varVacunaCompleta;
			
				item.Estravismo = varEstravismo;
			
				item.AgudezaVisualIzq = varAgudezaVisualIzq;
			
				item.AgudezaVisualDer = varAgudezaVisualDer;
			
				item.Audiometria = varAudiometria;
			
				item.Hipoacusia = varHipoacusia;
			
				item.TransFonacion = varTransFonacion;
			
				item.ObservacionesGeneral = varObservacionesGeneral;
			
				item.OdontoHabitosPernciosos = varOdontoHabitosPernciosos;
			
				item.OdontoMaloclusion = varOdontoMaloclusion;
			
				item.OdontoFluorAplicado = varOdontoFluorAplicado;
			
				item.UsaLentes = varUsaLentes;
			
				item.Grado = varGrado;
			
				item.Division = varDivision;
			
				item.Turno = varTurno;
			
				item.Sexo = varSexo;
			
				item.ZonaEstudio = varZonaEstudio;
			
				item.PacNombre = varPacNombre;
			
				item.FechaNac = varFechaNac;
			
				item.Domicilio = varDomicilio;
			
				item.Celular = varCelular;
			
				item.PacOSocial = varPacOSocial;
			
				item.Fecha = varFecha;
			
				item.Telefono = varTelefono;
			
				item.Ceod = varCeod;
			
				item.Cpod = varCpod;
			
				item.Observaciones = varObservaciones;
			
				item.OSocialTiene = varOSocialTiene;
			
				item.VacRestanAplicar = varVacRestanAplicar;
			
				item.ResponsableOdonto = varResponsableOdonto;
			
				item.ResponsableFicha = varResponsableFicha;
			
				item.AudiometriaValor = varAudiometriaValor;
			
				item.PesoAlumno = varPesoAlumno;
			
				item.VacSevacEsc = varVacSevacEsc;
			
				item.OdontoCariado = varOdontoCariado;
			
				item.IdProfesionalFicha = varIdProfesionalFicha;
			
				item.IdProfesionalOdonto = varIdProfesionalOdonto;
			
				item.FonoAudiometria = varFonoAudiometria;
			
				item.FonoTato = varFonoTato;
			
				item.FonoDiapason = varFonoDiapason;
			
				item.TatoValor = varTatoValor;
			
				item.Autorizado = varAutorizado;
			
				item.IdProvincia = varIdProvincia;
			
				item.IdDepartamento = varIdDepartamento;
			
				item.IdDLocalidad = varIdDLocalidad;
			
				item.IdLocalidad = varIdLocalidad;
			
				item.TatoValor1 = varTatoValor1;
			
				item.IdUsuarioCarga = varIdUsuarioCarga;
			
				item.FechaCarga = varFechaCarga;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn IdProsameColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn IdPacienteColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn IdEfectorColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn DNIPacienteColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn IdEstablecimientoColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn PrematuroColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        public static TableSchema.TableColumn TutorDNIColumn
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        public static TableSchema.TableColumn TutorNombreColumn
        {
            get { return Schema.Columns[7]; }
        }
        
        
        
        public static TableSchema.TableColumn SobreEdadColumn
        {
            get { return Schema.Columns[8]; }
        }
        
        
        
        public static TableSchema.TableColumn RepitenteColumn
        {
            get { return Schema.Columns[9]; }
        }
        
        
        
        public static TableSchema.TableColumn PesoColumn
        {
            get { return Schema.Columns[10]; }
        }
        
        
        
        public static TableSchema.TableColumn TallaColumn
        {
            get { return Schema.Columns[11]; }
        }
        
        
        
        public static TableSchema.TableColumn ImcColumn
        {
            get { return Schema.Columns[12]; }
        }
        
        
        
        public static TableSchema.TableColumn TaMaxColumn
        {
            get { return Schema.Columns[13]; }
        }
        
        
        
        public static TableSchema.TableColumn TaMinColumn
        {
            get { return Schema.Columns[14]; }
        }
        
        
        
        public static TableSchema.TableColumn PercentiloPesoColumn
        {
            get { return Schema.Columns[15]; }
        }
        
        
        
        public static TableSchema.TableColumn PercentiloTallaColumn
        {
            get { return Schema.Columns[16]; }
        }
        
        
        
        public static TableSchema.TableColumn PercentiloIMCColumn
        {
            get { return Schema.Columns[17]; }
        }
        
        
        
        public static TableSchema.TableColumn PercentiloMaxColumn
        {
            get { return Schema.Columns[18]; }
        }
        
        
        
        public static TableSchema.TableColumn PercentiloMinColumn
        {
            get { return Schema.Columns[19]; }
        }
        
        
        
        public static TableSchema.TableColumn EFPielFaneraColumn
        {
            get { return Schema.Columns[20]; }
        }
        
        
        
        public static TableSchema.TableColumn EFCardiovascularColumn
        {
            get { return Schema.Columns[21]; }
        }
        
        
        
        public static TableSchema.TableColumn EFRespiratorioColumn
        {
            get { return Schema.Columns[22]; }
        }
        
        
        
        public static TableSchema.TableColumn EFGenitalColumn
        {
            get { return Schema.Columns[23]; }
        }
        
        
        
        public static TableSchema.TableColumn EFAbdomenColumn
        {
            get { return Schema.Columns[24]; }
        }
        
        
        
        public static TableSchema.TableColumn EFOsteoarticularColumn
        {
            get { return Schema.Columns[25]; }
        }
        
        
        
        public static TableSchema.TableColumn EFNeurologicoColumn
        {
            get { return Schema.Columns[26]; }
        }
        
        
        
        public static TableSchema.TableColumn VacunaCarneColumn
        {
            get { return Schema.Columns[27]; }
        }
        
        
        
        public static TableSchema.TableColumn VacunaCompletaColumn
        {
            get { return Schema.Columns[28]; }
        }
        
        
        
        public static TableSchema.TableColumn EstravismoColumn
        {
            get { return Schema.Columns[29]; }
        }
        
        
        
        public static TableSchema.TableColumn AgudezaVisualIzqColumn
        {
            get { return Schema.Columns[30]; }
        }
        
        
        
        public static TableSchema.TableColumn AgudezaVisualDerColumn
        {
            get { return Schema.Columns[31]; }
        }
        
        
        
        public static TableSchema.TableColumn AudiometriaColumn
        {
            get { return Schema.Columns[32]; }
        }
        
        
        
        public static TableSchema.TableColumn HipoacusiaColumn
        {
            get { return Schema.Columns[33]; }
        }
        
        
        
        public static TableSchema.TableColumn TransFonacionColumn
        {
            get { return Schema.Columns[34]; }
        }
        
        
        
        public static TableSchema.TableColumn ObservacionesGeneralColumn
        {
            get { return Schema.Columns[35]; }
        }
        
        
        
        public static TableSchema.TableColumn OdontoHabitosPernciososColumn
        {
            get { return Schema.Columns[36]; }
        }
        
        
        
        public static TableSchema.TableColumn OdontoMaloclusionColumn
        {
            get { return Schema.Columns[37]; }
        }
        
        
        
        public static TableSchema.TableColumn OdontoFluorAplicadoColumn
        {
            get { return Schema.Columns[38]; }
        }
        
        
        
        public static TableSchema.TableColumn UsaLentesColumn
        {
            get { return Schema.Columns[39]; }
        }
        
        
        
        public static TableSchema.TableColumn GradoColumn
        {
            get { return Schema.Columns[40]; }
        }
        
        
        
        public static TableSchema.TableColumn DivisionColumn
        {
            get { return Schema.Columns[41]; }
        }
        
        
        
        public static TableSchema.TableColumn TurnoColumn
        {
            get { return Schema.Columns[42]; }
        }
        
        
        
        public static TableSchema.TableColumn SexoColumn
        {
            get { return Schema.Columns[43]; }
        }
        
        
        
        public static TableSchema.TableColumn ZonaEstudioColumn
        {
            get { return Schema.Columns[44]; }
        }
        
        
        
        public static TableSchema.TableColumn PacNombreColumn
        {
            get { return Schema.Columns[45]; }
        }
        
        
        
        public static TableSchema.TableColumn FechaNacColumn
        {
            get { return Schema.Columns[46]; }
        }
        
        
        
        public static TableSchema.TableColumn DomicilioColumn
        {
            get { return Schema.Columns[47]; }
        }
        
        
        
        public static TableSchema.TableColumn CelularColumn
        {
            get { return Schema.Columns[48]; }
        }
        
        
        
        public static TableSchema.TableColumn PacOSocialColumn
        {
            get { return Schema.Columns[49]; }
        }
        
        
        
        public static TableSchema.TableColumn FechaColumn
        {
            get { return Schema.Columns[50]; }
        }
        
        
        
        public static TableSchema.TableColumn TelefonoColumn
        {
            get { return Schema.Columns[51]; }
        }
        
        
        
        public static TableSchema.TableColumn CeodColumn
        {
            get { return Schema.Columns[52]; }
        }
        
        
        
        public static TableSchema.TableColumn CpodColumn
        {
            get { return Schema.Columns[53]; }
        }
        
        
        
        public static TableSchema.TableColumn ObservacionesColumn
        {
            get { return Schema.Columns[54]; }
        }
        
        
        
        public static TableSchema.TableColumn OSocialTieneColumn
        {
            get { return Schema.Columns[55]; }
        }
        
        
        
        public static TableSchema.TableColumn VacRestanAplicarColumn
        {
            get { return Schema.Columns[56]; }
        }
        
        
        
        public static TableSchema.TableColumn ResponsableOdontoColumn
        {
            get { return Schema.Columns[57]; }
        }
        
        
        
        public static TableSchema.TableColumn ResponsableFichaColumn
        {
            get { return Schema.Columns[58]; }
        }
        
        
        
        public static TableSchema.TableColumn AudiometriaValorColumn
        {
            get { return Schema.Columns[59]; }
        }
        
        
        
        public static TableSchema.TableColumn PesoAlumnoColumn
        {
            get { return Schema.Columns[60]; }
        }
        
        
        
        public static TableSchema.TableColumn VacSevacEscColumn
        {
            get { return Schema.Columns[61]; }
        }
        
        
        
        public static TableSchema.TableColumn OdontoCariadoColumn
        {
            get { return Schema.Columns[62]; }
        }
        
        
        
        public static TableSchema.TableColumn IdProfesionalFichaColumn
        {
            get { return Schema.Columns[63]; }
        }
        
        
        
        public static TableSchema.TableColumn IdProfesionalOdontoColumn
        {
            get { return Schema.Columns[64]; }
        }
        
        
        
        public static TableSchema.TableColumn FonoAudiometriaColumn
        {
            get { return Schema.Columns[65]; }
        }
        
        
        
        public static TableSchema.TableColumn FonoTatoColumn
        {
            get { return Schema.Columns[66]; }
        }
        
        
        
        public static TableSchema.TableColumn FonoDiapasonColumn
        {
            get { return Schema.Columns[67]; }
        }
        
        
        
        public static TableSchema.TableColumn TatoValorColumn
        {
            get { return Schema.Columns[68]; }
        }
        
        
        
        public static TableSchema.TableColumn AutorizadoColumn
        {
            get { return Schema.Columns[69]; }
        }
        
        
        
        public static TableSchema.TableColumn IdProvinciaColumn
        {
            get { return Schema.Columns[70]; }
        }
        
        
        
        public static TableSchema.TableColumn IdDepartamentoColumn
        {
            get { return Schema.Columns[71]; }
        }
        
        
        
        public static TableSchema.TableColumn IdDLocalidadColumn
        {
            get { return Schema.Columns[72]; }
        }
        
        
        
        public static TableSchema.TableColumn IdLocalidadColumn
        {
            get { return Schema.Columns[73]; }
        }
        
        
        
        public static TableSchema.TableColumn TatoValor1Column
        {
            get { return Schema.Columns[74]; }
        }
        
        
        
        public static TableSchema.TableColumn IdUsuarioCargaColumn
        {
            get { return Schema.Columns[75]; }
        }
        
        
        
        public static TableSchema.TableColumn FechaCargaColumn
        {
            get { return Schema.Columns[76]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string IdProsame = @"idProsame";
			 public static string IdPaciente = @"idPaciente";
			 public static string IdEfector = @"idEfector";
			 public static string DNIPaciente = @"DNIPaciente";
			 public static string IdEstablecimiento = @"idEstablecimiento";
			 public static string Prematuro = @"Prematuro";
			 public static string TutorDNI = @"TutorDNI";
			 public static string TutorNombre = @"TutorNombre";
			 public static string SobreEdad = @"SobreEdad";
			 public static string Repitente = @"Repitente";
			 public static string Peso = @"Peso";
			 public static string Talla = @"Talla";
			 public static string Imc = @"IMC";
			 public static string TaMax = @"TaMax";
			 public static string TaMin = @"TaMin";
			 public static string PercentiloPeso = @"PercentiloPeso";
			 public static string PercentiloTalla = @"PercentiloTalla";
			 public static string PercentiloIMC = @"PercentiloIMC";
			 public static string PercentiloMax = @"PercentiloMax";
			 public static string PercentiloMin = @"PercentiloMin";
			 public static string EFPielFanera = @"EFPielFanera";
			 public static string EFCardiovascular = @"EFCardiovascular";
			 public static string EFRespiratorio = @"EFRespiratorio";
			 public static string EFGenital = @"EFGenital";
			 public static string EFAbdomen = @"EFAbdomen";
			 public static string EFOsteoarticular = @"EFOsteoarticular";
			 public static string EFNeurologico = @"EFNeurologico";
			 public static string VacunaCarne = @"VacunaCarne";
			 public static string VacunaCompleta = @"VacunaCompleta";
			 public static string Estravismo = @"Estravismo";
			 public static string AgudezaVisualIzq = @"AgudezaVisualIzq";
			 public static string AgudezaVisualDer = @"AgudezaVisualDer";
			 public static string Audiometria = @"Audiometria";
			 public static string Hipoacusia = @"Hipoacusia";
			 public static string TransFonacion = @"TransFonacion";
			 public static string ObservacionesGeneral = @"ObservacionesGeneral";
			 public static string OdontoHabitosPernciosos = @"OdontoHabitosPernciosos";
			 public static string OdontoMaloclusion = @"OdontoMaloclusion";
			 public static string OdontoFluorAplicado = @"OdontoFluorAplicado";
			 public static string UsaLentes = @"UsaLentes";
			 public static string Grado = @"Grado";
			 public static string Division = @"Division";
			 public static string Turno = @"Turno";
			 public static string Sexo = @"Sexo";
			 public static string ZonaEstudio = @"ZonaEstudio";
			 public static string PacNombre = @"PacNombre";
			 public static string FechaNac = @"FechaNac";
			 public static string Domicilio = @"Domicilio";
			 public static string Celular = @"Celular";
			 public static string PacOSocial = @"PacOSocial";
			 public static string Fecha = @"Fecha";
			 public static string Telefono = @"Telefono";
			 public static string Ceod = @"CEOD";
			 public static string Cpod = @"CPOD";
			 public static string Observaciones = @"Observaciones";
			 public static string OSocialTiene = @"oSocialTiene";
			 public static string VacRestanAplicar = @"vacRestanAplicar";
			 public static string ResponsableOdonto = @"ResponsableOdonto";
			 public static string ResponsableFicha = @"ResponsableFicha";
			 public static string AudiometriaValor = @"audiometriaValor";
			 public static string PesoAlumno = @"PesoAlumno";
			 public static string VacSevacEsc = @"VacSevacEsc";
			 public static string OdontoCariado = @"OdontoCariado";
			 public static string IdProfesionalFicha = @"idProfesionalFicha";
			 public static string IdProfesionalOdonto = @"idProfesionalOdonto";
			 public static string FonoAudiometria = @"FonoAudiometria";
			 public static string FonoTato = @"FonoTato";
			 public static string FonoDiapason = @"FonoDiapason";
			 public static string TatoValor = @"TatoValor";
			 public static string Autorizado = @"Autorizado";
			 public static string IdProvincia = @"idProvincia";
			 public static string IdDepartamento = @"idDepartamento";
			 public static string IdDLocalidad = @"idDLocalidad";
			 public static string IdLocalidad = @"idLocalidad";
			 public static string TatoValor1 = @"tatoValor1";
			 public static string IdUsuarioCarga = @"idUsuarioCarga";
			 public static string FechaCarga = @"fechaCarga";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
