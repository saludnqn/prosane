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
	/// Strongly-typed collection for the EmrTipoTrauma class.
	/// </summary>
    [Serializable]
	public partial class EmrTipoTraumaCollection : ActiveList<EmrTipoTrauma, EmrTipoTraumaCollection>
	{	   
		public EmrTipoTraumaCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>EmrTipoTraumaCollection</returns>
		public EmrTipoTraumaCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                EmrTipoTrauma o = this[i];
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
	/// This is an ActiveRecord class which wraps the EMR_TipoTrauma table.
	/// </summary>
	[Serializable]
	public partial class EmrTipoTrauma : ActiveRecord<EmrTipoTrauma>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public EmrTipoTrauma()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public EmrTipoTrauma(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public EmrTipoTrauma(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public EmrTipoTrauma(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("EMR_TipoTrauma", TableType.Table, DataService.GetInstance("RisProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarIdTipoTrauma = new TableSchema.TableColumn(schema);
				colvarIdTipoTrauma.ColumnName = "idTipoTrauma";
				colvarIdTipoTrauma.DataType = DbType.Int32;
				colvarIdTipoTrauma.MaxLength = 0;
				colvarIdTipoTrauma.AutoIncrement = true;
				colvarIdTipoTrauma.IsNullable = false;
				colvarIdTipoTrauma.IsPrimaryKey = true;
				colvarIdTipoTrauma.IsForeignKey = false;
				colvarIdTipoTrauma.IsReadOnly = false;
				colvarIdTipoTrauma.DefaultSetting = @"";
				colvarIdTipoTrauma.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdTipoTrauma);
				
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
				DataService.Providers["RisProvider"].AddSchema("EMR_TipoTrauma",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("IdTipoTrauma")]
		[Bindable(true)]
		public int IdTipoTrauma 
		{
			get { return GetColumnValue<int>(Columns.IdTipoTrauma); }
			set { SetColumnValue(Columns.IdTipoTrauma, value); }
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
        
		
		private DalRis.EmrTraumaCollection colEmrTraumaRecords;
		public DalRis.EmrTraumaCollection EmrTraumaRecords()
		{
			if(colEmrTraumaRecords == null)
			{
				colEmrTraumaRecords = new DalRis.EmrTraumaCollection().Where(EmrTrauma.Columns.IdTipoTrauma, IdTipoTrauma).Load();
				colEmrTraumaRecords.ListChanged += new ListChangedEventHandler(colEmrTraumaRecords_ListChanged);
			}
			return colEmrTraumaRecords;
		}
				
		void colEmrTraumaRecords_ListChanged(object sender, ListChangedEventArgs e)
		{
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
		        // Set foreign key value
		        colEmrTraumaRecords[e.NewIndex].IdTipoTrauma = IdTipoTrauma;
				colEmrTraumaRecords.ListChanged += new ListChangedEventHandler(colEmrTraumaRecords_ListChanged);
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
			EmrTipoTrauma item = new EmrTipoTrauma();
			
			item.Nombre = varNombre;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varIdTipoTrauma,string varNombre)
		{
			EmrTipoTrauma item = new EmrTipoTrauma();
			
				item.IdTipoTrauma = varIdTipoTrauma;
			
				item.Nombre = varNombre;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn IdTipoTraumaColumn
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
			 public static string IdTipoTrauma = @"idTipoTrauma";
			 public static string Nombre = @"nombre";
						
		}
		#endregion
		
		#region Update PK Collections
		
        public void SetPKValues()
        {
                if (colEmrTraumaRecords != null)
                {
                    foreach (DalRis.EmrTrauma item in colEmrTraumaRecords)
                    {
                        if (item.IdTipoTrauma != IdTipoTrauma)
                        {
                            item.IdTipoTrauma = IdTipoTrauma;
                        }
                    }
               }
		}
        #endregion
    
        #region Deep Save
		
        public void DeepSave()
        {
            Save();
            
                if (colEmrTraumaRecords != null)
                {
                    colEmrTraumaRecords.SaveAll();
               }
		}
        #endregion
	}
}
