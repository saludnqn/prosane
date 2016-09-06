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
	/// Strongly-typed collection for the BdsSerologium class.
	/// </summary>
    [Serializable]
	public partial class BdsSerologiumCollection : ActiveList<BdsSerologium, BdsSerologiumCollection>
	{	   
		public BdsSerologiumCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>BdsSerologiumCollection</returns>
		public BdsSerologiumCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                BdsSerologium o = this[i];
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
	/// This is an ActiveRecord class which wraps the BDS_Serologia table.
	/// </summary>
	[Serializable]
	public partial class BdsSerologium : ActiveRecord<BdsSerologium>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public BdsSerologium()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public BdsSerologium(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public BdsSerologium(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public BdsSerologium(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("BDS_Serologia", TableType.Table, DataService.GetInstance("RisProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarIdSerologia = new TableSchema.TableColumn(schema);
				colvarIdSerologia.ColumnName = "idSerologia";
				colvarIdSerologia.DataType = DbType.Int32;
				colvarIdSerologia.MaxLength = 0;
				colvarIdSerologia.AutoIncrement = true;
				colvarIdSerologia.IsNullable = false;
				colvarIdSerologia.IsPrimaryKey = true;
				colvarIdSerologia.IsForeignKey = false;
				colvarIdSerologia.IsReadOnly = false;
				colvarIdSerologia.DefaultSetting = @"";
				colvarIdSerologia.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdSerologia);
				
				TableSchema.TableColumn colvarIdAdmision = new TableSchema.TableColumn(schema);
				colvarIdAdmision.ColumnName = "idAdmision";
				colvarIdAdmision.DataType = DbType.Int32;
				colvarIdAdmision.MaxLength = 0;
				colvarIdAdmision.AutoIncrement = false;
				colvarIdAdmision.IsNullable = false;
				colvarIdAdmision.IsPrimaryKey = false;
				colvarIdAdmision.IsForeignKey = false;
				colvarIdAdmision.IsReadOnly = false;
				colvarIdAdmision.DefaultSetting = @"";
				colvarIdAdmision.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdAdmision);
				
				TableSchema.TableColumn colvarFechaYHora = new TableSchema.TableColumn(schema);
				colvarFechaYHora.ColumnName = "fechaYHora";
				colvarFechaYHora.DataType = DbType.DateTime;
				colvarFechaYHora.MaxLength = 0;
				colvarFechaYHora.AutoIncrement = false;
				colvarFechaYHora.IsNullable = false;
				colvarFechaYHora.IsPrimaryKey = false;
				colvarFechaYHora.IsForeignKey = false;
				colvarFechaYHora.IsReadOnly = false;
				colvarFechaYHora.DefaultSetting = @"";
				colvarFechaYHora.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFechaYHora);
				
				TableSchema.TableColumn colvarBvdr = new TableSchema.TableColumn(schema);
				colvarBvdr.ColumnName = "BVDR";
				colvarBvdr.DataType = DbType.AnsiString;
				colvarBvdr.MaxLength = 20;
				colvarBvdr.AutoIncrement = false;
				colvarBvdr.IsNullable = false;
				colvarBvdr.IsPrimaryKey = false;
				colvarBvdr.IsForeignKey = false;
				colvarBvdr.IsReadOnly = false;
				colvarBvdr.DefaultSetting = @"";
				colvarBvdr.ForeignKeyTableName = "";
				schema.Columns.Add(colvarBvdr);
				
				TableSchema.TableColumn colvarBhud = new TableSchema.TableColumn(schema);
				colvarBhud.ColumnName = "BHUD";
				colvarBhud.DataType = DbType.AnsiString;
				colvarBhud.MaxLength = 20;
				colvarBhud.AutoIncrement = false;
				colvarBhud.IsNullable = false;
				colvarBhud.IsPrimaryKey = false;
				colvarBhud.IsForeignKey = false;
				colvarBhud.IsReadOnly = false;
				colvarBhud.DefaultSetting = @"";
				colvarBhud.ForeignKeyTableName = "";
				schema.Columns.Add(colvarBhud);
				
				TableSchema.TableColumn colvarBche = new TableSchema.TableColumn(schema);
				colvarBche.ColumnName = "BCHE";
				colvarBche.DataType = DbType.AnsiString;
				colvarBche.MaxLength = 20;
				colvarBche.AutoIncrement = false;
				colvarBche.IsNullable = false;
				colvarBche.IsPrimaryKey = false;
				colvarBche.IsForeignKey = false;
				colvarBche.IsReadOnly = false;
				colvarBche.DefaultSetting = @"";
				colvarBche.ForeignKeyTableName = "";
				schema.Columns.Add(colvarBche);
				
				TableSchema.TableColumn colvarBchha = new TableSchema.TableColumn(schema);
				colvarBchha.ColumnName = "BCHHA";
				colvarBchha.DataType = DbType.AnsiString;
				colvarBchha.MaxLength = 20;
				colvarBchha.AutoIncrement = false;
				colvarBchha.IsNullable = false;
				colvarBchha.IsPrimaryKey = false;
				colvarBchha.IsForeignKey = false;
				colvarBchha.IsReadOnly = false;
				colvarBchha.DefaultSetting = @"";
				colvarBchha.ForeignKeyTableName = "";
				schema.Columns.Add(colvarBchha);
				
				TableSchema.TableColumn colvarBhc = new TableSchema.TableColumn(schema);
				colvarBhc.ColumnName = "BHC";
				colvarBhc.DataType = DbType.AnsiString;
				colvarBhc.MaxLength = 20;
				colvarBhc.AutoIncrement = false;
				colvarBhc.IsNullable = false;
				colvarBhc.IsPrimaryKey = false;
				colvarBhc.IsForeignKey = false;
				colvarBhc.IsReadOnly = false;
				colvarBhc.DefaultSetting = @"";
				colvarBhc.ForeignKeyTableName = "";
				schema.Columns.Add(colvarBhc);
				
				TableSchema.TableColumn colvarBHBsa = new TableSchema.TableColumn(schema);
				colvarBHBsa.ColumnName = "BHBsa";
				colvarBHBsa.DataType = DbType.AnsiString;
				colvarBHBsa.MaxLength = 20;
				colvarBHBsa.AutoIncrement = false;
				colvarBHBsa.IsNullable = false;
				colvarBHBsa.IsPrimaryKey = false;
				colvarBHBsa.IsForeignKey = false;
				colvarBHBsa.IsReadOnly = false;
				colvarBHBsa.DefaultSetting = @"";
				colvarBHBsa.ForeignKeyTableName = "";
				schema.Columns.Add(colvarBHBsa);
				
				TableSchema.TableColumn colvarBHBc = new TableSchema.TableColumn(schema);
				colvarBHBc.ColumnName = "BHBc";
				colvarBHBc.DataType = DbType.AnsiString;
				colvarBHBc.MaxLength = 20;
				colvarBHBc.AutoIncrement = false;
				colvarBHBc.IsNullable = false;
				colvarBHBc.IsPrimaryKey = false;
				colvarBHBc.IsForeignKey = false;
				colvarBHBc.IsReadOnly = false;
				colvarBHBc.DefaultSetting = @"";
				colvarBHBc.ForeignKeyTableName = "";
				schema.Columns.Add(colvarBHBc);
				
				TableSchema.TableColumn colvarBhiva = new TableSchema.TableColumn(schema);
				colvarBhiva.ColumnName = "BHIVA";
				colvarBhiva.DataType = DbType.AnsiString;
				colvarBhiva.MaxLength = 20;
				colvarBhiva.AutoIncrement = false;
				colvarBhiva.IsNullable = false;
				colvarBhiva.IsPrimaryKey = false;
				colvarBhiva.IsForeignKey = false;
				colvarBhiva.IsReadOnly = false;
				colvarBhiva.DefaultSetting = @"";
				colvarBhiva.ForeignKeyTableName = "";
				schema.Columns.Add(colvarBhiva);
				
				TableSchema.TableColumn colvarBhtl = new TableSchema.TableColumn(schema);
				colvarBhtl.ColumnName = "BHTL";
				colvarBhtl.DataType = DbType.AnsiString;
				colvarBhtl.MaxLength = 20;
				colvarBhtl.AutoIncrement = false;
				colvarBhtl.IsNullable = false;
				colvarBhtl.IsPrimaryKey = false;
				colvarBhtl.IsForeignKey = false;
				colvarBhtl.IsReadOnly = false;
				colvarBhtl.DefaultSetting = @"";
				colvarBhtl.ForeignKeyTableName = "";
				schema.Columns.Add(colvarBhtl);
				
				TableSchema.TableColumn colvarAgP26 = new TableSchema.TableColumn(schema);
				colvarAgP26.ColumnName = "Ag_P26";
				colvarAgP26.DataType = DbType.AnsiString;
				colvarAgP26.MaxLength = 20;
				colvarAgP26.AutoIncrement = false;
				colvarAgP26.IsNullable = false;
				colvarAgP26.IsPrimaryKey = false;
				colvarAgP26.IsForeignKey = false;
				colvarAgP26.IsReadOnly = false;
				colvarAgP26.DefaultSetting = @"";
				colvarAgP26.ForeignKeyTableName = "";
				schema.Columns.Add(colvarAgP26);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["RisProvider"].AddSchema("BDS_Serologia",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("IdSerologia")]
		[Bindable(true)]
		public int IdSerologia 
		{
			get { return GetColumnValue<int>(Columns.IdSerologia); }
			set { SetColumnValue(Columns.IdSerologia, value); }
		}
		  
		[XmlAttribute("IdAdmision")]
		[Bindable(true)]
		public int IdAdmision 
		{
			get { return GetColumnValue<int>(Columns.IdAdmision); }
			set { SetColumnValue(Columns.IdAdmision, value); }
		}
		  
		[XmlAttribute("FechaYHora")]
		[Bindable(true)]
		public DateTime FechaYHora 
		{
			get { return GetColumnValue<DateTime>(Columns.FechaYHora); }
			set { SetColumnValue(Columns.FechaYHora, value); }
		}
		  
		[XmlAttribute("Bvdr")]
		[Bindable(true)]
		public string Bvdr 
		{
			get { return GetColumnValue<string>(Columns.Bvdr); }
			set { SetColumnValue(Columns.Bvdr, value); }
		}
		  
		[XmlAttribute("Bhud")]
		[Bindable(true)]
		public string Bhud 
		{
			get { return GetColumnValue<string>(Columns.Bhud); }
			set { SetColumnValue(Columns.Bhud, value); }
		}
		  
		[XmlAttribute("Bche")]
		[Bindable(true)]
		public string Bche 
		{
			get { return GetColumnValue<string>(Columns.Bche); }
			set { SetColumnValue(Columns.Bche, value); }
		}
		  
		[XmlAttribute("Bchha")]
		[Bindable(true)]
		public string Bchha 
		{
			get { return GetColumnValue<string>(Columns.Bchha); }
			set { SetColumnValue(Columns.Bchha, value); }
		}
		  
		[XmlAttribute("Bhc")]
		[Bindable(true)]
		public string Bhc 
		{
			get { return GetColumnValue<string>(Columns.Bhc); }
			set { SetColumnValue(Columns.Bhc, value); }
		}
		  
		[XmlAttribute("BHBsa")]
		[Bindable(true)]
		public string BHBsa 
		{
			get { return GetColumnValue<string>(Columns.BHBsa); }
			set { SetColumnValue(Columns.BHBsa, value); }
		}
		  
		[XmlAttribute("BHBc")]
		[Bindable(true)]
		public string BHBc 
		{
			get { return GetColumnValue<string>(Columns.BHBc); }
			set { SetColumnValue(Columns.BHBc, value); }
		}
		  
		[XmlAttribute("Bhiva")]
		[Bindable(true)]
		public string Bhiva 
		{
			get { return GetColumnValue<string>(Columns.Bhiva); }
			set { SetColumnValue(Columns.Bhiva, value); }
		}
		  
		[XmlAttribute("Bhtl")]
		[Bindable(true)]
		public string Bhtl 
		{
			get { return GetColumnValue<string>(Columns.Bhtl); }
			set { SetColumnValue(Columns.Bhtl, value); }
		}
		  
		[XmlAttribute("AgP26")]
		[Bindable(true)]
		public string AgP26 
		{
			get { return GetColumnValue<string>(Columns.AgP26); }
			set { SetColumnValue(Columns.AgP26, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(int varIdAdmision,DateTime varFechaYHora,string varBvdr,string varBhud,string varBche,string varBchha,string varBhc,string varBHBsa,string varBHBc,string varBhiva,string varBhtl,string varAgP26)
		{
			BdsSerologium item = new BdsSerologium();
			
			item.IdAdmision = varIdAdmision;
			
			item.FechaYHora = varFechaYHora;
			
			item.Bvdr = varBvdr;
			
			item.Bhud = varBhud;
			
			item.Bche = varBche;
			
			item.Bchha = varBchha;
			
			item.Bhc = varBhc;
			
			item.BHBsa = varBHBsa;
			
			item.BHBc = varBHBc;
			
			item.Bhiva = varBhiva;
			
			item.Bhtl = varBhtl;
			
			item.AgP26 = varAgP26;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varIdSerologia,int varIdAdmision,DateTime varFechaYHora,string varBvdr,string varBhud,string varBche,string varBchha,string varBhc,string varBHBsa,string varBHBc,string varBhiva,string varBhtl,string varAgP26)
		{
			BdsSerologium item = new BdsSerologium();
			
				item.IdSerologia = varIdSerologia;
			
				item.IdAdmision = varIdAdmision;
			
				item.FechaYHora = varFechaYHora;
			
				item.Bvdr = varBvdr;
			
				item.Bhud = varBhud;
			
				item.Bche = varBche;
			
				item.Bchha = varBchha;
			
				item.Bhc = varBhc;
			
				item.BHBsa = varBHBsa;
			
				item.BHBc = varBHBc;
			
				item.Bhiva = varBhiva;
			
				item.Bhtl = varBhtl;
			
				item.AgP26 = varAgP26;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn IdSerologiaColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn IdAdmisionColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn FechaYHoraColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn BvdrColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn BhudColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn BcheColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        public static TableSchema.TableColumn BchhaColumn
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        public static TableSchema.TableColumn BhcColumn
        {
            get { return Schema.Columns[7]; }
        }
        
        
        
        public static TableSchema.TableColumn BHBsaColumn
        {
            get { return Schema.Columns[8]; }
        }
        
        
        
        public static TableSchema.TableColumn BHBcColumn
        {
            get { return Schema.Columns[9]; }
        }
        
        
        
        public static TableSchema.TableColumn BhivaColumn
        {
            get { return Schema.Columns[10]; }
        }
        
        
        
        public static TableSchema.TableColumn BhtlColumn
        {
            get { return Schema.Columns[11]; }
        }
        
        
        
        public static TableSchema.TableColumn AgP26Column
        {
            get { return Schema.Columns[12]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string IdSerologia = @"idSerologia";
			 public static string IdAdmision = @"idAdmision";
			 public static string FechaYHora = @"fechaYHora";
			 public static string Bvdr = @"BVDR";
			 public static string Bhud = @"BHUD";
			 public static string Bche = @"BCHE";
			 public static string Bchha = @"BCHHA";
			 public static string Bhc = @"BHC";
			 public static string BHBsa = @"BHBsa";
			 public static string BHBc = @"BHBc";
			 public static string Bhiva = @"BHIVA";
			 public static string Bhtl = @"BHTL";
			 public static string AgP26 = @"Ag_P26";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
