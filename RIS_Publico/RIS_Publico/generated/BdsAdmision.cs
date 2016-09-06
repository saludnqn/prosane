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
	/// Strongly-typed collection for the BdsAdmision class.
	/// </summary>
    [Serializable]
	public partial class BdsAdmisionCollection : ActiveList<BdsAdmision, BdsAdmisionCollection>
	{	   
		public BdsAdmisionCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>BdsAdmisionCollection</returns>
		public BdsAdmisionCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                BdsAdmision o = this[i];
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
	/// This is an ActiveRecord class which wraps the BDS_Admision table.
	/// </summary>
	[Serializable]
	public partial class BdsAdmision : ActiveRecord<BdsAdmision>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public BdsAdmision()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public BdsAdmision(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public BdsAdmision(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public BdsAdmision(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("BDS_Admision", TableType.Table, DataService.GetInstance("RisProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarIdAdmision = new TableSchema.TableColumn(schema);
				colvarIdAdmision.ColumnName = "idAdmision";
				colvarIdAdmision.DataType = DbType.Int32;
				colvarIdAdmision.MaxLength = 0;
				colvarIdAdmision.AutoIncrement = true;
				colvarIdAdmision.IsNullable = false;
				colvarIdAdmision.IsPrimaryKey = true;
				colvarIdAdmision.IsForeignKey = false;
				colvarIdAdmision.IsReadOnly = false;
				colvarIdAdmision.DefaultSetting = @"";
				colvarIdAdmision.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdAdmision);
				
				TableSchema.TableColumn colvarFecha = new TableSchema.TableColumn(schema);
				colvarFecha.ColumnName = "fecha";
				colvarFecha.DataType = DbType.DateTime;
				colvarFecha.MaxLength = 0;
				colvarFecha.AutoIncrement = false;
				colvarFecha.IsNullable = false;
				colvarFecha.IsPrimaryKey = false;
				colvarFecha.IsForeignKey = false;
				colvarFecha.IsReadOnly = false;
				colvarFecha.DefaultSetting = @"";
				colvarFecha.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFecha);
				
				TableSchema.TableColumn colvarHoraAdmision = new TableSchema.TableColumn(schema);
				colvarHoraAdmision.ColumnName = "horaAdmision";
				colvarHoraAdmision.DataType = DbType.String;
				colvarHoraAdmision.MaxLength = 5;
				colvarHoraAdmision.AutoIncrement = false;
				colvarHoraAdmision.IsNullable = false;
				colvarHoraAdmision.IsPrimaryKey = false;
				colvarHoraAdmision.IsForeignKey = false;
				colvarHoraAdmision.IsReadOnly = false;
				colvarHoraAdmision.DefaultSetting = @"";
				colvarHoraAdmision.ForeignKeyTableName = "";
				schema.Columns.Add(colvarHoraAdmision);
				
				TableSchema.TableColumn colvarIdDonante = new TableSchema.TableColumn(schema);
				colvarIdDonante.ColumnName = "idDonante";
				colvarIdDonante.DataType = DbType.Int32;
				colvarIdDonante.MaxLength = 0;
				colvarIdDonante.AutoIncrement = false;
				colvarIdDonante.IsNullable = false;
				colvarIdDonante.IsPrimaryKey = false;
				colvarIdDonante.IsForeignKey = false;
				colvarIdDonante.IsReadOnly = false;
				colvarIdDonante.DefaultSetting = @"";
				colvarIdDonante.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdDonante);
				
				TableSchema.TableColumn colvarIdTipoDonante = new TableSchema.TableColumn(schema);
				colvarIdTipoDonante.ColumnName = "idTipoDonante";
				colvarIdTipoDonante.DataType = DbType.Int32;
				colvarIdTipoDonante.MaxLength = 0;
				colvarIdTipoDonante.AutoIncrement = false;
				colvarIdTipoDonante.IsNullable = false;
				colvarIdTipoDonante.IsPrimaryKey = false;
				colvarIdTipoDonante.IsForeignKey = false;
				colvarIdTipoDonante.IsReadOnly = false;
				colvarIdTipoDonante.DefaultSetting = @"";
				colvarIdTipoDonante.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdTipoDonante);
				
				TableSchema.TableColumn colvarIdEfectorExtraccion = new TableSchema.TableColumn(schema);
				colvarIdEfectorExtraccion.ColumnName = "idEfectorExtraccion";
				colvarIdEfectorExtraccion.DataType = DbType.Int32;
				colvarIdEfectorExtraccion.MaxLength = 0;
				colvarIdEfectorExtraccion.AutoIncrement = false;
				colvarIdEfectorExtraccion.IsNullable = false;
				colvarIdEfectorExtraccion.IsPrimaryKey = false;
				colvarIdEfectorExtraccion.IsForeignKey = false;
				colvarIdEfectorExtraccion.IsReadOnly = false;
				colvarIdEfectorExtraccion.DefaultSetting = @"";
				colvarIdEfectorExtraccion.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdEfectorExtraccion);
				
				TableSchema.TableColumn colvarNumeroDeBolsa = new TableSchema.TableColumn(schema);
				colvarNumeroDeBolsa.ColumnName = "numeroDeBolsa";
				colvarNumeroDeBolsa.DataType = DbType.String;
				colvarNumeroDeBolsa.MaxLength = 50;
				colvarNumeroDeBolsa.AutoIncrement = false;
				colvarNumeroDeBolsa.IsNullable = false;
				colvarNumeroDeBolsa.IsPrimaryKey = false;
				colvarNumeroDeBolsa.IsForeignKey = false;
				colvarNumeroDeBolsa.IsReadOnly = false;
				colvarNumeroDeBolsa.DefaultSetting = @"";
				colvarNumeroDeBolsa.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNumeroDeBolsa);
				
				TableSchema.TableColumn colvarEfectorOrigenBolsa = new TableSchema.TableColumn(schema);
				colvarEfectorOrigenBolsa.ColumnName = "efectorOrigenBolsa";
				colvarEfectorOrigenBolsa.DataType = DbType.String;
				colvarEfectorOrigenBolsa.MaxLength = 50;
				colvarEfectorOrigenBolsa.AutoIncrement = false;
				colvarEfectorOrigenBolsa.IsNullable = false;
				colvarEfectorOrigenBolsa.IsPrimaryKey = false;
				colvarEfectorOrigenBolsa.IsForeignKey = false;
				colvarEfectorOrigenBolsa.IsReadOnly = false;
				colvarEfectorOrigenBolsa.DefaultSetting = @"";
				colvarEfectorOrigenBolsa.ForeignKeyTableName = "";
				schema.Columns.Add(colvarEfectorOrigenBolsa);
				
				TableSchema.TableColumn colvarFechaExtraccionBolsa = new TableSchema.TableColumn(schema);
				colvarFechaExtraccionBolsa.ColumnName = "fechaExtraccionBolsa";
				colvarFechaExtraccionBolsa.DataType = DbType.DateTime;
				colvarFechaExtraccionBolsa.MaxLength = 0;
				colvarFechaExtraccionBolsa.AutoIncrement = false;
				colvarFechaExtraccionBolsa.IsNullable = false;
				colvarFechaExtraccionBolsa.IsPrimaryKey = false;
				colvarFechaExtraccionBolsa.IsForeignKey = false;
				colvarFechaExtraccionBolsa.IsReadOnly = false;
				colvarFechaExtraccionBolsa.DefaultSetting = @"";
				colvarFechaExtraccionBolsa.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFechaExtraccionBolsa);
				
				TableSchema.TableColumn colvarFechaVencimientoBolsa = new TableSchema.TableColumn(schema);
				colvarFechaVencimientoBolsa.ColumnName = "fechaVencimientoBolsa";
				colvarFechaVencimientoBolsa.DataType = DbType.DateTime;
				colvarFechaVencimientoBolsa.MaxLength = 0;
				colvarFechaVencimientoBolsa.AutoIncrement = false;
				colvarFechaVencimientoBolsa.IsNullable = false;
				colvarFechaVencimientoBolsa.IsPrimaryKey = false;
				colvarFechaVencimientoBolsa.IsForeignKey = false;
				colvarFechaVencimientoBolsa.IsReadOnly = false;
				colvarFechaVencimientoBolsa.DefaultSetting = @"";
				colvarFechaVencimientoBolsa.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFechaVencimientoBolsa);
				
				TableSchema.TableColumn colvarGrupoBolsa = new TableSchema.TableColumn(schema);
				colvarGrupoBolsa.ColumnName = "grupoBolsa";
				colvarGrupoBolsa.DataType = DbType.String;
				colvarGrupoBolsa.MaxLength = 20;
				colvarGrupoBolsa.AutoIncrement = false;
				colvarGrupoBolsa.IsNullable = false;
				colvarGrupoBolsa.IsPrimaryKey = false;
				colvarGrupoBolsa.IsForeignKey = false;
				colvarGrupoBolsa.IsReadOnly = false;
				colvarGrupoBolsa.DefaultSetting = @"";
				colvarGrupoBolsa.ForeignKeyTableName = "";
				schema.Columns.Add(colvarGrupoBolsa);
				
				TableSchema.TableColumn colvarFactorBolsa = new TableSchema.TableColumn(schema);
				colvarFactorBolsa.ColumnName = "factorBolsa";
				colvarFactorBolsa.DataType = DbType.String;
				colvarFactorBolsa.MaxLength = 20;
				colvarFactorBolsa.AutoIncrement = false;
				colvarFactorBolsa.IsNullable = false;
				colvarFactorBolsa.IsPrimaryKey = false;
				colvarFactorBolsa.IsForeignKey = false;
				colvarFactorBolsa.IsReadOnly = false;
				colvarFactorBolsa.DefaultSetting = @"";
				colvarFactorBolsa.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFactorBolsa);
				
				TableSchema.TableColumn colvarSerologiaBolsa = new TableSchema.TableColumn(schema);
				colvarSerologiaBolsa.ColumnName = "serologiaBolsa";
				colvarSerologiaBolsa.DataType = DbType.Boolean;
				colvarSerologiaBolsa.MaxLength = 0;
				colvarSerologiaBolsa.AutoIncrement = false;
				colvarSerologiaBolsa.IsNullable = false;
				colvarSerologiaBolsa.IsPrimaryKey = false;
				colvarSerologiaBolsa.IsForeignKey = false;
				colvarSerologiaBolsa.IsReadOnly = false;
				colvarSerologiaBolsa.DefaultSetting = @"";
				colvarSerologiaBolsa.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSerologiaBolsa);
				
				TableSchema.TableColumn colvarReceptor = new TableSchema.TableColumn(schema);
				colvarReceptor.ColumnName = "receptor";
				colvarReceptor.DataType = DbType.String;
				colvarReceptor.MaxLength = 100;
				colvarReceptor.AutoIncrement = false;
				colvarReceptor.IsNullable = false;
				colvarReceptor.IsPrimaryKey = false;
				colvarReceptor.IsForeignKey = false;
				colvarReceptor.IsReadOnly = false;
				colvarReceptor.DefaultSetting = @"";
				colvarReceptor.ForeignKeyTableName = "";
				schema.Columns.Add(colvarReceptor);
				
				TableSchema.TableColumn colvarObservacionesAdmision = new TableSchema.TableColumn(schema);
				colvarObservacionesAdmision.ColumnName = "observacionesAdmision";
				colvarObservacionesAdmision.DataType = DbType.String;
				colvarObservacionesAdmision.MaxLength = 500;
				colvarObservacionesAdmision.AutoIncrement = false;
				colvarObservacionesAdmision.IsNullable = false;
				colvarObservacionesAdmision.IsPrimaryKey = false;
				colvarObservacionesAdmision.IsForeignKey = false;
				colvarObservacionesAdmision.IsReadOnly = false;
				colvarObservacionesAdmision.DefaultSetting = @"";
				colvarObservacionesAdmision.ForeignKeyTableName = "";
				schema.Columns.Add(colvarObservacionesAdmision);
				
				TableSchema.TableColumn colvarResponsableEntrevista = new TableSchema.TableColumn(schema);
				colvarResponsableEntrevista.ColumnName = "responsableEntrevista";
				colvarResponsableEntrevista.DataType = DbType.String;
				colvarResponsableEntrevista.MaxLength = 100;
				colvarResponsableEntrevista.AutoIncrement = false;
				colvarResponsableEntrevista.IsNullable = false;
				colvarResponsableEntrevista.IsPrimaryKey = false;
				colvarResponsableEntrevista.IsForeignKey = false;
				colvarResponsableEntrevista.IsReadOnly = false;
				colvarResponsableEntrevista.DefaultSetting = @"";
				colvarResponsableEntrevista.ForeignKeyTableName = "";
				schema.Columns.Add(colvarResponsableEntrevista);
				
				TableSchema.TableColumn colvarEstadoEntrevista = new TableSchema.TableColumn(schema);
				colvarEstadoEntrevista.ColumnName = "estadoEntrevista";
				colvarEstadoEntrevista.DataType = DbType.String;
				colvarEstadoEntrevista.MaxLength = 10;
				colvarEstadoEntrevista.AutoIncrement = false;
				colvarEstadoEntrevista.IsNullable = false;
				colvarEstadoEntrevista.IsPrimaryKey = false;
				colvarEstadoEntrevista.IsForeignKey = false;
				colvarEstadoEntrevista.IsReadOnly = false;
				colvarEstadoEntrevista.DefaultSetting = @"";
				colvarEstadoEntrevista.ForeignKeyTableName = "";
				schema.Columns.Add(colvarEstadoEntrevista);
				
				TableSchema.TableColumn colvarIdTipoExclusion = new TableSchema.TableColumn(schema);
				colvarIdTipoExclusion.ColumnName = "idTipoExclusion";
				colvarIdTipoExclusion.DataType = DbType.Int32;
				colvarIdTipoExclusion.MaxLength = 0;
				colvarIdTipoExclusion.AutoIncrement = false;
				colvarIdTipoExclusion.IsNullable = false;
				colvarIdTipoExclusion.IsPrimaryKey = false;
				colvarIdTipoExclusion.IsForeignKey = false;
				colvarIdTipoExclusion.IsReadOnly = false;
				colvarIdTipoExclusion.DefaultSetting = @"";
				colvarIdTipoExclusion.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdTipoExclusion);
				
				TableSchema.TableColumn colvarFechaFinExclusion = new TableSchema.TableColumn(schema);
				colvarFechaFinExclusion.ColumnName = "fechaFinExclusion";
				colvarFechaFinExclusion.DataType = DbType.DateTime;
				colvarFechaFinExclusion.MaxLength = 0;
				colvarFechaFinExclusion.AutoIncrement = false;
				colvarFechaFinExclusion.IsNullable = false;
				colvarFechaFinExclusion.IsPrimaryKey = false;
				colvarFechaFinExclusion.IsForeignKey = false;
				colvarFechaFinExclusion.IsReadOnly = false;
				colvarFechaFinExclusion.DefaultSetting = @"";
				colvarFechaFinExclusion.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFechaFinExclusion);
				
				TableSchema.TableColumn colvarObservacionesExclusion = new TableSchema.TableColumn(schema);
				colvarObservacionesExclusion.ColumnName = "observacionesExclusion";
				colvarObservacionesExclusion.DataType = DbType.String;
				colvarObservacionesExclusion.MaxLength = 500;
				colvarObservacionesExclusion.AutoIncrement = false;
				colvarObservacionesExclusion.IsNullable = false;
				colvarObservacionesExclusion.IsPrimaryKey = false;
				colvarObservacionesExclusion.IsForeignKey = false;
				colvarObservacionesExclusion.IsReadOnly = false;
				colvarObservacionesExclusion.DefaultSetting = @"";
				colvarObservacionesExclusion.ForeignKeyTableName = "";
				schema.Columns.Add(colvarObservacionesExclusion);
				
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
				
				TableSchema.TableColumn colvarIdEfectorSerologia = new TableSchema.TableColumn(schema);
				colvarIdEfectorSerologia.ColumnName = "idEfectorSerologia";
				colvarIdEfectorSerologia.DataType = DbType.Int32;
				colvarIdEfectorSerologia.MaxLength = 0;
				colvarIdEfectorSerologia.AutoIncrement = false;
				colvarIdEfectorSerologia.IsNullable = false;
				colvarIdEfectorSerologia.IsPrimaryKey = false;
				colvarIdEfectorSerologia.IsForeignKey = false;
				colvarIdEfectorSerologia.IsReadOnly = false;
				colvarIdEfectorSerologia.DefaultSetting = @"";
				colvarIdEfectorSerologia.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdEfectorSerologia);
				
				TableSchema.TableColumn colvarIdEfectorHematologia = new TableSchema.TableColumn(schema);
				colvarIdEfectorHematologia.ColumnName = "idEfectorHematologia";
				colvarIdEfectorHematologia.DataType = DbType.Int32;
				colvarIdEfectorHematologia.MaxLength = 0;
				colvarIdEfectorHematologia.AutoIncrement = false;
				colvarIdEfectorHematologia.IsNullable = false;
				colvarIdEfectorHematologia.IsPrimaryKey = false;
				colvarIdEfectorHematologia.IsForeignKey = false;
				colvarIdEfectorHematologia.IsReadOnly = false;
				colvarIdEfectorHematologia.DefaultSetting = @"";
				colvarIdEfectorHematologia.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdEfectorHematologia);
				
				TableSchema.TableColumn colvarIdIncidenciaExtraccion = new TableSchema.TableColumn(schema);
				colvarIdIncidenciaExtraccion.ColumnName = "idIncidenciaExtraccion";
				colvarIdIncidenciaExtraccion.DataType = DbType.Int32;
				colvarIdIncidenciaExtraccion.MaxLength = 0;
				colvarIdIncidenciaExtraccion.AutoIncrement = false;
				colvarIdIncidenciaExtraccion.IsNullable = false;
				colvarIdIncidenciaExtraccion.IsPrimaryKey = false;
				colvarIdIncidenciaExtraccion.IsForeignKey = false;
				colvarIdIncidenciaExtraccion.IsReadOnly = false;
				colvarIdIncidenciaExtraccion.DefaultSetting = @"";
				colvarIdIncidenciaExtraccion.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdIncidenciaExtraccion);
				
				TableSchema.TableColumn colvarDescartada = new TableSchema.TableColumn(schema);
				colvarDescartada.ColumnName = "descartada";
				colvarDescartada.DataType = DbType.Boolean;
				colvarDescartada.MaxLength = 0;
				colvarDescartada.AutoIncrement = false;
				colvarDescartada.IsNullable = false;
				colvarDescartada.IsPrimaryKey = false;
				colvarDescartada.IsForeignKey = false;
				colvarDescartada.IsReadOnly = false;
				colvarDescartada.DefaultSetting = @"";
				colvarDescartada.ForeignKeyTableName = "";
				schema.Columns.Add(colvarDescartada);
				
				TableSchema.TableColumn colvarFechaDescarte = new TableSchema.TableColumn(schema);
				colvarFechaDescarte.ColumnName = "fechaDescarte";
				colvarFechaDescarte.DataType = DbType.DateTime;
				colvarFechaDescarte.MaxLength = 0;
				colvarFechaDescarte.AutoIncrement = false;
				colvarFechaDescarte.IsNullable = false;
				colvarFechaDescarte.IsPrimaryKey = false;
				colvarFechaDescarte.IsForeignKey = false;
				colvarFechaDescarte.IsReadOnly = false;
				colvarFechaDescarte.DefaultSetting = @"";
				colvarFechaDescarte.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFechaDescarte);
				
				TableSchema.TableColumn colvarIdUsuarioDescarte = new TableSchema.TableColumn(schema);
				colvarIdUsuarioDescarte.ColumnName = "idUsuarioDescarte";
				colvarIdUsuarioDescarte.DataType = DbType.Int32;
				colvarIdUsuarioDescarte.MaxLength = 0;
				colvarIdUsuarioDescarte.AutoIncrement = false;
				colvarIdUsuarioDescarte.IsNullable = false;
				colvarIdUsuarioDescarte.IsPrimaryKey = false;
				colvarIdUsuarioDescarte.IsForeignKey = false;
				colvarIdUsuarioDescarte.IsReadOnly = false;
				colvarIdUsuarioDescarte.DefaultSetting = @"";
				colvarIdUsuarioDescarte.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdUsuarioDescarte);
				
				TableSchema.TableColumn colvarExtraccion = new TableSchema.TableColumn(schema);
				colvarExtraccion.ColumnName = "extraccion";
				colvarExtraccion.DataType = DbType.String;
				colvarExtraccion.MaxLength = 10;
				colvarExtraccion.AutoIncrement = false;
				colvarExtraccion.IsNullable = false;
				colvarExtraccion.IsPrimaryKey = false;
				colvarExtraccion.IsForeignKey = false;
				colvarExtraccion.IsReadOnly = false;
				colvarExtraccion.DefaultSetting = @"";
				colvarExtraccion.ForeignKeyTableName = "";
				schema.Columns.Add(colvarExtraccion);
				
				TableSchema.TableColumn colvarColecta = new TableSchema.TableColumn(schema);
				colvarColecta.ColumnName = "colecta";
				colvarColecta.DataType = DbType.String;
				colvarColecta.MaxLength = 10;
				colvarColecta.AutoIncrement = false;
				colvarColecta.IsNullable = true;
				colvarColecta.IsPrimaryKey = false;
				colvarColecta.IsForeignKey = false;
				colvarColecta.IsReadOnly = false;
				colvarColecta.DefaultSetting = @"";
				colvarColecta.ForeignKeyTableName = "";
				schema.Columns.Add(colvarColecta);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["RisProvider"].AddSchema("BDS_Admision",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("IdAdmision")]
		[Bindable(true)]
		public int IdAdmision 
		{
			get { return GetColumnValue<int>(Columns.IdAdmision); }
			set { SetColumnValue(Columns.IdAdmision, value); }
		}
		  
		[XmlAttribute("Fecha")]
		[Bindable(true)]
		public DateTime Fecha 
		{
			get { return GetColumnValue<DateTime>(Columns.Fecha); }
			set { SetColumnValue(Columns.Fecha, value); }
		}
		  
		[XmlAttribute("HoraAdmision")]
		[Bindable(true)]
		public string HoraAdmision 
		{
			get { return GetColumnValue<string>(Columns.HoraAdmision); }
			set { SetColumnValue(Columns.HoraAdmision, value); }
		}
		  
		[XmlAttribute("IdDonante")]
		[Bindable(true)]
		public int IdDonante 
		{
			get { return GetColumnValue<int>(Columns.IdDonante); }
			set { SetColumnValue(Columns.IdDonante, value); }
		}
		  
		[XmlAttribute("IdTipoDonante")]
		[Bindable(true)]
		public int IdTipoDonante 
		{
			get { return GetColumnValue<int>(Columns.IdTipoDonante); }
			set { SetColumnValue(Columns.IdTipoDonante, value); }
		}
		  
		[XmlAttribute("IdEfectorExtraccion")]
		[Bindable(true)]
		public int IdEfectorExtraccion 
		{
			get { return GetColumnValue<int>(Columns.IdEfectorExtraccion); }
			set { SetColumnValue(Columns.IdEfectorExtraccion, value); }
		}
		  
		[XmlAttribute("NumeroDeBolsa")]
		[Bindable(true)]
		public string NumeroDeBolsa 
		{
			get { return GetColumnValue<string>(Columns.NumeroDeBolsa); }
			set { SetColumnValue(Columns.NumeroDeBolsa, value); }
		}
		  
		[XmlAttribute("EfectorOrigenBolsa")]
		[Bindable(true)]
		public string EfectorOrigenBolsa 
		{
			get { return GetColumnValue<string>(Columns.EfectorOrigenBolsa); }
			set { SetColumnValue(Columns.EfectorOrigenBolsa, value); }
		}
		  
		[XmlAttribute("FechaExtraccionBolsa")]
		[Bindable(true)]
		public DateTime FechaExtraccionBolsa 
		{
			get { return GetColumnValue<DateTime>(Columns.FechaExtraccionBolsa); }
			set { SetColumnValue(Columns.FechaExtraccionBolsa, value); }
		}
		  
		[XmlAttribute("FechaVencimientoBolsa")]
		[Bindable(true)]
		public DateTime FechaVencimientoBolsa 
		{
			get { return GetColumnValue<DateTime>(Columns.FechaVencimientoBolsa); }
			set { SetColumnValue(Columns.FechaVencimientoBolsa, value); }
		}
		  
		[XmlAttribute("GrupoBolsa")]
		[Bindable(true)]
		public string GrupoBolsa 
		{
			get { return GetColumnValue<string>(Columns.GrupoBolsa); }
			set { SetColumnValue(Columns.GrupoBolsa, value); }
		}
		  
		[XmlAttribute("FactorBolsa")]
		[Bindable(true)]
		public string FactorBolsa 
		{
			get { return GetColumnValue<string>(Columns.FactorBolsa); }
			set { SetColumnValue(Columns.FactorBolsa, value); }
		}
		  
		[XmlAttribute("SerologiaBolsa")]
		[Bindable(true)]
		public bool SerologiaBolsa 
		{
			get { return GetColumnValue<bool>(Columns.SerologiaBolsa); }
			set { SetColumnValue(Columns.SerologiaBolsa, value); }
		}
		  
		[XmlAttribute("Receptor")]
		[Bindable(true)]
		public string Receptor 
		{
			get { return GetColumnValue<string>(Columns.Receptor); }
			set { SetColumnValue(Columns.Receptor, value); }
		}
		  
		[XmlAttribute("ObservacionesAdmision")]
		[Bindable(true)]
		public string ObservacionesAdmision 
		{
			get { return GetColumnValue<string>(Columns.ObservacionesAdmision); }
			set { SetColumnValue(Columns.ObservacionesAdmision, value); }
		}
		  
		[XmlAttribute("ResponsableEntrevista")]
		[Bindable(true)]
		public string ResponsableEntrevista 
		{
			get { return GetColumnValue<string>(Columns.ResponsableEntrevista); }
			set { SetColumnValue(Columns.ResponsableEntrevista, value); }
		}
		  
		[XmlAttribute("EstadoEntrevista")]
		[Bindable(true)]
		public string EstadoEntrevista 
		{
			get { return GetColumnValue<string>(Columns.EstadoEntrevista); }
			set { SetColumnValue(Columns.EstadoEntrevista, value); }
		}
		  
		[XmlAttribute("IdTipoExclusion")]
		[Bindable(true)]
		public int IdTipoExclusion 
		{
			get { return GetColumnValue<int>(Columns.IdTipoExclusion); }
			set { SetColumnValue(Columns.IdTipoExclusion, value); }
		}
		  
		[XmlAttribute("FechaFinExclusion")]
		[Bindable(true)]
		public DateTime FechaFinExclusion 
		{
			get { return GetColumnValue<DateTime>(Columns.FechaFinExclusion); }
			set { SetColumnValue(Columns.FechaFinExclusion, value); }
		}
		  
		[XmlAttribute("ObservacionesExclusion")]
		[Bindable(true)]
		public string ObservacionesExclusion 
		{
			get { return GetColumnValue<string>(Columns.ObservacionesExclusion); }
			set { SetColumnValue(Columns.ObservacionesExclusion, value); }
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
		  
		[XmlAttribute("IdEfectorSerologia")]
		[Bindable(true)]
		public int IdEfectorSerologia 
		{
			get { return GetColumnValue<int>(Columns.IdEfectorSerologia); }
			set { SetColumnValue(Columns.IdEfectorSerologia, value); }
		}
		  
		[XmlAttribute("IdEfectorHematologia")]
		[Bindable(true)]
		public int IdEfectorHematologia 
		{
			get { return GetColumnValue<int>(Columns.IdEfectorHematologia); }
			set { SetColumnValue(Columns.IdEfectorHematologia, value); }
		}
		  
		[XmlAttribute("IdIncidenciaExtraccion")]
		[Bindable(true)]
		public int IdIncidenciaExtraccion 
		{
			get { return GetColumnValue<int>(Columns.IdIncidenciaExtraccion); }
			set { SetColumnValue(Columns.IdIncidenciaExtraccion, value); }
		}
		  
		[XmlAttribute("Descartada")]
		[Bindable(true)]
		public bool Descartada 
		{
			get { return GetColumnValue<bool>(Columns.Descartada); }
			set { SetColumnValue(Columns.Descartada, value); }
		}
		  
		[XmlAttribute("FechaDescarte")]
		[Bindable(true)]
		public DateTime FechaDescarte 
		{
			get { return GetColumnValue<DateTime>(Columns.FechaDescarte); }
			set { SetColumnValue(Columns.FechaDescarte, value); }
		}
		  
		[XmlAttribute("IdUsuarioDescarte")]
		[Bindable(true)]
		public int IdUsuarioDescarte 
		{
			get { return GetColumnValue<int>(Columns.IdUsuarioDescarte); }
			set { SetColumnValue(Columns.IdUsuarioDescarte, value); }
		}
		  
		[XmlAttribute("Extraccion")]
		[Bindable(true)]
		public string Extraccion 
		{
			get { return GetColumnValue<string>(Columns.Extraccion); }
			set { SetColumnValue(Columns.Extraccion, value); }
		}
		  
		[XmlAttribute("Colecta")]
		[Bindable(true)]
		public string Colecta 
		{
			get { return GetColumnValue<string>(Columns.Colecta); }
			set { SetColumnValue(Columns.Colecta, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(DateTime varFecha,string varHoraAdmision,int varIdDonante,int varIdTipoDonante,int varIdEfectorExtraccion,string varNumeroDeBolsa,string varEfectorOrigenBolsa,DateTime varFechaExtraccionBolsa,DateTime varFechaVencimientoBolsa,string varGrupoBolsa,string varFactorBolsa,bool varSerologiaBolsa,string varReceptor,string varObservacionesAdmision,string varResponsableEntrevista,string varEstadoEntrevista,int varIdTipoExclusion,DateTime varFechaFinExclusion,string varObservacionesExclusion,int varIdUsuarioRegistro,DateTime varFechaRegistro,int varIdEfectorSerologia,int varIdEfectorHematologia,int varIdIncidenciaExtraccion,bool varDescartada,DateTime varFechaDescarte,int varIdUsuarioDescarte,string varExtraccion,string varColecta)
		{
			BdsAdmision item = new BdsAdmision();
			
			item.Fecha = varFecha;
			
			item.HoraAdmision = varHoraAdmision;
			
			item.IdDonante = varIdDonante;
			
			item.IdTipoDonante = varIdTipoDonante;
			
			item.IdEfectorExtraccion = varIdEfectorExtraccion;
			
			item.NumeroDeBolsa = varNumeroDeBolsa;
			
			item.EfectorOrigenBolsa = varEfectorOrigenBolsa;
			
			item.FechaExtraccionBolsa = varFechaExtraccionBolsa;
			
			item.FechaVencimientoBolsa = varFechaVencimientoBolsa;
			
			item.GrupoBolsa = varGrupoBolsa;
			
			item.FactorBolsa = varFactorBolsa;
			
			item.SerologiaBolsa = varSerologiaBolsa;
			
			item.Receptor = varReceptor;
			
			item.ObservacionesAdmision = varObservacionesAdmision;
			
			item.ResponsableEntrevista = varResponsableEntrevista;
			
			item.EstadoEntrevista = varEstadoEntrevista;
			
			item.IdTipoExclusion = varIdTipoExclusion;
			
			item.FechaFinExclusion = varFechaFinExclusion;
			
			item.ObservacionesExclusion = varObservacionesExclusion;
			
			item.IdUsuarioRegistro = varIdUsuarioRegistro;
			
			item.FechaRegistro = varFechaRegistro;
			
			item.IdEfectorSerologia = varIdEfectorSerologia;
			
			item.IdEfectorHematologia = varIdEfectorHematologia;
			
			item.IdIncidenciaExtraccion = varIdIncidenciaExtraccion;
			
			item.Descartada = varDescartada;
			
			item.FechaDescarte = varFechaDescarte;
			
			item.IdUsuarioDescarte = varIdUsuarioDescarte;
			
			item.Extraccion = varExtraccion;
			
			item.Colecta = varColecta;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varIdAdmision,DateTime varFecha,string varHoraAdmision,int varIdDonante,int varIdTipoDonante,int varIdEfectorExtraccion,string varNumeroDeBolsa,string varEfectorOrigenBolsa,DateTime varFechaExtraccionBolsa,DateTime varFechaVencimientoBolsa,string varGrupoBolsa,string varFactorBolsa,bool varSerologiaBolsa,string varReceptor,string varObservacionesAdmision,string varResponsableEntrevista,string varEstadoEntrevista,int varIdTipoExclusion,DateTime varFechaFinExclusion,string varObservacionesExclusion,int varIdUsuarioRegistro,DateTime varFechaRegistro,int varIdEfectorSerologia,int varIdEfectorHematologia,int varIdIncidenciaExtraccion,bool varDescartada,DateTime varFechaDescarte,int varIdUsuarioDescarte,string varExtraccion,string varColecta)
		{
			BdsAdmision item = new BdsAdmision();
			
				item.IdAdmision = varIdAdmision;
			
				item.Fecha = varFecha;
			
				item.HoraAdmision = varHoraAdmision;
			
				item.IdDonante = varIdDonante;
			
				item.IdTipoDonante = varIdTipoDonante;
			
				item.IdEfectorExtraccion = varIdEfectorExtraccion;
			
				item.NumeroDeBolsa = varNumeroDeBolsa;
			
				item.EfectorOrigenBolsa = varEfectorOrigenBolsa;
			
				item.FechaExtraccionBolsa = varFechaExtraccionBolsa;
			
				item.FechaVencimientoBolsa = varFechaVencimientoBolsa;
			
				item.GrupoBolsa = varGrupoBolsa;
			
				item.FactorBolsa = varFactorBolsa;
			
				item.SerologiaBolsa = varSerologiaBolsa;
			
				item.Receptor = varReceptor;
			
				item.ObservacionesAdmision = varObservacionesAdmision;
			
				item.ResponsableEntrevista = varResponsableEntrevista;
			
				item.EstadoEntrevista = varEstadoEntrevista;
			
				item.IdTipoExclusion = varIdTipoExclusion;
			
				item.FechaFinExclusion = varFechaFinExclusion;
			
				item.ObservacionesExclusion = varObservacionesExclusion;
			
				item.IdUsuarioRegistro = varIdUsuarioRegistro;
			
				item.FechaRegistro = varFechaRegistro;
			
				item.IdEfectorSerologia = varIdEfectorSerologia;
			
				item.IdEfectorHematologia = varIdEfectorHematologia;
			
				item.IdIncidenciaExtraccion = varIdIncidenciaExtraccion;
			
				item.Descartada = varDescartada;
			
				item.FechaDescarte = varFechaDescarte;
			
				item.IdUsuarioDescarte = varIdUsuarioDescarte;
			
				item.Extraccion = varExtraccion;
			
				item.Colecta = varColecta;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn IdAdmisionColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn FechaColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn HoraAdmisionColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn IdDonanteColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn IdTipoDonanteColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn IdEfectorExtraccionColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        public static TableSchema.TableColumn NumeroDeBolsaColumn
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        public static TableSchema.TableColumn EfectorOrigenBolsaColumn
        {
            get { return Schema.Columns[7]; }
        }
        
        
        
        public static TableSchema.TableColumn FechaExtraccionBolsaColumn
        {
            get { return Schema.Columns[8]; }
        }
        
        
        
        public static TableSchema.TableColumn FechaVencimientoBolsaColumn
        {
            get { return Schema.Columns[9]; }
        }
        
        
        
        public static TableSchema.TableColumn GrupoBolsaColumn
        {
            get { return Schema.Columns[10]; }
        }
        
        
        
        public static TableSchema.TableColumn FactorBolsaColumn
        {
            get { return Schema.Columns[11]; }
        }
        
        
        
        public static TableSchema.TableColumn SerologiaBolsaColumn
        {
            get { return Schema.Columns[12]; }
        }
        
        
        
        public static TableSchema.TableColumn ReceptorColumn
        {
            get { return Schema.Columns[13]; }
        }
        
        
        
        public static TableSchema.TableColumn ObservacionesAdmisionColumn
        {
            get { return Schema.Columns[14]; }
        }
        
        
        
        public static TableSchema.TableColumn ResponsableEntrevistaColumn
        {
            get { return Schema.Columns[15]; }
        }
        
        
        
        public static TableSchema.TableColumn EstadoEntrevistaColumn
        {
            get { return Schema.Columns[16]; }
        }
        
        
        
        public static TableSchema.TableColumn IdTipoExclusionColumn
        {
            get { return Schema.Columns[17]; }
        }
        
        
        
        public static TableSchema.TableColumn FechaFinExclusionColumn
        {
            get { return Schema.Columns[18]; }
        }
        
        
        
        public static TableSchema.TableColumn ObservacionesExclusionColumn
        {
            get { return Schema.Columns[19]; }
        }
        
        
        
        public static TableSchema.TableColumn IdUsuarioRegistroColumn
        {
            get { return Schema.Columns[20]; }
        }
        
        
        
        public static TableSchema.TableColumn FechaRegistroColumn
        {
            get { return Schema.Columns[21]; }
        }
        
        
        
        public static TableSchema.TableColumn IdEfectorSerologiaColumn
        {
            get { return Schema.Columns[22]; }
        }
        
        
        
        public static TableSchema.TableColumn IdEfectorHematologiaColumn
        {
            get { return Schema.Columns[23]; }
        }
        
        
        
        public static TableSchema.TableColumn IdIncidenciaExtraccionColumn
        {
            get { return Schema.Columns[24]; }
        }
        
        
        
        public static TableSchema.TableColumn DescartadaColumn
        {
            get { return Schema.Columns[25]; }
        }
        
        
        
        public static TableSchema.TableColumn FechaDescarteColumn
        {
            get { return Schema.Columns[26]; }
        }
        
        
        
        public static TableSchema.TableColumn IdUsuarioDescarteColumn
        {
            get { return Schema.Columns[27]; }
        }
        
        
        
        public static TableSchema.TableColumn ExtraccionColumn
        {
            get { return Schema.Columns[28]; }
        }
        
        
        
        public static TableSchema.TableColumn ColectaColumn
        {
            get { return Schema.Columns[29]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string IdAdmision = @"idAdmision";
			 public static string Fecha = @"fecha";
			 public static string HoraAdmision = @"horaAdmision";
			 public static string IdDonante = @"idDonante";
			 public static string IdTipoDonante = @"idTipoDonante";
			 public static string IdEfectorExtraccion = @"idEfectorExtraccion";
			 public static string NumeroDeBolsa = @"numeroDeBolsa";
			 public static string EfectorOrigenBolsa = @"efectorOrigenBolsa";
			 public static string FechaExtraccionBolsa = @"fechaExtraccionBolsa";
			 public static string FechaVencimientoBolsa = @"fechaVencimientoBolsa";
			 public static string GrupoBolsa = @"grupoBolsa";
			 public static string FactorBolsa = @"factorBolsa";
			 public static string SerologiaBolsa = @"serologiaBolsa";
			 public static string Receptor = @"receptor";
			 public static string ObservacionesAdmision = @"observacionesAdmision";
			 public static string ResponsableEntrevista = @"responsableEntrevista";
			 public static string EstadoEntrevista = @"estadoEntrevista";
			 public static string IdTipoExclusion = @"idTipoExclusion";
			 public static string FechaFinExclusion = @"fechaFinExclusion";
			 public static string ObservacionesExclusion = @"observacionesExclusion";
			 public static string IdUsuarioRegistro = @"idUsuarioRegistro";
			 public static string FechaRegistro = @"fechaRegistro";
			 public static string IdEfectorSerologia = @"idEfectorSerologia";
			 public static string IdEfectorHematologia = @"idEfectorHematologia";
			 public static string IdIncidenciaExtraccion = @"idIncidenciaExtraccion";
			 public static string Descartada = @"descartada";
			 public static string FechaDescarte = @"fechaDescarte";
			 public static string IdUsuarioDescarte = @"idUsuarioDescarte";
			 public static string Extraccion = @"extraccion";
			 public static string Colecta = @"colecta";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
