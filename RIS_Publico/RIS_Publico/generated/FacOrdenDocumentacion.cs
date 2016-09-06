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
	/// Strongly-typed collection for the FacOrdenDocumentacion class.
	/// </summary>
    [Serializable]
	public partial class FacOrdenDocumentacionCollection : ActiveList<FacOrdenDocumentacion, FacOrdenDocumentacionCollection>
	{	   
		public FacOrdenDocumentacionCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>FacOrdenDocumentacionCollection</returns>
		public FacOrdenDocumentacionCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                FacOrdenDocumentacion o = this[i];
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
	/// This is an ActiveRecord class which wraps the FAC_OrdenDocumentacion table.
	/// </summary>
	[Serializable]
	public partial class FacOrdenDocumentacion : ActiveRecord<FacOrdenDocumentacion>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public FacOrdenDocumentacion()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public FacOrdenDocumentacion(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public FacOrdenDocumentacion(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public FacOrdenDocumentacion(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("FAC_OrdenDocumentacion", TableType.Table, DataService.GetInstance("RisProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarIdOrdenDocumentacion = new TableSchema.TableColumn(schema);
				colvarIdOrdenDocumentacion.ColumnName = "idOrdenDocumentacion";
				colvarIdOrdenDocumentacion.DataType = DbType.Int32;
				colvarIdOrdenDocumentacion.MaxLength = 0;
				colvarIdOrdenDocumentacion.AutoIncrement = true;
				colvarIdOrdenDocumentacion.IsNullable = false;
				colvarIdOrdenDocumentacion.IsPrimaryKey = true;
				colvarIdOrdenDocumentacion.IsForeignKey = false;
				colvarIdOrdenDocumentacion.IsReadOnly = false;
				colvarIdOrdenDocumentacion.DefaultSetting = @"";
				colvarIdOrdenDocumentacion.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdOrdenDocumentacion);
				
				TableSchema.TableColumn colvarIdOrden = new TableSchema.TableColumn(schema);
				colvarIdOrden.ColumnName = "idOrden";
				colvarIdOrden.DataType = DbType.Int32;
				colvarIdOrden.MaxLength = 0;
				colvarIdOrden.AutoIncrement = false;
				colvarIdOrden.IsNullable = false;
				colvarIdOrden.IsPrimaryKey = false;
				colvarIdOrden.IsForeignKey = false;
				colvarIdOrden.IsReadOnly = false;
				colvarIdOrden.DefaultSetting = @"";
				colvarIdOrden.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdOrden);
				
				TableSchema.TableColumn colvarNombre = new TableSchema.TableColumn(schema);
				colvarNombre.ColumnName = "nombre";
				colvarNombre.DataType = DbType.AnsiString;
				colvarNombre.MaxLength = 250;
				colvarNombre.AutoIncrement = false;
				colvarNombre.IsNullable = false;
				colvarNombre.IsPrimaryKey = false;
				colvarNombre.IsForeignKey = false;
				colvarNombre.IsReadOnly = false;
				
						colvarNombre.DefaultSetting = @"('')";
				colvarNombre.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNombre);
				
				TableSchema.TableColumn colvarUbicacion = new TableSchema.TableColumn(schema);
				colvarUbicacion.ColumnName = "ubicacion";
				colvarUbicacion.DataType = DbType.AnsiString;
				colvarUbicacion.MaxLength = 500;
				colvarUbicacion.AutoIncrement = false;
				colvarUbicacion.IsNullable = false;
				colvarUbicacion.IsPrimaryKey = false;
				colvarUbicacion.IsForeignKey = false;
				colvarUbicacion.IsReadOnly = false;
				
						colvarUbicacion.DefaultSetting = @"('')";
				colvarUbicacion.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUbicacion);
				
				TableSchema.TableColumn colvarDetalle = new TableSchema.TableColumn(schema);
				colvarDetalle.ColumnName = "detalle";
				colvarDetalle.DataType = DbType.AnsiString;
				colvarDetalle.MaxLength = 500;
				colvarDetalle.AutoIncrement = false;
				colvarDetalle.IsNullable = false;
				colvarDetalle.IsPrimaryKey = false;
				colvarDetalle.IsForeignKey = false;
				colvarDetalle.IsReadOnly = false;
				
						colvarDetalle.DefaultSetting = @"('')";
				colvarDetalle.ForeignKeyTableName = "";
				schema.Columns.Add(colvarDetalle);
				
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
				
						colvarFechaRegistro.DefaultSetting = @"(((1)/(1))/(1900))";
				colvarFechaRegistro.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFechaRegistro);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["RisProvider"].AddSchema("FAC_OrdenDocumentacion",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("IdOrdenDocumentacion")]
		[Bindable(true)]
		public int IdOrdenDocumentacion 
		{
			get { return GetColumnValue<int>(Columns.IdOrdenDocumentacion); }
			set { SetColumnValue(Columns.IdOrdenDocumentacion, value); }
		}
		  
		[XmlAttribute("IdOrden")]
		[Bindable(true)]
		public int IdOrden 
		{
			get { return GetColumnValue<int>(Columns.IdOrden); }
			set { SetColumnValue(Columns.IdOrden, value); }
		}
		  
		[XmlAttribute("Nombre")]
		[Bindable(true)]
		public string Nombre 
		{
			get { return GetColumnValue<string>(Columns.Nombre); }
			set { SetColumnValue(Columns.Nombre, value); }
		}
		  
		[XmlAttribute("Ubicacion")]
		[Bindable(true)]
		public string Ubicacion 
		{
			get { return GetColumnValue<string>(Columns.Ubicacion); }
			set { SetColumnValue(Columns.Ubicacion, value); }
		}
		  
		[XmlAttribute("Detalle")]
		[Bindable(true)]
		public string Detalle 
		{
			get { return GetColumnValue<string>(Columns.Detalle); }
			set { SetColumnValue(Columns.Detalle, value); }
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
		public static void Insert(int varIdOrden,string varNombre,string varUbicacion,string varDetalle,int varIdUsuarioRegistro,DateTime varFechaRegistro)
		{
			FacOrdenDocumentacion item = new FacOrdenDocumentacion();
			
			item.IdOrden = varIdOrden;
			
			item.Nombre = varNombre;
			
			item.Ubicacion = varUbicacion;
			
			item.Detalle = varDetalle;
			
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
		public static void Update(int varIdOrdenDocumentacion,int varIdOrden,string varNombre,string varUbicacion,string varDetalle,int varIdUsuarioRegistro,DateTime varFechaRegistro)
		{
			FacOrdenDocumentacion item = new FacOrdenDocumentacion();
			
				item.IdOrdenDocumentacion = varIdOrdenDocumentacion;
			
				item.IdOrden = varIdOrden;
			
				item.Nombre = varNombre;
			
				item.Ubicacion = varUbicacion;
			
				item.Detalle = varDetalle;
			
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
        
        
        public static TableSchema.TableColumn IdOrdenDocumentacionColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn IdOrdenColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn NombreColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn UbicacionColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn DetalleColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn IdUsuarioRegistroColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        public static TableSchema.TableColumn FechaRegistroColumn
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string IdOrdenDocumentacion = @"idOrdenDocumentacion";
			 public static string IdOrden = @"idOrden";
			 public static string Nombre = @"nombre";
			 public static string Ubicacion = @"ubicacion";
			 public static string Detalle = @"detalle";
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
