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
	/// Strongly-typed collection for the FacOrdenTurno class.
	/// </summary>
    [Serializable]
	public partial class FacOrdenTurnoCollection : ActiveList<FacOrdenTurno, FacOrdenTurnoCollection>
	{	   
		public FacOrdenTurnoCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>FacOrdenTurnoCollection</returns>
		public FacOrdenTurnoCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                FacOrdenTurno o = this[i];
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
	/// This is an ActiveRecord class which wraps the FAC_OrdenTurno table.
	/// </summary>
	[Serializable]
	public partial class FacOrdenTurno : ActiveRecord<FacOrdenTurno>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public FacOrdenTurno()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public FacOrdenTurno(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public FacOrdenTurno(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public FacOrdenTurno(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("FAC_OrdenTurno", TableType.Table, DataService.GetInstance("RisProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarIdOrdenTurno = new TableSchema.TableColumn(schema);
				colvarIdOrdenTurno.ColumnName = "idOrdenTurno";
				colvarIdOrdenTurno.DataType = DbType.Int32;
				colvarIdOrdenTurno.MaxLength = 0;
				colvarIdOrdenTurno.AutoIncrement = true;
				colvarIdOrdenTurno.IsNullable = false;
				colvarIdOrdenTurno.IsPrimaryKey = true;
				colvarIdOrdenTurno.IsForeignKey = false;
				colvarIdOrdenTurno.IsReadOnly = false;
				colvarIdOrdenTurno.DefaultSetting = @"";
				colvarIdOrdenTurno.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdOrdenTurno);
				
				TableSchema.TableColumn colvarIdOrden = new TableSchema.TableColumn(schema);
				colvarIdOrden.ColumnName = "idOrden";
				colvarIdOrden.DataType = DbType.Int32;
				colvarIdOrden.MaxLength = 0;
				colvarIdOrden.AutoIncrement = false;
				colvarIdOrden.IsNullable = false;
				colvarIdOrden.IsPrimaryKey = false;
				colvarIdOrden.IsForeignKey = true;
				colvarIdOrden.IsReadOnly = false;
				colvarIdOrden.DefaultSetting = @"";
				
					colvarIdOrden.ForeignKeyTableName = "FAC_Orden";
				schema.Columns.Add(colvarIdOrden);
				
				TableSchema.TableColumn colvarIdTurno = new TableSchema.TableColumn(schema);
				colvarIdTurno.ColumnName = "idTurno";
				colvarIdTurno.DataType = DbType.Int32;
				colvarIdTurno.MaxLength = 0;
				colvarIdTurno.AutoIncrement = false;
				colvarIdTurno.IsNullable = false;
				colvarIdTurno.IsPrimaryKey = false;
				colvarIdTurno.IsForeignKey = true;
				colvarIdTurno.IsReadOnly = false;
				colvarIdTurno.DefaultSetting = @"";
				
					colvarIdTurno.ForeignKeyTableName = "CON_Turno";
				schema.Columns.Add(colvarIdTurno);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["RisProvider"].AddSchema("FAC_OrdenTurno",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("IdOrdenTurno")]
		[Bindable(true)]
		public int IdOrdenTurno 
		{
			get { return GetColumnValue<int>(Columns.IdOrdenTurno); }
			set { SetColumnValue(Columns.IdOrdenTurno, value); }
		}
		  
		[XmlAttribute("IdOrden")]
		[Bindable(true)]
		public int IdOrden 
		{
			get { return GetColumnValue<int>(Columns.IdOrden); }
			set { SetColumnValue(Columns.IdOrden, value); }
		}
		  
		[XmlAttribute("IdTurno")]
		[Bindable(true)]
		public int IdTurno 
		{
			get { return GetColumnValue<int>(Columns.IdTurno); }
			set { SetColumnValue(Columns.IdTurno, value); }
		}
		
		#endregion
		
		
			
		
		#region ForeignKey Properties
		
		/// <summary>
		/// Returns a FacOrden ActiveRecord object related to this FacOrdenTurno
		/// 
		/// </summary>
		public DalRis.FacOrden FacOrden
		{
			get { return DalRis.FacOrden.FetchByID(this.IdOrden); }
			set { SetColumnValue("idOrden", value.IdOrden); }
		}
		
		
		/// <summary>
		/// Returns a ConTurno ActiveRecord object related to this FacOrdenTurno
		/// 
		/// </summary>
		public DalRis.ConTurno ConTurno
		{
			get { return DalRis.ConTurno.FetchByID(this.IdTurno); }
			set { SetColumnValue("idTurno", value.IdTurno); }
		}
		
		
		#endregion
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(int varIdOrden,int varIdTurno)
		{
			FacOrdenTurno item = new FacOrdenTurno();
			
			item.IdOrden = varIdOrden;
			
			item.IdTurno = varIdTurno;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varIdOrdenTurno,int varIdOrden,int varIdTurno)
		{
			FacOrdenTurno item = new FacOrdenTurno();
			
				item.IdOrdenTurno = varIdOrdenTurno;
			
				item.IdOrden = varIdOrden;
			
				item.IdTurno = varIdTurno;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn IdOrdenTurnoColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn IdOrdenColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn IdTurnoColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string IdOrdenTurno = @"idOrdenTurno";
			 public static string IdOrden = @"idOrden";
			 public static string IdTurno = @"idTurno";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
