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
	/// Strongly-typed collection for the AprEtnium class.
	/// </summary>
    [Serializable]
	public partial class AprEtniumCollection : ActiveList<AprEtnium, AprEtniumCollection>
	{	   
		public AprEtniumCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>AprEtniumCollection</returns>
		public AprEtniumCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                AprEtnium o = this[i];
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
	/// This is an ActiveRecord class which wraps the APR_Etnia table.
	/// </summary>
	[Serializable]
	public partial class AprEtnium : ActiveRecord<AprEtnium>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public AprEtnium()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public AprEtnium(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public AprEtnium(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public AprEtnium(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("APR_Etnia", TableType.Table, DataService.GetInstance("RisProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarIdEtnia = new TableSchema.TableColumn(schema);
				colvarIdEtnia.ColumnName = "idEtnia";
				colvarIdEtnia.DataType = DbType.Int32;
				colvarIdEtnia.MaxLength = 0;
				colvarIdEtnia.AutoIncrement = true;
				colvarIdEtnia.IsNullable = false;
				colvarIdEtnia.IsPrimaryKey = true;
				colvarIdEtnia.IsForeignKey = false;
				colvarIdEtnia.IsReadOnly = false;
				colvarIdEtnia.DefaultSetting = @"";
				colvarIdEtnia.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdEtnia);
				
				TableSchema.TableColumn colvarNombre = new TableSchema.TableColumn(schema);
				colvarNombre.ColumnName = "nombre";
				colvarNombre.DataType = DbType.String;
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
				DataService.Providers["RisProvider"].AddSchema("APR_Etnia",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("IdEtnia")]
		[Bindable(true)]
		public int IdEtnia 
		{
			get { return GetColumnValue<int>(Columns.IdEtnia); }
			set { SetColumnValue(Columns.IdEtnia, value); }
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
        
		
		private DalRis.SysPacienteCollection colSysPacienteRecords;
		public DalRis.SysPacienteCollection SysPacienteRecords()
		{
			if(colSysPacienteRecords == null)
			{
				colSysPacienteRecords = new DalRis.SysPacienteCollection().Where(SysPaciente.Columns.IdEtnia, IdEtnia).Load();
				colSysPacienteRecords.ListChanged += new ListChangedEventHandler(colSysPacienteRecords_ListChanged);
			}
			return colSysPacienteRecords;
		}
				
		void colSysPacienteRecords_ListChanged(object sender, ListChangedEventArgs e)
		{
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
		        // Set foreign key value
		        colSysPacienteRecords[e.NewIndex].IdEtnia = IdEtnia;
				colSysPacienteRecords.ListChanged += new ListChangedEventHandler(colSysPacienteRecords_ListChanged);
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
			AprEtnium item = new AprEtnium();
			
			item.Nombre = varNombre;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varIdEtnia,string varNombre)
		{
			AprEtnium item = new AprEtnium();
			
				item.IdEtnia = varIdEtnia;
			
				item.Nombre = varNombre;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn IdEtniaColumn
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
			 public static string IdEtnia = @"idEtnia";
			 public static string Nombre = @"nombre";
						
		}
		#endregion
		
		#region Update PK Collections
		
        public void SetPKValues()
        {
                if (colSysPacienteRecords != null)
                {
                    foreach (DalRis.SysPaciente item in colSysPacienteRecords)
                    {
                        if (item.IdEtnia != IdEtnia)
                        {
                            item.IdEtnia = IdEtnia;
                        }
                    }
               }
		}
        #endregion
    
        #region Deep Save
		
        public void DeepSave()
        {
            Save();
            
                if (colSysPacienteRecords != null)
                {
                    colSysPacienteRecords.SaveAll();
               }
		}
        #endregion
	}
}
