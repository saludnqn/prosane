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
	/// Strongly-typed collection for the TamMicrorganismo class.
	/// </summary>
    [Serializable]
	public partial class TamMicrorganismoCollection : ActiveList<TamMicrorganismo, TamMicrorganismoCollection>
	{	   
		public TamMicrorganismoCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>TamMicrorganismoCollection</returns>
		public TamMicrorganismoCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                TamMicrorganismo o = this[i];
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
	/// This is an ActiveRecord class which wraps the TAM_Microrganismo table.
	/// </summary>
	[Serializable]
	public partial class TamMicrorganismo : ActiveRecord<TamMicrorganismo>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public TamMicrorganismo()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public TamMicrorganismo(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public TamMicrorganismo(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public TamMicrorganismo(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("TAM_Microrganismo", TableType.Table, DataService.GetInstance("RisProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarIdMicrorganismo = new TableSchema.TableColumn(schema);
				colvarIdMicrorganismo.ColumnName = "idMicrorganismo";
				colvarIdMicrorganismo.DataType = DbType.Int32;
				colvarIdMicrorganismo.MaxLength = 0;
				colvarIdMicrorganismo.AutoIncrement = true;
				colvarIdMicrorganismo.IsNullable = false;
				colvarIdMicrorganismo.IsPrimaryKey = true;
				colvarIdMicrorganismo.IsForeignKey = false;
				colvarIdMicrorganismo.IsReadOnly = false;
				colvarIdMicrorganismo.DefaultSetting = @"";
				colvarIdMicrorganismo.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdMicrorganismo);
				
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
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["RisProvider"].AddSchema("TAM_Microrganismo",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("IdMicrorganismo")]
		[Bindable(true)]
		public int IdMicrorganismo 
		{
			get { return GetColumnValue<int>(Columns.IdMicrorganismo); }
			set { SetColumnValue(Columns.IdMicrorganismo, value); }
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
        
		
		private DalRis.TamPapHPCollection colTamPapHPRecords;
		public DalRis.TamPapHPCollection TamPapHPRecords()
		{
			if(colTamPapHPRecords == null)
			{
				colTamPapHPRecords = new DalRis.TamPapHPCollection().Where(TamPapHP.Columns.IdMicroorganismo, IdMicrorganismo).Load();
				colTamPapHPRecords.ListChanged += new ListChangedEventHandler(colTamPapHPRecords_ListChanged);
			}
			return colTamPapHPRecords;
		}
				
		void colTamPapHPRecords_ListChanged(object sender, ListChangedEventArgs e)
		{
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
		        // Set foreign key value
		        colTamPapHPRecords[e.NewIndex].IdMicroorganismo = IdMicrorganismo;
				colTamPapHPRecords.ListChanged += new ListChangedEventHandler(colTamPapHPRecords_ListChanged);
            }
		}
		private DalRis.TamPapCollection colTamPapRecords;
		public DalRis.TamPapCollection TamPapRecords()
		{
			if(colTamPapRecords == null)
			{
				colTamPapRecords = new DalRis.TamPapCollection().Where(TamPap.Columns.IdMicrorganismo, IdMicrorganismo).Load();
				colTamPapRecords.ListChanged += new ListChangedEventHandler(colTamPapRecords_ListChanged);
			}
			return colTamPapRecords;
		}
				
		void colTamPapRecords_ListChanged(object sender, ListChangedEventArgs e)
		{
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
		        // Set foreign key value
		        colTamPapRecords[e.NewIndex].IdMicrorganismo = IdMicrorganismo;
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
		public static void Insert(string varNombre)
		{
			TamMicrorganismo item = new TamMicrorganismo();
			
			item.Nombre = varNombre;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varIdMicrorganismo,string varNombre)
		{
			TamMicrorganismo item = new TamMicrorganismo();
			
				item.IdMicrorganismo = varIdMicrorganismo;
			
				item.Nombre = varNombre;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn IdMicrorganismoColumn
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
			 public static string IdMicrorganismo = @"idMicrorganismo";
			 public static string Nombre = @"nombre";
						
		}
		#endregion
		
		#region Update PK Collections
		
        public void SetPKValues()
        {
                if (colTamPapHPRecords != null)
                {
                    foreach (DalRis.TamPapHP item in colTamPapHPRecords)
                    {
                        if (item.IdMicroorganismo != IdMicrorganismo)
                        {
                            item.IdMicroorganismo = IdMicrorganismo;
                        }
                    }
               }
		
                if (colTamPapRecords != null)
                {
                    foreach (DalRis.TamPap item in colTamPapRecords)
                    {
                        if (item.IdMicrorganismo != IdMicrorganismo)
                        {
                            item.IdMicrorganismo = IdMicrorganismo;
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
