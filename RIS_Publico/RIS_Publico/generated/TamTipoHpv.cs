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
	/// Strongly-typed collection for the TamTipoHpv class.
	/// </summary>
    [Serializable]
	public partial class TamTipoHpvCollection : ActiveList<TamTipoHpv, TamTipoHpvCollection>
	{	   
		public TamTipoHpvCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>TamTipoHpvCollection</returns>
		public TamTipoHpvCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                TamTipoHpv o = this[i];
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
	/// This is an ActiveRecord class which wraps the TAM_TipoHpv table.
	/// </summary>
	[Serializable]
	public partial class TamTipoHpv : ActiveRecord<TamTipoHpv>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public TamTipoHpv()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public TamTipoHpv(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public TamTipoHpv(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public TamTipoHpv(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("TAM_TipoHpv", TableType.Table, DataService.GetInstance("RisProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarIdTipoHpv = new TableSchema.TableColumn(schema);
				colvarIdTipoHpv.ColumnName = "idTipoHpv";
				colvarIdTipoHpv.DataType = DbType.Int32;
				colvarIdTipoHpv.MaxLength = 0;
				colvarIdTipoHpv.AutoIncrement = true;
				colvarIdTipoHpv.IsNullable = false;
				colvarIdTipoHpv.IsPrimaryKey = true;
				colvarIdTipoHpv.IsForeignKey = false;
				colvarIdTipoHpv.IsReadOnly = false;
				colvarIdTipoHpv.DefaultSetting = @"";
				colvarIdTipoHpv.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdTipoHpv);
				
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
				DataService.Providers["RisProvider"].AddSchema("TAM_TipoHpv",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("IdTipoHpv")]
		[Bindable(true)]
		public int IdTipoHpv 
		{
			get { return GetColumnValue<int>(Columns.IdTipoHpv); }
			set { SetColumnValue(Columns.IdTipoHpv, value); }
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
        
		
		private DalRis.TamHpvCollection colTamHpvRecords;
		public DalRis.TamHpvCollection TamHpvRecords()
		{
			if(colTamHpvRecords == null)
			{
				colTamHpvRecords = new DalRis.TamHpvCollection().Where(TamHpv.Columns.IdTipoHpvPrevio, IdTipoHpv).Load();
				colTamHpvRecords.ListChanged += new ListChangedEventHandler(colTamHpvRecords_ListChanged);
			}
			return colTamHpvRecords;
		}
				
		void colTamHpvRecords_ListChanged(object sender, ListChangedEventArgs e)
		{
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
		        // Set foreign key value
		        colTamHpvRecords[e.NewIndex].IdTipoHpvPrevio = IdTipoHpv;
				colTamHpvRecords.ListChanged += new ListChangedEventHandler(colTamHpvRecords_ListChanged);
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
			TamTipoHpv item = new TamTipoHpv();
			
			item.Nombre = varNombre;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varIdTipoHpv,string varNombre)
		{
			TamTipoHpv item = new TamTipoHpv();
			
				item.IdTipoHpv = varIdTipoHpv;
			
				item.Nombre = varNombre;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn IdTipoHpvColumn
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
			 public static string IdTipoHpv = @"idTipoHpv";
			 public static string Nombre = @"nombre";
						
		}
		#endregion
		
		#region Update PK Collections
		
        public void SetPKValues()
        {
                if (colTamHpvRecords != null)
                {
                    foreach (DalRis.TamHpv item in colTamHpvRecords)
                    {
                        if (item.IdTipoHpvPrevio != IdTipoHpv)
                        {
                            item.IdTipoHpvPrevio = IdTipoHpv;
                        }
                    }
               }
		}
        #endregion
    
        #region Deep Save
		
        public void DeepSave()
        {
            Save();
            
                if (colTamHpvRecords != null)
                {
                    colTamHpvRecords.SaveAll();
               }
		}
        #endregion
	}
}
