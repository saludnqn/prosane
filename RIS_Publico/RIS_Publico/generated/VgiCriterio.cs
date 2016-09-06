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
	/// Strongly-typed collection for the VgiCriterio class.
	/// </summary>
    [Serializable]
	public partial class VgiCriterioCollection : ActiveList<VgiCriterio, VgiCriterioCollection>
	{	   
		public VgiCriterioCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>VgiCriterioCollection</returns>
		public VgiCriterioCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                VgiCriterio o = this[i];
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
	/// This is an ActiveRecord class which wraps the vgi_Criterios table.
	/// </summary>
	[Serializable]
	public partial class VgiCriterio : ActiveRecord<VgiCriterio>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public VgiCriterio()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public VgiCriterio(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public VgiCriterio(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public VgiCriterio(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("vgi_Criterios", TableType.Table, DataService.GetInstance("RisProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarIdVGICriterios = new TableSchema.TableColumn(schema);
				colvarIdVGICriterios.ColumnName = "idVGICriterios";
				colvarIdVGICriterios.DataType = DbType.Int32;
				colvarIdVGICriterios.MaxLength = 0;
				colvarIdVGICriterios.AutoIncrement = true;
				colvarIdVGICriterios.IsNullable = false;
				colvarIdVGICriterios.IsPrimaryKey = true;
				colvarIdVGICriterios.IsForeignKey = false;
				colvarIdVGICriterios.IsReadOnly = false;
				colvarIdVGICriterios.DefaultSetting = @"";
				colvarIdVGICriterios.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdVGICriterios);
				
				TableSchema.TableColumn colvarIdVGIDato = new TableSchema.TableColumn(schema);
				colvarIdVGIDato.ColumnName = "idVGIDato";
				colvarIdVGIDato.DataType = DbType.Int32;
				colvarIdVGIDato.MaxLength = 0;
				colvarIdVGIDato.AutoIncrement = false;
				colvarIdVGIDato.IsNullable = false;
				colvarIdVGIDato.IsPrimaryKey = false;
				colvarIdVGIDato.IsForeignKey = false;
				colvarIdVGIDato.IsReadOnly = false;
				colvarIdVGIDato.DefaultSetting = @"";
				colvarIdVGIDato.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdVGIDato);
				
				TableSchema.TableColumn colvarIdVGICInterconsultaItems = new TableSchema.TableColumn(schema);
				colvarIdVGICInterconsultaItems.ColumnName = "idVGICInterconsultaItems";
				colvarIdVGICInterconsultaItems.DataType = DbType.Int32;
				colvarIdVGICInterconsultaItems.MaxLength = 0;
				colvarIdVGICInterconsultaItems.AutoIncrement = false;
				colvarIdVGICInterconsultaItems.IsNullable = true;
				colvarIdVGICInterconsultaItems.IsPrimaryKey = false;
				colvarIdVGICInterconsultaItems.IsForeignKey = false;
				colvarIdVGICInterconsultaItems.IsReadOnly = false;
				colvarIdVGICInterconsultaItems.DefaultSetting = @"";
				colvarIdVGICInterconsultaItems.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdVGICInterconsultaItems);
				
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
				DataService.Providers["RisProvider"].AddSchema("vgi_Criterios",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("IdVGICriterios")]
		[Bindable(true)]
		public int IdVGICriterios 
		{
			get { return GetColumnValue<int>(Columns.IdVGICriterios); }
			set { SetColumnValue(Columns.IdVGICriterios, value); }
		}
		  
		[XmlAttribute("IdVGIDato")]
		[Bindable(true)]
		public int IdVGIDato 
		{
			get { return GetColumnValue<int>(Columns.IdVGIDato); }
			set { SetColumnValue(Columns.IdVGIDato, value); }
		}
		  
		[XmlAttribute("IdVGICInterconsultaItems")]
		[Bindable(true)]
		public int? IdVGICInterconsultaItems 
		{
			get { return GetColumnValue<int?>(Columns.IdVGICInterconsultaItems); }
			set { SetColumnValue(Columns.IdVGICInterconsultaItems, value); }
		}
		  
		[XmlAttribute("Valor")]
		[Bindable(true)]
		public int? Valor 
		{
			get { return GetColumnValue<int?>(Columns.Valor); }
			set { SetColumnValue(Columns.Valor, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(int varIdVGIDato,int? varIdVGICInterconsultaItems,int? varValor)
		{
			VgiCriterio item = new VgiCriterio();
			
			item.IdVGIDato = varIdVGIDato;
			
			item.IdVGICInterconsultaItems = varIdVGICInterconsultaItems;
			
			item.Valor = varValor;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varIdVGICriterios,int varIdVGIDato,int? varIdVGICInterconsultaItems,int? varValor)
		{
			VgiCriterio item = new VgiCriterio();
			
				item.IdVGICriterios = varIdVGICriterios;
			
				item.IdVGIDato = varIdVGIDato;
			
				item.IdVGICInterconsultaItems = varIdVGICInterconsultaItems;
			
				item.Valor = varValor;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn IdVGICriteriosColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn IdVGIDatoColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn IdVGICInterconsultaItemsColumn
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
			 public static string IdVGICriterios = @"idVGICriterios";
			 public static string IdVGIDato = @"idVGIDato";
			 public static string IdVGICInterconsultaItems = @"idVGICInterconsultaItems";
			 public static string Valor = @"Valor";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
