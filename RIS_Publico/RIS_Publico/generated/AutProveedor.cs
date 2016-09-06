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
	/// Strongly-typed collection for the AutProveedor class.
	/// </summary>
    [Serializable]
	public partial class AutProveedorCollection : ActiveList<AutProveedor, AutProveedorCollection>
	{	   
		public AutProveedorCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>AutProveedorCollection</returns>
		public AutProveedorCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                AutProveedor o = this[i];
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
	/// This is an ActiveRecord class which wraps the AUT_Proveedor table.
	/// </summary>
	[Serializable]
	public partial class AutProveedor : ActiveRecord<AutProveedor>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public AutProveedor()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public AutProveedor(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public AutProveedor(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public AutProveedor(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("AUT_Proveedor", TableType.Table, DataService.GetInstance("RisProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarIdProveedor = new TableSchema.TableColumn(schema);
				colvarIdProveedor.ColumnName = "idProveedor";
				colvarIdProveedor.DataType = DbType.Int32;
				colvarIdProveedor.MaxLength = 0;
				colvarIdProveedor.AutoIncrement = true;
				colvarIdProveedor.IsNullable = false;
				colvarIdProveedor.IsPrimaryKey = true;
				colvarIdProveedor.IsForeignKey = false;
				colvarIdProveedor.IsReadOnly = false;
				colvarIdProveedor.DefaultSetting = @"";
				colvarIdProveedor.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdProveedor);
				
				TableSchema.TableColumn colvarNombre = new TableSchema.TableColumn(schema);
				colvarNombre.ColumnName = "nombre";
				colvarNombre.DataType = DbType.String;
				colvarNombre.MaxLength = 50;
				colvarNombre.AutoIncrement = false;
				colvarNombre.IsNullable = false;
				colvarNombre.IsPrimaryKey = false;
				colvarNombre.IsForeignKey = false;
				colvarNombre.IsReadOnly = false;
				colvarNombre.DefaultSetting = @"";
				colvarNombre.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNombre);
				
				TableSchema.TableColumn colvarCuit = new TableSchema.TableColumn(schema);
				colvarCuit.ColumnName = "cuit";
				colvarCuit.DataType = DbType.String;
				colvarCuit.MaxLength = 50;
				colvarCuit.AutoIncrement = false;
				colvarCuit.IsNullable = false;
				colvarCuit.IsPrimaryKey = false;
				colvarCuit.IsForeignKey = false;
				colvarCuit.IsReadOnly = false;
				colvarCuit.DefaultSetting = @"";
				colvarCuit.ForeignKeyTableName = "";
				schema.Columns.Add(colvarCuit);
				
				TableSchema.TableColumn colvarDireccion = new TableSchema.TableColumn(schema);
				colvarDireccion.ColumnName = "direccion";
				colvarDireccion.DataType = DbType.String;
				colvarDireccion.MaxLength = 50;
				colvarDireccion.AutoIncrement = false;
				colvarDireccion.IsNullable = false;
				colvarDireccion.IsPrimaryKey = false;
				colvarDireccion.IsForeignKey = false;
				colvarDireccion.IsReadOnly = false;
				colvarDireccion.DefaultSetting = @"";
				colvarDireccion.ForeignKeyTableName = "";
				schema.Columns.Add(colvarDireccion);
				
				TableSchema.TableColumn colvarTelefono = new TableSchema.TableColumn(schema);
				colvarTelefono.ColumnName = "telefono";
				colvarTelefono.DataType = DbType.String;
				colvarTelefono.MaxLength = 50;
				colvarTelefono.AutoIncrement = false;
				colvarTelefono.IsNullable = false;
				colvarTelefono.IsPrimaryKey = false;
				colvarTelefono.IsForeignKey = false;
				colvarTelefono.IsReadOnly = false;
				colvarTelefono.DefaultSetting = @"";
				colvarTelefono.ForeignKeyTableName = "";
				schema.Columns.Add(colvarTelefono);
				
				TableSchema.TableColumn colvarIdTipoProveedor = new TableSchema.TableColumn(schema);
				colvarIdTipoProveedor.ColumnName = "idTipoProveedor";
				colvarIdTipoProveedor.DataType = DbType.Decimal;
				colvarIdTipoProveedor.MaxLength = 0;
				colvarIdTipoProveedor.AutoIncrement = false;
				colvarIdTipoProveedor.IsNullable = true;
				colvarIdTipoProveedor.IsPrimaryKey = false;
				colvarIdTipoProveedor.IsForeignKey = false;
				colvarIdTipoProveedor.IsReadOnly = false;
				colvarIdTipoProveedor.DefaultSetting = @"";
				colvarIdTipoProveedor.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdTipoProveedor);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["RisProvider"].AddSchema("AUT_Proveedor",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("IdProveedor")]
		[Bindable(true)]
		public int IdProveedor 
		{
			get { return GetColumnValue<int>(Columns.IdProveedor); }
			set { SetColumnValue(Columns.IdProveedor, value); }
		}
		  
		[XmlAttribute("Nombre")]
		[Bindable(true)]
		public string Nombre 
		{
			get { return GetColumnValue<string>(Columns.Nombre); }
			set { SetColumnValue(Columns.Nombre, value); }
		}
		  
		[XmlAttribute("Cuit")]
		[Bindable(true)]
		public string Cuit 
		{
			get { return GetColumnValue<string>(Columns.Cuit); }
			set { SetColumnValue(Columns.Cuit, value); }
		}
		  
		[XmlAttribute("Direccion")]
		[Bindable(true)]
		public string Direccion 
		{
			get { return GetColumnValue<string>(Columns.Direccion); }
			set { SetColumnValue(Columns.Direccion, value); }
		}
		  
		[XmlAttribute("Telefono")]
		[Bindable(true)]
		public string Telefono 
		{
			get { return GetColumnValue<string>(Columns.Telefono); }
			set { SetColumnValue(Columns.Telefono, value); }
		}
		  
		[XmlAttribute("IdTipoProveedor")]
		[Bindable(true)]
		public decimal? IdTipoProveedor 
		{
			get { return GetColumnValue<decimal?>(Columns.IdTipoProveedor); }
			set { SetColumnValue(Columns.IdTipoProveedor, value); }
		}
		
		#endregion
		
		
		#region PrimaryKey Methods		
		
        protected override void SetPrimaryKey(object oValue)
        {
            base.SetPrimaryKey(oValue);
            
            SetPKValues();
        }
        
		
		private DalRis.AutMovimientoCollection colAutMovimientoRecords;
		public DalRis.AutMovimientoCollection AutMovimientoRecords()
		{
			if(colAutMovimientoRecords == null)
			{
				colAutMovimientoRecords = new DalRis.AutMovimientoCollection().Where(AutMovimiento.Columns.IdProveedor, IdProveedor).Load();
				colAutMovimientoRecords.ListChanged += new ListChangedEventHandler(colAutMovimientoRecords_ListChanged);
			}
			return colAutMovimientoRecords;
		}
				
		void colAutMovimientoRecords_ListChanged(object sender, ListChangedEventArgs e)
		{
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
		        // Set foreign key value
		        colAutMovimientoRecords[e.NewIndex].IdProveedor = IdProveedor;
				colAutMovimientoRecords.ListChanged += new ListChangedEventHandler(colAutMovimientoRecords_ListChanged);
            }
		}
		#endregion
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varNombre,string varCuit,string varDireccion,string varTelefono,decimal? varIdTipoProveedor)
		{
			AutProveedor item = new AutProveedor();
			
			item.Nombre = varNombre;
			
			item.Cuit = varCuit;
			
			item.Direccion = varDireccion;
			
			item.Telefono = varTelefono;
			
			item.IdTipoProveedor = varIdTipoProveedor;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varIdProveedor,string varNombre,string varCuit,string varDireccion,string varTelefono,decimal? varIdTipoProveedor)
		{
			AutProveedor item = new AutProveedor();
			
				item.IdProveedor = varIdProveedor;
			
				item.Nombre = varNombre;
			
				item.Cuit = varCuit;
			
				item.Direccion = varDireccion;
			
				item.Telefono = varTelefono;
			
				item.IdTipoProveedor = varIdTipoProveedor;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn IdProveedorColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn NombreColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn CuitColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn DireccionColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn TelefonoColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn IdTipoProveedorColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string IdProveedor = @"idProveedor";
			 public static string Nombre = @"nombre";
			 public static string Cuit = @"cuit";
			 public static string Direccion = @"direccion";
			 public static string Telefono = @"telefono";
			 public static string IdTipoProveedor = @"idTipoProveedor";
						
		}
		#endregion
		
		#region Update PK Collections
		
        public void SetPKValues()
        {
                if (colAutMovimientoRecords != null)
                {
                    foreach (DalRis.AutMovimiento item in colAutMovimientoRecords)
                    {
                        if (item.IdProveedor != IdProveedor)
                        {
                            item.IdProveedor = IdProveedor;
                        }
                    }
               }
		}
        #endregion
    
        #region Deep Save
		
        public void DeepSave()
        {
            Save();
            
                if (colAutMovimientoRecords != null)
                {
                    colAutMovimientoRecords.SaveAll();
               }
		}
        #endregion
	}
}
