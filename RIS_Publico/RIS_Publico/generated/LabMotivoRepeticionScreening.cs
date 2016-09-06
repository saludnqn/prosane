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
	/// Strongly-typed collection for the LabMotivoRepeticionScreening class.
	/// </summary>
    [Serializable]
	public partial class LabMotivoRepeticionScreeningCollection : ActiveList<LabMotivoRepeticionScreening, LabMotivoRepeticionScreeningCollection>
	{	   
		public LabMotivoRepeticionScreeningCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>LabMotivoRepeticionScreeningCollection</returns>
		public LabMotivoRepeticionScreeningCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                LabMotivoRepeticionScreening o = this[i];
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
	/// This is an ActiveRecord class which wraps the LAB_MotivoRepeticionScreening table.
	/// </summary>
	[Serializable]
	public partial class LabMotivoRepeticionScreening : ActiveRecord<LabMotivoRepeticionScreening>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public LabMotivoRepeticionScreening()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public LabMotivoRepeticionScreening(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public LabMotivoRepeticionScreening(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public LabMotivoRepeticionScreening(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("LAB_MotivoRepeticionScreening", TableType.Table, DataService.GetInstance("RisProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarIdMotivoRepeticionScreening = new TableSchema.TableColumn(schema);
				colvarIdMotivoRepeticionScreening.ColumnName = "idMotivoRepeticionScreening";
				colvarIdMotivoRepeticionScreening.DataType = DbType.Int32;
				colvarIdMotivoRepeticionScreening.MaxLength = 0;
				colvarIdMotivoRepeticionScreening.AutoIncrement = true;
				colvarIdMotivoRepeticionScreening.IsNullable = false;
				colvarIdMotivoRepeticionScreening.IsPrimaryKey = true;
				colvarIdMotivoRepeticionScreening.IsForeignKey = false;
				colvarIdMotivoRepeticionScreening.IsReadOnly = false;
				colvarIdMotivoRepeticionScreening.DefaultSetting = @"";
				colvarIdMotivoRepeticionScreening.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdMotivoRepeticionScreening);
				
				TableSchema.TableColumn colvarDescripcion = new TableSchema.TableColumn(schema);
				colvarDescripcion.ColumnName = "descripcion";
				colvarDescripcion.DataType = DbType.String;
				colvarDescripcion.MaxLength = 500;
				colvarDescripcion.AutoIncrement = false;
				colvarDescripcion.IsNullable = false;
				colvarDescripcion.IsPrimaryKey = false;
				colvarDescripcion.IsForeignKey = false;
				colvarDescripcion.IsReadOnly = false;
				colvarDescripcion.DefaultSetting = @"";
				colvarDescripcion.ForeignKeyTableName = "";
				schema.Columns.Add(colvarDescripcion);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["RisProvider"].AddSchema("LAB_MotivoRepeticionScreening",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("IdMotivoRepeticionScreening")]
		[Bindable(true)]
		public int IdMotivoRepeticionScreening 
		{
			get { return GetColumnValue<int>(Columns.IdMotivoRepeticionScreening); }
			set { SetColumnValue(Columns.IdMotivoRepeticionScreening, value); }
		}
		  
		[XmlAttribute("Descripcion")]
		[Bindable(true)]
		public string Descripcion 
		{
			get { return GetColumnValue<string>(Columns.Descripcion); }
			set { SetColumnValue(Columns.Descripcion, value); }
		}
		
		#endregion
		
		
		#region PrimaryKey Methods		
		
        protected override void SetPrimaryKey(object oValue)
        {
            base.SetPrimaryKey(oValue);
            
            SetPKValues();
        }
        
		
		private DalRis.LabSolicitudScreeningRepeticionCollection colLabSolicitudScreeningRepeticionRecords;
		public DalRis.LabSolicitudScreeningRepeticionCollection LabSolicitudScreeningRepeticionRecords()
		{
			if(colLabSolicitudScreeningRepeticionRecords == null)
			{
				colLabSolicitudScreeningRepeticionRecords = new DalRis.LabSolicitudScreeningRepeticionCollection().Where(LabSolicitudScreeningRepeticion.Columns.IdMotivoRepeticion, IdMotivoRepeticionScreening).Load();
				colLabSolicitudScreeningRepeticionRecords.ListChanged += new ListChangedEventHandler(colLabSolicitudScreeningRepeticionRecords_ListChanged);
			}
			return colLabSolicitudScreeningRepeticionRecords;
		}
				
		void colLabSolicitudScreeningRepeticionRecords_ListChanged(object sender, ListChangedEventArgs e)
		{
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
		        // Set foreign key value
		        colLabSolicitudScreeningRepeticionRecords[e.NewIndex].IdMotivoRepeticion = IdMotivoRepeticionScreening;
				colLabSolicitudScreeningRepeticionRecords.ListChanged += new ListChangedEventHandler(colLabSolicitudScreeningRepeticionRecords_ListChanged);
            }
		}
		#endregion
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varDescripcion)
		{
			LabMotivoRepeticionScreening item = new LabMotivoRepeticionScreening();
			
			item.Descripcion = varDescripcion;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varIdMotivoRepeticionScreening,string varDescripcion)
		{
			LabMotivoRepeticionScreening item = new LabMotivoRepeticionScreening();
			
				item.IdMotivoRepeticionScreening = varIdMotivoRepeticionScreening;
			
				item.Descripcion = varDescripcion;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn IdMotivoRepeticionScreeningColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn DescripcionColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string IdMotivoRepeticionScreening = @"idMotivoRepeticionScreening";
			 public static string Descripcion = @"descripcion";
						
		}
		#endregion
		
		#region Update PK Collections
		
        public void SetPKValues()
        {
                if (colLabSolicitudScreeningRepeticionRecords != null)
                {
                    foreach (DalRis.LabSolicitudScreeningRepeticion item in colLabSolicitudScreeningRepeticionRecords)
                    {
                        if (item.IdMotivoRepeticion != IdMotivoRepeticionScreening)
                        {
                            item.IdMotivoRepeticion = IdMotivoRepeticionScreening;
                        }
                    }
               }
		}
        #endregion
    
        #region Deep Save
		
        public void DeepSave()
        {
            Save();
            
                if (colLabSolicitudScreeningRepeticionRecords != null)
                {
                    colLabSolicitudScreeningRepeticionRecords.SaveAll();
               }
		}
        #endregion
	}
}
