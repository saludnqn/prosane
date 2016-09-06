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
	/// Strongly-typed collection for the TstAfiliadosISSN class.
	/// </summary>
    [Serializable]
	public partial class TstAfiliadosISSNCollection : ActiveList<TstAfiliadosISSN, TstAfiliadosISSNCollection>
	{	   
		public TstAfiliadosISSNCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>TstAfiliadosISSNCollection</returns>
		public TstAfiliadosISSNCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                TstAfiliadosISSN o = this[i];
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
	/// This is an ActiveRecord class which wraps the TST_AfiliadosISSN table.
	/// </summary>
	[Serializable]
	public partial class TstAfiliadosISSN : ActiveRecord<TstAfiliadosISSN>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public TstAfiliadosISSN()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public TstAfiliadosISSN(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public TstAfiliadosISSN(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public TstAfiliadosISSN(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("TST_AfiliadosISSN", TableType.Table, DataService.GetInstance("RisProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarId = new TableSchema.TableColumn(schema);
				colvarId.ColumnName = "id";
				colvarId.DataType = DbType.Int32;
				colvarId.MaxLength = 0;
				colvarId.AutoIncrement = true;
				colvarId.IsNullable = false;
				colvarId.IsPrimaryKey = true;
				colvarId.IsForeignKey = false;
				colvarId.IsReadOnly = false;
				colvarId.DefaultSetting = @"";
				colvarId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarId);
				
				TableSchema.TableColumn colvarTipoDoc = new TableSchema.TableColumn(schema);
				colvarTipoDoc.ColumnName = "TipoDoc";
				colvarTipoDoc.DataType = DbType.AnsiString;
				colvarTipoDoc.MaxLength = 3;
				colvarTipoDoc.AutoIncrement = false;
				colvarTipoDoc.IsNullable = true;
				colvarTipoDoc.IsPrimaryKey = false;
				colvarTipoDoc.IsForeignKey = false;
				colvarTipoDoc.IsReadOnly = false;
				colvarTipoDoc.DefaultSetting = @"";
				colvarTipoDoc.ForeignKeyTableName = "";
				schema.Columns.Add(colvarTipoDoc);
				
				TableSchema.TableColumn colvarNroDoc = new TableSchema.TableColumn(schema);
				colvarNroDoc.ColumnName = "NroDoc";
				colvarNroDoc.DataType = DbType.Int32;
				colvarNroDoc.MaxLength = 0;
				colvarNroDoc.AutoIncrement = false;
				colvarNroDoc.IsNullable = true;
				colvarNroDoc.IsPrimaryKey = false;
				colvarNroDoc.IsForeignKey = false;
				colvarNroDoc.IsReadOnly = false;
				colvarNroDoc.DefaultSetting = @"";
				colvarNroDoc.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNroDoc);
				
				TableSchema.TableColumn colvarApeNom = new TableSchema.TableColumn(schema);
				colvarApeNom.ColumnName = "ApeNom";
				colvarApeNom.DataType = DbType.AnsiString;
				colvarApeNom.MaxLength = 25;
				colvarApeNom.AutoIncrement = false;
				colvarApeNom.IsNullable = true;
				colvarApeNom.IsPrimaryKey = false;
				colvarApeNom.IsForeignKey = false;
				colvarApeNom.IsReadOnly = false;
				colvarApeNom.DefaultSetting = @"";
				colvarApeNom.ForeignKeyTableName = "";
				schema.Columns.Add(colvarApeNom);
				
				TableSchema.TableColumn colvarDomicilio = new TableSchema.TableColumn(schema);
				colvarDomicilio.ColumnName = "Domicilio";
				colvarDomicilio.DataType = DbType.AnsiString;
				colvarDomicilio.MaxLength = 25;
				colvarDomicilio.AutoIncrement = false;
				colvarDomicilio.IsNullable = true;
				colvarDomicilio.IsPrimaryKey = false;
				colvarDomicilio.IsForeignKey = false;
				colvarDomicilio.IsReadOnly = false;
				colvarDomicilio.DefaultSetting = @"";
				colvarDomicilio.ForeignKeyTableName = "";
				schema.Columns.Add(colvarDomicilio);
				
				TableSchema.TableColumn colvarSimilarityLocalidad = new TableSchema.TableColumn(schema);
				colvarSimilarityLocalidad.ColumnName = "_Similarity_Localidad";
				colvarSimilarityLocalidad.DataType = DbType.Single;
				colvarSimilarityLocalidad.MaxLength = 0;
				colvarSimilarityLocalidad.AutoIncrement = false;
				colvarSimilarityLocalidad.IsNullable = true;
				colvarSimilarityLocalidad.IsPrimaryKey = false;
				colvarSimilarityLocalidad.IsForeignKey = false;
				colvarSimilarityLocalidad.IsReadOnly = false;
				colvarSimilarityLocalidad.DefaultSetting = @"";
				colvarSimilarityLocalidad.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSimilarityLocalidad);
				
				TableSchema.TableColumn colvarReparticion = new TableSchema.TableColumn(schema);
				colvarReparticion.ColumnName = "Reparticion";
				colvarReparticion.DataType = DbType.AnsiString;
				colvarReparticion.MaxLength = 4;
				colvarReparticion.AutoIncrement = false;
				colvarReparticion.IsNullable = true;
				colvarReparticion.IsPrimaryKey = false;
				colvarReparticion.IsForeignKey = false;
				colvarReparticion.IsReadOnly = false;
				colvarReparticion.DefaultSetting = @"";
				colvarReparticion.ForeignKeyTableName = "";
				schema.Columns.Add(colvarReparticion);
				
				TableSchema.TableColumn colvarNroAfiliado = new TableSchema.TableColumn(schema);
				colvarNroAfiliado.ColumnName = "NroAfiliado";
				colvarNroAfiliado.DataType = DbType.AnsiString;
				colvarNroAfiliado.MaxLength = 6;
				colvarNroAfiliado.AutoIncrement = false;
				colvarNroAfiliado.IsNullable = true;
				colvarNroAfiliado.IsPrimaryKey = false;
				colvarNroAfiliado.IsForeignKey = false;
				colvarNroAfiliado.IsReadOnly = false;
				colvarNroAfiliado.DefaultSetting = @"";
				colvarNroAfiliado.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNroAfiliado);
				
				TableSchema.TableColumn colvarCarga = new TableSchema.TableColumn(schema);
				colvarCarga.ColumnName = "Carga";
				colvarCarga.DataType = DbType.AnsiString;
				colvarCarga.MaxLength = 2;
				colvarCarga.AutoIncrement = false;
				colvarCarga.IsNullable = true;
				colvarCarga.IsPrimaryKey = false;
				colvarCarga.IsForeignKey = false;
				colvarCarga.IsReadOnly = false;
				colvarCarga.DefaultSetting = @"";
				colvarCarga.ForeignKeyTableName = "";
				schema.Columns.Add(colvarCarga);
				
				TableSchema.TableColumn colvarFechaNacimiento = new TableSchema.TableColumn(schema);
				colvarFechaNacimiento.ColumnName = "FechaNacimiento";
				colvarFechaNacimiento.DataType = DbType.AnsiString;
				colvarFechaNacimiento.MaxLength = 8;
				colvarFechaNacimiento.AutoIncrement = false;
				colvarFechaNacimiento.IsNullable = true;
				colvarFechaNacimiento.IsPrimaryKey = false;
				colvarFechaNacimiento.IsForeignKey = false;
				colvarFechaNacimiento.IsReadOnly = false;
				colvarFechaNacimiento.DefaultSetting = @"";
				colvarFechaNacimiento.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFechaNacimiento);
				
				TableSchema.TableColumn colvarFechaIngreso = new TableSchema.TableColumn(schema);
				colvarFechaIngreso.ColumnName = "FechaIngreso";
				colvarFechaIngreso.DataType = DbType.AnsiString;
				colvarFechaIngreso.MaxLength = 8;
				colvarFechaIngreso.AutoIncrement = false;
				colvarFechaIngreso.IsNullable = true;
				colvarFechaIngreso.IsPrimaryKey = false;
				colvarFechaIngreso.IsForeignKey = false;
				colvarFechaIngreso.IsReadOnly = false;
				colvarFechaIngreso.DefaultSetting = @"";
				colvarFechaIngreso.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFechaIngreso);
				
				TableSchema.TableColumn colvarFechaVencimiento = new TableSchema.TableColumn(schema);
				colvarFechaVencimiento.ColumnName = "FechaVencimiento";
				colvarFechaVencimiento.DataType = DbType.AnsiString;
				colvarFechaVencimiento.MaxLength = 8;
				colvarFechaVencimiento.AutoIncrement = false;
				colvarFechaVencimiento.IsNullable = true;
				colvarFechaVencimiento.IsPrimaryKey = false;
				colvarFechaVencimiento.IsForeignKey = false;
				colvarFechaVencimiento.IsReadOnly = false;
				colvarFechaVencimiento.DefaultSetting = @"";
				colvarFechaVencimiento.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFechaVencimiento);
				
				TableSchema.TableColumn colvarLocalidadOriginal = new TableSchema.TableColumn(schema);
				colvarLocalidadOriginal.ColumnName = "LocalidadOriginal";
				colvarLocalidadOriginal.DataType = DbType.AnsiString;
				colvarLocalidadOriginal.MaxLength = 20;
				colvarLocalidadOriginal.AutoIncrement = false;
				colvarLocalidadOriginal.IsNullable = true;
				colvarLocalidadOriginal.IsPrimaryKey = false;
				colvarLocalidadOriginal.IsForeignKey = false;
				colvarLocalidadOriginal.IsReadOnly = false;
				colvarLocalidadOriginal.DefaultSetting = @"";
				colvarLocalidadOriginal.ForeignKeyTableName = "";
				schema.Columns.Add(colvarLocalidadOriginal);
				
				TableSchema.TableColumn colvarSysLocalidad = new TableSchema.TableColumn(schema);
				colvarSysLocalidad.ColumnName = "sys_Localidad";
				colvarSysLocalidad.DataType = DbType.String;
				colvarSysLocalidad.MaxLength = 100;
				colvarSysLocalidad.AutoIncrement = false;
				colvarSysLocalidad.IsNullable = true;
				colvarSysLocalidad.IsPrimaryKey = false;
				colvarSysLocalidad.IsForeignKey = false;
				colvarSysLocalidad.IsReadOnly = false;
				colvarSysLocalidad.DefaultSetting = @"";
				colvarSysLocalidad.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSysLocalidad);
				
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
				
				TableSchema.TableColumn colvarSimilarity = new TableSchema.TableColumn(schema);
				colvarSimilarity.ColumnName = "_Similarity";
				colvarSimilarity.DataType = DbType.Single;
				colvarSimilarity.MaxLength = 0;
				colvarSimilarity.AutoIncrement = false;
				colvarSimilarity.IsNullable = true;
				colvarSimilarity.IsPrimaryKey = false;
				colvarSimilarity.IsForeignKey = false;
				colvarSimilarity.IsReadOnly = false;
				colvarSimilarity.DefaultSetting = @"";
				colvarSimilarity.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSimilarity);
				
				TableSchema.TableColumn colvarConfidence = new TableSchema.TableColumn(schema);
				colvarConfidence.ColumnName = "_Confidence";
				colvarConfidence.DataType = DbType.Single;
				colvarConfidence.MaxLength = 0;
				colvarConfidence.AutoIncrement = false;
				colvarConfidence.IsNullable = true;
				colvarConfidence.IsPrimaryKey = false;
				colvarConfidence.IsForeignKey = false;
				colvarConfidence.IsReadOnly = false;
				colvarConfidence.DefaultSetting = @"";
				colvarConfidence.ForeignKeyTableName = "";
				schema.Columns.Add(colvarConfidence);
				
				TableSchema.TableColumn colvarApellido = new TableSchema.TableColumn(schema);
				colvarApellido.ColumnName = "Apellido";
				colvarApellido.DataType = DbType.AnsiString;
				colvarApellido.MaxLength = 25;
				colvarApellido.AutoIncrement = false;
				colvarApellido.IsNullable = true;
				colvarApellido.IsPrimaryKey = false;
				colvarApellido.IsForeignKey = false;
				colvarApellido.IsReadOnly = false;
				colvarApellido.DefaultSetting = @"";
				colvarApellido.ForeignKeyTableName = "";
				schema.Columns.Add(colvarApellido);
				
				TableSchema.TableColumn colvarNombre = new TableSchema.TableColumn(schema);
				colvarNombre.ColumnName = "Nombre";
				colvarNombre.DataType = DbType.AnsiString;
				colvarNombre.MaxLength = 25;
				colvarNombre.AutoIncrement = false;
				colvarNombre.IsNullable = true;
				colvarNombre.IsPrimaryKey = false;
				colvarNombre.IsForeignKey = false;
				colvarNombre.IsReadOnly = false;
				colvarNombre.DefaultSetting = @"";
				colvarNombre.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNombre);
				
				TableSchema.TableColumn colvarFechaNacimiento2 = new TableSchema.TableColumn(schema);
				colvarFechaNacimiento2.ColumnName = "FechaNacimiento2";
				colvarFechaNacimiento2.DataType = DbType.DateTime;
				colvarFechaNacimiento2.MaxLength = 0;
				colvarFechaNacimiento2.AutoIncrement = false;
				colvarFechaNacimiento2.IsNullable = true;
				colvarFechaNacimiento2.IsPrimaryKey = false;
				colvarFechaNacimiento2.IsForeignKey = false;
				colvarFechaNacimiento2.IsReadOnly = false;
				colvarFechaNacimiento2.DefaultSetting = @"";
				colvarFechaNacimiento2.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFechaNacimiento2);
				
				TableSchema.TableColumn colvarFechaIngreso2 = new TableSchema.TableColumn(schema);
				colvarFechaIngreso2.ColumnName = "FechaIngreso2";
				colvarFechaIngreso2.DataType = DbType.DateTime;
				colvarFechaIngreso2.MaxLength = 0;
				colvarFechaIngreso2.AutoIncrement = false;
				colvarFechaIngreso2.IsNullable = true;
				colvarFechaIngreso2.IsPrimaryKey = false;
				colvarFechaIngreso2.IsForeignKey = false;
				colvarFechaIngreso2.IsReadOnly = false;
				colvarFechaIngreso2.DefaultSetting = @"";
				colvarFechaIngreso2.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFechaIngreso2);
				
				TableSchema.TableColumn colvarNumeroAfiliado = new TableSchema.TableColumn(schema);
				colvarNumeroAfiliado.ColumnName = "NumeroAfiliado";
				colvarNumeroAfiliado.DataType = DbType.AnsiString;
				colvarNumeroAfiliado.MaxLength = 14;
				colvarNumeroAfiliado.AutoIncrement = false;
				colvarNumeroAfiliado.IsNullable = true;
				colvarNumeroAfiliado.IsPrimaryKey = false;
				colvarNumeroAfiliado.IsForeignKey = false;
				colvarNumeroAfiliado.IsReadOnly = false;
				colvarNumeroAfiliado.DefaultSetting = @"";
				colvarNumeroAfiliado.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNumeroAfiliado);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["RisProvider"].AddSchema("TST_AfiliadosISSN",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("Id")]
		[Bindable(true)]
		public int Id 
		{
			get { return GetColumnValue<int>(Columns.Id); }
			set { SetColumnValue(Columns.Id, value); }
		}
		  
		[XmlAttribute("TipoDoc")]
		[Bindable(true)]
		public string TipoDoc 
		{
			get { return GetColumnValue<string>(Columns.TipoDoc); }
			set { SetColumnValue(Columns.TipoDoc, value); }
		}
		  
		[XmlAttribute("NroDoc")]
		[Bindable(true)]
		public int? NroDoc 
		{
			get { return GetColumnValue<int?>(Columns.NroDoc); }
			set { SetColumnValue(Columns.NroDoc, value); }
		}
		  
		[XmlAttribute("ApeNom")]
		[Bindable(true)]
		public string ApeNom 
		{
			get { return GetColumnValue<string>(Columns.ApeNom); }
			set { SetColumnValue(Columns.ApeNom, value); }
		}
		  
		[XmlAttribute("Domicilio")]
		[Bindable(true)]
		public string Domicilio 
		{
			get { return GetColumnValue<string>(Columns.Domicilio); }
			set { SetColumnValue(Columns.Domicilio, value); }
		}
		  
		[XmlAttribute("SimilarityLocalidad")]
		[Bindable(true)]
		public float? SimilarityLocalidad 
		{
			get { return GetColumnValue<float?>(Columns.SimilarityLocalidad); }
			set { SetColumnValue(Columns.SimilarityLocalidad, value); }
		}
		  
		[XmlAttribute("Reparticion")]
		[Bindable(true)]
		public string Reparticion 
		{
			get { return GetColumnValue<string>(Columns.Reparticion); }
			set { SetColumnValue(Columns.Reparticion, value); }
		}
		  
		[XmlAttribute("NroAfiliado")]
		[Bindable(true)]
		public string NroAfiliado 
		{
			get { return GetColumnValue<string>(Columns.NroAfiliado); }
			set { SetColumnValue(Columns.NroAfiliado, value); }
		}
		  
		[XmlAttribute("Carga")]
		[Bindable(true)]
		public string Carga 
		{
			get { return GetColumnValue<string>(Columns.Carga); }
			set { SetColumnValue(Columns.Carga, value); }
		}
		  
		[XmlAttribute("FechaNacimiento")]
		[Bindable(true)]
		public string FechaNacimiento 
		{
			get { return GetColumnValue<string>(Columns.FechaNacimiento); }
			set { SetColumnValue(Columns.FechaNacimiento, value); }
		}
		  
		[XmlAttribute("FechaIngreso")]
		[Bindable(true)]
		public string FechaIngreso 
		{
			get { return GetColumnValue<string>(Columns.FechaIngreso); }
			set { SetColumnValue(Columns.FechaIngreso, value); }
		}
		  
		[XmlAttribute("FechaVencimiento")]
		[Bindable(true)]
		public string FechaVencimiento 
		{
			get { return GetColumnValue<string>(Columns.FechaVencimiento); }
			set { SetColumnValue(Columns.FechaVencimiento, value); }
		}
		  
		[XmlAttribute("LocalidadOriginal")]
		[Bindable(true)]
		public string LocalidadOriginal 
		{
			get { return GetColumnValue<string>(Columns.LocalidadOriginal); }
			set { SetColumnValue(Columns.LocalidadOriginal, value); }
		}
		  
		[XmlAttribute("SysLocalidad")]
		[Bindable(true)]
		public string SysLocalidad 
		{
			get { return GetColumnValue<string>(Columns.SysLocalidad); }
			set { SetColumnValue(Columns.SysLocalidad, value); }
		}
		  
		[XmlAttribute("IdLocalidad")]
		[Bindable(true)]
		public int? IdLocalidad 
		{
			get { return GetColumnValue<int?>(Columns.IdLocalidad); }
			set { SetColumnValue(Columns.IdLocalidad, value); }
		}
		  
		[XmlAttribute("Similarity")]
		[Bindable(true)]
		public float? Similarity 
		{
			get { return GetColumnValue<float?>(Columns.Similarity); }
			set { SetColumnValue(Columns.Similarity, value); }
		}
		  
		[XmlAttribute("Confidence")]
		[Bindable(true)]
		public float? Confidence 
		{
			get { return GetColumnValue<float?>(Columns.Confidence); }
			set { SetColumnValue(Columns.Confidence, value); }
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
		  
		[XmlAttribute("FechaNacimiento2")]
		[Bindable(true)]
		public DateTime? FechaNacimiento2 
		{
			get { return GetColumnValue<DateTime?>(Columns.FechaNacimiento2); }
			set { SetColumnValue(Columns.FechaNacimiento2, value); }
		}
		  
		[XmlAttribute("FechaIngreso2")]
		[Bindable(true)]
		public DateTime? FechaIngreso2 
		{
			get { return GetColumnValue<DateTime?>(Columns.FechaIngreso2); }
			set { SetColumnValue(Columns.FechaIngreso2, value); }
		}
		  
		[XmlAttribute("NumeroAfiliado")]
		[Bindable(true)]
		public string NumeroAfiliado 
		{
			get { return GetColumnValue<string>(Columns.NumeroAfiliado); }
			set { SetColumnValue(Columns.NumeroAfiliado, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varTipoDoc,int? varNroDoc,string varApeNom,string varDomicilio,float? varSimilarityLocalidad,string varReparticion,string varNroAfiliado,string varCarga,string varFechaNacimiento,string varFechaIngreso,string varFechaVencimiento,string varLocalidadOriginal,string varSysLocalidad,int? varIdLocalidad,float? varSimilarity,float? varConfidence,string varApellido,string varNombre,DateTime? varFechaNacimiento2,DateTime? varFechaIngreso2,string varNumeroAfiliado)
		{
			TstAfiliadosISSN item = new TstAfiliadosISSN();
			
			item.TipoDoc = varTipoDoc;
			
			item.NroDoc = varNroDoc;
			
			item.ApeNom = varApeNom;
			
			item.Domicilio = varDomicilio;
			
			item.SimilarityLocalidad = varSimilarityLocalidad;
			
			item.Reparticion = varReparticion;
			
			item.NroAfiliado = varNroAfiliado;
			
			item.Carga = varCarga;
			
			item.FechaNacimiento = varFechaNacimiento;
			
			item.FechaIngreso = varFechaIngreso;
			
			item.FechaVencimiento = varFechaVencimiento;
			
			item.LocalidadOriginal = varLocalidadOriginal;
			
			item.SysLocalidad = varSysLocalidad;
			
			item.IdLocalidad = varIdLocalidad;
			
			item.Similarity = varSimilarity;
			
			item.Confidence = varConfidence;
			
			item.Apellido = varApellido;
			
			item.Nombre = varNombre;
			
			item.FechaNacimiento2 = varFechaNacimiento2;
			
			item.FechaIngreso2 = varFechaIngreso2;
			
			item.NumeroAfiliado = varNumeroAfiliado;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varId,string varTipoDoc,int? varNroDoc,string varApeNom,string varDomicilio,float? varSimilarityLocalidad,string varReparticion,string varNroAfiliado,string varCarga,string varFechaNacimiento,string varFechaIngreso,string varFechaVencimiento,string varLocalidadOriginal,string varSysLocalidad,int? varIdLocalidad,float? varSimilarity,float? varConfidence,string varApellido,string varNombre,DateTime? varFechaNacimiento2,DateTime? varFechaIngreso2,string varNumeroAfiliado)
		{
			TstAfiliadosISSN item = new TstAfiliadosISSN();
			
				item.Id = varId;
			
				item.TipoDoc = varTipoDoc;
			
				item.NroDoc = varNroDoc;
			
				item.ApeNom = varApeNom;
			
				item.Domicilio = varDomicilio;
			
				item.SimilarityLocalidad = varSimilarityLocalidad;
			
				item.Reparticion = varReparticion;
			
				item.NroAfiliado = varNroAfiliado;
			
				item.Carga = varCarga;
			
				item.FechaNacimiento = varFechaNacimiento;
			
				item.FechaIngreso = varFechaIngreso;
			
				item.FechaVencimiento = varFechaVencimiento;
			
				item.LocalidadOriginal = varLocalidadOriginal;
			
				item.SysLocalidad = varSysLocalidad;
			
				item.IdLocalidad = varIdLocalidad;
			
				item.Similarity = varSimilarity;
			
				item.Confidence = varConfidence;
			
				item.Apellido = varApellido;
			
				item.Nombre = varNombre;
			
				item.FechaNacimiento2 = varFechaNacimiento2;
			
				item.FechaIngreso2 = varFechaIngreso2;
			
				item.NumeroAfiliado = varNumeroAfiliado;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn IdColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn TipoDocColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn NroDocColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn ApeNomColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn DomicilioColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn SimilarityLocalidadColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        public static TableSchema.TableColumn ReparticionColumn
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        public static TableSchema.TableColumn NroAfiliadoColumn
        {
            get { return Schema.Columns[7]; }
        }
        
        
        
        public static TableSchema.TableColumn CargaColumn
        {
            get { return Schema.Columns[8]; }
        }
        
        
        
        public static TableSchema.TableColumn FechaNacimientoColumn
        {
            get { return Schema.Columns[9]; }
        }
        
        
        
        public static TableSchema.TableColumn FechaIngresoColumn
        {
            get { return Schema.Columns[10]; }
        }
        
        
        
        public static TableSchema.TableColumn FechaVencimientoColumn
        {
            get { return Schema.Columns[11]; }
        }
        
        
        
        public static TableSchema.TableColumn LocalidadOriginalColumn
        {
            get { return Schema.Columns[12]; }
        }
        
        
        
        public static TableSchema.TableColumn SysLocalidadColumn
        {
            get { return Schema.Columns[13]; }
        }
        
        
        
        public static TableSchema.TableColumn IdLocalidadColumn
        {
            get { return Schema.Columns[14]; }
        }
        
        
        
        public static TableSchema.TableColumn SimilarityColumn
        {
            get { return Schema.Columns[15]; }
        }
        
        
        
        public static TableSchema.TableColumn ConfidenceColumn
        {
            get { return Schema.Columns[16]; }
        }
        
        
        
        public static TableSchema.TableColumn ApellidoColumn
        {
            get { return Schema.Columns[17]; }
        }
        
        
        
        public static TableSchema.TableColumn NombreColumn
        {
            get { return Schema.Columns[18]; }
        }
        
        
        
        public static TableSchema.TableColumn FechaNacimiento2Column
        {
            get { return Schema.Columns[19]; }
        }
        
        
        
        public static TableSchema.TableColumn FechaIngreso2Column
        {
            get { return Schema.Columns[20]; }
        }
        
        
        
        public static TableSchema.TableColumn NumeroAfiliadoColumn
        {
            get { return Schema.Columns[21]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string Id = @"id";
			 public static string TipoDoc = @"TipoDoc";
			 public static string NroDoc = @"NroDoc";
			 public static string ApeNom = @"ApeNom";
			 public static string Domicilio = @"Domicilio";
			 public static string SimilarityLocalidad = @"_Similarity_Localidad";
			 public static string Reparticion = @"Reparticion";
			 public static string NroAfiliado = @"NroAfiliado";
			 public static string Carga = @"Carga";
			 public static string FechaNacimiento = @"FechaNacimiento";
			 public static string FechaIngreso = @"FechaIngreso";
			 public static string FechaVencimiento = @"FechaVencimiento";
			 public static string LocalidadOriginal = @"LocalidadOriginal";
			 public static string SysLocalidad = @"sys_Localidad";
			 public static string IdLocalidad = @"idLocalidad";
			 public static string Similarity = @"_Similarity";
			 public static string Confidence = @"_Confidence";
			 public static string Apellido = @"Apellido";
			 public static string Nombre = @"Nombre";
			 public static string FechaNacimiento2 = @"FechaNacimiento2";
			 public static string FechaIngreso2 = @"FechaIngreso2";
			 public static string NumeroAfiliado = @"NumeroAfiliado";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
