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
	/// Strongly-typed collection for the FacOrden class.
	/// </summary>
    [Serializable]
	public partial class FacOrdenCollection : ActiveList<FacOrden, FacOrdenCollection>
	{	   
		public FacOrdenCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>FacOrdenCollection</returns>
		public FacOrdenCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                FacOrden o = this[i];
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
	/// This is an ActiveRecord class which wraps the FAC_Orden table.
	/// </summary>
	[Serializable]
	public partial class FacOrden : ActiveRecord<FacOrden>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public FacOrden()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public FacOrden(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public FacOrden(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public FacOrden(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("FAC_Orden", TableType.Table, DataService.GetInstance("RisProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarIdOrden = new TableSchema.TableColumn(schema);
				colvarIdOrden.ColumnName = "idOrden";
				colvarIdOrden.DataType = DbType.Int32;
				colvarIdOrden.MaxLength = 0;
				colvarIdOrden.AutoIncrement = true;
				colvarIdOrden.IsNullable = false;
				colvarIdOrden.IsPrimaryKey = true;
				colvarIdOrden.IsForeignKey = false;
				colvarIdOrden.IsReadOnly = false;
				colvarIdOrden.DefaultSetting = @"";
				colvarIdOrden.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdOrden);
				
				TableSchema.TableColumn colvarIdEfector = new TableSchema.TableColumn(schema);
				colvarIdEfector.ColumnName = "idEfector";
				colvarIdEfector.DataType = DbType.Int32;
				colvarIdEfector.MaxLength = 0;
				colvarIdEfector.AutoIncrement = false;
				colvarIdEfector.IsNullable = false;
				colvarIdEfector.IsPrimaryKey = false;
				colvarIdEfector.IsForeignKey = true;
				colvarIdEfector.IsReadOnly = false;
				colvarIdEfector.DefaultSetting = @"";
				
					colvarIdEfector.ForeignKeyTableName = "Sys_Efector";
				schema.Columns.Add(colvarIdEfector);
				
				TableSchema.TableColumn colvarNumero = new TableSchema.TableColumn(schema);
				colvarNumero.ColumnName = "numero";
				colvarNumero.DataType = DbType.Int32;
				colvarNumero.MaxLength = 0;
				colvarNumero.AutoIncrement = false;
				colvarNumero.IsNullable = false;
				colvarNumero.IsPrimaryKey = false;
				colvarNumero.IsForeignKey = false;
				colvarNumero.IsReadOnly = false;
				colvarNumero.DefaultSetting = @"";
				colvarNumero.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNumero);
				
				TableSchema.TableColumn colvarPeriodo = new TableSchema.TableColumn(schema);
				colvarPeriodo.ColumnName = "periodo";
				colvarPeriodo.DataType = DbType.AnsiStringFixedLength;
				colvarPeriodo.MaxLength = 10;
				colvarPeriodo.AutoIncrement = false;
				colvarPeriodo.IsNullable = false;
				colvarPeriodo.IsPrimaryKey = false;
				colvarPeriodo.IsForeignKey = false;
				colvarPeriodo.IsReadOnly = false;
				colvarPeriodo.DefaultSetting = @"";
				colvarPeriodo.ForeignKeyTableName = "";
				schema.Columns.Add(colvarPeriodo);
				
				TableSchema.TableColumn colvarIdServicio = new TableSchema.TableColumn(schema);
				colvarIdServicio.ColumnName = "idServicio";
				colvarIdServicio.DataType = DbType.Int32;
				colvarIdServicio.MaxLength = 0;
				colvarIdServicio.AutoIncrement = false;
				colvarIdServicio.IsNullable = false;
				colvarIdServicio.IsPrimaryKey = false;
				colvarIdServicio.IsForeignKey = true;
				colvarIdServicio.IsReadOnly = false;
				colvarIdServicio.DefaultSetting = @"";
				
					colvarIdServicio.ForeignKeyTableName = "Sys_Servicio";
				schema.Columns.Add(colvarIdServicio);
				
				TableSchema.TableColumn colvarIdPaciente = new TableSchema.TableColumn(schema);
				colvarIdPaciente.ColumnName = "idPaciente";
				colvarIdPaciente.DataType = DbType.Int32;
				colvarIdPaciente.MaxLength = 0;
				colvarIdPaciente.AutoIncrement = false;
				colvarIdPaciente.IsNullable = false;
				colvarIdPaciente.IsPrimaryKey = false;
				colvarIdPaciente.IsForeignKey = false;
				colvarIdPaciente.IsReadOnly = false;
				
						colvarIdPaciente.DefaultSetting = @"((0))";
				colvarIdPaciente.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdPaciente);
				
				TableSchema.TableColumn colvarIdProfesional = new TableSchema.TableColumn(schema);
				colvarIdProfesional.ColumnName = "idProfesional";
				colvarIdProfesional.DataType = DbType.Int32;
				colvarIdProfesional.MaxLength = 0;
				colvarIdProfesional.AutoIncrement = false;
				colvarIdProfesional.IsNullable = false;
				colvarIdProfesional.IsPrimaryKey = false;
				colvarIdProfesional.IsForeignKey = false;
				colvarIdProfesional.IsReadOnly = false;
				
						colvarIdProfesional.DefaultSetting = @"('')";
				colvarIdProfesional.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdProfesional);
				
				TableSchema.TableColumn colvarFecha = new TableSchema.TableColumn(schema);
				colvarFecha.ColumnName = "fecha";
				colvarFecha.DataType = DbType.DateTime;
				colvarFecha.MaxLength = 0;
				colvarFecha.AutoIncrement = false;
				colvarFecha.IsNullable = false;
				colvarFecha.IsPrimaryKey = false;
				colvarFecha.IsForeignKey = false;
				colvarFecha.IsReadOnly = false;
				
						colvarFecha.DefaultSetting = @"(((1)/(1))/(1900))";
				colvarFecha.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFecha);
				
				TableSchema.TableColumn colvarFechaPractica = new TableSchema.TableColumn(schema);
				colvarFechaPractica.ColumnName = "fechaPractica";
				colvarFechaPractica.DataType = DbType.DateTime;
				colvarFechaPractica.MaxLength = 0;
				colvarFechaPractica.AutoIncrement = false;
				colvarFechaPractica.IsNullable = false;
				colvarFechaPractica.IsPrimaryKey = false;
				colvarFechaPractica.IsForeignKey = false;
				colvarFechaPractica.IsReadOnly = false;
				
						colvarFechaPractica.DefaultSetting = @"(((1)/(1))/(1900))";
				colvarFechaPractica.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFechaPractica);
				
				TableSchema.TableColumn colvarIdTipoPractica = new TableSchema.TableColumn(schema);
				colvarIdTipoPractica.ColumnName = "idTipoPractica";
				colvarIdTipoPractica.DataType = DbType.Int32;
				colvarIdTipoPractica.MaxLength = 0;
				colvarIdTipoPractica.AutoIncrement = false;
				colvarIdTipoPractica.IsNullable = false;
				colvarIdTipoPractica.IsPrimaryKey = false;
				colvarIdTipoPractica.IsForeignKey = true;
				colvarIdTipoPractica.IsReadOnly = false;
				colvarIdTipoPractica.DefaultSetting = @"";
				
					colvarIdTipoPractica.ForeignKeyTableName = "FAC_TipoPractica";
				schema.Columns.Add(colvarIdTipoPractica);
				
				TableSchema.TableColumn colvarIdObraSocial = new TableSchema.TableColumn(schema);
				colvarIdObraSocial.ColumnName = "idObraSocial";
				colvarIdObraSocial.DataType = DbType.Int32;
				colvarIdObraSocial.MaxLength = 0;
				colvarIdObraSocial.AutoIncrement = false;
				colvarIdObraSocial.IsNullable = false;
				colvarIdObraSocial.IsPrimaryKey = false;
				colvarIdObraSocial.IsForeignKey = true;
				colvarIdObraSocial.IsReadOnly = false;
				colvarIdObraSocial.DefaultSetting = @"";
				
					colvarIdObraSocial.ForeignKeyTableName = "Sys_ObraSocial";
				schema.Columns.Add(colvarIdObraSocial);
				
				TableSchema.TableColumn colvarNroAfiliado = new TableSchema.TableColumn(schema);
				colvarNroAfiliado.ColumnName = "nroAfiliado";
				colvarNroAfiliado.DataType = DbType.AnsiString;
				colvarNroAfiliado.MaxLength = 50;
				colvarNroAfiliado.AutoIncrement = false;
				colvarNroAfiliado.IsNullable = false;
				colvarNroAfiliado.IsPrimaryKey = false;
				colvarNroAfiliado.IsForeignKey = false;
				colvarNroAfiliado.IsReadOnly = false;
				
						colvarNroAfiliado.DefaultSetting = @"('')";
				colvarNroAfiliado.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNroAfiliado);
				
				TableSchema.TableColumn colvarObservaciones = new TableSchema.TableColumn(schema);
				colvarObservaciones.ColumnName = "observaciones";
				colvarObservaciones.DataType = DbType.AnsiString;
				colvarObservaciones.MaxLength = 500;
				colvarObservaciones.AutoIncrement = false;
				colvarObservaciones.IsNullable = false;
				colvarObservaciones.IsPrimaryKey = false;
				colvarObservaciones.IsForeignKey = false;
				colvarObservaciones.IsReadOnly = false;
				
						colvarObservaciones.DefaultSetting = @"('')";
				colvarObservaciones.ForeignKeyTableName = "";
				schema.Columns.Add(colvarObservaciones);
				
				TableSchema.TableColumn colvarEstado = new TableSchema.TableColumn(schema);
				colvarEstado.ColumnName = "estado";
				colvarEstado.DataType = DbType.AnsiStringFixedLength;
				colvarEstado.MaxLength = 10;
				colvarEstado.AutoIncrement = false;
				colvarEstado.IsNullable = false;
				colvarEstado.IsPrimaryKey = false;
				colvarEstado.IsForeignKey = false;
				colvarEstado.IsReadOnly = false;
				
						colvarEstado.DefaultSetting = @"('A')";
				colvarEstado.ForeignKeyTableName = "";
				schema.Columns.Add(colvarEstado);
				
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
				
						colvarFechaRegistro.DefaultSetting = @"(((1)/(1))/(1900))";
				colvarFechaRegistro.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFechaRegistro);
				
				TableSchema.TableColumn colvarIdPrefactura = new TableSchema.TableColumn(schema);
				colvarIdPrefactura.ColumnName = "idPrefactura";
				colvarIdPrefactura.DataType = DbType.Int32;
				colvarIdPrefactura.MaxLength = 0;
				colvarIdPrefactura.AutoIncrement = false;
				colvarIdPrefactura.IsNullable = false;
				colvarIdPrefactura.IsPrimaryKey = false;
				colvarIdPrefactura.IsForeignKey = true;
				colvarIdPrefactura.IsReadOnly = false;
				
						colvarIdPrefactura.DefaultSetting = @"((0))";
				
					colvarIdPrefactura.ForeignKeyTableName = "FAC_PreFactura";
				schema.Columns.Add(colvarIdPrefactura);
				
				TableSchema.TableColumn colvarIdFactura = new TableSchema.TableColumn(schema);
				colvarIdFactura.ColumnName = "idFactura";
				colvarIdFactura.DataType = DbType.Int32;
				colvarIdFactura.MaxLength = 0;
				colvarIdFactura.AutoIncrement = false;
				colvarIdFactura.IsNullable = false;
				colvarIdFactura.IsPrimaryKey = false;
				colvarIdFactura.IsForeignKey = true;
				colvarIdFactura.IsReadOnly = false;
				
						colvarIdFactura.DefaultSetting = @"((0))";
				
					colvarIdFactura.ForeignKeyTableName = "FAC_Factura";
				schema.Columns.Add(colvarIdFactura);
				
				TableSchema.TableColumn colvarBaja = new TableSchema.TableColumn(schema);
				colvarBaja.ColumnName = "baja";
				colvarBaja.DataType = DbType.Boolean;
				colvarBaja.MaxLength = 0;
				colvarBaja.AutoIncrement = false;
				colvarBaja.IsNullable = false;
				colvarBaja.IsPrimaryKey = false;
				colvarBaja.IsForeignKey = false;
				colvarBaja.IsReadOnly = false;
				
						colvarBaja.DefaultSetting = @"((0))";
				colvarBaja.ForeignKeyTableName = "";
				schema.Columns.Add(colvarBaja);
				
				TableSchema.TableColumn colvarCodificaHIV = new TableSchema.TableColumn(schema);
				colvarCodificaHIV.ColumnName = "codificaHIV";
				colvarCodificaHIV.DataType = DbType.Boolean;
				colvarCodificaHIV.MaxLength = 0;
				colvarCodificaHIV.AutoIncrement = false;
				colvarCodificaHIV.IsNullable = false;
				colvarCodificaHIV.IsPrimaryKey = false;
				colvarCodificaHIV.IsForeignKey = false;
				colvarCodificaHIV.IsReadOnly = false;
				
						colvarCodificaHIV.DefaultSetting = @"((0))";
				colvarCodificaHIV.ForeignKeyTableName = "";
				schema.Columns.Add(colvarCodificaHIV);
				
				TableSchema.TableColumn colvarMonto = new TableSchema.TableColumn(schema);
				colvarMonto.ColumnName = "monto";
				colvarMonto.DataType = DbType.Decimal;
				colvarMonto.MaxLength = 0;
				colvarMonto.AutoIncrement = false;
				colvarMonto.IsNullable = false;
				colvarMonto.IsPrimaryKey = false;
				colvarMonto.IsForeignKey = false;
				colvarMonto.IsReadOnly = false;
				
						colvarMonto.DefaultSetting = @"((0))";
				colvarMonto.ForeignKeyTableName = "";
				schema.Columns.Add(colvarMonto);
				
				TableSchema.TableColumn colvarNumeroSiniestro = new TableSchema.TableColumn(schema);
				colvarNumeroSiniestro.ColumnName = "numeroSiniestro";
				colvarNumeroSiniestro.DataType = DbType.AnsiString;
				colvarNumeroSiniestro.MaxLength = 50;
				colvarNumeroSiniestro.AutoIncrement = false;
				colvarNumeroSiniestro.IsNullable = false;
				colvarNumeroSiniestro.IsPrimaryKey = false;
				colvarNumeroSiniestro.IsForeignKey = false;
				colvarNumeroSiniestro.IsReadOnly = false;
				
						colvarNumeroSiniestro.DefaultSetting = @"((0))";
				colvarNumeroSiniestro.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNumeroSiniestro);
				
				TableSchema.TableColumn colvarFechaSiniestro = new TableSchema.TableColumn(schema);
				colvarFechaSiniestro.ColumnName = "fechaSiniestro";
				colvarFechaSiniestro.DataType = DbType.DateTime;
				colvarFechaSiniestro.MaxLength = 0;
				colvarFechaSiniestro.AutoIncrement = false;
				colvarFechaSiniestro.IsNullable = false;
				colvarFechaSiniestro.IsPrimaryKey = false;
				colvarFechaSiniestro.IsForeignKey = false;
				colvarFechaSiniestro.IsReadOnly = false;
				
						colvarFechaSiniestro.DefaultSetting = @"(getdate())";
				colvarFechaSiniestro.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFechaSiniestro);
				
				TableSchema.TableColumn colvarFacturaFueraConvenio = new TableSchema.TableColumn(schema);
				colvarFacturaFueraConvenio.ColumnName = "facturaFueraConvenio";
				colvarFacturaFueraConvenio.DataType = DbType.Boolean;
				colvarFacturaFueraConvenio.MaxLength = 0;
				colvarFacturaFueraConvenio.AutoIncrement = false;
				colvarFacturaFueraConvenio.IsNullable = false;
				colvarFacturaFueraConvenio.IsPrimaryKey = false;
				colvarFacturaFueraConvenio.IsForeignKey = false;
				colvarFacturaFueraConvenio.IsReadOnly = false;
				
						colvarFacturaFueraConvenio.DefaultSetting = @"((0))";
				colvarFacturaFueraConvenio.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFacturaFueraConvenio);
				
				TableSchema.TableColumn colvarEsInternacion = new TableSchema.TableColumn(schema);
				colvarEsInternacion.ColumnName = "esInternacion";
				colvarEsInternacion.DataType = DbType.Boolean;
				colvarEsInternacion.MaxLength = 0;
				colvarEsInternacion.AutoIncrement = false;
				colvarEsInternacion.IsNullable = true;
				colvarEsInternacion.IsPrimaryKey = false;
				colvarEsInternacion.IsForeignKey = false;
				colvarEsInternacion.IsReadOnly = false;
				
						colvarEsInternacion.DefaultSetting = @"((0))";
				colvarEsInternacion.ForeignKeyTableName = "";
				schema.Columns.Add(colvarEsInternacion);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["RisProvider"].AddSchema("FAC_Orden",schema);
			}
		}
		#endregion
		
		#region Props
		  
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
		  
		[XmlAttribute("Numero")]
		[Bindable(true)]
		public int Numero 
		{
			get { return GetColumnValue<int>(Columns.Numero); }
			set { SetColumnValue(Columns.Numero, value); }
		}
		  
		[XmlAttribute("Periodo")]
		[Bindable(true)]
		public string Periodo 
		{
			get { return GetColumnValue<string>(Columns.Periodo); }
			set { SetColumnValue(Columns.Periodo, value); }
		}
		  
		[XmlAttribute("IdServicio")]
		[Bindable(true)]
		public int IdServicio 
		{
			get { return GetColumnValue<int>(Columns.IdServicio); }
			set { SetColumnValue(Columns.IdServicio, value); }
		}
		  
		[XmlAttribute("IdPaciente")]
		[Bindable(true)]
		public int IdPaciente 
		{
			get { return GetColumnValue<int>(Columns.IdPaciente); }
			set { SetColumnValue(Columns.IdPaciente, value); }
		}
		  
		[XmlAttribute("IdProfesional")]
		[Bindable(true)]
		public int IdProfesional 
		{
			get { return GetColumnValue<int>(Columns.IdProfesional); }
			set { SetColumnValue(Columns.IdProfesional, value); }
		}
		  
		[XmlAttribute("Fecha")]
		[Bindable(true)]
		public DateTime Fecha 
		{
			get { return GetColumnValue<DateTime>(Columns.Fecha); }
			set { SetColumnValue(Columns.Fecha, value); }
		}
		  
		[XmlAttribute("FechaPractica")]
		[Bindable(true)]
		public DateTime FechaPractica 
		{
			get { return GetColumnValue<DateTime>(Columns.FechaPractica); }
			set { SetColumnValue(Columns.FechaPractica, value); }
		}
		  
		[XmlAttribute("IdTipoPractica")]
		[Bindable(true)]
		public int IdTipoPractica 
		{
			get { return GetColumnValue<int>(Columns.IdTipoPractica); }
			set { SetColumnValue(Columns.IdTipoPractica, value); }
		}
		  
		[XmlAttribute("IdObraSocial")]
		[Bindable(true)]
		public int IdObraSocial 
		{
			get { return GetColumnValue<int>(Columns.IdObraSocial); }
			set { SetColumnValue(Columns.IdObraSocial, value); }
		}
		  
		[XmlAttribute("NroAfiliado")]
		[Bindable(true)]
		public string NroAfiliado 
		{
			get { return GetColumnValue<string>(Columns.NroAfiliado); }
			set { SetColumnValue(Columns.NroAfiliado, value); }
		}
		  
		[XmlAttribute("Observaciones")]
		[Bindable(true)]
		public string Observaciones 
		{
			get { return GetColumnValue<string>(Columns.Observaciones); }
			set { SetColumnValue(Columns.Observaciones, value); }
		}
		  
		[XmlAttribute("Estado")]
		[Bindable(true)]
		public string Estado 
		{
			get { return GetColumnValue<string>(Columns.Estado); }
			set { SetColumnValue(Columns.Estado, value); }
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
		  
		[XmlAttribute("IdPrefactura")]
		[Bindable(true)]
		public int IdPrefactura 
		{
			get { return GetColumnValue<int>(Columns.IdPrefactura); }
			set { SetColumnValue(Columns.IdPrefactura, value); }
		}
		  
		[XmlAttribute("IdFactura")]
		[Bindable(true)]
		public int IdFactura 
		{
			get { return GetColumnValue<int>(Columns.IdFactura); }
			set { SetColumnValue(Columns.IdFactura, value); }
		}
		  
		[XmlAttribute("Baja")]
		[Bindable(true)]
		public bool Baja 
		{
			get { return GetColumnValue<bool>(Columns.Baja); }
			set { SetColumnValue(Columns.Baja, value); }
		}
		  
		[XmlAttribute("CodificaHIV")]
		[Bindable(true)]
		public bool CodificaHIV 
		{
			get { return GetColumnValue<bool>(Columns.CodificaHIV); }
			set { SetColumnValue(Columns.CodificaHIV, value); }
		}
		  
		[XmlAttribute("Monto")]
		[Bindable(true)]
		public decimal Monto 
		{
			get { return GetColumnValue<decimal>(Columns.Monto); }
			set { SetColumnValue(Columns.Monto, value); }
		}
		  
		[XmlAttribute("NumeroSiniestro")]
		[Bindable(true)]
		public string NumeroSiniestro 
		{
			get { return GetColumnValue<string>(Columns.NumeroSiniestro); }
			set { SetColumnValue(Columns.NumeroSiniestro, value); }
		}
		  
		[XmlAttribute("FechaSiniestro")]
		[Bindable(true)]
		public DateTime FechaSiniestro 
		{
			get { return GetColumnValue<DateTime>(Columns.FechaSiniestro); }
			set { SetColumnValue(Columns.FechaSiniestro, value); }
		}
		  
		[XmlAttribute("FacturaFueraConvenio")]
		[Bindable(true)]
		public bool FacturaFueraConvenio 
		{
			get { return GetColumnValue<bool>(Columns.FacturaFueraConvenio); }
			set { SetColumnValue(Columns.FacturaFueraConvenio, value); }
		}
		  
		[XmlAttribute("EsInternacion")]
		[Bindable(true)]
		public bool? EsInternacion 
		{
			get { return GetColumnValue<bool?>(Columns.EsInternacion); }
			set { SetColumnValue(Columns.EsInternacion, value); }
		}
		
		#endregion
		
		
		#region PrimaryKey Methods		
		
        protected override void SetPrimaryKey(object oValue)
        {
            base.SetPrimaryKey(oValue);
            
            SetPKValues();
        }
        
		
		private DalRis.FacOrdenLaboratorioCollection colFacOrdenLaboratorioRecords;
		public DalRis.FacOrdenLaboratorioCollection FacOrdenLaboratorioRecords()
		{
			if(colFacOrdenLaboratorioRecords == null)
			{
				colFacOrdenLaboratorioRecords = new DalRis.FacOrdenLaboratorioCollection().Where(FacOrdenLaboratorio.Columns.IdOrden, IdOrden).Load();
				colFacOrdenLaboratorioRecords.ListChanged += new ListChangedEventHandler(colFacOrdenLaboratorioRecords_ListChanged);
			}
			return colFacOrdenLaboratorioRecords;
		}
				
		void colFacOrdenLaboratorioRecords_ListChanged(object sender, ListChangedEventArgs e)
		{
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
		        // Set foreign key value
		        colFacOrdenLaboratorioRecords[e.NewIndex].IdOrden = IdOrden;
				colFacOrdenLaboratorioRecords.ListChanged += new ListChangedEventHandler(colFacOrdenLaboratorioRecords_ListChanged);
            }
		}
		private DalRis.FacOrdenTurnoCollection colFacOrdenTurnoRecords;
		public DalRis.FacOrdenTurnoCollection FacOrdenTurnoRecords()
		{
			if(colFacOrdenTurnoRecords == null)
			{
				colFacOrdenTurnoRecords = new DalRis.FacOrdenTurnoCollection().Where(FacOrdenTurno.Columns.IdOrden, IdOrden).Load();
				colFacOrdenTurnoRecords.ListChanged += new ListChangedEventHandler(colFacOrdenTurnoRecords_ListChanged);
			}
			return colFacOrdenTurnoRecords;
		}
				
		void colFacOrdenTurnoRecords_ListChanged(object sender, ListChangedEventArgs e)
		{
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
		        // Set foreign key value
		        colFacOrdenTurnoRecords[e.NewIndex].IdOrden = IdOrden;
				colFacOrdenTurnoRecords.ListChanged += new ListChangedEventHandler(colFacOrdenTurnoRecords_ListChanged);
            }
		}
		private DalRis.FacOrdenDetalleCollection colFacOrdenDetalleRecords;
		public DalRis.FacOrdenDetalleCollection FacOrdenDetalleRecords()
		{
			if(colFacOrdenDetalleRecords == null)
			{
				colFacOrdenDetalleRecords = new DalRis.FacOrdenDetalleCollection().Where(FacOrdenDetalle.Columns.IdOrden, IdOrden).Load();
				colFacOrdenDetalleRecords.ListChanged += new ListChangedEventHandler(colFacOrdenDetalleRecords_ListChanged);
			}
			return colFacOrdenDetalleRecords;
		}
				
		void colFacOrdenDetalleRecords_ListChanged(object sender, ListChangedEventArgs e)
		{
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
		        // Set foreign key value
		        colFacOrdenDetalleRecords[e.NewIndex].IdOrden = IdOrden;
				colFacOrdenDetalleRecords.ListChanged += new ListChangedEventHandler(colFacOrdenDetalleRecords_ListChanged);
            }
		}
		private DalRis.FacOrdenPacienteCollection colFacOrdenPacienteRecords;
		public DalRis.FacOrdenPacienteCollection FacOrdenPacienteRecords()
		{
			if(colFacOrdenPacienteRecords == null)
			{
				colFacOrdenPacienteRecords = new DalRis.FacOrdenPacienteCollection().Where(FacOrdenPaciente.Columns.IdOrden, IdOrden).Load();
				colFacOrdenPacienteRecords.ListChanged += new ListChangedEventHandler(colFacOrdenPacienteRecords_ListChanged);
			}
			return colFacOrdenPacienteRecords;
		}
				
		void colFacOrdenPacienteRecords_ListChanged(object sender, ListChangedEventArgs e)
		{
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
		        // Set foreign key value
		        colFacOrdenPacienteRecords[e.NewIndex].IdOrden = IdOrden;
				colFacOrdenPacienteRecords.ListChanged += new ListChangedEventHandler(colFacOrdenPacienteRecords_ListChanged);
            }
		}
		#endregion
		
			
		
		#region ForeignKey Properties
		
		/// <summary>
		/// Returns a SysEfector ActiveRecord object related to this FacOrden
		/// 
		/// </summary>
		public DalRis.SysEfector SysEfector
		{
			get { return DalRis.SysEfector.FetchByID(this.IdEfector); }
			set { SetColumnValue("idEfector", value.IdEfector); }
		}
		
		
		/// <summary>
		/// Returns a SysObraSocial ActiveRecord object related to this FacOrden
		/// 
		/// </summary>
		public DalRis.SysObraSocial SysObraSocial
		{
			get { return DalRis.SysObraSocial.FetchByID(this.IdObraSocial); }
			set { SetColumnValue("idObraSocial", value.IdObraSocial); }
		}
		
		
		/// <summary>
		/// Returns a FacTipoPractica ActiveRecord object related to this FacOrden
		/// 
		/// </summary>
		public DalRis.FacTipoPractica FacTipoPractica
		{
			get { return DalRis.FacTipoPractica.FetchByID(this.IdTipoPractica); }
			set { SetColumnValue("idTipoPractica", value.IdTipoPractica); }
		}
		
		
		/// <summary>
		/// Returns a FacPreFactura ActiveRecord object related to this FacOrden
		/// 
		/// </summary>
		public DalRis.FacPreFactura FacPreFactura
		{
			get { return DalRis.FacPreFactura.FetchByID(this.IdPrefactura); }
			set { SetColumnValue("idPrefactura", value.IdPreFactura); }
		}
		
		
		/// <summary>
		/// Returns a SysServicio ActiveRecord object related to this FacOrden
		/// 
		/// </summary>
		public DalRis.SysServicio SysServicio
		{
			get { return DalRis.SysServicio.FetchByID(this.IdServicio); }
			set { SetColumnValue("idServicio", value.IdServicio); }
		}
		
		
		/// <summary>
		/// Returns a FacFactura ActiveRecord object related to this FacOrden
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
		public static void Insert(int varIdEfector,int varNumero,string varPeriodo,int varIdServicio,int varIdPaciente,int varIdProfesional,DateTime varFecha,DateTime varFechaPractica,int varIdTipoPractica,int varIdObraSocial,string varNroAfiliado,string varObservaciones,string varEstado,int varIdUsuarioRegistro,DateTime varFechaRegistro,int varIdPrefactura,int varIdFactura,bool varBaja,bool varCodificaHIV,decimal varMonto,string varNumeroSiniestro,DateTime varFechaSiniestro,bool varFacturaFueraConvenio,bool? varEsInternacion)
		{
			FacOrden item = new FacOrden();
			
			item.IdEfector = varIdEfector;
			
			item.Numero = varNumero;
			
			item.Periodo = varPeriodo;
			
			item.IdServicio = varIdServicio;
			
			item.IdPaciente = varIdPaciente;
			
			item.IdProfesional = varIdProfesional;
			
			item.Fecha = varFecha;
			
			item.FechaPractica = varFechaPractica;
			
			item.IdTipoPractica = varIdTipoPractica;
			
			item.IdObraSocial = varIdObraSocial;
			
			item.NroAfiliado = varNroAfiliado;
			
			item.Observaciones = varObservaciones;
			
			item.Estado = varEstado;
			
			item.IdUsuarioRegistro = varIdUsuarioRegistro;
			
			item.FechaRegistro = varFechaRegistro;
			
			item.IdPrefactura = varIdPrefactura;
			
			item.IdFactura = varIdFactura;
			
			item.Baja = varBaja;
			
			item.CodificaHIV = varCodificaHIV;
			
			item.Monto = varMonto;
			
			item.NumeroSiniestro = varNumeroSiniestro;
			
			item.FechaSiniestro = varFechaSiniestro;
			
			item.FacturaFueraConvenio = varFacturaFueraConvenio;
			
			item.EsInternacion = varEsInternacion;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varIdOrden,int varIdEfector,int varNumero,string varPeriodo,int varIdServicio,int varIdPaciente,int varIdProfesional,DateTime varFecha,DateTime varFechaPractica,int varIdTipoPractica,int varIdObraSocial,string varNroAfiliado,string varObservaciones,string varEstado,int varIdUsuarioRegistro,DateTime varFechaRegistro,int varIdPrefactura,int varIdFactura,bool varBaja,bool varCodificaHIV,decimal varMonto,string varNumeroSiniestro,DateTime varFechaSiniestro,bool varFacturaFueraConvenio,bool? varEsInternacion)
		{
			FacOrden item = new FacOrden();
			
				item.IdOrden = varIdOrden;
			
				item.IdEfector = varIdEfector;
			
				item.Numero = varNumero;
			
				item.Periodo = varPeriodo;
			
				item.IdServicio = varIdServicio;
			
				item.IdPaciente = varIdPaciente;
			
				item.IdProfesional = varIdProfesional;
			
				item.Fecha = varFecha;
			
				item.FechaPractica = varFechaPractica;
			
				item.IdTipoPractica = varIdTipoPractica;
			
				item.IdObraSocial = varIdObraSocial;
			
				item.NroAfiliado = varNroAfiliado;
			
				item.Observaciones = varObservaciones;
			
				item.Estado = varEstado;
			
				item.IdUsuarioRegistro = varIdUsuarioRegistro;
			
				item.FechaRegistro = varFechaRegistro;
			
				item.IdPrefactura = varIdPrefactura;
			
				item.IdFactura = varIdFactura;
			
				item.Baja = varBaja;
			
				item.CodificaHIV = varCodificaHIV;
			
				item.Monto = varMonto;
			
				item.NumeroSiniestro = varNumeroSiniestro;
			
				item.FechaSiniestro = varFechaSiniestro;
			
				item.FacturaFueraConvenio = varFacturaFueraConvenio;
			
				item.EsInternacion = varEsInternacion;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn IdOrdenColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn IdEfectorColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn NumeroColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn PeriodoColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn IdServicioColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn IdPacienteColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        public static TableSchema.TableColumn IdProfesionalColumn
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        public static TableSchema.TableColumn FechaColumn
        {
            get { return Schema.Columns[7]; }
        }
        
        
        
        public static TableSchema.TableColumn FechaPracticaColumn
        {
            get { return Schema.Columns[8]; }
        }
        
        
        
        public static TableSchema.TableColumn IdTipoPracticaColumn
        {
            get { return Schema.Columns[9]; }
        }
        
        
        
        public static TableSchema.TableColumn IdObraSocialColumn
        {
            get { return Schema.Columns[10]; }
        }
        
        
        
        public static TableSchema.TableColumn NroAfiliadoColumn
        {
            get { return Schema.Columns[11]; }
        }
        
        
        
        public static TableSchema.TableColumn ObservacionesColumn
        {
            get { return Schema.Columns[12]; }
        }
        
        
        
        public static TableSchema.TableColumn EstadoColumn
        {
            get { return Schema.Columns[13]; }
        }
        
        
        
        public static TableSchema.TableColumn IdUsuarioRegistroColumn
        {
            get { return Schema.Columns[14]; }
        }
        
        
        
        public static TableSchema.TableColumn FechaRegistroColumn
        {
            get { return Schema.Columns[15]; }
        }
        
        
        
        public static TableSchema.TableColumn IdPrefacturaColumn
        {
            get { return Schema.Columns[16]; }
        }
        
        
        
        public static TableSchema.TableColumn IdFacturaColumn
        {
            get { return Schema.Columns[17]; }
        }
        
        
        
        public static TableSchema.TableColumn BajaColumn
        {
            get { return Schema.Columns[18]; }
        }
        
        
        
        public static TableSchema.TableColumn CodificaHIVColumn
        {
            get { return Schema.Columns[19]; }
        }
        
        
        
        public static TableSchema.TableColumn MontoColumn
        {
            get { return Schema.Columns[20]; }
        }
        
        
        
        public static TableSchema.TableColumn NumeroSiniestroColumn
        {
            get { return Schema.Columns[21]; }
        }
        
        
        
        public static TableSchema.TableColumn FechaSiniestroColumn
        {
            get { return Schema.Columns[22]; }
        }
        
        
        
        public static TableSchema.TableColumn FacturaFueraConvenioColumn
        {
            get { return Schema.Columns[23]; }
        }
        
        
        
        public static TableSchema.TableColumn EsInternacionColumn
        {
            get { return Schema.Columns[24]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string IdOrden = @"idOrden";
			 public static string IdEfector = @"idEfector";
			 public static string Numero = @"numero";
			 public static string Periodo = @"periodo";
			 public static string IdServicio = @"idServicio";
			 public static string IdPaciente = @"idPaciente";
			 public static string IdProfesional = @"idProfesional";
			 public static string Fecha = @"fecha";
			 public static string FechaPractica = @"fechaPractica";
			 public static string IdTipoPractica = @"idTipoPractica";
			 public static string IdObraSocial = @"idObraSocial";
			 public static string NroAfiliado = @"nroAfiliado";
			 public static string Observaciones = @"observaciones";
			 public static string Estado = @"estado";
			 public static string IdUsuarioRegistro = @"idUsuarioRegistro";
			 public static string FechaRegistro = @"fechaRegistro";
			 public static string IdPrefactura = @"idPrefactura";
			 public static string IdFactura = @"idFactura";
			 public static string Baja = @"baja";
			 public static string CodificaHIV = @"codificaHIV";
			 public static string Monto = @"monto";
			 public static string NumeroSiniestro = @"numeroSiniestro";
			 public static string FechaSiniestro = @"fechaSiniestro";
			 public static string FacturaFueraConvenio = @"facturaFueraConvenio";
			 public static string EsInternacion = @"esInternacion";
						
		}
		#endregion
		
		#region Update PK Collections
		
        public void SetPKValues()
        {
                if (colFacOrdenLaboratorioRecords != null)
                {
                    foreach (DalRis.FacOrdenLaboratorio item in colFacOrdenLaboratorioRecords)
                    {
                        if (item.IdOrden != IdOrden)
                        {
                            item.IdOrden = IdOrden;
                        }
                    }
               }
		
                if (colFacOrdenTurnoRecords != null)
                {
                    foreach (DalRis.FacOrdenTurno item in colFacOrdenTurnoRecords)
                    {
                        if (item.IdOrden != IdOrden)
                        {
                            item.IdOrden = IdOrden;
                        }
                    }
               }
		
                if (colFacOrdenDetalleRecords != null)
                {
                    foreach (DalRis.FacOrdenDetalle item in colFacOrdenDetalleRecords)
                    {
                        if (item.IdOrden != IdOrden)
                        {
                            item.IdOrden = IdOrden;
                        }
                    }
               }
		
                if (colFacOrdenPacienteRecords != null)
                {
                    foreach (DalRis.FacOrdenPaciente item in colFacOrdenPacienteRecords)
                    {
                        if (item.IdOrden != IdOrden)
                        {
                            item.IdOrden = IdOrden;
                        }
                    }
               }
		}
        #endregion
    
        #region Deep Save
		
        public void DeepSave()
        {
            Save();
            
                if (colFacOrdenLaboratorioRecords != null)
                {
                    colFacOrdenLaboratorioRecords.SaveAll();
               }
		
                if (colFacOrdenTurnoRecords != null)
                {
                    colFacOrdenTurnoRecords.SaveAll();
               }
		
                if (colFacOrdenDetalleRecords != null)
                {
                    colFacOrdenDetalleRecords.SaveAll();
               }
		
                if (colFacOrdenPacienteRecords != null)
                {
                    colFacOrdenPacienteRecords.SaveAll();
               }
		}
        #endregion
	}
}
