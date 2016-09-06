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
	/// Strongly-typed collection for the TamMujere class.
	/// </summary>
    [Serializable]
	public partial class TamMujereCollection : ActiveList<TamMujere, TamMujereCollection>
	{	   
		public TamMujereCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>TamMujereCollection</returns>
		public TamMujereCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                TamMujere o = this[i];
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
	/// This is an ActiveRecord class which wraps the TAM_Mujeres table.
	/// </summary>
	[Serializable]
	public partial class TamMujere : ActiveRecord<TamMujere>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public TamMujere()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public TamMujere(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public TamMujere(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public TamMujere(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("TAM_Mujeres", TableType.Table, DataService.GetInstance("RisProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarIdMujeres = new TableSchema.TableColumn(schema);
				colvarIdMujeres.ColumnName = "idMujeres";
				colvarIdMujeres.DataType = DbType.Int32;
				colvarIdMujeres.MaxLength = 0;
				colvarIdMujeres.AutoIncrement = true;
				colvarIdMujeres.IsNullable = false;
				colvarIdMujeres.IsPrimaryKey = true;
				colvarIdMujeres.IsForeignKey = false;
				colvarIdMujeres.IsReadOnly = false;
				colvarIdMujeres.DefaultSetting = @"";
				colvarIdMujeres.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdMujeres);
				
				TableSchema.TableColumn colvarNumHc = new TableSchema.TableColumn(schema);
				colvarNumHc.ColumnName = "Num_HC";
				colvarNumHc.DataType = DbType.String;
				colvarNumHc.MaxLength = 50;
				colvarNumHc.AutoIncrement = false;
				colvarNumHc.IsNullable = true;
				colvarNumHc.IsPrimaryKey = false;
				colvarNumHc.IsForeignKey = false;
				colvarNumHc.IsReadOnly = false;
				colvarNumHc.DefaultSetting = @"";
				colvarNumHc.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNumHc);
				
				TableSchema.TableColumn colvarApellido = new TableSchema.TableColumn(schema);
				colvarApellido.ColumnName = "Apellido";
				colvarApellido.DataType = DbType.String;
				colvarApellido.MaxLength = 50;
				colvarApellido.AutoIncrement = false;
				colvarApellido.IsNullable = true;
				colvarApellido.IsPrimaryKey = false;
				colvarApellido.IsForeignKey = false;
				colvarApellido.IsReadOnly = false;
				colvarApellido.DefaultSetting = @"";
				colvarApellido.ForeignKeyTableName = "";
				schema.Columns.Add(colvarApellido);
				
				TableSchema.TableColumn colvarNombres = new TableSchema.TableColumn(schema);
				colvarNombres.ColumnName = "Nombres";
				colvarNombres.DataType = DbType.String;
				colvarNombres.MaxLength = 50;
				colvarNombres.AutoIncrement = false;
				colvarNombres.IsNullable = true;
				colvarNombres.IsPrimaryKey = false;
				colvarNombres.IsForeignKey = false;
				colvarNombres.IsReadOnly = false;
				colvarNombres.DefaultSetting = @"";
				colvarNombres.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNombres);
				
				TableSchema.TableColumn colvarFechaNacimiento = new TableSchema.TableColumn(schema);
				colvarFechaNacimiento.ColumnName = "FechaNacimiento";
				colvarFechaNacimiento.DataType = DbType.AnsiString;
				colvarFechaNacimiento.MaxLength = 10;
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
				colvarEdad.IsNullable = true;
				colvarEdad.IsPrimaryKey = false;
				colvarEdad.IsForeignKey = false;
				colvarEdad.IsReadOnly = false;
				colvarEdad.DefaultSetting = @"";
				colvarEdad.ForeignKeyTableName = "";
				schema.Columns.Add(colvarEdad);
				
				TableSchema.TableColumn colvarIdTipoDoc = new TableSchema.TableColumn(schema);
				colvarIdTipoDoc.ColumnName = "Id_TipoDoc";
				colvarIdTipoDoc.DataType = DbType.Int32;
				colvarIdTipoDoc.MaxLength = 0;
				colvarIdTipoDoc.AutoIncrement = false;
				colvarIdTipoDoc.IsNullable = true;
				colvarIdTipoDoc.IsPrimaryKey = false;
				colvarIdTipoDoc.IsForeignKey = false;
				colvarIdTipoDoc.IsReadOnly = false;
				colvarIdTipoDoc.DefaultSetting = @"";
				colvarIdTipoDoc.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdTipoDoc);
				
				TableSchema.TableColumn colvarNumeroDocumento = new TableSchema.TableColumn(schema);
				colvarNumeroDocumento.ColumnName = "Numero_Documento";
				colvarNumeroDocumento.DataType = DbType.Int32;
				colvarNumeroDocumento.MaxLength = 0;
				colvarNumeroDocumento.AutoIncrement = false;
				colvarNumeroDocumento.IsNullable = true;
				colvarNumeroDocumento.IsPrimaryKey = false;
				colvarNumeroDocumento.IsForeignKey = false;
				colvarNumeroDocumento.IsReadOnly = false;
				colvarNumeroDocumento.DefaultSetting = @"";
				colvarNumeroDocumento.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNumeroDocumento);
				
				TableSchema.TableColumn colvarTelefono = new TableSchema.TableColumn(schema);
				colvarTelefono.ColumnName = "Telefono";
				colvarTelefono.DataType = DbType.String;
				colvarTelefono.MaxLength = 50;
				colvarTelefono.AutoIncrement = false;
				colvarTelefono.IsNullable = true;
				colvarTelefono.IsPrimaryKey = false;
				colvarTelefono.IsForeignKey = false;
				colvarTelefono.IsReadOnly = false;
				colvarTelefono.DefaultSetting = @"";
				colvarTelefono.ForeignKeyTableName = "";
				schema.Columns.Add(colvarTelefono);
				
				TableSchema.TableColumn colvarDomicilio = new TableSchema.TableColumn(schema);
				colvarDomicilio.ColumnName = "Domicilio";
				colvarDomicilio.DataType = DbType.String;
				colvarDomicilio.MaxLength = 50;
				colvarDomicilio.AutoIncrement = false;
				colvarDomicilio.IsNullable = true;
				colvarDomicilio.IsPrimaryKey = false;
				colvarDomicilio.IsForeignKey = false;
				colvarDomicilio.IsReadOnly = false;
				colvarDomicilio.DefaultSetting = @"";
				colvarDomicilio.ForeignKeyTableName = "";
				schema.Columns.Add(colvarDomicilio);
				
				TableSchema.TableColumn colvarBarrio = new TableSchema.TableColumn(schema);
				colvarBarrio.ColumnName = "Barrio";
				colvarBarrio.DataType = DbType.String;
				colvarBarrio.MaxLength = 50;
				colvarBarrio.AutoIncrement = false;
				colvarBarrio.IsNullable = true;
				colvarBarrio.IsPrimaryKey = false;
				colvarBarrio.IsForeignKey = false;
				colvarBarrio.IsReadOnly = false;
				colvarBarrio.DefaultSetting = @"";
				colvarBarrio.ForeignKeyTableName = "";
				schema.Columns.Add(colvarBarrio);
				
				TableSchema.TableColumn colvarIdProvincia = new TableSchema.TableColumn(schema);
				colvarIdProvincia.ColumnName = "Id_Provincia";
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
				colvarIdDepartamento.ColumnName = "Id_Departamento";
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
				
				TableSchema.TableColumn colvarIdLocalidad = new TableSchema.TableColumn(schema);
				colvarIdLocalidad.ColumnName = "Id_Localidad";
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
				
				TableSchema.TableColumn colvarCp = new TableSchema.TableColumn(schema);
				colvarCp.ColumnName = "CP";
				colvarCp.DataType = DbType.String;
				colvarCp.MaxLength = 50;
				colvarCp.AutoIncrement = false;
				colvarCp.IsNullable = true;
				colvarCp.IsPrimaryKey = false;
				colvarCp.IsForeignKey = false;
				colvarCp.IsReadOnly = false;
				colvarCp.DefaultSetting = @"";
				colvarCp.ForeignKeyTableName = "";
				schema.Columns.Add(colvarCp);
				
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
				
				TableSchema.TableColumn colvarZonaSalud = new TableSchema.TableColumn(schema);
				colvarZonaSalud.ColumnName = "Zona_Salud";
				colvarZonaSalud.DataType = DbType.Int32;
				colvarZonaSalud.MaxLength = 0;
				colvarZonaSalud.AutoIncrement = false;
				colvarZonaSalud.IsNullable = true;
				colvarZonaSalud.IsPrimaryKey = false;
				colvarZonaSalud.IsForeignKey = false;
				colvarZonaSalud.IsReadOnly = false;
				colvarZonaSalud.DefaultSetting = @"";
				colvarZonaSalud.ForeignKeyTableName = "";
				schema.Columns.Add(colvarZonaSalud);
				
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
				
				TableSchema.TableColumn colvarFechaAlta = new TableSchema.TableColumn(schema);
				colvarFechaAlta.ColumnName = "fecha_alta";
				colvarFechaAlta.DataType = DbType.AnsiString;
				colvarFechaAlta.MaxLength = 10;
				colvarFechaAlta.AutoIncrement = false;
				colvarFechaAlta.IsNullable = true;
				colvarFechaAlta.IsPrimaryKey = false;
				colvarFechaAlta.IsForeignKey = false;
				colvarFechaAlta.IsReadOnly = false;
				colvarFechaAlta.DefaultSetting = @"";
				colvarFechaAlta.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFechaAlta);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["RisProvider"].AddSchema("TAM_Mujeres",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("IdMujeres")]
		[Bindable(true)]
		public int IdMujeres 
		{
			get { return GetColumnValue<int>(Columns.IdMujeres); }
			set { SetColumnValue(Columns.IdMujeres, value); }
		}
		  
		[XmlAttribute("NumHc")]
		[Bindable(true)]
		public string NumHc 
		{
			get { return GetColumnValue<string>(Columns.NumHc); }
			set { SetColumnValue(Columns.NumHc, value); }
		}
		  
		[XmlAttribute("Apellido")]
		[Bindable(true)]
		public string Apellido 
		{
			get { return GetColumnValue<string>(Columns.Apellido); }
			set { SetColumnValue(Columns.Apellido, value); }
		}
		  
		[XmlAttribute("Nombres")]
		[Bindable(true)]
		public string Nombres 
		{
			get { return GetColumnValue<string>(Columns.Nombres); }
			set { SetColumnValue(Columns.Nombres, value); }
		}
		  
		[XmlAttribute("FechaNacimiento")]
		[Bindable(true)]
		public string FechaNacimiento 
		{
			get { return GetColumnValue<string>(Columns.FechaNacimiento); }
			set { SetColumnValue(Columns.FechaNacimiento, value); }
		}
		  
		[XmlAttribute("Edad")]
		[Bindable(true)]
		public int? Edad 
		{
			get { return GetColumnValue<int?>(Columns.Edad); }
			set { SetColumnValue(Columns.Edad, value); }
		}
		  
		[XmlAttribute("IdTipoDoc")]
		[Bindable(true)]
		public int? IdTipoDoc 
		{
			get { return GetColumnValue<int?>(Columns.IdTipoDoc); }
			set { SetColumnValue(Columns.IdTipoDoc, value); }
		}
		  
		[XmlAttribute("NumeroDocumento")]
		[Bindable(true)]
		public int? NumeroDocumento 
		{
			get { return GetColumnValue<int?>(Columns.NumeroDocumento); }
			set { SetColumnValue(Columns.NumeroDocumento, value); }
		}
		  
		[XmlAttribute("Telefono")]
		[Bindable(true)]
		public string Telefono 
		{
			get { return GetColumnValue<string>(Columns.Telefono); }
			set { SetColumnValue(Columns.Telefono, value); }
		}
		  
		[XmlAttribute("Domicilio")]
		[Bindable(true)]
		public string Domicilio 
		{
			get { return GetColumnValue<string>(Columns.Domicilio); }
			set { SetColumnValue(Columns.Domicilio, value); }
		}
		  
		[XmlAttribute("Barrio")]
		[Bindable(true)]
		public string Barrio 
		{
			get { return GetColumnValue<string>(Columns.Barrio); }
			set { SetColumnValue(Columns.Barrio, value); }
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
		  
		[XmlAttribute("IdLocalidad")]
		[Bindable(true)]
		public int? IdLocalidad 
		{
			get { return GetColumnValue<int?>(Columns.IdLocalidad); }
			set { SetColumnValue(Columns.IdLocalidad, value); }
		}
		  
		[XmlAttribute("Cp")]
		[Bindable(true)]
		public string Cp 
		{
			get { return GetColumnValue<string>(Columns.Cp); }
			set { SetColumnValue(Columns.Cp, value); }
		}
		  
		[XmlAttribute("IdCentro")]
		[Bindable(true)]
		public int? IdCentro 
		{
			get { return GetColumnValue<int?>(Columns.IdCentro); }
			set { SetColumnValue(Columns.IdCentro, value); }
		}
		  
		[XmlAttribute("Observaciones")]
		[Bindable(true)]
		public string Observaciones 
		{
			get { return GetColumnValue<string>(Columns.Observaciones); }
			set { SetColumnValue(Columns.Observaciones, value); }
		}
		  
		[XmlAttribute("ZonaSalud")]
		[Bindable(true)]
		public int? ZonaSalud 
		{
			get { return GetColumnValue<int?>(Columns.ZonaSalud); }
			set { SetColumnValue(Columns.ZonaSalud, value); }
		}
		  
		[XmlAttribute("IdMujerExporta")]
		[Bindable(true)]
		public int? IdMujerExporta 
		{
			get { return GetColumnValue<int?>(Columns.IdMujerExporta); }
			set { SetColumnValue(Columns.IdMujerExporta, value); }
		}
		  
		[XmlAttribute("FechaAlta")]
		[Bindable(true)]
		public string FechaAlta 
		{
			get { return GetColumnValue<string>(Columns.FechaAlta); }
			set { SetColumnValue(Columns.FechaAlta, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varNumHc,string varApellido,string varNombres,string varFechaNacimiento,int? varEdad,int? varIdTipoDoc,int? varNumeroDocumento,string varTelefono,string varDomicilio,string varBarrio,int? varIdProvincia,int? varIdDepartamento,int? varIdLocalidad,string varCp,int? varIdCentro,string varObservaciones,int? varZonaSalud,int? varIdMujerExporta,string varFechaAlta)
		{
			TamMujere item = new TamMujere();
			
			item.NumHc = varNumHc;
			
			item.Apellido = varApellido;
			
			item.Nombres = varNombres;
			
			item.FechaNacimiento = varFechaNacimiento;
			
			item.Edad = varEdad;
			
			item.IdTipoDoc = varIdTipoDoc;
			
			item.NumeroDocumento = varNumeroDocumento;
			
			item.Telefono = varTelefono;
			
			item.Domicilio = varDomicilio;
			
			item.Barrio = varBarrio;
			
			item.IdProvincia = varIdProvincia;
			
			item.IdDepartamento = varIdDepartamento;
			
			item.IdLocalidad = varIdLocalidad;
			
			item.Cp = varCp;
			
			item.IdCentro = varIdCentro;
			
			item.Observaciones = varObservaciones;
			
			item.ZonaSalud = varZonaSalud;
			
			item.IdMujerExporta = varIdMujerExporta;
			
			item.FechaAlta = varFechaAlta;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varIdMujeres,string varNumHc,string varApellido,string varNombres,string varFechaNacimiento,int? varEdad,int? varIdTipoDoc,int? varNumeroDocumento,string varTelefono,string varDomicilio,string varBarrio,int? varIdProvincia,int? varIdDepartamento,int? varIdLocalidad,string varCp,int? varIdCentro,string varObservaciones,int? varZonaSalud,int? varIdMujerExporta,string varFechaAlta)
		{
			TamMujere item = new TamMujere();
			
				item.IdMujeres = varIdMujeres;
			
				item.NumHc = varNumHc;
			
				item.Apellido = varApellido;
			
				item.Nombres = varNombres;
			
				item.FechaNacimiento = varFechaNacimiento;
			
				item.Edad = varEdad;
			
				item.IdTipoDoc = varIdTipoDoc;
			
				item.NumeroDocumento = varNumeroDocumento;
			
				item.Telefono = varTelefono;
			
				item.Domicilio = varDomicilio;
			
				item.Barrio = varBarrio;
			
				item.IdProvincia = varIdProvincia;
			
				item.IdDepartamento = varIdDepartamento;
			
				item.IdLocalidad = varIdLocalidad;
			
				item.Cp = varCp;
			
				item.IdCentro = varIdCentro;
			
				item.Observaciones = varObservaciones;
			
				item.ZonaSalud = varZonaSalud;
			
				item.IdMujerExporta = varIdMujerExporta;
			
				item.FechaAlta = varFechaAlta;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn IdMujeresColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn NumHcColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn ApellidoColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn NombresColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn FechaNacimientoColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn EdadColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        public static TableSchema.TableColumn IdTipoDocColumn
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        public static TableSchema.TableColumn NumeroDocumentoColumn
        {
            get { return Schema.Columns[7]; }
        }
        
        
        
        public static TableSchema.TableColumn TelefonoColumn
        {
            get { return Schema.Columns[8]; }
        }
        
        
        
        public static TableSchema.TableColumn DomicilioColumn
        {
            get { return Schema.Columns[9]; }
        }
        
        
        
        public static TableSchema.TableColumn BarrioColumn
        {
            get { return Schema.Columns[10]; }
        }
        
        
        
        public static TableSchema.TableColumn IdProvinciaColumn
        {
            get { return Schema.Columns[11]; }
        }
        
        
        
        public static TableSchema.TableColumn IdDepartamentoColumn
        {
            get { return Schema.Columns[12]; }
        }
        
        
        
        public static TableSchema.TableColumn IdLocalidadColumn
        {
            get { return Schema.Columns[13]; }
        }
        
        
        
        public static TableSchema.TableColumn CpColumn
        {
            get { return Schema.Columns[14]; }
        }
        
        
        
        public static TableSchema.TableColumn IdCentroColumn
        {
            get { return Schema.Columns[15]; }
        }
        
        
        
        public static TableSchema.TableColumn ObservacionesColumn
        {
            get { return Schema.Columns[16]; }
        }
        
        
        
        public static TableSchema.TableColumn ZonaSaludColumn
        {
            get { return Schema.Columns[17]; }
        }
        
        
        
        public static TableSchema.TableColumn IdMujerExportaColumn
        {
            get { return Schema.Columns[18]; }
        }
        
        
        
        public static TableSchema.TableColumn FechaAltaColumn
        {
            get { return Schema.Columns[19]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string IdMujeres = @"idMujeres";
			 public static string NumHc = @"Num_HC";
			 public static string Apellido = @"Apellido";
			 public static string Nombres = @"Nombres";
			 public static string FechaNacimiento = @"FechaNacimiento";
			 public static string Edad = @"Edad";
			 public static string IdTipoDoc = @"Id_TipoDoc";
			 public static string NumeroDocumento = @"Numero_Documento";
			 public static string Telefono = @"Telefono";
			 public static string Domicilio = @"Domicilio";
			 public static string Barrio = @"Barrio";
			 public static string IdProvincia = @"Id_Provincia";
			 public static string IdDepartamento = @"Id_Departamento";
			 public static string IdLocalidad = @"Id_Localidad";
			 public static string Cp = @"CP";
			 public static string IdCentro = @"id_Centro";
			 public static string Observaciones = @"observaciones";
			 public static string ZonaSalud = @"Zona_Salud";
			 public static string IdMujerExporta = @"Id_Mujer_Exporta";
			 public static string FechaAlta = @"fecha_alta";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
