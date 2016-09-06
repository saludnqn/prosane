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
	/// Strongly-typed collection for the TstPaciente class.
	/// </summary>
    [Serializable]
	public partial class TstPacienteCollection : ActiveList<TstPaciente, TstPacienteCollection>
	{	   
		public TstPacienteCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>TstPacienteCollection</returns>
		public TstPacienteCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                TstPaciente o = this[i];
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
	/// This is an ActiveRecord class which wraps the TST_Paciente table.
	/// </summary>
	[Serializable]
	public partial class TstPaciente : ActiveRecord<TstPaciente>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public TstPaciente()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public TstPaciente(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public TstPaciente(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public TstPaciente(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("TST_Paciente", TableType.Table, DataService.GetInstance("RisProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarIdPaciente = new TableSchema.TableColumn(schema);
				colvarIdPaciente.ColumnName = "idPaciente";
				colvarIdPaciente.DataType = DbType.Int32;
				colvarIdPaciente.MaxLength = 0;
				colvarIdPaciente.AutoIncrement = true;
				colvarIdPaciente.IsNullable = false;
				colvarIdPaciente.IsPrimaryKey = true;
				colvarIdPaciente.IsForeignKey = false;
				colvarIdPaciente.IsReadOnly = false;
				colvarIdPaciente.DefaultSetting = @"";
				colvarIdPaciente.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdPaciente);
				
				TableSchema.TableColumn colvarIdEfector = new TableSchema.TableColumn(schema);
				colvarIdEfector.ColumnName = "idEfector";
				colvarIdEfector.DataType = DbType.Int32;
				colvarIdEfector.MaxLength = 0;
				colvarIdEfector.AutoIncrement = false;
				colvarIdEfector.IsNullable = false;
				colvarIdEfector.IsPrimaryKey = false;
				colvarIdEfector.IsForeignKey = false;
				colvarIdEfector.IsReadOnly = false;
				
						colvarIdEfector.DefaultSetting = @"((0))";
				colvarIdEfector.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdEfector);
				
				TableSchema.TableColumn colvarApellido = new TableSchema.TableColumn(schema);
				colvarApellido.ColumnName = "apellido";
				colvarApellido.DataType = DbType.String;
				colvarApellido.MaxLength = 100;
				colvarApellido.AutoIncrement = false;
				colvarApellido.IsNullable = false;
				colvarApellido.IsPrimaryKey = false;
				colvarApellido.IsForeignKey = false;
				colvarApellido.IsReadOnly = false;
				colvarApellido.DefaultSetting = @"";
				colvarApellido.ForeignKeyTableName = "";
				schema.Columns.Add(colvarApellido);
				
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
				
				TableSchema.TableColumn colvarNumeroDocumento = new TableSchema.TableColumn(schema);
				colvarNumeroDocumento.ColumnName = "numeroDocumento";
				colvarNumeroDocumento.DataType = DbType.Int32;
				colvarNumeroDocumento.MaxLength = 0;
				colvarNumeroDocumento.AutoIncrement = false;
				colvarNumeroDocumento.IsNullable = false;
				colvarNumeroDocumento.IsPrimaryKey = false;
				colvarNumeroDocumento.IsForeignKey = false;
				colvarNumeroDocumento.IsReadOnly = false;
				
						colvarNumeroDocumento.DefaultSetting = @"((0))";
				colvarNumeroDocumento.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNumeroDocumento);
				
				TableSchema.TableColumn colvarIdSexo = new TableSchema.TableColumn(schema);
				colvarIdSexo.ColumnName = "idSexo";
				colvarIdSexo.DataType = DbType.Int32;
				colvarIdSexo.MaxLength = 0;
				colvarIdSexo.AutoIncrement = false;
				colvarIdSexo.IsNullable = false;
				colvarIdSexo.IsPrimaryKey = false;
				colvarIdSexo.IsForeignKey = false;
				colvarIdSexo.IsReadOnly = false;
				
						colvarIdSexo.DefaultSetting = @"((1))";
				colvarIdSexo.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdSexo);
				
				TableSchema.TableColumn colvarFechaNacimiento = new TableSchema.TableColumn(schema);
				colvarFechaNacimiento.ColumnName = "fechaNacimiento";
				colvarFechaNacimiento.DataType = DbType.DateTime;
				colvarFechaNacimiento.MaxLength = 0;
				colvarFechaNacimiento.AutoIncrement = false;
				colvarFechaNacimiento.IsNullable = false;
				colvarFechaNacimiento.IsPrimaryKey = false;
				colvarFechaNacimiento.IsForeignKey = false;
				colvarFechaNacimiento.IsReadOnly = false;
				colvarFechaNacimiento.DefaultSetting = @"";
				colvarFechaNacimiento.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFechaNacimiento);
				
				TableSchema.TableColumn colvarIdEstado = new TableSchema.TableColumn(schema);
				colvarIdEstado.ColumnName = "idEstado";
				colvarIdEstado.DataType = DbType.Int32;
				colvarIdEstado.MaxLength = 0;
				colvarIdEstado.AutoIncrement = false;
				colvarIdEstado.IsNullable = false;
				colvarIdEstado.IsPrimaryKey = false;
				colvarIdEstado.IsForeignKey = false;
				colvarIdEstado.IsReadOnly = false;
				
						colvarIdEstado.DefaultSetting = @"((1))";
				colvarIdEstado.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdEstado);
				
				TableSchema.TableColumn colvarIdMotivoNI = new TableSchema.TableColumn(schema);
				colvarIdMotivoNI.ColumnName = "idMotivoNI";
				colvarIdMotivoNI.DataType = DbType.Int32;
				colvarIdMotivoNI.MaxLength = 0;
				colvarIdMotivoNI.AutoIncrement = false;
				colvarIdMotivoNI.IsNullable = false;
				colvarIdMotivoNI.IsPrimaryKey = false;
				colvarIdMotivoNI.IsForeignKey = false;
				colvarIdMotivoNI.IsReadOnly = false;
				
						colvarIdMotivoNI.DefaultSetting = @"((0))";
				colvarIdMotivoNI.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdMotivoNI);
				
				TableSchema.TableColumn colvarIdPais = new TableSchema.TableColumn(schema);
				colvarIdPais.ColumnName = "idPais";
				colvarIdPais.DataType = DbType.Int32;
				colvarIdPais.MaxLength = 0;
				colvarIdPais.AutoIncrement = false;
				colvarIdPais.IsNullable = false;
				colvarIdPais.IsPrimaryKey = false;
				colvarIdPais.IsForeignKey = false;
				colvarIdPais.IsReadOnly = false;
				
						colvarIdPais.DefaultSetting = @"((0))";
				colvarIdPais.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdPais);
				
				TableSchema.TableColumn colvarIdProvincia = new TableSchema.TableColumn(schema);
				colvarIdProvincia.ColumnName = "idProvincia";
				colvarIdProvincia.DataType = DbType.Int32;
				colvarIdProvincia.MaxLength = 0;
				colvarIdProvincia.AutoIncrement = false;
				colvarIdProvincia.IsNullable = false;
				colvarIdProvincia.IsPrimaryKey = false;
				colvarIdProvincia.IsForeignKey = false;
				colvarIdProvincia.IsReadOnly = false;
				
						colvarIdProvincia.DefaultSetting = @"((0))";
				colvarIdProvincia.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdProvincia);
				
				TableSchema.TableColumn colvarIdNivelInstruccion = new TableSchema.TableColumn(schema);
				colvarIdNivelInstruccion.ColumnName = "idNivelInstruccion";
				colvarIdNivelInstruccion.DataType = DbType.Int32;
				colvarIdNivelInstruccion.MaxLength = 0;
				colvarIdNivelInstruccion.AutoIncrement = false;
				colvarIdNivelInstruccion.IsNullable = false;
				colvarIdNivelInstruccion.IsPrimaryKey = false;
				colvarIdNivelInstruccion.IsForeignKey = false;
				colvarIdNivelInstruccion.IsReadOnly = false;
				
						colvarIdNivelInstruccion.DefaultSetting = @"((-1))";
				colvarIdNivelInstruccion.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdNivelInstruccion);
				
				TableSchema.TableColumn colvarIdSituacionLaboral = new TableSchema.TableColumn(schema);
				colvarIdSituacionLaboral.ColumnName = "idSituacionLaboral";
				colvarIdSituacionLaboral.DataType = DbType.Int32;
				colvarIdSituacionLaboral.MaxLength = 0;
				colvarIdSituacionLaboral.AutoIncrement = false;
				colvarIdSituacionLaboral.IsNullable = false;
				colvarIdSituacionLaboral.IsPrimaryKey = false;
				colvarIdSituacionLaboral.IsForeignKey = false;
				colvarIdSituacionLaboral.IsReadOnly = false;
				
						colvarIdSituacionLaboral.DefaultSetting = @"((-1))";
				colvarIdSituacionLaboral.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdSituacionLaboral);
				
				TableSchema.TableColumn colvarIdProfesion = new TableSchema.TableColumn(schema);
				colvarIdProfesion.ColumnName = "idProfesion";
				colvarIdProfesion.DataType = DbType.Int32;
				colvarIdProfesion.MaxLength = 0;
				colvarIdProfesion.AutoIncrement = false;
				colvarIdProfesion.IsNullable = false;
				colvarIdProfesion.IsPrimaryKey = false;
				colvarIdProfesion.IsForeignKey = false;
				colvarIdProfesion.IsReadOnly = false;
				
						colvarIdProfesion.DefaultSetting = @"((-1))";
				colvarIdProfesion.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdProfesion);
				
				TableSchema.TableColumn colvarIdOcupacion = new TableSchema.TableColumn(schema);
				colvarIdOcupacion.ColumnName = "idOcupacion";
				colvarIdOcupacion.DataType = DbType.Int32;
				colvarIdOcupacion.MaxLength = 0;
				colvarIdOcupacion.AutoIncrement = false;
				colvarIdOcupacion.IsNullable = false;
				colvarIdOcupacion.IsPrimaryKey = false;
				colvarIdOcupacion.IsForeignKey = false;
				colvarIdOcupacion.IsReadOnly = false;
				
						colvarIdOcupacion.DefaultSetting = @"((-1))";
				colvarIdOcupacion.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdOcupacion);
				
				TableSchema.TableColumn colvarCalle = new TableSchema.TableColumn(schema);
				colvarCalle.ColumnName = "calle";
				colvarCalle.DataType = DbType.String;
				colvarCalle.MaxLength = 50;
				colvarCalle.AutoIncrement = false;
				colvarCalle.IsNullable = false;
				colvarCalle.IsPrimaryKey = false;
				colvarCalle.IsForeignKey = false;
				colvarCalle.IsReadOnly = false;
				
						colvarCalle.DefaultSetting = @"('')";
				colvarCalle.ForeignKeyTableName = "";
				schema.Columns.Add(colvarCalle);
				
				TableSchema.TableColumn colvarNumero = new TableSchema.TableColumn(schema);
				colvarNumero.ColumnName = "numero";
				colvarNumero.DataType = DbType.Int32;
				colvarNumero.MaxLength = 0;
				colvarNumero.AutoIncrement = false;
				colvarNumero.IsNullable = false;
				colvarNumero.IsPrimaryKey = false;
				colvarNumero.IsForeignKey = false;
				colvarNumero.IsReadOnly = false;
				
						colvarNumero.DefaultSetting = @"((0))";
				colvarNumero.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNumero);
				
				TableSchema.TableColumn colvarPiso = new TableSchema.TableColumn(schema);
				colvarPiso.ColumnName = "piso";
				colvarPiso.DataType = DbType.String;
				colvarPiso.MaxLength = 10;
				colvarPiso.AutoIncrement = false;
				colvarPiso.IsNullable = false;
				colvarPiso.IsPrimaryKey = false;
				colvarPiso.IsForeignKey = false;
				colvarPiso.IsReadOnly = false;
				
						colvarPiso.DefaultSetting = @"('')";
				colvarPiso.ForeignKeyTableName = "";
				schema.Columns.Add(colvarPiso);
				
				TableSchema.TableColumn colvarDepartamento = new TableSchema.TableColumn(schema);
				colvarDepartamento.ColumnName = "departamento";
				colvarDepartamento.DataType = DbType.String;
				colvarDepartamento.MaxLength = 10;
				colvarDepartamento.AutoIncrement = false;
				colvarDepartamento.IsNullable = false;
				colvarDepartamento.IsPrimaryKey = false;
				colvarDepartamento.IsForeignKey = false;
				colvarDepartamento.IsReadOnly = false;
				
						colvarDepartamento.DefaultSetting = @"('')";
				colvarDepartamento.ForeignKeyTableName = "";
				schema.Columns.Add(colvarDepartamento);
				
				TableSchema.TableColumn colvarManzana = new TableSchema.TableColumn(schema);
				colvarManzana.ColumnName = "manzana";
				colvarManzana.DataType = DbType.String;
				colvarManzana.MaxLength = 50;
				colvarManzana.AutoIncrement = false;
				colvarManzana.IsNullable = false;
				colvarManzana.IsPrimaryKey = false;
				colvarManzana.IsForeignKey = false;
				colvarManzana.IsReadOnly = false;
				
						colvarManzana.DefaultSetting = @"('')";
				colvarManzana.ForeignKeyTableName = "";
				schema.Columns.Add(colvarManzana);
				
				TableSchema.TableColumn colvarIdBarrio = new TableSchema.TableColumn(schema);
				colvarIdBarrio.ColumnName = "idBarrio";
				colvarIdBarrio.DataType = DbType.Int32;
				colvarIdBarrio.MaxLength = 0;
				colvarIdBarrio.AutoIncrement = false;
				colvarIdBarrio.IsNullable = false;
				colvarIdBarrio.IsPrimaryKey = false;
				colvarIdBarrio.IsForeignKey = false;
				colvarIdBarrio.IsReadOnly = false;
				
						colvarIdBarrio.DefaultSetting = @"((-1))";
				colvarIdBarrio.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdBarrio);
				
				TableSchema.TableColumn colvarIdLocalidad = new TableSchema.TableColumn(schema);
				colvarIdLocalidad.ColumnName = "idLocalidad";
				colvarIdLocalidad.DataType = DbType.Int32;
				colvarIdLocalidad.MaxLength = 0;
				colvarIdLocalidad.AutoIncrement = false;
				colvarIdLocalidad.IsNullable = false;
				colvarIdLocalidad.IsPrimaryKey = false;
				colvarIdLocalidad.IsForeignKey = false;
				colvarIdLocalidad.IsReadOnly = false;
				
						colvarIdLocalidad.DefaultSetting = @"((-1))";
				colvarIdLocalidad.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdLocalidad);
				
				TableSchema.TableColumn colvarIdDepartamento = new TableSchema.TableColumn(schema);
				colvarIdDepartamento.ColumnName = "idDepartamento";
				colvarIdDepartamento.DataType = DbType.Int32;
				colvarIdDepartamento.MaxLength = 0;
				colvarIdDepartamento.AutoIncrement = false;
				colvarIdDepartamento.IsNullable = false;
				colvarIdDepartamento.IsPrimaryKey = false;
				colvarIdDepartamento.IsForeignKey = false;
				colvarIdDepartamento.IsReadOnly = false;
				
						colvarIdDepartamento.DefaultSetting = @"((-1))";
				colvarIdDepartamento.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdDepartamento);
				
				TableSchema.TableColumn colvarIdProvinciaDomicilio = new TableSchema.TableColumn(schema);
				colvarIdProvinciaDomicilio.ColumnName = "idProvinciaDomicilio";
				colvarIdProvinciaDomicilio.DataType = DbType.Int32;
				colvarIdProvinciaDomicilio.MaxLength = 0;
				colvarIdProvinciaDomicilio.AutoIncrement = false;
				colvarIdProvinciaDomicilio.IsNullable = false;
				colvarIdProvinciaDomicilio.IsPrimaryKey = false;
				colvarIdProvinciaDomicilio.IsForeignKey = false;
				colvarIdProvinciaDomicilio.IsReadOnly = false;
				
						colvarIdProvinciaDomicilio.DefaultSetting = @"((-1))";
				colvarIdProvinciaDomicilio.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdProvinciaDomicilio);
				
				TableSchema.TableColumn colvarReferencia = new TableSchema.TableColumn(schema);
				colvarReferencia.ColumnName = "referencia";
				colvarReferencia.DataType = DbType.String;
				colvarReferencia.MaxLength = 200;
				colvarReferencia.AutoIncrement = false;
				colvarReferencia.IsNullable = false;
				colvarReferencia.IsPrimaryKey = false;
				colvarReferencia.IsForeignKey = false;
				colvarReferencia.IsReadOnly = false;
				
						colvarReferencia.DefaultSetting = @"('')";
				colvarReferencia.ForeignKeyTableName = "";
				schema.Columns.Add(colvarReferencia);
				
				TableSchema.TableColumn colvarInformacionContacto = new TableSchema.TableColumn(schema);
				colvarInformacionContacto.ColumnName = "informacionContacto";
				colvarInformacionContacto.DataType = DbType.String;
				colvarInformacionContacto.MaxLength = 800;
				colvarInformacionContacto.AutoIncrement = false;
				colvarInformacionContacto.IsNullable = false;
				colvarInformacionContacto.IsPrimaryKey = false;
				colvarInformacionContacto.IsForeignKey = false;
				colvarInformacionContacto.IsReadOnly = false;
				
						colvarInformacionContacto.DefaultSetting = @"('--')";
				colvarInformacionContacto.ForeignKeyTableName = "";
				schema.Columns.Add(colvarInformacionContacto);
				
				TableSchema.TableColumn colvarCronico = new TableSchema.TableColumn(schema);
				colvarCronico.ColumnName = "cronico";
				colvarCronico.DataType = DbType.Boolean;
				colvarCronico.MaxLength = 0;
				colvarCronico.AutoIncrement = false;
				colvarCronico.IsNullable = false;
				colvarCronico.IsPrimaryKey = false;
				colvarCronico.IsForeignKey = false;
				colvarCronico.IsReadOnly = false;
				
						colvarCronico.DefaultSetting = @"((0))";
				colvarCronico.ForeignKeyTableName = "";
				schema.Columns.Add(colvarCronico);
				
				TableSchema.TableColumn colvarIdObraSocial = new TableSchema.TableColumn(schema);
				colvarIdObraSocial.ColumnName = "idObraSocial";
				colvarIdObraSocial.DataType = DbType.Int32;
				colvarIdObraSocial.MaxLength = 0;
				colvarIdObraSocial.AutoIncrement = false;
				colvarIdObraSocial.IsNullable = false;
				colvarIdObraSocial.IsPrimaryKey = false;
				colvarIdObraSocial.IsForeignKey = false;
				colvarIdObraSocial.IsReadOnly = false;
				
						colvarIdObraSocial.DefaultSetting = @"((-1))";
				colvarIdObraSocial.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdObraSocial);
				
				TableSchema.TableColumn colvarIdUsuario = new TableSchema.TableColumn(schema);
				colvarIdUsuario.ColumnName = "idUsuario";
				colvarIdUsuario.DataType = DbType.Int32;
				colvarIdUsuario.MaxLength = 0;
				colvarIdUsuario.AutoIncrement = false;
				colvarIdUsuario.IsNullable = false;
				colvarIdUsuario.IsPrimaryKey = false;
				colvarIdUsuario.IsForeignKey = false;
				colvarIdUsuario.IsReadOnly = false;
				
						colvarIdUsuario.DefaultSetting = @"((2))";
				colvarIdUsuario.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdUsuario);
				
				TableSchema.TableColumn colvarFechaAlta = new TableSchema.TableColumn(schema);
				colvarFechaAlta.ColumnName = "fechaAlta";
				colvarFechaAlta.DataType = DbType.DateTime;
				colvarFechaAlta.MaxLength = 0;
				colvarFechaAlta.AutoIncrement = false;
				colvarFechaAlta.IsNullable = false;
				colvarFechaAlta.IsPrimaryKey = false;
				colvarFechaAlta.IsForeignKey = false;
				colvarFechaAlta.IsReadOnly = false;
				
						colvarFechaAlta.DefaultSetting = @"(getdate())";
				colvarFechaAlta.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFechaAlta);
				
				TableSchema.TableColumn colvarFechaDefuncion = new TableSchema.TableColumn(schema);
				colvarFechaDefuncion.ColumnName = "fechaDefuncion";
				colvarFechaDefuncion.DataType = DbType.DateTime;
				colvarFechaDefuncion.MaxLength = 0;
				colvarFechaDefuncion.AutoIncrement = false;
				colvarFechaDefuncion.IsNullable = false;
				colvarFechaDefuncion.IsPrimaryKey = false;
				colvarFechaDefuncion.IsForeignKey = false;
				colvarFechaDefuncion.IsReadOnly = false;
				
						colvarFechaDefuncion.DefaultSetting = @"(((1)/(1))/(1900))";
				colvarFechaDefuncion.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFechaDefuncion);
				
				TableSchema.TableColumn colvarFechaUltimaActualizacion = new TableSchema.TableColumn(schema);
				colvarFechaUltimaActualizacion.ColumnName = "fechaUltimaActualizacion";
				colvarFechaUltimaActualizacion.DataType = DbType.DateTime;
				colvarFechaUltimaActualizacion.MaxLength = 0;
				colvarFechaUltimaActualizacion.AutoIncrement = false;
				colvarFechaUltimaActualizacion.IsNullable = false;
				colvarFechaUltimaActualizacion.IsPrimaryKey = false;
				colvarFechaUltimaActualizacion.IsForeignKey = false;
				colvarFechaUltimaActualizacion.IsReadOnly = false;
				
						colvarFechaUltimaActualizacion.DefaultSetting = @"(getdate())";
				colvarFechaUltimaActualizacion.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFechaUltimaActualizacion);
				
				TableSchema.TableColumn colvarIdEstadoCivil = new TableSchema.TableColumn(schema);
				colvarIdEstadoCivil.ColumnName = "idEstadoCivil";
				colvarIdEstadoCivil.DataType = DbType.Int32;
				colvarIdEstadoCivil.MaxLength = 0;
				colvarIdEstadoCivil.AutoIncrement = false;
				colvarIdEstadoCivil.IsNullable = false;
				colvarIdEstadoCivil.IsPrimaryKey = false;
				colvarIdEstadoCivil.IsForeignKey = false;
				colvarIdEstadoCivil.IsReadOnly = false;
				
						colvarIdEstadoCivil.DefaultSetting = @"((-1))";
				colvarIdEstadoCivil.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdEstadoCivil);
				
				TableSchema.TableColumn colvarIdEtnia = new TableSchema.TableColumn(schema);
				colvarIdEtnia.ColumnName = "idEtnia";
				colvarIdEtnia.DataType = DbType.Int32;
				colvarIdEtnia.MaxLength = 0;
				colvarIdEtnia.AutoIncrement = false;
				colvarIdEtnia.IsNullable = false;
				colvarIdEtnia.IsPrimaryKey = false;
				colvarIdEtnia.IsForeignKey = false;
				colvarIdEtnia.IsReadOnly = false;
				
						colvarIdEtnia.DefaultSetting = @"((-1))";
				colvarIdEtnia.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdEtnia);
				
				TableSchema.TableColumn colvarIdPoblacion = new TableSchema.TableColumn(schema);
				colvarIdPoblacion.ColumnName = "idPoblacion";
				colvarIdPoblacion.DataType = DbType.Int32;
				colvarIdPoblacion.MaxLength = 0;
				colvarIdPoblacion.AutoIncrement = false;
				colvarIdPoblacion.IsNullable = false;
				colvarIdPoblacion.IsPrimaryKey = false;
				colvarIdPoblacion.IsForeignKey = false;
				colvarIdPoblacion.IsReadOnly = false;
				
						colvarIdPoblacion.DefaultSetting = @"((-1))";
				colvarIdPoblacion.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdPoblacion);
				
				TableSchema.TableColumn colvarIdIdioma = new TableSchema.TableColumn(schema);
				colvarIdIdioma.ColumnName = "idIdioma";
				colvarIdIdioma.DataType = DbType.Int32;
				colvarIdIdioma.MaxLength = 0;
				colvarIdIdioma.AutoIncrement = false;
				colvarIdIdioma.IsNullable = false;
				colvarIdIdioma.IsPrimaryKey = false;
				colvarIdIdioma.IsForeignKey = false;
				colvarIdIdioma.IsReadOnly = false;
				
						colvarIdIdioma.DefaultSetting = @"((-1))";
				colvarIdIdioma.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdIdioma);
				
				TableSchema.TableColumn colvarOtroBarrio = new TableSchema.TableColumn(schema);
				colvarOtroBarrio.ColumnName = "otroBarrio";
				colvarOtroBarrio.DataType = DbType.String;
				colvarOtroBarrio.MaxLength = 150;
				colvarOtroBarrio.AutoIncrement = false;
				colvarOtroBarrio.IsNullable = false;
				colvarOtroBarrio.IsPrimaryKey = false;
				colvarOtroBarrio.IsForeignKey = false;
				colvarOtroBarrio.IsReadOnly = false;
				
						colvarOtroBarrio.DefaultSetting = @"('')";
				colvarOtroBarrio.ForeignKeyTableName = "";
				schema.Columns.Add(colvarOtroBarrio);
				
				TableSchema.TableColumn colvarCamino = new TableSchema.TableColumn(schema);
				colvarCamino.ColumnName = "camino";
				colvarCamino.DataType = DbType.String;
				colvarCamino.MaxLength = 100;
				colvarCamino.AutoIncrement = false;
				colvarCamino.IsNullable = false;
				colvarCamino.IsPrimaryKey = false;
				colvarCamino.IsForeignKey = false;
				colvarCamino.IsReadOnly = false;
				
						colvarCamino.DefaultSetting = @"('')";
				colvarCamino.ForeignKeyTableName = "";
				schema.Columns.Add(colvarCamino);
				
				TableSchema.TableColumn colvarCampo = new TableSchema.TableColumn(schema);
				colvarCampo.ColumnName = "campo";
				colvarCampo.DataType = DbType.String;
				colvarCampo.MaxLength = 100;
				colvarCampo.AutoIncrement = false;
				colvarCampo.IsNullable = false;
				colvarCampo.IsPrimaryKey = false;
				colvarCampo.IsForeignKey = false;
				colvarCampo.IsReadOnly = false;
				
						colvarCampo.DefaultSetting = @"('')";
				colvarCampo.ForeignKeyTableName = "";
				schema.Columns.Add(colvarCampo);
				
				TableSchema.TableColumn colvarEsUrbano = new TableSchema.TableColumn(schema);
				colvarEsUrbano.ColumnName = "esUrbano";
				colvarEsUrbano.DataType = DbType.Boolean;
				colvarEsUrbano.MaxLength = 0;
				colvarEsUrbano.AutoIncrement = false;
				colvarEsUrbano.IsNullable = false;
				colvarEsUrbano.IsPrimaryKey = false;
				colvarEsUrbano.IsForeignKey = false;
				colvarEsUrbano.IsReadOnly = false;
				
						colvarEsUrbano.DefaultSetting = @"((1))";
				colvarEsUrbano.ForeignKeyTableName = "";
				schema.Columns.Add(colvarEsUrbano);
				
				TableSchema.TableColumn colvarLote = new TableSchema.TableColumn(schema);
				colvarLote.ColumnName = "lote";
				colvarLote.DataType = DbType.String;
				colvarLote.MaxLength = 10;
				colvarLote.AutoIncrement = false;
				colvarLote.IsNullable = false;
				colvarLote.IsPrimaryKey = false;
				colvarLote.IsForeignKey = false;
				colvarLote.IsReadOnly = false;
				
						colvarLote.DefaultSetting = @"('')";
				colvarLote.ForeignKeyTableName = "";
				schema.Columns.Add(colvarLote);
				
				TableSchema.TableColumn colvarParcela = new TableSchema.TableColumn(schema);
				colvarParcela.ColumnName = "parcela";
				colvarParcela.DataType = DbType.String;
				colvarParcela.MaxLength = 10;
				colvarParcela.AutoIncrement = false;
				colvarParcela.IsNullable = false;
				colvarParcela.IsPrimaryKey = false;
				colvarParcela.IsForeignKey = false;
				colvarParcela.IsReadOnly = false;
				
						colvarParcela.DefaultSetting = @"('')";
				colvarParcela.ForeignKeyTableName = "";
				schema.Columns.Add(colvarParcela);
				
				TableSchema.TableColumn colvarEdificio = new TableSchema.TableColumn(schema);
				colvarEdificio.ColumnName = "edificio";
				colvarEdificio.DataType = DbType.AnsiString;
				colvarEdificio.MaxLength = 50;
				colvarEdificio.AutoIncrement = false;
				colvarEdificio.IsNullable = false;
				colvarEdificio.IsPrimaryKey = false;
				colvarEdificio.IsForeignKey = false;
				colvarEdificio.IsReadOnly = false;
				
						colvarEdificio.DefaultSetting = @"('')";
				colvarEdificio.ForeignKeyTableName = "";
				schema.Columns.Add(colvarEdificio);
				
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
				
				TableSchema.TableColumn colvarOrigen = new TableSchema.TableColumn(schema);
				colvarOrigen.ColumnName = "origen";
				colvarOrigen.DataType = DbType.AnsiString;
				colvarOrigen.MaxLength = 50;
				colvarOrigen.AutoIncrement = false;
				colvarOrigen.IsNullable = true;
				colvarOrigen.IsPrimaryKey = false;
				colvarOrigen.IsForeignKey = false;
				colvarOrigen.IsReadOnly = false;
				colvarOrigen.DefaultSetting = @"";
				colvarOrigen.ForeignKeyTableName = "";
				schema.Columns.Add(colvarOrigen);
				
				TableSchema.TableColumn colvarNumeroAfiliado = new TableSchema.TableColumn(schema);
				colvarNumeroAfiliado.ColumnName = "numeroAfiliado";
				colvarNumeroAfiliado.DataType = DbType.AnsiString;
				colvarNumeroAfiliado.MaxLength = 50;
				colvarNumeroAfiliado.AutoIncrement = false;
				colvarNumeroAfiliado.IsNullable = true;
				colvarNumeroAfiliado.IsPrimaryKey = false;
				colvarNumeroAfiliado.IsForeignKey = false;
				colvarNumeroAfiliado.IsReadOnly = false;
				colvarNumeroAfiliado.DefaultSetting = @"";
				colvarNumeroAfiliado.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNumeroAfiliado);
				
				TableSchema.TableColumn colvarFAlta = new TableSchema.TableColumn(schema);
				colvarFAlta.ColumnName = "fAlta";
				colvarFAlta.DataType = DbType.DateTime;
				colvarFAlta.MaxLength = 0;
				colvarFAlta.AutoIncrement = false;
				colvarFAlta.IsNullable = true;
				colvarFAlta.IsPrimaryKey = false;
				colvarFAlta.IsForeignKey = false;
				colvarFAlta.IsReadOnly = false;
				colvarFAlta.DefaultSetting = @"";
				colvarFAlta.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFAlta);
				
				TableSchema.TableColumn colvarFechaImportacion = new TableSchema.TableColumn(schema);
				colvarFechaImportacion.ColumnName = "fechaImportacion";
				colvarFechaImportacion.DataType = DbType.DateTime;
				colvarFechaImportacion.MaxLength = 0;
				colvarFechaImportacion.AutoIncrement = false;
				colvarFechaImportacion.IsNullable = true;
				colvarFechaImportacion.IsPrimaryKey = false;
				colvarFechaImportacion.IsForeignKey = false;
				colvarFechaImportacion.IsReadOnly = false;
				
						colvarFechaImportacion.DefaultSetting = @"(getdate())";
				colvarFechaImportacion.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFechaImportacion);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["RisProvider"].AddSchema("TST_Paciente",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("IdPaciente")]
		[Bindable(true)]
		public int IdPaciente 
		{
			get { return GetColumnValue<int>(Columns.IdPaciente); }
			set { SetColumnValue(Columns.IdPaciente, value); }
		}
		  
		[XmlAttribute("IdEfector")]
		[Bindable(true)]
		public int IdEfector 
		{
			get { return GetColumnValue<int>(Columns.IdEfector); }
			set { SetColumnValue(Columns.IdEfector, value); }
		}
		  
		[XmlAttribute("Apellido")]
		[Bindable(true)]
		public string Apellido 
		{
			get { return GetColumnValue<string>(Columns.Apellido); }
			set { SetColumnValue(Columns.Apellido, value); }
		}
		  
		[XmlAttribute("Nombre")]
		[Bindable(true)]
		public string Nombre 
		{
			get { return GetColumnValue<string>(Columns.Nombre); }
			set { SetColumnValue(Columns.Nombre, value); }
		}
		  
		[XmlAttribute("NumeroDocumento")]
		[Bindable(true)]
		public int NumeroDocumento 
		{
			get { return GetColumnValue<int>(Columns.NumeroDocumento); }
			set { SetColumnValue(Columns.NumeroDocumento, value); }
		}
		  
		[XmlAttribute("IdSexo")]
		[Bindable(true)]
		public int IdSexo 
		{
			get { return GetColumnValue<int>(Columns.IdSexo); }
			set { SetColumnValue(Columns.IdSexo, value); }
		}
		  
		[XmlAttribute("FechaNacimiento")]
		[Bindable(true)]
		public DateTime FechaNacimiento 
		{
			get { return GetColumnValue<DateTime>(Columns.FechaNacimiento); }
			set { SetColumnValue(Columns.FechaNacimiento, value); }
		}
		  
		[XmlAttribute("IdEstado")]
		[Bindable(true)]
		public int IdEstado 
		{
			get { return GetColumnValue<int>(Columns.IdEstado); }
			set { SetColumnValue(Columns.IdEstado, value); }
		}
		  
		[XmlAttribute("IdMotivoNI")]
		[Bindable(true)]
		public int IdMotivoNI 
		{
			get { return GetColumnValue<int>(Columns.IdMotivoNI); }
			set { SetColumnValue(Columns.IdMotivoNI, value); }
		}
		  
		[XmlAttribute("IdPais")]
		[Bindable(true)]
		public int IdPais 
		{
			get { return GetColumnValue<int>(Columns.IdPais); }
			set { SetColumnValue(Columns.IdPais, value); }
		}
		  
		[XmlAttribute("IdProvincia")]
		[Bindable(true)]
		public int IdProvincia 
		{
			get { return GetColumnValue<int>(Columns.IdProvincia); }
			set { SetColumnValue(Columns.IdProvincia, value); }
		}
		  
		[XmlAttribute("IdNivelInstruccion")]
		[Bindable(true)]
		public int IdNivelInstruccion 
		{
			get { return GetColumnValue<int>(Columns.IdNivelInstruccion); }
			set { SetColumnValue(Columns.IdNivelInstruccion, value); }
		}
		  
		[XmlAttribute("IdSituacionLaboral")]
		[Bindable(true)]
		public int IdSituacionLaboral 
		{
			get { return GetColumnValue<int>(Columns.IdSituacionLaboral); }
			set { SetColumnValue(Columns.IdSituacionLaboral, value); }
		}
		  
		[XmlAttribute("IdProfesion")]
		[Bindable(true)]
		public int IdProfesion 
		{
			get { return GetColumnValue<int>(Columns.IdProfesion); }
			set { SetColumnValue(Columns.IdProfesion, value); }
		}
		  
		[XmlAttribute("IdOcupacion")]
		[Bindable(true)]
		public int IdOcupacion 
		{
			get { return GetColumnValue<int>(Columns.IdOcupacion); }
			set { SetColumnValue(Columns.IdOcupacion, value); }
		}
		  
		[XmlAttribute("Calle")]
		[Bindable(true)]
		public string Calle 
		{
			get { return GetColumnValue<string>(Columns.Calle); }
			set { SetColumnValue(Columns.Calle, value); }
		}
		  
		[XmlAttribute("Numero")]
		[Bindable(true)]
		public int Numero 
		{
			get { return GetColumnValue<int>(Columns.Numero); }
			set { SetColumnValue(Columns.Numero, value); }
		}
		  
		[XmlAttribute("Piso")]
		[Bindable(true)]
		public string Piso 
		{
			get { return GetColumnValue<string>(Columns.Piso); }
			set { SetColumnValue(Columns.Piso, value); }
		}
		  
		[XmlAttribute("Departamento")]
		[Bindable(true)]
		public string Departamento 
		{
			get { return GetColumnValue<string>(Columns.Departamento); }
			set { SetColumnValue(Columns.Departamento, value); }
		}
		  
		[XmlAttribute("Manzana")]
		[Bindable(true)]
		public string Manzana 
		{
			get { return GetColumnValue<string>(Columns.Manzana); }
			set { SetColumnValue(Columns.Manzana, value); }
		}
		  
		[XmlAttribute("IdBarrio")]
		[Bindable(true)]
		public int IdBarrio 
		{
			get { return GetColumnValue<int>(Columns.IdBarrio); }
			set { SetColumnValue(Columns.IdBarrio, value); }
		}
		  
		[XmlAttribute("IdLocalidad")]
		[Bindable(true)]
		public int IdLocalidad 
		{
			get { return GetColumnValue<int>(Columns.IdLocalidad); }
			set { SetColumnValue(Columns.IdLocalidad, value); }
		}
		  
		[XmlAttribute("IdDepartamento")]
		[Bindable(true)]
		public int IdDepartamento 
		{
			get { return GetColumnValue<int>(Columns.IdDepartamento); }
			set { SetColumnValue(Columns.IdDepartamento, value); }
		}
		  
		[XmlAttribute("IdProvinciaDomicilio")]
		[Bindable(true)]
		public int IdProvinciaDomicilio 
		{
			get { return GetColumnValue<int>(Columns.IdProvinciaDomicilio); }
			set { SetColumnValue(Columns.IdProvinciaDomicilio, value); }
		}
		  
		[XmlAttribute("Referencia")]
		[Bindable(true)]
		public string Referencia 
		{
			get { return GetColumnValue<string>(Columns.Referencia); }
			set { SetColumnValue(Columns.Referencia, value); }
		}
		  
		[XmlAttribute("InformacionContacto")]
		[Bindable(true)]
		public string InformacionContacto 
		{
			get { return GetColumnValue<string>(Columns.InformacionContacto); }
			set { SetColumnValue(Columns.InformacionContacto, value); }
		}
		  
		[XmlAttribute("Cronico")]
		[Bindable(true)]
		public bool Cronico 
		{
			get { return GetColumnValue<bool>(Columns.Cronico); }
			set { SetColumnValue(Columns.Cronico, value); }
		}
		  
		[XmlAttribute("IdObraSocial")]
		[Bindable(true)]
		public int IdObraSocial 
		{
			get { return GetColumnValue<int>(Columns.IdObraSocial); }
			set { SetColumnValue(Columns.IdObraSocial, value); }
		}
		  
		[XmlAttribute("IdUsuario")]
		[Bindable(true)]
		public int IdUsuario 
		{
			get { return GetColumnValue<int>(Columns.IdUsuario); }
			set { SetColumnValue(Columns.IdUsuario, value); }
		}
		  
		[XmlAttribute("FechaAlta")]
		[Bindable(true)]
		public DateTime FechaAlta 
		{
			get { return GetColumnValue<DateTime>(Columns.FechaAlta); }
			set { SetColumnValue(Columns.FechaAlta, value); }
		}
		  
		[XmlAttribute("FechaDefuncion")]
		[Bindable(true)]
		public DateTime FechaDefuncion 
		{
			get { return GetColumnValue<DateTime>(Columns.FechaDefuncion); }
			set { SetColumnValue(Columns.FechaDefuncion, value); }
		}
		  
		[XmlAttribute("FechaUltimaActualizacion")]
		[Bindable(true)]
		public DateTime FechaUltimaActualizacion 
		{
			get { return GetColumnValue<DateTime>(Columns.FechaUltimaActualizacion); }
			set { SetColumnValue(Columns.FechaUltimaActualizacion, value); }
		}
		  
		[XmlAttribute("IdEstadoCivil")]
		[Bindable(true)]
		public int IdEstadoCivil 
		{
			get { return GetColumnValue<int>(Columns.IdEstadoCivil); }
			set { SetColumnValue(Columns.IdEstadoCivil, value); }
		}
		  
		[XmlAttribute("IdEtnia")]
		[Bindable(true)]
		public int IdEtnia 
		{
			get { return GetColumnValue<int>(Columns.IdEtnia); }
			set { SetColumnValue(Columns.IdEtnia, value); }
		}
		  
		[XmlAttribute("IdPoblacion")]
		[Bindable(true)]
		public int IdPoblacion 
		{
			get { return GetColumnValue<int>(Columns.IdPoblacion); }
			set { SetColumnValue(Columns.IdPoblacion, value); }
		}
		  
		[XmlAttribute("IdIdioma")]
		[Bindable(true)]
		public int IdIdioma 
		{
			get { return GetColumnValue<int>(Columns.IdIdioma); }
			set { SetColumnValue(Columns.IdIdioma, value); }
		}
		  
		[XmlAttribute("OtroBarrio")]
		[Bindable(true)]
		public string OtroBarrio 
		{
			get { return GetColumnValue<string>(Columns.OtroBarrio); }
			set { SetColumnValue(Columns.OtroBarrio, value); }
		}
		  
		[XmlAttribute("Camino")]
		[Bindable(true)]
		public string Camino 
		{
			get { return GetColumnValue<string>(Columns.Camino); }
			set { SetColumnValue(Columns.Camino, value); }
		}
		  
		[XmlAttribute("Campo")]
		[Bindable(true)]
		public string Campo 
		{
			get { return GetColumnValue<string>(Columns.Campo); }
			set { SetColumnValue(Columns.Campo, value); }
		}
		  
		[XmlAttribute("EsUrbano")]
		[Bindable(true)]
		public bool EsUrbano 
		{
			get { return GetColumnValue<bool>(Columns.EsUrbano); }
			set { SetColumnValue(Columns.EsUrbano, value); }
		}
		  
		[XmlAttribute("Lote")]
		[Bindable(true)]
		public string Lote 
		{
			get { return GetColumnValue<string>(Columns.Lote); }
			set { SetColumnValue(Columns.Lote, value); }
		}
		  
		[XmlAttribute("Parcela")]
		[Bindable(true)]
		public string Parcela 
		{
			get { return GetColumnValue<string>(Columns.Parcela); }
			set { SetColumnValue(Columns.Parcela, value); }
		}
		  
		[XmlAttribute("Edificio")]
		[Bindable(true)]
		public string Edificio 
		{
			get { return GetColumnValue<string>(Columns.Edificio); }
			set { SetColumnValue(Columns.Edificio, value); }
		}
		  
		[XmlAttribute("Activo")]
		[Bindable(true)]
		public bool Activo 
		{
			get { return GetColumnValue<bool>(Columns.Activo); }
			set { SetColumnValue(Columns.Activo, value); }
		}
		  
		[XmlAttribute("Origen")]
		[Bindable(true)]
		public string Origen 
		{
			get { return GetColumnValue<string>(Columns.Origen); }
			set { SetColumnValue(Columns.Origen, value); }
		}
		  
		[XmlAttribute("NumeroAfiliado")]
		[Bindable(true)]
		public string NumeroAfiliado 
		{
			get { return GetColumnValue<string>(Columns.NumeroAfiliado); }
			set { SetColumnValue(Columns.NumeroAfiliado, value); }
		}
		  
		[XmlAttribute("FAlta")]
		[Bindable(true)]
		public DateTime? FAlta 
		{
			get { return GetColumnValue<DateTime?>(Columns.FAlta); }
			set { SetColumnValue(Columns.FAlta, value); }
		}
		  
		[XmlAttribute("FechaImportacion")]
		[Bindable(true)]
		public DateTime? FechaImportacion 
		{
			get { return GetColumnValue<DateTime?>(Columns.FechaImportacion); }
			set { SetColumnValue(Columns.FechaImportacion, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(int varIdEfector,string varApellido,string varNombre,int varNumeroDocumento,int varIdSexo,DateTime varFechaNacimiento,int varIdEstado,int varIdMotivoNI,int varIdPais,int varIdProvincia,int varIdNivelInstruccion,int varIdSituacionLaboral,int varIdProfesion,int varIdOcupacion,string varCalle,int varNumero,string varPiso,string varDepartamento,string varManzana,int varIdBarrio,int varIdLocalidad,int varIdDepartamento,int varIdProvinciaDomicilio,string varReferencia,string varInformacionContacto,bool varCronico,int varIdObraSocial,int varIdUsuario,DateTime varFechaAlta,DateTime varFechaDefuncion,DateTime varFechaUltimaActualizacion,int varIdEstadoCivil,int varIdEtnia,int varIdPoblacion,int varIdIdioma,string varOtroBarrio,string varCamino,string varCampo,bool varEsUrbano,string varLote,string varParcela,string varEdificio,bool varActivo,string varOrigen,string varNumeroAfiliado,DateTime? varFAlta,DateTime? varFechaImportacion)
		{
			TstPaciente item = new TstPaciente();
			
			item.IdEfector = varIdEfector;
			
			item.Apellido = varApellido;
			
			item.Nombre = varNombre;
			
			item.NumeroDocumento = varNumeroDocumento;
			
			item.IdSexo = varIdSexo;
			
			item.FechaNacimiento = varFechaNacimiento;
			
			item.IdEstado = varIdEstado;
			
			item.IdMotivoNI = varIdMotivoNI;
			
			item.IdPais = varIdPais;
			
			item.IdProvincia = varIdProvincia;
			
			item.IdNivelInstruccion = varIdNivelInstruccion;
			
			item.IdSituacionLaboral = varIdSituacionLaboral;
			
			item.IdProfesion = varIdProfesion;
			
			item.IdOcupacion = varIdOcupacion;
			
			item.Calle = varCalle;
			
			item.Numero = varNumero;
			
			item.Piso = varPiso;
			
			item.Departamento = varDepartamento;
			
			item.Manzana = varManzana;
			
			item.IdBarrio = varIdBarrio;
			
			item.IdLocalidad = varIdLocalidad;
			
			item.IdDepartamento = varIdDepartamento;
			
			item.IdProvinciaDomicilio = varIdProvinciaDomicilio;
			
			item.Referencia = varReferencia;
			
			item.InformacionContacto = varInformacionContacto;
			
			item.Cronico = varCronico;
			
			item.IdObraSocial = varIdObraSocial;
			
			item.IdUsuario = varIdUsuario;
			
			item.FechaAlta = varFechaAlta;
			
			item.FechaDefuncion = varFechaDefuncion;
			
			item.FechaUltimaActualizacion = varFechaUltimaActualizacion;
			
			item.IdEstadoCivil = varIdEstadoCivil;
			
			item.IdEtnia = varIdEtnia;
			
			item.IdPoblacion = varIdPoblacion;
			
			item.IdIdioma = varIdIdioma;
			
			item.OtroBarrio = varOtroBarrio;
			
			item.Camino = varCamino;
			
			item.Campo = varCampo;
			
			item.EsUrbano = varEsUrbano;
			
			item.Lote = varLote;
			
			item.Parcela = varParcela;
			
			item.Edificio = varEdificio;
			
			item.Activo = varActivo;
			
			item.Origen = varOrigen;
			
			item.NumeroAfiliado = varNumeroAfiliado;
			
			item.FAlta = varFAlta;
			
			item.FechaImportacion = varFechaImportacion;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varIdPaciente,int varIdEfector,string varApellido,string varNombre,int varNumeroDocumento,int varIdSexo,DateTime varFechaNacimiento,int varIdEstado,int varIdMotivoNI,int varIdPais,int varIdProvincia,int varIdNivelInstruccion,int varIdSituacionLaboral,int varIdProfesion,int varIdOcupacion,string varCalle,int varNumero,string varPiso,string varDepartamento,string varManzana,int varIdBarrio,int varIdLocalidad,int varIdDepartamento,int varIdProvinciaDomicilio,string varReferencia,string varInformacionContacto,bool varCronico,int varIdObraSocial,int varIdUsuario,DateTime varFechaAlta,DateTime varFechaDefuncion,DateTime varFechaUltimaActualizacion,int varIdEstadoCivil,int varIdEtnia,int varIdPoblacion,int varIdIdioma,string varOtroBarrio,string varCamino,string varCampo,bool varEsUrbano,string varLote,string varParcela,string varEdificio,bool varActivo,string varOrigen,string varNumeroAfiliado,DateTime? varFAlta,DateTime? varFechaImportacion)
		{
			TstPaciente item = new TstPaciente();
			
				item.IdPaciente = varIdPaciente;
			
				item.IdEfector = varIdEfector;
			
				item.Apellido = varApellido;
			
				item.Nombre = varNombre;
			
				item.NumeroDocumento = varNumeroDocumento;
			
				item.IdSexo = varIdSexo;
			
				item.FechaNacimiento = varFechaNacimiento;
			
				item.IdEstado = varIdEstado;
			
				item.IdMotivoNI = varIdMotivoNI;
			
				item.IdPais = varIdPais;
			
				item.IdProvincia = varIdProvincia;
			
				item.IdNivelInstruccion = varIdNivelInstruccion;
			
				item.IdSituacionLaboral = varIdSituacionLaboral;
			
				item.IdProfesion = varIdProfesion;
			
				item.IdOcupacion = varIdOcupacion;
			
				item.Calle = varCalle;
			
				item.Numero = varNumero;
			
				item.Piso = varPiso;
			
				item.Departamento = varDepartamento;
			
				item.Manzana = varManzana;
			
				item.IdBarrio = varIdBarrio;
			
				item.IdLocalidad = varIdLocalidad;
			
				item.IdDepartamento = varIdDepartamento;
			
				item.IdProvinciaDomicilio = varIdProvinciaDomicilio;
			
				item.Referencia = varReferencia;
			
				item.InformacionContacto = varInformacionContacto;
			
				item.Cronico = varCronico;
			
				item.IdObraSocial = varIdObraSocial;
			
				item.IdUsuario = varIdUsuario;
			
				item.FechaAlta = varFechaAlta;
			
				item.FechaDefuncion = varFechaDefuncion;
			
				item.FechaUltimaActualizacion = varFechaUltimaActualizacion;
			
				item.IdEstadoCivil = varIdEstadoCivil;
			
				item.IdEtnia = varIdEtnia;
			
				item.IdPoblacion = varIdPoblacion;
			
				item.IdIdioma = varIdIdioma;
			
				item.OtroBarrio = varOtroBarrio;
			
				item.Camino = varCamino;
			
				item.Campo = varCampo;
			
				item.EsUrbano = varEsUrbano;
			
				item.Lote = varLote;
			
				item.Parcela = varParcela;
			
				item.Edificio = varEdificio;
			
				item.Activo = varActivo;
			
				item.Origen = varOrigen;
			
				item.NumeroAfiliado = varNumeroAfiliado;
			
				item.FAlta = varFAlta;
			
				item.FechaImportacion = varFechaImportacion;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn IdPacienteColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn IdEfectorColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn ApellidoColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn NombreColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn NumeroDocumentoColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn IdSexoColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        public static TableSchema.TableColumn FechaNacimientoColumn
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        public static TableSchema.TableColumn IdEstadoColumn
        {
            get { return Schema.Columns[7]; }
        }
        
        
        
        public static TableSchema.TableColumn IdMotivoNIColumn
        {
            get { return Schema.Columns[8]; }
        }
        
        
        
        public static TableSchema.TableColumn IdPaisColumn
        {
            get { return Schema.Columns[9]; }
        }
        
        
        
        public static TableSchema.TableColumn IdProvinciaColumn
        {
            get { return Schema.Columns[10]; }
        }
        
        
        
        public static TableSchema.TableColumn IdNivelInstruccionColumn
        {
            get { return Schema.Columns[11]; }
        }
        
        
        
        public static TableSchema.TableColumn IdSituacionLaboralColumn
        {
            get { return Schema.Columns[12]; }
        }
        
        
        
        public static TableSchema.TableColumn IdProfesionColumn
        {
            get { return Schema.Columns[13]; }
        }
        
        
        
        public static TableSchema.TableColumn IdOcupacionColumn
        {
            get { return Schema.Columns[14]; }
        }
        
        
        
        public static TableSchema.TableColumn CalleColumn
        {
            get { return Schema.Columns[15]; }
        }
        
        
        
        public static TableSchema.TableColumn NumeroColumn
        {
            get { return Schema.Columns[16]; }
        }
        
        
        
        public static TableSchema.TableColumn PisoColumn
        {
            get { return Schema.Columns[17]; }
        }
        
        
        
        public static TableSchema.TableColumn DepartamentoColumn
        {
            get { return Schema.Columns[18]; }
        }
        
        
        
        public static TableSchema.TableColumn ManzanaColumn
        {
            get { return Schema.Columns[19]; }
        }
        
        
        
        public static TableSchema.TableColumn IdBarrioColumn
        {
            get { return Schema.Columns[20]; }
        }
        
        
        
        public static TableSchema.TableColumn IdLocalidadColumn
        {
            get { return Schema.Columns[21]; }
        }
        
        
        
        public static TableSchema.TableColumn IdDepartamentoColumn
        {
            get { return Schema.Columns[22]; }
        }
        
        
        
        public static TableSchema.TableColumn IdProvinciaDomicilioColumn
        {
            get { return Schema.Columns[23]; }
        }
        
        
        
        public static TableSchema.TableColumn ReferenciaColumn
        {
            get { return Schema.Columns[24]; }
        }
        
        
        
        public static TableSchema.TableColumn InformacionContactoColumn
        {
            get { return Schema.Columns[25]; }
        }
        
        
        
        public static TableSchema.TableColumn CronicoColumn
        {
            get { return Schema.Columns[26]; }
        }
        
        
        
        public static TableSchema.TableColumn IdObraSocialColumn
        {
            get { return Schema.Columns[27]; }
        }
        
        
        
        public static TableSchema.TableColumn IdUsuarioColumn
        {
            get { return Schema.Columns[28]; }
        }
        
        
        
        public static TableSchema.TableColumn FechaAltaColumn
        {
            get { return Schema.Columns[29]; }
        }
        
        
        
        public static TableSchema.TableColumn FechaDefuncionColumn
        {
            get { return Schema.Columns[30]; }
        }
        
        
        
        public static TableSchema.TableColumn FechaUltimaActualizacionColumn
        {
            get { return Schema.Columns[31]; }
        }
        
        
        
        public static TableSchema.TableColumn IdEstadoCivilColumn
        {
            get { return Schema.Columns[32]; }
        }
        
        
        
        public static TableSchema.TableColumn IdEtniaColumn
        {
            get { return Schema.Columns[33]; }
        }
        
        
        
        public static TableSchema.TableColumn IdPoblacionColumn
        {
            get { return Schema.Columns[34]; }
        }
        
        
        
        public static TableSchema.TableColumn IdIdiomaColumn
        {
            get { return Schema.Columns[35]; }
        }
        
        
        
        public static TableSchema.TableColumn OtroBarrioColumn
        {
            get { return Schema.Columns[36]; }
        }
        
        
        
        public static TableSchema.TableColumn CaminoColumn
        {
            get { return Schema.Columns[37]; }
        }
        
        
        
        public static TableSchema.TableColumn CampoColumn
        {
            get { return Schema.Columns[38]; }
        }
        
        
        
        public static TableSchema.TableColumn EsUrbanoColumn
        {
            get { return Schema.Columns[39]; }
        }
        
        
        
        public static TableSchema.TableColumn LoteColumn
        {
            get { return Schema.Columns[40]; }
        }
        
        
        
        public static TableSchema.TableColumn ParcelaColumn
        {
            get { return Schema.Columns[41]; }
        }
        
        
        
        public static TableSchema.TableColumn EdificioColumn
        {
            get { return Schema.Columns[42]; }
        }
        
        
        
        public static TableSchema.TableColumn ActivoColumn
        {
            get { return Schema.Columns[43]; }
        }
        
        
        
        public static TableSchema.TableColumn OrigenColumn
        {
            get { return Schema.Columns[44]; }
        }
        
        
        
        public static TableSchema.TableColumn NumeroAfiliadoColumn
        {
            get { return Schema.Columns[45]; }
        }
        
        
        
        public static TableSchema.TableColumn FAltaColumn
        {
            get { return Schema.Columns[46]; }
        }
        
        
        
        public static TableSchema.TableColumn FechaImportacionColumn
        {
            get { return Schema.Columns[47]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string IdPaciente = @"idPaciente";
			 public static string IdEfector = @"idEfector";
			 public static string Apellido = @"apellido";
			 public static string Nombre = @"nombre";
			 public static string NumeroDocumento = @"numeroDocumento";
			 public static string IdSexo = @"idSexo";
			 public static string FechaNacimiento = @"fechaNacimiento";
			 public static string IdEstado = @"idEstado";
			 public static string IdMotivoNI = @"idMotivoNI";
			 public static string IdPais = @"idPais";
			 public static string IdProvincia = @"idProvincia";
			 public static string IdNivelInstruccion = @"idNivelInstruccion";
			 public static string IdSituacionLaboral = @"idSituacionLaboral";
			 public static string IdProfesion = @"idProfesion";
			 public static string IdOcupacion = @"idOcupacion";
			 public static string Calle = @"calle";
			 public static string Numero = @"numero";
			 public static string Piso = @"piso";
			 public static string Departamento = @"departamento";
			 public static string Manzana = @"manzana";
			 public static string IdBarrio = @"idBarrio";
			 public static string IdLocalidad = @"idLocalidad";
			 public static string IdDepartamento = @"idDepartamento";
			 public static string IdProvinciaDomicilio = @"idProvinciaDomicilio";
			 public static string Referencia = @"referencia";
			 public static string InformacionContacto = @"informacionContacto";
			 public static string Cronico = @"cronico";
			 public static string IdObraSocial = @"idObraSocial";
			 public static string IdUsuario = @"idUsuario";
			 public static string FechaAlta = @"fechaAlta";
			 public static string FechaDefuncion = @"fechaDefuncion";
			 public static string FechaUltimaActualizacion = @"fechaUltimaActualizacion";
			 public static string IdEstadoCivil = @"idEstadoCivil";
			 public static string IdEtnia = @"idEtnia";
			 public static string IdPoblacion = @"idPoblacion";
			 public static string IdIdioma = @"idIdioma";
			 public static string OtroBarrio = @"otroBarrio";
			 public static string Camino = @"camino";
			 public static string Campo = @"campo";
			 public static string EsUrbano = @"esUrbano";
			 public static string Lote = @"lote";
			 public static string Parcela = @"parcela";
			 public static string Edificio = @"edificio";
			 public static string Activo = @"activo";
			 public static string Origen = @"origen";
			 public static string NumeroAfiliado = @"numeroAfiliado";
			 public static string FAlta = @"fAlta";
			 public static string FechaImportacion = @"fechaImportacion";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
