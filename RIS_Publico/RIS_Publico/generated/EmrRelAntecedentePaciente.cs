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
	/// Strongly-typed collection for the EmrRelAntecedentePaciente class.
	/// </summary>
    [Serializable]
	public partial class EmrRelAntecedentePacienteCollection : ActiveList<EmrRelAntecedentePaciente, EmrRelAntecedentePacienteCollection>
	{	   
		public EmrRelAntecedentePacienteCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>EmrRelAntecedentePacienteCollection</returns>
		public EmrRelAntecedentePacienteCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                EmrRelAntecedentePaciente o = this[i];
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
	/// This is an ActiveRecord class which wraps the EMR_RelAntecedentePaciente table.
	/// </summary>
	[Serializable]
	public partial class EmrRelAntecedentePaciente : ActiveRecord<EmrRelAntecedentePaciente>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public EmrRelAntecedentePaciente()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public EmrRelAntecedentePaciente(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public EmrRelAntecedentePaciente(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public EmrRelAntecedentePaciente(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("EMR_RelAntecedentePaciente", TableType.Table, DataService.GetInstance("RisProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarIdRelAntecedentePaciente = new TableSchema.TableColumn(schema);
				colvarIdRelAntecedentePaciente.ColumnName = "idRelAntecedentePaciente";
				colvarIdRelAntecedentePaciente.DataType = DbType.Int32;
				colvarIdRelAntecedentePaciente.MaxLength = 0;
				colvarIdRelAntecedentePaciente.AutoIncrement = true;
				colvarIdRelAntecedentePaciente.IsNullable = false;
				colvarIdRelAntecedentePaciente.IsPrimaryKey = true;
				colvarIdRelAntecedentePaciente.IsForeignKey = false;
				colvarIdRelAntecedentePaciente.IsReadOnly = false;
				colvarIdRelAntecedentePaciente.DefaultSetting = @"";
				colvarIdRelAntecedentePaciente.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdRelAntecedentePaciente);
				
				TableSchema.TableColumn colvarIdAntecedente = new TableSchema.TableColumn(schema);
				colvarIdAntecedente.ColumnName = "idAntecedente";
				colvarIdAntecedente.DataType = DbType.Int32;
				colvarIdAntecedente.MaxLength = 0;
				colvarIdAntecedente.AutoIncrement = false;
				colvarIdAntecedente.IsNullable = true;
				colvarIdAntecedente.IsPrimaryKey = false;
				colvarIdAntecedente.IsForeignKey = true;
				colvarIdAntecedente.IsReadOnly = false;
				colvarIdAntecedente.DefaultSetting = @"";
				
					colvarIdAntecedente.ForeignKeyTableName = "Sys_Antecedente";
				schema.Columns.Add(colvarIdAntecedente);
				
				TableSchema.TableColumn colvarIdPaciente = new TableSchema.TableColumn(schema);
				colvarIdPaciente.ColumnName = "idPaciente";
				colvarIdPaciente.DataType = DbType.Int32;
				colvarIdPaciente.MaxLength = 0;
				colvarIdPaciente.AutoIncrement = false;
				colvarIdPaciente.IsNullable = true;
				colvarIdPaciente.IsPrimaryKey = false;
				colvarIdPaciente.IsForeignKey = false;
				colvarIdPaciente.IsReadOnly = false;
				colvarIdPaciente.DefaultSetting = @"";
				colvarIdPaciente.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdPaciente);
				
				TableSchema.TableColumn colvarIdHCPrehospitalaria = new TableSchema.TableColumn(schema);
				colvarIdHCPrehospitalaria.ColumnName = "idHCPrehospitalaria";
				colvarIdHCPrehospitalaria.DataType = DbType.Int32;
				colvarIdHCPrehospitalaria.MaxLength = 0;
				colvarIdHCPrehospitalaria.AutoIncrement = false;
				colvarIdHCPrehospitalaria.IsNullable = true;
				colvarIdHCPrehospitalaria.IsPrimaryKey = false;
				colvarIdHCPrehospitalaria.IsForeignKey = true;
				colvarIdHCPrehospitalaria.IsReadOnly = false;
				colvarIdHCPrehospitalaria.DefaultSetting = @"";
				
					colvarIdHCPrehospitalaria.ForeignKeyTableName = "EMR_Prehospitalaria";
				schema.Columns.Add(colvarIdHCPrehospitalaria);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["RisProvider"].AddSchema("EMR_RelAntecedentePaciente",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("IdRelAntecedentePaciente")]
		[Bindable(true)]
		public int IdRelAntecedentePaciente 
		{
			get { return GetColumnValue<int>(Columns.IdRelAntecedentePaciente); }
			set { SetColumnValue(Columns.IdRelAntecedentePaciente, value); }
		}
		  
		[XmlAttribute("IdAntecedente")]
		[Bindable(true)]
		public int? IdAntecedente 
		{
			get { return GetColumnValue<int?>(Columns.IdAntecedente); }
			set { SetColumnValue(Columns.IdAntecedente, value); }
		}
		  
		[XmlAttribute("IdPaciente")]
		[Bindable(true)]
		public int? IdPaciente 
		{
			get { return GetColumnValue<int?>(Columns.IdPaciente); }
			set { SetColumnValue(Columns.IdPaciente, value); }
		}
		  
		[XmlAttribute("IdHCPrehospitalaria")]
		[Bindable(true)]
		public int? IdHCPrehospitalaria 
		{
			get { return GetColumnValue<int?>(Columns.IdHCPrehospitalaria); }
			set { SetColumnValue(Columns.IdHCPrehospitalaria, value); }
		}
		
		#endregion
		
		
			
		
		#region ForeignKey Properties
		
		/// <summary>
		/// Returns a SysAntecedente ActiveRecord object related to this EmrRelAntecedentePaciente
		/// 
		/// </summary>
		public DalRis.SysAntecedente SysAntecedente
		{
			get { return DalRis.SysAntecedente.FetchByID(this.IdAntecedente); }
			set { SetColumnValue("idAntecedente", value.IdAntecedente); }
		}
		
		
		/// <summary>
		/// Returns a EmrPrehospitalarium ActiveRecord object related to this EmrRelAntecedentePaciente
		/// 
		/// </summary>
		public DalRis.EmrPrehospitalarium EmrPrehospitalarium
		{
			get { return DalRis.EmrPrehospitalarium.FetchByID(this.IdHCPrehospitalaria); }
			set { SetColumnValue("idHCPrehospitalaria", value.IdHCPrehospitalaria); }
		}
		
		
		#endregion
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(int? varIdAntecedente,int? varIdPaciente,int? varIdHCPrehospitalaria)
		{
			EmrRelAntecedentePaciente item = new EmrRelAntecedentePaciente();
			
			item.IdAntecedente = varIdAntecedente;
			
			item.IdPaciente = varIdPaciente;
			
			item.IdHCPrehospitalaria = varIdHCPrehospitalaria;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varIdRelAntecedentePaciente,int? varIdAntecedente,int? varIdPaciente,int? varIdHCPrehospitalaria)
		{
			EmrRelAntecedentePaciente item = new EmrRelAntecedentePaciente();
			
				item.IdRelAntecedentePaciente = varIdRelAntecedentePaciente;
			
				item.IdAntecedente = varIdAntecedente;
			
				item.IdPaciente = varIdPaciente;
			
				item.IdHCPrehospitalaria = varIdHCPrehospitalaria;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn IdRelAntecedentePacienteColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn IdAntecedenteColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn IdPacienteColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn IdHCPrehospitalariaColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string IdRelAntecedentePaciente = @"idRelAntecedentePaciente";
			 public static string IdAntecedente = @"idAntecedente";
			 public static string IdPaciente = @"idPaciente";
			 public static string IdHCPrehospitalaria = @"idHCPrehospitalaria";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
