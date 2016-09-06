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
	/// Strongly-typed collection for the VgiDato class.
	/// </summary>
    [Serializable]
	public partial class VgiDatoCollection : ActiveList<VgiDato, VgiDatoCollection>
	{	   
		public VgiDatoCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>VgiDatoCollection</returns>
		public VgiDatoCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                VgiDato o = this[i];
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
	/// This is an ActiveRecord class which wraps the VGI_Datos table.
	/// </summary>
	[Serializable]
	public partial class VgiDato : ActiveRecord<VgiDato>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public VgiDato()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public VgiDato(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public VgiDato(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public VgiDato(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("VGI_Datos", TableType.Table, DataService.GetInstance("RisProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarIdVGIDato = new TableSchema.TableColumn(schema);
				colvarIdVGIDato.ColumnName = "idVGIDato";
				colvarIdVGIDato.DataType = DbType.Int32;
				colvarIdVGIDato.MaxLength = 0;
				colvarIdVGIDato.AutoIncrement = true;
				colvarIdVGIDato.IsNullable = false;
				colvarIdVGIDato.IsPrimaryKey = true;
				colvarIdVGIDato.IsForeignKey = false;
				colvarIdVGIDato.IsReadOnly = false;
				colvarIdVGIDato.DefaultSetting = @"";
				colvarIdVGIDato.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdVGIDato);
				
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
				
				TableSchema.TableColumn colvarIdTurno = new TableSchema.TableColumn(schema);
				colvarIdTurno.ColumnName = "idTurno";
				colvarIdTurno.DataType = DbType.Int32;
				colvarIdTurno.MaxLength = 0;
				colvarIdTurno.AutoIncrement = false;
				colvarIdTurno.IsNullable = true;
				colvarIdTurno.IsPrimaryKey = false;
				colvarIdTurno.IsForeignKey = true;
				colvarIdTurno.IsReadOnly = false;
				colvarIdTurno.DefaultSetting = @"";
				
					colvarIdTurno.ForeignKeyTableName = "CON_Turno";
				schema.Columns.Add(colvarIdTurno);
				
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
				
				TableSchema.TableColumn colvarVivienda = new TableSchema.TableColumn(schema);
				colvarVivienda.ColumnName = "Vivienda";
				colvarVivienda.DataType = DbType.String;
				colvarVivienda.MaxLength = 50;
				colvarVivienda.AutoIncrement = false;
				colvarVivienda.IsNullable = true;
				colvarVivienda.IsPrimaryKey = false;
				colvarVivienda.IsForeignKey = false;
				colvarVivienda.IsReadOnly = false;
				colvarVivienda.DefaultSetting = @"";
				colvarVivienda.ForeignKeyTableName = "";
				schema.Columns.Add(colvarVivienda);
				
				TableSchema.TableColumn colvarAñosEscolaridad = new TableSchema.TableColumn(schema);
				colvarAñosEscolaridad.ColumnName = "AñosEscolaridad";
				colvarAñosEscolaridad.DataType = DbType.Decimal;
				colvarAñosEscolaridad.MaxLength = 0;
				colvarAñosEscolaridad.AutoIncrement = false;
				colvarAñosEscolaridad.IsNullable = true;
				colvarAñosEscolaridad.IsPrimaryKey = false;
				colvarAñosEscolaridad.IsForeignKey = false;
				colvarAñosEscolaridad.IsReadOnly = false;
				colvarAñosEscolaridad.DefaultSetting = @"";
				colvarAñosEscolaridad.ForeignKeyTableName = "";
				schema.Columns.Add(colvarAñosEscolaridad);
				
				TableSchema.TableColumn colvarTrabajoPrevio = new TableSchema.TableColumn(schema);
				colvarTrabajoPrevio.ColumnName = "TrabajoPrevio";
				colvarTrabajoPrevio.DataType = DbType.String;
				colvarTrabajoPrevio.MaxLength = 150;
				colvarTrabajoPrevio.AutoIncrement = false;
				colvarTrabajoPrevio.IsNullable = true;
				colvarTrabajoPrevio.IsPrimaryKey = false;
				colvarTrabajoPrevio.IsForeignKey = false;
				colvarTrabajoPrevio.IsReadOnly = false;
				colvarTrabajoPrevio.DefaultSetting = @"";
				colvarTrabajoPrevio.ForeignKeyTableName = "";
				schema.Columns.Add(colvarTrabajoPrevio);
				
				TableSchema.TableColumn colvarIngresos = new TableSchema.TableColumn(schema);
				colvarIngresos.ColumnName = "Ingresos";
				colvarIngresos.DataType = DbType.String;
				colvarIngresos.MaxLength = 15;
				colvarIngresos.AutoIncrement = false;
				colvarIngresos.IsNullable = true;
				colvarIngresos.IsPrimaryKey = false;
				colvarIngresos.IsForeignKey = false;
				colvarIngresos.IsReadOnly = false;
				colvarIngresos.DefaultSetting = @"";
				colvarIngresos.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIngresos);
				
				TableSchema.TableColumn colvarCentroAsistencia = new TableSchema.TableColumn(schema);
				colvarCentroAsistencia.ColumnName = "CentroAsistencia";
				colvarCentroAsistencia.DataType = DbType.Int32;
				colvarCentroAsistencia.MaxLength = 0;
				colvarCentroAsistencia.AutoIncrement = false;
				colvarCentroAsistencia.IsNullable = true;
				colvarCentroAsistencia.IsPrimaryKey = false;
				colvarCentroAsistencia.IsForeignKey = false;
				colvarCentroAsistencia.IsReadOnly = false;
				colvarCentroAsistencia.DefaultSetting = @"";
				colvarCentroAsistencia.ForeignKeyTableName = "";
				schema.Columns.Add(colvarCentroAsistencia);
				
				TableSchema.TableColumn colvarFamiliarACargo = new TableSchema.TableColumn(schema);
				colvarFamiliarACargo.ColumnName = "FamiliarACargo";
				colvarFamiliarACargo.DataType = DbType.String;
				colvarFamiliarACargo.MaxLength = 150;
				colvarFamiliarACargo.AutoIncrement = false;
				colvarFamiliarACargo.IsNullable = true;
				colvarFamiliarACargo.IsPrimaryKey = false;
				colvarFamiliarACargo.IsForeignKey = false;
				colvarFamiliarACargo.IsReadOnly = false;
				colvarFamiliarACargo.DefaultSetting = @"";
				colvarFamiliarACargo.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFamiliarACargo);
				
				TableSchema.TableColumn colvarVinculo = new TableSchema.TableColumn(schema);
				colvarVinculo.ColumnName = "Vinculo";
				colvarVinculo.DataType = DbType.String;
				colvarVinculo.MaxLength = 50;
				colvarVinculo.AutoIncrement = false;
				colvarVinculo.IsNullable = true;
				colvarVinculo.IsPrimaryKey = false;
				colvarVinculo.IsForeignKey = false;
				colvarVinculo.IsReadOnly = false;
				colvarVinculo.DefaultSetting = @"";
				colvarVinculo.ForeignKeyTableName = "";
				schema.Columns.Add(colvarVinculo);
				
				TableSchema.TableColumn colvarIdMedicoCabecera = new TableSchema.TableColumn(schema);
				colvarIdMedicoCabecera.ColumnName = "idMedicoCabecera";
				colvarIdMedicoCabecera.DataType = DbType.Int32;
				colvarIdMedicoCabecera.MaxLength = 0;
				colvarIdMedicoCabecera.AutoIncrement = false;
				colvarIdMedicoCabecera.IsNullable = true;
				colvarIdMedicoCabecera.IsPrimaryKey = false;
				colvarIdMedicoCabecera.IsForeignKey = true;
				colvarIdMedicoCabecera.IsReadOnly = false;
				colvarIdMedicoCabecera.DefaultSetting = @"";
				
					colvarIdMedicoCabecera.ForeignKeyTableName = "Sys_Profesional";
				schema.Columns.Add(colvarIdMedicoCabecera);
				
				TableSchema.TableColumn colvarContacto = new TableSchema.TableColumn(schema);
				colvarContacto.ColumnName = "Contacto";
				colvarContacto.DataType = DbType.String;
				colvarContacto.MaxLength = 150;
				colvarContacto.AutoIncrement = false;
				colvarContacto.IsNullable = true;
				colvarContacto.IsPrimaryKey = false;
				colvarContacto.IsForeignKey = false;
				colvarContacto.IsReadOnly = false;
				colvarContacto.DefaultSetting = @"";
				colvarContacto.ForeignKeyTableName = "";
				schema.Columns.Add(colvarContacto);
				
				TableSchema.TableColumn colvarTotalClinico = new TableSchema.TableColumn(schema);
				colvarTotalClinico.ColumnName = "TotalClinico";
				colvarTotalClinico.DataType = DbType.Int32;
				colvarTotalClinico.MaxLength = 0;
				colvarTotalClinico.AutoIncrement = false;
				colvarTotalClinico.IsNullable = true;
				colvarTotalClinico.IsPrimaryKey = false;
				colvarTotalClinico.IsForeignKey = false;
				colvarTotalClinico.IsReadOnly = false;
				colvarTotalClinico.DefaultSetting = @"";
				colvarTotalClinico.ForeignKeyTableName = "";
				schema.Columns.Add(colvarTotalClinico);
				
				TableSchema.TableColumn colvarTotalRCVG = new TableSchema.TableColumn(schema);
				colvarTotalRCVG.ColumnName = "TotalRCVG";
				colvarTotalRCVG.DataType = DbType.Int32;
				colvarTotalRCVG.MaxLength = 0;
				colvarTotalRCVG.AutoIncrement = false;
				colvarTotalRCVG.IsNullable = true;
				colvarTotalRCVG.IsPrimaryKey = false;
				colvarTotalRCVG.IsForeignKey = false;
				colvarTotalRCVG.IsReadOnly = false;
				colvarTotalRCVG.DefaultSetting = @"";
				colvarTotalRCVG.ForeignKeyTableName = "";
				schema.Columns.Add(colvarTotalRCVG);
				
				TableSchema.TableColumn colvarTotalABVD = new TableSchema.TableColumn(schema);
				colvarTotalABVD.ColumnName = "TotalABVD";
				colvarTotalABVD.DataType = DbType.Int32;
				colvarTotalABVD.MaxLength = 0;
				colvarTotalABVD.AutoIncrement = false;
				colvarTotalABVD.IsNullable = true;
				colvarTotalABVD.IsPrimaryKey = false;
				colvarTotalABVD.IsForeignKey = false;
				colvarTotalABVD.IsReadOnly = false;
				colvarTotalABVD.DefaultSetting = @"";
				colvarTotalABVD.ForeignKeyTableName = "";
				schema.Columns.Add(colvarTotalABVD);
				
				TableSchema.TableColumn colvarTotalAIVD = new TableSchema.TableColumn(schema);
				colvarTotalAIVD.ColumnName = "TotalAIVD";
				colvarTotalAIVD.DataType = DbType.Int32;
				colvarTotalAIVD.MaxLength = 0;
				colvarTotalAIVD.AutoIncrement = false;
				colvarTotalAIVD.IsNullable = true;
				colvarTotalAIVD.IsPrimaryKey = false;
				colvarTotalAIVD.IsForeignKey = false;
				colvarTotalAIVD.IsReadOnly = false;
				colvarTotalAIVD.DefaultSetting = @"";
				colvarTotalAIVD.ForeignKeyTableName = "";
				schema.Columns.Add(colvarTotalAIVD);
				
				TableSchema.TableColumn colvarTotalSocial = new TableSchema.TableColumn(schema);
				colvarTotalSocial.ColumnName = "TotalSocial";
				colvarTotalSocial.DataType = DbType.Int32;
				colvarTotalSocial.MaxLength = 0;
				colvarTotalSocial.AutoIncrement = false;
				colvarTotalSocial.IsNullable = true;
				colvarTotalSocial.IsPrimaryKey = false;
				colvarTotalSocial.IsForeignKey = false;
				colvarTotalSocial.IsReadOnly = false;
				colvarTotalSocial.DefaultSetting = @"";
				colvarTotalSocial.ForeignKeyTableName = "";
				schema.Columns.Add(colvarTotalSocial);
				
				TableSchema.TableColumn colvarTotalMental = new TableSchema.TableColumn(schema);
				colvarTotalMental.ColumnName = "TotalMental";
				colvarTotalMental.DataType = DbType.Int32;
				colvarTotalMental.MaxLength = 0;
				colvarTotalMental.AutoIncrement = false;
				colvarTotalMental.IsNullable = true;
				colvarTotalMental.IsPrimaryKey = false;
				colvarTotalMental.IsForeignKey = false;
				colvarTotalMental.IsReadOnly = false;
				colvarTotalMental.DefaultSetting = @"";
				colvarTotalMental.ForeignKeyTableName = "";
				schema.Columns.Add(colvarTotalMental);
				
				TableSchema.TableColumn colvarProximaEvaluacion = new TableSchema.TableColumn(schema);
				colvarProximaEvaluacion.ColumnName = "ProximaEvaluacion";
				colvarProximaEvaluacion.DataType = DbType.DateTime;
				colvarProximaEvaluacion.MaxLength = 0;
				colvarProximaEvaluacion.AutoIncrement = false;
				colvarProximaEvaluacion.IsNullable = true;
				colvarProximaEvaluacion.IsPrimaryKey = false;
				colvarProximaEvaluacion.IsForeignKey = false;
				colvarProximaEvaluacion.IsReadOnly = false;
				colvarProximaEvaluacion.DefaultSetting = @"";
				colvarProximaEvaluacion.ForeignKeyTableName = "";
				schema.Columns.Add(colvarProximaEvaluacion);
				
				TableSchema.TableColumn colvarIdUsuarioCarga = new TableSchema.TableColumn(schema);
				colvarIdUsuarioCarga.ColumnName = "idUsuarioCarga";
				colvarIdUsuarioCarga.DataType = DbType.Int32;
				colvarIdUsuarioCarga.MaxLength = 0;
				colvarIdUsuarioCarga.AutoIncrement = false;
				colvarIdUsuarioCarga.IsNullable = true;
				colvarIdUsuarioCarga.IsPrimaryKey = false;
				colvarIdUsuarioCarga.IsForeignKey = false;
				colvarIdUsuarioCarga.IsReadOnly = false;
				colvarIdUsuarioCarga.DefaultSetting = @"";
				colvarIdUsuarioCarga.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdUsuarioCarga);
				
				TableSchema.TableColumn colvarFechaCarga = new TableSchema.TableColumn(schema);
				colvarFechaCarga.ColumnName = "FechaCarga";
				colvarFechaCarga.DataType = DbType.DateTime;
				colvarFechaCarga.MaxLength = 0;
				colvarFechaCarga.AutoIncrement = false;
				colvarFechaCarga.IsNullable = true;
				colvarFechaCarga.IsPrimaryKey = false;
				colvarFechaCarga.IsForeignKey = false;
				colvarFechaCarga.IsReadOnly = false;
				colvarFechaCarga.DefaultSetting = @"";
				colvarFechaCarga.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFechaCarga);
				
				TableSchema.TableColumn colvarVisionAlteracion = new TableSchema.TableColumn(schema);
				colvarVisionAlteracion.ColumnName = "VisionAlteracion";
				colvarVisionAlteracion.DataType = DbType.AnsiString;
				colvarVisionAlteracion.MaxLength = 2;
				colvarVisionAlteracion.AutoIncrement = false;
				colvarVisionAlteracion.IsNullable = true;
				colvarVisionAlteracion.IsPrimaryKey = false;
				colvarVisionAlteracion.IsForeignKey = false;
				colvarVisionAlteracion.IsReadOnly = false;
				colvarVisionAlteracion.DefaultSetting = @"";
				colvarVisionAlteracion.ForeignKeyTableName = "";
				schema.Columns.Add(colvarVisionAlteracion);
				
				TableSchema.TableColumn colvarAudicionAlteracion = new TableSchema.TableColumn(schema);
				colvarAudicionAlteracion.ColumnName = "AudicionAlteracion";
				colvarAudicionAlteracion.DataType = DbType.AnsiString;
				colvarAudicionAlteracion.MaxLength = 2;
				colvarAudicionAlteracion.AutoIncrement = false;
				colvarAudicionAlteracion.IsNullable = true;
				colvarAudicionAlteracion.IsPrimaryKey = false;
				colvarAudicionAlteracion.IsForeignKey = false;
				colvarAudicionAlteracion.IsReadOnly = false;
				colvarAudicionAlteracion.DefaultSetting = @"";
				colvarAudicionAlteracion.ForeignKeyTableName = "";
				schema.Columns.Add(colvarAudicionAlteracion);
				
				TableSchema.TableColumn colvarMedicacion = new TableSchema.TableColumn(schema);
				colvarMedicacion.ColumnName = "Medicacion";
				colvarMedicacion.DataType = DbType.String;
				colvarMedicacion.MaxLength = 150;
				colvarMedicacion.AutoIncrement = false;
				colvarMedicacion.IsNullable = true;
				colvarMedicacion.IsPrimaryKey = false;
				colvarMedicacion.IsForeignKey = false;
				colvarMedicacion.IsReadOnly = false;
				colvarMedicacion.DefaultSetting = @"";
				colvarMedicacion.ForeignKeyTableName = "";
				schema.Columns.Add(colvarMedicacion);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["RisProvider"].AddSchema("VGI_Datos",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("IdVGIDato")]
		[Bindable(true)]
		public int IdVGIDato 
		{
			get { return GetColumnValue<int>(Columns.IdVGIDato); }
			set { SetColumnValue(Columns.IdVGIDato, value); }
		}
		  
		[XmlAttribute("IdPaciente")]
		[Bindable(true)]
		public int? IdPaciente 
		{
			get { return GetColumnValue<int?>(Columns.IdPaciente); }
			set { SetColumnValue(Columns.IdPaciente, value); }
		}
		  
		[XmlAttribute("IdTurno")]
		[Bindable(true)]
		public int? IdTurno 
		{
			get { return GetColumnValue<int?>(Columns.IdTurno); }
			set { SetColumnValue(Columns.IdTurno, value); }
		}
		  
		[XmlAttribute("Fecha")]
		[Bindable(true)]
		public DateTime? Fecha 
		{
			get { return GetColumnValue<DateTime?>(Columns.Fecha); }
			set { SetColumnValue(Columns.Fecha, value); }
		}
		  
		[XmlAttribute("Vivienda")]
		[Bindable(true)]
		public string Vivienda 
		{
			get { return GetColumnValue<string>(Columns.Vivienda); }
			set { SetColumnValue(Columns.Vivienda, value); }
		}
		  
		[XmlAttribute("AñosEscolaridad")]
		[Bindable(true)]
		public decimal? AñosEscolaridad 
		{
			get { return GetColumnValue<decimal?>(Columns.AñosEscolaridad); }
			set { SetColumnValue(Columns.AñosEscolaridad, value); }
		}
		  
		[XmlAttribute("TrabajoPrevio")]
		[Bindable(true)]
		public string TrabajoPrevio 
		{
			get { return GetColumnValue<string>(Columns.TrabajoPrevio); }
			set { SetColumnValue(Columns.TrabajoPrevio, value); }
		}
		  
		[XmlAttribute("Ingresos")]
		[Bindable(true)]
		public string Ingresos 
		{
			get { return GetColumnValue<string>(Columns.Ingresos); }
			set { SetColumnValue(Columns.Ingresos, value); }
		}
		  
		[XmlAttribute("CentroAsistencia")]
		[Bindable(true)]
		public int? CentroAsistencia 
		{
			get { return GetColumnValue<int?>(Columns.CentroAsistencia); }
			set { SetColumnValue(Columns.CentroAsistencia, value); }
		}
		  
		[XmlAttribute("FamiliarACargo")]
		[Bindable(true)]
		public string FamiliarACargo 
		{
			get { return GetColumnValue<string>(Columns.FamiliarACargo); }
			set { SetColumnValue(Columns.FamiliarACargo, value); }
		}
		  
		[XmlAttribute("Vinculo")]
		[Bindable(true)]
		public string Vinculo 
		{
			get { return GetColumnValue<string>(Columns.Vinculo); }
			set { SetColumnValue(Columns.Vinculo, value); }
		}
		  
		[XmlAttribute("IdMedicoCabecera")]
		[Bindable(true)]
		public int? IdMedicoCabecera 
		{
			get { return GetColumnValue<int?>(Columns.IdMedicoCabecera); }
			set { SetColumnValue(Columns.IdMedicoCabecera, value); }
		}
		  
		[XmlAttribute("Contacto")]
		[Bindable(true)]
		public string Contacto 
		{
			get { return GetColumnValue<string>(Columns.Contacto); }
			set { SetColumnValue(Columns.Contacto, value); }
		}
		  
		[XmlAttribute("TotalClinico")]
		[Bindable(true)]
		public int? TotalClinico 
		{
			get { return GetColumnValue<int?>(Columns.TotalClinico); }
			set { SetColumnValue(Columns.TotalClinico, value); }
		}
		  
		[XmlAttribute("TotalRCVG")]
		[Bindable(true)]
		public int? TotalRCVG 
		{
			get { return GetColumnValue<int?>(Columns.TotalRCVG); }
			set { SetColumnValue(Columns.TotalRCVG, value); }
		}
		  
		[XmlAttribute("TotalABVD")]
		[Bindable(true)]
		public int? TotalABVD 
		{
			get { return GetColumnValue<int?>(Columns.TotalABVD); }
			set { SetColumnValue(Columns.TotalABVD, value); }
		}
		  
		[XmlAttribute("TotalAIVD")]
		[Bindable(true)]
		public int? TotalAIVD 
		{
			get { return GetColumnValue<int?>(Columns.TotalAIVD); }
			set { SetColumnValue(Columns.TotalAIVD, value); }
		}
		  
		[XmlAttribute("TotalSocial")]
		[Bindable(true)]
		public int? TotalSocial 
		{
			get { return GetColumnValue<int?>(Columns.TotalSocial); }
			set { SetColumnValue(Columns.TotalSocial, value); }
		}
		  
		[XmlAttribute("TotalMental")]
		[Bindable(true)]
		public int? TotalMental 
		{
			get { return GetColumnValue<int?>(Columns.TotalMental); }
			set { SetColumnValue(Columns.TotalMental, value); }
		}
		  
		[XmlAttribute("ProximaEvaluacion")]
		[Bindable(true)]
		public DateTime? ProximaEvaluacion 
		{
			get { return GetColumnValue<DateTime?>(Columns.ProximaEvaluacion); }
			set { SetColumnValue(Columns.ProximaEvaluacion, value); }
		}
		  
		[XmlAttribute("IdUsuarioCarga")]
		[Bindable(true)]
		public int? IdUsuarioCarga 
		{
			get { return GetColumnValue<int?>(Columns.IdUsuarioCarga); }
			set { SetColumnValue(Columns.IdUsuarioCarga, value); }
		}
		  
		[XmlAttribute("FechaCarga")]
		[Bindable(true)]
		public DateTime? FechaCarga 
		{
			get { return GetColumnValue<DateTime?>(Columns.FechaCarga); }
			set { SetColumnValue(Columns.FechaCarga, value); }
		}
		  
		[XmlAttribute("VisionAlteracion")]
		[Bindable(true)]
		public string VisionAlteracion 
		{
			get { return GetColumnValue<string>(Columns.VisionAlteracion); }
			set { SetColumnValue(Columns.VisionAlteracion, value); }
		}
		  
		[XmlAttribute("AudicionAlteracion")]
		[Bindable(true)]
		public string AudicionAlteracion 
		{
			get { return GetColumnValue<string>(Columns.AudicionAlteracion); }
			set { SetColumnValue(Columns.AudicionAlteracion, value); }
		}
		  
		[XmlAttribute("Medicacion")]
		[Bindable(true)]
		public string Medicacion 
		{
			get { return GetColumnValue<string>(Columns.Medicacion); }
			set { SetColumnValue(Columns.Medicacion, value); }
		}
		
		#endregion
		
		
		#region PrimaryKey Methods		
		
        protected override void SetPrimaryKey(object oValue)
        {
            base.SetPrimaryKey(oValue);
            
            SetPKValues();
        }
        
		
		private DalRis.VgiItemsDatoCollection colVgiItemsDatos;
		public DalRis.VgiItemsDatoCollection VgiItemsDatos()
		{
			if(colVgiItemsDatos == null)
			{
				colVgiItemsDatos = new DalRis.VgiItemsDatoCollection().Where(VgiItemsDato.Columns.IdVGIDatos, IdVGIDato).Load();
				colVgiItemsDatos.ListChanged += new ListChangedEventHandler(colVgiItemsDatos_ListChanged);
			}
			return colVgiItemsDatos;
		}
				
		void colVgiItemsDatos_ListChanged(object sender, ListChangedEventArgs e)
		{
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
		        // Set foreign key value
		        colVgiItemsDatos[e.NewIndex].IdVGIDatos = IdVGIDato;
				colVgiItemsDatos.ListChanged += new ListChangedEventHandler(colVgiItemsDatos_ListChanged);
            }
		}
		#endregion
		
			
		
		#region ForeignKey Properties
		
		/// <summary>
		/// Returns a SysProfesional ActiveRecord object related to this VgiDato
		/// 
		/// </summary>
		public DalRis.SysProfesional SysProfesional
		{
			get { return DalRis.SysProfesional.FetchByID(this.IdMedicoCabecera); }
			set { SetColumnValue("idMedicoCabecera", value.IdProfesional); }
		}
		
		
		/// <summary>
		/// Returns a ConTurno ActiveRecord object related to this VgiDato
		/// 
		/// </summary>
		public DalRis.ConTurno ConTurno
		{
			get { return DalRis.ConTurno.FetchByID(this.IdTurno); }
			set { SetColumnValue("idTurno", value.IdTurno); }
		}
		
		
		#endregion
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(int? varIdPaciente,int? varIdTurno,DateTime? varFecha,string varVivienda,decimal? varAñosEscolaridad,string varTrabajoPrevio,string varIngresos,int? varCentroAsistencia,string varFamiliarACargo,string varVinculo,int? varIdMedicoCabecera,string varContacto,int? varTotalClinico,int? varTotalRCVG,int? varTotalABVD,int? varTotalAIVD,int? varTotalSocial,int? varTotalMental,DateTime? varProximaEvaluacion,int? varIdUsuarioCarga,DateTime? varFechaCarga,string varVisionAlteracion,string varAudicionAlteracion,string varMedicacion)
		{
			VgiDato item = new VgiDato();
			
			item.IdPaciente = varIdPaciente;
			
			item.IdTurno = varIdTurno;
			
			item.Fecha = varFecha;
			
			item.Vivienda = varVivienda;
			
			item.AñosEscolaridad = varAñosEscolaridad;
			
			item.TrabajoPrevio = varTrabajoPrevio;
			
			item.Ingresos = varIngresos;
			
			item.CentroAsistencia = varCentroAsistencia;
			
			item.FamiliarACargo = varFamiliarACargo;
			
			item.Vinculo = varVinculo;
			
			item.IdMedicoCabecera = varIdMedicoCabecera;
			
			item.Contacto = varContacto;
			
			item.TotalClinico = varTotalClinico;
			
			item.TotalRCVG = varTotalRCVG;
			
			item.TotalABVD = varTotalABVD;
			
			item.TotalAIVD = varTotalAIVD;
			
			item.TotalSocial = varTotalSocial;
			
			item.TotalMental = varTotalMental;
			
			item.ProximaEvaluacion = varProximaEvaluacion;
			
			item.IdUsuarioCarga = varIdUsuarioCarga;
			
			item.FechaCarga = varFechaCarga;
			
			item.VisionAlteracion = varVisionAlteracion;
			
			item.AudicionAlteracion = varAudicionAlteracion;
			
			item.Medicacion = varMedicacion;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varIdVGIDato,int? varIdPaciente,int? varIdTurno,DateTime? varFecha,string varVivienda,decimal? varAñosEscolaridad,string varTrabajoPrevio,string varIngresos,int? varCentroAsistencia,string varFamiliarACargo,string varVinculo,int? varIdMedicoCabecera,string varContacto,int? varTotalClinico,int? varTotalRCVG,int? varTotalABVD,int? varTotalAIVD,int? varTotalSocial,int? varTotalMental,DateTime? varProximaEvaluacion,int? varIdUsuarioCarga,DateTime? varFechaCarga,string varVisionAlteracion,string varAudicionAlteracion,string varMedicacion)
		{
			VgiDato item = new VgiDato();
			
				item.IdVGIDato = varIdVGIDato;
			
				item.IdPaciente = varIdPaciente;
			
				item.IdTurno = varIdTurno;
			
				item.Fecha = varFecha;
			
				item.Vivienda = varVivienda;
			
				item.AñosEscolaridad = varAñosEscolaridad;
			
				item.TrabajoPrevio = varTrabajoPrevio;
			
				item.Ingresos = varIngresos;
			
				item.CentroAsistencia = varCentroAsistencia;
			
				item.FamiliarACargo = varFamiliarACargo;
			
				item.Vinculo = varVinculo;
			
				item.IdMedicoCabecera = varIdMedicoCabecera;
			
				item.Contacto = varContacto;
			
				item.TotalClinico = varTotalClinico;
			
				item.TotalRCVG = varTotalRCVG;
			
				item.TotalABVD = varTotalABVD;
			
				item.TotalAIVD = varTotalAIVD;
			
				item.TotalSocial = varTotalSocial;
			
				item.TotalMental = varTotalMental;
			
				item.ProximaEvaluacion = varProximaEvaluacion;
			
				item.IdUsuarioCarga = varIdUsuarioCarga;
			
				item.FechaCarga = varFechaCarga;
			
				item.VisionAlteracion = varVisionAlteracion;
			
				item.AudicionAlteracion = varAudicionAlteracion;
			
				item.Medicacion = varMedicacion;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn IdVGIDatoColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn IdPacienteColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn IdTurnoColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn FechaColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn ViviendaColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn AñosEscolaridadColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        public static TableSchema.TableColumn TrabajoPrevioColumn
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        public static TableSchema.TableColumn IngresosColumn
        {
            get { return Schema.Columns[7]; }
        }
        
        
        
        public static TableSchema.TableColumn CentroAsistenciaColumn
        {
            get { return Schema.Columns[8]; }
        }
        
        
        
        public static TableSchema.TableColumn FamiliarACargoColumn
        {
            get { return Schema.Columns[9]; }
        }
        
        
        
        public static TableSchema.TableColumn VinculoColumn
        {
            get { return Schema.Columns[10]; }
        }
        
        
        
        public static TableSchema.TableColumn IdMedicoCabeceraColumn
        {
            get { return Schema.Columns[11]; }
        }
        
        
        
        public static TableSchema.TableColumn ContactoColumn
        {
            get { return Schema.Columns[12]; }
        }
        
        
        
        public static TableSchema.TableColumn TotalClinicoColumn
        {
            get { return Schema.Columns[13]; }
        }
        
        
        
        public static TableSchema.TableColumn TotalRCVGColumn
        {
            get { return Schema.Columns[14]; }
        }
        
        
        
        public static TableSchema.TableColumn TotalABVDColumn
        {
            get { return Schema.Columns[15]; }
        }
        
        
        
        public static TableSchema.TableColumn TotalAIVDColumn
        {
            get { return Schema.Columns[16]; }
        }
        
        
        
        public static TableSchema.TableColumn TotalSocialColumn
        {
            get { return Schema.Columns[17]; }
        }
        
        
        
        public static TableSchema.TableColumn TotalMentalColumn
        {
            get { return Schema.Columns[18]; }
        }
        
        
        
        public static TableSchema.TableColumn ProximaEvaluacionColumn
        {
            get { return Schema.Columns[19]; }
        }
        
        
        
        public static TableSchema.TableColumn IdUsuarioCargaColumn
        {
            get { return Schema.Columns[20]; }
        }
        
        
        
        public static TableSchema.TableColumn FechaCargaColumn
        {
            get { return Schema.Columns[21]; }
        }
        
        
        
        public static TableSchema.TableColumn VisionAlteracionColumn
        {
            get { return Schema.Columns[22]; }
        }
        
        
        
        public static TableSchema.TableColumn AudicionAlteracionColumn
        {
            get { return Schema.Columns[23]; }
        }
        
        
        
        public static TableSchema.TableColumn MedicacionColumn
        {
            get { return Schema.Columns[24]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string IdVGIDato = @"idVGIDato";
			 public static string IdPaciente = @"idPaciente";
			 public static string IdTurno = @"idTurno";
			 public static string Fecha = @"Fecha";
			 public static string Vivienda = @"Vivienda";
			 public static string AñosEscolaridad = @"AñosEscolaridad";
			 public static string TrabajoPrevio = @"TrabajoPrevio";
			 public static string Ingresos = @"Ingresos";
			 public static string CentroAsistencia = @"CentroAsistencia";
			 public static string FamiliarACargo = @"FamiliarACargo";
			 public static string Vinculo = @"Vinculo";
			 public static string IdMedicoCabecera = @"idMedicoCabecera";
			 public static string Contacto = @"Contacto";
			 public static string TotalClinico = @"TotalClinico";
			 public static string TotalRCVG = @"TotalRCVG";
			 public static string TotalABVD = @"TotalABVD";
			 public static string TotalAIVD = @"TotalAIVD";
			 public static string TotalSocial = @"TotalSocial";
			 public static string TotalMental = @"TotalMental";
			 public static string ProximaEvaluacion = @"ProximaEvaluacion";
			 public static string IdUsuarioCarga = @"idUsuarioCarga";
			 public static string FechaCarga = @"FechaCarga";
			 public static string VisionAlteracion = @"VisionAlteracion";
			 public static string AudicionAlteracion = @"AudicionAlteracion";
			 public static string Medicacion = @"Medicacion";
						
		}
		#endregion
		
		#region Update PK Collections
		
        public void SetPKValues()
        {
                if (colVgiItemsDatos != null)
                {
                    foreach (DalRis.VgiItemsDato item in colVgiItemsDatos)
                    {
                        if (item.IdVGIDatos != IdVGIDato)
                        {
                            item.IdVGIDatos = IdVGIDato;
                        }
                    }
               }
		}
        #endregion
    
        #region Deep Save
		
        public void DeepSave()
        {
            Save();
            
                if (colVgiItemsDatos != null)
                {
                    colVgiItemsDatos.SaveAll();
               }
		}
        #endregion
	}
}
