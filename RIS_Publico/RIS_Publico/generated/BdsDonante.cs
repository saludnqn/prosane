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
	/// Strongly-typed collection for the BdsDonante class.
	/// </summary>
    [Serializable]
	public partial class BdsDonanteCollection : ActiveList<BdsDonante, BdsDonanteCollection>
	{	   
		public BdsDonanteCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>BdsDonanteCollection</returns>
		public BdsDonanteCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                BdsDonante o = this[i];
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
	/// This is an ActiveRecord class which wraps the BDS_Donante table.
	/// </summary>
	[Serializable]
	public partial class BdsDonante : ActiveRecord<BdsDonante>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public BdsDonante()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public BdsDonante(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public BdsDonante(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public BdsDonante(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("BDS_Donante", TableType.Table, DataService.GetInstance("RisProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarIdDonante = new TableSchema.TableColumn(schema);
				colvarIdDonante.ColumnName = "idDonante";
				colvarIdDonante.DataType = DbType.Int32;
				colvarIdDonante.MaxLength = 0;
				colvarIdDonante.AutoIncrement = true;
				colvarIdDonante.IsNullable = false;
				colvarIdDonante.IsPrimaryKey = true;
				colvarIdDonante.IsForeignKey = false;
				colvarIdDonante.IsReadOnly = false;
				colvarIdDonante.DefaultSetting = @"";
				colvarIdDonante.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdDonante);
				
				TableSchema.TableColumn colvarExtranjero = new TableSchema.TableColumn(schema);
				colvarExtranjero.ColumnName = "extranjero";
				colvarExtranjero.DataType = DbType.Boolean;
				colvarExtranjero.MaxLength = 0;
				colvarExtranjero.AutoIncrement = false;
				colvarExtranjero.IsNullable = false;
				colvarExtranjero.IsPrimaryKey = false;
				colvarExtranjero.IsForeignKey = false;
				colvarExtranjero.IsReadOnly = false;
				colvarExtranjero.DefaultSetting = @"";
				colvarExtranjero.ForeignKeyTableName = "";
				schema.Columns.Add(colvarExtranjero);
				
				TableSchema.TableColumn colvarNumeroDocumento = new TableSchema.TableColumn(schema);
				colvarNumeroDocumento.ColumnName = "numeroDocumento";
				colvarNumeroDocumento.DataType = DbType.Int32;
				colvarNumeroDocumento.MaxLength = 0;
				colvarNumeroDocumento.AutoIncrement = false;
				colvarNumeroDocumento.IsNullable = false;
				colvarNumeroDocumento.IsPrimaryKey = false;
				colvarNumeroDocumento.IsForeignKey = false;
				colvarNumeroDocumento.IsReadOnly = false;
				colvarNumeroDocumento.DefaultSetting = @"";
				colvarNumeroDocumento.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNumeroDocumento);
				
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
				
				TableSchema.TableColumn colvarIdSexo = new TableSchema.TableColumn(schema);
				colvarIdSexo.ColumnName = "idSexo";
				colvarIdSexo.DataType = DbType.Int32;
				colvarIdSexo.MaxLength = 0;
				colvarIdSexo.AutoIncrement = false;
				colvarIdSexo.IsNullable = false;
				colvarIdSexo.IsPrimaryKey = false;
				colvarIdSexo.IsForeignKey = false;
				colvarIdSexo.IsReadOnly = false;
				colvarIdSexo.DefaultSetting = @"";
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
				
				TableSchema.TableColumn colvarLugarNacimiento = new TableSchema.TableColumn(schema);
				colvarLugarNacimiento.ColumnName = "lugarNacimiento";
				colvarLugarNacimiento.DataType = DbType.String;
				colvarLugarNacimiento.MaxLength = 100;
				colvarLugarNacimiento.AutoIncrement = false;
				colvarLugarNacimiento.IsNullable = false;
				colvarLugarNacimiento.IsPrimaryKey = false;
				colvarLugarNacimiento.IsForeignKey = false;
				colvarLugarNacimiento.IsReadOnly = false;
				colvarLugarNacimiento.DefaultSetting = @"";
				colvarLugarNacimiento.ForeignKeyTableName = "";
				schema.Columns.Add(colvarLugarNacimiento);
				
				TableSchema.TableColumn colvarDomicilio = new TableSchema.TableColumn(schema);
				colvarDomicilio.ColumnName = "domicilio";
				colvarDomicilio.DataType = DbType.String;
				colvarDomicilio.MaxLength = 100;
				colvarDomicilio.AutoIncrement = false;
				colvarDomicilio.IsNullable = false;
				colvarDomicilio.IsPrimaryKey = false;
				colvarDomicilio.IsForeignKey = false;
				colvarDomicilio.IsReadOnly = false;
				colvarDomicilio.DefaultSetting = @"";
				colvarDomicilio.ForeignKeyTableName = "";
				schema.Columns.Add(colvarDomicilio);
				
				TableSchema.TableColumn colvarTelefono = new TableSchema.TableColumn(schema);
				colvarTelefono.ColumnName = "telefono";
				colvarTelefono.DataType = DbType.String;
				colvarTelefono.MaxLength = 30;
				colvarTelefono.AutoIncrement = false;
				colvarTelefono.IsNullable = false;
				colvarTelefono.IsPrimaryKey = false;
				colvarTelefono.IsForeignKey = false;
				colvarTelefono.IsReadOnly = false;
				colvarTelefono.DefaultSetting = @"";
				colvarTelefono.ForeignKeyTableName = "";
				schema.Columns.Add(colvarTelefono);
				
				TableSchema.TableColumn colvarIdUsuarioRegistro = new TableSchema.TableColumn(schema);
				colvarIdUsuarioRegistro.ColumnName = "idUsuarioRegistro";
				colvarIdUsuarioRegistro.DataType = DbType.Int32;
				colvarIdUsuarioRegistro.MaxLength = 0;
				colvarIdUsuarioRegistro.AutoIncrement = false;
				colvarIdUsuarioRegistro.IsNullable = false;
				colvarIdUsuarioRegistro.IsPrimaryKey = false;
				colvarIdUsuarioRegistro.IsForeignKey = false;
				colvarIdUsuarioRegistro.IsReadOnly = false;
				colvarIdUsuarioRegistro.DefaultSetting = @"";
				colvarIdUsuarioRegistro.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdUsuarioRegistro);
				
				TableSchema.TableColumn colvarFechaRegistro = new TableSchema.TableColumn(schema);
				colvarFechaRegistro.ColumnName = "fechaRegistro";
				colvarFechaRegistro.DataType = DbType.DateTime;
				colvarFechaRegistro.MaxLength = 0;
				colvarFechaRegistro.AutoIncrement = false;
				colvarFechaRegistro.IsNullable = false;
				colvarFechaRegistro.IsPrimaryKey = false;
				colvarFechaRegistro.IsForeignKey = false;
				colvarFechaRegistro.IsReadOnly = false;
				colvarFechaRegistro.DefaultSetting = @"";
				colvarFechaRegistro.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFechaRegistro);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["RisProvider"].AddSchema("BDS_Donante",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("IdDonante")]
		[Bindable(true)]
		public int IdDonante 
		{
			get { return GetColumnValue<int>(Columns.IdDonante); }
			set { SetColumnValue(Columns.IdDonante, value); }
		}
		  
		[XmlAttribute("Extranjero")]
		[Bindable(true)]
		public bool Extranjero 
		{
			get { return GetColumnValue<bool>(Columns.Extranjero); }
			set { SetColumnValue(Columns.Extranjero, value); }
		}
		  
		[XmlAttribute("NumeroDocumento")]
		[Bindable(true)]
		public int NumeroDocumento 
		{
			get { return GetColumnValue<int>(Columns.NumeroDocumento); }
			set { SetColumnValue(Columns.NumeroDocumento, value); }
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
		  
		[XmlAttribute("LugarNacimiento")]
		[Bindable(true)]
		public string LugarNacimiento 
		{
			get { return GetColumnValue<string>(Columns.LugarNacimiento); }
			set { SetColumnValue(Columns.LugarNacimiento, value); }
		}
		  
		[XmlAttribute("Domicilio")]
		[Bindable(true)]
		public string Domicilio 
		{
			get { return GetColumnValue<string>(Columns.Domicilio); }
			set { SetColumnValue(Columns.Domicilio, value); }
		}
		  
		[XmlAttribute("Telefono")]
		[Bindable(true)]
		public string Telefono 
		{
			get { return GetColumnValue<string>(Columns.Telefono); }
			set { SetColumnValue(Columns.Telefono, value); }
		}
		  
		[XmlAttribute("IdUsuarioRegistro")]
		[Bindable(true)]
		public int IdUsuarioRegistro 
		{
			get { return GetColumnValue<int>(Columns.IdUsuarioRegistro); }
			set { SetColumnValue(Columns.IdUsuarioRegistro, value); }
		}
		  
		[XmlAttribute("FechaRegistro")]
		[Bindable(true)]
		public DateTime FechaRegistro 
		{
			get { return GetColumnValue<DateTime>(Columns.FechaRegistro); }
			set { SetColumnValue(Columns.FechaRegistro, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(bool varExtranjero,int varNumeroDocumento,string varApellido,string varNombre,int varIdSexo,DateTime varFechaNacimiento,string varLugarNacimiento,string varDomicilio,string varTelefono,int varIdUsuarioRegistro,DateTime varFechaRegistro)
		{
			BdsDonante item = new BdsDonante();
			
			item.Extranjero = varExtranjero;
			
			item.NumeroDocumento = varNumeroDocumento;
			
			item.Apellido = varApellido;
			
			item.Nombre = varNombre;
			
			item.IdSexo = varIdSexo;
			
			item.FechaNacimiento = varFechaNacimiento;
			
			item.LugarNacimiento = varLugarNacimiento;
			
			item.Domicilio = varDomicilio;
			
			item.Telefono = varTelefono;
			
			item.IdUsuarioRegistro = varIdUsuarioRegistro;
			
			item.FechaRegistro = varFechaRegistro;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varIdDonante,bool varExtranjero,int varNumeroDocumento,string varApellido,string varNombre,int varIdSexo,DateTime varFechaNacimiento,string varLugarNacimiento,string varDomicilio,string varTelefono,int varIdUsuarioRegistro,DateTime varFechaRegistro)
		{
			BdsDonante item = new BdsDonante();
			
				item.IdDonante = varIdDonante;
			
				item.Extranjero = varExtranjero;
			
				item.NumeroDocumento = varNumeroDocumento;
			
				item.Apellido = varApellido;
			
				item.Nombre = varNombre;
			
				item.IdSexo = varIdSexo;
			
				item.FechaNacimiento = varFechaNacimiento;
			
				item.LugarNacimiento = varLugarNacimiento;
			
				item.Domicilio = varDomicilio;
			
				item.Telefono = varTelefono;
			
				item.IdUsuarioRegistro = varIdUsuarioRegistro;
			
				item.FechaRegistro = varFechaRegistro;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn IdDonanteColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn ExtranjeroColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn NumeroDocumentoColumn
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
        
        
        
        public static TableSchema.TableColumn IdSexoColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        public static TableSchema.TableColumn FechaNacimientoColumn
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        public static TableSchema.TableColumn LugarNacimientoColumn
        {
            get { return Schema.Columns[7]; }
        }
        
        
        
        public static TableSchema.TableColumn DomicilioColumn
        {
            get { return Schema.Columns[8]; }
        }
        
        
        
        public static TableSchema.TableColumn TelefonoColumn
        {
            get { return Schema.Columns[9]; }
        }
        
        
        
        public static TableSchema.TableColumn IdUsuarioRegistroColumn
        {
            get { return Schema.Columns[10]; }
        }
        
        
        
        public static TableSchema.TableColumn FechaRegistroColumn
        {
            get { return Schema.Columns[11]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string IdDonante = @"idDonante";
			 public static string Extranjero = @"extranjero";
			 public static string NumeroDocumento = @"numeroDocumento";
			 public static string Apellido = @"apellido";
			 public static string Nombre = @"nombre";
			 public static string IdSexo = @"idSexo";
			 public static string FechaNacimiento = @"fechaNacimiento";
			 public static string LugarNacimiento = @"lugarNacimiento";
			 public static string Domicilio = @"domicilio";
			 public static string Telefono = @"telefono";
			 public static string IdUsuarioRegistro = @"idUsuarioRegistro";
			 public static string FechaRegistro = @"fechaRegistro";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
