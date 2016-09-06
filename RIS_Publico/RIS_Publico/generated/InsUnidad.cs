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
	/// Strongly-typed collection for the InsUnidad class.
	/// </summary>
    [Serializable]
	public partial class InsUnidadCollection : ActiveList<InsUnidad, InsUnidadCollection>
	{	   
		public InsUnidadCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>InsUnidadCollection</returns>
		public InsUnidadCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                InsUnidad o = this[i];
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
	/// This is an ActiveRecord class which wraps the INS_Unidad table.
	/// </summary>
	[Serializable]
	public partial class InsUnidad : ActiveRecord<InsUnidad>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public InsUnidad()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public InsUnidad(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public InsUnidad(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public InsUnidad(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("INS_Unidad", TableType.Table, DataService.GetInstance("RisProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarIdUnidad = new TableSchema.TableColumn(schema);
				colvarIdUnidad.ColumnName = "idUnidad";
				colvarIdUnidad.DataType = DbType.Int32;
				colvarIdUnidad.MaxLength = 0;
				colvarIdUnidad.AutoIncrement = true;
				colvarIdUnidad.IsNullable = false;
				colvarIdUnidad.IsPrimaryKey = true;
				colvarIdUnidad.IsForeignKey = false;
				colvarIdUnidad.IsReadOnly = false;
				colvarIdUnidad.DefaultSetting = @"";
				colvarIdUnidad.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdUnidad);
				
				TableSchema.TableColumn colvarNombre = new TableSchema.TableColumn(schema);
				colvarNombre.ColumnName = "nombre";
				colvarNombre.DataType = DbType.AnsiString;
				colvarNombre.MaxLength = 50;
				colvarNombre.AutoIncrement = false;
				colvarNombre.IsNullable = false;
				colvarNombre.IsPrimaryKey = false;
				colvarNombre.IsForeignKey = false;
				colvarNombre.IsReadOnly = false;
				
						colvarNombre.DefaultSetting = @"('')";
				colvarNombre.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNombre);
				
				TableSchema.TableColumn colvarSimelaGrupo = new TableSchema.TableColumn(schema);
				colvarSimelaGrupo.ColumnName = "Simela_Grupo";
				colvarSimelaGrupo.DataType = DbType.Int32;
				colvarSimelaGrupo.MaxLength = 0;
				colvarSimelaGrupo.AutoIncrement = false;
				colvarSimelaGrupo.IsNullable = true;
				colvarSimelaGrupo.IsPrimaryKey = false;
				colvarSimelaGrupo.IsForeignKey = false;
				colvarSimelaGrupo.IsReadOnly = false;
				colvarSimelaGrupo.DefaultSetting = @"";
				colvarSimelaGrupo.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSimelaGrupo);
				
				TableSchema.TableColumn colvarSimelaRelacion = new TableSchema.TableColumn(schema);
				colvarSimelaRelacion.ColumnName = "Simela_Relacion";
				colvarSimelaRelacion.DataType = DbType.Decimal;
				colvarSimelaRelacion.MaxLength = 0;
				colvarSimelaRelacion.AutoIncrement = false;
				colvarSimelaRelacion.IsNullable = true;
				colvarSimelaRelacion.IsPrimaryKey = false;
				colvarSimelaRelacion.IsForeignKey = false;
				colvarSimelaRelacion.IsReadOnly = false;
				colvarSimelaRelacion.DefaultSetting = @"";
				colvarSimelaRelacion.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSimelaRelacion);
				
				TableSchema.TableColumn colvarBaja = new TableSchema.TableColumn(schema);
				colvarBaja.ColumnName = "baja";
				colvarBaja.DataType = DbType.Boolean;
				colvarBaja.MaxLength = 0;
				colvarBaja.AutoIncrement = false;
				colvarBaja.IsNullable = false;
				colvarBaja.IsPrimaryKey = false;
				colvarBaja.IsForeignKey = false;
				colvarBaja.IsReadOnly = false;
				
						colvarBaja.DefaultSetting = @"((0))";
				colvarBaja.ForeignKeyTableName = "";
				schema.Columns.Add(colvarBaja);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["RisProvider"].AddSchema("INS_Unidad",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("IdUnidad")]
		[Bindable(true)]
		public int IdUnidad 
		{
			get { return GetColumnValue<int>(Columns.IdUnidad); }
			set { SetColumnValue(Columns.IdUnidad, value); }
		}
		  
		[XmlAttribute("Nombre")]
		[Bindable(true)]
		public string Nombre 
		{
			get { return GetColumnValue<string>(Columns.Nombre); }
			set { SetColumnValue(Columns.Nombre, value); }
		}
		  
		[XmlAttribute("SimelaGrupo")]
		[Bindable(true)]
		public int? SimelaGrupo 
		{
			get { return GetColumnValue<int?>(Columns.SimelaGrupo); }
			set { SetColumnValue(Columns.SimelaGrupo, value); }
		}
		  
		[XmlAttribute("SimelaRelacion")]
		[Bindable(true)]
		public decimal? SimelaRelacion 
		{
			get { return GetColumnValue<decimal?>(Columns.SimelaRelacion); }
			set { SetColumnValue(Columns.SimelaRelacion, value); }
		}
		  
		[XmlAttribute("Baja")]
		[Bindable(true)]
		public bool Baja 
		{
			get { return GetColumnValue<bool>(Columns.Baja); }
			set { SetColumnValue(Columns.Baja, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varNombre,int? varSimelaGrupo,decimal? varSimelaRelacion,bool varBaja)
		{
			InsUnidad item = new InsUnidad();
			
			item.Nombre = varNombre;
			
			item.SimelaGrupo = varSimelaGrupo;
			
			item.SimelaRelacion = varSimelaRelacion;
			
			item.Baja = varBaja;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varIdUnidad,string varNombre,int? varSimelaGrupo,decimal? varSimelaRelacion,bool varBaja)
		{
			InsUnidad item = new InsUnidad();
			
				item.IdUnidad = varIdUnidad;
			
				item.Nombre = varNombre;
			
				item.SimelaGrupo = varSimelaGrupo;
			
				item.SimelaRelacion = varSimelaRelacion;
			
				item.Baja = varBaja;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn IdUnidadColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn NombreColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn SimelaGrupoColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn SimelaRelacionColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn BajaColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string IdUnidad = @"idUnidad";
			 public static string Nombre = @"nombre";
			 public static string SimelaGrupo = @"Simela_Grupo";
			 public static string SimelaRelacion = @"Simela_Relacion";
			 public static string Baja = @"baja";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
