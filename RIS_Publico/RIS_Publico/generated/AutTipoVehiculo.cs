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
	/// Strongly-typed collection for the AutTipoVehiculo class.
	/// </summary>
    [Serializable]
	public partial class AutTipoVehiculoCollection : ActiveList<AutTipoVehiculo, AutTipoVehiculoCollection>
	{	   
		public AutTipoVehiculoCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>AutTipoVehiculoCollection</returns>
		public AutTipoVehiculoCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                AutTipoVehiculo o = this[i];
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
	/// This is an ActiveRecord class which wraps the AUT_TipoVehiculo table.
	/// </summary>
	[Serializable]
	public partial class AutTipoVehiculo : ActiveRecord<AutTipoVehiculo>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public AutTipoVehiculo()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public AutTipoVehiculo(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public AutTipoVehiculo(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public AutTipoVehiculo(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("AUT_TipoVehiculo", TableType.Table, DataService.GetInstance("RisProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarIdTipoVehiculo = new TableSchema.TableColumn(schema);
				colvarIdTipoVehiculo.ColumnName = "idTipoVehiculo";
				colvarIdTipoVehiculo.DataType = DbType.Int32;
				colvarIdTipoVehiculo.MaxLength = 0;
				colvarIdTipoVehiculo.AutoIncrement = true;
				colvarIdTipoVehiculo.IsNullable = false;
				colvarIdTipoVehiculo.IsPrimaryKey = true;
				colvarIdTipoVehiculo.IsForeignKey = false;
				colvarIdTipoVehiculo.IsReadOnly = false;
				colvarIdTipoVehiculo.DefaultSetting = @"";
				colvarIdTipoVehiculo.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdTipoVehiculo);
				
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
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["RisProvider"].AddSchema("AUT_TipoVehiculo",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("IdTipoVehiculo")]
		[Bindable(true)]
		public int IdTipoVehiculo 
		{
			get { return GetColumnValue<int>(Columns.IdTipoVehiculo); }
			set { SetColumnValue(Columns.IdTipoVehiculo, value); }
		}
		  
		[XmlAttribute("Nombre")]
		[Bindable(true)]
		public string Nombre 
		{
			get { return GetColumnValue<string>(Columns.Nombre); }
			set { SetColumnValue(Columns.Nombre, value); }
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
				colAutVehiculoRecords = new DalRis.AutVehiculoCollection().Where(AutVehiculo.Columns.IdTipoVehiculo, IdTipoVehiculo).Load();
				colAutVehiculoRecords.ListChanged += new ListChangedEventHandler(colAutVehiculoRecords_ListChanged);
			}
			return colAutVehiculoRecords;
		}
				
		void colAutVehiculoRecords_ListChanged(object sender, ListChangedEventArgs e)
		{
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
		        // Set foreign key value
		        colAutVehiculoRecords[e.NewIndex].IdTipoVehiculo = IdTipoVehiculo;
				colAutVehiculoRecords.ListChanged += new ListChangedEventHandler(colAutVehiculoRecords_ListChanged);
            }
		}
		#endregion
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varNombre)
		{
			AutTipoVehiculo item = new AutTipoVehiculo();
			
			item.Nombre = varNombre;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varIdTipoVehiculo,string varNombre)
		{
			AutTipoVehiculo item = new AutTipoVehiculo();
			
				item.IdTipoVehiculo = varIdTipoVehiculo;
			
				item.Nombre = varNombre;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn IdTipoVehiculoColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn NombreColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string IdTipoVehiculo = @"idTipoVehiculo";
			 public static string Nombre = @"nombre";
						
		}
		#endregion
		
		#region Update PK Collections
		
        public void SetPKValues()
        {
                if (colAutVehiculoRecords != null)
                {
                    foreach (DalRis.AutVehiculo item in colAutVehiculoRecords)
                    {
                        if (item.IdTipoVehiculo != IdTipoVehiculo)
                        {
                            item.IdTipoVehiculo = IdTipoVehiculo;
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
