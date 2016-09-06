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
	/// Strongly-typed collection for the AutPmp class.
	/// </summary>
    [Serializable]
	public partial class AutPmpCollection : ActiveList<AutPmp, AutPmpCollection>
	{	   
		public AutPmpCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>AutPmpCollection</returns>
		public AutPmpCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                AutPmp o = this[i];
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
	/// This is an ActiveRecord class which wraps the AUT_PMP table.
	/// </summary>
	[Serializable]
	public partial class AutPmp : ActiveRecord<AutPmp>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public AutPmp()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public AutPmp(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public AutPmp(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public AutPmp(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("AUT_PMP", TableType.Table, DataService.GetInstance("RisProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarIdPMP = new TableSchema.TableColumn(schema);
				colvarIdPMP.ColumnName = "idPMP";
				colvarIdPMP.DataType = DbType.Int32;
				colvarIdPMP.MaxLength = 0;
				colvarIdPMP.AutoIncrement = true;
				colvarIdPMP.IsNullable = false;
				colvarIdPMP.IsPrimaryKey = true;
				colvarIdPMP.IsForeignKey = false;
				colvarIdPMP.IsReadOnly = false;
				colvarIdPMP.DefaultSetting = @"";
				colvarIdPMP.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdPMP);
				
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
				
				TableSchema.TableColumn colvarKilometraje = new TableSchema.TableColumn(schema);
				colvarKilometraje.ColumnName = "kilometraje";
				colvarKilometraje.DataType = DbType.Int32;
				colvarKilometraje.MaxLength = 0;
				colvarKilometraje.AutoIncrement = false;
				colvarKilometraje.IsNullable = false;
				colvarKilometraje.IsPrimaryKey = false;
				colvarKilometraje.IsForeignKey = false;
				colvarKilometraje.IsReadOnly = false;
				colvarKilometraje.DefaultSetting = @"";
				colvarKilometraje.ForeignKeyTableName = "";
				schema.Columns.Add(colvarKilometraje);
				
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
				
				TableSchema.TableColumn colvarIdTipoPNP = new TableSchema.TableColumn(schema);
				colvarIdTipoPNP.ColumnName = "idTipoPNP";
				colvarIdTipoPNP.DataType = DbType.Int32;
				colvarIdTipoPNP.MaxLength = 0;
				colvarIdTipoPNP.AutoIncrement = false;
				colvarIdTipoPNP.IsNullable = true;
				colvarIdTipoPNP.IsPrimaryKey = false;
				colvarIdTipoPNP.IsForeignKey = false;
				colvarIdTipoPNP.IsReadOnly = false;
				colvarIdTipoPNP.DefaultSetting = @"";
				colvarIdTipoPNP.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdTipoPNP);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["RisProvider"].AddSchema("AUT_PMP",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("IdPMP")]
		[Bindable(true)]
		public int IdPMP 
		{
			get { return GetColumnValue<int>(Columns.IdPMP); }
			set { SetColumnValue(Columns.IdPMP, value); }
		}
		  
		[XmlAttribute("Nombre")]
		[Bindable(true)]
		public string Nombre 
		{
			get { return GetColumnValue<string>(Columns.Nombre); }
			set { SetColumnValue(Columns.Nombre, value); }
		}
		  
		[XmlAttribute("Kilometraje")]
		[Bindable(true)]
		public int Kilometraje 
		{
			get { return GetColumnValue<int>(Columns.Kilometraje); }
			set { SetColumnValue(Columns.Kilometraje, value); }
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
		  
		[XmlAttribute("IdTipoPNP")]
		[Bindable(true)]
		public int? IdTipoPNP 
		{
			get { return GetColumnValue<int?>(Columns.IdTipoPNP); }
			set { SetColumnValue(Columns.IdTipoPNP, value); }
		}
		
		#endregion
		
		
		#region PrimaryKey Methods		
		
        protected override void SetPrimaryKey(object oValue)
        {
            base.SetPrimaryKey(oValue);
            
            SetPKValues();
        }
        
		
		private DalRis.AutVehiculoPmpCollection colAutVehiculoPmpRecords;
		public DalRis.AutVehiculoPmpCollection AutVehiculoPmpRecords()
		{
			if(colAutVehiculoPmpRecords == null)
			{
				colAutVehiculoPmpRecords = new DalRis.AutVehiculoPmpCollection().Where(AutVehiculoPmp.Columns.IdPMP, IdPMP).Load();
				colAutVehiculoPmpRecords.ListChanged += new ListChangedEventHandler(colAutVehiculoPmpRecords_ListChanged);
			}
			return colAutVehiculoPmpRecords;
		}
				
		void colAutVehiculoPmpRecords_ListChanged(object sender, ListChangedEventArgs e)
		{
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
		        // Set foreign key value
		        colAutVehiculoPmpRecords[e.NewIndex].IdPMP = IdPMP;
				colAutVehiculoPmpRecords.ListChanged += new ListChangedEventHandler(colAutVehiculoPmpRecords_ListChanged);
            }
		}
		#endregion
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varNombre,int varKilometraje,int? varIdPMPTipo,int varIdUsuarioRegistro,DateTime varFechaRegistro,int? varIdTipoPNP)
		{
			AutPmp item = new AutPmp();
			
			item.Nombre = varNombre;
			
			item.Kilometraje = varKilometraje;
			
			item.IdPMPTipo = varIdPMPTipo;
			
			item.IdUsuarioRegistro = varIdUsuarioRegistro;
			
			item.FechaRegistro = varFechaRegistro;
			
			item.IdTipoPNP = varIdTipoPNP;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varIdPMP,string varNombre,int varKilometraje,int? varIdPMPTipo,int varIdUsuarioRegistro,DateTime varFechaRegistro,int? varIdTipoPNP)
		{
			AutPmp item = new AutPmp();
			
				item.IdPMP = varIdPMP;
			
				item.Nombre = varNombre;
			
				item.Kilometraje = varKilometraje;
			
				item.IdPMPTipo = varIdPMPTipo;
			
				item.IdUsuarioRegistro = varIdUsuarioRegistro;
			
				item.FechaRegistro = varFechaRegistro;
			
				item.IdTipoPNP = varIdTipoPNP;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn IdPMPColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn NombreColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn KilometrajeColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn IdPMPTipoColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn IdUsuarioRegistroColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn FechaRegistroColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        public static TableSchema.TableColumn IdTipoPNPColumn
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string IdPMP = @"idPMP";
			 public static string Nombre = @"nombre";
			 public static string Kilometraje = @"kilometraje";
			 public static string IdPMPTipo = @"idPMPTipo";
			 public static string IdUsuarioRegistro = @"idUsuarioRegistro";
			 public static string FechaRegistro = @"fechaRegistro";
			 public static string IdTipoPNP = @"idTipoPNP";
						
		}
		#endregion
		
		#region Update PK Collections
		
        public void SetPKValues()
        {
                if (colAutVehiculoPmpRecords != null)
                {
                    foreach (DalRis.AutVehiculoPmp item in colAutVehiculoPmpRecords)
                    {
                        if (item.IdPMP != IdPMP)
                        {
                            item.IdPMP = IdPMP;
                        }
                    }
               }
		}
        #endregion
    
        #region Deep Save
		
        public void DeepSave()
        {
            Save();
            
                if (colAutVehiculoPmpRecords != null)
                {
                    colAutVehiculoPmpRecords.SaveAll();
               }
		}
        #endregion
	}
}
