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
	/// Strongly-typed collection for the PsmDerivacione class.
	/// </summary>
    [Serializable]
	public partial class PsmDerivacioneCollection : ActiveList<PsmDerivacione, PsmDerivacioneCollection>
	{	   
		public PsmDerivacioneCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>PsmDerivacioneCollection</returns>
		public PsmDerivacioneCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                PsmDerivacione o = this[i];
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
	/// This is an ActiveRecord class which wraps the PSM_Derivaciones table.
	/// </summary>
	[Serializable]
	public partial class PsmDerivacione : ActiveRecord<PsmDerivacione>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public PsmDerivacione()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public PsmDerivacione(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public PsmDerivacione(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public PsmDerivacione(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("PSM_Derivaciones", TableType.Table, DataService.GetInstance("RisProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarIdDericiones = new TableSchema.TableColumn(schema);
				colvarIdDericiones.ColumnName = "idDericiones";
				colvarIdDericiones.DataType = DbType.Int32;
				colvarIdDericiones.MaxLength = 0;
				colvarIdDericiones.AutoIncrement = true;
				colvarIdDericiones.IsNullable = false;
				colvarIdDericiones.IsPrimaryKey = true;
				colvarIdDericiones.IsForeignKey = false;
				colvarIdDericiones.IsReadOnly = false;
				colvarIdDericiones.DefaultSetting = @"";
				colvarIdDericiones.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdDericiones);
				
				TableSchema.TableColumn colvarIdProsame = new TableSchema.TableColumn(schema);
				colvarIdProsame.ColumnName = "idProsame";
				colvarIdProsame.DataType = DbType.Int32;
				colvarIdProsame.MaxLength = 0;
				colvarIdProsame.AutoIncrement = false;
				colvarIdProsame.IsNullable = false;
				colvarIdProsame.IsPrimaryKey = false;
				colvarIdProsame.IsForeignKey = false;
				colvarIdProsame.IsReadOnly = false;
				colvarIdProsame.DefaultSetting = @"";
				colvarIdProsame.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdProsame);
				
				TableSchema.TableColumn colvarIdEspecialidad = new TableSchema.TableColumn(schema);
				colvarIdEspecialidad.ColumnName = "idEspecialidad";
				colvarIdEspecialidad.DataType = DbType.Int32;
				colvarIdEspecialidad.MaxLength = 0;
				colvarIdEspecialidad.AutoIncrement = false;
				colvarIdEspecialidad.IsNullable = false;
				colvarIdEspecialidad.IsPrimaryKey = false;
				colvarIdEspecialidad.IsForeignKey = false;
				colvarIdEspecialidad.IsReadOnly = false;
				colvarIdEspecialidad.DefaultSetting = @"";
				colvarIdEspecialidad.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdEspecialidad);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["RisProvider"].AddSchema("PSM_Derivaciones",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("IdDericiones")]
		[Bindable(true)]
		public int IdDericiones 
		{
			get { return GetColumnValue<int>(Columns.IdDericiones); }
			set { SetColumnValue(Columns.IdDericiones, value); }
		}
		  
		[XmlAttribute("IdProsame")]
		[Bindable(true)]
		public int IdProsame 
		{
			get { return GetColumnValue<int>(Columns.IdProsame); }
			set { SetColumnValue(Columns.IdProsame, value); }
		}
		  
		[XmlAttribute("IdEspecialidad")]
		[Bindable(true)]
		public int IdEspecialidad 
		{
			get { return GetColumnValue<int>(Columns.IdEspecialidad); }
			set { SetColumnValue(Columns.IdEspecialidad, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(int varIdProsame,int varIdEspecialidad)
		{
			PsmDerivacione item = new PsmDerivacione();
			
			item.IdProsame = varIdProsame;
			
			item.IdEspecialidad = varIdEspecialidad;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varIdDericiones,int varIdProsame,int varIdEspecialidad)
		{
			PsmDerivacione item = new PsmDerivacione();
			
				item.IdDericiones = varIdDericiones;
			
				item.IdProsame = varIdProsame;
			
				item.IdEspecialidad = varIdEspecialidad;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn IdDericionesColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn IdProsameColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn IdEspecialidadColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string IdDericiones = @"idDericiones";
			 public static string IdProsame = @"idProsame";
			 public static string IdEspecialidad = @"idEspecialidad";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
