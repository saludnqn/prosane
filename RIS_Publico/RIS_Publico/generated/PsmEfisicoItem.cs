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
	/// Strongly-typed collection for the PsmEfisicoItem class.
	/// </summary>
    [Serializable]
	public partial class PsmEfisicoItemCollection : ActiveList<PsmEfisicoItem, PsmEfisicoItemCollection>
	{	   
		public PsmEfisicoItemCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>PsmEfisicoItemCollection</returns>
		public PsmEfisicoItemCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                PsmEfisicoItem o = this[i];
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
	/// This is an ActiveRecord class which wraps the PSM_EfisicoItems table.
	/// </summary>
	[Serializable]
	public partial class PsmEfisicoItem : ActiveRecord<PsmEfisicoItem>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public PsmEfisicoItem()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public PsmEfisicoItem(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public PsmEfisicoItem(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public PsmEfisicoItem(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("PSM_EfisicoItems", TableType.Table, DataService.GetInstance("RisProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarIdPSMEfisicoItems = new TableSchema.TableColumn(schema);
				colvarIdPSMEfisicoItems.ColumnName = "idPSMEfisicoItems";
				colvarIdPSMEfisicoItems.DataType = DbType.Decimal;
				colvarIdPSMEfisicoItems.MaxLength = 0;
				colvarIdPSMEfisicoItems.AutoIncrement = false;
				colvarIdPSMEfisicoItems.IsNullable = false;
				colvarIdPSMEfisicoItems.IsPrimaryKey = true;
				colvarIdPSMEfisicoItems.IsForeignKey = false;
				colvarIdPSMEfisicoItems.IsReadOnly = false;
				colvarIdPSMEfisicoItems.DefaultSetting = @"";
				colvarIdPSMEfisicoItems.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdPSMEfisicoItems);
				
				TableSchema.TableColumn colvarNombre = new TableSchema.TableColumn(schema);
				colvarNombre.ColumnName = "Nombre";
				colvarNombre.DataType = DbType.String;
				colvarNombre.MaxLength = 10;
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
				DataService.Providers["RisProvider"].AddSchema("PSM_EfisicoItems",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("IdPSMEfisicoItems")]
		[Bindable(true)]
		public decimal IdPSMEfisicoItems 
		{
			get { return GetColumnValue<decimal>(Columns.IdPSMEfisicoItems); }
			set { SetColumnValue(Columns.IdPSMEfisicoItems, value); }
		}
		  
		[XmlAttribute("Nombre")]
		[Bindable(true)]
		public string Nombre 
		{
			get { return GetColumnValue<string>(Columns.Nombre); }
			set { SetColumnValue(Columns.Nombre, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(decimal varIdPSMEfisicoItems,string varNombre)
		{
			PsmEfisicoItem item = new PsmEfisicoItem();
			
			item.IdPSMEfisicoItems = varIdPSMEfisicoItems;
			
			item.Nombre = varNombre;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(decimal varIdPSMEfisicoItems,string varNombre)
		{
			PsmEfisicoItem item = new PsmEfisicoItem();
			
				item.IdPSMEfisicoItems = varIdPSMEfisicoItems;
			
				item.Nombre = varNombre;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn IdPSMEfisicoItemsColumn
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
			 public static string IdPSMEfisicoItems = @"idPSMEfisicoItems";
			 public static string Nombre = @"Nombre";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
