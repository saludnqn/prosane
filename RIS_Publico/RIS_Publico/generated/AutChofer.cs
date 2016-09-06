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
	/// Strongly-typed collection for the AutChofer class.
	/// </summary>
    [Serializable]
	public partial class AutChoferCollection : ActiveList<AutChofer, AutChoferCollection>
	{	   
		public AutChoferCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>AutChoferCollection</returns>
		public AutChoferCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                AutChofer o = this[i];
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
	/// This is an ActiveRecord class which wraps the AUT_Chofer table.
	/// </summary>
	[Serializable]
	public partial class AutChofer : ActiveRecord<AutChofer>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public AutChofer()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public AutChofer(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public AutChofer(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public AutChofer(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("AUT_Chofer", TableType.Table, DataService.GetInstance("RisProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarIdChofer = new TableSchema.TableColumn(schema);
				colvarIdChofer.ColumnName = "idChofer";
				colvarIdChofer.DataType = DbType.Int32;
				colvarIdChofer.MaxLength = 0;
				colvarIdChofer.AutoIncrement = true;
				colvarIdChofer.IsNullable = false;
				colvarIdChofer.IsPrimaryKey = true;
				colvarIdChofer.IsForeignKey = false;
				colvarIdChofer.IsReadOnly = false;
				colvarIdChofer.DefaultSetting = @"";
				colvarIdChofer.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdChofer);
				
				TableSchema.TableColumn colvarApellido = new TableSchema.TableColumn(schema);
				colvarApellido.ColumnName = "apellido";
				colvarApellido.DataType = DbType.String;
				colvarApellido.MaxLength = 50;
				colvarApellido.AutoIncrement = false;
				colvarApellido.IsNullable = false;
				colvarApellido.IsPrimaryKey = false;
				colvarApellido.IsForeignKey = false;
				colvarApellido.IsReadOnly = false;
				colvarApellido.DefaultSetting = @"";
				colvarApellido.ForeignKeyTableName = "";
				schema.Columns.Add(colvarApellido);
				
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
				
				TableSchema.TableColumn colvarDocumento = new TableSchema.TableColumn(schema);
				colvarDocumento.ColumnName = "documento";
				colvarDocumento.DataType = DbType.String;
				colvarDocumento.MaxLength = 50;
				colvarDocumento.AutoIncrement = false;
				colvarDocumento.IsNullable = false;
				colvarDocumento.IsPrimaryKey = false;
				colvarDocumento.IsForeignKey = false;
				colvarDocumento.IsReadOnly = false;
				colvarDocumento.DefaultSetting = @"";
				colvarDocumento.ForeignKeyTableName = "";
				schema.Columns.Add(colvarDocumento);
				
				TableSchema.TableColumn colvarLegajo = new TableSchema.TableColumn(schema);
				colvarLegajo.ColumnName = "legajo";
				colvarLegajo.DataType = DbType.String;
				colvarLegajo.MaxLength = 30;
				colvarLegajo.AutoIncrement = false;
				colvarLegajo.IsNullable = false;
				colvarLegajo.IsPrimaryKey = false;
				colvarLegajo.IsForeignKey = false;
				colvarLegajo.IsReadOnly = false;
				colvarLegajo.DefaultSetting = @"";
				colvarLegajo.ForeignKeyTableName = "";
				schema.Columns.Add(colvarLegajo);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["RisProvider"].AddSchema("AUT_Chofer",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("IdChofer")]
		[Bindable(true)]
		public int IdChofer 
		{
			get { return GetColumnValue<int>(Columns.IdChofer); }
			set { SetColumnValue(Columns.IdChofer, value); }
		}
		  
		[XmlAttribute("Apellido")]
		[Bindable(true)]
		public string Apellido 
		{
			get { return GetColumnValue<string>(Columns.Apellido); }
			set { SetColumnValue(Columns.Apellido, value); }
		}
		  
		[XmlAttribute("Nombre")]
		[Bindable(true)]
		public string Nombre 
		{
			get { return GetColumnValue<string>(Columns.Nombre); }
			set { SetColumnValue(Columns.Nombre, value); }
		}
		  
		[XmlAttribute("Documento")]
		[Bindable(true)]
		public string Documento 
		{
			get { return GetColumnValue<string>(Columns.Documento); }
			set { SetColumnValue(Columns.Documento, value); }
		}
		  
		[XmlAttribute("Legajo")]
		[Bindable(true)]
		public string Legajo 
		{
			get { return GetColumnValue<string>(Columns.Legajo); }
			set { SetColumnValue(Columns.Legajo, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varApellido,string varNombre,string varDocumento,string varLegajo)
		{
			AutChofer item = new AutChofer();
			
			item.Apellido = varApellido;
			
			item.Nombre = varNombre;
			
			item.Documento = varDocumento;
			
			item.Legajo = varLegajo;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varIdChofer,string varApellido,string varNombre,string varDocumento,string varLegajo)
		{
			AutChofer item = new AutChofer();
			
				item.IdChofer = varIdChofer;
			
				item.Apellido = varApellido;
			
				item.Nombre = varNombre;
			
				item.Documento = varDocumento;
			
				item.Legajo = varLegajo;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn IdChoferColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn ApellidoColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn NombreColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn DocumentoColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn LegajoColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string IdChofer = @"idChofer";
			 public static string Apellido = @"apellido";
			 public static string Nombre = @"nombre";
			 public static string Documento = @"documento";
			 public static string Legajo = @"legajo";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
