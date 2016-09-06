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
	/// Strongly-typed collection for the BdsProductoAdmision class.
	/// </summary>
    [Serializable]
	public partial class BdsProductoAdmisionCollection : ActiveList<BdsProductoAdmision, BdsProductoAdmisionCollection>
	{	   
		public BdsProductoAdmisionCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>BdsProductoAdmisionCollection</returns>
		public BdsProductoAdmisionCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                BdsProductoAdmision o = this[i];
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
	/// This is an ActiveRecord class which wraps the BDS_ProductoAdmision table.
	/// </summary>
	[Serializable]
	public partial class BdsProductoAdmision : ActiveRecord<BdsProductoAdmision>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public BdsProductoAdmision()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public BdsProductoAdmision(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public BdsProductoAdmision(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public BdsProductoAdmision(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("BDS_ProductoAdmision", TableType.Table, DataService.GetInstance("RisProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarIdProductoAdmision = new TableSchema.TableColumn(schema);
				colvarIdProductoAdmision.ColumnName = "idProductoAdmision";
				colvarIdProductoAdmision.DataType = DbType.Int32;
				colvarIdProductoAdmision.MaxLength = 0;
				colvarIdProductoAdmision.AutoIncrement = true;
				colvarIdProductoAdmision.IsNullable = false;
				colvarIdProductoAdmision.IsPrimaryKey = true;
				colvarIdProductoAdmision.IsForeignKey = false;
				colvarIdProductoAdmision.IsReadOnly = false;
				colvarIdProductoAdmision.DefaultSetting = @"";
				colvarIdProductoAdmision.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdProductoAdmision);
				
				TableSchema.TableColumn colvarIdAdmision = new TableSchema.TableColumn(schema);
				colvarIdAdmision.ColumnName = "idAdmision";
				colvarIdAdmision.DataType = DbType.Int32;
				colvarIdAdmision.MaxLength = 0;
				colvarIdAdmision.AutoIncrement = false;
				colvarIdAdmision.IsNullable = false;
				colvarIdAdmision.IsPrimaryKey = false;
				colvarIdAdmision.IsForeignKey = false;
				colvarIdAdmision.IsReadOnly = false;
				colvarIdAdmision.DefaultSetting = @"";
				colvarIdAdmision.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdAdmision);
				
				TableSchema.TableColumn colvarIdHemocomponente = new TableSchema.TableColumn(schema);
				colvarIdHemocomponente.ColumnName = "idHemocomponente";
				colvarIdHemocomponente.DataType = DbType.Int32;
				colvarIdHemocomponente.MaxLength = 0;
				colvarIdHemocomponente.AutoIncrement = false;
				colvarIdHemocomponente.IsNullable = false;
				colvarIdHemocomponente.IsPrimaryKey = false;
				colvarIdHemocomponente.IsForeignKey = false;
				colvarIdHemocomponente.IsReadOnly = false;
				colvarIdHemocomponente.DefaultSetting = @"";
				colvarIdHemocomponente.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdHemocomponente);
				
				TableSchema.TableColumn colvarIdUsoHemocomponente = new TableSchema.TableColumn(schema);
				colvarIdUsoHemocomponente.ColumnName = "idUsoHemocomponente";
				colvarIdUsoHemocomponente.DataType = DbType.Int32;
				colvarIdUsoHemocomponente.MaxLength = 0;
				colvarIdUsoHemocomponente.AutoIncrement = false;
				colvarIdUsoHemocomponente.IsNullable = false;
				colvarIdUsoHemocomponente.IsPrimaryKey = false;
				colvarIdUsoHemocomponente.IsForeignKey = false;
				colvarIdUsoHemocomponente.IsReadOnly = false;
				colvarIdUsoHemocomponente.DefaultSetting = @"";
				colvarIdUsoHemocomponente.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdUsoHemocomponente);
				
				TableSchema.TableColumn colvarIdUsuarioLibera = new TableSchema.TableColumn(schema);
				colvarIdUsuarioLibera.ColumnName = "idUsuarioLibera";
				colvarIdUsuarioLibera.DataType = DbType.Int32;
				colvarIdUsuarioLibera.MaxLength = 0;
				colvarIdUsuarioLibera.AutoIncrement = false;
				colvarIdUsuarioLibera.IsNullable = false;
				colvarIdUsuarioLibera.IsPrimaryKey = false;
				colvarIdUsuarioLibera.IsForeignKey = false;
				colvarIdUsuarioLibera.IsReadOnly = false;
				colvarIdUsuarioLibera.DefaultSetting = @"";
				colvarIdUsuarioLibera.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdUsuarioLibera);
				
				TableSchema.TableColumn colvarFechaLiberacion = new TableSchema.TableColumn(schema);
				colvarFechaLiberacion.ColumnName = "fechaLiberacion";
				colvarFechaLiberacion.DataType = DbType.DateTime;
				colvarFechaLiberacion.MaxLength = 0;
				colvarFechaLiberacion.AutoIncrement = false;
				colvarFechaLiberacion.IsNullable = false;
				colvarFechaLiberacion.IsPrimaryKey = false;
				colvarFechaLiberacion.IsForeignKey = false;
				colvarFechaLiberacion.IsReadOnly = false;
				colvarFechaLiberacion.DefaultSetting = @"";
				colvarFechaLiberacion.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFechaLiberacion);
				
				TableSchema.TableColumn colvarPeso = new TableSchema.TableColumn(schema);
				colvarPeso.ColumnName = "peso";
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
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["RisProvider"].AddSchema("BDS_ProductoAdmision",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("IdProductoAdmision")]
		[Bindable(true)]
		public int IdProductoAdmision 
		{
			get { return GetColumnValue<int>(Columns.IdProductoAdmision); }
			set { SetColumnValue(Columns.IdProductoAdmision, value); }
		}
		  
		[XmlAttribute("IdAdmision")]
		[Bindable(true)]
		public int IdAdmision 
		{
			get { return GetColumnValue<int>(Columns.IdAdmision); }
			set { SetColumnValue(Columns.IdAdmision, value); }
		}
		  
		[XmlAttribute("IdHemocomponente")]
		[Bindable(true)]
		public int IdHemocomponente 
		{
			get { return GetColumnValue<int>(Columns.IdHemocomponente); }
			set { SetColumnValue(Columns.IdHemocomponente, value); }
		}
		  
		[XmlAttribute("IdUsoHemocomponente")]
		[Bindable(true)]
		public int IdUsoHemocomponente 
		{
			get { return GetColumnValue<int>(Columns.IdUsoHemocomponente); }
			set { SetColumnValue(Columns.IdUsoHemocomponente, value); }
		}
		  
		[XmlAttribute("IdUsuarioLibera")]
		[Bindable(true)]
		public int IdUsuarioLibera 
		{
			get { return GetColumnValue<int>(Columns.IdUsuarioLibera); }
			set { SetColumnValue(Columns.IdUsuarioLibera, value); }
		}
		  
		[XmlAttribute("FechaLiberacion")]
		[Bindable(true)]
		public DateTime FechaLiberacion 
		{
			get { return GetColumnValue<DateTime>(Columns.FechaLiberacion); }
			set { SetColumnValue(Columns.FechaLiberacion, value); }
		}
		  
		[XmlAttribute("Peso")]
		[Bindable(true)]
		public decimal? Peso 
		{
			get { return GetColumnValue<decimal?>(Columns.Peso); }
			set { SetColumnValue(Columns.Peso, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(int varIdAdmision,int varIdHemocomponente,int varIdUsoHemocomponente,int varIdUsuarioLibera,DateTime varFechaLiberacion,decimal? varPeso)
		{
			BdsProductoAdmision item = new BdsProductoAdmision();
			
			item.IdAdmision = varIdAdmision;
			
			item.IdHemocomponente = varIdHemocomponente;
			
			item.IdUsoHemocomponente = varIdUsoHemocomponente;
			
			item.IdUsuarioLibera = varIdUsuarioLibera;
			
			item.FechaLiberacion = varFechaLiberacion;
			
			item.Peso = varPeso;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varIdProductoAdmision,int varIdAdmision,int varIdHemocomponente,int varIdUsoHemocomponente,int varIdUsuarioLibera,DateTime varFechaLiberacion,decimal? varPeso)
		{
			BdsProductoAdmision item = new BdsProductoAdmision();
			
				item.IdProductoAdmision = varIdProductoAdmision;
			
				item.IdAdmision = varIdAdmision;
			
				item.IdHemocomponente = varIdHemocomponente;
			
				item.IdUsoHemocomponente = varIdUsoHemocomponente;
			
				item.IdUsuarioLibera = varIdUsuarioLibera;
			
				item.FechaLiberacion = varFechaLiberacion;
			
				item.Peso = varPeso;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn IdProductoAdmisionColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn IdAdmisionColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn IdHemocomponenteColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn IdUsoHemocomponenteColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn IdUsuarioLiberaColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn FechaLiberacionColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        public static TableSchema.TableColumn PesoColumn
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string IdProductoAdmision = @"idProductoAdmision";
			 public static string IdAdmision = @"idAdmision";
			 public static string IdHemocomponente = @"idHemocomponente";
			 public static string IdUsoHemocomponente = @"idUsoHemocomponente";
			 public static string IdUsuarioLibera = @"idUsuarioLibera";
			 public static string FechaLiberacion = @"fechaLiberacion";
			 public static string Peso = @"peso";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
