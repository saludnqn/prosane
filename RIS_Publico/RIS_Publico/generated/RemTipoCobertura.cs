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
	/// Strongly-typed collection for the RemTipoCobertura class.
	/// </summary>
    [Serializable]
	public partial class RemTipoCoberturaCollection : ActiveList<RemTipoCobertura, RemTipoCoberturaCollection>
	{	   
		public RemTipoCoberturaCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>RemTipoCoberturaCollection</returns>
		public RemTipoCoberturaCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                RemTipoCobertura o = this[i];
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
	/// This is an ActiveRecord class which wraps the Rem_TipoCobertura table.
	/// </summary>
	[Serializable]
	public partial class RemTipoCobertura : ActiveRecord<RemTipoCobertura>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public RemTipoCobertura()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public RemTipoCobertura(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public RemTipoCobertura(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public RemTipoCobertura(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("Rem_TipoCobertura", TableType.Table, DataService.GetInstance("RisProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarIdTipoCobertura = new TableSchema.TableColumn(schema);
				colvarIdTipoCobertura.ColumnName = "idTipoCobertura";
				colvarIdTipoCobertura.DataType = DbType.Int32;
				colvarIdTipoCobertura.MaxLength = 0;
				colvarIdTipoCobertura.AutoIncrement = true;
				colvarIdTipoCobertura.IsNullable = false;
				colvarIdTipoCobertura.IsPrimaryKey = true;
				colvarIdTipoCobertura.IsForeignKey = false;
				colvarIdTipoCobertura.IsReadOnly = false;
				colvarIdTipoCobertura.DefaultSetting = @"";
				colvarIdTipoCobertura.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdTipoCobertura);
				
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
				DataService.Providers["RisProvider"].AddSchema("Rem_TipoCobertura",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("IdTipoCobertura")]
		[Bindable(true)]
		public int IdTipoCobertura 
		{
			get { return GetColumnValue<int>(Columns.IdTipoCobertura); }
			set { SetColumnValue(Columns.IdTipoCobertura, value); }
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
        
		
		private DalRis.SysRelFormularioCoberturaCollection colSysRelFormularioCoberturaRecords;
		public DalRis.SysRelFormularioCoberturaCollection SysRelFormularioCoberturaRecords()
		{
			if(colSysRelFormularioCoberturaRecords == null)
			{
				colSysRelFormularioCoberturaRecords = new DalRis.SysRelFormularioCoberturaCollection().Where(SysRelFormularioCobertura.Columns.IdTipoCobertura, IdTipoCobertura).Load();
				colSysRelFormularioCoberturaRecords.ListChanged += new ListChangedEventHandler(colSysRelFormularioCoberturaRecords_ListChanged);
			}
			return colSysRelFormularioCoberturaRecords;
		}
				
		void colSysRelFormularioCoberturaRecords_ListChanged(object sender, ListChangedEventArgs e)
		{
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
		        // Set foreign key value
		        colSysRelFormularioCoberturaRecords[e.NewIndex].IdTipoCobertura = IdTipoCobertura;
				colSysRelFormularioCoberturaRecords.ListChanged += new ListChangedEventHandler(colSysRelFormularioCoberturaRecords_ListChanged);
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
			RemTipoCobertura item = new RemTipoCobertura();
			
			item.Nombre = varNombre;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varIdTipoCobertura,string varNombre)
		{
			RemTipoCobertura item = new RemTipoCobertura();
			
				item.IdTipoCobertura = varIdTipoCobertura;
			
				item.Nombre = varNombre;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn IdTipoCoberturaColumn
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
			 public static string IdTipoCobertura = @"idTipoCobertura";
			 public static string Nombre = @"nombre";
						
		}
		#endregion
		
		#region Update PK Collections
		
        public void SetPKValues()
        {
                if (colSysRelFormularioCoberturaRecords != null)
                {
                    foreach (DalRis.SysRelFormularioCobertura item in colSysRelFormularioCoberturaRecords)
                    {
                        if (item.IdTipoCobertura != IdTipoCobertura)
                        {
                            item.IdTipoCobertura = IdTipoCobertura;
                        }
                    }
               }
		}
        #endregion
    
        #region Deep Save
		
        public void DeepSave()
        {
            Save();
            
                if (colSysRelFormularioCoberturaRecords != null)
                {
                    colSysRelFormularioCoberturaRecords.SaveAll();
               }
		}
        #endregion
	}
}
