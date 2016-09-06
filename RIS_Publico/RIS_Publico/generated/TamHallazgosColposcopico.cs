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
	/// Strongly-typed collection for the TamHallazgosColposcopico class.
	/// </summary>
    [Serializable]
	public partial class TamHallazgosColposcopicoCollection : ActiveList<TamHallazgosColposcopico, TamHallazgosColposcopicoCollection>
	{	   
		public TamHallazgosColposcopicoCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>TamHallazgosColposcopicoCollection</returns>
		public TamHallazgosColposcopicoCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                TamHallazgosColposcopico o = this[i];
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
	/// This is an ActiveRecord class which wraps the TAM_HallazgosColposcopicos table.
	/// </summary>
	[Serializable]
	public partial class TamHallazgosColposcopico : ActiveRecord<TamHallazgosColposcopico>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public TamHallazgosColposcopico()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public TamHallazgosColposcopico(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public TamHallazgosColposcopico(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public TamHallazgosColposcopico(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("TAM_HallazgosColposcopicos", TableType.Table, DataService.GetInstance("RisProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarIdHallazgosColposcopicos = new TableSchema.TableColumn(schema);
				colvarIdHallazgosColposcopicos.ColumnName = "idHallazgosColposcopicos";
				colvarIdHallazgosColposcopicos.DataType = DbType.Int32;
				colvarIdHallazgosColposcopicos.MaxLength = 0;
				colvarIdHallazgosColposcopicos.AutoIncrement = true;
				colvarIdHallazgosColposcopicos.IsNullable = false;
				colvarIdHallazgosColposcopicos.IsPrimaryKey = true;
				colvarIdHallazgosColposcopicos.IsForeignKey = false;
				colvarIdHallazgosColposcopicos.IsReadOnly = false;
				colvarIdHallazgosColposcopicos.DefaultSetting = @"";
				colvarIdHallazgosColposcopicos.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdHallazgosColposcopicos);
				
				TableSchema.TableColumn colvarNombre = new TableSchema.TableColumn(schema);
				colvarNombre.ColumnName = "nombre";
				colvarNombre.DataType = DbType.AnsiString;
				colvarNombre.MaxLength = 50;
				colvarNombre.AutoIncrement = false;
				colvarNombre.IsNullable = true;
				colvarNombre.IsPrimaryKey = false;
				colvarNombre.IsForeignKey = false;
				colvarNombre.IsReadOnly = false;
				colvarNombre.DefaultSetting = @"";
				colvarNombre.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNombre);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["RisProvider"].AddSchema("TAM_HallazgosColposcopicos",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("IdHallazgosColposcopicos")]
		[Bindable(true)]
		public int IdHallazgosColposcopicos 
		{
			get { return GetColumnValue<int>(Columns.IdHallazgosColposcopicos); }
			set { SetColumnValue(Columns.IdHallazgosColposcopicos, value); }
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
        
		
		private DalRis.TamColposcopiumCollection colTamColposcopia;
		public DalRis.TamColposcopiumCollection TamColposcopia()
		{
			if(colTamColposcopia == null)
			{
				colTamColposcopia = new DalRis.TamColposcopiumCollection().Where(TamColposcopium.Columns.IdHallazgosColposcopicos, IdHallazgosColposcopicos).Load();
				colTamColposcopia.ListChanged += new ListChangedEventHandler(colTamColposcopia_ListChanged);
			}
			return colTamColposcopia;
		}
				
		void colTamColposcopia_ListChanged(object sender, ListChangedEventArgs e)
		{
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
		        // Set foreign key value
		        colTamColposcopia[e.NewIndex].IdHallazgosColposcopicos = IdHallazgosColposcopicos;
				colTamColposcopia.ListChanged += new ListChangedEventHandler(colTamColposcopia_ListChanged);
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
			TamHallazgosColposcopico item = new TamHallazgosColposcopico();
			
			item.Nombre = varNombre;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varIdHallazgosColposcopicos,string varNombre)
		{
			TamHallazgosColposcopico item = new TamHallazgosColposcopico();
			
				item.IdHallazgosColposcopicos = varIdHallazgosColposcopicos;
			
				item.Nombre = varNombre;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn IdHallazgosColposcopicosColumn
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
			 public static string IdHallazgosColposcopicos = @"idHallazgosColposcopicos";
			 public static string Nombre = @"nombre";
						
		}
		#endregion
		
		#region Update PK Collections
		
        public void SetPKValues()
        {
                if (colTamColposcopia != null)
                {
                    foreach (DalRis.TamColposcopium item in colTamColposcopia)
                    {
                        if (item.IdHallazgosColposcopicos != IdHallazgosColposcopicos)
                        {
                            item.IdHallazgosColposcopicos = IdHallazgosColposcopicos;
                        }
                    }
               }
		}
        #endregion
    
        #region Deep Save
		
        public void DeepSave()
        {
            Save();
            
                if (colTamColposcopia != null)
                {
                    colTamColposcopia.SaveAll();
               }
		}
        #endregion
	}
}
