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
	/// Strongly-typed collection for the FacFacturaDetalle class.
	/// </summary>
    [Serializable]
	public partial class FacFacturaDetalleCollection : ActiveList<FacFacturaDetalle, FacFacturaDetalleCollection>
	{	   
		public FacFacturaDetalleCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>FacFacturaDetalleCollection</returns>
		public FacFacturaDetalleCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                FacFacturaDetalle o = this[i];
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
	/// This is an ActiveRecord class which wraps the FAC_FacturaDetalle table.
	/// </summary>
	[Serializable]
	public partial class FacFacturaDetalle : ActiveRecord<FacFacturaDetalle>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public FacFacturaDetalle()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public FacFacturaDetalle(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public FacFacturaDetalle(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public FacFacturaDetalle(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("FAC_FacturaDetalle", TableType.Table, DataService.GetInstance("RisProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarIdFacturaDetalle = new TableSchema.TableColumn(schema);
				colvarIdFacturaDetalle.ColumnName = "idFacturaDetalle";
				colvarIdFacturaDetalle.DataType = DbType.Int32;
				colvarIdFacturaDetalle.MaxLength = 0;
				colvarIdFacturaDetalle.AutoIncrement = true;
				colvarIdFacturaDetalle.IsNullable = false;
				colvarIdFacturaDetalle.IsPrimaryKey = true;
				colvarIdFacturaDetalle.IsForeignKey = false;
				colvarIdFacturaDetalle.IsReadOnly = false;
				colvarIdFacturaDetalle.DefaultSetting = @"";
				colvarIdFacturaDetalle.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdFacturaDetalle);
				
				TableSchema.TableColumn colvarIdFactura = new TableSchema.TableColumn(schema);
				colvarIdFactura.ColumnName = "idFactura";
				colvarIdFactura.DataType = DbType.Int32;
				colvarIdFactura.MaxLength = 0;
				colvarIdFactura.AutoIncrement = false;
				colvarIdFactura.IsNullable = false;
				colvarIdFactura.IsPrimaryKey = false;
				colvarIdFactura.IsForeignKey = true;
				colvarIdFactura.IsReadOnly = false;
				colvarIdFactura.DefaultSetting = @"";
				
					colvarIdFactura.ForeignKeyTableName = "FAC_Factura";
				schema.Columns.Add(colvarIdFactura);
				
				TableSchema.TableColumn colvarCantidad = new TableSchema.TableColumn(schema);
				colvarCantidad.ColumnName = "cantidad";
				colvarCantidad.DataType = DbType.Int32;
				colvarCantidad.MaxLength = 0;
				colvarCantidad.AutoIncrement = false;
				colvarCantidad.IsNullable = false;
				colvarCantidad.IsPrimaryKey = false;
				colvarCantidad.IsForeignKey = false;
				colvarCantidad.IsReadOnly = false;
				colvarCantidad.DefaultSetting = @"";
				colvarCantidad.ForeignKeyTableName = "";
				schema.Columns.Add(colvarCantidad);
				
				TableSchema.TableColumn colvarDescripcion = new TableSchema.TableColumn(schema);
				colvarDescripcion.ColumnName = "descripcion";
				colvarDescripcion.DataType = DbType.AnsiString;
				colvarDescripcion.MaxLength = 250;
				colvarDescripcion.AutoIncrement = false;
				colvarDescripcion.IsNullable = false;
				colvarDescripcion.IsPrimaryKey = false;
				colvarDescripcion.IsForeignKey = false;
				colvarDescripcion.IsReadOnly = false;
				colvarDescripcion.DefaultSetting = @"";
				colvarDescripcion.ForeignKeyTableName = "";
				schema.Columns.Add(colvarDescripcion);
				
				TableSchema.TableColumn colvarValorUnidad = new TableSchema.TableColumn(schema);
				colvarValorUnidad.ColumnName = "valorUnidad";
				colvarValorUnidad.DataType = DbType.Decimal;
				colvarValorUnidad.MaxLength = 0;
				colvarValorUnidad.AutoIncrement = false;
				colvarValorUnidad.IsNullable = false;
				colvarValorUnidad.IsPrimaryKey = false;
				colvarValorUnidad.IsForeignKey = false;
				colvarValorUnidad.IsReadOnly = false;
				
						colvarValorUnidad.DefaultSetting = @"((0))";
				colvarValorUnidad.ForeignKeyTableName = "";
				schema.Columns.Add(colvarValorUnidad);
				
				TableSchema.TableColumn colvarValorTotal = new TableSchema.TableColumn(schema);
				colvarValorTotal.ColumnName = "valorTotal";
				colvarValorTotal.DataType = DbType.Decimal;
				colvarValorTotal.MaxLength = 0;
				colvarValorTotal.AutoIncrement = false;
				colvarValorTotal.IsNullable = false;
				colvarValorTotal.IsPrimaryKey = false;
				colvarValorTotal.IsForeignKey = false;
				colvarValorTotal.IsReadOnly = false;
				
						colvarValorTotal.DefaultSetting = @"((0))";
				colvarValorTotal.ForeignKeyTableName = "";
				schema.Columns.Add(colvarValorTotal);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["RisProvider"].AddSchema("FAC_FacturaDetalle",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("IdFacturaDetalle")]
		[Bindable(true)]
		public int IdFacturaDetalle 
		{
			get { return GetColumnValue<int>(Columns.IdFacturaDetalle); }
			set { SetColumnValue(Columns.IdFacturaDetalle, value); }
		}
		  
		[XmlAttribute("IdFactura")]
		[Bindable(true)]
		public int IdFactura 
		{
			get { return GetColumnValue<int>(Columns.IdFactura); }
			set { SetColumnValue(Columns.IdFactura, value); }
		}
		  
		[XmlAttribute("Cantidad")]
		[Bindable(true)]
		public int Cantidad 
		{
			get { return GetColumnValue<int>(Columns.Cantidad); }
			set { SetColumnValue(Columns.Cantidad, value); }
		}
		  
		[XmlAttribute("Descripcion")]
		[Bindable(true)]
		public string Descripcion 
		{
			get { return GetColumnValue<string>(Columns.Descripcion); }
			set { SetColumnValue(Columns.Descripcion, value); }
		}
		  
		[XmlAttribute("ValorUnidad")]
		[Bindable(true)]
		public decimal ValorUnidad 
		{
			get { return GetColumnValue<decimal>(Columns.ValorUnidad); }
			set { SetColumnValue(Columns.ValorUnidad, value); }
		}
		  
		[XmlAttribute("ValorTotal")]
		[Bindable(true)]
		public decimal ValorTotal 
		{
			get { return GetColumnValue<decimal>(Columns.ValorTotal); }
			set { SetColumnValue(Columns.ValorTotal, value); }
		}
		
		#endregion
		
		
			
		
		#region ForeignKey Properties
		
		/// <summary>
		/// Returns a FacFactura ActiveRecord object related to this FacFacturaDetalle
		/// 
		/// </summary>
		public DalRis.FacFactura FacFactura
		{
			get { return DalRis.FacFactura.FetchByID(this.IdFactura); }
			set { SetColumnValue("idFactura", value.IdFactura); }
		}
		
		
		#endregion
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(int varIdFactura,int varCantidad,string varDescripcion,decimal varValorUnidad,decimal varValorTotal)
		{
			FacFacturaDetalle item = new FacFacturaDetalle();
			
			item.IdFactura = varIdFactura;
			
			item.Cantidad = varCantidad;
			
			item.Descripcion = varDescripcion;
			
			item.ValorUnidad = varValorUnidad;
			
			item.ValorTotal = varValorTotal;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varIdFacturaDetalle,int varIdFactura,int varCantidad,string varDescripcion,decimal varValorUnidad,decimal varValorTotal)
		{
			FacFacturaDetalle item = new FacFacturaDetalle();
			
				item.IdFacturaDetalle = varIdFacturaDetalle;
			
				item.IdFactura = varIdFactura;
			
				item.Cantidad = varCantidad;
			
				item.Descripcion = varDescripcion;
			
				item.ValorUnidad = varValorUnidad;
			
				item.ValorTotal = varValorTotal;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn IdFacturaDetalleColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn IdFacturaColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn CantidadColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn DescripcionColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn ValorUnidadColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn ValorTotalColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string IdFacturaDetalle = @"idFacturaDetalle";
			 public static string IdFactura = @"idFactura";
			 public static string Cantidad = @"cantidad";
			 public static string Descripcion = @"descripcion";
			 public static string ValorUnidad = @"valorUnidad";
			 public static string ValorTotal = @"valorTotal";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
