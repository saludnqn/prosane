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
	/// Strongly-typed collection for the EmrGlasgowOcular class.
	/// </summary>
    [Serializable]
	public partial class EmrGlasgowOcularCollection : ActiveList<EmrGlasgowOcular, EmrGlasgowOcularCollection>
	{	   
		public EmrGlasgowOcularCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>EmrGlasgowOcularCollection</returns>
		public EmrGlasgowOcularCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                EmrGlasgowOcular o = this[i];
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
	/// This is an ActiveRecord class which wraps the EMR_GlasgowOcular table.
	/// </summary>
	[Serializable]
	public partial class EmrGlasgowOcular : ActiveRecord<EmrGlasgowOcular>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public EmrGlasgowOcular()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public EmrGlasgowOcular(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public EmrGlasgowOcular(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public EmrGlasgowOcular(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("EMR_GlasgowOcular", TableType.Table, DataService.GetInstance("RisProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarIdGlasgowOcular = new TableSchema.TableColumn(schema);
				colvarIdGlasgowOcular.ColumnName = "idGlasgowOcular";
				colvarIdGlasgowOcular.DataType = DbType.Int32;
				colvarIdGlasgowOcular.MaxLength = 0;
				colvarIdGlasgowOcular.AutoIncrement = true;
				colvarIdGlasgowOcular.IsNullable = false;
				colvarIdGlasgowOcular.IsPrimaryKey = true;
				colvarIdGlasgowOcular.IsForeignKey = false;
				colvarIdGlasgowOcular.IsReadOnly = false;
				colvarIdGlasgowOcular.DefaultSetting = @"";
				colvarIdGlasgowOcular.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdGlasgowOcular);
				
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
				
				TableSchema.TableColumn colvarValor = new TableSchema.TableColumn(schema);
				colvarValor.ColumnName = "valor";
				colvarValor.DataType = DbType.Int32;
				colvarValor.MaxLength = 0;
				colvarValor.AutoIncrement = false;
				colvarValor.IsNullable = false;
				colvarValor.IsPrimaryKey = false;
				colvarValor.IsForeignKey = false;
				colvarValor.IsReadOnly = false;
				
						colvarValor.DefaultSetting = @"((0))";
				colvarValor.ForeignKeyTableName = "";
				schema.Columns.Add(colvarValor);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["RisProvider"].AddSchema("EMR_GlasgowOcular",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("IdGlasgowOcular")]
		[Bindable(true)]
		public int IdGlasgowOcular 
		{
			get { return GetColumnValue<int>(Columns.IdGlasgowOcular); }
			set { SetColumnValue(Columns.IdGlasgowOcular, value); }
		}
		  
		[XmlAttribute("Nombre")]
		[Bindable(true)]
		public string Nombre 
		{
			get { return GetColumnValue<string>(Columns.Nombre); }
			set { SetColumnValue(Columns.Nombre, value); }
		}
		  
		[XmlAttribute("Valor")]
		[Bindable(true)]
		public int Valor 
		{
			get { return GetColumnValue<int>(Columns.Valor); }
			set { SetColumnValue(Columns.Valor, value); }
		}
		
		#endregion
		
		
		#region PrimaryKey Methods		
		
        protected override void SetPrimaryKey(object oValue)
        {
            base.SetPrimaryKey(oValue);
            
            SetPKValues();
        }
        
		
		private DalRis.EmrPrehospitalariumCollection colEmrPrehospitalaria;
		public DalRis.EmrPrehospitalariumCollection EmrPrehospitalaria()
		{
			if(colEmrPrehospitalaria == null)
			{
				colEmrPrehospitalaria = new DalRis.EmrPrehospitalariumCollection().Where(EmrPrehospitalarium.Columns.IdGlasgowOcular, IdGlasgowOcular).Load();
				colEmrPrehospitalaria.ListChanged += new ListChangedEventHandler(colEmrPrehospitalaria_ListChanged);
			}
			return colEmrPrehospitalaria;
		}
				
		void colEmrPrehospitalaria_ListChanged(object sender, ListChangedEventArgs e)
		{
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
		        // Set foreign key value
		        colEmrPrehospitalaria[e.NewIndex].IdGlasgowOcular = IdGlasgowOcular;
				colEmrPrehospitalaria.ListChanged += new ListChangedEventHandler(colEmrPrehospitalaria_ListChanged);
            }
		}
		#endregion
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varNombre,int varValor)
		{
			EmrGlasgowOcular item = new EmrGlasgowOcular();
			
			item.Nombre = varNombre;
			
			item.Valor = varValor;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varIdGlasgowOcular,string varNombre,int varValor)
		{
			EmrGlasgowOcular item = new EmrGlasgowOcular();
			
				item.IdGlasgowOcular = varIdGlasgowOcular;
			
				item.Nombre = varNombre;
			
				item.Valor = varValor;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn IdGlasgowOcularColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn NombreColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn ValorColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string IdGlasgowOcular = @"idGlasgowOcular";
			 public static string Nombre = @"nombre";
			 public static string Valor = @"valor";
						
		}
		#endregion
		
		#region Update PK Collections
		
        public void SetPKValues()
        {
                if (colEmrPrehospitalaria != null)
                {
                    foreach (DalRis.EmrPrehospitalarium item in colEmrPrehospitalaria)
                    {
                        if (item.IdGlasgowOcular != IdGlasgowOcular)
                        {
                            item.IdGlasgowOcular = IdGlasgowOcular;
                        }
                    }
               }
		}
        #endregion
    
        #region Deep Save
		
        public void DeepSave()
        {
            Save();
            
                if (colEmrPrehospitalaria != null)
                {
                    colEmrPrehospitalaria.SaveAll();
               }
		}
        #endregion
	}
}
