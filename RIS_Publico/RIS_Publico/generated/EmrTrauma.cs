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
	/// Strongly-typed collection for the EmrTrauma class.
	/// </summary>
    [Serializable]
	public partial class EmrTraumaCollection : ActiveList<EmrTrauma, EmrTraumaCollection>
	{	   
		public EmrTraumaCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>EmrTraumaCollection</returns>
		public EmrTraumaCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                EmrTrauma o = this[i];
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
	/// This is an ActiveRecord class which wraps the EMR_Trauma table.
	/// </summary>
	[Serializable]
	public partial class EmrTrauma : ActiveRecord<EmrTrauma>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public EmrTrauma()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public EmrTrauma(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public EmrTrauma(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public EmrTrauma(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("EMR_Trauma", TableType.Table, DataService.GetInstance("RisProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarIdTrauma = new TableSchema.TableColumn(schema);
				colvarIdTrauma.ColumnName = "idTrauma";
				colvarIdTrauma.DataType = DbType.Int32;
				colvarIdTrauma.MaxLength = 0;
				colvarIdTrauma.AutoIncrement = true;
				colvarIdTrauma.IsNullable = false;
				colvarIdTrauma.IsPrimaryKey = true;
				colvarIdTrauma.IsForeignKey = false;
				colvarIdTrauma.IsReadOnly = false;
				colvarIdTrauma.DefaultSetting = @"";
				colvarIdTrauma.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdTrauma);
				
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
				
				TableSchema.TableColumn colvarIdTipoTrauma = new TableSchema.TableColumn(schema);
				colvarIdTipoTrauma.ColumnName = "idTipoTrauma";
				colvarIdTipoTrauma.DataType = DbType.Int32;
				colvarIdTipoTrauma.MaxLength = 0;
				colvarIdTipoTrauma.AutoIncrement = false;
				colvarIdTipoTrauma.IsNullable = false;
				colvarIdTipoTrauma.IsPrimaryKey = false;
				colvarIdTipoTrauma.IsForeignKey = true;
				colvarIdTipoTrauma.IsReadOnly = false;
				
						colvarIdTipoTrauma.DefaultSetting = @"((0))";
				
					colvarIdTipoTrauma.ForeignKeyTableName = "EMR_TipoTrauma";
				schema.Columns.Add(colvarIdTipoTrauma);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["RisProvider"].AddSchema("EMR_Trauma",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("IdTrauma")]
		[Bindable(true)]
		public int IdTrauma 
		{
			get { return GetColumnValue<int>(Columns.IdTrauma); }
			set { SetColumnValue(Columns.IdTrauma, value); }
		}
		  
		[XmlAttribute("Nombre")]
		[Bindable(true)]
		public string Nombre 
		{
			get { return GetColumnValue<string>(Columns.Nombre); }
			set { SetColumnValue(Columns.Nombre, value); }
		}
		  
		[XmlAttribute("IdTipoTrauma")]
		[Bindable(true)]
		public int IdTipoTrauma 
		{
			get { return GetColumnValue<int>(Columns.IdTipoTrauma); }
			set { SetColumnValue(Columns.IdTipoTrauma, value); }
		}
		
		#endregion
		
		
		#region PrimaryKey Methods		
		
        protected override void SetPrimaryKey(object oValue)
        {
            base.SetPrimaryKey(oValue);
            
            SetPKValues();
        }
        
		
		private DalRis.EmrRelTraumaPrehospitalariumCollection colEmrRelTraumaPrehospitalaria;
		public DalRis.EmrRelTraumaPrehospitalariumCollection EmrRelTraumaPrehospitalaria()
		{
			if(colEmrRelTraumaPrehospitalaria == null)
			{
				colEmrRelTraumaPrehospitalaria = new DalRis.EmrRelTraumaPrehospitalariumCollection().Where(EmrRelTraumaPrehospitalarium.Columns.IdTrauma, IdTrauma).Load();
				colEmrRelTraumaPrehospitalaria.ListChanged += new ListChangedEventHandler(colEmrRelTraumaPrehospitalaria_ListChanged);
			}
			return colEmrRelTraumaPrehospitalaria;
		}
				
		void colEmrRelTraumaPrehospitalaria_ListChanged(object sender, ListChangedEventArgs e)
		{
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
		        // Set foreign key value
		        colEmrRelTraumaPrehospitalaria[e.NewIndex].IdTrauma = IdTrauma;
				colEmrRelTraumaPrehospitalaria.ListChanged += new ListChangedEventHandler(colEmrRelTraumaPrehospitalaria_ListChanged);
            }
		}
		#endregion
		
			
		
		#region ForeignKey Properties
		
		/// <summary>
		/// Returns a EmrTipoTrauma ActiveRecord object related to this EmrTrauma
		/// 
		/// </summary>
		public DalRis.EmrTipoTrauma EmrTipoTrauma
		{
			get { return DalRis.EmrTipoTrauma.FetchByID(this.IdTipoTrauma); }
			set { SetColumnValue("idTipoTrauma", value.IdTipoTrauma); }
		}
		
		
		#endregion
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varNombre,int varIdTipoTrauma)
		{
			EmrTrauma item = new EmrTrauma();
			
			item.Nombre = varNombre;
			
			item.IdTipoTrauma = varIdTipoTrauma;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varIdTrauma,string varNombre,int varIdTipoTrauma)
		{
			EmrTrauma item = new EmrTrauma();
			
				item.IdTrauma = varIdTrauma;
			
				item.Nombre = varNombre;
			
				item.IdTipoTrauma = varIdTipoTrauma;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn IdTraumaColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn NombreColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn IdTipoTraumaColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string IdTrauma = @"idTrauma";
			 public static string Nombre = @"nombre";
			 public static string IdTipoTrauma = @"idTipoTrauma";
						
		}
		#endregion
		
		#region Update PK Collections
		
        public void SetPKValues()
        {
                if (colEmrRelTraumaPrehospitalaria != null)
                {
                    foreach (DalRis.EmrRelTraumaPrehospitalarium item in colEmrRelTraumaPrehospitalaria)
                    {
                        if (item.IdTrauma != IdTrauma)
                        {
                            item.IdTrauma = IdTrauma;
                        }
                    }
               }
		}
        #endregion
    
        #region Deep Save
		
        public void DeepSave()
        {
            Save();
            
                if (colEmrRelTraumaPrehospitalaria != null)
                {
                    colEmrRelTraumaPrehospitalaria.SaveAll();
               }
		}
        #endregion
	}
}
