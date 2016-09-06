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
	/// Strongly-typed collection for the FacTipoPractica class.
	/// </summary>
    [Serializable]
	public partial class FacTipoPracticaCollection : ActiveList<FacTipoPractica, FacTipoPracticaCollection>
	{	   
		public FacTipoPracticaCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>FacTipoPracticaCollection</returns>
		public FacTipoPracticaCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                FacTipoPractica o = this[i];
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
	/// This is an ActiveRecord class which wraps the FAC_TipoPractica table.
	/// </summary>
	[Serializable]
	public partial class FacTipoPractica : ActiveRecord<FacTipoPractica>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public FacTipoPractica()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public FacTipoPractica(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public FacTipoPractica(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public FacTipoPractica(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("FAC_TipoPractica", TableType.Table, DataService.GetInstance("RisProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarIdTipoPractica = new TableSchema.TableColumn(schema);
				colvarIdTipoPractica.ColumnName = "idTipoPractica";
				colvarIdTipoPractica.DataType = DbType.Int32;
				colvarIdTipoPractica.MaxLength = 0;
				colvarIdTipoPractica.AutoIncrement = true;
				colvarIdTipoPractica.IsNullable = false;
				colvarIdTipoPractica.IsPrimaryKey = true;
				colvarIdTipoPractica.IsForeignKey = false;
				colvarIdTipoPractica.IsReadOnly = false;
				colvarIdTipoPractica.DefaultSetting = @"";
				colvarIdTipoPractica.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdTipoPractica);
				
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
				DataService.Providers["RisProvider"].AddSchema("FAC_TipoPractica",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("IdTipoPractica")]
		[Bindable(true)]
		public int IdTipoPractica 
		{
			get { return GetColumnValue<int>(Columns.IdTipoPractica); }
			set { SetColumnValue(Columns.IdTipoPractica, value); }
		}
		  
		[XmlAttribute("Nombre")]
		[Bindable(true)]
		public string Nombre 
		{
			get { return GetColumnValue<string>(Columns.Nombre); }
			set { SetColumnValue(Columns.Nombre, value); }
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
        
		
		private DalRis.FacOrdenCollection colFacOrdenRecords;
		public DalRis.FacOrdenCollection FacOrdenRecords()
		{
			if(colFacOrdenRecords == null)
			{
				colFacOrdenRecords = new DalRis.FacOrdenCollection().Where(FacOrden.Columns.IdTipoPractica, IdTipoPractica).Load();
				colFacOrdenRecords.ListChanged += new ListChangedEventHandler(colFacOrdenRecords_ListChanged);
			}
			return colFacOrdenRecords;
		}
				
		void colFacOrdenRecords_ListChanged(object sender, ListChangedEventArgs e)
		{
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
		        // Set foreign key value
		        colFacOrdenRecords[e.NewIndex].IdTipoPractica = IdTipoPractica;
				colFacOrdenRecords.ListChanged += new ListChangedEventHandler(colFacOrdenRecords_ListChanged);
            }
		}
		private DalRis.FacNomencladorCollection colFacNomencladorRecords;
		public DalRis.FacNomencladorCollection FacNomencladorRecords()
		{
			if(colFacNomencladorRecords == null)
			{
				colFacNomencladorRecords = new DalRis.FacNomencladorCollection().Where(FacNomenclador.Columns.IdTipoPractica, IdTipoPractica).Load();
				colFacNomencladorRecords.ListChanged += new ListChangedEventHandler(colFacNomencladorRecords_ListChanged);
			}
			return colFacNomencladorRecords;
		}
				
		void colFacNomencladorRecords_ListChanged(object sender, ListChangedEventArgs e)
		{
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
		        // Set foreign key value
		        colFacNomencladorRecords[e.NewIndex].IdTipoPractica = IdTipoPractica;
				colFacNomencladorRecords.ListChanged += new ListChangedEventHandler(colFacNomencladorRecords_ListChanged);
            }
		}
		#endregion
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varNombre,bool varBaja)
		{
			FacTipoPractica item = new FacTipoPractica();
			
			item.Nombre = varNombre;
			
			item.Baja = varBaja;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varIdTipoPractica,string varNombre,bool varBaja)
		{
			FacTipoPractica item = new FacTipoPractica();
			
				item.IdTipoPractica = varIdTipoPractica;
			
				item.Nombre = varNombre;
			
				item.Baja = varBaja;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn IdTipoPracticaColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn NombreColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn BajaColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string IdTipoPractica = @"idTipoPractica";
			 public static string Nombre = @"nombre";
			 public static string Baja = @"baja";
						
		}
		#endregion
		
		#region Update PK Collections
		
        public void SetPKValues()
        {
                if (colFacOrdenRecords != null)
                {
                    foreach (DalRis.FacOrden item in colFacOrdenRecords)
                    {
                        if (item.IdTipoPractica != IdTipoPractica)
                        {
                            item.IdTipoPractica = IdTipoPractica;
                        }
                    }
               }
		
                if (colFacNomencladorRecords != null)
                {
                    foreach (DalRis.FacNomenclador item in colFacNomencladorRecords)
                    {
                        if (item.IdTipoPractica != IdTipoPractica)
                        {
                            item.IdTipoPractica = IdTipoPractica;
                        }
                    }
               }
		}
        #endregion
    
        #region Deep Save
		
        public void DeepSave()
        {
            Save();
            
                if (colFacOrdenRecords != null)
                {
                    colFacOrdenRecords.SaveAll();
               }
		
                if (colFacNomencladorRecords != null)
                {
                    colFacNomencladorRecords.SaveAll();
               }
		}
        #endregion
	}
}
