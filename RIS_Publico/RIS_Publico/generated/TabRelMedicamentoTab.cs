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
	/// Strongly-typed collection for the TabRelMedicamentoTab class.
	/// </summary>
    [Serializable]
	public partial class TabRelMedicamentoTabCollection : ActiveList<TabRelMedicamentoTab, TabRelMedicamentoTabCollection>
	{	   
		public TabRelMedicamentoTabCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>TabRelMedicamentoTabCollection</returns>
		public TabRelMedicamentoTabCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                TabRelMedicamentoTab o = this[i];
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
	/// This is an ActiveRecord class which wraps the TAB_RelMedicamentoTab table.
	/// </summary>
	[Serializable]
	public partial class TabRelMedicamentoTab : ActiveRecord<TabRelMedicamentoTab>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public TabRelMedicamentoTab()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public TabRelMedicamentoTab(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public TabRelMedicamentoTab(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public TabRelMedicamentoTab(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("TAB_RelMedicamentoTab", TableType.Table, DataService.GetInstance("RisProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarIdRelMedicamentoTab = new TableSchema.TableColumn(schema);
				colvarIdRelMedicamentoTab.ColumnName = "idRelMedicamentoTab";
				colvarIdRelMedicamentoTab.DataType = DbType.Int32;
				colvarIdRelMedicamentoTab.MaxLength = 0;
				colvarIdRelMedicamentoTab.AutoIncrement = true;
				colvarIdRelMedicamentoTab.IsNullable = false;
				colvarIdRelMedicamentoTab.IsPrimaryKey = true;
				colvarIdRelMedicamentoTab.IsForeignKey = false;
				colvarIdRelMedicamentoTab.IsReadOnly = false;
				colvarIdRelMedicamentoTab.DefaultSetting = @"";
				colvarIdRelMedicamentoTab.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdRelMedicamentoTab);
				
				TableSchema.TableColumn colvarIdMedicamento = new TableSchema.TableColumn(schema);
				colvarIdMedicamento.ColumnName = "idMedicamento";
				colvarIdMedicamento.DataType = DbType.Int32;
				colvarIdMedicamento.MaxLength = 0;
				colvarIdMedicamento.AutoIncrement = false;
				colvarIdMedicamento.IsNullable = false;
				colvarIdMedicamento.IsPrimaryKey = false;
				colvarIdMedicamento.IsForeignKey = true;
				colvarIdMedicamento.IsReadOnly = false;
				
						colvarIdMedicamento.DefaultSetting = @"((0))";
				
					colvarIdMedicamento.ForeignKeyTableName = "Sys_Medicamento";
				schema.Columns.Add(colvarIdMedicamento);
				
				TableSchema.TableColumn colvarIdControl = new TableSchema.TableColumn(schema);
				colvarIdControl.ColumnName = "idControl";
				colvarIdControl.DataType = DbType.Int32;
				colvarIdControl.MaxLength = 0;
				colvarIdControl.AutoIncrement = false;
				colvarIdControl.IsNullable = false;
				colvarIdControl.IsPrimaryKey = false;
				colvarIdControl.IsForeignKey = true;
				colvarIdControl.IsReadOnly = false;
				
						colvarIdControl.DefaultSetting = @"((0))";
				
					colvarIdControl.ForeignKeyTableName = "TAB_Control";
				schema.Columns.Add(colvarIdControl);
				
				TableSchema.TableColumn colvarCantidad = new TableSchema.TableColumn(schema);
				colvarCantidad.ColumnName = "cantidad";
				colvarCantidad.DataType = DbType.Int32;
				colvarCantidad.MaxLength = 0;
				colvarCantidad.AutoIncrement = false;
				colvarCantidad.IsNullable = false;
				colvarCantidad.IsPrimaryKey = false;
				colvarCantidad.IsForeignKey = false;
				colvarCantidad.IsReadOnly = false;
				
						colvarCantidad.DefaultSetting = @"((0))";
				colvarCantidad.ForeignKeyTableName = "";
				schema.Columns.Add(colvarCantidad);
				
				TableSchema.TableColumn colvarUnidad = new TableSchema.TableColumn(schema);
				colvarUnidad.ColumnName = "unidad";
				colvarUnidad.DataType = DbType.AnsiString;
				colvarUnidad.MaxLength = 50;
				colvarUnidad.AutoIncrement = false;
				colvarUnidad.IsNullable = false;
				colvarUnidad.IsPrimaryKey = false;
				colvarUnidad.IsForeignKey = false;
				colvarUnidad.IsReadOnly = false;
				
						colvarUnidad.DefaultSetting = @"('')";
				colvarUnidad.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUnidad);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["RisProvider"].AddSchema("TAB_RelMedicamentoTab",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("IdRelMedicamentoTab")]
		[Bindable(true)]
		public int IdRelMedicamentoTab 
		{
			get { return GetColumnValue<int>(Columns.IdRelMedicamentoTab); }
			set { SetColumnValue(Columns.IdRelMedicamentoTab, value); }
		}
		  
		[XmlAttribute("IdMedicamento")]
		[Bindable(true)]
		public int IdMedicamento 
		{
			get { return GetColumnValue<int>(Columns.IdMedicamento); }
			set { SetColumnValue(Columns.IdMedicamento, value); }
		}
		  
		[XmlAttribute("IdControl")]
		[Bindable(true)]
		public int IdControl 
		{
			get { return GetColumnValue<int>(Columns.IdControl); }
			set { SetColumnValue(Columns.IdControl, value); }
		}
		  
		[XmlAttribute("Cantidad")]
		[Bindable(true)]
		public int Cantidad 
		{
			get { return GetColumnValue<int>(Columns.Cantidad); }
			set { SetColumnValue(Columns.Cantidad, value); }
		}
		  
		[XmlAttribute("Unidad")]
		[Bindable(true)]
		public string Unidad 
		{
			get { return GetColumnValue<string>(Columns.Unidad); }
			set { SetColumnValue(Columns.Unidad, value); }
		}
		
		#endregion
		
		
			
		
		#region ForeignKey Properties
		
		/// <summary>
		/// Returns a SysMedicamento ActiveRecord object related to this TabRelMedicamentoTab
		/// 
		/// </summary>
		public DalRis.SysMedicamento SysMedicamento
		{
			get { return DalRis.SysMedicamento.FetchByID(this.IdMedicamento); }
			set { SetColumnValue("idMedicamento", value.IdMedicamento); }
		}
		
		
		/// <summary>
		/// Returns a TabControl ActiveRecord object related to this TabRelMedicamentoTab
		/// 
		/// </summary>
		public DalRis.TabControl TabControl
		{
			get { return DalRis.TabControl.FetchByID(this.IdControl); }
			set { SetColumnValue("idControl", value.IdControl); }
		}
		
		
		#endregion
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(int varIdMedicamento,int varIdControl,int varCantidad,string varUnidad)
		{
			TabRelMedicamentoTab item = new TabRelMedicamentoTab();
			
			item.IdMedicamento = varIdMedicamento;
			
			item.IdControl = varIdControl;
			
			item.Cantidad = varCantidad;
			
			item.Unidad = varUnidad;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varIdRelMedicamentoTab,int varIdMedicamento,int varIdControl,int varCantidad,string varUnidad)
		{
			TabRelMedicamentoTab item = new TabRelMedicamentoTab();
			
				item.IdRelMedicamentoTab = varIdRelMedicamentoTab;
			
				item.IdMedicamento = varIdMedicamento;
			
				item.IdControl = varIdControl;
			
				item.Cantidad = varCantidad;
			
				item.Unidad = varUnidad;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn IdRelMedicamentoTabColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn IdMedicamentoColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn IdControlColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn CantidadColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn UnidadColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string IdRelMedicamentoTab = @"idRelMedicamentoTab";
			 public static string IdMedicamento = @"idMedicamento";
			 public static string IdControl = @"idControl";
			 public static string Cantidad = @"cantidad";
			 public static string Unidad = @"unidad";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
