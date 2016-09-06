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
	/// Strongly-typed collection for the FacTipoIva class.
	/// </summary>
    [Serializable]
	public partial class FacTipoIvaCollection : ActiveList<FacTipoIva, FacTipoIvaCollection>
	{	   
		public FacTipoIvaCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>FacTipoIvaCollection</returns>
		public FacTipoIvaCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                FacTipoIva o = this[i];
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
	/// This is an ActiveRecord class which wraps the FAC_TipoIva table.
	/// </summary>
	[Serializable]
	public partial class FacTipoIva : ActiveRecord<FacTipoIva>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public FacTipoIva()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public FacTipoIva(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public FacTipoIva(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public FacTipoIva(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("FAC_TipoIva", TableType.Table, DataService.GetInstance("RisProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarIdTipoIva = new TableSchema.TableColumn(schema);
				colvarIdTipoIva.ColumnName = "idTipoIva";
				colvarIdTipoIva.DataType = DbType.Int32;
				colvarIdTipoIva.MaxLength = 0;
				colvarIdTipoIva.AutoIncrement = true;
				colvarIdTipoIva.IsNullable = false;
				colvarIdTipoIva.IsPrimaryKey = true;
				colvarIdTipoIva.IsForeignKey = false;
				colvarIdTipoIva.IsReadOnly = false;
				colvarIdTipoIva.DefaultSetting = @"";
				colvarIdTipoIva.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdTipoIva);
				
				TableSchema.TableColumn colvarNombre = new TableSchema.TableColumn(schema);
				colvarNombre.ColumnName = "nombre";
				colvarNombre.DataType = DbType.AnsiString;
				colvarNombre.MaxLength = 50;
				colvarNombre.AutoIncrement = false;
				colvarNombre.IsNullable = false;
				colvarNombre.IsPrimaryKey = false;
				colvarNombre.IsForeignKey = false;
				colvarNombre.IsReadOnly = false;
				colvarNombre.DefaultSetting = @"";
				colvarNombre.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNombre);
				
				TableSchema.TableColumn colvarAbreviatura = new TableSchema.TableColumn(schema);
				colvarAbreviatura.ColumnName = "abreviatura";
				colvarAbreviatura.DataType = DbType.AnsiString;
				colvarAbreviatura.MaxLength = 50;
				colvarAbreviatura.AutoIncrement = false;
				colvarAbreviatura.IsNullable = false;
				colvarAbreviatura.IsPrimaryKey = false;
				colvarAbreviatura.IsForeignKey = false;
				colvarAbreviatura.IsReadOnly = false;
				
						colvarAbreviatura.DefaultSetting = @"('')";
				colvarAbreviatura.ForeignKeyTableName = "";
				schema.Columns.Add(colvarAbreviatura);
				
				TableSchema.TableColumn colvarRecibeComprobante = new TableSchema.TableColumn(schema);
				colvarRecibeComprobante.ColumnName = "recibeComprobante";
				colvarRecibeComprobante.DataType = DbType.AnsiString;
				colvarRecibeComprobante.MaxLength = 50;
				colvarRecibeComprobante.AutoIncrement = false;
				colvarRecibeComprobante.IsNullable = false;
				colvarRecibeComprobante.IsPrimaryKey = false;
				colvarRecibeComprobante.IsForeignKey = false;
				colvarRecibeComprobante.IsReadOnly = false;
				
						colvarRecibeComprobante.DefaultSetting = @"('')";
				colvarRecibeComprobante.ForeignKeyTableName = "";
				schema.Columns.Add(colvarRecibeComprobante);
				
				TableSchema.TableColumn colvarEmiteComprobante = new TableSchema.TableColumn(schema);
				colvarEmiteComprobante.ColumnName = "emiteComprobante";
				colvarEmiteComprobante.DataType = DbType.AnsiString;
				colvarEmiteComprobante.MaxLength = 50;
				colvarEmiteComprobante.AutoIncrement = false;
				colvarEmiteComprobante.IsNullable = false;
				colvarEmiteComprobante.IsPrimaryKey = false;
				colvarEmiteComprobante.IsForeignKey = false;
				colvarEmiteComprobante.IsReadOnly = false;
				
						colvarEmiteComprobante.DefaultSetting = @"('')";
				colvarEmiteComprobante.ForeignKeyTableName = "";
				schema.Columns.Add(colvarEmiteComprobante);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["RisProvider"].AddSchema("FAC_TipoIva",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("IdTipoIva")]
		[Bindable(true)]
		public int IdTipoIva 
		{
			get { return GetColumnValue<int>(Columns.IdTipoIva); }
			set { SetColumnValue(Columns.IdTipoIva, value); }
		}
		  
		[XmlAttribute("Nombre")]
		[Bindable(true)]
		public string Nombre 
		{
			get { return GetColumnValue<string>(Columns.Nombre); }
			set { SetColumnValue(Columns.Nombre, value); }
		}
		  
		[XmlAttribute("Abreviatura")]
		[Bindable(true)]
		public string Abreviatura 
		{
			get { return GetColumnValue<string>(Columns.Abreviatura); }
			set { SetColumnValue(Columns.Abreviatura, value); }
		}
		  
		[XmlAttribute("RecibeComprobante")]
		[Bindable(true)]
		public string RecibeComprobante 
		{
			get { return GetColumnValue<string>(Columns.RecibeComprobante); }
			set { SetColumnValue(Columns.RecibeComprobante, value); }
		}
		  
		[XmlAttribute("EmiteComprobante")]
		[Bindable(true)]
		public string EmiteComprobante 
		{
			get { return GetColumnValue<string>(Columns.EmiteComprobante); }
			set { SetColumnValue(Columns.EmiteComprobante, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varNombre,string varAbreviatura,string varRecibeComprobante,string varEmiteComprobante)
		{
			FacTipoIva item = new FacTipoIva();
			
			item.Nombre = varNombre;
			
			item.Abreviatura = varAbreviatura;
			
			item.RecibeComprobante = varRecibeComprobante;
			
			item.EmiteComprobante = varEmiteComprobante;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varIdTipoIva,string varNombre,string varAbreviatura,string varRecibeComprobante,string varEmiteComprobante)
		{
			FacTipoIva item = new FacTipoIva();
			
				item.IdTipoIva = varIdTipoIva;
			
				item.Nombre = varNombre;
			
				item.Abreviatura = varAbreviatura;
			
				item.RecibeComprobante = varRecibeComprobante;
			
				item.EmiteComprobante = varEmiteComprobante;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn IdTipoIvaColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn NombreColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn AbreviaturaColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn RecibeComprobanteColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn EmiteComprobanteColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string IdTipoIva = @"idTipoIva";
			 public static string Nombre = @"nombre";
			 public static string Abreviatura = @"abreviatura";
			 public static string RecibeComprobante = @"recibeComprobante";
			 public static string EmiteComprobante = @"emiteComprobante";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
