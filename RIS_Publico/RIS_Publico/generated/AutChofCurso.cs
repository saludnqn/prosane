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
	/// Strongly-typed collection for the AutChofCurso class.
	/// </summary>
    [Serializable]
	public partial class AutChofCursoCollection : ActiveList<AutChofCurso, AutChofCursoCollection>
	{	   
		public AutChofCursoCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>AutChofCursoCollection</returns>
		public AutChofCursoCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                AutChofCurso o = this[i];
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
	/// This is an ActiveRecord class which wraps the Aut_ChofCursos table.
	/// </summary>
	[Serializable]
	public partial class AutChofCurso : ActiveRecord<AutChofCurso>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public AutChofCurso()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public AutChofCurso(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public AutChofCurso(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public AutChofCurso(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("Aut_ChofCursos", TableType.Table, DataService.GetInstance("RisProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarIdCurso = new TableSchema.TableColumn(schema);
				colvarIdCurso.ColumnName = "idCurso";
				colvarIdCurso.DataType = DbType.Decimal;
				colvarIdCurso.MaxLength = 0;
				colvarIdCurso.AutoIncrement = false;
				colvarIdCurso.IsNullable = false;
				colvarIdCurso.IsPrimaryKey = true;
				colvarIdCurso.IsForeignKey = false;
				colvarIdCurso.IsReadOnly = false;
				colvarIdCurso.DefaultSetting = @"";
				colvarIdCurso.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdCurso);
				
				TableSchema.TableColumn colvarIdChofer = new TableSchema.TableColumn(schema);
				colvarIdChofer.ColumnName = "idChofer";
				colvarIdChofer.DataType = DbType.Decimal;
				colvarIdChofer.MaxLength = 0;
				colvarIdChofer.AutoIncrement = false;
				colvarIdChofer.IsNullable = false;
				colvarIdChofer.IsPrimaryKey = true;
				colvarIdChofer.IsForeignKey = false;
				colvarIdChofer.IsReadOnly = false;
				colvarIdChofer.DefaultSetting = @"";
				colvarIdChofer.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdChofer);
				
				TableSchema.TableColumn colvarAño = new TableSchema.TableColumn(schema);
				colvarAño.ColumnName = "Año";
				colvarAño.DataType = DbType.Decimal;
				colvarAño.MaxLength = 0;
				colvarAño.AutoIncrement = false;
				colvarAño.IsNullable = true;
				colvarAño.IsPrimaryKey = false;
				colvarAño.IsForeignKey = false;
				colvarAño.IsReadOnly = false;
				colvarAño.DefaultSetting = @"";
				colvarAño.ForeignKeyTableName = "";
				schema.Columns.Add(colvarAño);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["RisProvider"].AddSchema("Aut_ChofCursos",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("IdCurso")]
		[Bindable(true)]
		public decimal IdCurso 
		{
			get { return GetColumnValue<decimal>(Columns.IdCurso); }
			set { SetColumnValue(Columns.IdCurso, value); }
		}
		  
		[XmlAttribute("IdChofer")]
		[Bindable(true)]
		public decimal IdChofer 
		{
			get { return GetColumnValue<decimal>(Columns.IdChofer); }
			set { SetColumnValue(Columns.IdChofer, value); }
		}
		  
		[XmlAttribute("Año")]
		[Bindable(true)]
		public decimal? Año 
		{
			get { return GetColumnValue<decimal?>(Columns.Año); }
			set { SetColumnValue(Columns.Año, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(decimal varIdCurso,decimal varIdChofer,decimal? varAño)
		{
			AutChofCurso item = new AutChofCurso();
			
			item.IdCurso = varIdCurso;
			
			item.IdChofer = varIdChofer;
			
			item.Año = varAño;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(decimal varIdCurso,decimal varIdChofer,decimal? varAño)
		{
			AutChofCurso item = new AutChofCurso();
			
				item.IdCurso = varIdCurso;
			
				item.IdChofer = varIdChofer;
			
				item.Año = varAño;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn IdCursoColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn IdChoferColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn AñoColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string IdCurso = @"idCurso";
			 public static string IdChofer = @"idChofer";
			 public static string Año = @"Año";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
