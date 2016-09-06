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
	/// Strongly-typed collection for the AutCurso class.
	/// </summary>
    [Serializable]
	public partial class AutCursoCollection : ActiveList<AutCurso, AutCursoCollection>
	{	   
		public AutCursoCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>AutCursoCollection</returns>
		public AutCursoCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                AutCurso o = this[i];
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
	/// This is an ActiveRecord class which wraps the Aut_Cursos table.
	/// </summary>
	[Serializable]
	public partial class AutCurso : ActiveRecord<AutCurso>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public AutCurso()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public AutCurso(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public AutCurso(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public AutCurso(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("Aut_Cursos", TableType.Table, DataService.GetInstance("RisProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarIdCurso = new TableSchema.TableColumn(schema);
				colvarIdCurso.ColumnName = "idCurso";
				colvarIdCurso.DataType = DbType.Decimal;
				colvarIdCurso.MaxLength = 0;
				colvarIdCurso.AutoIncrement = true;
				colvarIdCurso.IsNullable = false;
				colvarIdCurso.IsPrimaryKey = true;
				colvarIdCurso.IsForeignKey = false;
				colvarIdCurso.IsReadOnly = false;
				colvarIdCurso.DefaultSetting = @"";
				colvarIdCurso.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdCurso);
				
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
				
				TableSchema.TableColumn colvarPuntos = new TableSchema.TableColumn(schema);
				colvarPuntos.ColumnName = "Puntos";
				colvarPuntos.DataType = DbType.Decimal;
				colvarPuntos.MaxLength = 0;
				colvarPuntos.AutoIncrement = false;
				colvarPuntos.IsNullable = true;
				colvarPuntos.IsPrimaryKey = false;
				colvarPuntos.IsForeignKey = false;
				colvarPuntos.IsReadOnly = false;
				colvarPuntos.DefaultSetting = @"";
				colvarPuntos.ForeignKeyTableName = "";
				schema.Columns.Add(colvarPuntos);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["RisProvider"].AddSchema("Aut_Cursos",schema);
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
		  
		[XmlAttribute("Nombre")]
		[Bindable(true)]
		public string Nombre 
		{
			get { return GetColumnValue<string>(Columns.Nombre); }
			set { SetColumnValue(Columns.Nombre, value); }
		}
		  
		[XmlAttribute("Puntos")]
		[Bindable(true)]
		public decimal? Puntos 
		{
			get { return GetColumnValue<decimal?>(Columns.Puntos); }
			set { SetColumnValue(Columns.Puntos, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varNombre,decimal? varPuntos)
		{
			AutCurso item = new AutCurso();
			
			item.Nombre = varNombre;
			
			item.Puntos = varPuntos;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(decimal varIdCurso,string varNombre,decimal? varPuntos)
		{
			AutCurso item = new AutCurso();
			
				item.IdCurso = varIdCurso;
			
				item.Nombre = varNombre;
			
				item.Puntos = varPuntos;
			
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
        
        
        
        public static TableSchema.TableColumn NombreColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn PuntosColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string IdCurso = @"idCurso";
			 public static string Nombre = @"Nombre";
			 public static string Puntos = @"Puntos";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
