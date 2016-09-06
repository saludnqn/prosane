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
	/// Strongly-typed collection for the TamPapHP class.
	/// </summary>
    [Serializable]
	public partial class TamPapHPCollection : ActiveList<TamPapHP, TamPapHPCollection>
	{	   
		public TamPapHPCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>TamPapHPCollection</returns>
		public TamPapHPCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                TamPapHP o = this[i];
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
	/// This is an ActiveRecord class which wraps the TAM_PapHP table.
	/// </summary>
	[Serializable]
	public partial class TamPapHP : ActiveRecord<TamPapHP>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public TamPapHP()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public TamPapHP(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public TamPapHP(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public TamPapHP(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("TAM_PapHP", TableType.Table, DataService.GetInstance("RisProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarIdPapHP = new TableSchema.TableColumn(schema);
				colvarIdPapHP.ColumnName = "id_PapHP";
				colvarIdPapHP.DataType = DbType.Int32;
				colvarIdPapHP.MaxLength = 0;
				colvarIdPapHP.AutoIncrement = true;
				colvarIdPapHP.IsNullable = false;
				colvarIdPapHP.IsPrimaryKey = true;
				colvarIdPapHP.IsForeignKey = false;
				colvarIdPapHP.IsReadOnly = false;
				colvarIdPapHP.DefaultSetting = @"";
				colvarIdPapHP.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdPapHP);
				
				TableSchema.TableColumn colvarId = new TableSchema.TableColumn(schema);
				colvarId.ColumnName = "id";
				colvarId.DataType = DbType.Int32;
				colvarId.MaxLength = 0;
				colvarId.AutoIncrement = false;
				colvarId.IsNullable = false;
				colvarId.IsPrimaryKey = false;
				colvarId.IsForeignKey = false;
				colvarId.IsReadOnly = false;
				colvarId.DefaultSetting = @"";
				colvarId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarId);
				
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
				colvarIdResultadoPapPrevio.ColumnName = "id_Resultado_Pap_Previo";
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
				colvarIdCitologo.ColumnName = "id_Citologo";
				colvarIdCitologo.DataType = DbType.Int32;
				colvarIdCitologo.MaxLength = 0;
				colvarIdCitologo.AutoIncrement = false;
				colvarIdCitologo.IsNullable = true;
				colvarIdCitologo.IsPrimaryKey = false;
				colvarIdCitologo.IsForeignKey = true;
				colvarIdCitologo.IsReadOnly = false;
				colvarIdCitologo.DefaultSetting = @"";
				
					colvarIdCitologo.ForeignKeyTableName = "Sys_Profesional";
				schema.Columns.Add(colvarIdCitologo);
				
				TableSchema.TableColumn colvarIdMedicoSol = new TableSchema.TableColumn(schema);
				colvarIdMedicoSol.ColumnName = "id_Medico_Sol";
				colvarIdMedicoSol.DataType = DbType.Int32;
				colvarIdMedicoSol.MaxLength = 0;
				colvarIdMedicoSol.AutoIncrement = false;
				colvarIdMedicoSol.IsNullable = true;
				colvarIdMedicoSol.IsPrimaryKey = false;
				colvarIdMedicoSol.IsForeignKey = true;
				colvarIdMedicoSol.IsReadOnly = false;
				colvarIdMedicoSol.DefaultSetting = @"";
				
					colvarIdMedicoSol.ForeignKeyTableName = "Sys_Profesional";
				schema.Columns.Add(colvarIdMedicoSol);
				
				TableSchema.TableColumn colvarIdTipoMuestra = new TableSchema.TableColumn(schema);
				colvarIdTipoMuestra.ColumnName = "id_TipoMuestra";
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
				colvarFechaMuestra.ColumnName = "fecha_Muestra";
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
				
				TableSchema.TableColumn colvarIdCentroMuestra = new TableSchema.TableColumn(schema);
				colvarIdCentroMuestra.ColumnName = "id_Centro_Muestra";
				colvarIdCentroMuestra.DataType = DbType.Int32;
				colvarIdCentroMuestra.MaxLength = 0;
				colvarIdCentroMuestra.AutoIncrement = false;
				colvarIdCentroMuestra.IsNullable = true;
				colvarIdCentroMuestra.IsPrimaryKey = false;
				colvarIdCentroMuestra.IsForeignKey = true;
				colvarIdCentroMuestra.IsReadOnly = false;
				colvarIdCentroMuestra.DefaultSetting = @"";
				
					colvarIdCentroMuestra.ForeignKeyTableName = "Sys_Efector";
				schema.Columns.Add(colvarIdCentroMuestra);
				
				TableSchema.TableColumn colvarFechaInforme = new TableSchema.TableColumn(schema);
				colvarFechaInforme.ColumnName = "fecha_Informe";
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
				
				TableSchema.TableColumn colvarMujerDni = new TableSchema.TableColumn(schema);
				colvarMujerDni.ColumnName = "mujerDni";
				colvarMujerDni.DataType = DbType.Int32;
				colvarMujerDni.MaxLength = 0;
				colvarMujerDni.AutoIncrement = false;
				colvarMujerDni.IsNullable = true;
				colvarMujerDni.IsPrimaryKey = false;
				colvarMujerDni.IsForeignKey = false;
				colvarMujerDni.IsReadOnly = false;
				colvarMujerDni.DefaultSetting = @"";
				colvarMujerDni.ForeignKeyTableName = "";
				schema.Columns.Add(colvarMujerDni);
				
				TableSchema.TableColumn colvarMujerFechaNacimiento = new TableSchema.TableColumn(schema);
				colvarMujerFechaNacimiento.ColumnName = "mujerFechaNacimiento";
				colvarMujerFechaNacimiento.DataType = DbType.DateTime;
				colvarMujerFechaNacimiento.MaxLength = 0;
				colvarMujerFechaNacimiento.AutoIncrement = false;
				colvarMujerFechaNacimiento.IsNullable = true;
				colvarMujerFechaNacimiento.IsPrimaryKey = false;
				colvarMujerFechaNacimiento.IsForeignKey = false;
				colvarMujerFechaNacimiento.IsReadOnly = false;
				colvarMujerFechaNacimiento.DefaultSetting = @"";
				colvarMujerFechaNacimiento.ForeignKeyTableName = "";
				schema.Columns.Add(colvarMujerFechaNacimiento);
				
				TableSchema.TableColumn colvarMujerEdadPrestacion = new TableSchema.TableColumn(schema);
				colvarMujerEdadPrestacion.ColumnName = "mujerEdadPrestacion";
				colvarMujerEdadPrestacion.DataType = DbType.Int32;
				colvarMujerEdadPrestacion.MaxLength = 0;
				colvarMujerEdadPrestacion.AutoIncrement = false;
				colvarMujerEdadPrestacion.IsNullable = true;
				colvarMujerEdadPrestacion.IsPrimaryKey = false;
				colvarMujerEdadPrestacion.IsForeignKey = false;
				colvarMujerEdadPrestacion.IsReadOnly = false;
				colvarMujerEdadPrestacion.DefaultSetting = @"";
				colvarMujerEdadPrestacion.ForeignKeyTableName = "";
				schema.Columns.Add(colvarMujerEdadPrestacion);
				
				TableSchema.TableColumn colvarMujerNombre = new TableSchema.TableColumn(schema);
				colvarMujerNombre.ColumnName = "mujerNombre";
				colvarMujerNombre.DataType = DbType.AnsiString;
				colvarMujerNombre.MaxLength = 200;
				colvarMujerNombre.AutoIncrement = false;
				colvarMujerNombre.IsNullable = true;
				colvarMujerNombre.IsPrimaryKey = false;
				colvarMujerNombre.IsForeignKey = false;
				colvarMujerNombre.IsReadOnly = false;
				colvarMujerNombre.DefaultSetting = @"";
				colvarMujerNombre.ForeignKeyTableName = "";
				schema.Columns.Add(colvarMujerNombre);
				
				TableSchema.TableColumn colvarMujerApellido = new TableSchema.TableColumn(schema);
				colvarMujerApellido.ColumnName = "mujerApellido";
				colvarMujerApellido.DataType = DbType.AnsiString;
				colvarMujerApellido.MaxLength = 200;
				colvarMujerApellido.AutoIncrement = false;
				colvarMujerApellido.IsNullable = true;
				colvarMujerApellido.IsPrimaryKey = false;
				colvarMujerApellido.IsForeignKey = false;
				colvarMujerApellido.IsReadOnly = false;
				colvarMujerApellido.DefaultSetting = @"";
				colvarMujerApellido.ForeignKeyTableName = "";
				schema.Columns.Add(colvarMujerApellido);
				
				TableSchema.TableColumn colvarMujerTelefono = new TableSchema.TableColumn(schema);
				colvarMujerTelefono.ColumnName = "mujerTelefono";
				colvarMujerTelefono.DataType = DbType.AnsiString;
				colvarMujerTelefono.MaxLength = 50;
				colvarMujerTelefono.AutoIncrement = false;
				colvarMujerTelefono.IsNullable = true;
				colvarMujerTelefono.IsPrimaryKey = false;
				colvarMujerTelefono.IsForeignKey = false;
				colvarMujerTelefono.IsReadOnly = false;
				colvarMujerTelefono.DefaultSetting = @"";
				colvarMujerTelefono.ForeignKeyTableName = "";
				schema.Columns.Add(colvarMujerTelefono);
				
				TableSchema.TableColumn colvarMujerDireccion = new TableSchema.TableColumn(schema);
				colvarMujerDireccion.ColumnName = "mujerDireccion";
				colvarMujerDireccion.DataType = DbType.AnsiString;
				colvarMujerDireccion.MaxLength = 200;
				colvarMujerDireccion.AutoIncrement = false;
				colvarMujerDireccion.IsNullable = true;
				colvarMujerDireccion.IsPrimaryKey = false;
				colvarMujerDireccion.IsForeignKey = false;
				colvarMujerDireccion.IsReadOnly = false;
				colvarMujerDireccion.DefaultSetting = @"";
				colvarMujerDireccion.ForeignKeyTableName = "";
				schema.Columns.Add(colvarMujerDireccion);
				
				TableSchema.TableColumn colvarMujerDireccionNro = new TableSchema.TableColumn(schema);
				colvarMujerDireccionNro.ColumnName = "mujerDireccionNro";
				colvarMujerDireccionNro.DataType = DbType.AnsiString;
				colvarMujerDireccionNro.MaxLength = 50;
				colvarMujerDireccionNro.AutoIncrement = false;
				colvarMujerDireccionNro.IsNullable = true;
				colvarMujerDireccionNro.IsPrimaryKey = false;
				colvarMujerDireccionNro.IsForeignKey = false;
				colvarMujerDireccionNro.IsReadOnly = false;
				colvarMujerDireccionNro.DefaultSetting = @"";
				colvarMujerDireccionNro.ForeignKeyTableName = "";
				schema.Columns.Add(colvarMujerDireccionNro);
				
				TableSchema.TableColumn colvarMujerLocalidad = new TableSchema.TableColumn(schema);
				colvarMujerLocalidad.ColumnName = "mujerLocalidad";
				colvarMujerLocalidad.DataType = DbType.AnsiString;
				colvarMujerLocalidad.MaxLength = 100;
				colvarMujerLocalidad.AutoIncrement = false;
				colvarMujerLocalidad.IsNullable = true;
				colvarMujerLocalidad.IsPrimaryKey = false;
				colvarMujerLocalidad.IsForeignKey = false;
				colvarMujerLocalidad.IsReadOnly = false;
				colvarMujerLocalidad.DefaultSetting = @"";
				colvarMujerLocalidad.ForeignKeyTableName = "";
				schema.Columns.Add(colvarMujerLocalidad);
				
				TableSchema.TableColumn colvarIdCalidadMuestra = new TableSchema.TableColumn(schema);
				colvarIdCalidadMuestra.ColumnName = "id_CalidadMuestra";
				colvarIdCalidadMuestra.DataType = DbType.Int32;
				colvarIdCalidadMuestra.MaxLength = 0;
				colvarIdCalidadMuestra.AutoIncrement = false;
				colvarIdCalidadMuestra.IsNullable = true;
				colvarIdCalidadMuestra.IsPrimaryKey = false;
				colvarIdCalidadMuestra.IsForeignKey = true;
				colvarIdCalidadMuestra.IsReadOnly = false;
				colvarIdCalidadMuestra.DefaultSetting = @"";
				
					colvarIdCalidadMuestra.ForeignKeyTableName = "TAM_CalidadMuestra";
				schema.Columns.Add(colvarIdCalidadMuestra);
				
				TableSchema.TableColumn colvarIdMicroorganismo = new TableSchema.TableColumn(schema);
				colvarIdMicroorganismo.ColumnName = "id_Microorganismo";
				colvarIdMicroorganismo.DataType = DbType.Int32;
				colvarIdMicroorganismo.MaxLength = 0;
				colvarIdMicroorganismo.AutoIncrement = false;
				colvarIdMicroorganismo.IsNullable = true;
				colvarIdMicroorganismo.IsPrimaryKey = false;
				colvarIdMicroorganismo.IsForeignKey = true;
				colvarIdMicroorganismo.IsReadOnly = false;
				colvarIdMicroorganismo.DefaultSetting = @"";
				
					colvarIdMicroorganismo.ForeignKeyTableName = "TAM_Microrganismo";
				schema.Columns.Add(colvarIdMicroorganismo);
				
				TableSchema.TableColumn colvarIdOtrosHallazgos = new TableSchema.TableColumn(schema);
				colvarIdOtrosHallazgos.ColumnName = "id_OtrosHallazgos";
				colvarIdOtrosHallazgos.DataType = DbType.Int32;
				colvarIdOtrosHallazgos.MaxLength = 0;
				colvarIdOtrosHallazgos.AutoIncrement = false;
				colvarIdOtrosHallazgos.IsNullable = true;
				colvarIdOtrosHallazgos.IsPrimaryKey = false;
				colvarIdOtrosHallazgos.IsForeignKey = true;
				colvarIdOtrosHallazgos.IsReadOnly = false;
				colvarIdOtrosHallazgos.DefaultSetting = @"";
				
					colvarIdOtrosHallazgos.ForeignKeyTableName = "TAM_OtrosHallazgos";
				schema.Columns.Add(colvarIdOtrosHallazgos);
				
				TableSchema.TableColumn colvarIdCelulasEscamosas = new TableSchema.TableColumn(schema);
				colvarIdCelulasEscamosas.ColumnName = "id_CelulasEscamosas";
				colvarIdCelulasEscamosas.DataType = DbType.Int32;
				colvarIdCelulasEscamosas.MaxLength = 0;
				colvarIdCelulasEscamosas.AutoIncrement = false;
				colvarIdCelulasEscamosas.IsNullable = true;
				colvarIdCelulasEscamosas.IsPrimaryKey = false;
				colvarIdCelulasEscamosas.IsForeignKey = true;
				colvarIdCelulasEscamosas.IsReadOnly = false;
				colvarIdCelulasEscamosas.DefaultSetting = @"";
				
					colvarIdCelulasEscamosas.ForeignKeyTableName = "TAM_CelulasEscamosas";
				schema.Columns.Add(colvarIdCelulasEscamosas);
				
				TableSchema.TableColumn colvarIdCelulasGlandulares = new TableSchema.TableColumn(schema);
				colvarIdCelulasGlandulares.ColumnName = "id_CelulasGlandulares";
				colvarIdCelulasGlandulares.DataType = DbType.Int32;
				colvarIdCelulasGlandulares.MaxLength = 0;
				colvarIdCelulasGlandulares.AutoIncrement = false;
				colvarIdCelulasGlandulares.IsNullable = true;
				colvarIdCelulasGlandulares.IsPrimaryKey = false;
				colvarIdCelulasGlandulares.IsForeignKey = true;
				colvarIdCelulasGlandulares.IsReadOnly = false;
				colvarIdCelulasGlandulares.DefaultSetting = @"";
				
					colvarIdCelulasGlandulares.ForeignKeyTableName = "TAM_CelulasGlandulares";
				schema.Columns.Add(colvarIdCelulasGlandulares);
				
				TableSchema.TableColumn colvarIdObservacion = new TableSchema.TableColumn(schema);
				colvarIdObservacion.ColumnName = "id_Observacion";
				colvarIdObservacion.DataType = DbType.Int32;
				colvarIdObservacion.MaxLength = 0;
				colvarIdObservacion.AutoIncrement = false;
				colvarIdObservacion.IsNullable = true;
				colvarIdObservacion.IsPrimaryKey = false;
				colvarIdObservacion.IsForeignKey = true;
				colvarIdObservacion.IsReadOnly = false;
				colvarIdObservacion.DefaultSetting = @"";
				
					colvarIdObservacion.ForeignKeyTableName = "TAM_ObservacionPap";
				schema.Columns.Add(colvarIdObservacion);
				
				TableSchema.TableColumn colvarFechaRecepcion = new TableSchema.TableColumn(schema);
				colvarFechaRecepcion.ColumnName = "fecha_Recepcion";
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
				
				TableSchema.TableColumn colvarObservaciones = new TableSchema.TableColumn(schema);
				colvarObservaciones.ColumnName = "observaciones";
				colvarObservaciones.DataType = DbType.String;
				colvarObservaciones.MaxLength = 200;
				colvarObservaciones.AutoIncrement = false;
				colvarObservaciones.IsNullable = true;
				colvarObservaciones.IsPrimaryKey = false;
				colvarObservaciones.IsForeignKey = false;
				colvarObservaciones.IsReadOnly = false;
				colvarObservaciones.DefaultSetting = @"";
				colvarObservaciones.ForeignKeyTableName = "";
				schema.Columns.Add(colvarObservaciones);
				
				TableSchema.TableColumn colvarIdCentro = new TableSchema.TableColumn(schema);
				colvarIdCentro.ColumnName = "id_Centro";
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
				colvarIdMujerExporta.ColumnName = "id_Mujer_Exporta";
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
				colvarNumeroLaboratorio.ColumnName = "numero_Laboratorio";
				colvarNumeroLaboratorio.DataType = DbType.AnsiString;
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
				colvarFechaEntrega.ColumnName = "fecha_Entrega";
				colvarFechaEntrega.DataType = DbType.DateTime;
				colvarFechaEntrega.MaxLength = 0;
				colvarFechaEntrega.AutoIncrement = false;
				colvarFechaEntrega.IsNullable = true;
				colvarFechaEntrega.IsPrimaryKey = false;
				colvarFechaEntrega.IsForeignKey = false;
				colvarFechaEntrega.IsReadOnly = false;
				colvarFechaEntrega.DefaultSetting = @"";
				colvarFechaEntrega.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFechaEntrega);
				
				TableSchema.TableColumn colvarCervixSatisfactorio = new TableSchema.TableColumn(schema);
				colvarCervixSatisfactorio.ColumnName = "cervix_Satisfactorio";
				colvarCervixSatisfactorio.DataType = DbType.Boolean;
				colvarCervixSatisfactorio.MaxLength = 0;
				colvarCervixSatisfactorio.AutoIncrement = false;
				colvarCervixSatisfactorio.IsNullable = true;
				colvarCervixSatisfactorio.IsPrimaryKey = false;
				colvarCervixSatisfactorio.IsForeignKey = false;
				colvarCervixSatisfactorio.IsReadOnly = false;
				colvarCervixSatisfactorio.DefaultSetting = @"";
				colvarCervixSatisfactorio.ForeignKeyTableName = "";
				schema.Columns.Add(colvarCervixSatisfactorio);
				
				TableSchema.TableColumn colvarTratHormonal = new TableSchema.TableColumn(schema);
				colvarTratHormonal.ColumnName = "trat_Hormonal";
				colvarTratHormonal.DataType = DbType.Boolean;
				colvarTratHormonal.MaxLength = 0;
				colvarTratHormonal.AutoIncrement = false;
				colvarTratHormonal.IsNullable = true;
				colvarTratHormonal.IsPrimaryKey = false;
				colvarTratHormonal.IsForeignKey = false;
				colvarTratHormonal.IsReadOnly = false;
				colvarTratHormonal.DefaultSetting = @"";
				colvarTratHormonal.ForeignKeyTableName = "";
				schema.Columns.Add(colvarTratHormonal);
				
				TableSchema.TableColumn colvarTratRadiante = new TableSchema.TableColumn(schema);
				colvarTratRadiante.ColumnName = "trat_Radiante";
				colvarTratRadiante.DataType = DbType.Boolean;
				colvarTratRadiante.MaxLength = 0;
				colvarTratRadiante.AutoIncrement = false;
				colvarTratRadiante.IsNullable = true;
				colvarTratRadiante.IsPrimaryKey = false;
				colvarTratRadiante.IsForeignKey = false;
				colvarTratRadiante.IsReadOnly = false;
				colvarTratRadiante.DefaultSetting = @"";
				colvarTratRadiante.ForeignKeyTableName = "";
				schema.Columns.Add(colvarTratRadiante);
				
				TableSchema.TableColumn colvarIdTratDestructivo = new TableSchema.TableColumn(schema);
				colvarIdTratDestructivo.ColumnName = "id_Trat_Destructivo";
				colvarIdTratDestructivo.DataType = DbType.Int32;
				colvarIdTratDestructivo.MaxLength = 0;
				colvarIdTratDestructivo.AutoIncrement = false;
				colvarIdTratDestructivo.IsNullable = true;
				colvarIdTratDestructivo.IsPrimaryKey = false;
				colvarIdTratDestructivo.IsForeignKey = false;
				colvarIdTratDestructivo.IsReadOnly = false;
				colvarIdTratDestructivo.DefaultSetting = @"";
				colvarIdTratDestructivo.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdTratDestructivo);
				
				TableSchema.TableColumn colvarQuimioterapia = new TableSchema.TableColumn(schema);
				colvarQuimioterapia.ColumnName = "quimioterapia";
				colvarQuimioterapia.DataType = DbType.Boolean;
				colvarQuimioterapia.MaxLength = 0;
				colvarQuimioterapia.AutoIncrement = false;
				colvarQuimioterapia.IsNullable = true;
				colvarQuimioterapia.IsPrimaryKey = false;
				colvarQuimioterapia.IsForeignKey = false;
				colvarQuimioterapia.IsReadOnly = false;
				colvarQuimioterapia.DefaultSetting = @"";
				colvarQuimioterapia.ForeignKeyTableName = "";
				schema.Columns.Add(colvarQuimioterapia);
				
				TableSchema.TableColumn colvarEmbarazada = new TableSchema.TableColumn(schema);
				colvarEmbarazada.ColumnName = "embarazada";
				colvarEmbarazada.DataType = DbType.Boolean;
				colvarEmbarazada.MaxLength = 0;
				colvarEmbarazada.AutoIncrement = false;
				colvarEmbarazada.IsNullable = true;
				colvarEmbarazada.IsPrimaryKey = false;
				colvarEmbarazada.IsForeignKey = false;
				colvarEmbarazada.IsReadOnly = false;
				colvarEmbarazada.DefaultSetting = @"";
				colvarEmbarazada.ForeignKeyTableName = "";
				schema.Columns.Add(colvarEmbarazada);
				
				TableSchema.TableColumn colvarFechaFum = new TableSchema.TableColumn(schema);
				colvarFechaFum.ColumnName = "fecha_FUM";
				colvarFechaFum.DataType = DbType.DateTime;
				colvarFechaFum.MaxLength = 0;
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
				colvarIdAnticonceptivo.ColumnName = "id_Anticonceptivo";
				colvarIdAnticonceptivo.DataType = DbType.Int32;
				colvarIdAnticonceptivo.MaxLength = 0;
				colvarIdAnticonceptivo.AutoIncrement = false;
				colvarIdAnticonceptivo.IsNullable = true;
				colvarIdAnticonceptivo.IsPrimaryKey = false;
				colvarIdAnticonceptivo.IsForeignKey = true;
				colvarIdAnticonceptivo.IsReadOnly = false;
				colvarIdAnticonceptivo.DefaultSetting = @"";
				
					colvarIdAnticonceptivo.ForeignKeyTableName = "TAM_MetodoAnticonceptivo";
				schema.Columns.Add(colvarIdAnticonceptivo);
				
				TableSchema.TableColumn colvarIdCirugia = new TableSchema.TableColumn(schema);
				colvarIdCirugia.ColumnName = "id_Cirugia";
				colvarIdCirugia.DataType = DbType.Int32;
				colvarIdCirugia.MaxLength = 0;
				colvarIdCirugia.AutoIncrement = false;
				colvarIdCirugia.IsNullable = true;
				colvarIdCirugia.IsPrimaryKey = false;
				colvarIdCirugia.IsForeignKey = true;
				colvarIdCirugia.IsReadOnly = false;
				colvarIdCirugia.DefaultSetting = @"";
				
					colvarIdCirugia.ForeignKeyTableName = "TAM_TipoCirugia";
				schema.Columns.Add(colvarIdCirugia);
				
				TableSchema.TableColumn colvarMenopausia = new TableSchema.TableColumn(schema);
				colvarMenopausia.ColumnName = "menopausia";
				colvarMenopausia.DataType = DbType.Boolean;
				colvarMenopausia.MaxLength = 0;
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
				colvarLactancia.DataType = DbType.Boolean;
				colvarLactancia.MaxLength = 0;
				colvarLactancia.AutoIncrement = false;
				colvarLactancia.IsNullable = true;
				colvarLactancia.IsPrimaryKey = false;
				colvarLactancia.IsForeignKey = false;
				colvarLactancia.IsReadOnly = false;
				colvarLactancia.DefaultSetting = @"";
				colvarLactancia.ForeignKeyTableName = "";
				schema.Columns.Add(colvarLactancia);
				
				TableSchema.TableColumn colvarFechaPrevio = new TableSchema.TableColumn(schema);
				colvarFechaPrevio.ColumnName = "fecha_Previo";
				colvarFechaPrevio.DataType = DbType.DateTime;
				colvarFechaPrevio.MaxLength = 0;
				colvarFechaPrevio.AutoIncrement = false;
				colvarFechaPrevio.IsNullable = true;
				colvarFechaPrevio.IsPrimaryKey = false;
				colvarFechaPrevio.IsForeignKey = false;
				colvarFechaPrevio.IsReadOnly = false;
				colvarFechaPrevio.DefaultSetting = @"";
				colvarFechaPrevio.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFechaPrevio);
				
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
				
				TableSchema.TableColumn colvarNota = new TableSchema.TableColumn(schema);
				colvarNota.ColumnName = "nota";
				colvarNota.DataType = DbType.AnsiString;
				colvarNota.MaxLength = 50;
				colvarNota.AutoIncrement = false;
				colvarNota.IsNullable = true;
				colvarNota.IsPrimaryKey = false;
				colvarNota.IsForeignKey = false;
				colvarNota.IsReadOnly = false;
				colvarNota.DefaultSetting = @"";
				colvarNota.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNota);
				
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
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["RisProvider"].AddSchema("TAM_PapHP",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("IdPapHP")]
		[Bindable(true)]
		public int IdPapHP 
		{
			get { return GetColumnValue<int>(Columns.IdPapHP); }
			set { SetColumnValue(Columns.IdPapHP, value); }
		}
		  
		[XmlAttribute("Id")]
		[Bindable(true)]
		public int Id 
		{
			get { return GetColumnValue<int>(Columns.Id); }
			set { SetColumnValue(Columns.Id, value); }
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
		public DateTime? FechaMuestra 
		{
			get { return GetColumnValue<DateTime?>(Columns.FechaMuestra); }
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
		public DateTime? FechaInforme 
		{
			get { return GetColumnValue<DateTime?>(Columns.FechaInforme); }
			set { SetColumnValue(Columns.FechaInforme, value); }
		}
		  
		[XmlAttribute("MujerDni")]
		[Bindable(true)]
		public int? MujerDni 
		{
			get { return GetColumnValue<int?>(Columns.MujerDni); }
			set { SetColumnValue(Columns.MujerDni, value); }
		}
		  
		[XmlAttribute("MujerFechaNacimiento")]
		[Bindable(true)]
		public DateTime? MujerFechaNacimiento 
		{
			get { return GetColumnValue<DateTime?>(Columns.MujerFechaNacimiento); }
			set { SetColumnValue(Columns.MujerFechaNacimiento, value); }
		}
		  
		[XmlAttribute("MujerEdadPrestacion")]
		[Bindable(true)]
		public int? MujerEdadPrestacion 
		{
			get { return GetColumnValue<int?>(Columns.MujerEdadPrestacion); }
			set { SetColumnValue(Columns.MujerEdadPrestacion, value); }
		}
		  
		[XmlAttribute("MujerNombre")]
		[Bindable(true)]
		public string MujerNombre 
		{
			get { return GetColumnValue<string>(Columns.MujerNombre); }
			set { SetColumnValue(Columns.MujerNombre, value); }
		}
		  
		[XmlAttribute("MujerApellido")]
		[Bindable(true)]
		public string MujerApellido 
		{
			get { return GetColumnValue<string>(Columns.MujerApellido); }
			set { SetColumnValue(Columns.MujerApellido, value); }
		}
		  
		[XmlAttribute("MujerTelefono")]
		[Bindable(true)]
		public string MujerTelefono 
		{
			get { return GetColumnValue<string>(Columns.MujerTelefono); }
			set { SetColumnValue(Columns.MujerTelefono, value); }
		}
		  
		[XmlAttribute("MujerDireccion")]
		[Bindable(true)]
		public string MujerDireccion 
		{
			get { return GetColumnValue<string>(Columns.MujerDireccion); }
			set { SetColumnValue(Columns.MujerDireccion, value); }
		}
		  
		[XmlAttribute("MujerDireccionNro")]
		[Bindable(true)]
		public string MujerDireccionNro 
		{
			get { return GetColumnValue<string>(Columns.MujerDireccionNro); }
			set { SetColumnValue(Columns.MujerDireccionNro, value); }
		}
		  
		[XmlAttribute("MujerLocalidad")]
		[Bindable(true)]
		public string MujerLocalidad 
		{
			get { return GetColumnValue<string>(Columns.MujerLocalidad); }
			set { SetColumnValue(Columns.MujerLocalidad, value); }
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
		public DateTime? FechaRecepcion 
		{
			get { return GetColumnValue<DateTime?>(Columns.FechaRecepcion); }
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
		public DateTime? FechaEntrega 
		{
			get { return GetColumnValue<DateTime?>(Columns.FechaEntrega); }
			set { SetColumnValue(Columns.FechaEntrega, value); }
		}
		  
		[XmlAttribute("CervixSatisfactorio")]
		[Bindable(true)]
		public bool? CervixSatisfactorio 
		{
			get { return GetColumnValue<bool?>(Columns.CervixSatisfactorio); }
			set { SetColumnValue(Columns.CervixSatisfactorio, value); }
		}
		  
		[XmlAttribute("TratHormonal")]
		[Bindable(true)]
		public bool? TratHormonal 
		{
			get { return GetColumnValue<bool?>(Columns.TratHormonal); }
			set { SetColumnValue(Columns.TratHormonal, value); }
		}
		  
		[XmlAttribute("TratRadiante")]
		[Bindable(true)]
		public bool? TratRadiante 
		{
			get { return GetColumnValue<bool?>(Columns.TratRadiante); }
			set { SetColumnValue(Columns.TratRadiante, value); }
		}
		  
		[XmlAttribute("IdTratDestructivo")]
		[Bindable(true)]
		public int? IdTratDestructivo 
		{
			get { return GetColumnValue<int?>(Columns.IdTratDestructivo); }
			set { SetColumnValue(Columns.IdTratDestructivo, value); }
		}
		  
		[XmlAttribute("Quimioterapia")]
		[Bindable(true)]
		public bool? Quimioterapia 
		{
			get { return GetColumnValue<bool?>(Columns.Quimioterapia); }
			set { SetColumnValue(Columns.Quimioterapia, value); }
		}
		  
		[XmlAttribute("Embarazada")]
		[Bindable(true)]
		public bool? Embarazada 
		{
			get { return GetColumnValue<bool?>(Columns.Embarazada); }
			set { SetColumnValue(Columns.Embarazada, value); }
		}
		  
		[XmlAttribute("FechaFum")]
		[Bindable(true)]
		public DateTime? FechaFum 
		{
			get { return GetColumnValue<DateTime?>(Columns.FechaFum); }
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
		public bool? Menopausia 
		{
			get { return GetColumnValue<bool?>(Columns.Menopausia); }
			set { SetColumnValue(Columns.Menopausia, value); }
		}
		  
		[XmlAttribute("Lactancia")]
		[Bindable(true)]
		public bool? Lactancia 
		{
			get { return GetColumnValue<bool?>(Columns.Lactancia); }
			set { SetColumnValue(Columns.Lactancia, value); }
		}
		  
		[XmlAttribute("FechaPrevio")]
		[Bindable(true)]
		public DateTime? FechaPrevio 
		{
			get { return GetColumnValue<DateTime?>(Columns.FechaPrevio); }
			set { SetColumnValue(Columns.FechaPrevio, value); }
		}
		  
		[XmlAttribute("PasadoSips")]
		[Bindable(true)]
		public bool? PasadoSips 
		{
			get { return GetColumnValue<bool?>(Columns.PasadoSips); }
			set { SetColumnValue(Columns.PasadoSips, value); }
		}
		  
		[XmlAttribute("Activo")]
		[Bindable(true)]
		public bool? Activo 
		{
			get { return GetColumnValue<bool?>(Columns.Activo); }
			set { SetColumnValue(Columns.Activo, value); }
		}
		  
		[XmlAttribute("Nota")]
		[Bindable(true)]
		public string Nota 
		{
			get { return GetColumnValue<string>(Columns.Nota); }
			set { SetColumnValue(Columns.Nota, value); }
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
		
		#endregion
		
		
			
		
		#region ForeignKey Properties
		
		/// <summary>
		/// Returns a SysEfector ActiveRecord object related to this TamPapHP
		/// 
		/// </summary>
		public DalRis.SysEfector SysEfector
		{
			get { return DalRis.SysEfector.FetchByID(this.IdCentroMuestra); }
			set { SetColumnValue("id_Centro_Muestra", value.IdEfector); }
		}
		
		
		/// <summary>
		/// Returns a TamTipoCirugium ActiveRecord object related to this TamPapHP
		/// 
		/// </summary>
		public DalRis.TamTipoCirugium TamTipoCirugium
		{
			get { return DalRis.TamTipoCirugium.FetchByID(this.IdCirugia); }
			set { SetColumnValue("id_Cirugia", value.IdTipoCirugia); }
		}
		
		
		/// <summary>
		/// Returns a TamTipoMuestra ActiveRecord object related to this TamPapHP
		/// 
		/// </summary>
		public DalRis.TamTipoMuestra TamTipoMuestra
		{
			get { return DalRis.TamTipoMuestra.FetchByID(this.IdTipoMuestra); }
			set { SetColumnValue("id_TipoMuestra", value.IdTipoMuestra); }
		}
		
		
		/// <summary>
		/// Returns a TamMicrorganismo ActiveRecord object related to this TamPapHP
		/// 
		/// </summary>
		public DalRis.TamMicrorganismo TamMicrorganismo
		{
			get { return DalRis.TamMicrorganismo.FetchByID(this.IdMicroorganismo); }
			set { SetColumnValue("id_Microorganismo", value.IdMicrorganismo); }
		}
		
		
		/// <summary>
		/// Returns a TamObservacionPap ActiveRecord object related to this TamPapHP
		/// 
		/// </summary>
		public DalRis.TamObservacionPap TamObservacionPap
		{
			get { return DalRis.TamObservacionPap.FetchByID(this.IdObservacion); }
			set { SetColumnValue("id_Observacion", value.IdObservacionPap); }
		}
		
		
		/// <summary>
		/// Returns a TamOtrosHallazgo ActiveRecord object related to this TamPapHP
		/// 
		/// </summary>
		public DalRis.TamOtrosHallazgo TamOtrosHallazgo
		{
			get { return DalRis.TamOtrosHallazgo.FetchByID(this.IdOtrosHallazgos); }
			set { SetColumnValue("id_OtrosHallazgos", value.IdOtrosHallazgos); }
		}
		
		
		/// <summary>
		/// Returns a TamCelulasGlandulare ActiveRecord object related to this TamPapHP
		/// 
		/// </summary>
		public DalRis.TamCelulasGlandulare TamCelulasGlandulare
		{
			get { return DalRis.TamCelulasGlandulare.FetchByID(this.IdCelulasGlandulares); }
			set { SetColumnValue("id_CelulasGlandulares", value.IdCelulasGlandulares); }
		}
		
		
		/// <summary>
		/// Returns a TamCalidadMuestra ActiveRecord object related to this TamPapHP
		/// 
		/// </summary>
		public DalRis.TamCalidadMuestra TamCalidadMuestra
		{
			get { return DalRis.TamCalidadMuestra.FetchByID(this.IdCalidadMuestra); }
			set { SetColumnValue("id_CalidadMuestra", value.IdCalidadMuestra); }
		}
		
		
		/// <summary>
		/// Returns a SysProfesional ActiveRecord object related to this TamPapHP
		/// 
		/// </summary>
		public DalRis.SysProfesional SysProfesional
		{
			get { return DalRis.SysProfesional.FetchByID(this.IdCitologo); }
			set { SetColumnValue("id_Citologo", value.IdProfesional); }
		}
		
		
		/// <summary>
		/// Returns a SysProfesional ActiveRecord object related to this TamPapHP
		/// 
		/// </summary>
		public DalRis.SysProfesional SysProfesionalToIdMedicoSol
		{
			get { return DalRis.SysProfesional.FetchByID(this.IdMedicoSol); }
			set { SetColumnValue("id_Medico_Sol", value.IdProfesional); }
		}
		
		
		/// <summary>
		/// Returns a TamMetodoAnticonceptivo ActiveRecord object related to this TamPapHP
		/// 
		/// </summary>
		public DalRis.TamMetodoAnticonceptivo TamMetodoAnticonceptivo
		{
			get { return DalRis.TamMetodoAnticonceptivo.FetchByID(this.IdAnticonceptivo); }
			set { SetColumnValue("id_Anticonceptivo", value.IdMetodoAnticonceptivo); }
		}
		
		
		/// <summary>
		/// Returns a TamCelulasEscamosa ActiveRecord object related to this TamPapHP
		/// 
		/// </summary>
		public DalRis.TamCelulasEscamosa TamCelulasEscamosa
		{
			get { return DalRis.TamCelulasEscamosa.FetchByID(this.IdCelulasEscamosas); }
			set { SetColumnValue("id_CelulasEscamosas", value.IdCelulasEscamosas); }
		}
		
		
		#endregion
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(int varId,int? varIdTipoPapPrevio,int? varIdResultadoPapPrevio,int? varIdCitologo,int? varIdMedicoSol,int? varIdTipoMuestra,DateTime? varFechaMuestra,int? varIdCentroMuestra,DateTime? varFechaInforme,int? varMujerDni,DateTime? varMujerFechaNacimiento,int? varMujerEdadPrestacion,string varMujerNombre,string varMujerApellido,string varMujerTelefono,string varMujerDireccion,string varMujerDireccionNro,string varMujerLocalidad,int? varIdCalidadMuestra,int? varIdMicroorganismo,int? varIdOtrosHallazgos,int? varIdCelulasEscamosas,int? varIdCelulasGlandulares,int? varIdObservacion,DateTime? varFechaRecepcion,string varObservaciones,int? varIdCentro,int? varIdMujerExporta,string varNumeroLaboratorio,DateTime? varFechaEntrega,bool? varCervixSatisfactorio,bool? varTratHormonal,bool? varTratRadiante,int? varIdTratDestructivo,bool? varQuimioterapia,bool? varEmbarazada,DateTime? varFechaFum,int? varParidad,int? varIdAnticonceptivo,int? varIdCirugia,bool? varMenopausia,bool? varLactancia,DateTime? varFechaPrevio,bool? varPasadoSips,bool? varActivo,string varNota,string varCreatedBy,DateTime varCreatedOn,string varModifiedBy,DateTime varModifiedOn)
		{
			TamPapHP item = new TamPapHP();
			
			item.Id = varId;
			
			item.IdTipoPapPrevio = varIdTipoPapPrevio;
			
			item.IdResultadoPapPrevio = varIdResultadoPapPrevio;
			
			item.IdCitologo = varIdCitologo;
			
			item.IdMedicoSol = varIdMedicoSol;
			
			item.IdTipoMuestra = varIdTipoMuestra;
			
			item.FechaMuestra = varFechaMuestra;
			
			item.IdCentroMuestra = varIdCentroMuestra;
			
			item.FechaInforme = varFechaInforme;
			
			item.MujerDni = varMujerDni;
			
			item.MujerFechaNacimiento = varMujerFechaNacimiento;
			
			item.MujerEdadPrestacion = varMujerEdadPrestacion;
			
			item.MujerNombre = varMujerNombre;
			
			item.MujerApellido = varMujerApellido;
			
			item.MujerTelefono = varMujerTelefono;
			
			item.MujerDireccion = varMujerDireccion;
			
			item.MujerDireccionNro = varMujerDireccionNro;
			
			item.MujerLocalidad = varMujerLocalidad;
			
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
			
			item.IdTratDestructivo = varIdTratDestructivo;
			
			item.Quimioterapia = varQuimioterapia;
			
			item.Embarazada = varEmbarazada;
			
			item.FechaFum = varFechaFum;
			
			item.Paridad = varParidad;
			
			item.IdAnticonceptivo = varIdAnticonceptivo;
			
			item.IdCirugia = varIdCirugia;
			
			item.Menopausia = varMenopausia;
			
			item.Lactancia = varLactancia;
			
			item.FechaPrevio = varFechaPrevio;
			
			item.PasadoSips = varPasadoSips;
			
			item.Activo = varActivo;
			
			item.Nota = varNota;
			
			item.CreatedBy = varCreatedBy;
			
			item.CreatedOn = varCreatedOn;
			
			item.ModifiedBy = varModifiedBy;
			
			item.ModifiedOn = varModifiedOn;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varIdPapHP,int varId,int? varIdTipoPapPrevio,int? varIdResultadoPapPrevio,int? varIdCitologo,int? varIdMedicoSol,int? varIdTipoMuestra,DateTime? varFechaMuestra,int? varIdCentroMuestra,DateTime? varFechaInforme,int? varMujerDni,DateTime? varMujerFechaNacimiento,int? varMujerEdadPrestacion,string varMujerNombre,string varMujerApellido,string varMujerTelefono,string varMujerDireccion,string varMujerDireccionNro,string varMujerLocalidad,int? varIdCalidadMuestra,int? varIdMicroorganismo,int? varIdOtrosHallazgos,int? varIdCelulasEscamosas,int? varIdCelulasGlandulares,int? varIdObservacion,DateTime? varFechaRecepcion,string varObservaciones,int? varIdCentro,int? varIdMujerExporta,string varNumeroLaboratorio,DateTime? varFechaEntrega,bool? varCervixSatisfactorio,bool? varTratHormonal,bool? varTratRadiante,int? varIdTratDestructivo,bool? varQuimioterapia,bool? varEmbarazada,DateTime? varFechaFum,int? varParidad,int? varIdAnticonceptivo,int? varIdCirugia,bool? varMenopausia,bool? varLactancia,DateTime? varFechaPrevio,bool? varPasadoSips,bool? varActivo,string varNota,string varCreatedBy,DateTime varCreatedOn,string varModifiedBy,DateTime varModifiedOn)
		{
			TamPapHP item = new TamPapHP();
			
				item.IdPapHP = varIdPapHP;
			
				item.Id = varId;
			
				item.IdTipoPapPrevio = varIdTipoPapPrevio;
			
				item.IdResultadoPapPrevio = varIdResultadoPapPrevio;
			
				item.IdCitologo = varIdCitologo;
			
				item.IdMedicoSol = varIdMedicoSol;
			
				item.IdTipoMuestra = varIdTipoMuestra;
			
				item.FechaMuestra = varFechaMuestra;
			
				item.IdCentroMuestra = varIdCentroMuestra;
			
				item.FechaInforme = varFechaInforme;
			
				item.MujerDni = varMujerDni;
			
				item.MujerFechaNacimiento = varMujerFechaNacimiento;
			
				item.MujerEdadPrestacion = varMujerEdadPrestacion;
			
				item.MujerNombre = varMujerNombre;
			
				item.MujerApellido = varMujerApellido;
			
				item.MujerTelefono = varMujerTelefono;
			
				item.MujerDireccion = varMujerDireccion;
			
				item.MujerDireccionNro = varMujerDireccionNro;
			
				item.MujerLocalidad = varMujerLocalidad;
			
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
			
				item.IdTratDestructivo = varIdTratDestructivo;
			
				item.Quimioterapia = varQuimioterapia;
			
				item.Embarazada = varEmbarazada;
			
				item.FechaFum = varFechaFum;
			
				item.Paridad = varParidad;
			
				item.IdAnticonceptivo = varIdAnticonceptivo;
			
				item.IdCirugia = varIdCirugia;
			
				item.Menopausia = varMenopausia;
			
				item.Lactancia = varLactancia;
			
				item.FechaPrevio = varFechaPrevio;
			
				item.PasadoSips = varPasadoSips;
			
				item.Activo = varActivo;
			
				item.Nota = varNota;
			
				item.CreatedBy = varCreatedBy;
			
				item.CreatedOn = varCreatedOn;
			
				item.ModifiedBy = varModifiedBy;
			
				item.ModifiedOn = varModifiedOn;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn IdPapHPColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn IdColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn IdTipoPapPrevioColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn IdResultadoPapPrevioColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn IdCitologoColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn IdMedicoSolColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        public static TableSchema.TableColumn IdTipoMuestraColumn
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        public static TableSchema.TableColumn FechaMuestraColumn
        {
            get { return Schema.Columns[7]; }
        }
        
        
        
        public static TableSchema.TableColumn IdCentroMuestraColumn
        {
            get { return Schema.Columns[8]; }
        }
        
        
        
        public static TableSchema.TableColumn FechaInformeColumn
        {
            get { return Schema.Columns[9]; }
        }
        
        
        
        public static TableSchema.TableColumn MujerDniColumn
        {
            get { return Schema.Columns[10]; }
        }
        
        
        
        public static TableSchema.TableColumn MujerFechaNacimientoColumn
        {
            get { return Schema.Columns[11]; }
        }
        
        
        
        public static TableSchema.TableColumn MujerEdadPrestacionColumn
        {
            get { return Schema.Columns[12]; }
        }
        
        
        
        public static TableSchema.TableColumn MujerNombreColumn
        {
            get { return Schema.Columns[13]; }
        }
        
        
        
        public static TableSchema.TableColumn MujerApellidoColumn
        {
            get { return Schema.Columns[14]; }
        }
        
        
        
        public static TableSchema.TableColumn MujerTelefonoColumn
        {
            get { return Schema.Columns[15]; }
        }
        
        
        
        public static TableSchema.TableColumn MujerDireccionColumn
        {
            get { return Schema.Columns[16]; }
        }
        
        
        
        public static TableSchema.TableColumn MujerDireccionNroColumn
        {
            get { return Schema.Columns[17]; }
        }
        
        
        
        public static TableSchema.TableColumn MujerLocalidadColumn
        {
            get { return Schema.Columns[18]; }
        }
        
        
        
        public static TableSchema.TableColumn IdCalidadMuestraColumn
        {
            get { return Schema.Columns[19]; }
        }
        
        
        
        public static TableSchema.TableColumn IdMicroorganismoColumn
        {
            get { return Schema.Columns[20]; }
        }
        
        
        
        public static TableSchema.TableColumn IdOtrosHallazgosColumn
        {
            get { return Schema.Columns[21]; }
        }
        
        
        
        public static TableSchema.TableColumn IdCelulasEscamosasColumn
        {
            get { return Schema.Columns[22]; }
        }
        
        
        
        public static TableSchema.TableColumn IdCelulasGlandularesColumn
        {
            get { return Schema.Columns[23]; }
        }
        
        
        
        public static TableSchema.TableColumn IdObservacionColumn
        {
            get { return Schema.Columns[24]; }
        }
        
        
        
        public static TableSchema.TableColumn FechaRecepcionColumn
        {
            get { return Schema.Columns[25]; }
        }
        
        
        
        public static TableSchema.TableColumn ObservacionesColumn
        {
            get { return Schema.Columns[26]; }
        }
        
        
        
        public static TableSchema.TableColumn IdCentroColumn
        {
            get { return Schema.Columns[27]; }
        }
        
        
        
        public static TableSchema.TableColumn IdMujerExportaColumn
        {
            get { return Schema.Columns[28]; }
        }
        
        
        
        public static TableSchema.TableColumn NumeroLaboratorioColumn
        {
            get { return Schema.Columns[29]; }
        }
        
        
        
        public static TableSchema.TableColumn FechaEntregaColumn
        {
            get { return Schema.Columns[30]; }
        }
        
        
        
        public static TableSchema.TableColumn CervixSatisfactorioColumn
        {
            get { return Schema.Columns[31]; }
        }
        
        
        
        public static TableSchema.TableColumn TratHormonalColumn
        {
            get { return Schema.Columns[32]; }
        }
        
        
        
        public static TableSchema.TableColumn TratRadianteColumn
        {
            get { return Schema.Columns[33]; }
        }
        
        
        
        public static TableSchema.TableColumn IdTratDestructivoColumn
        {
            get { return Schema.Columns[34]; }
        }
        
        
        
        public static TableSchema.TableColumn QuimioterapiaColumn
        {
            get { return Schema.Columns[35]; }
        }
        
        
        
        public static TableSchema.TableColumn EmbarazadaColumn
        {
            get { return Schema.Columns[36]; }
        }
        
        
        
        public static TableSchema.TableColumn FechaFumColumn
        {
            get { return Schema.Columns[37]; }
        }
        
        
        
        public static TableSchema.TableColumn ParidadColumn
        {
            get { return Schema.Columns[38]; }
        }
        
        
        
        public static TableSchema.TableColumn IdAnticonceptivoColumn
        {
            get { return Schema.Columns[39]; }
        }
        
        
        
        public static TableSchema.TableColumn IdCirugiaColumn
        {
            get { return Schema.Columns[40]; }
        }
        
        
        
        public static TableSchema.TableColumn MenopausiaColumn
        {
            get { return Schema.Columns[41]; }
        }
        
        
        
        public static TableSchema.TableColumn LactanciaColumn
        {
            get { return Schema.Columns[42]; }
        }
        
        
        
        public static TableSchema.TableColumn FechaPrevioColumn
        {
            get { return Schema.Columns[43]; }
        }
        
        
        
        public static TableSchema.TableColumn PasadoSipsColumn
        {
            get { return Schema.Columns[44]; }
        }
        
        
        
        public static TableSchema.TableColumn ActivoColumn
        {
            get { return Schema.Columns[45]; }
        }
        
        
        
        public static TableSchema.TableColumn NotaColumn
        {
            get { return Schema.Columns[46]; }
        }
        
        
        
        public static TableSchema.TableColumn CreatedByColumn
        {
            get { return Schema.Columns[47]; }
        }
        
        
        
        public static TableSchema.TableColumn CreatedOnColumn
        {
            get { return Schema.Columns[48]; }
        }
        
        
        
        public static TableSchema.TableColumn ModifiedByColumn
        {
            get { return Schema.Columns[49]; }
        }
        
        
        
        public static TableSchema.TableColumn ModifiedOnColumn
        {
            get { return Schema.Columns[50]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string IdPapHP = @"id_PapHP";
			 public static string Id = @"id";
			 public static string IdTipoPapPrevio = @"id_TipoPapPrevio";
			 public static string IdResultadoPapPrevio = @"id_Resultado_Pap_Previo";
			 public static string IdCitologo = @"id_Citologo";
			 public static string IdMedicoSol = @"id_Medico_Sol";
			 public static string IdTipoMuestra = @"id_TipoMuestra";
			 public static string FechaMuestra = @"fecha_Muestra";
			 public static string IdCentroMuestra = @"id_Centro_Muestra";
			 public static string FechaInforme = @"fecha_Informe";
			 public static string MujerDni = @"mujerDni";
			 public static string MujerFechaNacimiento = @"mujerFechaNacimiento";
			 public static string MujerEdadPrestacion = @"mujerEdadPrestacion";
			 public static string MujerNombre = @"mujerNombre";
			 public static string MujerApellido = @"mujerApellido";
			 public static string MujerTelefono = @"mujerTelefono";
			 public static string MujerDireccion = @"mujerDireccion";
			 public static string MujerDireccionNro = @"mujerDireccionNro";
			 public static string MujerLocalidad = @"mujerLocalidad";
			 public static string IdCalidadMuestra = @"id_CalidadMuestra";
			 public static string IdMicroorganismo = @"id_Microorganismo";
			 public static string IdOtrosHallazgos = @"id_OtrosHallazgos";
			 public static string IdCelulasEscamosas = @"id_CelulasEscamosas";
			 public static string IdCelulasGlandulares = @"id_CelulasGlandulares";
			 public static string IdObservacion = @"id_Observacion";
			 public static string FechaRecepcion = @"fecha_Recepcion";
			 public static string Observaciones = @"observaciones";
			 public static string IdCentro = @"id_Centro";
			 public static string IdMujerExporta = @"id_Mujer_Exporta";
			 public static string NumeroLaboratorio = @"numero_Laboratorio";
			 public static string FechaEntrega = @"fecha_Entrega";
			 public static string CervixSatisfactorio = @"cervix_Satisfactorio";
			 public static string TratHormonal = @"trat_Hormonal";
			 public static string TratRadiante = @"trat_Radiante";
			 public static string IdTratDestructivo = @"id_Trat_Destructivo";
			 public static string Quimioterapia = @"quimioterapia";
			 public static string Embarazada = @"embarazada";
			 public static string FechaFum = @"fecha_FUM";
			 public static string Paridad = @"Paridad";
			 public static string IdAnticonceptivo = @"id_Anticonceptivo";
			 public static string IdCirugia = @"id_Cirugia";
			 public static string Menopausia = @"menopausia";
			 public static string Lactancia = @"lactancia";
			 public static string FechaPrevio = @"fecha_Previo";
			 public static string PasadoSips = @"pasado_Sips";
			 public static string Activo = @"activo";
			 public static string Nota = @"nota";
			 public static string CreatedBy = @"CreatedBy";
			 public static string CreatedOn = @"CreatedOn";
			 public static string ModifiedBy = @"ModifiedBy";
			 public static string ModifiedOn = @"ModifiedOn";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
