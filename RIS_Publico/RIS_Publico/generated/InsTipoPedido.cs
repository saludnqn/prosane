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
	/// Strongly-typed collection for the InsTipoPedido class.
	/// </summary>
    [Serializable]
	public partial class InsTipoPedidoCollection : ActiveList<InsTipoPedido, InsTipoPedidoCollection>
	{	   
		public InsTipoPedidoCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>InsTipoPedidoCollection</returns>
		public InsTipoPedidoCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                InsTipoPedido o = this[i];
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
	/// This is an ActiveRecord class which wraps the INS_TipoPedido table.
	/// </summary>
	[Serializable]
	public partial class InsTipoPedido : ActiveRecord<InsTipoPedido>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public InsTipoPedido()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public InsTipoPedido(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public InsTipoPedido(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public InsTipoPedido(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("INS_TipoPedido", TableType.Table, DataService.GetInstance("RisProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarIdTipoPedido = new TableSchema.TableColumn(schema);
				colvarIdTipoPedido.ColumnName = "idTipoPedido";
				colvarIdTipoPedido.DataType = DbType.Int32;
				colvarIdTipoPedido.MaxLength = 0;
				colvarIdTipoPedido.AutoIncrement = true;
				colvarIdTipoPedido.IsNullable = false;
				colvarIdTipoPedido.IsPrimaryKey = true;
				colvarIdTipoPedido.IsForeignKey = false;
				colvarIdTipoPedido.IsReadOnly = false;
				colvarIdTipoPedido.DefaultSetting = @"";
				colvarIdTipoPedido.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdTipoPedido);
				
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
				DataService.Providers["RisProvider"].AddSchema("INS_TipoPedido",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("IdTipoPedido")]
		[Bindable(true)]
		public int IdTipoPedido 
		{
			get { return GetColumnValue<int>(Columns.IdTipoPedido); }
			set { SetColumnValue(Columns.IdTipoPedido, value); }
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
        
		
		private DalRis.InsPedidoCollection colInsPedidoRecords;
		public DalRis.InsPedidoCollection InsPedidoRecords()
		{
			if(colInsPedidoRecords == null)
			{
				colInsPedidoRecords = new DalRis.InsPedidoCollection().Where(InsPedido.Columns.IdTipoPedido, IdTipoPedido).Load();
				colInsPedidoRecords.ListChanged += new ListChangedEventHandler(colInsPedidoRecords_ListChanged);
			}
			return colInsPedidoRecords;
		}
				
		void colInsPedidoRecords_ListChanged(object sender, ListChangedEventArgs e)
		{
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
		        // Set foreign key value
		        colInsPedidoRecords[e.NewIndex].IdTipoPedido = IdTipoPedido;
				colInsPedidoRecords.ListChanged += new ListChangedEventHandler(colInsPedidoRecords_ListChanged);
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
			InsTipoPedido item = new InsTipoPedido();
			
			item.Nombre = varNombre;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varIdTipoPedido,string varNombre)
		{
			InsTipoPedido item = new InsTipoPedido();
			
				item.IdTipoPedido = varIdTipoPedido;
			
				item.Nombre = varNombre;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn IdTipoPedidoColumn
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
			 public static string IdTipoPedido = @"idTipoPedido";
			 public static string Nombre = @"nombre";
						
		}
		#endregion
		
		#region Update PK Collections
		
        public void SetPKValues()
        {
                if (colInsPedidoRecords != null)
                {
                    foreach (DalRis.InsPedido item in colInsPedidoRecords)
                    {
                        if (item.IdTipoPedido != IdTipoPedido)
                        {
                            item.IdTipoPedido = IdTipoPedido;
                        }
                    }
               }
		}
        #endregion
    
        #region Deep Save
		
        public void DeepSave()
        {
            Save();
            
                if (colInsPedidoRecords != null)
                {
                    colInsPedidoRecords.SaveAll();
               }
		}
        #endregion
	}
}
