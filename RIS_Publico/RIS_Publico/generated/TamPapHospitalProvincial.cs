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
	/// Strongly-typed collection for the TamPapHospitalProvincial class.
	/// </summary>
    [Serializable]
	public partial class TamPapHospitalProvincialCollection : ActiveList<TamPapHospitalProvincial, TamPapHospitalProvincialCollection>
	{	   
		public TamPapHospitalProvincialCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>TamPapHospitalProvincialCollection</returns>
		public TamPapHospitalProvincialCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                TamPapHospitalProvincial o = this[i];
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
	/// This is an ActiveRecord class which wraps the TAM_PapHospitalProvincial table.
	/// </summary>
	[Serializable]
	public partial class TamPapHospitalProvincial : ActiveRecord<TamPapHospitalProvincial>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public TamPapHospitalProvincial()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public TamPapHospitalProvincial(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public TamPapHospitalProvincial(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public TamPapHospitalProvincial(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("TAM_PapHospitalProvincial", TableType.Table, DataService.GetInstance("RisProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarIdPapHP = new TableSchema.TableColumn(schema);
				colvarIdPapHP.ColumnName = "idPapHP";
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
				
				TableSchema.TableColumn colvarFechaIngreso = new TableSchema.TableColumn(schema);
				colvarFechaIngreso.ColumnName = "fechaIngreso";
				colvarFechaIngreso.DataType = DbType.DateTime;
				colvarFechaIngreso.MaxLength = 0;
				colvarFechaIngreso.AutoIncrement = false;
				colvarFechaIngreso.IsNullable = true;
				colvarFechaIngreso.IsPrimaryKey = false;
				colvarFechaIngreso.IsForeignKey = false;
				colvarFechaIngreso.IsReadOnly = false;
				colvarFechaIngreso.DefaultSetting = @"";
				colvarFechaIngreso.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFechaIngreso);
				
				TableSchema.TableColumn colvarProtocolo = new TableSchema.TableColumn(schema);
				colvarProtocolo.ColumnName = "protocolo";
				colvarProtocolo.DataType = DbType.AnsiString;
				colvarProtocolo.MaxLength = 20;
				colvarProtocolo.AutoIncrement = false;
				colvarProtocolo.IsNullable = false;
				colvarProtocolo.IsPrimaryKey = false;
				colvarProtocolo.IsForeignKey = false;
				colvarProtocolo.IsReadOnly = false;
				
						colvarProtocolo.DefaultSetting = @"('')";
				colvarProtocolo.ForeignKeyTableName = "";
				schema.Columns.Add(colvarProtocolo);
				
				TableSchema.TableColumn colvarApellido = new TableSchema.TableColumn(schema);
				colvarApellido.ColumnName = "apellido";
				colvarApellido.DataType = DbType.AnsiString;
				colvarApellido.MaxLength = 200;
				colvarApellido.AutoIncrement = false;
				colvarApellido.IsNullable = false;
				colvarApellido.IsPrimaryKey = false;
				colvarApellido.IsForeignKey = false;
				colvarApellido.IsReadOnly = false;
				
						colvarApellido.DefaultSetting = @"('')";
				colvarApellido.ForeignKeyTableName = "";
				schema.Columns.Add(colvarApellido);
				
				TableSchema.TableColumn colvarNombre = new TableSchema.TableColumn(schema);
				colvarNombre.ColumnName = "nombre";
				colvarNombre.DataType = DbType.AnsiString;
				colvarNombre.MaxLength = 200;
				colvarNombre.AutoIncrement = false;
				colvarNombre.IsNullable = true;
				colvarNombre.IsPrimaryKey = false;
				colvarNombre.IsForeignKey = false;
				colvarNombre.IsReadOnly = false;
				colvarNombre.DefaultSetting = @"";
				colvarNombre.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNombre);
				
				TableSchema.TableColumn colvarDocumento = new TableSchema.TableColumn(schema);
				colvarDocumento.ColumnName = "documento";
				colvarDocumento.DataType = DbType.Int32;
				colvarDocumento.MaxLength = 0;
				colvarDocumento.AutoIncrement = false;
				colvarDocumento.IsNullable = false;
				colvarDocumento.IsPrimaryKey = false;
				colvarDocumento.IsForeignKey = false;
				colvarDocumento.IsReadOnly = false;
				
						colvarDocumento.DefaultSetting = @"((0))";
				colvarDocumento.ForeignKeyTableName = "";
				schema.Columns.Add(colvarDocumento);
				
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
				
				TableSchema.TableColumn colvarEdad = new TableSchema.TableColumn(schema);
				colvarEdad.ColumnName = "Edad";
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
				
				TableSchema.TableColumn colvarObraSocial = new TableSchema.TableColumn(schema);
				colvarObraSocial.ColumnName = "ObraSocial";
				colvarObraSocial.DataType = DbType.AnsiString;
				colvarObraSocial.MaxLength = 200;
				colvarObraSocial.AutoIncrement = false;
				colvarObraSocial.IsNullable = true;
				colvarObraSocial.IsPrimaryKey = false;
				colvarObraSocial.IsForeignKey = false;
				colvarObraSocial.IsReadOnly = false;
				
						colvarObraSocial.DefaultSetting = @"('')";
				colvarObraSocial.ForeignKeyTableName = "";
				schema.Columns.Add(colvarObraSocial);
				
				TableSchema.TableColumn colvarEstadoPrestacion = new TableSchema.TableColumn(schema);
				colvarEstadoPrestacion.ColumnName = "EstadoPrestacion";
				colvarEstadoPrestacion.DataType = DbType.AnsiString;
				colvarEstadoPrestacion.MaxLength = 100;
				colvarEstadoPrestacion.AutoIncrement = false;
				colvarEstadoPrestacion.IsNullable = false;
				colvarEstadoPrestacion.IsPrimaryKey = false;
				colvarEstadoPrestacion.IsForeignKey = false;
				colvarEstadoPrestacion.IsReadOnly = false;
				
						colvarEstadoPrestacion.DefaultSetting = @"('')";
				colvarEstadoPrestacion.ForeignKeyTableName = "";
				schema.Columns.Add(colvarEstadoPrestacion);
				
				TableSchema.TableColumn colvarFechaDiagnostico = new TableSchema.TableColumn(schema);
				colvarFechaDiagnostico.ColumnName = "fechaDiagnostico";
				colvarFechaDiagnostico.DataType = DbType.DateTime;
				colvarFechaDiagnostico.MaxLength = 0;
				colvarFechaDiagnostico.AutoIncrement = false;
				colvarFechaDiagnostico.IsNullable = true;
				colvarFechaDiagnostico.IsPrimaryKey = false;
				colvarFechaDiagnostico.IsForeignKey = false;
				colvarFechaDiagnostico.IsReadOnly = false;
				colvarFechaDiagnostico.DefaultSetting = @"";
				colvarFechaDiagnostico.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFechaDiagnostico);
				
				TableSchema.TableColumn colvarIdCelulasEscamosas = new TableSchema.TableColumn(schema);
				colvarIdCelulasEscamosas.ColumnName = "idCelulasEscamosas";
				colvarIdCelulasEscamosas.DataType = DbType.Int32;
				colvarIdCelulasEscamosas.MaxLength = 0;
				colvarIdCelulasEscamosas.AutoIncrement = false;
				colvarIdCelulasEscamosas.IsNullable = true;
				colvarIdCelulasEscamosas.IsPrimaryKey = false;
				colvarIdCelulasEscamosas.IsForeignKey = false;
				colvarIdCelulasEscamosas.IsReadOnly = false;
				
						colvarIdCelulasEscamosas.DefaultSetting = @"((0))";
				colvarIdCelulasEscamosas.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdCelulasEscamosas);
				
				TableSchema.TableColumn colvarCelulasEscamosas = new TableSchema.TableColumn(schema);
				colvarCelulasEscamosas.ColumnName = "CelulasEscamosas";
				colvarCelulasEscamosas.DataType = DbType.AnsiString;
				colvarCelulasEscamosas.MaxLength = 100;
				colvarCelulasEscamosas.AutoIncrement = false;
				colvarCelulasEscamosas.IsNullable = true;
				colvarCelulasEscamosas.IsPrimaryKey = false;
				colvarCelulasEscamosas.IsForeignKey = false;
				colvarCelulasEscamosas.IsReadOnly = false;
				colvarCelulasEscamosas.DefaultSetting = @"";
				colvarCelulasEscamosas.ForeignKeyTableName = "";
				schema.Columns.Add(colvarCelulasEscamosas);
				
				TableSchema.TableColumn colvarIdCelulasGlandulares = new TableSchema.TableColumn(schema);
				colvarIdCelulasGlandulares.ColumnName = "idCelulasGlandulares";
				colvarIdCelulasGlandulares.DataType = DbType.Int32;
				colvarIdCelulasGlandulares.MaxLength = 0;
				colvarIdCelulasGlandulares.AutoIncrement = false;
				colvarIdCelulasGlandulares.IsNullable = true;
				colvarIdCelulasGlandulares.IsPrimaryKey = false;
				colvarIdCelulasGlandulares.IsForeignKey = false;
				colvarIdCelulasGlandulares.IsReadOnly = false;
				
						colvarIdCelulasGlandulares.DefaultSetting = @"((0))";
				colvarIdCelulasGlandulares.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdCelulasGlandulares);
				
				TableSchema.TableColumn colvarCelulasGlandulares = new TableSchema.TableColumn(schema);
				colvarCelulasGlandulares.ColumnName = "CelulasGlandulares";
				colvarCelulasGlandulares.DataType = DbType.AnsiString;
				colvarCelulasGlandulares.MaxLength = 100;
				colvarCelulasGlandulares.AutoIncrement = false;
				colvarCelulasGlandulares.IsNullable = true;
				colvarCelulasGlandulares.IsPrimaryKey = false;
				colvarCelulasGlandulares.IsForeignKey = false;
				colvarCelulasGlandulares.IsReadOnly = false;
				colvarCelulasGlandulares.DefaultSetting = @"";
				colvarCelulasGlandulares.ForeignKeyTableName = "";
				schema.Columns.Add(colvarCelulasGlandulares);
				
				TableSchema.TableColumn colvarResultado = new TableSchema.TableColumn(schema);
				colvarResultado.ColumnName = "resultado";
				colvarResultado.DataType = DbType.AnsiString;
				colvarResultado.MaxLength = 1000;
				colvarResultado.AutoIncrement = false;
				colvarResultado.IsNullable = true;
				colvarResultado.IsPrimaryKey = false;
				colvarResultado.IsForeignKey = false;
				colvarResultado.IsReadOnly = false;
				colvarResultado.DefaultSetting = @"";
				colvarResultado.ForeignKeyTableName = "";
				schema.Columns.Add(colvarResultado);
				
				TableSchema.TableColumn colvarCodigo = new TableSchema.TableColumn(schema);
				colvarCodigo.ColumnName = "codigo";
				colvarCodigo.DataType = DbType.AnsiString;
				colvarCodigo.MaxLength = 10;
				colvarCodigo.AutoIncrement = false;
				colvarCodigo.IsNullable = true;
				colvarCodigo.IsPrimaryKey = false;
				colvarCodigo.IsForeignKey = false;
				colvarCodigo.IsReadOnly = false;
				colvarCodigo.DefaultSetting = @"";
				colvarCodigo.ForeignKeyTableName = "";
				schema.Columns.Add(colvarCodigo);
				
				TableSchema.TableColumn colvarCantidad = new TableSchema.TableColumn(schema);
				colvarCantidad.ColumnName = "cantidad";
				colvarCantidad.DataType = DbType.Int32;
				colvarCantidad.MaxLength = 0;
				colvarCantidad.AutoIncrement = false;
				colvarCantidad.IsNullable = true;
				colvarCantidad.IsPrimaryKey = false;
				colvarCantidad.IsForeignKey = false;
				colvarCantidad.IsReadOnly = false;
				colvarCantidad.DefaultSetting = @"";
				colvarCantidad.ForeignKeyTableName = "";
				schema.Columns.Add(colvarCantidad);
				
				TableSchema.TableColumn colvarIdEfectorOrigen = new TableSchema.TableColumn(schema);
				colvarIdEfectorOrigen.ColumnName = "idEfectorOrigen";
				colvarIdEfectorOrigen.DataType = DbType.Int32;
				colvarIdEfectorOrigen.MaxLength = 0;
				colvarIdEfectorOrigen.AutoIncrement = false;
				colvarIdEfectorOrigen.IsNullable = true;
				colvarIdEfectorOrigen.IsPrimaryKey = false;
				colvarIdEfectorOrigen.IsForeignKey = false;
				colvarIdEfectorOrigen.IsReadOnly = false;
				
						colvarIdEfectorOrigen.DefaultSetting = @"((0))";
				colvarIdEfectorOrigen.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdEfectorOrigen);
				
				TableSchema.TableColumn colvarOrigen = new TableSchema.TableColumn(schema);
				colvarOrigen.ColumnName = "origen";
				colvarOrigen.DataType = DbType.AnsiString;
				colvarOrigen.MaxLength = 200;
				colvarOrigen.AutoIncrement = false;
				colvarOrigen.IsNullable = true;
				colvarOrigen.IsPrimaryKey = false;
				colvarOrigen.IsForeignKey = false;
				colvarOrigen.IsReadOnly = false;
				colvarOrigen.DefaultSetting = @"";
				colvarOrigen.ForeignKeyTableName = "";
				schema.Columns.Add(colvarOrigen);
				
				TableSchema.TableColumn colvarZona = new TableSchema.TableColumn(schema);
				colvarZona.ColumnName = "zona";
				colvarZona.DataType = DbType.AnsiString;
				colvarZona.MaxLength = 200;
				colvarZona.AutoIncrement = false;
				colvarZona.IsNullable = true;
				colvarZona.IsPrimaryKey = false;
				colvarZona.IsForeignKey = false;
				colvarZona.IsReadOnly = false;
				colvarZona.DefaultSetting = @"";
				colvarZona.ForeignKeyTableName = "";
				schema.Columns.Add(colvarZona);
				
				TableSchema.TableColumn colvarFirmado = new TableSchema.TableColumn(schema);
				colvarFirmado.ColumnName = "firmado";
				colvarFirmado.DataType = DbType.AnsiString;
				colvarFirmado.MaxLength = 10;
				colvarFirmado.AutoIncrement = false;
				colvarFirmado.IsNullable = true;
				colvarFirmado.IsPrimaryKey = false;
				colvarFirmado.IsForeignKey = false;
				colvarFirmado.IsReadOnly = false;
				colvarFirmado.DefaultSetting = @"";
				colvarFirmado.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFirmado);
				
				TableSchema.TableColumn colvarUsuarioHP = new TableSchema.TableColumn(schema);
				colvarUsuarioHP.ColumnName = "usuarioHP";
				colvarUsuarioHP.DataType = DbType.AnsiString;
				colvarUsuarioHP.MaxLength = 50;
				colvarUsuarioHP.AutoIncrement = false;
				colvarUsuarioHP.IsNullable = true;
				colvarUsuarioHP.IsPrimaryKey = false;
				colvarUsuarioHP.IsForeignKey = false;
				colvarUsuarioHP.IsReadOnly = false;
				colvarUsuarioHP.DefaultSetting = @"";
				colvarUsuarioHP.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUsuarioHP);
				
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
				
				TableSchema.TableColumn colvarCreatedBy = new TableSchema.TableColumn(schema);
				colvarCreatedBy.ColumnName = "CreatedBy";
				colvarCreatedBy.DataType = DbType.AnsiString;
				colvarCreatedBy.MaxLength = 50;
				colvarCreatedBy.AutoIncrement = false;
				colvarCreatedBy.IsNullable = true;
				colvarCreatedBy.IsPrimaryKey = false;
				colvarCreatedBy.IsForeignKey = false;
				colvarCreatedBy.IsReadOnly = false;
				colvarCreatedBy.DefaultSetting = @"";
				colvarCreatedBy.ForeignKeyTableName = "";
				schema.Columns.Add(colvarCreatedBy);
				
				TableSchema.TableColumn colvarCreatedOn = new TableSchema.TableColumn(schema);
				colvarCreatedOn.ColumnName = "CreatedOn";
				colvarCreatedOn.DataType = DbType.DateTime;
				colvarCreatedOn.MaxLength = 0;
				colvarCreatedOn.AutoIncrement = false;
				colvarCreatedOn.IsNullable = true;
				colvarCreatedOn.IsPrimaryKey = false;
				colvarCreatedOn.IsForeignKey = false;
				colvarCreatedOn.IsReadOnly = false;
				colvarCreatedOn.DefaultSetting = @"";
				colvarCreatedOn.ForeignKeyTableName = "";
				schema.Columns.Add(colvarCreatedOn);
				
				TableSchema.TableColumn colvarModifiedBy = new TableSchema.TableColumn(schema);
				colvarModifiedBy.ColumnName = "ModifiedBy";
				colvarModifiedBy.DataType = DbType.AnsiString;
				colvarModifiedBy.MaxLength = 50;
				colvarModifiedBy.AutoIncrement = false;
				colvarModifiedBy.IsNullable = true;
				colvarModifiedBy.IsPrimaryKey = false;
				colvarModifiedBy.IsForeignKey = false;
				colvarModifiedBy.IsReadOnly = false;
				colvarModifiedBy.DefaultSetting = @"";
				colvarModifiedBy.ForeignKeyTableName = "";
				schema.Columns.Add(colvarModifiedBy);
				
				TableSchema.TableColumn colvarModifiedOn = new TableSchema.TableColumn(schema);
				colvarModifiedOn.ColumnName = "ModifiedOn";
				colvarModifiedOn.DataType = DbType.DateTime;
				colvarModifiedOn.MaxLength = 0;
				colvarModifiedOn.AutoIncrement = false;
				colvarModifiedOn.IsNullable = true;
				colvarModifiedOn.IsPrimaryKey = false;
				colvarModifiedOn.IsForeignKey = false;
				colvarModifiedOn.IsReadOnly = false;
				colvarModifiedOn.DefaultSetting = @"";
				colvarModifiedOn.ForeignKeyTableName = "";
				schema.Columns.Add(colvarModifiedOn);
				
				TableSchema.TableColumn colvarObservaciones = new TableSchema.TableColumn(schema);
				colvarObservaciones.ColumnName = "Observaciones";
				colvarObservaciones.DataType = DbType.AnsiString;
				colvarObservaciones.MaxLength = 100;
				colvarObservaciones.AutoIncrement = false;
				colvarObservaciones.IsNullable = true;
				colvarObservaciones.IsPrimaryKey = false;
				colvarObservaciones.IsForeignKey = false;
				colvarObservaciones.IsReadOnly = false;
				
						colvarObservaciones.DefaultSetting = @"('')";
				colvarObservaciones.ForeignKeyTableName = "";
				schema.Columns.Add(colvarObservaciones);
				
				TableSchema.TableColumn colvarPasadoSips = new TableSchema.TableColumn(schema);
				colvarPasadoSips.ColumnName = "pasadoSips";
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
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["RisProvider"].AddSchema("TAM_PapHospitalProvincial",schema);
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
		  
		[XmlAttribute("FechaIngreso")]
		[Bindable(true)]
		public DateTime? FechaIngreso 
		{
			get { return GetColumnValue<DateTime?>(Columns.FechaIngreso); }
			set { SetColumnValue(Columns.FechaIngreso, value); }
		}
		  
		[XmlAttribute("Protocolo")]
		[Bindable(true)]
		public string Protocolo 
		{
			get { return GetColumnValue<string>(Columns.Protocolo); }
			set { SetColumnValue(Columns.Protocolo, value); }
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
		  
		[XmlAttribute("Documento")]
		[Bindable(true)]
		public int Documento 
		{
			get { return GetColumnValue<int>(Columns.Documento); }
			set { SetColumnValue(Columns.Documento, value); }
		}
		  
		[XmlAttribute("FechaNacimiento")]
		[Bindable(true)]
		public DateTime? FechaNacimiento 
		{
			get { return GetColumnValue<DateTime?>(Columns.FechaNacimiento); }
			set { SetColumnValue(Columns.FechaNacimiento, value); }
		}
		  
		[XmlAttribute("Edad")]
		[Bindable(true)]
		public int Edad 
		{
			get { return GetColumnValue<int>(Columns.Edad); }
			set { SetColumnValue(Columns.Edad, value); }
		}
		  
		[XmlAttribute("ObraSocial")]
		[Bindable(true)]
		public string ObraSocial 
		{
			get { return GetColumnValue<string>(Columns.ObraSocial); }
			set { SetColumnValue(Columns.ObraSocial, value); }
		}
		  
		[XmlAttribute("EstadoPrestacion")]
		[Bindable(true)]
		public string EstadoPrestacion 
		{
			get { return GetColumnValue<string>(Columns.EstadoPrestacion); }
			set { SetColumnValue(Columns.EstadoPrestacion, value); }
		}
		  
		[XmlAttribute("FechaDiagnostico")]
		[Bindable(true)]
		public DateTime? FechaDiagnostico 
		{
			get { return GetColumnValue<DateTime?>(Columns.FechaDiagnostico); }
			set { SetColumnValue(Columns.FechaDiagnostico, value); }
		}
		  
		[XmlAttribute("IdCelulasEscamosas")]
		[Bindable(true)]
		public int? IdCelulasEscamosas 
		{
			get { return GetColumnValue<int?>(Columns.IdCelulasEscamosas); }
			set { SetColumnValue(Columns.IdCelulasEscamosas, value); }
		}
		  
		[XmlAttribute("CelulasEscamosas")]
		[Bindable(true)]
		public string CelulasEscamosas 
		{
			get { return GetColumnValue<string>(Columns.CelulasEscamosas); }
			set { SetColumnValue(Columns.CelulasEscamosas, value); }
		}
		  
		[XmlAttribute("IdCelulasGlandulares")]
		[Bindable(true)]
		public int? IdCelulasGlandulares 
		{
			get { return GetColumnValue<int?>(Columns.IdCelulasGlandulares); }
			set { SetColumnValue(Columns.IdCelulasGlandulares, value); }
		}
		  
		[XmlAttribute("CelulasGlandulares")]
		[Bindable(true)]
		public string CelulasGlandulares 
		{
			get { return GetColumnValue<string>(Columns.CelulasGlandulares); }
			set { SetColumnValue(Columns.CelulasGlandulares, value); }
		}
		  
		[XmlAttribute("Resultado")]
		[Bindable(true)]
		public string Resultado 
		{
			get { return GetColumnValue<string>(Columns.Resultado); }
			set { SetColumnValue(Columns.Resultado, value); }
		}
		  
		[XmlAttribute("Codigo")]
		[Bindable(true)]
		public string Codigo 
		{
			get { return GetColumnValue<string>(Columns.Codigo); }
			set { SetColumnValue(Columns.Codigo, value); }
		}
		  
		[XmlAttribute("Cantidad")]
		[Bindable(true)]
		public int? Cantidad 
		{
			get { return GetColumnValue<int?>(Columns.Cantidad); }
			set { SetColumnValue(Columns.Cantidad, value); }
		}
		  
		[XmlAttribute("IdEfectorOrigen")]
		[Bindable(true)]
		public int? IdEfectorOrigen 
		{
			get { return GetColumnValue<int?>(Columns.IdEfectorOrigen); }
			set { SetColumnValue(Columns.IdEfectorOrigen, value); }
		}
		  
		[XmlAttribute("Origen")]
		[Bindable(true)]
		public string Origen 
		{
			get { return GetColumnValue<string>(Columns.Origen); }
			set { SetColumnValue(Columns.Origen, value); }
		}
		  
		[XmlAttribute("Zona")]
		[Bindable(true)]
		public string Zona 
		{
			get { return GetColumnValue<string>(Columns.Zona); }
			set { SetColumnValue(Columns.Zona, value); }
		}
		  
		[XmlAttribute("Firmado")]
		[Bindable(true)]
		public string Firmado 
		{
			get { return GetColumnValue<string>(Columns.Firmado); }
			set { SetColumnValue(Columns.Firmado, value); }
		}
		  
		[XmlAttribute("UsuarioHP")]
		[Bindable(true)]
		public string UsuarioHP 
		{
			get { return GetColumnValue<string>(Columns.UsuarioHP); }
			set { SetColumnValue(Columns.UsuarioHP, value); }
		}
		  
		[XmlAttribute("Activo")]
		[Bindable(true)]
		public bool Activo 
		{
			get { return GetColumnValue<bool>(Columns.Activo); }
			set { SetColumnValue(Columns.Activo, value); }
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
		public DateTime? CreatedOn 
		{
			get { return GetColumnValue<DateTime?>(Columns.CreatedOn); }
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
		public DateTime? ModifiedOn 
		{
			get { return GetColumnValue<DateTime?>(Columns.ModifiedOn); }
			set { SetColumnValue(Columns.ModifiedOn, value); }
		}
		  
		[XmlAttribute("Observaciones")]
		[Bindable(true)]
		public string Observaciones 
		{
			get { return GetColumnValue<string>(Columns.Observaciones); }
			set { SetColumnValue(Columns.Observaciones, value); }
		}
		  
		[XmlAttribute("PasadoSips")]
		[Bindable(true)]
		public bool? PasadoSips 
		{
			get { return GetColumnValue<bool?>(Columns.PasadoSips); }
			set { SetColumnValue(Columns.PasadoSips, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(DateTime? varFechaIngreso,string varProtocolo,string varApellido,string varNombre,int varDocumento,DateTime? varFechaNacimiento,int varEdad,string varObraSocial,string varEstadoPrestacion,DateTime? varFechaDiagnostico,int? varIdCelulasEscamosas,string varCelulasEscamosas,int? varIdCelulasGlandulares,string varCelulasGlandulares,string varResultado,string varCodigo,int? varCantidad,int? varIdEfectorOrigen,string varOrigen,string varZona,string varFirmado,string varUsuarioHP,bool varActivo,string varCreatedBy,DateTime? varCreatedOn,string varModifiedBy,DateTime? varModifiedOn,string varObservaciones,bool? varPasadoSips)
		{
			TamPapHospitalProvincial item = new TamPapHospitalProvincial();
			
			item.FechaIngreso = varFechaIngreso;
			
			item.Protocolo = varProtocolo;
			
			item.Apellido = varApellido;
			
			item.Nombre = varNombre;
			
			item.Documento = varDocumento;
			
			item.FechaNacimiento = varFechaNacimiento;
			
			item.Edad = varEdad;
			
			item.ObraSocial = varObraSocial;
			
			item.EstadoPrestacion = varEstadoPrestacion;
			
			item.FechaDiagnostico = varFechaDiagnostico;
			
			item.IdCelulasEscamosas = varIdCelulasEscamosas;
			
			item.CelulasEscamosas = varCelulasEscamosas;
			
			item.IdCelulasGlandulares = varIdCelulasGlandulares;
			
			item.CelulasGlandulares = varCelulasGlandulares;
			
			item.Resultado = varResultado;
			
			item.Codigo = varCodigo;
			
			item.Cantidad = varCantidad;
			
			item.IdEfectorOrigen = varIdEfectorOrigen;
			
			item.Origen = varOrigen;
			
			item.Zona = varZona;
			
			item.Firmado = varFirmado;
			
			item.UsuarioHP = varUsuarioHP;
			
			item.Activo = varActivo;
			
			item.CreatedBy = varCreatedBy;
			
			item.CreatedOn = varCreatedOn;
			
			item.ModifiedBy = varModifiedBy;
			
			item.ModifiedOn = varModifiedOn;
			
			item.Observaciones = varObservaciones;
			
			item.PasadoSips = varPasadoSips;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varIdPapHP,DateTime? varFechaIngreso,string varProtocolo,string varApellido,string varNombre,int varDocumento,DateTime? varFechaNacimiento,int varEdad,string varObraSocial,string varEstadoPrestacion,DateTime? varFechaDiagnostico,int? varIdCelulasEscamosas,string varCelulasEscamosas,int? varIdCelulasGlandulares,string varCelulasGlandulares,string varResultado,string varCodigo,int? varCantidad,int? varIdEfectorOrigen,string varOrigen,string varZona,string varFirmado,string varUsuarioHP,bool varActivo,string varCreatedBy,DateTime? varCreatedOn,string varModifiedBy,DateTime? varModifiedOn,string varObservaciones,bool? varPasadoSips)
		{
			TamPapHospitalProvincial item = new TamPapHospitalProvincial();
			
				item.IdPapHP = varIdPapHP;
			
				item.FechaIngreso = varFechaIngreso;
			
				item.Protocolo = varProtocolo;
			
				item.Apellido = varApellido;
			
				item.Nombre = varNombre;
			
				item.Documento = varDocumento;
			
				item.FechaNacimiento = varFechaNacimiento;
			
				item.Edad = varEdad;
			
				item.ObraSocial = varObraSocial;
			
				item.EstadoPrestacion = varEstadoPrestacion;
			
				item.FechaDiagnostico = varFechaDiagnostico;
			
				item.IdCelulasEscamosas = varIdCelulasEscamosas;
			
				item.CelulasEscamosas = varCelulasEscamosas;
			
				item.IdCelulasGlandulares = varIdCelulasGlandulares;
			
				item.CelulasGlandulares = varCelulasGlandulares;
			
				item.Resultado = varResultado;
			
				item.Codigo = varCodigo;
			
				item.Cantidad = varCantidad;
			
				item.IdEfectorOrigen = varIdEfectorOrigen;
			
				item.Origen = varOrigen;
			
				item.Zona = varZona;
			
				item.Firmado = varFirmado;
			
				item.UsuarioHP = varUsuarioHP;
			
				item.Activo = varActivo;
			
				item.CreatedBy = varCreatedBy;
			
				item.CreatedOn = varCreatedOn;
			
				item.ModifiedBy = varModifiedBy;
			
				item.ModifiedOn = varModifiedOn;
			
				item.Observaciones = varObservaciones;
			
				item.PasadoSips = varPasadoSips;
			
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
        
        
        
        public static TableSchema.TableColumn FechaIngresoColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn ProtocoloColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn ApellidoColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn NombreColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn DocumentoColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        public static TableSchema.TableColumn FechaNacimientoColumn
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        public static TableSchema.TableColumn EdadColumn
        {
            get { return Schema.Columns[7]; }
        }
        
        
        
        public static TableSchema.TableColumn ObraSocialColumn
        {
            get { return Schema.Columns[8]; }
        }
        
        
        
        public static TableSchema.TableColumn EstadoPrestacionColumn
        {
            get { return Schema.Columns[9]; }
        }
        
        
        
        public static TableSchema.TableColumn FechaDiagnosticoColumn
        {
            get { return Schema.Columns[10]; }
        }
        
        
        
        public static TableSchema.TableColumn IdCelulasEscamosasColumn
        {
            get { return Schema.Columns[11]; }
        }
        
        
        
        public static TableSchema.TableColumn CelulasEscamosasColumn
        {
            get { return Schema.Columns[12]; }
        }
        
        
        
        public static TableSchema.TableColumn IdCelulasGlandularesColumn
        {
            get { return Schema.Columns[13]; }
        }
        
        
        
        public static TableSchema.TableColumn CelulasGlandularesColumn
        {
            get { return Schema.Columns[14]; }
        }
        
        
        
        public static TableSchema.TableColumn ResultadoColumn
        {
            get { return Schema.Columns[15]; }
        }
        
        
        
        public static TableSchema.TableColumn CodigoColumn
        {
            get { return Schema.Columns[16]; }
        }
        
        
        
        public static TableSchema.TableColumn CantidadColumn
        {
            get { return Schema.Columns[17]; }
        }
        
        
        
        public static TableSchema.TableColumn IdEfectorOrigenColumn
        {
            get { return Schema.Columns[18]; }
        }
        
        
        
        public static TableSchema.TableColumn OrigenColumn
        {
            get { return Schema.Columns[19]; }
        }
        
        
        
        public static TableSchema.TableColumn ZonaColumn
        {
            get { return Schema.Columns[20]; }
        }
        
        
        
        public static TableSchema.TableColumn FirmadoColumn
        {
            get { return Schema.Columns[21]; }
        }
        
        
        
        public static TableSchema.TableColumn UsuarioHPColumn
        {
            get { return Schema.Columns[22]; }
        }
        
        
        
        public static TableSchema.TableColumn ActivoColumn
        {
            get { return Schema.Columns[23]; }
        }
        
        
        
        public static TableSchema.TableColumn CreatedByColumn
        {
            get { return Schema.Columns[24]; }
        }
        
        
        
        public static TableSchema.TableColumn CreatedOnColumn
        {
            get { return Schema.Columns[25]; }
        }
        
        
        
        public static TableSchema.TableColumn ModifiedByColumn
        {
            get { return Schema.Columns[26]; }
        }
        
        
        
        public static TableSchema.TableColumn ModifiedOnColumn
        {
            get { return Schema.Columns[27]; }
        }
        
        
        
        public static TableSchema.TableColumn ObservacionesColumn
        {
            get { return Schema.Columns[28]; }
        }
        
        
        
        public static TableSchema.TableColumn PasadoSipsColumn
        {
            get { return Schema.Columns[29]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string IdPapHP = @"idPapHP";
			 public static string FechaIngreso = @"fechaIngreso";
			 public static string Protocolo = @"protocolo";
			 public static string Apellido = @"apellido";
			 public static string Nombre = @"nombre";
			 public static string Documento = @"documento";
			 public static string FechaNacimiento = @"fechaNacimiento";
			 public static string Edad = @"Edad";
			 public static string ObraSocial = @"ObraSocial";
			 public static string EstadoPrestacion = @"EstadoPrestacion";
			 public static string FechaDiagnostico = @"fechaDiagnostico";
			 public static string IdCelulasEscamosas = @"idCelulasEscamosas";
			 public static string CelulasEscamosas = @"CelulasEscamosas";
			 public static string IdCelulasGlandulares = @"idCelulasGlandulares";
			 public static string CelulasGlandulares = @"CelulasGlandulares";
			 public static string Resultado = @"resultado";
			 public static string Codigo = @"codigo";
			 public static string Cantidad = @"cantidad";
			 public static string IdEfectorOrigen = @"idEfectorOrigen";
			 public static string Origen = @"origen";
			 public static string Zona = @"zona";
			 public static string Firmado = @"firmado";
			 public static string UsuarioHP = @"usuarioHP";
			 public static string Activo = @"activo";
			 public static string CreatedBy = @"CreatedBy";
			 public static string CreatedOn = @"CreatedOn";
			 public static string ModifiedBy = @"ModifiedBy";
			 public static string ModifiedOn = @"ModifiedOn";
			 public static string Observaciones = @"Observaciones";
			 public static string PasadoSips = @"pasadoSips";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
