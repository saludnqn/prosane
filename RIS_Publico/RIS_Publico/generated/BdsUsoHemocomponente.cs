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
	/// Strongly-typed collection for the BdsUsoHemocomponente class.
	/// </summary>
    [Serializable]
	public partial class BdsUsoHemocomponenteCollection : ActiveList<BdsUsoHemocomponente, BdsUsoHemocomponenteCollection>
	{	   
		public BdsUsoHemocomponenteCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>BdsUsoHemocomponenteCollection</returns>
		public BdsUsoHemocomponenteCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                BdsUsoHemocomponente o = this[i];
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
	/// This is an ActiveRecord class which wraps the BDS_UsoHemocomponente table.
	/// </summary>
	[Serializable]
	public partial class BdsUsoHemocomponente : ActiveRecord<BdsUsoHemocomponente>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public BdsUsoHemocomponente()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public BdsUsoHemocomponente(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public BdsUsoHemocomponente(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public BdsUsoHemocomponente(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("BDS_UsoHemocomponente", TableType.Table, DataService.GetInstance("RisProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarIdUsoHemocomponente = new TableSchema.TableColumn(schema);
				colvarIdUsoHemocomponente.ColumnName = "idUsoHemocomponente";
				colvarIdUsoHemocomponente.DataType = DbType.Int32;
				colvarIdUsoHemocomponente.MaxLength = 0;
				colvarIdUsoHemocomponente.AutoIncrement = true;
				colvarIdUsoHemocomponente.IsNullable = false;
				colvarIdUsoHemocomponente.IsPrimaryKey = true;
				colvarIdUsoHemocomponente.IsForeignKey = false;
				colvarIdUsoHemocomponente.IsReadOnly = false;
				colvarIdUsoHemocomponente.DefaultSetting = @"";
				colvarIdUsoHemocomponente.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdUsoHemocomponente);
				
				TableSchema.TableColumn colvarNombre = new TableSchema.TableColumn(schema);
				colvarNombre.ColumnName = "nombre";
				colvarNombre.DataType = DbType.AnsiStringFixedLength;
				colvarNombre.MaxLength = 30;
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
				DataService.Providers["RisProvider"].AddSchema("BDS_UsoHemocomponente",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("IdUsoHemocomponente")]
		[Bindable(true)]
		public int IdUsoHemocomponente 
		{
			get { return GetColumnValue<int>(Columns.IdUsoHemocomponente); }
			set { SetColumnValue(Columns.IdUsoHemocomponente, value); }
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
		public static void Insert(string varNombre)
		{
			BdsUsoHemocomponente item = new BdsUsoHemocomponente();
			
			item.Nombre = varNombre;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varIdUsoHemocomponente,string varNombre)
		{
			BdsUsoHemocomponente item = new BdsUsoHemocomponente();
			
				item.IdUsoHemocomponente = varIdUsoHemocomponente;
			
				item.Nombre = varNombre;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn IdUsoHemocomponenteColumn
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
			 public static string IdUsoHemocomponente = @"idUsoHemocomponente";
			 public static string Nombre = @"nombre";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
