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
	/// Strongly-typed collection for the TamTipoTratamiento class.
	/// </summary>
    [Serializable]
	public partial class TamTipoTratamientoCollection : ActiveList<TamTipoTratamiento, TamTipoTratamientoCollection>
	{	   
		public TamTipoTratamientoCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>TamTipoTratamientoCollection</returns>
		public TamTipoTratamientoCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                TamTipoTratamiento o = this[i];
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
	/// This is an ActiveRecord class which wraps the TAM_TipoTratamiento table.
	/// </summary>
	[Serializable]
	public partial class TamTipoTratamiento : ActiveRecord<TamTipoTratamiento>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public TamTipoTratamiento()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public TamTipoTratamiento(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public TamTipoTratamiento(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public TamTipoTratamiento(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("TAM_TipoTratamiento", TableType.Table, DataService.GetInstance("RisProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarIdTipoTratamiento = new TableSchema.TableColumn(schema);
				colvarIdTipoTratamiento.ColumnName = "idTipoTratamiento";
				colvarIdTipoTratamiento.DataType = DbType.Int32;
				colvarIdTipoTratamiento.MaxLength = 0;
				colvarIdTipoTratamiento.AutoIncrement = true;
				colvarIdTipoTratamiento.IsNullable = false;
				colvarIdTipoTratamiento.IsPrimaryKey = true;
				colvarIdTipoTratamiento.IsForeignKey = false;
				colvarIdTipoTratamiento.IsReadOnly = false;
				colvarIdTipoTratamiento.DefaultSetting = @"";
				colvarIdTipoTratamiento.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdTipoTratamiento);
				
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
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["RisProvider"].AddSchema("TAM_TipoTratamiento",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("IdTipoTratamiento")]
		[Bindable(true)]
		public int IdTipoTratamiento 
		{
			get { return GetColumnValue<int>(Columns.IdTipoTratamiento); }
			set { SetColumnValue(Columns.IdTipoTratamiento, value); }
		}
		  
		[XmlAttribute("Nombre")]
		[Bindable(true)]
		public string Nombre 
		{
			get { return GetColumnValue<string>(Columns.Nombre); }
			set { SetColumnValue(Columns.Nombre, value); }
		}
		
		#endregion
		
		
		#region PrimaryKey Methods		
		
        protected override void SetPrimaryKey(object oValue)
        {
            base.SetPrimaryKey(oValue);
            
            SetPKValues();
        }
        
		
		private DalRis.TamTratamientoCollection colTamTratamientos;
		public DalRis.TamTratamientoCollection TamTratamientos()
		{
			if(colTamTratamientos == null)
			{
				colTamTratamientos = new DalRis.TamTratamientoCollection().Where(TamTratamiento.Columns.IdTipoTratamiento, IdTipoTratamiento).Load();
				colTamTratamientos.ListChanged += new ListChangedEventHandler(colTamTratamientos_ListChanged);
			}
			return colTamTratamientos;
		}
				
		void colTamTratamientos_ListChanged(object sender, ListChangedEventArgs e)
		{
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
		        // Set foreign key value
		        colTamTratamientos[e.NewIndex].IdTipoTratamiento = IdTipoTratamiento;
				colTamTratamientos.ListChanged += new ListChangedEventHandler(colTamTratamientos_ListChanged);
            }
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
			TamTipoTratamiento item = new TamTipoTratamiento();
			
			item.Nombre = varNombre;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varIdTipoTratamiento,string varNombre)
		{
			TamTipoTratamiento item = new TamTipoTratamiento();
			
				item.IdTipoTratamiento = varIdTipoTratamiento;
			
				item.Nombre = varNombre;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn IdTipoTratamientoColumn
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
			 public static string IdTipoTratamiento = @"idTipoTratamiento";
			 public static string Nombre = @"nombre";
						
		}
		#endregion
		
		#region Update PK Collections
		
        public void SetPKValues()
        {
                if (colTamTratamientos != null)
                {
                    foreach (DalRis.TamTratamiento item in colTamTratamientos)
                    {
                        if (item.IdTipoTratamiento != IdTipoTratamiento)
                        {
                            item.IdTipoTratamiento = IdTipoTratamiento;
                        }
                    }
               }
		}
        #endregion
    
        #region Deep Save
		
        public void DeepSave()
        {
            Save();
            
                if (colTamTratamientos != null)
                {
                    colTamTratamientos.SaveAll();
               }
		}
        #endregion
	}
}
