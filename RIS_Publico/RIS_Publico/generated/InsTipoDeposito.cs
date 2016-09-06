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
	/// Strongly-typed collection for the InsTipoDeposito class.
	/// </summary>
    [Serializable]
	public partial class InsTipoDepositoCollection : ActiveList<InsTipoDeposito, InsTipoDepositoCollection>
	{	   
		public InsTipoDepositoCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>InsTipoDepositoCollection</returns>
		public InsTipoDepositoCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                InsTipoDeposito o = this[i];
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
	/// This is an ActiveRecord class which wraps the INS_TipoDeposito table.
	/// </summary>
	[Serializable]
	public partial class InsTipoDeposito : ActiveRecord<InsTipoDeposito>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public InsTipoDeposito()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public InsTipoDeposito(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public InsTipoDeposito(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public InsTipoDeposito(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("INS_TipoDeposito", TableType.Table, DataService.GetInstance("RisProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarIdTipoDeposito = new TableSchema.TableColumn(schema);
				colvarIdTipoDeposito.ColumnName = "idTipoDeposito";
				colvarIdTipoDeposito.DataType = DbType.Int32;
				colvarIdTipoDeposito.MaxLength = 0;
				colvarIdTipoDeposito.AutoIncrement = true;
				colvarIdTipoDeposito.IsNullable = false;
				colvarIdTipoDeposito.IsPrimaryKey = true;
				colvarIdTipoDeposito.IsForeignKey = false;
				colvarIdTipoDeposito.IsReadOnly = false;
				colvarIdTipoDeposito.DefaultSetting = @"";
				colvarIdTipoDeposito.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdTipoDeposito);
				
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
				
				TableSchema.TableColumn colvarDescripcion = new TableSchema.TableColumn(schema);
				colvarDescripcion.ColumnName = "descripcion";
				colvarDescripcion.DataType = DbType.AnsiString;
				colvarDescripcion.MaxLength = 200;
				colvarDescripcion.AutoIncrement = false;
				colvarDescripcion.IsNullable = false;
				colvarDescripcion.IsPrimaryKey = false;
				colvarDescripcion.IsForeignKey = false;
				colvarDescripcion.IsReadOnly = false;
				
						colvarDescripcion.DefaultSetting = @"('')";
				colvarDescripcion.ForeignKeyTableName = "";
				schema.Columns.Add(colvarDescripcion);
				
				TableSchema.TableColumn colvarBaja = new TableSchema.TableColumn(schema);
				colvarBaja.ColumnName = "baja";
				colvarBaja.DataType = DbType.Boolean;
				colvarBaja.MaxLength = 0;
				colvarBaja.AutoIncrement = false;
				colvarBaja.IsNullable = false;
				colvarBaja.IsPrimaryKey = false;
				colvarBaja.IsForeignKey = false;
				colvarBaja.IsReadOnly = false;
				
						colvarBaja.DefaultSetting = @"((0))";
				colvarBaja.ForeignKeyTableName = "";
				schema.Columns.Add(colvarBaja);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["RisProvider"].AddSchema("INS_TipoDeposito",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("IdTipoDeposito")]
		[Bindable(true)]
		public int IdTipoDeposito 
		{
			get { return GetColumnValue<int>(Columns.IdTipoDeposito); }
			set { SetColumnValue(Columns.IdTipoDeposito, value); }
		}
		  
		[XmlAttribute("Nombre")]
		[Bindable(true)]
		public string Nombre 
		{
			get { return GetColumnValue<string>(Columns.Nombre); }
			set { SetColumnValue(Columns.Nombre, value); }
		}
		  
		[XmlAttribute("Descripcion")]
		[Bindable(true)]
		public string Descripcion 
		{
			get { return GetColumnValue<string>(Columns.Descripcion); }
			set { SetColumnValue(Columns.Descripcion, value); }
		}
		  
		[XmlAttribute("Baja")]
		[Bindable(true)]
		public bool Baja 
		{
			get { return GetColumnValue<bool>(Columns.Baja); }
			set { SetColumnValue(Columns.Baja, value); }
		}
		
		#endregion
		
		
		#region PrimaryKey Methods		
		
        protected override void SetPrimaryKey(object oValue)
        {
            base.SetPrimaryKey(oValue);
            
            SetPKValues();
        }
        
		
		private DalRis.InsDepositoCollection colInsDepositoRecords;
		public DalRis.InsDepositoCollection InsDepositoRecords()
		{
			if(colInsDepositoRecords == null)
			{
				colInsDepositoRecords = new DalRis.InsDepositoCollection().Where(InsDeposito.Columns.IdTipoDeposito, IdTipoDeposito).Load();
				colInsDepositoRecords.ListChanged += new ListChangedEventHandler(colInsDepositoRecords_ListChanged);
			}
			return colInsDepositoRecords;
		}
				
		void colInsDepositoRecords_ListChanged(object sender, ListChangedEventArgs e)
		{
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
		        // Set foreign key value
		        colInsDepositoRecords[e.NewIndex].IdTipoDeposito = IdTipoDeposito;
				colInsDepositoRecords.ListChanged += new ListChangedEventHandler(colInsDepositoRecords_ListChanged);
            }
		}
		#endregion
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varNombre,string varDescripcion,bool varBaja)
		{
			InsTipoDeposito item = new InsTipoDeposito();
			
			item.Nombre = varNombre;
			
			item.Descripcion = varDescripcion;
			
			item.Baja = varBaja;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varIdTipoDeposito,string varNombre,string varDescripcion,bool varBaja)
		{
			InsTipoDeposito item = new InsTipoDeposito();
			
				item.IdTipoDeposito = varIdTipoDeposito;
			
				item.Nombre = varNombre;
			
				item.Descripcion = varDescripcion;
			
				item.Baja = varBaja;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn IdTipoDepositoColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn NombreColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn DescripcionColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn BajaColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string IdTipoDeposito = @"idTipoDeposito";
			 public static string Nombre = @"nombre";
			 public static string Descripcion = @"descripcion";
			 public static string Baja = @"baja";
						
		}
		#endregion
		
		#region Update PK Collections
		
        public void SetPKValues()
        {
                if (colInsDepositoRecords != null)
                {
                    foreach (DalRis.InsDeposito item in colInsDepositoRecords)
                    {
                        if (item.IdTipoDeposito != IdTipoDeposito)
                        {
                            item.IdTipoDeposito = IdTipoDeposito;
                        }
                    }
               }
		}
        #endregion
    
        #region Deep Save
		
        public void DeepSave()
        {
            Save();
            
                if (colInsDepositoRecords != null)
                {
                    colInsDepositoRecords.SaveAll();
               }
		}
        #endregion
	}
}
