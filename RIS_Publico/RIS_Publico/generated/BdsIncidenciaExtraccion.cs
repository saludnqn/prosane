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
	/// Strongly-typed collection for the BdsIncidenciaExtraccion class.
	/// </summary>
    [Serializable]
	public partial class BdsIncidenciaExtraccionCollection : ActiveList<BdsIncidenciaExtraccion, BdsIncidenciaExtraccionCollection>
	{	   
		public BdsIncidenciaExtraccionCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>BdsIncidenciaExtraccionCollection</returns>
		public BdsIncidenciaExtraccionCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                BdsIncidenciaExtraccion o = this[i];
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
	/// This is an ActiveRecord class which wraps the BDS_IncidenciaExtraccion table.
	/// </summary>
	[Serializable]
	public partial class BdsIncidenciaExtraccion : ActiveRecord<BdsIncidenciaExtraccion>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public BdsIncidenciaExtraccion()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public BdsIncidenciaExtraccion(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public BdsIncidenciaExtraccion(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public BdsIncidenciaExtraccion(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("BDS_IncidenciaExtraccion", TableType.Table, DataService.GetInstance("RisProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarIdIncidenciaExtraccion = new TableSchema.TableColumn(schema);
				colvarIdIncidenciaExtraccion.ColumnName = "idIncidenciaExtraccion";
				colvarIdIncidenciaExtraccion.DataType = DbType.Int32;
				colvarIdIncidenciaExtraccion.MaxLength = 0;
				colvarIdIncidenciaExtraccion.AutoIncrement = true;
				colvarIdIncidenciaExtraccion.IsNullable = false;
				colvarIdIncidenciaExtraccion.IsPrimaryKey = true;
				colvarIdIncidenciaExtraccion.IsForeignKey = false;
				colvarIdIncidenciaExtraccion.IsReadOnly = false;
				colvarIdIncidenciaExtraccion.DefaultSetting = @"";
				colvarIdIncidenciaExtraccion.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdIncidenciaExtraccion);
				
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
				DataService.Providers["RisProvider"].AddSchema("BDS_IncidenciaExtraccion",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("IdIncidenciaExtraccion")]
		[Bindable(true)]
		public int IdIncidenciaExtraccion 
		{
			get { return GetColumnValue<int>(Columns.IdIncidenciaExtraccion); }
			set { SetColumnValue(Columns.IdIncidenciaExtraccion, value); }
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
			BdsIncidenciaExtraccion item = new BdsIncidenciaExtraccion();
			
			item.Nombre = varNombre;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varIdIncidenciaExtraccion,string varNombre)
		{
			BdsIncidenciaExtraccion item = new BdsIncidenciaExtraccion();
			
				item.IdIncidenciaExtraccion = varIdIncidenciaExtraccion;
			
				item.Nombre = varNombre;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn IdIncidenciaExtraccionColumn
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
			 public static string IdIncidenciaExtraccion = @"idIncidenciaExtraccion";
			 public static string Nombre = @"nombre";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
