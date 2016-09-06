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
// <auto-generated />
namespace DalRis
{
	/// <summary>
	/// Strongly-typed collection for the VgiCInterconsultaItems1 class.
	/// </summary>
    [Serializable]
	public partial class VgiCInterconsultaItems1Collection : ActiveList<VgiCInterconsultaItems1, VgiCInterconsultaItems1Collection>
	{	   
		public VgiCInterconsultaItems1Collection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>VgiCInterconsultaItems1Collection</returns>
		public VgiCInterconsultaItems1Collection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                VgiCInterconsultaItems1 o = this[i];
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
	/// This is an ActiveRecord class which wraps the VGI_CInterconsultaItems1 table.
	/// </summary>
	[Serializable]
	public partial class VgiCInterconsultaItems1 : ActiveRecord<VgiCInterconsultaItems1>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public VgiCInterconsultaItems1()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public VgiCInterconsultaItems1(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public VgiCInterconsultaItems1(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public VgiCInterconsultaItems1(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("VGI_CInterconsultaItems1", TableType.Table, DataService.GetInstance("RisProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarVGICriteriosInterconsultaItems = new TableSchema.TableColumn(schema);
				colvarVGICriteriosInterconsultaItems.ColumnName = "VGICriteriosInterconsultaItems";
				colvarVGICriteriosInterconsultaItems.DataType = DbType.Decimal;
				colvarVGICriteriosInterconsultaItems.MaxLength = 0;
				colvarVGICriteriosInterconsultaItems.AutoIncrement = false;
				colvarVGICriteriosInterconsultaItems.IsNullable = false;
				colvarVGICriteriosInterconsultaItems.IsPrimaryKey = true;
				colvarVGICriteriosInterconsultaItems.IsForeignKey = false;
				colvarVGICriteriosInterconsultaItems.IsReadOnly = false;
				colvarVGICriteriosInterconsultaItems.DefaultSetting = @"";
				colvarVGICriteriosInterconsultaItems.ForeignKeyTableName = "";
				schema.Columns.Add(colvarVGICriteriosInterconsultaItems);
				
				TableSchema.TableColumn colvarNombre = new TableSchema.TableColumn(schema);
				colvarNombre.ColumnName = "Nombre";
				colvarNombre.DataType = DbType.String;
				colvarNombre.MaxLength = 100;
				colvarNombre.AutoIncrement = false;
				colvarNombre.IsNullable = true;
				colvarNombre.IsPrimaryKey = false;
				colvarNombre.IsForeignKey = false;
				colvarNombre.IsReadOnly = false;
				colvarNombre.DefaultSetting = @"";
				colvarNombre.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNombre);
				
				TableSchema.TableColumn colvarVgiCInterconsulta = new TableSchema.TableColumn(schema);
				colvarVgiCInterconsulta.ColumnName = "VGI_CInterconsulta";
				colvarVgiCInterconsulta.DataType = DbType.Int32;
				colvarVgiCInterconsulta.MaxLength = 0;
				colvarVgiCInterconsulta.AutoIncrement = false;
				colvarVgiCInterconsulta.IsNullable = true;
				colvarVgiCInterconsulta.IsPrimaryKey = false;
				colvarVgiCInterconsulta.IsForeignKey = false;
				colvarVgiCInterconsulta.IsReadOnly = false;
				colvarVgiCInterconsulta.DefaultSetting = @"";
				colvarVgiCInterconsulta.ForeignKeyTableName = "";
				schema.Columns.Add(colvarVgiCInterconsulta);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["RisProvider"].AddSchema("VGI_CInterconsultaItems1",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("VGICriteriosInterconsultaItems")]
		[Bindable(true)]
		public decimal VGICriteriosInterconsultaItems 
		{
			get { return GetColumnValue<decimal>(Columns.VGICriteriosInterconsultaItems); }
			set { SetColumnValue(Columns.VGICriteriosInterconsultaItems, value); }
		}
		  
		[XmlAttribute("Nombre")]
		[Bindable(true)]
		public string Nombre 
		{
			get { return GetColumnValue<string>(Columns.Nombre); }
			set { SetColumnValue(Columns.Nombre, value); }
		}
		  
		[XmlAttribute("VgiCInterconsulta")]
		[Bindable(true)]
		public int? VgiCInterconsulta 
		{
			get { return GetColumnValue<int?>(Columns.VgiCInterconsulta); }
			set { SetColumnValue(Columns.VgiCInterconsulta, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(decimal varVGICriteriosInterconsultaItems,string varNombre,int? varVgiCInterconsulta)
		{
			VgiCInterconsultaItems1 item = new VgiCInterconsultaItems1();
			
			item.VGICriteriosInterconsultaItems = varVGICriteriosInterconsultaItems;
			
			item.Nombre = varNombre;
			
			item.VgiCInterconsulta = varVgiCInterconsulta;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(decimal varVGICriteriosInterconsultaItems,string varNombre,int? varVgiCInterconsulta)
		{
			VgiCInterconsultaItems1 item = new VgiCInterconsultaItems1();
			
				item.VGICriteriosInterconsultaItems = varVGICriteriosInterconsultaItems;
			
				item.Nombre = varNombre;
			
				item.VgiCInterconsulta = varVgiCInterconsulta;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn VGICriteriosInterconsultaItemsColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn NombreColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn VgiCInterconsultaColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string VGICriteriosInterconsultaItems = @"VGICriteriosInterconsultaItems";
			 public static string Nombre = @"Nombre";
			 public static string VgiCInterconsulta = @"VGI_CInterconsulta";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}