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
	/// Strongly-typed collection for the TamBiopsium class.
	/// </summary>
    [Serializable]
	public partial class TamBiopsiumCollection : ActiveList<TamBiopsium, TamBiopsiumCollection>
	{	   
		public TamBiopsiumCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>TamBiopsiumCollection</returns>
		public TamBiopsiumCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                TamBiopsium o = this[i];
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
	/// This is an ActiveRecord class which wraps the TAM_Biopsia table.
	/// </summary>
	[Serializable]
	public partial class TamBiopsium : ActiveRecord<TamBiopsium>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public TamBiopsium()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public TamBiopsium(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public TamBiopsium(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public TamBiopsium(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("TAM_Biopsia", TableType.Table, DataService.GetInstance("RisProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarIdBiopsia = new TableSchema.TableColumn(schema);
				colvarIdBiopsia.ColumnName = "idBiopsia";
				colvarIdBiopsia.DataType = DbType.Int32;
				colvarIdBiopsia.MaxLength = 0;
				colvarIdBiopsia.AutoIncrement = true;
				colvarIdBiopsia.IsNullable = false;
				colvarIdBiopsia.IsPrimaryKey = true;
				colvarIdBiopsia.IsForeignKey = false;
				colvarIdBiopsia.IsReadOnly = false;
				colvarIdBiopsia.DefaultSetting = @"";
				colvarIdBiopsia.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdBiopsia);
				
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
				
				TableSchema.TableColumn colvarFechaRealizacion = new TableSchema.TableColumn(schema);
				colvarFechaRealizacion.ColumnName = "fechaRealizacion";
				colvarFechaRealizacion.DataType = DbType.DateTime;
				colvarFechaRealizacion.MaxLength = 0;
				colvarFechaRealizacion.AutoIncrement = false;
				colvarFechaRealizacion.IsNullable = false;
				colvarFechaRealizacion.IsPrimaryKey = false;
				colvarFechaRealizacion.IsForeignKey = false;
				colvarFechaRealizacion.IsReadOnly = false;
				colvarFechaRealizacion.DefaultSetting = @"";
				colvarFechaRealizacion.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFechaRealizacion);
				
				TableSchema.TableColumn colvarOrigen = new TableSchema.TableColumn(schema);
				colvarOrigen.ColumnName = "origen";
				colvarOrigen.DataType = DbType.AnsiString;
				colvarOrigen.MaxLength = 50;
				colvarOrigen.AutoIncrement = false;
				colvarOrigen.IsNullable = false;
				colvarOrigen.IsPrimaryKey = false;
				colvarOrigen.IsForeignKey = false;
				colvarOrigen.IsReadOnly = false;
				
						colvarOrigen.DefaultSetting = @"('')";
				colvarOrigen.ForeignKeyTableName = "";
				schema.Columns.Add(colvarOrigen);
				
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
				
				TableSchema.TableColumn colvarNumeroIngreso = new TableSchema.TableColumn(schema);
				colvarNumeroIngreso.ColumnName = "numeroIngreso";
				colvarNumeroIngreso.DataType = DbType.Int32;
				colvarNumeroIngreso.MaxLength = 0;
				colvarNumeroIngreso.AutoIncrement = false;
				colvarNumeroIngreso.IsNullable = false;
				colvarNumeroIngreso.IsPrimaryKey = false;
				colvarNumeroIngreso.IsForeignKey = false;
				colvarNumeroIngreso.IsReadOnly = false;
				
						colvarNumeroIngreso.DefaultSetting = @"((0))";
				colvarNumeroIngreso.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNumeroIngreso);
				
				TableSchema.TableColumn colvarIdProfesionalPatologo = new TableSchema.TableColumn(schema);
				colvarIdProfesionalPatologo.ColumnName = "idProfesionalPatologo";
				colvarIdProfesionalPatologo.DataType = DbType.Int32;
				colvarIdProfesionalPatologo.MaxLength = 0;
				colvarIdProfesionalPatologo.AutoIncrement = false;
				colvarIdProfesionalPatologo.IsNullable = false;
				colvarIdProfesionalPatologo.IsPrimaryKey = false;
				colvarIdProfesionalPatologo.IsForeignKey = true;
				colvarIdProfesionalPatologo.IsReadOnly = false;
				
						colvarIdProfesionalPatologo.DefaultSetting = @"((0))";
				
					colvarIdProfesionalPatologo.ForeignKeyTableName = "Sys_Profesional";
				schema.Columns.Add(colvarIdProfesionalPatologo);
				
				TableSchema.TableColumn colvarIdEfectorResultado = new TableSchema.TableColumn(schema);
				colvarIdEfectorResultado.ColumnName = "idEfectorResultado";
				colvarIdEfectorResultado.DataType = DbType.Int32;
				colvarIdEfectorResultado.MaxLength = 0;
				colvarIdEfectorResultado.AutoIncrement = false;
				colvarIdEfectorResultado.IsNullable = false;
				colvarIdEfectorResultado.IsPrimaryKey = false;
				colvarIdEfectorResultado.IsForeignKey = true;
				colvarIdEfectorResultado.IsReadOnly = false;
				
						colvarIdEfectorResultado.DefaultSetting = @"((0))";
				
					colvarIdEfectorResultado.ForeignKeyTableName = "Sys_Efector";
				schema.Columns.Add(colvarIdEfectorResultado);
				
				TableSchema.TableColumn colvarMacroscopia = new TableSchema.TableColumn(schema);
				colvarMacroscopia.ColumnName = "macroscopia";
				colvarMacroscopia.DataType = DbType.AnsiString;
				colvarMacroscopia.MaxLength = 300;
				colvarMacroscopia.AutoIncrement = false;
				colvarMacroscopia.IsNullable = false;
				colvarMacroscopia.IsPrimaryKey = false;
				colvarMacroscopia.IsForeignKey = false;
				colvarMacroscopia.IsReadOnly = false;
				
						colvarMacroscopia.DefaultSetting = @"('')";
				colvarMacroscopia.ForeignKeyTableName = "";
				schema.Columns.Add(colvarMacroscopia);
				
				TableSchema.TableColumn colvarMicroscopia = new TableSchema.TableColumn(schema);
				colvarMicroscopia.ColumnName = "microscopia";
				colvarMicroscopia.DataType = DbType.AnsiString;
				colvarMicroscopia.MaxLength = 300;
				colvarMicroscopia.AutoIncrement = false;
				colvarMicroscopia.IsNullable = false;
				colvarMicroscopia.IsPrimaryKey = false;
				colvarMicroscopia.IsForeignKey = false;
				colvarMicroscopia.IsReadOnly = false;
				
						colvarMicroscopia.DefaultSetting = @"('')";
				colvarMicroscopia.ForeignKeyTableName = "";
				schema.Columns.Add(colvarMicroscopia);
				
				TableSchema.TableColumn colvarIdDiagnostico = new TableSchema.TableColumn(schema);
				colvarIdDiagnostico.ColumnName = "idDiagnostico";
				colvarIdDiagnostico.DataType = DbType.Int32;
				colvarIdDiagnostico.MaxLength = 0;
				colvarIdDiagnostico.AutoIncrement = false;
				colvarIdDiagnostico.IsNullable = false;
				colvarIdDiagnostico.IsPrimaryKey = false;
				colvarIdDiagnostico.IsForeignKey = true;
				colvarIdDiagnostico.IsReadOnly = false;
				
						colvarIdDiagnostico.DefaultSetting = @"((0))";
				
					colvarIdDiagnostico.ForeignKeyTableName = "TAM_Diagnostico";
				schema.Columns.Add(colvarIdDiagnostico);
				
				TableSchema.TableColumn colvarDiagnosticoAdicional = new TableSchema.TableColumn(schema);
				colvarDiagnosticoAdicional.ColumnName = "diagnosticoAdicional";
				colvarDiagnosticoAdicional.DataType = DbType.AnsiString;
				colvarDiagnosticoAdicional.MaxLength = 300;
				colvarDiagnosticoAdicional.AutoIncrement = false;
				colvarDiagnosticoAdicional.IsNullable = false;
				colvarDiagnosticoAdicional.IsPrimaryKey = false;
				colvarDiagnosticoAdicional.IsForeignKey = false;
				colvarDiagnosticoAdicional.IsReadOnly = false;
				
						colvarDiagnosticoAdicional.DefaultSetting = @"('')";
				colvarDiagnosticoAdicional.ForeignKeyTableName = "";
				schema.Columns.Add(colvarDiagnosticoAdicional);
				
				TableSchema.TableColumn colvarObservaciones = new TableSchema.TableColumn(schema);
				colvarObservaciones.ColumnName = "observaciones";
				colvarObservaciones.DataType = DbType.AnsiString;
				colvarObservaciones.MaxLength = 300;
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
				
				TableSchema.TableColumn colvarIdTipoMaterial = new TableSchema.TableColumn(schema);
				colvarIdTipoMaterial.ColumnName = "idTipoMaterial";
				colvarIdTipoMaterial.DataType = DbType.Int32;
				colvarIdTipoMaterial.MaxLength = 0;
				colvarIdTipoMaterial.AutoIncrement = false;
				colvarIdTipoMaterial.IsNullable = false;
				colvarIdTipoMaterial.IsPrimaryKey = false;
				colvarIdTipoMaterial.IsForeignKey = false;
				colvarIdTipoMaterial.IsReadOnly = false;
				
						colvarIdTipoMaterial.DefaultSetting = @"((0))";
				colvarIdTipoMaterial.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdTipoMaterial);
				
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
				DataService.Providers["RisProvider"].AddSchema("TAM_Biopsia",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("IdBiopsia")]
		[Bindable(true)]
		public int IdBiopsia 
		{
			get { return GetColumnValue<int>(Columns.IdBiopsia); }
			set { SetColumnValue(Columns.IdBiopsia, value); }
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
		  
		[XmlAttribute("FechaRealizacion")]
		[Bindable(true)]
		public DateTime FechaRealizacion 
		{
			get { return GetColumnValue<DateTime>(Columns.FechaRealizacion); }
			set { SetColumnValue(Columns.FechaRealizacion, value); }
		}
		  
		[XmlAttribute("Origen")]
		[Bindable(true)]
		public string Origen 
		{
			get { return GetColumnValue<string>(Columns.Origen); }
			set { SetColumnValue(Columns.Origen, value); }
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
		  
		[XmlAttribute("FechaInforme")]
		[Bindable(true)]
		public DateTime FechaInforme 
		{
			get { return GetColumnValue<DateTime>(Columns.FechaInforme); }
			set { SetColumnValue(Columns.FechaInforme, value); }
		}
		  
		[XmlAttribute("NumeroIngreso")]
		[Bindable(true)]
		public int NumeroIngreso 
		{
			get { return GetColumnValue<int>(Columns.NumeroIngreso); }
			set { SetColumnValue(Columns.NumeroIngreso, value); }
		}
		  
		[XmlAttribute("IdProfesionalPatologo")]
		[Bindable(true)]
		public int IdProfesionalPatologo 
		{
			get { return GetColumnValue<int>(Columns.IdProfesionalPatologo); }
			set { SetColumnValue(Columns.IdProfesionalPatologo, value); }
		}
		  
		[XmlAttribute("IdEfectorResultado")]
		[Bindable(true)]
		public int IdEfectorResultado 
		{
			get { return GetColumnValue<int>(Columns.IdEfectorResultado); }
			set { SetColumnValue(Columns.IdEfectorResultado, value); }
		}
		  
		[XmlAttribute("Macroscopia")]
		[Bindable(true)]
		public string Macroscopia 
		{
			get { return GetColumnValue<string>(Columns.Macroscopia); }
			set { SetColumnValue(Columns.Macroscopia, value); }
		}
		  
		[XmlAttribute("Microscopia")]
		[Bindable(true)]
		public string Microscopia 
		{
			get { return GetColumnValue<string>(Columns.Microscopia); }
			set { SetColumnValue(Columns.Microscopia, value); }
		}
		  
		[XmlAttribute("IdDiagnostico")]
		[Bindable(true)]
		public int IdDiagnostico 
		{
			get { return GetColumnValue<int>(Columns.IdDiagnostico); }
			set { SetColumnValue(Columns.IdDiagnostico, value); }
		}
		  
		[XmlAttribute("DiagnosticoAdicional")]
		[Bindable(true)]
		public string DiagnosticoAdicional 
		{
			get { return GetColumnValue<string>(Columns.DiagnosticoAdicional); }
			set { SetColumnValue(Columns.DiagnosticoAdicional, value); }
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
		  
		[XmlAttribute("IdTipoMaterial")]
		[Bindable(true)]
		public int IdTipoMaterial 
		{
			get { return GetColumnValue<int>(Columns.IdTipoMaterial); }
			set { SetColumnValue(Columns.IdTipoMaterial, value); }
		}
		  
		[XmlAttribute("Activo")]
		[Bindable(true)]
		public bool Activo 
		{
			get { return GetColumnValue<bool>(Columns.Activo); }
			set { SetColumnValue(Columns.Activo, value); }
		}
		
		#endregion
		
		
		#region PrimaryKey Methods		
		
        protected override void SetPrimaryKey(object oValue)
        {
            base.SetPrimaryKey(oValue);
            
            SetPKValues();
        }
        
		
		private DalRis.TamRelTipoMaterialBiopsiumCollection colTamRelTipoMaterialBiopsia;
		public DalRis.TamRelTipoMaterialBiopsiumCollection TamRelTipoMaterialBiopsia()
		{
			if(colTamRelTipoMaterialBiopsia == null)
			{
				colTamRelTipoMaterialBiopsia = new DalRis.TamRelTipoMaterialBiopsiumCollection().Where(TamRelTipoMaterialBiopsium.Columns.IdBiopsia, IdBiopsia).Load();
				colTamRelTipoMaterialBiopsia.ListChanged += new ListChangedEventHandler(colTamRelTipoMaterialBiopsia_ListChanged);
			}
			return colTamRelTipoMaterialBiopsia;
		}
				
		void colTamRelTipoMaterialBiopsia_ListChanged(object sender, ListChangedEventArgs e)
		{
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
		        // Set foreign key value
		        colTamRelTipoMaterialBiopsia[e.NewIndex].IdBiopsia = IdBiopsia;
				colTamRelTipoMaterialBiopsia.ListChanged += new ListChangedEventHandler(colTamRelTipoMaterialBiopsia_ListChanged);
            }
		}
		#endregion
		
			
		
		#region ForeignKey Properties
		
		/// <summary>
		/// Returns a TamDiagnostico ActiveRecord object related to this TamBiopsium
		/// 
		/// </summary>
		public DalRis.TamDiagnostico TamDiagnostico
		{
			get { return DalRis.TamDiagnostico.FetchByID(this.IdDiagnostico); }
			set { SetColumnValue("idDiagnostico", value.IdDiagnostico); }
		}
		
		
		/// <summary>
		/// Returns a SysEfector ActiveRecord object related to this TamBiopsium
		/// 
		/// </summary>
		public DalRis.SysEfector SysEfector
		{
			get { return DalRis.SysEfector.FetchByID(this.IdEfectorResultado); }
			set { SetColumnValue("idEfectorResultado", value.IdEfector); }
		}
		
		
		/// <summary>
		/// Returns a SysEfector ActiveRecord object related to this TamBiopsium
		/// 
		/// </summary>
		public DalRis.SysEfector SysEfectorToIdEfectorMuestra
		{
			get { return DalRis.SysEfector.FetchByID(this.IdEfectorMuestra); }
			set { SetColumnValue("idEfectorMuestra", value.IdEfector); }
		}
		
		
		/// <summary>
		/// Returns a SysEfector ActiveRecord object related to this TamBiopsium
		/// 
		/// </summary>
		public DalRis.SysEfector SysEfectorToIdEfectorMuestra
		{
			get { return DalRis.SysEfector.FetchByID(this.IdEfectorMuestra); }
			set { SetColumnValue("idEfectorMuestra", value.IdEfector); }
		}
		
		
		/// <summary>
		/// Returns a TamRegistro ActiveRecord object related to this TamBiopsium
		/// 
		/// </summary>
		public DalRis.TamRegistro TamRegistro
		{
			get { return DalRis.TamRegistro.FetchByID(this.IdTam); }
			set { SetColumnValue("idTam", value.IdTam); }
		}
		
		
		/// <summary>
		/// Returns a SysProfesional ActiveRecord object related to this TamBiopsium
		/// 
		/// </summary>
		public DalRis.SysProfesional SysProfesional
		{
			get { return DalRis.SysProfesional.FetchByID(this.IdProfesionalPatologo); }
			set { SetColumnValue("idProfesionalPatologo", value.IdProfesional); }
		}
		
		
		/// <summary>
		/// Returns a SysProfesional ActiveRecord object related to this TamBiopsium
		/// 
		/// </summary>
		public DalRis.SysProfesional SysProfesionalToIdProfesionalMuestra
		{
			get { return DalRis.SysProfesional.FetchByID(this.IdProfesionalMuestra); }
			set { SetColumnValue("idProfesionalMuestra", value.IdProfesional); }
		}
		
		
		#endregion
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(int varIdTam,int varIdPaciente,int varEdad,DateTime varFechaRealizacion,string varOrigen,int varIdProfesionalMuestra,int varIdEfectorMuestra,DateTime varFechaRecepcion,DateTime varFechaInforme,int varNumeroIngreso,int varIdProfesionalPatologo,int varIdEfectorResultado,string varMacroscopia,string varMicroscopia,int varIdDiagnostico,string varDiagnosticoAdicional,string varObservaciones,string varCreatedBy,DateTime varCreatedOn,string varModifiedBy,DateTime varModifiedOn,int varIdTipoMaterial,bool varActivo)
		{
			TamBiopsium item = new TamBiopsium();
			
			item.IdTam = varIdTam;
			
			item.IdPaciente = varIdPaciente;
			
			item.Edad = varEdad;
			
			item.FechaRealizacion = varFechaRealizacion;
			
			item.Origen = varOrigen;
			
			item.IdProfesionalMuestra = varIdProfesionalMuestra;
			
			item.IdEfectorMuestra = varIdEfectorMuestra;
			
			item.FechaRecepcion = varFechaRecepcion;
			
			item.FechaInforme = varFechaInforme;
			
			item.NumeroIngreso = varNumeroIngreso;
			
			item.IdProfesionalPatologo = varIdProfesionalPatologo;
			
			item.IdEfectorResultado = varIdEfectorResultado;
			
			item.Macroscopia = varMacroscopia;
			
			item.Microscopia = varMicroscopia;
			
			item.IdDiagnostico = varIdDiagnostico;
			
			item.DiagnosticoAdicional = varDiagnosticoAdicional;
			
			item.Observaciones = varObservaciones;
			
			item.CreatedBy = varCreatedBy;
			
			item.CreatedOn = varCreatedOn;
			
			item.ModifiedBy = varModifiedBy;
			
			item.ModifiedOn = varModifiedOn;
			
			item.IdTipoMaterial = varIdTipoMaterial;
			
			item.Activo = varActivo;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varIdBiopsia,int varIdTam,int varIdPaciente,int varEdad,DateTime varFechaRealizacion,string varOrigen,int varIdProfesionalMuestra,int varIdEfectorMuestra,DateTime varFechaRecepcion,DateTime varFechaInforme,int varNumeroIngreso,int varIdProfesionalPatologo,int varIdEfectorResultado,string varMacroscopia,string varMicroscopia,int varIdDiagnostico,string varDiagnosticoAdicional,string varObservaciones,string varCreatedBy,DateTime varCreatedOn,string varModifiedBy,DateTime varModifiedOn,int varIdTipoMaterial,bool varActivo)
		{
			TamBiopsium item = new TamBiopsium();
			
				item.IdBiopsia = varIdBiopsia;
			
				item.IdTam = varIdTam;
			
				item.IdPaciente = varIdPaciente;
			
				item.Edad = varEdad;
			
				item.FechaRealizacion = varFechaRealizacion;
			
				item.Origen = varOrigen;
			
				item.IdProfesionalMuestra = varIdProfesionalMuestra;
			
				item.IdEfectorMuestra = varIdEfectorMuestra;
			
				item.FechaRecepcion = varFechaRecepcion;
			
				item.FechaInforme = varFechaInforme;
			
				item.NumeroIngreso = varNumeroIngreso;
			
				item.IdProfesionalPatologo = varIdProfesionalPatologo;
			
				item.IdEfectorResultado = varIdEfectorResultado;
			
				item.Macroscopia = varMacroscopia;
			
				item.Microscopia = varMicroscopia;
			
				item.IdDiagnostico = varIdDiagnostico;
			
				item.DiagnosticoAdicional = varDiagnosticoAdicional;
			
				item.Observaciones = varObservaciones;
			
				item.CreatedBy = varCreatedBy;
			
				item.CreatedOn = varCreatedOn;
			
				item.ModifiedBy = varModifiedBy;
			
				item.ModifiedOn = varModifiedOn;
			
				item.IdTipoMaterial = varIdTipoMaterial;
			
				item.Activo = varActivo;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn IdBiopsiaColumn
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
        
        
        
        public static TableSchema.TableColumn FechaRealizacionColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn OrigenColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        public static TableSchema.TableColumn IdProfesionalMuestraColumn
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        public static TableSchema.TableColumn IdEfectorMuestraColumn
        {
            get { return Schema.Columns[7]; }
        }
        
        
        
        public static TableSchema.TableColumn FechaRecepcionColumn
        {
            get { return Schema.Columns[8]; }
        }
        
        
        
        public static TableSchema.TableColumn FechaInformeColumn
        {
            get { return Schema.Columns[9]; }
        }
        
        
        
        public static TableSchema.TableColumn NumeroIngresoColumn
        {
            get { return Schema.Columns[10]; }
        }
        
        
        
        public static TableSchema.TableColumn IdProfesionalPatologoColumn
        {
            get { return Schema.Columns[11]; }
        }
        
        
        
        public static TableSchema.TableColumn IdEfectorResultadoColumn
        {
            get { return Schema.Columns[12]; }
        }
        
        
        
        public static TableSchema.TableColumn MacroscopiaColumn
        {
            get { return Schema.Columns[13]; }
        }
        
        
        
        public static TableSchema.TableColumn MicroscopiaColumn
        {
            get { return Schema.Columns[14]; }
        }
        
        
        
        public static TableSchema.TableColumn IdDiagnosticoColumn
        {
            get { return Schema.Columns[15]; }
        }
        
        
        
        public static TableSchema.TableColumn DiagnosticoAdicionalColumn
        {
            get { return Schema.Columns[16]; }
        }
        
        
        
        public static TableSchema.TableColumn ObservacionesColumn
        {
            get { return Schema.Columns[17]; }
        }
        
        
        
        public static TableSchema.TableColumn CreatedByColumn
        {
            get { return Schema.Columns[18]; }
        }
        
        
        
        public static TableSchema.TableColumn CreatedOnColumn
        {
            get { return Schema.Columns[19]; }
        }
        
        
        
        public static TableSchema.TableColumn ModifiedByColumn
        {
            get { return Schema.Columns[20]; }
        }
        
        
        
        public static TableSchema.TableColumn ModifiedOnColumn
        {
            get { return Schema.Columns[21]; }
        }
        
        
        
        public static TableSchema.TableColumn IdTipoMaterialColumn
        {
            get { return Schema.Columns[22]; }
        }
        
        
        
        public static TableSchema.TableColumn ActivoColumn
        {
            get { return Schema.Columns[23]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string IdBiopsia = @"idBiopsia";
			 public static string IdTam = @"idTam";
			 public static string IdPaciente = @"idPaciente";
			 public static string Edad = @"edad";
			 public static string FechaRealizacion = @"fechaRealizacion";
			 public static string Origen = @"origen";
			 public static string IdProfesionalMuestra = @"idProfesionalMuestra";
			 public static string IdEfectorMuestra = @"idEfectorMuestra";
			 public static string FechaRecepcion = @"fechaRecepcion";
			 public static string FechaInforme = @"fechaInforme";
			 public static string NumeroIngreso = @"numeroIngreso";
			 public static string IdProfesionalPatologo = @"idProfesionalPatologo";
			 public static string IdEfectorResultado = @"idEfectorResultado";
			 public static string Macroscopia = @"macroscopia";
			 public static string Microscopia = @"microscopia";
			 public static string IdDiagnostico = @"idDiagnostico";
			 public static string DiagnosticoAdicional = @"diagnosticoAdicional";
			 public static string Observaciones = @"observaciones";
			 public static string CreatedBy = @"CreatedBy";
			 public static string CreatedOn = @"CreatedOn";
			 public static string ModifiedBy = @"ModifiedBy";
			 public static string ModifiedOn = @"ModifiedOn";
			 public static string IdTipoMaterial = @"idTipoMaterial";
			 public static string Activo = @"activo";
						
		}
		#endregion
		
		#region Update PK Collections
		
        public void SetPKValues()
        {
                if (colTamRelTipoMaterialBiopsia != null)
                {
                    foreach (DalRis.TamRelTipoMaterialBiopsium item in colTamRelTipoMaterialBiopsia)
                    {
                        if (item.IdBiopsia != IdBiopsia)
                        {
                            item.IdBiopsia = IdBiopsia;
                        }
                    }
               }
		}
        #endregion
    
        #region Deep Save
		
        public void DeepSave()
        {
            Save();
            
                if (colTamRelTipoMaterialBiopsia != null)
                {
                    colTamRelTipoMaterialBiopsia.SaveAll();
               }
		}
        #endregion
	}
}
