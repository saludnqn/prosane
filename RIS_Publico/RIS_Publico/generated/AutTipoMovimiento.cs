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
	/// Strongly-typed collection for the AutTipoMovimiento class.
	/// </summary>
    [Serializable]
	public partial class AutTipoMovimientoCollection : ActiveList<AutTipoMovimiento, AutTipoMovimientoCollection>
	{	   
		public AutTipoMovimientoCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>AutTipoMovimientoCollection</returns>
		public AutTipoMovimientoCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                AutTipoMovimiento o = this[i];
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
	/// This is an ActiveRecord class which wraps the AUT_TipoMovimiento table.
	/// </summary>
	[Serializable]
	public partial class AutTipoMovimiento : ActiveRecord<AutTipoMovimiento>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public AutTipoMovimiento()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public AutTipoMovimiento(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public AutTipoMovimiento(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public AutTipoMovimiento(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("AUT_TipoMovimiento", TableType.Table, DataService.GetInstance("RisProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarIdTipoMovimiento = new TableSchema.TableColumn(schema);
				colvarIdTipoMovimiento.ColumnName = "idTipoMovimiento";
				colvarIdTipoMovimiento.DataType = DbType.Int32;
				colvarIdTipoMovimiento.MaxLength = 0;
				colvarIdTipoMovimiento.AutoIncrement = true;
				colvarIdTipoMovimiento.IsNullable = false;
				colvarIdTipoMovimiento.IsPrimaryKey = true;
				colvarIdTipoMovimiento.IsForeignKey = false;
				colvarIdTipoMovimiento.IsReadOnly = false;
				colvarIdTipoMovimiento.DefaultSetting = @"";
				colvarIdTipoMovimiento.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdTipoMovimiento);
				
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
				DataService.Providers["RisProvider"].AddSchema("AUT_TipoMovimiento",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("IdTipoMovimiento")]
		[Bindable(true)]
		public int IdTipoMovimiento 
		{
			get { return GetColumnValue<int>(Columns.IdTipoMovimiento); }
			set { SetColumnValue(Columns.IdTipoMovimiento, value); }
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
        
		
		private DalRis.AutMovimientoCollection colAutMovimientoRecords;
		public DalRis.AutMovimientoCollection AutMovimientoRecords()
		{
			if(colAutMovimientoRecords == null)
			{
				colAutMovimientoRecords = new DalRis.AutMovimientoCollection().Where(AutMovimiento.Columns.IdTipoMovimiento, IdTipoMovimiento).Load();
				colAutMovimientoRecords.ListChanged += new ListChangedEventHandler(colAutMovimientoRecords_ListChanged);
			}
			return colAutMovimientoRecords;
		}
				
		void colAutMovimientoRecords_ListChanged(object sender, ListChangedEventArgs e)
		{
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
		        // Set foreign key value
		        colAutMovimientoRecords[e.NewIndex].IdTipoMovimiento = IdTipoMovimiento;
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
		public static void Insert(string varNombre)
		{
			AutTipoMovimiento item = new AutTipoMovimiento();
			
			item.Nombre = varNombre;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varIdTipoMovimiento,string varNombre)
		{
			AutTipoMovimiento item = new AutTipoMovimiento();
			
				item.IdTipoMovimiento = varIdTipoMovimiento;
			
				item.Nombre = varNombre;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn IdTipoMovimientoColumn
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
			 public static string IdTipoMovimiento = @"idTipoMovimiento";
			 public static string Nombre = @"nombre";
						
		}
		#endregion
		
		#region Update PK Collections
		
        public void SetPKValues()
        {
                if (colAutMovimientoRecords != null)
                {
                    foreach (DalRis.AutMovimiento item in colAutMovimientoRecords)
                    {
                        if (item.IdTipoMovimiento != IdTipoMovimiento)
                        {
                            item.IdTipoMovimiento = IdTipoMovimiento;
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
