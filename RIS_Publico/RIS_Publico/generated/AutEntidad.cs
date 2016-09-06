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
	/// Strongly-typed collection for the AutEntidad class.
	/// </summary>
    [Serializable]
	public partial class AutEntidadCollection : ActiveList<AutEntidad, AutEntidadCollection>
	{	   
		public AutEntidadCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>AutEntidadCollection</returns>
		public AutEntidadCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                AutEntidad o = this[i];
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
	/// This is an ActiveRecord class which wraps the AUT_Entidad table.
	/// </summary>
	[Serializable]
	public partial class AutEntidad : ActiveRecord<AutEntidad>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public AutEntidad()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public AutEntidad(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public AutEntidad(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public AutEntidad(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("AUT_Entidad", TableType.Table, DataService.GetInstance("RisProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarIdEntidad = new TableSchema.TableColumn(schema);
				colvarIdEntidad.ColumnName = "idEntidad";
				colvarIdEntidad.DataType = DbType.Int32;
				colvarIdEntidad.MaxLength = 0;
				colvarIdEntidad.AutoIncrement = true;
				colvarIdEntidad.IsNullable = false;
				colvarIdEntidad.IsPrimaryKey = true;
				colvarIdEntidad.IsForeignKey = false;
				colvarIdEntidad.IsReadOnly = false;
				colvarIdEntidad.DefaultSetting = @"";
				colvarIdEntidad.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdEntidad);
				
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
				
				TableSchema.TableColumn colvarIdZona = new TableSchema.TableColumn(schema);
				colvarIdZona.ColumnName = "idZona";
				colvarIdZona.DataType = DbType.Int32;
				colvarIdZona.MaxLength = 0;
				colvarIdZona.AutoIncrement = false;
				colvarIdZona.IsNullable = false;
				colvarIdZona.IsPrimaryKey = false;
				colvarIdZona.IsForeignKey = true;
				colvarIdZona.IsReadOnly = false;
				colvarIdZona.DefaultSetting = @"";
				
					colvarIdZona.ForeignKeyTableName = "Sys_Zona";
				schema.Columns.Add(colvarIdZona);
				
				TableSchema.TableColumn colvarIdEntidadSuperior = new TableSchema.TableColumn(schema);
				colvarIdEntidadSuperior.ColumnName = "idEntidadSuperior";
				colvarIdEntidadSuperior.DataType = DbType.Int32;
				colvarIdEntidadSuperior.MaxLength = 0;
				colvarIdEntidadSuperior.AutoIncrement = false;
				colvarIdEntidadSuperior.IsNullable = false;
				colvarIdEntidadSuperior.IsPrimaryKey = false;
				colvarIdEntidadSuperior.IsForeignKey = false;
				colvarIdEntidadSuperior.IsReadOnly = false;
				colvarIdEntidadSuperior.DefaultSetting = @"";
				colvarIdEntidadSuperior.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdEntidadSuperior);
				
				TableSchema.TableColumn colvarIdTipoEntidad = new TableSchema.TableColumn(schema);
				colvarIdTipoEntidad.ColumnName = "idTipoEntidad";
				colvarIdTipoEntidad.DataType = DbType.Int32;
				colvarIdTipoEntidad.MaxLength = 0;
				colvarIdTipoEntidad.AutoIncrement = false;
				colvarIdTipoEntidad.IsNullable = false;
				colvarIdTipoEntidad.IsPrimaryKey = false;
				colvarIdTipoEntidad.IsForeignKey = false;
				colvarIdTipoEntidad.IsReadOnly = false;
				colvarIdTipoEntidad.DefaultSetting = @"";
				colvarIdTipoEntidad.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdTipoEntidad);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["RisProvider"].AddSchema("AUT_Entidad",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("IdEntidad")]
		[Bindable(true)]
		public int IdEntidad 
		{
			get { return GetColumnValue<int>(Columns.IdEntidad); }
			set { SetColumnValue(Columns.IdEntidad, value); }
		}
		  
		[XmlAttribute("Nombre")]
		[Bindable(true)]
		public string Nombre 
		{
			get { return GetColumnValue<string>(Columns.Nombre); }
			set { SetColumnValue(Columns.Nombre, value); }
		}
		  
		[XmlAttribute("IdZona")]
		[Bindable(true)]
		public int IdZona 
		{
			get { return GetColumnValue<int>(Columns.IdZona); }
			set { SetColumnValue(Columns.IdZona, value); }
		}
		  
		[XmlAttribute("IdEntidadSuperior")]
		[Bindable(true)]
		public int IdEntidadSuperior 
		{
			get { return GetColumnValue<int>(Columns.IdEntidadSuperior); }
			set { SetColumnValue(Columns.IdEntidadSuperior, value); }
		}
		  
		[XmlAttribute("IdTipoEntidad")]
		[Bindable(true)]
		public int IdTipoEntidad 
		{
			get { return GetColumnValue<int>(Columns.IdTipoEntidad); }
			set { SetColumnValue(Columns.IdTipoEntidad, value); }
		}
		
		#endregion
		
		
		#region PrimaryKey Methods		
		
        protected override void SetPrimaryKey(object oValue)
        {
            base.SetPrimaryKey(oValue);
            
            SetPKValues();
        }
        
		
		private DalRis.AutVehiculoCollection colAutVehiculoRecords;
		public DalRis.AutVehiculoCollection AutVehiculoRecords()
		{
			if(colAutVehiculoRecords == null)
			{
				colAutVehiculoRecords = new DalRis.AutVehiculoCollection().Where(AutVehiculo.Columns.IdEntidad, IdEntidad).Load();
				colAutVehiculoRecords.ListChanged += new ListChangedEventHandler(colAutVehiculoRecords_ListChanged);
			}
			return colAutVehiculoRecords;
		}
				
		void colAutVehiculoRecords_ListChanged(object sender, ListChangedEventArgs e)
		{
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
		        // Set foreign key value
		        colAutVehiculoRecords[e.NewIndex].IdEntidad = IdEntidad;
				colAutVehiculoRecords.ListChanged += new ListChangedEventHandler(colAutVehiculoRecords_ListChanged);
            }
		}
		#endregion
		
			
		
		#region ForeignKey Properties
		
		/// <summary>
		/// Returns a SysZona ActiveRecord object related to this AutEntidad
		/// 
		/// </summary>
		public DalRis.SysZona SysZona
		{
			get { return DalRis.SysZona.FetchByID(this.IdZona); }
			set { SetColumnValue("idZona", value.IdZona); }
		}
		
		
		#endregion
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varNombre,int varIdZona,int varIdEntidadSuperior,int varIdTipoEntidad)
		{
			AutEntidad item = new AutEntidad();
			
			item.Nombre = varNombre;
			
			item.IdZona = varIdZona;
			
			item.IdEntidadSuperior = varIdEntidadSuperior;
			
			item.IdTipoEntidad = varIdTipoEntidad;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varIdEntidad,string varNombre,int varIdZona,int varIdEntidadSuperior,int varIdTipoEntidad)
		{
			AutEntidad item = new AutEntidad();
			
				item.IdEntidad = varIdEntidad;
			
				item.Nombre = varNombre;
			
				item.IdZona = varIdZona;
			
				item.IdEntidadSuperior = varIdEntidadSuperior;
			
				item.IdTipoEntidad = varIdTipoEntidad;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn IdEntidadColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn NombreColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn IdZonaColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn IdEntidadSuperiorColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn IdTipoEntidadColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string IdEntidad = @"idEntidad";
			 public static string Nombre = @"nombre";
			 public static string IdZona = @"idZona";
			 public static string IdEntidadSuperior = @"idEntidadSuperior";
			 public static string IdTipoEntidad = @"idTipoEntidad";
						
		}
		#endregion
		
		#region Update PK Collections
		
        public void SetPKValues()
        {
                if (colAutVehiculoRecords != null)
                {
                    foreach (DalRis.AutVehiculo item in colAutVehiculoRecords)
                    {
                        if (item.IdEntidad != IdEntidad)
                        {
                            item.IdEntidad = IdEntidad;
                        }
                    }
               }
		}
        #endregion
    
        #region Deep Save
		
        public void DeepSave()
        {
            Save();
            
                if (colAutVehiculoRecords != null)
                {
                    colAutVehiculoRecords.SaveAll();
               }
		}
        #endregion
	}
}
