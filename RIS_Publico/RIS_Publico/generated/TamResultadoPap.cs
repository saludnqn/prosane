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
	/// Strongly-typed collection for the TamResultadoPap class.
	/// </summary>
    [Serializable]
	public partial class TamResultadoPapCollection : ActiveList<TamResultadoPap, TamResultadoPapCollection>
	{	   
		public TamResultadoPapCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>TamResultadoPapCollection</returns>
		public TamResultadoPapCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                TamResultadoPap o = this[i];
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
	/// This is an ActiveRecord class which wraps the TAM_ResultadoPap table.
	/// </summary>
	[Serializable]
	public partial class TamResultadoPap : ActiveRecord<TamResultadoPap>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public TamResultadoPap()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public TamResultadoPap(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public TamResultadoPap(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public TamResultadoPap(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("TAM_ResultadoPap", TableType.Table, DataService.GetInstance("RisProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarIdResultadoPap = new TableSchema.TableColumn(schema);
				colvarIdResultadoPap.ColumnName = "idResultadoPap";
				colvarIdResultadoPap.DataType = DbType.Int32;
				colvarIdResultadoPap.MaxLength = 0;
				colvarIdResultadoPap.AutoIncrement = true;
				colvarIdResultadoPap.IsNullable = false;
				colvarIdResultadoPap.IsPrimaryKey = true;
				colvarIdResultadoPap.IsForeignKey = false;
				colvarIdResultadoPap.IsReadOnly = false;
				colvarIdResultadoPap.DefaultSetting = @"";
				colvarIdResultadoPap.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdResultadoPap);
				
				TableSchema.TableColumn colvarNombre = new TableSchema.TableColumn(schema);
				colvarNombre.ColumnName = "nombre";
				colvarNombre.DataType = DbType.AnsiString;
				colvarNombre.MaxLength = 200;
				colvarNombre.AutoIncrement = false;
				colvarNombre.IsNullable = false;
				colvarNombre.IsPrimaryKey = false;
				colvarNombre.IsForeignKey = false;
				colvarNombre.IsReadOnly = false;
				
						colvarNombre.DefaultSetting = @"('')";
				colvarNombre.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNombre);
				
				TableSchema.TableColumn colvarOrden = new TableSchema.TableColumn(schema);
				colvarOrden.ColumnName = "orden";
				colvarOrden.DataType = DbType.Int32;
				colvarOrden.MaxLength = 0;
				colvarOrden.AutoIncrement = false;
				colvarOrden.IsNullable = false;
				colvarOrden.IsPrimaryKey = false;
				colvarOrden.IsForeignKey = false;
				colvarOrden.IsReadOnly = false;
				
						colvarOrden.DefaultSetting = @"((0))";
				colvarOrden.ForeignKeyTableName = "";
				schema.Columns.Add(colvarOrden);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["RisProvider"].AddSchema("TAM_ResultadoPap",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("IdResultadoPap")]
		[Bindable(true)]
		public int IdResultadoPap 
		{
			get { return GetColumnValue<int>(Columns.IdResultadoPap); }
			set { SetColumnValue(Columns.IdResultadoPap, value); }
		}
		  
		[XmlAttribute("Nombre")]
		[Bindable(true)]
		public string Nombre 
		{
			get { return GetColumnValue<string>(Columns.Nombre); }
			set { SetColumnValue(Columns.Nombre, value); }
		}
		  
		[XmlAttribute("Orden")]
		[Bindable(true)]
		public int Orden 
		{
			get { return GetColumnValue<int>(Columns.Orden); }
			set { SetColumnValue(Columns.Orden, value); }
		}
		
		#endregion
		
		
		#region PrimaryKey Methods		
		
        protected override void SetPrimaryKey(object oValue)
        {
            base.SetPrimaryKey(oValue);
            
            SetPKValues();
        }
        
		
		private DalRis.TamPapCollection colTamPapRecords;
		public DalRis.TamPapCollection TamPapRecords()
		{
			if(colTamPapRecords == null)
			{
				colTamPapRecords = new DalRis.TamPapCollection().Where(TamPap.Columns.IdTipoResultado, IdResultadoPap).Load();
				colTamPapRecords.ListChanged += new ListChangedEventHandler(colTamPapRecords_ListChanged);
			}
			return colTamPapRecords;
		}
				
		void colTamPapRecords_ListChanged(object sender, ListChangedEventArgs e)
		{
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
		        // Set foreign key value
		        colTamPapRecords[e.NewIndex].IdTipoResultado = IdResultadoPap;
				colTamPapRecords.ListChanged += new ListChangedEventHandler(colTamPapRecords_ListChanged);
            }
		}
		#endregion
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varNombre,int varOrden)
		{
			TamResultadoPap item = new TamResultadoPap();
			
			item.Nombre = varNombre;
			
			item.Orden = varOrden;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varIdResultadoPap,string varNombre,int varOrden)
		{
			TamResultadoPap item = new TamResultadoPap();
			
				item.IdResultadoPap = varIdResultadoPap;
			
				item.Nombre = varNombre;
			
				item.Orden = varOrden;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn IdResultadoPapColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn NombreColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn OrdenColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string IdResultadoPap = @"idResultadoPap";
			 public static string Nombre = @"nombre";
			 public static string Orden = @"orden";
						
		}
		#endregion
		
		#region Update PK Collections
		
        public void SetPKValues()
        {
                if (colTamPapRecords != null)
                {
                    foreach (DalRis.TamPap item in colTamPapRecords)
                    {
                        if (item.IdTipoResultado != IdResultadoPap)
                        {
                            item.IdTipoResultado = IdResultadoPap;
                        }
                    }
               }
		}
        #endregion
    
        #region Deep Save
		
        public void DeepSave()
        {
            Save();
            
                if (colTamPapRecords != null)
                {
                    colTamPapRecords.SaveAll();
               }
		}
        #endregion
	}
}
