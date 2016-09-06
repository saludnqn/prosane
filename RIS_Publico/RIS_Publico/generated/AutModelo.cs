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
	/// Strongly-typed collection for the AutModelo class.
	/// </summary>
    [Serializable]
	public partial class AutModeloCollection : ActiveList<AutModelo, AutModeloCollection>
	{	   
		public AutModeloCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>AutModeloCollection</returns>
		public AutModeloCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                AutModelo o = this[i];
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
	/// This is an ActiveRecord class which wraps the AUT_Modelo table.
	/// </summary>
	[Serializable]
	public partial class AutModelo : ActiveRecord<AutModelo>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public AutModelo()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public AutModelo(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public AutModelo(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public AutModelo(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("AUT_Modelo", TableType.Table, DataService.GetInstance("RisProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarIdModelo = new TableSchema.TableColumn(schema);
				colvarIdModelo.ColumnName = "idModelo";
				colvarIdModelo.DataType = DbType.Int32;
				colvarIdModelo.MaxLength = 0;
				colvarIdModelo.AutoIncrement = true;
				colvarIdModelo.IsNullable = false;
				colvarIdModelo.IsPrimaryKey = true;
				colvarIdModelo.IsForeignKey = false;
				colvarIdModelo.IsReadOnly = false;
				colvarIdModelo.DefaultSetting = @"";
				colvarIdModelo.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdModelo);
				
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
				
				TableSchema.TableColumn colvarIdMarca = new TableSchema.TableColumn(schema);
				colvarIdMarca.ColumnName = "idMarca";
				colvarIdMarca.DataType = DbType.Int32;
				colvarIdMarca.MaxLength = 0;
				colvarIdMarca.AutoIncrement = false;
				colvarIdMarca.IsNullable = false;
				colvarIdMarca.IsPrimaryKey = false;
				colvarIdMarca.IsForeignKey = false;
				colvarIdMarca.IsReadOnly = false;
				colvarIdMarca.DefaultSetting = @"";
				colvarIdMarca.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdMarca);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["RisProvider"].AddSchema("AUT_Modelo",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("IdModelo")]
		[Bindable(true)]
		public int IdModelo 
		{
			get { return GetColumnValue<int>(Columns.IdModelo); }
			set { SetColumnValue(Columns.IdModelo, value); }
		}
		  
		[XmlAttribute("Nombre")]
		[Bindable(true)]
		public string Nombre 
		{
			get { return GetColumnValue<string>(Columns.Nombre); }
			set { SetColumnValue(Columns.Nombre, value); }
		}
		  
		[XmlAttribute("IdMarca")]
		[Bindable(true)]
		public int IdMarca 
		{
			get { return GetColumnValue<int>(Columns.IdMarca); }
			set { SetColumnValue(Columns.IdMarca, value); }
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
				colAutVehiculoRecords = new DalRis.AutVehiculoCollection().Where(AutVehiculo.Columns.IdModelo, IdModelo).Load();
				colAutVehiculoRecords.ListChanged += new ListChangedEventHandler(colAutVehiculoRecords_ListChanged);
			}
			return colAutVehiculoRecords;
		}
				
		void colAutVehiculoRecords_ListChanged(object sender, ListChangedEventArgs e)
		{
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
		        // Set foreign key value
		        colAutVehiculoRecords[e.NewIndex].IdModelo = IdModelo;
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
		public static void Insert(string varNombre,int varIdMarca)
		{
			AutModelo item = new AutModelo();
			
			item.Nombre = varNombre;
			
			item.IdMarca = varIdMarca;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varIdModelo,string varNombre,int varIdMarca)
		{
			AutModelo item = new AutModelo();
			
				item.IdModelo = varIdModelo;
			
				item.Nombre = varNombre;
			
				item.IdMarca = varIdMarca;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn IdModeloColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn NombreColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn IdMarcaColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string IdModelo = @"idModelo";
			 public static string Nombre = @"nombre";
			 public static string IdMarca = @"idMarca";
						
		}
		#endregion
		
		#region Update PK Collections
		
        public void SetPKValues()
        {
                if (colAutVehiculoRecords != null)
                {
                    foreach (DalRis.AutVehiculo item in colAutVehiculoRecords)
                    {
                        if (item.IdModelo != IdModelo)
                        {
                            item.IdModelo = IdModelo;
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
