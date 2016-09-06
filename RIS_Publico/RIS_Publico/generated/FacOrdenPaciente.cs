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
	/// Strongly-typed collection for the FacOrdenPaciente class.
	/// </summary>
    [Serializable]
	public partial class FacOrdenPacienteCollection : ActiveList<FacOrdenPaciente, FacOrdenPacienteCollection>
	{	   
		public FacOrdenPacienteCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>FacOrdenPacienteCollection</returns>
		public FacOrdenPacienteCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                FacOrdenPaciente o = this[i];
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
	/// This is an ActiveRecord class which wraps the FAC_OrdenPaciente table.
	/// </summary>
	[Serializable]
	public partial class FacOrdenPaciente : ActiveRecord<FacOrdenPaciente>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public FacOrdenPaciente()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public FacOrdenPaciente(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public FacOrdenPaciente(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public FacOrdenPaciente(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("FAC_OrdenPaciente", TableType.Table, DataService.GetInstance("RisProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarIdOrdenPaciente = new TableSchema.TableColumn(schema);
				colvarIdOrdenPaciente.ColumnName = "idOrdenPaciente";
				colvarIdOrdenPaciente.DataType = DbType.Int32;
				colvarIdOrdenPaciente.MaxLength = 0;
				colvarIdOrdenPaciente.AutoIncrement = true;
				colvarIdOrdenPaciente.IsNullable = false;
				colvarIdOrdenPaciente.IsPrimaryKey = true;
				colvarIdOrdenPaciente.IsForeignKey = false;
				colvarIdOrdenPaciente.IsReadOnly = false;
				colvarIdOrdenPaciente.DefaultSetting = @"";
				colvarIdOrdenPaciente.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdOrdenPaciente);
				
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
				
				TableSchema.TableColumn colvarIdPaciente = new TableSchema.TableColumn(schema);
				colvarIdPaciente.ColumnName = "idPaciente";
				colvarIdPaciente.DataType = DbType.Int32;
				colvarIdPaciente.MaxLength = 0;
				colvarIdPaciente.AutoIncrement = false;
				colvarIdPaciente.IsNullable = false;
				colvarIdPaciente.IsPrimaryKey = false;
				colvarIdPaciente.IsForeignKey = true;
				colvarIdPaciente.IsReadOnly = false;
				colvarIdPaciente.DefaultSetting = @"";
				
					colvarIdPaciente.ForeignKeyTableName = "Sys_Paciente";
				schema.Columns.Add(colvarIdPaciente);
				
				TableSchema.TableColumn colvarFechaPractica = new TableSchema.TableColumn(schema);
				colvarFechaPractica.ColumnName = "fechaPractica";
				colvarFechaPractica.DataType = DbType.DateTime;
				colvarFechaPractica.MaxLength = 0;
				colvarFechaPractica.AutoIncrement = false;
				colvarFechaPractica.IsNullable = false;
				colvarFechaPractica.IsPrimaryKey = false;
				colvarFechaPractica.IsForeignKey = false;
				colvarFechaPractica.IsReadOnly = false;
				colvarFechaPractica.DefaultSetting = @"";
				colvarFechaPractica.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFechaPractica);
				
				TableSchema.TableColumn colvarDiagnostico = new TableSchema.TableColumn(schema);
				colvarDiagnostico.ColumnName = "diagnostico";
				colvarDiagnostico.DataType = DbType.AnsiString;
				colvarDiagnostico.MaxLength = 500;
				colvarDiagnostico.AutoIncrement = false;
				colvarDiagnostico.IsNullable = false;
				colvarDiagnostico.IsPrimaryKey = false;
				colvarDiagnostico.IsForeignKey = false;
				colvarDiagnostico.IsReadOnly = false;
				colvarDiagnostico.DefaultSetting = @"";
				colvarDiagnostico.ForeignKeyTableName = "";
				schema.Columns.Add(colvarDiagnostico);
				
				TableSchema.TableColumn colvarIdOrdenDetalle = new TableSchema.TableColumn(schema);
				colvarIdOrdenDetalle.ColumnName = "idOrdenDetalle";
				colvarIdOrdenDetalle.DataType = DbType.Int32;
				colvarIdOrdenDetalle.MaxLength = 0;
				colvarIdOrdenDetalle.AutoIncrement = false;
				colvarIdOrdenDetalle.IsNullable = true;
				colvarIdOrdenDetalle.IsPrimaryKey = false;
				colvarIdOrdenDetalle.IsForeignKey = false;
				colvarIdOrdenDetalle.IsReadOnly = false;
				colvarIdOrdenDetalle.DefaultSetting = @"";
				colvarIdOrdenDetalle.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdOrdenDetalle);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["RisProvider"].AddSchema("FAC_OrdenPaciente",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("IdOrdenPaciente")]
		[Bindable(true)]
		public int IdOrdenPaciente 
		{
			get { return GetColumnValue<int>(Columns.IdOrdenPaciente); }
			set { SetColumnValue(Columns.IdOrdenPaciente, value); }
		}
		  
		[XmlAttribute("IdOrden")]
		[Bindable(true)]
		public int IdOrden 
		{
			get { return GetColumnValue<int>(Columns.IdOrden); }
			set { SetColumnValue(Columns.IdOrden, value); }
		}
		  
		[XmlAttribute("IdPaciente")]
		[Bindable(true)]
		public int IdPaciente 
		{
			get { return GetColumnValue<int>(Columns.IdPaciente); }
			set { SetColumnValue(Columns.IdPaciente, value); }
		}
		  
		[XmlAttribute("FechaPractica")]
		[Bindable(true)]
		public DateTime FechaPractica 
		{
			get { return GetColumnValue<DateTime>(Columns.FechaPractica); }
			set { SetColumnValue(Columns.FechaPractica, value); }
		}
		  
		[XmlAttribute("Diagnostico")]
		[Bindable(true)]
		public string Diagnostico 
		{
			get { return GetColumnValue<string>(Columns.Diagnostico); }
			set { SetColumnValue(Columns.Diagnostico, value); }
		}
		  
		[XmlAttribute("IdOrdenDetalle")]
		[Bindable(true)]
		public int? IdOrdenDetalle 
		{
			get { return GetColumnValue<int?>(Columns.IdOrdenDetalle); }
			set { SetColumnValue(Columns.IdOrdenDetalle, value); }
		}
		
		#endregion
		
		
			
		
		#region ForeignKey Properties
		
		/// <summary>
		/// Returns a SysPaciente ActiveRecord object related to this FacOrdenPaciente
		/// 
		/// </summary>
		public DalRis.SysPaciente SysPaciente
		{
			get { return DalRis.SysPaciente.FetchByID(this.IdPaciente); }
			set { SetColumnValue("idPaciente", value.IdPaciente); }
		}
		
		
		/// <summary>
		/// Returns a FacOrden ActiveRecord object related to this FacOrdenPaciente
		/// 
		/// </summary>
		public DalRis.FacOrden FacOrden
		{
			get { return DalRis.FacOrden.FetchByID(this.IdOrden); }
			set { SetColumnValue("idOrden", value.IdOrden); }
		}
		
		
		#endregion
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(int varIdOrden,int varIdPaciente,DateTime varFechaPractica,string varDiagnostico,int? varIdOrdenDetalle)
		{
			FacOrdenPaciente item = new FacOrdenPaciente();
			
			item.IdOrden = varIdOrden;
			
			item.IdPaciente = varIdPaciente;
			
			item.FechaPractica = varFechaPractica;
			
			item.Diagnostico = varDiagnostico;
			
			item.IdOrdenDetalle = varIdOrdenDetalle;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varIdOrdenPaciente,int varIdOrden,int varIdPaciente,DateTime varFechaPractica,string varDiagnostico,int? varIdOrdenDetalle)
		{
			FacOrdenPaciente item = new FacOrdenPaciente();
			
				item.IdOrdenPaciente = varIdOrdenPaciente;
			
				item.IdOrden = varIdOrden;
			
				item.IdPaciente = varIdPaciente;
			
				item.FechaPractica = varFechaPractica;
			
				item.Diagnostico = varDiagnostico;
			
				item.IdOrdenDetalle = varIdOrdenDetalle;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn IdOrdenPacienteColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn IdOrdenColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn IdPacienteColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn FechaPracticaColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn DiagnosticoColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn IdOrdenDetalleColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string IdOrdenPaciente = @"idOrdenPaciente";
			 public static string IdOrden = @"idOrden";
			 public static string IdPaciente = @"idPaciente";
			 public static string FechaPractica = @"fechaPractica";
			 public static string Diagnostico = @"diagnostico";
			 public static string IdOrdenDetalle = @"idOrdenDetalle";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
