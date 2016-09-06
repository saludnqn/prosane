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
	/// Strongly-typed collection for the FacCapitulo class.
	/// </summary>
    [Serializable]
	public partial class FacCapituloCollection : ActiveList<FacCapitulo, FacCapituloCollection>
	{	   
		public FacCapituloCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>FacCapituloCollection</returns>
		public FacCapituloCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                FacCapitulo o = this[i];
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
	/// This is an ActiveRecord class which wraps the FAC_Capitulo table.
	/// </summary>
	[Serializable]
	public partial class FacCapitulo : ActiveRecord<FacCapitulo>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public FacCapitulo()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public FacCapitulo(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public FacCapitulo(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public FacCapitulo(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("FAC_Capitulo", TableType.Table, DataService.GetInstance("RisProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarIdCapitulo = new TableSchema.TableColumn(schema);
				colvarIdCapitulo.ColumnName = "idCapitulo";
				colvarIdCapitulo.DataType = DbType.Int32;
				colvarIdCapitulo.MaxLength = 0;
				colvarIdCapitulo.AutoIncrement = true;
				colvarIdCapitulo.IsNullable = false;
				colvarIdCapitulo.IsPrimaryKey = true;
				colvarIdCapitulo.IsForeignKey = false;
				colvarIdCapitulo.IsReadOnly = false;
				colvarIdCapitulo.DefaultSetting = @"";
				colvarIdCapitulo.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdCapitulo);
				
				TableSchema.TableColumn colvarNombre = new TableSchema.TableColumn(schema);
				colvarNombre.ColumnName = "Nombre";
				colvarNombre.DataType = DbType.AnsiString;
				colvarNombre.MaxLength = 100;
				colvarNombre.AutoIncrement = false;
				colvarNombre.IsNullable = false;
				colvarNombre.IsPrimaryKey = false;
				colvarNombre.IsForeignKey = false;
				colvarNombre.IsReadOnly = false;
				colvarNombre.DefaultSetting = @"";
				colvarNombre.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNombre);
				
				TableSchema.TableColumn colvarCodigoDesde = new TableSchema.TableColumn(schema);
				colvarCodigoDesde.ColumnName = "CodigoDesde";
				colvarCodigoDesde.DataType = DbType.AnsiString;
				colvarCodigoDesde.MaxLength = 50;
				colvarCodigoDesde.AutoIncrement = false;
				colvarCodigoDesde.IsNullable = false;
				colvarCodigoDesde.IsPrimaryKey = false;
				colvarCodigoDesde.IsForeignKey = false;
				colvarCodigoDesde.IsReadOnly = false;
				colvarCodigoDesde.DefaultSetting = @"";
				colvarCodigoDesde.ForeignKeyTableName = "";
				schema.Columns.Add(colvarCodigoDesde);
				
				TableSchema.TableColumn colvarCodigoHasta = new TableSchema.TableColumn(schema);
				colvarCodigoHasta.ColumnName = "CodigoHasta";
				colvarCodigoHasta.DataType = DbType.AnsiString;
				colvarCodigoHasta.MaxLength = 50;
				colvarCodigoHasta.AutoIncrement = false;
				colvarCodigoHasta.IsNullable = false;
				colvarCodigoHasta.IsPrimaryKey = false;
				colvarCodigoHasta.IsForeignKey = false;
				colvarCodigoHasta.IsReadOnly = false;
				colvarCodigoHasta.DefaultSetting = @"";
				colvarCodigoHasta.ForeignKeyTableName = "";
				schema.Columns.Add(colvarCodigoHasta);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["RisProvider"].AddSchema("FAC_Capitulo",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("IdCapitulo")]
		[Bindable(true)]
		public int IdCapitulo 
		{
			get { return GetColumnValue<int>(Columns.IdCapitulo); }
			set { SetColumnValue(Columns.IdCapitulo, value); }
		}
		  
		[XmlAttribute("Nombre")]
		[Bindable(true)]
		public string Nombre 
		{
			get { return GetColumnValue<string>(Columns.Nombre); }
			set { SetColumnValue(Columns.Nombre, value); }
		}
		  
		[XmlAttribute("CodigoDesde")]
		[Bindable(true)]
		public string CodigoDesde 
		{
			get { return GetColumnValue<string>(Columns.CodigoDesde); }
			set { SetColumnValue(Columns.CodigoDesde, value); }
		}
		  
		[XmlAttribute("CodigoHasta")]
		[Bindable(true)]
		public string CodigoHasta 
		{
			get { return GetColumnValue<string>(Columns.CodigoHasta); }
			set { SetColumnValue(Columns.CodigoHasta, value); }
		}
		
		#endregion
		
		
		#region PrimaryKey Methods		
		
        protected override void SetPrimaryKey(object oValue)
        {
            base.SetPrimaryKey(oValue);
            
            SetPKValues();
        }
        
		
		private DalRis.FacNomencladorCollection colFacNomencladorRecords;
		public DalRis.FacNomencladorCollection FacNomencladorRecords()
		{
			if(colFacNomencladorRecords == null)
			{
				colFacNomencladorRecords = new DalRis.FacNomencladorCollection().Where(FacNomenclador.Columns.IdCapitulo, IdCapitulo).Load();
				colFacNomencladorRecords.ListChanged += new ListChangedEventHandler(colFacNomencladorRecords_ListChanged);
			}
			return colFacNomencladorRecords;
		}
				
		void colFacNomencladorRecords_ListChanged(object sender, ListChangedEventArgs e)
		{
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
		        // Set foreign key value
		        colFacNomencladorRecords[e.NewIndex].IdCapitulo = IdCapitulo;
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
		public static void Insert(string varNombre,string varCodigoDesde,string varCodigoHasta)
		{
			FacCapitulo item = new FacCapitulo();
			
			item.Nombre = varNombre;
			
			item.CodigoDesde = varCodigoDesde;
			
			item.CodigoHasta = varCodigoHasta;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varIdCapitulo,string varNombre,string varCodigoDesde,string varCodigoHasta)
		{
			FacCapitulo item = new FacCapitulo();
			
				item.IdCapitulo = varIdCapitulo;
			
				item.Nombre = varNombre;
			
				item.CodigoDesde = varCodigoDesde;
			
				item.CodigoHasta = varCodigoHasta;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn IdCapituloColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn NombreColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn CodigoDesdeColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn CodigoHastaColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string IdCapitulo = @"idCapitulo";
			 public static string Nombre = @"Nombre";
			 public static string CodigoDesde = @"CodigoDesde";
			 public static string CodigoHasta = @"CodigoHasta";
						
		}
		#endregion
		
		#region Update PK Collections
		
        public void SetPKValues()
        {
                if (colFacNomencladorRecords != null)
                {
                    foreach (DalRis.FacNomenclador item in colFacNomencladorRecords)
                    {
                        if (item.IdCapitulo != IdCapitulo)
                        {
                            item.IdCapitulo = IdCapitulo;
                        }
                    }
               }
		}
        #endregion
    
        #region Deep Save
		
        public void DeepSave()
        {
            Save();
            
                if (colFacNomencladorRecords != null)
                {
                    colFacNomencladorRecords.SaveAll();
               }
		}
        #endregion
	}
}
