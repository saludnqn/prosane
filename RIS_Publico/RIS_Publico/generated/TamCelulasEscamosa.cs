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
	/// Strongly-typed collection for the TamCelulasEscamosa class.
	/// </summary>
    [Serializable]
	public partial class TamCelulasEscamosaCollection : ActiveList<TamCelulasEscamosa, TamCelulasEscamosaCollection>
	{	   
		public TamCelulasEscamosaCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>TamCelulasEscamosaCollection</returns>
		public TamCelulasEscamosaCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                TamCelulasEscamosa o = this[i];
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
	/// This is an ActiveRecord class which wraps the TAM_CelulasEscamosas table.
	/// </summary>
	[Serializable]
	public partial class TamCelulasEscamosa : ActiveRecord<TamCelulasEscamosa>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public TamCelulasEscamosa()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public TamCelulasEscamosa(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public TamCelulasEscamosa(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public TamCelulasEscamosa(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("TAM_CelulasEscamosas", TableType.Table, DataService.GetInstance("RisProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarIdCelulasEscamosas = new TableSchema.TableColumn(schema);
				colvarIdCelulasEscamosas.ColumnName = "idCelulasEscamosas";
				colvarIdCelulasEscamosas.DataType = DbType.Int32;
				colvarIdCelulasEscamosas.MaxLength = 0;
				colvarIdCelulasEscamosas.AutoIncrement = true;
				colvarIdCelulasEscamosas.IsNullable = false;
				colvarIdCelulasEscamosas.IsPrimaryKey = true;
				colvarIdCelulasEscamosas.IsForeignKey = false;
				colvarIdCelulasEscamosas.IsReadOnly = false;
				colvarIdCelulasEscamosas.DefaultSetting = @"";
				colvarIdCelulasEscamosas.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdCelulasEscamosas);
				
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
				
				TableSchema.TableColumn colvarVariable = new TableSchema.TableColumn(schema);
				colvarVariable.ColumnName = "variable";
				colvarVariable.DataType = DbType.AnsiString;
				colvarVariable.MaxLength = 50;
				colvarVariable.AutoIncrement = false;
				colvarVariable.IsNullable = false;
				colvarVariable.IsPrimaryKey = false;
				colvarVariable.IsForeignKey = false;
				colvarVariable.IsReadOnly = false;
				
						colvarVariable.DefaultSetting = @"('')";
				colvarVariable.ForeignKeyTableName = "";
				schema.Columns.Add(colvarVariable);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["RisProvider"].AddSchema("TAM_CelulasEscamosas",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("IdCelulasEscamosas")]
		[Bindable(true)]
		public int IdCelulasEscamosas 
		{
			get { return GetColumnValue<int>(Columns.IdCelulasEscamosas); }
			set { SetColumnValue(Columns.IdCelulasEscamosas, value); }
		}
		  
		[XmlAttribute("Nombre")]
		[Bindable(true)]
		public string Nombre 
		{
			get { return GetColumnValue<string>(Columns.Nombre); }
			set { SetColumnValue(Columns.Nombre, value); }
		}
		  
		[XmlAttribute("Variable")]
		[Bindable(true)]
		public string Variable 
		{
			get { return GetColumnValue<string>(Columns.Variable); }
			set { SetColumnValue(Columns.Variable, value); }
		}
		
		#endregion
		
		
		#region PrimaryKey Methods		
		
        protected override void SetPrimaryKey(object oValue)
        {
            base.SetPrimaryKey(oValue);
            
            SetPKValues();
        }
        
		
		private DalRis.TamPapHPCollection colTamPapHPRecords;
		public DalRis.TamPapHPCollection TamPapHPRecords()
		{
			if(colTamPapHPRecords == null)
			{
				colTamPapHPRecords = new DalRis.TamPapHPCollection().Where(TamPapHP.Columns.IdCelulasEscamosas, IdCelulasEscamosas).Load();
				colTamPapHPRecords.ListChanged += new ListChangedEventHandler(colTamPapHPRecords_ListChanged);
			}
			return colTamPapHPRecords;
		}
				
		void colTamPapHPRecords_ListChanged(object sender, ListChangedEventArgs e)
		{
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
		        // Set foreign key value
		        colTamPapHPRecords[e.NewIndex].IdCelulasEscamosas = IdCelulasEscamosas;
				colTamPapHPRecords.ListChanged += new ListChangedEventHandler(colTamPapHPRecords_ListChanged);
            }
		}
		private DalRis.TamPapCollection colTamPapRecords;
		public DalRis.TamPapCollection TamPapRecords()
		{
			if(colTamPapRecords == null)
			{
				colTamPapRecords = new DalRis.TamPapCollection().Where(TamPap.Columns.IdCelulasEscamosas, IdCelulasEscamosas).Load();
				colTamPapRecords.ListChanged += new ListChangedEventHandler(colTamPapRecords_ListChanged);
			}
			return colTamPapRecords;
		}
				
		void colTamPapRecords_ListChanged(object sender, ListChangedEventArgs e)
		{
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
		        // Set foreign key value
		        colTamPapRecords[e.NewIndex].IdCelulasEscamosas = IdCelulasEscamosas;
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
		public static void Insert(string varNombre,string varVariable)
		{
			TamCelulasEscamosa item = new TamCelulasEscamosa();
			
			item.Nombre = varNombre;
			
			item.Variable = varVariable;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varIdCelulasEscamosas,string varNombre,string varVariable)
		{
			TamCelulasEscamosa item = new TamCelulasEscamosa();
			
				item.IdCelulasEscamosas = varIdCelulasEscamosas;
			
				item.Nombre = varNombre;
			
				item.Variable = varVariable;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn IdCelulasEscamosasColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn NombreColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn VariableColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string IdCelulasEscamosas = @"idCelulasEscamosas";
			 public static string Nombre = @"nombre";
			 public static string Variable = @"variable";
						
		}
		#endregion
		
		#region Update PK Collections
		
        public void SetPKValues()
        {
                if (colTamPapHPRecords != null)
                {
                    foreach (DalRis.TamPapHP item in colTamPapHPRecords)
                    {
                        if (item.IdCelulasEscamosas != IdCelulasEscamosas)
                        {
                            item.IdCelulasEscamosas = IdCelulasEscamosas;
                        }
                    }
               }
		
                if (colTamPapRecords != null)
                {
                    foreach (DalRis.TamPap item in colTamPapRecords)
                    {
                        if (item.IdCelulasEscamosas != IdCelulasEscamosas)
                        {
                            item.IdCelulasEscamosas = IdCelulasEscamosas;
                        }
                    }
               }
		}
        #endregion
    
        #region Deep Save
		
        public void DeepSave()
        {
            Save();
            
                if (colTamPapHPRecords != null)
                {
                    colTamPapHPRecords.SaveAll();
               }
		
                if (colTamPapRecords != null)
                {
                    colTamPapRecords.SaveAll();
               }
		}
        #endregion
	}
}
