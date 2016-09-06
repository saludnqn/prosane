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
	/// Strongly-typed collection for the BdsHematologium class.
	/// </summary>
    [Serializable]
	public partial class BdsHematologiumCollection : ActiveList<BdsHematologium, BdsHematologiumCollection>
	{	   
		public BdsHematologiumCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>BdsHematologiumCollection</returns>
		public BdsHematologiumCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                BdsHematologium o = this[i];
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
	/// This is an ActiveRecord class which wraps the BDS_Hematologia table.
	/// </summary>
	[Serializable]
	public partial class BdsHematologium : ActiveRecord<BdsHematologium>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public BdsHematologium()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public BdsHematologium(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public BdsHematologium(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public BdsHematologium(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("BDS_Hematologia", TableType.Table, DataService.GetInstance("RisProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarIdHematologia = new TableSchema.TableColumn(schema);
				colvarIdHematologia.ColumnName = "idHematologia";
				colvarIdHematologia.DataType = DbType.Int32;
				colvarIdHematologia.MaxLength = 0;
				colvarIdHematologia.AutoIncrement = true;
				colvarIdHematologia.IsNullable = false;
				colvarIdHematologia.IsPrimaryKey = true;
				colvarIdHematologia.IsForeignKey = false;
				colvarIdHematologia.IsReadOnly = false;
				colvarIdHematologia.DefaultSetting = @"";
				colvarIdHematologia.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdHematologia);
				
				TableSchema.TableColumn colvarIdAdmision = new TableSchema.TableColumn(schema);
				colvarIdAdmision.ColumnName = "idAdmision";
				colvarIdAdmision.DataType = DbType.Int32;
				colvarIdAdmision.MaxLength = 0;
				colvarIdAdmision.AutoIncrement = false;
				colvarIdAdmision.IsNullable = false;
				colvarIdAdmision.IsPrimaryKey = false;
				colvarIdAdmision.IsForeignKey = false;
				colvarIdAdmision.IsReadOnly = false;
				colvarIdAdmision.DefaultSetting = @"";
				colvarIdAdmision.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdAdmision);
				
				TableSchema.TableColumn colvarGrupo = new TableSchema.TableColumn(schema);
				colvarGrupo.ColumnName = "grupo";
				colvarGrupo.DataType = DbType.AnsiString;
				colvarGrupo.MaxLength = 10;
				colvarGrupo.AutoIncrement = false;
				colvarGrupo.IsNullable = false;
				colvarGrupo.IsPrimaryKey = false;
				colvarGrupo.IsForeignKey = false;
				colvarGrupo.IsReadOnly = false;
				colvarGrupo.DefaultSetting = @"";
				colvarGrupo.ForeignKeyTableName = "";
				schema.Columns.Add(colvarGrupo);
				
				TableSchema.TableColumn colvarFactor = new TableSchema.TableColumn(schema);
				colvarFactor.ColumnName = "factor";
				colvarFactor.DataType = DbType.AnsiString;
				colvarFactor.MaxLength = 50;
				colvarFactor.AutoIncrement = false;
				colvarFactor.IsNullable = false;
				colvarFactor.IsPrimaryKey = false;
				colvarFactor.IsForeignKey = false;
				colvarFactor.IsReadOnly = false;
				colvarFactor.DefaultSetting = @"";
				colvarFactor.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFactor);
				
				TableSchema.TableColumn colvarPai = new TableSchema.TableColumn(schema);
				colvarPai.ColumnName = "PAI";
				colvarPai.DataType = DbType.AnsiString;
				colvarPai.MaxLength = 50;
				colvarPai.AutoIncrement = false;
				colvarPai.IsNullable = false;
				colvarPai.IsPrimaryKey = false;
				colvarPai.IsForeignKey = false;
				colvarPai.IsReadOnly = false;
				colvarPai.DefaultSetting = @"";
				colvarPai.ForeignKeyTableName = "";
				schema.Columns.Add(colvarPai);
				
				TableSchema.TableColumn colvarDDebil = new TableSchema.TableColumn(schema);
				colvarDDebil.ColumnName = "dDebil";
				colvarDDebil.DataType = DbType.AnsiString;
				colvarDDebil.MaxLength = 50;
				colvarDDebil.AutoIncrement = false;
				colvarDDebil.IsNullable = false;
				colvarDDebil.IsPrimaryKey = false;
				colvarDDebil.IsForeignKey = false;
				colvarDDebil.IsReadOnly = false;
				colvarDDebil.DefaultSetting = @"";
				colvarDDebil.ForeignKeyTableName = "";
				schema.Columns.Add(colvarDDebil);
				
				TableSchema.TableColumn colvarObservaciones = new TableSchema.TableColumn(schema);
				colvarObservaciones.ColumnName = "Observaciones";
				colvarObservaciones.DataType = DbType.String;
				colvarObservaciones.MaxLength = 500;
				colvarObservaciones.AutoIncrement = false;
				colvarObservaciones.IsNullable = false;
				colvarObservaciones.IsPrimaryKey = false;
				colvarObservaciones.IsForeignKey = false;
				colvarObservaciones.IsReadOnly = false;
				colvarObservaciones.DefaultSetting = @"";
				colvarObservaciones.ForeignKeyTableName = "";
				schema.Columns.Add(colvarObservaciones);
				
				TableSchema.TableColumn colvarIdUsuarioRegistro = new TableSchema.TableColumn(schema);
				colvarIdUsuarioRegistro.ColumnName = "idUsuarioRegistro";
				colvarIdUsuarioRegistro.DataType = DbType.Int32;
				colvarIdUsuarioRegistro.MaxLength = 0;
				colvarIdUsuarioRegistro.AutoIncrement = false;
				colvarIdUsuarioRegistro.IsNullable = true;
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
				colvarFechaRegistro.IsNullable = true;
				colvarFechaRegistro.IsPrimaryKey = false;
				colvarFechaRegistro.IsForeignKey = false;
				colvarFechaRegistro.IsReadOnly = false;
				colvarFechaRegistro.DefaultSetting = @"";
				colvarFechaRegistro.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFechaRegistro);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["RisProvider"].AddSchema("BDS_Hematologia",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("IdHematologia")]
		[Bindable(true)]
		public int IdHematologia 
		{
			get { return GetColumnValue<int>(Columns.IdHematologia); }
			set { SetColumnValue(Columns.IdHematologia, value); }
		}
		  
		[XmlAttribute("IdAdmision")]
		[Bindable(true)]
		public int IdAdmision 
		{
			get { return GetColumnValue<int>(Columns.IdAdmision); }
			set { SetColumnValue(Columns.IdAdmision, value); }
		}
		  
		[XmlAttribute("Grupo")]
		[Bindable(true)]
		public string Grupo 
		{
			get { return GetColumnValue<string>(Columns.Grupo); }
			set { SetColumnValue(Columns.Grupo, value); }
		}
		  
		[XmlAttribute("Factor")]
		[Bindable(true)]
		public string Factor 
		{
			get { return GetColumnValue<string>(Columns.Factor); }
			set { SetColumnValue(Columns.Factor, value); }
		}
		  
		[XmlAttribute("Pai")]
		[Bindable(true)]
		public string Pai 
		{
			get { return GetColumnValue<string>(Columns.Pai); }
			set { SetColumnValue(Columns.Pai, value); }
		}
		  
		[XmlAttribute("DDebil")]
		[Bindable(true)]
		public string DDebil 
		{
			get { return GetColumnValue<string>(Columns.DDebil); }
			set { SetColumnValue(Columns.DDebil, value); }
		}
		  
		[XmlAttribute("Observaciones")]
		[Bindable(true)]
		public string Observaciones 
		{
			get { return GetColumnValue<string>(Columns.Observaciones); }
			set { SetColumnValue(Columns.Observaciones, value); }
		}
		  
		[XmlAttribute("IdUsuarioRegistro")]
		[Bindable(true)]
		public int? IdUsuarioRegistro 
		{
			get { return GetColumnValue<int?>(Columns.IdUsuarioRegistro); }
			set { SetColumnValue(Columns.IdUsuarioRegistro, value); }
		}
		  
		[XmlAttribute("FechaRegistro")]
		[Bindable(true)]
		public DateTime? FechaRegistro 
		{
			get { return GetColumnValue<DateTime?>(Columns.FechaRegistro); }
			set { SetColumnValue(Columns.FechaRegistro, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(int varIdAdmision,string varGrupo,string varFactor,string varPai,string varDDebil,string varObservaciones,int? varIdUsuarioRegistro,DateTime? varFechaRegistro)
		{
			BdsHematologium item = new BdsHematologium();
			
			item.IdAdmision = varIdAdmision;
			
			item.Grupo = varGrupo;
			
			item.Factor = varFactor;
			
			item.Pai = varPai;
			
			item.DDebil = varDDebil;
			
			item.Observaciones = varObservaciones;
			
			item.IdUsuarioRegistro = varIdUsuarioRegistro;
			
			item.FechaRegistro = varFechaRegistro;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varIdHematologia,int varIdAdmision,string varGrupo,string varFactor,string varPai,string varDDebil,string varObservaciones,int? varIdUsuarioRegistro,DateTime? varFechaRegistro)
		{
			BdsHematologium item = new BdsHematologium();
			
				item.IdHematologia = varIdHematologia;
			
				item.IdAdmision = varIdAdmision;
			
				item.Grupo = varGrupo;
			
				item.Factor = varFactor;
			
				item.Pai = varPai;
			
				item.DDebil = varDDebil;
			
				item.Observaciones = varObservaciones;
			
				item.IdUsuarioRegistro = varIdUsuarioRegistro;
			
				item.FechaRegistro = varFechaRegistro;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn IdHematologiaColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn IdAdmisionColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn GrupoColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn FactorColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn PaiColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn DDebilColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        public static TableSchema.TableColumn ObservacionesColumn
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        public static TableSchema.TableColumn IdUsuarioRegistroColumn
        {
            get { return Schema.Columns[7]; }
        }
        
        
        
        public static TableSchema.TableColumn FechaRegistroColumn
        {
            get { return Schema.Columns[8]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string IdHematologia = @"idHematologia";
			 public static string IdAdmision = @"idAdmision";
			 public static string Grupo = @"grupo";
			 public static string Factor = @"factor";
			 public static string Pai = @"PAI";
			 public static string DDebil = @"dDebil";
			 public static string Observaciones = @"Observaciones";
			 public static string IdUsuarioRegistro = @"idUsuarioRegistro";
			 public static string FechaRegistro = @"fechaRegistro";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
