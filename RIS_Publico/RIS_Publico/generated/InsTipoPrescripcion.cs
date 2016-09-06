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
	/// Strongly-typed collection for the InsTipoPrescripcion class.
	/// </summary>
    [Serializable]
	public partial class InsTipoPrescripcionCollection : ActiveList<InsTipoPrescripcion, InsTipoPrescripcionCollection>
	{	   
		public InsTipoPrescripcionCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>InsTipoPrescripcionCollection</returns>
		public InsTipoPrescripcionCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                InsTipoPrescripcion o = this[i];
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
	/// This is an ActiveRecord class which wraps the INS_TipoPrescripcion table.
	/// </summary>
	[Serializable]
	public partial class InsTipoPrescripcion : ActiveRecord<InsTipoPrescripcion>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public InsTipoPrescripcion()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public InsTipoPrescripcion(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public InsTipoPrescripcion(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public InsTipoPrescripcion(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("INS_TipoPrescripcion", TableType.Table, DataService.GetInstance("RisProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarIdTipoPrescripcion = new TableSchema.TableColumn(schema);
				colvarIdTipoPrescripcion.ColumnName = "idTipoPrescripcion";
				colvarIdTipoPrescripcion.DataType = DbType.Int32;
				colvarIdTipoPrescripcion.MaxLength = 0;
				colvarIdTipoPrescripcion.AutoIncrement = true;
				colvarIdTipoPrescripcion.IsNullable = false;
				colvarIdTipoPrescripcion.IsPrimaryKey = true;
				colvarIdTipoPrescripcion.IsForeignKey = false;
				colvarIdTipoPrescripcion.IsReadOnly = false;
				colvarIdTipoPrescripcion.DefaultSetting = @"";
				colvarIdTipoPrescripcion.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdTipoPrescripcion);
				
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
				DataService.Providers["RisProvider"].AddSchema("INS_TipoPrescripcion",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("IdTipoPrescripcion")]
		[Bindable(true)]
		public int IdTipoPrescripcion 
		{
			get { return GetColumnValue<int>(Columns.IdTipoPrescripcion); }
			set { SetColumnValue(Columns.IdTipoPrescripcion, value); }
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
        
		
		private DalRis.InsPrescripcionCollection colInsPrescripcionRecords;
		public DalRis.InsPrescripcionCollection InsPrescripcionRecords()
		{
			if(colInsPrescripcionRecords == null)
			{
				colInsPrescripcionRecords = new DalRis.InsPrescripcionCollection().Where(InsPrescripcion.Columns.IdTipoPrescripcion, IdTipoPrescripcion).Load();
				colInsPrescripcionRecords.ListChanged += new ListChangedEventHandler(colInsPrescripcionRecords_ListChanged);
			}
			return colInsPrescripcionRecords;
		}
				
		void colInsPrescripcionRecords_ListChanged(object sender, ListChangedEventArgs e)
		{
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
		        // Set foreign key value
		        colInsPrescripcionRecords[e.NewIndex].IdTipoPrescripcion = IdTipoPrescripcion;
				colInsPrescripcionRecords.ListChanged += new ListChangedEventHandler(colInsPrescripcionRecords_ListChanged);
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
			InsTipoPrescripcion item = new InsTipoPrescripcion();
			
			item.Nombre = varNombre;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varIdTipoPrescripcion,string varNombre)
		{
			InsTipoPrescripcion item = new InsTipoPrescripcion();
			
				item.IdTipoPrescripcion = varIdTipoPrescripcion;
			
				item.Nombre = varNombre;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn IdTipoPrescripcionColumn
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
			 public static string IdTipoPrescripcion = @"idTipoPrescripcion";
			 public static string Nombre = @"nombre";
						
		}
		#endregion
		
		#region Update PK Collections
		
        public void SetPKValues()
        {
                if (colInsPrescripcionRecords != null)
                {
                    foreach (DalRis.InsPrescripcion item in colInsPrescripcionRecords)
                    {
                        if (item.IdTipoPrescripcion != IdTipoPrescripcion)
                        {
                            item.IdTipoPrescripcion = IdTipoPrescripcion;
                        }
                    }
               }
		}
        #endregion
    
        #region Deep Save
		
        public void DeepSave()
        {
            Save();
            
                if (colInsPrescripcionRecords != null)
                {
                    colInsPrescripcionRecords.SaveAll();
               }
		}
        #endregion
	}
}
