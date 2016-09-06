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
	/// Strongly-typed collection for the VgiItem class.
	/// </summary>
    [Serializable]
	public partial class VgiItemCollection : ActiveList<VgiItem, VgiItemCollection>
	{	   
		public VgiItemCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>VgiItemCollection</returns>
		public VgiItemCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                VgiItem o = this[i];
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
	/// This is an ActiveRecord class which wraps the vgi_Items table.
	/// </summary>
	[Serializable]
	public partial class VgiItem : ActiveRecord<VgiItem>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public VgiItem()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public VgiItem(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public VgiItem(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public VgiItem(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("vgi_Items", TableType.Table, DataService.GetInstance("RisProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarIdItems = new TableSchema.TableColumn(schema);
				colvarIdItems.ColumnName = "idItems";
				colvarIdItems.DataType = DbType.Int32;
				colvarIdItems.MaxLength = 0;
				colvarIdItems.AutoIncrement = false;
				colvarIdItems.IsNullable = false;
				colvarIdItems.IsPrimaryKey = true;
				colvarIdItems.IsForeignKey = false;
				colvarIdItems.IsReadOnly = false;
				colvarIdItems.DefaultSetting = @"";
				colvarIdItems.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdItems);
				
				TableSchema.TableColumn colvarNombre = new TableSchema.TableColumn(schema);
				colvarNombre.ColumnName = "Nombre";
				colvarNombre.DataType = DbType.String;
				colvarNombre.MaxLength = 20;
				colvarNombre.AutoIncrement = false;
				colvarNombre.IsNullable = true;
				colvarNombre.IsPrimaryKey = false;
				colvarNombre.IsForeignKey = false;
				colvarNombre.IsReadOnly = false;
				colvarNombre.DefaultSetting = @"";
				colvarNombre.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNombre);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["RisProvider"].AddSchema("vgi_Items",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("IdItems")]
		[Bindable(true)]
		public int IdItems 
		{
			get { return GetColumnValue<int>(Columns.IdItems); }
			set { SetColumnValue(Columns.IdItems, value); }
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
        
		
		private DalRis.VgiItemsDatoCollection colVgiItemsDatos;
		public DalRis.VgiItemsDatoCollection VgiItemsDatos()
		{
			if(colVgiItemsDatos == null)
			{
				colVgiItemsDatos = new DalRis.VgiItemsDatoCollection().Where(VgiItemsDato.Columns.IdItems, IdItems).Load();
				colVgiItemsDatos.ListChanged += new ListChangedEventHandler(colVgiItemsDatos_ListChanged);
			}
			return colVgiItemsDatos;
		}
				
		void colVgiItemsDatos_ListChanged(object sender, ListChangedEventArgs e)
		{
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
		        // Set foreign key value
		        colVgiItemsDatos[e.NewIndex].IdItems = IdItems;
				colVgiItemsDatos.ListChanged += new ListChangedEventHandler(colVgiItemsDatos_ListChanged);
            }
		}
		#endregion
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(int varIdItems,string varNombre)
		{
			VgiItem item = new VgiItem();
			
			item.IdItems = varIdItems;
			
			item.Nombre = varNombre;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varIdItems,string varNombre)
		{
			VgiItem item = new VgiItem();
			
				item.IdItems = varIdItems;
			
				item.Nombre = varNombre;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn IdItemsColumn
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
			 public static string IdItems = @"idItems";
			 public static string Nombre = @"Nombre";
						
		}
		#endregion
		
		#region Update PK Collections
		
        public void SetPKValues()
        {
                if (colVgiItemsDatos != null)
                {
                    foreach (DalRis.VgiItemsDato item in colVgiItemsDatos)
                    {
                        if (item.IdItems != IdItems)
                        {
                            item.IdItems = IdItems;
                        }
                    }
               }
		}
        #endregion
    
        #region Deep Save
		
        public void DeepSave()
        {
            Save();
            
                if (colVgiItemsDatos != null)
                {
                    colVgiItemsDatos.SaveAll();
               }
		}
        #endregion
	}
}
