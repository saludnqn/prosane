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
	/// Strongly-typed collection for the AutItemMovimiento class.
	/// </summary>
    [Serializable]
	public partial class AutItemMovimientoCollection : ActiveList<AutItemMovimiento, AutItemMovimientoCollection>
	{	   
		public AutItemMovimientoCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>AutItemMovimientoCollection</returns>
		public AutItemMovimientoCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                AutItemMovimiento o = this[i];
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
	/// This is an ActiveRecord class which wraps the AUT_ItemMovimiento table.
	/// </summary>
	[Serializable]
	public partial class AutItemMovimiento : ActiveRecord<AutItemMovimiento>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public AutItemMovimiento()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public AutItemMovimiento(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public AutItemMovimiento(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public AutItemMovimiento(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("AUT_ItemMovimiento", TableType.Table, DataService.GetInstance("RisProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarIdItemMovimiento = new TableSchema.TableColumn(schema);
				colvarIdItemMovimiento.ColumnName = "idItemMovimiento";
				colvarIdItemMovimiento.DataType = DbType.Int32;
				colvarIdItemMovimiento.MaxLength = 0;
				colvarIdItemMovimiento.AutoIncrement = true;
				colvarIdItemMovimiento.IsNullable = false;
				colvarIdItemMovimiento.IsPrimaryKey = true;
				colvarIdItemMovimiento.IsForeignKey = false;
				colvarIdItemMovimiento.IsReadOnly = false;
				colvarIdItemMovimiento.DefaultSetting = @"";
				colvarIdItemMovimiento.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdItemMovimiento);
				
				TableSchema.TableColumn colvarNombre = new TableSchema.TableColumn(schema);
				colvarNombre.ColumnName = "nombre";
				colvarNombre.DataType = DbType.String;
				colvarNombre.MaxLength = 50;
				colvarNombre.AutoIncrement = false;
				colvarNombre.IsNullable = false;
				colvarNombre.IsPrimaryKey = false;
				colvarNombre.IsForeignKey = false;
				colvarNombre.IsReadOnly = false;
				colvarNombre.DefaultSetting = @"";
				colvarNombre.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNombre);
				
				TableSchema.TableColumn colvarIdPMPTipo = new TableSchema.TableColumn(schema);
				colvarIdPMPTipo.ColumnName = "idPMPTipo";
				colvarIdPMPTipo.DataType = DbType.Int32;
				colvarIdPMPTipo.MaxLength = 0;
				colvarIdPMPTipo.AutoIncrement = false;
				colvarIdPMPTipo.IsNullable = true;
				colvarIdPMPTipo.IsPrimaryKey = false;
				colvarIdPMPTipo.IsForeignKey = false;
				colvarIdPMPTipo.IsReadOnly = false;
				colvarIdPMPTipo.DefaultSetting = @"";
				colvarIdPMPTipo.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdPMPTipo);
				
				TableSchema.TableColumn colvarIdUsuarioRegistro = new TableSchema.TableColumn(schema);
				colvarIdUsuarioRegistro.ColumnName = "idUsuarioRegistro";
				colvarIdUsuarioRegistro.DataType = DbType.Int32;
				colvarIdUsuarioRegistro.MaxLength = 0;
				colvarIdUsuarioRegistro.AutoIncrement = false;
				colvarIdUsuarioRegistro.IsNullable = false;
				colvarIdUsuarioRegistro.IsPrimaryKey = false;
				colvarIdUsuarioRegistro.IsForeignKey = false;
				colvarIdUsuarioRegistro.IsReadOnly = false;
				colvarIdUsuarioRegistro.DefaultSetting = @"";
				colvarIdUsuarioRegistro.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdUsuarioRegistro);
				
				TableSchema.TableColumn colvarFechaRegistro = new TableSchema.TableColumn(schema);
				colvarFechaRegistro.ColumnName = "fechaRegistro";
				colvarFechaRegistro.DataType = DbType.DateTime;
				colvarFechaRegistro.MaxLength = 0;
				colvarFechaRegistro.AutoIncrement = false;
				colvarFechaRegistro.IsNullable = false;
				colvarFechaRegistro.IsPrimaryKey = false;
				colvarFechaRegistro.IsForeignKey = false;
				colvarFechaRegistro.IsReadOnly = false;
				colvarFechaRegistro.DefaultSetting = @"";
				colvarFechaRegistro.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFechaRegistro);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["RisProvider"].AddSchema("AUT_ItemMovimiento",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("IdItemMovimiento")]
		[Bindable(true)]
		public int IdItemMovimiento 
		{
			get { return GetColumnValue<int>(Columns.IdItemMovimiento); }
			set { SetColumnValue(Columns.IdItemMovimiento, value); }
		}
		  
		[XmlAttribute("Nombre")]
		[Bindable(true)]
		public string Nombre 
		{
			get { return GetColumnValue<string>(Columns.Nombre); }
			set { SetColumnValue(Columns.Nombre, value); }
		}
		  
		[XmlAttribute("IdPMPTipo")]
		[Bindable(true)]
		public int? IdPMPTipo 
		{
			get { return GetColumnValue<int?>(Columns.IdPMPTipo); }
			set { SetColumnValue(Columns.IdPMPTipo, value); }
		}
		  
		[XmlAttribute("IdUsuarioRegistro")]
		[Bindable(true)]
		public int IdUsuarioRegistro 
		{
			get { return GetColumnValue<int>(Columns.IdUsuarioRegistro); }
			set { SetColumnValue(Columns.IdUsuarioRegistro, value); }
		}
		  
		[XmlAttribute("FechaRegistro")]
		[Bindable(true)]
		public DateTime FechaRegistro 
		{
			get { return GetColumnValue<DateTime>(Columns.FechaRegistro); }
			set { SetColumnValue(Columns.FechaRegistro, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varNombre,int? varIdPMPTipo,int varIdUsuarioRegistro,DateTime varFechaRegistro)
		{
			AutItemMovimiento item = new AutItemMovimiento();
			
			item.Nombre = varNombre;
			
			item.IdPMPTipo = varIdPMPTipo;
			
			item.IdUsuarioRegistro = varIdUsuarioRegistro;
			
			item.FechaRegistro = varFechaRegistro;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varIdItemMovimiento,string varNombre,int? varIdPMPTipo,int varIdUsuarioRegistro,DateTime varFechaRegistro)
		{
			AutItemMovimiento item = new AutItemMovimiento();
			
				item.IdItemMovimiento = varIdItemMovimiento;
			
				item.Nombre = varNombre;
			
				item.IdPMPTipo = varIdPMPTipo;
			
				item.IdUsuarioRegistro = varIdUsuarioRegistro;
			
				item.FechaRegistro = varFechaRegistro;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn IdItemMovimientoColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn NombreColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn IdPMPTipoColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn IdUsuarioRegistroColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn FechaRegistroColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string IdItemMovimiento = @"idItemMovimiento";
			 public static string Nombre = @"nombre";
			 public static string IdPMPTipo = @"idPMPTipo";
			 public static string IdUsuarioRegistro = @"idUsuarioRegistro";
			 public static string FechaRegistro = @"fechaRegistro";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
