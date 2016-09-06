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
	/// Strongly-typed collection for the FacUnidad class.
	/// </summary>
    [Serializable]
	public partial class FacUnidadCollection : ActiveList<FacUnidad, FacUnidadCollection>
	{	   
		public FacUnidadCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>FacUnidadCollection</returns>
		public FacUnidadCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                FacUnidad o = this[i];
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
	/// This is an ActiveRecord class which wraps the FAC_Unidad table.
	/// </summary>
	[Serializable]
	public partial class FacUnidad : ActiveRecord<FacUnidad>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public FacUnidad()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public FacUnidad(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public FacUnidad(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public FacUnidad(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("FAC_Unidad", TableType.Table, DataService.GetInstance("RisProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarIdUnidad = new TableSchema.TableColumn(schema);
				colvarIdUnidad.ColumnName = "idUnidad";
				colvarIdUnidad.DataType = DbType.Int32;
				colvarIdUnidad.MaxLength = 0;
				colvarIdUnidad.AutoIncrement = true;
				colvarIdUnidad.IsNullable = false;
				colvarIdUnidad.IsPrimaryKey = true;
				colvarIdUnidad.IsForeignKey = false;
				colvarIdUnidad.IsReadOnly = false;
				colvarIdUnidad.DefaultSetting = @"";
				colvarIdUnidad.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdUnidad);
				
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
				
				TableSchema.TableColumn colvarSimbolo = new TableSchema.TableColumn(schema);
				colvarSimbolo.ColumnName = "simbolo";
				colvarSimbolo.DataType = DbType.AnsiStringFixedLength;
				colvarSimbolo.MaxLength = 10;
				colvarSimbolo.AutoIncrement = false;
				colvarSimbolo.IsNullable = false;
				colvarSimbolo.IsPrimaryKey = false;
				colvarSimbolo.IsForeignKey = false;
				colvarSimbolo.IsReadOnly = false;
				colvarSimbolo.DefaultSetting = @"";
				colvarSimbolo.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSimbolo);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["RisProvider"].AddSchema("FAC_Unidad",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("IdUnidad")]
		[Bindable(true)]
		public int IdUnidad 
		{
			get { return GetColumnValue<int>(Columns.IdUnidad); }
			set { SetColumnValue(Columns.IdUnidad, value); }
		}
		  
		[XmlAttribute("Nombre")]
		[Bindable(true)]
		public string Nombre 
		{
			get { return GetColumnValue<string>(Columns.Nombre); }
			set { SetColumnValue(Columns.Nombre, value); }
		}
		  
		[XmlAttribute("Simbolo")]
		[Bindable(true)]
		public string Simbolo 
		{
			get { return GetColumnValue<string>(Columns.Simbolo); }
			set { SetColumnValue(Columns.Simbolo, value); }
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
				colFacNomencladorRecords = new DalRis.FacNomencladorCollection().Where(FacNomenclador.Columns.IdUnidad, IdUnidad).Load();
				colFacNomencladorRecords.ListChanged += new ListChangedEventHandler(colFacNomencladorRecords_ListChanged);
			}
			return colFacNomencladorRecords;
		}
				
		void colFacNomencladorRecords_ListChanged(object sender, ListChangedEventArgs e)
		{
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
		        // Set foreign key value
		        colFacNomencladorRecords[e.NewIndex].IdUnidad = IdUnidad;
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
		public static void Insert(string varNombre,string varSimbolo)
		{
			FacUnidad item = new FacUnidad();
			
			item.Nombre = varNombre;
			
			item.Simbolo = varSimbolo;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varIdUnidad,string varNombre,string varSimbolo)
		{
			FacUnidad item = new FacUnidad();
			
				item.IdUnidad = varIdUnidad;
			
				item.Nombre = varNombre;
			
				item.Simbolo = varSimbolo;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn IdUnidadColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn NombreColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn SimboloColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string IdUnidad = @"idUnidad";
			 public static string Nombre = @"nombre";
			 public static string Simbolo = @"simbolo";
						
		}
		#endregion
		
		#region Update PK Collections
		
        public void SetPKValues()
        {
                if (colFacNomencladorRecords != null)
                {
                    foreach (DalRis.FacNomenclador item in colFacNomencladorRecords)
                    {
                        if (item.IdUnidad != IdUnidad)
                        {
                            item.IdUnidad = IdUnidad;
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
