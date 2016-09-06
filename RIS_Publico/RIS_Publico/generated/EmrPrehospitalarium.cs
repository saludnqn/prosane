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
	/// Strongly-typed collection for the EmrPrehospitalarium class.
	/// </summary>
    [Serializable]
	public partial class EmrPrehospitalariumCollection : ActiveList<EmrPrehospitalarium, EmrPrehospitalariumCollection>
	{	   
		public EmrPrehospitalariumCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>EmrPrehospitalariumCollection</returns>
		public EmrPrehospitalariumCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                EmrPrehospitalarium o = this[i];
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
	/// This is an ActiveRecord class which wraps the EMR_Prehospitalaria table.
	/// </summary>
	[Serializable]
	public partial class EmrPrehospitalarium : ActiveRecord<EmrPrehospitalarium>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public EmrPrehospitalarium()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public EmrPrehospitalarium(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public EmrPrehospitalarium(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public EmrPrehospitalarium(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("EMR_Prehospitalaria", TableType.Table, DataService.GetInstance("RisProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarIdHCPrehospitalaria = new TableSchema.TableColumn(schema);
				colvarIdHCPrehospitalaria.ColumnName = "idHCPrehospitalaria";
				colvarIdHCPrehospitalaria.DataType = DbType.Int32;
				colvarIdHCPrehospitalaria.MaxLength = 0;
				colvarIdHCPrehospitalaria.AutoIncrement = true;
				colvarIdHCPrehospitalaria.IsNullable = false;
				colvarIdHCPrehospitalaria.IsPrimaryKey = true;
				colvarIdHCPrehospitalaria.IsForeignKey = false;
				colvarIdHCPrehospitalaria.IsReadOnly = false;
				colvarIdHCPrehospitalaria.DefaultSetting = @"";
				colvarIdHCPrehospitalaria.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdHCPrehospitalaria);
				
				TableSchema.TableColumn colvarNumeroAuxilio = new TableSchema.TableColumn(schema);
				colvarNumeroAuxilio.ColumnName = "numeroAuxilio";
				colvarNumeroAuxilio.DataType = DbType.AnsiString;
				colvarNumeroAuxilio.MaxLength = 50;
				colvarNumeroAuxilio.AutoIncrement = false;
				colvarNumeroAuxilio.IsNullable = false;
				colvarNumeroAuxilio.IsPrimaryKey = false;
				colvarNumeroAuxilio.IsForeignKey = false;
				colvarNumeroAuxilio.IsReadOnly = false;
				
						colvarNumeroAuxilio.DefaultSetting = @"((0))";
				colvarNumeroAuxilio.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNumeroAuxilio);
				
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
				
				TableSchema.TableColumn colvarHoraTrasmitido = new TableSchema.TableColumn(schema);
				colvarHoraTrasmitido.ColumnName = "horaTrasmitido";
				colvarHoraTrasmitido.DataType = DbType.AnsiStringFixedLength;
				colvarHoraTrasmitido.MaxLength = 5;
				colvarHoraTrasmitido.AutoIncrement = false;
				colvarHoraTrasmitido.IsNullable = false;
				colvarHoraTrasmitido.IsPrimaryKey = false;
				colvarHoraTrasmitido.IsForeignKey = false;
				colvarHoraTrasmitido.IsReadOnly = false;
				
						colvarHoraTrasmitido.DefaultSetting = @"('')";
				colvarHoraTrasmitido.ForeignKeyTableName = "";
				schema.Columns.Add(colvarHoraTrasmitido);
				
				TableSchema.TableColumn colvarMovil = new TableSchema.TableColumn(schema);
				colvarMovil.ColumnName = "movil";
				colvarMovil.DataType = DbType.AnsiStringFixedLength;
				colvarMovil.MaxLength = 10;
				colvarMovil.AutoIncrement = false;
				colvarMovil.IsNullable = false;
				colvarMovil.IsPrimaryKey = false;
				colvarMovil.IsForeignKey = false;
				colvarMovil.IsReadOnly = false;
				
						colvarMovil.DefaultSetting = @"('')";
				colvarMovil.ForeignKeyTableName = "";
				schema.Columns.Add(colvarMovil);
				
				TableSchema.TableColumn colvarIdBase = new TableSchema.TableColumn(schema);
				colvarIdBase.ColumnName = "idBase";
				colvarIdBase.DataType = DbType.Int32;
				colvarIdBase.MaxLength = 0;
				colvarIdBase.AutoIncrement = false;
				colvarIdBase.IsNullable = false;
				colvarIdBase.IsPrimaryKey = false;
				colvarIdBase.IsForeignKey = true;
				colvarIdBase.IsReadOnly = false;
				
						colvarIdBase.DefaultSetting = @"((0))";
				
					colvarIdBase.ForeignKeyTableName = "EMR_Base";
				schema.Columns.Add(colvarIdBase);
				
				TableSchema.TableColumn colvarHoraArribo = new TableSchema.TableColumn(schema);
				colvarHoraArribo.ColumnName = "horaArribo";
				colvarHoraArribo.DataType = DbType.AnsiStringFixedLength;
				colvarHoraArribo.MaxLength = 5;
				colvarHoraArribo.AutoIncrement = false;
				colvarHoraArribo.IsNullable = false;
				colvarHoraArribo.IsPrimaryKey = false;
				colvarHoraArribo.IsForeignKey = false;
				colvarHoraArribo.IsReadOnly = false;
				
						colvarHoraArribo.DefaultSetting = @"('')";
				colvarHoraArribo.ForeignKeyTableName = "";
				schema.Columns.Add(colvarHoraArribo);
				
				TableSchema.TableColumn colvarCodigoLlamado = new TableSchema.TableColumn(schema);
				colvarCodigoLlamado.ColumnName = "codigoLlamado";
				colvarCodigoLlamado.DataType = DbType.AnsiString;
				colvarCodigoLlamado.MaxLength = 50;
				colvarCodigoLlamado.AutoIncrement = false;
				colvarCodigoLlamado.IsNullable = false;
				colvarCodigoLlamado.IsPrimaryKey = false;
				colvarCodigoLlamado.IsForeignKey = false;
				colvarCodigoLlamado.IsReadOnly = false;
				
						colvarCodigoLlamado.DefaultSetting = @"('')";
				colvarCodigoLlamado.ForeignKeyTableName = "";
				schema.Columns.Add(colvarCodigoLlamado);
				
				TableSchema.TableColumn colvarTipoCodigo = new TableSchema.TableColumn(schema);
				colvarTipoCodigo.ColumnName = "tipoCodigo";
				colvarTipoCodigo.DataType = DbType.AnsiString;
				colvarTipoCodigo.MaxLength = 50;
				colvarTipoCodigo.AutoIncrement = false;
				colvarTipoCodigo.IsNullable = false;
				colvarTipoCodigo.IsPrimaryKey = false;
				colvarTipoCodigo.IsForeignKey = false;
				colvarTipoCodigo.IsReadOnly = false;
				
						colvarTipoCodigo.DefaultSetting = @"('')";
				colvarTipoCodigo.ForeignKeyTableName = "";
				schema.Columns.Add(colvarTipoCodigo);
				
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
				
				TableSchema.TableColumn colvarEdad = new TableSchema.TableColumn(schema);
				colvarEdad.ColumnName = "edad";
				colvarEdad.DataType = DbType.Int32;
				colvarEdad.MaxLength = 0;
				colvarEdad.AutoIncrement = false;
				colvarEdad.IsNullable = false;
				colvarEdad.IsPrimaryKey = false;
				colvarEdad.IsForeignKey = false;
				colvarEdad.IsReadOnly = false;
				
						colvarEdad.DefaultSetting = @"((0))";
				colvarEdad.ForeignKeyTableName = "";
				schema.Columns.Add(colvarEdad);
				
				TableSchema.TableColumn colvarIdObraSocial = new TableSchema.TableColumn(schema);
				colvarIdObraSocial.ColumnName = "idObraSocial";
				colvarIdObraSocial.DataType = DbType.Int32;
				colvarIdObraSocial.MaxLength = 0;
				colvarIdObraSocial.AutoIncrement = false;
				colvarIdObraSocial.IsNullable = false;
				colvarIdObraSocial.IsPrimaryKey = false;
				colvarIdObraSocial.IsForeignKey = true;
				colvarIdObraSocial.IsReadOnly = false;
				
						colvarIdObraSocial.DefaultSetting = @"((0))";
				
					colvarIdObraSocial.ForeignKeyTableName = "Sys_ObraSocial";
				schema.Columns.Add(colvarIdObraSocial);
				
				TableSchema.TableColumn colvarNumeroAfiliado = new TableSchema.TableColumn(schema);
				colvarNumeroAfiliado.ColumnName = "numeroAfiliado";
				colvarNumeroAfiliado.DataType = DbType.AnsiString;
				colvarNumeroAfiliado.MaxLength = 50;
				colvarNumeroAfiliado.AutoIncrement = false;
				colvarNumeroAfiliado.IsNullable = false;
				colvarNumeroAfiliado.IsPrimaryKey = false;
				colvarNumeroAfiliado.IsForeignKey = false;
				colvarNumeroAfiliado.IsReadOnly = false;
				
						colvarNumeroAfiliado.DefaultSetting = @"('')";
				colvarNumeroAfiliado.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNumeroAfiliado);
				
				TableSchema.TableColumn colvarOtraObraSocial = new TableSchema.TableColumn(schema);
				colvarOtraObraSocial.ColumnName = "otraObraSocial";
				colvarOtraObraSocial.DataType = DbType.AnsiString;
				colvarOtraObraSocial.MaxLength = 300;
				colvarOtraObraSocial.AutoIncrement = false;
				colvarOtraObraSocial.IsNullable = false;
				colvarOtraObraSocial.IsPrimaryKey = false;
				colvarOtraObraSocial.IsForeignKey = false;
				colvarOtraObraSocial.IsReadOnly = false;
				colvarOtraObraSocial.DefaultSetting = @"";
				colvarOtraObraSocial.ForeignKeyTableName = "";
				schema.Columns.Add(colvarOtraObraSocial);
				
				TableSchema.TableColumn colvarPatente = new TableSchema.TableColumn(schema);
				colvarPatente.ColumnName = "patente";
				colvarPatente.DataType = DbType.AnsiString;
				colvarPatente.MaxLength = 50;
				colvarPatente.AutoIncrement = false;
				colvarPatente.IsNullable = false;
				colvarPatente.IsPrimaryKey = false;
				colvarPatente.IsForeignKey = false;
				colvarPatente.IsReadOnly = false;
				
						colvarPatente.DefaultSetting = @"('')";
				colvarPatente.ForeignKeyTableName = "";
				schema.Columns.Add(colvarPatente);
				
				TableSchema.TableColumn colvarSeguro = new TableSchema.TableColumn(schema);
				colvarSeguro.ColumnName = "seguro";
				colvarSeguro.DataType = DbType.AnsiString;
				colvarSeguro.MaxLength = 50;
				colvarSeguro.AutoIncrement = false;
				colvarSeguro.IsNullable = false;
				colvarSeguro.IsPrimaryKey = false;
				colvarSeguro.IsForeignKey = false;
				colvarSeguro.IsReadOnly = false;
				
						colvarSeguro.DefaultSetting = @"('')";
				colvarSeguro.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSeguro);
				
				TableSchema.TableColumn colvarViaPublica = new TableSchema.TableColumn(schema);
				colvarViaPublica.ColumnName = "viaPublica";
				colvarViaPublica.DataType = DbType.AnsiString;
				colvarViaPublica.MaxLength = 200;
				colvarViaPublica.AutoIncrement = false;
				colvarViaPublica.IsNullable = false;
				colvarViaPublica.IsPrimaryKey = false;
				colvarViaPublica.IsForeignKey = false;
				colvarViaPublica.IsReadOnly = false;
				
						colvarViaPublica.DefaultSetting = @"('')";
				colvarViaPublica.ForeignKeyTableName = "";
				schema.Columns.Add(colvarViaPublica);
				
				TableSchema.TableColumn colvarDomicilio = new TableSchema.TableColumn(schema);
				colvarDomicilio.ColumnName = "domicilio";
				colvarDomicilio.DataType = DbType.AnsiString;
				colvarDomicilio.MaxLength = 200;
				colvarDomicilio.AutoIncrement = false;
				colvarDomicilio.IsNullable = false;
				colvarDomicilio.IsPrimaryKey = false;
				colvarDomicilio.IsForeignKey = false;
				colvarDomicilio.IsReadOnly = false;
				
						colvarDomicilio.DefaultSetting = @"('')";
				colvarDomicilio.ForeignKeyTableName = "";
				schema.Columns.Add(colvarDomicilio);
				
				TableSchema.TableColumn colvarTransito = new TableSchema.TableColumn(schema);
				colvarTransito.ColumnName = "transito";
				colvarTransito.DataType = DbType.Int32;
				colvarTransito.MaxLength = 0;
				colvarTransito.AutoIncrement = false;
				colvarTransito.IsNullable = false;
				colvarTransito.IsPrimaryKey = false;
				colvarTransito.IsForeignKey = false;
				colvarTransito.IsReadOnly = false;
				
						colvarTransito.DefaultSetting = @"((0))";
				colvarTransito.ForeignKeyTableName = "";
				schema.Columns.Add(colvarTransito);
				
				TableSchema.TableColumn colvarDerrumbe = new TableSchema.TableColumn(schema);
				colvarDerrumbe.ColumnName = "derrumbe";
				colvarDerrumbe.DataType = DbType.Int32;
				colvarDerrumbe.MaxLength = 0;
				colvarDerrumbe.AutoIncrement = false;
				colvarDerrumbe.IsNullable = false;
				colvarDerrumbe.IsPrimaryKey = false;
				colvarDerrumbe.IsForeignKey = false;
				colvarDerrumbe.IsReadOnly = false;
				
						colvarDerrumbe.DefaultSetting = @"((0))";
				colvarDerrumbe.ForeignKeyTableName = "";
				schema.Columns.Add(colvarDerrumbe);
				
				TableSchema.TableColumn colvarPrevension = new TableSchema.TableColumn(schema);
				colvarPrevension.ColumnName = "prevension";
				colvarPrevension.DataType = DbType.Int32;
				colvarPrevension.MaxLength = 0;
				colvarPrevension.AutoIncrement = false;
				colvarPrevension.IsNullable = false;
				colvarPrevension.IsPrimaryKey = false;
				colvarPrevension.IsForeignKey = false;
				colvarPrevension.IsReadOnly = false;
				
						colvarPrevension.DefaultSetting = @"((0))";
				colvarPrevension.ForeignKeyTableName = "";
				schema.Columns.Add(colvarPrevension);
				
				TableSchema.TableColumn colvarIncendio = new TableSchema.TableColumn(schema);
				colvarIncendio.ColumnName = "incendio";
				colvarIncendio.DataType = DbType.Int32;
				colvarIncendio.MaxLength = 0;
				colvarIncendio.AutoIncrement = false;
				colvarIncendio.IsNullable = false;
				colvarIncendio.IsPrimaryKey = false;
				colvarIncendio.IsForeignKey = false;
				colvarIncendio.IsReadOnly = false;
				
						colvarIncendio.DefaultSetting = @"((0))";
				colvarIncendio.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIncendio);
				
				TableSchema.TableColumn colvarExplosion = new TableSchema.TableColumn(schema);
				colvarExplosion.ColumnName = "explosion";
				colvarExplosion.DataType = DbType.Int32;
				colvarExplosion.MaxLength = 0;
				colvarExplosion.AutoIncrement = false;
				colvarExplosion.IsNullable = false;
				colvarExplosion.IsPrimaryKey = false;
				colvarExplosion.IsForeignKey = false;
				colvarExplosion.IsReadOnly = false;
				
						colvarExplosion.DefaultSetting = @"((0))";
				colvarExplosion.ForeignKeyTableName = "";
				schema.Columns.Add(colvarExplosion);
				
				TableSchema.TableColumn colvarViolenciaSocial = new TableSchema.TableColumn(schema);
				colvarViolenciaSocial.ColumnName = "violenciaSocial";
				colvarViolenciaSocial.DataType = DbType.Int32;
				colvarViolenciaSocial.MaxLength = 0;
				colvarViolenciaSocial.AutoIncrement = false;
				colvarViolenciaSocial.IsNullable = false;
				colvarViolenciaSocial.IsPrimaryKey = false;
				colvarViolenciaSocial.IsForeignKey = false;
				colvarViolenciaSocial.IsReadOnly = false;
				
						colvarViolenciaSocial.DefaultSetting = @"((0))";
				colvarViolenciaSocial.ForeignKeyTableName = "";
				schema.Columns.Add(colvarViolenciaSocial);
				
				TableSchema.TableColumn colvarTrauma = new TableSchema.TableColumn(schema);
				colvarTrauma.ColumnName = "trauma";
				colvarTrauma.DataType = DbType.Int32;
				colvarTrauma.MaxLength = 0;
				colvarTrauma.AutoIncrement = false;
				colvarTrauma.IsNullable = false;
				colvarTrauma.IsPrimaryKey = false;
				colvarTrauma.IsForeignKey = false;
				colvarTrauma.IsReadOnly = false;
				
						colvarTrauma.DefaultSetting = @"((0))";
				colvarTrauma.ForeignKeyTableName = "";
				schema.Columns.Add(colvarTrauma);
				
				TableSchema.TableColumn colvarMovilApoyo = new TableSchema.TableColumn(schema);
				colvarMovilApoyo.ColumnName = "movilApoyo";
				colvarMovilApoyo.DataType = DbType.Int32;
				colvarMovilApoyo.MaxLength = 0;
				colvarMovilApoyo.AutoIncrement = false;
				colvarMovilApoyo.IsNullable = false;
				colvarMovilApoyo.IsPrimaryKey = false;
				colvarMovilApoyo.IsForeignKey = false;
				colvarMovilApoyo.IsReadOnly = false;
				
						colvarMovilApoyo.DefaultSetting = @"((0))";
				colvarMovilApoyo.ForeignKeyTableName = "";
				schema.Columns.Add(colvarMovilApoyo);
				
				TableSchema.TableColumn colvarMovilApoyoCual = new TableSchema.TableColumn(schema);
				colvarMovilApoyoCual.ColumnName = "movilApoyoCual";
				colvarMovilApoyoCual.DataType = DbType.AnsiString;
				colvarMovilApoyoCual.MaxLength = 100;
				colvarMovilApoyoCual.AutoIncrement = false;
				colvarMovilApoyoCual.IsNullable = false;
				colvarMovilApoyoCual.IsPrimaryKey = false;
				colvarMovilApoyoCual.IsForeignKey = false;
				colvarMovilApoyoCual.IsReadOnly = false;
				
						colvarMovilApoyoCual.DefaultSetting = @"('')";
				colvarMovilApoyoCual.ForeignKeyTableName = "";
				schema.Columns.Add(colvarMovilApoyoCual);
				
				TableSchema.TableColumn colvarIntervencionPolicial = new TableSchema.TableColumn(schema);
				colvarIntervencionPolicial.ColumnName = "intervencionPolicial";
				colvarIntervencionPolicial.DataType = DbType.Int32;
				colvarIntervencionPolicial.MaxLength = 0;
				colvarIntervencionPolicial.AutoIncrement = false;
				colvarIntervencionPolicial.IsNullable = false;
				colvarIntervencionPolicial.IsPrimaryKey = false;
				colvarIntervencionPolicial.IsForeignKey = false;
				colvarIntervencionPolicial.IsReadOnly = false;
				
						colvarIntervencionPolicial.DefaultSetting = @"((0))";
				colvarIntervencionPolicial.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIntervencionPolicial);
				
				TableSchema.TableColumn colvarComisaria = new TableSchema.TableColumn(schema);
				colvarComisaria.ColumnName = "comisaria";
				colvarComisaria.DataType = DbType.AnsiString;
				colvarComisaria.MaxLength = 100;
				colvarComisaria.AutoIncrement = false;
				colvarComisaria.IsNullable = false;
				colvarComisaria.IsPrimaryKey = false;
				colvarComisaria.IsForeignKey = false;
				colvarComisaria.IsReadOnly = false;
				
						colvarComisaria.DefaultSetting = @"('')";
				colvarComisaria.ForeignKeyTableName = "";
				schema.Columns.Add(colvarComisaria);
				
				TableSchema.TableColumn colvarOficialComisaria = new TableSchema.TableColumn(schema);
				colvarOficialComisaria.ColumnName = "oficialComisaria";
				colvarOficialComisaria.DataType = DbType.AnsiString;
				colvarOficialComisaria.MaxLength = 100;
				colvarOficialComisaria.AutoIncrement = false;
				colvarOficialComisaria.IsNullable = false;
				colvarOficialComisaria.IsPrimaryKey = false;
				colvarOficialComisaria.IsForeignKey = false;
				colvarOficialComisaria.IsReadOnly = false;
				
						colvarOficialComisaria.DefaultSetting = @"('')";
				colvarOficialComisaria.ForeignKeyTableName = "";
				schema.Columns.Add(colvarOficialComisaria);
				
				TableSchema.TableColumn colvarIntervencionBomberos = new TableSchema.TableColumn(schema);
				colvarIntervencionBomberos.ColumnName = "intervencionBomberos";
				colvarIntervencionBomberos.DataType = DbType.Int32;
				colvarIntervencionBomberos.MaxLength = 0;
				colvarIntervencionBomberos.AutoIncrement = false;
				colvarIntervencionBomberos.IsNullable = false;
				colvarIntervencionBomberos.IsPrimaryKey = false;
				colvarIntervencionBomberos.IsForeignKey = false;
				colvarIntervencionBomberos.IsReadOnly = false;
				
						colvarIntervencionBomberos.DefaultSetting = @"((0))";
				colvarIntervencionBomberos.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIntervencionBomberos);
				
				TableSchema.TableColumn colvarCuartel = new TableSchema.TableColumn(schema);
				colvarCuartel.ColumnName = "cuartel";
				colvarCuartel.DataType = DbType.AnsiString;
				colvarCuartel.MaxLength = 100;
				colvarCuartel.AutoIncrement = false;
				colvarCuartel.IsNullable = false;
				colvarCuartel.IsPrimaryKey = false;
				colvarCuartel.IsForeignKey = false;
				colvarCuartel.IsReadOnly = false;
				
						colvarCuartel.DefaultSetting = @"('')";
				colvarCuartel.ForeignKeyTableName = "";
				schema.Columns.Add(colvarCuartel);
				
				TableSchema.TableColumn colvarOficialCuartel = new TableSchema.TableColumn(schema);
				colvarOficialCuartel.ColumnName = "oficialCuartel";
				colvarOficialCuartel.DataType = DbType.AnsiString;
				colvarOficialCuartel.MaxLength = 100;
				colvarOficialCuartel.AutoIncrement = false;
				colvarOficialCuartel.IsNullable = false;
				colvarOficialCuartel.IsPrimaryKey = false;
				colvarOficialCuartel.IsForeignKey = false;
				colvarOficialCuartel.IsReadOnly = false;
				
						colvarOficialCuartel.DefaultSetting = @"('')";
				colvarOficialCuartel.ForeignKeyTableName = "";
				schema.Columns.Add(colvarOficialCuartel);
				
				TableSchema.TableColumn colvarObservacionesIncidentes = new TableSchema.TableColumn(schema);
				colvarObservacionesIncidentes.ColumnName = "observacionesIncidentes";
				colvarObservacionesIncidentes.DataType = DbType.AnsiString;
				colvarObservacionesIncidentes.MaxLength = 300;
				colvarObservacionesIncidentes.AutoIncrement = false;
				colvarObservacionesIncidentes.IsNullable = false;
				colvarObservacionesIncidentes.IsPrimaryKey = false;
				colvarObservacionesIncidentes.IsForeignKey = false;
				colvarObservacionesIncidentes.IsReadOnly = false;
				
						colvarObservacionesIncidentes.DefaultSetting = @"('')";
				colvarObservacionesIncidentes.ForeignKeyTableName = "";
				schema.Columns.Add(colvarObservacionesIncidentes);
				
				TableSchema.TableColumn colvarNumeroMuertos = new TableSchema.TableColumn(schema);
				colvarNumeroMuertos.ColumnName = "numeroMuertos";
				colvarNumeroMuertos.DataType = DbType.Int32;
				colvarNumeroMuertos.MaxLength = 0;
				colvarNumeroMuertos.AutoIncrement = false;
				colvarNumeroMuertos.IsNullable = false;
				colvarNumeroMuertos.IsPrimaryKey = false;
				colvarNumeroMuertos.IsForeignKey = false;
				colvarNumeroMuertos.IsReadOnly = false;
				
						colvarNumeroMuertos.DefaultSetting = @"((0))";
				colvarNumeroMuertos.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNumeroMuertos);
				
				TableSchema.TableColumn colvarNumeroVehiculos = new TableSchema.TableColumn(schema);
				colvarNumeroVehiculos.ColumnName = "numeroVehiculos";
				colvarNumeroVehiculos.DataType = DbType.Int32;
				colvarNumeroVehiculos.MaxLength = 0;
				colvarNumeroVehiculos.AutoIncrement = false;
				colvarNumeroVehiculos.IsNullable = false;
				colvarNumeroVehiculos.IsPrimaryKey = false;
				colvarNumeroVehiculos.IsForeignKey = false;
				colvarNumeroVehiculos.IsReadOnly = false;
				
						colvarNumeroVehiculos.DefaultSetting = @"((0))";
				colvarNumeroVehiculos.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNumeroVehiculos);
				
				TableSchema.TableColumn colvarObservacionesMuertes = new TableSchema.TableColumn(schema);
				colvarObservacionesMuertes.ColumnName = "observacionesMuertes";
				colvarObservacionesMuertes.DataType = DbType.AnsiString;
				colvarObservacionesMuertes.MaxLength = 200;
				colvarObservacionesMuertes.AutoIncrement = false;
				colvarObservacionesMuertes.IsNullable = false;
				colvarObservacionesMuertes.IsPrimaryKey = false;
				colvarObservacionesMuertes.IsForeignKey = false;
				colvarObservacionesMuertes.IsReadOnly = false;
				
						colvarObservacionesMuertes.DefaultSetting = @"('')";
				colvarObservacionesMuertes.ForeignKeyTableName = "";
				schema.Columns.Add(colvarObservacionesMuertes);
				
				TableSchema.TableColumn colvarAmortiguadoPor = new TableSchema.TableColumn(schema);
				colvarAmortiguadoPor.ColumnName = "amortiguadoPor";
				colvarAmortiguadoPor.DataType = DbType.AnsiString;
				colvarAmortiguadoPor.MaxLength = 200;
				colvarAmortiguadoPor.AutoIncrement = false;
				colvarAmortiguadoPor.IsNullable = false;
				colvarAmortiguadoPor.IsPrimaryKey = false;
				colvarAmortiguadoPor.IsForeignKey = false;
				colvarAmortiguadoPor.IsReadOnly = false;
				
						colvarAmortiguadoPor.DefaultSetting = @"('')";
				colvarAmortiguadoPor.ForeignKeyTableName = "";
				schema.Columns.Add(colvarAmortiguadoPor);
				
				TableSchema.TableColumn colvarObservacionesTrauma = new TableSchema.TableColumn(schema);
				colvarObservacionesTrauma.ColumnName = "observacionesTrauma";
				colvarObservacionesTrauma.DataType = DbType.AnsiString;
				colvarObservacionesTrauma.MaxLength = 200;
				colvarObservacionesTrauma.AutoIncrement = false;
				colvarObservacionesTrauma.IsNullable = false;
				colvarObservacionesTrauma.IsPrimaryKey = false;
				colvarObservacionesTrauma.IsForeignKey = false;
				colvarObservacionesTrauma.IsReadOnly = false;
				
						colvarObservacionesTrauma.DefaultSetting = @"('')";
				colvarObservacionesTrauma.ForeignKeyTableName = "";
				schema.Columns.Add(colvarObservacionesTrauma);
				
				TableSchema.TableColumn colvarVictimasMultiples = new TableSchema.TableColumn(schema);
				colvarVictimasMultiples.ColumnName = "victimasMultiples";
				colvarVictimasMultiples.DataType = DbType.Int32;
				colvarVictimasMultiples.MaxLength = 0;
				colvarVictimasMultiples.AutoIncrement = false;
				colvarVictimasMultiples.IsNullable = false;
				colvarVictimasMultiples.IsPrimaryKey = false;
				colvarVictimasMultiples.IsForeignKey = false;
				colvarVictimasMultiples.IsReadOnly = false;
				
						colvarVictimasMultiples.DefaultSetting = @"((0))";
				colvarVictimasMultiples.ForeignKeyTableName = "";
				schema.Columns.Add(colvarVictimasMultiples);
				
				TableSchema.TableColumn colvarNumeroVictimas = new TableSchema.TableColumn(schema);
				colvarNumeroVictimas.ColumnName = "numeroVictimas";
				colvarNumeroVictimas.DataType = DbType.Int32;
				colvarNumeroVictimas.MaxLength = 0;
				colvarNumeroVictimas.AutoIncrement = false;
				colvarNumeroVictimas.IsNullable = false;
				colvarNumeroVictimas.IsPrimaryKey = false;
				colvarNumeroVictimas.IsForeignKey = false;
				colvarNumeroVictimas.IsReadOnly = false;
				
						colvarNumeroVictimas.DefaultSetting = @"((0))";
				colvarNumeroVictimas.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNumeroVictimas);
				
				TableSchema.TableColumn colvarFallecidoInSitu = new TableSchema.TableColumn(schema);
				colvarFallecidoInSitu.ColumnName = "fallecidoInSitu";
				colvarFallecidoInSitu.DataType = DbType.Boolean;
				colvarFallecidoInSitu.MaxLength = 0;
				colvarFallecidoInSitu.AutoIncrement = false;
				colvarFallecidoInSitu.IsNullable = false;
				colvarFallecidoInSitu.IsPrimaryKey = false;
				colvarFallecidoInSitu.IsForeignKey = false;
				colvarFallecidoInSitu.IsReadOnly = false;
				
						colvarFallecidoInSitu.DefaultSetting = @"((0))";
				colvarFallecidoInSitu.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFallecidoInSitu);
				
				TableSchema.TableColumn colvarFallecidoEnMovil = new TableSchema.TableColumn(schema);
				colvarFallecidoEnMovil.ColumnName = "fallecidoEnMovil";
				colvarFallecidoEnMovil.DataType = DbType.Boolean;
				colvarFallecidoEnMovil.MaxLength = 0;
				colvarFallecidoEnMovil.AutoIncrement = false;
				colvarFallecidoEnMovil.IsNullable = false;
				colvarFallecidoEnMovil.IsPrimaryKey = false;
				colvarFallecidoEnMovil.IsForeignKey = false;
				colvarFallecidoEnMovil.IsReadOnly = false;
				
						colvarFallecidoEnMovil.DefaultSetting = @"((0))";
				colvarFallecidoEnMovil.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFallecidoEnMovil);
				
				TableSchema.TableColumn colvarOtrasCausas = new TableSchema.TableColumn(schema);
				colvarOtrasCausas.ColumnName = "otrasCausas";
				colvarOtrasCausas.DataType = DbType.AnsiString;
				colvarOtrasCausas.MaxLength = 100;
				colvarOtrasCausas.AutoIncrement = false;
				colvarOtrasCausas.IsNullable = false;
				colvarOtrasCausas.IsPrimaryKey = false;
				colvarOtrasCausas.IsForeignKey = false;
				colvarOtrasCausas.IsReadOnly = false;
				
						colvarOtrasCausas.DefaultSetting = @"('')";
				colvarOtrasCausas.ForeignKeyTableName = "";
				schema.Columns.Add(colvarOtrasCausas);
				
				TableSchema.TableColumn colvarObservacionesCausas = new TableSchema.TableColumn(schema);
				colvarObservacionesCausas.ColumnName = "observacionesCausas";
				colvarObservacionesCausas.DataType = DbType.AnsiString;
				colvarObservacionesCausas.MaxLength = 200;
				colvarObservacionesCausas.AutoIncrement = false;
				colvarObservacionesCausas.IsNullable = false;
				colvarObservacionesCausas.IsPrimaryKey = false;
				colvarObservacionesCausas.IsForeignKey = false;
				colvarObservacionesCausas.IsReadOnly = false;
				
						colvarObservacionesCausas.DefaultSetting = @"('')";
				colvarObservacionesCausas.ForeignKeyTableName = "";
				schema.Columns.Add(colvarObservacionesCausas);
				
				TableSchema.TableColumn colvarActitud = new TableSchema.TableColumn(schema);
				colvarActitud.ColumnName = "actitud";
				colvarActitud.DataType = DbType.Int32;
				colvarActitud.MaxLength = 0;
				colvarActitud.AutoIncrement = false;
				colvarActitud.IsNullable = false;
				colvarActitud.IsPrimaryKey = false;
				colvarActitud.IsForeignKey = false;
				colvarActitud.IsReadOnly = false;
				
						colvarActitud.DefaultSetting = @"((0))";
				colvarActitud.ForeignKeyTableName = "";
				schema.Columns.Add(colvarActitud);
				
				TableSchema.TableColumn colvarFc = new TableSchema.TableColumn(schema);
				colvarFc.ColumnName = "FC";
				colvarFc.DataType = DbType.Int32;
				colvarFc.MaxLength = 0;
				colvarFc.AutoIncrement = false;
				colvarFc.IsNullable = false;
				colvarFc.IsPrimaryKey = false;
				colvarFc.IsForeignKey = false;
				colvarFc.IsReadOnly = false;
				
						colvarFc.DefaultSetting = @"((0))";
				colvarFc.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFc);
				
				TableSchema.TableColumn colvarFr = new TableSchema.TableColumn(schema);
				colvarFr.ColumnName = "FR";
				colvarFr.DataType = DbType.Int32;
				colvarFr.MaxLength = 0;
				colvarFr.AutoIncrement = false;
				colvarFr.IsNullable = false;
				colvarFr.IsPrimaryKey = false;
				colvarFr.IsForeignKey = false;
				colvarFr.IsReadOnly = false;
				
						colvarFr.DefaultSetting = @"((0))";
				colvarFr.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFr);
				
				TableSchema.TableColumn colvarSaturacion = new TableSchema.TableColumn(schema);
				colvarSaturacion.ColumnName = "saturacion";
				colvarSaturacion.DataType = DbType.Int32;
				colvarSaturacion.MaxLength = 0;
				colvarSaturacion.AutoIncrement = false;
				colvarSaturacion.IsNullable = false;
				colvarSaturacion.IsPrimaryKey = false;
				colvarSaturacion.IsForeignKey = false;
				colvarSaturacion.IsReadOnly = false;
				
						colvarSaturacion.DefaultSetting = @"((0))";
				colvarSaturacion.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSaturacion);
				
				TableSchema.TableColumn colvarRellenoCapilar = new TableSchema.TableColumn(schema);
				colvarRellenoCapilar.ColumnName = "rellenoCapilar";
				colvarRellenoCapilar.DataType = DbType.AnsiString;
				colvarRellenoCapilar.MaxLength = 50;
				colvarRellenoCapilar.AutoIncrement = false;
				colvarRellenoCapilar.IsNullable = false;
				colvarRellenoCapilar.IsPrimaryKey = false;
				colvarRellenoCapilar.IsForeignKey = false;
				colvarRellenoCapilar.IsReadOnly = false;
				
						colvarRellenoCapilar.DefaultSetting = @"((0))";
				colvarRellenoCapilar.ForeignKeyTableName = "";
				schema.Columns.Add(colvarRellenoCapilar);
				
				TableSchema.TableColumn colvarTensionArterialD = new TableSchema.TableColumn(schema);
				colvarTensionArterialD.ColumnName = "tensionArterialD";
				colvarTensionArterialD.DataType = DbType.Int32;
				colvarTensionArterialD.MaxLength = 0;
				colvarTensionArterialD.AutoIncrement = false;
				colvarTensionArterialD.IsNullable = false;
				colvarTensionArterialD.IsPrimaryKey = false;
				colvarTensionArterialD.IsForeignKey = false;
				colvarTensionArterialD.IsReadOnly = false;
				
						colvarTensionArterialD.DefaultSetting = @"((0))";
				colvarTensionArterialD.ForeignKeyTableName = "";
				schema.Columns.Add(colvarTensionArterialD);
				
				TableSchema.TableColumn colvarTensionArterialS = new TableSchema.TableColumn(schema);
				colvarTensionArterialS.ColumnName = "tensionArterialS";
				colvarTensionArterialS.DataType = DbType.Int32;
				colvarTensionArterialS.MaxLength = 0;
				colvarTensionArterialS.AutoIncrement = false;
				colvarTensionArterialS.IsNullable = false;
				colvarTensionArterialS.IsPrimaryKey = false;
				colvarTensionArterialS.IsForeignKey = false;
				colvarTensionArterialS.IsReadOnly = false;
				
						colvarTensionArterialS.DefaultSetting = @"((0))";
				colvarTensionArterialS.ForeignKeyTableName = "";
				schema.Columns.Add(colvarTensionArterialS);
				
				TableSchema.TableColumn colvarSignosVitales = new TableSchema.TableColumn(schema);
				colvarSignosVitales.ColumnName = "signosVitales";
				colvarSignosVitales.DataType = DbType.Int32;
				colvarSignosVitales.MaxLength = 0;
				colvarSignosVitales.AutoIncrement = false;
				colvarSignosVitales.IsNullable = false;
				colvarSignosVitales.IsPrimaryKey = false;
				colvarSignosVitales.IsForeignKey = false;
				colvarSignosVitales.IsReadOnly = false;
				
						colvarSignosVitales.DefaultSetting = @"((0))";
				colvarSignosVitales.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSignosVitales);
				
				TableSchema.TableColumn colvarRespiratorio = new TableSchema.TableColumn(schema);
				colvarRespiratorio.ColumnName = "respiratorio";
				colvarRespiratorio.DataType = DbType.Int32;
				colvarRespiratorio.MaxLength = 0;
				colvarRespiratorio.AutoIncrement = false;
				colvarRespiratorio.IsNullable = false;
				colvarRespiratorio.IsPrimaryKey = false;
				colvarRespiratorio.IsForeignKey = false;
				colvarRespiratorio.IsReadOnly = false;
				
						colvarRespiratorio.DefaultSetting = @"((0))";
				colvarRespiratorio.ForeignKeyTableName = "";
				schema.Columns.Add(colvarRespiratorio);
				
				TableSchema.TableColumn colvarAbdomen = new TableSchema.TableColumn(schema);
				colvarAbdomen.ColumnName = "abdomen";
				colvarAbdomen.DataType = DbType.Int32;
				colvarAbdomen.MaxLength = 0;
				colvarAbdomen.AutoIncrement = false;
				colvarAbdomen.IsNullable = false;
				colvarAbdomen.IsPrimaryKey = false;
				colvarAbdomen.IsForeignKey = false;
				colvarAbdomen.IsReadOnly = false;
				
						colvarAbdomen.DefaultSetting = @"((0))";
				colvarAbdomen.ForeignKeyTableName = "";
				schema.Columns.Add(colvarAbdomen);
				
				TableSchema.TableColumn colvarCirculatorios = new TableSchema.TableColumn(schema);
				colvarCirculatorios.ColumnName = "circulatorios";
				colvarCirculatorios.DataType = DbType.Int32;
				colvarCirculatorios.MaxLength = 0;
				colvarCirculatorios.AutoIncrement = false;
				colvarCirculatorios.IsNullable = false;
				colvarCirculatorios.IsPrimaryKey = false;
				colvarCirculatorios.IsForeignKey = false;
				colvarCirculatorios.IsReadOnly = false;
				
						colvarCirculatorios.DefaultSetting = @"((0))";
				colvarCirculatorios.ForeignKeyTableName = "";
				schema.Columns.Add(colvarCirculatorios);
				
				TableSchema.TableColumn colvarUrogenital = new TableSchema.TableColumn(schema);
				colvarUrogenital.ColumnName = "Urogenital";
				colvarUrogenital.DataType = DbType.Int32;
				colvarUrogenital.MaxLength = 0;
				colvarUrogenital.AutoIncrement = false;
				colvarUrogenital.IsNullable = false;
				colvarUrogenital.IsPrimaryKey = false;
				colvarUrogenital.IsForeignKey = false;
				colvarUrogenital.IsReadOnly = false;
				
						colvarUrogenital.DefaultSetting = @"((0))";
				colvarUrogenital.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUrogenital);
				
				TableSchema.TableColumn colvarPerdidaConocimiento = new TableSchema.TableColumn(schema);
				colvarPerdidaConocimiento.ColumnName = "perdidaConocimiento";
				colvarPerdidaConocimiento.DataType = DbType.Int32;
				colvarPerdidaConocimiento.MaxLength = 0;
				colvarPerdidaConocimiento.AutoIncrement = false;
				colvarPerdidaConocimiento.IsNullable = false;
				colvarPerdidaConocimiento.IsPrimaryKey = false;
				colvarPerdidaConocimiento.IsForeignKey = false;
				colvarPerdidaConocimiento.IsReadOnly = false;
				
						colvarPerdidaConocimiento.DefaultSetting = @"((0))";
				colvarPerdidaConocimiento.ForeignKeyTableName = "";
				schema.Columns.Add(colvarPerdidaConocimiento);
				
				TableSchema.TableColumn colvarIdGlasgowOcular = new TableSchema.TableColumn(schema);
				colvarIdGlasgowOcular.ColumnName = "idGlasgowOcular";
				colvarIdGlasgowOcular.DataType = DbType.Int32;
				colvarIdGlasgowOcular.MaxLength = 0;
				colvarIdGlasgowOcular.AutoIncrement = false;
				colvarIdGlasgowOcular.IsNullable = false;
				colvarIdGlasgowOcular.IsPrimaryKey = false;
				colvarIdGlasgowOcular.IsForeignKey = true;
				colvarIdGlasgowOcular.IsReadOnly = false;
				
						colvarIdGlasgowOcular.DefaultSetting = @"((0))";
				
					colvarIdGlasgowOcular.ForeignKeyTableName = "EMR_GlasgowOcular";
				schema.Columns.Add(colvarIdGlasgowOcular);
				
				TableSchema.TableColumn colvarIdGlasgowVerbal = new TableSchema.TableColumn(schema);
				colvarIdGlasgowVerbal.ColumnName = "idGlasgowVerbal";
				colvarIdGlasgowVerbal.DataType = DbType.Int32;
				colvarIdGlasgowVerbal.MaxLength = 0;
				colvarIdGlasgowVerbal.AutoIncrement = false;
				colvarIdGlasgowVerbal.IsNullable = false;
				colvarIdGlasgowVerbal.IsPrimaryKey = false;
				colvarIdGlasgowVerbal.IsForeignKey = true;
				colvarIdGlasgowVerbal.IsReadOnly = false;
				
						colvarIdGlasgowVerbal.DefaultSetting = @"((0))";
				
					colvarIdGlasgowVerbal.ForeignKeyTableName = "EMR_GlasgowVerbal";
				schema.Columns.Add(colvarIdGlasgowVerbal);
				
				TableSchema.TableColumn colvarIdGlasgowMotor = new TableSchema.TableColumn(schema);
				colvarIdGlasgowMotor.ColumnName = "idGlasgowMotor";
				colvarIdGlasgowMotor.DataType = DbType.Int32;
				colvarIdGlasgowMotor.MaxLength = 0;
				colvarIdGlasgowMotor.AutoIncrement = false;
				colvarIdGlasgowMotor.IsNullable = false;
				colvarIdGlasgowMotor.IsPrimaryKey = false;
				colvarIdGlasgowMotor.IsForeignKey = true;
				colvarIdGlasgowMotor.IsReadOnly = false;
				
						colvarIdGlasgowMotor.DefaultSetting = @"((0))";
				
					colvarIdGlasgowMotor.ForeignKeyTableName = "EMR_GlasgowMotor";
				schema.Columns.Add(colvarIdGlasgowMotor);
				
				TableSchema.TableColumn colvarValorGlasgow = new TableSchema.TableColumn(schema);
				colvarValorGlasgow.ColumnName = "valorGlasgow";
				colvarValorGlasgow.DataType = DbType.AnsiString;
				colvarValorGlasgow.MaxLength = 20;
				colvarValorGlasgow.AutoIncrement = false;
				colvarValorGlasgow.IsNullable = false;
				colvarValorGlasgow.IsPrimaryKey = false;
				colvarValorGlasgow.IsForeignKey = false;
				colvarValorGlasgow.IsReadOnly = false;
				
						colvarValorGlasgow.DefaultSetting = @"((0))";
				colvarValorGlasgow.ForeignKeyTableName = "";
				schema.Columns.Add(colvarValorGlasgow);
				
				TableSchema.TableColumn colvarIdPupilas = new TableSchema.TableColumn(schema);
				colvarIdPupilas.ColumnName = "idPupilas";
				colvarIdPupilas.DataType = DbType.Int32;
				colvarIdPupilas.MaxLength = 0;
				colvarIdPupilas.AutoIncrement = false;
				colvarIdPupilas.IsNullable = false;
				colvarIdPupilas.IsPrimaryKey = false;
				colvarIdPupilas.IsForeignKey = true;
				colvarIdPupilas.IsReadOnly = false;
				
						colvarIdPupilas.DefaultSetting = @"((0))";
				
					colvarIdPupilas.ForeignKeyTableName = "EMR_Pupilas";
				schema.Columns.Add(colvarIdPupilas);
				
				TableSchema.TableColumn colvarFocoMotor = new TableSchema.TableColumn(schema);
				colvarFocoMotor.ColumnName = "focoMotor";
				colvarFocoMotor.DataType = DbType.Int32;
				colvarFocoMotor.MaxLength = 0;
				colvarFocoMotor.AutoIncrement = false;
				colvarFocoMotor.IsNullable = false;
				colvarFocoMotor.IsPrimaryKey = false;
				colvarFocoMotor.IsForeignKey = false;
				colvarFocoMotor.IsReadOnly = false;
				
						colvarFocoMotor.DefaultSetting = @"((0))";
				colvarFocoMotor.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFocoMotor);
				
				TableSchema.TableColumn colvarParesia = new TableSchema.TableColumn(schema);
				colvarParesia.ColumnName = "paresia";
				colvarParesia.DataType = DbType.Int32;
				colvarParesia.MaxLength = 0;
				colvarParesia.AutoIncrement = false;
				colvarParesia.IsNullable = false;
				colvarParesia.IsPrimaryKey = false;
				colvarParesia.IsForeignKey = false;
				colvarParesia.IsReadOnly = false;
				
						colvarParesia.DefaultSetting = @"((0))";
				colvarParesia.ForeignKeyTableName = "";
				schema.Columns.Add(colvarParesia);
				
				TableSchema.TableColumn colvarPlejia = new TableSchema.TableColumn(schema);
				colvarPlejia.ColumnName = "plejia";
				colvarPlejia.DataType = DbType.Int32;
				colvarPlejia.MaxLength = 0;
				colvarPlejia.AutoIncrement = false;
				colvarPlejia.IsNullable = false;
				colvarPlejia.IsPrimaryKey = false;
				colvarPlejia.IsForeignKey = false;
				colvarPlejia.IsReadOnly = false;
				
						colvarPlejia.DefaultSetting = @"((0))";
				colvarPlejia.ForeignKeyTableName = "";
				schema.Columns.Add(colvarPlejia);
				
				TableSchema.TableColumn colvarLadoID = new TableSchema.TableColumn(schema);
				colvarLadoID.ColumnName = "ladoID";
				colvarLadoID.DataType = DbType.Int32;
				colvarLadoID.MaxLength = 0;
				colvarLadoID.AutoIncrement = false;
				colvarLadoID.IsNullable = false;
				colvarLadoID.IsPrimaryKey = false;
				colvarLadoID.IsForeignKey = false;
				colvarLadoID.IsReadOnly = false;
				
						colvarLadoID.DefaultSetting = @"((0))";
				colvarLadoID.ForeignKeyTableName = "";
				schema.Columns.Add(colvarLadoID);
				
				TableSchema.TableColumn colvarCabeza = new TableSchema.TableColumn(schema);
				colvarCabeza.ColumnName = "cabeza";
				colvarCabeza.DataType = DbType.Boolean;
				colvarCabeza.MaxLength = 0;
				colvarCabeza.AutoIncrement = false;
				colvarCabeza.IsNullable = false;
				colvarCabeza.IsPrimaryKey = false;
				colvarCabeza.IsForeignKey = false;
				colvarCabeza.IsReadOnly = false;
				
						colvarCabeza.DefaultSetting = @"((0))";
				colvarCabeza.ForeignKeyTableName = "";
				schema.Columns.Add(colvarCabeza);
				
				TableSchema.TableColumn colvarAxila = new TableSchema.TableColumn(schema);
				colvarAxila.ColumnName = "axila";
				colvarAxila.DataType = DbType.Boolean;
				colvarAxila.MaxLength = 0;
				colvarAxila.AutoIncrement = false;
				colvarAxila.IsNullable = false;
				colvarAxila.IsPrimaryKey = false;
				colvarAxila.IsForeignKey = false;
				colvarAxila.IsReadOnly = false;
				
						colvarAxila.DefaultSetting = @"((0))";
				colvarAxila.ForeignKeyTableName = "";
				schema.Columns.Add(colvarAxila);
				
				TableSchema.TableColumn colvarAmputacion = new TableSchema.TableColumn(schema);
				colvarAmputacion.ColumnName = "amputacion";
				colvarAmputacion.DataType = DbType.Boolean;
				colvarAmputacion.MaxLength = 0;
				colvarAmputacion.AutoIncrement = false;
				colvarAmputacion.IsNullable = false;
				colvarAmputacion.IsPrimaryKey = false;
				colvarAmputacion.IsForeignKey = false;
				colvarAmputacion.IsReadOnly = false;
				
						colvarAmputacion.DefaultSetting = @"((0))";
				colvarAmputacion.ForeignKeyTableName = "";
				schema.Columns.Add(colvarAmputacion);
				
				TableSchema.TableColumn colvarIngimal = new TableSchema.TableColumn(schema);
				colvarIngimal.ColumnName = "ingimal";
				colvarIngimal.DataType = DbType.Boolean;
				colvarIngimal.MaxLength = 0;
				colvarIngimal.AutoIncrement = false;
				colvarIngimal.IsNullable = false;
				colvarIngimal.IsPrimaryKey = false;
				colvarIngimal.IsForeignKey = false;
				colvarIngimal.IsReadOnly = false;
				
						colvarIngimal.DefaultSetting = @"((0))";
				colvarIngimal.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIngimal);
				
				TableSchema.TableColumn colvarCuello = new TableSchema.TableColumn(schema);
				colvarCuello.ColumnName = "cuello";
				colvarCuello.DataType = DbType.Boolean;
				colvarCuello.MaxLength = 0;
				colvarCuello.AutoIncrement = false;
				colvarCuello.IsNullable = false;
				colvarCuello.IsPrimaryKey = false;
				colvarCuello.IsForeignKey = false;
				colvarCuello.IsReadOnly = false;
				
						colvarCuello.DefaultSetting = @"((0))";
				colvarCuello.ForeignKeyTableName = "";
				schema.Columns.Add(colvarCuello);
				
				TableSchema.TableColumn colvarDorso = new TableSchema.TableColumn(schema);
				colvarDorso.ColumnName = "dorso";
				colvarDorso.DataType = DbType.Boolean;
				colvarDorso.MaxLength = 0;
				colvarDorso.AutoIncrement = false;
				colvarDorso.IsNullable = false;
				colvarDorso.IsPrimaryKey = false;
				colvarDorso.IsForeignKey = false;
				colvarDorso.IsReadOnly = false;
				
						colvarDorso.DefaultSetting = @"((0))";
				colvarDorso.ForeignKeyTableName = "";
				schema.Columns.Add(colvarDorso);
				
				TableSchema.TableColumn colvarTorax = new TableSchema.TableColumn(schema);
				colvarTorax.ColumnName = "torax";
				colvarTorax.DataType = DbType.Boolean;
				colvarTorax.MaxLength = 0;
				colvarTorax.AutoIncrement = false;
				colvarTorax.IsNullable = false;
				colvarTorax.IsPrimaryKey = false;
				colvarTorax.IsForeignKey = false;
				colvarTorax.IsReadOnly = false;
				
						colvarTorax.DefaultSetting = @"((0))";
				colvarTorax.ForeignKeyTableName = "";
				schema.Columns.Add(colvarTorax);
				
				TableSchema.TableColumn colvarMSuperior = new TableSchema.TableColumn(schema);
				colvarMSuperior.ColumnName = "mSuperior";
				colvarMSuperior.DataType = DbType.Boolean;
				colvarMSuperior.MaxLength = 0;
				colvarMSuperior.AutoIncrement = false;
				colvarMSuperior.IsNullable = false;
				colvarMSuperior.IsPrimaryKey = false;
				colvarMSuperior.IsForeignKey = false;
				colvarMSuperior.IsReadOnly = false;
				
						colvarMSuperior.DefaultSetting = @"((0))";
				colvarMSuperior.ForeignKeyTableName = "";
				schema.Columns.Add(colvarMSuperior);
				
				TableSchema.TableColumn colvarMInferior = new TableSchema.TableColumn(schema);
				colvarMInferior.ColumnName = "mInferior";
				colvarMInferior.DataType = DbType.Boolean;
				colvarMInferior.MaxLength = 0;
				colvarMInferior.AutoIncrement = false;
				colvarMInferior.IsNullable = false;
				colvarMInferior.IsPrimaryKey = false;
				colvarMInferior.IsForeignKey = false;
				colvarMInferior.IsReadOnly = false;
				
						colvarMInferior.DefaultSetting = @"((0))";
				colvarMInferior.ForeignKeyTableName = "";
				schema.Columns.Add(colvarMInferior);
				
				TableSchema.TableColumn colvarLesionesAbdomen = new TableSchema.TableColumn(schema);
				colvarLesionesAbdomen.ColumnName = "lesionesAbdomen";
				colvarLesionesAbdomen.DataType = DbType.Boolean;
				colvarLesionesAbdomen.MaxLength = 0;
				colvarLesionesAbdomen.AutoIncrement = false;
				colvarLesionesAbdomen.IsNullable = false;
				colvarLesionesAbdomen.IsPrimaryKey = false;
				colvarLesionesAbdomen.IsForeignKey = false;
				colvarLesionesAbdomen.IsReadOnly = false;
				
						colvarLesionesAbdomen.DefaultSetting = @"((0))";
				colvarLesionesAbdomen.ForeignKeyTableName = "";
				schema.Columns.Add(colvarLesionesAbdomen);
				
				TableSchema.TableColumn colvarOtrasLesiones = new TableSchema.TableColumn(schema);
				colvarOtrasLesiones.ColumnName = "otrasLesiones";
				colvarOtrasLesiones.DataType = DbType.AnsiString;
				colvarOtrasLesiones.MaxLength = 200;
				colvarOtrasLesiones.AutoIncrement = false;
				colvarOtrasLesiones.IsNullable = false;
				colvarOtrasLesiones.IsPrimaryKey = false;
				colvarOtrasLesiones.IsForeignKey = false;
				colvarOtrasLesiones.IsReadOnly = false;
				
						colvarOtrasLesiones.DefaultSetting = @"('')";
				colvarOtrasLesiones.ForeignKeyTableName = "";
				schema.Columns.Add(colvarOtrasLesiones);
				
				TableSchema.TableColumn colvarTipoQuemadura = new TableSchema.TableColumn(schema);
				colvarTipoQuemadura.ColumnName = "tipoQuemadura";
				colvarTipoQuemadura.DataType = DbType.AnsiString;
				colvarTipoQuemadura.MaxLength = 100;
				colvarTipoQuemadura.AutoIncrement = false;
				colvarTipoQuemadura.IsNullable = false;
				colvarTipoQuemadura.IsPrimaryKey = false;
				colvarTipoQuemadura.IsForeignKey = false;
				colvarTipoQuemadura.IsReadOnly = false;
				
						colvarTipoQuemadura.DefaultSetting = @"('')";
				colvarTipoQuemadura.ForeignKeyTableName = "";
				schema.Columns.Add(colvarTipoQuemadura);
				
				TableSchema.TableColumn colvarPorcentajeQuemadura = new TableSchema.TableColumn(schema);
				colvarPorcentajeQuemadura.ColumnName = "porcentajeQuemadura";
				colvarPorcentajeQuemadura.DataType = DbType.AnsiString;
				colvarPorcentajeQuemadura.MaxLength = 50;
				colvarPorcentajeQuemadura.AutoIncrement = false;
				colvarPorcentajeQuemadura.IsNullable = false;
				colvarPorcentajeQuemadura.IsPrimaryKey = false;
				colvarPorcentajeQuemadura.IsForeignKey = false;
				colvarPorcentajeQuemadura.IsReadOnly = false;
				
						colvarPorcentajeQuemadura.DefaultSetting = @"('')";
				colvarPorcentajeQuemadura.ForeignKeyTableName = "";
				schema.Columns.Add(colvarPorcentajeQuemadura);
				
				TableSchema.TableColumn colvarDiagnosticoPresuntivo = new TableSchema.TableColumn(schema);
				colvarDiagnosticoPresuntivo.ColumnName = "diagnosticoPresuntivo";
				colvarDiagnosticoPresuntivo.DataType = DbType.AnsiString;
				colvarDiagnosticoPresuntivo.MaxLength = 200;
				colvarDiagnosticoPresuntivo.AutoIncrement = false;
				colvarDiagnosticoPresuntivo.IsNullable = false;
				colvarDiagnosticoPresuntivo.IsPrimaryKey = false;
				colvarDiagnosticoPresuntivo.IsForeignKey = false;
				colvarDiagnosticoPresuntivo.IsReadOnly = false;
				
						colvarDiagnosticoPresuntivo.DefaultSetting = @"('')";
				colvarDiagnosticoPresuntivo.ForeignKeyTableName = "";
				schema.Columns.Add(colvarDiagnosticoPresuntivo);
				
				TableSchema.TableColumn colvarIdCODCie10 = new TableSchema.TableColumn(schema);
				colvarIdCODCie10.ColumnName = "idCODCie10";
				colvarIdCODCie10.DataType = DbType.Int32;
				colvarIdCODCie10.MaxLength = 0;
				colvarIdCODCie10.AutoIncrement = false;
				colvarIdCODCie10.IsNullable = false;
				colvarIdCODCie10.IsPrimaryKey = false;
				colvarIdCODCie10.IsForeignKey = true;
				colvarIdCODCie10.IsReadOnly = false;
				
						colvarIdCODCie10.DefaultSetting = @"((0))";
				
					colvarIdCODCie10.ForeignKeyTableName = "Sys_CIE10";
				schema.Columns.Add(colvarIdCODCie10);
				
				TableSchema.TableColumn colvarProcedimiento = new TableSchema.TableColumn(schema);
				colvarProcedimiento.ColumnName = "procedimiento";
				colvarProcedimiento.DataType = DbType.AnsiString;
				colvarProcedimiento.MaxLength = 300;
				colvarProcedimiento.AutoIncrement = false;
				colvarProcedimiento.IsNullable = false;
				colvarProcedimiento.IsPrimaryKey = false;
				colvarProcedimiento.IsForeignKey = false;
				colvarProcedimiento.IsReadOnly = false;
				
						colvarProcedimiento.DefaultSetting = @"('')";
				colvarProcedimiento.ForeignKeyTableName = "";
				schema.Columns.Add(colvarProcedimiento);
				
				TableSchema.TableColumn colvarTratamiento = new TableSchema.TableColumn(schema);
				colvarTratamiento.ColumnName = "tratamiento";
				colvarTratamiento.DataType = DbType.AnsiString;
				colvarTratamiento.MaxLength = 200;
				colvarTratamiento.AutoIncrement = false;
				colvarTratamiento.IsNullable = false;
				colvarTratamiento.IsPrimaryKey = false;
				colvarTratamiento.IsForeignKey = false;
				colvarTratamiento.IsReadOnly = false;
				
						colvarTratamiento.DefaultSetting = @"('')";
				colvarTratamiento.ForeignKeyTableName = "";
				schema.Columns.Add(colvarTratamiento);
				
				TableSchema.TableColumn colvarAntecedentesPersonales = new TableSchema.TableColumn(schema);
				colvarAntecedentesPersonales.ColumnName = "antecedentesPersonales";
				colvarAntecedentesPersonales.DataType = DbType.Int32;
				colvarAntecedentesPersonales.MaxLength = 0;
				colvarAntecedentesPersonales.AutoIncrement = false;
				colvarAntecedentesPersonales.IsNullable = false;
				colvarAntecedentesPersonales.IsPrimaryKey = false;
				colvarAntecedentesPersonales.IsForeignKey = false;
				colvarAntecedentesPersonales.IsReadOnly = false;
				
						colvarAntecedentesPersonales.DefaultSetting = @"((0))";
				colvarAntecedentesPersonales.ForeignKeyTableName = "";
				schema.Columns.Add(colvarAntecedentesPersonales);
				
				TableSchema.TableColumn colvarCategorizacionFinal = new TableSchema.TableColumn(schema);
				colvarCategorizacionFinal.ColumnName = "categorizacionFinal";
				colvarCategorizacionFinal.DataType = DbType.Int32;
				colvarCategorizacionFinal.MaxLength = 0;
				colvarCategorizacionFinal.AutoIncrement = false;
				colvarCategorizacionFinal.IsNullable = false;
				colvarCategorizacionFinal.IsPrimaryKey = false;
				colvarCategorizacionFinal.IsForeignKey = false;
				colvarCategorizacionFinal.IsReadOnly = false;
				
						colvarCategorizacionFinal.DefaultSetting = @"((0))";
				colvarCategorizacionFinal.ForeignKeyTableName = "";
				schema.Columns.Add(colvarCategorizacionFinal);
				
				TableSchema.TableColumn colvarDestino = new TableSchema.TableColumn(schema);
				colvarDestino.ColumnName = "destino";
				colvarDestino.DataType = DbType.Int32;
				colvarDestino.MaxLength = 0;
				colvarDestino.AutoIncrement = false;
				colvarDestino.IsNullable = false;
				colvarDestino.IsPrimaryKey = false;
				colvarDestino.IsForeignKey = false;
				colvarDestino.IsReadOnly = false;
				
						colvarDestino.DefaultSetting = @"((0))";
				colvarDestino.ForeignKeyTableName = "";
				schema.Columns.Add(colvarDestino);
				
				TableSchema.TableColumn colvarTrasladado = new TableSchema.TableColumn(schema);
				colvarTrasladado.ColumnName = "trasladado";
				colvarTrasladado.DataType = DbType.Int32;
				colvarTrasladado.MaxLength = 0;
				colvarTrasladado.AutoIncrement = false;
				colvarTrasladado.IsNullable = false;
				colvarTrasladado.IsPrimaryKey = false;
				colvarTrasladado.IsForeignKey = false;
				colvarTrasladado.IsReadOnly = false;
				
						colvarTrasladado.DefaultSetting = @"((0))";
				colvarTrasladado.ForeignKeyTableName = "";
				schema.Columns.Add(colvarTrasladado);
				
				TableSchema.TableColumn colvarIdEfector = new TableSchema.TableColumn(schema);
				colvarIdEfector.ColumnName = "idEfector";
				colvarIdEfector.DataType = DbType.Int32;
				colvarIdEfector.MaxLength = 0;
				colvarIdEfector.AutoIncrement = false;
				colvarIdEfector.IsNullable = false;
				colvarIdEfector.IsPrimaryKey = false;
				colvarIdEfector.IsForeignKey = true;
				colvarIdEfector.IsReadOnly = false;
				
						colvarIdEfector.DefaultSetting = @"((0))";
				
					colvarIdEfector.ForeignKeyTableName = "Sys_Efector";
				schema.Columns.Add(colvarIdEfector);
				
				TableSchema.TableColumn colvarSanatorio = new TableSchema.TableColumn(schema);
				colvarSanatorio.ColumnName = "sanatorio";
				colvarSanatorio.DataType = DbType.AnsiString;
				colvarSanatorio.MaxLength = 200;
				colvarSanatorio.AutoIncrement = false;
				colvarSanatorio.IsNullable = false;
				colvarSanatorio.IsPrimaryKey = false;
				colvarSanatorio.IsForeignKey = false;
				colvarSanatorio.IsReadOnly = false;
				
						colvarSanatorio.DefaultSetting = @"('')";
				colvarSanatorio.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSanatorio);
				
				TableSchema.TableColumn colvarTrasladadoMovil = new TableSchema.TableColumn(schema);
				colvarTrasladadoMovil.ColumnName = "trasladadoMovil";
				colvarTrasladadoMovil.DataType = DbType.AnsiString;
				colvarTrasladadoMovil.MaxLength = 100;
				colvarTrasladadoMovil.AutoIncrement = false;
				colvarTrasladadoMovil.IsNullable = false;
				colvarTrasladadoMovil.IsPrimaryKey = false;
				colvarTrasladadoMovil.IsForeignKey = false;
				colvarTrasladadoMovil.IsReadOnly = false;
				
						colvarTrasladadoMovil.DefaultSetting = @"('')";
				colvarTrasladadoMovil.ForeignKeyTableName = "";
				schema.Columns.Add(colvarTrasladadoMovil);
				
				TableSchema.TableColumn colvarFirmaAfirmativa = new TableSchema.TableColumn(schema);
				colvarFirmaAfirmativa.ColumnName = "firmaAfirmativa";
				colvarFirmaAfirmativa.DataType = DbType.Boolean;
				colvarFirmaAfirmativa.MaxLength = 0;
				colvarFirmaAfirmativa.AutoIncrement = false;
				colvarFirmaAfirmativa.IsNullable = false;
				colvarFirmaAfirmativa.IsPrimaryKey = false;
				colvarFirmaAfirmativa.IsForeignKey = false;
				colvarFirmaAfirmativa.IsReadOnly = false;
				
						colvarFirmaAfirmativa.DefaultSetting = @"((0))";
				colvarFirmaAfirmativa.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFirmaAfirmativa);
				
				TableSchema.TableColumn colvarFirmaNegativa = new TableSchema.TableColumn(schema);
				colvarFirmaNegativa.ColumnName = "firmaNegativa";
				colvarFirmaNegativa.DataType = DbType.Boolean;
				colvarFirmaNegativa.MaxLength = 0;
				colvarFirmaNegativa.AutoIncrement = false;
				colvarFirmaNegativa.IsNullable = false;
				colvarFirmaNegativa.IsPrimaryKey = false;
				colvarFirmaNegativa.IsForeignKey = false;
				colvarFirmaNegativa.IsReadOnly = false;
				
						colvarFirmaNegativa.DefaultSetting = @"((0))";
				colvarFirmaNegativa.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFirmaNegativa);
				
				TableSchema.TableColumn colvarOtroGlasgow = new TableSchema.TableColumn(schema);
				colvarOtroGlasgow.ColumnName = "otroGlasgow";
				colvarOtroGlasgow.DataType = DbType.AnsiString;
				colvarOtroGlasgow.MaxLength = 50;
				colvarOtroGlasgow.AutoIncrement = false;
				colvarOtroGlasgow.IsNullable = false;
				colvarOtroGlasgow.IsPrimaryKey = false;
				colvarOtroGlasgow.IsForeignKey = false;
				colvarOtroGlasgow.IsReadOnly = false;
				
						colvarOtroGlasgow.DefaultSetting = @"('')";
				colvarOtroGlasgow.ForeignKeyTableName = "";
				schema.Columns.Add(colvarOtroGlasgow);
				
				TableSchema.TableColumn colvarOtrosAntecedentes = new TableSchema.TableColumn(schema);
				colvarOtrosAntecedentes.ColumnName = "otrosAntecedentes";
				colvarOtrosAntecedentes.DataType = DbType.AnsiString;
				colvarOtrosAntecedentes.MaxLength = 200;
				colvarOtrosAntecedentes.AutoIncrement = false;
				colvarOtrosAntecedentes.IsNullable = false;
				colvarOtrosAntecedentes.IsPrimaryKey = false;
				colvarOtrosAntecedentes.IsForeignKey = false;
				colvarOtrosAntecedentes.IsReadOnly = false;
				
						colvarOtrosAntecedentes.DefaultSetting = @"('')";
				colvarOtrosAntecedentes.ForeignKeyTableName = "";
				schema.Columns.Add(colvarOtrosAntecedentes);
				
				TableSchema.TableColumn colvarOtroDiagnostico = new TableSchema.TableColumn(schema);
				colvarOtroDiagnostico.ColumnName = "otroDiagnostico";
				colvarOtroDiagnostico.DataType = DbType.AnsiString;
				colvarOtroDiagnostico.MaxLength = 1000;
				colvarOtroDiagnostico.AutoIncrement = false;
				colvarOtroDiagnostico.IsNullable = false;
				colvarOtroDiagnostico.IsPrimaryKey = false;
				colvarOtroDiagnostico.IsForeignKey = false;
				colvarOtroDiagnostico.IsReadOnly = false;
				
						colvarOtroDiagnostico.DefaultSetting = @"('')";
				colvarOtroDiagnostico.ForeignKeyTableName = "";
				schema.Columns.Add(colvarOtroDiagnostico);
				
				TableSchema.TableColumn colvarAntecedenteDiabetes = new TableSchema.TableColumn(schema);
				colvarAntecedenteDiabetes.ColumnName = "antecedenteDiabetes";
				colvarAntecedenteDiabetes.DataType = DbType.Boolean;
				colvarAntecedenteDiabetes.MaxLength = 0;
				colvarAntecedenteDiabetes.AutoIncrement = false;
				colvarAntecedenteDiabetes.IsNullable = false;
				colvarAntecedenteDiabetes.IsPrimaryKey = false;
				colvarAntecedenteDiabetes.IsForeignKey = false;
				colvarAntecedenteDiabetes.IsReadOnly = false;
				
						colvarAntecedenteDiabetes.DefaultSetting = @"((0))";
				colvarAntecedenteDiabetes.ForeignKeyTableName = "";
				schema.Columns.Add(colvarAntecedenteDiabetes);
				
				TableSchema.TableColumn colvarIdProfesional = new TableSchema.TableColumn(schema);
				colvarIdProfesional.ColumnName = "idProfesional";
				colvarIdProfesional.DataType = DbType.Int32;
				colvarIdProfesional.MaxLength = 0;
				colvarIdProfesional.AutoIncrement = false;
				colvarIdProfesional.IsNullable = false;
				colvarIdProfesional.IsPrimaryKey = false;
				colvarIdProfesional.IsForeignKey = true;
				colvarIdProfesional.IsReadOnly = false;
				
						colvarIdProfesional.DefaultSetting = @"((0))";
				
					colvarIdProfesional.ForeignKeyTableName = "Sys_Profesional";
				schema.Columns.Add(colvarIdProfesional);
				
				TableSchema.TableColumn colvarIdProfesionalRecibe = new TableSchema.TableColumn(schema);
				colvarIdProfesionalRecibe.ColumnName = "idProfesionalRecibe";
				colvarIdProfesionalRecibe.DataType = DbType.Int32;
				colvarIdProfesionalRecibe.MaxLength = 0;
				colvarIdProfesionalRecibe.AutoIncrement = false;
				colvarIdProfesionalRecibe.IsNullable = false;
				colvarIdProfesionalRecibe.IsPrimaryKey = false;
				colvarIdProfesionalRecibe.IsForeignKey = true;
				colvarIdProfesionalRecibe.IsReadOnly = false;
				
						colvarIdProfesionalRecibe.DefaultSetting = @"((0))";
				
					colvarIdProfesionalRecibe.ForeignKeyTableName = "Sys_Profesional";
				schema.Columns.Add(colvarIdProfesionalRecibe);
				
				TableSchema.TableColumn colvarEnfermero = new TableSchema.TableColumn(schema);
				colvarEnfermero.ColumnName = "enfermero";
				colvarEnfermero.DataType = DbType.AnsiString;
				colvarEnfermero.MaxLength = 200;
				colvarEnfermero.AutoIncrement = false;
				colvarEnfermero.IsNullable = false;
				colvarEnfermero.IsPrimaryKey = false;
				colvarEnfermero.IsForeignKey = false;
				colvarEnfermero.IsReadOnly = false;
				
						colvarEnfermero.DefaultSetting = @"('')";
				colvarEnfermero.ForeignKeyTableName = "";
				schema.Columns.Add(colvarEnfermero);
				
				TableSchema.TableColumn colvarActiva = new TableSchema.TableColumn(schema);
				colvarActiva.ColumnName = "activa";
				colvarActiva.DataType = DbType.Boolean;
				colvarActiva.MaxLength = 0;
				colvarActiva.AutoIncrement = false;
				colvarActiva.IsNullable = false;
				colvarActiva.IsPrimaryKey = false;
				colvarActiva.IsForeignKey = false;
				colvarActiva.IsReadOnly = false;
				
						colvarActiva.DefaultSetting = @"((1))";
				colvarActiva.ForeignKeyTableName = "";
				schema.Columns.Add(colvarActiva);
				
				TableSchema.TableColumn colvarCreatedBy = new TableSchema.TableColumn(schema);
				colvarCreatedBy.ColumnName = "CreatedBy";
				colvarCreatedBy.DataType = DbType.AnsiString;
				colvarCreatedBy.MaxLength = 50;
				colvarCreatedBy.AutoIncrement = false;
				colvarCreatedBy.IsNullable = false;
				colvarCreatedBy.IsPrimaryKey = false;
				colvarCreatedBy.IsForeignKey = false;
				colvarCreatedBy.IsReadOnly = false;
				
						colvarCreatedBy.DefaultSetting = @"('')";
				colvarCreatedBy.ForeignKeyTableName = "";
				schema.Columns.Add(colvarCreatedBy);
				
				TableSchema.TableColumn colvarCreatedOn = new TableSchema.TableColumn(schema);
				colvarCreatedOn.ColumnName = "CreatedOn";
				colvarCreatedOn.DataType = DbType.DateTime;
				colvarCreatedOn.MaxLength = 0;
				colvarCreatedOn.AutoIncrement = false;
				colvarCreatedOn.IsNullable = false;
				colvarCreatedOn.IsPrimaryKey = false;
				colvarCreatedOn.IsForeignKey = false;
				colvarCreatedOn.IsReadOnly = false;
				
						colvarCreatedOn.DefaultSetting = @"(((1)/(1))/(1900))";
				colvarCreatedOn.ForeignKeyTableName = "";
				schema.Columns.Add(colvarCreatedOn);
				
				TableSchema.TableColumn colvarModifiedBy = new TableSchema.TableColumn(schema);
				colvarModifiedBy.ColumnName = "ModifiedBy";
				colvarModifiedBy.DataType = DbType.AnsiString;
				colvarModifiedBy.MaxLength = 50;
				colvarModifiedBy.AutoIncrement = false;
				colvarModifiedBy.IsNullable = false;
				colvarModifiedBy.IsPrimaryKey = false;
				colvarModifiedBy.IsForeignKey = false;
				colvarModifiedBy.IsReadOnly = false;
				
						colvarModifiedBy.DefaultSetting = @"('')";
				colvarModifiedBy.ForeignKeyTableName = "";
				schema.Columns.Add(colvarModifiedBy);
				
				TableSchema.TableColumn colvarModifiedOn = new TableSchema.TableColumn(schema);
				colvarModifiedOn.ColumnName = "ModifiedOn";
				colvarModifiedOn.DataType = DbType.DateTime;
				colvarModifiedOn.MaxLength = 0;
				colvarModifiedOn.AutoIncrement = false;
				colvarModifiedOn.IsNullable = false;
				colvarModifiedOn.IsPrimaryKey = false;
				colvarModifiedOn.IsForeignKey = false;
				colvarModifiedOn.IsReadOnly = false;
				
						colvarModifiedOn.DefaultSetting = @"(((1)/(1))/(1900))";
				colvarModifiedOn.ForeignKeyTableName = "";
				schema.Columns.Add(colvarModifiedOn);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["RisProvider"].AddSchema("EMR_Prehospitalaria",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("IdHCPrehospitalaria")]
		[Bindable(true)]
		public int IdHCPrehospitalaria 
		{
			get { return GetColumnValue<int>(Columns.IdHCPrehospitalaria); }
			set { SetColumnValue(Columns.IdHCPrehospitalaria, value); }
		}
		  
		[XmlAttribute("NumeroAuxilio")]
		[Bindable(true)]
		public string NumeroAuxilio 
		{
			get { return GetColumnValue<string>(Columns.NumeroAuxilio); }
			set { SetColumnValue(Columns.NumeroAuxilio, value); }
		}
		  
		[XmlAttribute("Fecha")]
		[Bindable(true)]
		public DateTime Fecha 
		{
			get { return GetColumnValue<DateTime>(Columns.Fecha); }
			set { SetColumnValue(Columns.Fecha, value); }
		}
		  
		[XmlAttribute("HoraTrasmitido")]
		[Bindable(true)]
		public string HoraTrasmitido 
		{
			get { return GetColumnValue<string>(Columns.HoraTrasmitido); }
			set { SetColumnValue(Columns.HoraTrasmitido, value); }
		}
		  
		[XmlAttribute("Movil")]
		[Bindable(true)]
		public string Movil 
		{
			get { return GetColumnValue<string>(Columns.Movil); }
			set { SetColumnValue(Columns.Movil, value); }
		}
		  
		[XmlAttribute("IdBase")]
		[Bindable(true)]
		public int IdBase 
		{
			get { return GetColumnValue<int>(Columns.IdBase); }
			set { SetColumnValue(Columns.IdBase, value); }
		}
		  
		[XmlAttribute("HoraArribo")]
		[Bindable(true)]
		public string HoraArribo 
		{
			get { return GetColumnValue<string>(Columns.HoraArribo); }
			set { SetColumnValue(Columns.HoraArribo, value); }
		}
		  
		[XmlAttribute("CodigoLlamado")]
		[Bindable(true)]
		public string CodigoLlamado 
		{
			get { return GetColumnValue<string>(Columns.CodigoLlamado); }
			set { SetColumnValue(Columns.CodigoLlamado, value); }
		}
		  
		[XmlAttribute("TipoCodigo")]
		[Bindable(true)]
		public string TipoCodigo 
		{
			get { return GetColumnValue<string>(Columns.TipoCodigo); }
			set { SetColumnValue(Columns.TipoCodigo, value); }
		}
		  
		[XmlAttribute("IdPaciente")]
		[Bindable(true)]
		public int IdPaciente 
		{
			get { return GetColumnValue<int>(Columns.IdPaciente); }
			set { SetColumnValue(Columns.IdPaciente, value); }
		}
		  
		[XmlAttribute("Edad")]
		[Bindable(true)]
		public int Edad 
		{
			get { return GetColumnValue<int>(Columns.Edad); }
			set { SetColumnValue(Columns.Edad, value); }
		}
		  
		[XmlAttribute("IdObraSocial")]
		[Bindable(true)]
		public int IdObraSocial 
		{
			get { return GetColumnValue<int>(Columns.IdObraSocial); }
			set { SetColumnValue(Columns.IdObraSocial, value); }
		}
		  
		[XmlAttribute("NumeroAfiliado")]
		[Bindable(true)]
		public string NumeroAfiliado 
		{
			get { return GetColumnValue<string>(Columns.NumeroAfiliado); }
			set { SetColumnValue(Columns.NumeroAfiliado, value); }
		}
		  
		[XmlAttribute("OtraObraSocial")]
		[Bindable(true)]
		public string OtraObraSocial 
		{
			get { return GetColumnValue<string>(Columns.OtraObraSocial); }
			set { SetColumnValue(Columns.OtraObraSocial, value); }
		}
		  
		[XmlAttribute("Patente")]
		[Bindable(true)]
		public string Patente 
		{
			get { return GetColumnValue<string>(Columns.Patente); }
			set { SetColumnValue(Columns.Patente, value); }
		}
		  
		[XmlAttribute("Seguro")]
		[Bindable(true)]
		public string Seguro 
		{
			get { return GetColumnValue<string>(Columns.Seguro); }
			set { SetColumnValue(Columns.Seguro, value); }
		}
		  
		[XmlAttribute("ViaPublica")]
		[Bindable(true)]
		public string ViaPublica 
		{
			get { return GetColumnValue<string>(Columns.ViaPublica); }
			set { SetColumnValue(Columns.ViaPublica, value); }
		}
		  
		[XmlAttribute("Domicilio")]
		[Bindable(true)]
		public string Domicilio 
		{
			get { return GetColumnValue<string>(Columns.Domicilio); }
			set { SetColumnValue(Columns.Domicilio, value); }
		}
		  
		[XmlAttribute("Transito")]
		[Bindable(true)]
		public int Transito 
		{
			get { return GetColumnValue<int>(Columns.Transito); }
			set { SetColumnValue(Columns.Transito, value); }
		}
		  
		[XmlAttribute("Derrumbe")]
		[Bindable(true)]
		public int Derrumbe 
		{
			get { return GetColumnValue<int>(Columns.Derrumbe); }
			set { SetColumnValue(Columns.Derrumbe, value); }
		}
		  
		[XmlAttribute("Prevension")]
		[Bindable(true)]
		public int Prevension 
		{
			get { return GetColumnValue<int>(Columns.Prevension); }
			set { SetColumnValue(Columns.Prevension, value); }
		}
		  
		[XmlAttribute("Incendio")]
		[Bindable(true)]
		public int Incendio 
		{
			get { return GetColumnValue<int>(Columns.Incendio); }
			set { SetColumnValue(Columns.Incendio, value); }
		}
		  
		[XmlAttribute("Explosion")]
		[Bindable(true)]
		public int Explosion 
		{
			get { return GetColumnValue<int>(Columns.Explosion); }
			set { SetColumnValue(Columns.Explosion, value); }
		}
		  
		[XmlAttribute("ViolenciaSocial")]
		[Bindable(true)]
		public int ViolenciaSocial 
		{
			get { return GetColumnValue<int>(Columns.ViolenciaSocial); }
			set { SetColumnValue(Columns.ViolenciaSocial, value); }
		}
		  
		[XmlAttribute("Trauma")]
		[Bindable(true)]
		public int Trauma 
		{
			get { return GetColumnValue<int>(Columns.Trauma); }
			set { SetColumnValue(Columns.Trauma, value); }
		}
		  
		[XmlAttribute("MovilApoyo")]
		[Bindable(true)]
		public int MovilApoyo 
		{
			get { return GetColumnValue<int>(Columns.MovilApoyo); }
			set { SetColumnValue(Columns.MovilApoyo, value); }
		}
		  
		[XmlAttribute("MovilApoyoCual")]
		[Bindable(true)]
		public string MovilApoyoCual 
		{
			get { return GetColumnValue<string>(Columns.MovilApoyoCual); }
			set { SetColumnValue(Columns.MovilApoyoCual, value); }
		}
		  
		[XmlAttribute("IntervencionPolicial")]
		[Bindable(true)]
		public int IntervencionPolicial 
		{
			get { return GetColumnValue<int>(Columns.IntervencionPolicial); }
			set { SetColumnValue(Columns.IntervencionPolicial, value); }
		}
		  
		[XmlAttribute("Comisaria")]
		[Bindable(true)]
		public string Comisaria 
		{
			get { return GetColumnValue<string>(Columns.Comisaria); }
			set { SetColumnValue(Columns.Comisaria, value); }
		}
		  
		[XmlAttribute("OficialComisaria")]
		[Bindable(true)]
		public string OficialComisaria 
		{
			get { return GetColumnValue<string>(Columns.OficialComisaria); }
			set { SetColumnValue(Columns.OficialComisaria, value); }
		}
		  
		[XmlAttribute("IntervencionBomberos")]
		[Bindable(true)]
		public int IntervencionBomberos 
		{
			get { return GetColumnValue<int>(Columns.IntervencionBomberos); }
			set { SetColumnValue(Columns.IntervencionBomberos, value); }
		}
		  
		[XmlAttribute("Cuartel")]
		[Bindable(true)]
		public string Cuartel 
		{
			get { return GetColumnValue<string>(Columns.Cuartel); }
			set { SetColumnValue(Columns.Cuartel, value); }
		}
		  
		[XmlAttribute("OficialCuartel")]
		[Bindable(true)]
		public string OficialCuartel 
		{
			get { return GetColumnValue<string>(Columns.OficialCuartel); }
			set { SetColumnValue(Columns.OficialCuartel, value); }
		}
		  
		[XmlAttribute("ObservacionesIncidentes")]
		[Bindable(true)]
		public string ObservacionesIncidentes 
		{
			get { return GetColumnValue<string>(Columns.ObservacionesIncidentes); }
			set { SetColumnValue(Columns.ObservacionesIncidentes, value); }
		}
		  
		[XmlAttribute("NumeroMuertos")]
		[Bindable(true)]
		public int NumeroMuertos 
		{
			get { return GetColumnValue<int>(Columns.NumeroMuertos); }
			set { SetColumnValue(Columns.NumeroMuertos, value); }
		}
		  
		[XmlAttribute("NumeroVehiculos")]
		[Bindable(true)]
		public int NumeroVehiculos 
		{
			get { return GetColumnValue<int>(Columns.NumeroVehiculos); }
			set { SetColumnValue(Columns.NumeroVehiculos, value); }
		}
		  
		[XmlAttribute("ObservacionesMuertes")]
		[Bindable(true)]
		public string ObservacionesMuertes 
		{
			get { return GetColumnValue<string>(Columns.ObservacionesMuertes); }
			set { SetColumnValue(Columns.ObservacionesMuertes, value); }
		}
		  
		[XmlAttribute("AmortiguadoPor")]
		[Bindable(true)]
		public string AmortiguadoPor 
		{
			get { return GetColumnValue<string>(Columns.AmortiguadoPor); }
			set { SetColumnValue(Columns.AmortiguadoPor, value); }
		}
		  
		[XmlAttribute("ObservacionesTrauma")]
		[Bindable(true)]
		public string ObservacionesTrauma 
		{
			get { return GetColumnValue<string>(Columns.ObservacionesTrauma); }
			set { SetColumnValue(Columns.ObservacionesTrauma, value); }
		}
		  
		[XmlAttribute("VictimasMultiples")]
		[Bindable(true)]
		public int VictimasMultiples 
		{
			get { return GetColumnValue<int>(Columns.VictimasMultiples); }
			set { SetColumnValue(Columns.VictimasMultiples, value); }
		}
		  
		[XmlAttribute("NumeroVictimas")]
		[Bindable(true)]
		public int NumeroVictimas 
		{
			get { return GetColumnValue<int>(Columns.NumeroVictimas); }
			set { SetColumnValue(Columns.NumeroVictimas, value); }
		}
		  
		[XmlAttribute("FallecidoInSitu")]
		[Bindable(true)]
		public bool FallecidoInSitu 
		{
			get { return GetColumnValue<bool>(Columns.FallecidoInSitu); }
			set { SetColumnValue(Columns.FallecidoInSitu, value); }
		}
		  
		[XmlAttribute("FallecidoEnMovil")]
		[Bindable(true)]
		public bool FallecidoEnMovil 
		{
			get { return GetColumnValue<bool>(Columns.FallecidoEnMovil); }
			set { SetColumnValue(Columns.FallecidoEnMovil, value); }
		}
		  
		[XmlAttribute("OtrasCausas")]
		[Bindable(true)]
		public string OtrasCausas 
		{
			get { return GetColumnValue<string>(Columns.OtrasCausas); }
			set { SetColumnValue(Columns.OtrasCausas, value); }
		}
		  
		[XmlAttribute("ObservacionesCausas")]
		[Bindable(true)]
		public string ObservacionesCausas 
		{
			get { return GetColumnValue<string>(Columns.ObservacionesCausas); }
			set { SetColumnValue(Columns.ObservacionesCausas, value); }
		}
		  
		[XmlAttribute("Actitud")]
		[Bindable(true)]
		public int Actitud 
		{
			get { return GetColumnValue<int>(Columns.Actitud); }
			set { SetColumnValue(Columns.Actitud, value); }
		}
		  
		[XmlAttribute("Fc")]
		[Bindable(true)]
		public int Fc 
		{
			get { return GetColumnValue<int>(Columns.Fc); }
			set { SetColumnValue(Columns.Fc, value); }
		}
		  
		[XmlAttribute("Fr")]
		[Bindable(true)]
		public int Fr 
		{
			get { return GetColumnValue<int>(Columns.Fr); }
			set { SetColumnValue(Columns.Fr, value); }
		}
		  
		[XmlAttribute("Saturacion")]
		[Bindable(true)]
		public int Saturacion 
		{
			get { return GetColumnValue<int>(Columns.Saturacion); }
			set { SetColumnValue(Columns.Saturacion, value); }
		}
		  
		[XmlAttribute("RellenoCapilar")]
		[Bindable(true)]
		public string RellenoCapilar 
		{
			get { return GetColumnValue<string>(Columns.RellenoCapilar); }
			set { SetColumnValue(Columns.RellenoCapilar, value); }
		}
		  
		[XmlAttribute("TensionArterialD")]
		[Bindable(true)]
		public int TensionArterialD 
		{
			get { return GetColumnValue<int>(Columns.TensionArterialD); }
			set { SetColumnValue(Columns.TensionArterialD, value); }
		}
		  
		[XmlAttribute("TensionArterialS")]
		[Bindable(true)]
		public int TensionArterialS 
		{
			get { return GetColumnValue<int>(Columns.TensionArterialS); }
			set { SetColumnValue(Columns.TensionArterialS, value); }
		}
		  
		[XmlAttribute("SignosVitales")]
		[Bindable(true)]
		public int SignosVitales 
		{
			get { return GetColumnValue<int>(Columns.SignosVitales); }
			set { SetColumnValue(Columns.SignosVitales, value); }
		}
		  
		[XmlAttribute("Respiratorio")]
		[Bindable(true)]
		public int Respiratorio 
		{
			get { return GetColumnValue<int>(Columns.Respiratorio); }
			set { SetColumnValue(Columns.Respiratorio, value); }
		}
		  
		[XmlAttribute("Abdomen")]
		[Bindable(true)]
		public int Abdomen 
		{
			get { return GetColumnValue<int>(Columns.Abdomen); }
			set { SetColumnValue(Columns.Abdomen, value); }
		}
		  
		[XmlAttribute("Circulatorios")]
		[Bindable(true)]
		public int Circulatorios 
		{
			get { return GetColumnValue<int>(Columns.Circulatorios); }
			set { SetColumnValue(Columns.Circulatorios, value); }
		}
		  
		[XmlAttribute("Urogenital")]
		[Bindable(true)]
		public int Urogenital 
		{
			get { return GetColumnValue<int>(Columns.Urogenital); }
			set { SetColumnValue(Columns.Urogenital, value); }
		}
		  
		[XmlAttribute("PerdidaConocimiento")]
		[Bindable(true)]
		public int PerdidaConocimiento 
		{
			get { return GetColumnValue<int>(Columns.PerdidaConocimiento); }
			set { SetColumnValue(Columns.PerdidaConocimiento, value); }
		}
		  
		[XmlAttribute("IdGlasgowOcular")]
		[Bindable(true)]
		public int IdGlasgowOcular 
		{
			get { return GetColumnValue<int>(Columns.IdGlasgowOcular); }
			set { SetColumnValue(Columns.IdGlasgowOcular, value); }
		}
		  
		[XmlAttribute("IdGlasgowVerbal")]
		[Bindable(true)]
		public int IdGlasgowVerbal 
		{
			get { return GetColumnValue<int>(Columns.IdGlasgowVerbal); }
			set { SetColumnValue(Columns.IdGlasgowVerbal, value); }
		}
		  
		[XmlAttribute("IdGlasgowMotor")]
		[Bindable(true)]
		public int IdGlasgowMotor 
		{
			get { return GetColumnValue<int>(Columns.IdGlasgowMotor); }
			set { SetColumnValue(Columns.IdGlasgowMotor, value); }
		}
		  
		[XmlAttribute("ValorGlasgow")]
		[Bindable(true)]
		public string ValorGlasgow 
		{
			get { return GetColumnValue<string>(Columns.ValorGlasgow); }
			set { SetColumnValue(Columns.ValorGlasgow, value); }
		}
		  
		[XmlAttribute("IdPupilas")]
		[Bindable(true)]
		public int IdPupilas 
		{
			get { return GetColumnValue<int>(Columns.IdPupilas); }
			set { SetColumnValue(Columns.IdPupilas, value); }
		}
		  
		[XmlAttribute("FocoMotor")]
		[Bindable(true)]
		public int FocoMotor 
		{
			get { return GetColumnValue<int>(Columns.FocoMotor); }
			set { SetColumnValue(Columns.FocoMotor, value); }
		}
		  
		[XmlAttribute("Paresia")]
		[Bindable(true)]
		public int Paresia 
		{
			get { return GetColumnValue<int>(Columns.Paresia); }
			set { SetColumnValue(Columns.Paresia, value); }
		}
		  
		[XmlAttribute("Plejia")]
		[Bindable(true)]
		public int Plejia 
		{
			get { return GetColumnValue<int>(Columns.Plejia); }
			set { SetColumnValue(Columns.Plejia, value); }
		}
		  
		[XmlAttribute("LadoID")]
		[Bindable(true)]
		public int LadoID 
		{
			get { return GetColumnValue<int>(Columns.LadoID); }
			set { SetColumnValue(Columns.LadoID, value); }
		}
		  
		[XmlAttribute("Cabeza")]
		[Bindable(true)]
		public bool Cabeza 
		{
			get { return GetColumnValue<bool>(Columns.Cabeza); }
			set { SetColumnValue(Columns.Cabeza, value); }
		}
		  
		[XmlAttribute("Axila")]
		[Bindable(true)]
		public bool Axila 
		{
			get { return GetColumnValue<bool>(Columns.Axila); }
			set { SetColumnValue(Columns.Axila, value); }
		}
		  
		[XmlAttribute("Amputacion")]
		[Bindable(true)]
		public bool Amputacion 
		{
			get { return GetColumnValue<bool>(Columns.Amputacion); }
			set { SetColumnValue(Columns.Amputacion, value); }
		}
		  
		[XmlAttribute("Ingimal")]
		[Bindable(true)]
		public bool Ingimal 
		{
			get { return GetColumnValue<bool>(Columns.Ingimal); }
			set { SetColumnValue(Columns.Ingimal, value); }
		}
		  
		[XmlAttribute("Cuello")]
		[Bindable(true)]
		public bool Cuello 
		{
			get { return GetColumnValue<bool>(Columns.Cuello); }
			set { SetColumnValue(Columns.Cuello, value); }
		}
		  
		[XmlAttribute("Dorso")]
		[Bindable(true)]
		public bool Dorso 
		{
			get { return GetColumnValue<bool>(Columns.Dorso); }
			set { SetColumnValue(Columns.Dorso, value); }
		}
		  
		[XmlAttribute("Torax")]
		[Bindable(true)]
		public bool Torax 
		{
			get { return GetColumnValue<bool>(Columns.Torax); }
			set { SetColumnValue(Columns.Torax, value); }
		}
		  
		[XmlAttribute("MSuperior")]
		[Bindable(true)]
		public bool MSuperior 
		{
			get { return GetColumnValue<bool>(Columns.MSuperior); }
			set { SetColumnValue(Columns.MSuperior, value); }
		}
		  
		[XmlAttribute("MInferior")]
		[Bindable(true)]
		public bool MInferior 
		{
			get { return GetColumnValue<bool>(Columns.MInferior); }
			set { SetColumnValue(Columns.MInferior, value); }
		}
		  
		[XmlAttribute("LesionesAbdomen")]
		[Bindable(true)]
		public bool LesionesAbdomen 
		{
			get { return GetColumnValue<bool>(Columns.LesionesAbdomen); }
			set { SetColumnValue(Columns.LesionesAbdomen, value); }
		}
		  
		[XmlAttribute("OtrasLesiones")]
		[Bindable(true)]
		public string OtrasLesiones 
		{
			get { return GetColumnValue<string>(Columns.OtrasLesiones); }
			set { SetColumnValue(Columns.OtrasLesiones, value); }
		}
		  
		[XmlAttribute("TipoQuemadura")]
		[Bindable(true)]
		public string TipoQuemadura 
		{
			get { return GetColumnValue<string>(Columns.TipoQuemadura); }
			set { SetColumnValue(Columns.TipoQuemadura, value); }
		}
		  
		[XmlAttribute("PorcentajeQuemadura")]
		[Bindable(true)]
		public string PorcentajeQuemadura 
		{
			get { return GetColumnValue<string>(Columns.PorcentajeQuemadura); }
			set { SetColumnValue(Columns.PorcentajeQuemadura, value); }
		}
		  
		[XmlAttribute("DiagnosticoPresuntivo")]
		[Bindable(true)]
		public string DiagnosticoPresuntivo 
		{
			get { return GetColumnValue<string>(Columns.DiagnosticoPresuntivo); }
			set { SetColumnValue(Columns.DiagnosticoPresuntivo, value); }
		}
		  
		[XmlAttribute("IdCODCie10")]
		[Bindable(true)]
		public int IdCODCie10 
		{
			get { return GetColumnValue<int>(Columns.IdCODCie10); }
			set { SetColumnValue(Columns.IdCODCie10, value); }
		}
		  
		[XmlAttribute("Procedimiento")]
		[Bindable(true)]
		public string Procedimiento 
		{
			get { return GetColumnValue<string>(Columns.Procedimiento); }
			set { SetColumnValue(Columns.Procedimiento, value); }
		}
		  
		[XmlAttribute("Tratamiento")]
		[Bindable(true)]
		public string Tratamiento 
		{
			get { return GetColumnValue<string>(Columns.Tratamiento); }
			set { SetColumnValue(Columns.Tratamiento, value); }
		}
		  
		[XmlAttribute("AntecedentesPersonales")]
		[Bindable(true)]
		public int AntecedentesPersonales 
		{
			get { return GetColumnValue<int>(Columns.AntecedentesPersonales); }
			set { SetColumnValue(Columns.AntecedentesPersonales, value); }
		}
		  
		[XmlAttribute("CategorizacionFinal")]
		[Bindable(true)]
		public int CategorizacionFinal 
		{
			get { return GetColumnValue<int>(Columns.CategorizacionFinal); }
			set { SetColumnValue(Columns.CategorizacionFinal, value); }
		}
		  
		[XmlAttribute("Destino")]
		[Bindable(true)]
		public int Destino 
		{
			get { return GetColumnValue<int>(Columns.Destino); }
			set { SetColumnValue(Columns.Destino, value); }
		}
		  
		[XmlAttribute("Trasladado")]
		[Bindable(true)]
		public int Trasladado 
		{
			get { return GetColumnValue<int>(Columns.Trasladado); }
			set { SetColumnValue(Columns.Trasladado, value); }
		}
		  
		[XmlAttribute("IdEfector")]
		[Bindable(true)]
		public int IdEfector 
		{
			get { return GetColumnValue<int>(Columns.IdEfector); }
			set { SetColumnValue(Columns.IdEfector, value); }
		}
		  
		[XmlAttribute("Sanatorio")]
		[Bindable(true)]
		public string Sanatorio 
		{
			get { return GetColumnValue<string>(Columns.Sanatorio); }
			set { SetColumnValue(Columns.Sanatorio, value); }
		}
		  
		[XmlAttribute("TrasladadoMovil")]
		[Bindable(true)]
		public string TrasladadoMovil 
		{
			get { return GetColumnValue<string>(Columns.TrasladadoMovil); }
			set { SetColumnValue(Columns.TrasladadoMovil, value); }
		}
		  
		[XmlAttribute("FirmaAfirmativa")]
		[Bindable(true)]
		public bool FirmaAfirmativa 
		{
			get { return GetColumnValue<bool>(Columns.FirmaAfirmativa); }
			set { SetColumnValue(Columns.FirmaAfirmativa, value); }
		}
		  
		[XmlAttribute("FirmaNegativa")]
		[Bindable(true)]
		public bool FirmaNegativa 
		{
			get { return GetColumnValue<bool>(Columns.FirmaNegativa); }
			set { SetColumnValue(Columns.FirmaNegativa, value); }
		}
		  
		[XmlAttribute("OtroGlasgow")]
		[Bindable(true)]
		public string OtroGlasgow 
		{
			get { return GetColumnValue<string>(Columns.OtroGlasgow); }
			set { SetColumnValue(Columns.OtroGlasgow, value); }
		}
		  
		[XmlAttribute("OtrosAntecedentes")]
		[Bindable(true)]
		public string OtrosAntecedentes 
		{
			get { return GetColumnValue<string>(Columns.OtrosAntecedentes); }
			set { SetColumnValue(Columns.OtrosAntecedentes, value); }
		}
		  
		[XmlAttribute("OtroDiagnostico")]
		[Bindable(true)]
		public string OtroDiagnostico 
		{
			get { return GetColumnValue<string>(Columns.OtroDiagnostico); }
			set { SetColumnValue(Columns.OtroDiagnostico, value); }
		}
		  
		[XmlAttribute("AntecedenteDiabetes")]
		[Bindable(true)]
		public bool AntecedenteDiabetes 
		{
			get { return GetColumnValue<bool>(Columns.AntecedenteDiabetes); }
			set { SetColumnValue(Columns.AntecedenteDiabetes, value); }
		}
		  
		[XmlAttribute("IdProfesional")]
		[Bindable(true)]
		public int IdProfesional 
		{
			get { return GetColumnValue<int>(Columns.IdProfesional); }
			set { SetColumnValue(Columns.IdProfesional, value); }
		}
		  
		[XmlAttribute("IdProfesionalRecibe")]
		[Bindable(true)]
		public int IdProfesionalRecibe 
		{
			get { return GetColumnValue<int>(Columns.IdProfesionalRecibe); }
			set { SetColumnValue(Columns.IdProfesionalRecibe, value); }
		}
		  
		[XmlAttribute("Enfermero")]
		[Bindable(true)]
		public string Enfermero 
		{
			get { return GetColumnValue<string>(Columns.Enfermero); }
			set { SetColumnValue(Columns.Enfermero, value); }
		}
		  
		[XmlAttribute("Activa")]
		[Bindable(true)]
		public bool Activa 
		{
			get { return GetColumnValue<bool>(Columns.Activa); }
			set { SetColumnValue(Columns.Activa, value); }
		}
		  
		[XmlAttribute("CreatedBy")]
		[Bindable(true)]
		public string CreatedBy 
		{
			get { return GetColumnValue<string>(Columns.CreatedBy); }
			set { SetColumnValue(Columns.CreatedBy, value); }
		}
		  
		[XmlAttribute("CreatedOn")]
		[Bindable(true)]
		public DateTime CreatedOn 
		{
			get { return GetColumnValue<DateTime>(Columns.CreatedOn); }
			set { SetColumnValue(Columns.CreatedOn, value); }
		}
		  
		[XmlAttribute("ModifiedBy")]
		[Bindable(true)]
		public string ModifiedBy 
		{
			get { return GetColumnValue<string>(Columns.ModifiedBy); }
			set { SetColumnValue(Columns.ModifiedBy, value); }
		}
		  
		[XmlAttribute("ModifiedOn")]
		[Bindable(true)]
		public DateTime ModifiedOn 
		{
			get { return GetColumnValue<DateTime>(Columns.ModifiedOn); }
			set { SetColumnValue(Columns.ModifiedOn, value); }
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
				colEmrRelTraumaPrehospitalaria = new DalRis.EmrRelTraumaPrehospitalariumCollection().Where(EmrRelTraumaPrehospitalarium.Columns.IdHCPrehospitalaria, IdHCPrehospitalaria).Load();
				colEmrRelTraumaPrehospitalaria.ListChanged += new ListChangedEventHandler(colEmrRelTraumaPrehospitalaria_ListChanged);
			}
			return colEmrRelTraumaPrehospitalaria;
		}
				
		void colEmrRelTraumaPrehospitalaria_ListChanged(object sender, ListChangedEventArgs e)
		{
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
		        // Set foreign key value
		        colEmrRelTraumaPrehospitalaria[e.NewIndex].IdHCPrehospitalaria = IdHCPrehospitalaria;
				colEmrRelTraumaPrehospitalaria.ListChanged += new ListChangedEventHandler(colEmrRelTraumaPrehospitalaria_ListChanged);
            }
		}
		private DalRis.EmrRelAntecedentePacienteCollection colEmrRelAntecedentePacienteRecords;
		public DalRis.EmrRelAntecedentePacienteCollection EmrRelAntecedentePacienteRecords()
		{
			if(colEmrRelAntecedentePacienteRecords == null)
			{
				colEmrRelAntecedentePacienteRecords = new DalRis.EmrRelAntecedentePacienteCollection().Where(EmrRelAntecedentePaciente.Columns.IdHCPrehospitalaria, IdHCPrehospitalaria).Load();
				colEmrRelAntecedentePacienteRecords.ListChanged += new ListChangedEventHandler(colEmrRelAntecedentePacienteRecords_ListChanged);
			}
			return colEmrRelAntecedentePacienteRecords;
		}
				
		void colEmrRelAntecedentePacienteRecords_ListChanged(object sender, ListChangedEventArgs e)
		{
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
		        // Set foreign key value
		        colEmrRelAntecedentePacienteRecords[e.NewIndex].IdHCPrehospitalaria = IdHCPrehospitalaria;
				colEmrRelAntecedentePacienteRecords.ListChanged += new ListChangedEventHandler(colEmrRelAntecedentePacienteRecords_ListChanged);
            }
		}
		#endregion
		
			
		
		#region ForeignKey Properties
		
		/// <summary>
		/// Returns a SysCIE10 ActiveRecord object related to this EmrPrehospitalarium
		/// 
		/// </summary>
		public DalRis.SysCIE10 SysCIE10
		{
			get { return DalRis.SysCIE10.FetchByID(this.IdCODCie10); }
			set { SetColumnValue("idCODCie10", value.Id); }
		}
		
		
		/// <summary>
		/// Returns a SysEfector ActiveRecord object related to this EmrPrehospitalarium
		/// 
		/// </summary>
		public DalRis.SysEfector SysEfector
		{
			get { return DalRis.SysEfector.FetchByID(this.IdEfector); }
			set { SetColumnValue("idEfector", value.IdEfector); }
		}
		
		
		/// <summary>
		/// Returns a EmrBase ActiveRecord object related to this EmrPrehospitalarium
		/// 
		/// </summary>
		public DalRis.EmrBase EmrBase
		{
			get { return DalRis.EmrBase.FetchByID(this.IdBase); }
			set { SetColumnValue("idBase", value.IdBase); }
		}
		
		
		/// <summary>
		/// Returns a SysObraSocial ActiveRecord object related to this EmrPrehospitalarium
		/// 
		/// </summary>
		public DalRis.SysObraSocial SysObraSocial
		{
			get { return DalRis.SysObraSocial.FetchByID(this.IdObraSocial); }
			set { SetColumnValue("idObraSocial", value.IdObraSocial); }
		}
		
		
		/// <summary>
		/// Returns a SysProfesional ActiveRecord object related to this EmrPrehospitalarium
		/// 
		/// </summary>
		public DalRis.SysProfesional SysProfesional
		{
			get { return DalRis.SysProfesional.FetchByID(this.IdProfesional); }
			set { SetColumnValue("idProfesional", value.IdProfesional); }
		}
		
		
		/// <summary>
		/// Returns a SysProfesional ActiveRecord object related to this EmrPrehospitalarium
		/// 
		/// </summary>
		public DalRis.SysProfesional SysProfesionalToIdProfesionalRecibe
		{
			get { return DalRis.SysProfesional.FetchByID(this.IdProfesionalRecibe); }
			set { SetColumnValue("idProfesionalRecibe", value.IdProfesional); }
		}
		
		
		/// <summary>
		/// Returns a EmrGlasgowVerbal ActiveRecord object related to this EmrPrehospitalarium
		/// 
		/// </summary>
		public DalRis.EmrGlasgowVerbal EmrGlasgowVerbal
		{
			get { return DalRis.EmrGlasgowVerbal.FetchByID(this.IdGlasgowVerbal); }
			set { SetColumnValue("idGlasgowVerbal", value.IdGlasgowVerbal); }
		}
		
		
		/// <summary>
		/// Returns a EmrGlasgowMotor ActiveRecord object related to this EmrPrehospitalarium
		/// 
		/// </summary>
		public DalRis.EmrGlasgowMotor EmrGlasgowMotor
		{
			get { return DalRis.EmrGlasgowMotor.FetchByID(this.IdGlasgowMotor); }
			set { SetColumnValue("idGlasgowMotor", value.IdGlasgowMotor); }
		}
		
		
		/// <summary>
		/// Returns a EmrGlasgowOcular ActiveRecord object related to this EmrPrehospitalarium
		/// 
		/// </summary>
		public DalRis.EmrGlasgowOcular EmrGlasgowOcular
		{
			get { return DalRis.EmrGlasgowOcular.FetchByID(this.IdGlasgowOcular); }
			set { SetColumnValue("idGlasgowOcular", value.IdGlasgowOcular); }
		}
		
		
		/// <summary>
		/// Returns a EmrPupila ActiveRecord object related to this EmrPrehospitalarium
		/// 
		/// </summary>
		public DalRis.EmrPupila EmrPupila
		{
			get { return DalRis.EmrPupila.FetchByID(this.IdPupilas); }
			set { SetColumnValue("idPupilas", value.IdPupilas); }
		}
		
		
		#endregion
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varNumeroAuxilio,DateTime varFecha,string varHoraTrasmitido,string varMovil,int varIdBase,string varHoraArribo,string varCodigoLlamado,string varTipoCodigo,int varIdPaciente,int varEdad,int varIdObraSocial,string varNumeroAfiliado,string varOtraObraSocial,string varPatente,string varSeguro,string varViaPublica,string varDomicilio,int varTransito,int varDerrumbe,int varPrevension,int varIncendio,int varExplosion,int varViolenciaSocial,int varTrauma,int varMovilApoyo,string varMovilApoyoCual,int varIntervencionPolicial,string varComisaria,string varOficialComisaria,int varIntervencionBomberos,string varCuartel,string varOficialCuartel,string varObservacionesIncidentes,int varNumeroMuertos,int varNumeroVehiculos,string varObservacionesMuertes,string varAmortiguadoPor,string varObservacionesTrauma,int varVictimasMultiples,int varNumeroVictimas,bool varFallecidoInSitu,bool varFallecidoEnMovil,string varOtrasCausas,string varObservacionesCausas,int varActitud,int varFc,int varFr,int varSaturacion,string varRellenoCapilar,int varTensionArterialD,int varTensionArterialS,int varSignosVitales,int varRespiratorio,int varAbdomen,int varCirculatorios,int varUrogenital,int varPerdidaConocimiento,int varIdGlasgowOcular,int varIdGlasgowVerbal,int varIdGlasgowMotor,string varValorGlasgow,int varIdPupilas,int varFocoMotor,int varParesia,int varPlejia,int varLadoID,bool varCabeza,bool varAxila,bool varAmputacion,bool varIngimal,bool varCuello,bool varDorso,bool varTorax,bool varMSuperior,bool varMInferior,bool varLesionesAbdomen,string varOtrasLesiones,string varTipoQuemadura,string varPorcentajeQuemadura,string varDiagnosticoPresuntivo,int varIdCODCie10,string varProcedimiento,string varTratamiento,int varAntecedentesPersonales,int varCategorizacionFinal,int varDestino,int varTrasladado,int varIdEfector,string varSanatorio,string varTrasladadoMovil,bool varFirmaAfirmativa,bool varFirmaNegativa,string varOtroGlasgow,string varOtrosAntecedentes,string varOtroDiagnostico,bool varAntecedenteDiabetes,int varIdProfesional,int varIdProfesionalRecibe,string varEnfermero,bool varActiva,string varCreatedBy,DateTime varCreatedOn,string varModifiedBy,DateTime varModifiedOn)
		{
			EmrPrehospitalarium item = new EmrPrehospitalarium();
			
			item.NumeroAuxilio = varNumeroAuxilio;
			
			item.Fecha = varFecha;
			
			item.HoraTrasmitido = varHoraTrasmitido;
			
			item.Movil = varMovil;
			
			item.IdBase = varIdBase;
			
			item.HoraArribo = varHoraArribo;
			
			item.CodigoLlamado = varCodigoLlamado;
			
			item.TipoCodigo = varTipoCodigo;
			
			item.IdPaciente = varIdPaciente;
			
			item.Edad = varEdad;
			
			item.IdObraSocial = varIdObraSocial;
			
			item.NumeroAfiliado = varNumeroAfiliado;
			
			item.OtraObraSocial = varOtraObraSocial;
			
			item.Patente = varPatente;
			
			item.Seguro = varSeguro;
			
			item.ViaPublica = varViaPublica;
			
			item.Domicilio = varDomicilio;
			
			item.Transito = varTransito;
			
			item.Derrumbe = varDerrumbe;
			
			item.Prevension = varPrevension;
			
			item.Incendio = varIncendio;
			
			item.Explosion = varExplosion;
			
			item.ViolenciaSocial = varViolenciaSocial;
			
			item.Trauma = varTrauma;
			
			item.MovilApoyo = varMovilApoyo;
			
			item.MovilApoyoCual = varMovilApoyoCual;
			
			item.IntervencionPolicial = varIntervencionPolicial;
			
			item.Comisaria = varComisaria;
			
			item.OficialComisaria = varOficialComisaria;
			
			item.IntervencionBomberos = varIntervencionBomberos;
			
			item.Cuartel = varCuartel;
			
			item.OficialCuartel = varOficialCuartel;
			
			item.ObservacionesIncidentes = varObservacionesIncidentes;
			
			item.NumeroMuertos = varNumeroMuertos;
			
			item.NumeroVehiculos = varNumeroVehiculos;
			
			item.ObservacionesMuertes = varObservacionesMuertes;
			
			item.AmortiguadoPor = varAmortiguadoPor;
			
			item.ObservacionesTrauma = varObservacionesTrauma;
			
			item.VictimasMultiples = varVictimasMultiples;
			
			item.NumeroVictimas = varNumeroVictimas;
			
			item.FallecidoInSitu = varFallecidoInSitu;
			
			item.FallecidoEnMovil = varFallecidoEnMovil;
			
			item.OtrasCausas = varOtrasCausas;
			
			item.ObservacionesCausas = varObservacionesCausas;
			
			item.Actitud = varActitud;
			
			item.Fc = varFc;
			
			item.Fr = varFr;
			
			item.Saturacion = varSaturacion;
			
			item.RellenoCapilar = varRellenoCapilar;
			
			item.TensionArterialD = varTensionArterialD;
			
			item.TensionArterialS = varTensionArterialS;
			
			item.SignosVitales = varSignosVitales;
			
			item.Respiratorio = varRespiratorio;
			
			item.Abdomen = varAbdomen;
			
			item.Circulatorios = varCirculatorios;
			
			item.Urogenital = varUrogenital;
			
			item.PerdidaConocimiento = varPerdidaConocimiento;
			
			item.IdGlasgowOcular = varIdGlasgowOcular;
			
			item.IdGlasgowVerbal = varIdGlasgowVerbal;
			
			item.IdGlasgowMotor = varIdGlasgowMotor;
			
			item.ValorGlasgow = varValorGlasgow;
			
			item.IdPupilas = varIdPupilas;
			
			item.FocoMotor = varFocoMotor;
			
			item.Paresia = varParesia;
			
			item.Plejia = varPlejia;
			
			item.LadoID = varLadoID;
			
			item.Cabeza = varCabeza;
			
			item.Axila = varAxila;
			
			item.Amputacion = varAmputacion;
			
			item.Ingimal = varIngimal;
			
			item.Cuello = varCuello;
			
			item.Dorso = varDorso;
			
			item.Torax = varTorax;
			
			item.MSuperior = varMSuperior;
			
			item.MInferior = varMInferior;
			
			item.LesionesAbdomen = varLesionesAbdomen;
			
			item.OtrasLesiones = varOtrasLesiones;
			
			item.TipoQuemadura = varTipoQuemadura;
			
			item.PorcentajeQuemadura = varPorcentajeQuemadura;
			
			item.DiagnosticoPresuntivo = varDiagnosticoPresuntivo;
			
			item.IdCODCie10 = varIdCODCie10;
			
			item.Procedimiento = varProcedimiento;
			
			item.Tratamiento = varTratamiento;
			
			item.AntecedentesPersonales = varAntecedentesPersonales;
			
			item.CategorizacionFinal = varCategorizacionFinal;
			
			item.Destino = varDestino;
			
			item.Trasladado = varTrasladado;
			
			item.IdEfector = varIdEfector;
			
			item.Sanatorio = varSanatorio;
			
			item.TrasladadoMovil = varTrasladadoMovil;
			
			item.FirmaAfirmativa = varFirmaAfirmativa;
			
			item.FirmaNegativa = varFirmaNegativa;
			
			item.OtroGlasgow = varOtroGlasgow;
			
			item.OtrosAntecedentes = varOtrosAntecedentes;
			
			item.OtroDiagnostico = varOtroDiagnostico;
			
			item.AntecedenteDiabetes = varAntecedenteDiabetes;
			
			item.IdProfesional = varIdProfesional;
			
			item.IdProfesionalRecibe = varIdProfesionalRecibe;
			
			item.Enfermero = varEnfermero;
			
			item.Activa = varActiva;
			
			item.CreatedBy = varCreatedBy;
			
			item.CreatedOn = varCreatedOn;
			
			item.ModifiedBy = varModifiedBy;
			
			item.ModifiedOn = varModifiedOn;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varIdHCPrehospitalaria,string varNumeroAuxilio,DateTime varFecha,string varHoraTrasmitido,string varMovil,int varIdBase,string varHoraArribo,string varCodigoLlamado,string varTipoCodigo,int varIdPaciente,int varEdad,int varIdObraSocial,string varNumeroAfiliado,string varOtraObraSocial,string varPatente,string varSeguro,string varViaPublica,string varDomicilio,int varTransito,int varDerrumbe,int varPrevension,int varIncendio,int varExplosion,int varViolenciaSocial,int varTrauma,int varMovilApoyo,string varMovilApoyoCual,int varIntervencionPolicial,string varComisaria,string varOficialComisaria,int varIntervencionBomberos,string varCuartel,string varOficialCuartel,string varObservacionesIncidentes,int varNumeroMuertos,int varNumeroVehiculos,string varObservacionesMuertes,string varAmortiguadoPor,string varObservacionesTrauma,int varVictimasMultiples,int varNumeroVictimas,bool varFallecidoInSitu,bool varFallecidoEnMovil,string varOtrasCausas,string varObservacionesCausas,int varActitud,int varFc,int varFr,int varSaturacion,string varRellenoCapilar,int varTensionArterialD,int varTensionArterialS,int varSignosVitales,int varRespiratorio,int varAbdomen,int varCirculatorios,int varUrogenital,int varPerdidaConocimiento,int varIdGlasgowOcular,int varIdGlasgowVerbal,int varIdGlasgowMotor,string varValorGlasgow,int varIdPupilas,int varFocoMotor,int varParesia,int varPlejia,int varLadoID,bool varCabeza,bool varAxila,bool varAmputacion,bool varIngimal,bool varCuello,bool varDorso,bool varTorax,bool varMSuperior,bool varMInferior,bool varLesionesAbdomen,string varOtrasLesiones,string varTipoQuemadura,string varPorcentajeQuemadura,string varDiagnosticoPresuntivo,int varIdCODCie10,string varProcedimiento,string varTratamiento,int varAntecedentesPersonales,int varCategorizacionFinal,int varDestino,int varTrasladado,int varIdEfector,string varSanatorio,string varTrasladadoMovil,bool varFirmaAfirmativa,bool varFirmaNegativa,string varOtroGlasgow,string varOtrosAntecedentes,string varOtroDiagnostico,bool varAntecedenteDiabetes,int varIdProfesional,int varIdProfesionalRecibe,string varEnfermero,bool varActiva,string varCreatedBy,DateTime varCreatedOn,string varModifiedBy,DateTime varModifiedOn)
		{
			EmrPrehospitalarium item = new EmrPrehospitalarium();
			
				item.IdHCPrehospitalaria = varIdHCPrehospitalaria;
			
				item.NumeroAuxilio = varNumeroAuxilio;
			
				item.Fecha = varFecha;
			
				item.HoraTrasmitido = varHoraTrasmitido;
			
				item.Movil = varMovil;
			
				item.IdBase = varIdBase;
			
				item.HoraArribo = varHoraArribo;
			
				item.CodigoLlamado = varCodigoLlamado;
			
				item.TipoCodigo = varTipoCodigo;
			
				item.IdPaciente = varIdPaciente;
			
				item.Edad = varEdad;
			
				item.IdObraSocial = varIdObraSocial;
			
				item.NumeroAfiliado = varNumeroAfiliado;
			
				item.OtraObraSocial = varOtraObraSocial;
			
				item.Patente = varPatente;
			
				item.Seguro = varSeguro;
			
				item.ViaPublica = varViaPublica;
			
				item.Domicilio = varDomicilio;
			
				item.Transito = varTransito;
			
				item.Derrumbe = varDerrumbe;
			
				item.Prevension = varPrevension;
			
				item.Incendio = varIncendio;
			
				item.Explosion = varExplosion;
			
				item.ViolenciaSocial = varViolenciaSocial;
			
				item.Trauma = varTrauma;
			
				item.MovilApoyo = varMovilApoyo;
			
				item.MovilApoyoCual = varMovilApoyoCual;
			
				item.IntervencionPolicial = varIntervencionPolicial;
			
				item.Comisaria = varComisaria;
			
				item.OficialComisaria = varOficialComisaria;
			
				item.IntervencionBomberos = varIntervencionBomberos;
			
				item.Cuartel = varCuartel;
			
				item.OficialCuartel = varOficialCuartel;
			
				item.ObservacionesIncidentes = varObservacionesIncidentes;
			
				item.NumeroMuertos = varNumeroMuertos;
			
				item.NumeroVehiculos = varNumeroVehiculos;
			
				item.ObservacionesMuertes = varObservacionesMuertes;
			
				item.AmortiguadoPor = varAmortiguadoPor;
			
				item.ObservacionesTrauma = varObservacionesTrauma;
			
				item.VictimasMultiples = varVictimasMultiples;
			
				item.NumeroVictimas = varNumeroVictimas;
			
				item.FallecidoInSitu = varFallecidoInSitu;
			
				item.FallecidoEnMovil = varFallecidoEnMovil;
			
				item.OtrasCausas = varOtrasCausas;
			
				item.ObservacionesCausas = varObservacionesCausas;
			
				item.Actitud = varActitud;
			
				item.Fc = varFc;
			
				item.Fr = varFr;
			
				item.Saturacion = varSaturacion;
			
				item.RellenoCapilar = varRellenoCapilar;
			
				item.TensionArterialD = varTensionArterialD;
			
				item.TensionArterialS = varTensionArterialS;
			
				item.SignosVitales = varSignosVitales;
			
				item.Respiratorio = varRespiratorio;
			
				item.Abdomen = varAbdomen;
			
				item.Circulatorios = varCirculatorios;
			
				item.Urogenital = varUrogenital;
			
				item.PerdidaConocimiento = varPerdidaConocimiento;
			
				item.IdGlasgowOcular = varIdGlasgowOcular;
			
				item.IdGlasgowVerbal = varIdGlasgowVerbal;
			
				item.IdGlasgowMotor = varIdGlasgowMotor;
			
				item.ValorGlasgow = varValorGlasgow;
			
				item.IdPupilas = varIdPupilas;
			
				item.FocoMotor = varFocoMotor;
			
				item.Paresia = varParesia;
			
				item.Plejia = varPlejia;
			
				item.LadoID = varLadoID;
			
				item.Cabeza = varCabeza;
			
				item.Axila = varAxila;
			
				item.Amputacion = varAmputacion;
			
				item.Ingimal = varIngimal;
			
				item.Cuello = varCuello;
			
				item.Dorso = varDorso;
			
				item.Torax = varTorax;
			
				item.MSuperior = varMSuperior;
			
				item.MInferior = varMInferior;
			
				item.LesionesAbdomen = varLesionesAbdomen;
			
				item.OtrasLesiones = varOtrasLesiones;
			
				item.TipoQuemadura = varTipoQuemadura;
			
				item.PorcentajeQuemadura = varPorcentajeQuemadura;
			
				item.DiagnosticoPresuntivo = varDiagnosticoPresuntivo;
			
				item.IdCODCie10 = varIdCODCie10;
			
				item.Procedimiento = varProcedimiento;
			
				item.Tratamiento = varTratamiento;
			
				item.AntecedentesPersonales = varAntecedentesPersonales;
			
				item.CategorizacionFinal = varCategorizacionFinal;
			
				item.Destino = varDestino;
			
				item.Trasladado = varTrasladado;
			
				item.IdEfector = varIdEfector;
			
				item.Sanatorio = varSanatorio;
			
				item.TrasladadoMovil = varTrasladadoMovil;
			
				item.FirmaAfirmativa = varFirmaAfirmativa;
			
				item.FirmaNegativa = varFirmaNegativa;
			
				item.OtroGlasgow = varOtroGlasgow;
			
				item.OtrosAntecedentes = varOtrosAntecedentes;
			
				item.OtroDiagnostico = varOtroDiagnostico;
			
				item.AntecedenteDiabetes = varAntecedenteDiabetes;
			
				item.IdProfesional = varIdProfesional;
			
				item.IdProfesionalRecibe = varIdProfesionalRecibe;
			
				item.Enfermero = varEnfermero;
			
				item.Activa = varActiva;
			
				item.CreatedBy = varCreatedBy;
			
				item.CreatedOn = varCreatedOn;
			
				item.ModifiedBy = varModifiedBy;
			
				item.ModifiedOn = varModifiedOn;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn IdHCPrehospitalariaColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn NumeroAuxilioColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn FechaColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn HoraTrasmitidoColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn MovilColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn IdBaseColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        public static TableSchema.TableColumn HoraArriboColumn
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        public static TableSchema.TableColumn CodigoLlamadoColumn
        {
            get { return Schema.Columns[7]; }
        }
        
        
        
        public static TableSchema.TableColumn TipoCodigoColumn
        {
            get { return Schema.Columns[8]; }
        }
        
        
        
        public static TableSchema.TableColumn IdPacienteColumn
        {
            get { return Schema.Columns[9]; }
        }
        
        
        
        public static TableSchema.TableColumn EdadColumn
        {
            get { return Schema.Columns[10]; }
        }
        
        
        
        public static TableSchema.TableColumn IdObraSocialColumn
        {
            get { return Schema.Columns[11]; }
        }
        
        
        
        public static TableSchema.TableColumn NumeroAfiliadoColumn
        {
            get { return Schema.Columns[12]; }
        }
        
        
        
        public static TableSchema.TableColumn OtraObraSocialColumn
        {
            get { return Schema.Columns[13]; }
        }
        
        
        
        public static TableSchema.TableColumn PatenteColumn
        {
            get { return Schema.Columns[14]; }
        }
        
        
        
        public static TableSchema.TableColumn SeguroColumn
        {
            get { return Schema.Columns[15]; }
        }
        
        
        
        public static TableSchema.TableColumn ViaPublicaColumn
        {
            get { return Schema.Columns[16]; }
        }
        
        
        
        public static TableSchema.TableColumn DomicilioColumn
        {
            get { return Schema.Columns[17]; }
        }
        
        
        
        public static TableSchema.TableColumn TransitoColumn
        {
            get { return Schema.Columns[18]; }
        }
        
        
        
        public static TableSchema.TableColumn DerrumbeColumn
        {
            get { return Schema.Columns[19]; }
        }
        
        
        
        public static TableSchema.TableColumn PrevensionColumn
        {
            get { return Schema.Columns[20]; }
        }
        
        
        
        public static TableSchema.TableColumn IncendioColumn
        {
            get { return Schema.Columns[21]; }
        }
        
        
        
        public static TableSchema.TableColumn ExplosionColumn
        {
            get { return Schema.Columns[22]; }
        }
        
        
        
        public static TableSchema.TableColumn ViolenciaSocialColumn
        {
            get { return Schema.Columns[23]; }
        }
        
        
        
        public static TableSchema.TableColumn TraumaColumn
        {
            get { return Schema.Columns[24]; }
        }
        
        
        
        public static TableSchema.TableColumn MovilApoyoColumn
        {
            get { return Schema.Columns[25]; }
        }
        
        
        
        public static TableSchema.TableColumn MovilApoyoCualColumn
        {
            get { return Schema.Columns[26]; }
        }
        
        
        
        public static TableSchema.TableColumn IntervencionPolicialColumn
        {
            get { return Schema.Columns[27]; }
        }
        
        
        
        public static TableSchema.TableColumn ComisariaColumn
        {
            get { return Schema.Columns[28]; }
        }
        
        
        
        public static TableSchema.TableColumn OficialComisariaColumn
        {
            get { return Schema.Columns[29]; }
        }
        
        
        
        public static TableSchema.TableColumn IntervencionBomberosColumn
        {
            get { return Schema.Columns[30]; }
        }
        
        
        
        public static TableSchema.TableColumn CuartelColumn
        {
            get { return Schema.Columns[31]; }
        }
        
        
        
        public static TableSchema.TableColumn OficialCuartelColumn
        {
            get { return Schema.Columns[32]; }
        }
        
        
        
        public static TableSchema.TableColumn ObservacionesIncidentesColumn
        {
            get { return Schema.Columns[33]; }
        }
        
        
        
        public static TableSchema.TableColumn NumeroMuertosColumn
        {
            get { return Schema.Columns[34]; }
        }
        
        
        
        public static TableSchema.TableColumn NumeroVehiculosColumn
        {
            get { return Schema.Columns[35]; }
        }
        
        
        
        public static TableSchema.TableColumn ObservacionesMuertesColumn
        {
            get { return Schema.Columns[36]; }
        }
        
        
        
        public static TableSchema.TableColumn AmortiguadoPorColumn
        {
            get { return Schema.Columns[37]; }
        }
        
        
        
        public static TableSchema.TableColumn ObservacionesTraumaColumn
        {
            get { return Schema.Columns[38]; }
        }
        
        
        
        public static TableSchema.TableColumn VictimasMultiplesColumn
        {
            get { return Schema.Columns[39]; }
        }
        
        
        
        public static TableSchema.TableColumn NumeroVictimasColumn
        {
            get { return Schema.Columns[40]; }
        }
        
        
        
        public static TableSchema.TableColumn FallecidoInSituColumn
        {
            get { return Schema.Columns[41]; }
        }
        
        
        
        public static TableSchema.TableColumn FallecidoEnMovilColumn
        {
            get { return Schema.Columns[42]; }
        }
        
        
        
        public static TableSchema.TableColumn OtrasCausasColumn
        {
            get { return Schema.Columns[43]; }
        }
        
        
        
        public static TableSchema.TableColumn ObservacionesCausasColumn
        {
            get { return Schema.Columns[44]; }
        }
        
        
        
        public static TableSchema.TableColumn ActitudColumn
        {
            get { return Schema.Columns[45]; }
        }
        
        
        
        public static TableSchema.TableColumn FcColumn
        {
            get { return Schema.Columns[46]; }
        }
        
        
        
        public static TableSchema.TableColumn FrColumn
        {
            get { return Schema.Columns[47]; }
        }
        
        
        
        public static TableSchema.TableColumn SaturacionColumn
        {
            get { return Schema.Columns[48]; }
        }
        
        
        
        public static TableSchema.TableColumn RellenoCapilarColumn
        {
            get { return Schema.Columns[49]; }
        }
        
        
        
        public static TableSchema.TableColumn TensionArterialDColumn
        {
            get { return Schema.Columns[50]; }
        }
        
        
        
        public static TableSchema.TableColumn TensionArterialSColumn
        {
            get { return Schema.Columns[51]; }
        }
        
        
        
        public static TableSchema.TableColumn SignosVitalesColumn
        {
            get { return Schema.Columns[52]; }
        }
        
        
        
        public static TableSchema.TableColumn RespiratorioColumn
        {
            get { return Schema.Columns[53]; }
        }
        
        
        
        public static TableSchema.TableColumn AbdomenColumn
        {
            get { return Schema.Columns[54]; }
        }
        
        
        
        public static TableSchema.TableColumn CirculatoriosColumn
        {
            get { return Schema.Columns[55]; }
        }
        
        
        
        public static TableSchema.TableColumn UrogenitalColumn
        {
            get { return Schema.Columns[56]; }
        }
        
        
        
        public static TableSchema.TableColumn PerdidaConocimientoColumn
        {
            get { return Schema.Columns[57]; }
        }
        
        
        
        public static TableSchema.TableColumn IdGlasgowOcularColumn
        {
            get { return Schema.Columns[58]; }
        }
        
        
        
        public static TableSchema.TableColumn IdGlasgowVerbalColumn
        {
            get { return Schema.Columns[59]; }
        }
        
        
        
        public static TableSchema.TableColumn IdGlasgowMotorColumn
        {
            get { return Schema.Columns[60]; }
        }
        
        
        
        public static TableSchema.TableColumn ValorGlasgowColumn
        {
            get { return Schema.Columns[61]; }
        }
        
        
        
        public static TableSchema.TableColumn IdPupilasColumn
        {
            get { return Schema.Columns[62]; }
        }
        
        
        
        public static TableSchema.TableColumn FocoMotorColumn
        {
            get { return Schema.Columns[63]; }
        }
        
        
        
        public static TableSchema.TableColumn ParesiaColumn
        {
            get { return Schema.Columns[64]; }
        }
        
        
        
        public static TableSchema.TableColumn PlejiaColumn
        {
            get { return Schema.Columns[65]; }
        }
        
        
        
        public static TableSchema.TableColumn LadoIDColumn
        {
            get { return Schema.Columns[66]; }
        }
        
        
        
        public static TableSchema.TableColumn CabezaColumn
        {
            get { return Schema.Columns[67]; }
        }
        
        
        
        public static TableSchema.TableColumn AxilaColumn
        {
            get { return Schema.Columns[68]; }
        }
        
        
        
        public static TableSchema.TableColumn AmputacionColumn
        {
            get { return Schema.Columns[69]; }
        }
        
        
        
        public static TableSchema.TableColumn IngimalColumn
        {
            get { return Schema.Columns[70]; }
        }
        
        
        
        public static TableSchema.TableColumn CuelloColumn
        {
            get { return Schema.Columns[71]; }
        }
        
        
        
        public static TableSchema.TableColumn DorsoColumn
        {
            get { return Schema.Columns[72]; }
        }
        
        
        
        public static TableSchema.TableColumn ToraxColumn
        {
            get { return Schema.Columns[73]; }
        }
        
        
        
        public static TableSchema.TableColumn MSuperiorColumn
        {
            get { return Schema.Columns[74]; }
        }
        
        
        
        public static TableSchema.TableColumn MInferiorColumn
        {
            get { return Schema.Columns[75]; }
        }
        
        
        
        public static TableSchema.TableColumn LesionesAbdomenColumn
        {
            get { return Schema.Columns[76]; }
        }
        
        
        
        public static TableSchema.TableColumn OtrasLesionesColumn
        {
            get { return Schema.Columns[77]; }
        }
        
        
        
        public static TableSchema.TableColumn TipoQuemaduraColumn
        {
            get { return Schema.Columns[78]; }
        }
        
        
        
        public static TableSchema.TableColumn PorcentajeQuemaduraColumn
        {
            get { return Schema.Columns[79]; }
        }
        
        
        
        public static TableSchema.TableColumn DiagnosticoPresuntivoColumn
        {
            get { return Schema.Columns[80]; }
        }
        
        
        
        public static TableSchema.TableColumn IdCODCie10Column
        {
            get { return Schema.Columns[81]; }
        }
        
        
        
        public static TableSchema.TableColumn ProcedimientoColumn
        {
            get { return Schema.Columns[82]; }
        }
        
        
        
        public static TableSchema.TableColumn TratamientoColumn
        {
            get { return Schema.Columns[83]; }
        }
        
        
        
        public static TableSchema.TableColumn AntecedentesPersonalesColumn
        {
            get { return Schema.Columns[84]; }
        }
        
        
        
        public static TableSchema.TableColumn CategorizacionFinalColumn
        {
            get { return Schema.Columns[85]; }
        }
        
        
        
        public static TableSchema.TableColumn DestinoColumn
        {
            get { return Schema.Columns[86]; }
        }
        
        
        
        public static TableSchema.TableColumn TrasladadoColumn
        {
            get { return Schema.Columns[87]; }
        }
        
        
        
        public static TableSchema.TableColumn IdEfectorColumn
        {
            get { return Schema.Columns[88]; }
        }
        
        
        
        public static TableSchema.TableColumn SanatorioColumn
        {
            get { return Schema.Columns[89]; }
        }
        
        
        
        public static TableSchema.TableColumn TrasladadoMovilColumn
        {
            get { return Schema.Columns[90]; }
        }
        
        
        
        public static TableSchema.TableColumn FirmaAfirmativaColumn
        {
            get { return Schema.Columns[91]; }
        }
        
        
        
        public static TableSchema.TableColumn FirmaNegativaColumn
        {
            get { return Schema.Columns[92]; }
        }
        
        
        
        public static TableSchema.TableColumn OtroGlasgowColumn
        {
            get { return Schema.Columns[93]; }
        }
        
        
        
        public static TableSchema.TableColumn OtrosAntecedentesColumn
        {
            get { return Schema.Columns[94]; }
        }
        
        
        
        public static TableSchema.TableColumn OtroDiagnosticoColumn
        {
            get { return Schema.Columns[95]; }
        }
        
        
        
        public static TableSchema.TableColumn AntecedenteDiabetesColumn
        {
            get { return Schema.Columns[96]; }
        }
        
        
        
        public static TableSchema.TableColumn IdProfesionalColumn
        {
            get { return Schema.Columns[97]; }
        }
        
        
        
        public static TableSchema.TableColumn IdProfesionalRecibeColumn
        {
            get { return Schema.Columns[98]; }
        }
        
        
        
        public static TableSchema.TableColumn EnfermeroColumn
        {
            get { return Schema.Columns[99]; }
        }
        
        
        
        public static TableSchema.TableColumn ActivaColumn
        {
            get { return Schema.Columns[100]; }
        }
        
        
        
        public static TableSchema.TableColumn CreatedByColumn
        {
            get { return Schema.Columns[101]; }
        }
        
        
        
        public static TableSchema.TableColumn CreatedOnColumn
        {
            get { return Schema.Columns[102]; }
        }
        
        
        
        public static TableSchema.TableColumn ModifiedByColumn
        {
            get { return Schema.Columns[103]; }
        }
        
        
        
        public static TableSchema.TableColumn ModifiedOnColumn
        {
            get { return Schema.Columns[104]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string IdHCPrehospitalaria = @"idHCPrehospitalaria";
			 public static string NumeroAuxilio = @"numeroAuxilio";
			 public static string Fecha = @"fecha";
			 public static string HoraTrasmitido = @"horaTrasmitido";
			 public static string Movil = @"movil";
			 public static string IdBase = @"idBase";
			 public static string HoraArribo = @"horaArribo";
			 public static string CodigoLlamado = @"codigoLlamado";
			 public static string TipoCodigo = @"tipoCodigo";
			 public static string IdPaciente = @"idPaciente";
			 public static string Edad = @"edad";
			 public static string IdObraSocial = @"idObraSocial";
			 public static string NumeroAfiliado = @"numeroAfiliado";
			 public static string OtraObraSocial = @"otraObraSocial";
			 public static string Patente = @"patente";
			 public static string Seguro = @"seguro";
			 public static string ViaPublica = @"viaPublica";
			 public static string Domicilio = @"domicilio";
			 public static string Transito = @"transito";
			 public static string Derrumbe = @"derrumbe";
			 public static string Prevension = @"prevension";
			 public static string Incendio = @"incendio";
			 public static string Explosion = @"explosion";
			 public static string ViolenciaSocial = @"violenciaSocial";
			 public static string Trauma = @"trauma";
			 public static string MovilApoyo = @"movilApoyo";
			 public static string MovilApoyoCual = @"movilApoyoCual";
			 public static string IntervencionPolicial = @"intervencionPolicial";
			 public static string Comisaria = @"comisaria";
			 public static string OficialComisaria = @"oficialComisaria";
			 public static string IntervencionBomberos = @"intervencionBomberos";
			 public static string Cuartel = @"cuartel";
			 public static string OficialCuartel = @"oficialCuartel";
			 public static string ObservacionesIncidentes = @"observacionesIncidentes";
			 public static string NumeroMuertos = @"numeroMuertos";
			 public static string NumeroVehiculos = @"numeroVehiculos";
			 public static string ObservacionesMuertes = @"observacionesMuertes";
			 public static string AmortiguadoPor = @"amortiguadoPor";
			 public static string ObservacionesTrauma = @"observacionesTrauma";
			 public static string VictimasMultiples = @"victimasMultiples";
			 public static string NumeroVictimas = @"numeroVictimas";
			 public static string FallecidoInSitu = @"fallecidoInSitu";
			 public static string FallecidoEnMovil = @"fallecidoEnMovil";
			 public static string OtrasCausas = @"otrasCausas";
			 public static string ObservacionesCausas = @"observacionesCausas";
			 public static string Actitud = @"actitud";
			 public static string Fc = @"FC";
			 public static string Fr = @"FR";
			 public static string Saturacion = @"saturacion";
			 public static string RellenoCapilar = @"rellenoCapilar";
			 public static string TensionArterialD = @"tensionArterialD";
			 public static string TensionArterialS = @"tensionArterialS";
			 public static string SignosVitales = @"signosVitales";
			 public static string Respiratorio = @"respiratorio";
			 public static string Abdomen = @"abdomen";
			 public static string Circulatorios = @"circulatorios";
			 public static string Urogenital = @"Urogenital";
			 public static string PerdidaConocimiento = @"perdidaConocimiento";
			 public static string IdGlasgowOcular = @"idGlasgowOcular";
			 public static string IdGlasgowVerbal = @"idGlasgowVerbal";
			 public static string IdGlasgowMotor = @"idGlasgowMotor";
			 public static string ValorGlasgow = @"valorGlasgow";
			 public static string IdPupilas = @"idPupilas";
			 public static string FocoMotor = @"focoMotor";
			 public static string Paresia = @"paresia";
			 public static string Plejia = @"plejia";
			 public static string LadoID = @"ladoID";
			 public static string Cabeza = @"cabeza";
			 public static string Axila = @"axila";
			 public static string Amputacion = @"amputacion";
			 public static string Ingimal = @"ingimal";
			 public static string Cuello = @"cuello";
			 public static string Dorso = @"dorso";
			 public static string Torax = @"torax";
			 public static string MSuperior = @"mSuperior";
			 public static string MInferior = @"mInferior";
			 public static string LesionesAbdomen = @"lesionesAbdomen";
			 public static string OtrasLesiones = @"otrasLesiones";
			 public static string TipoQuemadura = @"tipoQuemadura";
			 public static string PorcentajeQuemadura = @"porcentajeQuemadura";
			 public static string DiagnosticoPresuntivo = @"diagnosticoPresuntivo";
			 public static string IdCODCie10 = @"idCODCie10";
			 public static string Procedimiento = @"procedimiento";
			 public static string Tratamiento = @"tratamiento";
			 public static string AntecedentesPersonales = @"antecedentesPersonales";
			 public static string CategorizacionFinal = @"categorizacionFinal";
			 public static string Destino = @"destino";
			 public static string Trasladado = @"trasladado";
			 public static string IdEfector = @"idEfector";
			 public static string Sanatorio = @"sanatorio";
			 public static string TrasladadoMovil = @"trasladadoMovil";
			 public static string FirmaAfirmativa = @"firmaAfirmativa";
			 public static string FirmaNegativa = @"firmaNegativa";
			 public static string OtroGlasgow = @"otroGlasgow";
			 public static string OtrosAntecedentes = @"otrosAntecedentes";
			 public static string OtroDiagnostico = @"otroDiagnostico";
			 public static string AntecedenteDiabetes = @"antecedenteDiabetes";
			 public static string IdProfesional = @"idProfesional";
			 public static string IdProfesionalRecibe = @"idProfesionalRecibe";
			 public static string Enfermero = @"enfermero";
			 public static string Activa = @"activa";
			 public static string CreatedBy = @"CreatedBy";
			 public static string CreatedOn = @"CreatedOn";
			 public static string ModifiedBy = @"ModifiedBy";
			 public static string ModifiedOn = @"ModifiedOn";
						
		}
		#endregion
		
		#region Update PK Collections
		
        public void SetPKValues()
        {
                if (colEmrRelTraumaPrehospitalaria != null)
                {
                    foreach (DalRis.EmrRelTraumaPrehospitalarium item in colEmrRelTraumaPrehospitalaria)
                    {
                        if (item.IdHCPrehospitalaria != IdHCPrehospitalaria)
                        {
                            item.IdHCPrehospitalaria = IdHCPrehospitalaria;
                        }
                    }
               }
		
                if (colEmrRelAntecedentePacienteRecords != null)
                {
                    foreach (DalRis.EmrRelAntecedentePaciente item in colEmrRelAntecedentePacienteRecords)
                    {
                        if (item.IdHCPrehospitalaria != IdHCPrehospitalaria)
                        {
                            item.IdHCPrehospitalaria = IdHCPrehospitalaria;
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
		
                if (colEmrRelAntecedentePacienteRecords != null)
                {
                    colEmrRelAntecedentePacienteRecords.SaveAll();
               }
		}
        #endregion
	}
}
