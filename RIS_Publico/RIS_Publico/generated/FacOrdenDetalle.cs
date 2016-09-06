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
	/// Strongly-typed collection for the FacOrdenDetalle class.
	/// </summary>
    [Serializable]
	public partial class FacOrdenDetalleCollection : ActiveList<FacOrdenDetalle, FacOrdenDetalleCollection>
	{	   
		public FacOrdenDetalleCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>FacOrdenDetalleCollection</returns>
		public FacOrdenDetalleCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                FacOrdenDetalle o = this[i];
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
	/// This is an ActiveRecord class which wraps the FAC_OrdenDetalle table.
	/// </summary>
	[Serializable]
	public partial class FacOrdenDetalle : ActiveRecord<FacOrdenDetalle>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public FacOrdenDetalle()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public FacOrdenDetalle(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public FacOrdenDetalle(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public FacOrdenDetalle(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("FAC_OrdenDetalle", TableType.Table, DataService.GetInstance("RisProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarIdOrdenDetalle = new TableSchema.TableColumn(schema);
				colvarIdOrdenDetalle.ColumnName = "idOrdenDetalle";
				colvarIdOrdenDetalle.DataType = DbType.Int32;
				colvarIdOrdenDetalle.MaxLength = 0;
				colvarIdOrdenDetalle.AutoIncrement = true;
				colvarIdOrdenDetalle.IsNullable = false;
				colvarIdOrdenDetalle.IsPrimaryKey = true;
				colvarIdOrdenDetalle.IsForeignKey = true;
				colvarIdOrdenDetalle.IsReadOnly = false;
				colvarIdOrdenDetalle.DefaultSetting = @"";
				
					colvarIdOrdenDetalle.ForeignKeyTableName = "FAC_OrdenDetalle";
				schema.Columns.Add(colvarIdOrdenDetalle);
				
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
				
				TableSchema.TableColumn colvarIdEfector = new TableSchema.TableColumn(schema);
				colvarIdEfector.ColumnName = "idEfector";
				colvarIdEfector.DataType = DbType.Int32;
				colvarIdEfector.MaxLength = 0;
				colvarIdEfector.AutoIncrement = false;
				colvarIdEfector.IsNullable = false;
				colvarIdEfector.IsPrimaryKey = false;
				colvarIdEfector.IsForeignKey = false;
				colvarIdEfector.IsReadOnly = false;
				colvarIdEfector.DefaultSetting = @"";
				colvarIdEfector.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdEfector);
				
				TableSchema.TableColumn colvarIdNomenclador = new TableSchema.TableColumn(schema);
				colvarIdNomenclador.ColumnName = "idNomenclador";
				colvarIdNomenclador.DataType = DbType.Int32;
				colvarIdNomenclador.MaxLength = 0;
				colvarIdNomenclador.AutoIncrement = false;
				colvarIdNomenclador.IsNullable = false;
				colvarIdNomenclador.IsPrimaryKey = false;
				colvarIdNomenclador.IsForeignKey = true;
				colvarIdNomenclador.IsReadOnly = false;
				
						colvarIdNomenclador.DefaultSetting = @"((0))";
				
					colvarIdNomenclador.ForeignKeyTableName = "FAC_Nomenclador";
				schema.Columns.Add(colvarIdNomenclador);
				
				TableSchema.TableColumn colvarDescripcion = new TableSchema.TableColumn(schema);
				colvarDescripcion.ColumnName = "descripcion";
				colvarDescripcion.DataType = DbType.AnsiString;
				colvarDescripcion.MaxLength = 500;
				colvarDescripcion.AutoIncrement = false;
				colvarDescripcion.IsNullable = false;
				colvarDescripcion.IsPrimaryKey = false;
				colvarDescripcion.IsForeignKey = false;
				colvarDescripcion.IsReadOnly = false;
				
						colvarDescripcion.DefaultSetting = @"('')";
				colvarDescripcion.ForeignKeyTableName = "";
				schema.Columns.Add(colvarDescripcion);
				
				TableSchema.TableColumn colvarCantidad = new TableSchema.TableColumn(schema);
				colvarCantidad.ColumnName = "cantidad";
				colvarCantidad.DataType = DbType.Int32;
				colvarCantidad.MaxLength = 0;
				colvarCantidad.AutoIncrement = false;
				colvarCantidad.IsNullable = false;
				colvarCantidad.IsPrimaryKey = false;
				colvarCantidad.IsForeignKey = false;
				colvarCantidad.IsReadOnly = false;
				
						colvarCantidad.DefaultSetting = @"((1))";
				colvarCantidad.ForeignKeyTableName = "";
				schema.Columns.Add(colvarCantidad);
				
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
				
				TableSchema.TableColumn colvarAjuste = new TableSchema.TableColumn(schema);
				colvarAjuste.ColumnName = "ajuste";
				colvarAjuste.DataType = DbType.Decimal;
				colvarAjuste.MaxLength = 0;
				colvarAjuste.AutoIncrement = false;
				colvarAjuste.IsNullable = false;
				colvarAjuste.IsPrimaryKey = false;
				colvarAjuste.IsForeignKey = false;
				colvarAjuste.IsReadOnly = false;
				
						colvarAjuste.DefaultSetting = @"((0))";
				colvarAjuste.ForeignKeyTableName = "";
				schema.Columns.Add(colvarAjuste);
				
				TableSchema.TableColumn colvarTotal = new TableSchema.TableColumn(schema);
				colvarTotal.ColumnName = "total";
				colvarTotal.DataType = DbType.Decimal;
				colvarTotal.MaxLength = 0;
				colvarTotal.AutoIncrement = false;
				colvarTotal.IsNullable = true;
				colvarTotal.IsPrimaryKey = false;
				colvarTotal.IsForeignKey = false;
				colvarTotal.IsReadOnly = true;
				colvarTotal.DefaultSetting = @"";
				colvarTotal.ForeignKeyTableName = "";
				schema.Columns.Add(colvarTotal);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["RisProvider"].AddSchema("FAC_OrdenDetalle",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("IdOrdenDetalle")]
		[Bindable(true)]
		public int IdOrdenDetalle 
		{
			get { return GetColumnValue<int>(Columns.IdOrdenDetalle); }
			set { SetColumnValue(Columns.IdOrdenDetalle, value); }
		}
		  
		[XmlAttribute("IdOrden")]
		[Bindable(true)]
		public int IdOrden 
		{
			get { return GetColumnValue<int>(Columns.IdOrden); }
			set { SetColumnValue(Columns.IdOrden, value); }
		}
		  
		[XmlAttribute("IdEfector")]
		[Bindable(true)]
		public int IdEfector 
		{
			get { return GetColumnValue<int>(Columns.IdEfector); }
			set { SetColumnValue(Columns.IdEfector, value); }
		}
		  
		[XmlAttribute("IdNomenclador")]
		[Bindable(true)]
		public int IdNomenclador 
		{
			get { return GetColumnValue<int>(Columns.IdNomenclador); }
			set { SetColumnValue(Columns.IdNomenclador, value); }
		}
		  
		[XmlAttribute("Descripcion")]
		[Bindable(true)]
		public string Descripcion 
		{
			get { return GetColumnValue<string>(Columns.Descripcion); }
			set { SetColumnValue(Columns.Descripcion, value); }
		}
		  
		[XmlAttribute("Cantidad")]
		[Bindable(true)]
		public int Cantidad 
		{
			get { return GetColumnValue<int>(Columns.Cantidad); }
			set { SetColumnValue(Columns.Cantidad, value); }
		}
		  
		[XmlAttribute("ValorUnidad")]
		[Bindable(true)]
		public decimal ValorUnidad 
		{
			get { return GetColumnValue<decimal>(Columns.ValorUnidad); }
			set { SetColumnValue(Columns.ValorUnidad, value); }
		}
		  
		[XmlAttribute("Ajuste")]
		[Bindable(true)]
		public decimal Ajuste 
		{
			get { return GetColumnValue<decimal>(Columns.Ajuste); }
			set { SetColumnValue(Columns.Ajuste, value); }
		}
		  
		[XmlAttribute("Total")]
		[Bindable(true)]
		public decimal? Total 
		{
			get { return GetColumnValue<decimal?>(Columns.Total); }
			set { SetColumnValue(Columns.Total, value); }
		}
		
		#endregion
		
		
		#region PrimaryKey Methods		
		
        protected override void SetPrimaryKey(object oValue)
        {
            base.SetPrimaryKey(oValue);
            
            SetPKValues();
        }
        
		
		private DalRis.FacOrdenDetalleCollection colChildFacOrdenDetalleRecords;
		public DalRis.FacOrdenDetalleCollection ChildFacOrdenDetalleRecords()
		{
			if(colChildFacOrdenDetalleRecords == null)
			{
				colChildFacOrdenDetalleRecords = new DalRis.FacOrdenDetalleCollection().Where(FacOrdenDetalle.Columns.IdOrdenDetalle, IdOrdenDetalle).Load();
				colChildFacOrdenDetalleRecords.ListChanged += new ListChangedEventHandler(colChildFacOrdenDetalleRecords_ListChanged);
			}
			return colChildFacOrdenDetalleRecords;
		}
				
		void colChildFacOrdenDetalleRecords_ListChanged(object sender, ListChangedEventArgs e)
		{
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
		        // Set foreign key value
		        colChildFacOrdenDetalleRecords[e.NewIndex].IdOrdenDetalle = IdOrdenDetalle;
				colChildFacOrdenDetalleRecords.ListChanged += new ListChangedEventHandler(colChildFacOrdenDetalleRecords_ListChanged);
            }
		}
		#endregion
		
			
		
		#region ForeignKey Properties
		
		/// <summary>
		/// Returns a FacNomenclador ActiveRecord object related to this FacOrdenDetalle
		/// 
		/// </summary>
		public DalRis.FacNomenclador FacNomenclador
		{
			get { return DalRis.FacNomenclador.FetchByID(this.IdNomenclador); }
			set { SetColumnValue("idNomenclador", value.IdNomenclador); }
		}
		
		
		/// <summary>
		/// Returns a FacOrden ActiveRecord object related to this FacOrdenDetalle
		/// 
		/// </summary>
		public DalRis.FacOrden FacOrden
		{
			get { return DalRis.FacOrden.FetchByID(this.IdOrden); }
			set { SetColumnValue("idOrden", value.IdOrden); }
		}
		
		
		/// <summary>
		/// Returns a FacOrdenDetalle ActiveRecord object related to this FacOrdenDetalle
		/// 
		/// </summary>
		public DalRis.FacOrdenDetalle ParentFacOrdenDetalle
		{
			get { return DalRis.FacOrdenDetalle.FetchByID(this.IdOrdenDetalle); }
			set { SetColumnValue("idOrdenDetalle", value.IdOrdenDetalle); }
		}
		
		
		#endregion
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(int varIdOrden,int varIdEfector,int varIdNomenclador,string varDescripcion,int varCantidad,decimal varValorUnidad,decimal varAjuste,decimal? varTotal)
		{
			FacOrdenDetalle item = new FacOrdenDetalle();
			
			item.IdOrden = varIdOrden;
			
			item.IdEfector = varIdEfector;
			
			item.IdNomenclador = varIdNomenclador;
			
			item.Descripcion = varDescripcion;
			
			item.Cantidad = varCantidad;
			
			item.ValorUnidad = varValorUnidad;
			
			item.Ajuste = varAjuste;
			
			item.Total = varTotal;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varIdOrdenDetalle,int varIdOrden,int varIdEfector,int varIdNomenclador,string varDescripcion,int varCantidad,decimal varValorUnidad,decimal varAjuste,decimal? varTotal)
		{
			FacOrdenDetalle item = new FacOrdenDetalle();
			
				item.IdOrdenDetalle = varIdOrdenDetalle;
			
				item.IdOrden = varIdOrden;
			
				item.IdEfector = varIdEfector;
			
				item.IdNomenclador = varIdNomenclador;
			
				item.Descripcion = varDescripcion;
			
				item.Cantidad = varCantidad;
			
				item.ValorUnidad = varValorUnidad;
			
				item.Ajuste = varAjuste;
			
				item.Total = varTotal;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn IdOrdenDetalleColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn IdOrdenColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn IdEfectorColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn IdNomencladorColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn DescripcionColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn CantidadColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        public static TableSchema.TableColumn ValorUnidadColumn
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        public static TableSchema.TableColumn AjusteColumn
        {
            get { return Schema.Columns[7]; }
        }
        
        
        
        public static TableSchema.TableColumn TotalColumn
        {
            get { return Schema.Columns[8]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string IdOrdenDetalle = @"idOrdenDetalle";
			 public static string IdOrden = @"idOrden";
			 public static string IdEfector = @"idEfector";
			 public static string IdNomenclador = @"idNomenclador";
			 public static string Descripcion = @"descripcion";
			 public static string Cantidad = @"cantidad";
			 public static string ValorUnidad = @"valorUnidad";
			 public static string Ajuste = @"ajuste";
			 public static string Total = @"total";
						
		}
		#endregion
		
		#region Update PK Collections
		
        public void SetPKValues()
        {
                if (colChildFacOrdenDetalleRecords != null)
                {
                    foreach (DalRis.FacOrdenDetalle item in colChildFacOrdenDetalleRecords)
                    {
                        if (item.IdOrdenDetalle != IdOrdenDetalle)
                        {
                            item.IdOrdenDetalle = IdOrdenDetalle;
                        }
                    }
               }
		}
        #endregion
    
        #region Deep Save
		
        public void DeepSave()
        {
            Save();
            
                if (colChildFacOrdenDetalleRecords != null)
                {
                    colChildFacOrdenDetalleRecords.SaveAll();
               }
		}
        #endregion
	}
}
