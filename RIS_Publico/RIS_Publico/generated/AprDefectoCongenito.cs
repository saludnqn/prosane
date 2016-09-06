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
	/// Strongly-typed collection for the AprDefectoCongenito class.
	/// </summary>
    [Serializable]
	public partial class AprDefectoCongenitoCollection : ActiveList<AprDefectoCongenito, AprDefectoCongenitoCollection>
	{	   
		public AprDefectoCongenitoCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>AprDefectoCongenitoCollection</returns>
		public AprDefectoCongenitoCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                AprDefectoCongenito o = this[i];
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
	/// This is an ActiveRecord class which wraps the APR_DefectoCongenito table.
	/// </summary>
	[Serializable]
	public partial class AprDefectoCongenito : ActiveRecord<AprDefectoCongenito>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public AprDefectoCongenito()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public AprDefectoCongenito(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public AprDefectoCongenito(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public AprDefectoCongenito(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("APR_DefectoCongenito", TableType.Table, DataService.GetInstance("RisProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarIdDefectoCongenito = new TableSchema.TableColumn(schema);
				colvarIdDefectoCongenito.ColumnName = "idDefectoCongenito";
				colvarIdDefectoCongenito.DataType = DbType.Int32;
				colvarIdDefectoCongenito.MaxLength = 0;
				colvarIdDefectoCongenito.AutoIncrement = true;
				colvarIdDefectoCongenito.IsNullable = false;
				colvarIdDefectoCongenito.IsPrimaryKey = true;
				colvarIdDefectoCongenito.IsForeignKey = false;
				colvarIdDefectoCongenito.IsReadOnly = false;
				colvarIdDefectoCongenito.DefaultSetting = @"";
				colvarIdDefectoCongenito.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdDefectoCongenito);
				
				TableSchema.TableColumn colvarNombre = new TableSchema.TableColumn(schema);
				colvarNombre.ColumnName = "nombre";
				colvarNombre.DataType = DbType.AnsiString;
				colvarNombre.MaxLength = 50;
				colvarNombre.AutoIncrement = false;
				colvarNombre.IsNullable = false;
				colvarNombre.IsPrimaryKey = false;
				colvarNombre.IsForeignKey = false;
				colvarNombre.IsReadOnly = false;
				colvarNombre.DefaultSetting = @"";
				colvarNombre.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNombre);
				
				TableSchema.TableColumn colvarCreatedBy = new TableSchema.TableColumn(schema);
				colvarCreatedBy.ColumnName = "CreatedBy";
				colvarCreatedBy.DataType = DbType.AnsiString;
				colvarCreatedBy.MaxLength = 50;
				colvarCreatedBy.AutoIncrement = false;
				colvarCreatedBy.IsNullable = true;
				colvarCreatedBy.IsPrimaryKey = false;
				colvarCreatedBy.IsForeignKey = false;
				colvarCreatedBy.IsReadOnly = false;
				colvarCreatedBy.DefaultSetting = @"";
				colvarCreatedBy.ForeignKeyTableName = "";
				schema.Columns.Add(colvarCreatedBy);
				
				TableSchema.TableColumn colvarCreatedOn = new TableSchema.TableColumn(schema);
				colvarCreatedOn.ColumnName = "CreatedOn";
				colvarCreatedOn.DataType = DbType.DateTime;
				colvarCreatedOn.MaxLength = 0;
				colvarCreatedOn.AutoIncrement = false;
				colvarCreatedOn.IsNullable = true;
				colvarCreatedOn.IsPrimaryKey = false;
				colvarCreatedOn.IsForeignKey = false;
				colvarCreatedOn.IsReadOnly = false;
				colvarCreatedOn.DefaultSetting = @"";
				colvarCreatedOn.ForeignKeyTableName = "";
				schema.Columns.Add(colvarCreatedOn);
				
				TableSchema.TableColumn colvarModifiedBy = new TableSchema.TableColumn(schema);
				colvarModifiedBy.ColumnName = "ModifiedBy";
				colvarModifiedBy.DataType = DbType.AnsiString;
				colvarModifiedBy.MaxLength = 50;
				colvarModifiedBy.AutoIncrement = false;
				colvarModifiedBy.IsNullable = true;
				colvarModifiedBy.IsPrimaryKey = false;
				colvarModifiedBy.IsForeignKey = false;
				colvarModifiedBy.IsReadOnly = false;
				colvarModifiedBy.DefaultSetting = @"";
				colvarModifiedBy.ForeignKeyTableName = "";
				schema.Columns.Add(colvarModifiedBy);
				
				TableSchema.TableColumn colvarModifiedOn = new TableSchema.TableColumn(schema);
				colvarModifiedOn.ColumnName = "ModifiedOn";
				colvarModifiedOn.DataType = DbType.DateTime;
				colvarModifiedOn.MaxLength = 0;
				colvarModifiedOn.AutoIncrement = false;
				colvarModifiedOn.IsNullable = true;
				colvarModifiedOn.IsPrimaryKey = false;
				colvarModifiedOn.IsForeignKey = false;
				colvarModifiedOn.IsReadOnly = false;
				colvarModifiedOn.DefaultSetting = @"";
				colvarModifiedOn.ForeignKeyTableName = "";
				schema.Columns.Add(colvarModifiedOn);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["RisProvider"].AddSchema("APR_DefectoCongenito",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("IdDefectoCongenito")]
		[Bindable(true)]
		public int IdDefectoCongenito 
		{
			get { return GetColumnValue<int>(Columns.IdDefectoCongenito); }
			set { SetColumnValue(Columns.IdDefectoCongenito, value); }
		}
		  
		[XmlAttribute("Nombre")]
		[Bindable(true)]
		public string Nombre 
		{
			get { return GetColumnValue<string>(Columns.Nombre); }
			set { SetColumnValue(Columns.Nombre, value); }
		}
		  
		[XmlAttribute("CreatedBy")]
		[Bindable(true)]
		public string CreatedBy 
		{
			get { return GetColumnValue<string>(Columns.CreatedBy); }
			set { SetColumnValue(Columns.CreatedBy, value); }
		}
		  
		[XmlAttribute("CreatedOn")]
		[Bindable(true)]
		public DateTime? CreatedOn 
		{
			get { return GetColumnValue<DateTime?>(Columns.CreatedOn); }
			set { SetColumnValue(Columns.CreatedOn, value); }
		}
		  
		[XmlAttribute("ModifiedBy")]
		[Bindable(true)]
		public string ModifiedBy 
		{
			get { return GetColumnValue<string>(Columns.ModifiedBy); }
			set { SetColumnValue(Columns.ModifiedBy, value); }
		}
		  
		[XmlAttribute("ModifiedOn")]
		[Bindable(true)]
		public DateTime? ModifiedOn 
		{
			get { return GetColumnValue<DateTime?>(Columns.ModifiedOn); }
			set { SetColumnValue(Columns.ModifiedOn, value); }
		}
		
		#endregion
		
		
		#region PrimaryKey Methods		
		
        protected override void SetPrimaryKey(object oValue)
        {
            base.SetPrimaryKey(oValue);
            
            SetPKValues();
        }
        
		
		private DalRis.AprRelRecienNacidoDefectoCongenitoCollection colAprRelRecienNacidoDefectoCongenitoRecords;
		public DalRis.AprRelRecienNacidoDefectoCongenitoCollection AprRelRecienNacidoDefectoCongenitoRecords()
		{
			if(colAprRelRecienNacidoDefectoCongenitoRecords == null)
			{
				colAprRelRecienNacidoDefectoCongenitoRecords = new DalRis.AprRelRecienNacidoDefectoCongenitoCollection().Where(AprRelRecienNacidoDefectoCongenito.Columns.IdDefectoCongenito, IdDefectoCongenito).Load();
				colAprRelRecienNacidoDefectoCongenitoRecords.ListChanged += new ListChangedEventHandler(colAprRelRecienNacidoDefectoCongenitoRecords_ListChanged);
			}
			return colAprRelRecienNacidoDefectoCongenitoRecords;
		}
				
		void colAprRelRecienNacidoDefectoCongenitoRecords_ListChanged(object sender, ListChangedEventArgs e)
		{
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
		        // Set foreign key value
		        colAprRelRecienNacidoDefectoCongenitoRecords[e.NewIndex].IdDefectoCongenito = IdDefectoCongenito;
				colAprRelRecienNacidoDefectoCongenitoRecords.ListChanged += new ListChangedEventHandler(colAprRelRecienNacidoDefectoCongenitoRecords_ListChanged);
            }
		}
		#endregion
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varNombre,string varCreatedBy,DateTime? varCreatedOn,string varModifiedBy,DateTime? varModifiedOn)
		{
			AprDefectoCongenito item = new AprDefectoCongenito();
			
			item.Nombre = varNombre;
			
			item.CreatedBy = varCreatedBy;
			
			item.CreatedOn = varCreatedOn;
			
			item.ModifiedBy = varModifiedBy;
			
			item.ModifiedOn = varModifiedOn;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varIdDefectoCongenito,string varNombre,string varCreatedBy,DateTime? varCreatedOn,string varModifiedBy,DateTime? varModifiedOn)
		{
			AprDefectoCongenito item = new AprDefectoCongenito();
			
				item.IdDefectoCongenito = varIdDefectoCongenito;
			
				item.Nombre = varNombre;
			
				item.CreatedBy = varCreatedBy;
			
				item.CreatedOn = varCreatedOn;
			
				item.ModifiedBy = varModifiedBy;
			
				item.ModifiedOn = varModifiedOn;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn IdDefectoCongenitoColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn NombreColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn CreatedByColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn CreatedOnColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn ModifiedByColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn ModifiedOnColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string IdDefectoCongenito = @"idDefectoCongenito";
			 public static string Nombre = @"nombre";
			 public static string CreatedBy = @"CreatedBy";
			 public static string CreatedOn = @"CreatedOn";
			 public static string ModifiedBy = @"ModifiedBy";
			 public static string ModifiedOn = @"ModifiedOn";
						
		}
		#endregion
		
		#region Update PK Collections
		
        public void SetPKValues()
        {
                if (colAprRelRecienNacidoDefectoCongenitoRecords != null)
                {
                    foreach (DalRis.AprRelRecienNacidoDefectoCongenito item in colAprRelRecienNacidoDefectoCongenitoRecords)
                    {
                        if (item.IdDefectoCongenito != IdDefectoCongenito)
                        {
                            item.IdDefectoCongenito = IdDefectoCongenito;
                        }
                    }
               }
		}
        #endregion
    
        #region Deep Save
		
        public void DeepSave()
        {
            Save();
            
                if (colAprRelRecienNacidoDefectoCongenitoRecords != null)
                {
                    colAprRelRecienNacidoDefectoCongenitoRecords.SaveAll();
               }
		}
        #endregion
	}
}
