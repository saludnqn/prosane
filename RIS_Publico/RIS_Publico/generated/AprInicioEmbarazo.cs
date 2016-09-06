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
	/// Strongly-typed collection for the AprInicioEmbarazo class.
	/// </summary>
    [Serializable]
	public partial class AprInicioEmbarazoCollection : ActiveList<AprInicioEmbarazo, AprInicioEmbarazoCollection>
	{	   
		public AprInicioEmbarazoCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>AprInicioEmbarazoCollection</returns>
		public AprInicioEmbarazoCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                AprInicioEmbarazo o = this[i];
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
	/// This is an ActiveRecord class which wraps the APR_InicioEmbarazo table.
	/// </summary>
	[Serializable]
	public partial class AprInicioEmbarazo : ActiveRecord<AprInicioEmbarazo>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public AprInicioEmbarazo()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public AprInicioEmbarazo(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public AprInicioEmbarazo(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public AprInicioEmbarazo(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("APR_InicioEmbarazo", TableType.Table, DataService.GetInstance("RisProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarIdInicioEmabarazo = new TableSchema.TableColumn(schema);
				colvarIdInicioEmabarazo.ColumnName = "idInicioEmabarazo";
				colvarIdInicioEmabarazo.DataType = DbType.Int32;
				colvarIdInicioEmabarazo.MaxLength = 0;
				colvarIdInicioEmabarazo.AutoIncrement = true;
				colvarIdInicioEmabarazo.IsNullable = false;
				colvarIdInicioEmabarazo.IsPrimaryKey = true;
				colvarIdInicioEmabarazo.IsForeignKey = false;
				colvarIdInicioEmabarazo.IsReadOnly = false;
				colvarIdInicioEmabarazo.DefaultSetting = @"";
				colvarIdInicioEmabarazo.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdInicioEmabarazo);
				
				TableSchema.TableColumn colvarNombre = new TableSchema.TableColumn(schema);
				colvarNombre.ColumnName = "nombre";
				colvarNombre.DataType = DbType.AnsiString;
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
				DataService.Providers["RisProvider"].AddSchema("APR_InicioEmbarazo",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("IdInicioEmabarazo")]
		[Bindable(true)]
		public int IdInicioEmabarazo 
		{
			get { return GetColumnValue<int>(Columns.IdInicioEmabarazo); }
			set { SetColumnValue(Columns.IdInicioEmabarazo, value); }
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
			AprInicioEmbarazo item = new AprInicioEmbarazo();
			
			item.Nombre = varNombre;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varIdInicioEmabarazo,string varNombre)
		{
			AprInicioEmbarazo item = new AprInicioEmbarazo();
			
				item.IdInicioEmabarazo = varIdInicioEmabarazo;
			
				item.Nombre = varNombre;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn IdInicioEmabarazoColumn
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
			 public static string IdInicioEmabarazo = @"idInicioEmabarazo";
			 public static string Nombre = @"nombre";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
