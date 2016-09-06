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
	/// Strongly-typed collection for the VgiItemsDato class.
	/// </summary>
    [Serializable]
	public partial class VgiItemsDatoCollection : ActiveList<VgiItemsDato, VgiItemsDatoCollection>
	{	   
		public VgiItemsDatoCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>VgiItemsDatoCollection</returns>
		public VgiItemsDatoCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                VgiItemsDato o = this[i];
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
	/// This is an ActiveRecord class which wraps the vgi_ItemsDatos table.
	/// </summary>
	[Serializable]
	public partial class VgiItemsDato : ActiveRecord<VgiItemsDato>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public VgiItemsDato()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public VgiItemsDato(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public VgiItemsDato(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public VgiItemsDato(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("vgi_ItemsDatos", TableType.Table, DataService.GetInstance("RisProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarIdVGItemDatos = new TableSchema.TableColumn(schema);
				colvarIdVGItemDatos.ColumnName = "idVGItemDatos";
				colvarIdVGItemDatos.DataType = DbType.Int32;
				colvarIdVGItemDatos.MaxLength = 0;
				colvarIdVGItemDatos.AutoIncrement = false;
				colvarIdVGItemDatos.IsNullable = false;
				colvarIdVGItemDatos.IsPrimaryKey = true;
				colvarIdVGItemDatos.IsForeignKey = false;
				colvarIdVGItemDatos.IsReadOnly = false;
				colvarIdVGItemDatos.DefaultSetting = @"";
				colvarIdVGItemDatos.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdVGItemDatos);
				
				TableSchema.TableColumn colvarIdVGIDatos = new TableSchema.TableColumn(schema);
				colvarIdVGIDatos.ColumnName = "idVGIDatos";
				colvarIdVGIDatos.DataType = DbType.Int32;
				colvarIdVGIDatos.MaxLength = 0;
				colvarIdVGIDatos.AutoIncrement = false;
				colvarIdVGIDatos.IsNullable = true;
				colvarIdVGIDatos.IsPrimaryKey = false;
				colvarIdVGIDatos.IsForeignKey = true;
				colvarIdVGIDatos.IsReadOnly = false;
				colvarIdVGIDatos.DefaultSetting = @"";
				
					colvarIdVGIDatos.ForeignKeyTableName = "VGI_Datos";
				schema.Columns.Add(colvarIdVGIDatos);
				
				TableSchema.TableColumn colvarIdItems = new TableSchema.TableColumn(schema);
				colvarIdItems.ColumnName = "idItems";
				colvarIdItems.DataType = DbType.Int32;
				colvarIdItems.MaxLength = 0;
				colvarIdItems.AutoIncrement = false;
				colvarIdItems.IsNullable = true;
				colvarIdItems.IsPrimaryKey = false;
				colvarIdItems.IsForeignKey = true;
				colvarIdItems.IsReadOnly = false;
				colvarIdItems.DefaultSetting = @"";
				
					colvarIdItems.ForeignKeyTableName = "vgi_Items";
				schema.Columns.Add(colvarIdItems);
				
				TableSchema.TableColumn colvarValor = new TableSchema.TableColumn(schema);
				colvarValor.ColumnName = "Valor";
				colvarValor.DataType = DbType.Int32;
				colvarValor.MaxLength = 0;
				colvarValor.AutoIncrement = false;
				colvarValor.IsNullable = true;
				colvarValor.IsPrimaryKey = false;
				colvarValor.IsForeignKey = false;
				colvarValor.IsReadOnly = false;
				colvarValor.DefaultSetting = @"";
				colvarValor.ForeignKeyTableName = "";
				schema.Columns.Add(colvarValor);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["RisProvider"].AddSchema("vgi_ItemsDatos",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("IdVGItemDatos")]
		[Bindable(true)]
		public int IdVGItemDatos 
		{
			get { return GetColumnValue<int>(Columns.IdVGItemDatos); }
			set { SetColumnValue(Columns.IdVGItemDatos, value); }
		}
		  
		[XmlAttribute("IdVGIDatos")]
		[Bindable(true)]
		public int? IdVGIDatos 
		{
			get { return GetColumnValue<int?>(Columns.IdVGIDatos); }
			set { SetColumnValue(Columns.IdVGIDatos, value); }
		}
		  
		[XmlAttribute("IdItems")]
		[Bindable(true)]
		public int? IdItems 
		{
			get { return GetColumnValue<int?>(Columns.IdItems); }
			set { SetColumnValue(Columns.IdItems, value); }
		}
		  
		[XmlAttribute("Valor")]
		[Bindable(true)]
		public int? Valor 
		{
			get { return GetColumnValue<int?>(Columns.Valor); }
			set { SetColumnValue(Columns.Valor, value); }
		}
		
		#endregion
		
		
			
		
		#region ForeignKey Properties
		
		/// <summary>
		/// Returns a VgiItem ActiveRecord object related to this VgiItemsDato
		/// 
		/// </summary>
		public DalRis.VgiItem VgiItem
		{
			get { return DalRis.VgiItem.FetchByID(this.IdItems); }
			set { SetColumnValue("idItems", value.IdItems); }
		}
		
		
		/// <summary>
		/// Returns a VgiDato ActiveRecord object related to this VgiItemsDato
		/// 
		/// </summary>
		public DalRis.VgiDato VgiDato
		{
			get { return DalRis.VgiDato.FetchByID(this.IdVGIDatos); }
			set { SetColumnValue("idVGIDatos", value.IdVGIDato); }
		}
		
		
		#endregion
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(int varIdVGItemDatos,int? varIdVGIDatos,int? varIdItems,int? varValor)
		{
			VgiItemsDato item = new VgiItemsDato();
			
			item.IdVGItemDatos = varIdVGItemDatos;
			
			item.IdVGIDatos = varIdVGIDatos;
			
			item.IdItems = varIdItems;
			
			item.Valor = varValor;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varIdVGItemDatos,int? varIdVGIDatos,int? varIdItems,int? varValor)
		{
			VgiItemsDato item = new VgiItemsDato();
			
				item.IdVGItemDatos = varIdVGItemDatos;
			
				item.IdVGIDatos = varIdVGIDatos;
			
				item.IdItems = varIdItems;
			
				item.Valor = varValor;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn IdVGItemDatosColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn IdVGIDatosColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn IdItemsColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn ValorColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string IdVGItemDatos = @"idVGItemDatos";
			 public static string IdVGIDatos = @"idVGIDatos";
			 public static string IdItems = @"idItems";
			 public static string Valor = @"Valor";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
