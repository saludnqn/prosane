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
	/// Strongly-typed collection for the TamResultadoHpv class.
	/// </summary>
    [Serializable]
	public partial class TamResultadoHpvCollection : ActiveList<TamResultadoHpv, TamResultadoHpvCollection>
	{	   
		public TamResultadoHpvCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>TamResultadoHpvCollection</returns>
		public TamResultadoHpvCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                TamResultadoHpv o = this[i];
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
	/// This is an ActiveRecord class which wraps the TAM_ResultadoHpv table.
	/// </summary>
	[Serializable]
	public partial class TamResultadoHpv : ActiveRecord<TamResultadoHpv>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public TamResultadoHpv()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public TamResultadoHpv(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public TamResultadoHpv(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public TamResultadoHpv(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("TAM_ResultadoHpv", TableType.Table, DataService.GetInstance("RisProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarIdResultadoHpv = new TableSchema.TableColumn(schema);
				colvarIdResultadoHpv.ColumnName = "idResultadoHpv";
				colvarIdResultadoHpv.DataType = DbType.Int32;
				colvarIdResultadoHpv.MaxLength = 0;
				colvarIdResultadoHpv.AutoIncrement = true;
				colvarIdResultadoHpv.IsNullable = false;
				colvarIdResultadoHpv.IsPrimaryKey = true;
				colvarIdResultadoHpv.IsForeignKey = false;
				colvarIdResultadoHpv.IsReadOnly = false;
				colvarIdResultadoHpv.DefaultSetting = @"";
				colvarIdResultadoHpv.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdResultadoHpv);
				
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
				DataService.Providers["RisProvider"].AddSchema("TAM_ResultadoHpv",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("IdResultadoHpv")]
		[Bindable(true)]
		public int IdResultadoHpv 
		{
			get { return GetColumnValue<int>(Columns.IdResultadoHpv); }
			set { SetColumnValue(Columns.IdResultadoHpv, value); }
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
        
		
		private DalRis.TamHpvHPCollection colTamHpvHPRecords;
		public DalRis.TamHpvHPCollection TamHpvHPRecords()
		{
			if(colTamHpvHPRecords == null)
			{
				colTamHpvHPRecords = new DalRis.TamHpvHPCollection().Where(TamHpvHP.Columns.IdResultado, IdResultadoHpv).Load();
				colTamHpvHPRecords.ListChanged += new ListChangedEventHandler(colTamHpvHPRecords_ListChanged);
			}
			return colTamHpvHPRecords;
		}
				
		void colTamHpvHPRecords_ListChanged(object sender, ListChangedEventArgs e)
		{
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
		        // Set foreign key value
		        colTamHpvHPRecords[e.NewIndex].IdResultado = IdResultadoHpv;
				colTamHpvHPRecords.ListChanged += new ListChangedEventHandler(colTamHpvHPRecords_ListChanged);
            }
		}
		private DalRis.TamHpvCollection colTamHpvRecords;
		public DalRis.TamHpvCollection TamHpvRecords()
		{
			if(colTamHpvRecords == null)
			{
				colTamHpvRecords = new DalRis.TamHpvCollection().Where(TamHpv.Columns.IdResultadoPrevioHpv, IdResultadoHpv).Load();
				colTamHpvRecords.ListChanged += new ListChangedEventHandler(colTamHpvRecords_ListChanged);
			}
			return colTamHpvRecords;
		}
				
		void colTamHpvRecords_ListChanged(object sender, ListChangedEventArgs e)
		{
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
		        // Set foreign key value
		        colTamHpvRecords[e.NewIndex].IdResultadoPrevioHpv = IdResultadoHpv;
				colTamHpvRecords.ListChanged += new ListChangedEventHandler(colTamHpvRecords_ListChanged);
            }
		}
		private DalRis.TamHpvCollection colTamHpvRecordsFromTamResultadoHpv;
		public DalRis.TamHpvCollection TamHpvRecordsFromTamResultadoHpv()
		{
			if(colTamHpvRecordsFromTamResultadoHpv == null)
			{
				colTamHpvRecordsFromTamResultadoHpv = new DalRis.TamHpvCollection().Where(TamHpv.Columns.IdResultadoHpv, IdResultadoHpv).Load();
				colTamHpvRecordsFromTamResultadoHpv.ListChanged += new ListChangedEventHandler(colTamHpvRecordsFromTamResultadoHpv_ListChanged);
			}
			return colTamHpvRecordsFromTamResultadoHpv;
		}
				
		void colTamHpvRecordsFromTamResultadoHpv_ListChanged(object sender, ListChangedEventArgs e)
		{
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
		        // Set foreign key value
		        colTamHpvRecordsFromTamResultadoHpv[e.NewIndex].IdResultadoHpv = IdResultadoHpv;
				colTamHpvRecordsFromTamResultadoHpv.ListChanged += new ListChangedEventHandler(colTamHpvRecordsFromTamResultadoHpv_ListChanged);
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
			TamResultadoHpv item = new TamResultadoHpv();
			
			item.Nombre = varNombre;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varIdResultadoHpv,string varNombre)
		{
			TamResultadoHpv item = new TamResultadoHpv();
			
				item.IdResultadoHpv = varIdResultadoHpv;
			
				item.Nombre = varNombre;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn IdResultadoHpvColumn
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
			 public static string IdResultadoHpv = @"idResultadoHpv";
			 public static string Nombre = @"nombre";
						
		}
		#endregion
		
		#region Update PK Collections
		
        public void SetPKValues()
        {
                if (colTamHpvHPRecords != null)
                {
                    foreach (DalRis.TamHpvHP item in colTamHpvHPRecords)
                    {
                        if (item.IdResultado != IdResultadoHpv)
                        {
                            item.IdResultado = IdResultadoHpv;
                        }
                    }
               }
		
                if (colTamHpvRecords != null)
                {
                    foreach (DalRis.TamHpv item in colTamHpvRecords)
                    {
                        if (item.IdResultadoPrevioHpv != IdResultadoHpv)
                        {
                            item.IdResultadoPrevioHpv = IdResultadoHpv;
                        }
                    }
               }
		
                if (colTamHpvRecordsFromTamResultadoHpv != null)
                {
                    foreach (DalRis.TamHpv item in colTamHpvRecordsFromTamResultadoHpv)
                    {
                        if (item.IdResultadoHpv != IdResultadoHpv)
                        {
                            item.IdResultadoHpv = IdResultadoHpv;
                        }
                    }
               }
		}
        #endregion
    
        #region Deep Save
		
        public void DeepSave()
        {
            Save();
            
                if (colTamHpvHPRecords != null)
                {
                    colTamHpvHPRecords.SaveAll();
               }
		
                if (colTamHpvRecords != null)
                {
                    colTamHpvRecords.SaveAll();
               }
		
                if (colTamHpvRecordsFromTamResultadoHpv != null)
                {
                    colTamHpvRecordsFromTamResultadoHpv.SaveAll();
               }
		}
        #endregion
	}
}
