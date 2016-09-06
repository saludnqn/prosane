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
	/// Strongly-typed collection for the TamTipoMaterialBiopsium class.
	/// </summary>
    [Serializable]
	public partial class TamTipoMaterialBiopsiumCollection : ActiveList<TamTipoMaterialBiopsium, TamTipoMaterialBiopsiumCollection>
	{	   
		public TamTipoMaterialBiopsiumCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>TamTipoMaterialBiopsiumCollection</returns>
		public TamTipoMaterialBiopsiumCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                TamTipoMaterialBiopsium o = this[i];
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
	/// This is an ActiveRecord class which wraps the TAM_TipoMaterialBiopsia table.
	/// </summary>
	[Serializable]
	public partial class TamTipoMaterialBiopsium : ActiveRecord<TamTipoMaterialBiopsium>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public TamTipoMaterialBiopsium()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public TamTipoMaterialBiopsium(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public TamTipoMaterialBiopsium(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public TamTipoMaterialBiopsium(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("TAM_TipoMaterialBiopsia", TableType.Table, DataService.GetInstance("RisProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarIdTipoMaterialBiopsia = new TableSchema.TableColumn(schema);
				colvarIdTipoMaterialBiopsia.ColumnName = "idTipoMaterialBiopsia";
				colvarIdTipoMaterialBiopsia.DataType = DbType.Int32;
				colvarIdTipoMaterialBiopsia.MaxLength = 0;
				colvarIdTipoMaterialBiopsia.AutoIncrement = true;
				colvarIdTipoMaterialBiopsia.IsNullable = false;
				colvarIdTipoMaterialBiopsia.IsPrimaryKey = true;
				colvarIdTipoMaterialBiopsia.IsForeignKey = false;
				colvarIdTipoMaterialBiopsia.IsReadOnly = false;
				colvarIdTipoMaterialBiopsia.DefaultSetting = @"";
				colvarIdTipoMaterialBiopsia.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdTipoMaterialBiopsia);
				
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
				
				TableSchema.TableColumn colvarActivo = new TableSchema.TableColumn(schema);
				colvarActivo.ColumnName = "activo";
				colvarActivo.DataType = DbType.Boolean;
				colvarActivo.MaxLength = 0;
				colvarActivo.AutoIncrement = false;
				colvarActivo.IsNullable = false;
				colvarActivo.IsPrimaryKey = false;
				colvarActivo.IsForeignKey = false;
				colvarActivo.IsReadOnly = false;
				
						colvarActivo.DefaultSetting = @"((1))";
				colvarActivo.ForeignKeyTableName = "";
				schema.Columns.Add(colvarActivo);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["RisProvider"].AddSchema("TAM_TipoMaterialBiopsia",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("IdTipoMaterialBiopsia")]
		[Bindable(true)]
		public int IdTipoMaterialBiopsia 
		{
			get { return GetColumnValue<int>(Columns.IdTipoMaterialBiopsia); }
			set { SetColumnValue(Columns.IdTipoMaterialBiopsia, value); }
		}
		  
		[XmlAttribute("Nombre")]
		[Bindable(true)]
		public string Nombre 
		{
			get { return GetColumnValue<string>(Columns.Nombre); }
			set { SetColumnValue(Columns.Nombre, value); }
		}
		  
		[XmlAttribute("Activo")]
		[Bindable(true)]
		public bool Activo 
		{
			get { return GetColumnValue<bool>(Columns.Activo); }
			set { SetColumnValue(Columns.Activo, value); }
		}
		
		#endregion
		
		
		#region PrimaryKey Methods		
		
        protected override void SetPrimaryKey(object oValue)
        {
            base.SetPrimaryKey(oValue);
            
            SetPKValues();
        }
        
		
		private DalRis.TamRelTipoMaterialBiopsiumCollection colTamRelTipoMaterialBiopsia;
		public DalRis.TamRelTipoMaterialBiopsiumCollection TamRelTipoMaterialBiopsia()
		{
			if(colTamRelTipoMaterialBiopsia == null)
			{
				colTamRelTipoMaterialBiopsia = new DalRis.TamRelTipoMaterialBiopsiumCollection().Where(TamRelTipoMaterialBiopsium.Columns.IdTipoMaterialBiopsia, IdTipoMaterialBiopsia).Load();
				colTamRelTipoMaterialBiopsia.ListChanged += new ListChangedEventHandler(colTamRelTipoMaterialBiopsia_ListChanged);
			}
			return colTamRelTipoMaterialBiopsia;
		}
				
		void colTamRelTipoMaterialBiopsia_ListChanged(object sender, ListChangedEventArgs e)
		{
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
		        // Set foreign key value
		        colTamRelTipoMaterialBiopsia[e.NewIndex].IdTipoMaterialBiopsia = IdTipoMaterialBiopsia;
				colTamRelTipoMaterialBiopsia.ListChanged += new ListChangedEventHandler(colTamRelTipoMaterialBiopsia_ListChanged);
            }
		}
		#endregion
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varNombre,bool varActivo)
		{
			TamTipoMaterialBiopsium item = new TamTipoMaterialBiopsium();
			
			item.Nombre = varNombre;
			
			item.Activo = varActivo;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varIdTipoMaterialBiopsia,string varNombre,bool varActivo)
		{
			TamTipoMaterialBiopsium item = new TamTipoMaterialBiopsium();
			
				item.IdTipoMaterialBiopsia = varIdTipoMaterialBiopsia;
			
				item.Nombre = varNombre;
			
				item.Activo = varActivo;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn IdTipoMaterialBiopsiaColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn NombreColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn ActivoColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string IdTipoMaterialBiopsia = @"idTipoMaterialBiopsia";
			 public static string Nombre = @"nombre";
			 public static string Activo = @"activo";
						
		}
		#endregion
		
		#region Update PK Collections
		
        public void SetPKValues()
        {
                if (colTamRelTipoMaterialBiopsia != null)
                {
                    foreach (DalRis.TamRelTipoMaterialBiopsium item in colTamRelTipoMaterialBiopsia)
                    {
                        if (item.IdTipoMaterialBiopsia != IdTipoMaterialBiopsia)
                        {
                            item.IdTipoMaterialBiopsia = IdTipoMaterialBiopsia;
                        }
                    }
               }
		}
        #endregion
    
        #region Deep Save
		
        public void DeepSave()
        {
            Save();
            
                if (colTamRelTipoMaterialBiopsia != null)
                {
                    colTamRelTipoMaterialBiopsia.SaveAll();
               }
		}
        #endregion
	}
}
