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
	/// Strongly-typed collection for the EmrPupila class.
	/// </summary>
    [Serializable]
	public partial class EmrPupilaCollection : ActiveList<EmrPupila, EmrPupilaCollection>
	{	   
		public EmrPupilaCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>EmrPupilaCollection</returns>
		public EmrPupilaCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                EmrPupila o = this[i];
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
	/// This is an ActiveRecord class which wraps the EMR_Pupilas table.
	/// </summary>
	[Serializable]
	public partial class EmrPupila : ActiveRecord<EmrPupila>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public EmrPupila()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public EmrPupila(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public EmrPupila(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public EmrPupila(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("EMR_Pupilas", TableType.Table, DataService.GetInstance("RisProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarIdPupilas = new TableSchema.TableColumn(schema);
				colvarIdPupilas.ColumnName = "idPupilas";
				colvarIdPupilas.DataType = DbType.Int32;
				colvarIdPupilas.MaxLength = 0;
				colvarIdPupilas.AutoIncrement = true;
				colvarIdPupilas.IsNullable = false;
				colvarIdPupilas.IsPrimaryKey = true;
				colvarIdPupilas.IsForeignKey = false;
				colvarIdPupilas.IsReadOnly = false;
				colvarIdPupilas.DefaultSetting = @"";
				colvarIdPupilas.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdPupilas);
				
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
				
				TableSchema.TableColumn colvarDescripcion = new TableSchema.TableColumn(schema);
				colvarDescripcion.ColumnName = "descripcion";
				colvarDescripcion.DataType = DbType.AnsiString;
				colvarDescripcion.MaxLength = 50;
				colvarDescripcion.AutoIncrement = false;
				colvarDescripcion.IsNullable = false;
				colvarDescripcion.IsPrimaryKey = false;
				colvarDescripcion.IsForeignKey = false;
				colvarDescripcion.IsReadOnly = false;
				
						colvarDescripcion.DefaultSetting = @"('')";
				colvarDescripcion.ForeignKeyTableName = "";
				schema.Columns.Add(colvarDescripcion);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["RisProvider"].AddSchema("EMR_Pupilas",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("IdPupilas")]
		[Bindable(true)]
		public int IdPupilas 
		{
			get { return GetColumnValue<int>(Columns.IdPupilas); }
			set { SetColumnValue(Columns.IdPupilas, value); }
		}
		  
		[XmlAttribute("Nombre")]
		[Bindable(true)]
		public string Nombre 
		{
			get { return GetColumnValue<string>(Columns.Nombre); }
			set { SetColumnValue(Columns.Nombre, value); }
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
        
		
		private DalRis.EmrPrehospitalariumCollection colEmrPrehospitalaria;
		public DalRis.EmrPrehospitalariumCollection EmrPrehospitalaria()
		{
			if(colEmrPrehospitalaria == null)
			{
				colEmrPrehospitalaria = new DalRis.EmrPrehospitalariumCollection().Where(EmrPrehospitalarium.Columns.IdPupilas, IdPupilas).Load();
				colEmrPrehospitalaria.ListChanged += new ListChangedEventHandler(colEmrPrehospitalaria_ListChanged);
			}
			return colEmrPrehospitalaria;
		}
				
		void colEmrPrehospitalaria_ListChanged(object sender, ListChangedEventArgs e)
		{
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
		        // Set foreign key value
		        colEmrPrehospitalaria[e.NewIndex].IdPupilas = IdPupilas;
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
		public static void Insert(string varNombre,string varDescripcion)
		{
			EmrPupila item = new EmrPupila();
			
			item.Nombre = varNombre;
			
			item.Descripcion = varDescripcion;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varIdPupilas,string varNombre,string varDescripcion)
		{
			EmrPupila item = new EmrPupila();
			
				item.IdPupilas = varIdPupilas;
			
				item.Nombre = varNombre;
			
				item.Descripcion = varDescripcion;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn IdPupilasColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn NombreColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn DescripcionColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string IdPupilas = @"idPupilas";
			 public static string Nombre = @"nombre";
			 public static string Descripcion = @"descripcion";
						
		}
		#endregion
		
		#region Update PK Collections
		
        public void SetPKValues()
        {
                if (colEmrPrehospitalaria != null)
                {
                    foreach (DalRis.EmrPrehospitalarium item in colEmrPrehospitalaria)
                    {
                        if (item.IdPupilas != IdPupilas)
                        {
                            item.IdPupilas = IdPupilas;
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
