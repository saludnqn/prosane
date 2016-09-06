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
	/// Strongly-typed collection for the EmrBase class.
	/// </summary>
    [Serializable]
	public partial class EmrBaseCollection : ActiveList<EmrBase, EmrBaseCollection>
	{	   
		public EmrBaseCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>EmrBaseCollection</returns>
		public EmrBaseCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                EmrBase o = this[i];
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
	/// This is an ActiveRecord class which wraps the EMR_Base table.
	/// </summary>
	[Serializable]
	public partial class EmrBase : ActiveRecord<EmrBase>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public EmrBase()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public EmrBase(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public EmrBase(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public EmrBase(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("EMR_Base", TableType.Table, DataService.GetInstance("RisProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarIdBase = new TableSchema.TableColumn(schema);
				colvarIdBase.ColumnName = "idBase";
				colvarIdBase.DataType = DbType.Int32;
				colvarIdBase.MaxLength = 0;
				colvarIdBase.AutoIncrement = true;
				colvarIdBase.IsNullable = false;
				colvarIdBase.IsPrimaryKey = true;
				colvarIdBase.IsForeignKey = false;
				colvarIdBase.IsReadOnly = false;
				colvarIdBase.DefaultSetting = @"";
				colvarIdBase.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdBase);
				
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
				
				TableSchema.TableColumn colvarActiva = new TableSchema.TableColumn(schema);
				colvarActiva.ColumnName = "activa";
				colvarActiva.DataType = DbType.Boolean;
				colvarActiva.MaxLength = 0;
				colvarActiva.AutoIncrement = false;
				colvarActiva.IsNullable = false;
				colvarActiva.IsPrimaryKey = false;
				colvarActiva.IsForeignKey = false;
				colvarActiva.IsReadOnly = false;
				
						colvarActiva.DefaultSetting = @"((1))";
				colvarActiva.ForeignKeyTableName = "";
				schema.Columns.Add(colvarActiva);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["RisProvider"].AddSchema("EMR_Base",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("IdBase")]
		[Bindable(true)]
		public int IdBase 
		{
			get { return GetColumnValue<int>(Columns.IdBase); }
			set { SetColumnValue(Columns.IdBase, value); }
		}
		  
		[XmlAttribute("Nombre")]
		[Bindable(true)]
		public string Nombre 
		{
			get { return GetColumnValue<string>(Columns.Nombre); }
			set { SetColumnValue(Columns.Nombre, value); }
		}
		  
		[XmlAttribute("Activa")]
		[Bindable(true)]
		public bool Activa 
		{
			get { return GetColumnValue<bool>(Columns.Activa); }
			set { SetColumnValue(Columns.Activa, value); }
		}
		
		#endregion
		
		
		#region PrimaryKey Methods		
		
        protected override void SetPrimaryKey(object oValue)
        {
            base.SetPrimaryKey(oValue);
            
            SetPKValues();
        }
        
		
		private DalRis.EmrPrehospitalariumCollection colEmrPrehospitalaria;
		public DalRis.EmrPrehospitalariumCollection EmrPrehospitalaria()
		{
			if(colEmrPrehospitalaria == null)
			{
				colEmrPrehospitalaria = new DalRis.EmrPrehospitalariumCollection().Where(EmrPrehospitalarium.Columns.IdBase, IdBase).Load();
				colEmrPrehospitalaria.ListChanged += new ListChangedEventHandler(colEmrPrehospitalaria_ListChanged);
			}
			return colEmrPrehospitalaria;
		}
				
		void colEmrPrehospitalaria_ListChanged(object sender, ListChangedEventArgs e)
		{
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
		        // Set foreign key value
		        colEmrPrehospitalaria[e.NewIndex].IdBase = IdBase;
				colEmrPrehospitalaria.ListChanged += new ListChangedEventHandler(colEmrPrehospitalaria_ListChanged);
            }
		}
		private DalRis.EmrRegistroCollection colEmrRegistroRecords;
		public DalRis.EmrRegistroCollection EmrRegistroRecords()
		{
			if(colEmrRegistroRecords == null)
			{
				colEmrRegistroRecords = new DalRis.EmrRegistroCollection().Where(EmrRegistro.Columns.IdBase, IdBase).Load();
				colEmrRegistroRecords.ListChanged += new ListChangedEventHandler(colEmrRegistroRecords_ListChanged);
			}
			return colEmrRegistroRecords;
		}
				
		void colEmrRegistroRecords_ListChanged(object sender, ListChangedEventArgs e)
		{
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
		        // Set foreign key value
		        colEmrRegistroRecords[e.NewIndex].IdBase = IdBase;
				colEmrRegistroRecords.ListChanged += new ListChangedEventHandler(colEmrRegistroRecords_ListChanged);
            }
		}
		#endregion
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varNombre,bool varActiva)
		{
			EmrBase item = new EmrBase();
			
			item.Nombre = varNombre;
			
			item.Activa = varActiva;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varIdBase,string varNombre,bool varActiva)
		{
			EmrBase item = new EmrBase();
			
				item.IdBase = varIdBase;
			
				item.Nombre = varNombre;
			
				item.Activa = varActiva;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn IdBaseColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn NombreColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn ActivaColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string IdBase = @"idBase";
			 public static string Nombre = @"nombre";
			 public static string Activa = @"activa";
						
		}
		#endregion
		
		#region Update PK Collections
		
        public void SetPKValues()
        {
                if (colEmrPrehospitalaria != null)
                {
                    foreach (DalRis.EmrPrehospitalarium item in colEmrPrehospitalaria)
                    {
                        if (item.IdBase != IdBase)
                        {
                            item.IdBase = IdBase;
                        }
                    }
               }
		
                if (colEmrRegistroRecords != null)
                {
                    foreach (DalRis.EmrRegistro item in colEmrRegistroRecords)
                    {
                        if (item.IdBase != IdBase)
                        {
                            item.IdBase = IdBase;
                        }
                    }
               }
		}
        #endregion
    
        #region Deep Save
		
        public void DeepSave()
        {
            Save();
            
                if (colEmrPrehospitalaria != null)
                {
                    colEmrPrehospitalaria.SaveAll();
               }
		
                if (colEmrRegistroRecords != null)
                {
                    colEmrRegistroRecords.SaveAll();
               }
		}
        #endregion
	}
}
