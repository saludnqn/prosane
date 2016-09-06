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
	/// Strongly-typed collection for the AutVehiculoPmp class.
	/// </summary>
    [Serializable]
	public partial class AutVehiculoPmpCollection : ActiveList<AutVehiculoPmp, AutVehiculoPmpCollection>
	{	   
		public AutVehiculoPmpCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>AutVehiculoPmpCollection</returns>
		public AutVehiculoPmpCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                AutVehiculoPmp o = this[i];
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
	/// This is an ActiveRecord class which wraps the AUT_Vehiculo_PMP table.
	/// </summary>
	[Serializable]
	public partial class AutVehiculoPmp : ActiveRecord<AutVehiculoPmp>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public AutVehiculoPmp()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public AutVehiculoPmp(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public AutVehiculoPmp(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public AutVehiculoPmp(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("AUT_Vehiculo_PMP", TableType.Table, DataService.GetInstance("RisProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarIdVehiculoPMP = new TableSchema.TableColumn(schema);
				colvarIdVehiculoPMP.ColumnName = "idVehiculoPMP";
				colvarIdVehiculoPMP.DataType = DbType.Int32;
				colvarIdVehiculoPMP.MaxLength = 0;
				colvarIdVehiculoPMP.AutoIncrement = true;
				colvarIdVehiculoPMP.IsNullable = false;
				colvarIdVehiculoPMP.IsPrimaryKey = true;
				colvarIdVehiculoPMP.IsForeignKey = false;
				colvarIdVehiculoPMP.IsReadOnly = false;
				colvarIdVehiculoPMP.DefaultSetting = @"";
				colvarIdVehiculoPMP.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdVehiculoPMP);
				
				TableSchema.TableColumn colvarIdVehiculo = new TableSchema.TableColumn(schema);
				colvarIdVehiculo.ColumnName = "idVehiculo";
				colvarIdVehiculo.DataType = DbType.Int32;
				colvarIdVehiculo.MaxLength = 0;
				colvarIdVehiculo.AutoIncrement = false;
				colvarIdVehiculo.IsNullable = false;
				colvarIdVehiculo.IsPrimaryKey = false;
				colvarIdVehiculo.IsForeignKey = true;
				colvarIdVehiculo.IsReadOnly = false;
				colvarIdVehiculo.DefaultSetting = @"";
				
					colvarIdVehiculo.ForeignKeyTableName = "AUT_Vehiculo";
				schema.Columns.Add(colvarIdVehiculo);
				
				TableSchema.TableColumn colvarIdPMP = new TableSchema.TableColumn(schema);
				colvarIdPMP.ColumnName = "idPMP";
				colvarIdPMP.DataType = DbType.Int32;
				colvarIdPMP.MaxLength = 0;
				colvarIdPMP.AutoIncrement = false;
				colvarIdPMP.IsNullable = false;
				colvarIdPMP.IsPrimaryKey = false;
				colvarIdPMP.IsForeignKey = true;
				colvarIdPMP.IsReadOnly = false;
				colvarIdPMP.DefaultSetting = @"";
				
					colvarIdPMP.ForeignKeyTableName = "AUT_PMP";
				schema.Columns.Add(colvarIdPMP);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["RisProvider"].AddSchema("AUT_Vehiculo_PMP",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("IdVehiculoPMP")]
		[Bindable(true)]
		public int IdVehiculoPMP 
		{
			get { return GetColumnValue<int>(Columns.IdVehiculoPMP); }
			set { SetColumnValue(Columns.IdVehiculoPMP, value); }
		}
		  
		[XmlAttribute("IdVehiculo")]
		[Bindable(true)]
		public int IdVehiculo 
		{
			get { return GetColumnValue<int>(Columns.IdVehiculo); }
			set { SetColumnValue(Columns.IdVehiculo, value); }
		}
		  
		[XmlAttribute("IdPMP")]
		[Bindable(true)]
		public int IdPMP 
		{
			get { return GetColumnValue<int>(Columns.IdPMP); }
			set { SetColumnValue(Columns.IdPMP, value); }
		}
		
		#endregion
		
		
		#region PrimaryKey Methods		
		
        protected override void SetPrimaryKey(object oValue)
        {
            base.SetPrimaryKey(oValue);
            
            SetPKValues();
        }
        
		
		private DalRis.AutHistoricoVehiculoPmpCollection colAutHistoricoVehiculoPmpRecords;
		public DalRis.AutHistoricoVehiculoPmpCollection AutHistoricoVehiculoPmpRecords()
		{
			if(colAutHistoricoVehiculoPmpRecords == null)
			{
				colAutHistoricoVehiculoPmpRecords = new DalRis.AutHistoricoVehiculoPmpCollection().Where(AutHistoricoVehiculoPmp.Columns.IdVehiculoPMP, IdVehiculoPMP).Load();
				colAutHistoricoVehiculoPmpRecords.ListChanged += new ListChangedEventHandler(colAutHistoricoVehiculoPmpRecords_ListChanged);
			}
			return colAutHistoricoVehiculoPmpRecords;
		}
				
		void colAutHistoricoVehiculoPmpRecords_ListChanged(object sender, ListChangedEventArgs e)
		{
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
		        // Set foreign key value
		        colAutHistoricoVehiculoPmpRecords[e.NewIndex].IdVehiculoPMP = IdVehiculoPMP;
				colAutHistoricoVehiculoPmpRecords.ListChanged += new ListChangedEventHandler(colAutHistoricoVehiculoPmpRecords_ListChanged);
            }
		}
		#endregion
		
			
		
		#region ForeignKey Properties
		
		/// <summary>
		/// Returns a AutPmp ActiveRecord object related to this AutVehiculoPmp
		/// 
		/// </summary>
		public DalRis.AutPmp AutPmp
		{
			get { return DalRis.AutPmp.FetchByID(this.IdPMP); }
			set { SetColumnValue("idPMP", value.IdPMP); }
		}
		
		
		/// <summary>
		/// Returns a AutVehiculo ActiveRecord object related to this AutVehiculoPmp
		/// 
		/// </summary>
		public DalRis.AutVehiculo AutVehiculo
		{
			get { return DalRis.AutVehiculo.FetchByID(this.IdVehiculo); }
			set { SetColumnValue("idVehiculo", value.IdVehiculo); }
		}
		
		
		#endregion
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(int varIdVehiculo,int varIdPMP)
		{
			AutVehiculoPmp item = new AutVehiculoPmp();
			
			item.IdVehiculo = varIdVehiculo;
			
			item.IdPMP = varIdPMP;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varIdVehiculoPMP,int varIdVehiculo,int varIdPMP)
		{
			AutVehiculoPmp item = new AutVehiculoPmp();
			
				item.IdVehiculoPMP = varIdVehiculoPMP;
			
				item.IdVehiculo = varIdVehiculo;
			
				item.IdPMP = varIdPMP;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn IdVehiculoPMPColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn IdVehiculoColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn IdPMPColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string IdVehiculoPMP = @"idVehiculoPMP";
			 public static string IdVehiculo = @"idVehiculo";
			 public static string IdPMP = @"idPMP";
						
		}
		#endregion
		
		#region Update PK Collections
		
        public void SetPKValues()
        {
                if (colAutHistoricoVehiculoPmpRecords != null)
                {
                    foreach (DalRis.AutHistoricoVehiculoPmp item in colAutHistoricoVehiculoPmpRecords)
                    {
                        if (item.IdVehiculoPMP != IdVehiculoPMP)
                        {
                            item.IdVehiculoPMP = IdVehiculoPMP;
                        }
                    }
               }
		}
        #endregion
    
        #region Deep Save
		
        public void DeepSave()
        {
            Save();
            
                if (colAutHistoricoVehiculoPmpRecords != null)
                {
                    colAutHistoricoVehiculoPmpRecords.SaveAll();
               }
		}
        #endregion
	}
}
