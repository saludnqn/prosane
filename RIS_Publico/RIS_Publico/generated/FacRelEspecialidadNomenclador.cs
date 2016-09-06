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
	/// Strongly-typed collection for the FacRelEspecialidadNomenclador class.
	/// </summary>
    [Serializable]
	public partial class FacRelEspecialidadNomencladorCollection : ActiveList<FacRelEspecialidadNomenclador, FacRelEspecialidadNomencladorCollection>
	{	   
		public FacRelEspecialidadNomencladorCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>FacRelEspecialidadNomencladorCollection</returns>
		public FacRelEspecialidadNomencladorCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                FacRelEspecialidadNomenclador o = this[i];
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
	/// This is an ActiveRecord class which wraps the FAC_RelEspecialidadNomenclador table.
	/// </summary>
	[Serializable]
	public partial class FacRelEspecialidadNomenclador : ActiveRecord<FacRelEspecialidadNomenclador>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public FacRelEspecialidadNomenclador()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public FacRelEspecialidadNomenclador(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public FacRelEspecialidadNomenclador(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public FacRelEspecialidadNomenclador(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("FAC_RelEspecialidadNomenclador", TableType.Table, DataService.GetInstance("RisProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarIdRelEspecialidadNomenclador = new TableSchema.TableColumn(schema);
				colvarIdRelEspecialidadNomenclador.ColumnName = "idRelEspecialidadNomenclador";
				colvarIdRelEspecialidadNomenclador.DataType = DbType.Int32;
				colvarIdRelEspecialidadNomenclador.MaxLength = 0;
				colvarIdRelEspecialidadNomenclador.AutoIncrement = true;
				colvarIdRelEspecialidadNomenclador.IsNullable = false;
				colvarIdRelEspecialidadNomenclador.IsPrimaryKey = true;
				colvarIdRelEspecialidadNomenclador.IsForeignKey = false;
				colvarIdRelEspecialidadNomenclador.IsReadOnly = false;
				colvarIdRelEspecialidadNomenclador.DefaultSetting = @"";
				colvarIdRelEspecialidadNomenclador.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdRelEspecialidadNomenclador);
				
				TableSchema.TableColumn colvarIdEspecialidad = new TableSchema.TableColumn(schema);
				colvarIdEspecialidad.ColumnName = "idEspecialidad";
				colvarIdEspecialidad.DataType = DbType.Int32;
				colvarIdEspecialidad.MaxLength = 0;
				colvarIdEspecialidad.AutoIncrement = false;
				colvarIdEspecialidad.IsNullable = false;
				colvarIdEspecialidad.IsPrimaryKey = false;
				colvarIdEspecialidad.IsForeignKey = true;
				colvarIdEspecialidad.IsReadOnly = false;
				colvarIdEspecialidad.DefaultSetting = @"";
				
					colvarIdEspecialidad.ForeignKeyTableName = "Sys_Especialidad";
				schema.Columns.Add(colvarIdEspecialidad);
				
				TableSchema.TableColumn colvarCodigo = new TableSchema.TableColumn(schema);
				colvarCodigo.ColumnName = "codigo";
				colvarCodigo.DataType = DbType.AnsiString;
				colvarCodigo.MaxLength = 50;
				colvarCodigo.AutoIncrement = false;
				colvarCodigo.IsNullable = false;
				colvarCodigo.IsPrimaryKey = false;
				colvarCodigo.IsForeignKey = false;
				colvarCodigo.IsReadOnly = false;
				colvarCodigo.DefaultSetting = @"";
				colvarCodigo.ForeignKeyTableName = "";
				schema.Columns.Add(colvarCodigo);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["RisProvider"].AddSchema("FAC_RelEspecialidadNomenclador",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("IdRelEspecialidadNomenclador")]
		[Bindable(true)]
		public int IdRelEspecialidadNomenclador 
		{
			get { return GetColumnValue<int>(Columns.IdRelEspecialidadNomenclador); }
			set { SetColumnValue(Columns.IdRelEspecialidadNomenclador, value); }
		}
		  
		[XmlAttribute("IdEspecialidad")]
		[Bindable(true)]
		public int IdEspecialidad 
		{
			get { return GetColumnValue<int>(Columns.IdEspecialidad); }
			set { SetColumnValue(Columns.IdEspecialidad, value); }
		}
		  
		[XmlAttribute("Codigo")]
		[Bindable(true)]
		public string Codigo 
		{
			get { return GetColumnValue<string>(Columns.Codigo); }
			set { SetColumnValue(Columns.Codigo, value); }
		}
		
		#endregion
		
		
			
		
		#region ForeignKey Properties
		
		/// <summary>
		/// Returns a SysEspecialidad ActiveRecord object related to this FacRelEspecialidadNomenclador
		/// 
		/// </summary>
		public DalRis.SysEspecialidad SysEspecialidad
		{
			get { return DalRis.SysEspecialidad.FetchByID(this.IdEspecialidad); }
			set { SetColumnValue("idEspecialidad", value.IdEspecialidad); }
		}
		
		
		#endregion
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(int varIdEspecialidad,string varCodigo)
		{
			FacRelEspecialidadNomenclador item = new FacRelEspecialidadNomenclador();
			
			item.IdEspecialidad = varIdEspecialidad;
			
			item.Codigo = varCodigo;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varIdRelEspecialidadNomenclador,int varIdEspecialidad,string varCodigo)
		{
			FacRelEspecialidadNomenclador item = new FacRelEspecialidadNomenclador();
			
				item.IdRelEspecialidadNomenclador = varIdRelEspecialidadNomenclador;
			
				item.IdEspecialidad = varIdEspecialidad;
			
				item.Codigo = varCodigo;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn IdRelEspecialidadNomencladorColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn IdEspecialidadColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn CodigoColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string IdRelEspecialidadNomenclador = @"idRelEspecialidadNomenclador";
			 public static string IdEspecialidad = @"idEspecialidad";
			 public static string Codigo = @"codigo";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
